﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

#if !NO_PERF
using System;
using System.Reactive.Disposables;

namespace System.Reactive.Linq.ObservableImpl
{
    class Using<TSource, TResource> : Producer<TSource>
        where TResource : IDisposable
    {
        private readonly Func<TResource> _resourceFactory;
        private readonly Func<TResource, IObservable<TSource>> _observableFactory;

        public Using(Func<TResource> resourceFactory, Func<TResource, IObservable<TSource>> observableFactory)
        {
            _resourceFactory = resourceFactory;
            _observableFactory = observableFactory;
        }

        protected override IDisposable Run(IObserver<TSource> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(this, observer, cancel);
            setSink(sink);
            return sink.Run();
        }

        class _ : Sink<TSource>, IObserver<TSource>
        {
            private readonly Using<TSource, TResource> _parent;

            public _(Using<TSource, TResource> parent, IObserver<TSource> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _parent = parent;
            }

            public IDisposable Run()
            {
                var source = default(IObservable<TSource>);
                var disposable = Disposable.Empty;
                try
                {
                    var resource = _parent._resourceFactory();
                    if (resource != null)
                        disposable = resource;
                    source = _parent._observableFactory(resource);
                }
                catch (Exception exception)
                {
                    return StableCompositeDisposable.Create(Observable.Throw<TSource>(exception).SubscribeSafe(this), disposable);
                }

                return StableCompositeDisposable.Create(source.SubscribeSafe(this), disposable);
            }

            public void OnNext(TSource value)
            {
                base._observer.OnNext(value);
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnCompleted();
                base.Dispose();
            }
        }
    }
}
#endif
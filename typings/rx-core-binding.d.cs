using System;
using Bridge;
using Bridge.Html5;
using Bridge.WebGL;
using any = System.Object;
using boolean = System.Boolean;
using Function = System.Delegate;
using RegExp = Bridge.Text.RegularExpressions.Regex;
using number = System.Double;
using Number = System.Double;

namespace Rx
{
	[External]
	[Name("Rx")]
	public static class GlobalClass
	{
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static SubjectStatic Subject { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static AsyncSubjectStatic AsyncSubject { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static BehaviorSubjectStatic BehaviorSubject { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static ReplaySubjectStatic ReplaySubject { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static ConnectableObservableStatic ConnectableObservable { get; set; }
#pragma warning restore CS0626
	}
	[ObjectLiteral]
	public class JSONISubject<T> : ISubject<T>
	{
	[External]
	public delegate boolean hasObserversDelegate ();

#pragma warning disable CS0626
		public extern boolean HasObservers ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern hasObserversDelegate hasObservers { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> multicastDelegate (Observable<T> subject);

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Multicast (Observable<T> subject);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern multicastDelegate multicast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> multicastDelegate<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<T> Multicast<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern multicastDelegate<TResult> multicast<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Publish ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate publish { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishDelegate<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> Publish<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate<TResult> publish<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> Share ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareDelegate share { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishLastDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> PublishLast ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishLastDelegate publishLast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishLastDelegate<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> PublishLast<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishLastDelegate<TResult> publishLast<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishValueDelegate (T initialValue);

#pragma warning disable CS0626
		public extern ConnectableObservable<T> PublishValue (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishValueDelegate publishValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishValueDelegate<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);

#pragma warning disable CS0626
		public extern Observable<TResult> PublishValue<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishValueDelegate<TResult> publishValue<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareValueDelegate (T initialValue);

#pragma warning disable CS0626
		public extern Observable<T> ShareValue (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareValueDelegate shareValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> replayDelegate (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Replay (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern replayDelegate replay { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareReplayDelegate (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> ShareReplay (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareReplayDelegate shareReplay { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ISubject<T> : Observable<T>, Observer<T>, IDisposable
	{
		boolean HasObservers ();
	}
	[External]
	public interface Subject<T> : ISubject<T>
	{
	}
	[ObjectLiteral]
	public class JSONSubjectStatic : SubjectStatic
	{
	[External]
	public delegate Subject<T> >Delegate ();

#pragma warning disable CS0626
		public extern Subject<T> > ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern >Delegate > { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ISubject<T> createDelegate<T> (Observer<T> observer = default(Observer<T>), Observable<T> observable = default(Observable<T>));

#pragma warning disable CS0626
		public extern ISubject<T> Create<T> (Observer<T> observer = default(Observer<T>), Observable<T> observable = default(Observable<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern createDelegate<T> create<T> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface SubjectStatic
	{
		Subject<T> > ();
		ISubject<T> Create<T> (Observer<T> observer = default(Observer<T>), Observable<T> observable = default(Observable<T>));
	}
	[External]
	public interface AsyncSubject<T> : Subject<T>
	{
	}
	[ObjectLiteral]
	public class JSONAsyncSubjectStatic : AsyncSubjectStatic
	{
	[External]
	public delegate AsyncSubject<T> >Delegate ();

#pragma warning disable CS0626
		public extern AsyncSubject<T> > ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern >Delegate > { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface AsyncSubjectStatic
	{
		AsyncSubject<T> > ();
	}
	[ObjectLiteral]
	public class JSONBehaviorSubject<T> : BehaviorSubject<T>
	{
	[External]
	public delegate T getValueDelegate ();

#pragma warning disable CS0626
		public extern T GetValue ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern getValueDelegate getValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> multicastDelegate (Observable<T> subject);

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Multicast (Observable<T> subject);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern multicastDelegate multicast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> multicastDelegate<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<T> Multicast<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern multicastDelegate<TResult> multicast<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Publish ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate publish { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishDelegate<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> Publish<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate<TResult> publish<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> Share ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareDelegate share { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishLastDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> PublishLast ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishLastDelegate publishLast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishLastDelegate<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> PublishLast<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishLastDelegate<TResult> publishLast<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishValueDelegate (T initialValue);

#pragma warning disable CS0626
		public extern ConnectableObservable<T> PublishValue (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishValueDelegate publishValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishValueDelegate<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);

#pragma warning disable CS0626
		public extern Observable<TResult> PublishValue<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishValueDelegate<TResult> publishValue<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareValueDelegate (T initialValue);

#pragma warning disable CS0626
		public extern Observable<T> ShareValue (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareValueDelegate shareValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> replayDelegate (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Replay (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern replayDelegate replay { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareReplayDelegate (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> ShareReplay (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareReplayDelegate shareReplay { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate boolean hasObserversDelegate ();

#pragma warning disable CS0626
		public extern boolean HasObservers ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern hasObserversDelegate hasObservers { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface BehaviorSubject<T> : Subject<T>
	{
		T GetValue ();
	}
	[ObjectLiteral]
	public class JSONBehaviorSubjectStatic : BehaviorSubjectStatic
	{
	[External]
	public delegate BehaviorSubject<T> >Delegate (T initialValue);

#pragma warning disable CS0626
		public extern BehaviorSubject<T> > (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern >Delegate > { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface BehaviorSubjectStatic
	{
		BehaviorSubject<T> > (T initialValue);
	}
	[External]
	public interface ReplaySubject<T> : Subject<T>
	{
	}
	[ObjectLiteral]
	public class JSONReplaySubjectStatic : ReplaySubjectStatic
	{
	[External]
	public delegate ReplaySubject<T> >Delegate (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ReplaySubject<T> > (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern >Delegate > { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ReplaySubjectStatic
	{
		ReplaySubject<T> > (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
	}
	[ObjectLiteral]
	public class JSONConnectableObservable<T> : ConnectableObservable<T>
	{
	[External]
	public delegate IDisposable connectDelegate ();

#pragma warning disable CS0626
		public extern IDisposable Connect ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern connectDelegate connect { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> refCountDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> RefCount ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern refCountDelegate refCount { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> multicastDelegate (Observable<T> subject);

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Multicast (Observable<T> subject);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern multicastDelegate multicast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> multicastDelegate<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<T> Multicast<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern multicastDelegate<TResult> multicast<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Publish ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate publish { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishDelegate<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> Publish<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate<TResult> publish<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> Share ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareDelegate share { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishLastDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> PublishLast ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishLastDelegate publishLast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishLastDelegate<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> PublishLast<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishLastDelegate<TResult> publishLast<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishValueDelegate (T initialValue);

#pragma warning disable CS0626
		public extern ConnectableObservable<T> PublishValue (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishValueDelegate publishValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishValueDelegate<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);

#pragma warning disable CS0626
		public extern Observable<TResult> PublishValue<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishValueDelegate<TResult> publishValue<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareValueDelegate (T initialValue);

#pragma warning disable CS0626
		public extern Observable<T> ShareValue (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareValueDelegate shareValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> replayDelegate (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Replay (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern replayDelegate replay { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareReplayDelegate (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> ShareReplay (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareReplayDelegate shareReplay { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ConnectableObservable<T> : Observable<T>
	{
		IDisposable Connect ();
		Observable<T> RefCount ();
	}
	[ObjectLiteral]
	public class JSONConnectableObservableStatic : ConnectableObservableStatic
	{
	[External]
	public delegate ConnectableObservable<T> >Delegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> > ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern >Delegate > { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ConnectableObservableStatic
	{
		ConnectableObservable<T> > ();
	}
	[External]
	public delegate ISubject<T> ObservableMulticastParam1Delegate<T, TResult> ();
	[External]
	public delegate Observable<T> ObservableMulticastParam2Delegate<T, TResult> (ConnectableObservable<T> source);
	[External]
	public delegate Observable<TResult> ObservablePublishParam1Delegate<T, TResult> (ConnectableObservable<T> source);
	[External]
	public delegate Observable<TResult> ObservablePublishLastParam1Delegate<T, TResult> (ConnectableObservable<T> source);
	[External]
	public delegate Observable<TResult> ObservablePublishValueParam1Delegate<T, TResult> (ConnectableObservable<T> source);
	[External]
	public delegate Observable<T> ObservableReplayParam1Delegate<T> (ConnectableObservable<T> source);
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate ConnectableObservable<T> multicastDelegate (Observable<T> subject);

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Multicast (Observable<T> subject);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern multicastDelegate multicast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> multicastDelegate<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<T> Multicast<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern multicastDelegate<TResult> multicast<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Publish ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate publish { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishDelegate<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> Publish<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate<TResult> publish<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> Share ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareDelegate share { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishLastDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> PublishLast ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishLastDelegate publishLast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishLastDelegate<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> PublishLast<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishLastDelegate<TResult> publishLast<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishValueDelegate (T initialValue);

#pragma warning disable CS0626
		public extern ConnectableObservable<T> PublishValue (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishValueDelegate publishValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> publishValueDelegate<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);

#pragma warning disable CS0626
		public extern Observable<TResult> PublishValue<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishValueDelegate<TResult> publishValue<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareValueDelegate (T initialValue);

#pragma warning disable CS0626
		public extern Observable<T> ShareValue (T initialValue);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareValueDelegate shareValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> replayDelegate (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Replay (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern replayDelegate replay { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> shareReplayDelegate (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> ShareReplay (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern shareReplayDelegate shareReplay { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		ConnectableObservable<T> Multicast (Observable<T> subject);
		Observable<T> Multicast<TResult> (ObservableMulticastParam1Delegate<T, TResult> subjectSelector, ObservableMulticastParam2Delegate<T, TResult> selector);
		ConnectableObservable<T> Publish ();
		Observable<TResult> Publish<TResult> (ObservablePublishParam1Delegate<T, TResult> selector);
		Observable<T> Share ();
		ConnectableObservable<T> PublishLast ();
		Observable<TResult> PublishLast<TResult> (ObservablePublishLastParam1Delegate<T, TResult> selector);
		ConnectableObservable<T> PublishValue (T initialValue);
		Observable<TResult> PublishValue<TResult> (ObservablePublishValueParam1Delegate<T, TResult> selector, T initialValue);
		Observable<T> ShareValue (T initialValue);
		ConnectableObservable<T> Replay (boolean selector = default(boolean), number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
		Observable<T> Replay (ObservableReplayParam1Delegate<T> selector, number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
		Observable<T> ShareReplay (number bufferSize = default(number), number window = default(number), IScheduler scheduler = default(IScheduler));
	}

}

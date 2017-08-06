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
	public delegate IPromise<R> IPromiseThenParam1Delegate<T, R> (T value);
	[External]
	public delegate IPromise<R> IPromiseThenParam2Delegate<T, R> (any reason);
	[External]
	public delegate IPromise<R> IPromiseThenParam1Delegate_<T, R> (T value);
	[External]
	public delegate R IPromiseThenParam2Delegate_<T, R> (any reason);
	[External]
	public delegate R IPromiseThenParam1Delegate__<T, R> (T value);
	[External]
	public delegate IPromise<R> IPromiseThenParam2Delegate__<T, R> (any reason);
	[External]
	public delegate R IPromiseThenParam1Delegate___<T, R> (T value);
	[External]
	public delegate R IPromiseThenParam2Delegate___<T, R> (any reason);
	[ObjectLiteral]
	public class JSONIPromise<T> : IPromise<T>
	{
	[External]
	public delegate IPromise<R> thenDelegate<R> (IPromiseThenParam1Delegate<T, R> onFulfilled, IPromiseThenParam2Delegate<T, R> onRejected);

#pragma warning disable CS0626
		public extern IPromise<R> Then<R> (IPromiseThenParam1Delegate<T, R> onFulfilled, IPromiseThenParam2Delegate<T, R> onRejected);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDelegate<R> then<R> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface IPromise<T>
	{
		IPromise<R> Then<R> (IPromiseThenParam1Delegate<T, R> onFulfilled, IPromiseThenParam2Delegate<T, R> onRejected);
		IPromise<R> Then<R> (IPromiseThenParam1Delegate_<T, R> onFulfilled, IPromiseThenParam2Delegate_<T, R> onRejected = default(IPromiseThenParam2Delegate_<T, R>));
		IPromise<R> Then<R> (IPromiseThenParam1Delegate__<T, R> onFulfilled, IPromiseThenParam2Delegate__<T, R> onRejected);
		IPromise<R> Then<R> (IPromiseThenParam1Delegate___<T, R> onFulfilled = default(IPromiseThenParam1Delegate___<T, R>), IPromiseThenParam2Delegate___<T, R> onRejected = default(IPromiseThenParam2Delegate___<T, R>));
	}
	[ObjectLiteral]
	public class JSONIDisposable : IDisposable
	{
	[External]
	public delegate void disposeDelegate ();

#pragma warning disable CS0626
		public extern void Dispose ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern disposeDelegate dispose { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface IDisposable
	{
		void Dispose ();
	}
	[External]
	public delegate boolean ISchedulerCatchParam1Delegate (any exception);
	[External]
	public delegate boolean ISchedulerCatchExceptionParam1Delegate (any exception);
	[ObjectLiteral]
	public class JSONIScheduler : IScheduler
	{
	[External]
	public delegate IScheduler catchDelegate (ISchedulerCatchParam1Delegate handler);

#pragma warning disable CS0626
		public extern IScheduler Catch (ISchedulerCatchParam1Delegate handler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchDelegate @catch { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IScheduler catchExceptionDelegate (ISchedulerCatchExceptionParam1Delegate handler);

#pragma warning disable CS0626
		public extern IScheduler CatchException (ISchedulerCatchExceptionParam1Delegate handler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchExceptionDelegate catchException { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface IScheduler
	{
		IScheduler Catch (ISchedulerCatchParam1Delegate handler);
		IScheduler CatchException (ISchedulerCatchExceptionParam1Delegate handler);
	}
	[ObjectLiteral]
	public class JSONObserver<T> : Observer<T>
	{
	[External]
	public delegate Observer<any> checkedDelegate ();

#pragma warning disable CS0626
		public extern Observer<any> Checked ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern checkedDelegate @checked { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observer<T>
	{
		Observer<any> Checked ();
	}
	[ObjectLiteral]
	public class JSONObserverStatic : ObserverStatic
	{
	[External]
	public delegate Observer<T> notifyOnDelegate<T> (IScheduler scheduler);

#pragma warning disable CS0626
		public extern Observer<T> NotifyOn<T> (IScheduler scheduler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern notifyOnDelegate<T> notifyOn<T> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObserverStatic
	{
		Observer<T> NotifyOn<T> (IScheduler scheduler);
	}
	[External]
	public delegate string ObservableDistinctParam2Delegate<T> (T value);
	[External]
	public delegate TKey ObservableDistinctParam1Delegate<T, TKey> (T value);
	[External]
	public delegate string ObservableDistinctParam2Delegate<T, TKey> (TKey key);
	[External]
	public delegate TKey ObservableGroupByParam1Delegate<T, TKey, TElement> (T value);
	[External]
	public delegate string ObservableGroupByParam3Delegate<T, TKey, TElement> (TKey key);
	[External]
	public delegate TKey ObservableGroupByParam1Delegate_<T, TKey, TElement> (T value);
	[External]
	public delegate TElement ObservableGroupByParam2Delegate<T, TKey, TElement> (T value);
	[External]
	public delegate string ObservableGroupByParam3Delegate_<T, TKey, TElement> (TKey key);
	[External]
	public delegate TKey ObservableGroupByUntilParam1Delegate<T, TKey, TDuration> (T value);
	[External]
	public delegate Observable<TDuration> ObservableGroupByUntilParam3Delegate<T, TKey, TDuration> (GroupedObservable<TKey, T> group);
	[External]
	public delegate string ObservableGroupByUntilParam4Delegate<T, TKey, TDuration> (TKey key);
	[External]
	public delegate TKey ObservableGroupByUntilParam1Delegate<T, TKey, TElement, TDuration> (T value);
	[External]
	public delegate TElement ObservableGroupByUntilParam2Delegate<T, TKey, TElement, TDuration> (T value);
	[External]
	public delegate Observable<TDuration> ObservableGroupByUntilParam3Delegate<T, TKey, TElement, TDuration> (GroupedObservable<TKey, TElement> group);
	[External]
	public delegate string ObservableGroupByUntilParam4Delegate<T, TKey, TElement, TDuration> (TKey key);
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate Observable<T> observeOnDelegate (IScheduler scheduler);

#pragma warning disable CS0626
		public extern Observable<T> ObserveOn (IScheduler scheduler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern observeOnDelegate observeOn { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> subscribeOnDelegate (IScheduler scheduler);

#pragma warning disable CS0626
		public extern Observable<T> SubscribeOn (IScheduler scheduler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnDelegate subscribeOn { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> ambDelegate (Any<IPromise<T>, Observable<T>> rightSource);

#pragma warning disable CS0626
		public extern Observable<T> Amb (Any<IPromise<T>, Observable<T>> rightSource);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ambDelegate amb { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> onErrorResumeNextDelegate (Any<IPromise<T>, Observable<T>> second);

#pragma warning disable CS0626
		public extern Observable<T> OnErrorResumeNext (Any<IPromise<T>, Observable<T>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern onErrorResumeNextDelegate onErrorResumeNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> bufferWithCountDelegate (number count, number skip = default(number));

#pragma warning disable CS0626
		public extern Observable<T[]> BufferWithCount (number count, number skip = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern bufferWithCountDelegate bufferWithCount { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Observable<T>> windowWithCountDelegate (number count, number skip = default(number));

#pragma warning disable CS0626
		public extern Observable<Observable<T>> WindowWithCount (number count, number skip = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern windowWithCountDelegate windowWithCount { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> defaultIfEmptyDelegate (T defaultValue = default(T));

#pragma warning disable CS0626
		public extern Observable<T> DefaultIfEmpty (T defaultValue = default(T));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern defaultIfEmptyDelegate defaultIfEmpty { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> distinctDelegate (boolean skipParameter, ObservableDistinctParam2Delegate<T> valueSerializer);

#pragma warning disable CS0626
		public extern Observable<T> Distinct (boolean skipParameter, ObservableDistinctParam2Delegate<T> valueSerializer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern distinctDelegate distinct { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> distinctDelegate<TKey> (ObservableDistinctParam1Delegate<T, TKey> keySelector = default(ObservableDistinctParam1Delegate<T, TKey>), ObservableDistinctParam2Delegate<T, TKey> keySerializer = default(ObservableDistinctParam2Delegate<T, TKey>));

#pragma warning disable CS0626
		public extern Observable<T> Distinct<TKey> (ObservableDistinctParam1Delegate<T, TKey> keySelector = default(ObservableDistinctParam1Delegate<T, TKey>), ObservableDistinctParam2Delegate<T, TKey> keySerializer = default(ObservableDistinctParam2Delegate<T, TKey>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern distinctDelegate<TKey> distinct<TKey> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<GroupedObservable<TKey, T> groupByDelegate<TKey, TElement> (ObservableGroupByParam1Delegate<T, TKey, TElement> keySelector, boolean skipElementSelector = default(boolean), ObservableGroupByParam3Delegate<T, TKey, TElement> keySerializer = default(ObservableGroupByParam3Delegate<T, TKey, TElement>));

#pragma warning disable CS0626
		public extern Observable<GroupedObservable<TKey, T> GroupBy<TKey, TElement> (ObservableGroupByParam1Delegate<T, TKey, TElement> keySelector, boolean skipElementSelector = default(boolean), ObservableGroupByParam3Delegate<T, TKey, TElement> keySerializer = default(ObservableGroupByParam3Delegate<T, TKey, TElement>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern groupByDelegate<TKey, TElement> groupBy<TKey, TElement> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<GroupedObservable<TKey, T> groupByUntilDelegate<TKey, TDuration> (ObservableGroupByUntilParam1Delegate<T, TKey, TDuration> keySelector, boolean skipElementSelector, ObservableGroupByUntilParam3Delegate<T, TKey, TDuration> durationSelector, ObservableGroupByUntilParam4Delegate<T, TKey, TDuration> keySerializer = default(ObservableGroupByUntilParam4Delegate<T, TKey, TDuration>));

#pragma warning disable CS0626
		public extern Observable<GroupedObservable<TKey, T> GroupByUntil<TKey, TDuration> (ObservableGroupByUntilParam1Delegate<T, TKey, TDuration> keySelector, boolean skipElementSelector, ObservableGroupByUntilParam3Delegate<T, TKey, TDuration> durationSelector, ObservableGroupByUntilParam4Delegate<T, TKey, TDuration> keySerializer = default(ObservableGroupByUntilParam4Delegate<T, TKey, TDuration>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern groupByUntilDelegate<TKey, TDuration> groupByUntil<TKey, TDuration> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<GroupedObservable<TKey, TElement> groupByUntilDelegate<TKey, TElement, TDuration> (ObservableGroupByUntilParam1Delegate<T, TKey, TElement, TDuration> keySelector, ObservableGroupByUntilParam2Delegate<T, TKey, TElement, TDuration> elementSelector, ObservableGroupByUntilParam3Delegate<T, TKey, TElement, TDuration> durationSelector, ObservableGroupByUntilParam4Delegate<T, TKey, TElement, TDuration> keySerializer = default(ObservableGroupByUntilParam4Delegate<T, TKey, TElement, TDuration>));

#pragma warning disable CS0626
		public extern Observable<GroupedObservable<TKey, TElement> GroupByUntil<TKey, TElement, TDuration> (ObservableGroupByUntilParam1Delegate<T, TKey, TElement, TDuration> keySelector, ObservableGroupByUntilParam2Delegate<T, TKey, TElement, TDuration> elementSelector, ObservableGroupByUntilParam3Delegate<T, TKey, TElement, TDuration> durationSelector, ObservableGroupByUntilParam4Delegate<T, TKey, TElement, TDuration> keySerializer = default(ObservableGroupByUntilParam4Delegate<T, TKey, TElement, TDuration>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern groupByUntilDelegate<TKey, TElement, TDuration> groupByUntil<TKey, TElement, TDuration> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		Observable<T> ObserveOn (IScheduler scheduler);
		Observable<T> SubscribeOn (IScheduler scheduler);
		Observable<T> Amb (Any<IPromise<T>, Observable<T>> rightSource);
		Observable<T> OnErrorResumeNext (Any<IPromise<T>, Observable<T>> second);
		Observable<T[]> BufferWithCount (number count, number skip = default(number));
		Observable<Observable<T>> WindowWithCount (number count, number skip = default(number));
		Observable<T> DefaultIfEmpty (T defaultValue = default(T));
		Observable<T> Distinct (boolean skipParameter, ObservableDistinctParam2Delegate<T> valueSerializer);
		Observable<T> Distinct<TKey> (ObservableDistinctParam1Delegate<T, TKey> keySelector = default(ObservableDistinctParam1Delegate<T, TKey>), ObservableDistinctParam2Delegate<T, TKey> keySerializer = default(ObservableDistinctParam2Delegate<T, TKey>));
		Observable<GroupedObservable<TKey, T> GroupBy<TKey, TElement> (ObservableGroupByParam1Delegate<T, TKey, TElement> keySelector, boolean skipElementSelector = default(boolean), ObservableGroupByParam3Delegate<T, TKey, TElement> keySerializer = default(ObservableGroupByParam3Delegate<T, TKey, TElement>));
		Observable<GroupedObservable<TKey, TElement> GroupBy<TKey, TElement> (ObservableGroupByParam1Delegate_<T, TKey, TElement> keySelector, ObservableGroupByParam2Delegate<T, TKey, TElement> elementSelector, ObservableGroupByParam3Delegate_<T, TKey, TElement> keySerializer = default(ObservableGroupByParam3Delegate_<T, TKey, TElement>));
		Observable<GroupedObservable<TKey, T> GroupByUntil<TKey, TDuration> (ObservableGroupByUntilParam1Delegate<T, TKey, TDuration> keySelector, boolean skipElementSelector, ObservableGroupByUntilParam3Delegate<T, TKey, TDuration> durationSelector, ObservableGroupByUntilParam4Delegate<T, TKey, TDuration> keySerializer = default(ObservableGroupByUntilParam4Delegate<T, TKey, TDuration>));
		Observable<GroupedObservable<TKey, TElement> GroupByUntil<TKey, TElement, TDuration> (ObservableGroupByUntilParam1Delegate<T, TKey, TElement, TDuration> keySelector, ObservableGroupByUntilParam2Delegate<T, TKey, TElement, TDuration> elementSelector, ObservableGroupByUntilParam3Delegate<T, TKey, TElement, TDuration> durationSelector, ObservableGroupByUntilParam4Delegate<T, TKey, TElement, TDuration> keySerializer = default(ObservableGroupByUntilParam4Delegate<T, TKey, TElement, TDuration>));
	}
	[External]
	public delegate TResource ObservableStaticUsingParam1Delegate<TSource, TResource> ();
	[External]
	public delegate Observable<TSource> ObservableStaticUsingParam2Delegate<TSource, TResource> (TResource resource);
	[ObjectLiteral]
	public class JSONObservableStatic : ObservableStatic
	{
	[External]
	public delegate Observable<TSource> usingDelegate<TSource, TResource> (ObservableStaticUsingParam1Delegate<TSource, TResource> resourceFactory, ObservableStaticUsingParam2Delegate<TSource, TResource> observableFactory);

#pragma warning disable CS0626
		public extern Observable<TSource> Using<TSource, TResource> (ObservableStaticUsingParam1Delegate<TSource, TResource> resourceFactory, ObservableStaticUsingParam2Delegate<TSource, TResource> observableFactory);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern usingDelegate<TSource, TResource> using<TSource, TResource> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> ambDelegate<T> (params IPromise<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T> Amb<T> (params IPromise<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ambDelegate<T> amb<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> onErrorResumeNextDelegate<T> (params IPromise<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T> OnErrorResumeNext<T> (params IPromise<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern onErrorResumeNextDelegate<T> onErrorResumeNext<T> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObservableStatic
	{
		Observable<TSource> Using<TSource, TResource> (ObservableStaticUsingParam1Delegate<TSource, TResource> resourceFactory, ObservableStaticUsingParam2Delegate<TSource, TResource> observableFactory) where TResource : IDisposable;
		Observable<T> Amb<T> (params IPromise<T>[] sources);
		Observable<T> Amb<T> (params Observable<T>[] sources);
		Observable<T> Amb<T> (Any<Array<IPromise<T>>, Array<Observable<T>>> sources);
		Observable<T> OnErrorResumeNext<T> (params IPromise<T>[] sources);
		Observable<T> OnErrorResumeNext<T> (params Observable<T>[] sources);
		Observable<T> OnErrorResumeNext<T> (Any<Array<IPromise<T>>, Array<Observable<T>>> sources);
	}
	[ObjectLiteral]
	public class JSONGroupedObservable<TKey, TElement> : GroupedObservable<TKey, TElement>
	{
#pragma warning disable CS0626
		public extern TKey Key { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern Observable<TElement> UnderlyingObservable { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface GroupedObservable<TKey, TElement> : Observable<TElement>
	{
		[FieldProperty]
		TKey Key { get; set; }
		[FieldProperty]
		Observable<TElement> UnderlyingObservable { get; set; }
	}

}

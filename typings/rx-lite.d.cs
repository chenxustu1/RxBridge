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

namespace Rx.internals
{
	[External]
	[Name("Rx.internals")]
	public static class GlobalClass
	{
#pragma warning disable CS0626
		public extern static boolean IsEqual (any left, any right);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static Observable<T> AddRef<T> (Observable<T> xs, GlobalClassRInterface r);
#pragma warning restore CS0626
	}
	[External]
	public class GlobalClassRInterface
	{
#pragma warning disable CS0626
		public extern IDisposable GetDisposable ();
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern GlobalClassRInterface ();
#pragma warning restore CS0824
	}
	[External]
	public class PriorityQueue<TTime>
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern number Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern static number Count { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		public extern PriorityQueue (number capacity);
#pragma warning restore CS0824
#pragma warning disable CS0626
		public extern boolean IsHigherPriority (number left, number right);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Percolate (number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Heapify (number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ScheduledItem<TTime> Peek ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void RemoveAt (number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ScheduledItem<TTime> Dequeue ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Enqueue (ScheduledItem<TTime> item);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern boolean Remove (ScheduledItem<TTime> item);
#pragma warning restore CS0626
	}
	[External]
	public delegate IDisposable ScheduledItemConstructorParam3Delegate<TTime> (IScheduler scheduler, any state);
	[External]
	public delegate number ScheduledItemConstructorParam5Delegate<TTime> (TTime x, TTime y);
	[External]
	public delegate IDisposable ScheduledItemActionDelegate<TTime> (IScheduler scheduler, any state);
	[External]
	public delegate number ScheduledItemComparerDelegate<TTime> (TTime x, TTime y);
	[External]
	public class ScheduledItem<TTime>
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern IScheduler Scheduler { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern TTime State { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern ScheduledItemActionDelegate<TTime> Action { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern TTime DueTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern ScheduledItemComparerDelegate<TTime> Comparer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern SingleAssignmentDisposable Disposable { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		public extern ScheduledItem (IScheduler scheduler, any state, ScheduledItemConstructorParam3Delegate<TTime> action, TTime dueTime, ScheduledItemConstructorParam5Delegate<TTime> comparer = default(ScheduledItemConstructorParam5Delegate<TTime>));
#pragma warning restore CS0824
#pragma warning disable CS0626
		public extern void Invoke ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern number CompareTo (ScheduledItem<TTime> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern boolean IsCancelled ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern IDisposable InvokeCore ();
#pragma warning restore CS0626
	}

}
namespace Rx.config
{
	[External]
	[Name("Rx.config")]
	public static class GlobalClass
	{
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static GlobalClassPromiseInterface Promise { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public class GlobalClassPromiseInterface
	{
#pragma warning disable CS0626
		public extern object > (GlobalClass>Param1Delegate resolver, GlobalClass>Param2Delegate rejectPromise);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern GlobalClassPromiseInterface ();
#pragma warning restore CS0824
	}

}
	[External]
	public static class Rx.helpers
	{
#pragma warning disable CS0626
		public extern static void Noop ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static boolean NotDefined (any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static T Identity<T> (T value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static number DefaultNow ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static boolean DefaultComparer (any left, any right);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static number DefaultSubComparer (any left, any right);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static string DefaultKeySerializer (any key);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static void DefaultError (any err);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static boolean IsPromise (any p);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static T[] AsArray<T> (params T[] args);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static boolean Not (any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static boolean IsFunction (any value);
#pragma warning restore CS0626
	}
namespace Rx
{
	[External]
	[Name("Rx")]
	public static class GlobalClass
	{
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static SchedulerStatic Scheduler { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static ObserverStatic Observer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static ObservableStatic Observable { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public class CompositeDisposable : IDisposable
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern boolean IsDisposed { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern number Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		public extern CompositeDisposable (params IDisposable[] disposables);
#pragma warning restore CS0824
#pragma warning disable CS0824
		public extern CompositeDisposable (IDisposable[] disposables);
#pragma warning restore CS0824
#pragma warning disable CS0626
		public extern void Dispose ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Add (IDisposable item);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern boolean Remove (IDisposable item);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern IDisposable[] ToArray ();
#pragma warning restore CS0626
	}
	[External]
	public delegate void DisposableConstructorParam1Delegate ();
	[External]
	public delegate void DisposableCreateParam1Delegate ();
	[External]
	public class Disposable : IDisposable
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern static IDisposable Empty { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		public extern Disposable (DisposableConstructorParam1Delegate action);
#pragma warning restore CS0824
#pragma warning disable CS0626
		public extern static IDisposable Create (DisposableCreateParam1Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Dispose ();
#pragma warning restore CS0626
	}
	[External]
	public class SingleAssignmentDisposable : IDisposable
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern boolean IsDisposed { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern IDisposable Current { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		public extern SingleAssignmentDisposable ();
#pragma warning restore CS0824
#pragma warning disable CS0626
		public extern void Dispose ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern IDisposable GetDisposable ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetDisposable (IDisposable value);
#pragma warning restore CS0626
	}
	[External]
	public class SerialDisposable : SingleAssignmentDisposable
	{
#pragma warning disable CS0824
		public extern SerialDisposable ();
#pragma warning restore CS0824
	}
	[External]
	public class RefCountDisposable : IDisposable
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern boolean IsDisposed { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		public extern RefCountDisposable (IDisposable disposable);
#pragma warning restore CS0824
#pragma warning disable CS0626
		public extern void Dispose ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern IDisposable GetDisposable ();
#pragma warning restore CS0626
	}
	[External]
	public delegate void ISchedulerScheduleParam1Delegate ();
	[External]
	public delegate IDisposable ISchedulerScheduleWithStateParam2Delegate<TState> (IScheduler scheduler, TState state);
	[External]
	public delegate void ISchedulerScheduleWithAbsoluteParam2Delegate ();
	[External]
	public delegate IDisposable ISchedulerScheduleWithAbsoluteAndStateParam3Delegate<TState> (IScheduler scheduler, TState state);
	[External]
	public delegate void ISchedulerScheduleWithRelativeParam2Delegate ();
	[External]
	public delegate IDisposable ISchedulerScheduleWithRelativeAndStateParam3Delegate<TState> (IScheduler scheduler, TState state);
	[External]
	public delegate void ISchedulerScheduleRecursiveParam1Delegate ( action,  , oid >);
	[External]
	public delegate void ISchedulerScheduleRecursiveWithStateParam2Delegate<TState> (TState state,  action, TState state);
	[External]
	public delegate void ISchedulerScheduleRecursiveWithAbsoluteParam2Delegate ( action, number dueTime);
	[External]
	public delegate void ISchedulerScheduleRecursiveWithAbsoluteAndStateParam3Delegate<TState> (TState state,  action, TState state, number dueTime);
	[External]
	public delegate void ISchedulerScheduleRecursiveWithRelativeParam2Delegate ( action, number dueTime);
	[External]
	public delegate void ISchedulerScheduleRecursiveWithRelativeAndStateParam3Delegate<TState> (TState state,  action, TState state, number dueTime);
	[External]
	public delegate void ISchedulerSchedulePeriodicParam2Delegate ();
	[External]
	public delegate TState ISchedulerSchedulePeriodicWithStateParam3Delegate<TState> (TState state);
	[ObjectLiteral]
	public class JSONIScheduler : IScheduler
	{
	[External]
	public delegate number nowDelegate ();

#pragma warning disable CS0626
		public extern number Now ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern nowDelegate now { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate boolean isSchedulerDelegate (any value);

#pragma warning disable CS0626
		public extern boolean IsScheduler (any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern isSchedulerDelegate isScheduler { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleDelegate (ISchedulerScheduleParam1Delegate action);

#pragma warning disable CS0626
		public extern IDisposable Schedule (ISchedulerScheduleParam1Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleDelegate schedule { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithStateDelegate<TState> (TState state, ISchedulerScheduleWithStateParam2Delegate<TState> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithState<TState> (TState state, ISchedulerScheduleWithStateParam2Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithStateDelegate<TState> scheduleWithState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithAbsoluteDelegate (number dueTime, ISchedulerScheduleWithAbsoluteParam2Delegate action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithAbsolute (number dueTime, ISchedulerScheduleWithAbsoluteParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithAbsoluteDelegate scheduleWithAbsolute { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithAbsoluteAndStateDelegate<TState> (TState state, number dueTime, ISchedulerScheduleWithAbsoluteAndStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithAbsoluteAndState<TState> (TState state, number dueTime, ISchedulerScheduleWithAbsoluteAndStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithAbsoluteAndStateDelegate<TState> scheduleWithAbsoluteAndState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithRelativeDelegate (number dueTime, ISchedulerScheduleWithRelativeParam2Delegate action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithRelative (number dueTime, ISchedulerScheduleWithRelativeParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithRelativeDelegate scheduleWithRelative { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithRelativeAndStateDelegate<TState> (TState state, number dueTime, ISchedulerScheduleWithRelativeAndStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithRelativeAndState<TState> (TState state, number dueTime, ISchedulerScheduleWithRelativeAndStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithRelativeAndStateDelegate<TState> scheduleWithRelativeAndState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleRecursiveDelegate (ISchedulerScheduleRecursiveParam1Delegate action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleRecursive (ISchedulerScheduleRecursiveParam1Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveDelegate scheduleRecursive { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithStateDelegate<TState> (TState state, ISchedulerScheduleRecursiveWithStateParam2Delegate<TState> action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithState<TState> (TState state, ISchedulerScheduleRecursiveWithStateParam2Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithStateDelegate<TState> scheduleRecursiveWithState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithAbsoluteDelegate (number dueTime, ISchedulerScheduleRecursiveWithAbsoluteParam2Delegate action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithAbsolute (number dueTime, ISchedulerScheduleRecursiveWithAbsoluteParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithAbsoluteDelegate scheduleRecursiveWithAbsolute { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithAbsoluteAndStateDelegate<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithAbsoluteAndStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithAbsoluteAndState<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithAbsoluteAndStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithAbsoluteAndStateDelegate<TState> scheduleRecursiveWithAbsoluteAndState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithRelativeDelegate (number dueTime, ISchedulerScheduleRecursiveWithRelativeParam2Delegate action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithRelative (number dueTime, ISchedulerScheduleRecursiveWithRelativeParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithRelativeDelegate scheduleRecursiveWithRelative { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithRelativeAndStateDelegate<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithRelativeAndStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithRelativeAndState<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithRelativeAndStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithRelativeAndStateDelegate<TState> scheduleRecursiveWithRelativeAndState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable schedulePeriodicDelegate (number period, ISchedulerSchedulePeriodicParam2Delegate action);

#pragma warning disable CS0626
		public extern IDisposable SchedulePeriodic (number period, ISchedulerSchedulePeriodicParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern schedulePeriodicDelegate schedulePeriodic { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable schedulePeriodicWithStateDelegate<TState> (TState state, number period, ISchedulerSchedulePeriodicWithStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern IDisposable SchedulePeriodicWithState<TState> (TState state, number period, ISchedulerSchedulePeriodicWithStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern schedulePeriodicWithStateDelegate<TState> schedulePeriodicWithState<TState> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface IScheduler
	{
		number Now ();
		boolean IsScheduler (any value);
		IDisposable Schedule (ISchedulerScheduleParam1Delegate action);
		IDisposable ScheduleWithState<TState> (TState state, ISchedulerScheduleWithStateParam2Delegate<TState> action);
		IDisposable ScheduleWithAbsolute (number dueTime, ISchedulerScheduleWithAbsoluteParam2Delegate action);
		IDisposable ScheduleWithAbsoluteAndState<TState> (TState state, number dueTime, ISchedulerScheduleWithAbsoluteAndStateParam3Delegate<TState> action);
		IDisposable ScheduleWithRelative (number dueTime, ISchedulerScheduleWithRelativeParam2Delegate action);
		IDisposable ScheduleWithRelativeAndState<TState> (TState state, number dueTime, ISchedulerScheduleWithRelativeAndStateParam3Delegate<TState> action);
		IDisposable ScheduleRecursive (ISchedulerScheduleRecursiveParam1Delegate action);
		object ScheduleRecursiveWithState<TState> (TState state, ISchedulerScheduleRecursiveWithStateParam2Delegate<TState> action);
		object ScheduleRecursiveWithAbsolute (number dueTime, ISchedulerScheduleRecursiveWithAbsoluteParam2Delegate action);
		object ScheduleRecursiveWithAbsoluteAndState<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithAbsoluteAndStateParam3Delegate<TState> action);
		object ScheduleRecursiveWithRelative (number dueTime, ISchedulerScheduleRecursiveWithRelativeParam2Delegate action);
		object ScheduleRecursiveWithRelativeAndState<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithRelativeAndStateParam3Delegate<TState> action);
		IDisposable SchedulePeriodic (number period, ISchedulerSchedulePeriodicParam2Delegate action);
		IDisposable SchedulePeriodicWithState<TState> (TState state, number period, ISchedulerSchedulePeriodicWithStateParam3Delegate<TState> action);
	}
	[External]
	public interface Scheduler : IScheduler
	{
	}
	[External]
	public delegate number SchedulerStaticNewParam1Delegate ();
	[External]
	public delegate IDisposable SchedulerStaticNewParam2Delegate (any state,  action, IScheduler scheduler, any state);
	[External]
	public delegate IDisposable SchedulerStaticScheduleRelativeDelegate (any state, number dueTime,  action, IScheduler scheduler, any state);
	[External]
	public delegate IDisposable SchedulerStaticScheduleAbsoluteDelegate (any state, number dueTime,  action, IScheduler scheduler, any state);
	[ObjectLiteral]
	public class JSONSchedulerStatic : SchedulerStatic
	{
#pragma warning disable CS0626
		public extern SchedulerStaticScheduleRelativeDelegate ScheduleRelative { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern SchedulerStaticScheduleAbsoluteDelegate ScheduleAbsolute { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern IScheduler Immediate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ICurrentThreadScheduler CurrentThread { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern IScheduler Default { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern IScheduler Timeout { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object newDelegate (SchedulerStaticNewParam1Delegate now, SchedulerStaticNewParam2Delegate schedule);

#pragma warning disable CS0626
		public extern object New (SchedulerStaticNewParam1Delegate now, SchedulerStaticNewParam2Delegate schedule);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern newDelegate @new { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate number normalizeDelegate (number timeSpan);

#pragma warning disable CS0626
		public extern number Normalize (number timeSpan);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern normalizeDelegate normalize { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface SchedulerStatic
	{
		[FieldProperty]
		SchedulerStaticScheduleRelativeDelegate ScheduleRelative { get; set; }
		[FieldProperty]
		SchedulerStaticScheduleAbsoluteDelegate ScheduleAbsolute { get; set; }
		[FieldProperty]
		IScheduler Immediate { get; set; }
		[FieldProperty]
		ICurrentThreadScheduler CurrentThread { get; set; }
		[FieldProperty]
		IScheduler Default { get; set; }
		[FieldProperty]
		IScheduler Timeout { get; set; }
		object New (SchedulerStaticNewParam1Delegate now, SchedulerStaticNewParam2Delegate schedule);
		number Normalize (number timeSpan);
	}
	[ObjectLiteral]
	public class JSONICurrentThreadScheduler : ICurrentThreadScheduler
	{
	[External]
	public delegate boolean scheduleRequiredDelegate ();

#pragma warning disable CS0626
		public extern boolean ScheduleRequired ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRequiredDelegate scheduleRequired { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate number nowDelegate ();

#pragma warning disable CS0626
		public extern number Now ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern nowDelegate now { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate boolean isSchedulerDelegate (any value);

#pragma warning disable CS0626
		public extern boolean IsScheduler (any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern isSchedulerDelegate isScheduler { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleDelegate (ISchedulerScheduleParam1Delegate action);

#pragma warning disable CS0626
		public extern IDisposable Schedule (ISchedulerScheduleParam1Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleDelegate schedule { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithStateDelegate<TState> (TState state, ISchedulerScheduleWithStateParam2Delegate<TState> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithState<TState> (TState state, ISchedulerScheduleWithStateParam2Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithStateDelegate<TState> scheduleWithState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithAbsoluteDelegate (number dueTime, ISchedulerScheduleWithAbsoluteParam2Delegate action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithAbsolute (number dueTime, ISchedulerScheduleWithAbsoluteParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithAbsoluteDelegate scheduleWithAbsolute { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithAbsoluteAndStateDelegate<TState> (TState state, number dueTime, ISchedulerScheduleWithAbsoluteAndStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithAbsoluteAndState<TState> (TState state, number dueTime, ISchedulerScheduleWithAbsoluteAndStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithAbsoluteAndStateDelegate<TState> scheduleWithAbsoluteAndState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithRelativeDelegate (number dueTime, ISchedulerScheduleWithRelativeParam2Delegate action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithRelative (number dueTime, ISchedulerScheduleWithRelativeParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithRelativeDelegate scheduleWithRelative { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleWithRelativeAndStateDelegate<TState> (TState state, number dueTime, ISchedulerScheduleWithRelativeAndStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleWithRelativeAndState<TState> (TState state, number dueTime, ISchedulerScheduleWithRelativeAndStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleWithRelativeAndStateDelegate<TState> scheduleWithRelativeAndState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleRecursiveDelegate (ISchedulerScheduleRecursiveParam1Delegate action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleRecursive (ISchedulerScheduleRecursiveParam1Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveDelegate scheduleRecursive { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithStateDelegate<TState> (TState state, ISchedulerScheduleRecursiveWithStateParam2Delegate<TState> action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithState<TState> (TState state, ISchedulerScheduleRecursiveWithStateParam2Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithStateDelegate<TState> scheduleRecursiveWithState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithAbsoluteDelegate (number dueTime, ISchedulerScheduleRecursiveWithAbsoluteParam2Delegate action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithAbsolute (number dueTime, ISchedulerScheduleRecursiveWithAbsoluteParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithAbsoluteDelegate scheduleRecursiveWithAbsolute { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithAbsoluteAndStateDelegate<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithAbsoluteAndStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithAbsoluteAndState<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithAbsoluteAndStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithAbsoluteAndStateDelegate<TState> scheduleRecursiveWithAbsoluteAndState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithRelativeDelegate (number dueTime, ISchedulerScheduleRecursiveWithRelativeParam2Delegate action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithRelative (number dueTime, ISchedulerScheduleRecursiveWithRelativeParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithRelativeDelegate scheduleRecursiveWithRelative { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object scheduleRecursiveWithRelativeAndStateDelegate<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithRelativeAndStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern object ScheduleRecursiveWithRelativeAndState<TState> (TState state, number dueTime, ISchedulerScheduleRecursiveWithRelativeAndStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRecursiveWithRelativeAndStateDelegate<TState> scheduleRecursiveWithRelativeAndState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable schedulePeriodicDelegate (number period, ISchedulerSchedulePeriodicParam2Delegate action);

#pragma warning disable CS0626
		public extern IDisposable SchedulePeriodic (number period, ISchedulerSchedulePeriodicParam2Delegate action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern schedulePeriodicDelegate schedulePeriodic { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable schedulePeriodicWithStateDelegate<TState> (TState state, number period, ISchedulerSchedulePeriodicWithStateParam3Delegate<TState> action);

#pragma warning disable CS0626
		public extern IDisposable SchedulePeriodicWithState<TState> (TState state, number period, ISchedulerSchedulePeriodicWithStateParam3Delegate<TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern schedulePeriodicWithStateDelegate<TState> schedulePeriodicWithState<TState> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ICurrentThreadScheduler : IScheduler
	{
		boolean ScheduleRequired ();
	}
	[External]
	public delegate TResult NotificationAcceptParam1Delegate<T, TResult> (T value);
	[External]
	public delegate TResult NotificationAcceptParam2Delegate<T, TResult> (any exception);
	[External]
	public delegate TResult NotificationAcceptParam3Delegate<T, TResult> ();
	[External]
	public class Notification<T>
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern boolean HasValue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Kind { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern T Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Exception { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Accept (IObserver<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern TResult Accept<TResult> (NotificationAcceptParam1Delegate<T, TResult> onNext, NotificationAcceptParam2Delegate<T, TResult> onError = default(NotificationAcceptParam2Delegate<T, TResult>), NotificationAcceptParam3Delegate<T, TResult> onCompleted = default(NotificationAcceptParam3Delegate<T, TResult>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern Observable<T> ToObservable (IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern boolean Equals (Notification<T> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static Notification<T> CreateOnNext<T> (T value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static Notification<T> CreateOnError<T> (any exception);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern static Notification<T> CreateOnCompleted<T> ();
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern Notification ();
#pragma warning restore CS0824
	}
	[ObjectLiteral]
	public class JSONIObserver<T> : IObserver<T>
	{
	[External]
	public delegate void onNextDelegate (T value);

#pragma warning disable CS0626
		public extern void OnNext (T value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern onNextDelegate onNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void onErrorDelegate (any exception);

#pragma warning disable CS0626
		public extern void OnError (any exception);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern onErrorDelegate onError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void onCompletedDelegate ();

#pragma warning disable CS0626
		public extern void OnCompleted ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern onCompletedDelegate onCompleted { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface IObserver<T>
	{
		void OnNext (T value);
		void OnError (any exception);
		void OnCompleted ();
	}
	[External]
	public delegate void ObserverToNotifierDelegate<T> (Notification<T> notification);
	[ObjectLiteral]
	public class JSONObserver<T> : Observer<T>
	{
	[External]
	public delegate ObserverToNotifierDelegate<T> toNotifierDelegate ();

#pragma warning disable CS0626
		public extern ObserverToNotifierDelegate<T> ToNotifier ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toNotifierDelegate toNotifier { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observer<T> asObserverDelegate ();

#pragma warning disable CS0626
		public extern Observer<T> AsObserver ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern asObserverDelegate asObserver { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void onNextDelegate (T value);

#pragma warning disable CS0626
		public extern void OnNext (T value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern onNextDelegate onNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void onErrorDelegate (any exception);

#pragma warning disable CS0626
		public extern void OnError (any exception);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern onErrorDelegate onError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void onCompletedDelegate ();

#pragma warning disable CS0626
		public extern void OnCompleted ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern onCompletedDelegate onCompleted { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observer<T> : IObserver<T>
	{
		ObserverToNotifierDelegate<T> ToNotifier ();
		Observer<T> AsObserver ();
	}
	[External]
	public delegate void ObserverStaticCreateParam1Delegate<T> (T value);
	[External]
	public delegate void ObserverStaticCreateParam2Delegate<T> (any exception);
	[External]
	public delegate void ObserverStaticCreateParam3Delegate<T> ();
	[External]
	public delegate void ObserverStaticFromNotifierParam1Delegate<T> (Notification<T> notification, any thisArg = default(any));
	[ObjectLiteral]
	public class JSONObserverStatic : ObserverStatic
	{
	[External]
	public delegate Observer<T> createDelegate<T> (ObserverStaticCreateParam1Delegate<T> onNext = default(ObserverStaticCreateParam1Delegate<T>), ObserverStaticCreateParam2Delegate<T> onError = default(ObserverStaticCreateParam2Delegate<T>), ObserverStaticCreateParam3Delegate<T> onCompleted = default(ObserverStaticCreateParam3Delegate<T>));

#pragma warning disable CS0626
		public extern Observer<T> Create<T> (ObserverStaticCreateParam1Delegate<T> onNext = default(ObserverStaticCreateParam1Delegate<T>), ObserverStaticCreateParam2Delegate<T> onError = default(ObserverStaticCreateParam2Delegate<T>), ObserverStaticCreateParam3Delegate<T> onCompleted = default(ObserverStaticCreateParam3Delegate<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern createDelegate<T> create<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observer<T> fromNotifierDelegate<T> (ObserverStaticFromNotifierParam1Delegate<T> handler);

#pragma warning disable CS0626
		public extern Observer<T> FromNotifier<T> (ObserverStaticFromNotifierParam1Delegate<T> handler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern fromNotifierDelegate<T> fromNotifier<T> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObserverStatic
	{
		Observer<T> Create<T> (ObserverStaticCreateParam1Delegate<T> onNext = default(ObserverStaticCreateParam1Delegate<T>), ObserverStaticCreateParam2Delegate<T> onError = default(ObserverStaticCreateParam2Delegate<T>), ObserverStaticCreateParam3Delegate<T> onCompleted = default(ObserverStaticCreateParam3Delegate<T>));
		Observer<T> FromNotifier<T> (ObserverStaticFromNotifierParam1Delegate<T> handler);
	}
	[External]
	public delegate void IObservableSubscribeParam1Delegate<T> (T value);
	[External]
	public delegate void IObservableSubscribeParam2Delegate<T> (any exception);
	[External]
	public delegate void IObservableSubscribeParam3Delegate<T> ();
	[External]
	public delegate void IObservableSubscribeOnNextParam1Delegate<T> (T value);
	[External]
	public delegate void IObservableSubscribeOnErrorParam1Delegate<T> (any exception);
	[External]
	public delegate void IObservableSubscribeOnCompletedParam1Delegate<T> ();
	[ObjectLiteral]
	public class JSONIObservable<T> : IObservable<T>
	{
	[External]
	public delegate IDisposable subscribeDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern IDisposable Subscribe (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeDelegate subscribe { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnNextDelegate (IObservableSubscribeOnNextParam1Delegate<T> onNext, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnNext (IObservableSubscribeOnNextParam1Delegate<T> onNext, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnNextDelegate subscribeOnNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnErrorDelegate (IObservableSubscribeOnErrorParam1Delegate<T> onError, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnError (IObservableSubscribeOnErrorParam1Delegate<T> onError, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnErrorDelegate subscribeOnError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnCompletedDelegate (IObservableSubscribeOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnCompleted (IObservableSubscribeOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnCompletedDelegate subscribeOnCompleted { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface IObservable<T>
	{
		IDisposable Subscribe (Observer<T> observer);
		IDisposable Subscribe (IObservableSubscribeParam1Delegate<T> onNext = default(IObservableSubscribeParam1Delegate<T>), IObservableSubscribeParam2Delegate<T> onError = default(IObservableSubscribeParam2Delegate<T>), IObservableSubscribeParam3Delegate<T> onCompleted = default(IObservableSubscribeParam3Delegate<T>));
		IDisposable SubscribeOnNext (IObservableSubscribeOnNextParam1Delegate<T> onNext, any thisArg = default(any));
		IDisposable SubscribeOnError (IObservableSubscribeOnErrorParam1Delegate<T> onError, any thisArg = default(any));
		IDisposable SubscribeOnCompleted (IObservableSubscribeOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
	}
	[External]
	public delegate void ObservableForEachParam1Delegate<T> (T value);
	[External]
	public delegate void ObservableForEachParam2Delegate<T> (any exception);
	[External]
	public delegate void ObservableForEachParam3Delegate<T> ();
	[External]
	public delegate IPromise<T> ObservableCatchParam1Delegate<T> (Error exception);
	[External]
	public delegate IPromise<T> ObservableCatchExceptionParam1Delegate<T> (Error exception);
	[External]
	public delegate TResult ObservableCombineLatestParam2Delegate<T, T2, TResult> (T v1, T2 v2);
	[External]
	public delegate TResult ObservableCombineLatestParam3Delegate<T, T2, T3, TResult> (T v1, T2 v2, T3 v3);
	[External]
	public delegate TResult ObservableCombineLatestParam4Delegate<T, T2, T3, T4, TResult> (T v1, T2 v2, T3 v3, T4 v4);
	[External]
	public delegate TResult ObservableCombineLatestParam5Delegate<T, T2, T3, T4, T5, TResult> (T v1, T2 v2, T3 v3, T4 v4, T5 v5);
	[External]
	public delegate object ObservableCombineLatestParam1Delegate<T, TOther, TResult> (IPromise<TOther> Observable<TOther>);
	[External]
	public delegate TResult ObservableCombineLatestParam2Delegate<T, TOther, TResult> (T firstValue, params TOther[] otherValues);
	[External]
	public delegate TResult ObservableWithLatestFromParam2Delegate<T, T2, TResult> (T v1, T2 v2);
	[External]
	public delegate TResult ObservableWithLatestFromParam3Delegate<T, T2, T3, TResult> (T v1, T2 v2, T3 v3);
	[External]
	public delegate TResult ObservableWithLatestFromParam4Delegate<T, T2, T3, T4, TResult> (T v1, T2 v2, T3 v3, T4 v4);
	[External]
	public delegate TResult ObservableWithLatestFromParam5Delegate<T, T2, T3, T4, T5, TResult> (T v1, T2 v2, T3 v3, T4 v4, T5 v5);
	[External]
	public delegate object ObservableWithLatestFromParam1Delegate<T, TOther, TResult> (IPromise<TOther> Observable<TOther>);
	[External]
	public delegate TResult ObservableWithLatestFromParam2Delegate<T, TOther, TResult> (T firstValue, params TOther[] otherValues);
	[External]
	public delegate object ObservableConcatParam1Delegate<T> (IPromise<T> Observable<T>);
	[External]
	public delegate object ObservableConcatParam1Delegate_<T> (IPromise<T> Observable<T>);
	[External]
	public delegate Observable<T2> ObservableConcatMapParam1Delegate<T, T2, R> (T value, number index);
	[External]
	public delegate R ObservableConcatMapParam2Delegate<T, T2, R> (T value1, T2 value2, number index);
	[External]
	public delegate IPromise<T2> ObservableConcatMapParam1Delegate_<T, T2, R> (T value, number index);
	[External]
	public delegate R ObservableConcatMapParam2Delegate_<T, T2, R> (T value1, T2 value2, number index);
	[External]
	public delegate Observable<R> ObservableConcatMapParam1Delegate<T, R> (T value, number index);
	[External]
	public delegate IPromise<R> ObservableConcatMapParam1Delegate_<T, R> (T value, number index);
	[External]
	public delegate R[] ObservableConcatMapParam1Delegate__<T, R> (T value, number index);
	[External]
	public delegate TResult ObservableZipParam2Delegate<T, T2, TResult> (T v1, T2 v2);
	[External]
	public delegate TResult ObservableZipParam3Delegate<T, T2, T3, TResult> (T v1, T2 v2, T3 v3);
	[External]
	public delegate TResult ObservableZipParam4Delegate<T, T2, T3, T4, TResult> (T v1, T2 v2, T3 v3, T4 v4);
	[External]
	public delegate TResult ObservableZipParam5Delegate<T, T2, T3, T4, T5, TResult> (T v1, T2 v2, T3 v3, T4 v4, T5 v5);
	[External]
	public delegate object ObservableZipParam1Delegate<T, TOther, TResult> (IPromise<TOther> Observable<TOther>);
	[External]
	public delegate TResult ObservableZipParam2Delegate<T, TOther, TResult> (T left, params TOther[] right);
	[External]
	public delegate boolean ObservableDistinctUntilChangedParam2Delegate<T> (T x, T y);
	[External]
	public delegate TValue ObservableDistinctUntilChangedParam1Delegate<T, TValue> (T value);
	[External]
	public delegate boolean ObservableDistinctUntilChangedParam2Delegate<T, TValue> (TValue x, TValue y);
	[External]
	public delegate void ObservableDoParam1Delegate<T> (T value);
	[External]
	public delegate void ObservableDoParam2Delegate<T> (Error exception);
	[External]
	public delegate void ObservableDoParam3Delegate<T> ();
	[External]
	public delegate void ObservableDoActionParam1Delegate<T> (T value);
	[External]
	public delegate void ObservableDoActionParam2Delegate<T> (Error exception);
	[External]
	public delegate void ObservableDoActionParam3Delegate<T> ();
	[External]
	public delegate void ObservableTapParam1Delegate<T> (T value);
	[External]
	public delegate void ObservableTapParam2Delegate<T> (Error exception);
	[External]
	public delegate void ObservableTapParam3Delegate<T> ();
	[External]
	public delegate void ObservableDoOnNextParam1Delegate<T> (T value);
	[External]
	public delegate void ObservableDoOnErrorParam1Delegate<T> (any exception);
	[External]
	public delegate void ObservableDoOnCompletedParam1Delegate<T> ();
	[External]
	public delegate void ObservableTapOnNextParam1Delegate<T> (T value);
	[External]
	public delegate void ObservableTapOnErrorParam1Delegate<T> (any exception);
	[External]
	public delegate void ObservableTapOnCompletedParam1Delegate<T> ();
	[External]
	public delegate void ObservableFinallyParam1Delegate<T> ();
	[External]
	public delegate void ObservableFinallyActionParam1Delegate<T> ();
	[External]
	public delegate Observable<any> ObservableRetryWhenParam1Delegate<T, TError> (Observable<TError> errors);
	[External]
	public delegate TAcc ObservableScanParam1Delegate<T, TAcc> (TAcc acc, T value, number index = default(number), Observable<TAcc> source = default(Observable<TAcc>));
	[External]
	public delegate T ObservableScanParam1Delegate<T> (T acc, T value, number index = default(number), Observable<T> source = default(Observable<T>));
	[External]
	public delegate TResult ObservableSelectParam1Delegate<T, TResult> (T value, number index, Observable<T> source);
	[External]
	public delegate TResult ObservableMapParam1Delegate<T, TResult> (T value, number index, Observable<T> source);
	[External]
	public delegate Observable<TOther> ObservableSelectManyParam1Delegate<T, TOther, TResult> (T value);
	[External]
	public delegate TResult ObservableSelectManyParam2Delegate<T, TOther, TResult> (T item, TOther other);
	[External]
	public delegate IPromise<TOther> ObservableSelectManyParam1Delegate_<T, TOther, TResult> (T value);
	[External]
	public delegate TResult ObservableSelectManyParam2Delegate_<T, TOther, TResult> (T item, TOther other);
	[External]
	public delegate Observable<TResult> ObservableSelectManyParam1Delegate<T, TResult> (T value);
	[External]
	public delegate IPromise<TResult> ObservableSelectManyParam1Delegate_<T, TResult> (T value);
	[External]
	public delegate TResult[] ObservableSelectManyParam1Delegate__<T, TResult> (T value);
	[External]
	public delegate Observable<TOther> ObservableFlatMapParam1Delegate<T, TOther, TResult> (T value);
	[External]
	public delegate TResult ObservableFlatMapParam2Delegate<T, TOther, TResult> (T item, TOther other);
	[External]
	public delegate IPromise<TOther> ObservableFlatMapParam1Delegate_<T, TOther, TResult> (T value);
	[External]
	public delegate TResult ObservableFlatMapParam2Delegate_<T, TOther, TResult> (T item, TOther other);
	[External]
	public delegate Observable<TResult> ObservableFlatMapParam1Delegate<T, TResult> (T value);
	[External]
	public delegate IPromise<TResult> ObservableFlatMapParam1Delegate_<T, TResult> (T value);
	[External]
	public delegate TResult[] ObservableFlatMapParam1Delegate__<T, TResult> (T value);
	[External]
	public delegate Observable<T2> ObservableSelectManyObserverParam1Delegate<T, T2, T3, T4> (T value, number index);
	[External]
	public delegate Observable<T3> ObservableSelectManyObserverParam2Delegate<T, T2, T3, T4> (any exception);
	[External]
	public delegate Observable<T4> ObservableSelectManyObserverParam3Delegate<T, T2, T3, T4> ();
	[External]
	public delegate Observable<T2> ObservableFlatMapObserverParam1Delegate<T, T2, T3, T4> (T value, number index);
	[External]
	public delegate Observable<T3> ObservableFlatMapObserverParam2Delegate<T, T2, T3, T4> (any exception);
	[External]
	public delegate Observable<T4> ObservableFlatMapObserverParam3Delegate<T, T2, T3, T4> ();
	[External]
	public delegate Observable<T2> ObservableSelectConcatParam1Delegate<T, T2, R> (T value, number index);
	[External]
	public delegate R ObservableSelectConcatParam2Delegate<T, T2, R> (T value1, T2 value2, number index);
	[External]
	public delegate IPromise<T2> ObservableSelectConcatParam1Delegate_<T, T2, R> (T value, number index);
	[External]
	public delegate R ObservableSelectConcatParam2Delegate_<T, T2, R> (T value1, T2 value2, number index);
	[External]
	public delegate Observable<R> ObservableSelectConcatParam1Delegate<T, R> (T value, number index);
	[External]
	public delegate IPromise<R> ObservableSelectConcatParam1Delegate_<T, R> (T value, number index);
	[External]
	public delegate Observable<TResult> ObservableSelectSwitchParam1Delegate<T, TResult> (T value, number index, Observable<T> source);
	[External]
	public delegate Observable<TResult> ObservableFlatMapLatestParam1Delegate<T, TResult> (T value, number index, Observable<T> source);
	[External]
	public delegate TResult ObservableSwitchMapParam1Delegate<T, TResult> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableSkipWhileParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableTakeWhileParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableWhereParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableFilterParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public class ObservablePromiseCtorInterface<T>
	{
#pragma warning disable CS0626
		public extern object New (GlobalClassNewParam1Delegate resolver, GlobalClassNewParam2Delegate rejectPromise);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ObservablePromiseCtorInterface ();
#pragma warning restore CS0824
	}
	[External]
	public delegate R ObservableExclusiveMapParam1Delegate<T, I, R> (I value, number index, Observable<I> source);
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
#pragma warning disable CS0626
		public extern ObservablePromiseCtorInterface<T> PromiseCtor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern TPromise  { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable forEachDelegate (ObservableForEachParam1Delegate<T> onNext = default(ObservableForEachParam1Delegate<T>), ObservableForEachParam2Delegate<T> onError = default(ObservableForEachParam2Delegate<T>), ObservableForEachParam3Delegate<T> onCompleted = default(ObservableForEachParam3Delegate<T>));

#pragma warning disable CS0626
		public extern IDisposable ForEach (ObservableForEachParam1Delegate<T> onNext = default(ObservableForEachParam1Delegate<T>), ObservableForEachParam2Delegate<T> onError = default(ObservableForEachParam2Delegate<T>), ObservableForEachParam3Delegate<T> onCompleted = default(ObservableForEachParam3Delegate<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern forEachDelegate forEach { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> toArrayDelegate ();

#pragma warning disable CS0626
		public extern Observable<T[]> ToArray ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toArrayDelegate toArray { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object catchDelegate (ObservableCatchParam1Delegate<T> handler);

#pragma warning disable CS0626
		public extern object Catch (ObservableCatchParam1Delegate<T> handler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchDelegate @catch { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object catchExceptionDelegate (ObservableCatchExceptionParam1Delegate<T> handler);

#pragma warning disable CS0626
		public extern object CatchException (ObservableCatchExceptionParam1Delegate<T> handler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchExceptionDelegate catchException { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2]> combineLatestDelegate<T2> (Any<Observable<T2>, IPromise<T2>> second);

#pragma warning disable CS0626
		public extern Observable<[T, T2]> CombineLatest<T2> (Any<Observable<T2>, IPromise<T2>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2> combineLatest<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableCombineLatestParam2Delegate<T, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableCombineLatestParam2Delegate<T, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, TResult> combineLatest<T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3]> combineLatestDelegate<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3]> CombineLatest<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3> combineLatest<T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableCombineLatestParam3Delegate<T, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableCombineLatestParam3Delegate<T, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, TResult> combineLatest<T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4]> combineLatestDelegate<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4]> CombineLatest<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, T4> combineLatest<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableCombineLatestParam4Delegate<T, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableCombineLatestParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, T4, TResult> combineLatest<T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4, T5]> combineLatestDelegate<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4, T5]> CombineLatest<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, T4, T5> combineLatest<T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableCombineLatestParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableCombineLatestParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, T4, T5, TResult> combineLatest<T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<TOther, TResult> (ObservableCombineLatestParam1Delegate<T, TOther, TResult>[] souces, ObservableCombineLatestParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<TOther, TResult> (ObservableCombineLatestParam1Delegate<T, TOther, TResult>[] souces, ObservableCombineLatestParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<TOther, TResult> combineLatest<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2]> withLatestFromDelegate<T2> (Any<Observable<T2>, IPromise<T2>> second);

#pragma warning disable CS0626
		public extern Observable<[T, T2]> WithLatestFrom<T2> (Any<Observable<T2>, IPromise<T2>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2> withLatestFrom<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableWithLatestFromParam2Delegate<T, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableWithLatestFromParam2Delegate<T, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, TResult> withLatestFrom<T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3]> withLatestFromDelegate<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3]> WithLatestFrom<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3> withLatestFrom<T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableWithLatestFromParam3Delegate<T, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableWithLatestFromParam3Delegate<T, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, TResult> withLatestFrom<T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4]> withLatestFromDelegate<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4]> WithLatestFrom<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, T4> withLatestFrom<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableWithLatestFromParam4Delegate<T, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableWithLatestFromParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, T4, TResult> withLatestFrom<T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4, T5]> withLatestFromDelegate<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4, T5]> WithLatestFrom<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, T4, T5> withLatestFrom<T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableWithLatestFromParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableWithLatestFromParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, T4, T5, TResult> withLatestFrom<T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<TOther, TResult> (ObservableWithLatestFromParam1Delegate<T, TOther, TResult>[] souces, ObservableWithLatestFromParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<TOther, TResult> (ObservableWithLatestFromParam1Delegate<T, TOther, TResult>[] souces, ObservableWithLatestFromParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<TOther, TResult> withLatestFrom<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> concatDelegate (params ObservableConcatParam1Delegate<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T> Concat (params ObservableConcatParam1Delegate<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatDelegate concat { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> concatAllDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> ConcatAll ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatAllDelegate concatAll { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> concatObservableDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> ConcatObservable ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatObservableDelegate concatObservable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> concatMapDelegate<T2, R> (ObservableConcatMapParam1Delegate<T, T2, R> selector, ObservableConcatMapParam2Delegate<T, T2, R> resultSelector);

#pragma warning disable CS0626
		public extern Observable<R> ConcatMap<T2, R> (ObservableConcatMapParam1Delegate<T, T2, R> selector, ObservableConcatMapParam2Delegate<T, T2, R> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatMapDelegate<T2, R> concatMap<T2, R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> concatMapDelegate<R> (ObservableConcatMapParam1Delegate<T, R> selector);

#pragma warning disable CS0626
		public extern Observable<R> ConcatMap<R> (ObservableConcatMapParam1Delegate<T, R> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatMapDelegate<R> concatMap<R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate T mergeDelegate (number maxConcurrent);

#pragma warning disable CS0626
		public extern T Merge (number maxConcurrent);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mergeDelegate merge { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> mergeAllDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> MergeAll ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mergeAllDelegate mergeAll { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> mergeObservableDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> MergeObservable ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mergeObservableDelegate mergeObservable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipUntilDelegate<T2> (Observable<T2> other);

#pragma warning disable CS0626
		public extern Observable<T> SkipUntil<T2> (Observable<T2> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipUntilDelegate<T2> skipUntil<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate T switchDelegate ();

#pragma warning disable CS0626
		public extern T Switch ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern switchDelegate @switch { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate T switchLatestDelegate ();

#pragma warning disable CS0626
		public extern T SwitchLatest ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern switchLatestDelegate switchLatest { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeUntilDelegate<T2> (Observable<T2> other);

#pragma warning disable CS0626
		public extern Observable<T> TakeUntil<T2> (Observable<T2> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeUntilDelegate<T2> takeUntil<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2]> zipDelegate<T2> (Any<Observable<T2>, IPromise<T2>> second);

#pragma warning disable CS0626
		public extern Observable<[T, T2]> Zip<T2> (Any<Observable<T2>, IPromise<T2>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2> zip<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableZipParam2Delegate<T, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableZipParam2Delegate<T, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, TResult> zip<T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3]> zipDelegate<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3]> Zip<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3> zip<T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableZipParam3Delegate<T, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableZipParam3Delegate<T, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, TResult> zip<T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4]> zipDelegate<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4]> Zip<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, T4> zip<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableZipParam4Delegate<T, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableZipParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, T4, TResult> zip<T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4, T5]> zipDelegate<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4, T5]> Zip<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, T4, T5> zip<T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableZipParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableZipParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, T4, T5, TResult> zip<T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<TOther, TResult> (ObservableZipParam1Delegate<T, TOther, TResult>[] second, ObservableZipParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<TOther, TResult> (ObservableZipParam1Delegate<T, TOther, TResult>[] second, ObservableZipParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<TOther, TResult> zip<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> asObservableDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> AsObservable ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern asObservableDelegate asObservable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TOrigin> dematerializeDelegate<TOrigin> ();

#pragma warning disable CS0626
		public extern Observable<TOrigin> Dematerialize<TOrigin> ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern dematerializeDelegate<TOrigin> dematerialize<TOrigin> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> distinctUntilChangedDelegate (boolean skipParameter, ObservableDistinctUntilChangedParam2Delegate<T> comparer);

#pragma warning disable CS0626
		public extern Observable<T> DistinctUntilChanged (boolean skipParameter, ObservableDistinctUntilChangedParam2Delegate<T> comparer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern distinctUntilChangedDelegate distinctUntilChanged { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> distinctUntilChangedDelegate<TValue> (ObservableDistinctUntilChangedParam1Delegate<T, TValue> keySelector = default(ObservableDistinctUntilChangedParam1Delegate<T, TValue>), ObservableDistinctUntilChangedParam2Delegate<T, TValue> comparer = default(ObservableDistinctUntilChangedParam2Delegate<T, TValue>));

#pragma warning disable CS0626
		public extern Observable<T> DistinctUntilChanged<TValue> (ObservableDistinctUntilChangedParam1Delegate<T, TValue> keySelector = default(ObservableDistinctUntilChangedParam1Delegate<T, TValue>), ObservableDistinctUntilChangedParam2Delegate<T, TValue> comparer = default(ObservableDistinctUntilChangedParam2Delegate<T, TValue>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern distinctUntilChangedDelegate<TValue> distinctUntilChanged<TValue> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern Observable<T> Do (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doDelegate @do { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doActionDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern Observable<T> DoAction (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doActionDelegate doAction { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> tapDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern Observable<T> Tap (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern tapDelegate tap { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doOnNextDelegate (ObservableDoOnNextParam1Delegate<T> onNext, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> DoOnNext (ObservableDoOnNextParam1Delegate<T> onNext, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doOnNextDelegate doOnNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doOnErrorDelegate (ObservableDoOnErrorParam1Delegate<T> onError, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> DoOnError (ObservableDoOnErrorParam1Delegate<T> onError, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doOnErrorDelegate doOnError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doOnCompletedDelegate (ObservableDoOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> DoOnCompleted (ObservableDoOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doOnCompletedDelegate doOnCompleted { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> tapOnNextDelegate (ObservableTapOnNextParam1Delegate<T> onNext, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> TapOnNext (ObservableTapOnNextParam1Delegate<T> onNext, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern tapOnNextDelegate tapOnNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> tapOnErrorDelegate (ObservableTapOnErrorParam1Delegate<T> onError, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> TapOnError (ObservableTapOnErrorParam1Delegate<T> onError, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern tapOnErrorDelegate tapOnError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> tapOnCompletedDelegate (ObservableTapOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> TapOnCompleted (ObservableTapOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern tapOnCompletedDelegate tapOnCompleted { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> finallyDelegate (ObservableFinallyParam1Delegate<T> action);

#pragma warning disable CS0626
		public extern Observable<T> Finally (ObservableFinallyParam1Delegate<T> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern finallyDelegate @finally { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> finallyActionDelegate (ObservableFinallyActionParam1Delegate<T> action);

#pragma warning disable CS0626
		public extern Observable<T> FinallyAction (ObservableFinallyActionParam1Delegate<T> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern finallyActionDelegate finallyAction { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> ignoreElementsDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> IgnoreElements ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ignoreElementsDelegate ignoreElements { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Notification<T>> materializeDelegate ();

#pragma warning disable CS0626
		public extern Observable<Notification<T>> Materialize ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern materializeDelegate materialize { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> repeatDelegate (number repeatCount = default(number));

#pragma warning disable CS0626
		public extern Observable<T> Repeat (number repeatCount = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern repeatDelegate repeat { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> retryDelegate (number retryCount = default(number));

#pragma warning disable CS0626
		public extern Observable<T> Retry (number retryCount = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern retryDelegate retry { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> retryWhenDelegate<TError> (ObservableRetryWhenParam1Delegate<T, TError> notifier);

#pragma warning disable CS0626
		public extern Observable<T> RetryWhen<TError> (ObservableRetryWhenParam1Delegate<T, TError> notifier);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern retryWhenDelegate<TError> retryWhen<TError> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TAcc> scanDelegate<TAcc> (ObservableScanParam1Delegate<T, TAcc> accumulator, TAcc seed);

#pragma warning disable CS0626
		public extern Observable<TAcc> Scan<TAcc> (ObservableScanParam1Delegate<T, TAcc> accumulator, TAcc seed);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scanDelegate<TAcc> scan<TAcc> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> scanDelegate (ObservableScanParam1Delegate<T> accumulator);

#pragma warning disable CS0626
		public extern Observable<T> Scan (ObservableScanParam1Delegate<T> accumulator);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scanDelegate scan { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipLastDelegate (number count);

#pragma warning disable CS0626
		public extern Observable<T> SkipLast (number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipLastDelegate skipLast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> startWithDelegate (params T[] values);

#pragma warning disable CS0626
		public extern Observable<T> StartWith (params T[] values);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern startWithDelegate startWith { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeLastDelegate (number count);

#pragma warning disable CS0626
		public extern Observable<T> TakeLast (number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeLastDelegate takeLast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> takeLastBufferDelegate (number count);

#pragma warning disable CS0626
		public extern Observable<T[]> TakeLastBuffer (number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeLastBufferDelegate takeLastBuffer { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> selectDelegate<TResult> (ObservableSelectParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> Select<TResult> (ObservableSelectParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectDelegate<TResult> select<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> mapDelegate<TResult> (ObservableMapParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> Map<TResult> (ObservableMapParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mapDelegate<TResult> map<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> pluckDelegate<TResult> (string prop);

#pragma warning disable CS0626
		public extern Observable<TResult> Pluck<TResult> (string prop);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pluckDelegate<TResult> pluck<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> selectManyDelegate<TOther, TResult> (ObservableSelectManyParam1Delegate<T, TOther, TResult> selector, ObservableSelectManyParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> SelectMany<TOther, TResult> (ObservableSelectManyParam1Delegate<T, TOther, TResult> selector, ObservableSelectManyParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectManyDelegate<TOther, TResult> selectMany<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> selectManyDelegate<TResult> (ObservableSelectManyParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> SelectMany<TResult> (ObservableSelectManyParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectManyDelegate<TResult> selectMany<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> flatMapDelegate<TOther, TResult> (ObservableFlatMapParam1Delegate<T, TOther, TResult> selector, ObservableFlatMapParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> FlatMap<TOther, TResult> (ObservableFlatMapParam1Delegate<T, TOther, TResult> selector, ObservableFlatMapParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern flatMapDelegate<TOther, TResult> flatMap<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> flatMapDelegate<TResult> (ObservableFlatMapParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> FlatMap<TResult> (ObservableFlatMapParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern flatMapDelegate<TResult> flatMap<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<2 | T3 | T4> selectManyObserverDelegate<T2, T3, T4> (ObservableSelectManyObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableSelectManyObserverParam2Delegate<T, T2, T3, T4> onError, ObservableSelectManyObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<2 | T3 | T4> SelectManyObserver<T2, T3, T4> (ObservableSelectManyObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableSelectManyObserverParam2Delegate<T, T2, T3, T4> onError, ObservableSelectManyObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectManyObserverDelegate<T2, T3, T4> selectManyObserver<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<2 | T3 | T4> flatMapObserverDelegate<T2, T3, T4> (ObservableFlatMapObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableFlatMapObserverParam2Delegate<T, T2, T3, T4> onError, ObservableFlatMapObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<2 | T3 | T4> FlatMapObserver<T2, T3, T4> (ObservableFlatMapObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableFlatMapObserverParam2Delegate<T, T2, T3, T4> onError, ObservableFlatMapObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern flatMapObserverDelegate<T2, T3, T4> flatMapObserver<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> selectConcatDelegate<T2, R> (ObservableSelectConcatParam1Delegate<T, T2, R> selector, ObservableSelectConcatParam2Delegate<T, T2, R> resultSelector);

#pragma warning disable CS0626
		public extern Observable<R> SelectConcat<T2, R> (ObservableSelectConcatParam1Delegate<T, T2, R> selector, ObservableSelectConcatParam2Delegate<T, T2, R> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectConcatDelegate<T2, R> selectConcat<T2, R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> selectConcatDelegate<R> (ObservableSelectConcatParam1Delegate<T, R> selector);

#pragma warning disable CS0626
		public extern Observable<R> SelectConcat<R> (ObservableSelectConcatParam1Delegate<T, R> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectConcatDelegate<R> selectConcat<R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> selectSwitchDelegate<TResult> (ObservableSelectSwitchParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> SelectSwitch<TResult> (ObservableSelectSwitchParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectSwitchDelegate<TResult> selectSwitch<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> flatMapLatestDelegate<TResult> (ObservableFlatMapLatestParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> FlatMapLatest<TResult> (ObservableFlatMapLatestParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern flatMapLatestDelegate<TResult> flatMapLatest<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> switchMapDelegate<TResult> (ObservableSwitchMapParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> SwitchMap<TResult> (ObservableSwitchMapParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern switchMapDelegate<TResult> switchMap<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipDelegate (number count);

#pragma warning disable CS0626
		public extern Observable<T> Skip (number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipDelegate skip { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipWhileDelegate (ObservableSkipWhileParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> SkipWhile (ObservableSkipWhileParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipWhileDelegate skipWhile { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeDelegate (number count, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Take (number count, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeDelegate take { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeWhileDelegate (ObservableTakeWhileParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> TakeWhile (ObservableTakeWhileParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeWhileDelegate takeWhile { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> whereDelegate (ObservableWhereParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> Where (ObservableWhereParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern whereDelegate where { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> filterDelegate (ObservableFilterParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> Filter (ObservableFilterParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern filterDelegate filter { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IPromise<T> toPromiseDelegate (ObservablePromiseCtorInterface<T> promiseCtor = default(ObservablePromiseCtorInterface<T>));

#pragma warning disable CS0626
		public extern IPromise<T> ToPromise (ObservablePromiseCtorInterface<T> promiseCtor = default(ObservablePromiseCtorInterface<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toPromiseDelegate toPromise { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> exclusiveDelegate<R> ();

#pragma warning disable CS0626
		public extern Observable<R> Exclusive<R> ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern exclusiveDelegate<R> exclusive<R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> exclusiveMapDelegate<I, R> (ObservableExclusiveMapParam1Delegate<T, I, R> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<R> ExclusiveMap<I, R> (ObservableExclusiveMapParam1Delegate<T, I, R> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern exclusiveMapDelegate<I, R> exclusiveMap<I, R> { get; set; }
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
	public delegate IDisposable subscribeDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern IDisposable Subscribe (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeDelegate subscribe { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnNextDelegate (IObservableSubscribeOnNextParam1Delegate<T> onNext, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnNext (IObservableSubscribeOnNextParam1Delegate<T> onNext, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnNextDelegate subscribeOnNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnErrorDelegate (IObservableSubscribeOnErrorParam1Delegate<T> onError, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnError (IObservableSubscribeOnErrorParam1Delegate<T> onError, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnErrorDelegate subscribeOnError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnCompletedDelegate (IObservableSubscribeOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnCompleted (IObservableSubscribeOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnCompletedDelegate subscribeOnCompleted { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T> : IObservable<T>
	{
		[FieldProperty]
		ObservablePromiseCtorInterface<T> PromiseCtor { get; set; }
		[FieldProperty]
		TPromise  { get; set; }
		IDisposable ForEach (ObservableForEachParam1Delegate<T> onNext = default(ObservableForEachParam1Delegate<T>), ObservableForEachParam2Delegate<T> onError = default(ObservableForEachParam2Delegate<T>), ObservableForEachParam3Delegate<T> onCompleted = default(ObservableForEachParam3Delegate<T>));
		Observable<T[]> ToArray ();
		object Catch (ObservableCatchParam1Delegate<T> handler);
		Observable<T> Catch (Observable<T> second);
		object CatchException (ObservableCatchExceptionParam1Delegate<T> handler);
		Observable<T> CatchException (Observable<T> second);
		Observable<[T, T2]> CombineLatest<T2> (Any<Observable<T2>, IPromise<T2>> second);
		Observable<TResult> CombineLatest<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableCombineLatestParam2Delegate<T, T2, TResult> resultSelector);
		Observable<[T, T2, T3]> CombineLatest<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
		Observable<TResult> CombineLatest<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableCombineLatestParam3Delegate<T, T2, T3, TResult> resultSelector);
		Observable<[T, T2, T3, T4]> CombineLatest<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
		Observable<TResult> CombineLatest<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableCombineLatestParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
		Observable<[T, T2, T3, T4, T5]> CombineLatest<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
		Observable<TResult> CombineLatest<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableCombineLatestParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
		Observable<TResult> CombineLatest<TOther, TResult> (ObservableCombineLatestParam1Delegate<T, TOther, TResult>[] souces, ObservableCombineLatestParam2Delegate<T, TOther, TResult> resultSelector);
		Observable<[T, T2]> WithLatestFrom<T2> (Any<Observable<T2>, IPromise<T2>> second);
		Observable<TResult> WithLatestFrom<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableWithLatestFromParam2Delegate<T, T2, TResult> resultSelector);
		Observable<[T, T2, T3]> WithLatestFrom<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
		Observable<TResult> WithLatestFrom<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableWithLatestFromParam3Delegate<T, T2, T3, TResult> resultSelector);
		Observable<[T, T2, T3, T4]> WithLatestFrom<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
		Observable<TResult> WithLatestFrom<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableWithLatestFromParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
		Observable<[T, T2, T3, T4, T5]> WithLatestFrom<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
		Observable<TResult> WithLatestFrom<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableWithLatestFromParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
		Observable<TResult> WithLatestFrom<TOther, TResult> (ObservableWithLatestFromParam1Delegate<T, TOther, TResult>[] souces, ObservableWithLatestFromParam2Delegate<T, TOther, TResult> resultSelector);
		Observable<T> Concat (params ObservableConcatParam1Delegate<T>[] sources);
		Observable<T> Concat (ObservableConcatParam1Delegate_<T>[] sources);
		Observable<T> ConcatAll ();
		Observable<T> ConcatObservable ();
		Observable<R> ConcatMap<T2, R> (ObservableConcatMapParam1Delegate<T, T2, R> selector, ObservableConcatMapParam2Delegate<T, T2, R> resultSelector);
		Observable<R> ConcatMap<T2, R> (ObservableConcatMapParam1Delegate_<T, T2, R> selector, ObservableConcatMapParam2Delegate_<T, T2, R> resultSelector);
		Observable<R> ConcatMap<R> (ObservableConcatMapParam1Delegate<T, R> selector);
		Observable<R> ConcatMap<R> (ObservableConcatMapParam1Delegate_<T, R> selector);
		Observable<R> ConcatMap<R> (ObservableConcatMapParam1Delegate__<T, R> selector);
		Observable<R> ConcatMap<R> (Observable<R> sequence);
		Observable<R> ConcatMap<R> (R[] sequence);
		T Merge (number maxConcurrent);
		Observable<T> Merge (Observable<T> other);
		Observable<T> Merge (IPromise<T> other);
		Observable<T> MergeAll ();
		Observable<T> MergeObservable ();
		Observable<T> SkipUntil<T2> (Observable<T2> other);
		Observable<T> SkipUntil<T2> (IPromise<T2> other);
		T Switch ();
		T SwitchLatest ();
		Observable<T> TakeUntil<T2> (Observable<T2> other);
		Observable<T> TakeUntil<T2> (IPromise<T2> other);
		Observable<[T, T2]> Zip<T2> (Any<Observable<T2>, IPromise<T2>> second);
		Observable<TResult> Zip<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableZipParam2Delegate<T, T2, TResult> resultSelector);
		Observable<[T, T2, T3]> Zip<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
		Observable<TResult> Zip<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableZipParam3Delegate<T, T2, T3, TResult> resultSelector);
		Observable<[T, T2, T3, T4]> Zip<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
		Observable<TResult> Zip<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableZipParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
		Observable<[T, T2, T3, T4, T5]> Zip<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
		Observable<TResult> Zip<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableZipParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
		Observable<TResult> Zip<TOther, TResult> (ObservableZipParam1Delegate<T, TOther, TResult>[] second, ObservableZipParam2Delegate<T, TOther, TResult> resultSelector);
		Observable<T> AsObservable ();
		Observable<TOrigin> Dematerialize<TOrigin> ();
		Observable<T> DistinctUntilChanged (boolean skipParameter, ObservableDistinctUntilChangedParam2Delegate<T> comparer);
		Observable<T> DistinctUntilChanged<TValue> (ObservableDistinctUntilChangedParam1Delegate<T, TValue> keySelector = default(ObservableDistinctUntilChangedParam1Delegate<T, TValue>), ObservableDistinctUntilChangedParam2Delegate<T, TValue> comparer = default(ObservableDistinctUntilChangedParam2Delegate<T, TValue>));
		Observable<T> Do (Observer<T> observer);
		Observable<T> Do (ObservableDoParam1Delegate<T> onNext = default(ObservableDoParam1Delegate<T>), ObservableDoParam2Delegate<T> onError = default(ObservableDoParam2Delegate<T>), ObservableDoParam3Delegate<T> onCompleted = default(ObservableDoParam3Delegate<T>));
		Observable<T> DoAction (Observer<T> observer);
		Observable<T> DoAction (ObservableDoActionParam1Delegate<T> onNext = default(ObservableDoActionParam1Delegate<T>), ObservableDoActionParam2Delegate<T> onError = default(ObservableDoActionParam2Delegate<T>), ObservableDoActionParam3Delegate<T> onCompleted = default(ObservableDoActionParam3Delegate<T>));
		Observable<T> Tap (Observer<T> observer);
		Observable<T> Tap (ObservableTapParam1Delegate<T> onNext = default(ObservableTapParam1Delegate<T>), ObservableTapParam2Delegate<T> onError = default(ObservableTapParam2Delegate<T>), ObservableTapParam3Delegate<T> onCompleted = default(ObservableTapParam3Delegate<T>));
		Observable<T> DoOnNext (ObservableDoOnNextParam1Delegate<T> onNext, any thisArg = default(any));
		Observable<T> DoOnError (ObservableDoOnErrorParam1Delegate<T> onError, any thisArg = default(any));
		Observable<T> DoOnCompleted (ObservableDoOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
		Observable<T> TapOnNext (ObservableTapOnNextParam1Delegate<T> onNext, any thisArg = default(any));
		Observable<T> TapOnError (ObservableTapOnErrorParam1Delegate<T> onError, any thisArg = default(any));
		Observable<T> TapOnCompleted (ObservableTapOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
		Observable<T> Finally (ObservableFinallyParam1Delegate<T> action);
		Observable<T> FinallyAction (ObservableFinallyActionParam1Delegate<T> action);
		Observable<T> IgnoreElements ();
		Observable<Notification<T>> Materialize ();
		Observable<T> Repeat (number repeatCount = default(number));
		Observable<T> Retry (number retryCount = default(number));
		Observable<T> RetryWhen<TError> (ObservableRetryWhenParam1Delegate<T, TError> notifier);
		Observable<TAcc> Scan<TAcc> (ObservableScanParam1Delegate<T, TAcc> accumulator, TAcc seed);
		Observable<T> Scan (ObservableScanParam1Delegate<T> accumulator);
		Observable<T> SkipLast (number count);
		Observable<T> StartWith (params T[] values);
		Observable<T> StartWith (IScheduler scheduler, params T[] values);
		Observable<T> TakeLast (number count);
		Observable<T[]> TakeLastBuffer (number count);
		Observable<TResult> Select<TResult> (ObservableSelectParam1Delegate<T, TResult> selector, any thisArg = default(any));
		Observable<TResult> Map<TResult> (ObservableMapParam1Delegate<T, TResult> selector, any thisArg = default(any));
		Observable<TResult> Pluck<TResult> (string prop);
		Observable<TResult> SelectMany<TOther, TResult> (ObservableSelectManyParam1Delegate<T, TOther, TResult> selector, ObservableSelectManyParam2Delegate<T, TOther, TResult> resultSelector);
		Observable<TResult> SelectMany<TOther, TResult> (ObservableSelectManyParam1Delegate_<T, TOther, TResult> selector, ObservableSelectManyParam2Delegate_<T, TOther, TResult> resultSelector);
		Observable<TResult> SelectMany<TResult> (ObservableSelectManyParam1Delegate<T, TResult> selector);
		Observable<TResult> SelectMany<TResult> (ObservableSelectManyParam1Delegate_<T, TResult> selector);
		Observable<TResult> SelectMany<TResult> (Observable<TResult> other);
		Observable<TResult> SelectMany<TResult> (IPromise<TResult> other);
		Observable<TResult> SelectMany<TResult> (ObservableSelectManyParam1Delegate__<T, TResult> selector);
		Observable<TResult> FlatMap<TOther, TResult> (ObservableFlatMapParam1Delegate<T, TOther, TResult> selector, ObservableFlatMapParam2Delegate<T, TOther, TResult> resultSelector);
		Observable<TResult> FlatMap<TOther, TResult> (ObservableFlatMapParam1Delegate_<T, TOther, TResult> selector, ObservableFlatMapParam2Delegate_<T, TOther, TResult> resultSelector);
		Observable<TResult> FlatMap<TResult> (ObservableFlatMapParam1Delegate<T, TResult> selector);
		Observable<TResult> FlatMap<TResult> (ObservableFlatMapParam1Delegate_<T, TResult> selector);
		Observable<TResult> FlatMap<TResult> (Observable<TResult> other);
		Observable<TResult> FlatMap<TResult> (IPromise<TResult> other);
		Observable<TResult> FlatMap<TResult> (ObservableFlatMapParam1Delegate__<T, TResult> selector);
		Observable<2 | T3 | T4> SelectManyObserver<T2, T3, T4> (ObservableSelectManyObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableSelectManyObserverParam2Delegate<T, T2, T3, T4> onError, ObservableSelectManyObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));
		Observable<2 | T3 | T4> FlatMapObserver<T2, T3, T4> (ObservableFlatMapObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableFlatMapObserverParam2Delegate<T, T2, T3, T4> onError, ObservableFlatMapObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));
		Observable<R> SelectConcat<T2, R> (ObservableSelectConcatParam1Delegate<T, T2, R> selector, ObservableSelectConcatParam2Delegate<T, T2, R> resultSelector);
		Observable<R> SelectConcat<T2, R> (ObservableSelectConcatParam1Delegate_<T, T2, R> selector, ObservableSelectConcatParam2Delegate_<T, T2, R> resultSelector);
		Observable<R> SelectConcat<R> (ObservableSelectConcatParam1Delegate<T, R> selector);
		Observable<R> SelectConcat<R> (ObservableSelectConcatParam1Delegate_<T, R> selector);
		Observable<R> SelectConcat<R> (Observable<R> sequence);
		Observable<TResult> SelectSwitch<TResult> (ObservableSelectSwitchParam1Delegate<T, TResult> selector, any thisArg = default(any));
		Observable<TResult> FlatMapLatest<TResult> (ObservableFlatMapLatestParam1Delegate<T, TResult> selector, any thisArg = default(any));
		Observable<TResult> SwitchMap<TResult> (ObservableSwitchMapParam1Delegate<T, TResult> selector, any thisArg = default(any));
		Observable<T> Skip (number count);
		Observable<T> SkipWhile (ObservableSkipWhileParam1Delegate<T> predicate, any thisArg = default(any));
		Observable<T> Take (number count, IScheduler scheduler = default(IScheduler));
		Observable<T> TakeWhile (ObservableTakeWhileParam1Delegate<T> predicate, any thisArg = default(any));
		Observable<T> Where (ObservableWhereParam1Delegate<T> predicate, any thisArg = default(any));
		Observable<T> Filter (ObservableFilterParam1Delegate<T> predicate, any thisArg = default(any));
		IPromise<T> ToPromise (ObservablePromiseCtorInterface<T> promiseCtor = default(ObservablePromiseCtorInterface<T>));
		Observable<R> Exclusive<R> ();
		Observable<R> ExclusiveMap<I, R> (ObservableExclusiveMapParam1Delegate<T, I, R> selector, any thisArg = default(any));
		ConnectableObservable<T> Publish ();
	}
	[ObjectLiteral]
	public class JSONConnectableObservable<T> : ConnectableObservable<T>
	{
#pragma warning disable CS0626
		public extern ObservablePromiseCtorInterface<T> PromiseCtor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern TPromise  { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Disposable connectDelegate ();

#pragma warning disable CS0626
		public extern Disposable Connect ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern connectDelegate connect { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern IDisposable Subscribe (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeDelegate subscribe { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnNextDelegate (IObservableSubscribeOnNextParam1Delegate<T> onNext, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnNext (IObservableSubscribeOnNextParam1Delegate<T> onNext, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnNextDelegate subscribeOnNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnErrorDelegate (IObservableSubscribeOnErrorParam1Delegate<T> onError, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnError (IObservableSubscribeOnErrorParam1Delegate<T> onError, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnErrorDelegate subscribeOnError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable subscribeOnCompletedDelegate (IObservableSubscribeOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern IDisposable SubscribeOnCompleted (IObservableSubscribeOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern subscribeOnCompletedDelegate subscribeOnCompleted { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable forEachDelegate (ObservableForEachParam1Delegate<T> onNext = default(ObservableForEachParam1Delegate<T>), ObservableForEachParam2Delegate<T> onError = default(ObservableForEachParam2Delegate<T>), ObservableForEachParam3Delegate<T> onCompleted = default(ObservableForEachParam3Delegate<T>));

#pragma warning disable CS0626
		public extern IDisposable ForEach (ObservableForEachParam1Delegate<T> onNext = default(ObservableForEachParam1Delegate<T>), ObservableForEachParam2Delegate<T> onError = default(ObservableForEachParam2Delegate<T>), ObservableForEachParam3Delegate<T> onCompleted = default(ObservableForEachParam3Delegate<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern forEachDelegate forEach { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> toArrayDelegate ();

#pragma warning disable CS0626
		public extern Observable<T[]> ToArray ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toArrayDelegate toArray { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object catchDelegate (ObservableCatchParam1Delegate<T> handler);

#pragma warning disable CS0626
		public extern object Catch (ObservableCatchParam1Delegate<T> handler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchDelegate @catch { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object catchExceptionDelegate (ObservableCatchExceptionParam1Delegate<T> handler);

#pragma warning disable CS0626
		public extern object CatchException (ObservableCatchExceptionParam1Delegate<T> handler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchExceptionDelegate catchException { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2]> combineLatestDelegate<T2> (Any<Observable<T2>, IPromise<T2>> second);

#pragma warning disable CS0626
		public extern Observable<[T, T2]> CombineLatest<T2> (Any<Observable<T2>, IPromise<T2>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2> combineLatest<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableCombineLatestParam2Delegate<T, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableCombineLatestParam2Delegate<T, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, TResult> combineLatest<T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3]> combineLatestDelegate<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3]> CombineLatest<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3> combineLatest<T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableCombineLatestParam3Delegate<T, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableCombineLatestParam3Delegate<T, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, TResult> combineLatest<T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4]> combineLatestDelegate<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4]> CombineLatest<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, T4> combineLatest<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableCombineLatestParam4Delegate<T, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableCombineLatestParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, T4, TResult> combineLatest<T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4, T5]> combineLatestDelegate<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4, T5]> CombineLatest<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, T4, T5> combineLatest<T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableCombineLatestParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableCombineLatestParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T2, T3, T4, T5, TResult> combineLatest<T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<TOther, TResult> (ObservableCombineLatestParam1Delegate<T, TOther, TResult>[] souces, ObservableCombineLatestParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<TOther, TResult> (ObservableCombineLatestParam1Delegate<T, TOther, TResult>[] souces, ObservableCombineLatestParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<TOther, TResult> combineLatest<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2]> withLatestFromDelegate<T2> (Any<Observable<T2>, IPromise<T2>> second);

#pragma warning disable CS0626
		public extern Observable<[T, T2]> WithLatestFrom<T2> (Any<Observable<T2>, IPromise<T2>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2> withLatestFrom<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableWithLatestFromParam2Delegate<T, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableWithLatestFromParam2Delegate<T, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, TResult> withLatestFrom<T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3]> withLatestFromDelegate<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3]> WithLatestFrom<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3> withLatestFrom<T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableWithLatestFromParam3Delegate<T, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableWithLatestFromParam3Delegate<T, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, TResult> withLatestFrom<T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4]> withLatestFromDelegate<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4]> WithLatestFrom<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, T4> withLatestFrom<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableWithLatestFromParam4Delegate<T, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableWithLatestFromParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, T4, TResult> withLatestFrom<T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4, T5]> withLatestFromDelegate<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4, T5]> WithLatestFrom<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, T4, T5> withLatestFrom<T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableWithLatestFromParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableWithLatestFromParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T2, T3, T4, T5, TResult> withLatestFrom<T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<TOther, TResult> (ObservableWithLatestFromParam1Delegate<T, TOther, TResult>[] souces, ObservableWithLatestFromParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<TOther, TResult> (ObservableWithLatestFromParam1Delegate<T, TOther, TResult>[] souces, ObservableWithLatestFromParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<TOther, TResult> withLatestFrom<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> concatDelegate (params ObservableConcatParam1Delegate<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T> Concat (params ObservableConcatParam1Delegate<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatDelegate concat { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> concatAllDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> ConcatAll ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatAllDelegate concatAll { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> concatObservableDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> ConcatObservable ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatObservableDelegate concatObservable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> concatMapDelegate<T2, R> (ObservableConcatMapParam1Delegate<T, T2, R> selector, ObservableConcatMapParam2Delegate<T, T2, R> resultSelector);

#pragma warning disable CS0626
		public extern Observable<R> ConcatMap<T2, R> (ObservableConcatMapParam1Delegate<T, T2, R> selector, ObservableConcatMapParam2Delegate<T, T2, R> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatMapDelegate<T2, R> concatMap<T2, R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> concatMapDelegate<R> (ObservableConcatMapParam1Delegate<T, R> selector);

#pragma warning disable CS0626
		public extern Observable<R> ConcatMap<R> (ObservableConcatMapParam1Delegate<T, R> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatMapDelegate<R> concatMap<R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate T mergeDelegate (number maxConcurrent);

#pragma warning disable CS0626
		public extern T Merge (number maxConcurrent);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mergeDelegate merge { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> mergeAllDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> MergeAll ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mergeAllDelegate mergeAll { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> mergeObservableDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> MergeObservable ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mergeObservableDelegate mergeObservable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipUntilDelegate<T2> (Observable<T2> other);

#pragma warning disable CS0626
		public extern Observable<T> SkipUntil<T2> (Observable<T2> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipUntilDelegate<T2> skipUntil<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate T switchDelegate ();

#pragma warning disable CS0626
		public extern T Switch ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern switchDelegate @switch { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate T switchLatestDelegate ();

#pragma warning disable CS0626
		public extern T SwitchLatest ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern switchLatestDelegate switchLatest { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeUntilDelegate<T2> (Observable<T2> other);

#pragma warning disable CS0626
		public extern Observable<T> TakeUntil<T2> (Observable<T2> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeUntilDelegate<T2> takeUntil<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2]> zipDelegate<T2> (Any<Observable<T2>, IPromise<T2>> second);

#pragma warning disable CS0626
		public extern Observable<[T, T2]> Zip<T2> (Any<Observable<T2>, IPromise<T2>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2> zip<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableZipParam2Delegate<T, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T2, TResult> (Any<Observable<T2>, IPromise<T2>> second, ObservableZipParam2Delegate<T, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, TResult> zip<T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3]> zipDelegate<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3]> Zip<T2, T3> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3> zip<T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableZipParam3Delegate<T, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T2, T3, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableZipParam3Delegate<T, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, TResult> zip<T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4]> zipDelegate<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4]> Zip<T2, T3, T4> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, T4> zip<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableZipParam4Delegate<T, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T2, T3, T4, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableZipParam4Delegate<T, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, T4, TResult> zip<T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4, T5]> zipDelegate<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4, T5]> Zip<T2, T3, T4, T5> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, T4, T5> zip<T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableZipParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T2, T3, T4, T5, TResult> (Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableZipParam5Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T2, T3, T4, T5, TResult> zip<T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<TOther, TResult> (ObservableZipParam1Delegate<T, TOther, TResult>[] second, ObservableZipParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<TOther, TResult> (ObservableZipParam1Delegate<T, TOther, TResult>[] second, ObservableZipParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<TOther, TResult> zip<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> asObservableDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> AsObservable ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern asObservableDelegate asObservable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TOrigin> dematerializeDelegate<TOrigin> ();

#pragma warning disable CS0626
		public extern Observable<TOrigin> Dematerialize<TOrigin> ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern dematerializeDelegate<TOrigin> dematerialize<TOrigin> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> distinctUntilChangedDelegate (boolean skipParameter, ObservableDistinctUntilChangedParam2Delegate<T> comparer);

#pragma warning disable CS0626
		public extern Observable<T> DistinctUntilChanged (boolean skipParameter, ObservableDistinctUntilChangedParam2Delegate<T> comparer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern distinctUntilChangedDelegate distinctUntilChanged { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> distinctUntilChangedDelegate<TValue> (ObservableDistinctUntilChangedParam1Delegate<T, TValue> keySelector = default(ObservableDistinctUntilChangedParam1Delegate<T, TValue>), ObservableDistinctUntilChangedParam2Delegate<T, TValue> comparer = default(ObservableDistinctUntilChangedParam2Delegate<T, TValue>));

#pragma warning disable CS0626
		public extern Observable<T> DistinctUntilChanged<TValue> (ObservableDistinctUntilChangedParam1Delegate<T, TValue> keySelector = default(ObservableDistinctUntilChangedParam1Delegate<T, TValue>), ObservableDistinctUntilChangedParam2Delegate<T, TValue> comparer = default(ObservableDistinctUntilChangedParam2Delegate<T, TValue>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern distinctUntilChangedDelegate<TValue> distinctUntilChanged<TValue> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern Observable<T> Do (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doDelegate @do { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doActionDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern Observable<T> DoAction (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doActionDelegate doAction { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> tapDelegate (Observer<T> observer);

#pragma warning disable CS0626
		public extern Observable<T> Tap (Observer<T> observer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern tapDelegate tap { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doOnNextDelegate (ObservableDoOnNextParam1Delegate<T> onNext, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> DoOnNext (ObservableDoOnNextParam1Delegate<T> onNext, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doOnNextDelegate doOnNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doOnErrorDelegate (ObservableDoOnErrorParam1Delegate<T> onError, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> DoOnError (ObservableDoOnErrorParam1Delegate<T> onError, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doOnErrorDelegate doOnError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doOnCompletedDelegate (ObservableDoOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> DoOnCompleted (ObservableDoOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doOnCompletedDelegate doOnCompleted { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> tapOnNextDelegate (ObservableTapOnNextParam1Delegate<T> onNext, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> TapOnNext (ObservableTapOnNextParam1Delegate<T> onNext, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern tapOnNextDelegate tapOnNext { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> tapOnErrorDelegate (ObservableTapOnErrorParam1Delegate<T> onError, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> TapOnError (ObservableTapOnErrorParam1Delegate<T> onError, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern tapOnErrorDelegate tapOnError { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> tapOnCompletedDelegate (ObservableTapOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> TapOnCompleted (ObservableTapOnCompletedParam1Delegate<T> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern tapOnCompletedDelegate tapOnCompleted { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> finallyDelegate (ObservableFinallyParam1Delegate<T> action);

#pragma warning disable CS0626
		public extern Observable<T> Finally (ObservableFinallyParam1Delegate<T> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern finallyDelegate @finally { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> finallyActionDelegate (ObservableFinallyActionParam1Delegate<T> action);

#pragma warning disable CS0626
		public extern Observable<T> FinallyAction (ObservableFinallyActionParam1Delegate<T> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern finallyActionDelegate finallyAction { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> ignoreElementsDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> IgnoreElements ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ignoreElementsDelegate ignoreElements { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Notification<T>> materializeDelegate ();

#pragma warning disable CS0626
		public extern Observable<Notification<T>> Materialize ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern materializeDelegate materialize { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> repeatDelegate (number repeatCount = default(number));

#pragma warning disable CS0626
		public extern Observable<T> Repeat (number repeatCount = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern repeatDelegate repeat { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> retryDelegate (number retryCount = default(number));

#pragma warning disable CS0626
		public extern Observable<T> Retry (number retryCount = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern retryDelegate retry { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> retryWhenDelegate<TError> (ObservableRetryWhenParam1Delegate<T, TError> notifier);

#pragma warning disable CS0626
		public extern Observable<T> RetryWhen<TError> (ObservableRetryWhenParam1Delegate<T, TError> notifier);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern retryWhenDelegate<TError> retryWhen<TError> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TAcc> scanDelegate<TAcc> (ObservableScanParam1Delegate<T, TAcc> accumulator, TAcc seed);

#pragma warning disable CS0626
		public extern Observable<TAcc> Scan<TAcc> (ObservableScanParam1Delegate<T, TAcc> accumulator, TAcc seed);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scanDelegate<TAcc> scan<TAcc> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> scanDelegate (ObservableScanParam1Delegate<T> accumulator);

#pragma warning disable CS0626
		public extern Observable<T> Scan (ObservableScanParam1Delegate<T> accumulator);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scanDelegate scan { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipLastDelegate (number count);

#pragma warning disable CS0626
		public extern Observable<T> SkipLast (number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipLastDelegate skipLast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> startWithDelegate (params T[] values);

#pragma warning disable CS0626
		public extern Observable<T> StartWith (params T[] values);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern startWithDelegate startWith { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeLastDelegate (number count);

#pragma warning disable CS0626
		public extern Observable<T> TakeLast (number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeLastDelegate takeLast { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> takeLastBufferDelegate (number count);

#pragma warning disable CS0626
		public extern Observable<T[]> TakeLastBuffer (number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeLastBufferDelegate takeLastBuffer { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> selectDelegate<TResult> (ObservableSelectParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> Select<TResult> (ObservableSelectParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectDelegate<TResult> select<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> mapDelegate<TResult> (ObservableMapParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> Map<TResult> (ObservableMapParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mapDelegate<TResult> map<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> pluckDelegate<TResult> (string prop);

#pragma warning disable CS0626
		public extern Observable<TResult> Pluck<TResult> (string prop);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pluckDelegate<TResult> pluck<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> selectManyDelegate<TOther, TResult> (ObservableSelectManyParam1Delegate<T, TOther, TResult> selector, ObservableSelectManyParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> SelectMany<TOther, TResult> (ObservableSelectManyParam1Delegate<T, TOther, TResult> selector, ObservableSelectManyParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectManyDelegate<TOther, TResult> selectMany<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> selectManyDelegate<TResult> (ObservableSelectManyParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> SelectMany<TResult> (ObservableSelectManyParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectManyDelegate<TResult> selectMany<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> flatMapDelegate<TOther, TResult> (ObservableFlatMapParam1Delegate<T, TOther, TResult> selector, ObservableFlatMapParam2Delegate<T, TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> FlatMap<TOther, TResult> (ObservableFlatMapParam1Delegate<T, TOther, TResult> selector, ObservableFlatMapParam2Delegate<T, TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern flatMapDelegate<TOther, TResult> flatMap<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> flatMapDelegate<TResult> (ObservableFlatMapParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> FlatMap<TResult> (ObservableFlatMapParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern flatMapDelegate<TResult> flatMap<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<2 | T3 | T4> selectManyObserverDelegate<T2, T3, T4> (ObservableSelectManyObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableSelectManyObserverParam2Delegate<T, T2, T3, T4> onError, ObservableSelectManyObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<2 | T3 | T4> SelectManyObserver<T2, T3, T4> (ObservableSelectManyObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableSelectManyObserverParam2Delegate<T, T2, T3, T4> onError, ObservableSelectManyObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectManyObserverDelegate<T2, T3, T4> selectManyObserver<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<2 | T3 | T4> flatMapObserverDelegate<T2, T3, T4> (ObservableFlatMapObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableFlatMapObserverParam2Delegate<T, T2, T3, T4> onError, ObservableFlatMapObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<2 | T3 | T4> FlatMapObserver<T2, T3, T4> (ObservableFlatMapObserverParam1Delegate<T, T2, T3, T4> onNext, ObservableFlatMapObserverParam2Delegate<T, T2, T3, T4> onError, ObservableFlatMapObserverParam3Delegate<T, T2, T3, T4> onCompleted, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern flatMapObserverDelegate<T2, T3, T4> flatMapObserver<T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> selectConcatDelegate<T2, R> (ObservableSelectConcatParam1Delegate<T, T2, R> selector, ObservableSelectConcatParam2Delegate<T, T2, R> resultSelector);

#pragma warning disable CS0626
		public extern Observable<R> SelectConcat<T2, R> (ObservableSelectConcatParam1Delegate<T, T2, R> selector, ObservableSelectConcatParam2Delegate<T, T2, R> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectConcatDelegate<T2, R> selectConcat<T2, R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> selectConcatDelegate<R> (ObservableSelectConcatParam1Delegate<T, R> selector);

#pragma warning disable CS0626
		public extern Observable<R> SelectConcat<R> (ObservableSelectConcatParam1Delegate<T, R> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectConcatDelegate<R> selectConcat<R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> selectSwitchDelegate<TResult> (ObservableSelectSwitchParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> SelectSwitch<TResult> (ObservableSelectSwitchParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern selectSwitchDelegate<TResult> selectSwitch<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> flatMapLatestDelegate<TResult> (ObservableFlatMapLatestParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> FlatMapLatest<TResult> (ObservableFlatMapLatestParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern flatMapLatestDelegate<TResult> flatMapLatest<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> switchMapDelegate<TResult> (ObservableSwitchMapParam1Delegate<T, TResult> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<TResult> SwitchMap<TResult> (ObservableSwitchMapParam1Delegate<T, TResult> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern switchMapDelegate<TResult> switchMap<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipDelegate (number count);

#pragma warning disable CS0626
		public extern Observable<T> Skip (number count);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipDelegate skip { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipWhileDelegate (ObservableSkipWhileParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> SkipWhile (ObservableSkipWhileParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipWhileDelegate skipWhile { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeDelegate (number count, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Take (number count, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeDelegate take { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeWhileDelegate (ObservableTakeWhileParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> TakeWhile (ObservableTakeWhileParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeWhileDelegate takeWhile { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> whereDelegate (ObservableWhereParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> Where (ObservableWhereParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern whereDelegate where { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> filterDelegate (ObservableFilterParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> Filter (ObservableFilterParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern filterDelegate filter { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IPromise<T> toPromiseDelegate (ObservablePromiseCtorInterface<T> promiseCtor = default(ObservablePromiseCtorInterface<T>));

#pragma warning disable CS0626
		public extern IPromise<T> ToPromise (ObservablePromiseCtorInterface<T> promiseCtor = default(ObservablePromiseCtorInterface<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toPromiseDelegate toPromise { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> exclusiveDelegate<R> ();

#pragma warning disable CS0626
		public extern Observable<R> Exclusive<R> ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern exclusiveDelegate<R> exclusive<R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<R> exclusiveMapDelegate<I, R> (ObservableExclusiveMapParam1Delegate<T, I, R> selector, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<R> ExclusiveMap<I, R> (ObservableExclusiveMapParam1Delegate<T, I, R> selector, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern exclusiveMapDelegate<I, R> exclusiveMap<I, R> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ConnectableObservable<T> publishDelegate ();

#pragma warning disable CS0626
		public extern ConnectableObservable<T> Publish ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern publishDelegate publish { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ConnectableObservable<T> : Observable<T>
	{
		Disposable Connect ();
	}
	[External]
	public delegate IDisposable ObservableStaticCreateParam1Delegate<T> (Observer<T> observer);
	[External]
	public delegate  ObservableStaticCreateParam1Delegate_<T> (Observer<T> observer);
	[External]
	public delegate void ObservableStaticCreateParam1Delegate__<T> (Observer<T> observer);
	[External]
	public delegate IDisposable ObservableStaticCreateWithDisposableParam1Delegate<T> (Observer<T> observer);
	[External]
	public delegate Observable<T> ObservableStaticDeferParam1Delegate<T> ();
	[External]
	public delegate IPromise<T> ObservableStaticDeferParam1Delegate_<T> ();
	[External]
	public delegate TResult ObservableStaticFromParam2Delegate<T, TResult> (T value, number index);
	[External]
	public delegate T ObservableStaticFromParam2Delegate<T> (T value, number index);
	[External]
	public class ObservableStaticArrayInterface
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern number Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern T this [number index] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ObservableStaticArrayInterface ();
#pragma warning restore CS0824
	}
	[External]
	public delegate TResult ObservableStaticFromParam2Delegate_<T, TResult> (T value, number index);
	[External]
	public delegate T ObservableStaticFromParam2Delegate_<T> (T value, number index);
	[External]
	public delegate T ObservableStaticFromParam2Delegate__<T> (any value, number index);
	[External]
	public delegate boolean ObservableStaticGenerateParam2Delegate<TState, TResult> (TState state);
	[External]
	public delegate TState ObservableStaticGenerateParam3Delegate<TState, TResult> (TState state);
	[External]
	public delegate TResult ObservableStaticGenerateParam4Delegate<TState, TResult> (TState state);
	[External]
	public delegate TResult ObservableStaticCombineLatestParam3Delegate<T, T2, TResult> (T v1, T2 v2);
	[External]
	public delegate TResult ObservableStaticCombineLatestParam4Delegate<T, T2, T3, TResult> (T v1, T2 v2, T3 v3);
	[External]
	public delegate TResult ObservableStaticCombineLatestParam5Delegate<T, T2, T3, T4, TResult> (T v1, T2 v2, T3 v3, T4 v4);
	[External]
	public delegate TResult ObservableStaticCombineLatestParam6Delegate<T, T2, T3, T4, T5, TResult> (T v1, T2 v2, T3 v3, T4 v4, T5 v5);
	[External]
	public delegate object ObservableStaticCombineLatestParam1Delegate<T> (IPromise<T> Observable<T>);
	[External]
	public delegate object ObservableStaticCombineLatestParam1Delegate<TOther, TResult> (IPromise<TOther> Observable<TOther>);
	[External]
	public delegate TResult ObservableStaticCombineLatestParam2Delegate<TOther, TResult> (params TOther[] otherValues);
	[External]
	public delegate TResult ObservableStaticWithLatestFromParam3Delegate<T, T2, TResult> (T v1, T2 v2);
	[External]
	public delegate TResult ObservableStaticWithLatestFromParam4Delegate<T, T2, T3, TResult> (T v1, T2 v2, T3 v3);
	[External]
	public delegate TResult ObservableStaticWithLatestFromParam5Delegate<T, T2, T3, T4, TResult> (T v1, T2 v2, T3 v3, T4 v4);
	[External]
	public delegate TResult ObservableStaticWithLatestFromParam6Delegate<T, T2, T3, T4, T5, TResult> (T v1, T2 v2, T3 v3, T4 v4, T5 v5);
	[External]
	public delegate object ObservableStaticWithLatestFromParam1Delegate<TOther, TResult> (IPromise<TOther> Observable<TOther>);
	[External]
	public delegate TResult ObservableStaticWithLatestFromParam2Delegate<TOther, TResult> (params TOther[] otherValues);
	[External]
	public class ObservableStaticObjInterface
	{
#pragma warning disable CS0626
		public extern T this [string key] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ObservableStaticObjInterface ();
#pragma warning restore CS0824
	}
	[External]
	public delegate object ObservableStaticZipParam2Delegate<T1, T2, TResult> (IPromise<T2> Observable<T2>);
	[External]
	public delegate TResult ObservableStaticZipParam3Delegate<T1, T2, TResult> (T1 item1, params T2[] right);
	[External]
	public delegate TResult ObservableStaticZipParam3Delegate_<T1, T2, TResult> (T1 item1, T2 item2);
	[External]
	public delegate TResult ObservableStaticZipParam4Delegate<T1, T2, T3, TResult> (T1 item1, T2 item2, T3 item3);
	[External]
	public delegate TResult ObservableStaticZipParam5Delegate<T1, T2, T3, T4, TResult> (T1 item1, T2 item2, T3 item3, T4 item4);
	[External]
	public delegate TResult ObservableStaticZipParam6Delegate<T1, T2, T3, T4, T5, TResult> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);
	[External]
	public delegate object ObservableStaticZipArrayParam1Delegate<T> (IPromise<T> Observable<T>);
	[External]
	public delegate object ObservableStaticZipArrayParam1Delegate_<T> (IPromise<T> Observable<T>);
	[ObjectLiteral]
	public class JSONObservableStatic : ObservableStatic
	{
#pragma warning disable CS0626
		public extern Observable<[T1, T2]>  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern any Prototype { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> createDelegate<T> (ObservableStaticCreateParam1Delegate<T> subscribe);

#pragma warning disable CS0626
		public extern Observable<T> Create<T> (ObservableStaticCreateParam1Delegate<T> subscribe);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern createDelegate<T> create<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> createWithDisposableDelegate<T> (ObservableStaticCreateWithDisposableParam1Delegate<T> subscribe);

#pragma warning disable CS0626
		public extern Observable<T> CreateWithDisposable<T> (ObservableStaticCreateWithDisposableParam1Delegate<T> subscribe);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern createWithDisposableDelegate<T> createWithDisposable<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> deferDelegate<T> (ObservableStaticDeferParam1Delegate<T> observableFactory);

#pragma warning disable CS0626
		public extern Observable<T> Defer<T> (ObservableStaticDeferParam1Delegate<T> observableFactory);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern deferDelegate<T> defer<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> emptyDelegate<T> (IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Empty<T> (IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern emptyDelegate<T> empty<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> fromDelegate<T, TResult> (T[] array, ObservableStaticFromParam2Delegate<T, TResult> mapFn, any thisArg = default(any), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<TResult> From<T, TResult> (T[] array, ObservableStaticFromParam2Delegate<T, TResult> mapFn, any thisArg = default(any), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern fromDelegate<T, TResult> from<T, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> fromDelegate<T> (T[] array, ObservableStaticFromParam2Delegate<T> mapFn = default(ObservableStaticFromParam2Delegate<T>), any thisArg = default(any), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> From<T> (T[] array, ObservableStaticFromParam2Delegate<T> mapFn = default(ObservableStaticFromParam2Delegate<T>), any thisArg = default(any), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern fromDelegate<T> from<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> fromArrayDelegate<T> (T[] array, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> FromArray<T> (T[] array, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern fromArrayDelegate<T> fromArray<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> generateDelegate<TState, TResult> (TState initialState, ObservableStaticGenerateParam2Delegate<TState, TResult> condition, ObservableStaticGenerateParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateParam4Delegate<TState, TResult> resultSelector, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<TResult> Generate<TState, TResult> (TState initialState, ObservableStaticGenerateParam2Delegate<TState, TResult> condition, ObservableStaticGenerateParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateParam4Delegate<TState, TResult> resultSelector, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern generateDelegate<TState, TResult> generate<TState, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> neverDelegate<T> ();

#pragma warning disable CS0626
		public extern Observable<T> Never<T> ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern neverDelegate<T> never<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> ofDelegate<T> (params T[] values);

#pragma warning disable CS0626
		public extern Observable<T> Of<T> (params T[] values);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ofDelegate<T> of<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> ofWithSchedulerDelegate<T> (IScheduler scheduler = default(IScheduler), params T[] values);

#pragma warning disable CS0626
		public extern Observable<T> OfWithScheduler<T> (IScheduler scheduler = default(IScheduler), params T[] values);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ofWithSchedulerDelegate<T> ofWithScheduler<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<number> rangeDelegate (number start, number count, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<number> Range (number start, number count, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern rangeDelegate range { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> repeatDelegate<T> (T value, number repeatCount = default(number), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Repeat<T> (T value, number repeatCount = default(number), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern repeatDelegate<T> repeat<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> returnDelegate<T> (T value, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Return<T> (T value, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern returnDelegate<T> return<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> justDelegate<T> (T value, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Just<T> (T value, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern justDelegate<T> just<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> returnValueDelegate<T> (T value, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> ReturnValue<T> (T value, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern returnValueDelegate<T> returnValue<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> throwDelegate<T> (Error exception, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Throw<T> (Error exception, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern throwDelegate<T> throw<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> throwExceptionDelegate<T> (Error exception, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> ThrowException<T> (Error exception, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern throwExceptionDelegate<T> throwException<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> throwErrorDelegate<T> (Error error, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> ThrowError<T> (Error error, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern throwErrorDelegate<T> throwError<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> catchDelegate<T> (Any<IPromise<T>[], Observable<T>[]> sources);

#pragma warning disable CS0626
		public extern Observable<T> Catch<T> (Any<IPromise<T>[], Observable<T>[]> sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchDelegate<T> catch<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> catchExceptionDelegate<T> (Any<IPromise<T>[], Observable<T>[]> sources);

#pragma warning disable CS0626
		public extern Observable<T> CatchException<T> (Any<IPromise<T>[], Observable<T>[]> sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchExceptionDelegate<T> catchException<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> catchErrorDelegate<T> (Any<IPromise<T>[], Observable<T>[]> sources);

#pragma warning disable CS0626
		public extern Observable<T> CatchError<T> (Any<IPromise<T>[], Observable<T>[]> sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern catchErrorDelegate<T> catchError<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2]> combineLatestDelegate<T, T2> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second);

#pragma warning disable CS0626
		public extern Observable<[T, T2]> CombineLatest<T, T2> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T, T2> combineLatest<T, T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T, T2, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, ObservableStaticCombineLatestParam3Delegate<T, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T, T2, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, ObservableStaticCombineLatestParam3Delegate<T, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T, T2, TResult> combineLatest<T, T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3]> combineLatestDelegate<T, T2, T3> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3]> CombineLatest<T, T2, T3> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T, T2, T3> combineLatest<T, T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T, T2, T3, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableStaticCombineLatestParam4Delegate<T, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T, T2, T3, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableStaticCombineLatestParam4Delegate<T, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T, T2, T3, TResult> combineLatest<T, T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4]> combineLatestDelegate<T, T2, T3, T4> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4]> CombineLatest<T, T2, T3, T4> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T, T2, T3, T4> combineLatest<T, T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T, T2, T3, T4, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableStaticCombineLatestParam5Delegate<T, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T, T2, T3, T4, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableStaticCombineLatestParam5Delegate<T, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T, T2, T3, T4, TResult> combineLatest<T, T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4, T5]> combineLatestDelegate<T, T2, T3, T4, T5> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4, T5]> CombineLatest<T, T2, T3, T4, T5> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T, T2, T3, T4, T5> combineLatest<T, T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<T, T2, T3, T4, T5, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableStaticCombineLatestParam6Delegate<T, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<T, T2, T3, T4, T5, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableStaticCombineLatestParam6Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T, T2, T3, T4, T5, TResult> combineLatest<T, T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> combineLatestDelegate<T> (ObservableStaticCombineLatestParam1Delegate<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T[]> CombineLatest<T> (ObservableStaticCombineLatestParam1Delegate<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<T> combineLatest<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> combineLatestDelegate<TOther, TResult> (ObservableStaticCombineLatestParam1Delegate<TOther, TResult>[] sources, ObservableStaticCombineLatestParam2Delegate<TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> CombineLatest<TOther, TResult> (ObservableStaticCombineLatestParam1Delegate<TOther, TResult>[] sources, ObservableStaticCombineLatestParam2Delegate<TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern combineLatestDelegate<TOther, TResult> combineLatest<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2]> withLatestFromDelegate<T, T2> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second);

#pragma warning disable CS0626
		public extern Observable<[T, T2]> WithLatestFrom<T, T2> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T, T2> withLatestFrom<T, T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T, T2, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, ObservableStaticWithLatestFromParam3Delegate<T, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T, T2, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, ObservableStaticWithLatestFromParam3Delegate<T, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T, T2, TResult> withLatestFrom<T, T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3]> withLatestFromDelegate<T, T2, T3> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3]> WithLatestFrom<T, T2, T3> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T, T2, T3> withLatestFrom<T, T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T, T2, T3, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableStaticWithLatestFromParam4Delegate<T, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T, T2, T3, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableStaticWithLatestFromParam4Delegate<T, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T, T2, T3, TResult> withLatestFrom<T, T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4]> withLatestFromDelegate<T, T2, T3, T4> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4]> WithLatestFrom<T, T2, T3, T4> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T, T2, T3, T4> withLatestFrom<T, T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T, T2, T3, T4, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableStaticWithLatestFromParam5Delegate<T, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T, T2, T3, T4, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableStaticWithLatestFromParam5Delegate<T, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T, T2, T3, T4, TResult> withLatestFrom<T, T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T, T2, T3, T4, T5]> withLatestFromDelegate<T, T2, T3, T4, T5> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);

#pragma warning disable CS0626
		public extern Observable<[T, T2, T3, T4, T5]> WithLatestFrom<T, T2, T3, T4, T5> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T, T2, T3, T4, T5> withLatestFrom<T, T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<T, T2, T3, T4, T5, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableStaticWithLatestFromParam6Delegate<T, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<T, T2, T3, T4, T5, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableStaticWithLatestFromParam6Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<T, T2, T3, T4, T5, TResult> withLatestFrom<T, T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> withLatestFromDelegate<TOther, TResult> (ObservableStaticWithLatestFromParam1Delegate<TOther, TResult>[] souces, ObservableStaticWithLatestFromParam2Delegate<TOther, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> WithLatestFrom<TOther, TResult> (ObservableStaticWithLatestFromParam1Delegate<TOther, TResult>[] souces, ObservableStaticWithLatestFromParam2Delegate<TOther, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern withLatestFromDelegate<TOther, TResult> withLatestFrom<TOther, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> concatDelegate<T> (params Observable<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T> Concat<T> (params Observable<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern concatDelegate<T> concat<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> mergeDelegate<T> (params Observable<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T> Merge<T> (params Observable<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern mergeDelegate<T> merge<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[string, T]> pairsDelegate<T> (ObservableStaticObjInterface obj, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<[string, T]> Pairs<T> (ObservableStaticObjInterface obj, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pairsDelegate<T> pairs<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate object zipDelegate<T1, T2> (Any<Observable<T1>, IPromise<T1>> first, Any<Observable<T2>, IPromise<T2>, > sources);

#pragma warning disable CS0626
		public extern object Zip<T1, T2> (Any<Observable<T1>, IPromise<T1>> first, Any<Observable<T2>, IPromise<T2>, > sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T1, T2> zip<T1, T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T1, T2, TResult> (Any<Observable<T1>, IPromise<T1>> first, ObservableStaticZipParam2Delegate<T1, T2, TResult>[] sources, ObservableStaticZipParam3Delegate<T1, T2, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T1, T2, TResult> (Any<Observable<T1>, IPromise<T1>> first, ObservableStaticZipParam2Delegate<T1, T2, TResult>[] sources, ObservableStaticZipParam3Delegate<T1, T2, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T1, T2, TResult> zip<T1, T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T1, T2, T3]> zipDelegate<T1, T2, T3> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3);

#pragma warning disable CS0626
		public extern Observable<[T1, T2, T3]> Zip<T1, T2, T3> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T1, T2, T3> zip<T1, T2, T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T1, T2, T3, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, ObservableStaticZipParam4Delegate<T1, T2, T3, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T1, T2, T3, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, ObservableStaticZipParam4Delegate<T1, T2, T3, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T1, T2, T3, TResult> zip<T1, T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T1, T2, T3, T4]> zipDelegate<T1, T2, T3, T4> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4);

#pragma warning disable CS0626
		public extern Observable<[T1, T2, T3, T4]> Zip<T1, T2, T3, T4> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T1, T2, T3, T4> zip<T1, T2, T3, T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T1, T2, T3, T4, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, ObservableStaticZipParam5Delegate<T1, T2, T3, T4, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T1, T2, T3, T4, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, ObservableStaticZipParam5Delegate<T1, T2, T3, T4, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T1, T2, T3, T4, TResult> zip<T1, T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<[T1, T2, T3, T4, T5]> zipDelegate<T1, T2, T3, T4, T5> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, Any<Observable<T5>, IPromise<T5>> source5);

#pragma warning disable CS0626
		public extern Observable<[T1, T2, T3, T4, T5]> Zip<T1, T2, T3, T4, T5> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, Any<Observable<T5>, IPromise<T5>> source5);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T1, T2, T3, T4, T5> zip<T1, T2, T3, T4, T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> zipDelegate<T1, T2, T3, T4, T5, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, Any<Observable<T5>, IPromise<T5>> source5, ObservableStaticZipParam6Delegate<T1, T2, T3, T4, T5, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Zip<T1, T2, T3, T4, T5, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, Any<Observable<T5>, IPromise<T5>> source5, ObservableStaticZipParam6Delegate<T1, T2, T3, T4, T5, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipDelegate<T1, T2, T3, T4, T5, TResult> zip<T1, T2, T3, T4, T5, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> zipArrayDelegate<T> (params ObservableStaticZipArrayParam1Delegate<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T[]> ZipArray<T> (params ObservableStaticZipArrayParam1Delegate<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern zipArrayDelegate<T> zipArray<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> fromPromiseDelegate<T> (IPromise<T> promise);

#pragma warning disable CS0626
		public extern Observable<T> FromPromise<T> (IPromise<T> promise);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern fromPromiseDelegate<T> fromPromise<T> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObservableStatic
	{
		[FieldProperty]
		Observable<[T1, T2]>  { get; set; }
		[FieldProperty]
		any Prototype { get; set; }
		Observable<T> Create<T> (ObservableStaticCreateParam1Delegate<T> subscribe);
		object Create<T> (ObservableStaticCreateParam1Delegate_<T> subscribe);
		Observable<T> Create<T> (ObservableStaticCreateParam1Delegate__<T> subscribe);
		Observable<T> CreateWithDisposable<T> (ObservableStaticCreateWithDisposableParam1Delegate<T> subscribe);
		Observable<T> Defer<T> (ObservableStaticDeferParam1Delegate<T> observableFactory);
		Observable<T> Defer<T> (ObservableStaticDeferParam1Delegate_<T> observableFactory);
		Observable<T> Empty<T> (IScheduler scheduler = default(IScheduler));
		Observable<TResult> From<T, TResult> (T[] array, ObservableStaticFromParam2Delegate<T, TResult> mapFn, any thisArg = default(any), IScheduler scheduler = default(IScheduler));
		Observable<T> From<T> (T[] array, ObservableStaticFromParam2Delegate<T> mapFn = default(ObservableStaticFromParam2Delegate<T>), any thisArg = default(any), IScheduler scheduler = default(IScheduler));
		Observable<TResult> From<T, TResult> (ObservableStaticArrayInterface array, ObservableStaticFromParam2Delegate_<T, TResult> mapFn, any thisArg = default(any), IScheduler scheduler = default(IScheduler));
		Observable<T> From<T> (ObservableStaticArrayInterface array, ObservableStaticFromParam2Delegate_<T> mapFn = default(ObservableStaticFromParam2Delegate_<T>), any thisArg = default(any), IScheduler scheduler = default(IScheduler));
		Observable<T> From<T> (any iterable, ObservableStaticFromParam2Delegate__<T> mapFn = default(ObservableStaticFromParam2Delegate__<T>), any thisArg = default(any), IScheduler scheduler = default(IScheduler));
		Observable<T> FromArray<T> (T[] array, IScheduler scheduler = default(IScheduler));
		Observable<T> FromArray<T> (ObservableStaticArrayInterface array, IScheduler scheduler = default(IScheduler));
		Observable<TResult> Generate<TState, TResult> (TState initialState, ObservableStaticGenerateParam2Delegate<TState, TResult> condition, ObservableStaticGenerateParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateParam4Delegate<TState, TResult> resultSelector, IScheduler scheduler = default(IScheduler));
		Observable<T> Never<T> ();
		Observable<T> Of<T> (params T[] values);
		Observable<T> OfWithScheduler<T> (IScheduler scheduler = default(IScheduler), params T[] values);
		Observable<number> Range (number start, number count, IScheduler scheduler = default(IScheduler));
		Observable<T> Repeat<T> (T value, number repeatCount = default(number), IScheduler scheduler = default(IScheduler));
		Observable<T> Return<T> (T value, IScheduler scheduler = default(IScheduler));
		Observable<T> Just<T> (T value, IScheduler scheduler = default(IScheduler));
		Observable<T> ReturnValue<T> (T value, IScheduler scheduler = default(IScheduler));
		Observable<T> Throw<T> (Error exception, IScheduler scheduler = default(IScheduler));
		Observable<T> ThrowException<T> (Error exception, IScheduler scheduler = default(IScheduler));
		Observable<T> ThrowError<T> (Error error, IScheduler scheduler = default(IScheduler));
		Observable<T> Catch<T> (Any<IPromise<T>[], Observable<T>[]> sources);
		Observable<T> Catch<T> (params Observable<T>[] sources);
		Observable<T> Catch<T> (params IPromise<T>[] sources);
		Observable<T> CatchException<T> (Any<IPromise<T>[], Observable<T>[]> sources);
		Observable<T> CatchException<T> (params Observable<T>[] sources);
		Observable<T> CatchException<T> (params IPromise<T>[] sources);
		Observable<T> CatchError<T> (Any<IPromise<T>[], Observable<T>[]> sources);
		Observable<T> CatchError<T> (params Observable<T>[] sources);
		Observable<T> CatchError<T> (params IPromise<T>[] sources);
		Observable<[T, T2]> CombineLatest<T, T2> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second);
		Observable<TResult> CombineLatest<T, T2, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, ObservableStaticCombineLatestParam3Delegate<T, T2, TResult> resultSelector);
		Observable<[T, T2, T3]> CombineLatest<T, T2, T3> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
		Observable<TResult> CombineLatest<T, T2, T3, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableStaticCombineLatestParam4Delegate<T, T2, T3, TResult> resultSelector);
		Observable<[T, T2, T3, T4]> CombineLatest<T, T2, T3, T4> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
		Observable<TResult> CombineLatest<T, T2, T3, T4, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableStaticCombineLatestParam5Delegate<T, T2, T3, T4, TResult> resultSelector);
		Observable<[T, T2, T3, T4, T5]> CombineLatest<T, T2, T3, T4, T5> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
		Observable<TResult> CombineLatest<T, T2, T3, T4, T5, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableStaticCombineLatestParam6Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
		Observable<T[]> CombineLatest<T> (ObservableStaticCombineLatestParam1Delegate<T>[] sources);
		Observable<TResult> CombineLatest<TOther, TResult> (ObservableStaticCombineLatestParam1Delegate<TOther, TResult>[] sources, ObservableStaticCombineLatestParam2Delegate<TOther, TResult> resultSelector);
		Observable<[T, T2]> WithLatestFrom<T, T2> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second);
		Observable<TResult> WithLatestFrom<T, T2, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, ObservableStaticWithLatestFromParam3Delegate<T, T2, TResult> resultSelector);
		Observable<[T, T2, T3]> WithLatestFrom<T, T2, T3> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third);
		Observable<TResult> WithLatestFrom<T, T2, T3, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, ObservableStaticWithLatestFromParam4Delegate<T, T2, T3, TResult> resultSelector);
		Observable<[T, T2, T3, T4]> WithLatestFrom<T, T2, T3, T4> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth);
		Observable<TResult> WithLatestFrom<T, T2, T3, T4, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, ObservableStaticWithLatestFromParam5Delegate<T, T2, T3, T4, TResult> resultSelector);
		Observable<[T, T2, T3, T4, T5]> WithLatestFrom<T, T2, T3, T4, T5> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth);
		Observable<TResult> WithLatestFrom<T, T2, T3, T4, T5, TResult> (Any<Observable<T>, IPromise<T>> first, Any<Observable<T2>, IPromise<T2>> second, Any<Observable<T3>, IPromise<T3>> third, Any<Observable<T4>, IPromise<T4>> fourth, Any<Observable<T5>, IPromise<T5>> fifth, ObservableStaticWithLatestFromParam6Delegate<T, T2, T3, T4, T5, TResult> resultSelector);
		Observable<TResult> WithLatestFrom<TOther, TResult> (ObservableStaticWithLatestFromParam1Delegate<TOther, TResult>[] souces, ObservableStaticWithLatestFromParam2Delegate<TOther, TResult> resultSelector);
		Observable<T> Concat<T> (params Observable<T>[] sources);
		Observable<T> Concat<T> (params IPromise<T>[] sources);
		Observable<T> Concat<T> (Any<IPromise<T>[], Observable<T>[]> sources);
		Observable<T> Merge<T> (params Observable<T>[] sources);
		Observable<T> Merge<T> (params IPromise<T>[] sources);
		Observable<T> Merge<T> (Any<IPromise<T>[], Observable<T>[]> sources);
		Observable<T> Merge<T> (IScheduler scheduler, params Observable<T>[] sources);
		Observable<T> Merge<T> (IScheduler scheduler, params IPromise<T>[] sources);
		Observable<T> Merge<T> (IScheduler scheduler, Any<IPromise<T>[], Observable<T>[]> sources);
		Observable<[string, T]> Pairs<T> (ObservableStaticObjInterface obj, IScheduler scheduler = default(IScheduler));
		object Zip<T1, T2> (Any<Observable<T1>, IPromise<T1>> first, Any<Observable<T2>, IPromise<T2>, > sources);
		Observable<TResult> Zip<T1, T2, TResult> (Any<Observable<T1>, IPromise<T1>> first, ObservableStaticZipParam2Delegate<T1, T2, TResult>[] sources, ObservableStaticZipParam3Delegate<T1, T2, TResult> resultSelector);
		Observable<TResult> Zip<T1, T2, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, ObservableStaticZipParam3Delegate_<T1, T2, TResult> resultSelector);
		Observable<[T1, T2, T3]> Zip<T1, T2, T3> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3);
		Observable<TResult> Zip<T1, T2, T3, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, ObservableStaticZipParam4Delegate<T1, T2, T3, TResult> resultSelector);
		Observable<[T1, T2, T3, T4]> Zip<T1, T2, T3, T4> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4);
		Observable<TResult> Zip<T1, T2, T3, T4, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, ObservableStaticZipParam5Delegate<T1, T2, T3, T4, TResult> resultSelector);
		Observable<[T1, T2, T3, T4, T5]> Zip<T1, T2, T3, T4, T5> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, Any<Observable<T5>, IPromise<T5>> source5);
		Observable<TResult> Zip<T1, T2, T3, T4, T5, TResult> (Any<Observable<T1>, IPromise<T1>> source1, Any<Observable<T2>, IPromise<T2>> source2, Any<Observable<T3>, IPromise<T3>> source3, Any<Observable<T4>, IPromise<T4>> source4, Any<Observable<T5>, IPromise<T5>> source5, ObservableStaticZipParam6Delegate<T1, T2, T3, T4, T5, TResult> resultSelector);
		Observable<T[]> ZipArray<T> (params ObservableStaticZipArrayParam1Delegate<T>[] sources);
		Observable<T[]> ZipArray<T> (ObservableStaticZipArrayParam1Delegate_<T>[] sources);
		Observable<T> FromPromise<T> (IPromise<T> promise);
	}

}
	[External]
	public static class Rx.config
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern static boolean UseNativeEvents { get; set; }
#pragma warning restore CS0626
	}
namespace Rx
{
	[External]
	public class ObservableStaticFromCallbackInterface
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern GlobalClassDelegate  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern GlobalClassDelegate_  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern GlobalClassDelegate__  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern GlobalClassDelegate___  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object <TResult> (GlobalClass<TResult>Param1Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object <T1, TResult> (GlobalClass<T1, TResult>Param1Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object <T1, T2, TResult> (GlobalClass<T1, T2, TResult>Param1Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object <T1, T2, T3, TResult> (GlobalClass<T1, T2, T3, TResult>Param1Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<TCallbackResult, TResult>Delegate <TCallbackResult, TResult> (GlobalClass<TCallbackResult, TResult>Param1Delegate func, any context, GlobalClass<TCallbackResult, TResult>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, TCallbackResult, TResult>Delegate <T1, TCallbackResult, TResult> (GlobalClass<T1, TCallbackResult, TResult>Param1Delegate func, any context, GlobalClass<T1, TCallbackResult, TResult>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, T2, TCallbackResult, TResult>Delegate <T1, T2, TCallbackResult, TResult> (GlobalClass<T1, T2, TCallbackResult, TResult>Param1Delegate func, any context, GlobalClass<T1, T2, TCallbackResult, TResult>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, T2, T3, TCallbackResult, TResult>Delegate <T1, T2, T3, TCallbackResult, TResult> (GlobalClass<T1, T2, T3, TCallbackResult, TResult>Param1Delegate func, any context, GlobalClass<T1, T2, T3, TCallbackResult, TResult>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<TResult>Delegate <TResult> (GlobalClass_<TResult>Param1Delegate func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, TResult>Delegate <T1, TResult> (GlobalClass_<T1, TResult>Param1Delegate func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, T2, TResult>Delegate <T1, T2, TResult> (GlobalClass_<T1, T2, TResult>Param1Delegate func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, T2, T3, TResult>Delegate <T1, T2, T3, TResult> (GlobalClass_<T1, T2, T3, TResult>Param1Delegate func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass_<TCallbackResult, TResult>Delegate <TCallbackResult, TResult> (Function func, any context, GlobalClass_<TCallbackResult, TResult>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass_<TResult>Delegate <TResult> (Function func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ObservableStaticFromCallbackInterface ();
#pragma warning restore CS0824
	}
	[External]
	public class ObservableStaticFromNodeCallbackInterface
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern GlobalClassDelegate  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern GlobalClassDelegate_  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern GlobalClassDelegate__  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern GlobalClassDelegate___  { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object <T> (GlobalClass<T>Param1Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object <T1, T> (GlobalClass<T1, T>Param1Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object <T1, T2, T> (GlobalClass<T1, T2, T>Param1Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object <T1, T2, T3, T> (GlobalClass<T1, T2, T3, T>Param1Delegate func);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<TC, TR>Delegate <TC, TR> (GlobalClass<TC, TR>Param1Delegate func, any context, GlobalClass<TC, TR>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, TC, TR>Delegate <T1, TC, TR> (GlobalClass<T1, TC, TR>Param1Delegate func, any context, GlobalClass<T1, TC, TR>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, T2, TC, TR>Delegate <T1, T2, TC, TR> (GlobalClass<T1, T2, TC, TR>Param1Delegate func, any context, GlobalClass<T1, T2, TC, TR>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, T2, T3, TC, TR>Delegate <T1, T2, T3, TC, TR> (GlobalClass<T1, T2, T3, TC, TR>Param1Delegate func, any context, GlobalClass<T1, T2, T3, TC, TR>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<TR>Delegate <TR> (GlobalClass<TR>Param1Delegate func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, TR>Delegate <T1, TR> (GlobalClass<T1, TR>Param1Delegate func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, T2, TR>Delegate <T1, T2, TR> (GlobalClass<T1, T2, TR>Param1Delegate func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T1, T2, T3, TR>Delegate <T1, T2, T3, TR> (GlobalClass<T1, T2, T3, TR>Param1Delegate func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<TC, T>Delegate <TC, T> (Function func, any context, GlobalClass<TC, T>Param3Delegate selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GlobalClass<T>Delegate <T> (Function func, any context = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ObservableStaticFromNodeCallbackInterface ();
#pragma warning restore CS0824
	}
	[External]
	public delegate T ObservableStaticFromEventParam3Delegate<T> (params any[] args);
	[External]
	public delegate void ObservableStaticFromEventPatternParam1Delegate<T> (Function handler);
	[External]
	public delegate void ObservableStaticFromEventPatternParam2Delegate<T> (Function handler);
	[External]
	public delegate T ObservableStaticFromEventPatternParam3Delegate<T> (params any[] args);
	[ObjectLiteral]
	public class JSONObservableStatic : ObservableStatic
	{
#pragma warning disable CS0626
		public extern ObservableStaticFromCallbackInterface FromCallback { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ObservableStaticFromNodeCallbackInterface FromNodeCallback { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> fromEventDelegate<T> (Any<ArrayLike<DOMEventTarget>, DOMEventTarget, NodeEventTarget, NativeEventTarget> element, string eventName, ObservableStaticFromEventParam3Delegate<T> selector = default(ObservableStaticFromEventParam3Delegate<T>));

#pragma warning disable CS0626
		public extern Observable<T> FromEvent<T> (Any<ArrayLike<DOMEventTarget>, DOMEventTarget, NodeEventTarget, NativeEventTarget> element, string eventName, ObservableStaticFromEventParam3Delegate<T> selector = default(ObservableStaticFromEventParam3Delegate<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern fromEventDelegate<T> fromEvent<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> fromEventPatternDelegate<T> (ObservableStaticFromEventPatternParam1Delegate<T> addHandler, ObservableStaticFromEventPatternParam2Delegate<T> removeHandler, ObservableStaticFromEventPatternParam3Delegate<T> selector = default(ObservableStaticFromEventPatternParam3Delegate<T>));

#pragma warning disable CS0626
		public extern Observable<T> FromEventPattern<T> (ObservableStaticFromEventPatternParam1Delegate<T> addHandler, ObservableStaticFromEventPatternParam2Delegate<T> removeHandler, ObservableStaticFromEventPatternParam3Delegate<T> selector = default(ObservableStaticFromEventPatternParam3Delegate<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern fromEventPatternDelegate<T> fromEventPattern<T> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObservableStatic
	{
		[FieldProperty]
		ObservableStaticFromCallbackInterface FromCallback { get; set; }
		[FieldProperty]
		ObservableStaticFromNodeCallbackInterface FromNodeCallback { get; set; }
		Observable<T> FromEvent<T> (Any<ArrayLike<DOMEventTarget>, DOMEventTarget, NodeEventTarget, NativeEventTarget> element, string eventName, ObservableStaticFromEventParam3Delegate<T> selector = default(ObservableStaticFromEventParam3Delegate<T>));
		Observable<T> FromEventPattern<T> (ObservableStaticFromEventPatternParam1Delegate<T> addHandler, ObservableStaticFromEventPatternParam2Delegate<T> removeHandler, ObservableStaticFromEventPatternParam3Delegate<T> selector = default(ObservableStaticFromEventPatternParam3Delegate<T>));
	}
	[External]
	public delegate any NodeEventTargetAddListenerDelegate (string name,  cb, any e);
	[ObjectLiteral]
	public class JSONNodeEventTarget : NodeEventTarget
	{
#pragma warning disable CS0626
		public extern NodeEventTargetAddListenerDelegate AddListener { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface NodeEventTarget
	{
		[FieldProperty]
		NodeEventTargetAddListenerDelegate AddListener { get; set; }
	}
	[External]
	public delegate any NativeEventTargetOnDelegate (string name,  cb, any e);
	[External]
	public delegate any NativeEventTargetOffDelegate (string name,  cb, any e);
	[ObjectLiteral]
	public class JSONNativeEventTarget : NativeEventTarget
	{
#pragma warning disable CS0626
		public extern NativeEventTargetOnDelegate On { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern NativeEventTargetOffDelegate Off { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface NativeEventTarget
	{
		[FieldProperty]
		NativeEventTargetOnDelegate On { get; set; }
		[FieldProperty]
		NativeEventTargetOffDelegate Off { get; set; }
	}
	[External]
	public delegate any DOMEventTargetAddEventListenerParam2Delegate (any e);
	[External]
	public delegate any DOMEventTargetRemoveEventListenerParam2Delegate (any e);
	[ObjectLiteral]
	public class JSONDOMEventTarget : DOMEventTarget
	{
	[External]
	public delegate void addEventListenerDelegate (string type, DOMEventTargetAddEventListenerParam2Delegate listener, boolean useCapture);

#pragma warning disable CS0626
		public extern void AddEventListener (string type, DOMEventTargetAddEventListenerParam2Delegate listener, boolean useCapture);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern addEventListenerDelegate addEventListener { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void removeEventListenerDelegate (string type, DOMEventTargetRemoveEventListenerParam2Delegate listener, boolean useCapture);

#pragma warning disable CS0626
		public extern void RemoveEventListener (string type, DOMEventTargetRemoveEventListenerParam2Delegate listener, boolean useCapture);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern removeEventListenerDelegate removeEventListener { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface DOMEventTarget
	{
		void AddEventListener (string type, DOMEventTargetAddEventListenerParam2Delegate listener, boolean useCapture);
		void RemoveEventListener (string type, DOMEventTargetRemoveEventListenerParam2Delegate listener, boolean useCapture);
	}

}
namespace Rx
{
	[ObjectLiteral]
	public class JSONTimeInterval<T> : TimeInterval<T>
	{
#pragma warning disable CS0626
		public extern T Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern number Interval { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface TimeInterval<T>
	{
		[FieldProperty]
		T Value { get; set; }
		[FieldProperty]
		number Interval { get; set; }
	}
	[ObjectLiteral]
	public class JSONTimestamp<T> : Timestamp<T>
	{
#pragma warning disable CS0626
		public extern T Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern number Timestamp { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Timestamp<T>
	{
		[FieldProperty]
		T Value { get; set; }
		[FieldProperty]
		number Timestamp { get; set; }
	}
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate Observable<T> delayDelegate (Date dueTime, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Delay (Date dueTime, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern delayDelegate delay { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> debounceDelegate (number dueTime, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Debounce (number dueTime, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern debounceDelegate debounce { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> throttleWithTimeoutDelegate (number dueTime, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> ThrottleWithTimeout (number dueTime, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern throttleWithTimeoutDelegate throttleWithTimeout { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> throttleDelegate (number dueTime, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Throttle (number dueTime, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern throttleDelegate throttle { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TimeInterval<T>> timeIntervalDelegate (IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<TimeInterval<T>> TimeInterval (IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern timeIntervalDelegate timeInterval { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Timestamp<T>> timestampDelegate (IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<Timestamp<T>> Timestamp (IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern timestampDelegate timestamp { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> sampleDelegate (number interval, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Sample (number interval, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern sampleDelegate sample { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> sampleDelegate<TSample> (Observable<TSample> sampler, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Sample<TSample> (Observable<TSample> sampler, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern sampleDelegate<TSample> sample<TSample> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> timeoutDelegate (Date dueTime, Observable<T> other = default(Observable<T>), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Timeout (Date dueTime, Observable<T> other = default(Observable<T>), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern timeoutDelegate timeout { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		Observable<T> Delay (Date dueTime, IScheduler scheduler = default(IScheduler));
		Observable<T> Delay (number dueTime, IScheduler scheduler = default(IScheduler));
		Observable<T> Debounce (number dueTime, IScheduler scheduler = default(IScheduler));
		Observable<T> ThrottleWithTimeout (number dueTime, IScheduler scheduler = default(IScheduler));
		Observable<T> Throttle (number dueTime, IScheduler scheduler = default(IScheduler));
		Observable<TimeInterval<T>> TimeInterval (IScheduler scheduler = default(IScheduler));
		Observable<Timestamp<T>> Timestamp (IScheduler scheduler = default(IScheduler));
		Observable<T> Sample (number interval, IScheduler scheduler = default(IScheduler));
		Observable<T> Sample<TSample> (Observable<TSample> sampler, IScheduler scheduler = default(IScheduler));
		Observable<T> Timeout (Date dueTime, Observable<T> other = default(Observable<T>), IScheduler scheduler = default(IScheduler));
		Observable<T> Timeout (number dueTime, Observable<T> other = default(Observable<T>), IScheduler scheduler = default(IScheduler));
	}
	[ObjectLiteral]
	public class JSONObservableStatic : ObservableStatic
	{
	[External]
	public delegate Observable<number> intervalDelegate (number period, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<number> Interval (number period, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern intervalDelegate interval { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<number> timerDelegate (number dueTime, number period, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<number> Timer (number dueTime, number period, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern timerDelegate timer { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObservableStatic
	{
		Observable<number> Interval (number period, IScheduler scheduler = default(IScheduler));
		Observable<number> Interval (number dutTime, number period, IScheduler scheduler = default(IScheduler));
		Observable<number> Timer (number dueTime, number period, IScheduler scheduler = default(IScheduler));
		Observable<number> Timer (number dueTime, IScheduler scheduler = default(IScheduler));
	}

}

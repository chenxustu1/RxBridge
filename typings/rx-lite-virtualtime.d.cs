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
		public extern static GlobalClassHistoricalSchedulerInterface HistoricalScheduler { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public delegate void VirtualTimeSchedulerScheduleAbsoluteParam2Delegate<TAbsolute, TRelative> ();
	[External]
	public delegate IDisposable VirtualTimeSchedulerScheduleAbsoluteWithStateParam3Delegate<TAbsolute, TRelative, TState> (IScheduler scheduler, TState state);
	[External]
	public delegate void VirtualTimeSchedulerScheduleRelativeParam2Delegate<TAbsolute, TRelative> ();
	[External]
	public delegate IDisposable VirtualTimeSchedulerScheduleRelativeWithStateParam3Delegate<TAbsolute, TRelative, TState> (IScheduler scheduler, TState state);
	[ObjectLiteral]
	public class JSONVirtualTimeScheduler<TAbsolute, TRelative> : VirtualTimeScheduler<TAbsolute, TRelative>
	{
#pragma warning disable CS0626
		public extern boolean IsEnabled { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void advanceByDelegate (TRelative time);

#pragma warning disable CS0626
		public extern void AdvanceBy (TRelative time);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern advanceByDelegate advanceBy { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void advanceToDelegate (TAbsolute time);

#pragma warning disable CS0626
		public extern void AdvanceTo (TAbsolute time);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern advanceToDelegate advanceTo { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleAbsoluteDelegate (TAbsolute dueTime, VirtualTimeSchedulerScheduleAbsoluteParam2Delegate<TAbsolute, TRelative> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleAbsolute (TAbsolute dueTime, VirtualTimeSchedulerScheduleAbsoluteParam2Delegate<TAbsolute, TRelative> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleAbsoluteDelegate scheduleAbsolute { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleAbsoluteWithStateDelegate<TState> (TState state, TAbsolute dueTime, VirtualTimeSchedulerScheduleAbsoluteWithStateParam3Delegate<TAbsolute, TRelative, TState> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleAbsoluteWithState<TState> (TState state, TAbsolute dueTime, VirtualTimeSchedulerScheduleAbsoluteWithStateParam3Delegate<TAbsolute, TRelative, TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleAbsoluteWithStateDelegate<TState> scheduleAbsoluteWithState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleRelativeDelegate (TRelative dueTime, VirtualTimeSchedulerScheduleRelativeParam2Delegate<TAbsolute, TRelative> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleRelative (TRelative dueTime, VirtualTimeSchedulerScheduleRelativeParam2Delegate<TAbsolute, TRelative> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRelativeDelegate scheduleRelative { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable scheduleRelativeWithStateDelegate<TState> (TState state, TRelative dueTime, VirtualTimeSchedulerScheduleRelativeWithStateParam3Delegate<TAbsolute, TRelative, TState> action);

#pragma warning disable CS0626
		public extern IDisposable ScheduleRelativeWithState<TState> (TState state, TRelative dueTime, VirtualTimeSchedulerScheduleRelativeWithStateParam3Delegate<TAbsolute, TRelative, TState> action);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern scheduleRelativeWithStateDelegate<TState> scheduleRelativeWithState<TState> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void sleepDelegate (TRelative time);

#pragma warning disable CS0626
		public extern void Sleep (TRelative time);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern sleepDelegate sleep { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate IDisposable startDelegate ();

#pragma warning disable CS0626
		public extern IDisposable Start ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern startDelegate start { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void stopDelegate ();

#pragma warning disable CS0626
		public extern void Stop ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern stopDelegate stop { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate TAbsolute addDelegate (TAbsolute from, TRelative by);

#pragma warning disable CS0626
		public extern TAbsolute Add (TAbsolute from, TRelative by);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern addDelegate add { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate number toDateTimeOffsetDelegate (TAbsolute duetime);

#pragma warning disable CS0626
		public extern number ToDateTimeOffset (TAbsolute duetime);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toDateTimeOffsetDelegate toDateTimeOffset { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate TRelative toRelativeDelegate (number duetime);

#pragma warning disable CS0626
		public extern TRelative ToRelative (number duetime);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toRelativeDelegate toRelative { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate internals.ScheduledItem<TAbsolute> getNextDelegate ();

#pragma warning disable CS0626
		public extern internals.ScheduledItem<TAbsolute> GetNext ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern getNextDelegate getNext { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface VirtualTimeScheduler<TAbsolute, TRelative> : Scheduler
	{
		[FieldProperty]
		boolean IsEnabled { get; set; }
		void AdvanceBy (TRelative time);
		void AdvanceTo (TAbsolute time);
		IDisposable ScheduleAbsolute (TAbsolute dueTime, VirtualTimeSchedulerScheduleAbsoluteParam2Delegate<TAbsolute, TRelative> action);
		IDisposable ScheduleAbsoluteWithState<TState> (TState state, TAbsolute dueTime, VirtualTimeSchedulerScheduleAbsoluteWithStateParam3Delegate<TAbsolute, TRelative, TState> action);
		IDisposable ScheduleRelative (TRelative dueTime, VirtualTimeSchedulerScheduleRelativeParam2Delegate<TAbsolute, TRelative> action);
		IDisposable ScheduleRelativeWithState<TState> (TState state, TRelative dueTime, VirtualTimeSchedulerScheduleRelativeWithStateParam3Delegate<TAbsolute, TRelative, TState> action);
		void Sleep (TRelative time);
		IDisposable Start ();
		void Stop ();
		TAbsolute Add (TAbsolute from, TRelative by);
		number ToDateTimeOffset (TAbsolute duetime);
		TRelative ToRelative (number duetime);
		internals.ScheduledItem<TAbsolute> GetNext ();
	}
	[External]
	public interface HistoricalScheduler : VirtualTimeScheduler<number, number>
	{
	}
	[External]
	public class GlobalClassHistoricalSchedulerInterface
	{
#pragma warning disable CS0626
		public extern HistoricalScheduler New (number initialClock, GlobalClassNewParam2Delegate comparer);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern GlobalClassHistoricalSchedulerInterface ();
#pragma warning restore CS0824
	}

}

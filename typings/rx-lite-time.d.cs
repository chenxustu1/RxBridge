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
	public delegate number ObservableDelayWithSelectorParam1Delegate<T> (T item);
	[External]
	public delegate number ObservableDelayWithSelectorParam2Delegate<T> (T item);
	[External]
	public delegate Observable<TTimeout> ObservableTimeoutWithSelectorParam2Delegate<T, TTimeout> (T item);
	[External]
	public delegate Observable<TTimeout> ObservableDebounceWithSelectorParam1Delegate<T, TTimeout> (T item);
	[External]
	public delegate Observable<TTimeout> ObservableThrottleWithSelectorParam1Delegate<T, TTimeout> (T item);
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate Observable<T> delaySubscriptionDelegate (number dueTime, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> DelaySubscription (number dueTime, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern delaySubscriptionDelegate delaySubscription { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> delayWithSelectorDelegate (ObservableDelayWithSelectorParam1Delegate<T> delayDurationSelector);

#pragma warning disable CS0626
		public extern Observable<T> DelayWithSelector (ObservableDelayWithSelectorParam1Delegate<T> delayDurationSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern delayWithSelectorDelegate delayWithSelector { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> timeoutWithSelectorDelegate<TTimeout> (Observable<TTimeout> firstTimeout, ObservableTimeoutWithSelectorParam2Delegate<T, TTimeout> timeoutdurationSelector = default(ObservableTimeoutWithSelectorParam2Delegate<T, TTimeout>), Observable<T> other = default(Observable<T>));

#pragma warning disable CS0626
		public extern Observable<T> TimeoutWithSelector<TTimeout> (Observable<TTimeout> firstTimeout, ObservableTimeoutWithSelectorParam2Delegate<T, TTimeout> timeoutdurationSelector = default(ObservableTimeoutWithSelectorParam2Delegate<T, TTimeout>), Observable<T> other = default(Observable<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern timeoutWithSelectorDelegate<TTimeout> timeoutWithSelector<TTimeout> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> debounceWithSelectorDelegate<TTimeout> (ObservableDebounceWithSelectorParam1Delegate<T, TTimeout> debounceDurationSelector);

#pragma warning disable CS0626
		public extern Observable<T> DebounceWithSelector<TTimeout> (ObservableDebounceWithSelectorParam1Delegate<T, TTimeout> debounceDurationSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern debounceWithSelectorDelegate<TTimeout> debounceWithSelector<TTimeout> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> throttleWithSelectorDelegate<TTimeout> (ObservableThrottleWithSelectorParam1Delegate<T, TTimeout> debounceDurationSelector);

#pragma warning disable CS0626
		public extern Observable<T> ThrottleWithSelector<TTimeout> (ObservableThrottleWithSelectorParam1Delegate<T, TTimeout> debounceDurationSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern throttleWithSelectorDelegate<TTimeout> throttleWithSelector<TTimeout> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipLastWithTimeDelegate (number duration, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> SkipLastWithTime (number duration, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipLastWithTimeDelegate skipLastWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeLastWithTimeDelegate (number duration, IScheduler timerScheduler = default(IScheduler), IScheduler loopScheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> TakeLastWithTime (number duration, IScheduler timerScheduler = default(IScheduler), IScheduler loopScheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeLastWithTimeDelegate takeLastWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> takeLastBufferWithTimeDelegate (number duration, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T[]> TakeLastBufferWithTime (number duration, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeLastBufferWithTimeDelegate takeLastBufferWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeWithTimeDelegate (number duration, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> TakeWithTime (number duration, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeWithTimeDelegate takeWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipWithTimeDelegate (number duration, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> SkipWithTime (number duration, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipWithTimeDelegate skipWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> skipUntilWithTimeDelegate (Date startTime, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> SkipUntilWithTime (Date startTime, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern skipUntilWithTimeDelegate skipUntilWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> takeUntilWithTimeDelegate (Date endTime, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> TakeUntilWithTime (Date endTime, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern takeUntilWithTimeDelegate takeUntilWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Observable<T>> windowWithTimeDelegate (number timeSpan, number timeShift, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<Observable<T>> WindowWithTime (number timeSpan, number timeShift, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern windowWithTimeDelegate windowWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Observable<T>> windowWithTimeOrCountDelegate (number timeSpan, number count, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<Observable<T>> WindowWithTimeOrCount (number timeSpan, number count, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern windowWithTimeOrCountDelegate windowWithTimeOrCount { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> bufferWithTimeDelegate (number timeSpan, number timeShift, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T[]> BufferWithTime (number timeSpan, number timeShift, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern bufferWithTimeDelegate bufferWithTime { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> bufferWithTimeOrCountDelegate (number timeSpan, number count, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T[]> BufferWithTimeOrCount (number timeSpan, number count, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern bufferWithTimeOrCountDelegate bufferWithTimeOrCount { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		Observable<T> DelaySubscription (number dueTime, IScheduler scheduler = default(IScheduler));
		Observable<T> DelayWithSelector (ObservableDelayWithSelectorParam1Delegate<T> delayDurationSelector);
		Observable<T> DelayWithSelector (number subscriptionDelay, ObservableDelayWithSelectorParam2Delegate<T> delayDurationSelector);
		Observable<T> TimeoutWithSelector<TTimeout> (Observable<TTimeout> firstTimeout, ObservableTimeoutWithSelectorParam2Delegate<T, TTimeout> timeoutdurationSelector = default(ObservableTimeoutWithSelectorParam2Delegate<T, TTimeout>), Observable<T> other = default(Observable<T>));
		Observable<T> DebounceWithSelector<TTimeout> (ObservableDebounceWithSelectorParam1Delegate<T, TTimeout> debounceDurationSelector);
		Observable<T> ThrottleWithSelector<TTimeout> (ObservableThrottleWithSelectorParam1Delegate<T, TTimeout> debounceDurationSelector);
		Observable<T> SkipLastWithTime (number duration, IScheduler scheduler = default(IScheduler));
		Observable<T> TakeLastWithTime (number duration, IScheduler timerScheduler = default(IScheduler), IScheduler loopScheduler = default(IScheduler));
		Observable<T[]> TakeLastBufferWithTime (number duration, IScheduler scheduler = default(IScheduler));
		Observable<T> TakeWithTime (number duration, IScheduler scheduler = default(IScheduler));
		Observable<T> SkipWithTime (number duration, IScheduler scheduler = default(IScheduler));
		Observable<T> SkipUntilWithTime (Date startTime, IScheduler scheduler = default(IScheduler));
		Observable<T> SkipUntilWithTime (number duration, IScheduler scheduler = default(IScheduler));
		Observable<T> TakeUntilWithTime (Date endTime, IScheduler scheduler = default(IScheduler));
		Observable<T> TakeUntilWithTime (number duration, IScheduler scheduler = default(IScheduler));
		Observable<Observable<T>> WindowWithTime (number timeSpan, number timeShift, IScheduler scheduler = default(IScheduler));
		Observable<Observable<T>> WindowWithTime (number timeSpan, IScheduler scheduler = default(IScheduler));
		Observable<Observable<T>> WindowWithTimeOrCount (number timeSpan, number count, IScheduler scheduler = default(IScheduler));
		Observable<T[]> BufferWithTime (number timeSpan, number timeShift, IScheduler scheduler = default(IScheduler));
		Observable<T[]> BufferWithTime (number timeSpan, IScheduler scheduler = default(IScheduler));
		Observable<T[]> BufferWithTimeOrCount (number timeSpan, number count, IScheduler scheduler = default(IScheduler));
	}
	[External]
	public delegate boolean ObservableStaticGenerateWithRelativeTimeParam2Delegate<TState, TResult> (TState state);
	[External]
	public delegate TState ObservableStaticGenerateWithRelativeTimeParam3Delegate<TState, TResult> (TState state);
	[External]
	public delegate TResult ObservableStaticGenerateWithRelativeTimeParam4Delegate<TState, TResult> (TState state);
	[External]
	public delegate number ObservableStaticGenerateWithRelativeTimeParam5Delegate<TState, TResult> (TState state);
	[External]
	public delegate boolean ObservableStaticGenerateWithAbsoluteTimeParam2Delegate<TState, TResult> (TState state);
	[External]
	public delegate TState ObservableStaticGenerateWithAbsoluteTimeParam3Delegate<TState, TResult> (TState state);
	[External]
	public delegate TResult ObservableStaticGenerateWithAbsoluteTimeParam4Delegate<TState, TResult> (TState state);
	[External]
	public delegate Date ObservableStaticGenerateWithAbsoluteTimeParam5Delegate<TState, TResult> (TState state);
	[ObjectLiteral]
	public class JSONObservableStatic : ObservableStatic
	{
	[External]
	public delegate Observable<number> timerDelegate (Date dueTime, number period, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<number> Timer (Date dueTime, number period, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern timerDelegate timer { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> generateWithRelativeTimeDelegate<TState, TResult> (TState initialState, ObservableStaticGenerateWithRelativeTimeParam2Delegate<TState, TResult> condition, ObservableStaticGenerateWithRelativeTimeParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateWithRelativeTimeParam4Delegate<TState, TResult> resultSelector, ObservableStaticGenerateWithRelativeTimeParam5Delegate<TState, TResult> timeSelector, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<TResult> GenerateWithRelativeTime<TState, TResult> (TState initialState, ObservableStaticGenerateWithRelativeTimeParam2Delegate<TState, TResult> condition, ObservableStaticGenerateWithRelativeTimeParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateWithRelativeTimeParam4Delegate<TState, TResult> resultSelector, ObservableStaticGenerateWithRelativeTimeParam5Delegate<TState, TResult> timeSelector, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern generateWithRelativeTimeDelegate<TState, TResult> generateWithRelativeTime<TState, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> generateWithAbsoluteTimeDelegate<TState, TResult> (TState initialState, ObservableStaticGenerateWithAbsoluteTimeParam2Delegate<TState, TResult> condition, ObservableStaticGenerateWithAbsoluteTimeParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateWithAbsoluteTimeParam4Delegate<TState, TResult> resultSelector, ObservableStaticGenerateWithAbsoluteTimeParam5Delegate<TState, TResult> timeSelector, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<TResult> GenerateWithAbsoluteTime<TState, TResult> (TState initialState, ObservableStaticGenerateWithAbsoluteTimeParam2Delegate<TState, TResult> condition, ObservableStaticGenerateWithAbsoluteTimeParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateWithAbsoluteTimeParam4Delegate<TState, TResult> resultSelector, ObservableStaticGenerateWithAbsoluteTimeParam5Delegate<TState, TResult> timeSelector, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern generateWithAbsoluteTimeDelegate<TState, TResult> generateWithAbsoluteTime<TState, TResult> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObservableStatic
	{
		Observable<number> Timer (Date dueTime, number period, IScheduler scheduler = default(IScheduler));
		Observable<number> Timer (Date dueTime, IScheduler scheduler = default(IScheduler));
		Observable<TResult> GenerateWithRelativeTime<TState, TResult> (TState initialState, ObservableStaticGenerateWithRelativeTimeParam2Delegate<TState, TResult> condition, ObservableStaticGenerateWithRelativeTimeParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateWithRelativeTimeParam4Delegate<TState, TResult> resultSelector, ObservableStaticGenerateWithRelativeTimeParam5Delegate<TState, TResult> timeSelector, IScheduler scheduler = default(IScheduler));
		Observable<TResult> GenerateWithAbsoluteTime<TState, TResult> (TState initialState, ObservableStaticGenerateWithAbsoluteTimeParam2Delegate<TState, TResult> condition, ObservableStaticGenerateWithAbsoluteTimeParam3Delegate<TState, TResult> iterate, ObservableStaticGenerateWithAbsoluteTimeParam4Delegate<TState, TResult> resultSelector, ObservableStaticGenerateWithAbsoluteTimeParam5Delegate<TState, TResult> timeSelector, IScheduler scheduler = default(IScheduler));
	}

}

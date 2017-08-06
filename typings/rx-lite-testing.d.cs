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
		public extern static GlobalClassTestSchedulerInterface TestScheduler { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static GlobalClassReactiveTestInterface ReactiveTest { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern static MockObserverStatic MockObserver { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public delegate Observable<T> TestSchedulerStartWithTimingParam1Delegate<T> ();
	[External]
	public delegate Observable<T> TestSchedulerStartWithDisposeParam1Delegate<T> ();
	[External]
	public delegate Observable<T> TestSchedulerStartWithCreateParam1Delegate<T> ();
	[ObjectLiteral]
	public class JSONTestScheduler : TestScheduler
	{
	[External]
	public delegate Observable<T> createColdObservableDelegate<T> (params Recorded[] records);

#pragma warning disable CS0626
		public extern Observable<T> CreateColdObservable<T> (params Recorded[] records);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern createColdObservableDelegate<T> createColdObservable<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> createHotObservableDelegate<T> (params Recorded[] records);

#pragma warning disable CS0626
		public extern Observable<T> CreateHotObservable<T> (params Recorded[] records);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern createHotObservableDelegate<T> createHotObservable<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate MockObserver<T> createObserverDelegate<T> ();

#pragma warning disable CS0626
		public extern MockObserver<T> CreateObserver<T> ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern createObserverDelegate<T> createObserver<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate MockObserver<T> startWithTimingDelegate<T> (TestSchedulerStartWithTimingParam1Delegate<T> create, number createdAt, number subscribedAt, number disposedAt);

#pragma warning disable CS0626
		public extern MockObserver<T> StartWithTiming<T> (TestSchedulerStartWithTimingParam1Delegate<T> create, number createdAt, number subscribedAt, number disposedAt);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern startWithTimingDelegate<T> startWithTiming<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate MockObserver<T> startWithDisposeDelegate<T> (TestSchedulerStartWithDisposeParam1Delegate<T> create, number disposedAt);

#pragma warning disable CS0626
		public extern MockObserver<T> StartWithDispose<T> (TestSchedulerStartWithDisposeParam1Delegate<T> create, number disposedAt);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern startWithDisposeDelegate<T> startWithDispose<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate MockObserver<T> startWithCreateDelegate<T> (TestSchedulerStartWithCreateParam1Delegate<T> create);

#pragma warning disable CS0626
		public extern MockObserver<T> StartWithCreate<T> (TestSchedulerStartWithCreateParam1Delegate<T> create);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern startWithCreateDelegate<T> startWithCreate<T> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface TestScheduler : VirtualTimeScheduler<number, number>
	{
		Observable<T> CreateColdObservable<T> (params Recorded[] records);
		Observable<T> CreateHotObservable<T> (params Recorded[] records);
		MockObserver<T> CreateObserver<T> ();
		MockObserver<T> StartWithTiming<T> (TestSchedulerStartWithTimingParam1Delegate<T> create, number createdAt, number subscribedAt, number disposedAt);
		MockObserver<T> StartWithDispose<T> (TestSchedulerStartWithDisposeParam1Delegate<T> create, number disposedAt);
		MockObserver<T> StartWithCreate<T> (TestSchedulerStartWithCreateParam1Delegate<T> create);
	}
	[External]
	public class GlobalClassTestSchedulerInterface
	{
#pragma warning disable CS0626
		public extern TestScheduler New ();
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern GlobalClassTestSchedulerInterface ();
#pragma warning restore CS0824
	}
	[External]
	public delegate boolean RecordedConstructorParam3Delegate (any x, any y);
	[External]
	public class Recorded
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern number Time { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern any Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		public extern Recorded (number time, any value, RecordedConstructorParam3Delegate equalityComparer = default(RecordedConstructorParam3Delegate));
#pragma warning restore CS0824
#pragma warning disable CS0626
		public extern boolean Equals (Recorded other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern string ToString ();
#pragma warning restore CS0626
	}
	[External]
	public class GlobalClassReactiveTestInterface
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern number Created { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern number Subscribed { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern number Disposed { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern Recorded OnNext (number ticks, any value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern Recorded OnError (number ticks, any exception);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern Recorded OnCompleted (number ticks);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern Subscription Subscribe (number subscribeAt, number unsubscribeAt = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern GlobalClassReactiveTestInterface ();
#pragma warning restore CS0824
	}
	[External]
	public class Subscription
	{
#pragma warning disable CS0824
		public extern Subscription (number subscribeAt, number unsubscribeAt = default(number));
#pragma warning restore CS0824
#pragma warning disable CS0626
		public extern boolean Equals (Subscription other);
#pragma warning restore CS0626
	}
	[ObjectLiteral]
	public class JSONMockObserver<T> : MockObserver<T>
	{
#pragma warning disable CS0626
		public extern Recorded[] Messages { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface MockObserver<T> : Observer<T>
	{
		[FieldProperty]
		Recorded[] Messages { get; set; }
	}
	[ObjectLiteral]
	public class JSONMockObserverStatic : MockObserverStatic
	{
	[External]
	public delegate MockObserver<T> >Delegate (IScheduler scheduler);

#pragma warning disable CS0626
		public extern MockObserver<T> > (IScheduler scheduler);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern >Delegate > { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface MockObserverStatic : ObserverStatic
	{
		MockObserver<T> > (IScheduler scheduler);
	}

}

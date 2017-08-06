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
	public delegate IPromise<T> ObservableStaticStartAsyncParam1Delegate<T> ();
	[External]
	public delegate T ObservableStaticStartParam1Delegate<T> ();
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate<TResult> ();
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate<TResult> ();
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate<T1, TResult> (T1 arg1);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate<T1, TResult> (T1 arg1);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate_<T1, TResult> (T1 arg1 = default(T1));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate_<T1, TResult> (T1 arg1 = default(T1));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate__<T1, TResult> (params T1[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate__<T1, TResult> (params T1[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate<T1, T2, TResult> (T1 arg1, T2 arg2);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate<T1, T2, TResult> (T1 arg1, T2 arg2);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate_<T1, T2, TResult> (T1 arg1, T2 arg2 = default(T2));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate_<T1, T2, TResult> (T1 arg1, T2 arg2 = default(T2));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate__<T1, T2, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate__<T1, T2, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate___<T1, T2, TResult> (T1 arg1, params T2[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate___<T1, T2, TResult> (T1 arg1, params T2[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate____<T1, T2, TResult> (T1 arg1 = default(T1), params T2[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate____<T1, T2, TResult> (T1 arg1 = default(T1), params T2[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate<T1, T2, T3, TResult> (T1 arg1, T2 arg2, T3 arg3);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate<T1, T2, T3, TResult> (T1 arg1, T2 arg2, T3 arg3);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate_<T1, T2, T3, TResult> (T1 arg1, T2 arg2, T3 arg3 = default(T3));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate_<T1, T2, T3, TResult> (T1 arg1, T2 arg2, T3 arg3 = default(T3));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate__<T1, T2, T3, TResult> (T1 arg1, T2 arg2 = default(T2), T3 arg3 = default(T3));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate__<T1, T2, T3, TResult> (T1 arg1, T2 arg2 = default(T2), T3 arg3 = default(T3));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate___<T1, T2, T3, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2), T3 arg3 = default(T3));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate___<T1, T2, T3, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2), T3 arg3 = default(T3));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate____<T1, T2, T3, TResult> (T1 arg1, T2 arg2, params T3[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate____<T1, T2, T3, TResult> (T1 arg1, T2 arg2, params T3[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate_____<T1, T2, T3, TResult> (T1 arg1, T2 arg2 = default(T2), params T3[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate_____<T1, T2, T3, TResult> (T1 arg1, T2 arg2 = default(T2), params T3[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate______<T1, T2, T3, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2), params T3[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate______<T1, T2, T3, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2), params T3[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3, T4 arg4);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3, T4 arg4);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate_<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3, T4 arg4 = default(T4));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate_<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3, T4 arg4 = default(T4));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate__<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3 = default(T3), T4 arg4 = default(T4));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate__<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3 = default(T3), T4 arg4 = default(T4));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate___<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2 = default(T2), T3 arg3 = default(T3), T4 arg4 = default(T4));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate___<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2 = default(T2), T3 arg3 = default(T3), T4 arg4 = default(T4));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate____<T1, T2, T3, T4, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2), T3 arg3 = default(T3), T4 arg4 = default(T4));
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate____<T1, T2, T3, T4, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2), T3 arg3 = default(T3), T4 arg4 = default(T4));
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate_____<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3, params T4[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate_____<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3, params T4[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate______<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3 = default(T3), params T4[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate______<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2, T3 arg3 = default(T3), params T4[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate_______<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2 = default(T2), T3 arg3 = default(T3), params T4[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate_______<T1, T2, T3, T4, TResult> (T1 arg1, T2 arg2 = default(T2), T3 arg3 = default(T3), params T4[] args);
	[External]
	public delegate TResult ObservableStaticToAsyncParam1Delegate________<T1, T2, T3, T4, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2), T3 arg3 = default(T3), params T4[] args);
	[External]
	public delegate Observable<TResult> ObservableStaticToAsyncDelegate________<T1, T2, T3, T4, TResult> (T1 arg1 = default(T1), T2 arg2 = default(T2), T3 arg3 = default(T3), params T4[] args);
	[ObjectLiteral]
	public class JSONObservableStatic : ObservableStatic
	{
	[External]
	public delegate Observable<T> startAsyncDelegate<T> (ObservableStaticStartAsyncParam1Delegate<T> functionAsync);

#pragma warning disable CS0626
		public extern Observable<T> StartAsync<T> (ObservableStaticStartAsyncParam1Delegate<T> functionAsync);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern startAsyncDelegate<T> startAsync<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> startDelegate<T> (ObservableStaticStartParam1Delegate<T> func, any context = default(any), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Start<T> (ObservableStaticStartParam1Delegate<T> func, any context = default(any), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern startDelegate<T> start<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ObservableStaticToAsyncDelegate<TResult> toAsyncDelegate<TResult> (ObservableStaticToAsyncParam1Delegate<TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ObservableStaticToAsyncDelegate<TResult> ToAsync<TResult> (ObservableStaticToAsyncParam1Delegate<TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toAsyncDelegate<TResult> toAsync<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ObservableStaticToAsyncDelegate<T1, TResult> toAsyncDelegate<T1, TResult> (ObservableStaticToAsyncParam1Delegate<T1, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ObservableStaticToAsyncDelegate<T1, TResult> ToAsync<T1, TResult> (ObservableStaticToAsyncParam1Delegate<T1, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toAsyncDelegate<T1, TResult> toAsync<T1, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ObservableStaticToAsyncDelegate<T1, T2, TResult> toAsyncDelegate<T1, T2, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ObservableStaticToAsyncDelegate<T1, T2, TResult> ToAsync<T1, T2, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toAsyncDelegate<T1, T2, TResult> toAsync<T1, T2, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ObservableStaticToAsyncDelegate<T1, T2, T3, TResult> toAsyncDelegate<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ObservableStaticToAsyncDelegate<T1, T2, T3, TResult> ToAsync<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toAsyncDelegate<T1, T2, T3, TResult> toAsync<T1, T2, T3, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ObservableStaticToAsyncDelegate<T1, T2, T3, T4, TResult> toAsyncDelegate<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern ObservableStaticToAsyncDelegate<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern toAsyncDelegate<T1, T2, T3, T4, TResult> toAsync<T1, T2, T3, T4, TResult> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObservableStatic
	{
		Observable<T> StartAsync<T> (ObservableStaticStartAsyncParam1Delegate<T> functionAsync);
		Observable<T> Start<T> (ObservableStaticStartParam1Delegate<T> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate<TResult> ToAsync<TResult> (ObservableStaticToAsyncParam1Delegate<TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate<T1, TResult> ToAsync<T1, TResult> (ObservableStaticToAsyncParam1Delegate<T1, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate_<T1, TResult> ToAsync<T1, TResult> (ObservableStaticToAsyncParam1Delegate_<T1, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate__<T1, TResult> ToAsync<T1, TResult> (ObservableStaticToAsyncParam1Delegate__<T1, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate<T1, T2, TResult> ToAsync<T1, T2, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate_<T1, T2, TResult> ToAsync<T1, T2, TResult> (ObservableStaticToAsyncParam1Delegate_<T1, T2, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate__<T1, T2, TResult> ToAsync<T1, T2, TResult> (ObservableStaticToAsyncParam1Delegate__<T1, T2, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate___<T1, T2, TResult> ToAsync<T1, T2, TResult> (ObservableStaticToAsyncParam1Delegate___<T1, T2, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate____<T1, T2, TResult> ToAsync<T1, T2, TResult> (ObservableStaticToAsyncParam1Delegate____<T1, T2, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate<T1, T2, T3, TResult> ToAsync<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate_<T1, T2, T3, TResult> ToAsync<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate_<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate__<T1, T2, T3, TResult> ToAsync<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate__<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate___<T1, T2, T3, TResult> ToAsync<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate___<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate____<T1, T2, T3, TResult> ToAsync<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate____<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate_____<T1, T2, T3, TResult> ToAsync<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate_____<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate______<T1, T2, T3, TResult> ToAsync<T1, T2, T3, TResult> (ObservableStaticToAsyncParam1Delegate______<T1, T2, T3, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate_<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate_<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate__<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate__<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate___<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate___<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate____<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate____<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate_____<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate_____<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate______<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate______<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate_______<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate_______<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
		ObservableStaticToAsyncDelegate________<T1, T2, T3, T4, TResult> ToAsync<T1, T2, T3, T4, TResult> (ObservableStaticToAsyncParam1Delegate________<T1, T2, T3, T4, TResult> func, any context = default(any), IScheduler scheduler = default(IScheduler));
	}

}

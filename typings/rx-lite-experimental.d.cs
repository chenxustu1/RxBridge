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
	public delegate Observable<TResult> ObservableLetParam1Delegate<T, TResult> (Observable<T> source);
	[External]
	public delegate Observable<TResult> ObservableLetBindParam1Delegate<T, TResult> (Observable<T> source);
	[External]
	public delegate boolean ObservableDoWhileParam1Delegate<T> ();
	[External]
	public delegate Observable<T> ObservableExpandParam1Delegate<T> (T item);
	[External]
	public delegate TResult ObservableForkJoinParam2Delegate<T, TSecond, TResult> (T left, TSecond right);
	[External]
	public delegate TResult ObservableForkJoinParam2Delegate_<T, TSecond, TResult> (T left, TSecond right);
	[External]
	public delegate TResult ObservableManySelectParam1Delegate<T, TResult> (Observable<T> item, number index, Observable<T> source);
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate Observable<TResult> letDelegate<TResult> (ObservableLetParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> Let<TResult> (ObservableLetParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern letDelegate<TResult> let<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> letBindDelegate<TResult> (ObservableLetBindParam1Delegate<T, TResult> selector);

#pragma warning disable CS0626
		public extern Observable<TResult> LetBind<TResult> (ObservableLetBindParam1Delegate<T, TResult> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern letBindDelegate<TResult> letBind<TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> doWhileDelegate (ObservableDoWhileParam1Delegate<T> condition);

#pragma warning disable CS0626
		public extern Observable<T> DoWhile (ObservableDoWhileParam1Delegate<T> condition);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern doWhileDelegate doWhile { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> expandDelegate (ObservableExpandParam1Delegate<T> selector, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<T> Expand (ObservableExpandParam1Delegate<T> selector, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern expandDelegate expand { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> forkJoinDelegate<TSecond, TResult> (Observable<TSecond> second, ObservableForkJoinParam2Delegate<T, TSecond, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> ForkJoin<TSecond, TResult> (Observable<TSecond> second, ObservableForkJoinParam2Delegate<T, TSecond, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern forkJoinDelegate<TSecond, TResult> forkJoin<TSecond, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> manySelectDelegate<TResult> (ObservableManySelectParam1Delegate<T, TResult> selector, IScheduler scheduler = default(IScheduler));

#pragma warning disable CS0626
		public extern Observable<TResult> ManySelect<TResult> (ObservableManySelectParam1Delegate<T, TResult> selector, IScheduler scheduler = default(IScheduler));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern manySelectDelegate<TResult> manySelect<TResult> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		Observable<TResult> Let<TResult> (ObservableLetParam1Delegate<T, TResult> selector);
		Observable<TResult> LetBind<TResult> (ObservableLetBindParam1Delegate<T, TResult> selector);
		Observable<T> DoWhile (ObservableDoWhileParam1Delegate<T> condition);
		Observable<T> Expand (ObservableExpandParam1Delegate<T> selector, IScheduler scheduler = default(IScheduler));
		Observable<TResult> ForkJoin<TSecond, TResult> (Observable<TSecond> second, ObservableForkJoinParam2Delegate<T, TSecond, TResult> resultSelector);
		Observable<TResult> ForkJoin<TSecond, TResult> (IPromise<TSecond> second, ObservableForkJoinParam2Delegate_<T, TSecond, TResult> resultSelector);
		Observable<TResult> ManySelect<TResult> (ObservableManySelectParam1Delegate<T, TResult> selector, IScheduler scheduler = default(IScheduler));
	}
	[External]
	public delegate boolean ObservableStaticIfParam1Delegate<T> ();
	[External]
	public delegate boolean ObservableStaticIfParam1Delegate_<T> ();
	[External]
	public delegate boolean ObservableStaticIfParam1Delegate__<T> ();
	[External]
	public delegate boolean ObservableStaticIfParam1Delegate___<T> ();
	[External]
	public delegate boolean ObservableStaticIfParam1Delegate____<T> ();
	[External]
	public delegate boolean ObservableStaticIfParam1Delegate_____<T> ();
	[External]
	public delegate boolean ObservableStaticIfThenParam1Delegate<T> ();
	[External]
	public delegate boolean ObservableStaticIfThenParam1Delegate_<T> ();
	[External]
	public delegate boolean ObservableStaticIfThenParam1Delegate__<T> ();
	[External]
	public delegate boolean ObservableStaticIfThenParam1Delegate___<T> ();
	[External]
	public delegate boolean ObservableStaticIfThenParam1Delegate____<T> ();
	[External]
	public delegate boolean ObservableStaticIfThenParam1Delegate_____<T> ();
	[External]
	public delegate Observable<TResult> ObservableStaticForParam2Delegate<T, TResult> (T item);
	[External]
	public delegate Observable<TResult> ObservableStaticForInParam2Delegate<T, TResult> (T item);
	[External]
	public delegate boolean ObservableStaticWhileParam1Delegate<T> ();
	[External]
	public delegate boolean ObservableStaticWhileParam1Delegate_<T> ();
	[External]
	public delegate boolean ObservableStaticWhileDoParam1Delegate<T> ();
	[External]
	public delegate boolean ObservableStaticWhileDoParam1Delegate_<T> ();
	[External]
	public delegate string ObservableStaticCaseParam1Delegate<T> ();
	[External]
	public class ObservableStaticSourcesInterface
	{
#pragma warning disable CS0626
		public extern Observable<T> this [string key] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ObservableStaticSourcesInterface ();
#pragma warning restore CS0824
	}
	[External]
	public delegate string ObservableStaticCaseParam1Delegate_<T> ();
	[External]
	public delegate string ObservableStaticCaseParam1Delegate__<T> ();
	[External]
	public delegate string ObservableStaticCaseParam1Delegate___<T> ();
	[External]
	public delegate string ObservableStaticCaseParam1Delegate____<T> ();
	[External]
	public delegate string ObservableStaticCaseParam1Delegate_____<T> ();
	[External]
	public delegate number ObservableStaticCaseParam1Delegate______<T> ();
	[External]
	public delegate number ObservableStaticCaseParam1Delegate_______<T> ();
	[External]
	public delegate number ObservableStaticCaseParam1Delegate________<T> ();
	[External]
	public delegate number ObservableStaticCaseParam1Delegate_________<T> ();
	[External]
	public delegate number ObservableStaticCaseParam1Delegate__________<T> ();
	[External]
	public delegate number ObservableStaticCaseParam1Delegate___________<T> ();
	[External]
	public delegate string ObservableStaticSwitchCaseParam1Delegate<T> ();
	[External]
	public delegate string ObservableStaticSwitchCaseParam1Delegate_<T> ();
	[External]
	public delegate string ObservableStaticSwitchCaseParam1Delegate__<T> ();
	[External]
	public delegate string ObservableStaticSwitchCaseParam1Delegate___<T> ();
	[External]
	public delegate string ObservableStaticSwitchCaseParam1Delegate____<T> ();
	[External]
	public delegate string ObservableStaticSwitchCaseParam1Delegate_____<T> ();
	[External]
	public delegate number ObservableStaticSwitchCaseParam1Delegate______<T> ();
	[External]
	public delegate number ObservableStaticSwitchCaseParam1Delegate_______<T> ();
	[External]
	public delegate number ObservableStaticSwitchCaseParam1Delegate________<T> ();
	[External]
	public delegate number ObservableStaticSwitchCaseParam1Delegate_________<T> ();
	[External]
	public delegate number ObservableStaticSwitchCaseParam1Delegate__________<T> ();
	[External]
	public delegate number ObservableStaticSwitchCaseParam1Delegate___________<T> ();
	[ObjectLiteral]
	public class JSONObservableStatic : ObservableStatic
	{
	[External]
	public delegate Observable<T> ifDelegate<T> (ObservableStaticIfParam1Delegate<T> condition, Observable<T> thenSource, Observable<T> elseSource);

#pragma warning disable CS0626
		public extern Observable<T> If<T> (ObservableStaticIfParam1Delegate<T> condition, Observable<T> thenSource, Observable<T> elseSource);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ifDelegate<T> if<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> ifThenDelegate<T> (ObservableStaticIfThenParam1Delegate<T> condition, Observable<T> thenSource, Observable<T> elseSource);

#pragma warning disable CS0626
		public extern Observable<T> IfThen<T> (ObservableStaticIfThenParam1Delegate<T> condition, Observable<T> thenSource, Observable<T> elseSource);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ifThenDelegate<T> ifThen<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> forDelegate<T, TResult> (T[] sources, ObservableStaticForParam2Delegate<T, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> For<T, TResult> (T[] sources, ObservableStaticForParam2Delegate<T, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern forDelegate<T, TResult> for<T, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> forInDelegate<T, TResult> (T[] sources, ObservableStaticForInParam2Delegate<T, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> ForIn<T, TResult> (T[] sources, ObservableStaticForInParam2Delegate<T, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern forInDelegate<T, TResult> forIn<T, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> whileDelegate<T> (ObservableStaticWhileParam1Delegate<T> condition, Observable<T> source);

#pragma warning disable CS0626
		public extern Observable<T> While<T> (ObservableStaticWhileParam1Delegate<T> condition, Observable<T> source);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern whileDelegate<T> while<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> whileDoDelegate<T> (ObservableStaticWhileDoParam1Delegate<T> condition, Observable<T> source);

#pragma warning disable CS0626
		public extern Observable<T> WhileDo<T> (ObservableStaticWhileDoParam1Delegate<T> condition, Observable<T> source);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern whileDoDelegate<T> whileDo<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> caseDelegate<T> (ObservableStaticCaseParam1Delegate<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);

#pragma warning disable CS0626
		public extern Observable<T> Case<T> (ObservableStaticCaseParam1Delegate<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern caseDelegate<T> case<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> switchCaseDelegate<T> (ObservableStaticSwitchCaseParam1Delegate<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);

#pragma warning disable CS0626
		public extern Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern switchCaseDelegate<T> switchCase<T> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> forkJoinDelegate<T> (Observable<T>[] sources);

#pragma warning disable CS0626
		public extern Observable<T[]> ForkJoin<T> (Observable<T>[] sources);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern forkJoinDelegate<T> forkJoin<T> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObservableStatic
	{
		Observable<T> If<T> (ObservableStaticIfParam1Delegate<T> condition, Observable<T> thenSource, Observable<T> elseSource);
		Observable<T> If<T> (ObservableStaticIfParam1Delegate_<T> condition, Observable<T> thenSource, IPromise<T> elseSource);
		Observable<T> If<T> (ObservableStaticIfParam1Delegate__<T> condition, IPromise<T> thenSource, Observable<T> elseSource);
		Observable<T> If<T> (ObservableStaticIfParam1Delegate___<T> condition, IPromise<T> thenSource, IPromise<T> elseSource);
		Observable<T> If<T> (ObservableStaticIfParam1Delegate____<T> condition, Observable<T> thenSource, IScheduler scheduler = default(IScheduler));
		Observable<T> If<T> (ObservableStaticIfParam1Delegate_____<T> condition, IPromise<T> thenSource, IScheduler scheduler = default(IScheduler));
		Observable<T> IfThen<T> (ObservableStaticIfThenParam1Delegate<T> condition, Observable<T> thenSource, Observable<T> elseSource);
		Observable<T> IfThen<T> (ObservableStaticIfThenParam1Delegate_<T> condition, Observable<T> thenSource, IPromise<T> elseSource);
		Observable<T> IfThen<T> (ObservableStaticIfThenParam1Delegate__<T> condition, IPromise<T> thenSource, Observable<T> elseSource);
		Observable<T> IfThen<T> (ObservableStaticIfThenParam1Delegate___<T> condition, IPromise<T> thenSource, IPromise<T> elseSource);
		Observable<T> IfThen<T> (ObservableStaticIfThenParam1Delegate____<T> condition, Observable<T> thenSource, IScheduler scheduler = default(IScheduler));
		Observable<T> IfThen<T> (ObservableStaticIfThenParam1Delegate_____<T> condition, IPromise<T> thenSource, IScheduler scheduler = default(IScheduler));
		Observable<TResult> For<T, TResult> (T[] sources, ObservableStaticForParam2Delegate<T, TResult> resultSelector);
		Observable<TResult> ForIn<T, TResult> (T[] sources, ObservableStaticForInParam2Delegate<T, TResult> resultSelector);
		Observable<T> While<T> (ObservableStaticWhileParam1Delegate<T> condition, Observable<T> source);
		Observable<T> While<T> (ObservableStaticWhileParam1Delegate_<T> condition, IPromise<T> source);
		Observable<T> WhileDo<T> (ObservableStaticWhileDoParam1Delegate<T> condition, Observable<T> source);
		Observable<T> WhileDo<T> (ObservableStaticWhileDoParam1Delegate_<T> condition, IPromise<T> source);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate_<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate__<T> selector, ObservableStaticSourcesInterface sources, IPromise<T> elseSource);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate___<T> selector, ObservableStaticSourcesInterface sources, IPromise<T> elseSource);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate____<T> selector, ObservableStaticSourcesInterface sources, IScheduler scheduler = default(IScheduler));
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate_____<T> selector, ObservableStaticSourcesInterface sources, IScheduler scheduler = default(IScheduler));
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate______<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate_______<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate________<T> selector, ObservableStaticSourcesInterface sources, IPromise<T> elseSource);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate_________<T> selector, ObservableStaticSourcesInterface sources, IPromise<T> elseSource);
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate__________<T> selector, ObservableStaticSourcesInterface sources, IScheduler scheduler = default(IScheduler));
		Observable<T> Case<T> (ObservableStaticCaseParam1Delegate___________<T> selector, ObservableStaticSourcesInterface sources, IScheduler scheduler = default(IScheduler));
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate_<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate__<T> selector, ObservableStaticSourcesInterface sources, IPromise<T> elseSource);
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate___<T> selector, ObservableStaticSourcesInterface sources, IPromise<T> elseSource);
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate____<T> selector, ObservableStaticSourcesInterface sources, IScheduler scheduler = default(IScheduler));
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate_____<T> selector, ObservableStaticSourcesInterface sources, IScheduler scheduler = default(IScheduler));
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate______<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate_______<T> selector, ObservableStaticSourcesInterface sources, Observable<T> elseSource);
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate________<T> selector, ObservableStaticSourcesInterface sources, IPromise<T> elseSource);
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate_________<T> selector, ObservableStaticSourcesInterface sources, IPromise<T> elseSource);
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate__________<T> selector, ObservableStaticSourcesInterface sources, IScheduler scheduler = default(IScheduler));
		Observable<T> SwitchCase<T> (ObservableStaticSwitchCaseParam1Delegate___________<T> selector, ObservableStaticSourcesInterface sources, IScheduler scheduler = default(IScheduler));
		Observable<T[]> ForkJoin<T> (Observable<T>[] sources);
		Observable<T[]> ForkJoin<T> (IPromise<T>[] sources);
		Observable<T[]> ForkJoin<T> (params Observable<T>[] args);
		Observable<T[]> ForkJoin<T> (params IPromise<T>[] args);
	}

}

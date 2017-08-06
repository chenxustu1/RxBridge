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
	public delegate Observable<TDurationLeft> ObservableJoinParam2Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> (T leftItem);
	[External]
	public delegate Observable<TDurationRight> ObservableJoinParam3Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> (TRight rightItem);
	[External]
	public delegate TResult ObservableJoinParam4Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> (T leftItem, TRight rightItem);
	[External]
	public delegate Observable<TDurationLeft> ObservableGroupJoinParam2Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> (T leftItem);
	[External]
	public delegate Observable<TDurationRight> ObservableGroupJoinParam3Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> (TRight rightItem);
	[External]
	public delegate TResult ObservableGroupJoinParam4Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> (T leftItem, Observable<TRight> rightItem);
	[External]
	public delegate Observable<TWindowClosing> ObservableWindowParam1Delegate<T, TWindowClosing> ();
	[External]
	public delegate Observable<TWindowClosing> ObservableWindowParam2Delegate<T, TWindowOpening, TWindowClosing> ();
	[External]
	public delegate Observable<TBufferClosing> ObservableBufferParam1Delegate<T, TBufferClosing> ();
	[External]
	public delegate Observable<TBufferClosing> ObservableBufferParam2Delegate<T, TBufferOpening, TBufferClosing> ();
	[External]
	public delegate boolean ObservablePartitionParam1Delegate<T> (T value, number index, Observable<T> source);
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate Observable<TResult> joinDelegate<TRight, TDurationLeft, TDurationRight, TResult> (Observable<TRight> right, ObservableJoinParam2Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> leftDurationSelector, ObservableJoinParam3Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> rightDurationSelector, ObservableJoinParam4Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> Join<TRight, TDurationLeft, TDurationRight, TResult> (Observable<TRight> right, ObservableJoinParam2Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> leftDurationSelector, ObservableJoinParam3Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> rightDurationSelector, ObservableJoinParam4Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern joinDelegate<TRight, TDurationLeft, TDurationRight, TResult> join<TRight, TDurationLeft, TDurationRight, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TResult> groupJoinDelegate<TRight, TDurationLeft, TDurationRight, TResult> (Observable<TRight> right, ObservableGroupJoinParam2Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> leftDurationSelector, ObservableGroupJoinParam3Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> rightDurationSelector, ObservableGroupJoinParam4Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> resultSelector);

#pragma warning disable CS0626
		public extern Observable<TResult> GroupJoin<TRight, TDurationLeft, TDurationRight, TResult> (Observable<TRight> right, ObservableGroupJoinParam2Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> leftDurationSelector, ObservableGroupJoinParam3Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> rightDurationSelector, ObservableGroupJoinParam4Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> resultSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern groupJoinDelegate<TRight, TDurationLeft, TDurationRight, TResult> groupJoin<TRight, TDurationLeft, TDurationRight, TResult> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Observable<T>> windowDelegate<TWindowOpening> (Observable<TWindowOpening> windowOpenings);

#pragma warning disable CS0626
		public extern Observable<Observable<T>> Window<TWindowOpening> (Observable<TWindowOpening> windowOpenings);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern windowDelegate<TWindowOpening> window<TWindowOpening> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Observable<T>> windowDelegate<TWindowClosing> (ObservableWindowParam1Delegate<T, TWindowClosing> windowClosingSelector);

#pragma warning disable CS0626
		public extern Observable<Observable<T>> Window<TWindowClosing> (ObservableWindowParam1Delegate<T, TWindowClosing> windowClosingSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern windowDelegate<TWindowClosing> window<TWindowClosing> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<Observable<T>> windowDelegate<TWindowOpening, TWindowClosing> (Observable<TWindowOpening> windowOpenings, ObservableWindowParam2Delegate<T, TWindowOpening, TWindowClosing> windowClosingSelector);

#pragma warning disable CS0626
		public extern Observable<Observable<T>> Window<TWindowOpening, TWindowClosing> (Observable<TWindowOpening> windowOpenings, ObservableWindowParam2Delegate<T, TWindowOpening, TWindowClosing> windowClosingSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern windowDelegate<TWindowOpening, TWindowClosing> window<TWindowOpening, TWindowClosing> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> bufferDelegate<TBufferOpening> (Observable<TBufferOpening> bufferOpenings);

#pragma warning disable CS0626
		public extern Observable<T[]> Buffer<TBufferOpening> (Observable<TBufferOpening> bufferOpenings);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern bufferDelegate<TBufferOpening> buffer<TBufferOpening> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> bufferDelegate<TBufferClosing> (ObservableBufferParam1Delegate<T, TBufferClosing> bufferClosingSelector);

#pragma warning disable CS0626
		public extern Observable<T[]> Buffer<TBufferClosing> (ObservableBufferParam1Delegate<T, TBufferClosing> bufferClosingSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern bufferDelegate<TBufferClosing> buffer<TBufferClosing> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> bufferDelegate<TBufferOpening, TBufferClosing> (Observable<TBufferOpening> bufferOpenings, ObservableBufferParam2Delegate<T, TBufferOpening, TBufferClosing> bufferClosingSelector);

#pragma warning disable CS0626
		public extern Observable<T[]> Buffer<TBufferOpening, TBufferClosing> (Observable<TBufferOpening> bufferOpenings, ObservableBufferParam2Delegate<T, TBufferOpening, TBufferClosing> bufferClosingSelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern bufferDelegate<TBufferOpening, TBufferClosing> buffer<TBufferOpening, TBufferClosing> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T[]> pairwiseDelegate ();

#pragma warning disable CS0626
		public extern Observable<T[]> Pairwise ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pairwiseDelegate pairwise { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T>[] partitionDelegate (ObservablePartitionParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T>[] Partition (ObservablePartitionParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern partitionDelegate partition { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		Observable<TResult> Join<TRight, TDurationLeft, TDurationRight, TResult> (Observable<TRight> right, ObservableJoinParam2Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> leftDurationSelector, ObservableJoinParam3Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> rightDurationSelector, ObservableJoinParam4Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> resultSelector);
		Observable<TResult> GroupJoin<TRight, TDurationLeft, TDurationRight, TResult> (Observable<TRight> right, ObservableGroupJoinParam2Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> leftDurationSelector, ObservableGroupJoinParam3Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> rightDurationSelector, ObservableGroupJoinParam4Delegate<T, TRight, TDurationLeft, TDurationRight, TResult> resultSelector);
		Observable<Observable<T>> Window<TWindowOpening> (Observable<TWindowOpening> windowOpenings);
		Observable<Observable<T>> Window<TWindowClosing> (ObservableWindowParam1Delegate<T, TWindowClosing> windowClosingSelector);
		Observable<Observable<T>> Window<TWindowOpening, TWindowClosing> (Observable<TWindowOpening> windowOpenings, ObservableWindowParam2Delegate<T, TWindowOpening, TWindowClosing> windowClosingSelector);
		Observable<T[]> Buffer<TBufferOpening> (Observable<TBufferOpening> bufferOpenings);
		Observable<T[]> Buffer<TBufferClosing> (ObservableBufferParam1Delegate<T, TBufferClosing> bufferClosingSelector);
		Observable<T[]> Buffer<TBufferOpening, TBufferClosing> (Observable<TBufferOpening> bufferOpenings, ObservableBufferParam2Delegate<T, TBufferOpening, TBufferClosing> bufferClosingSelector);
		Observable<T[]> Pairwise ();
		Observable<T>[] Partition (ObservablePartitionParam1Delegate<T> predicate, any thisArg = default(any));
	}

}

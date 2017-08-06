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
	public delegate TR Pattern1ThenDoParam1Delegate<T1, TR> (T1 item1);
	[ObjectLiteral]
	public class JSONPattern1<T1> : Pattern1<T1>
	{
	[External]
	public delegate Pattern2<T1, T2> andDelegate<T2> (Observable<T2> other);

#pragma warning disable CS0626
		public extern Pattern2<T1, T2> And<T2> (Observable<T2> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T2> and<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern1ThenDoParam1Delegate<T1, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern1ThenDoParam1Delegate<T1, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern1<T1>
	{
		Pattern2<T1, T2> And<T2> (Observable<T2> other);
		Plan<TR> ThenDo<TR> (Pattern1ThenDoParam1Delegate<T1, TR> selector);
	}
	[External]
	public delegate TR Pattern2ThenDoParam1Delegate<T1, T2, TR> (T1 item1, T2 item2);
	[ObjectLiteral]
	public class JSONPattern2<T1, T2> : Pattern2<T1, T2>
	{
	[External]
	public delegate Pattern3<T1, T2, T3> andDelegate<T3> (Observable<T3> other);

#pragma warning disable CS0626
		public extern Pattern3<T1, T2, T3> And<T3> (Observable<T3> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T3> and<T3> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern2ThenDoParam1Delegate<T1, T2, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern2ThenDoParam1Delegate<T1, T2, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern2<T1, T2>
	{
		Pattern3<T1, T2, T3> And<T3> (Observable<T3> other);
		Plan<TR> ThenDo<TR> (Pattern2ThenDoParam1Delegate<T1, T2, TR> selector);
	}
	[External]
	public delegate TR Pattern3ThenDoParam1Delegate<T1, T2, T3, TR> (T1 item1, T2 item2, T3 item3);
	[ObjectLiteral]
	public class JSONPattern3<T1, T2, T3> : Pattern3<T1, T2, T3>
	{
	[External]
	public delegate Pattern4<T1, T2, T3, T4> andDelegate<T4> (Observable<T4> other);

#pragma warning disable CS0626
		public extern Pattern4<T1, T2, T3, T4> And<T4> (Observable<T4> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T4> and<T4> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern3ThenDoParam1Delegate<T1, T2, T3, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern3ThenDoParam1Delegate<T1, T2, T3, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern3<T1, T2, T3>
	{
		Pattern4<T1, T2, T3, T4> And<T4> (Observable<T4> other);
		Plan<TR> ThenDo<TR> (Pattern3ThenDoParam1Delegate<T1, T2, T3, TR> selector);
	}
	[External]
	public delegate TR Pattern4ThenDoParam1Delegate<T1, T2, T3, T4, TR> (T1 item1, T2 item2, T3 item3, T4 item4);
	[ObjectLiteral]
	public class JSONPattern4<T1, T2, T3, T4> : Pattern4<T1, T2, T3, T4>
	{
	[External]
	public delegate Pattern5<T1, T2, T3, T4, T5> andDelegate<T5> (Observable<T5> other);

#pragma warning disable CS0626
		public extern Pattern5<T1, T2, T3, T4, T5> And<T5> (Observable<T5> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T5> and<T5> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern4ThenDoParam1Delegate<T1, T2, T3, T4, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern4ThenDoParam1Delegate<T1, T2, T3, T4, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern4<T1, T2, T3, T4>
	{
		Pattern5<T1, T2, T3, T4, T5> And<T5> (Observable<T5> other);
		Plan<TR> ThenDo<TR> (Pattern4ThenDoParam1Delegate<T1, T2, T3, T4, TR> selector);
	}
	[External]
	public delegate TR Pattern5ThenDoParam1Delegate<T1, T2, T3, T4, T5, TR> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);
	[ObjectLiteral]
	public class JSONPattern5<T1, T2, T3, T4, T5> : Pattern5<T1, T2, T3, T4, T5>
	{
	[External]
	public delegate Pattern6<T1, T2, T3, T4, T5, T6> andDelegate<T6> (Observable<T6> other);

#pragma warning disable CS0626
		public extern Pattern6<T1, T2, T3, T4, T5, T6> And<T6> (Observable<T6> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T6> and<T6> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern5ThenDoParam1Delegate<T1, T2, T3, T4, T5, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern5ThenDoParam1Delegate<T1, T2, T3, T4, T5, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern5<T1, T2, T3, T4, T5>
	{
		Pattern6<T1, T2, T3, T4, T5, T6> And<T6> (Observable<T6> other);
		Plan<TR> ThenDo<TR> (Pattern5ThenDoParam1Delegate<T1, T2, T3, T4, T5, TR> selector);
	}
	[External]
	public delegate TR Pattern6ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, TR> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);
	[ObjectLiteral]
	public class JSONPattern6<T1, T2, T3, T4, T5, T6> : Pattern6<T1, T2, T3, T4, T5, T6>
	{
	[External]
	public delegate Pattern7<T1, T2, T3, T4, T5, T6, T7> andDelegate<T7> (Observable<T7> other);

#pragma warning disable CS0626
		public extern Pattern7<T1, T2, T3, T4, T5, T6, T7> And<T7> (Observable<T7> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T7> and<T7> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern6ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern6ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern6<T1, T2, T3, T4, T5, T6>
	{
		Pattern7<T1, T2, T3, T4, T5, T6, T7> And<T7> (Observable<T7> other);
		Plan<TR> ThenDo<TR> (Pattern6ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, TR> selector);
	}
	[External]
	public delegate TR Pattern7ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, TR> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);
	[ObjectLiteral]
	public class JSONPattern7<T1, T2, T3, T4, T5, T6, T7> : Pattern7<T1, T2, T3, T4, T5, T6, T7>
	{
	[External]
	public delegate Pattern8<T1, T2, T3, T4, T5, T6, T7, T8> andDelegate<T8> (Observable<T8> other);

#pragma warning disable CS0626
		public extern Pattern8<T1, T2, T3, T4, T5, T6, T7, T8> And<T8> (Observable<T8> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T8> and<T8> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern7ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern7ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern7<T1, T2, T3, T4, T5, T6, T7>
	{
		Pattern8<T1, T2, T3, T4, T5, T6, T7, T8> And<T8> (Observable<T8> other);
		Plan<TR> ThenDo<TR> (Pattern7ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, TR> selector);
	}
	[External]
	public delegate TR Pattern8ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, T8, TR> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);
	[ObjectLiteral]
	public class JSONPattern8<T1, T2, T3, T4, T5, T6, T7, T8> : Pattern8<T1, T2, T3, T4, T5, T6, T7, T8>
	{
	[External]
	public delegate Pattern9<T1, T2, T3, T4, T5, T6, T7, T8, T9> andDelegate<T9> (Observable<T9> other);

#pragma warning disable CS0626
		public extern Pattern9<T1, T2, T3, T4, T5, T6, T7, T8, T9> And<T9> (Observable<T9> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T9> and<T9> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern8ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, T8, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern8ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, T8, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern8<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		Pattern9<T1, T2, T3, T4, T5, T6, T7, T8, T9> And<T9> (Observable<T9> other);
		Plan<TR> ThenDo<TR> (Pattern8ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, T8, TR> selector);
	}
	[External]
	public delegate TR Pattern9ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9);
	[ObjectLiteral]
	public class JSONPattern9<T1, T2, T3, T4, T5, T6, T7, T8, T9> : Pattern9<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (Pattern9ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (Pattern9ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Pattern9<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
		Plan<TR> ThenDo<TR> (Pattern9ThenDoParam1Delegate<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> selector);
	}
	[External]
	public interface Plan<T>
	{
	}
	[External]
	public delegate TR ObservableThenDoParam1Delegate<T, TR> (T item1);
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate Pattern2<T, T2> andDelegate<T2> (Observable<T2> other);

#pragma warning disable CS0626
		public extern Pattern2<T, T2> And<T2> (Observable<T2> other);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern andDelegate<T2> and<T2> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Plan<TR> thenDoDelegate<TR> (ObservableThenDoParam1Delegate<T, TR> selector);

#pragma warning disable CS0626
		public extern Plan<TR> ThenDo<TR> (ObservableThenDoParam1Delegate<T, TR> selector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern thenDoDelegate<TR> thenDo<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		Pattern2<T, T2> And<T2> (Observable<T2> other);
		Plan<TR> ThenDo<TR> (ObservableThenDoParam1Delegate<T, TR> selector);
	}
	[ObjectLiteral]
	public class JSONObservableStatic : ObservableStatic
	{
	[External]
	public delegate Observable<TR> whenDelegate<TR> (Plan<TR> plan);

#pragma warning disable CS0626
		public extern Observable<TR> When<TR> (Plan<TR> plan);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern whenDelegate<TR> when<TR> { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ObservableStatic
	{
		Observable<TR> When<TR> (Plan<TR> plan);
	}

}

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
	public delegate T ObservableAggregateParam1Delegate<T> (T acc, T value);
	[External]
	public delegate TAcc ObservableAggregateParam2Delegate<T, TAcc> (TAcc acc, T value);
	[External]
	public delegate T ObservableReduceParam1Delegate<T> (T acc, T value);
	[External]
	public delegate TAcc ObservableReduceParam1Delegate<T, TAcc> (TAcc acc, T value);
	[External]
	public delegate boolean ObservableAnyParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableSomeParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableAllParam1Delegate<T> (T value);
	[External]
	public delegate boolean ObservableEveryParam1Delegate<T> (T value);
	[External]
	public delegate boolean ObservableContainsParam2Delegate<T, TOther> (T value1, TOther value2);
	[External]
	public delegate boolean ObservableCountParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate number ObservableSumParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate TKey ObservableMinByParam1Delegate<T, TKey> (T item);
	[External]
	public delegate number ObservableMinByParam2Delegate<T, TKey> (TKey value1, TKey value2);
	[External]
	public delegate number ObservableMinByParam1Delegate<T> (T item);
	[External]
	public delegate number ObservableMinParam1Delegate<T> (T value1, T value2);
	[External]
	public delegate TKey ObservableMaxByParam1Delegate<T, TKey> (T item);
	[External]
	public delegate number ObservableMaxByParam2Delegate<T, TKey> (TKey value1, TKey value2);
	[External]
	public delegate number ObservableMaxByParam1Delegate<T> (T item);
	[External]
	public delegate number ObservableMaxParam1Delegate<T> (T value1, T value2);
	[External]
	public delegate number ObservableAverageParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate number ObservableSequenceEqualParam2Delegate<T, TOther> (T value1, TOther value2);
	[External]
	public delegate number ObservableSequenceEqualParam2Delegate_<T, TOther> (T value1, TOther value2);
	[External]
	public delegate number ObservableSequenceEqualParam2Delegate__<T, TOther> (T value1, TOther value2);
	[External]
	public delegate boolean ObservableSingleParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableFirstParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableLastParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableFindParam1Delegate<T> (T value, number index, Observable<T> source);
	[External]
	public delegate boolean ObservableFindIndexParam1Delegate<T> (T value, number index, Observable<T> source);
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate Observable<T> finalValueDelegate ();

#pragma warning disable CS0626
		public extern Observable<T> FinalValue ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern finalValueDelegate finalValue { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> aggregateDelegate (ObservableAggregateParam1Delegate<T> accumulator);

#pragma warning disable CS0626
		public extern Observable<T> Aggregate (ObservableAggregateParam1Delegate<T> accumulator);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern aggregateDelegate aggregate { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TAcc> aggregateDelegate<TAcc> (TAcc seed, ObservableAggregateParam2Delegate<T, TAcc> accumulator);

#pragma warning disable CS0626
		public extern Observable<TAcc> Aggregate<TAcc> (TAcc seed, ObservableAggregateParam2Delegate<T, TAcc> accumulator);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern aggregateDelegate<TAcc> aggregate<TAcc> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> reduceDelegate (ObservableReduceParam1Delegate<T> accumulator);

#pragma warning disable CS0626
		public extern Observable<T> Reduce (ObservableReduceParam1Delegate<T> accumulator);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern reduceDelegate reduce { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<TAcc> reduceDelegate<TAcc> (ObservableReduceParam1Delegate<T, TAcc> accumulator, TAcc seed);

#pragma warning disable CS0626
		public extern Observable<TAcc> Reduce<TAcc> (ObservableReduceParam1Delegate<T, TAcc> accumulator, TAcc seed);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern reduceDelegate<TAcc> reduce<TAcc> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> anyDelegate (ObservableAnyParam1Delegate<T> predicate = default(ObservableAnyParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<boolean> Any (ObservableAnyParam1Delegate<T> predicate = default(ObservableAnyParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern anyDelegate any { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> someDelegate (ObservableSomeParam1Delegate<T> predicate = default(ObservableSomeParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<boolean> Some (ObservableSomeParam1Delegate<T> predicate = default(ObservableSomeParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern someDelegate some { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> isEmptyDelegate ();

#pragma warning disable CS0626
		public extern Observable<boolean> IsEmpty ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern isEmptyDelegate isEmpty { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> allDelegate (ObservableAllParam1Delegate<T> predicate = default(ObservableAllParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<boolean> All (ObservableAllParam1Delegate<T> predicate = default(ObservableAllParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern allDelegate all { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> everyDelegate (ObservableEveryParam1Delegate<T> predicate = default(ObservableEveryParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<boolean> Every (ObservableEveryParam1Delegate<T> predicate = default(ObservableEveryParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern everyDelegate every { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> containsDelegate (T value);

#pragma warning disable CS0626
		public extern Observable<boolean> Contains (T value);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern containsDelegate contains { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> containsDelegate<TOther> (TOther value, ObservableContainsParam2Delegate<T, TOther> comparer);

#pragma warning disable CS0626
		public extern Observable<boolean> Contains<TOther> (TOther value, ObservableContainsParam2Delegate<T, TOther> comparer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern containsDelegate<TOther> contains<TOther> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<number> countDelegate (ObservableCountParam1Delegate<T> predicate = default(ObservableCountParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<number> Count (ObservableCountParam1Delegate<T> predicate = default(ObservableCountParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern countDelegate count { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<number> sumDelegate (ObservableSumParam1Delegate<T> keySelector = default(ObservableSumParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<number> Sum (ObservableSumParam1Delegate<T> keySelector = default(ObservableSumParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern sumDelegate sum { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> minByDelegate<TKey> (ObservableMinByParam1Delegate<T, TKey> keySelector, ObservableMinByParam2Delegate<T, TKey> comparer);

#pragma warning disable CS0626
		public extern Observable<T> MinBy<TKey> (ObservableMinByParam1Delegate<T, TKey> keySelector, ObservableMinByParam2Delegate<T, TKey> comparer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern minByDelegate<TKey> minBy<TKey> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> minByDelegate (ObservableMinByParam1Delegate<T> keySelector);

#pragma warning disable CS0626
		public extern Observable<T> MinBy (ObservableMinByParam1Delegate<T> keySelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern minByDelegate minBy { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> minDelegate (ObservableMinParam1Delegate<T> comparer = default(ObservableMinParam1Delegate<T>));

#pragma warning disable CS0626
		public extern Observable<T> Min (ObservableMinParam1Delegate<T> comparer = default(ObservableMinParam1Delegate<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern minDelegate min { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> maxByDelegate<TKey> (ObservableMaxByParam1Delegate<T, TKey> keySelector, ObservableMaxByParam2Delegate<T, TKey> comparer);

#pragma warning disable CS0626
		public extern Observable<T> MaxBy<TKey> (ObservableMaxByParam1Delegate<T, TKey> keySelector, ObservableMaxByParam2Delegate<T, TKey> comparer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern maxByDelegate<TKey> maxBy<TKey> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> maxByDelegate (ObservableMaxByParam1Delegate<T> keySelector);

#pragma warning disable CS0626
		public extern Observable<T> MaxBy (ObservableMaxByParam1Delegate<T> keySelector);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern maxByDelegate maxBy { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<number> maxDelegate (ObservableMaxParam1Delegate<T> comparer = default(ObservableMaxParam1Delegate<T>));

#pragma warning disable CS0626
		public extern Observable<number> Max (ObservableMaxParam1Delegate<T> comparer = default(ObservableMaxParam1Delegate<T>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern maxDelegate max { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<number> averageDelegate (ObservableAverageParam1Delegate<T> keySelector = default(ObservableAverageParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<number> Average (ObservableAverageParam1Delegate<T> keySelector = default(ObservableAverageParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern averageDelegate average { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> sequenceEqualDelegate<TOther> (Observable<TOther> second, ObservableSequenceEqualParam2Delegate<T, TOther> comparer);

#pragma warning disable CS0626
		public extern Observable<boolean> SequenceEqual<TOther> (Observable<TOther> second, ObservableSequenceEqualParam2Delegate<T, TOther> comparer);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern sequenceEqualDelegate<TOther> sequenceEqual<TOther> { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<boolean> sequenceEqualDelegate (Observable<T> second);

#pragma warning disable CS0626
		public extern Observable<boolean> SequenceEqual (Observable<T> second);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern sequenceEqualDelegate sequenceEqual { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> elementAtDelegate (number index);

#pragma warning disable CS0626
		public extern Observable<T> ElementAt (number index);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern elementAtDelegate elementAt { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> singleDelegate (ObservableSingleParam1Delegate<T> predicate = default(ObservableSingleParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> Single (ObservableSingleParam1Delegate<T> predicate = default(ObservableSingleParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern singleDelegate single { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> firstDelegate (ObservableFirstParam1Delegate<T> predicate = default(ObservableFirstParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> First (ObservableFirstParam1Delegate<T> predicate = default(ObservableFirstParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern firstDelegate first { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> lastDelegate (ObservableLastParam1Delegate<T> predicate = default(ObservableLastParam1Delegate<T>), any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> Last (ObservableLastParam1Delegate<T> predicate = default(ObservableLastParam1Delegate<T>), any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern lastDelegate last { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<T> findDelegate (ObservableFindParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<T> Find (ObservableFindParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern findDelegate find { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate Observable<number> findIndexDelegate (ObservableFindIndexParam1Delegate<T> predicate, any thisArg = default(any));

#pragma warning disable CS0626
		public extern Observable<number> FindIndex (ObservableFindIndexParam1Delegate<T> predicate, any thisArg = default(any));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern findIndexDelegate findIndex { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		Observable<T> FinalValue ();
		Observable<T> Aggregate (ObservableAggregateParam1Delegate<T> accumulator);
		Observable<TAcc> Aggregate<TAcc> (TAcc seed, ObservableAggregateParam2Delegate<T, TAcc> accumulator);
		Observable<T> Reduce (ObservableReduceParam1Delegate<T> accumulator);
		Observable<TAcc> Reduce<TAcc> (ObservableReduceParam1Delegate<T, TAcc> accumulator, TAcc seed);
		Observable<boolean> Any (ObservableAnyParam1Delegate<T> predicate = default(ObservableAnyParam1Delegate<T>), any thisArg = default(any));
		Observable<boolean> Some (ObservableSomeParam1Delegate<T> predicate = default(ObservableSomeParam1Delegate<T>), any thisArg = default(any));
		Observable<boolean> IsEmpty ();
		Observable<boolean> All (ObservableAllParam1Delegate<T> predicate = default(ObservableAllParam1Delegate<T>), any thisArg = default(any));
		Observable<boolean> Every (ObservableEveryParam1Delegate<T> predicate = default(ObservableEveryParam1Delegate<T>), any thisArg = default(any));
		Observable<boolean> Contains (T value);
		Observable<boolean> Contains<TOther> (TOther value, ObservableContainsParam2Delegate<T, TOther> comparer);
		Observable<number> Count (ObservableCountParam1Delegate<T> predicate = default(ObservableCountParam1Delegate<T>), any thisArg = default(any));
		Observable<number> Sum (ObservableSumParam1Delegate<T> keySelector = default(ObservableSumParam1Delegate<T>), any thisArg = default(any));
		Observable<T> MinBy<TKey> (ObservableMinByParam1Delegate<T, TKey> keySelector, ObservableMinByParam2Delegate<T, TKey> comparer);
		Observable<T> MinBy (ObservableMinByParam1Delegate<T> keySelector);
		Observable<T> Min (ObservableMinParam1Delegate<T> comparer = default(ObservableMinParam1Delegate<T>));
		Observable<T> MaxBy<TKey> (ObservableMaxByParam1Delegate<T, TKey> keySelector, ObservableMaxByParam2Delegate<T, TKey> comparer);
		Observable<T> MaxBy (ObservableMaxByParam1Delegate<T> keySelector);
		Observable<number> Max (ObservableMaxParam1Delegate<T> comparer = default(ObservableMaxParam1Delegate<T>));
		Observable<number> Average (ObservableAverageParam1Delegate<T> keySelector = default(ObservableAverageParam1Delegate<T>), any thisArg = default(any));
		Observable<boolean> SequenceEqual<TOther> (Observable<TOther> second, ObservableSequenceEqualParam2Delegate<T, TOther> comparer);
		Observable<boolean> SequenceEqual<TOther> (IPromise<TOther> second, ObservableSequenceEqualParam2Delegate_<T, TOther> comparer);
		Observable<boolean> SequenceEqual (Observable<T> second);
		Observable<boolean> SequenceEqual (IPromise<T> second);
		Observable<boolean> SequenceEqual<TOther> (TOther[] second, ObservableSequenceEqualParam2Delegate__<T, TOther> comparer);
		Observable<boolean> SequenceEqual (T[] second);
		Observable<T> ElementAt (number index);
		Observable<T> Single (ObservableSingleParam1Delegate<T> predicate = default(ObservableSingleParam1Delegate<T>), any thisArg = default(any));
		Observable<T> First (ObservableFirstParam1Delegate<T> predicate = default(ObservableFirstParam1Delegate<T>), any thisArg = default(any));
		Observable<T> Last (ObservableLastParam1Delegate<T> predicate = default(ObservableLastParam1Delegate<T>), any thisArg = default(any));
		Observable<T> Find (ObservableFindParam1Delegate<T> predicate, any thisArg = default(any));
		Observable<number> FindIndex (ObservableFindIndexParam1Delegate<T> predicate, any thisArg = default(any));
	}

}

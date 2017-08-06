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
	[ObjectLiteral]
	public class JSONObservable<T> : Observable<T>
	{
	[External]
	public delegate PausableObservable<T> pausableDelegate (Observable<boolean> pauser = default(Observable<boolean>));

#pragma warning disable CS0626
		public extern PausableObservable<T> Pausable (Observable<boolean> pauser = default(Observable<boolean>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pausableDelegate pausable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate PausableObservable<T> pausableBufferedDelegate (Observable<boolean> pauser = default(Observable<boolean>));

#pragma warning disable CS0626
		public extern PausableObservable<T> PausableBuffered (Observable<boolean> pauser = default(Observable<boolean>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pausableBufferedDelegate pausableBuffered { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ControlledObservable<T> controlledDelegate (boolean enableQueue = default(boolean));

#pragma warning disable CS0626
		public extern ControlledObservable<T> Controlled (boolean enableQueue = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern controlledDelegate controlled { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface Observable<T>
	{
		PausableObservable<T> Pausable (Observable<boolean> pauser = default(Observable<boolean>));
		PausableObservable<T> PausableBuffered (Observable<boolean> pauser = default(Observable<boolean>));
		ControlledObservable<T> Controlled (boolean enableQueue = default(boolean));
	}
	[ObjectLiteral]
	public class JSONControlledObservable<T> : ControlledObservable<T>
	{
	[External]
	public delegate IDisposable requestDelegate (number numberOfItems = default(number));

#pragma warning disable CS0626
		public extern IDisposable Request (number numberOfItems = default(number));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern requestDelegate request { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate PausableObservable<T> pausableDelegate (Observable<boolean> pauser = default(Observable<boolean>));

#pragma warning disable CS0626
		public extern PausableObservable<T> Pausable (Observable<boolean> pauser = default(Observable<boolean>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pausableDelegate pausable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate PausableObservable<T> pausableBufferedDelegate (Observable<boolean> pauser = default(Observable<boolean>));

#pragma warning disable CS0626
		public extern PausableObservable<T> PausableBuffered (Observable<boolean> pauser = default(Observable<boolean>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pausableBufferedDelegate pausableBuffered { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ControlledObservable<T> controlledDelegate (boolean enableQueue = default(boolean));

#pragma warning disable CS0626
		public extern ControlledObservable<T> Controlled (boolean enableQueue = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern controlledDelegate controlled { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface ControlledObservable<T> : Observable<T>
	{
		IDisposable Request (number numberOfItems = default(number));
	}
	[ObjectLiteral]
	public class JSONPausableObservable<T> : PausableObservable<T>
	{
	[External]
	public delegate void pauseDelegate ();

#pragma warning disable CS0626
		public extern void Pause ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pauseDelegate pause { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate void resumeDelegate ();

#pragma warning disable CS0626
		public extern void Resume ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern resumeDelegate resume { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate PausableObservable<T> pausableDelegate (Observable<boolean> pauser = default(Observable<boolean>));

#pragma warning disable CS0626
		public extern PausableObservable<T> Pausable (Observable<boolean> pauser = default(Observable<boolean>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pausableDelegate pausable { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate PausableObservable<T> pausableBufferedDelegate (Observable<boolean> pauser = default(Observable<boolean>));

#pragma warning disable CS0626
		public extern PausableObservable<T> PausableBuffered (Observable<boolean> pauser = default(Observable<boolean>));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern pausableBufferedDelegate pausableBuffered { get; set; }
#pragma warning restore CS0626
	[External]
	public delegate ControlledObservable<T> controlledDelegate (boolean enableQueue = default(boolean));

#pragma warning disable CS0626
		public extern ControlledObservable<T> Controlled (boolean enableQueue = default(boolean));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern controlledDelegate controlled { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface PausableObservable<T> : Observable<T>
	{
		void Pause ();
		void Resume ();
	}

}

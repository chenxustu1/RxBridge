//Apache 2.0 license note
//Original code here: https://github.com/Reactive-Extensions/Rx.NET/tree/v3.1.1
//I have changed this code in all the places marked with #RX_BRIDGE
//I have also added all of the code in the ./Bridge directory
// I think I have to include this: http://www.apache.org/licenses/LICENSE-2.0


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if RX_BRIDGE

namespace RxBridge
{
   internal static class Environment
   {
      public static bool HasShutdownStarted
      {
         get { return false; }
      }
   }
}

namespace System.Reactive
{
   internal interface IServiceProvider
   {
      object GetService(Type serviceType);
   }

   internal class Strings_Core
   {
      public const string FAILED_CLOCK_MONITORING = "FAILED_CLOCK_MONITORING";
      public const string CANT_OBTAIN_SCHEDULER = "CANT_OBTAIN_SCHEDULER";
      public const string DISPOSABLES_CANT_CONTAIN_NULL = "DISPOSABLES_CANT_CONTAIN_NULL";
      public const string DISPOSABLE_ALREADY_ASSIGNED = "DISPOSABLE_ALREADY_ASSIGNED";
      public const string REENTRANCY_DETECTED = "REENTRANCY_DETECTED";
      public const string OBSERVER_TERMINATED = "OBSERVER_TERMINATED";
      public const string HEAP_EMPTY = "HEAP_EMPTY";
      public const string COMPLETED_NO_VALUE = "COMPLETED_NO_VALUE";      
   }
   internal class Strings_Linq
   {
      public const string NO_ELEMENTS = "NO_ELEMENTS";
      public const string MORE_THAN_ONE_ELEMENT = "MORE_THAN_ONE_ELEMENT";
      public const string CANT_ADVANCE_WHILE_RUNNING = "CANT_ADVANCE_WHILE_RUNNING";
      public const string EVENT_MISSING_ADD_METHOD = "EVENT_MISSING_ADD_METHOD";
      public const string EVENT_MISSING_REMOVE_METHOD = "EVENT_MISSING_REMOVE_METHOD";
      public const string EVENT_ADD_METHOD_SHOULD_TAKE_ONE_PARAMETER = "EVENT_ADD_METHOD_SHOULD_TAKE_ONE_PARAMETER";
      public const string EVENT_REMOVE_METHOD_SHOULD_TAKE_ONE_PARAMETER = "EVENT_REMOVE_METHOD_SHOULD_TAKE_ONE_PARAMETER";
      public const string COULD_NOT_FIND_INSTANCE_EVENT = "COULD_NOT_FIND_INSTANCE_EVENT";
      public const string COULD_NOT_FIND_STATIC_EVENT = "COULD_NOT_FIND_STATIC_EVENT";
      public const string EVENT_PATTERN_REQUIRES_TWO_PARAMETERS = "EVENT_PATTERN_REQUIRES_TWO_PARAMETERS";
      public const string EVENT_SENDER_NOT_ASSIGNABLE = "EVENT_SENDER_NOT_ASSIGNABLE";
      public const string EVENT_ARGS_NOT_ASSIGNABLE = "EVENT_ARGS_NOT_ASSIGNABLE";
      public const string EVENT_MUST_RETURN_VOID = "EVENT_MUST_RETURN_VOID";
      public const string NO_MATCHING_ELEMENTS = "NO_MATCHING_ELEMENTS";
      public const string MORE_THAN_ONE_MATCHING_ELEMENT = "MORE_THAN_ONE_MATCHING_ELEMENT";
   }
}

namespace System.Threading
{
   /// <summary>
   /// This class is a hack to facilitate Bridge.net compatibility, use at your own risk
   /// </summary>
   internal class ManualResetEvent : IDisposable
   {
      protected bool _state;
      public ManualResetEvent(bool initial)
      {
         _state = initial;
      }
      public void Set()
      {
         _state = true;
      }
      public bool WaitOne(int period = -1)
      {
         if(period < 0)
         {
            while(!_state)
               System.Threading.Thread.Sleep(1);
         }
         else
         {
            bool abort = false;
            new Timer(x => abort = true, null, period, Timeout.Infinite);
            while(!_state && !abort)
               System.Threading.Thread.Sleep(1);
         }
         return _state;
      }
      public void Dispose()
      {
         Set();
      }
   }

   /// <summary>
   /// This class is a hack to facilitate Bridge.net compatibility, use at your own risk
   /// </summary>
   internal class AutoResetEvent : ManualResetEvent
   {
      public AutoResetEvent(bool initial) : base(initial) { }
      public void Reset() { _state = false; }
   }
}

namespace System.Runtime.CompilerServices
{
   [AttributeUsage(AttributeTargets.All)]
   internal class CompilerGeneratedAttribute : Attribute
   {
      public CompilerGeneratedAttribute()
      {
      }
   }
}


namespace System.Reflection
{
   internal static class EventInfoExtensions
   {
      public static MethodInfo GetAddMethod(this EventInfo evt)
      {
         return null;
      }
      public static MethodInfo GetRemoveMethod(this EventInfo evt)
      {
         return null;
      }
   }
}

namespace System
{
   internal static class Interlocked
   {
      public static T CompareExchange<T>(ref T location1, T value, T comparand)
      {
         var val = location1;
         if(location1.Equals(comparand))
            location1 = value;
         return val;
      }

      public static T Exchange<T>(ref T location1, T value)
      {
         var val = location1;
         location1 = value;
         return val;
      }

      public static int Increment(ref int location)
      {
         location++;
         return location;
      }

      public static int Decrement(ref int location)
      {
         location--;
         return location;
      }

      public static long Increment(ref long location)
      {
         location++;
         return location;
      }

      public static long Decrement(ref long location)
      {
         location--;
         return location;
      }
   }
}

namespace System
{
   internal delegate void AsyncCallback(IAsyncResult ar);
   internal interface IAsyncResult
   {
      bool IsCompleted { get; }
      //WaitHandle AsyncWaitHandle { get; }
      Object AsyncState { get; }
      bool CompletedSynchronously { get; }
   }
}

namespace System
{

   internal class ObjectDisposedException : Exception
   {
      public ObjectDisposedException(string msg) : base(msg) { }
   }

   internal class TargetInvocationException : Exception
   {
      public TargetInvocationException(string msg) : base(msg) { }
   }

   internal class WeakReference<T>
   {
      readonly T _value;
      public WeakReference(T value)
      {
         _value = value;
      }
      public bool TryGetTarget(out T val)
      {
         val = _value;
         return true;
      }
   }
   internal class GC
   {
      static public void SuppressFinalize(object obj) { }
   }
}

namespace System
{
   internal enum DateTimeKind
   {
      Local, Unspecified, Utc
   }

   internal static class DateTimeExtensions
   {
      public static long ToFileTime(this DateTime dt)
      {
         return 0;
      }

      public static DateTime SpecifyKind(this DateTime unused_for_static, DateTime dt, DateTimeKind kind)
      {
         if(kind == DateTimeKind.Utc)
            return dt.ToUniversalTime();
         else if(kind == DateTimeKind.Local)
            return dt.ToLocalTime();
         else
            return dt;
      }

      public static DateTimeKind Kind(this DateTime dt)
      {
         if(dt.Equals(dt.ToLocalTime()))
            return DateTimeKind.Local;
         else if(dt.Equals(dt.ToUniversalTime()))
            return DateTimeKind.Utc;
         else
            return DateTimeKind.Unspecified;
      }
   }

   internal class TimeZone
   {
      internal static TimeZone CurrentTimeZone = new TimeZone();
      public TimeSpan GetUtcOffset(DateTime dt)
      {
         return new TimeSpan(dt.GetTimezoneOffset(), 0, 0);
      }
   }
}

namespace System.Runtime.Serialization { }
namespace System.Security.Permissions { }

namespace System.Reactive.Concurrency
{
   internal class CurrentThreadScheduler : LocalScheduler
   {
      private static readonly Lazy<CurrentThreadScheduler> s_instance = new Lazy<CurrentThreadScheduler>(() => new CurrentThreadScheduler());
      CurrentThreadScheduler()
      {
      }

      internal static CurrentThreadScheduler Instance
      {
         get { return s_instance.Value; }
      }

      static public bool IsScheduleRequired
      {
         get
         {
            return false;
         }
      }

      public override IDisposable Schedule<TState>(TState state, TimeSpan dueTime, Func<IScheduler, TState, IDisposable> action)
      {
         return ImmediateScheduler.Instance.Schedule<TState>(state, dueTime, action);
      }
   }
}


#endif
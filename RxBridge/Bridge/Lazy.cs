#if RX_BRIDGE

using System.Threading;

namespace System
{
   internal class Lazy<T>
   {
      class Boxed
      {
         internal Boxed(T value)
         {
            this.value = value;
         }
         internal T value;
      }

      readonly object _lock;
      readonly Func<T> _value;
      object _boxed;
      public Lazy(Func<T> valueFactory, bool isThreadSafe)
      {
         _value = valueFactory;
         _lock = (isThreadSafe) ? new object() : null;
      }

      public Lazy(Func<T> valueFactory) : this(valueFactory, true) { }

      public bool IsValueCreated
      {
         get
         {
            return _boxed != null && _boxed is Boxed;
         }
      }

      public T Value
      {
         get
         {
            Boxed boxed = null;
            if(_boxed != null)
            {
               // Do a quick check up front for the fast path.
               boxed = _boxed as Boxed;
               if(boxed != null)
               {
                  return boxed.value;
               }
               throw new Exception("this shouldn't happen");
            }
            return LazyInitValue();
         }
      }

      private T LazyInitValue()
      {
         Boxed boxed = null;
         if(_lock == null)
            boxed = new Boxed(_value());
         else
         {
            lock(_lock)
            {
               if(_boxed == null)
                  _boxed = boxed = new Boxed(_value());
            }

            //bool locked = false;
            //try
            //{
            //   Monitor.Enter(_lock, ref locked);
            //   if(_boxed == null)
            //      _boxed = boxed = new Boxed(_value());
            //}
            //finally
            //{
            //   if(locked)
            //      Monitor.Exit(_lock);
            //}
         }
         return boxed.value;
      }
   }
}
#endif
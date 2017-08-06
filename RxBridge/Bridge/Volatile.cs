#if RX_BRIDGE

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Runtime.CompilerServices;
using System.Runtime;
using System.Security;

using Interlocked = System.Interlocked;

namespace System.Threading
{
   /// <summary>
   /// Non-Volatile Volatile class for Bridge.net support
   /// </summary>
   internal static class Volatile
   {
      public static bool Read(ref bool location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static sbyte Read(ref sbyte location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static byte Read(ref byte location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static short Read(ref short location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static ushort Read(ref ushort location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static int Read(ref int location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static uint Read(ref uint location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static long Read(ref long location)
      {
         //
         // On 32-bit machines, we use this implementation, since an ordinary volatile read
         // would not be atomic.
         //
         // On 64-bit machines, the VM will replace this with a more efficient implementation.
         //
         return System.Interlocked.CompareExchange(ref location, 0, 0);
      }

      public static IntPtr Read(ref IntPtr location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }


      public static UIntPtr Read(ref UIntPtr location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static float Read(ref float location)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }

      public static double Read(ref double location)
      {
         //
         // On 32-bit machines, we use this implementation, since an ordinary volatile read
         // would not be atomic.
         //
         // On 64-bit machines, the VM will replace this with a more efficient implementation.
         //
         return System.Interlocked.CompareExchange(ref location, 0, 0);
      }

      public static T Read<T>(ref T location) where T : class
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         var value = location;
         //Thread.MemoryBarrier();
         return value;
      }



      public static void Write(ref bool location, bool value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref sbyte location, sbyte value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref byte location, byte value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref short location, short value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref ushort location, ushort value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref int location, int value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref uint location, uint value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref long location, long value)
      {
         //
         // On 32-bit machines, we use this implementation, since an ordinary volatile write 
         // would not be atomic.
         //
         // On 64-bit machines, the VM will replace this with a more efficient implementation.
         //
         System.Interlocked.Exchange(ref location, value);
      }

      public static void Write(ref IntPtr location, IntPtr value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref UIntPtr location, UIntPtr value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref float location, float value)
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }

      public static void Write(ref double location, double value)
      {
         //
         // On 32-bit machines, we use this implementation, since an ordinary volatile write 
         // would not be atomic.
         //
         // On 64-bit machines, the VM will replace this with a more efficient implementation.
         //
         System.Interlocked.Exchange(ref location, value);
      }

      public static void Write<T>(ref T location, T value) where T : class
      {
         // 
         // The VM will replace this with a more efficient implementation.
         //
         //Thread.MemoryBarrier();
         location = value;
      }
   }
}
#endif
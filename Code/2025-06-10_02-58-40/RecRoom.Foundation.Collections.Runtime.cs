using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Foundation_Collections_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C523E0", Offset = "0x7C515E0", VA = "0x187C523E0", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[MMPJPOKPLFC]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3B636C0", Offset = "0x3B628C0", VA = "0x183B636C0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[MMPJPOKPLFC]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B647D0", Offset = "0x3B639D0", VA = "0x183B647D0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3B63840", Offset = "0x3B62A40", VA = "0x183B63840")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3B639A0", Offset = "0x3B62BA0", VA = "0x183B639A0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3B6CA20", Offset = "0x3B6BC20", VA = "0x183B6CA20")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C8B0", Offset = "0x3B6BAB0", VA = "0x183B6C8B0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D0E0", Offset = "0x3B6C2E0", VA = "0x183B6D0E0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D1E0", Offset = "0x3B6C3E0", VA = "0x183B6D1E0")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B64E00", Offset = "0x3B64000", VA = "0x183B64E00")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B64EC0", Offset = "0x3B640C0", VA = "0x183B64EC0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B65320", Offset = "0x3B64520", VA = "0x183B65320")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, BMJBNELGBIH range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B65360", Offset = "0x3B64560", VA = "0x183B65360")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3B651A0", Offset = "0x3B643A0", VA = "0x183B651A0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B63710", Offset = "0x3B62910", VA = "0x183B63710")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C960", Offset = "0x3B6BB60", VA = "0x183B6C960")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[MMPJPOKPLFC]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D2B0", Offset = "0x3B6C4B0", VA = "0x183B6D2B0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B6EF40", Offset = "0x3B6E140", VA = "0x183B6EF40")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B6EF50", Offset = "0x3B6E150", VA = "0x183B6EF50")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5011890", Offset = "0x5010A90", VA = "0x185011890")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C52BD0", Offset = "0x7C51DD0", VA = "0x187C52BD0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C52C00", Offset = "0x7C51E00", VA = "0x187C52C00")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E610", Offset = "0x3B6D810", VA = "0x183B6E610")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E400", Offset = "0x3B6D600", VA = "0x183B6E400")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E870", Offset = "0x3B6DA70", VA = "0x183B6E870")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E7A0", Offset = "0x3B6D9A0", VA = "0x183B6E7A0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E8C0", Offset = "0x3B6DAC0", VA = "0x183B6E8C0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E4D0", Offset = "0x3B6D6D0", VA = "0x183B6E4D0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3B6EB40", Offset = "0x3B6DD40", VA = "0x183B6EB40")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E9A0", Offset = "0x3B6DBA0", VA = "0x183B6E9A0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E380", Offset = "0x3B6D580", VA = "0x183B6E380")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E320", Offset = "0x3B6D520", VA = "0x183B6E320")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3B6E300", Offset = "0x3B6D500", VA = "0x183B6E300")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F370", Offset = "0x3B6E570", VA = "0x183B6F370")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B6EFA0", Offset = "0x3B6E1A0", VA = "0x183B6EFA0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F3A0", Offset = "0x3B6E5A0", VA = "0x183B6F3A0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F450", Offset = "0x3B6E650", VA = "0x183B6F450")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[MMPJPOKPLFC]
	public readonly struct NativeArrayAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x4C8B5D0", Offset = "0x4C8A7D0", VA = "0x184C8B5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE16590", Offset = "0xE15790", VA = "0x180E16590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x51CF240", Offset = "0x51CE440", VA = "0x1851CF240")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5513C30", Offset = "0x5512E30", VA = "0x185513C30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x55139E0", Offset = "0x5512BE0", VA = "0x1855139E0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4168890", Offset = "0x4167A90", VA = "0x184168890")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[MMPJPOKPLFC]
	public readonly struct NativeListAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly NativeList<T> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4C8B5D0", Offset = "0x4C8A7D0", VA = "0x184C8B5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5566240", Offset = "0x5565440", VA = "0x185566240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x51CF240", Offset = "0x51CE440", VA = "0x1851CF240")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5565DE0", Offset = "0x5564FE0", VA = "0x185565DE0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5565F80", Offset = "0x5565180", VA = "0x185565F80")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5566160", Offset = "0x5565360", VA = "0x185566160", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5565FC0", Offset = "0x55651C0", VA = "0x185565FC0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[MMPJPOKPLFC]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[MMPJPOKPLFC]
public static class KCAKHIBICLL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C51E60", Offset = "0x7C51060", VA = "0x187C51E60")]
	public static JobHandle BAIIKHNBBGO(this JobHandle BGPKBCGBDMP, JobHandle NIJBGCGEGBN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C51EA0", Offset = "0x7C510A0", VA = "0x187C51EA0")]
	public static JobHandle IEPHGJOKNAK(this Span<JobHandle> ILJPGEOGGKI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KNILMJNHGFK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x36AB750", Offset = "0x36AA950", VA = "0x1836AB750")]
	public static void OLKFAGPLGGN<T>(this T[] KBILCKNPAKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class CDFNEFPDNGP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x37EF980", Offset = "0x37EEB80", VA = "0x1837EF980")]
	public static NativeKeyValueArrays<TKey, TValue> DOAHKPNHHNG<TKey, TValue>(this Dictionary<TKey, TValue> MGGGOEHGEIK, Allocator DPAKHKILCMF) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LFCAAPPCBIN
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C52200", Offset = "0x7C51400", VA = "0x187C52200")]
	public static void HMJCKFHPCII(this GameObject LBBGHAOMHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C52340", Offset = "0x7C51540", VA = "0x187C52340")]
	public static void HMJCKFHPCII(this Component JCAGDPHNPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C522A0", Offset = "0x7C514A0", VA = "0x187C522A0")]
	public static void HMJCKFHPCII(this ScriptableObject OGLIILBBHFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JAILNONGEJC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C51D80", Offset = "0x7C50F80", VA = "0x187C51D80")]
	public static void JKECMACEHMD(this NativeList<byte> CFFEIIKPOPD, ReadOnlySpan<byte> KGIGBPHOIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A61960", Offset = "0x3A60B60", VA = "0x183A61960")]
	public static void LEDHFGFACEN<T>(this NativeList<T> CFFEIIKPOPD, T KJIOHKMJAPE, int OCEHNHGKKJH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PLNJHCOFANJ
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE730", Offset = "0x3BCD930", VA = "0x183BCE730")]
	public static T MFCONBLAIMN<T>(this ReadOnlySpan<byte> KJIOHKMJAPE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE010", Offset = "0x3BCD210", VA = "0x183BCE010")]
	public static T DAGFOBHLLAC<T>(this Span<T> KGIGBPHOIPK, Func<T, bool> DODOMGCMOEG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE6A0", Offset = "0x3BCD8A0", VA = "0x183BCE6A0")]
	public static bool GHOELHMHBHL<T>(this Span<T> KGIGBPHOIPK, Func<T, bool> DODOMGCMOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE970", Offset = "0x3BCDB70", VA = "0x183BCE970")]
	public static bool MGCDHBAPECL<T>(this Span<T> KGIGBPHOIPK, Func<T, bool> DODOMGCMOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3BCDBB0", Offset = "0x3BCCDB0", VA = "0x183BCDBB0")]
	public static T AFHCIICHJIO<T>([In] this ReadOnlySpan<byte> KGIGBPHOIPK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A63C30", Offset = "0x3A62E30", VA = "0x183A63C30")]
	public static Span<TTo> CLIAAGNOFOA<TTo, TFrom>(this Span<TFrom> KGIGBPHOIPK) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A63C30", Offset = "0x3A62E30", VA = "0x183A63C30")]
	public static ReadOnlySpan<TTo> CLIAAGNOFOA<TTo, TFrom>(this ReadOnlySpan<TFrom> KGIGBPHOIPK) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A63C30", Offset = "0x3A62E30", VA = "0x183A63C30")]
	public static ReadOnlySpan<TTo> CLIAAGNOFOA<TTo>(this ReadOnlySpan<byte> KGIGBPHOIPK) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE5B0", Offset = "0x3BCD7B0", VA = "0x183BCE5B0")]
	public static Span<T> EDIKNCAPOAM<T>(this ReadOnlySpan<T> LMDCFNDMKMH) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE130", Offset = "0x3BCD330", VA = "0x183BCE130")]
	public static Span<byte> DEEMOOGCBGF<T>([In] this Span<byte> KGIGBPHOIPK, T KJIOHKMJAPE) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C52C30", Offset = "0x7C51E30", VA = "0x187C52C30")]
	private static Enum EEMIJGGJNKE([In] ReadOnlySpan<byte> KGIGBPHOIPK, Type MFFKACCIKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C531D0", Offset = "0x7C523D0", VA = "0x187C531D0")]
	public static Enum EHNLCLOOIBH([In] this Span<byte> KGIGBPHOIPK, Type MFFKACCIKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C53240", Offset = "0x7C52440", VA = "0x187C53240")]
	public static void IGFBJIPNOEN([In] this Span<byte> KGIGBPHOIPK, Enum GDKPICOHMLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EMPBPOABOJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EOBGPHOJEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C51C00", Offset = "0x7C50E00", VA = "0x187C51C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C51AE0", Offset = "0x7C50CE0", VA = "0x187C51AE0")]
	[AsyncStateMachine(typeof(EOBGPHOJEMG))]
	public static void FPGCOLOJIPK(this Task DACBPJEFOKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GLECIENJCOD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D630", Offset = "0x3A0C830", VA = "0x183A0D630")]
	public static NativeArray<T> IENDLAOGMGO<T>(this UnsafeList<T> CFFEIIKPOPD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D510", Offset = "0x3A0C710", VA = "0x183A0D510")]
	public static NativeArray<T> DIJDGNALOLC<T>(this UnsafeList<T> CFFEIIKPOPD, bool BODGJLLPAHO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D580", Offset = "0x3A0C780", VA = "0x183A0D580")]
	public static UnsafeList<T> EDIKNCAPOAM<T>(this UnsafeList<T> CFFEIIKPOPD, Allocator DPAKHKILCMF) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CLIININNGAG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum PCNFKKNKOIH : short
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Uncategorized,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		ObjectModel,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		SplineWrapper,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Scalability,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		UpdateAllocator,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Snapshot,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		ShadowEntities,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		PostLoadNetworkIdSystem,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Singleton,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		COUNT
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct AKDGDENENFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly PCNFKKNKOIH MHDODBCCAJB;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2F37ED0", Offset = "0x2F370D0", VA = "0x182F37ED0")]
		public AKDGDENENFL(PCNFKKNKOIH MHDODBCCAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory JDEHBEJMLMF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	public static void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C51550", Offset = "0x7C50750", VA = "0x187C51550")]
	static CLIININNGAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x36AAE60", Offset = "0x36AA060", VA = "0x1836AAE60")]
	public static AKDGDENENFL DLDMJFHEBKE(PCNFKKNKOIH MHDODBCCAJB)
	{
		return default(AKDGDENENFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	public static void DFAMECJBBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KBHMGBNIJIN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F6B0", Offset = "0x2A8E8B0", VA = "0x182A8F6B0")]
	public static NHPBDMPEHPP<T1, T2> CPNCLNJGGMA<T1, T2>(this (T1, T2) CFCICIOAJCD) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(NHPBDMPEHPP<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B6E0", Offset = "0x3A1A8E0", VA = "0x183A1B6E0")]
	public static BOGJDDAEFMG<T1, T2, T3> CPNCLNJGGMA<T1, T2, T3>(this (T1, T2, T3) CFCICIOAJCD) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(BOGJDDAEFMG<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NHPBDMPEHPP<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) CFCICIOAJCD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FBC0", Offset = "0x2A8EDC0", VA = "0x182A8FBC0")]
	public NHPBDMPEHPP((T1, T2) CFCICIOAJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x548F4D0", Offset = "0x548E6D0", VA = "0x18548F4D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BOGJDDAEFMG<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) CFCICIOAJCD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x548F880", Offset = "0x548EA80", VA = "0x18548F880")]
	public BOGJDDAEFMG((T1, T2, T3) CFCICIOAJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6342100", Offset = "0x6341300", VA = "0x186342100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JJABBHBJFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C51E00", Offset = "0x7C51000", VA = "0x187C51E00")]
	public static Range EGFFNLIEJLD(this BMJBNELGBIH CFPNMKPLIJH)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class ECJDCHJBPBP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct EJBOGBOPNFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int ALPNOAKDGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int GCHDNICOBCO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C51AD0", Offset = "0x7C50CD0", VA = "0x187C51AD0")]
		public EJBOGBOPNFM(int EIGANLKFLHL, int GCHDNICOBCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C51AC0", Offset = "0x7C50CC0", VA = "0x187C51AC0")]
		public bool ICPIGBJELHK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C516C0", Offset = "0x7C508C0", VA = "0x187C516C0")]
	public static EJBOGBOPNFM BFKODFEKGDL(this Range CFPNMKPLIJH)
	{
		return default(EJBOGBOPNFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct ANCIKPOIOFG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle BIFBBDMNGPL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LPBBHPPNAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5011AE0", Offset = "0x5010CE0", VA = "0x185011AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5011A30", Offset = "0x5010C30", VA = "0x185011A30")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5011DA0", Offset = "0x5010FA0", VA = "0x185011DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x50120A0", Offset = "0x50112A0", VA = "0x1850120A0")]
	public ANCIKPOIOFG(T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5011890", Offset = "0x5010A90", VA = "0x185011890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class KJOGDKEPJKC<THandle, TValue> : IDisposable where THandle : struct, JHEBGNDPGNA where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> ILJPGEOGGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> LMKJLPPFOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> NODGAELKNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> DPCIBMMLLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int DIBKHODLKPM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x513AC40", Offset = "0x5139E40", VA = "0x18513AC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x513B100", Offset = "0x513A300", VA = "0x18513B100")]
	public KJOGDKEPJKC(Action<TValue> DPCIBMMLLOG, [Optional] Func<TValue> NODGAELKNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x513AAA0", Offset = "0x5139CA0", VA = "0x18513AAA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x513AE60", Offset = "0x513A060", VA = "0x18513AE60")]
	public THandle LHOMNBOIMGH(TValue KJIOHKMJAPE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x513A7C0", Offset = "0x51399C0", VA = "0x18513A7C0")]
	public bool BEPHGAAGPAM(THandle BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x513ADB0", Offset = "0x5139FB0", VA = "0x18513ADB0")]
	public bool LHFIILLJKMI(THandle BIFBBDMNGPL, [Out] TValue KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x513A770", Offset = "0x5139970", VA = "0x18513A770")]
	public TValue AFHCIICHJIO(THandle BIFBBDMNGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x513AB20", Offset = "0x5139D20", VA = "0x18513AB20")]
	public bool IBDFDDCHHCK(THandle BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x513AFA0", Offset = "0x513A1A0", VA = "0x18513AFA0")]
	private THandle OHHEAOGPNDB(int CMDFFDAPDIB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x513AC00", Offset = "0x5139E00", VA = "0x18513AC00")]
	private TValue JKBBNFBIFNP(int CMDFFDAPDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x513B0C0", Offset = "0x513A2C0", VA = "0x18513B0C0")]
	private void PPAJCKEKGGI(int CMDFFDAPDIB, [In] THandle BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x513B080", Offset = "0x513A280", VA = "0x18513B080")]
	private void PLOIEIGKCLK(int CMDFFDAPDIB, [In] TValue KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x513AC70", Offset = "0x5139E70", VA = "0x18513AC70")]
	private THandle LBOHLNGMNFI()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x513A9E0", Offset = "0x5139BE0", VA = "0x18513A9E0")]
	private void DNOOHKCDCAG(THandle BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x513AFE0", Offset = "0x513A1E0", VA = "0x18513AFE0")]
	private int OJEAAAOIABG(int EPCDIDIGEAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x513B0B0", Offset = "0x513A2B0", VA = "0x18513B0B0")]
	private bool PMDMAAADAEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA00F40", Offset = "0xA00140", VA = "0x180A00F40")]
	private void POJDKEDIIEA(THandle BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x513AFF0", Offset = "0x513A1F0", VA = "0x18513AFF0")]
	private bool OPBNDAMCCNE([Out] THandle BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x513AED0", Offset = "0x513A0D0", VA = "0x18513AED0")]
	private bool OBGMMBGIAKK([Out] THandle BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x513A8A0", Offset = "0x5139AA0", VA = "0x18513A8A0")]
	private void CDJGNEAIJEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JHEBGNDPGNA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int IJCKDBACFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int HNJNJKKAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MBLPHHONKCB
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8700", Offset = "0x3AE7900", VA = "0x183AE8700")]
	public static bool NKMMNDJFKKJ<T>(this T BIFBBDMNGPL, T CMOCFNBHPLJ) where T : struct, JHEBGNDPGNA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AE86F0", Offset = "0x3AE78F0", VA = "0x183AE86F0")]
	public static bool APFGOMCKPFB<T>(this T BIFBBDMNGPL) where T : struct, JHEBGNDPGNA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C52470", Offset = "0x7C51670", VA = "0x187C52470")]
	public static string OFOIBKAHLEB(this JHEBGNDPGNA BIFBBDMNGPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct COFGDNEKJBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type CENFOOCFHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> OBDKMIDBACK;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x51CF270", Offset = "0x51CE470", VA = "0x1851CF270")]
	public COFGDNEKJBL(Type GPCMFIFGGGE, Span<byte> KGIGBPHOIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37FD8A0", Offset = "0x37FCAA0", VA = "0x1837FD8A0")]
	public static COFGDNEKJBL DELEFIJNGAA<T>(T KJIOHKMJAPE) where T : struct
	{
		return default(COFGDNEKJBL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C51640", Offset = "0x7C50840", VA = "0x187C51640")]
	public static ECNHDPCIGGN PDHAGBEBCNG([In] COFGDNEKJBL EJNMHOGNAED)
	{
		return default(ECNHDPCIGGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C515B0", Offset = "0x7C507B0", VA = "0x187C515B0")]
	public Enum EHNLCLOOIBH(Type MFFKACCIKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37FD870", Offset = "0x37FCA70", VA = "0x1837FD870")]
	public void DEEMOOGCBGF<T>([In] T KJIOHKMJAPE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C51630", Offset = "0x7C50830", VA = "0x187C51630")]
	public void IGFBJIPNOEN(Enum GDKPICOHMLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct ECNHDPCIGGN
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct IOCCIECKGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* FJCBIBANOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* OEMGHFPDJLC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type CENFOOCFHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> OBDKMIDBACK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PIKCEFMKLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C518E0", Offset = "0x7C50AE0", VA = "0x187C518E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DPAJFMGACKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7C518F0", Offset = "0x7C50AF0", VA = "0x187C518F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x51CF270", Offset = "0x51CE470", VA = "0x1851CF270")]
	public ECNHDPCIGGN(Type GPCMFIFGGGE, ReadOnlySpan<byte> KGIGBPHOIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3883790", Offset = "0x3882990", VA = "0x183883790")]
	public static ECNHDPCIGGN DELEFIJNGAA<T>(T KJIOHKMJAPE) where T : struct
	{
		return default(ECNHDPCIGGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C51940", Offset = "0x7C50B40", VA = "0x187C51940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C51710", Offset = "0x7C50910", VA = "0x187C51710")]
	public object EHBNCLFPCEK(int CMDFFDAPDIB = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NPCFOCBIHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B62F90", Offset = "0x3B62190", VA = "0x183B62F90")]
	public static NativeArray<T> DELEFIJNGAA<T>(T KJIOHKMJAPE, bool BODGJLLPAHO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B62FD0", Offset = "0x3B621D0", VA = "0x183B62FD0")]
	public static NativeArray<T> PJFNLGICNHN<T>(T KJIOHKMJAPE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B62F60", Offset = "0x3B62160", VA = "0x183B62F60")]
	public static NativeArray<T> BENMCDFPLNJ<T>(T KJIOHKMJAPE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C529E0", Offset = "0x7C51BE0", VA = "0x187C529E0")]
	public static NativeArray<byte> BENMCDFPLNJ(ReadOnlySpan<byte> KJIOHKMJAPE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C52AA0", Offset = "0x7C51CA0", VA = "0x187C52AA0")]
	public static NativeArray<byte> DELEFIJNGAA(ReadOnlySpan<byte> KJIOHKMJAPE, bool BODGJLLPAHO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C52B50", Offset = "0x7C51D50", VA = "0x187C52B50")]
	public unsafe static NativeArray<byte> DELEFIJNGAA(byte* GCCMBHDIADP, int CLBDAFJFHFB, bool BODGJLLPAHO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B62EF0", Offset = "0x3B620F0", VA = "0x183B62EF0")]
	public static NativeArray<T> BCEMEONNHIA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct KFBHOFDBCJO : IEquatable<KFBHOFDBCJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int JBACALNNIPN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type BGLOFMKFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C51FE0", Offset = "0x7C511E0", VA = "0x187C51FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C52160", Offset = "0x7C51360", VA = "0x187C52160")]
	public KFBHOFDBCJO(Type GDHKDBJPDLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C52090", Offset = "0x7C51290", VA = "0x187C52090")]
	public static KFBHOFDBCJO PDHAGBEBCNG(Type GDHKDBJPDLG)
	{
		return default(KFBHOFDBCJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2273C90", Offset = "0x2272E90", VA = "0x182273C90", Slot = "4")]
	public bool Equals(KFBHOFDBCJO CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C51F50", Offset = "0x7C51150", VA = "0x187C51F50", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C52120", Offset = "0x7C51320", VA = "0x187C52120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class MMMEBBJKNJC
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> NNKKBMDCKJJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> ACFAJPAHDNI;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C52860", Offset = "0x7C51A60", VA = "0x187C52860")]
	static MMMEBBJKNJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C52660", Offset = "0x7C51860", VA = "0x187C52660")]
	public static bool LHOMNBOIMGH(Type GDHKDBJPDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C526C0", Offset = "0x7C518C0", VA = "0x187C526C0")]
	private static bool LHOMNBOIMGH(Type GDHKDBJPDLG, [Out] int CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C52600", Offset = "0x7C51800", VA = "0x187C52600")]
	public static int HCAEEHCCBEL(Type GDHKDBJPDLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C52580", Offset = "0x7C51780", VA = "0x187C52580")]
	public static Type AFHCIICHJIO(int CMDFFDAPDIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct HEAOACFPCEM<Handle> where Handle : JHEBGNDPGNA, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct GKKOPFMGCBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly HEAOACFPCEM<Handle> LNBOHLIJCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int CMDFFDAPDIB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle NFPDMEMKIGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x4C1B140", Offset = "0x4C1A340", VA = "0x184C1B140")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4C1B400", Offset = "0x4C1A600", VA = "0x184C1B400")]
		public GKKOPFMGCBC(HEAOACFPCEM<Handle> LNBOHLIJCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4C1ADD0", Offset = "0x4C19FD0", VA = "0x184C1ADD0")]
		public IGAHIMPCEML FAHGDJGLLGD([In] IGAHIMPCEML LDINAKFKJDF)
		{
			return default(IGAHIMPCEML);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4C1AE60", Offset = "0x4C1A060", VA = "0x184C1AE60")]
		public bool ICPIGBJELHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4C1B080", Offset = "0x4C1A280", VA = "0x184C1B080")]
		private Handle KACPHKEJMAH(string NPEJLHCJPAI)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct IGAHIMPCEML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private GKKOPFMGCBC GNHLNIIFICK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4DE8760", Offset = "0x4DE7960", VA = "0x184DE8760")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4DE87A0", Offset = "0x4DE79A0", VA = "0x184DE87A0")]
		public IGAHIMPCEML(HEAOACFPCEM<Handle> LNBOHLIJCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4DE86E0", Offset = "0x4DE78E0", VA = "0x184DE86E0")]
		public bool ICPIGBJELHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4DE8630", Offset = "0x4DE7830", VA = "0x184DE8630")]
		public IGAHIMPCEML BFKODFEKGDL()
		{
			return default(IGAHIMPCEML);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> JACPKFHCGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> JNFNFJIOMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int DPKMCFABNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int JENHIFJHMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool DELPJOEAOKG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BFJKGNBMPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4C9BB90", Offset = "0x4C9AD90", VA = "0x184C9BB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IGAHIMPCEML MIKKBPDMBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4C9BC10", Offset = "0x4C9AE10", VA = "0x184C9BC10")]
		get
		{
			return default(IGAHIMPCEML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C9CB00", Offset = "0x4C9BD00", VA = "0x184C9CB00")]
	public HEAOACFPCEM(int LJPOFFHOCIN, Allocator DPAKHKILCMF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B210", Offset = "0x4C9A410", VA = "0x184C9B210")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x21F1D70", Offset = "0x21F0F70", VA = "0x1821F1D70")]
	public static int OJEAAAOIABG(int JIKDBGFICJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2F532D0", Offset = "0x2F524D0", VA = "0x182F532D0")]
	public static bool NGKOIMEALPF(int JIKDBGFICJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B7E0", Offset = "0x4C9A9E0", VA = "0x184C9B7E0")]
	public bool HJOHPHNLJPC(int CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B440", Offset = "0x4C9A640", VA = "0x184C9B440")]
	public bool EAOIJLJELNI(Handle BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C6B0", Offset = "0x4C9B8B0", VA = "0x184C9C6B0")]
	public Handle OBNCNPDMBFO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C9BCA0", Offset = "0x4C9AEA0", VA = "0x184C9BCA0")]
	public void LNHIJIKCOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B770", Offset = "0x4C9A970", VA = "0x184C9B770")]
	public void GNGPILHEFBP(Handle BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0")]
	private bool DGJDKMKAJAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B0F0", Offset = "0x4C9A2F0", VA = "0x184C9B0F0")]
	private bool BBKKJNLHCBM(int CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C770", Offset = "0x4C9B970", VA = "0x184C9C770")]
	private void PHPKNIKONAF([Out] int CMDFFDAPDIB, [Out] int EPCDIDIGEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C2C0", Offset = "0x4C9B4C0", VA = "0x184C9C2C0")]
	private void NMOFEBADBHB(Handle BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C5A0", Offset = "0x4C9B7A0", VA = "0x184C9C5A0")]
	private void NNKADFNGNOO(int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B5A0", Offset = "0x4C9A7A0", VA = "0x184C9B5A0")]
	private bool FOLKOELBFOJ([Out] int CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4C9BA00", Offset = "0x4C9AC00", VA = "0x184C9BA00")]
	private static Handle JFEADHKEFBN(int CMDFFDAPDIB, int EPCDIDIGEAG)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct NKLGEGLMBAO<Handle, T> where Handle : JHEBGNDPGNA, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HEAOACFPCEM<Handle> PIALPOLIOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] PDJHBNDJDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> JBDKCHKDIDL;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5499F60", Offset = "0x5499160", VA = "0x185499F60")]
	public NKLGEGLMBAO(int LJPOFFHOCIN, [Optional] Action<T> JBDKCHKDIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5499280", Offset = "0x5498480", VA = "0x185499280")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5499920", Offset = "0x5498B20", VA = "0x185499920")]
	public bool LHFIILLJKMI(Handle BIFBBDMNGPL, [Out] T KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5499AF0", Offset = "0x5498CF0", VA = "0x185499AF0")]
	public Handle LHOMNBOIMGH(T KFMNDOMPAMC)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5499630", Offset = "0x5498830", VA = "0x185499630")]
	public void JKODBGONDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5499CC0", Offset = "0x5498EC0", VA = "0x185499CC0")]
	public void PKCJOLGDFLO(Handle BIFBBDMNGPL, [Out] T NLOEAEGPLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5499E90", Offset = "0x5499090", VA = "0x185499E90")]
	public void PKCJOLGDFLO(Handle BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54993B0", Offset = "0x54985B0", VA = "0x1854993B0")]
	private T EABOBGHIJHA(int CMDFFDAPDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5499300", Offset = "0x5498500", VA = "0x185499300")]
	private void CPDHGDAGLOJ(int NAIMCKDNFFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct EFNLAMGBNCO<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct HHPMBCPEBDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private EFNLAMGBNCO<T> KBILCKNPAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int CMDFFDAPDIB;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4CA8440", Offset = "0x4CA7640", VA = "0x184CA8440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28C9390", Offset = "0x28C8590", VA = "0x1828C9390")]
		public HHPMBCPEBDB(EFNLAMGBNCO<T> KBILCKNPAKO, int CMDFFDAPDIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4CA83F0", Offset = "0x4CA75F0", VA = "0x184CA83F0")]
		public bool ICPIGBJELHK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CPBPHLNMCDP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EFNLAMGBNCO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public CPBPHLNMCDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6879EE0", Offset = "0x68790E0", VA = "0x186879EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6879F80", Offset = "0x6879180", VA = "0x186879F80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ENLPKMINOIP : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public EFNLAMGBNCO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public ENLPKMINOIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x46E9200", Offset = "0x46E8400", VA = "0x1846E9200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x46E92A0", Offset = "0x46E84A0", VA = "0x1846E92A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] CAIGHLKIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint KJIOHKMJAPE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4674780", Offset = "0x4673980", VA = "0x184674780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AEOGNGCAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x46740E0", Offset = "0x46732E0", VA = "0x1846740E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PAKAGCJKALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1814100", Offset = "0x1813300", VA = "0x181814100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool GEEFOJDHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4673E90", Offset = "0x4673090", VA = "0x184673E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KAPKGCINFNF<T> OBDKMIDBACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4674190", Offset = "0x4673390", VA = "0x184674190")]
		get
		{
			return default(KAPKGCINFNF<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4674560", Offset = "0x4673760", VA = "0x184674560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x46743D0", Offset = "0x46735D0", VA = "0x1846743D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4674DF0", Offset = "0x4673FF0", VA = "0x184674DF0")]
	internal EFNLAMGBNCO(EFNLAMGBNCO<T> KBILCKNPAKO, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4674AC0", Offset = "0x4673CC0", VA = "0x184674AC0")]
	private EFNLAMGBNCO(T[] KBILCKNPAKO, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4674AE0", Offset = "0x4673CE0", VA = "0x184674AE0")]
	public EFNLAMGBNCO(IEnumerable<T> LMKJLPPFOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4674E10", Offset = "0x4674010", VA = "0x184674E10")]
	public EFNLAMGBNCO(int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4674790", Offset = "0x4673990", VA = "0x184674790")]
	public int NBGADLHAMML(T KJIOHKMJAPE, int EIGANLKFLHL, int OCEHNHGKKJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4674310", Offset = "0x4673510", VA = "0x184674310")]
	public void GGDGLJPCNCA(int DFNNLLPCPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4673F10", Offset = "0x4673110", VA = "0x184673F10")]
	private void BGHDOBAAEEA(int DFNNLLPCPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4674350", Offset = "0x4673550", VA = "0x184674350")]
	public T[] HPGNNOLKFME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4674630", Offset = "0x4673830", VA = "0x184674630")]
	public T[] LAKGJCBGJBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4674110", Offset = "0x4673310", VA = "0x184674110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4674810", Offset = "0x4673A10", VA = "0x184674810")]
	public void NCJIGOLHAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4673EA0", Offset = "0x46730A0", VA = "0x184673EA0")]
	public HHPMBCPEBDB BFKODFEKGDL()
	{
		return default(HHPMBCPEBDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4674900", Offset = "0x4673B00", VA = "0x184674900", Slot = "5")]
	[IteratorStateMachine(typeof(EFNLAMGBNCO<>.CPBPHLNMCDP))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x46749E0", Offset = "0x4673BE0", VA = "0x1846749E0", Slot = "6")]
	[IteratorStateMachine(typeof(EFNLAMGBNCO<>.ENLPKMINOIP))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4674480", Offset = "0x4673680", VA = "0x184674480")]
	public static EFNLAMGBNCO<T> JPMGIGMMHME(T[] KBILCKNPAKO)
	{
		return default(EFNLAMGBNCO<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4674870", Offset = "0x4673A70", VA = "0x184674870")]
	public static EFNLAMGBNCO<T> PDHAGBEBCNG(T[] KBILCKNPAKO)
	{
		return default(EFNLAMGBNCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x46744E0", Offset = "0x46736E0", VA = "0x1846744E0")]
	private void KCNBIFGNKLC(int CMDFFDAPDIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class NKNHMBEFOJB<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct JOBBNMPLPHF : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private NKNHMBEFOJB<T> CFFEIIKPOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int CMDFFDAPDIB;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5082180", Offset = "0x5081380", VA = "0x185082180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x50821C0", Offset = "0x50813C0", VA = "0x1850821C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x476C580", Offset = "0x476B780", VA = "0x18476C580")]
		public JOBBNMPLPHF(NKNHMBEFOJB<T> CFFEIIKPOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x50820A0", Offset = "0x50812A0", VA = "0x1850820A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5082130", Offset = "0x5081330", VA = "0x185082130", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EFNLAMGBNCO<T> CAIGHLKIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int CLBDAFJFHFB;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x549AF10", Offset = "0x549A110", VA = "0x18549AF10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4F359A0", Offset = "0x4F34BA0", VA = "0x184F359A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x46EB980", Offset = "0x46EAB80", VA = "0x1846EB980", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BFJKGNBMPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x549AA60", Offset = "0x5499C60", VA = "0x18549AA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PAKAGCJKALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x549A330", Offset = "0x5499530", VA = "0x18549A330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public KAPKGCINFNF<T> OBDKMIDBACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x549A160", Offset = "0x5499360", VA = "0x18549A160")]
		get
		{
			return default(KAPKGCINFNF<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x549AEA0", Offset = "0x549A0A0", VA = "0x18549AEA0")]
	public NKNHMBEFOJB(int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4B6CD30", Offset = "0x4B6BF30", VA = "0x184B6CD30")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x549ACD0", Offset = "0x5499ED0", VA = "0x18549ACD0")]
	public EFNLAMGBNCO<T> NICCFCMAPNO()
	{
		return default(EFNLAMGBNCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x549AB70", Offset = "0x5499D70", VA = "0x18549AB70")]
	public void LHOMNBOIMGH(T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x549A350", Offset = "0x5499550", VA = "0x18549A350")]
	private void GGDGLJPCNCA(int POKPPHJAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x549A900", Offset = "0x5499B00", VA = "0x18549A900")]
	public void JKECMACEHMD(List<T> DOMKGFFHOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x549A880", Offset = "0x5499A80", VA = "0x18549A880")]
	public void JKECMACEHMD(T[] DOMKGFFHOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x549AA80", Offset = "0x5499C80", VA = "0x18549AA80")]
	public void KNEIJKOBFCD(int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x549A400", Offset = "0x5499600", VA = "0x18549A400")]
	public void JEGKOLGNEKC(int LOAEIBOIKHP, int GCHDNICOBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x549AC60", Offset = "0x5499E60", VA = "0x18549AC60")]
	public int NBGADLHAMML(T KJIOHKMJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x549AD10", Offset = "0x5499F10", VA = "0x18549AD10")]
	public bool NJCAMOKKLGF(T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x549AB00", Offset = "0x5499D00", VA = "0x18549AB00")]
	public T[] LAKGJCBGJBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x549A140", Offset = "0x5499340", VA = "0x18549A140", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x549AD50", Offset = "0x5499F50", VA = "0x18549AD50")]
	public static EFNLAMGBNCO<T> PDHAGBEBCNG(NKNHMBEFOJB<T> CFFEIIKPOPD)
	{
		return default(EFNLAMGBNCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x549A390", Offset = "0x5499590", VA = "0x18549A390", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x549AE00", Offset = "0x549A000", VA = "0x18549AE00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x549AE30", Offset = "0x549A030", VA = "0x18549AE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x549A1E0", Offset = "0x54993E0", VA = "0x18549A1E0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void EFCENFAKOFO(int KJIOHKMJAPE, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x549A650", Offset = "0x5499850", VA = "0x18549A650")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JIPKJKLMPBA(int LOAEIBOIKHP, int GCHDNICOBCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BJOPHLPICEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x378E780", Offset = "0x378D980", VA = "0x18378E780")]
	public static void NCJIGOLHAPD<T>(this NKNHMBEFOJB<T> CFFEIIKPOPD) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public ref struct KAPKGCINFNF<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> CAIGHLKIDBF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5125200", Offset = "0x5124400", VA = "0x185125200")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x51251D0", Offset = "0x51243D0", VA = "0x1851251D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5125280", Offset = "0x5124480", VA = "0x185125280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x13066A0", Offset = "0x13058A0", VA = "0x1813066A0")]
	public KAPKGCINFNF(Span<object> KGIGBPHOIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5125020", Offset = "0x5124220", VA = "0x185125020")]
	public KAPKGCINFNF<T> ICLDDBKJFJJ(int EIGANLKFLHL)
	{
		return default(KAPKGCINFNF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x51250F0", Offset = "0x51242F0", VA = "0x1851250F0")]
	public KAPKGCINFNF<T> ICLDDBKJFJJ(int EIGANLKFLHL, int CLBDAFJFHFB)
	{
		return default(KAPKGCINFNF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5124F70", Offset = "0x5124170", VA = "0x185124F70")]
	public void GGNEAAKPFPJ(KAPKGCINFNF<T> OCDOIFNHAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x51252C0", Offset = "0x51244C0", VA = "0x1851252C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5124F20", Offset = "0x5124120", VA = "0x185124F20", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5124FD0", Offset = "0x51241D0", VA = "0x185124FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct BMJBNELGBIH : IEquatable<BMJBNELGBIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int GJBFKFHLHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int OCEHNHGKKJH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int IJIKKLFMGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C110", Offset = "0x2F5B310", VA = "0x182F5C110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6E42C20", Offset = "0x6E41E20", VA = "0x186E42C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FAAEADAEFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PFMOJGOAPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C51450", Offset = "0x7C50650", VA = "0x187C51450")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C513A0", Offset = "0x7C505A0", VA = "0x187C513A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) FGIDNNAALEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7C51460", Offset = "0x7C50660", VA = "0x187C51460")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
	private BMJBNELGBIH(int GJBFKFHLHKP, int OCEHNHGKKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x28AF7E0", Offset = "0x28AE9E0", VA = "0x1828AF7E0")]
	public static BMJBNELGBIH MEDDAOJDEEG(int GJBFKFHLHKP, int OCEHNHGKKJH)
	{
		return default(BMJBNELGBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7C51440", Offset = "0x7C50640", VA = "0x187C51440")]
	public static BMJBNELGBIH FAANKJBNMPB(int EIGANLKFLHL, int GCHDNICOBCO)
	{
		return default(BMJBNELGBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7C514C0", Offset = "0x7C506C0", VA = "0x187C514C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1262400", Offset = "0x1261600", VA = "0x181262400", Slot = "4")]
	public bool Equals(BMJBNELGBIH CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7C513B0", Offset = "0x7C505B0", VA = "0x187C513B0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F92EC0", Offset = "0x6F920C0", VA = "0x186F92EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct PGJEOLNPFBC<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> CAIGHLKIDBF;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x13066A0", Offset = "0x13058A0", VA = "0x1813066A0")]
	public PGJEOLNPFBC(NativeArray<T> CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x56E7BF0", Offset = "0x56E6DF0", VA = "0x1856E7BF0", Slot = "6")]
	public int Compare(int HGCMPGNMMIB, int PIALGICKFLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x56E7CE0", Offset = "0x56E6EE0", VA = "0x1856E7CE0", Slot = "4")]
	public bool Equals(int HGCMPGNMMIB, int PIALGICKFLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x56E7DD0", Offset = "0x56E6FD0", VA = "0x1856E7DD0", Slot = "5")]
	public int GetHashCode(int HGCMPGNMMIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PJBIFMICLKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3BC64F0", Offset = "0x3BC56F0", VA = "0x183BC64F0")]
	public static T[] KDHLMFKJLOD<T>(List<T> CFFEIIKPOPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct DFDECPINEDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* FILJOHJIADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle LCKJPNKEHBJ;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5B25F10", Offset = "0x5B25110", VA = "0x185B25F10")]
	public void BHPGJKNEABL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CBNCDMAKDNC
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x37E9100", Offset = "0x37E8300", VA = "0x1837E9100")]
	public static DFDECPINEDH JFEAGGECPOH<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> ABMKJAEMGBO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(DFDECPINEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x37E9100", Offset = "0x37E8300", VA = "0x1837E9100")]
	public static UnsafeParallelHashMap<TKey, TValue> CDNFECOPEFJ<TKey, TValue>(this DFDECPINEDH ABMKJAEMGBO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class MMDHIOICKIE
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3B02A40", Offset = "0x3B01C40", VA = "0x183B02A40")]
	public static int MMGHMLNBCIC<T>(ReadOnlySpan<T> IHGALFJFICC, ReadOnlySpan<T> JCICCDOCMDE, int CLBDAFJFHFB) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class ACLPJKIOFCB
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2F936C0", Offset = "0x2F928C0", VA = "0x182F936C0")]
	public static T NNHKGDAPOLJ<T>(this NativeArray<byte> LMDCFNDMKMH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2F93750", Offset = "0x2F92950", VA = "0x182F93750")]
	public static NativeArray<T> PDOPENAAMAJ<T>(this NativeArray<byte> LMDCFNDMKMH, int OCEHNHGKKJH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2F93510", Offset = "0x2F92710", VA = "0x182F93510")]
	public static void BOGBGKANOGB<T>(this NativeList<byte> MCOCJMBCCJG, [In] T KJIOHKMJAPE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2F93480", Offset = "0x2F92680", VA = "0x182F93480")]
	public static void BOGBGKANOGB<T>(this NativeList<byte> MCOCJMBCCJG, NativeArray<T> KJIOHKMJAPE) where T : struct
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}

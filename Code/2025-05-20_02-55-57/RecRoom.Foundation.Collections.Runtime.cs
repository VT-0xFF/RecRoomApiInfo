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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C96360", Offset = "0x7C95560", VA = "0x187C96360", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[NCIOBHKCNPM]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x398F790", Offset = "0x398E990", VA = "0x18398F790")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[NCIOBHKCNPM]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3990640", Offset = "0x398F840", VA = "0x183990640")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x398F860", Offset = "0x398EA60", VA = "0x18398F860")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x398F9E0", Offset = "0x398EBE0", VA = "0x18398F9E0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3992430", Offset = "0x3991630", VA = "0x183992430")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3992140", Offset = "0x3991340", VA = "0x183992140")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x39922F0", Offset = "0x39914F0", VA = "0x1839922F0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3992AB0", Offset = "0x3991CB0", VA = "0x183992AB0")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3990DC0", Offset = "0x398FFC0", VA = "0x183990DC0")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3990EA0", Offset = "0x39900A0", VA = "0x183990EA0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x39913B0", Offset = "0x39905B0", VA = "0x1839913B0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, GDHEFDIGGIJ range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x39913F0", Offset = "0x39905F0", VA = "0x1839913F0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3991220", Offset = "0x3990420", VA = "0x183991220")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3992230", Offset = "0x3991430", VA = "0x183992230")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[NCIOBHKCNPM]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x399AEC0", Offset = "0x399A0C0", VA = "0x18399AEC0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x399CDC0", Offset = "0x399BFC0", VA = "0x18399CDC0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x399CD70", Offset = "0x399BF70", VA = "0x18399CD70")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x54CA0E0", Offset = "0x54C92E0", VA = "0x1854CA0E0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C963F0", Offset = "0x7C955F0", VA = "0x187C963F0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C96420", Offset = "0x7C95620", VA = "0x187C96420")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x399C2D0", Offset = "0x399B4D0", VA = "0x18399C2D0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x399C160", Offset = "0x399B360", VA = "0x18399C160")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x399C4C0", Offset = "0x399B6C0", VA = "0x18399C4C0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x399C470", Offset = "0x399B670", VA = "0x18399C470")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x399C420", Offset = "0x399B620", VA = "0x18399C420")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x399C230", Offset = "0x399B430", VA = "0x18399C230")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x399C790", Offset = "0x399B990", VA = "0x18399C790")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x399C5F0", Offset = "0x399B7F0", VA = "0x18399C5F0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x399C1B0", Offset = "0x399B3B0", VA = "0x18399C1B0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x399C100", Offset = "0x399B300", VA = "0x18399C100")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x399C0E0", Offset = "0x399B2E0", VA = "0x18399C0E0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x399D1A0", Offset = "0x399C3A0", VA = "0x18399D1A0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x399CDD0", Offset = "0x399BFD0", VA = "0x18399CDD0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x399D1D0", Offset = "0x399C3D0", VA = "0x18399D1D0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x399D290", Offset = "0x399C490", VA = "0x18399D290")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[NCIOBHKCNPM]
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
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4AEA180", Offset = "0x4AE9380", VA = "0x184AEA180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xDAF870", Offset = "0xDAEA70", VA = "0x180DAF870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x50A7D40", Offset = "0x50A6F40", VA = "0x1850A7D40")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x53C9A90", Offset = "0x53C8C90", VA = "0x1853C9A90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x53C98D0", Offset = "0x53C8AD0", VA = "0x1853C98D0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7CBF0", Offset = "0x3F7BDF0", VA = "0x183F7CBF0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[NCIOBHKCNPM]
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
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x541E830", Offset = "0x541DA30", VA = "0x18541E830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x541E870", Offset = "0x541DA70", VA = "0x18541E870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50A7D40", Offset = "0x50A6F40", VA = "0x1850A7D40")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x541E490", Offset = "0x541D690", VA = "0x18541E490")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x541E5D0", Offset = "0x541D7D0", VA = "0x18541E5D0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x541E790", Offset = "0x541D990", VA = "0x18541E790", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x541E6D0", Offset = "0x541D8D0", VA = "0x18541E6D0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NCIOBHKCNPM]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NCIOBHKCNPM]
public static class ELDJEBJLCGI
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C94A00", Offset = "0x7C93C00", VA = "0x187C94A00")]
	public static JobHandle KHMIOELICLD(this JobHandle FCKEKMKDGOB, JobHandle PMDPDEMGJJE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C94950", Offset = "0x7C93B50", VA = "0x187C94950")]
	public static JobHandle DPBMBJIAHCH(this Span<JobHandle> DCLFGGJMPBJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NCOCGNPFKGO
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34C9040", Offset = "0x34C8240", VA = "0x1834C9040")]
	public static void FKFEALEGJFP<T>(this T[] CABEAFGDMFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AIKOOLHCEDI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40170C0", Offset = "0x40162C0", VA = "0x1840170C0")]
	public static NativeKeyValueArrays<TKey, TValue> NILOCLMLJDG<TKey, TValue>(this Dictionary<TKey, TValue> IEEHHNMCCEB, Allocator FOPENOLHBOM) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JDHACFOKPNG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C959B0", Offset = "0x7C94BB0", VA = "0x187C959B0")]
	public static void BEAIFNNLMFF(this GameObject GNOLFLMODHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C95910", Offset = "0x7C94B10", VA = "0x187C95910")]
	public static void BEAIFNNLMFF(this Component CBNJHLDNKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C95870", Offset = "0x7C94A70", VA = "0x187C95870")]
	public static void BEAIFNNLMFF(this ScriptableObject GMIAACHAOLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BABLOKINHEM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C946A0", Offset = "0x7C938A0", VA = "0x187C946A0")]
	public static void HCPMLEOPPMA(this NativeList<byte> MEHAOGGFJIO, ReadOnlySpan<byte> IGFOGCEEFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35A7620", Offset = "0x35A6820", VA = "0x1835A7620")]
	public static void MKNCOMLBLBF<T>(this NativeList<T> MEHAOGGFJIO, T MLCDCHNOCFI, int KIFHGDECLNI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IAPJMPEBBAP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3842880", Offset = "0x3841A80", VA = "0x183842880")]
	public static T FAIDOIPNKOM<T>(this ReadOnlySpan<byte> MLCDCHNOCFI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3842BC0", Offset = "0x3841DC0", VA = "0x183842BC0")]
	public static T HEAKPEEOPHE<T>(this Span<T> IGFOGCEEFHD, Func<T, bool> MFBKJOFMGMP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3843270", Offset = "0x3842470", VA = "0x183843270")]
	public static bool PDAKPIPFOOE<T>(this Span<T> IGFOGCEEFHD, Func<T, bool> MFBKJOFMGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x38427D0", Offset = "0x38419D0", VA = "0x1838427D0")]
	public static bool ELDKIIGLGNH<T>(this Span<T> IGFOGCEEFHD, Func<T, bool> MFBKJOFMGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3842D20", Offset = "0x3841F20", VA = "0x183842D20")]
	public static T HKFPFFCEPKK<T>([In] this ReadOnlySpan<byte> IGFOGCEEFHD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36A6860", Offset = "0x36A5A60", VA = "0x1836A6860")]
	public static Span<TTo> HGCDDLCKPLD<TTo, TFrom>(this Span<TFrom> IGFOGCEEFHD) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36A6860", Offset = "0x36A5A60", VA = "0x1836A6860")]
	public static ReadOnlySpan<TTo> HGCDDLCKPLD<TTo, TFrom>(this ReadOnlySpan<TFrom> IGFOGCEEFHD) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36A6860", Offset = "0x36A5A60", VA = "0x1836A6860")]
	public static ReadOnlySpan<TTo> HGCDDLCKPLD<TTo>(this ReadOnlySpan<byte> IGFOGCEEFHD) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3842AC0", Offset = "0x3841CC0", VA = "0x183842AC0")]
	public static Span<T> GIAPJGILOPE<T>(this ReadOnlySpan<T> JIJCOIBMMGK) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x38422C0", Offset = "0x38414C0", VA = "0x1838422C0")]
	public static Span<byte> DENBCCCLIHH<T>([In] this Span<byte> IGFOGCEEFHD, T MLCDCHNOCFI) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C94DE0", Offset = "0x7C93FE0", VA = "0x187C94DE0")]
	private static Enum FMLGNKNFNPE([In] ReadOnlySpan<byte> IGFOGCEEFHD, Type CIPDLJOCAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C94D70", Offset = "0x7C93F70", VA = "0x187C94D70")]
	public static Enum FLJGJLOMEHP([In] this Span<byte> IGFOGCEEFHD, Type CIPDLJOCAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C95390", Offset = "0x7C94590", VA = "0x187C95390")]
	public static void KMNBPPIFMEJ([In] this Span<byte> IGFOGCEEFHD, Enum EJKIDBDKPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CENCDEANDBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GMHPFBOMCDD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C94BF0", Offset = "0x7C93DF0", VA = "0x187C94BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C94720", Offset = "0x7C93920", VA = "0x187C94720")]
	[AsyncStateMachine(typeof(GMHPFBOMCDD))]
	public static void IGPJCJBNIFB(this Task PNIEJJKFCEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AFFBEHMCABN
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4015760", Offset = "0x4014960", VA = "0x184015760")]
	public static NativeArray<T> HLOPPLIGAAF<T>(this UnsafeList<T> MEHAOGGFJIO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x40157C0", Offset = "0x40149C0", VA = "0x1840157C0")]
	public static NativeArray<T> PDIEJLGAGIA<T>(this UnsafeList<T> MEHAOGGFJIO, bool HAKDEDLGFPF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40156B0", Offset = "0x40148B0", VA = "0x1840156B0")]
	public static UnsafeList<T> GIAPJGILOPE<T>(this UnsafeList<T> MEHAOGGFJIO, Allocator FOPENOLHBOM) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ALDOMHIEADO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum AEPJNJAEEAC : short
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
	public struct AMCMPJNOECA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly AEPJNJAEEAC AGBHGDFILGO;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2E13DC0", Offset = "0x2E12FC0", VA = "0x182E13DC0")]
		public AMCMPJNOECA(AEPJNJAEEAC AGBHGDFILGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory BHDEGBMLBGB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	public static void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C94640", Offset = "0x7C93840", VA = "0x187C94640")]
	static ALDOMHIEADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34D6C30", Offset = "0x34D5E30", VA = "0x1834D6C30")]
	public static AMCMPJNOECA BLKIEIEHDNH(AEPJNJAEEAC AGBHGDFILGO)
	{
		return default(AMCMPJNOECA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	public static void ANHKLLHADJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GBKABKLPPJG
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x381E9E0", Offset = "0x381DBE0", VA = "0x18381E9E0")]
	public static OEABCCCNLNM<T1, T2> BHLOIPDIKFA<T1, T2>(this (T1, T2) KPDPCCJMJOH) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(OEABCCCNLNM<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x381EA00", Offset = "0x381DC00", VA = "0x18381EA00")]
	public static CFAHMDLBEMB<T1, T2, T3> BHLOIPDIKFA<T1, T2, T3>(this (T1, T2, T3) KPDPCCJMJOH) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(CFAHMDLBEMB<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OEABCCCNLNM<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) KPDPCCJMJOH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x54C42E0", Offset = "0x54C34E0", VA = "0x1854C42E0")]
	public OEABCCCNLNM((T1, T2) KPDPCCJMJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x54C3E20", Offset = "0x54C3020", VA = "0x1854C3E20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CFAHMDLBEMB<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) KPDPCCJMJOH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x54C42F0", Offset = "0x54C34F0", VA = "0x1854C42F0")]
	public CFAHMDLBEMB((T1, T2, T3) KPDPCCJMJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6454810", Offset = "0x6453A10", VA = "0x186454810", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JIFDGLMHKMK
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C95CF0", Offset = "0x7C94EF0", VA = "0x187C95CF0")]
	public static Range IGIHHDJNLFA(this GDHEFDIGGIJ IKOPOIHFBKC)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class LACLDBAEHIN
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct KNKLKDLLNOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int BMBDPNPBBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int KAFOOAGKGFA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C96300", Offset = "0x7C95500", VA = "0x187C96300")]
		public KNKLKDLLNOK(int CAECICLJFEI, int KAFOOAGKGFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C962F0", Offset = "0x7C954F0", VA = "0x187C962F0")]
		public bool GINLNMBLNPM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C96310", Offset = "0x7C95510", VA = "0x187C96310")]
	public static KNKLKDLLNOK MAJHBAEJHEK(this Range IKOPOIHFBKC)
	{
		return default(KNKLKDLLNOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OFCHAHAEHEB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle NLNGJFNOHGL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MMLPAJIHGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x54CA110", Offset = "0x54C9310", VA = "0x1854CA110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x54C9ED0", Offset = "0x54C90D0", VA = "0x1854C9ED0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x54CA300", Offset = "0x54C9500", VA = "0x1854CA300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x54CA6D0", Offset = "0x54C98D0", VA = "0x1854CA6D0")]
	public OFCHAHAEHEB(T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x54CA0E0", Offset = "0x54C92E0", VA = "0x1854CA0E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class GNLIPAPECAL<THandle, TValue> : IDisposable where THandle : struct, AKEBFDHKPEH where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> DCLFGGJMPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> CPMBLPBIGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> EGAFKMANKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> JMFAHJKOMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int PFFIEEBFDPP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4A9D4D0", Offset = "0x4A9C6D0", VA = "0x184A9D4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DD60", Offset = "0x4A9CF60", VA = "0x184A9DD60")]
	public GNLIPAPECAL(Action<TValue> JMFAHJKOMFI, [Optional] Func<TValue> EGAFKMANKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D560", Offset = "0x4A9C760", VA = "0x184A9D560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DC60", Offset = "0x4A9CE60", VA = "0x184A9DC60")]
	public THandle OOLDDNFEGEK(TValue MLCDCHNOCFI)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DB30", Offset = "0x4A9CD30", VA = "0x184A9DB30")]
	public bool NHLEMPKJEGJ(THandle NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DA50", Offset = "0x4A9CC50", VA = "0x184A9DA50")]
	public bool LONOHHPMJJI(THandle NLNGJFNOHGL, [Out] TValue MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D790", Offset = "0x4A9C990", VA = "0x184A9D790")]
	public TValue HKFPFFCEPKK(THandle NLNGJFNOHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D210", Offset = "0x4A9C410", VA = "0x184A9D210")]
	public bool BFOGLOCPFFB(THandle NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DD00", Offset = "0x4A9CF00", VA = "0x184A9DD00")]
	private THandle PFEIGKHDOJD(int NIBICIJAIGM)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D1B0", Offset = "0x4A9C3B0", VA = "0x184A9D1B0")]
	private TValue AMMOCOJJGOL(int NIBICIJAIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D740", Offset = "0x4A9C940", VA = "0x184A9D740")]
	private void HJJGIMIKABD(int NIBICIJAIGM, [In] THandle NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D510", Offset = "0x4A9C710", VA = "0x184A9D510")]
	private void DFKHJHBMAIH(int NIBICIJAIGM, [In] TValue MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D7E0", Offset = "0x4A9C9E0", VA = "0x184A9D7E0")]
	private THandle HKNCBNFEFGM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D630", Offset = "0x4A9C830", VA = "0x184A9D630")]
	private void FMELHHDIDOK(THandle NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DA40", Offset = "0x4A9CC40", VA = "0x184A9DA40")]
	private int JKGBJJDIIFI(int COBPGHDNJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DB20", Offset = "0x4A9CD20", VA = "0x184A9DB20")]
	private bool NBJNDFFBBNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9FD8D0", Offset = "0x9FCAD0", VA = "0x1809FD8D0")]
	private void HFMCGJBFJCJ(THandle NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D990", Offset = "0x4A9CB90", VA = "0x184A9D990")]
	private bool JGMPKHIFEJO([Out] THandle NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D080", Offset = "0x4A9C280", VA = "0x184A9D080")]
	private bool ACGIPGOOCPE([Out] THandle NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4A9D320", Offset = "0x4A9C520", VA = "0x184A9D320")]
	private void BMBJLAOILOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AKEBFDHKPEH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int PMLOAHGMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CIHAMGDJGOI
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3620750", Offset = "0x361F950", VA = "0x183620750")]
	public static bool HIOBGOLFKLF<T>(this T NLNGJFNOHGL, T FNJGMJGALLH) where T : struct, AKEBFDHKPEH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3620770", Offset = "0x361F970", VA = "0x183620770")]
	public static bool KJALJJOFOOG<T>(this T NLNGJFNOHGL) where T : struct, AKEBFDHKPEH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C94840", Offset = "0x7C93A40", VA = "0x187C94840")]
	public static string POFPLJMILKE(this AKEBFDHKPEH NLNGJFNOHGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct JJCDHLJFLKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type IHHJMDCOJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> CLMCBMKCKDJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50A7C90", Offset = "0x50A6E90", VA = "0x1850A7C90")]
	public JJCDHLJFLKO(Type GKIMNCEMBGI, Span<byte> IGFOGCEEFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3869D00", Offset = "0x3868F00", VA = "0x183869D00")]
	public static JJCDHLJFLKO JHLKCEPMGDF<T>(T MLCDCHNOCFI) where T : struct
	{
		return default(JJCDHLJFLKO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C95DE0", Offset = "0x7C94FE0", VA = "0x187C95DE0")]
	public static PJBOFIJMJKD NEKLFDMHCNA([In] JJCDHLJFLKO DENDMCHJGLJ)
	{
		return default(PJBOFIJMJKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C95D50", Offset = "0x7C94F50", VA = "0x187C95D50")]
	public Enum FLJGJLOMEHP(Type CIPDLJOCAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3869CC0", Offset = "0x3868EC0", VA = "0x183869CC0")]
	public void DENBCCCLIHH<T>([In] T MLCDCHNOCFI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C95DD0", Offset = "0x7C94FD0", VA = "0x187C95DD0")]
	public void KMNBPPIFMEJ(Enum EJKIDBDKPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct PJBOFIJMJKD
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct GPHAPALJAPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* BGLJIPLMAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* MGPOHFGJFMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type IHHJMDCOJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> CLMCBMKCKDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DJDJGFKNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C96670", Offset = "0x7C95870", VA = "0x187C96670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DLMMMOALIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C96450", Offset = "0x7C95650", VA = "0x187C96450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x50A7C90", Offset = "0x50A6E90", VA = "0x1850A7C90")]
	public PJBOFIJMJKD(Type GKIMNCEMBGI, ReadOnlySpan<byte> IGFOGCEEFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3A16E50", Offset = "0x3A16050", VA = "0x183A16E50")]
	public static PJBOFIJMJKD JHLKCEPMGDF<T>(T MLCDCHNOCFI) where T : struct
	{
		return default(PJBOFIJMJKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C96680", Offset = "0x7C95880", VA = "0x187C96680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C964A0", Offset = "0x7C956A0", VA = "0x187C964A0")]
	public object IAAOOBKADHH(int NIBICIJAIGM = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PJOMGHDJHNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3A17850", Offset = "0x3A16A50", VA = "0x183A17850")]
	public static NativeArray<T> JHLKCEPMGDF<T>(T MLCDCHNOCFI, bool HAKDEDLGFPF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A178F0", Offset = "0x3A16AF0", VA = "0x183A178F0")]
	public static NativeArray<T> MEBPEHLFJPI<T>(T MLCDCHNOCFI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A178A0", Offset = "0x3A16AA0", VA = "0x183A178A0")]
	public static NativeArray<T> LFCBCPDFPHF<T>(T MLCDCHNOCFI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C96930", Offset = "0x7C95B30", VA = "0x187C96930")]
	public static NativeArray<byte> LFCBCPDFPHF(ReadOnlySpan<byte> MLCDCHNOCFI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C96800", Offset = "0x7C95A00", VA = "0x187C96800")]
	public static NativeArray<byte> JHLKCEPMGDF(ReadOnlySpan<byte> MLCDCHNOCFI, bool HAKDEDLGFPF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C968B0", Offset = "0x7C95AB0", VA = "0x187C968B0")]
	public unsafe static NativeArray<byte> JHLKCEPMGDF(byte* BFEBOLBJNJJ, int LMMGFKFHEJP, bool HAKDEDLGFPF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3A17940", Offset = "0x3A16B40", VA = "0x183A17940")]
	public static NativeArray<T> MLINAHCDIHH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct JHAICFANCNP : IEquatable<JHAICFANCNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int JGCOFBDMFGO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C95A50", Offset = "0x7C94C50", VA = "0x187C95A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C95C50", Offset = "0x7C94E50", VA = "0x187C95C50")]
	public JHAICFANCNP(Type EDLOHJEBKFM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C95B80", Offset = "0x7C94D80", VA = "0x187C95B80")]
	public static JHAICFANCNP NEKLFDMHCNA(Type EDLOHJEBKFM)
	{
		return default(JHAICFANCNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2175BB0", Offset = "0x2174DB0", VA = "0x182175BB0", Slot = "4")]
	public bool Equals(JHAICFANCNP FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C95B00", Offset = "0x7C94D00", VA = "0x187C95B00", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C95C10", Offset = "0x7C94E10", VA = "0x187C95C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JOFPFGPDGEA
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> KOCPNHDGPGB;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> MLPGEAENEFN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C96170", Offset = "0x7C95370", VA = "0x187C96170")]
	static JOFPFGPDGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C95F40", Offset = "0x7C95140", VA = "0x187C95F40")]
	public static bool OOLDDNFEGEK(Type EDLOHJEBKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C95FA0", Offset = "0x7C951A0", VA = "0x187C95FA0")]
	private static bool OOLDDNFEGEK(Type EDLOHJEBKFM, [Out] int NIBICIJAIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C95EE0", Offset = "0x7C950E0", VA = "0x187C95EE0")]
	public static int OGCDKJLAAHO(Type EDLOHJEBKFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C95E60", Offset = "0x7C95060", VA = "0x187C95E60")]
	public static Type HKFPFFCEPKK(int NIBICIJAIGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct NIKKGOGJIOJ<Handle> where Handle : AKEBFDHKPEH, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct INNBFOBAHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly NIKKGOGJIOJ<Handle> PLCKFFFKLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int NIBICIJAIGM;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle BMFBKIJLCIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4CA98D0", Offset = "0x4CA8AD0", VA = "0x184CA98D0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9AD0", Offset = "0x4CA8CD0", VA = "0x184CA9AD0")]
		public INNBFOBAHHF(NIKKGOGJIOJ<Handle> PLCKFFFKLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9A40", Offset = "0x4CA8C40", VA = "0x184CA9A40")]
		public FPMIBJFKOAB OIKMHICCLEP([In] FPMIBJFKOAB NIDPEFPJBOO)
		{
			return default(FPMIBJFKOAB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9520", Offset = "0x4CA8720", VA = "0x184CA9520")]
		public bool GINLNMBLNPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4CA94C0", Offset = "0x4CA86C0", VA = "0x184CA94C0")]
		private Handle GIDMECINELI(string BDAAPBJEHGD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct FPMIBJFKOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private INNBFOBAHHF KAMPNNKJJLA;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x49B4460", Offset = "0x49B3660", VA = "0x1849B4460")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x49B4590", Offset = "0x49B3790", VA = "0x1849B4590")]
		public FPMIBJFKOAB(NIKKGOGJIOJ<Handle> PLCKFFFKLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x49B44E0", Offset = "0x49B36E0", VA = "0x1849B44E0")]
		public bool GINLNMBLNPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x49B4520", Offset = "0x49B3720", VA = "0x1849B4520")]
		public FPMIBJFKOAB MAJHBAEJHEK()
		{
			return default(FPMIBJFKOAB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> IEBOIPNBBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> IDFPOKPMBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int HKOLIAECJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int MLADEAGBKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool FGBKGBFJLIA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int JDBAJODHLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5398B00", Offset = "0x5397D00", VA = "0x185398B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FPMIBJFKOAB DDHKIIIPLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x53991C0", Offset = "0x53983C0", VA = "0x1853991C0")]
		get
		{
			return default(FPMIBJFKOAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5399D50", Offset = "0x5398F50", VA = "0x185399D50")]
	public NIKKGOGJIOJ(int AAJLDOONBPL, Allocator FOPENOLHBOM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5399800", Offset = "0x5398A00", VA = "0x185399800")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x210C8B0", Offset = "0x210BAB0", VA = "0x18210C8B0")]
	public static int JKGBJJDIIFI(int KOBHBJCHIOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2E238D0", Offset = "0x2E22AD0", VA = "0x182E238D0")]
	public static bool GLMDDLAEPGM(int KOBHBJCHIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5399AB0", Offset = "0x5398CB0", VA = "0x185399AB0")]
	public bool JJIHDOIPBOM(int NIBICIJAIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5398450", Offset = "0x5397650", VA = "0x185398450")]
	public bool CEDMNDBLIAB(Handle NLNGJFNOHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5399320", Offset = "0x5398520", VA = "0x185399320")]
	public Handle FKBHINIHGLM()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5398EB0", Offset = "0x53980B0", VA = "0x185398EB0")]
	public void EGGGCHCJKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5398A20", Offset = "0x5397C20", VA = "0x185398A20")]
	public void EBPHEBGKCBC(Handle NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260")]
	private bool PLDOIBGPDGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5398240", Offset = "0x5397440", VA = "0x185398240")]
	private bool BGEJNGPGLCA(int NIBICIJAIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5398740", Offset = "0x5397940", VA = "0x185398740")]
	private void CHAOJNGKBCO([Out] int NIBICIJAIGM, [Out] int COBPGHDNJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x53996B0", Offset = "0x53988B0", VA = "0x1853996B0")]
	private void GKEBEEMHLPN(Handle NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5399BE0", Offset = "0x5398DE0", VA = "0x185399BE0")]
	private void LMABHFFAKCP(int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x53994A0", Offset = "0x53986A0", VA = "0x1853994A0")]
	private bool GABFDICPOLO([Out] int NIBICIJAIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x53982A0", Offset = "0x53974A0", VA = "0x1853982A0")]
	private static Handle BKJGBMGHFHO(int NIBICIJAIGM, int COBPGHDNJHM)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct KIMGDACKBII<Handle, T> where Handle : AKEBFDHKPEH, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NIKKGOGJIOJ<Handle> LNJOEDAHMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] JKNNNLFJFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> JAIOOHHLDAI;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5016DD0", Offset = "0x5015FD0", VA = "0x185016DD0")]
	public KIMGDACKBII(int AAJLDOONBPL, [Optional] Action<T> JAIOOHHLDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x50164A0", Offset = "0x50156A0", VA = "0x1850164A0")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x50169D0", Offset = "0x5015BD0", VA = "0x1850169D0")]
	public bool LONOHHPMJJI(Handle NLNGJFNOHGL, [Out] T DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5016CD0", Offset = "0x5015ED0", VA = "0x185016CD0")]
	public Handle OOLDDNFEGEK(T DBCLNEGBNLN)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5016270", Offset = "0x5015470", VA = "0x185016270")]
	public void ACMPDNFJHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x50165A0", Offset = "0x50157A0", VA = "0x1850165A0")]
	public void KKKHDEJPLIG(Handle NLNGJFNOHGL, [Out] T CNOPLECAGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5016840", Offset = "0x5015A40", VA = "0x185016840")]
	public void KKKHDEJPLIG(Handle NLNGJFNOHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5016B50", Offset = "0x5015D50", VA = "0x185016B50")]
	private T OKJKNKIJNEH(int NIBICIJAIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5016910", Offset = "0x5015B10", VA = "0x185016910")]
	private void LAOIFHLCCMK(int CANCBIKGAOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct IAJOLCEBCCF<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct HFHBIOLFNHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IAJOLCEBCCF<T> CABEAFGDMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int NIBICIJAIGM;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x4B22200", Offset = "0x4B21400", VA = "0x184B22200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27EE5C0", Offset = "0x27ED7C0", VA = "0x1827EE5C0")]
		public HFHBIOLFNHP(IAJOLCEBCCF<T> CABEAFGDMFF, int NIBICIJAIGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4B22250", Offset = "0x4B21450", VA = "0x184B22250")]
		public bool GINLNMBLNPM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NFAHBJFMGLL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public IAJOLCEBCCF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public NFAHBJFMGLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5380150", Offset = "0x537F350", VA = "0x185380150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x53801F0", Offset = "0x537F3F0", VA = "0x1853801F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CLHNAKMAJIE : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IAJOLCEBCCF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public CLHNAKMAJIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x662E870", Offset = "0x662DA70", VA = "0x18662E870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x662E910", Offset = "0x662DB10", VA = "0x18662E910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] DHAOEHNLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint MLCDCHNOCFI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4C6A110", Offset = "0x4C69310", VA = "0x184C6A110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BFALGEPOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4C69B90", Offset = "0x4C68D90", VA = "0x184C69B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CGPGHNNJOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1743130", Offset = "0x1742330", VA = "0x181743130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool LGALMCOAKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4C6A080", Offset = "0x4C69280", VA = "0x184C6A080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public OKPGMAPLAEE<T> CLMCBMKCKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4C69C90", Offset = "0x4C68E90", VA = "0x184C69C90")]
		get
		{
			return default(OKPGMAPLAEE<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4C69BC0", Offset = "0x4C68DC0", VA = "0x184C69BC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4C6A1A0", Offset = "0x4C693A0", VA = "0x184C6A1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A7F0", Offset = "0x4C699F0", VA = "0x184C6A7F0")]
	internal IAJOLCEBCCF(IAJOLCEBCCF<T> CABEAFGDMFF, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A880", Offset = "0x4C69A80", VA = "0x184C6A880")]
	private IAJOLCEBCCF(T[] CABEAFGDMFF, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A8A0", Offset = "0x4C69AA0", VA = "0x184C6A8A0")]
	public IAJOLCEBCCF(IEnumerable<T> CPMBLPBIGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A810", Offset = "0x4C69A10", VA = "0x184C6A810")]
	public IAJOLCEBCCF(int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A250", Offset = "0x4C69450", VA = "0x184C6A250")]
	public int IOLJJNDBKMM(T MLCDCHNOCFI, int CAECICLJFEI, int KIFHGDECLNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C69E70", Offset = "0x4C69070", VA = "0x184C69E70")]
	public void DOBNNMKADDA(int MHJEANLDBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A2D0", Offset = "0x4C694D0", VA = "0x184C6A2D0")]
	private void LFOCPBAFHBE(int MHJEANLDBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A090", Offset = "0x4C69290", VA = "0x184C6A090")]
	public T[] HLEEGIGFHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C69F30", Offset = "0x4C69130", VA = "0x184C69F30")]
	public T[] EKNHBOFPBHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4C69EB0", Offset = "0x4C690B0", VA = "0x184C69EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4C69E10", Offset = "0x4C69010", VA = "0x184C69E10")]
	public void DGMDNGELGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A4A0", Offset = "0x4C696A0", VA = "0x184C6A4A0")]
	public HFHBIOLFNHP MAJHBAEJHEK()
	{
		return default(HFHBIOLFNHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A610", Offset = "0x4C69810", VA = "0x184C6A610", Slot = "5")]
	[IteratorStateMachine(typeof(IAJOLCEBCCF<>.NFAHBJFMGLL))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A700", Offset = "0x4C69900", VA = "0x184C6A700", Slot = "6")]
	[IteratorStateMachine(typeof(IAJOLCEBCCF<>.CLHNAKMAJIE))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A5B0", Offset = "0x4C697B0", VA = "0x184C6A5B0")]
	public static IAJOLCEBCCF<T> NKLALPBGDMP(T[] CABEAFGDMFF)
	{
		return default(IAJOLCEBCCF<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A510", Offset = "0x4C69710", VA = "0x184C6A510")]
	public static IAJOLCEBCCF<T> NEKLFDMHCNA(T[] CABEAFGDMFF)
	{
		return default(IAJOLCEBCCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4C6A120", Offset = "0x4C69320", VA = "0x184C6A120")]
	private void IHKNMAOBIOC(int NIBICIJAIGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class GBAADKKOBIK<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct IDDFAGODNEJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private GBAADKKOBIK<T> MEHAOGGFJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int NIBICIJAIGM;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4C70410", Offset = "0x4C6F610", VA = "0x184C70410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x4C70450", Offset = "0x4C6F650", VA = "0x184C70450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x45C9080", Offset = "0x45C8280", VA = "0x1845C9080")]
		public IDDFAGODNEJ(GBAADKKOBIK<T> MEHAOGGFJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4C70320", Offset = "0x4C6F520", VA = "0x184C70320", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4C703C0", Offset = "0x4C6F5C0", VA = "0x184C703C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IAJOLCEBCCF<T> DHAOEHNLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int LMMGFKFHEJP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E6A0", Offset = "0x4A4D8A0", VA = "0x184A4E6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x49AD630", Offset = "0x49AC830", VA = "0x1849AD630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JDBAJODHLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E830", Offset = "0x4A4DA30", VA = "0x184A4E830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool CGPGHNNJOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4A4EBE0", Offset = "0x4A4DDE0", VA = "0x184A4EBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public OKPGMAPLAEE<T> CLMCBMKCKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E710", Offset = "0x4A4D910", VA = "0x184A4E710")]
		get
		{
			return default(OKPGMAPLAEE<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4A4F560", Offset = "0x4A4E760", VA = "0x184A4F560")]
	public GBAADKKOBIK(int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E8C0", Offset = "0x4A4DAC0", VA = "0x184A4E8C0")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E7F0", Offset = "0x4A4D9F0", VA = "0x184A4E7F0")]
	public IAJOLCEBCCF<T> EAMOEODHEJP()
	{
		return default(IAJOLCEBCCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4A4F390", Offset = "0x4A4E590", VA = "0x184A4F390")]
	public void OOLDDNFEGEK(T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E790", Offset = "0x4A4D990", VA = "0x184A4E790")]
	private void DOBNNMKADDA(int PIBKMAHMMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E970", Offset = "0x4A4DB70", VA = "0x184A4E970")]
	public void HCPMLEOPPMA(List<T> KNGFDIDKBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EAF0", Offset = "0x4A4DCF0", VA = "0x184A4EAF0")]
	public void HCPMLEOPPMA(T[] KNGFDIDKBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EC00", Offset = "0x4A4DE00", VA = "0x184A4EC00")]
	public void ILIMKGBDIAO(int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4A4ED60", Offset = "0x4A4DF60", VA = "0x184A4ED60")]
	public void JJOABNPNOBP(int EKDKEHDMLDH, int KAFOOAGKGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4A4ECE0", Offset = "0x4A4DEE0", VA = "0x184A4ECE0")]
	public int IOLJJNDBKMM(T MLCDCHNOCFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EB90", Offset = "0x4A4DD90", VA = "0x184A4EB90")]
	public bool HHAMPMLOBIE(T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E850", Offset = "0x4A4DA50", VA = "0x184A4E850")]
	public T[] EKNHBOFPBHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E7D0", Offset = "0x4A4D9D0", VA = "0x184A4E7D0", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4A4F2D0", Offset = "0x4A4E4D0", VA = "0x184A4F2D0")]
	public static IAJOLCEBCCF<T> NEKLFDMHCNA(GBAADKKOBIK<T> MEHAOGGFJIO)
	{
		return default(IAJOLCEBCCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E900", Offset = "0x4A4DB00", VA = "0x184A4E900", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4A4F4B0", Offset = "0x4A4E6B0", VA = "0x184A4F4B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4A4F4F0", Offset = "0x4A4E6F0", VA = "0x184A4F4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4A4F180", Offset = "0x4A4E380", VA = "0x184A4F180")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void KBKNCDEFOEJ(int MLCDCHNOCFI, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EF30", Offset = "0x4A4E130", VA = "0x184A4EF30")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void JKPLMABLINK(int EKDKEHDMLDH, int KAFOOAGKGFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class ALPLAPLDFED
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4019270", Offset = "0x4018470", VA = "0x184019270")]
	public static void DGMDNGELGNO<T>(this GBAADKKOBIK<T> MEHAOGGFJIO) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public ref struct OKPGMAPLAEE<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> DHAOEHNLNON;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5538970", Offset = "0x5537B70", VA = "0x185538970")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5538C80", Offset = "0x5537E80", VA = "0x185538C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5538C40", Offset = "0x5537E40", VA = "0x185538C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public OKPGMAPLAEE(Span<object> IGFOGCEEFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5538B20", Offset = "0x5537D20", VA = "0x185538B20")]
	public OKPGMAPLAEE<T> GGOAJKLNKDH(int CAECICLJFEI)
	{
		return default(OKPGMAPLAEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5538A40", Offset = "0x5537C40", VA = "0x185538A40")]
	public OKPGMAPLAEE<T> GGOAJKLNKDH(int CAECICLJFEI, int LMMGFKFHEJP)
	{
		return default(OKPGMAPLAEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5538CB0", Offset = "0x5537EB0", VA = "0x185538CB0")]
	public void LHEIMFHDGOA(OKPGMAPLAEE<T> MFPGJPKAOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5538D10", Offset = "0x5537F10", VA = "0x185538D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x55389F0", Offset = "0x5537BF0", VA = "0x1855389F0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5538BF0", Offset = "0x5537DF0", VA = "0x185538BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct GDHEFDIGGIJ : IEquatable<GDHEFDIGGIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int OEBFFKLMAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int KIFHGDECLNI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int EKHHHLINNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D960", Offset = "0x2E1CB60", VA = "0x182E1D960")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB12E0", Offset = "0x6EB04E0", VA = "0x186EB12E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int OGEPMCBNDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DJEBEGAHKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C94AA0", Offset = "0x7C93CA0", VA = "0x187C94AA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7C94B40", Offset = "0x7C93D40", VA = "0x187C94B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public (int begin, int end) EOIFCNGIANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C94A40", Offset = "0x7C93C40", VA = "0x187C94A40")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
	private GDHEFDIGGIJ(int OEBFFKLMAPN, int KIFHGDECLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x27DAE60", Offset = "0x27DA060", VA = "0x1827DAE60")]
	public static GDHEFDIGGIJ ANFBFGFJHLE(int OEBFFKLMAPN, int KIFHGDECLNI)
	{
		return default(GDHEFDIGGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7C94B50", Offset = "0x7C93D50", VA = "0x187C94B50")]
	public static GDHEFDIGGIJ LAMCIJHNHEI(int CAECICLJFEI, int KAFOOAGKGFA)
	{
		return default(GDHEFDIGGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C94B60", Offset = "0x7C93D60", VA = "0x187C94B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xEFE3F0", Offset = "0xEFD5F0", VA = "0x180EFE3F0", Slot = "4")]
	public bool Equals(GDHEFDIGGIJ FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7C94AB0", Offset = "0x7C93CB0", VA = "0x187C94AB0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7010E20", Offset = "0x7010020", VA = "0x187010E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct OJJGCBNIFGJ<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> DHAOEHNLNON;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
	public OJJGCBNIFGJ(NativeArray<T> DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x55380C0", Offset = "0x55372C0", VA = "0x1855380C0", Slot = "6")]
	public int Compare(int CCOLDGJALNH, int JCBKIOEHCDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55381B0", Offset = "0x55373B0", VA = "0x1855381B0", Slot = "4")]
	public bool Equals(int CCOLDGJALNH, int JCBKIOEHCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x55382A0", Offset = "0x55374A0", VA = "0x1855382A0", Slot = "5")]
	public int GetHashCode(int CCOLDGJALNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LDMBJKNAFFC
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x38BB400", Offset = "0x38BA600", VA = "0x1838BB400")]
	public static T[] DNEONBBAJKB<T>(List<T> MEHAOGGFJIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LONMAFGACJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* EIKBLLHBEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle OEAHGECIAIE;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5A94480", Offset = "0x5A93680", VA = "0x185A94480")]
	public void GNJBDGKPLLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class JKPBGEPOKDH
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x386D1A0", Offset = "0x386C3A0", VA = "0x18386D1A0")]
	public static LONMAFGACJO FNKFNBFMDED<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> JPGJDFDDJJG) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(LONMAFGACJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x386D1A0", Offset = "0x386C3A0", VA = "0x18386D1A0")]
	public static UnsafeParallelHashMap<TKey, TValue> JLFAEIGDOHC<TKey, TValue>(this LONMAFGACJO JPGJDFDDJJG) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class PLGJEDNIEGI
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3A19100", Offset = "0x3A18300", VA = "0x183A19100")]
	public static int KAOPOMJKLBD<T>(ReadOnlySpan<T> BOEDHCGFOLG, ReadOnlySpan<T> FCDOAFGANFB, int LMMGFKFHEJP) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CAKPAFBLHBB
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x36151A0", Offset = "0x36143A0", VA = "0x1836151A0")]
	public static T CADFNPGIBLB<T>(this NativeArray<byte> JIJCOIBMMGK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3615230", Offset = "0x3614430", VA = "0x183615230")]
	public static NativeArray<T> FIIBDFJDKKF<T>(this NativeArray<byte> JIJCOIBMMGK, int KIFHGDECLNI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3615650", Offset = "0x3614850", VA = "0x183615650")]
	public static void PNPAJCFNCBG<T>(this NativeList<byte> PDBEAHFDFJA, [In] T MLCDCHNOCFI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3615700", Offset = "0x3614900", VA = "0x183615700")]
	public static void PNPAJCFNCBG<T>(this NativeList<byte> PDBEAHFDFJA, NativeArray<T> MLCDCHNOCFI) where T : struct
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

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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80B87A0", Offset = "0x80B75A0", VA = "0x1880B87A0", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[IPOMJLLNKFD]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D12CC0", Offset = "0x3D11AC0", VA = "0x183D12CC0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[IPOMJLLNKFD]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D13C70", Offset = "0x3D12A70", VA = "0x183D13C70")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D12F90", Offset = "0x3D11D90", VA = "0x183D12F90")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D12EC0", Offset = "0x3D11CC0", VA = "0x183D12EC0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C5A0", Offset = "0x3D1B3A0", VA = "0x183D1C5A0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C330", Offset = "0x3D1B130", VA = "0x183D1C330")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C4A0", Offset = "0x3D1B2A0", VA = "0x183D1C4A0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CBF0", Offset = "0x3D1B9F0", VA = "0x183D1CBF0")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D14470", Offset = "0x3D13270", VA = "0x183D14470")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D14400", Offset = "0x3D13200", VA = "0x183D14400")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D14920", Offset = "0x3D13720", VA = "0x183D14920")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, PIHJPNGEKCI range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D14960", Offset = "0x3D13760", VA = "0x183D14960")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D147A0", Offset = "0x3D135A0", VA = "0x183D147A0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D12D10", Offset = "0x3D11B10", VA = "0x183D12D10")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C3E0", Offset = "0x3D1B1E0", VA = "0x183D1C3E0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[IPOMJLLNKFD]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CCC0", Offset = "0x3D1BAC0", VA = "0x183D1CCC0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E9F0", Offset = "0x3D1D7F0", VA = "0x183D1E9F0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E9A0", Offset = "0x3D1D7A0", VA = "0x183D1E9A0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE780", Offset = "0x6DDD580", VA = "0x186DDE780")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80B8A00", Offset = "0x80B7800", VA = "0x1880B8A00")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80B8A30", Offset = "0x80B7830", VA = "0x1880B8A30")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DFA0", Offset = "0x3D1CDA0", VA = "0x183D1DFA0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DD90", Offset = "0x3D1CB90", VA = "0x183D1DD90")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E150", Offset = "0x3D1CF50", VA = "0x183D1E150")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DFD0", Offset = "0x3D1CDD0", VA = "0x183D1DFD0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E020", Offset = "0x3D1CE20", VA = "0x183D1E020")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DE60", Offset = "0x3D1CC60", VA = "0x183D1DE60")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E3A0", Offset = "0x3D1D1A0", VA = "0x183D1E3A0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E200", Offset = "0x3D1D000", VA = "0x183D1E200")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DDE0", Offset = "0x3D1CBE0", VA = "0x183D1DDE0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DD30", Offset = "0x3D1CB30", VA = "0x183D1DD30")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DD10", Offset = "0x3D1CB10", VA = "0x183D1DD10")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EDD0", Offset = "0x3D1DBD0", VA = "0x183D1EDD0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EA00", Offset = "0x3D1D800", VA = "0x183D1EA00")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EE00", Offset = "0x3D1DC00", VA = "0x183D1EE00")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EEB0", Offset = "0x3D1DCB0", VA = "0x183D1EEB0")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[IPOMJLLNKFD]
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
			[Cpp2IlInjected.Address(RVA = "0x4E05750", Offset = "0x4E04550", VA = "0x184E05750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xEC90A0", Offset = "0xEC7EA0", VA = "0x180EC90A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x53D61C0", Offset = "0x53D4FC0", VA = "0x1853D61C0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x573F650", Offset = "0x573E450", VA = "0x18573F650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x573F570", Offset = "0x573E370", VA = "0x18573F570")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4202770", Offset = "0x4201570", VA = "0x184202770")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[IPOMJLLNKFD]
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
			[Cpp2IlInjected.Address(RVA = "0x4E05750", Offset = "0x4E04550", VA = "0x184E05750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x57A33D0", Offset = "0x57A21D0", VA = "0x1857A33D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x53D61C0", Offset = "0x53D4FC0", VA = "0x1853D61C0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x57A2E50", Offset = "0x57A1C50", VA = "0x1857A2E50")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x57A3000", Offset = "0x57A1E00", VA = "0x1857A3000")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x57A3100", Offset = "0x57A1F00", VA = "0x1857A3100", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x57A31E0", Offset = "0x57A1FE0", VA = "0x1857A31E0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[IPOMJLLNKFD]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[IPOMJLLNKFD]
public static class CGJHDNLKKJF
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80B7470", Offset = "0x80B6270", VA = "0x1880B7470")]
	public static JobHandle IMNDAFKIBOH(this JobHandle LKPLCEODICL, JobHandle MANCHAKPLNN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80B73C0", Offset = "0x80B61C0", VA = "0x1880B73C0")]
	public static JobHandle IAJCEPGMGJO(this Span<JobHandle> FLKIPICBFGF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EHDIIBDGNMI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x384D2B0", Offset = "0x384C0B0", VA = "0x18384D2B0")]
	public static void MKDKKBLDFOH<T>(this T[] COPOPHFGNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MJPGBMCOJMJ
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D820", Offset = "0x3C9C620", VA = "0x183C9D820")]
	public static NativeKeyValueArrays<TKey, TValue> FKONIIKJBHO<TKey, TValue>(this Dictionary<TKey, TValue> OBJPMEDBNDI, Allocator DFGMDNGNOEN) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HDFDFKNGEOH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80B7AE0", Offset = "0x80B68E0", VA = "0x1880B7AE0")]
	public static void MPOAFHMNNDO(this GameObject JLNNGPHDMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80B7A40", Offset = "0x80B6840", VA = "0x1880B7A40")]
	public static void MPOAFHMNNDO(this Component LPAADBJGJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80B7B80", Offset = "0x80B6980", VA = "0x1880B7B80")]
	public static void MPOAFHMNNDO(this ScriptableObject ABENCJPAHLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IKELACMJKHN
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80B7CA0", Offset = "0x80B6AA0", VA = "0x1880B7CA0")]
	public static void MBGFCNOCIDA(this NativeList<byte> ECEBLBALENP, ReadOnlySpan<byte> AJHFMGPCLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA010", Offset = "0x3BC8E10", VA = "0x183BCA010")]
	public static void MJOLJFEBPLO<T>(this NativeList<T> ECEBLBALENP, T BNECONOIKOE, int LJEIHABMGGI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CAJDFALKJEM
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3993E60", Offset = "0x3992C60", VA = "0x183993E60")]
	public static T NKBGNBEOKCK<T>(this ReadOnlySpan<byte> BNECONOIKOE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39941C0", Offset = "0x3992FC0", VA = "0x1839941C0")]
	public static T PFLNEKOPLCB<T>(this Span<T> AJHFMGPCLKE, Func<T, bool> MFECLOCKJEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3994130", Offset = "0x3992F30", VA = "0x183994130")]
	public static bool PEKCMFLHDFP<T>(this Span<T> AJHFMGPCLKE, Func<T, bool> MFECLOCKJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x39940A0", Offset = "0x3992EA0", VA = "0x1839940A0")]
	public static bool ODMIEGANGGC<T>(this Span<T> AJHFMGPCLKE, Func<T, bool> MFECLOCKJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3993A00", Offset = "0x3992800", VA = "0x183993A00")]
	public static T LHCLHJGACJJ<T>([In] this ReadOnlySpan<byte> AJHFMGPCLKE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3993540", Offset = "0x3992340", VA = "0x183993540")]
	public static Span<TTo> GOABLFHEAFB<TTo, TFrom>(this Span<TFrom> AJHFMGPCLKE) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3993540", Offset = "0x3992340", VA = "0x183993540")]
	public static ReadOnlySpan<TTo> GOABLFHEAFB<TTo, TFrom>(this ReadOnlySpan<TFrom> AJHFMGPCLKE) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3993540", Offset = "0x3992340", VA = "0x183993540")]
	public static ReadOnlySpan<TTo> GOABLFHEAFB<TTo>(this ReadOnlySpan<byte> AJHFMGPCLKE) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3993450", Offset = "0x3992250", VA = "0x183993450")]
	public static Span<T> AJBMEKOGIKE<T>(this ReadOnlySpan<T> GGCHDPHENOB) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3993580", Offset = "0x3992380", VA = "0x183993580")]
	public static Span<byte> LAGAMOKKAFA<T>([In] this Span<byte> AJHFMGPCLKE, T BNECONOIKOE) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80B6E20", Offset = "0x80B5C20", VA = "0x1880B6E20")]
	private static Enum MNHOHDBLHPA([In] ReadOnlySpan<byte> AJHFMGPCLKE, Type BOEOHEICOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80B68A0", Offset = "0x80B56A0", VA = "0x1880B68A0")]
	public static Enum IAPPMDKGMKJ([In] this Span<byte> AJHFMGPCLKE, Type BOEOHEICOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80B6910", Offset = "0x80B5710", VA = "0x1880B6910")]
	public static void ICECDBOGHCE([In] this Span<byte> AJHFMGPCLKE, Enum HECBCEDKAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JIMNOOKONEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MEPGIONCPBN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80B8830", Offset = "0x80B7630", VA = "0x1880B8830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80B7D20", Offset = "0x80B6B20", VA = "0x1880B7D20")]
	[AsyncStateMachine(typeof(MEPGIONCPBN))]
	public static void PIOKMCIEOJF(this Task ODOKMLFIJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NMKFAJHFFCM
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FD10", Offset = "0x3D0EB10", VA = "0x183D0FD10")]
	public static NativeArray<T> CFDOHMNGFGP<T>(this UnsafeList<T> ECEBLBALENP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FCA0", Offset = "0x3D0EAA0", VA = "0x183D0FCA0")]
	public static NativeArray<T> AMOMLGAFCHO<T>(this UnsafeList<T> ECEBLBALENP, bool IJHOIHKCLJE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FBF0", Offset = "0x3D0E9F0", VA = "0x183D0FBF0")]
	public static UnsafeList<T> AJBMEKOGIKE<T>(this UnsafeList<T> ECEBLBALENP, Allocator DFGMDNGNOEN) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PJECIACEOIL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum BAICBEFEGHA : short
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
	public struct FKHOIIMMKBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly BAICBEFEGHA MAHBBBBCDEL;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3097920", Offset = "0x3096720", VA = "0x183097920")]
		public FKHOIIMMKBE(BAICBEFEGHA MAHBBBBCDEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory INDDHEPFNIF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	public static void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80B8C10", Offset = "0x80B7A10", VA = "0x1880B8C10")]
	static PJECIACEOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x384CF90", Offset = "0x384BD90", VA = "0x18384CF90")]
	public static FKHOIIMMKBE LBBFKCOLKCK(BAICBEFEGHA MAHBBBBCDEL)
	{
		return default(FKHOIIMMKBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	public static void GDAHDDOHNKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CHICEHILKAL
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB120", Offset = "0x2BD9F20", VA = "0x182BDB120")]
	public static LENNMLABMJF<T1, T2> BBFOAFEAFBB<T1, T2>(this (T1, T2) EDAKOHHBNGI) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(LENNMLABMJF<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3996740", Offset = "0x3995540", VA = "0x183996740")]
	public static NGMFEMONHPA<T1, T2, T3> BBFOAFEAFBB<T1, T2, T3>(this (T1, T2, T3) EDAKOHHBNGI) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(NGMFEMONHPA<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LENNMLABMJF<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) EDAKOHHBNGI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAD50", Offset = "0x2BD9B50", VA = "0x182BDAD50")]
	public LENNMLABMJF((T1, T2) EDAKOHHBNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5415220", Offset = "0x5414020", VA = "0x185415220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NGMFEMONHPA<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) EDAKOHHBNGI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5415590", Offset = "0x5414390", VA = "0x185415590")]
	public NGMFEMONHPA((T1, T2, T3) EDAKOHHBNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x56E2AD0", Offset = "0x56E18D0", VA = "0x1856E2AD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HGJMOANHHOH
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80B7C20", Offset = "0x80B6A20", VA = "0x1880B7C20")]
	public static Range HLIGPGIMLHE(this PIHJPNGEKCI FANOBLNBIII)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MHFDFDCOOIB
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct ICKNJOJDIKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int ANBONAPGLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int CNDOBMAKBFL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x80B7C90", Offset = "0x80B6A90", VA = "0x1880B7C90")]
		public ICKNJOJDIKP(int DKBLEPBOJIC, int CNDOBMAKBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80B7C80", Offset = "0x80B6A80", VA = "0x1880B7C80")]
		public bool CELMNIAJJCM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80B89B0", Offset = "0x80B77B0", VA = "0x1880B89B0")]
	public static ICKNJOJDIKP OMGGHMFPBJO(this Range FANOBLNBIII)
	{
		return default(ICKNJOJDIKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DHBDFDCBLNN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle DADONNGONOC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JGEGOABMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE9F0", Offset = "0x6DDD7F0", VA = "0x186DDE9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE860", Offset = "0x6DDD660", VA = "0x186DDE860")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6DDEA00", Offset = "0x6DDD800", VA = "0x186DDEA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DDEFF0", Offset = "0x6DDDDF0", VA = "0x186DDEFF0")]
	public DHBDFDCBLNN(T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE780", Offset = "0x6DDD580", VA = "0x186DDE780", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class AFCMBNCMNCF<THandle, TValue> : IDisposable where THandle : struct, FOLAMDMFEJK where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> FLKIPICBFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> FEBLBJIINOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> JHFNCLLKHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> IKAKAHGCMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int FNPHEGDHCNJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4FD2350", Offset = "0x4FD1150", VA = "0x184FD2350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4FD29B0", Offset = "0x4FD17B0", VA = "0x184FD29B0")]
	public AFCMBNCMNCF(Action<TValue> IKAKAHGCMOA, [Optional] Func<TValue> JHFNCLLKHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4FD22D0", Offset = "0x4FD10D0", VA = "0x184FD22D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4FD28F0", Offset = "0x4FD16F0", VA = "0x184FD28F0")]
	public THandle OLHPIGGMIDE(TValue BNECONOIKOE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2100", Offset = "0x4FD0F00", VA = "0x184FD2100")]
	public bool BOGGHIAGAGL(THandle DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4FD24D0", Offset = "0x4FD12D0", VA = "0x184FD24D0")]
	public bool GNHMKAHECGG(THandle DADONNGONOC, [Out] TValue BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2740", Offset = "0x4FD1540", VA = "0x184FD2740")]
	public TValue LHCLHJGACJJ(THandle DADONNGONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2380", Offset = "0x4FD1180", VA = "0x184FD2380")]
	public bool FGHKILHPKEI(THandle DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4FD26F0", Offset = "0x4FD14F0", VA = "0x184FD26F0")]
	private THandle KHDALHDLGBD(int CKFKPOAGPKN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2480", Offset = "0x4FD1280", VA = "0x184FD2480")]
	private TValue GGDBPONNJMM(int CKFKPOAGPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1F50", Offset = "0x4FD0D50", VA = "0x184FD1F50")]
	private void BCMGMMPJJDF(int CKFKPOAGPKN, [In] THandle DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2970", Offset = "0x4FD1770", VA = "0x184FD2970")]
	private void PDGEMODFENH(int CKFKPOAGPKN, [In] TValue BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1F90", Offset = "0x4FD0D90", VA = "0x184FD1F90")]
	private THandle BELIJDOKHDJ()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2620", Offset = "0x4FD1420", VA = "0x184FD2620")]
	private void JIHMDHAHFGI(THandle DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4FD20F0", Offset = "0x4FD0EF0", VA = "0x184FD20F0")]
	private int BKCIMLFCADP(int DMIBKIHBLCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1F40", Offset = "0x4FD0D40", VA = "0x184FD1F40")]
	private bool AGALKBAPAME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA5C500", Offset = "0xA5B300", VA = "0x180A5C500")]
	private void ALHHLOEBGPO(THandle DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2580", Offset = "0x4FD1380", VA = "0x184FD2580")]
	private bool IPJILAPIGGE([Out] THandle DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4FD21F0", Offset = "0x4FD0FF0", VA = "0x184FD21F0")]
	private bool CJJNEHPACAN([Out] THandle DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2790", Offset = "0x4FD1590", VA = "0x184FD2790")]
	private void NIPMIGDFALK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FOLAMDMFEJK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int GBFKBOHPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int CALPLMDODGH
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
public static class KMNPPMLNAGD
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C450E0", Offset = "0x3C43EE0", VA = "0x183C450E0")]
	public static bool JLHAEFOCMFD<T>(this T DADONNGONOC, T LOKLFHKEJPC) where T : struct, FOLAMDMFEJK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C450D0", Offset = "0x3C43ED0", VA = "0x183C450D0")]
	public static bool IHBLCGMONJM<T>(this T DADONNGONOC) where T : struct, FOLAMDMFEJK
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80B7E40", Offset = "0x80B6C40", VA = "0x1880B7E40")]
	public static string OJHBKKNEOPA(this FOLAMDMFEJK DADONNGONOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct FGKHGPMAONK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type OABCNIDAGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> CFCANHPIMDP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x53D5BD0", Offset = "0x53D49D0", VA = "0x1853D5BD0")]
	public FGKHGPMAONK(Type CJGCAGGMHKJ, Span<byte> AJHFMGPCLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B63970", Offset = "0x3B62770", VA = "0x183B63970")]
	public static FGKHGPMAONK LJODEGLIPMG<T>(T BNECONOIKOE) where T : struct
	{
		return default(FGKHGPMAONK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x80B79C0", Offset = "0x80B67C0", VA = "0x1880B79C0")]
	public static LJHNPNKAGLL JGGBAIGHKJA([In] FGKHGPMAONK GCOEALJJGEI)
	{
		return default(LJHNPNKAGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x80B7930", Offset = "0x80B6730", VA = "0x1880B7930")]
	public Enum IAPPMDKGMKJ(Type BOEOHEICOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3B63940", Offset = "0x3B62740", VA = "0x183B63940")]
	public void LAGAMOKKAFA<T>([In] T BNECONOIKOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x80B79B0", Offset = "0x80B67B0", VA = "0x1880B79B0")]
	public void ICECDBOGHCE(Enum HECBCEDKAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct LJHNPNKAGLL
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct GMMHBBBGOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* MBGABICMPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* ENCNEIGDFEI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type OABCNIDAGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> CFCANHPIMDP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OLBNJFDBMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x80B8200", Offset = "0x80B7000", VA = "0x1880B8200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BCAOGMAHIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x80B83E0", Offset = "0x80B71E0", VA = "0x1880B83E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53D5BD0", Offset = "0x53D49D0", VA = "0x1853D5BD0")]
	public LJHNPNKAGLL(Type CJGCAGGMHKJ, ReadOnlySpan<byte> AJHFMGPCLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C56E90", Offset = "0x3C55C90", VA = "0x183C56E90")]
	public static LJHNPNKAGLL LJODEGLIPMG<T>(T BNECONOIKOE) where T : struct
	{
		return default(LJHNPNKAGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x80B8430", Offset = "0x80B7230", VA = "0x1880B8430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x80B8210", Offset = "0x80B7010", VA = "0x1880B8210")]
	public object EBHPDNINIBN(int CKFKPOAGPKN = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct LKOEPAIAGAB
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C58610", Offset = "0x3C57410", VA = "0x183C58610")]
	public static NativeArray<T> LJODEGLIPMG<T>(T BNECONOIKOE, bool IJHOIHKCLJE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3C586C0", Offset = "0x3C574C0", VA = "0x183C586C0")]
	public static NativeArray<T> NEDOOIIFHLA<T>(T BNECONOIKOE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C585E0", Offset = "0x3C573E0", VA = "0x183C585E0")]
	public static NativeArray<T> HCIFJNHEIOB<T>(T BNECONOIKOE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x80B85B0", Offset = "0x80B73B0", VA = "0x1880B85B0")]
	public static NativeArray<byte> HCIFJNHEIOB(ReadOnlySpan<byte> BNECONOIKOE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x80B8670", Offset = "0x80B7470", VA = "0x1880B8670")]
	public static NativeArray<byte> LJODEGLIPMG(ReadOnlySpan<byte> BNECONOIKOE, bool IJHOIHKCLJE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x80B8720", Offset = "0x80B7520", VA = "0x1880B8720")]
	public unsafe static NativeArray<byte> LJODEGLIPMG(byte* NMGAKCNLLDI, int IDFEOHMGIAF, bool IJHOIHKCLJE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3C58650", Offset = "0x3C57450", VA = "0x183C58650")]
	public static NativeArray<T> MMHNBCKELFI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct LDHCDKBGJPP : IEquatable<LDHCDKBGJPP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int NHAMEADDKAO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type KICDHMJGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80B8070", Offset = "0x80B6E70", VA = "0x1880B8070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x80B8160", Offset = "0x80B6F60", VA = "0x1880B8160")]
	public LDHCDKBGJPP(Type DGPNPBEKOOD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x80B7FE0", Offset = "0x80B6DE0", VA = "0x1880B7FE0")]
	public static LDHCDKBGJPP JGGBAIGHKJA(Type DGPNPBEKOOD)
	{
		return default(LDHCDKBGJPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x23CA4D0", Offset = "0x23C92D0", VA = "0x1823CA4D0", Slot = "4")]
	public bool Equals(LDHCDKBGJPP LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x80B7F50", Offset = "0x80B6D50", VA = "0x1880B7F50", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80B8120", Offset = "0x80B6F20", VA = "0x1880B8120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DBJKNDCBGGL
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> BJNGBIAIDFM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> JHACMKNCHLF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80B77A0", Offset = "0x80B65A0", VA = "0x1880B77A0")]
	static DBJKNDCBGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x80B7530", Offset = "0x80B6330", VA = "0x1880B7530")]
	public static bool OLHPIGGMIDE(Type DGPNPBEKOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80B7590", Offset = "0x80B6390", VA = "0x1880B7590")]
	private static bool OLHPIGGMIDE(Type DGPNPBEKOOD, [Out] int CKFKPOAGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x80B7740", Offset = "0x80B6540", VA = "0x1880B7740")]
	public static int PHAEBEKFBAF(Type DGPNPBEKOOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80B74B0", Offset = "0x80B62B0", VA = "0x1880B74B0")]
	public static Type LHCLHJGACJJ(int CKFKPOAGPKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JHDBBFGLNIJ<Handle> where Handle : FOLAMDMFEJK, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct MHOCOFGLDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly JHDBBFGLNIJ<Handle> DLFKJJNLNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int CKFKPOAGPKN;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle MALGOHBFHBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x5676FC0", Offset = "0x5675DC0", VA = "0x185676FC0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5677400", Offset = "0x5676200", VA = "0x185677400")]
		public MHOCOFGLDOI(JHDBBFGLNIJ<Handle> DLFKJJNLNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5677360", Offset = "0x5676160", VA = "0x185677360")]
		public BAEMHDJMEAK OGAKBGHEIKK([In] BAEMHDJMEAK FCNMCCJKGMG)
		{
			return default(BAEMHDJMEAK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5676EB0", Offset = "0x5675CB0", VA = "0x185676EB0")]
		public bool CELMNIAJJCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5677300", Offset = "0x5676100", VA = "0x185677300")]
		private Handle IFJGHMFEEGF(string IIHOFBLPONF)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct BAEMHDJMEAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MHOCOFGLDOI AJJJDEPLCJF;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x622CB90", Offset = "0x622B990", VA = "0x18622CB90")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x622CC90", Offset = "0x622BA90", VA = "0x18622CC90")]
		public BAEMHDJMEAK(JHDBBFGLNIJ<Handle> DLFKJJNLNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x622CB10", Offset = "0x622B910", VA = "0x18622CB10")]
		public bool CELMNIAJJCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x622CC10", Offset = "0x622BA10", VA = "0x18622CC10")]
		public BAEMHDJMEAK OMGGHMFPBJO()
		{
			return default(BAEMHDJMEAK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> LHJMNIBBCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> LJFFDAIIFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int CBEGHOAJAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int IMJEHGHADPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool FAJJENPPKCE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FOILODIMODM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x51A72A0", Offset = "0x51A60A0", VA = "0x1851A72A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BAEMHDJMEAK PCPKJFEHDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x51A83D0", Offset = "0x51A71D0", VA = "0x1851A83D0")]
		get
		{
			return default(BAEMHDJMEAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x51A8820", Offset = "0x51A7620", VA = "0x1851A8820")]
	public JHDBBFGLNIJ(int NMCMGBJLDBH, Allocator DFGMDNGNOEN = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x51A7D40", Offset = "0x51A6B40", VA = "0x1851A7D40")]
	public void LEFDKMKGENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x232E290", Offset = "0x232D090", VA = "0x18232E290")]
	public static int BKCIMLFCADP(int FPJNLHKNPEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x30A90C0", Offset = "0x30A7EC0", VA = "0x1830A90C0")]
	public static bool AOOFFJCDDJK(int FPJNLHKNPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x51A7440", Offset = "0x51A6240", VA = "0x1851A7440")]
	public bool HBIOAEEBAPI(int CKFKPOAGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x51A80E0", Offset = "0x51A6EE0", VA = "0x1851A80E0")]
	public bool OONANCJMDPP(Handle DADONNGONOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x51A7100", Offset = "0x51A5F00", VA = "0x1851A7100")]
	public Handle COLMIOMKIDM()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x51A7980", Offset = "0x51A6780", VA = "0x1851A7980")]
	public void HJEKPGLLFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x51A75D0", Offset = "0x51A63D0", VA = "0x1851A75D0")]
	public void HEEIMPGBKCE(Handle DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810")]
	private bool GDLBBGBEJCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x51A8080", Offset = "0x51A6E80", VA = "0x1851A8080")]
	private bool NMBMCEMCOPA(int CKFKPOAGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x51A85E0", Offset = "0x51A73E0", VA = "0x1851A85E0")]
	private void PMLKDJFKKOI([Out] int CKFKPOAGPKN, [Out] int DMIBKIHBLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x51A6CE0", Offset = "0x51A5AE0", VA = "0x1851A6CE0")]
	private void ANIEDICDFJA(Handle DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x51A7CA0", Offset = "0x51A6AA0", VA = "0x1851A7CA0")]
	private void KDPDHEEMKOF(int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x51A7F70", Offset = "0x51A6D70", VA = "0x1851A7F70")]
	private bool NJEMECFELDM([Out] int CKFKPOAGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x51A6F70", Offset = "0x51A5D70", VA = "0x1851A6F70")]
	private static Handle BKGOIFOADCD(int CKFKPOAGPKN, int DMIBKIHBLCP)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct IAJAGBHBKMA<Handle, T> where Handle : FOLAMDMFEJK, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private JHDBBFGLNIJ<Handle> MCDFJONKDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] PHGDIPJAEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> ENGONDNAIJM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D760", Offset = "0x4F0C560", VA = "0x184F0D760")]
	public IAJAGBHBKMA(int NMCMGBJLDBH, [Optional] Action<T> ENGONDNAIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D290", Offset = "0x4F0C090", VA = "0x184F0D290")]
	public void LEFDKMKGENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D080", Offset = "0x4F0BE80", VA = "0x184F0D080")]
	public bool GNHMKAHECGG(Handle DADONNGONOC, [Out] T MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D560", Offset = "0x4F0C360", VA = "0x184F0D560")]
	public Handle OLHPIGGMIDE(T MKPNGAKJFMP)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F0CC00", Offset = "0x4F0BA00", VA = "0x184F0CC00")]
	public void GIEPIPFJEFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F0C880", Offset = "0x4F0B680", VA = "0x184F0C880")]
	public void EBNLHEFHMEO(Handle DADONNGONOC, [Out] T CCJBGDNHCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F0CA60", Offset = "0x4F0B860", VA = "0x184F0CA60")]
	public void EBNLHEFHMEO(Handle DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D3D0", Offset = "0x4F0C1D0", VA = "0x184F0D3D0")]
	private T OGMLKCBPBFI(int CKFKPOAGPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F0D320", Offset = "0x4F0C120", VA = "0x184F0D320")]
	private void OFNMFJFHADC(int PBLNDLIKBOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct CPOPDMAPGMA<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct FJIIMGDJFNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private CPOPDMAPGMA<T> COPOPHFGNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int CKFKPOAGPKN;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4CB9390", Offset = "0x4CB8190", VA = "0x184CB9390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x29EFAD0", Offset = "0x29EE8D0", VA = "0x1829EFAD0")]
		public FJIIMGDJFNP(CPOPDMAPGMA<T> COPOPHFGNFG, int CKFKPOAGPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4CB9340", Offset = "0x4CB8140", VA = "0x184CB9340")]
		public bool CELMNIAJJCM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IKIHNDONMHM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CPOPDMAPGMA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public IKIHNDONMHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4F27B00", Offset = "0x4F26900", VA = "0x184F27B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F27BA0", Offset = "0x4F269A0", VA = "0x184F27BA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class PCONINBBEPD : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CPOPDMAPGMA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public PCONINBBEPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x59795F0", Offset = "0x59783F0", VA = "0x1859795F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5979690", Offset = "0x5978490", VA = "0x185979690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] BOIPFNOKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint BNECONOIKOE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B46770", Offset = "0x5B45570", VA = "0x185B46770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NPDDCPKLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69BCB70", Offset = "0x69BB970", VA = "0x1869BCB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HFECACFKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x196DE40", Offset = "0x196CC40", VA = "0x18196DE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool KGLMBPAGBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x69BC620", Offset = "0x69BB420", VA = "0x1869BC620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ACCBBCBBAJC<T> CFCANHPIMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x69BC2E0", Offset = "0x69BB0E0", VA = "0x1869BC2E0")]
		get
		{
			return default(ACCBBCBBAJC<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69BC4E0", Offset = "0x69BB2E0", VA = "0x1869BC4E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69BC730", Offset = "0x69BB530", VA = "0x1869BC730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69BCF60", Offset = "0x69BBD60", VA = "0x1869BCF60")]
	internal CPOPDMAPGMA(CPOPDMAPGMA<T> COPOPHFGNFG, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x69BCF40", Offset = "0x69BBD40", VA = "0x1869BCF40")]
	private CPOPDMAPGMA(T[] COPOPHFGNFG, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x69BCF80", Offset = "0x69BBD80", VA = "0x1869BCF80")]
	public CPOPDMAPGMA(IEnumerable<T> FEBLBJIINOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x69BD2A0", Offset = "0x69BC0A0", VA = "0x1869BD2A0")]
	public CPOPDMAPGMA(int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x69BC630", Offset = "0x69BB430", VA = "0x1869BC630")]
	public int GEOKHIPDOII(T BNECONOIKOE, int DKBLEPBOJIC, int LJEIHABMGGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x69BC7E0", Offset = "0x69BB5E0", VA = "0x1869BC7E0")]
	public void IGFDCIGIKEB(int GMELIBGMBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x69BC920", Offset = "0x69BB720", VA = "0x1869BC920")]
	private void KEANBODGGNL(int GMELIBGMBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x69BCAF0", Offset = "0x69BB8F0", VA = "0x1869BCAF0")]
	public T[] LIMPOIPHGEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x69BCC10", Offset = "0x69BBA10", VA = "0x1869BCC10")]
	public T[] OOHJPFAIEAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x69BC460", Offset = "0x69BB260", VA = "0x1869BC460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69BC5B0", Offset = "0x69BB3B0", VA = "0x1869BC5B0")]
	public void EPNHIBHGOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x69BCBA0", Offset = "0x69BB9A0", VA = "0x1869BCBA0")]
	public FJIIMGDJFNP OMGGHMFPBJO()
	{
		return default(FJIIMGDJFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69BCD60", Offset = "0x69BBB60", VA = "0x1869BCD60", Slot = "5")]
	[IteratorStateMachine(typeof(CPOPDMAPGMA<>.IKIHNDONMHM))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69BCE50", Offset = "0x69BBC50", VA = "0x1869BCE50", Slot = "6")]
	[IteratorStateMachine(typeof(CPOPDMAPGMA<>.PCONINBBEPD))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69BC8C0", Offset = "0x69BB6C0", VA = "0x1869BC8C0")]
	public static CPOPDMAPGMA<T> JJANHFMMOPO(T[] COPOPHFGNFG)
	{
		return default(CPOPDMAPGMA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69BC830", Offset = "0x69BB630", VA = "0x1869BC830")]
	public static CPOPDMAPGMA<T> JGGBAIGHKJA(T[] COPOPHFGNFG)
	{
		return default(CPOPDMAPGMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69BC6B0", Offset = "0x69BB4B0", VA = "0x1869BC6B0")]
	private void GMIDDCJEJGB(int CKFKPOAGPKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class IPIAILDABBI
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF960", Offset = "0x3BCE760", VA = "0x183BCF960")]
	public static CPOPDMAPGMA<T> OCEMMIMBNHP<T>(this IEnumerable<T> FHHFKEIPMHD) where T : class
	{
		return default(CPOPDMAPGMA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class GDLAFIILODC<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct PNIHJCIBFME : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private GDLAFIILODC<T> ECEBLBALENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int CKFKPOAGPKN;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x59CE330", Offset = "0x59CD130", VA = "0x1859CE330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x59CE370", Offset = "0x59CD170", VA = "0x1859CE370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x48C3E20", Offset = "0x48C2C20", VA = "0x1848C3E20")]
		public PNIHJCIBFME(GDLAFIILODC<T> ECEBLBALENP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x59CE250", Offset = "0x59CD050", VA = "0x1859CE250", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x59CE2E0", Offset = "0x59CD0E0", VA = "0x1859CE2E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private CPOPDMAPGMA<T> BOIPFNOKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int IDFEOHMGIAF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4D76980", Offset = "0x4D75780", VA = "0x184D76980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4D761B0", Offset = "0x4D74FB0", VA = "0x184D761B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4913400", Offset = "0x4912200", VA = "0x184913400", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int FOILODIMODM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4D75DC0", Offset = "0x4D74BC0", VA = "0x184D75DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool HFECACFKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D20", Offset = "0x4D74B20", VA = "0x184D75D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ACCBBCBBAJC<T> CFCANHPIMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4D75AD0", Offset = "0x4D748D0", VA = "0x184D75AD0")]
		get
		{
			return default(ACCBBCBBAJC<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4D76880", Offset = "0x4D75680", VA = "0x184D76880")]
	public GDLAFIILODC(IEnumerable<T> FEBLBJIINOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4D76910", Offset = "0x4D75710", VA = "0x184D76910")]
	public GDLAFIILODC(int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D76190", Offset = "0x4D74F90", VA = "0x184D76190")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4D75E60", Offset = "0x4D74C60", VA = "0x184D75E60")]
	public CPOPDMAPGMA<T> IAFIABBEGGL()
	{
		return default(CPOPDMAPGMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4D761D0", Offset = "0x4D74FD0", VA = "0x184D761D0")]
	public void OLHPIGGMIDE(T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4D75EB0", Offset = "0x4D74CB0", VA = "0x184D75EB0")]
	private void IGFDCIGIKEB(int COJMCLGONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4D75FA0", Offset = "0x4D74DA0", VA = "0x184D75FA0")]
	public void MBGFCNOCIDA(List<T> GAMMEDAFION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4D76110", Offset = "0x4D74F10", VA = "0x184D76110")]
	public void MBGFCNOCIDA(T[] GAMMEDAFION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4D75A40", Offset = "0x4D74840", VA = "0x184D75A40")]
	public void BCJHCFOGIGA(int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4D76570", Offset = "0x4D75370", VA = "0x184D76570")]
	public void PDLDIFOGOGI(int DMJFNPNEHKA, int CNDOBMAKBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D40", Offset = "0x4D74B40", VA = "0x184D75D40")]
	public int GEOKHIPDOII(T BNECONOIKOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4D75B60", Offset = "0x4D74960", VA = "0x184D75B60")]
	public bool CGCEPCBCCPD(T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4D762D0", Offset = "0x4D750D0", VA = "0x184D762D0")]
	public T[] OOHJPFAIEAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4D75BA0", Offset = "0x4D749A0", VA = "0x184D75BA0", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4D75EF0", Offset = "0x4D74CF0", VA = "0x184D75EF0")]
	public static CPOPDMAPGMA<T> JGGBAIGHKJA(GDLAFIILODC<T> ECEBLBALENP)
	{
		return default(CPOPDMAPGMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4D75DE0", Offset = "0x4D74BE0", VA = "0x184D75DE0", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4D767E0", Offset = "0x4D755E0", VA = "0x184D767E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4D76810", Offset = "0x4D75610", VA = "0x184D76810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4D75BD0", Offset = "0x4D749D0", VA = "0x184D75BD0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void EGGLFJAINIA(int BNECONOIKOE, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4D76340", Offset = "0x4D75140", VA = "0x184D76340")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PCFHMCAOALG(int DMJFNPNEHKA, int CNDOBMAKBFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FALKIGLPDLC
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D9D0", Offset = "0x3B5C7D0", VA = "0x183B5D9D0")]
	public static void EPNHIBHGOLH<T>(this GDLAFIILODC<T> ECEBLBALENP) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct ACCBBCBBAJC<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> BOIPFNOKGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD2A0", Offset = "0x4EAC0A0", VA = "0x184EAD2A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD5C0", Offset = "0x4EAC3C0", VA = "0x184EAD5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD530", Offset = "0x4EAC330", VA = "0x184EAD530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public ACCBBCBBAJC(Span<object> AJHFMGPCLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD410", Offset = "0x4EAC210", VA = "0x184EAD410")]
	public ACCBBCBBAJC<T> EKPIJCOKCLL(int DKBLEPBOJIC)
	{
		return default(ACCBBCBBAJC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD330", Offset = "0x4EAC130", VA = "0x184EAD330")]
	public ACCBBCBBAJC<T> EKPIJCOKCLL(int DKBLEPBOJIC, int IDFEOHMGIAF)
	{
		return default(ACCBBCBBAJC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD5F0", Offset = "0x4EAC3F0", VA = "0x184EAD5F0")]
	public void HPANNKPMOKF(ACCBBCBBAJC<T> FMOLIEPCLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD650", Offset = "0x4EAC450", VA = "0x184EAD650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD4E0", Offset = "0x4EAC2E0", VA = "0x184EAD4E0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD570", Offset = "0x4EAC370", VA = "0x184EAD570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct PIHJPNGEKCI : IEquatable<PIHJPNGEKCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int DOBKAGHAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int LJEIHABMGGI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int KJPGBDEIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x30BACB0", Offset = "0x30B9AB0", VA = "0x1830BACB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6E47E60", Offset = "0x6E46C60", VA = "0x186E47E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int OIMMNBMJGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int OJELBMAMOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x80B8B60", Offset = "0x80B7960", VA = "0x1880B8B60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x80B8AC0", Offset = "0x80B78C0", VA = "0x1880B8AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) AENOAEHHIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x80B8A60", Offset = "0x80B7860", VA = "0x1880B8A60")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
	private PIHJPNGEKCI(int DOBKAGHAEBK, int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x29D5C00", Offset = "0x29D4A00", VA = "0x1829D5C00")]
	public static PIHJPNGEKCI BMPMAMEBJPL(int DOBKAGHAEBK, int LJEIHABMGGI)
	{
		return default(PIHJPNGEKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x80B8B70", Offset = "0x80B7970", VA = "0x1880B8B70")]
	public static PIHJPNGEKCI MHOGMOODIOP(int DKBLEPBOJIC, int CNDOBMAKBFL)
	{
		return default(PIHJPNGEKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x80B8B80", Offset = "0x80B7980", VA = "0x1880B8B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1341670", Offset = "0x1340470", VA = "0x181341670", Slot = "4")]
	public bool Equals(PIHJPNGEKCI LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x80B8AD0", Offset = "0x80B78D0", VA = "0x1880B8AD0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x73C6D30", Offset = "0x73C5B30", VA = "0x1873C6D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct NMGPFDAGFPE<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> BOIPFNOKGBJ;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x141D1E0", Offset = "0x141BFE0", VA = "0x18141D1E0")]
	public NMGPFDAGFPE(NativeArray<T> BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x570D010", Offset = "0x570BE10", VA = "0x18570D010", Slot = "6")]
	public int Compare(int DHOMBGCEEAK, int EDBCCDDDLPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x570D100", Offset = "0x570BF00", VA = "0x18570D100", Slot = "4")]
	public bool Equals(int DHOMBGCEEAK, int EDBCCDDDLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x570D1F0", Offset = "0x570BFF0", VA = "0x18570D1F0", Slot = "5")]
	public int GetHashCode(int DHOMBGCEEAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PKEMHHPHIKM
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3D66680", Offset = "0x3D65480", VA = "0x183D66680")]
	public static T[] PIOEMHDDGFM<T>(List<T> ECEBLBALENP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LDDNBGPANHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* LDADOBNNOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle CGDAPHCNFOD;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5E23090", Offset = "0x5E21E90", VA = "0x185E23090")]
	public void LEFDKMKGENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class DIMNFNOMKDO
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x39E5520", Offset = "0x39E4320", VA = "0x1839E5520")]
	public static LDDNBGPANHO DDBFMLNEKPF<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> NGHKKFKEBOC) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(LDDNBGPANHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x39E5520", Offset = "0x39E4320", VA = "0x1839E5520")]
	public static UnsafeParallelHashMap<TKey, TValue> DBLJHBBIGGM<TKey, TValue>(this LDDNBGPANHO NGHKKFKEBOC) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class PPGHFBOKJEM
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3D75480", Offset = "0x3D74280", VA = "0x183D75480")]
	public static int LBAPGGHILAH<T>(ReadOnlySpan<T> ACJOJKGDHNK, ReadOnlySpan<T> LECNKMKOPNN, int IDFEOHMGIAF) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HICIEFPNEFG
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F7E0", Offset = "0x3B9E5E0", VA = "0x183B9F7E0")]
	public static T JEJBOKHGDOH<T>(this NativeArray<byte> GGCHDPHENOB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F870", Offset = "0x3B9E670", VA = "0x183B9F870")]
	public static NativeArray<T> NLPAEFGIMNF<T>(this NativeArray<byte> GGCHDPHENOB, int LJEIHABMGGI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F630", Offset = "0x3B9E430", VA = "0x183B9F630")]
	public static void HFOAKAKOEPN<T>(this NativeList<byte> KDLKIOAIFBA, [In] T BNECONOIKOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F5A0", Offset = "0x3B9E3A0", VA = "0x183B9F5A0")]
	public static void HFOAKAKOEPN<T>(this NativeList<byte> KDLKIOAIFBA, NativeArray<T> BNECONOIKOE) where T : struct
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

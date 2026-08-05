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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A1A0", Offset = "0x7D98FA0", VA = "0x187D9A1A0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[NGNCNDAJCGA]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AD39B0", Offset = "0x3AD27B0", VA = "0x183AD39B0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[NGNCNDAJCGA]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4B50", Offset = "0x3AD3950", VA = "0x183AD4B50")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3BB0", Offset = "0x3AD29B0", VA = "0x183AD3BB0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3DF0", Offset = "0x3AD2BF0", VA = "0x183AD3DF0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3ADEC60", Offset = "0x3ADDA60", VA = "0x183ADEC60")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE970", Offset = "0x3ADD770", VA = "0x183ADE970")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADEB20", Offset = "0x3ADD920", VA = "0x183ADEB20")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF360", Offset = "0x3ADE160", VA = "0x183ADF360")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD52D0", Offset = "0x3AD40D0", VA = "0x183AD52D0")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5490", Offset = "0x3AD4290", VA = "0x183AD5490")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD58C0", Offset = "0x3AD46C0", VA = "0x183AD58C0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, MAINECODIKP range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5900", Offset = "0x3AD4700", VA = "0x183AD5900")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5730", Offset = "0x3AD4530", VA = "0x183AD5730")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3A00", Offset = "0x3AD2800", VA = "0x183AD3A00")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3ADEA60", Offset = "0x3ADD860", VA = "0x183ADEA60")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[NGNCNDAJCGA]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF450", Offset = "0x3ADE250", VA = "0x183ADF450")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1300", Offset = "0x3AE0100", VA = "0x183AE1300")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3AE12B0", Offset = "0x3AE00B0", VA = "0x183AE12B0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x508D6C0", Offset = "0x508C4C0", VA = "0x18508D6C0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A650", Offset = "0x7D99450", VA = "0x187D9A650")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A680", Offset = "0x7D99480", VA = "0x187D9A680")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0860", Offset = "0x3ADF660", VA = "0x183AE0860")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE06F0", Offset = "0x3ADF4F0", VA = "0x183AE06F0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0930", Offset = "0x3ADF730", VA = "0x183AE0930")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE08E0", Offset = "0x3ADF6E0", VA = "0x183AE08E0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0890", Offset = "0x3ADF690", VA = "0x183AE0890")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE07C0", Offset = "0x3ADF5C0", VA = "0x183AE07C0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0CB0", Offset = "0x3ADFAB0", VA = "0x183AE0CB0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0B10", Offset = "0x3ADF910", VA = "0x183AE0B10")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0740", Offset = "0x3ADF540", VA = "0x183AE0740")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0690", Offset = "0x3ADF490", VA = "0x183AE0690")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0670", Offset = "0x3ADF470", VA = "0x183AE0670")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1820", Offset = "0x3AE0620", VA = "0x183AE1820")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1310", Offset = "0x3AE0110", VA = "0x183AE1310")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1850", Offset = "0x3AE0650", VA = "0x183AE1850")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1910", Offset = "0x3AE0710", VA = "0x183AE1910")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[NGNCNDAJCGA]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0E270", Offset = "0x4C0D070", VA = "0x184C0E270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xDE0900", Offset = "0xDDF700", VA = "0x180DE0900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x111AB20", Offset = "0x1119920", VA = "0x18111AB20")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x513F5D0", Offset = "0x513E3D0", VA = "0x18513F5D0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x550ABF0", Offset = "0x55099F0", VA = "0x18550ABF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x550AA30", Offset = "0x5509830", VA = "0x18550AA30")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3FDE020", Offset = "0x3FDCE20", VA = "0x183FDE020")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[NGNCNDAJCGA]
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
			[Cpp2IlInjected.Address(RVA = "0x4C0E270", Offset = "0x4C0D070", VA = "0x184C0E270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x555E3E0", Offset = "0x555D1E0", VA = "0x18555E3E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x513F5D0", Offset = "0x513E3D0", VA = "0x18513F5D0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x555DD10", Offset = "0x555CB10", VA = "0x18555DD10")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x555E000", Offset = "0x555CE00", VA = "0x18555E000")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x555E110", Offset = "0x555CF10", VA = "0x18555E110", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x555E040", Offset = "0x555CE40", VA = "0x18555E040")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NGNCNDAJCGA]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NGNCNDAJCGA]
public static class MHGLCDICNPP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A490", Offset = "0x7D99290", VA = "0x187D9A490")]
	public static JobHandle NJLONLCJHAA(this JobHandle CHIPBNNCPBF, JobHandle MDEAIGKHMKE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A3E0", Offset = "0x7D991E0", VA = "0x187D9A3E0")]
	public static JobHandle LIOMHLLBLJF(this Span<JobHandle> FPNAGIBIHJN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HAIDCCDLOLH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35A4720", Offset = "0x35A3520", VA = "0x1835A4720")]
	public static void CCLJDABAPHP<T>(this T[] KNDCNOIHMGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DJLFKGIGIHK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x375D880", Offset = "0x375C680", VA = "0x18375D880")]
	public static NativeKeyValueArrays<TKey, TValue> MENIEDFJEPJ<TKey, TValue>(this Dictionary<TKey, TValue> HLNAGBKDKBG, Allocator LNMGNHHGHLL) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EPAIPGGIOFP
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D99830", Offset = "0x7D98630", VA = "0x187D99830")]
	public static void PCPFKFAIFNA(this GameObject MMMAEDGEACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D99790", Offset = "0x7D98590", VA = "0x187D99790")]
	public static void PCPFKFAIFNA(this Component OFNOAHMACNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D996F0", Offset = "0x7D984F0", VA = "0x187D996F0")]
	public static void PCPFKFAIFNA(this ScriptableObject ABPAEHJJCMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KDLBBEDLCCI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A120", Offset = "0x7D98F20", VA = "0x187D9A120")]
	public static void DPALIPHJMKF(this NativeList<byte> COKPAJOONAO, ReadOnlySpan<byte> FNPNJDBGBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39C5770", Offset = "0x39C4570", VA = "0x1839C5770")]
	public static void PONGGFOGFNI<T>(this NativeList<T> COKPAJOONAO, T OAIIHELJHLG, int ALFGNAHPKIG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OABHKHIGNFG
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8890", Offset = "0x3AF7690", VA = "0x183AF8890")]
	public static T CDJFMOHPCML<T>(this ReadOnlySpan<byte> OAIIHELJHLG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8AD0", Offset = "0x3AF78D0", VA = "0x183AF8AD0")]
	public static T HOFFCLADEFE<T>(this Span<T> FNPNJDBGBFO, Func<T, bool> EJFOJGOLPON)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8C30", Offset = "0x3AF7A30", VA = "0x183AF8C30")]
	public static bool JCPINDJNAKP<T>(this Span<T> FNPNJDBGBFO, Func<T, bool> EJFOJGOLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9840", Offset = "0x3AF8640", VA = "0x183AF9840")]
	public static bool PGNLMIIDFAI<T>(this Span<T> FNPNJDBGBFO, Func<T, bool> EJFOJGOLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3AF92F0", Offset = "0x3AF80F0", VA = "0x183AF92F0")]
	public static T MBFFDPKOBBN<T>([In] this ReadOnlySpan<byte> FNPNJDBGBFO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39F1C90", Offset = "0x39F0A90", VA = "0x1839F1C90")]
	public static Span<TTo> GHCJIILCGDN<TTo, TFrom>(this Span<TFrom> FNPNJDBGBFO) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39F1C90", Offset = "0x39F0A90", VA = "0x1839F1C90")]
	public static ReadOnlySpan<TTo> GHCJIILCGDN<TTo, TFrom>(this ReadOnlySpan<TFrom> FNPNJDBGBFO) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39F1C90", Offset = "0x39F0A90", VA = "0x1839F1C90")]
	public static ReadOnlySpan<TTo> GHCJIILCGDN<TTo>(this ReadOnlySpan<byte> FNPNJDBGBFO) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF91F0", Offset = "0x3AF7FF0", VA = "0x183AF91F0")]
	public static Span<T> LAGKNEOGNDP<T>(this ReadOnlySpan<T> KHJEADFMOJM) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8CE0", Offset = "0x3AF7AE0", VA = "0x183AF8CE0")]
	public static Span<byte> KDAEEABIJCL<T>([In] this Span<byte> FNPNJDBGBFO, T OAIIHELJHLG) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9AC00", Offset = "0x7D99A00", VA = "0x187D9AC00")]
	private static Enum KDEONDNEJEL([In] ReadOnlySpan<byte> FNPNJDBGBFO, Type KHGGMDCPNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9AB90", Offset = "0x7D99990", VA = "0x187D9AB90")]
	public static Enum DMJBMEINKFF([In] this Span<byte> FNPNJDBGBFO, Type KHGGMDCPNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A6B0", Offset = "0x7D994B0", VA = "0x187D9A6B0")]
	public static void BIANAEGFODE([In] this Span<byte> FNPNJDBGBFO, Enum JMDMECFGMML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AHFMFOEIFMJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FGGGDHOEEBH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7D998D0", Offset = "0x7D986D0", VA = "0x187D998D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D99520", Offset = "0x7D98320", VA = "0x187D99520")]
	[AsyncStateMachine(typeof(FGGGDHOEEBH))]
	public static void DNHGDLHLOFH(this Task JIJABGNNHPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IDNKCJHEBDB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x39433C0", Offset = "0x39421C0", VA = "0x1839433C0")]
	public static NativeArray<T> AIDIFIEALFJ<T>(this UnsafeList<T> COKPAJOONAO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39434D0", Offset = "0x39422D0", VA = "0x1839434D0")]
	public static NativeArray<T> ODMBLEDBEDG<T>(this UnsafeList<T> COKPAJOONAO, bool DLODKGPBAGL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3943420", Offset = "0x3942220", VA = "0x183943420")]
	public static UnsafeList<T> LAGKNEOGNDP<T>(this UnsafeList<T> COKPAJOONAO, Allocator LNMGNHHGHLL) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MKPLBLPGLBI
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum IEGDKHJCMFG : short
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
	public struct ANOAGJPLGHG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly IEGDKHJCMFG MAKJJJECHHB;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2E93D50", Offset = "0x2E92B50", VA = "0x182E93D50")]
		public ANOAGJPLGHG(IEGDKHJCMFG MAKJJJECHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory IOLEFJBIFKA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	public static void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A4D0", Offset = "0x7D992D0", VA = "0x187D9A4D0")]
	static MKPLBLPGLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x35BF7C0", Offset = "0x35BE5C0", VA = "0x1835BF7C0")]
	public static ANOAGJPLGHG MCNALPIHNEM(IEGDKHJCMFG MAKJJJECHHB)
	{
		return default(ANOAGJPLGHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	public static void NKOGGLHHDEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KOPLBDDMHPE
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x39E2440", Offset = "0x39E1240", VA = "0x1839E2440")]
	public static HCLFABCHDCP<T1, T2> HANPNEPPHEE<T1, T2>(this (T1, T2) IHKPNNLPJHN) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(HCLFABCHDCP<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x39E2460", Offset = "0x39E1260", VA = "0x1839E2460")]
	public static KEBEHJGBKKC<T1, T2, T3> HANPNEPPHEE<T1, T2, T3>(this (T1, T2, T3) IHKPNNLPJHN) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(KEBEHJGBKKC<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HCLFABCHDCP<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) IHKPNNLPJHN;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4C175A0", Offset = "0x4C163A0", VA = "0x184C175A0")]
	public HCLFABCHDCP((T1, T2) IHKPNNLPJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4C173B0", Offset = "0x4C161B0", VA = "0x184C173B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KEBEHJGBKKC<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) IHKPNNLPJHN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4C175D0", Offset = "0x4C163D0", VA = "0x184C175D0")]
	public KEBEHJGBKKC((T1, T2, T3) IHKPNNLPJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x50A1590", Offset = "0x50A0390", VA = "0x1850A1590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class DHIOGINAKME
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D99690", Offset = "0x7D98490", VA = "0x187D99690")]
	public static Range ELFDDCGDHMG(this MAINECODIKP MIBGBKPCNLH)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CCHJOMHIPDK
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct FKMDFHIOLOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int DDEBNKFKCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int ONOFHBPOEEK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7D99A60", Offset = "0x7D98860", VA = "0x187D99A60")]
		public FKMDFHIOLOJ(int GNMMLFONKNO, int ONOFHBPOEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7D99A50", Offset = "0x7D98850", VA = "0x187D99A50")]
		public bool JONKILIIGKI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D99640", Offset = "0x7D98440", VA = "0x187D99640")]
	public static FKMDFHIOLOJ PHEMDOOJNPF(this Range MIBGBKPCNLH)
	{
		return default(FKMDFHIOLOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KACEBNOCGOH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle BHHPJCAPOMD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PBABFBFEBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x508D900", Offset = "0x508C700", VA = "0x18508D900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x508D6F0", Offset = "0x508C4F0", VA = "0x18508D6F0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x508DBC0", Offset = "0x508C9C0", VA = "0x18508DBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x508DD60", Offset = "0x508CB60", VA = "0x18508DD60")]
	public KACEBNOCGOH(T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x508D6C0", Offset = "0x508C4C0", VA = "0x18508D6C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class GOKPNNDFHDE<THandle, TValue> : IDisposable where THandle : struct, OBLKINNOMIA where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> FPNAGIBIHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> BGBLHEHBHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> MKJEBDLCEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> OJECJKBKBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int KMDLCBPEJHO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4BE1530", Offset = "0x4BE0330", VA = "0x184BE1530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1960", Offset = "0x4BE0760", VA = "0x184BE1960")]
	public GOKPNNDFHDE(Action<TValue> OJECJKBKBGB, [Optional] Func<TValue> MKJEBDLCEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1340", Offset = "0x4BE0140", VA = "0x184BE1340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0D90", Offset = "0x4BDFB90", VA = "0x184BE0D90")]
	public THandle AIKICPLLADB(TValue OAIIHELJHLG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4BE15C0", Offset = "0x4BE03C0", VA = "0x184BE15C0")]
	public bool KCGBACPBOON(THandle BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1410", Offset = "0x4BE0210", VA = "0x184BE1410")]
	public bool EDIACBOJIPL(THandle BHHPJCAPOMD, [Out] TValue OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4BE18B0", Offset = "0x4BE06B0", VA = "0x184BE18B0")]
	public TValue MBFFDPKOBBN(THandle BHHPJCAPOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0E90", Offset = "0x4BDFC90", VA = "0x184BE0E90")]
	public bool APHGFBFFFFI(THandle BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1900", Offset = "0x4BE0700", VA = "0x184BE1900")]
	private THandle OBLLCAJFJFM(int GLAOLHCPLLG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0E30", Offset = "0x4BDFC30", VA = "0x184BE0E30")]
	private TValue ALLJPLIMGBA(int GLAOLHCPLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4BE14E0", Offset = "0x4BE02E0", VA = "0x184BE14E0")]
	private void GLAFNHKBLHN(int GLAOLHCPLLG, [In] THandle BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1570", Offset = "0x4BE0370", VA = "0x184BE1570")]
	private void KAGLLOHFOOC(int GLAOLHCPLLG, [In] TValue OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1050", Offset = "0x4BDFE50", VA = "0x184BE1050")]
	private THandle BGLIGCHKGPP()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0C80", Offset = "0x4BDFA80", VA = "0x184BE0C80")]
	private void AIJDMCDCHNI(THandle BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1330", Offset = "0x4BE0130", VA = "0x184BE1330")]
	private int CACGMPPEGDC(int MFIBIFPFGCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4BE18A0", Offset = "0x4BE06A0", VA = "0x184BE18A0")]
	private bool LMAPJPNJMHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11510", VA = "0x180A12710")]
	private void OJLHJNNOOFM(THandle BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4BE0FA0", Offset = "0x4BDFDA0", VA = "0x184BE0FA0")]
	private bool BCDJGCFMAPE([Out] THandle BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4BE1200", Offset = "0x4BE0000", VA = "0x184BE1200")]
	private bool BHEFLLGOBDG([Out] THandle BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4BE16F0", Offset = "0x4BE04F0", VA = "0x184BE16F0")]
	private void LFFBOOFKDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OBLKINNOMIA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int KBDABDGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int JCCDJKBJEMD
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
public static class GACLFBPMIFG
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38FA8C0", Offset = "0x38F96C0", VA = "0x1838FA8C0")]
	public static bool COCAIIFINME<T>(this T BHHPJCAPOMD, T HBLONCAMFLG) where T : struct, OBLKINNOMIA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38FA8E0", Offset = "0x38F96E0", VA = "0x1838FA8E0")]
	public static bool JOCIPIGBAHE<T>(this T BHHPJCAPOMD) where T : struct, OBLKINNOMIA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7D99A70", Offset = "0x7D98870", VA = "0x187D99A70")]
	public static string MAIKGKKKBEI(this OBLKINNOMIA BHHPJCAPOMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct MPGMAKFMEHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type KCMCHDONHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> GEKFPFDKKJC;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x513F6A0", Offset = "0x513E4A0", VA = "0x18513F6A0")]
	public MPGMAKFMEHA(Type HIIDEKFEBIO, Span<byte> FNPNJDBGBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D8E0", Offset = "0x3A1C6E0", VA = "0x183A1D8E0")]
	public static MPGMAKFMEHA CAOJKMJCLDE<T>(T OAIIHELJHLG) where T : struct
	{
		return default(MPGMAKFMEHA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A5D0", Offset = "0x7D993D0", VA = "0x187D9A5D0")]
	public static HGLLOOGIBCJ HEKJAOMNHLJ([In] MPGMAKFMEHA JGFHGJBECJA)
	{
		return default(HGLLOOGIBCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A550", Offset = "0x7D99350", VA = "0x187D9A550")]
	public Enum DMJBMEINKFF(Type KHGGMDCPNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1E270", Offset = "0x3A1D070", VA = "0x183A1E270")]
	public void KDAEEABIJCL<T>([In] T OAIIHELJHLG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A540", Offset = "0x7D99340", VA = "0x187D9A540")]
	public void BIANAEGFODE(Enum JMDMECFGMML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct HGLLOOGIBCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct IHPODNJLJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* IKOBOACFOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* IGCCFPDANIF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type KCMCHDONHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> GEKFPFDKKJC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EHNJLIHBECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D99B80", Offset = "0x7D98980", VA = "0x187D99B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HCMJBKFEPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D99B90", Offset = "0x7D98990", VA = "0x187D99B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x513F6A0", Offset = "0x513E4A0", VA = "0x18513F6A0")]
	public HGLLOOGIBCJ(Type HIIDEKFEBIO, ReadOnlySpan<byte> FNPNJDBGBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x391DB30", Offset = "0x391C930", VA = "0x18391DB30")]
	public static HGLLOOGIBCJ CAOJKMJCLDE<T>(T OAIIHELJHLG) where T : struct
	{
		return default(HGLLOOGIBCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7D99DB0", Offset = "0x7D98BB0", VA = "0x187D99DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7D99BE0", Offset = "0x7D989E0", VA = "0x187D99BE0")]
	public object MBOEJKDGNCB(int GLAOLHCPLLG = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JEBJCAPNBDP
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3984050", Offset = "0x3982E50", VA = "0x183984050")]
	public static NativeArray<T> CAOJKMJCLDE<T>(T OAIIHELJHLG, bool DLODKGPBAGL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x39840A0", Offset = "0x3982EA0", VA = "0x1839840A0")]
	public static NativeArray<T> CDOEGDDJOBG<T>(T OAIIHELJHLG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x39840F0", Offset = "0x3982EF0", VA = "0x1839840F0")]
	public static NativeArray<T> EIFJHCKAOKF<T>(T OAIIHELJHLG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A060", Offset = "0x7D98E60", VA = "0x187D9A060")]
	public static NativeArray<byte> EIFJHCKAOKF(ReadOnlySpan<byte> OAIIHELJHLG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7D99FB0", Offset = "0x7D98DB0", VA = "0x187D99FB0")]
	public static NativeArray<byte> CAOJKMJCLDE(ReadOnlySpan<byte> OAIIHELJHLG, bool DLODKGPBAGL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7D99F30", Offset = "0x7D98D30", VA = "0x187D99F30")]
	public unsafe static NativeArray<byte> CAOJKMJCLDE(byte* CDACLPDOBIB, int NPCJGIOCILE, bool DLODKGPBAGL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3984140", Offset = "0x3982F40", VA = "0x183984140")]
	public static NativeArray<T> LJAJAMKHAJN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct OEHPENEOLJI : IEquatable<OEHPENEOLJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int HIICBEJDFMG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B6C0", Offset = "0x7D9A4C0", VA = "0x187D9B6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B840", Offset = "0x7D9A640", VA = "0x187D9B840")]
	public OEHPENEOLJI(Type AAFMBEEMJAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B770", Offset = "0x7D9A570", VA = "0x187D9B770")]
	public static OEHPENEOLJI HEKJAOMNHLJ(Type AAFMBEEMJAC)
	{
		return default(OEHPENEOLJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x21CB070", Offset = "0x21C9E70", VA = "0x1821CB070", Slot = "4")]
	public bool Equals(OEHPENEOLJI HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B640", Offset = "0x7D9A440", VA = "0x187D9B640", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B800", Offset = "0x7D9A600", VA = "0x187D9B800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ODDDCEBBDLD
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> IJENGICPAOB;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> JCCGMGNBCDB;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B4B0", Offset = "0x7D9A2B0", VA = "0x187D9B4B0")]
	static ODDDCEBBDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B1A0", Offset = "0x7D99FA0", VA = "0x187D9B1A0")]
	public static bool AIKICPLLADB(Type AAFMBEEMJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B200", Offset = "0x7D9A000", VA = "0x187D9B200")]
	private static bool AIKICPLLADB(Type AAFMBEEMJAC, [Out] int GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B3D0", Offset = "0x7D9A1D0", VA = "0x187D9B3D0")]
	public static int DDMFCGNGLKI(Type AAFMBEEMJAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B430", Offset = "0x7D9A230", VA = "0x187D9B430")]
	public static Type MBFFDPKOBBN(int GLAOLHCPLLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct DEAOJLOFOAA<Handle> where Handle : OBLKINNOMIA, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct COCEMOBLKEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly DEAOJLOFOAA<Handle> CEJJHFEJOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int GLAOLHCPLLG;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle BMEINGKEHNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x671C450", Offset = "0x671B250", VA = "0x18671C450")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x671C890", Offset = "0x671B690", VA = "0x18671C890")]
		public COCEMOBLKEM(DEAOJLOFOAA<Handle> CEJJHFEJOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x671C800", Offset = "0x671B600", VA = "0x18671C800")]
		public FOEGPPFJNBA NBEICDCLFEE([In] FOEGPPFJNBA AOJFFKDCAKJ)
		{
			return default(FOEGPPFJNBA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x671C5C0", Offset = "0x671B3C0", VA = "0x18671C5C0")]
		public bool JONKILIIGKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x671C280", Offset = "0x671B080", VA = "0x18671C280")]
		private Handle EOGOAFMJPHK(string NJJDPBHNDPA)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct FOEGPPFJNBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private COCEMOBLKEM DCAHIDHHAMN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4ADADA0", Offset = "0x4AD9BA0", VA = "0x184ADADA0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAF10", Offset = "0x4AD9D10", VA = "0x184ADAF10")]
		public FOEGPPFJNBA(DEAOJLOFOAA<Handle> CEJJHFEJOGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAE20", Offset = "0x4AD9C20", VA = "0x184ADAE20")]
		public bool JONKILIIGKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4ADAEA0", Offset = "0x4AD9CA0", VA = "0x184ADAEA0")]
		public FOEGPPFJNBA PHEMDOOJNPF()
		{
			return default(FOEGPPFJNBA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> LKPKEIALMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> PFGBCCGLGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int KOJDBGOLBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int ACOMNMFFFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool ODPFIENHBNA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HFLLAFNJABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0180", Offset = "0x6AEEF80", VA = "0x186AF0180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FOEGPPFJNBA DBHEDKPMANL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0D90", Offset = "0x6AEFB90", VA = "0x186AF0D90")]
		get
		{
			return default(FOEGPPFJNBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AF10A0", Offset = "0x6AEFEA0", VA = "0x186AF10A0")]
	public DEAOJLOFOAA(int NMACKFEHHPP, Allocator LNMGNHHGHLL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0280", Offset = "0x6AEF080", VA = "0x186AF0280")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2166F40", Offset = "0x2165D40", VA = "0x182166F40")]
	public static int CACGMPPEGDC(int LCFJFNFOMKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2EA8F10", Offset = "0x2EA7D10", VA = "0x182EA8F10")]
	public static bool JMGEENAJLAE(int LCFJFNFOMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFA40", Offset = "0x6AEE840", VA = "0x186AEFA40")]
	public bool FCJBPMLFCPG(int GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFB70", Offset = "0x6AEE970", VA = "0x186AEFB70")]
	public bool GNKKIMPJIJD(Handle BHHPJCAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0F00", Offset = "0x6AEFD00", VA = "0x186AF0F00")]
	public Handle PEAGBODEPOL()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0A80", Offset = "0x6AEF880", VA = "0x186AF0A80")]
	public void NEDPHFBEBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0E20", Offset = "0x6AEFC20", VA = "0x186AF0E20")]
	public void OFGHIEECDMM(Handle BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0")]
	private bool FAPIBEJFIEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF850", Offset = "0x6AEE650", VA = "0x186AEF850")]
	private bool EDKHIFEIJGM(int GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFFD0", Offset = "0x6AEEDD0", VA = "0x186AEFFD0")]
	private void IDIKDCBHBKB([Out] int GLAOLHCPLLG, [Out] int MFIBIFPFGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AF04A0", Offset = "0x6AEF2A0", VA = "0x186AF04A0")]
	private void MJPKFHPLDID(Handle BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF650", Offset = "0x6AEE450", VA = "0x186AEF650")]
	private void ADICEMKPPCE(int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0340", Offset = "0x6AEF140", VA = "0x186AF0340")]
	private bool MGHFFLEPEME([Out] int GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF6A0", Offset = "0x6AEE4A0", VA = "0x186AEF6A0")]
	private static Handle BBJDLGPIEEB(int GLAOLHCPLLG, int MFIBIFPFGCD)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct FNGLBMMBANM<Handle, T> where Handle : OBLKINNOMIA, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private DEAOJLOFOAA<Handle> MFDCNKFHNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] EOEOEAGGCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> NAMLOPMJFJL;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4AD6580", Offset = "0x4AD5380", VA = "0x184AD6580")]
	public FNGLBMMBANM(int NMACKFEHHPP, [Optional] Action<T> NAMLOPMJFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4AD5F80", Offset = "0x4AD4D80", VA = "0x184AD5F80")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4AD5950", Offset = "0x4AD4750", VA = "0x184AD5950")]
	public bool EDIACBOJIPL(Handle BHHPJCAPOMD, [Out] T GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4AD5850", Offset = "0x4AD4650", VA = "0x184AD5850")]
	public Handle AIKICPLLADB(T GLEBGNJJOHG)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4AD6060", Offset = "0x4AD4E60", VA = "0x184AD6060")]
	public void PHFIJJGOKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4AD5C60", Offset = "0x4AD4A60", VA = "0x184AD5C60")]
	public void FKCGDELNEED(Handle BHHPJCAPOMD, [Out] T BGLPNFGABCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4AD5E30", Offset = "0x4AD4C30", VA = "0x184AD5E30")]
	public void FKCGDELNEED(Handle BHHPJCAPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4AD6000", Offset = "0x4AD4E00", VA = "0x184AD6000")]
	private T OKAENFEBGHL(int GLAOLHCPLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4AD5AD0", Offset = "0x4AD48D0", VA = "0x184AD5AD0")]
	private void EDLENJFDEJL(int JIEHMGAKDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct CONCPCFABOF<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct GCDGGAANCHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private CONCPCFABOF<T> KNDCNOIHMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int GLAOLHCPLLG;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4B81BE0", Offset = "0x4B809E0", VA = "0x184B81BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28509F0", Offset = "0x284F7F0", VA = "0x1828509F0")]
		public GCDGGAANCHF(CONCPCFABOF<T> KNDCNOIHMGO, int GLAOLHCPLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4B81C30", Offset = "0x4B80A30", VA = "0x184B81C30")]
		public bool JONKILIIGKI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MKLOKCECEPP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CONCPCFABOF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public MKLOKCECEPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x53C9EE0", Offset = "0x53C8CE0", VA = "0x1853C9EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x53C9F80", Offset = "0x53C8D80", VA = "0x1853C9F80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IEAMPONFIHB : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CONCPCFABOF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public IEAMPONFIHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4D2FCC0", Offset = "0x4D2EAC0", VA = "0x184D2FCC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D2FD60", Offset = "0x4D2EB60", VA = "0x184D2FD60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] FFEMKICJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint OAIIHELJHLG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5920AE0", Offset = "0x591F8E0", VA = "0x185920AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DAEKNHIBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x671DCA0", Offset = "0x671CAA0", VA = "0x18671DCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AMBHJOJJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x179EA30", Offset = "0x179D830", VA = "0x18179EA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool MHNKEAFFLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x671DA60", Offset = "0x671C860", VA = "0x18671DA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public CMEKEBMAIIH<T> GEKFPFDKKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x671DAB0", Offset = "0x671C8B0", VA = "0x18671DAB0")]
		get
		{
			return default(CMEKEBMAIIH<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x671D870", Offset = "0x671C670", VA = "0x18671D870")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x671D760", Offset = "0x671C560", VA = "0x18671D760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x671DEB0", Offset = "0x671CCB0", VA = "0x18671DEB0")]
	internal CONCPCFABOF(CONCPCFABOF<T> KNDCNOIHMGO, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x671E210", Offset = "0x671D010", VA = "0x18671E210")]
	private CONCPCFABOF(T[] KNDCNOIHMGO, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x671DED0", Offset = "0x671CCD0", VA = "0x18671DED0")]
	public CONCPCFABOF(IEnumerable<T> BGBLHEHBHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x671E230", Offset = "0x671D030", VA = "0x18671E230")]
	public CONCPCFABOF(int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x671D410", Offset = "0x671C210", VA = "0x18671D410")]
	public int DAHONCDEKIP(T OAIIHELJHLG, int GNMMLFONKNO, int ALFGNAHPKIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x671DA70", Offset = "0x671C870", VA = "0x18671DA70")]
	public void MAAFMNPDBJK(int OPKNNFAFEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x671D510", Offset = "0x671C310", VA = "0x18671D510")]
	private void EDIAICFKAOG(int OPKNNFAFEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x671D6E0", Offset = "0x671C4E0", VA = "0x18671D6E0")]
	public T[] FJDHLGGOKED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x671D260", Offset = "0x671C060", VA = "0x18671D260")]
	public T[] ABDKJFIDJKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x671D490", Offset = "0x671C290", VA = "0x18671D490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x671D810", Offset = "0x671C610", VA = "0x18671D810")]
	public void GPMOCMONGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x671DC30", Offset = "0x671CA30", VA = "0x18671DC30")]
	public GCDGGAANCHF PHEMDOOJNPF()
	{
		return default(GCDGGAANCHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x671DCD0", Offset = "0x671CAD0", VA = "0x18671DCD0", Slot = "5")]
	[IteratorStateMachine(typeof(CONCPCFABOF<>.MKLOKCECEPP))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x671DDC0", Offset = "0x671CBC0", VA = "0x18671DDC0", Slot = "6")]
	[IteratorStateMachine(typeof(CONCPCFABOF<>.IEAMPONFIHB))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x671D3B0", Offset = "0x671C1B0", VA = "0x18671D3B0")]
	public static CONCPCFABOF<T> AGECHJMGBOM(T[] KNDCNOIHMGO)
	{
		return default(CONCPCFABOF<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x671D9C0", Offset = "0x671C7C0", VA = "0x18671D9C0")]
	public static CONCPCFABOF<T> HEKJAOMNHLJ(T[] KNDCNOIHMGO)
	{
		return default(CONCPCFABOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x671D940", Offset = "0x671C740", VA = "0x18671D940")]
	private void HBHFIKNOKIL(int GLAOLHCPLLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class HIMKNIEIOHE<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct ENCAHKDNNLL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private HIMKNIEIOHE<T> COKPAJOONAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int GLAOLHCPLLG;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x46135F0", Offset = "0x46123F0", VA = "0x1846135F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4613650", Offset = "0x4612450", VA = "0x184613650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4613630", Offset = "0x4612430", VA = "0x184613630")]
		public ENCAHKDNNLL(HIMKNIEIOHE<T> COKPAJOONAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4613500", Offset = "0x4612300", VA = "0x184613500", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x46135A0", Offset = "0x46123A0", VA = "0x1846135A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private CONCPCFABOF<T> FFEMKICJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int NPCJGIOCILE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4C30870", Offset = "0x4C2F670", VA = "0x184C30870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4AD4010", Offset = "0x4AD2E10", VA = "0x184AD4010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int HFLLAFNJABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4C309A0", Offset = "0x4C2F7A0", VA = "0x184C309A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool AMBHJOJJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C307E0", Offset = "0x4C2F5E0", VA = "0x184C307E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public CMEKEBMAIIH<T> GEKFPFDKKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4C30C50", Offset = "0x4C2FA50", VA = "0x184C30C50")]
		get
		{
			return default(CMEKEBMAIIH<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4C30DC0", Offset = "0x4C2FBC0", VA = "0x184C30DC0")]
	public HIMKNIEIOHE(int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C30170", Offset = "0x4C2EF70", VA = "0x184C30170")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C30CD0", Offset = "0x4C2FAD0", VA = "0x184C30CD0")]
	public CONCPCFABOF<T> OJAECEJJEAJ()
	{
		return default(CONCPCFABOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FF70", Offset = "0x4C2ED70", VA = "0x184C2FF70")]
	public void AIKICPLLADB(T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C30C10", Offset = "0x4C2FA10", VA = "0x184C30C10")]
	private void MAAFMNPDBJK(int KIOMCEJDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C30320", Offset = "0x4C2F120", VA = "0x184C30320")]
	public void DPALIPHJMKF(List<T> HMGJLPMKAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4C30280", Offset = "0x4C2F080", VA = "0x184C30280")]
	public void DPALIPHJMKF(T[] HMGJLPMKAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4C30090", Offset = "0x4C2EE90", VA = "0x184C30090")]
	public void BIMJJOKKJKF(int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4C304C0", Offset = "0x4C2F2C0", VA = "0x184C304C0")]
	public void EHKALOCOOJC(int APJHOBKKNEO, int ONOFHBPOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4C30200", Offset = "0x4C2F000", VA = "0x184C30200")]
	public int DAHONCDEKIP(T OAIIHELJHLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4C301B0", Offset = "0x4C2EFB0", VA = "0x184C301B0")]
	public bool CIMEKDDIMAF(T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FF00", Offset = "0x4C2ED00", VA = "0x184C2FF00")]
	public T[] ABDKJFIDJKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4C304A0", Offset = "0x4C2F2A0", VA = "0x184C304A0", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4C308E0", Offset = "0x4C2F6E0", VA = "0x184C308E0")]
	public static CONCPCFABOF<T> HEKJAOMNHLJ(HIMKNIEIOHE<T> COKPAJOONAO)
	{
		return default(CONCPCFABOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4C30800", Offset = "0x4C2F600", VA = "0x184C30800", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4C30D10", Offset = "0x4C2FB10", VA = "0x184C30D10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4C30D50", Offset = "0x4C2FB50", VA = "0x184C30D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4C30690", Offset = "0x4C2F490", VA = "0x184C30690")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void FAFMGPIINML(int OAIIHELJHLG, int NPCJGIOCILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4C309C0", Offset = "0x4C2F7C0", VA = "0x184C309C0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ILFKMEGLNCM(int APJHOBKKNEO, int ONOFHBPOEEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class JNPHGLHALEN
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x398B110", Offset = "0x3989F10", VA = "0x18398B110")]
	public static void GPMOCMONGPM<T>(this HIMKNIEIOHE<T> COKPAJOONAO) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public ref struct CMEKEBMAIIH<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> FFEMKICJPKP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6717FF0", Offset = "0x6716DF0", VA = "0x186717FF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6717F70", Offset = "0x6716D70", VA = "0x186717F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6717EE0", Offset = "0x6716CE0", VA = "0x186717EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1261FF0", Offset = "0x1260DF0", VA = "0x181261FF0")]
	public CMEKEBMAIIH(Span<object> FNPNJDBGBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x67181B0", Offset = "0x6716FB0", VA = "0x1867181B0")]
	public CMEKEBMAIIH<T> NDFNLFFLKFB(int GNMMLFONKNO)
	{
		return default(CMEKEBMAIIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67180D0", Offset = "0x6716ED0", VA = "0x1867180D0")]
	public CMEKEBMAIIH<T> NDFNLFFLKFB(int GNMMLFONKNO, int NPCJGIOCILE)
	{
		return default(CMEKEBMAIIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6718070", Offset = "0x6716E70", VA = "0x186718070")]
	public void JCJPJJOOLPO(CMEKEBMAIIH<T> AAKAGDOFPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6718280", Offset = "0x6717080", VA = "0x186718280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6717F20", Offset = "0x6716D20", VA = "0x186717F20", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6717FA0", Offset = "0x6716DA0", VA = "0x186717FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MAINECODIKP : IEquatable<MAINECODIKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int PPPFIBNDOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int ALFGNAHPKIG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int KJACMEPEAID
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6640", Offset = "0x2EB5440", VA = "0x182EB6640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2F0", Offset = "0x6F9E0F0", VA = "0x186F9F2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int ANBHKEFMDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int JPGAHJPOIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A340", Offset = "0x7D99140", VA = "0x187D9A340")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A2D0", Offset = "0x7D990D0", VA = "0x187D9A2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public (int begin, int end) CKNJGPPFCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A2E0", Offset = "0x7D990E0", VA = "0x187D9A2E0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
	private MAINECODIKP(int PPPFIBNDOMK, int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2832B70", Offset = "0x2831970", VA = "0x182832B70")]
	public static MAINECODIKP KDEHLIPOCDJ(int PPPFIBNDOMK, int ALFGNAHPKIG)
	{
		return default(MAINECODIKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A2C0", Offset = "0x7D990C0", VA = "0x187D9A2C0")]
	public static MAINECODIKP FPMJLGLFDIF(int GNMMLFONKNO, int ONOFHBPOEEK)
	{
		return default(MAINECODIKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A350", Offset = "0x7D99150", VA = "0x187D9A350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0xF1EF30", Offset = "0xF1DD30", VA = "0x180F1EF30", Slot = "4")]
	public bool Equals(MAINECODIKP HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A230", Offset = "0x7D99030", VA = "0x187D9A230", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7100940", Offset = "0x70FF740", VA = "0x187100940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct JHAMMBIJHCN<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> FFEMKICJPKP;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1261FF0", Offset = "0x1260DF0", VA = "0x181261FF0")]
	public JHAMMBIJHCN(NativeArray<T> FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4FACD50", Offset = "0x4FABB50", VA = "0x184FACD50", Slot = "6")]
	public int Compare(int AJEEBBBAOKG, int GJPKMHAOJHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4FACE40", Offset = "0x4FABC40", VA = "0x184FACE40", Slot = "4")]
	public bool Equals(int AJEEBBBAOKG, int GJPKMHAOJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4FACF30", Offset = "0x4FABD30", VA = "0x184FACF30", Slot = "5")]
	public int GetHashCode(int AJEEBBBAOKG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class BOFILPJJPND
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x36A9930", Offset = "0x36A8730", VA = "0x1836A9930")]
	public static T[] GLCJMKIPJIK<T>(List<T> COKPAJOONAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct NGGOCILBKLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* CKJAPPIDLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle DONCPFGOBLE;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E9D0", Offset = "0x5C0D7D0", VA = "0x185C0E9D0")]
	public void LNJEMOCDJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AJCCBGAIGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4047160", Offset = "0x4045F60", VA = "0x184047160")]
	public static NGGOCILBKLI KDEKDPJAJOM<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> MNMCPCDGAHI) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(NGGOCILBKLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4047160", Offset = "0x4045F60", VA = "0x184047160")]
	public static UnsafeParallelHashMap<TKey, TValue> ICDNKGJPONK<TKey, TValue>(this NGGOCILBKLI MNMCPCDGAHI) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class BOBDJDDJCMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x36A9800", Offset = "0x36A8600", VA = "0x1836A9800")]
	public static int FACIFDIJJDP<T>(ReadOnlySpan<T> ANPPPGKHJCE, ReadOnlySpan<T> NHDKDANPEKJ, int NPCJGIOCILE) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class EONOAFEGNLA
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3787B90", Offset = "0x3786990", VA = "0x183787B90")]
	public static T DCFINHBGJDA<T>(this NativeArray<byte> KHJEADFMOJM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3787EB0", Offset = "0x3786CB0", VA = "0x183787EB0")]
	public static NativeArray<T> MPJOPLILFMF<T>(this NativeArray<byte> KHJEADFMOJM, int ALFGNAHPKIG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3787C20", Offset = "0x3786A20", VA = "0x183787C20")]
	public static void KNLEDDADFAC<T>(this NativeList<byte> BHBDEJBFADC, [In] T OAIIHELJHLG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3787CD0", Offset = "0x3786AD0", VA = "0x183787CD0")]
	public static void KNLEDDADFAC<T>(this NativeList<byte> BHBDEJBFADC, NativeArray<T> OAIIHELJHLG) where T : struct
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

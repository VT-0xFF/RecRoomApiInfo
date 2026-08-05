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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D46130", Offset = "0x7D44B30", VA = "0x187D46130", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CBGOBHFCBKJ]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6B50", Offset = "0x3BC5550", VA = "0x183BC6B50")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CBGOBHFCBKJ]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3BC7BB0", Offset = "0x3BC65B0", VA = "0x183BC7BB0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6D50", Offset = "0x3BC5750", VA = "0x183BC6D50")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6EB0", Offset = "0x3BC58B0", VA = "0x183BC6EB0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFEB0", Offset = "0x3BCE8B0", VA = "0x183BCFEB0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFD40", Offset = "0x3BCE740", VA = "0x183BCFD40")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0500", Offset = "0x3BCEF00", VA = "0x183BD0500")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0600", Offset = "0x3BCF000", VA = "0x183BD0600")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8300", Offset = "0x3BC6D00", VA = "0x183BC8300")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8290", Offset = "0x3BC6C90", VA = "0x183BC8290")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC87B0", Offset = "0x3BC71B0", VA = "0x183BC87B0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, JOGKEMLKOOJ range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3BC87F0", Offset = "0x3BC71F0", VA = "0x183BC87F0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8630", Offset = "0x3BC7030", VA = "0x183BC8630")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6BA0", Offset = "0x3BC55A0", VA = "0x183BC6BA0")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFDF0", Offset = "0x3BCE7F0", VA = "0x183BCFDF0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CBGOBHFCBKJ]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BD06D0", Offset = "0x3BCF0D0", VA = "0x183BD06D0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2400", Offset = "0x3BD0E00", VA = "0x183BD2400")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BD23B0", Offset = "0x3BD0DB0", VA = "0x183BD23B0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x54AA5B0", Offset = "0x54A8FB0", VA = "0x1854AA5B0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D47150", Offset = "0x7D45B50", VA = "0x187D47150")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D47180", Offset = "0x7D45B80", VA = "0x187D47180")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1890", Offset = "0x3BD0290", VA = "0x183BD1890")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1840", Offset = "0x3BD0240", VA = "0x183BD1840")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1B90", Offset = "0x3BD0590", VA = "0x183BD1B90")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD17A0", Offset = "0x3BD01A0", VA = "0x183BD17A0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD17F0", Offset = "0x3BD01F0", VA = "0x183BD17F0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1A40", Offset = "0x3BD0440", VA = "0x183BD1A40")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1F00", Offset = "0x3BD0900", VA = "0x183BD1F00")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1D60", Offset = "0x3BD0760", VA = "0x183BD1D60")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BD18C0", Offset = "0x3BD02C0", VA = "0x183BD18C0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1740", Offset = "0x3BD0140", VA = "0x183BD1740")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1720", Offset = "0x3BD0120", VA = "0x183BD1720")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BD27E0", Offset = "0x3BD11E0", VA = "0x183BD27E0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2410", Offset = "0x3BD0E10", VA = "0x183BD2410")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2810", Offset = "0x3BD1210", VA = "0x183BD2810")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BD28C0", Offset = "0x3BD12C0", VA = "0x183BD28C0")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CBGOBHFCBKJ]
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
			[Cpp2IlInjected.Address(RVA = "0x4CD0EB0", Offset = "0x4CCF8B0", VA = "0x184CD0EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE4ADD0", Offset = "0xE497D0", VA = "0x180E4ADD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xDCB0C0", Offset = "0xDC9AC0", VA = "0x180DCB0C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5268F60", Offset = "0x5267960", VA = "0x185268F60")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x555FDA0", Offset = "0x555E7A0", VA = "0x18555FDA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x555FCC0", Offset = "0x555E6C0", VA = "0x18555FCC0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x41DF380", Offset = "0x41DDD80", VA = "0x1841DF380")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CBGOBHFCBKJ]
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
			[Cpp2IlInjected.Address(RVA = "0x55BBCD0", Offset = "0x55BA6D0", VA = "0x1855BBCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x55BBD10", Offset = "0x55BA710", VA = "0x1855BBD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xDCB0C0", Offset = "0xDC9AC0", VA = "0x180DCB0C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5268F60", Offset = "0x5267960", VA = "0x185268F60")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x55BB930", Offset = "0x55BA330", VA = "0x1855BB930")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x55BBA70", Offset = "0x55BA470", VA = "0x1855BBA70")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x55BBC30", Offset = "0x55BA630", VA = "0x1855BBC30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x55BBAB0", Offset = "0x55BA4B0", VA = "0x1855BBAB0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CBGOBHFCBKJ]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CBGOBHFCBKJ]
public static class MFOFGFMLEFL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D462D0", Offset = "0x7D44CD0", VA = "0x187D462D0")]
	public static JobHandle ENENEKCHCGF(this JobHandle MJGADEGDMOP, JobHandle LJDEEJKPAEN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D46310", Offset = "0x7D44D10", VA = "0x187D46310")]
	public static JobHandle GJJPABFAEJD(this Span<JobHandle> FMPLMPHMMMJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JPEICDJLHGI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37083D0", Offset = "0x3706DD0", VA = "0x1837083D0")]
	public static void MPMJEFEEPDP<T>(this T[] KLDOGKPLNJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HOPBMJFLPKN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A8DE30", Offset = "0x3A8C830", VA = "0x183A8DE30")]
	public static NativeKeyValueArrays<TKey, TValue> LEDLMPPPMAM<TKey, TValue>(this Dictionary<TKey, TValue> FHONBPKKLIE, Allocator NDKMELBEFLH) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MNAFKOONLNO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D46500", Offset = "0x7D44F00", VA = "0x187D46500")]
	public static void NNJOAIFMLKI(this GameObject HNGFDIJGINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D463C0", Offset = "0x7D44DC0", VA = "0x187D463C0")]
	public static void NNJOAIFMLKI(this Component FDMBFEDKLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D46460", Offset = "0x7D44E60", VA = "0x187D46460")]
	public static void NNJOAIFMLKI(this ScriptableObject JBMEGEJHMJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NJKELNBBHEO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D470D0", Offset = "0x7D45AD0", VA = "0x187D470D0")]
	public static void BBBAJHJCMNI(this NativeList<byte> IBKFNAMHILN, ReadOnlySpan<byte> MOJDBMJFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA640", Offset = "0x3BB9040", VA = "0x183BBA640")]
	public static void HNJBEOGMAEI<T>(this NativeList<T> IBKFNAMHILN, T PCDAHJCDHHF, int IMCIONKBBCL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MPHHDJECIEE
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C980", Offset = "0x3B5B380", VA = "0x183B5C980")]
	public static T IAIGJCEHBEH<T>(this ReadOnlySpan<byte> PCDAHJCDHHF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C2F0", Offset = "0x3B5ACF0", VA = "0x183B5C2F0")]
	public static T ALEJMHHONCE<T>(this Span<T> MOJDBMJFEGC, Func<T, bool> JCLFJDGNIME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D060", Offset = "0x3B5BA60", VA = "0x183B5D060")]
	public static bool LHBKDGJCFAF<T>(this Span<T> MOJDBMJFEGC, Func<T, bool> JCLFJDGNIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D0F0", Offset = "0x3B5BAF0", VA = "0x183B5D0F0")]
	public static bool PELMDLKIEAF<T>(this Span<T> MOJDBMJFEGC, Func<T, bool> JCLFJDGNIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B5CBC0", Offset = "0x3B5B5C0", VA = "0x183B5CBC0")]
	public static T IBPMNADNGOO<T>([In] this ReadOnlySpan<byte> MOJDBMJFEGC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D020", Offset = "0x3B5BA20", VA = "0x183B5D020")]
	public static Span<TTo> IJKJEIANEKC<TTo, TFrom>(this Span<TFrom> MOJDBMJFEGC) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D020", Offset = "0x3B5BA20", VA = "0x183B5D020")]
	public static ReadOnlySpan<TTo> IJKJEIANEKC<TTo, TFrom>(this ReadOnlySpan<TFrom> MOJDBMJFEGC) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D020", Offset = "0x3B5BA20", VA = "0x183B5D020")]
	public static ReadOnlySpan<TTo> IJKJEIANEKC<TTo>(this ReadOnlySpan<byte> MOJDBMJFEGC) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C890", Offset = "0x3B5B290", VA = "0x183B5C890")]
	public static Span<T> FDFMDNPNFDC<T>(this ReadOnlySpan<T> AJHCLHGHINB) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C410", Offset = "0x3B5AE10", VA = "0x183B5C410")]
	public static Span<byte> DGDFODDEBEH<T>([In] this Span<byte> MOJDBMJFEGC, T PCDAHJCDHHF) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D46B20", Offset = "0x7D45520", VA = "0x187D46B20")]
	private static Enum OGHJNIBOEBA([In] ReadOnlySpan<byte> MOJDBMJFEGC, Type HDKNAAMEFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D465A0", Offset = "0x7D44FA0", VA = "0x187D465A0")]
	public static Enum GKFLHAPHKPP([In] this Span<byte> MOJDBMJFEGC, Type HDKNAAMEFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D46610", Offset = "0x7D45010", VA = "0x187D46610")]
	public static void HOMAJDDIPDD([In] this Span<byte> MOJDBMJFEGC, Enum MIMNBICPMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KEAHKCFDIKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DIBIALDFDAO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7D45040", Offset = "0x7D43A40", VA = "0x187D45040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45C00", Offset = "0x7D44600", VA = "0x187D45C00")]
	[AsyncStateMachine(typeof(DIBIALDFDAO))]
	public static void GOOBEKHPIGE(this Task ANAFNAJGANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DFDGOJNFMEL
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x38AF810", Offset = "0x38AE210", VA = "0x1838AF810")]
	public static NativeArray<T> GLBNNNHGMMA<T>(this UnsafeList<T> IBKFNAMHILN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x38AF860", Offset = "0x38AE260", VA = "0x1838AF860")]
	public static NativeArray<T> ODEDAGOOBCC<T>(this UnsafeList<T> IBKFNAMHILN, bool AIJOGNDOIOI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x38AF760", Offset = "0x38AE160", VA = "0x1838AF760")]
	public static UnsafeList<T> FDFMDNPNFDC<T>(this UnsafeList<T> IBKFNAMHILN, Allocator NDKMELBEFLH) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LGKFAENDBCK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum KENIBCICJKG : short
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
	public struct GPFAGKJEHHC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly KENIBCICJKG KJNEHANBOBO;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2F98C40", Offset = "0x2F97640", VA = "0x182F98C40")]
		public GPFAGKJEHHC(KENIBCICJKG KJNEHANBOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory KGIGFDOMMJA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	public static void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D20", Offset = "0x7D44720", VA = "0x187D45D20")]
	static LGKFAENDBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3710DE0", Offset = "0x370F7E0", VA = "0x183710DE0")]
	public static GPFAGKJEHHC BNHALKPGDNO(KENIBCICJKG KJNEHANBOBO)
	{
		return default(GPFAGKJEHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	public static void ELIPAMFBAGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BJLEDILFHIF
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF88F0", Offset = "0x2AF72F0", VA = "0x182AF88F0")]
	public static IGGGIBPEBBN<T1, T2> KPNNHLOOLAP<T1, T2>(this (T1, T2) IHFPCHKMHPK) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(IGGGIBPEBBN<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37F2B90", Offset = "0x37F1590", VA = "0x1837F2B90")]
	public static NGDFFPBBEDJ<T1, T2, T3> KPNNHLOOLAP<T1, T2, T3>(this (T1, T2, T3) IHFPCHKMHPK) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(NGDFFPBBEDJ<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IGGGIBPEBBN<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) IHFPCHKMHPK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF83F0", Offset = "0x2AF6DF0", VA = "0x182AF83F0")]
	public IGGGIBPEBBN((T1, T2) IHFPCHKMHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4E50C90", Offset = "0x4E4F690", VA = "0x184E50C90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NGDFFPBBEDJ<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) IHFPCHKMHPK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E50FD0", Offset = "0x4E4F9D0", VA = "0x184E50FD0")]
	public NGDFFPBBEDJ((T1, T2, T3) IHFPCHKMHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5500F10", Offset = "0x54FF910", VA = "0x185500F10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CKDLFGHOFNH
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D44DF0", Offset = "0x7D437F0", VA = "0x187D44DF0")]
	public static Range PGPLIEDHFCF(this JOGKEMLKOOJ GMBPOMFEMOJ)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EJFOJKKHJGA
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct EGFIBOIKAAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int JHMCKEFMDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int EMHKONLCKLP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7D452E0", Offset = "0x7D43CE0", VA = "0x187D452E0")]
		public EGFIBOIKAAB(int HKECPJKDGLJ, int EMHKONLCKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7D452D0", Offset = "0x7D43CD0", VA = "0x187D452D0")]
		public bool OKGFECGDIIM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D452F0", Offset = "0x7D43CF0", VA = "0x187D452F0")]
	public static EGFIBOIKAAB ICNPOCIJNJG(this Range GMBPOMFEMOJ)
	{
		return default(EGFIBOIKAAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MODCHJFNLOH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle GCKDJGKENJL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NKBELBJELGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x54AA800", Offset = "0x54A9200", VA = "0x1854AA800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x54AA750", Offset = "0x54A9150", VA = "0x1854AA750")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x54AAAC0", Offset = "0x54A94C0", VA = "0x1854AAAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x54AADC0", Offset = "0x54A97C0", VA = "0x1854AADC0")]
	public MODCHJFNLOH(T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x54AA5B0", Offset = "0x54A8FB0", VA = "0x1854AA5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class HFOEGHGDEEB<THandle, TValue> : IDisposable where THandle : struct, MCDNNIEBNOJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> FMPLMPHMMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> OKEIIBNBBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> AHHEJKEFMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> MINACMLGMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int NHGGABHDEJL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4CEF380", Offset = "0x4CEDD80", VA = "0x184CEF380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4CEFD10", Offset = "0x4CEE710", VA = "0x184CEFD10")]
	public HFOEGHGDEEB(Action<TValue> MINACMLGMPM, [Optional] Func<TValue> AHHEJKEFMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF540", Offset = "0x4CEDF40", VA = "0x184CEF540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4CEFB60", Offset = "0x4CEE560", VA = "0x184CEFB60")]
	public THandle PBDMKLNODMP(TValue PCDAHJCDHHF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF5C0", Offset = "0x4CEDFC0", VA = "0x184CEF5C0")]
	public bool EFCPNMLOGFP(THandle GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF6A0", Offset = "0x4CEE0A0", VA = "0x184CEF6A0")]
	public bool EFEDHOLKNME(THandle GCKDJGKENJL, [Out] TValue PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF8B0", Offset = "0x4CEE2B0", VA = "0x184CEF8B0")]
	public TValue IBPMNADNGOO(THandle GCKDJGKENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF7D0", Offset = "0x4CEE1D0", VA = "0x184CEF7D0")]
	public bool IAKPEOGICJH(THandle GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF760", Offset = "0x4CEE160", VA = "0x184CEF760")]
	private THandle GNJLMKGIANH(int MNFHMLCLFEB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF470", Offset = "0x4CEDE70", VA = "0x184CEF470")]
	private TValue BACOOPOJLAH(int MNFHMLCLFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF900", Offset = "0x4CEE300", VA = "0x184CEF900")]
	private void IHPEIEBGJON(int MNFHMLCLFEB, [In] THandle GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF7A0", Offset = "0x4CEE1A0", VA = "0x184CEF7A0")]
	private void HIKLPLIFDEP(int MNFHMLCLFEB, [In] TValue PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4CEFBD0", Offset = "0x4CEE5D0", VA = "0x184CEFBD0")]
	private THandle PKLOCOJEOKM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF3B0", Offset = "0x4CEDDB0", VA = "0x184CEF3B0")]
	private void ANOHKFJJPIL(THandle GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF750", Offset = "0x4CEE150", VA = "0x184CEF750")]
	private int EGHKJJDGKJC(int GPMAOGCPKOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4CEFB50", Offset = "0x4CEE550", VA = "0x184CEFB50")]
	private bool PAGKADHGEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A550", Offset = "0xA08F50", VA = "0x180A0A550")]
	private void LPECIBPEINO(THandle GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF4B0", Offset = "0x4CEDEB0", VA = "0x184CEF4B0")]
	private bool CFMOPKJDIGP([Out] THandle GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF940", Offset = "0x4CEE340", VA = "0x184CEF940")]
	private bool KEBCGEOCDIM([Out] THandle GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4CEFA10", Offset = "0x4CEE410", VA = "0x184CEFA10")]
	private void LNEIGDFBJAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MCDNNIEBNOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int FOIACCDFCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int EHHACNLGFDK
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
public static class MAFOHIGEDHF
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B33350", Offset = "0x3B31D50", VA = "0x183B33350")]
	public static bool HNBFHDLKKAD<T>(this T GCKDJGKENJL, T NDNHELJMDCG) where T : struct, MCDNNIEBNOJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B33340", Offset = "0x3B31D40", VA = "0x183B33340")]
	public static bool HBILGBNKLDB<T>(this T GCKDJGKENJL) where T : struct, MCDNNIEBNOJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7D461C0", Offset = "0x7D44BC0", VA = "0x187D461C0")]
	public static string CLALOCNMNAF(this MCDNNIEBNOJ GCKDJGKENJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct DMLEMIIKCOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type CIKNEDICOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> NHOHDDANGID;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x52687C0", Offset = "0x52671C0", VA = "0x1852687C0")]
	public DMLEMIIKCOM(Type CFKFMHNHHOJ, Span<byte> MOJDBMJFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38D2F70", Offset = "0x38D1970", VA = "0x1838D2F70")]
	public static DMLEMIIKCOM ALHLPHFCPPN<T>(T PCDAHJCDHHF) where T : struct
	{
		return default(DMLEMIIKCOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7D45240", Offset = "0x7D43C40", VA = "0x187D45240")]
	public static LLHNONBDAEA HNONLACFBHP([In] DMLEMIIKCOM FGEFHKAEIPE)
	{
		return default(LLHNONBDAEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7D451C0", Offset = "0x7D43BC0", VA = "0x187D451C0")]
	public Enum GKFLHAPHKPP(Type HDKNAAMEFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38D3870", Offset = "0x38D2270", VA = "0x1838D3870")]
	public void DGDFODDEBEH<T>([In] T PCDAHJCDHHF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7D452C0", Offset = "0x7D43CC0", VA = "0x187D452C0")]
	public void HOMAJDDIPDD(Enum MIMNBICPMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct LLHNONBDAEA
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct KLMHHEIALAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* AJIEINPOCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* FIOKNFOOEIM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type CIKNEDICOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> NHOHDDANGID;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HLDMKAKMLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D45DD0", Offset = "0x7D447D0", VA = "0x187D45DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BANGNLHEDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D80", Offset = "0x7D44780", VA = "0x187D45D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x52687C0", Offset = "0x52671C0", VA = "0x1852687C0")]
	public LLHNONBDAEA(Type CFKFMHNHHOJ, ReadOnlySpan<byte> MOJDBMJFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B22070", Offset = "0x3B20A70", VA = "0x183B22070")]
	public static LLHNONBDAEA ALHLPHFCPPN<T>(T PCDAHJCDHHF) where T : struct
	{
		return default(LLHNONBDAEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7D45FB0", Offset = "0x7D449B0", VA = "0x187D45FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7D45DE0", Offset = "0x7D447E0", VA = "0x187D45DE0")]
	public object NMAGCFPCDMH(int MNFHMLCLFEB = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct DFMHOMEDLFL
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38B1C90", Offset = "0x38B0690", VA = "0x1838B1C90")]
	public static NativeArray<T> ALHLPHFCPPN<T>(T PCDAHJCDHHF, bool AIJOGNDOIOI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38B1D70", Offset = "0x38B0770", VA = "0x1838B1D70")]
	public static NativeArray<T> NLNIDBFLNIO<T>(T PCDAHJCDHHF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38B1CD0", Offset = "0x38B06D0", VA = "0x1838B1CD0")]
	public static NativeArray<T> BGPGFEIHICM<T>(T PCDAHJCDHHF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7D44F80", Offset = "0x7D43980", VA = "0x187D44F80")]
	public static NativeArray<byte> BGPGFEIHICM(ReadOnlySpan<byte> PCDAHJCDHHF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7D44E50", Offset = "0x7D43850", VA = "0x187D44E50")]
	public static NativeArray<byte> ALHLPHFCPPN(ReadOnlySpan<byte> PCDAHJCDHHF, bool AIJOGNDOIOI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7D44F00", Offset = "0x7D43900", VA = "0x187D44F00")]
	public unsafe static NativeArray<byte> ALHLPHFCPPN(byte* EDOMOHMKDKM, int EIJGIDNMHGP, bool AIJOGNDOIOI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x38B1D00", Offset = "0x38B0700", VA = "0x1838B1D00")]
	public static NativeArray<T> BOAAIAHJNJN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct EKDGKMHFIKJ : IEquatable<EKDGKMHFIKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int OBNOAMFOPDD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type GLEDFKBBOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D45460", Offset = "0x7D43E60", VA = "0x187D45460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45550", Offset = "0x7D43F50", VA = "0x187D45550")]
	public EKDGKMHFIKJ(Type HHCAOFMCNLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7D453D0", Offset = "0x7D43DD0", VA = "0x187D453D0")]
	public static EKDGKMHFIKJ HNONLACFBHP(Type HHCAOFMCNLG)
	{
		return default(EKDGKMHFIKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x22D9F40", Offset = "0x22D8940", VA = "0x1822D9F40", Slot = "4")]
	public bool Equals(EKDGKMHFIKJ NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D45340", Offset = "0x7D43D40", VA = "0x187D45340", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D45510", Offset = "0x7D43F10", VA = "0x187D45510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class KBHGKPCPDEN
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> OBLNICLEBOO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> AIPAJOJGILO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D45A80", Offset = "0x7D44480", VA = "0x187D45A80")]
	static KBHGKPCPDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D45A20", Offset = "0x7D44420", VA = "0x187D45A20")]
	public static bool PBDMKLNODMP(Type HHCAOFMCNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D45880", Offset = "0x7D44280", VA = "0x187D45880")]
	private static bool PBDMKLNODMP(Type HHCAOFMCNLG, [Out] int MNFHMLCLFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D45820", Offset = "0x7D44220", VA = "0x187D45820")]
	public static int LIIJGAECNHF(Type HHCAOFMCNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D457A0", Offset = "0x7D441A0", VA = "0x187D457A0")]
	public static Type IBPMNADNGOO(int MNFHMLCLFEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct DGIJOJPIGDD<Handle> where Handle : MCDNNIEBNOJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct NAMLMCFOOMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly DGIJOJPIGDD<Handle> EDCLKKJAJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int MNFHMLCLFEB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle BFMDJMOHPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x54EAA10", Offset = "0x54E9410", VA = "0x1854EAA10")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x54EAD90", Offset = "0x54E9790", VA = "0x1854EAD90")]
		public NAMLMCFOOMM(DGIJOJPIGDD<Handle> EDCLKKJAJPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x54EA760", Offset = "0x54E9160", VA = "0x1854EA760")]
		public EBOHNDCMCIF FMDOFBCLPJB([In] EBOHNDCMCIF FHFGMILAALL)
		{
			return default(EBOHNDCMCIF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x54EAB70", Offset = "0x54E9570", VA = "0x1854EAB70")]
		public bool OKGFECGDIIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x54EA850", Offset = "0x54E9250", VA = "0x1854EA850")]
		private Handle GNJJJIMECLP(string IJOJGNJMCGP)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct EBOHNDCMCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private NAMLMCFOOMM NEJDEHLPAEG;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x46865C0", Offset = "0x4684FC0", VA = "0x1846865C0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4686680", Offset = "0x4685080", VA = "0x184686680")]
		public EBOHNDCMCIF(DGIJOJPIGDD<Handle> EDCLKKJAJPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4686640", Offset = "0x4685040", VA = "0x184686640")]
		public bool OKGFECGDIIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4686510", Offset = "0x4684F10", VA = "0x184686510")]
		public EBOHNDCMCIF ICNPOCIJNJG()
		{
			return default(EBOHNDCMCIF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> ECHJEKMIDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> KCGOMDGCLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int LMKDPDLMHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int EDAFPMCNOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool PNKNPMFEGOG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NJBAMFMNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFA90", Offset = "0x6AEE490", VA = "0x186AEFA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EBOHNDCMCIF PNDGBCCFCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6AEF9C0", Offset = "0x6AEE3C0", VA = "0x186AEF9C0")]
		get
		{
			return default(EBOHNDCMCIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFC50", Offset = "0x6AEE650", VA = "0x186AEFC50")]
	public DGIJOJPIGDD(int MJKAOEIBCPE, Allocator NDKMELBEFLH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF6A0", Offset = "0x6AEE0A0", VA = "0x186AEF6A0")]
	public void IIPIKJHBJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x236CA70", Offset = "0x236B470", VA = "0x18236CA70")]
	public static int EGHKJJDGKJC(int GEHEADBMGDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9BA0", Offset = "0x2FB85A0", VA = "0x182FB9BA0")]
	public static bool NLHHIDOMOJH(int GEHEADBMGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE2B0", Offset = "0x6AECCB0", VA = "0x186AEE2B0")]
	public bool ALIFBDEDGDI(int MNFHMLCLFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE4D0", Offset = "0x6AECED0", VA = "0x186AEE4D0")]
	public bool CJONNLHFDKP(Handle GCKDJGKENJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFAD0", Offset = "0x6AEE4D0", VA = "0x186AEFAD0")]
	public Handle MDOHOEDFIAO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF080", Offset = "0x6AEDA80", VA = "0x186AEF080")]
	public void FOEHNMIGMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF820", Offset = "0x6AEE220", VA = "0x186AEF820")]
	public void JGFECNCBKFJ(Handle GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA6EB70", Offset = "0xA6D570", VA = "0x180A6EB70")]
	private bool IJJMKPBAAMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF960", Offset = "0x6AEE360", VA = "0x186AEF960")]
	private bool KGCBICNOIKE(int MNFHMLCLFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE7A0", Offset = "0x6AED1A0", VA = "0x186AEE7A0")]
	private void DNLCNCOAFDE([Out] int MNFHMLCLFEB, [Out] int GPMAOGCPKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEDF0", Offset = "0x6AED7F0", VA = "0x186AEEDF0")]
	private void FGOLCAEBEDK(Handle GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEA60", Offset = "0x6AED460", VA = "0x186AEEA60")]
	private void DOHAHIHLCDI(int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEBB0", Offset = "0x6AED5B0", VA = "0x186AEEBB0")]
	private bool EHGFPJHFPFP([Out] int MNFHMLCLFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEC60", Offset = "0x6AED660", VA = "0x186AEEC60")]
	private static Handle ENKLFJOBAJJ(int MNFHMLCLFEB, int GPMAOGCPKOA)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct EOFNLJOONEC<Handle, T> where Handle : MCDNNIEBNOJ, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private DGIJOJPIGDD<Handle> KOMBBPPHMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] LGOCKJJFPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> KKICOAKCIDN;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x46BBBE0", Offset = "0x46BA5E0", VA = "0x1846BBBE0")]
	public EOFNLJOONEC(int MJKAOEIBCPE, [Optional] Action<T> KKICOAKCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x46BB2E0", Offset = "0x46B9CE0", VA = "0x1846BB2E0")]
	public void IIPIKJHBJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46BB100", Offset = "0x46B9B00", VA = "0x1846BB100")]
	public bool EFEDHOLKNME(Handle GCKDJGKENJL, [Out] T OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x46BB8D0", Offset = "0x46BA2D0", VA = "0x1846BB8D0")]
	public Handle PBDMKLNODMP(T OJDHMKOBKLD)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x46BB600", Offset = "0x46BA000", VA = "0x1846BB600")]
	public void LJOBPBAGILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x46BAD90", Offset = "0x46B9790", VA = "0x1846BAD90")]
	public void DAAFLACHELB(Handle GCKDJGKENJL, [Out] T MNJIAJFPBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x46BB030", Offset = "0x46B9A30", VA = "0x1846BB030")]
	public void DAAFLACHELB(Handle GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x46BB280", Offset = "0x46B9C80", VA = "0x1846BB280")]
	private T GLDJLNODHCI(int MNFHMLCLFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x46BB820", Offset = "0x46BA220", VA = "0x1846BB820")]
	private void LMAEMFEAKIG(int PLOKIGOEDIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct HDGDEEMNBFK<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct AOLIIJCFDKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private HDGDEEMNBFK<T> KLDOGKPLNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int MNFHMLCLFEB;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4F79FE0", Offset = "0x4F789E0", VA = "0x184F79FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x29160B0", Offset = "0x2914AB0", VA = "0x1829160B0")]
		public AOLIIJCFDKG(HDGDEEMNBFK<T> KLDOGKPLNJA, int MNFHMLCLFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4F7A030", Offset = "0x4F78A30", VA = "0x184F7A030")]
		public bool OKGFECGDIIM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KLFKHIMAICC : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HDGDEEMNBFK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public KLFKHIMAICC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x51D11C0", Offset = "0x51CFBC0", VA = "0x1851D11C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x51D1260", Offset = "0x51CFC60", VA = "0x1851D1260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EFHHLEFGEBK : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public HDGDEEMNBFK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public EFHHLEFGEBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4694B20", Offset = "0x4693520", VA = "0x184694B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4694BC0", Offset = "0x46935C0", VA = "0x184694BC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] HPGIDELCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint PCDAHJCDHHF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2C00", Offset = "0x4CE1600", VA = "0x184CE2C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LFELJFCAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4CE34B0", Offset = "0x4CE1EB0", VA = "0x184CE34B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OGNPMGIBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A94F0", VA = "0x1818AAAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool EDHKBLFOODO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4CE34E0", Offset = "0x4CE1EE0", VA = "0x184CE34E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MDNJMJPCAMN<T> NHOHDDANGID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2C50", Offset = "0x4CE1650", VA = "0x184CE2C50")]
		get
		{
			return default(MDNJMJPCAMN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2B30", Offset = "0x4CE1530", VA = "0x184CE2B30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2A80", Offset = "0x4CE1480", VA = "0x184CE2A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4CE36B0", Offset = "0x4CE20B0", VA = "0x184CE36B0")]
	internal HDGDEEMNBFK(HDGDEEMNBFK<T> KLDOGKPLNJA, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4CE39E0", Offset = "0x4CE23E0", VA = "0x184CE39E0")]
	private HDGDEEMNBFK(T[] KLDOGKPLNJA, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4CE36D0", Offset = "0x4CE20D0", VA = "0x184CE36D0")]
	public HDGDEEMNBFK(IEnumerable<T> OKEIIBNBBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3A00", Offset = "0x4CE2400", VA = "0x184CE3A00")]
	public HDGDEEMNBFK(int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3020", Offset = "0x4CE1A20", VA = "0x184CE3020")]
	public int HHIDBDHOLJB(T PCDAHJCDHHF, int HKECPJKDGLJ, int IMCIONKBBCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4CE2C10", Offset = "0x4CE1610", VA = "0x184CE2C10")]
	public void DIEPIKNHIGJ(int CGKKDCLBCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4CE32E0", Offset = "0x4CE1CE0", VA = "0x184CE32E0")]
	private void NHKPNPKKNDK(int CGKKDCLBCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4CE2FA0", Offset = "0x4CE19A0", VA = "0x184CE2FA0")]
	public T[] HAHLIGCAIEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4CE2E50", Offset = "0x4CE1850", VA = "0x184CE2E50")]
	public T[] GHLGFMMOBOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4CE2DD0", Offset = "0x4CE17D0", VA = "0x184CE2DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4CE31A0", Offset = "0x4CE1BA0", VA = "0x184CE31A0")]
	public void IEBAEJPDMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3130", Offset = "0x4CE1B30", VA = "0x184CE3130")]
	public AOLIIJCFDKG ICNPOCIJNJG()
	{
		return default(AOLIIJCFDKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4CE34F0", Offset = "0x4CE1EF0", VA = "0x184CE34F0", Slot = "5")]
	[IteratorStateMachine(typeof(HDGDEEMNBFK<>.KLFKHIMAICC))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4CE35D0", Offset = "0x4CE1FD0", VA = "0x184CE35D0", Slot = "6")]
	[IteratorStateMachine(typeof(HDGDEEMNBFK<>.EFHHLEFGEBK))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3200", Offset = "0x4CE1C00", VA = "0x184CE3200")]
	public static HDGDEEMNBFK<T> ILAMJJAEKIJ(T[] KLDOGKPLNJA)
	{
		return default(HDGDEEMNBFK<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4CE30A0", Offset = "0x4CE1AA0", VA = "0x184CE30A0")]
	public static HDGDEEMNBFK<T> HNONLACFBHP(T[] KLDOGKPLNJA)
	{
		return default(HDGDEEMNBFK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4CE3260", Offset = "0x4CE1C60", VA = "0x184CE3260")]
	private void NHGINGPMADN(int MNFHMLCLFEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class BBKFGDIALBG<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct JFIBCLOHLIK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private BBKFGDIALBG<T> IBKFNAMHILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int MNFHMLCLFEB;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x508FC40", Offset = "0x508E640", VA = "0x18508FC40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x508FC80", Offset = "0x508E680", VA = "0x18508FC80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4775860", Offset = "0x4774260", VA = "0x184775860")]
		public JFIBCLOHLIK(BBKFGDIALBG<T> IBKFNAMHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x508FB60", Offset = "0x508E560", VA = "0x18508FB60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x508FBF0", Offset = "0x508E5F0", VA = "0x18508FBF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private HDGDEEMNBFK<T> HPGIDELCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int EIJGIDNMHGP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60233B0", Offset = "0x6021DB0", VA = "0x1860233B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4550", Offset = "0x4BA2F50", VA = "0x184BA4550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x47C1950", Offset = "0x47C0350", VA = "0x1847C1950", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NJBAMFMNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6022F00", Offset = "0x6021900", VA = "0x186022F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool OGNPMGIBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6022D10", Offset = "0x6021710", VA = "0x186022D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public MDNJMJPCAMN<T> NHOHDDANGID
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6022800", Offset = "0x6021200", VA = "0x186022800")]
		get
		{
			return default(MDNJMJPCAMN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6023340", Offset = "0x6021D40", VA = "0x186023340")]
	public BBKFGDIALBG(int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4BC4AE0", Offset = "0x4BC34E0", VA = "0x184BC4AE0")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6022910", Offset = "0x6021310", VA = "0x186022910")]
	public HDGDEEMNBFK<T> GPIPCHCEPMG()
	{
		return default(HDGDEEMNBFK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6023170", Offset = "0x6021B70", VA = "0x186023170")]
	public void PBDMKLNODMP(T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60227C0", Offset = "0x60211C0", VA = "0x1860227C0")]
	private void DIEPIKNHIGJ(int OOPBDBFKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6022660", Offset = "0x6021060", VA = "0x186022660")]
	public void BBBAJHJCMNI(List<T> NBOIKFLACJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x60225E0", Offset = "0x6020FE0", VA = "0x1860225E0")]
	public void BBBAJHJCMNI(T[] NBOIKFLACJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6022E80", Offset = "0x6021880", VA = "0x186022E80")]
	public void LHCPPDPHBMJ(int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6022F20", Offset = "0x6021920", VA = "0x186022F20")]
	public void OHHLDEPHCPK(int INFODCOKAGO, int EMHKONLCKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x60229C0", Offset = "0x60213C0", VA = "0x1860229C0")]
	public int HHIDBDHOLJB(T PCDAHJCDHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6023260", Offset = "0x6021C60", VA = "0x186023260")]
	public bool PFLPBNAMPLH(T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60228A0", Offset = "0x60212A0", VA = "0x1860228A0")]
	public T[] GHLGFMMOBOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6022880", Offset = "0x6021280", VA = "0x186022880", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6022A30", Offset = "0x6021430", VA = "0x186022A30")]
	public static HDGDEEMNBFK<T> HNONLACFBHP(BBKFGDIALBG<T> IBKFNAMHILN)
	{
		return default(HDGDEEMNBFK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6022950", Offset = "0x6021350", VA = "0x186022950", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60232A0", Offset = "0x6021CA0", VA = "0x1860232A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60232D0", Offset = "0x6021CD0", VA = "0x1860232D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6022D30", Offset = "0x6021730", VA = "0x186022D30")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void JCPKNGOLDAJ(int PCDAHJCDHHF, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6022AE0", Offset = "0x60214E0", VA = "0x186022AE0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ICDKGNJHHOM(int INFODCOKAGO, int EMHKONLCKLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EDIIMHMLNEB
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x38F6140", Offset = "0x38F4B40", VA = "0x1838F6140")]
	public static void IEBAEJPDMKE<T>(this BBKFGDIALBG<T> IBKFNAMHILN) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public ref struct MDNJMJPCAMN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> HPGIDELCODH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5478DA0", Offset = "0x54777A0", VA = "0x185478DA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5478D70", Offset = "0x5477770", VA = "0x185478D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5478E20", Offset = "0x5477820", VA = "0x185478E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public MDNJMJPCAMN(Span<object> MOJDBMJFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5478F00", Offset = "0x5477900", VA = "0x185478F00")]
	public MDNJMJPCAMN<T> MBPFCDHELKG(int HKECPJKDGLJ)
	{
		return default(MDNJMJPCAMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5478FD0", Offset = "0x54779D0", VA = "0x185478FD0")]
	public MDNJMJPCAMN<T> MBPFCDHELKG(int HKECPJKDGLJ, int EIJGIDNMHGP)
	{
		return default(MDNJMJPCAMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5478D10", Offset = "0x5477710", VA = "0x185478D10")]
	public void AHEPFHGKECD(MDNJMJPCAMN<T> DPHLAAIBGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x54790B0", Offset = "0x5477AB0", VA = "0x1854790B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5478E60", Offset = "0x5477860", VA = "0x185478E60", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5478EB0", Offset = "0x54778B0", VA = "0x185478EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JOGKEMLKOOJ : IEquatable<JOGKEMLKOOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int BACDJHJBLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int IMCIONKBBCL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int LEHDAHFOAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2F60", Offset = "0x2FA1960", VA = "0x182FA2F60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F80", Offset = "0x6F26980", VA = "0x186F27F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int BICOIKPBINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int EKDNODFNLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7D456E0", Offset = "0x7D440E0", VA = "0x187D456E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7D45700", Offset = "0x7D44100", VA = "0x187D45700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) HMBAOIOCBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7D455F0", Offset = "0x7D43FF0", VA = "0x187D455F0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
	private JOGKEMLKOOJ(int BACDJHJBLPL, int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2905620", Offset = "0x2904020", VA = "0x182905620")]
	public static JOGKEMLKOOJ PIBFAOALICA(int BACDJHJBLPL, int IMCIONKBBCL)
	{
		return default(JOGKEMLKOOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7D456F0", Offset = "0x7D440F0", VA = "0x187D456F0")]
	public static JOGKEMLKOOJ GMPBNIOEEOJ(int HKECPJKDGLJ, int EMHKONLCKLP)
	{
		return default(JOGKEMLKOOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45710", Offset = "0x7D44110", VA = "0x187D45710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x129E210", Offset = "0x129CC10", VA = "0x18129E210", Slot = "4")]
	public bool Equals(JOGKEMLKOOJ NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7D45650", Offset = "0x7D44050", VA = "0x187D45650", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x708B400", Offset = "0x7089E00", VA = "0x18708B400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct PJHDFJNBLFH<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> HPGIDELCODH;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1361F70", Offset = "0x1360970", VA = "0x181361F70")]
	public PJHDFJNBLFH(NativeArray<T> HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x577F1C0", Offset = "0x577DBC0", VA = "0x18577F1C0", Slot = "6")]
	public int Compare(int CBPCNABIALH, int CBOHEKOGGHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x577F2B0", Offset = "0x577DCB0", VA = "0x18577F2B0", Slot = "4")]
	public bool Equals(int CBPCNABIALH, int CBOHEKOGGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x577F3A0", Offset = "0x577DDA0", VA = "0x18577F3A0", Slot = "5")]
	public int GetHashCode(int CBPCNABIALH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LGDHMBNKGKI
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F980", Offset = "0x3B1E380", VA = "0x183B1F980")]
	public static T[] IHHNLCAICOL<T>(List<T> IBKFNAMHILN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KCKGENGDDJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* BPIJIKNLJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle NGBAGFMAHMM;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5BBD4C0", Offset = "0x5BBBEC0", VA = "0x185BBD4C0")]
	public void IIPIKJHBJDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class MJBFDLJLKPC
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3B502E0", Offset = "0x3B4ECE0", VA = "0x183B502E0")]
	public static KCKGENGDDJB HLACPJKAJBH<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> ICFOMKCGHDA) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(KCKGENGDDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3B502E0", Offset = "0x3B4ECE0", VA = "0x183B502E0")]
	public static UnsafeParallelHashMap<TKey, TValue> GNBGKHBAFLH<TKey, TValue>(this KCKGENGDDJB ICFOMKCGHDA) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class EKLJOAJOPHG
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x38FBBE0", Offset = "0x38FA5E0", VA = "0x1838FBBE0")]
	public static int ECAANICBPPO<T>(ReadOnlySpan<T> FHABEEJIGEO, ReadOnlySpan<T> IPLDENMKCEP, int EIJGIDNMHGP) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class IBCHLBOGIFB
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D730", Offset = "0x3A9C130", VA = "0x183A9D730")]
	public static T NHDANIJBDLK<T>(this NativeArray<byte> AJHCLHGHINB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D340", Offset = "0x3A9BD40", VA = "0x183A9D340")]
	public static NativeArray<T> FMAAEEIFGOD<T>(this NativeArray<byte> AJHCLHGHINB, int IMCIONKBBCL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D190", Offset = "0x3A9BB90", VA = "0x183A9D190")]
	public static void EDMCADMCJAO<T>(this NativeList<byte> GMGNNFDOICN, [In] T PCDAHJCDHHF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D100", Offset = "0x3A9BB00", VA = "0x183A9D100")]
	public static void EDMCADMCJAO<T>(this NativeList<byte> GMGNNFDOICN, NativeArray<T> PCDAHJCDHHF) where T : struct
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

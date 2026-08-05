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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DC54A0", Offset = "0x7DC40A0", VA = "0x187DC54A0", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DGHDJLHOIDF]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C47760", Offset = "0x3C46360", VA = "0x183C47760")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DGHDJLHOIDF]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C48710", Offset = "0x3C47310", VA = "0x183C48710")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C47960", Offset = "0x3C46560", VA = "0x183C47960")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3C47AC0", Offset = "0x3C466C0", VA = "0x183C47AC0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BC40", Offset = "0x3C4A840", VA = "0x183C4BC40")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B9D0", Offset = "0x3C4A5D0", VA = "0x183C4B9D0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BB40", Offset = "0x3C4A740", VA = "0x183C4BB40")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C290", Offset = "0x3C4AE90", VA = "0x183C4C290")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3C48E60", Offset = "0x3C47A60", VA = "0x183C48E60")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3C48DF0", Offset = "0x3C479F0", VA = "0x183C48DF0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C49310", Offset = "0x3C47F10", VA = "0x183C49310")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, HJOGNENAABH range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C49350", Offset = "0x3C47F50", VA = "0x183C49350")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C49190", Offset = "0x3C47D90", VA = "0x183C49190")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C477B0", Offset = "0x3C463B0", VA = "0x183C477B0")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BA80", Offset = "0x3C4A680", VA = "0x183C4BA80")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DGHDJLHOIDF]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C51530", Offset = "0x3C50130", VA = "0x183C51530")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C53210", Offset = "0x3C51E10", VA = "0x183C53210")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3C53220", Offset = "0x3C51E20", VA = "0x183C53220")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1280", Offset = "0x4CDFE80", VA = "0x184CE1280")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5C20", Offset = "0x7DC4820", VA = "0x187DC5C20")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5C50", Offset = "0x7DC4850", VA = "0x187DC5C50")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C52840", Offset = "0x3C51440", VA = "0x183C52840")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C52600", Offset = "0x3C51200", VA = "0x183C52600")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C52940", Offset = "0x3C51540", VA = "0x183C52940")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C52770", Offset = "0x3C51370", VA = "0x183C52770")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C528F0", Offset = "0x3C514F0", VA = "0x183C528F0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C526D0", Offset = "0x3C512D0", VA = "0x183C526D0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C52BF0", Offset = "0x3C517F0", VA = "0x183C52BF0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C52A50", Offset = "0x3C51650", VA = "0x183C52A50")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C52650", Offset = "0x3C51250", VA = "0x183C52650")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C525A0", Offset = "0x3C511A0", VA = "0x183C525A0")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C52580", Offset = "0x3C51180", VA = "0x183C52580")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C53640", Offset = "0x3C52240", VA = "0x183C53640")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C53270", Offset = "0x3C51E70", VA = "0x183C53270")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3C53670", Offset = "0x3C52270", VA = "0x183C53670")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3C53720", Offset = "0x3C52320", VA = "0x183C53720")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DGHDJLHOIDF]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7F280", Offset = "0x4D7DE80", VA = "0x184D7F280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE4EF80", Offset = "0xE4DB80", VA = "0x180E4EF80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5273FD0", Offset = "0x5272BD0", VA = "0x185273FD0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5558120", Offset = "0x5556D20", VA = "0x185558120", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5557F20", Offset = "0x5556B20", VA = "0x185557F20")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x421E950", Offset = "0x421D550", VA = "0x18421E950")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DGHDJLHOIDF]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7F280", Offset = "0x4D7DE80", VA = "0x184D7F280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x55B9820", Offset = "0x55B8420", VA = "0x1855B9820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5273FD0", Offset = "0x5272BD0", VA = "0x185273FD0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x55B93C0", Offset = "0x55B7FC0", VA = "0x1855B93C0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x55B9560", Offset = "0x55B8160", VA = "0x1855B9560")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x55B9740", Offset = "0x55B8340", VA = "0x1855B9740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x55B95A0", Offset = "0x55B81A0", VA = "0x1855B95A0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DGHDJLHOIDF]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DGHDJLHOIDF]
public static class IAFNKCADAPG
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7DC52A0", Offset = "0x7DC3EA0", VA = "0x187DC52A0")]
	public static JobHandle KPICNFKPAAN(this JobHandle ABBBJFPFEKP, JobHandle KLKIJPOLHDE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC52E0", Offset = "0x7DC3EE0", VA = "0x187DC52E0")]
	public static JobHandle MFKMCGLCJBH(this Span<JobHandle> EJOMAHOPPJE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CKPGOLJLGJF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3733540", Offset = "0x3732140", VA = "0x183733540")]
	public static void ILJKHADAMOK<T>(this T[] IKALPCJBCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class POPNPMKIBCC
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C89080", Offset = "0x3C87C80", VA = "0x183C89080")]
	public static NativeKeyValueArrays<TKey, TValue> HFFNKMGEBFD<TKey, TValue>(this Dictionary<TKey, TValue> NJHNNBNFCIE, Allocator CMJGNOOCEGA) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AHLCFEDELBE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4400", Offset = "0x7DC3000", VA = "0x187DC4400")]
	public static void BNHAHAOLPJN(this GameObject AOALCMHDOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC44A0", Offset = "0x7DC30A0", VA = "0x187DC44A0")]
	public static void BNHAHAOLPJN(this Component LBEOEMMCAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4540", Offset = "0x7DC3140", VA = "0x187DC4540")]
	public static void BNHAHAOLPJN(this ScriptableObject NGPEJGPOEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DIIDLONIBCL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4650", Offset = "0x7DC3250", VA = "0x187DC4650")]
	public static void PAFOMKPENGA(this NativeList<byte> DNNGKIFFAHG, ReadOnlySpan<byte> NPFPPIBACNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x38E6F80", Offset = "0x38E5B80", VA = "0x1838E6F80")]
	public static void POJNNFFDMCL<T>(this NativeList<T> DNNGKIFFAHG, T OOHGFGHCOAJ, int DPOOEAFKIHD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AEBAKNMFHEN
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x303E380", Offset = "0x303CF80", VA = "0x18303E380")]
	public static T LKEDHALJIBO<T>(this ReadOnlySpan<byte> OOHGFGHCOAJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x303DD10", Offset = "0x303C910", VA = "0x18303DD10")]
	public static T JJGKJFBBOFE<T>(this Span<T> NPFPPIBACNM, Func<T, bool> MBALKMGMOLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x303E5C0", Offset = "0x303D1C0", VA = "0x18303E5C0")]
	public static bool NLLJMKHKBND<T>(this Span<T> NPFPPIBACNM, Func<T, bool> MBALKMGMOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x303DC80", Offset = "0x303C880", VA = "0x18303DC80")]
	public static bool GCKGIEJDHIK<T>(this Span<T> NPFPPIBACNM, Func<T, bool> MBALKMGMOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x303DF20", Offset = "0x303CB20", VA = "0x18303DF20")]
	public static T LBDBFELEJGA<T>([In] this ReadOnlySpan<byte> NPFPPIBACNM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x303DC40", Offset = "0x303C840", VA = "0x18303DC40")]
	public static Span<TTo> EPBLAFOBGOM<TTo, TFrom>(this Span<TFrom> NPFPPIBACNM) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x303DC40", Offset = "0x303C840", VA = "0x18303DC40")]
	public static ReadOnlySpan<TTo> EPBLAFOBGOM<TTo, TFrom>(this ReadOnlySpan<TFrom> NPFPPIBACNM) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x303DC40", Offset = "0x303C840", VA = "0x18303DC40")]
	public static ReadOnlySpan<TTo> EPBLAFOBGOM<TTo>(this ReadOnlySpan<byte> NPFPPIBACNM) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x303DE30", Offset = "0x303CA30", VA = "0x18303DE30")]
	public static Span<T> KIKIFBKOCFE<T>(this ReadOnlySpan<T> ENEAIMANIIG) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x303E650", Offset = "0x303D250", VA = "0x18303E650")]
	public static Span<byte> PEPEIECOOBP<T>([In] this Span<byte> NPFPPIBACNM, T OOHGFGHCOAJ) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC3980", Offset = "0x7DC2580", VA = "0x187DC3980")]
	private static Enum IHBOCPMBFGF([In] ReadOnlySpan<byte> NPFPPIBACNM, Type MJLAGNNHJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC3910", Offset = "0x7DC2510", VA = "0x187DC3910")]
	public static Enum GKLBJNJGBBO([In] this Span<byte> NPFPPIBACNM, Type MJLAGNNHJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC3F20", Offset = "0x7DC2B20", VA = "0x187DC3F20")]
	public static void KOOBOABNMDI([In] this Span<byte> NPFPPIBACNM, Enum NBOMHMDCNPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ENPKHEOMJLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MEBPOMCAELG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DC5530", Offset = "0x7DC4130", VA = "0x187DC5530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC46D0", Offset = "0x7DC32D0", VA = "0x187DC46D0")]
	[AsyncStateMachine(typeof(MEBPOMCAELG))]
	public static void BLPINCFJCEN(this Task LPCHKKFEGJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FEDOOPCDJEL
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D340", Offset = "0x3A5BF40", VA = "0x183A5D340")]
	public static NativeArray<T> JFBGLOOCCFE<T>(this UnsafeList<T> DNNGKIFFAHG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D440", Offset = "0x3A5C040", VA = "0x183A5D440")]
	public static NativeArray<T> OCJAGIMDCOI<T>(this UnsafeList<T> DNNGKIFFAHG, bool NICELLELNGE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A5D390", Offset = "0x3A5BF90", VA = "0x183A5D390")]
	public static UnsafeList<T> KIKIFBKOCFE<T>(this UnsafeList<T> DNNGKIFFAHG, Allocator CMJGNOOCEGA) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FBFCGPBOJMG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum CHLKNMBJOCH : short
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
	public struct MOPBIBHPDHG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly CHLKNMBJOCH MEPFFFGIFGB;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2FD6BD0", Offset = "0x2FD57D0", VA = "0x182FD6BD0")]
		public MOPBIBHPDHG(CHLKNMBJOCH MEPFFFGIFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory KPHLJGGNDKB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	public static void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4A90", Offset = "0x7DC3690", VA = "0x187DC4A90")]
	static FBFCGPBOJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3753D00", Offset = "0x3752900", VA = "0x183753D00")]
	public static MOPBIBHPDHG NDJMMNJLKBI(CHLKNMBJOCH MEPFFFGIFGB)
	{
		return default(MOPBIBHPDHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	public static void DMKNJCMDPPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DAEIIAEFONM
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B344A0", Offset = "0x2B330A0", VA = "0x182B344A0")]
	public static PGFACAOGFCF<T1, T2> HOMCKMGOHHA<T1, T2>(this (T1, T2) MEKACEALIFH) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(PGFACAOGFCF<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x38E06A0", Offset = "0x38DF2A0", VA = "0x1838E06A0")]
	public static OCLGOKGLMIA<T1, T2, T3> HOMCKMGOHHA<T1, T2, T3>(this (T1, T2, T3) MEKACEALIFH) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(OCLGOKGLMIA<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PGFACAOGFCF<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) MEKACEALIFH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B340E0", Offset = "0x2B32CE0", VA = "0x182B340E0")]
	public PGFACAOGFCF((T1, T2) MEKACEALIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x57CF3A0", Offset = "0x57CDFA0", VA = "0x1857CF3A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OCLGOKGLMIA<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) MEKACEALIFH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5658630", Offset = "0x5657230", VA = "0x185658630")]
	public OCLGOKGLMIA((T1, T2, T3) MEKACEALIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5658590", Offset = "0x5657190", VA = "0x185658590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GGNBGACIGIA
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4CE0", Offset = "0x7DC38E0", VA = "0x187DC4CE0")]
	public static Range AJGPPJPJJIB(this HJOGNENAABH BNCKDCNKIDE)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CPGIGNPGFAC
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct APNNCGCDFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int BEPIDBDGKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int NHCGLFAFCAA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7DC45F0", Offset = "0x7DC31F0", VA = "0x187DC45F0")]
		public APNNCGCDFLF(int EILAIOEPAPK, int NHCGLFAFCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7DC45E0", Offset = "0x7DC31E0", VA = "0x187DC45E0")]
		public bool MNOHJEBJBPH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4600", Offset = "0x7DC3200", VA = "0x187DC4600")]
	public static APNNCGCDFLF MEEEBEDBKAB(this Range BNCKDCNKIDE)
	{
		return default(APNNCGCDFLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct ACKDHLJBDPN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle BEPAMKMBKNC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JKBGPHOHGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1910", Offset = "0x4CE0510", VA = "0x184CE1910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1700", Offset = "0x4CE0300", VA = "0x184CE1700")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4CE12B0", Offset = "0x4CDFEB0", VA = "0x184CE12B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4CE1920", Offset = "0x4CE0520", VA = "0x184CE1920")]
	public ACKDHLJBDPN(T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4CE1280", Offset = "0x4CDFE80", VA = "0x184CE1280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class DGNDEINJLGE<THandle, TValue> : IDisposable where THandle : struct, PNKHKLJALOP where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> EJOMAHOPPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> AIPJHMCGMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> HOFGPOPMCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> LKOKJFNIHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int MNHMDDKHNHM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x429F230", Offset = "0x429DE30", VA = "0x18429F230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x429F5A0", Offset = "0x429E1A0", VA = "0x18429F5A0")]
	public DGNDEINJLGE(Action<TValue> LKOKJFNIHKB, [Optional] Func<TValue> HOFGPOPMCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x429EF60", Offset = "0x429DB60", VA = "0x18429EF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x429F480", Offset = "0x429E080", VA = "0x18429F480")]
	public THandle NKAMMCABBBC(TValue OOHGFGHCOAJ)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x429ECE0", Offset = "0x429D8E0", VA = "0x18429ECE0")]
	public bool AMAAGOMLOEN(THandle BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x429F4F0", Offset = "0x429E0F0", VA = "0x18429F4F0")]
	public bool OMPOHNEBOIH(THandle BEPAMKMBKNC, [Out] TValue OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x429F3F0", Offset = "0x429DFF0", VA = "0x18429F3F0")]
	public TValue LBDBFELEJGA(THandle BEPAMKMBKNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x429EE80", Offset = "0x429DA80", VA = "0x18429EE80")]
	public bool DOBEMPPDGDH(THandle BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x429F270", Offset = "0x429DE70", VA = "0x18429F270")]
	private THandle IIMPMBEMJAP(int EMMACFPOKFB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x429F130", Offset = "0x429DD30", VA = "0x18429F130")]
	private TValue EMBLLFFHGFA(int EMMACFPOKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x429F440", Offset = "0x429E040", VA = "0x18429F440")]
	private void LMCLPJHJIDN(int EMMACFPOKFB, [In] THandle BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x429EDC0", Offset = "0x429D9C0", VA = "0x18429EDC0")]
	private void BJEJKLJFPOA(int EMMACFPOKFB, [In] TValue OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x429F2B0", Offset = "0x429DEB0", VA = "0x18429F2B0")]
	private THandle IJAPNGPNIMJ()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x429F170", Offset = "0x429DD70", VA = "0x18429F170")]
	private void FMPLMCAHFNM(THandle BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x429F260", Offset = "0x429DE60", VA = "0x18429F260")]
	private int IHKDLPICMDH(int JBMEHOAGBAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x429F120", Offset = "0x429DD20", VA = "0x18429F120")]
	private bool EDHLEPNMKDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA27D50", Offset = "0xA26950", VA = "0x180A27D50")]
	private void GGCFPDKPEGF(THandle BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x429EDF0", Offset = "0x429D9F0", VA = "0x18429EDF0")]
	private bool DLNPOPKEIMJ([Out] THandle BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x429EC10", Offset = "0x429D810", VA = "0x18429EC10")]
	private bool ACJAFGIODPM([Out] THandle BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x429EFE0", Offset = "0x429DBE0", VA = "0x18429EFE0")]
	private void EDDKNPOMHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PNKHKLJALOP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int FCJKCAOMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int DLHOIMFANJP
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
public static class KIIMBJBGEFL
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B688F0", Offset = "0x3B674F0", VA = "0x183B688F0")]
	public static bool MGLMDKACMNC<T>(this T BEPAMKMBKNC, T GMNGNCHKEBK) where T : struct, PNKHKLJALOP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B688E0", Offset = "0x3B674E0", VA = "0x183B688E0")]
	public static bool JICHDGIBAGD<T>(this T BEPAMKMBKNC) where T : struct, PNKHKLJALOP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5390", Offset = "0x7DC3F90", VA = "0x187DC5390")]
	public static string DALHFDBCJKI(this PNKHKLJALOP BEPAMKMBKNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct NPPLDKJABIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type MNGJMEIAMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> JCOMHHICLPP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x52744A0", Offset = "0x52730A0", VA = "0x1852744A0")]
	public NPPLDKJABIP(Type OEMNNNIDKKN, Span<byte> NPFPPIBACNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C46A70", Offset = "0x3C45670", VA = "0x183C46A70")]
	public static NPPLDKJABIP AFAOJPNNAAP<T>(T OOHGFGHCOAJ) where T : struct
	{
		return default(NPPLDKJABIP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5B10", Offset = "0x7DC4710", VA = "0x187DC5B10")]
	public static HHJKFBANGIO GHOKLFELACP([In] NPPLDKJABIP DGCKGHIBLHO)
	{
		return default(HHJKFBANGIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5B90", Offset = "0x7DC4790", VA = "0x187DC5B90")]
	public Enum GKLBJNJGBBO(Type MJLAGNNHJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3C47370", Offset = "0x3C45F70", VA = "0x183C47370")]
	public void PEPEIECOOBP<T>([In] T OOHGFGHCOAJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5C10", Offset = "0x7DC4810", VA = "0x187DC5C10")]
	public void KOOBOABNMDI(Enum NBOMHMDCNPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct HHJKFBANGIO
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct DLJEIGOAJFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* BLPOCDFNOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* PKEEOKNPGCB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type MNGJMEIAMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> JCOMHHICLPP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LGGPAPKKGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4F10", Offset = "0x7DC3B10", VA = "0x187DC4F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DBKAACEBOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4F20", Offset = "0x7DC3B20", VA = "0x187DC4F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x52744A0", Offset = "0x52730A0", VA = "0x1852744A0")]
	public HHJKFBANGIO(Type OEMNNNIDKKN, ReadOnlySpan<byte> NPFPPIBACNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3440", Offset = "0x3AB2040", VA = "0x183AB3440")]
	public static HHJKFBANGIO AFAOJPNNAAP<T>(T OOHGFGHCOAJ) where T : struct
	{
		return default(HHJKFBANGIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4F70", Offset = "0x7DC3B70", VA = "0x187DC4F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4D40", Offset = "0x7DC3940", VA = "0x187DC4D40")]
	public object CALNAGEIGAD(int EMMACFPOKFB = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct GDPHFGLAPFH
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A85720", Offset = "0x3A84320", VA = "0x183A85720")]
	public static NativeArray<T> AFAOJPNNAAP<T>(T OOHGFGHCOAJ, bool NICELLELNGE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A85800", Offset = "0x3A84400", VA = "0x183A85800")]
	public static NativeArray<T> OHMFLEPBPEF<T>(T OOHGFGHCOAJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3A85760", Offset = "0x3A84360", VA = "0x183A85760")]
	public static NativeArray<T> FHBFAKHDKBB<T>(T OOHGFGHCOAJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4C20", Offset = "0x7DC3820", VA = "0x187DC4C20")]
	public static NativeArray<byte> FHBFAKHDKBB(ReadOnlySpan<byte> OOHGFGHCOAJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4B70", Offset = "0x7DC3770", VA = "0x187DC4B70")]
	public static NativeArray<byte> AFAOJPNNAAP(ReadOnlySpan<byte> OOHGFGHCOAJ, bool NICELLELNGE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4AF0", Offset = "0x7DC36F0", VA = "0x187DC4AF0")]
	public unsafe static NativeArray<byte> AFAOJPNNAAP(byte* LOACIBFEBOJ, int FMOIHNPEKPL, bool NICELLELNGE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3A85790", Offset = "0x3A84390", VA = "0x183A85790")]
	public static NativeArray<T> LELJIFADAHI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct EOGLKCOKBDJ : IEquatable<EOGLKCOKBDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int PCPIAGCOKAF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type JKOHHHGJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4900", Offset = "0x7DC3500", VA = "0x187DC4900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC49F0", Offset = "0x7DC35F0", VA = "0x187DC49F0")]
	public EOGLKCOKBDJ(Type OPOPAMPKKGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4870", Offset = "0x7DC3470", VA = "0x187DC4870")]
	public static EOGLKCOKBDJ GHOKLFELACP(Type OPOPAMPKKGD)
	{
		return default(EOGLKCOKBDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x230B2D0", Offset = "0x2309ED0", VA = "0x18230B2D0", Slot = "4")]
	public bool Equals(EOGLKCOKBDJ GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7DC47F0", Offset = "0x7DC33F0", VA = "0x187DC47F0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DC49B0", Offset = "0x7DC35B0", VA = "0x187DC49B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class MFEADIBNLIP
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> IELGNNFDLKP;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> EGKNELDMPKC;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5990", Offset = "0x7DC4590", VA = "0x187DC5990")]
	static MFEADIBNLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5930", Offset = "0x7DC4530", VA = "0x187DC5930")]
	public static bool NKAMMCABBBC(Type OPOPAMPKKGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5790", Offset = "0x7DC4390", VA = "0x187DC5790")]
	private static bool NKAMMCABBBC(Type OPOPAMPKKGD, [Out] int EMMACFPOKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DC56B0", Offset = "0x7DC42B0", VA = "0x187DC56B0")]
	public static int HEBIJECOELL(Type OPOPAMPKKGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5710", Offset = "0x7DC4310", VA = "0x187DC5710")]
	public static Type LBDBFELEJGA(int EMMACFPOKFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JJAMIHBDNGP<Handle> where Handle : PNKHKLJALOP, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct IDGJGIDGJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly JJAMIHBDNGP<Handle> CDMBMKNDFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int EMMACFPOKFB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle DNGEOEOFAJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x4E64F10", Offset = "0x4E63B10", VA = "0x184E64F10")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4E65540", Offset = "0x4E64140", VA = "0x184E65540")]
		public IDGJGIDGJDA(JJAMIHBDNGP<Handle> CDMBMKNDFHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E651D0", Offset = "0x4E63DD0", VA = "0x184E651D0")]
		public FOOHKJEMABL JHMOIFLKJAD([In] FOOHKJEMABL NGGJJFKLDLG)
		{
			return default(FOOHKJEMABL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4E65320", Offset = "0x4E63F20", VA = "0x184E65320")]
		public bool MNOHJEBJBPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E65260", Offset = "0x4E63E60", VA = "0x184E65260")]
		private Handle KOALEOLAPEM(string FNFIPKNHEOF)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct FOOHKJEMABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private IDGJGIDGJDA BMIOIMBJHLK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4C5A990", Offset = "0x4C59590", VA = "0x184C5A990")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4C5AB00", Offset = "0x4C59700", VA = "0x184C5AB00")]
		public FOOHKJEMABL(JJAMIHBDNGP<Handle> CDMBMKNDFHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4C5AA80", Offset = "0x4C59680", VA = "0x184C5AA80")]
		public bool MNOHJEBJBPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4C5AA10", Offset = "0x4C59610", VA = "0x184C5AA10")]
		public FOOHKJEMABL MEEEBEDBKAB()
		{
			return default(FOOHKJEMABL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> KMLKBPMJKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> DPGMIOFBGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int KPFLCKLPGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int EFDOJMLPKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool OKBGFJNNDMB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HFMPIJBIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x50FC680", Offset = "0x50FB280", VA = "0x1850FC680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FOOHKJEMABL NHJOBFPAIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x50FC470", Offset = "0x50FB070", VA = "0x1850FC470")]
		get
		{
			return default(FOOHKJEMABL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50FCB60", Offset = "0x50FB760", VA = "0x1850FCB60")]
	public JJAMIHBDNGP(int NAFCJAHNOKE, Allocator CMJGNOOCEGA = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x50FC3B0", Offset = "0x50FAFB0", VA = "0x1850FC3B0")]
	public void LDCCMKMJIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x23AC4F0", Offset = "0x23AB0F0", VA = "0x1823AC4F0")]
	public static int IHKDLPICMDH(int GCKEIIMJEBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2FEFA50", Offset = "0x2FEE650", VA = "0x182FEFA50")]
	public static bool GNNEJLIJICK(int GCKEIIMJEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x50FC0D0", Offset = "0x50FACD0", VA = "0x1850FC0D0")]
	public bool KAOBOFEAMIF(int EMMACFPOKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x50FC7C0", Offset = "0x50FB3C0", VA = "0x1850FC7C0")]
	public bool PBCPLCIMNBG(Handle BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x50FB1B0", Offset = "0x50F9DB0", VA = "0x1850FB1B0")]
	public Handle AJBLIEAIOEC()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x50FB270", Offset = "0x50F9E70", VA = "0x1850FB270")]
	public void AOGHFKPLOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x50FC570", Offset = "0x50FB170", VA = "0x1850FC570")]
	public void LFNJBPDOOHE(Handle BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xBDFF70", Offset = "0xBDEB70", VA = "0x180BDFF70")]
	private bool FHGKLOKNHOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x50FC760", Offset = "0x50FB360", VA = "0x1850FC760")]
	private bool OMGPHBLFCPF(int EMMACFPOKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x50FBE10", Offset = "0x50FAA10", VA = "0x1850FBE10")]
	private void HBPGKACFOHI([Out] int EMMACFPOKFB, [Out] int JBMEHOAGBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x50FBA20", Offset = "0x50FA620", VA = "0x1850FBA20")]
	private void FPHDDHOIDGI(Handle BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x50FC5E0", Offset = "0x50FB1E0", VA = "0x1850FC5E0")]
	private void LHOBICHDIGD(int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x50FBCB0", Offset = "0x50FA8B0", VA = "0x1850FBCB0")]
	private bool GHFOCGLMLAI([Out] int EMMACFPOKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x50FB940", Offset = "0x50FA540", VA = "0x1850FB940")]
	private static Handle BMHAGILLBFA(int EMMACFPOKFB, int JBMEHOAGBAN)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct ELOOCDDJBDF<Handle, T> where Handle : PNKHKLJALOP, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private JJAMIHBDNGP<Handle> ADCONLHODBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] IDCBOACJIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> MGMBDDFMAOO;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x473A3B0", Offset = "0x4738FB0", VA = "0x18473A3B0")]
	public ELOOCDDJBDF(int NAFCJAHNOKE, [Optional] Action<T> MGMBDDFMAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4739E40", Offset = "0x4738A40", VA = "0x184739E40")]
	public void LDCCMKMJIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x473A1F0", Offset = "0x4738DF0", VA = "0x18473A1F0")]
	public bool OMPOHNEBOIH(Handle BEPAMKMBKNC, [Out] T KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4739EC0", Offset = "0x4738AC0", VA = "0x184739EC0")]
	public Handle NKAMMCABBBC(T KDKJDFFGNJJ)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4739BA0", Offset = "0x47387A0", VA = "0x184739BA0")]
	public void IBFJPHINKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47396E0", Offset = "0x47382E0", VA = "0x1847396E0")]
	public void HMCNGGMNMHK(Handle BEPAMKMBKNC, [Out] T PIKEJBHKNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x47397D0", Offset = "0x47383D0", VA = "0x1847397D0")]
	public void HMCNGGMNMHK(Handle BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x473A0E0", Offset = "0x4738CE0", VA = "0x18473A0E0")]
	private T OKBAODAHDOH(int EMMACFPOKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4739560", Offset = "0x4738160", VA = "0x184739560")]
	private void HJOIIMPODJP(int DBCHDNMDNCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct HBFEOHNMHAE<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct ALPBCKJANAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private HBFEOHNMHAE<T> IKALPCJBCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int EMMACFPOKFB;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5054700", Offset = "0x5053300", VA = "0x185054700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x294FE60", Offset = "0x294EA60", VA = "0x18294FE60")]
		public ALPBCKJANAN(HBFEOHNMHAE<T> IKALPCJBCLK, int EMMACFPOKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5054750", Offset = "0x5053350", VA = "0x185054750")]
		public bool MNOHJEBJBPH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BKFGLDAFLBD : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HBFEOHNMHAE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public BKFGLDAFLBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x647DC30", Offset = "0x647C830", VA = "0x18647DC30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x647DCD0", Offset = "0x647C8D0", VA = "0x18647DCD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MLPBFPAAABE : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public HBFEOHNMHAE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public MLPBFPAAABE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x54C9240", Offset = "0x54C7E40", VA = "0x1854C9240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x54C92E0", Offset = "0x54C7EE0", VA = "0x1854C92E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] PEDMEJIDLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint OOHGFGHCOAJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4D864E0", Offset = "0x4D850E0", VA = "0x184D864E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PNOGDJAFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4D86590", Offset = "0x4D85190", VA = "0x184D86590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HLKMBCEEOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x18D3180", Offset = "0x18D1D80", VA = "0x1818D3180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool CCBOHDNGHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4D864F0", Offset = "0x4D850F0", VA = "0x184D864F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AOMOJHJAIEE<T> JCOMHHICLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4D86360", Offset = "0x4D84F60", VA = "0x184D86360")]
		get
		{
			return default(AOMOJHJAIEE<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4D86810", Offset = "0x4D85410", VA = "0x184D86810")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4D862B0", Offset = "0x4D84EB0", VA = "0x184D862B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D870B0", Offset = "0x4D85CB0", VA = "0x184D870B0")]
	internal HBFEOHNMHAE(HBFEOHNMHAE<T> IKALPCJBCLK, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D87020", Offset = "0x4D85C20", VA = "0x184D87020")]
	private HBFEOHNMHAE(T[] IKALPCJBCLK, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4D86D10", Offset = "0x4D85910", VA = "0x184D86D10")]
	public HBFEOHNMHAE(IEnumerable<T> AIPJHMCGMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D87040", Offset = "0x4D85C40", VA = "0x184D87040")]
	public HBFEOHNMHAE(int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D869F0", Offset = "0x4D855F0", VA = "0x184D869F0")]
	public int OJMMCCEOOLO(T OOHGFGHCOAJ, int EILAIOEPAPK, int DPOOEAFKIHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D86940", Offset = "0x4D85540", VA = "0x184D86940")]
	public void LCGJGMHPHEK(int HIPEGBEGHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D865C0", Offset = "0x4D851C0", VA = "0x184D865C0")]
	private void IAPHBHGJOAH(int HIPEGBEGHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D86790", Offset = "0x4D85390", VA = "0x184D86790")]
	public T[] IFMGGGDAKHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D860E0", Offset = "0x4D84CE0", VA = "0x184D860E0")]
	public T[] DCHGJGHKDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D86230", Offset = "0x4D84E30", VA = "0x184D86230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D868E0", Offset = "0x4D854E0", VA = "0x184D868E0")]
	public void JLMCDCDGANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D86980", Offset = "0x4D85580", VA = "0x184D86980")]
	public ALPBCKJANAN MEEEBEDBKAB()
	{
		return default(ALPBCKJANAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D86B50", Offset = "0x4D85750", VA = "0x184D86B50", Slot = "5")]
	[IteratorStateMachine(typeof(HBFEOHNMHAE<>.BKFGLDAFLBD))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D86C30", Offset = "0x4D85830", VA = "0x184D86C30", Slot = "6")]
	[IteratorStateMachine(typeof(HBFEOHNMHAE<>.MLPBFPAAABE))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D86A70", Offset = "0x4D85670", VA = "0x184D86A70")]
	public static HBFEOHNMHAE<T> PCOONNEEECC(T[] IKALPCJBCLK)
	{
		return default(HBFEOHNMHAE<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D86500", Offset = "0x4D85100", VA = "0x184D86500")]
	public static HBFEOHNMHAE<T> GHOKLFELACP(T[] IKALPCJBCLK)
	{
		return default(HBFEOHNMHAE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D86AD0", Offset = "0x4D856D0", VA = "0x184D86AD0")]
	private void PGOOBNNBACH(int EMMACFPOKFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class JAGGGNKIKJG<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct BHCGJDDAKOE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JAGGGNKIKJG<T> DNNGKIFFAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int EMMACFPOKFB;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x63A8D00", Offset = "0x63A7900", VA = "0x1863A8D00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x63A8D40", Offset = "0x63A7940", VA = "0x1863A8D40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x47CA020", Offset = "0x47C8C20", VA = "0x1847CA020")]
		public BHCGJDDAKOE(JAGGGNKIKJG<T> DNNGKIFFAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x63A8C20", Offset = "0x63A7820", VA = "0x1863A8C20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x63A8CB0", Offset = "0x63A78B0", VA = "0x1863A8CB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private HBFEOHNMHAE<T> PEDMEJIDLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int FMOIHNPEKPL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x50A2100", Offset = "0x50A0D00", VA = "0x1850A2100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x42D13C0", Offset = "0x42CFFC0", VA = "0x1842D13C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x481A4C0", Offset = "0x48190C0", VA = "0x18481A4C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HFMPIJBIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x50A1D60", Offset = "0x50A0960", VA = "0x1850A1D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool HLKMBCEEOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x50A1DF0", Offset = "0x50A09F0", VA = "0x1850A1DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public AOMOJHJAIEE<T> JCOMHHICLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x50A1440", Offset = "0x50A0040", VA = "0x1850A1440")]
		get
		{
			return default(AOMOJHJAIEE<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x50A2090", Offset = "0x50A0C90", VA = "0x1850A2090")]
	public JAGGGNKIKJG(int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C7B000", Offset = "0x4C79C00", VA = "0x184C7B000")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x50A14C0", Offset = "0x50A00C0", VA = "0x1850A14C0")]
	public HBFEOHNMHAE<T> FEPCGFBFDCP()
	{
		return default(HBFEOHNMHAE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x50A1C70", Offset = "0x50A0870", VA = "0x1850A1C70")]
	public void NKAMMCABBBC(T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x50A1C30", Offset = "0x50A0830", VA = "0x1850A1C30")]
	private void LCGJGMHPHEK(int PDJAEHLNOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x50A1E10", Offset = "0x50A0A10", VA = "0x1850A1E10")]
	public void PAFOMKPENGA(List<T> IDAGLLCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x50A1F70", Offset = "0x50A0B70", VA = "0x1850A1F70")]
	public void PAFOMKPENGA(T[] IDAGLLCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x50A1330", Offset = "0x509FF30", VA = "0x1850A1330")]
	public void ACCOGIPAHCG(int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x50A1540", Offset = "0x50A0140", VA = "0x1850A1540")]
	public void GDLDKPCGOLB(int NDLGMNAOBNI, int NHCGLFAFCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x50A1D80", Offset = "0x50A0980", VA = "0x1850A1D80")]
	public int OJMMCCEOOLO(T OOHGFGHCOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x50A1500", Offset = "0x50A0100", VA = "0x1850A1500")]
	public bool FHKFJOGHNEN(T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x50A13B0", Offset = "0x509FFB0", VA = "0x1850A13B0")]
	public T[] DCHGJGHKDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x50A1420", Offset = "0x50A0020", VA = "0x1850A1420", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x50A1790", Offset = "0x50A0390", VA = "0x1850A1790")]
	public static HBFEOHNMHAE<T> GHOKLFELACP(JAGGGNKIKJG<T> DNNGKIFFAHG)
	{
		return default(HBFEOHNMHAE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x50A1840", Offset = "0x50A0440", VA = "0x1850A1840", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x50A1FF0", Offset = "0x50A0BF0", VA = "0x1850A1FF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x50A2020", Offset = "0x50A0C20", VA = "0x1850A2020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x50A18B0", Offset = "0x50A04B0", VA = "0x1850A18B0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void HGINFJFDGGA(int OOHGFGHCOAJ, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x50A1A00", Offset = "0x50A0600", VA = "0x1850A1A00")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void HIGOCBOPMJC(int NDLGMNAOBNI, int NHCGLFAFCAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EIHMHEJGMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x390D1E0", Offset = "0x390BDE0", VA = "0x18390D1E0")]
	public static void JLMCDCDGANA<T>(this JAGGGNKIKJG<T> DNNGKIFFAHG) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public ref struct AOMOJHJAIEE<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> PEDMEJIDLNB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5070D30", Offset = "0x506F930", VA = "0x185070D30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5070C20", Offset = "0x506F820", VA = "0x185070C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5070CA0", Offset = "0x506F8A0", VA = "0x185070CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public AOMOJHJAIEE(Span<object> NPFPPIBACNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5070DB0", Offset = "0x506F9B0", VA = "0x185070DB0")]
	public AOMOJHJAIEE<T> MOHKJGJOJKL(int EILAIOEPAPK)
	{
		return default(AOMOJHJAIEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5070E80", Offset = "0x506FA80", VA = "0x185070E80")]
	public AOMOJHJAIEE<T> MOHKJGJOJKL(int EILAIOEPAPK, int FMOIHNPEKPL)
	{
		return default(AOMOJHJAIEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5070BC0", Offset = "0x506F7C0", VA = "0x185070BC0")]
	public void BMGNJMMNIBI(AOMOJHJAIEE<T> ADPADOFALMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5070F60", Offset = "0x506FB60", VA = "0x185070F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5070C50", Offset = "0x506F850", VA = "0x185070C50", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5070CE0", Offset = "0x506F8E0", VA = "0x185070CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct HJOGNENAABH : IEquatable<HJOGNENAABH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int KPHEINADMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int DPOOEAFKIHD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int DMBCPOGLMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6F80", Offset = "0x2FF5B80", VA = "0x182FF6F80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4900", Offset = "0x6FA3500", VA = "0x186FA4900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int IAIFKPGPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int GEEOJDFCKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5200", Offset = "0x7DC3E00", VA = "0x187DC5200")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7DC50F0", Offset = "0x7DC3CF0", VA = "0x187DC50F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) FEALBENDAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5100", Offset = "0x7DC3D00", VA = "0x187DC5100")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
	private HJOGNENAABH(int KPHEINADMCH, int DPOOEAFKIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x293C070", Offset = "0x293AC70", VA = "0x18293C070")]
	public static HJOGNENAABH DONAKGCFHGK(int KPHEINADMCH, int DPOOEAFKIHD)
	{
		return default(HJOGNENAABH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5160", Offset = "0x7DC3D60", VA = "0x187DC5160")]
	public static HJOGNENAABH EMLPGCIIDFL(int EILAIOEPAPK, int NHCGLFAFCAA)
	{
		return default(HJOGNENAABH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5210", Offset = "0x7DC3E10", VA = "0x187DC5210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x12B1980", Offset = "0x12B0580", VA = "0x1812B1980", Slot = "4")]
	public bool Equals(HJOGNENAABH GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5170", Offset = "0x7DC3D70", VA = "0x187DC5170", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x70F46D0", Offset = "0x70F32D0", VA = "0x1870F46D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct HNCOFDJBOOJ<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> PEDMEJIDLNB;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public HNCOFDJBOOJ(NativeArray<T> PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4DB83E0", Offset = "0x4DB6FE0", VA = "0x184DB83E0", Slot = "6")]
	public int Compare(int KFGAJBKADFK, int FEABMDLFEMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4DB84D0", Offset = "0x4DB70D0", VA = "0x184DB84D0", Slot = "4")]
	public bool Equals(int KFGAJBKADFK, int FEABMDLFEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4DB85C0", Offset = "0x4DB71C0", VA = "0x184DB85C0", Slot = "5")]
	public int GetHashCode(int KFGAJBKADFK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JIIBMGCJJBL
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3B24740", Offset = "0x3B23340", VA = "0x183B24740")]
	public static T[] AIPAALMEONK<T>(List<T> DNNGKIFFAHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct DEAEFJHAGJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* DFCNMEKEKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle OOGJFNCAGIF;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FC40", Offset = "0x5C1E840", VA = "0x185C1FC40")]
	public void LDCCMKMJIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class IKJFJDKDGCE
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3850", Offset = "0x3AF2450", VA = "0x183AF3850")]
	public static DEAEFJHAGJD EJKIIKBPHKN<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> IGFGOFBOBHO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(DEAEFJHAGJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3850", Offset = "0x3AF2450", VA = "0x183AF3850")]
	public static UnsafeParallelHashMap<TKey, TValue> KKALHLKOGPL<TKey, TValue>(this DEAEFJHAGJD IGFGOFBOBHO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GPBCLFPJJGC
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3AAAA00", Offset = "0x3AA9600", VA = "0x183AAAA00")]
	public static int JKGGFNBJJLB<T>(ReadOnlySpan<T> DAFIIBBCIAA, ReadOnlySpan<T> LBMDLDHJIDJ, int FMOIHNPEKPL) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AENGIHEHGNP
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x303FFB0", Offset = "0x303EBB0", VA = "0x18303FFB0")]
	public static T JBMIJPIPMMA<T>(this NativeArray<byte> ENEAIMANIIG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x303FBC0", Offset = "0x303E7C0", VA = "0x18303FBC0")]
	public static NativeArray<T> ADDBIAADCML<T>(this NativeArray<byte> ENEAIMANIIG, int DPOOEAFKIHD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3040040", Offset = "0x303EC40", VA = "0x183040040")]
	public static void MOPDAHIFEJI<T>(this NativeList<byte> JAKICABDOHC, [In] T OOHGFGHCOAJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x30400D0", Offset = "0x303ECD0", VA = "0x1830400D0")]
	public static void MOPDAHIFEJI<T>(this NativeList<byte> JAKICABDOHC, NativeArray<T> OOHGFGHCOAJ) where T : struct
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

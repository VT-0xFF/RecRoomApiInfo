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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80FA3B0", Offset = "0x80F8FB0", VA = "0x1880FA3B0", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[OOGFDLNMBKM]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3DCFA50", Offset = "0x3DCE650", VA = "0x183DCFA50")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[OOGFDLNMBKM]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0C10", Offset = "0x3DCF810", VA = "0x183DD0C10")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3DCFC50", Offset = "0x3DCE850", VA = "0x183DCFC50")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3DCFDB0", Offset = "0x3DCE9B0", VA = "0x183DCFDB0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9850", Offset = "0x3DD8450", VA = "0x183DD9850")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD95E0", Offset = "0x3DD81E0", VA = "0x183DD95E0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9750", Offset = "0x3DD8350", VA = "0x183DD9750")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9F10", Offset = "0x3DD8B10", VA = "0x183DD9F10")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1360", Offset = "0x3DCFF60", VA = "0x183DD1360")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD12F0", Offset = "0x3DCFEF0", VA = "0x183DD12F0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1810", Offset = "0x3DD0410", VA = "0x183DD1810")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, FPNBEMALHAC range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1850", Offset = "0x3DD0450", VA = "0x183DD1850")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1690", Offset = "0x3DD0290", VA = "0x183DD1690")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3DCFAA0", Offset = "0x3DCE6A0", VA = "0x183DCFAA0")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9690", Offset = "0x3DD8290", VA = "0x183DD9690")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[OOGFDLNMBKM]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9FE0", Offset = "0x3DD8BE0", VA = "0x183DD9FE0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBC70", Offset = "0x3DDA870", VA = "0x183DDBC70")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBC80", Offset = "0x3DDA880", VA = "0x183DDBC80")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x633C140", Offset = "0x633AD40", VA = "0x18633C140")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80FA6F0", Offset = "0x80F92F0", VA = "0x1880FA6F0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80FA720", Offset = "0x80F9320", VA = "0x1880FA720")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB440", Offset = "0x3DDA040", VA = "0x183DDB440")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB130", Offset = "0x3DD9D30", VA = "0x183DDB130")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB4A0", Offset = "0x3DDA0A0", VA = "0x183DDB4A0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB320", Offset = "0x3DD9F20", VA = "0x183DDB320")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB3F0", Offset = "0x3DD9FF0", VA = "0x183DDB3F0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB280", Offset = "0x3DD9E80", VA = "0x183DDB280")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB7A0", Offset = "0x3DDA3A0", VA = "0x183DDB7A0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB600", Offset = "0x3DDA200", VA = "0x183DDB600")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB0B0", Offset = "0x3DD9CB0", VA = "0x183DDB0B0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB050", Offset = "0x3DD9C50", VA = "0x183DDB050")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB030", Offset = "0x3DD9C30", VA = "0x183DDB030")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC0A0", Offset = "0x3DDACA0", VA = "0x183DDC0A0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBCD0", Offset = "0x3DDA8D0", VA = "0x183DDBCD0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC0D0", Offset = "0x3DDACD0", VA = "0x183DDC0D0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC180", Offset = "0x3DDAD80", VA = "0x183DDC180")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[OOGFDLNMBKM]
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
			[Cpp2IlInjected.Address(RVA = "0x4F52170", Offset = "0x4F50D70", VA = "0x184F52170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xEF1340", Offset = "0xEEFF40", VA = "0x180EF1340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xE507D0", Offset = "0xE4F3D0", VA = "0x180E507D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5442830", Offset = "0x5441430", VA = "0x185442830")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x57336C0", Offset = "0x57322C0", VA = "0x1857336C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x57335E0", Offset = "0x57321E0", VA = "0x1857335E0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x43B3190", Offset = "0x43B1D90", VA = "0x1843B3190")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[OOGFDLNMBKM]
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
			[Cpp2IlInjected.Address(RVA = "0x5799A50", Offset = "0x5798650", VA = "0x185799A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5799A90", Offset = "0x5798690", VA = "0x185799A90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xE507D0", Offset = "0xE4F3D0", VA = "0x180E507D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5442830", Offset = "0x5441430", VA = "0x185442830")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x57996B0", Offset = "0x57982B0", VA = "0x1857996B0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x57997F0", Offset = "0x57983F0", VA = "0x1857997F0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x57999B0", Offset = "0x57985B0", VA = "0x1857999B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5799830", Offset = "0x5798430", VA = "0x185799830")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[OOGFDLNMBKM]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[OOGFDLNMBKM]
public static class CJIBAMKOPDL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80F87A0", Offset = "0x80F73A0", VA = "0x1880F87A0")]
	public static JobHandle MOKPJBCDLFC(this JobHandle JPILOOHOBDJ, JobHandle MAKDDCFIOBO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80F86F0", Offset = "0x80F72F0", VA = "0x1880F86F0")]
	public static JobHandle MGMPFKOBEAP(this Span<JobHandle> PFNBMKKIEIH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JEEGCAHAPHN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38C5D10", Offset = "0x38C4910", VA = "0x1838C5D10")]
	public static void HAGLLFMPLGJ<T>(this T[] COJHNLDFDFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IEOEJCEINOE
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9E910", Offset = "0x3C9D510", VA = "0x183C9E910")]
	public static NativeKeyValueArrays<TKey, TValue> DGHNAOEAGHJ<TKey, TValue>(this Dictionary<TKey, TValue> ELIABFCDDBG, Allocator HPEAGMDCCBL) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PAIAJGCCGOP
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80FA9A0", Offset = "0x80F95A0", VA = "0x1880FA9A0")]
	public static void BHEAAFGCOOD(this GameObject HLOIBGDKPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80FA900", Offset = "0x80F9500", VA = "0x1880FA900")]
	public static void BHEAAFGCOOD(this Component GCOJJLDOHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80FA860", Offset = "0x80F9460", VA = "0x1880FA860")]
	public static void BHEAAFGCOOD(this ScriptableObject NKIKGPPLCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GPCOMOCODDF
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80F8BC0", Offset = "0x80F77C0", VA = "0x1880F8BC0")]
	public static void MDMBKAPGMLH(this NativeList<byte> ADEANPNALNF, ReadOnlySpan<byte> DOBOBJDFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F610", Offset = "0x3C4E210", VA = "0x183C4F610")]
	public static void LKACFOPACLE<T>(this NativeList<T> ADEANPNALNF, T BKMPCFIAHIG, int NKGPOLKDIPE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LABBBIEBMBI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F860", Offset = "0x3D0E460", VA = "0x183D0F860")]
	public static T OIHNNGMDEMJ<T>(this ReadOnlySpan<byte> BKMPCFIAHIG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D0ECE0", Offset = "0x3D0D8E0", VA = "0x183D0ECE0")]
	public static T GGJCMJPACBJ<T>(this Span<T> DOBOBJDFKFI, Func<T, bool> JAFCIPCJAAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D0EE00", Offset = "0x3D0DA00", VA = "0x183D0EE00")]
	public static bool HNABLFCAAEN<T>(this Span<T> DOBOBJDFKFI, Func<T, bool> JAFCIPCJAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D0EC10", Offset = "0x3D0D810", VA = "0x183D0EC10")]
	public static bool ECIHDOLBPAH<T>(this Span<T> DOBOBJDFKFI, Func<T, bool> JAFCIPCJAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F400", Offset = "0x3D0E000", VA = "0x183D0F400")]
	public static T LGFPFICEOKK<T>([In] this ReadOnlySpan<byte> DOBOBJDFKFI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D0ECA0", Offset = "0x3D0D8A0", VA = "0x183D0ECA0")]
	public static Span<TTo> ECJBHIPDDIO<TTo, TFrom>(this Span<TFrom> DOBOBJDFKFI) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D0ECA0", Offset = "0x3D0D8A0", VA = "0x183D0ECA0")]
	public static ReadOnlySpan<TTo> ECJBHIPDDIO<TTo, TFrom>(this ReadOnlySpan<TFrom> DOBOBJDFKFI) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D0ECA0", Offset = "0x3D0D8A0", VA = "0x183D0ECA0")]
	public static ReadOnlySpan<TTo> ECJBHIPDDIO<TTo>(this ReadOnlySpan<byte> DOBOBJDFKFI) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F310", Offset = "0x3D0DF10", VA = "0x183D0F310")]
	public static Span<T> JEKMEOOFFAJ<T>(this ReadOnlySpan<T> OJNBCCCOMPJ) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0EE90", Offset = "0x3D0DA90", VA = "0x183D0EE90")]
	public static Span<byte> IEFFBEILLPC<T>([In] this Span<byte> DOBOBJDFKFI, T BKMPCFIAHIG) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80F9880", Offset = "0x80F8480", VA = "0x1880F9880")]
	private static Enum NANKJKHGOAA([In] ReadOnlySpan<byte> DOBOBJDFKFI, Type IPGKEGBKDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80F9810", Offset = "0x80F8410", VA = "0x1880F9810")]
	public static Enum IDMMOCEKABL([In] this Span<byte> DOBOBJDFKFI, Type IPGKEGBKDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80F9300", Offset = "0x80F7F00", VA = "0x1880F9300")]
	public static void CKMCFGPCLAL([In] this Span<byte> DOBOBJDFKFI, Enum IILFEKLIFDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HLKHOGDMPMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EMHGNCCOGHI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80F8830", Offset = "0x80F7430", VA = "0x1880F8830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80F8C40", Offset = "0x80F7840", VA = "0x1880F8C40")]
	[AsyncStateMachine(typeof(EMHGNCCOGHI))]
	public static void CICGKPNOANE(this Task KJCIKLJPCMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GNPFECIKEEB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F120", Offset = "0x3C4DD20", VA = "0x183C4F120")]
	public static NativeArray<T> HMCMIGPHOPB<T>(this UnsafeList<T> ADEANPNALNF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F220", Offset = "0x3C4DE20", VA = "0x183C4F220")]
	public static NativeArray<T> LCHPEHMONGH<T>(this UnsafeList<T> ADEANPNALNF, bool BCHGIOMMOEN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F170", Offset = "0x3C4DD70", VA = "0x183C4F170")]
	public static UnsafeList<T> JEKMEOOFFAJ<T>(this UnsafeList<T> ADEANPNALNF, Allocator HPEAGMDCCBL) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PLMOPDCEEIE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum BMOCEBILOLD : short
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
	public struct DIDDMNGLCMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly BMOCEBILOLD DHCHBFGMFFD;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x30FED20", Offset = "0x30FD920", VA = "0x1830FED20")]
		public DIDDMNGLCMO(BMOCEBILOLD DHCHBFGMFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory CJIPCCCFEPA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	public static void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80FAA40", Offset = "0x80F9640", VA = "0x1880FAA40")]
	static PLMOPDCEEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38DD1A0", Offset = "0x38DBDA0", VA = "0x1838DD1A0")]
	public static DIDDMNGLCMO HOBKABLNFMF(BMOCEBILOLD DHCHBFGMFFD)
	{
		return default(DIDDMNGLCMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	public static void CPNDIPKEKLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class FGNAKPCGMEL
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D800", Offset = "0x2C1C400", VA = "0x182C1D800")]
	public static COANOJMOOMB<T1, T2> NFNFACKIEKP<T1, T2>(this (T1, T2) PCBNMHACLKI) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(COANOJMOOMB<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FDD0", Offset = "0x3A9E9D0", VA = "0x183A9FDD0")]
	public static DKELOMBENOE<T1, T2, T3> NFNFACKIEKP<T1, T2, T3>(this (T1, T2, T3) PCBNMHACLKI) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(DKELOMBENOE<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct COANOJMOOMB<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) PCBNMHACLKI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D820", Offset = "0x2C1C420", VA = "0x182C1D820")]
	public COANOJMOOMB((T1, T2) PCBNMHACLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C49AD0", Offset = "0x6C486D0", VA = "0x186C49AD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DKELOMBENOE<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) PCBNMHACLKI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4472AE0", Offset = "0x44716E0", VA = "0x184472AE0")]
	public DKELOMBENOE((T1, T2, T3) PCBNMHACLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4472A40", Offset = "0x4471640", VA = "0x184472A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FIDGNENCOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80F89B0", Offset = "0x80F75B0", VA = "0x1880F89B0")]
	public static Range BEEMNFKLFHB(this FPNBEMALHAC BNBCBHJAJGO)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CKDFFNBJBHO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct POIJEFHHLOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int MHKHDHBNFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int MAFBAKDLLMB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x80FAAC0", Offset = "0x80F96C0", VA = "0x1880FAAC0")]
		public POIJEFHHLOL(int LJEEMMFNMLE, int MAFBAKDLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80FAAB0", Offset = "0x80F96B0", VA = "0x1880FAAB0")]
		public bool PCJKIKDLNGG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80F87E0", Offset = "0x80F73E0", VA = "0x1880F87E0")]
	public static POIJEFHHLOL MIEHOANGBJG(this Range BNBCBHJAJGO)
	{
		return default(POIJEFHHLOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BEEGMBJKADI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle PHMFHDLJBOO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OPBMHHGPCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x633C170", Offset = "0x633AD70", VA = "0x18633C170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x633C5D0", Offset = "0x633B1D0", VA = "0x18633C5D0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x633C250", Offset = "0x633AE50", VA = "0x18633C250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x633C950", Offset = "0x633B550", VA = "0x18633C950")]
	public BEEGMBJKADI(T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x633C140", Offset = "0x633AD40", VA = "0x18633C140", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class NMMCJMDOANO<THandle, TValue> : IDisposable where THandle : struct, PDCJNGLGLLH where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> PFNBMKKIEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> OKFGGFMLPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> AJEINNFFOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> DLMKCCIFEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int PKKCEAKJMGK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5724BC0", Offset = "0x57237C0", VA = "0x185724BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5724F00", Offset = "0x5723B00", VA = "0x185724F00")]
	public NMMCJMDOANO(Action<TValue> DLMKCCIFEIN, [Optional] Func<TValue> AJEINNFFOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5724630", Offset = "0x5723230", VA = "0x185724630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5724DB0", Offset = "0x57239B0", VA = "0x185724DB0")]
	public THandle NDGLNAHKHEG(TValue BKMPCFIAHIG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5724E20", Offset = "0x5723A20", VA = "0x185724E20")]
	public bool PCEOKDJFDMA(THandle PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5724A80", Offset = "0x5723680", VA = "0x185724A80")]
	public bool GNMDKNPAJOM(THandle PHMFHDLJBOO, [Out] TValue BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5724BF0", Offset = "0x57237F0", VA = "0x185724BF0")]
	public TValue LGFPFICEOKK(THandle PHMFHDLJBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5724990", Offset = "0x5723590", VA = "0x185724990")]
	public bool GDLGKCEKPAD(THandle PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x57245B0", Offset = "0x57231B0", VA = "0x1857245B0")]
	private THandle DKOHLMGMBMG(int LCCBBMBENOH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5724570", Offset = "0x5723170", VA = "0x185724570")]
	private TValue CLFPKKLNFPN(int LCCBBMBENOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x57245F0", Offset = "0x57231F0", VA = "0x1857245F0")]
	private void DPOABEJKNHJ(int LCCBBMBENOH, [In] THandle PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5724C40", Offset = "0x5723840", VA = "0x185724C40")]
	private void MJLOGPHGKHJ(int LCCBBMBENOH, [In] TValue BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x57246B0", Offset = "0x57232B0", VA = "0x1857246B0")]
	private THandle EIIIFKKLLEL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5724800", Offset = "0x5723400", VA = "0x185724800")]
	private void FNEDDLFDNKO(THandle PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x57247F0", Offset = "0x57233F0", VA = "0x1857247F0")]
	private int FICDFIKMBEK(int LAHAJPPAFND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5724A70", Offset = "0x5723670", VA = "0x185724A70")]
	private bool GHDLDLBKAMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA681E0", Offset = "0xA66DE0", VA = "0x180A681E0")]
	private void CMEHFKIEIGK(THandle PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5724B30", Offset = "0x5723730", VA = "0x185724B30")]
	private bool HNFAKKDLOIJ([Out] THandle PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x57248C0", Offset = "0x57234C0", VA = "0x1857248C0")]
	private bool GBNJDCANOFC([Out] THandle PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5724C70", Offset = "0x5723870", VA = "0x185724C70")]
	private void MMFOCGIFHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PDCJNGLGLLH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CLIFKJOPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int IJGCLEGIDNG
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
public static class LKNGKLKPICH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A8F0", Offset = "0x3D294F0", VA = "0x183D2A8F0")]
	public static bool KPOKECAKFNF<T>(this T PHMFHDLJBOO, T IIOGPDPGOLB) where T : struct, PDCJNGLGLLH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A8E0", Offset = "0x3D294E0", VA = "0x183D2A8E0")]
	public static bool BGMCAGMEELL<T>(this T PHMFHDLJBOO) where T : struct, PDCJNGLGLLH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80FA2A0", Offset = "0x80F8EA0", VA = "0x1880FA2A0")]
	public static string JNCHILBKMMG(this PDCJNGLGLLH PHMFHDLJBOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct ODGPDIMIKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type KKFLCPGOHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> LEFHKCEMJCL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5449690", Offset = "0x5448290", VA = "0x185449690")]
	public ODGPDIMIKDO(Type OPFNBBJDCDI, Span<byte> DOBOBJDFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5B50", Offset = "0x3DF4750", VA = "0x183DF5B50")]
	public static ODGPDIMIKDO HEAKFDDJFMJ<T>(T BKMPCFIAHIG) where T : struct
	{
		return default(ODGPDIMIKDO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x80FA7E0", Offset = "0x80F93E0", VA = "0x1880FA7E0")]
	public static IIOLOBIILNO KDDDGPNBGLG([In] ODGPDIMIKDO KFNDMAAELJD)
	{
		return default(IIOLOBIILNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x80FA760", Offset = "0x80F9360", VA = "0x1880FA760")]
	public Enum IDMMOCEKABL(Type IPGKEGBKDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6450", Offset = "0x3DF5050", VA = "0x183DF6450")]
	public void IEFFBEILLPC<T>([In] T BKMPCFIAHIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x80FA750", Offset = "0x80F9350", VA = "0x1880FA750")]
	public void CKMCFGPCLAL(Enum IILFEKLIFDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct IIOLOBIILNO
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct KHLHHOJBLDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* HILFILMOILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* GLKJNDMFKLL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type KKFLCPGOHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> LEFHKCEMJCL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KIEGIHKIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x80F9170", Offset = "0x80F7D70", VA = "0x1880F9170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int ENHCADPDDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x80F8F50", Offset = "0x80F7B50", VA = "0x1880F8F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5449690", Offset = "0x5448290", VA = "0x185449690")]
	public IIOLOBIILNO(Type OPFNBBJDCDI, ReadOnlySpan<byte> DOBOBJDFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CA80D0", Offset = "0x3CA6CD0", VA = "0x183CA80D0")]
	public static IIOLOBIILNO HEAKFDDJFMJ<T>(T BKMPCFIAHIG) where T : struct
	{
		return default(IIOLOBIILNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x80F9180", Offset = "0x80F7D80", VA = "0x1880F9180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x80F8FA0", Offset = "0x80F7BA0", VA = "0x1880F8FA0")]
	public object JIGIECOGLJJ(int LCCBBMBENOH = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IFKBKNBBDEB
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0120", Offset = "0x3C9ED20", VA = "0x183CA0120")]
	public static NativeArray<T> HEAKFDDJFMJ<T>(T BKMPCFIAHIG, bool BCHGIOMMOEN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0160", Offset = "0x3C9ED60", VA = "0x183CA0160")]
	public static NativeArray<T> HLLGBFEOJOD<T>(T BKMPCFIAHIG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3CA00F0", Offset = "0x3C9ECF0", VA = "0x183CA00F0")]
	public static NativeArray<T> GEBFKEEECDI<T>(T BKMPCFIAHIG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x80F8D60", Offset = "0x80F7960", VA = "0x1880F8D60")]
	public static NativeArray<byte> GEBFKEEECDI(ReadOnlySpan<byte> BKMPCFIAHIG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x80F8EA0", Offset = "0x80F7AA0", VA = "0x1880F8EA0")]
	public static NativeArray<byte> HEAKFDDJFMJ(ReadOnlySpan<byte> BKMPCFIAHIG, bool BCHGIOMMOEN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x80F8E20", Offset = "0x80F7A20", VA = "0x1880F8E20")]
	public unsafe static NativeArray<byte> HEAKFDDJFMJ(byte* DGLHINKDMGM, int LBLBECEIAEC, bool BCHGIOMMOEN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0190", Offset = "0x3C9ED90", VA = "0x183CA0190")]
	public static NativeArray<T> LNCBONNLALO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct NOEHIGIDHKF : IEquatable<NOEHIGIDHKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int OMBGPNMLCNN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type GJCIAOMMHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80FA560", Offset = "0x80F9160", VA = "0x1880FA560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x80FA650", Offset = "0x80F9250", VA = "0x1880FA650")]
	public NOEHIGIDHKF(Type MDCDODCGNEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x80FA4D0", Offset = "0x80F90D0", VA = "0x1880FA4D0")]
	public static NOEHIGIDHKF KDDDGPNBGLG(Type MDCDODCGNEK)
	{
		return default(NOEHIGIDHKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2406580", Offset = "0x2405180", VA = "0x182406580", Slot = "4")]
	public bool Equals(NOEHIGIDHKF IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x80FA440", Offset = "0x80F9040", VA = "0x1880FA440", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80FA610", Offset = "0x80F9210", VA = "0x1880FA610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LCCHDLDOLOM
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> LOOKGLHNJND;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> DHACONNEMNF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80FA110", Offset = "0x80F8D10", VA = "0x1880FA110")]
	static LCCHDLDOLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x80F9F00", Offset = "0x80F8B00", VA = "0x1880F9F00")]
	public static bool NDGLNAHKHEG(Type MDCDODCGNEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80F9F60", Offset = "0x80F8B60", VA = "0x1880F9F60")]
	private static bool NDGLNAHKHEG(Type MDCDODCGNEK, [Out] int LCCBBMBENOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x80F9E20", Offset = "0x80F8A20", VA = "0x1880F9E20")]
	public static int BBMGDJPIKOB(Type MDCDODCGNEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80F9E80", Offset = "0x80F8A80", VA = "0x1880F9E80")]
	public static Type LGFPFICEOKK(int LCCBBMBENOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct BKANJKABCME<Handle> where Handle : PDCJNGLGLLH, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct JOMBDCGEDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly BKANJKABCME<Handle> KBEGPPOKLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int LCCBBMBENOH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle OFEEPGCAGEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x52F1990", Offset = "0x52F0590", VA = "0x1852F1990")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x52F1DA0", Offset = "0x52F09A0", VA = "0x1852F1DA0")]
		public JOMBDCGEDDO(BKANJKABCME<Handle> KBEGPPOKLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x52F1AF0", Offset = "0x52F06F0", VA = "0x1852F1AF0")]
		public FIAGAIEOAFF MJMNOIPJNFN([In] FIAGAIEOAFF HPNKJCMLGMJ)
		{
			return default(FIAGAIEOAFF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x52F1B80", Offset = "0x52F0780", VA = "0x1852F1B80")]
		public bool PCJKIKDLNGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x52F17D0", Offset = "0x52F03D0", VA = "0x1852F17D0")]
		private Handle BNEEAEDOGLG(string HLMEMBFCHLD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct FIAGAIEOAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private JOMBDCGEDDO ANFINGBKKIP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4D74C50", Offset = "0x4D73850", VA = "0x184D74C50")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4D74CD0", Offset = "0x4D738D0", VA = "0x184D74CD0")]
		public FIAGAIEOAFF(BKANJKABCME<Handle> KBEGPPOKLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4D74BD0", Offset = "0x4D737D0", VA = "0x184D74BD0")]
		public bool PCJKIKDLNGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4D74B60", Offset = "0x4D73760", VA = "0x184D74B60")]
		public FIAGAIEOAFF MIEHOANGBJG()
		{
			return default(FIAGAIEOAFF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> OALJKGOMIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> OAIJLHCPICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int DIHLKFACNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int BLDAFNPIEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool PIDJHAOECBN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LNNGLAPDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6608450", Offset = "0x6607050", VA = "0x186608450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FIAGAIEOAFF HPMKNNLDFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x66083C0", Offset = "0x6606FC0", VA = "0x1866083C0")]
		get
		{
			return default(FIAGAIEOAFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6608860", Offset = "0x6607460", VA = "0x186608860")]
	public BKANJKABCME(int FIDAAGJHPMA, Allocator HPEAGMDCCBL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6606DF0", Offset = "0x66059F0", VA = "0x186606DF0")]
	public void EDJAHJBIEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x236AF80", Offset = "0x2369B80", VA = "0x18236AF80")]
	public static int FICDFIKMBEK(int DNDKHMOJDEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3119DB0", Offset = "0x31189B0", VA = "0x183119DB0")]
	public static bool FAGNCFBEEOO(int DNDKHMOJDEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6608570", Offset = "0x6607170", VA = "0x186608570")]
	public bool NPHFAHCFOID(int LCCBBMBENOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6607F90", Offset = "0x6606B90", VA = "0x186607F90")]
	public bool IPMOFNLFOPJ(Handle PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6607380", Offset = "0x6605F80", VA = "0x186607380")]
	public Handle FBNBGNJLHHP()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6607C90", Offset = "0x6606890", VA = "0x186607C90")]
	public void IJLNDLJJGMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x66074B0", Offset = "0x66060B0", VA = "0x1866074B0")]
	public void FLEFOONILGF(Handle PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xAC0B50", Offset = "0xABF750", VA = "0x180AC0B50")]
	private bool BENCAJJMKEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6607260", Offset = "0x6605E60", VA = "0x186607260")]
	private bool EMCGNIIKCCG(int LCCBBMBENOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6607520", Offset = "0x6606120", VA = "0x186607520")]
	private void GLNMLDKBPAI([Out] int LCCBBMBENOH, [Out] int LAHAJPPAFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x66070C0", Offset = "0x6605CC0", VA = "0x1866070C0")]
	private void EEOEBPIEOOM(Handle PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6608520", Offset = "0x6607120", VA = "0x186608520")]
	private void NKBKBOHFMPO(int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6608260", Offset = "0x6606E60", VA = "0x186608260")]
	private bool KOHBOMFHNKL([Out] int LCCBBMBENOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x66077E0", Offset = "0x66063E0", VA = "0x1866077E0")]
	private static Handle IIOAACPFPMO(int LCCBBMBENOH, int LAHAJPPAFND)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct COODAAFILBG<Handle, T> where Handle : PDCJNGLGLLH, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private BKANJKABCME<Handle> PFIIEKGKELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] CICJDMMMMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> HGPMKDEPAAM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6C59190", Offset = "0x6C57D90", VA = "0x186C59190")]
	public COODAAFILBG(int FIDAAGJHPMA, [Optional] Action<T> HGPMKDEPAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C583A0", Offset = "0x6C56FA0", VA = "0x186C583A0")]
	public void EDJAHJBIEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C588E0", Offset = "0x6C574E0", VA = "0x186C588E0")]
	public bool GNMDKNPAJOM(Handle PHMFHDLJBOO, [Out] T KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C58DD0", Offset = "0x6C579D0", VA = "0x186C58DD0")]
	public Handle NDGLNAHKHEG(T KOJLNGLNBMH)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C58BB0", Offset = "0x6C577B0", VA = "0x186C58BB0")]
	public void MKBCBNIAEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C58570", Offset = "0x6C57170", VA = "0x186C58570")]
	public void ENKPLOICKCM(Handle PHMFHDLJBOO, [Out] T GPHECPMCOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C584A0", Offset = "0x6C570A0", VA = "0x186C584A0")]
	public void ENKPLOICKCM(Handle PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6C58340", Offset = "0x6C56F40", VA = "0x186C58340")]
	private T EADGMLABOEB(int LCCBBMBENOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6C58FF0", Offset = "0x6C57BF0", VA = "0x186C58FF0")]
	private void OPGKJCPDHFP(int JCJEPDALOLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct OOJKGBPAOPB<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct JELFPPBNHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private OOJKGBPAOPB<T> COJHNLDFDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int LCCBBMBENOH;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x52C8020", Offset = "0x52C6C20", VA = "0x1852C8020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A3ED30", Offset = "0x2A3D930", VA = "0x182A3ED30")]
		public JELFPPBNHHJ(OOJKGBPAOPB<T> COJHNLDFDFB, int LCCBBMBENOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x52C7FD0", Offset = "0x52C6BD0", VA = "0x1852C7FD0")]
		public bool PCJKIKDLNGG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EALPMNEJOKC : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public OOJKGBPAOPB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public EALPMNEJOKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x48C72A0", Offset = "0x48C5EA0", VA = "0x1848C72A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x48C7340", Offset = "0x48C5F40", VA = "0x1848C7340", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NMBIANKIGGB : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public OOJKGBPAOPB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public NMBIANKIGGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5723080", Offset = "0x5721C80", VA = "0x185723080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5723120", Offset = "0x5721D20", VA = "0x185723120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] CBCNBAPLLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint BKMPCFIAHIG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x588DC00", Offset = "0x588C800", VA = "0x18588DC00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NNPPJEMMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x588D3A0", Offset = "0x588BFA0", VA = "0x18588D3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AKCFPEAFOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x19852C0", Offset = "0x1983EC0", VA = "0x1819852C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool CFAELHAHEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x588D5F0", Offset = "0x588C1F0", VA = "0x18588D5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MHCIELBEICM<T> LEFHKCEMJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x588D9B0", Offset = "0x588C5B0", VA = "0x18588D9B0")]
		get
		{
			return default(MHCIELBEICM<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x588D600", Offset = "0x588C200", VA = "0x18588D600")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x588DC10", Offset = "0x588C810", VA = "0x18588DC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x588DE80", Offset = "0x588CA80", VA = "0x18588DE80")]
	internal OOJKGBPAOPB(OOJKGBPAOPB<T> COJHNLDFDFB, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x588DF10", Offset = "0x588CB10", VA = "0x18588DF10")]
	private OOJKGBPAOPB(T[] COJHNLDFDFB, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x588DF30", Offset = "0x588CB30", VA = "0x18588DF30")]
	public OOJKGBPAOPB(IEnumerable<T> OKFGGFMLPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x588DEA0", Offset = "0x588CAA0", VA = "0x18588DEA0")]
	public OOJKGBPAOPB(int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x588D760", Offset = "0x588C360", VA = "0x18588D760")]
	public int KFAOOJCFEOF(T BKMPCFIAHIG, int LJEEMMFNMLE, int NKGPOLKDIPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x588D4D0", Offset = "0x588C0D0", VA = "0x18588D4D0")]
	public void ECEPBGOBHMA(int HJMGLEONIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x588D7E0", Offset = "0x588C3E0", VA = "0x18588D7E0")]
	private void KNPKGKBLGPK(int HJMGLEONIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x588D3D0", Offset = "0x588BFD0", VA = "0x18588D3D0")]
	public T[] DCELKOLJCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x588D250", Offset = "0x588BE50", VA = "0x18588D250")]
	public T[] CLDFJMLAOLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x588D450", Offset = "0x588C050", VA = "0x18588D450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x588D590", Offset = "0x588C190", VA = "0x18588D590")]
	public void HDIMPELOFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x588DB90", Offset = "0x588C790", VA = "0x18588DB90")]
	public JELFPPBNHHJ MIEHOANGBJG()
	{
		return default(JELFPPBNHHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x588DCC0", Offset = "0x588C8C0", VA = "0x18588DCC0", Slot = "5")]
	[IteratorStateMachine(typeof(OOJKGBPAOPB<>.EALPMNEJOKC))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x588DDA0", Offset = "0x588C9A0", VA = "0x18588DDA0", Slot = "6")]
	[IteratorStateMachine(typeof(OOJKGBPAOPB<>.NMBIANKIGGB))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x588DB30", Offset = "0x588C730", VA = "0x18588DB30")]
	public static OOJKGBPAOPB<T> MEBBFHIMABF(T[] COJHNLDFDFB)
	{
		return default(OOJKGBPAOPB<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x588D6D0", Offset = "0x588C2D0", VA = "0x18588D6D0")]
	public static OOJKGBPAOPB<T> KDDDGPNBGLG(T[] COJHNLDFDFB)
	{
		return default(OOJKGBPAOPB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x588D510", Offset = "0x588C110", VA = "0x18588D510")]
	private void EOBGFAAKIMG(int LCCBBMBENOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class AOPMNNAIBAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x319A2A0", Offset = "0x3198EA0", VA = "0x18319A2A0")]
	public static OOJKGBPAOPB<T> LDDFGMNCNAN<T>(this IEnumerable<T> PEDKIKCGBIP) where T : class
	{
		return default(OOJKGBPAOPB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class EAICLJOGAIB<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct GHDEGKOFHDN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private EAICLJOGAIB<T> ADEANPNALNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int LCCBBMBENOH;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4E9CE50", Offset = "0x4E9BA50", VA = "0x184E9CE50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4E9CE90", Offset = "0x4E9BA90", VA = "0x184E9CE90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4983790", Offset = "0x4982390", VA = "0x184983790")]
		public GHDEGKOFHDN(EAICLJOGAIB<T> ADEANPNALNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CD70", Offset = "0x4E9B970", VA = "0x184E9CD70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CE00", Offset = "0x4E9BA00", VA = "0x184E9CE00", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private OOJKGBPAOPB<T> CBCNBAPLLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int LBLBECEIAEC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x48C6920", Offset = "0x48C5520", VA = "0x1848C6920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x48C5E50", Offset = "0x48C4A50", VA = "0x1848C5E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x48C6900", Offset = "0x48C5500", VA = "0x1848C6900", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LNNGLAPDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x48C6660", Offset = "0x48C5260", VA = "0x1848C6660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool AKCFPEAFOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x48C5860", Offset = "0x48C4460", VA = "0x1848C5860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public MHCIELBEICM<T> LEFHKCEMJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x48C6060", Offset = "0x48C4C60", VA = "0x1848C6060")]
		get
		{
			return default(MHCIELBEICM<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x48C6810", Offset = "0x48C5410", VA = "0x1848C6810")]
	public EAICLJOGAIB(IEnumerable<T> OKFGGFMLPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x48C6890", Offset = "0x48C5490", VA = "0x1848C6890")]
	public EAICLJOGAIB(int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x48C5EE0", Offset = "0x48C4AE0", VA = "0x1848C5EE0")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x48C57B0", Offset = "0x48C43B0", VA = "0x1848C57B0")]
	public OOJKGBPAOPB<T> BFJODDLEDOK()
	{
		return default(OOJKGBPAOPB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x48C6680", Offset = "0x48C5280", VA = "0x1848C6680")]
	public void NDGLNAHKHEG(T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x48C58C0", Offset = "0x48C44C0", VA = "0x1848C58C0")]
	private void ECEPBGOBHMA(int FJNGONEOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x48C6330", Offset = "0x48C4F30", VA = "0x1848C6330")]
	public void MDMBKAPGMLH(List<T> GIPHBDCKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x48C6490", Offset = "0x48C5090", VA = "0x1848C6490")]
	public void MDMBKAPGMLH(T[] GIPHBDCKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x48C5D60", Offset = "0x48C4960", VA = "0x1848C5D60")]
	public bool ENKPLOICKCM(T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x48C5DD0", Offset = "0x48C49D0", VA = "0x1848C5DD0")]
	public void FLNCHNHPMMB(int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x48C60E0", Offset = "0x48C4CE0", VA = "0x1848C60E0")]
	public void LDOLEPKLECI(int EIJAOFOALKH, int MAFBAKDLLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x48C58A0", Offset = "0x48C44A0", VA = "0x1848C58A0")]
	public void EADGMLABOEB(int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x48C5900", Offset = "0x48C4500", VA = "0x1848C5900")]
	public void EIPHEBICOIM(int EIJAOFOALKH, int MAFBAKDLLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x48C5FF0", Offset = "0x48C4BF0", VA = "0x1848C5FF0")]
	public int KFAOOJCFEOF(T BKMPCFIAHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x48C5FB0", Offset = "0x48C4BB0", VA = "0x1848C5FB0")]
	public bool KDPIOFHPCJJ(T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x48C57F0", Offset = "0x48C43F0", VA = "0x1848C57F0")]
	public T[] CLDFJMLAOLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x48C5880", Offset = "0x48C4480", VA = "0x1848C5880", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x48C5F00", Offset = "0x48C4B00", VA = "0x1848C5F00")]
	public static OOJKGBPAOPB<T> KDDDGPNBGLG(EAICLJOGAIB<T> ADEANPNALNF)
	{
		return default(OOJKGBPAOPB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x48C5E70", Offset = "0x48C4A70", VA = "0x1848C5E70", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x48C6770", Offset = "0x48C5370", VA = "0x1848C6770", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x48C67A0", Offset = "0x48C53A0", VA = "0x1848C67A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x48C6510", Offset = "0x48C5110", VA = "0x1848C6510")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void MMLJGJJKKLP(int BKMPCFIAHIG, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x48C5B30", Offset = "0x48C4730", VA = "0x1848C5B30")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ENFAFEMHCKN(int EIJAOFOALKH, int MAFBAKDLLMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BABKHJNADAO
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x39BDA30", Offset = "0x39BC630", VA = "0x1839BDA30")]
	public static void HDIMPELOFMK<T>(this EAICLJOGAIB<T> ADEANPNALNF) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct MHCIELBEICM<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> CBCNBAPLLJM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5673AC0", Offset = "0x56726C0", VA = "0x185673AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5673D30", Offset = "0x5672930", VA = "0x185673D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5673CF0", Offset = "0x56728F0", VA = "0x185673CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public MHCIELBEICM(Span<object> DOBOBJDFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5673B40", Offset = "0x5672740", VA = "0x185673B40")]
	public MHCIELBEICM<T> KLLLJLBKAGE(int LJEEMMFNMLE)
	{
		return default(MHCIELBEICM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5673C10", Offset = "0x5672810", VA = "0x185673C10")]
	public MHCIELBEICM<T> KLLLJLBKAGE(int LJEEMMFNMLE, int LBLBECEIAEC)
	{
		return default(MHCIELBEICM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5673A60", Offset = "0x5672660", VA = "0x185673A60")]
	public void IMHILHBHKJC(MHCIELBEICM<T> CEFCAHEJMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5673D60", Offset = "0x5672960", VA = "0x185673D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x56739C0", Offset = "0x56725C0", VA = "0x1856739C0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5673A10", Offset = "0x5672610", VA = "0x185673A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FPNBEMALHAC : IEquatable<FPNBEMALHAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int HDEKJKJDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int NKGPOLKDIPE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MMKAIHHLJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3119BD0", Offset = "0x31187D0", VA = "0x183119BD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6E6AD40", Offset = "0x6E69940", VA = "0x186E6AD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int BMKGOBBMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int ELIJGEBKLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x80F8A10", Offset = "0x80F7610", VA = "0x1880F8A10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x80F8B10", Offset = "0x80F7710", VA = "0x1880F8B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) MINDDEAHONB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x80F8A20", Offset = "0x80F7620", VA = "0x1880F8A20")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE432B0", Offset = "0xE41EB0", VA = "0x180E432B0")]
	private FPNBEMALHAC(int HDEKJKJDEIC, int NKGPOLKDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B720", Offset = "0x2A2A320", VA = "0x182A2B720")]
	public static FPNBEMALHAC GBMDLBJNOOL(int HDEKJKJDEIC, int NKGPOLKDIPE)
	{
		return default(FPNBEMALHAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x80F8B20", Offset = "0x80F7720", VA = "0x1880F8B20")]
	public static FPNBEMALHAC OPKIPHOMDNK(int LJEEMMFNMLE, int MAFBAKDLLMB)
	{
		return default(FPNBEMALHAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x80F8B30", Offset = "0x80F7730", VA = "0x1880F8B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1357FA0", Offset = "0x1356BA0", VA = "0x181357FA0", Slot = "4")]
	public bool Equals(FPNBEMALHAC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x80F8A80", Offset = "0x80F7680", VA = "0x1880F8A80", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x73EB830", Offset = "0x73EA430", VA = "0x1873EB830", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct AOEMGCLBFGI<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> CBCNBAPLLJM;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
	public AOEMGCLBFGI(NativeArray<T> CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5250DB0", Offset = "0x524F9B0", VA = "0x185250DB0", Slot = "6")]
	public int Compare(int LGCEHLADNJC, int LFHMHCKODDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5250EA0", Offset = "0x524FAA0", VA = "0x185250EA0", Slot = "4")]
	public bool Equals(int LGCEHLADNJC, int LFHMHCKODDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5250F90", Offset = "0x524FB90", VA = "0x185250F90", Slot = "5")]
	public int GetHashCode(int LGCEHLADNJC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EDIKJMEIENB
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8480", Offset = "0x3AB7080", VA = "0x183AB8480")]
	public static T[] BHJFEEFNBNE<T>(List<T> ADEANPNALNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct DIFNCHFPHDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* ADHBFJMDHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle HLEABPJBAKD;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EE70", Offset = "0x5E6DA70", VA = "0x185E6EE70")]
	public void EDJAHJBIEKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GADAIJFCENA
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C41720", Offset = "0x3C40320", VA = "0x183C41720")]
	public static DIFNCHFPHDM FNMPCMIHNCH<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> LDOBEDEHEFO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(DIFNCHFPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C41720", Offset = "0x3C40320", VA = "0x183C41720")]
	public static UnsafeParallelHashMap<TKey, TValue> GHDNBACPEGE<TKey, TValue>(this DIFNCHFPHDM LDOBEDEHEFO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DDLKAIIBKMN
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3A88EA0", Offset = "0x3A87AA0", VA = "0x183A88EA0")]
	public static int LKDMLNHIHJK<T>(ReadOnlySpan<T> HCGJPIKHNND, ReadOnlySpan<T> KKHNDFGLBKB, int LBLBECEIAEC) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LAAMOAEJKDO
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E760", Offset = "0x3D0D360", VA = "0x183D0E760")]
	public static T HEHDBFMCKCL<T>(this NativeArray<byte> OJNBCCCOMPJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E370", Offset = "0x3D0CF70", VA = "0x183D0E370")]
	public static NativeArray<T> FIJHIIAMFKP<T>(this NativeArray<byte> OJNBCCCOMPJ, int NKGPOLKDIPE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E880", Offset = "0x3D0D480", VA = "0x183D0E880")]
	public static void KJONDBHMIMN<T>(this NativeList<byte> IOKMBOFHINB, [In] T BKMPCFIAHIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E7F0", Offset = "0x3D0D3F0", VA = "0x183D0E7F0")]
	public static void KJONDBHMIMN<T>(this NativeList<byte> IOKMBOFHINB, NativeArray<T> BKMPCFIAHIG) where T : struct
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

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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x845E5D0", Offset = "0x845CBD0", VA = "0x18845E5D0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[PFFDKLDPPPL]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DF70", Offset = "0x3F1C570", VA = "0x183F1DF70")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[PFFDKLDPPPL]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F1E0", Offset = "0x3F1D7E0", VA = "0x183F1F1E0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E170", Offset = "0x3F1C770", VA = "0x183F1E170")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E2D0", Offset = "0x3F1C8D0", VA = "0x183F1E2D0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3F23BC0", Offset = "0x3F221C0", VA = "0x183F23BC0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3F23950", Offset = "0x3F21F50", VA = "0x183F23950")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3F23AC0", Offset = "0x3F220C0", VA = "0x183F23AC0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3F24210", Offset = "0x3F22810", VA = "0x183F24210")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F930", Offset = "0x3F1DF30", VA = "0x183F1F930")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F8C0", Offset = "0x3F1DEC0", VA = "0x183F1F8C0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F1FDE0", Offset = "0x3F1E3E0", VA = "0x183F1FDE0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, LKOMLBJPOKB range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F1FE20", Offset = "0x3F1E420", VA = "0x183F1FE20")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3F1FC60", Offset = "0x3F1E260", VA = "0x183F1FC60")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DFC0", Offset = "0x3F1C5C0", VA = "0x183F1DFC0")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F23A00", Offset = "0x3F22000", VA = "0x183F23A00")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[PFFDKLDPPPL]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F29720", Offset = "0x3F27D20", VA = "0x183F29720")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A6A0", Offset = "0x3F28CA0", VA = "0x183F2A6A0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A650", Offset = "0x3F28C50", VA = "0x183F2A650")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4AA5F80", Offset = "0x4AA4580", VA = "0x184AA5F80")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x845E910", Offset = "0x845CF10", VA = "0x18845E910")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x845E940", Offset = "0x845CF40", VA = "0x18845E940")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F29BD0", Offset = "0x3F281D0", VA = "0x183F29BD0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F299E0", Offset = "0x3F27FE0", VA = "0x183F299E0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F29CA0", Offset = "0x3F282A0", VA = "0x183F29CA0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F29C50", Offset = "0x3F28250", VA = "0x183F29C50")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F29C00", Offset = "0x3F28200", VA = "0x183F29C00")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F29B30", Offset = "0x3F28130", VA = "0x183F29B30")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F29FA0", Offset = "0x3F285A0", VA = "0x183F29FA0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F29E00", Offset = "0x3F28400", VA = "0x183F29E00")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F29A30", Offset = "0x3F28030", VA = "0x183F29A30")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F29980", Offset = "0x3F27F80", VA = "0x183F29980")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F29960", Offset = "0x3F27F60", VA = "0x183F29960")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AA80", Offset = "0x3F29080", VA = "0x183F2AA80")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A6B0", Offset = "0x3F28CB0", VA = "0x183F2A6B0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AAB0", Offset = "0x3F290B0", VA = "0x183F2AAB0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AB60", Offset = "0x3F29160", VA = "0x183F2AB60")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[PFFDKLDPPPL]
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
			[Cpp2IlInjected.Address(RVA = "0x509C2E0", Offset = "0x509A8E0", VA = "0x18509C2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF4F310", Offset = "0xF4D910", VA = "0x180F4F310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5672820", Offset = "0x5670E20", VA = "0x185672820")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CCA0", Offset = "0x5A2B2A0", VA = "0x185A2CCA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CBC0", Offset = "0x5A2B1C0", VA = "0x185A2CBC0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x44DD870", Offset = "0x44DBE70", VA = "0x1844DD870")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[PFFDKLDPPPL]
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
			[Cpp2IlInjected.Address(RVA = "0x509C2E0", Offset = "0x509A8E0", VA = "0x18509C2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5A86310", Offset = "0x5A84910", VA = "0x185A86310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5672820", Offset = "0x5670E20", VA = "0x185672820")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5A85D90", Offset = "0x5A84390", VA = "0x185A85D90")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5A85F40", Offset = "0x5A84540", VA = "0x185A85F40")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5A861B0", Offset = "0x5A847B0", VA = "0x185A861B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5A86040", Offset = "0x5A84640", VA = "0x185A86040")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[PFFDKLDPPPL]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PFFDKLDPPPL]
public static class CEJNBKEDPAM
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x845CC70", Offset = "0x845B270", VA = "0x18845CC70")]
	public static JobHandle IBIGCKLHAJA(this JobHandle IAFDMJDNHDH, JobHandle DFKKOPOBCBA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x845CCB0", Offset = "0x845B2B0", VA = "0x18845CCB0")]
	public static JobHandle IMEFBOJOPOA(this Span<JobHandle> DEDILDEDBEA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KKLJGDHMAGC
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BDA0", Offset = "0x3A0A3A0", VA = "0x183A0BDA0")]
	public static void OOIGDCNPPFG<T>(this T[] OHHBFAGELLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KOLMMJMFKOA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E68590", Offset = "0x3E66B90", VA = "0x183E68590")]
	public static NativeKeyValueArrays<TKey, TValue> LGLICDIMGMD<TKey, TValue>(this Dictionary<TKey, TValue> KMJJPAEMNAD, Allocator EKNOCGFFMAE) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EPMFNBGDNDH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x845D6A0", Offset = "0x845BCA0", VA = "0x18845D6A0")]
	public static void KMINHOBELBC(this GameObject EGMHLHLEIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x845D740", Offset = "0x845BD40", VA = "0x18845D740")]
	public static void KMINHOBELBC(this Component OFJDOOOKCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x845D600", Offset = "0x845BC00", VA = "0x18845D600")]
	public static void KMINHOBELBC(this ScriptableObject AIOMPELKDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LFCEMAGHGPI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x845E3A0", Offset = "0x845C9A0", VA = "0x18845E3A0")]
	public static void IGDPBMMMPEN(this NativeList<byte> AHJLBOEGGKN, ReadOnlySpan<byte> KJMKIAAPPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B290", Offset = "0x3E79890", VA = "0x183E7B290")]
	public static void MHEHPECBIID<T>(this NativeList<T> AHJLBOEGGKN, T FKMNCAKIOFK, int FEEKNNBMJMM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FAIJJAEAMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D78240", Offset = "0x3D76840", VA = "0x183D78240")]
	public static T KLNLMHAIJEP<T>(this ReadOnlySpan<byte> FKMNCAKIOFK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D77B40", Offset = "0x3D76140", VA = "0x183D77B40")]
	public static T DIAIFBFCEEH<T>(this Span<T> KJMKIAAPPJD, Func<T, bool> NJBKCOBBBAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D781B0", Offset = "0x3D767B0", VA = "0x183D781B0")]
	public static bool KIGHNCLMJPC<T>(this Span<T> KJMKIAAPPJD, Func<T, bool> NJBKCOBBBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D77AB0", Offset = "0x3D760B0", VA = "0x183D77AB0")]
	public static bool BEMNKPLPBFC<T>(this Span<T> KJMKIAAPPJD, Func<T, bool> NJBKCOBBBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D77D50", Offset = "0x3D76350", VA = "0x183D77D50")]
	public static T JLOHDPKHFGN<T>([In] this ReadOnlySpan<byte> KJMKIAAPPJD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D77490", Offset = "0x3D75A90", VA = "0x183D77490")]
	public static Span<TTo> NJCBNNCLPBA<TTo, TFrom>(this Span<TFrom> KJMKIAAPPJD) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D77490", Offset = "0x3D75A90", VA = "0x183D77490")]
	public static ReadOnlySpan<TTo> NJCBNNCLPBA<TTo, TFrom>(this ReadOnlySpan<TFrom> KJMKIAAPPJD) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D77490", Offset = "0x3D75A90", VA = "0x183D77490")]
	public static ReadOnlySpan<TTo> NJCBNNCLPBA<TTo>(this ReadOnlySpan<byte> KJMKIAAPPJD) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D77C60", Offset = "0x3D76260", VA = "0x183D77C60")]
	public static Span<T> JJDCBGIHCCL<T>(this ReadOnlySpan<T> JHGKHIGHBBL) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D77630", Offset = "0x3D75C30", VA = "0x183D77630")]
	public static Span<byte> ADPGIIFDGLO<T>([In] this Span<byte> KJMKIAAPPJD, T FKMNCAKIOFK) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x845D850", Offset = "0x845BE50", VA = "0x18845D850")]
	private static Enum GIHOEHFEGFN([In] ReadOnlySpan<byte> KJMKIAAPPJD, Type BDFOOGAJCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x845D7E0", Offset = "0x845BDE0", VA = "0x18845D7E0")]
	public static Enum DMJGGEIKOAO([In] this Span<byte> KJMKIAAPPJD, Type BDFOOGAJCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x845DE00", Offset = "0x845C400", VA = "0x18845DE00")]
	public static void NHHHPIEJFEC([In] this Span<byte> KJMKIAAPPJD, Enum FBLLKKIPJDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EJAJBHNFIHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OFKIKGINHJL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x845EA80", Offset = "0x845D080", VA = "0x18845EA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x845D4E0", Offset = "0x845BAE0", VA = "0x18845D4E0")]
	[AsyncStateMachine(typeof(OFKIKGINHJL))]
	public static void DAIPONJGLKP(this Task IHNLGGEEIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FOGOBIEEEON
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C690", Offset = "0x3D8AC90", VA = "0x183D8C690")]
	public static NativeArray<T> KOPOMOCCMPH<T>(this UnsafeList<T> AHJLBOEGGKN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C570", Offset = "0x3D8AB70", VA = "0x183D8C570")]
	public static NativeArray<T> GEJFNFMKFAP<T>(this UnsafeList<T> AHJLBOEGGKN, bool MGNIHBNKHPG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C5E0", Offset = "0x3D8ABE0", VA = "0x183D8C5E0")]
	public static UnsafeList<T> JJDCBGIHCCL<T>(this UnsafeList<T> AHJLBOEGGKN, Allocator EKNOCGFFMAE) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FPIKLKOHLPP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum EGPMGMHBJHJ : short
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
	public struct GHBDCOOPALG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly EGPMGMHBJHJ HFLDIIIPBCG;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x31FE510", Offset = "0x31FCB10", VA = "0x1831FE510")]
		public GHBDCOOPALG(EGPMGMHBJHJ HFLDIIIPBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory HIKGHFOMFFB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	public static void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x845E310", Offset = "0x845C910", VA = "0x18845E310")]
	static FPIKLKOHLPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A245A0", Offset = "0x3A22BA0", VA = "0x183A245A0")]
	public static GHBDCOOPALG GGPMEMKAMAL(EGPMGMHBJHJ HFLDIIIPBCG)
	{
		return default(GHBDCOOPALG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	public static void DGIHICJDKML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JNHJFIAEDBJ
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D314B0", Offset = "0x2D2FAB0", VA = "0x182D314B0")]
	public static DBKEONPPFFN<T1, T2> NOCOMMHEMNP<T1, T2>(this (T1, T2) EJHLMFPEOAB) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(DBKEONPPFFN<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3E3C390", Offset = "0x3E3A990", VA = "0x183E3C390")]
	public static CGMOCFEEPOA<T1, T2, T3> NOCOMMHEMNP<T1, T2, T3>(this (T1, T2, T3) EJHLMFPEOAB) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(CGMOCFEEPOA<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DBKEONPPFFN<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) EJHLMFPEOAB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D310F0", Offset = "0x2D2F6F0", VA = "0x182D310F0")]
	public DBKEONPPFFN((T1, T2) EJHLMFPEOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4594DF0", Offset = "0x45933F0", VA = "0x184594DF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CGMOCFEEPOA<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) EJHLMFPEOAB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4594F40", Offset = "0x4593540", VA = "0x184594F40")]
	public CGMOCFEEPOA((T1, T2, T3) EJHLMFPEOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DDBF60", Offset = "0x6DDA560", VA = "0x186DDBF60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class OKEJLHCJOAM
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x845EC00", Offset = "0x845D200", VA = "0x18845EC00")]
	public static Range EKPNFANIKDG(this LKOMLBJPOKB KNPJHKKMLOF)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class OOHLAINGJCO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct IIBALONOGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int KPAGJLFJEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int LGCPIJCGKDM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x845E390", Offset = "0x845C990", VA = "0x18845E390")]
		public IIBALONOGNO(int NEIBMENBNPA, int LGCPIJCGKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x845E380", Offset = "0x845C980", VA = "0x18845E380")]
		public bool FPHEKLELJCB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x845EC60", Offset = "0x845D260", VA = "0x18845EC60")]
	public static IIBALONOGNO DKMCAGKLCHH(this Range KNPJHKKMLOF)
	{
		return default(IIBALONOGNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EOOGCKDECDA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle IINGFCBPPPE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FCLEOOAEEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4AA5F70", Offset = "0x4AA4570", VA = "0x184AA5F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4AA6130", Offset = "0x4AA4730", VA = "0x184AA6130")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4AA5DC0", Offset = "0x4AA43C0", VA = "0x184AA5DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4AA62F0", Offset = "0x4AA48F0", VA = "0x184AA62F0")]
	public EOOGCKDECDA(T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5F80", Offset = "0x4AA4580", VA = "0x184AA5F80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class OKNHHPCOKDF<THandle, TValue> : IDisposable where THandle : struct, ILGHCGIBOJL where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> DEDILDEDBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> DMJEPOICLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> NOCBIBEBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> NLDLNIMEBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int BBCMEMEAJME;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5B88D60", Offset = "0x5B87360", VA = "0x185B88D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5B89360", Offset = "0x5B87960", VA = "0x185B89360")]
	public OKNHHPCOKDF(Action<TValue> NLDLNIMEBIH, [Optional] Func<TValue> NOCBIBEBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5B88B40", Offset = "0x5B87140", VA = "0x185B88B40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5B88DE0", Offset = "0x5B873E0", VA = "0x185B88DE0")]
	public THandle KMLBEHGKDFG(TValue FKMNCAKIOFK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5B88EC0", Offset = "0x5B874C0", VA = "0x185B88EC0")]
	public bool LOMEBHIDOPA(THandle IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5B88A90", Offset = "0x5B87090", VA = "0x185B88A90")]
	public bool BOHILBMMPDC(THandle IINGFCBPPPE, [Out] TValue FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5B88D90", Offset = "0x5B87390", VA = "0x185B88D90")]
	public TValue JLOHDPKHFGN(THandle IINGFCBPPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5B888F0", Offset = "0x5B86EF0", VA = "0x185B888F0")]
	public bool ANHHLAMACIC(THandle IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5B88E70", Offset = "0x5B87470", VA = "0x185B88E70")]
	private THandle LGLPCPNDEJN(int LEPAEEGOBDO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5B89310", Offset = "0x5B87910", VA = "0x185B89310")]
	private TValue PICMHBILFNN(int LEPAEEGOBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5B89090", Offset = "0x5B87690", VA = "0x185B89090")]
	private void OFBNEOOEOJD(int LEPAEEGOBDO, [In] THandle IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5B88D20", Offset = "0x5B87320", VA = "0x185B88D20")]
	private void FGHCPBDJEOJ(int LEPAEEGOBDO, [In] TValue FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5B88BC0", Offset = "0x5B871C0", VA = "0x185B88BC0")]
	private THandle FFBOENOCOJG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5B88FB0", Offset = "0x5B875B0", VA = "0x185B88FB0")]
	private void NKKLGOIHBFJ(THandle IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5B88E60", Offset = "0x5B87460", VA = "0x185B88E60")]
	private int LCCAGGMDPKB(int FOBPLBPGNLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5B89080", Offset = "0x5B87680", VA = "0x185B89080")]
	private bool NLBDIHGFCEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAA2490", Offset = "0xAA0A90", VA = "0x180AA2490")]
	private void NAHPAJOLBII(THandle IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5B889F0", Offset = "0x5B86FF0", VA = "0x185B889F0")]
	private bool APCODNGEPMO([Out] THandle IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5B890D0", Offset = "0x5B876D0", VA = "0x185B890D0")]
	private bool OJCMFALGGDB([Out] THandle IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5B891B0", Offset = "0x5B877B0", VA = "0x185B891B0")]
	private void OLLJGBNGPBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ILGHCGIBOJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int CIDOMJAOOEB
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
public static class OAPAFHFLNBH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F600", Offset = "0x3F3DC00", VA = "0x183F3F600")]
	public static bool GBIBBHDHADF<T>(this T IINGFCBPPPE, T IBCMCOKAJEM) where T : struct, ILGHCGIBOJL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F5F0", Offset = "0x3F3DBF0", VA = "0x183F3F5F0")]
	public static bool EJBELALFPGK<T>(this T IINGFCBPPPE) where T : struct, ILGHCGIBOJL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x845E970", Offset = "0x845CF70", VA = "0x18845E970")]
	public static string FKDGOFHDFIH(this ILGHCGIBOJL IINGFCBPPPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct DJHKGJKFELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type AKOHDOHMKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> IKPDKBJPCGG;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5682450", Offset = "0x5680A50", VA = "0x185682450")]
	public DJHKGJKFELM(Type PDNFDINGAAI, Span<byte> KJMKIAAPPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3840", Offset = "0x3BE1E40", VA = "0x183BE3840")]
	public static DJHKGJKFELM IEJLJBDKGKG<T>(T FKMNCAKIOFK) where T : struct
	{
		return default(DJHKGJKFELM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x845CDE0", Offset = "0x845B3E0", VA = "0x18845CDE0")]
	public static BKACLCEEHPD HPNBGLLBBBG([In] DJHKGJKFELM FIECNFDCBKN)
	{
		return default(BKACLCEEHPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x845CD60", Offset = "0x845B360", VA = "0x18845CD60")]
	public Enum DMJGGEIKOAO(Type BDFOOGAJCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3810", Offset = "0x3BE1E10", VA = "0x183BE3810")]
	public void ADPGIIFDGLO<T>([In] T FKMNCAKIOFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x845CE60", Offset = "0x845B460", VA = "0x18845CE60")]
	public void NHHHPIEJFEC(Enum FBLLKKIPJDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct BKACLCEEHPD
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct MPFIAIALDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* BGMLAHIEOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* HPDACPPDBNC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type AKOHDOHMKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> IKPDKBJPCGG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FDAAOBNANPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x845CAE0", Offset = "0x845B0E0", VA = "0x18845CAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DPHBLFKNCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x845C8C0", Offset = "0x845AEC0", VA = "0x18845C8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5682450", Offset = "0x5680A50", VA = "0x185682450")]
	public BKACLCEEHPD(Type PDNFDINGAAI, ReadOnlySpan<byte> KJMKIAAPPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B23320", Offset = "0x3B21920", VA = "0x183B23320")]
	public static BKACLCEEHPD IEJLJBDKGKG<T>(T FKMNCAKIOFK) where T : struct
	{
		return default(BKACLCEEHPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x845CAF0", Offset = "0x845B0F0", VA = "0x18845CAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x845C910", Offset = "0x845AF10", VA = "0x18845C910")]
	public object FFBNEPMPKIM(int LEPAEEGOBDO = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct ECMIIEPKBNH
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C07B90", Offset = "0x3C06190", VA = "0x183C07B90")]
	public static NativeArray<T> IEJLJBDKGKG<T>(T FKMNCAKIOFK, bool MGNIHBNKHPG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3C07B60", Offset = "0x3C06160", VA = "0x183C07B60")]
	public static NativeArray<T> FLMIDGBIKKF<T>(T FKMNCAKIOFK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C07C40", Offset = "0x3C06240", VA = "0x183C07C40")]
	public static NativeArray<T> MLDDHDBKNBN<T>(T FKMNCAKIOFK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x845D420", Offset = "0x845BA20", VA = "0x18845D420")]
	public static NativeArray<byte> MLDDHDBKNBN(ReadOnlySpan<byte> FKMNCAKIOFK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x845D370", Offset = "0x845B970", VA = "0x18845D370")]
	public static NativeArray<byte> IEJLJBDKGKG(ReadOnlySpan<byte> FKMNCAKIOFK, bool MGNIHBNKHPG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x845D2F0", Offset = "0x845B8F0", VA = "0x18845D2F0")]
	public unsafe static NativeArray<byte> IEJLJBDKGKG(byte* MOLHMKKLMHL, int FODNOPLPBPI, bool MGNIHBNKHPG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3C07BD0", Offset = "0x3C061D0", VA = "0x183C07BD0")]
	public static NativeArray<T> KBCDDOOGPEK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct NACKEFBEFNN : IEquatable<NACKEFBEFNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int IIBBPLOLFMF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x845E780", Offset = "0x845CD80", VA = "0x18845E780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x845E870", Offset = "0x845CE70", VA = "0x18845E870")]
	public NACKEFBEFNN(Type EHLAHNIAPLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x845E6F0", Offset = "0x845CCF0", VA = "0x18845E6F0")]
	public static NACKEFBEFNN HPNBGLLBBBG(Type EHLAHNIAPLD)
	{
		return default(NACKEFBEFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x24C4E00", Offset = "0x24C3400", VA = "0x1824C4E00", Slot = "4")]
	public bool Equals(NACKEFBEFNN IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x845E660", Offset = "0x845CC60", VA = "0x18845E660", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x845E830", Offset = "0x845CE30", VA = "0x18845E830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DOGJMPEHKIM
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> KPNOCCNCECL;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> ECOFIOCHIII;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x845D160", Offset = "0x845B760", VA = "0x18845D160")]
	static DOGJMPEHKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x845D100", Offset = "0x845B700", VA = "0x18845D100")]
	public static bool KMLBEHGKDFG(Type EHLAHNIAPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x845CF50", Offset = "0x845B550", VA = "0x18845CF50")]
	private static bool KMLBEHGKDFG(Type EHLAHNIAPLD, [Out] int LEPAEEGOBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x845CE70", Offset = "0x845B470", VA = "0x18845CE70")]
	public static int APOMBOKLKAC(Type EHLAHNIAPLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x845CED0", Offset = "0x845B4D0", VA = "0x18845CED0")]
	public static Type JLOHDPKHFGN(int LEPAEEGOBDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct BNEDNAPOHCD<Handle> where Handle : ILGHCGIBOJL, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct FEKEJCLMBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly BNEDNAPOHCD<Handle> KKEHMECDMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int LEPAEEGOBDO;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle JINFGAPMNCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x4F2B320", Offset = "0x4F29920", VA = "0x184F2B320")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4F2B6C0", Offset = "0x4F29CC0", VA = "0x184F2B6C0")]
		public FEKEJCLMBEC(BNEDNAPOHCD<Handle> KKEHMECDMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4F2B060", Offset = "0x4F29660", VA = "0x184F2B060")]
		public JIMCHNAPCBB BPFPEFLIIPC([In] JIMCHNAPCBB CGLIDCMIAEF)
		{
			return default(JIMCHNAPCBB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4F2B210", Offset = "0x4F29810", VA = "0x184F2B210")]
		public bool FPHEKLELJCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4F2B600", Offset = "0x4F29C00", VA = "0x184F2B600")]
		private Handle LHLHDEJNADP(string IFEHDCDCFPK)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct JIMCHNAPCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private FEKEJCLMBEC KHPNOPMFJDN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x54C2090", Offset = "0x54C0690", VA = "0x1854C2090")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x54C21D0", Offset = "0x54C07D0", VA = "0x1854C21D0")]
		public JIMCHNAPCBB(BNEDNAPOHCD<Handle> KKEHMECDMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x54C2190", Offset = "0x54C0790", VA = "0x1854C2190")]
		public bool FPHEKLELJCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x54C20D0", Offset = "0x54C06D0", VA = "0x1854C20D0")]
		public JIMCHNAPCBB DKMCAGKLCHH()
		{
			return default(JIMCHNAPCBB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> LOOMNKECFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> LNINOCOECOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int OPPBEHCHNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int JBLDLMMOJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool PMPDMNGGIKO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KEINBJHGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C830", Offset = "0x6A1AE30", VA = "0x186A1C830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public JIMCHNAPCBB BNBCLANKBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BDF0", Offset = "0x6A1A3F0", VA = "0x186A1BDF0")]
		get
		{
			return default(JIMCHNAPCBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D110", Offset = "0x6A1B710", VA = "0x186A1D110")]
	public BNEDNAPOHCD(int FAFEDGNEKFC, Allocator EKNOCGFFMAE = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BA40", Offset = "0x6A1A040", VA = "0x186A1BA40")]
	public void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2535B90", Offset = "0x2534190", VA = "0x182535B90")]
	public static int LCCAGGMDPKB(int EFGJHINBPCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x32122F0", Offset = "0x32108F0", VA = "0x1832122F0")]
	public static bool CNLEHLBBHBM(int EFGJHINBPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C870", Offset = "0x6A1AE70", VA = "0x186A1C870")]
	public bool LAFIPJAMHCB(int LEPAEEGOBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A1CD10", Offset = "0x6A1B310", VA = "0x186A1CD10")]
	public bool OJOLFNICGAP(Handle IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C4F0", Offset = "0x6A1AAF0", VA = "0x186A1C4F0")]
	public Handle HPMLANDFEFA()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BE90", Offset = "0x6A1A490", VA = "0x186A1BE90")]
	public void GKGMJNJLCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A1CAB0", Offset = "0x6A1B0B0", VA = "0x186A1CAB0")]
	public void NKIJKBJGCFO(Handle IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790")]
	private bool KIENMNDADLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BB60", Offset = "0x6A1A160", VA = "0x186A1BB60")]
	private bool DGFGNKKKENF(int LEPAEEGOBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B810", Offset = "0x6A19E10", VA = "0x186A1B810")]
	private void BADKDGPDDKO([Out] int LEPAEEGOBDO, [Out] int FOBPLBPGNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A1CFD0", Offset = "0x6A1B5D0", VA = "0x186A1CFD0")]
	private void PEDLJLAOCGM(Handle IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BBC0", Offset = "0x6A1A1C0", VA = "0x186A1BBC0")]
	private void DMHOEHDMFAH(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C690", Offset = "0x6A1AC90", VA = "0x186A1C690")]
	private bool IBJCFCDKBOK([Out] int LEPAEEGOBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BC60", Offset = "0x6A1A260", VA = "0x186A1BC60")]
	private static Handle ELLHNAHGKKE(int LEPAEEGOBDO, int FOBPLBPGNLL)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct IPKHHJEFILB<Handle, T> where Handle : ILGHCGIBOJL, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private BNEDNAPOHCD<Handle> DMGOJNOHNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] OCOFOPJAIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> DDLHELKDEIP;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x527B9F0", Offset = "0x5279FF0", VA = "0x18527B9F0")]
	public IPKHHJEFILB(int FAFEDGNEKFC, [Optional] Action<T> DDLHELKDEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x527AD80", Offset = "0x5279380", VA = "0x18527AD80")]
	public void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x527AC00", Offset = "0x5279200", VA = "0x18527AC00")]
	public bool BOHILBMMPDC(Handle IINGFCBPPPE, [Out] T NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x527B700", Offset = "0x5279D00", VA = "0x18527B700")]
	public Handle KMLBEHGKDFG(T NDBJJGOPOFO)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x527B4C0", Offset = "0x5279AC0", VA = "0x18527B4C0")]
	public void IFNLILPACBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x527AFD0", Offset = "0x52795D0", VA = "0x18527AFD0")]
	public void HCDNAOEAAEJ(Handle IINGFCBPPPE, [Out] T FHMNDDJJNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x527AF00", Offset = "0x5279500", VA = "0x18527AF00")]
	public void HCDNAOEAAEJ(Handle IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x527AEA0", Offset = "0x52794A0", VA = "0x18527AEA0")]
	private T DGHIAJCJCEN(int LEPAEEGOBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x527B940", Offset = "0x5279F40", VA = "0x18527B940")]
	private void NHAMKNJJIHA(int AMFBBHDHBAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct BHDJDKBLBGL<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct LJNFNLLPLOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BHDJDKBLBGL<T> OHHBFAGELLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int LEPAEEGOBDO;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x571F970", Offset = "0x571DF70", VA = "0x18571F970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B19E00", Offset = "0x2B18400", VA = "0x182B19E00")]
		public LJNFNLLPLOA(BHDJDKBLBGL<T> OHHBFAGELLA, int LEPAEEGOBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x571F9C0", Offset = "0x571DFC0", VA = "0x18571F9C0")]
		public bool FPHEKLELJCB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HMCPHOGJCHI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public BHDJDKBLBGL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public HMCPHOGJCHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x513CEC0", Offset = "0x513B4C0", VA = "0x18513CEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x513CF60", Offset = "0x513B560", VA = "0x18513CF60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GFCLKPKBFEM : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public BHDJDKBLBGL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public GFCLKPKBFEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFE60", Offset = "0x4FDE460", VA = "0x184FDFE60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFF00", Offset = "0x4FDE500", VA = "0x184FDFF00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] DAJAOHIJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint FKMNCAKIOFK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E0EC70", Offset = "0x5E0D270", VA = "0x185E0EC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ACEIOKDFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6862A00", Offset = "0x6861000", VA = "0x186862A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ODCDDECAKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1A21380", Offset = "0x1A1F980", VA = "0x181A21380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool DAPOINIAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6863130", Offset = "0x6861730", VA = "0x186863130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MFKEEIEHBAI<T> IKPDKBJPCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6862F50", Offset = "0x6861550", VA = "0x186862F50")]
		get
		{
			return default(MFKEEIEHBAI<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6862DF0", Offset = "0x68613F0", VA = "0x186862DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6862890", Offset = "0x6860E90", VA = "0x186862890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6863580", Offset = "0x6861B80", VA = "0x186863580")]
	internal BHDJDKBLBGL(BHDJDKBLBGL<T> OHHBFAGELLA, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68634F0", Offset = "0x6861AF0", VA = "0x1868634F0")]
	private BHDJDKBLBGL(T[] OHHBFAGELLA, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68635A0", Offset = "0x6861BA0", VA = "0x1868635A0")]
	public BHDJDKBLBGL(IEnumerable<T> DMJEPOICLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6863510", Offset = "0x6861B10", VA = "0x186863510")]
	public BHDJDKBLBGL(int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6863140", Offset = "0x6861740", VA = "0x186863140")]
	public int NPHKDLLOMIF(T FKMNCAKIOFK, int NEIBMENBNPA, int FEEKNNBMJMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68629B0", Offset = "0x6860FB0", VA = "0x1868629B0")]
	public void DANEBJKGABM(int FNBJODINBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6862BA0", Offset = "0x68611A0", VA = "0x186862BA0")]
	private void EHBFAKMHFIM(int FNBJODINBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6862D70", Offset = "0x6861370", VA = "0x186862D70")]
	public T[] ENAMBKAGOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x68631C0", Offset = "0x68617C0", VA = "0x1868631C0")]
	public T[] POAGEPOACJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6862B20", Offset = "0x6861120", VA = "0x186862B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6862940", Offset = "0x6860F40", VA = "0x186862940")]
	public void CAOKKMDOOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6862AB0", Offset = "0x68610B0", VA = "0x186862AB0")]
	public LJNFNLLPLOA DKMCAGKLCHH()
	{
		return default(LJNFNLLPLOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6863310", Offset = "0x6861910", VA = "0x186863310", Slot = "5")]
	[IteratorStateMachine(typeof(BHDJDKBLBGL<>.HMCPHOGJCHI))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6863400", Offset = "0x6861A00", VA = "0x186863400", Slot = "6")]
	[IteratorStateMachine(typeof(BHDJDKBLBGL<>.GFCLKPKBFEM))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x68630D0", Offset = "0x68616D0", VA = "0x1868630D0")]
	public static BHDJDKBLBGL<T> MCMBGBFDKPJ(T[] OHHBFAGELLA)
	{
		return default(BHDJDKBLBGL<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6862EC0", Offset = "0x68614C0", VA = "0x186862EC0")]
	public static BHDJDKBLBGL<T> HPNBGLLBBBG(T[] OHHBFAGELLA)
	{
		return default(BHDJDKBLBGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6862A30", Offset = "0x6861030", VA = "0x186862A30")]
	private void DFOHKFKBBKB(int LEPAEEGOBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MGAEBOLPCDD
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3EA2C10", Offset = "0x3EA1210", VA = "0x183EA2C10")]
	public static BHDJDKBLBGL<T> INGJNPGKCMN<T>(this IEnumerable<T> JLOLHCDOILB) where T : class
	{
		return default(BHDJDKBLBGL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class BIGICIGIIKM<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct KHBDAGICACL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private BIGICIGIIKM<T> AHJLBOEGGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int LEPAEEGOBDO;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x55C92C0", Offset = "0x55C78C0", VA = "0x1855C92C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x55C9300", Offset = "0x55C7900", VA = "0x1855C9300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4B2FDA0", Offset = "0x4B2E3A0", VA = "0x184B2FDA0")]
		public KHBDAGICACL(BIGICIGIIKM<T> AHJLBOEGGKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x55C91E0", Offset = "0x55C77E0", VA = "0x1855C91E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x55C9270", Offset = "0x55C7870", VA = "0x1855C9270", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private BHDJDKBLBGL<T> DAJAOHIJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int FODNOPLPBPI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x693E700", Offset = "0x693CD00", VA = "0x18693E700", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5678EB0", Offset = "0x56774B0", VA = "0x185678EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4B87000", Offset = "0x4B85600", VA = "0x184B87000", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int KEINBJHGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x693DE40", Offset = "0x693C440", VA = "0x18693DE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool ODCDDECAKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x693E050", Offset = "0x693C650", VA = "0x18693E050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public MFKEEIEHBAI<T> IKPDKBJPCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x693E170", Offset = "0x693C770", VA = "0x18693E170")]
		get
		{
			return default(MFKEEIEHBAI<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x693E670", Offset = "0x693CC70", VA = "0x18693E670")]
	public BIGICIGIIKM(IEnumerable<T> DMJEPOICLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x693E600", Offset = "0x693CC00", VA = "0x18693E600")]
	public BIGICIGIIKM(int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x693E500", Offset = "0x693CB00", VA = "0x18693E500")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x693E4B0", Offset = "0x693CAB0", VA = "0x18693E4B0")]
	public BHDJDKBLBGL<T> OCFMBLPFGCA()
	{
		return default(BHDJDKBLBGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x693E070", Offset = "0x693C670", VA = "0x18693E070")]
	public void KMLBEHGKDFG(T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x693D6A0", Offset = "0x693BCA0", VA = "0x18693D6A0")]
	private void DANEBJKGABM(int FAALOCBOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x693DE60", Offset = "0x693C460", VA = "0x18693DE60")]
	public void IGDPBMMMPEN(List<T> HIGCIOAFPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x693DFD0", Offset = "0x693C5D0", VA = "0x18693DFD0")]
	public void IGDPBMMMPEN(T[] HIGCIOAFPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x693DAB0", Offset = "0x693C0B0", VA = "0x18693DAB0")]
	public bool HCDNAOEAAEJ(T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x693D700", Offset = "0x693BD00", VA = "0x18693D700")]
	public void DMKEDDAHJJA(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x693D7C0", Offset = "0x693BDC0", VA = "0x18693D7C0")]
	public void GGFKGLICDNA(int BBDNGJCDBPJ, int LGCPIJCGKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x693D6E0", Offset = "0x693BCE0", VA = "0x18693D6E0")]
	public void DGHIAJCJCEN(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x693DB30", Offset = "0x693C130", VA = "0x18693DB30")]
	public void HIPJEKGFENJ(int BBDNGJCDBPJ, int LGCPIJCGKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x693E430", Offset = "0x693CA30", VA = "0x18693E430")]
	public int NPHKDLLOMIF(T FKMNCAKIOFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x576E2B0", Offset = "0x576C8B0", VA = "0x18576E2B0")]
	public bool DIIFLEHJKPJ(T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x693E520", Offset = "0x693CB20", VA = "0x18693E520")]
	public T[] POAGEPOACJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x693D790", Offset = "0x693BD90", VA = "0x18693D790", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x693DD90", Offset = "0x693C390", VA = "0x18693DD90")]
	public static BHDJDKBLBGL<T> HPNBGLLBBBG(BIGICIGIIKM<T> AHJLBOEGGKN)
	{
		return default(BHDJDKBLBGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x693DA30", Offset = "0x693C030", VA = "0x18693DA30", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E78900", Offset = "0x5E76F00", VA = "0x185E78900", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x693E590", Offset = "0x693CB90", VA = "0x18693E590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x693D550", Offset = "0x693BB50", VA = "0x18693D550")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CLJAJEIMLKG(int FKMNCAKIOFK, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x693E200", Offset = "0x693C800", VA = "0x18693E200")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void NJEDECGAFKG(int BBDNGJCDBPJ, int LGCPIJCGKDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IDIKCLILPJM
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3E02DB0", Offset = "0x3E013B0", VA = "0x183E02DB0")]
	public static void CAOKKMDOOLI<T>(this BIGICIGIIKM<T> AHJLBOEGGKN) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct MFKEEIEHBAI<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> DAJAOHIJHHL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x59531C0", Offset = "0x59517C0", VA = "0x1859531C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5952EE0", Offset = "0x59514E0", VA = "0x185952EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5953250", Offset = "0x5951850", VA = "0x185953250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public MFKEEIEHBAI(Span<object> KJMKIAAPPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x59530A0", Offset = "0x59516A0", VA = "0x1859530A0")]
	public MFKEEIEHBAI<T> FFOLPLINDOF(int NEIBMENBNPA)
	{
		return default(MFKEEIEHBAI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5952FC0", Offset = "0x59515C0", VA = "0x185952FC0")]
	public MFKEEIEHBAI<T> FFOLPLINDOF(int NEIBMENBNPA, int FODNOPLPBPI)
	{
		return default(MFKEEIEHBAI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5952F10", Offset = "0x5951510", VA = "0x185952F10")]
	public void CBDEJAGDNOD(MFKEEIEHBAI<T> CJOBIIPNKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5953290", Offset = "0x5951890", VA = "0x185953290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5952F70", Offset = "0x5951570", VA = "0x185952F70", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5953170", Offset = "0x5951770", VA = "0x185953170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LKOMLBJPOKB : IEquatable<LKOMLBJPOKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int EFCGAKGCCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int FEEKNNBMJMM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int IDBKJPJKELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x302EA30", Offset = "0x302D030", VA = "0x18302EA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LOBOJNLEMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int ONIBBDPIEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x845E520", Offset = "0x845CB20", VA = "0x18845E520")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x845E530", Offset = "0x845CB30", VA = "0x18845E530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) DMFBDHIJBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x845E430", Offset = "0x845CA30", VA = "0x18845E430")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
	private LKOMLBJPOKB(int EFCGAKGCCGN, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2B07470", Offset = "0x2B05A70", VA = "0x182B07470")]
	public static LKOMLBJPOKB EOJIEBJHADD(int EFCGAKGCCGN, int FEEKNNBMJMM)
	{
		return default(LKOMLBJPOKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x845E420", Offset = "0x845CA20", VA = "0x18845E420")]
	public static LKOMLBJPOKB DNDJLLIPBDG(int NEIBMENBNPA, int LGCPIJCGKDM)
	{
		return default(LKOMLBJPOKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x845E540", Offset = "0x845CB40", VA = "0x18845E540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x13F29A0", Offset = "0x13F0FA0", VA = "0x1813F29A0", Slot = "4")]
	public bool Equals(LKOMLBJPOKB IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x845E490", Offset = "0x845CA90", VA = "0x18845E490", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x773B770", Offset = "0x7739D70", VA = "0x18773B770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct AFEINPMCCNG<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> DAJAOHIJHHL;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public AFEINPMCCNG(NativeArray<T> DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x53E67A0", Offset = "0x53E4DA0", VA = "0x1853E67A0", Slot = "6")]
	public int Compare(int POMPNNDHCKO, int JLAHKMCOIFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x53E6890", Offset = "0x53E4E90", VA = "0x1853E6890", Slot = "4")]
	public bool Equals(int POMPNNDHCKO, int JLAHKMCOIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x53E6980", Offset = "0x53E4F80", VA = "0x1853E6980", Slot = "5")]
	public int GetHashCode(int POMPNNDHCKO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PKPCEHMCJIN
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3F6CB30", Offset = "0x3F6B130", VA = "0x183F6CB30")]
	public static T[] AILAJGBCJAG<T>(List<T> AHJLBOEGGKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NLICEJCCMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* LKPMANKODBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle PDPIAJGDPMG;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6116590", Offset = "0x6114B90", VA = "0x186116590")]
	public void CKBKAMMKCLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class DGHFJCLIOGC
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2030", Offset = "0x3BD0630", VA = "0x183BD2030")]
	public static NLICEJCCMDF PDNEAGBJDOJ<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> GKLIJOFCGJM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(NLICEJCCMDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2030", Offset = "0x3BD0630", VA = "0x183BD2030")]
	public static UnsafeParallelHashMap<TKey, TValue> KEMNIKCINNM<TKey, TValue>(this NLICEJCCMDF GKLIJOFCGJM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DCMOLHNLCOB
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC960", Offset = "0x3BCAF60", VA = "0x183BCC960")]
	public static int OIFBPLFLBLO<T>(ReadOnlySpan<T> PJHPKPEHEHO, ReadOnlySpan<T> JAOKBPOPMNB, int FODNOPLPBPI) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class EHEDMPLBGMB
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D690", Offset = "0x3C0BC90", VA = "0x183C0D690")]
	public static T ABOOHALKFOP<T>(this NativeArray<byte> JHGKHIGHBBL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D720", Offset = "0x3C0BD20", VA = "0x183C0D720")]
	public static NativeArray<T> KAEPDHGKCNH<T>(this NativeArray<byte> JHGKHIGHBBL, int FEEKNNBMJMM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3C0DBA0", Offset = "0x3C0C1A0", VA = "0x183C0DBA0")]
	public static void OFCKLKGLICM<T>(this NativeList<byte> BDHPLBBJNMG, [In] T FKMNCAKIOFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3C0DB10", Offset = "0x3C0C110", VA = "0x183C0DB10")]
	public static void OFCKLKGLICM<T>(this NativeList<byte> BDHPLBBJNMG, NativeArray<T> FKMNCAKIOFK) where T : struct
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

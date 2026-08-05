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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82A82E0", Offset = "0x82A76E0", VA = "0x1882A82E0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[GJKJDHMBACL]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3E634C0", Offset = "0x3E628C0", VA = "0x183E634C0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[GJKJDHMBACL]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E64730", Offset = "0x3E63B30", VA = "0x183E64730")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E636C0", Offset = "0x3E62AC0", VA = "0x183E636C0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3E63820", Offset = "0x3E62C20", VA = "0x183E63820")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3E66F10", Offset = "0x3E66310", VA = "0x183E66F10")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E66CA0", Offset = "0x3E660A0", VA = "0x183E66CA0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E66E10", Offset = "0x3E66210", VA = "0x183E66E10")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E675C0", Offset = "0x3E669C0", VA = "0x183E675C0")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E64EC0", Offset = "0x3E642C0", VA = "0x183E64EC0")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E64F80", Offset = "0x3E64380", VA = "0x183E64F80")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E653E0", Offset = "0x3E647E0", VA = "0x183E653E0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, NJKCHNHGMDO range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E65420", Offset = "0x3E64820", VA = "0x183E65420")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3E65260", Offset = "0x3E64660", VA = "0x183E65260")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3E63510", Offset = "0x3E62910", VA = "0x183E63510")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3E66D50", Offset = "0x3E66150", VA = "0x183E66D50")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[GJKJDHMBACL]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3E6ECC0", Offset = "0x3E6E0C0", VA = "0x183E6ECC0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E6FBF0", Offset = "0x3E6EFF0", VA = "0x183E6FBF0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E6FC00", Offset = "0x3E6F000", VA = "0x183E6FC00")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E63930", Offset = "0x4E62D30", VA = "0x184E63930")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82A8CD0", Offset = "0x82A80D0", VA = "0x1882A8CD0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82A8D00", Offset = "0x82A8100", VA = "0x1882A8D00")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F240", Offset = "0x3E6E640", VA = "0x183E6F240")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E6EF80", Offset = "0x3E6E380", VA = "0x183E6EF80")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F370", Offset = "0x3E6E770", VA = "0x183E6F370")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F0F0", Offset = "0x3E6E4F0", VA = "0x183E6F0F0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F320", Offset = "0x3E6E720", VA = "0x183E6F320")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F050", Offset = "0x3E6E450", VA = "0x183E6F050")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F690", Offset = "0x3E6EA90", VA = "0x183E6F690")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F4F0", Offset = "0x3E6E8F0", VA = "0x183E6F4F0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E6EFD0", Offset = "0x3E6E3D0", VA = "0x183E6EFD0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E6EF20", Offset = "0x3E6E320", VA = "0x183E6EF20")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E6EF00", Offset = "0x3E6E300", VA = "0x183E6EF00")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E70020", Offset = "0x3E6F420", VA = "0x183E70020")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E6FC50", Offset = "0x3E6F050", VA = "0x183E6FC50")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E70050", Offset = "0x3E6F450", VA = "0x183E70050")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3E70100", Offset = "0x3E6F500", VA = "0x183E70100")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[GJKJDHMBACL]
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
			[Cpp2IlInjected.Address(RVA = "0x4F95AB0", Offset = "0x4F94EB0", VA = "0x184F95AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xEF5D70", Offset = "0xEF5170", VA = "0x180EF5D70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x54DBD50", Offset = "0x54DB150", VA = "0x1854DBD50")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x584D2A0", Offset = "0x584C6A0", VA = "0x18584D2A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x584D130", Offset = "0x584C530", VA = "0x18584D130")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4464FD0", Offset = "0x44643D0", VA = "0x184464FD0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[GJKJDHMBACL]
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
			[Cpp2IlInjected.Address(RVA = "0x58AEBD0", Offset = "0x58ADFD0", VA = "0x1858AEBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x58AEC10", Offset = "0x58AE010", VA = "0x1858AEC10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x54DBD50", Offset = "0x54DB150", VA = "0x1854DBD50")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x58AE830", Offset = "0x58ADC30", VA = "0x1858AE830")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x58AE970", Offset = "0x58ADD70", VA = "0x1858AE970")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x58AEB30", Offset = "0x58ADF30", VA = "0x1858AEB30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x58AE9B0", Offset = "0x58ADDB0", VA = "0x1858AE9B0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[GJKJDHMBACL]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GJKJDHMBACL]
public static class MKIEEHIDHCL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x82A8AE0", Offset = "0x82A7EE0", VA = "0x1882A8AE0")]
	public static JobHandle PFGMGIICECL(this JobHandle HCFCOMCPJPA, JobHandle JOCIBENNGKI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82A8A30", Offset = "0x82A7E30", VA = "0x1882A8A30")]
	public static JobHandle GHDMGOFDFDF(this Span<JobHandle> DHJLFOIFJKG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JKAILAMJDEM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3949150", Offset = "0x3948550", VA = "0x183949150")]
	public static void HBLMHKLDBPD<T>(this T[] LMLCJEFLFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DJFEGDPBALO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A830", Offset = "0x3B09C30", VA = "0x183B0A830")]
	public static NativeKeyValueArrays<TKey, TValue> KEMDOFBPJJF<TKey, TValue>(this Dictionary<TKey, TValue> JAIKDDBMDJG, Allocator KCEIEKBPKNP) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KMPMAJNADLJ
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82A81A0", Offset = "0x82A75A0", VA = "0x1882A81A0")]
	public static void KHAHLIHOODL(this GameObject JBJNKCGNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82A8240", Offset = "0x82A7640", VA = "0x1882A8240")]
	public static void KHAHLIHOODL(this Component FCIHIIPNCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82A8100", Offset = "0x82A7500", VA = "0x1882A8100")]
	public static void KHAHLIHOODL(this ScriptableObject KOLGCPBBDPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HDLKIMCMPGG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82A7A90", Offset = "0x82A6E90", VA = "0x1882A7A90")]
	public static void NFFFKIMBGDJ(this NativeList<byte> KIGLENMLJCP, ReadOnlySpan<byte> MLNMMLOPPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1030", Offset = "0x3CC0430", VA = "0x183CC1030")]
	public static void ECMAEGIGGAE<T>(this NativeList<T> KIGLENMLJCP, T CBMEHPPMEEA, int PPNAGMANAKJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GJBKIIHBFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CB71F0", Offset = "0x3CB65F0", VA = "0x183CB71F0")]
	public static T KMJNDHMDIPC<T>(this ReadOnlySpan<byte> CBMEHPPMEEA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6F50", Offset = "0x3CB6350", VA = "0x183CB6F50")]
	public static T GNEPCFDOJFK<T>(this Span<T> MLNMMLOPPDM, Func<T, bool> FGBMMAJCGMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7070", Offset = "0x3CB6470", VA = "0x183CB7070")]
	public static bool HCEJPJJABBO<T>(this Span<T> MLNMMLOPPDM, Func<T, bool> FGBMMAJCGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6EC0", Offset = "0x3CB62C0", VA = "0x183CB6EC0")]
	public static bool GHNCHEMDCNF<T>(this Span<T> MLNMMLOPPDM, Func<T, bool> FGBMMAJCGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6A60", Offset = "0x3CB5E60", VA = "0x183CB6A60")]
	public static T DIJAEKOIPED<T>([In] this ReadOnlySpan<byte> MLNMMLOPPDM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FE00", Offset = "0x3A3F200", VA = "0x183A3FE00")]
	public static Span<TTo> IACBCBAHIOL<TTo, TFrom>(this Span<TFrom> MLNMMLOPPDM) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FE00", Offset = "0x3A3F200", VA = "0x183A3FE00")]
	public static ReadOnlySpan<TTo> IACBCBAHIOL<TTo, TFrom>(this ReadOnlySpan<TFrom> MLNMMLOPPDM) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FE00", Offset = "0x3A3F200", VA = "0x183A3FE00")]
	public static ReadOnlySpan<TTo> IACBCBAHIOL<TTo>(this ReadOnlySpan<byte> MLNMMLOPPDM) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7100", Offset = "0x3CB6500", VA = "0x183CB7100")]
	public static Span<T> JCIOENFMGMF<T>(this ReadOnlySpan<T> BEOBAPANJHO) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7430", Offset = "0x3CB6830", VA = "0x183CB7430")]
	public static Span<byte> LFFCNKDPJLH<T>([In] this Span<byte> MLNMMLOPPDM, T CBMEHPPMEEA) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82A74E0", Offset = "0x82A68E0", VA = "0x1882A74E0")]
	private static Enum PFGOPGJPHGM([In] ReadOnlySpan<byte> MLNMMLOPPDM, Type MELDCCHPAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82A7470", Offset = "0x82A6870", VA = "0x1882A7470")]
	public static Enum JPIDEKNILOF([In] this Span<byte> MLNMMLOPPDM, Type MELDCCHPAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82A6F60", Offset = "0x82A6360", VA = "0x1882A6F60")]
	public static void IFEHMNPMNAG([In] this Span<byte> MLNMMLOPPDM, Enum JFDJMGGLGMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IPCGMBJGHEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HMGIKGDLPNJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82A7B10", Offset = "0x82A6F10", VA = "0x1882A7B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82A7F90", Offset = "0x82A7390", VA = "0x1882A7F90")]
	[AsyncStateMachine(typeof(HMGIKGDLPNJ))]
	public static void CIDLKIHIAFG(this Task DBAMLJDDEJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PLDJNKOEDOG
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3ED25A0", Offset = "0x3ED19A0", VA = "0x183ED25A0")]
	public static NativeArray<T> EBINOPNIDDJ<T>(this UnsafeList<T> KIGLENMLJCP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2530", Offset = "0x3ED1930", VA = "0x183ED2530")]
	public static NativeArray<T> DGJCJDENODA<T>(this UnsafeList<T> KIGLENMLJCP, bool FJELOMHKCGN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3ED25F0", Offset = "0x3ED19F0", VA = "0x183ED25F0")]
	public static UnsafeList<T> JCIOENFMGMF<T>(this UnsafeList<T> KIGLENMLJCP, Allocator KCEIEKBPKNP) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DMOBOMJDFHK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum LKGGDHAFJCD : short
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
	public struct BDLBPKEINNL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly LKGGDHAFJCD PEENICAIFOP;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x31899A0", Offset = "0x3188DA0", VA = "0x1831899A0")]
		public BDLBPKEINNL(LKGGDHAFJCD PEENICAIFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory AEKNMLHGMDI;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	public static void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82A6960", Offset = "0x82A5D60", VA = "0x1882A6960")]
	static DMOBOMJDFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3956700", Offset = "0x3955B00", VA = "0x183956700")]
	public static BDLBPKEINNL HALPMLLHFHH(LKGGDHAFJCD PEENICAIFOP)
	{
		return default(BDLBPKEINNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	public static void DEMNDHHEPKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ABFBOKGONLA
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCE70", Offset = "0x2CBC270", VA = "0x182CBCE70")]
	public static LGJOCCCMAKC<T1, T2> CJECJKCBNIN<T1, T2>(this (T1, T2) GGKKDFMIENI) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(LGJOCCCMAKC<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x31E3580", Offset = "0x31E2980", VA = "0x1831E3580")]
	public static OFJHEEHAHDE<T1, T2, T3> CJECJKCBNIN<T1, T2, T3>(this (T1, T2, T3) GGKKDFMIENI) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(OFJHEEHAHDE<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LGJOCCCMAKC<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) GGKKDFMIENI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCBD0", Offset = "0x2CBBFD0", VA = "0x182CBCBD0")]
	public LGJOCCCMAKC((T1, T2) GGKKDFMIENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5506DB0", Offset = "0x55061B0", VA = "0x185506DB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OFJHEEHAHDE<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) GGKKDFMIENI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5507080", Offset = "0x5506480", VA = "0x185507080")]
	public OFJHEEHAHDE((T1, T2, T3) GGKKDFMIENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x59ADE70", Offset = "0x59AD270", VA = "0x1859ADE70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MCNKNNLPPLD
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82A8370", Offset = "0x82A7770", VA = "0x1882A8370")]
	public static Range LBMLKIEJHDK(this NJKCHNHGMDO CLIKJBPKKKI)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JKHBJCKLFBI
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct ANELECDMNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int FGKMAAFKCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int BBCNKKJCHEL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x82A6950", Offset = "0x82A5D50", VA = "0x1882A6950")]
		public ANELECDMNJL(int FEMDGHMCLCC, int BBCNKKJCHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82A6940", Offset = "0x82A5D40", VA = "0x1882A6940")]
		public bool BHOBOOOFJDO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82A80B0", Offset = "0x82A74B0", VA = "0x1882A80B0")]
	public static ANELECDMNJL OJAPBOKMMBI(this Range CLIKJBPKKKI)
	{
		return default(ANELECDMNJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FDOGNBDHEOG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle FELIADFOOJH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GINCCADAIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E63920", Offset = "0x4E62D20", VA = "0x184E63920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4E63A30", Offset = "0x4E62E30", VA = "0x184E63A30")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4E63C50", Offset = "0x4E63050", VA = "0x184E63C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4E640C0", Offset = "0x4E634C0", VA = "0x184E640C0")]
	public FDOGNBDHEOG(T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4E63930", Offset = "0x4E62D30", VA = "0x184E63930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class FLFBGEFLFIN<THandle, TValue> : IDisposable where THandle : struct, GFPDGFGKLAD where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> DHJLFOIFJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> EJCCOPPBIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> KNICNPBHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> ONHMMIHDBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int MDJIKIPNCFP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3690", Offset = "0x4EA2A90", VA = "0x184EA3690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3F00", Offset = "0x4EA3300", VA = "0x184EA3F00")]
	public FLFBGEFLFIN(Action<TValue> ONHMMIHDBGD, [Optional] Func<TValue> KNICNPBHDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3610", Offset = "0x4EA2A10", VA = "0x184EA3610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3A20", Offset = "0x4EA2E20", VA = "0x184EA3A20")]
	public THandle KOBMLIBBKBO(TValue CBMEHPPMEEA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3E20", Offset = "0x4EA3220", VA = "0x184EA3E20")]
	public bool ONLDIMNIKII(THandle FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4EA37D0", Offset = "0x4EA2BD0", VA = "0x184EA37D0")]
	public bool KGHIMGHIPAA(THandle FELIADFOOJH, [Out] TValue CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4EA35C0", Offset = "0x4EA29C0", VA = "0x184EA35C0")]
	public TValue DIJAEKOIPED(THandle FELIADFOOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3940", Offset = "0x4EA2D40", VA = "0x184EA3940")]
	public bool KNLAECGHIJO(THandle FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3570", Offset = "0x4EA2970", VA = "0x184EA3570")]
	private THandle AGCANNNPENJ(int NOEININIMIL)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4EA36C0", Offset = "0x4EA2AC0", VA = "0x184EA36C0")]
	private TValue FLBGDLPGKPP(int NOEININIMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3A90", Offset = "0x4EA2E90", VA = "0x184EA3A90")]
	private void MALIGOGCHJA(int NOEININIMIL, [In] THandle FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3D60", Offset = "0x4EA3160", VA = "0x184EA3D60")]
	private void OEOEKNMFCIO(int NOEININIMIL, [In] TValue CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3AD0", Offset = "0x4EA2ED0", VA = "0x184EA3AD0")]
	private THandle MBNCOGEFBAF()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3880", Offset = "0x4EA2C80", VA = "0x184EA3880")]
	private void KNGHDHPAHJP(THandle FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA35B0", Offset = "0x4EA29B0", VA = "0x184EA35B0")]
	private int CGLMGCPMMON(int CDBBOGJDAGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3D50", Offset = "0x4EA3150", VA = "0x184EA3D50")]
	private bool NNEHGCJCAIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA7BA10", Offset = "0xA7AE10", VA = "0x180A7BA10")]
	private void OAEAAAKANEE(THandle FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3D90", Offset = "0x4EA3190", VA = "0x184EA3D90")]
	private bool OKPJAFNHPBN([Out] THandle FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3700", Offset = "0x4EA2B00", VA = "0x184EA3700")]
	private bool JNJNNLFMHCG([Out] THandle FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3C10", Offset = "0x4EA3010", VA = "0x184EA3C10")]
	private void MFMPNGPNIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GFPDGFGKLAD
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JHGBNCFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int CAAKCKNELLL
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
public static class IBPIGNBMFEA
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8720", Offset = "0x3CF7B20", VA = "0x183CF8720")]
	public static bool DACNNNEDLPL<T>(this T FELIADFOOJH, T LHDOHAKINKP) where T : struct, GFPDGFGKLAD
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8740", Offset = "0x3CF7B40", VA = "0x183CF8740")]
	public static bool JDPJAANKGAC<T>(this T FELIADFOOJH) where T : struct, GFPDGFGKLAD
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82A7E80", Offset = "0x82A7280", VA = "0x1882A7E80")]
	public static string GCFMDAKMEND(this GFPDGFGKLAD FELIADFOOJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct GHFLJPPKMHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type KENFJGDACNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> BIBCPNILPDM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x54DBC80", Offset = "0x54DB080", VA = "0x1854DBC80")]
	public GHFLJPPKMHJ(Type DCOOBMOOHJA, Span<byte> MLNMMLOPPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3B20", Offset = "0x3CB2F20", VA = "0x183CB3B20")]
	public static GHFLJPPKMHJ HBEHBGIAPLO<T>(T CBMEHPPMEEA) where T : struct
	{
		return default(GHFLJPPKMHJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x82A69D0", Offset = "0x82A5DD0", VA = "0x1882A69D0")]
	public static MELJAKJGKPD GKKMDDPCKIG([In] GHFLJPPKMHJ GDOMDKGJNLG)
	{
		return default(MELJAKJGKPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x82A6A60", Offset = "0x82A5E60", VA = "0x1882A6A60")]
	public Enum JPIDEKNILOF(Type MELDCCHPAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4420", Offset = "0x3CB3820", VA = "0x183CB4420")]
	public void LFFCNKDPJLH<T>([In] T CBMEHPPMEEA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x82A6A50", Offset = "0x82A5E50", VA = "0x1882A6A50")]
	public void IFEHMNPMNAG(Enum JFDJMGGLGMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct MELJAKJGKPD
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct BDECGPOLIEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* HDOLJNKHEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* ICANJDFAIKK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type KENFJGDACNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> BIBCPNILPDM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EIKKOFKNPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82A85A0", Offset = "0x82A79A0", VA = "0x1882A85A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int JANIMFDKKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x82A85B0", Offset = "0x82A79B0", VA = "0x1882A85B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x54DBC80", Offset = "0x54DB080", VA = "0x1854DBC80")]
	public MELJAKJGKPD(Type DCOOBMOOHJA, ReadOnlySpan<byte> MLNMMLOPPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9560", Offset = "0x3DE8960", VA = "0x183DE9560")]
	public static MELJAKJGKPD HBEHBGIAPLO<T>(T CBMEHPPMEEA) where T : struct
	{
		return default(MELJAKJGKPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x82A8600", Offset = "0x82A7A00", VA = "0x1882A8600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x82A83D0", Offset = "0x82A77D0", VA = "0x1882A83D0")]
	public object IDOOJMLBDGF(int NOEININIMIL = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct HPDOJIIINIG
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CE78F0", Offset = "0x3CE6CF0", VA = "0x183CE78F0")]
	public static NativeArray<T> HBEHBGIAPLO<T>(T CBMEHPPMEEA, bool FJELOMHKCGN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7960", Offset = "0x3CE6D60", VA = "0x183CE7960")]
	public static NativeArray<T> LLLFMBGJIBC<T>(T CBMEHPPMEEA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7930", Offset = "0x3CE6D30", VA = "0x183CE7930")]
	public static NativeArray<T> JMONBKPCOCC<T>(T CBMEHPPMEEA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x82A7DC0", Offset = "0x82A71C0", VA = "0x1882A7DC0")]
	public static NativeArray<byte> JMONBKPCOCC(ReadOnlySpan<byte> CBMEHPPMEEA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x82A7C90", Offset = "0x82A7090", VA = "0x1882A7C90")]
	public static NativeArray<byte> HBEHBGIAPLO(ReadOnlySpan<byte> CBMEHPPMEEA, bool FJELOMHKCGN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x82A7D40", Offset = "0x82A7140", VA = "0x1882A7D40")]
	public unsafe static NativeArray<byte> HBEHBGIAPLO(byte* CCBIEBLEMMH, int COONBEDHJNN, bool FJELOMHKCGN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7880", Offset = "0x3CE6C80", VA = "0x183CE7880")]
	public static NativeArray<T> BOBPMJBGCMC<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MIOIDGJIPJP : IEquatable<MIOIDGJIPJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int HPCICPEJMIB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type GBFFBDIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82A88A0", Offset = "0x82A7CA0", VA = "0x1882A88A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x82A8990", Offset = "0x82A7D90", VA = "0x1882A8990")]
	public MIOIDGJIPJP(Type IIHAKBEOLJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x82A8810", Offset = "0x82A7C10", VA = "0x1882A8810")]
	public static MIOIDGJIPJP GKKMDDPCKIG(Type IIHAKBEOLJD)
	{
		return default(MIOIDGJIPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x247B9F0", Offset = "0x247ADF0", VA = "0x18247B9F0", Slot = "4")]
	public bool Equals(MIOIDGJIPJP LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x82A8780", Offset = "0x82A7B80", VA = "0x1882A8780", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x82A8950", Offset = "0x82A7D50", VA = "0x1882A8950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GHPDGJBGIIN
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> DFCHKNGAEOA;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> OGMPMHJMJJE;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x82A6DD0", Offset = "0x82A61D0", VA = "0x1882A6DD0")]
	static GHPDGJBGIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x82A6D70", Offset = "0x82A6170", VA = "0x1882A6D70")]
	public static bool KOBMLIBBKBO(Type IIHAKBEOLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82A6BC0", Offset = "0x82A5FC0", VA = "0x1882A6BC0")]
	private static bool KOBMLIBBKBO(Type IIHAKBEOLJD, [Out] int NOEININIMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x82A6AE0", Offset = "0x82A5EE0", VA = "0x1882A6AE0")]
	public static int ALLNKMDMIAE(Type IIHAKBEOLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x82A6B40", Offset = "0x82A5F40", VA = "0x1882A6B40")]
	public static Type DIJAEKOIPED(int NOEININIMIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct BDNBHKDPFNM<Handle> where Handle : GFPDGFGKLAD, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct IDOAJOPDCOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly BDNBHKDPFNM<Handle> ONFDFPDBLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int NOEININIMIL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle NDHJNKBBNMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x50BEB30", Offset = "0x50BDF30", VA = "0x1850BEB30")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x50BEE80", Offset = "0x50BE280", VA = "0x1850BEE80")]
		public IDOAJOPDCOF(BDNBHKDPFNM<Handle> ONFDFPDBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x50BEDF0", Offset = "0x50BE1F0", VA = "0x1850BEDF0")]
		public NJFMNFJLGGF EJOLKNBPCJB([In] NJFMNFJLGGF PCKIEOGDDCF)
		{
			return default(NJFMNFJLGGF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x50BEA20", Offset = "0x50BDE20", VA = "0x1850BEA20")]
		public bool BHOBOOOFJDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x50BE8B0", Offset = "0x50BDCB0", VA = "0x1850BE8B0")]
		private Handle BDLEILIJKED(string AFDNIPHJHMO)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct NJFMNFJLGGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private IDOAJOPDCOF NAMBIOCEEBO;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5810C50", Offset = "0x5810050", VA = "0x185810C50")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5810D40", Offset = "0x5810140", VA = "0x185810D40")]
		public NJFMNFJLGGF(BDNBHKDPFNM<Handle> ONFDFPDBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5810BD0", Offset = "0x580FFD0", VA = "0x185810BD0")]
		public bool BHOBOOOFJDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5810CD0", Offset = "0x58100D0", VA = "0x185810CD0")]
		public NJFMNFJLGGF OJAPBOKMMBI()
		{
			return default(NJFMNFJLGGF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> NCICLFAKJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> OICPMBPJPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int CGMOOCAHKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int FGODGFOKNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool KGBKNGMGMFL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DMBGGHINDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x646FE10", Offset = "0x646F210", VA = "0x18646FE10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NJFMNFJLGGF PHEAIBKHFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x646F580", Offset = "0x646E980", VA = "0x18646F580")]
		get
		{
			return default(NJFMNFJLGGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x646FE50", Offset = "0x646F250", VA = "0x18646FE50")]
	public BDNBHKDPFNM(int CGIAPJBPOEG, Allocator KCEIEKBPKNP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x646F0B0", Offset = "0x646E4B0", VA = "0x18646F0B0")]
	public void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x24EC6C0", Offset = "0x24EBAC0", VA = "0x1824EC6C0")]
	public static int CGLMGCPMMON(int EMOJJIEJAKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x31AD1B0", Offset = "0x31AC5B0", VA = "0x1831AD1B0")]
	public static bool FLNANKHJNKC(int EMOJJIEJAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x646EDD0", Offset = "0x646E1D0", VA = "0x18646EDD0")]
	public bool EOHEEGAGCIL(int NOEININIMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x646E610", Offset = "0x646DA10", VA = "0x18646E610")]
	public bool BBKLHABEKBD(Handle FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x646F400", Offset = "0x646E800", VA = "0x18646F400")]
	public Handle JKCHHCFJKCD()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x646F910", Offset = "0x646ED10", VA = "0x18646F910")]
	public void KADBGOLLIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x646FD60", Offset = "0x646F160", VA = "0x18646FD60")]
	public void MLPMKDCIKLB(Handle FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0")]
	private bool CJDHFOCCNPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x646FC90", Offset = "0x646F090", VA = "0x18646FC90")]
	private bool MJHDIKCPBGA(int NOEININIMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x646EA70", Offset = "0x646DE70", VA = "0x18646EA70")]
	private void CNMFNJCKJML([Out] int NOEININIMIL, [Out] int CDBBOGJDAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x646F2B0", Offset = "0x646E6B0", VA = "0x18646F2B0")]
	private void JIFLJNJJNLN(Handle FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x646ED80", Offset = "0x646E180", VA = "0x18646ED80")]
	private void DJILADAGGFN(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x646E910", Offset = "0x646DD10", VA = "0x18646E910")]
	private bool BGLEMNKJHBB([Out] int NOEININIMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x646E830", Offset = "0x646DC30", VA = "0x18646E830")]
	private static Handle BBKNOPCIJEB(int NOEININIMIL, int CDBBOGJDAGP)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct PLHBMHAOBPJ<Handle, T> where Handle : GFPDGFGKLAD, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private BDNBHKDPFNM<Handle> MFCCGIKEDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] EJDCKMAGDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> KKEPNAPJBDG;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B085E0", Offset = "0x5B079E0", VA = "0x185B085E0")]
	public PLHBMHAOBPJ(int CGIAPJBPOEG, [Optional] Action<T> KKEPNAPJBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B07C70", Offset = "0x5B07070", VA = "0x185B07C70")]
	public void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B081E0", Offset = "0x5B075E0", VA = "0x185B081E0")]
	public bool KGHIMGHIPAA(Handle FELIADFOOJH, [Out] T DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B083B0", Offset = "0x5B077B0", VA = "0x185B083B0")]
	public Handle KOBMLIBBKBO(T DEJGDIIDCDN)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B07CF0", Offset = "0x5B070F0", VA = "0x185B07CF0")]
	public void IBBOMBOACBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B07880", Offset = "0x5B06C80", VA = "0x185B07880")]
	public void CBDHBFLGDII(Handle FELIADFOOJH, [Out] T GCLPNKBEOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B07A50", Offset = "0x5B06E50", VA = "0x185B07A50")]
	public void CBDHBFLGDII(Handle FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B08580", Offset = "0x5B07980", VA = "0x185B08580")]
	private T PNJMDCCOGEG(int NOEININIMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B084D0", Offset = "0x5B078D0", VA = "0x185B084D0")]
	private void OIMBIOBIPAN(int PFCIPEMDJNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct LGOFOLFOCNA<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct BCHDACPBPPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private LGOFOLFOCNA<T> LMLCJEFLFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int NOEININIMIL;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x64658C0", Offset = "0x6464CC0", VA = "0x1864658C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AACFB0", Offset = "0x2AAC3B0", VA = "0x182AACFB0")]
		public BCHDACPBPPI(LGOFOLFOCNA<T> LMLCJEFLFMP, int NOEININIMIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6465870", Offset = "0x6464C70", VA = "0x186465870")]
		public bool BHOBOOOFJDO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HEHFKBMJFDG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public LGOFOLFOCNA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public HEHFKBMJFDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4FB31D0", Offset = "0x4FB25D0", VA = "0x184FB31D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3270", Offset = "0x4FB2670", VA = "0x184FB3270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ACBMMBFCPKA : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public LGOFOLFOCNA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public ACBMMBFCPKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5101E10", Offset = "0x5101210", VA = "0x185101E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5101EB0", Offset = "0x51012B0", VA = "0x185101EB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] NGIAGNLBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint CBMEHPPMEEA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5507DC0", Offset = "0x55071C0", VA = "0x185507DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GAGDCLONJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x55081F0", Offset = "0x55075F0", VA = "0x1855081F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AJBBOECICAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x19CEBA0", Offset = "0x19CDFA0", VA = "0x1819CEBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool GHMLPPHOFID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x55081E0", Offset = "0x55075E0", VA = "0x1855081E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JONICLGAPOO<T> BIBCPNILPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5507920", Offset = "0x5506D20", VA = "0x185507920")]
		get
		{
			return default(JONICLGAPOO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5507E50", Offset = "0x5507250", VA = "0x185507E50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5507D10", Offset = "0x5507110", VA = "0x185507D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5508570", Offset = "0x5507970", VA = "0x185508570")]
	internal LGOFOLFOCNA(LGOFOLFOCNA<T> LMLCJEFLFMP, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5508550", Offset = "0x5507950", VA = "0x185508550")]
	private LGOFOLFOCNA(T[] LMLCJEFLFMP, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5508590", Offset = "0x5507990", VA = "0x185508590")]
	public LGOFOLFOCNA(IEnumerable<T> EJCCOPPBIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55088A0", Offset = "0x5507CA0", VA = "0x1855088A0")]
	public LGOFOLFOCNA(int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5508290", Offset = "0x5507690", VA = "0x185508290")]
	public int PENPPLDLEPP(T CBMEHPPMEEA, int FEMDGHMCLCC, int PPNAGMANAKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5507AA0", Offset = "0x5506EA0", VA = "0x185507AA0")]
	public void AHPCPFPNKDL(int AGPDOLPGPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5507B40", Offset = "0x5506F40", VA = "0x185507B40")]
	private void BELMIDKJAGG(int AGPDOLPGPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5507F20", Offset = "0x5507320", VA = "0x185507F20")]
	public T[] FLFEJGNFNHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5507FA0", Offset = "0x55073A0", VA = "0x185507FA0")]
	public T[] GGJDOCMICNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5507DD0", Offset = "0x55071D0", VA = "0x185507DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5508180", Offset = "0x5507580", VA = "0x185508180")]
	public void IOJMEBLJPIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5508220", Offset = "0x5507620", VA = "0x185508220")]
	public BCHDACPBPPI OJAPBOKMMBI()
	{
		return default(BCHDACPBPPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5508390", Offset = "0x5507790", VA = "0x185508390", Slot = "5")]
	[IteratorStateMachine(typeof(LGOFOLFOCNA<>.HEHFKBMJFDG))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5508470", Offset = "0x5507870", VA = "0x185508470", Slot = "6")]
	[IteratorStateMachine(typeof(LGOFOLFOCNA<>.ACBMMBFCPKA))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5507AE0", Offset = "0x5506EE0", VA = "0x185507AE0")]
	public static LGOFOLFOCNA<T> AJPCIIIAIDE(T[] LMLCJEFLFMP)
	{
		return default(LGOFOLFOCNA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x55080F0", Offset = "0x55074F0", VA = "0x1855080F0")]
	public static LGOFOLFOCNA<T> GKKMDDPCKIG(T[] LMLCJEFLFMP)
	{
		return default(LGOFOLFOCNA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5508310", Offset = "0x5507710", VA = "0x185508310")]
	private void PMPDNCIODEB(int NOEININIMIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HDJBEGHBLJP
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0C70", Offset = "0x3CC0070", VA = "0x183CC0C70")]
	public static LGOFOLFOCNA<T> BODEALGKIEK<T>(this IEnumerable<T> LEANJGGPPBP) where T : class
	{
		return default(LGOFOLFOCNA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class PNBCFLDECIA<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct AEGFAPOLAAF : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PNBCFLDECIA<T> KIGLENMLJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int NOEININIMIL;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5108260", Offset = "0x5107660", VA = "0x185108260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x51082A0", Offset = "0x51076A0", VA = "0x1851082A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4A7EDD0", Offset = "0x4A7E1D0", VA = "0x184A7EDD0")]
		public AEGFAPOLAAF(PNBCFLDECIA<T> KIGLENMLJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5108180", Offset = "0x5107580", VA = "0x185108180", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5108210", Offset = "0x5107610", VA = "0x185108210", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LGOFOLFOCNA<T> NGIAGNLBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int COONBEDHJNN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5B20A50", Offset = "0x5B1FE50", VA = "0x185B20A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x546E4C0", Offset = "0x546D8C0", VA = "0x18546E4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4ACE590", Offset = "0x4ACD990", VA = "0x184ACE590", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int DMBGGHINDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5B20810", Offset = "0x5B1FC10", VA = "0x185B20810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool AJBBOECICAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5B207F0", Offset = "0x5B1FBF0", VA = "0x185B207F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public JONICLGAPOO<T> BIBCPNILPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5B1F960", Offset = "0x5B1ED60", VA = "0x185B1F960")]
		get
		{
			return default(JONICLGAPOO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B209D0", Offset = "0x5B1FDD0", VA = "0x185B209D0")]
	public PNBCFLDECIA(IEnumerable<T> EJCCOPPBIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B20960", Offset = "0x5B1FD60", VA = "0x185B20960")]
	public PNBCFLDECIA(int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B20480", Offset = "0x5B1F880", VA = "0x185B20480")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FE10", Offset = "0x5B1F210", VA = "0x185B1FE10")]
	public LGOFOLFOCNA<T> DGLNPEFNDGE()
	{
		return default(LGOFOLFOCNA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5B204A0", Offset = "0x5B1F8A0", VA = "0x185B204A0")]
	public void KOBMLIBBKBO(T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FC10", Offset = "0x5B1F010", VA = "0x185B1FC10")]
	private void AHPCPFPNKDL(int HLNAOJHAMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5B20610", Offset = "0x5B1FA10", VA = "0x185B20610")]
	public void NFFFKIMBGDJ(List<T> FDNGBEMKOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5B20770", Offset = "0x5B1FB70", VA = "0x185B20770")]
	public void NFFFKIMBGDJ(T[] FDNGBEMKOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FC50", Offset = "0x5B1F050", VA = "0x185B1FC50")]
	public bool CBDHBFLGDII(T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5B20590", Offset = "0x5B1F990", VA = "0x185B20590")]
	public void LMGKJCJANMJ(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5B20110", Offset = "0x5B1F510", VA = "0x185B20110")]
	public void GIKCFMCACAF(int PDGHJMBPDAJ, int BBCNKKJCHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5B208A0", Offset = "0x5B1FCA0", VA = "0x185B208A0")]
	public void PNJMDCCOGEG(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FE70", Offset = "0x5B1F270", VA = "0x185B1FE70")]
	public void GCIGCKBILNP(int PDGHJMBPDAJ, int BBCNKKJCHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5B20830", Offset = "0x5B1FC30", VA = "0x185B20830")]
	public int PENPPLDLEPP(T CBMEHPPMEEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x55AC900", Offset = "0x55ABD00", VA = "0x1855AC900")]
	public bool BIEHLJBGGLM(T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5B200A0", Offset = "0x5B1F4A0", VA = "0x185B200A0")]
	public T[] GGJDOCMICNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FE50", Offset = "0x5B1F250", VA = "0x185B1FE50", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5B20360", Offset = "0x5B1F760", VA = "0x185B20360")]
	public static LGOFOLFOCNA<T> GKKMDDPCKIG(PNBCFLDECIA<T> KIGLENMLJCP)
	{
		return default(LGOFOLFOCNA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5B20410", Offset = "0x5B1F810", VA = "0x185B20410", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5B208C0", Offset = "0x5B1FCC0", VA = "0x185B208C0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5B208F0", Offset = "0x5B1FCF0", VA = "0x185B208F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FCC0", Offset = "0x5B1F0C0", VA = "0x185B1FCC0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void DENLECEKGMJ(int CBMEHPPMEEA, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B1F9E0", Offset = "0x5B1EDE0", VA = "0x185B1F9E0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void AEDEMPLJFPG(int PDGHJMBPDAJ, int BBCNKKJCHEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JEEMHOCHBEF
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3D4F530", Offset = "0x3D4E930", VA = "0x183D4F530")]
	public static void IOJMEBLJPIJ<T>(this PNBCFLDECIA<T> KIGLENMLJCP) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct JONICLGAPOO<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> NGIAGNLBILI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5387DE0", Offset = "0x53871E0", VA = "0x185387DE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5387D70", Offset = "0x5387170", VA = "0x185387D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5387DA0", Offset = "0x53871A0", VA = "0x185387DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public JONICLGAPOO(Span<object> MLNMMLOPPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5387FE0", Offset = "0x53873E0", VA = "0x185387FE0")]
	public JONICLGAPOO<T> JCJMBJGAKEL(int FEMDGHMCLCC)
	{
		return default(JONICLGAPOO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5387F00", Offset = "0x5387300", VA = "0x185387F00")]
	public JONICLGAPOO<T> JCJMBJGAKEL(int FEMDGHMCLCC, int COONBEDHJNN)
	{
		return default(JONICLGAPOO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5387D10", Offset = "0x5387110", VA = "0x185387D10")]
	public void AHINEHNEJJM(JONICLGAPOO<T> IMGLICHPAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x53880B0", Offset = "0x53874B0", VA = "0x1853880B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5387E60", Offset = "0x5387260", VA = "0x185387E60", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5387EB0", Offset = "0x53872B0", VA = "0x185387EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NJKCHNHGMDO : IEquatable<NJKCHNHGMDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int FDIDNNCIDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int PPNAGMANAKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JDOCBDPHMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBA0", Offset = "0x2FBAFA0", VA = "0x182FBBBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int MGPFKCMJFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int ILNENIFJGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x82A8C10", Offset = "0x82A8010", VA = "0x1882A8C10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x82A8C30", Offset = "0x82A8030", VA = "0x1882A8C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) FFEHJNFKMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x82A8B20", Offset = "0x82A7F20", VA = "0x1882A8B20")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
	private NJKCHNHGMDO(int FDIDNNCIDHK, int PPNAGMANAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2A98040", Offset = "0x2A97440", VA = "0x182A98040")]
	public static NJKCHNHGMDO LICMJHALBCJ(int FDIDNNCIDHK, int PPNAGMANAKJ)
	{
		return default(NJKCHNHGMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x82A8C20", Offset = "0x82A8020", VA = "0x1882A8C20")]
	public static NJKCHNHGMDO OMKJMEHIMDK(int FEMDGHMCLCC, int BBCNKKJCHEL)
	{
		return default(NJKCHNHGMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x82A8C40", Offset = "0x82A8040", VA = "0x1882A8C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x13A86F0", Offset = "0x13A7AF0", VA = "0x1813A86F0", Slot = "4")]
	public bool Equals(NJKCHNHGMDO LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x82A8B80", Offset = "0x82A7F80", VA = "0x1882A8B80", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7575AB0", Offset = "0x7574EB0", VA = "0x187575AB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct AAAELADMMIG<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> NGIAGNLBILI;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public AAAELADMMIG(NativeArray<T> NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x50FA910", Offset = "0x50F9D10", VA = "0x1850FA910", Slot = "6")]
	public int Compare(int FNBJHADJBNG, int MODFPFNICHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x50FAA00", Offset = "0x50F9E00", VA = "0x1850FAA00", Slot = "4")]
	public bool Equals(int FNBJHADJBNG, int MODFPFNICHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x50FAAF0", Offset = "0x50F9EF0", VA = "0x1850FAAF0", Slot = "5")]
	public int GetHashCode(int FNBJHADJBNG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LOIMOCPFPOD
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3DD1400", Offset = "0x3DD0800", VA = "0x183DD1400")]
	public static T[] NJGDHGDFKNI<T>(List<T> KIGLENMLJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LICAEGJJLCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* GNJHLHIJJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle POLENDBEICD;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D980", Offset = "0x5F8CD80", VA = "0x185F8D980")]
	public void HNJLALOFPOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class AMDDFCMAOML
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3203E80", Offset = "0x3203280", VA = "0x183203E80")]
	public static LICAEGJJLCH OAJDIBBGNPP<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> FKMIOCNPCCJ) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(LICAEGJJLCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3203E80", Offset = "0x3203280", VA = "0x183203E80")]
	public static UnsafeParallelHashMap<TKey, TValue> KBFBGAHABBD<TKey, TValue>(this LICAEGJJLCH FKMIOCNPCCJ) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class ABMGDDGOMME
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x31E3DF0", Offset = "0x31E31F0", VA = "0x1831E3DF0")]
	public static int HPNGKCKBECG<T>(ReadOnlySpan<T> CFHMHELKEDA, ReadOnlySpan<T> OBOMBFLMOKF, int COONBEDHJNN) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FFLLBNPMAKG
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C940", Offset = "0x3C9BD40", VA = "0x183C9C940")]
	public static T LJMMIIDCAAL<T>(this NativeArray<byte> BEOBAPANJHO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C550", Offset = "0x3C9B950", VA = "0x183C9C550")]
	public static NativeArray<T> LAOJLCJAFIH<T>(this NativeArray<byte> BEOBAPANJHO, int PPNAGMANAKJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C3A0", Offset = "0x3C9B7A0", VA = "0x183C9C3A0")]
	public static void FIAMOLGPIJD<T>(this NativeList<byte> MBAOOPBKPLE, [In] T CBMEHPPMEEA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C310", Offset = "0x3C9B710", VA = "0x183C9C310")]
	public static void FIAMOLGPIJD<T>(this NativeList<byte> MBAOOPBKPLE, NativeArray<T> CBMEHPPMEEA) where T : struct
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

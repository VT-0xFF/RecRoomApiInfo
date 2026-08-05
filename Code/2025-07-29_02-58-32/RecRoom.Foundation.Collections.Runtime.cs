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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8300270", Offset = "0x82FEC70", VA = "0x188300270", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[OPFEBGPEKFA]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A320", Offset = "0x3E18D20", VA = "0x183E1A320")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[OPFEBGPEKFA]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B640", Offset = "0x3E1A040", VA = "0x183E1B640")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A570", Offset = "0x3E18F70", VA = "0x183E1A570")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A4A0", Offset = "0x3E18EA0", VA = "0x183E1A4A0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3E24350", Offset = "0x3E22D50", VA = "0x183E24350")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E240E0", Offset = "0x3E22AE0", VA = "0x183E240E0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E24250", Offset = "0x3E22C50", VA = "0x183E24250")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E24A10", Offset = "0x3E23410", VA = "0x183E24A10")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BD90", Offset = "0x3E1A790", VA = "0x183E1BD90")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BD20", Offset = "0x3E1A720", VA = "0x183E1BD20")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C240", Offset = "0x3E1AC40", VA = "0x183E1C240")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, NFNHCBCLHDC range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C280", Offset = "0x3E1AC80", VA = "0x183E1C280")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C0C0", Offset = "0x3E1AAC0", VA = "0x183E1C0C0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A370", Offset = "0x3E18D70", VA = "0x183E1A370")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3E24190", Offset = "0x3E22B90", VA = "0x183E24190")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[OPFEBGPEKFA]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3E25B30", Offset = "0x3E24530", VA = "0x183E25B30")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E26AB0", Offset = "0x3E254B0", VA = "0x183E26AB0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E26A60", Offset = "0x3E25460", VA = "0x183E26A60")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C3B0", Offset = "0x5B1ADB0", VA = "0x185B1C3B0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8300840", Offset = "0x82FF240", VA = "0x188300840")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8300870", Offset = "0x82FF270", VA = "0x188300870")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E26030", Offset = "0x3E24A30", VA = "0x183E26030")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E25E40", Offset = "0x3E24840", VA = "0x183E25E40")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E261E0", Offset = "0x3E24BE0", VA = "0x183E261E0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E25DF0", Offset = "0x3E247F0", VA = "0x183E25DF0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E26190", Offset = "0x3E24B90", VA = "0x183E26190")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E25F90", Offset = "0x3E24990", VA = "0x183E25F90")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E264E0", Offset = "0x3E24EE0", VA = "0x183E264E0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E26340", Offset = "0x3E24D40", VA = "0x183E26340")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E25E90", Offset = "0x3E24890", VA = "0x183E25E90")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E25D90", Offset = "0x3E24790", VA = "0x183E25D90")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E25D70", Offset = "0x3E24770", VA = "0x183E25D70")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E26E90", Offset = "0x3E25890", VA = "0x183E26E90")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E26AC0", Offset = "0x3E254C0", VA = "0x183E26AC0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E26EC0", Offset = "0x3E258C0", VA = "0x183E26EC0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3E26F70", Offset = "0x3E25970", VA = "0x183E26F70")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[OPFEBGPEKFA]
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
			[Cpp2IlInjected.Address(RVA = "0x4FEB6B0", Offset = "0x4FEA0B0", VA = "0x184FEB6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF1BB40", Offset = "0xF1A540", VA = "0x180F1BB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x55762E0", Offset = "0x5574CE0", VA = "0x1855762E0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x58F4080", Offset = "0x58F2A80", VA = "0x1858F4080", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x58F4290", Offset = "0x58F2C90", VA = "0x1858F4290")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x440FDB0", Offset = "0x440E7B0", VA = "0x18440FDB0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[OPFEBGPEKFA]
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
			[Cpp2IlInjected.Address(RVA = "0x4FEB6B0", Offset = "0x4FEA0B0", VA = "0x184FEB6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x594E1A0", Offset = "0x594CBA0", VA = "0x18594E1A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x55762E0", Offset = "0x5574CE0", VA = "0x1855762E0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x594DC20", Offset = "0x594C620", VA = "0x18594DC20")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x594DDD0", Offset = "0x594C7D0", VA = "0x18594DDD0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x594DFA0", Offset = "0x594C9A0", VA = "0x18594DFA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x594DED0", Offset = "0x594C8D0", VA = "0x18594DED0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[OPFEBGPEKFA]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[OPFEBGPEKFA]
public static class NIBGENBEDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83004B0", Offset = "0x82FEEB0", VA = "0x1883004B0")]
	public static JobHandle OKGNFKHAGMO(this JobHandle MLLJGIHINDJ, JobHandle ABNAHAKPDNC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83004F0", Offset = "0x82FEEF0", VA = "0x1883004F0")]
	public static JobHandle OPKFJMGLBOB(this Span<JobHandle> LNOBELKHMFL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IPHKMCHFFDK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x390B320", Offset = "0x3909D20", VA = "0x18390B320")]
	public static void CHLOADNGFGM<T>(this T[] JCEJMKLBKKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FLPLOCKMJCP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C55780", Offset = "0x3C54180", VA = "0x183C55780")]
	public static NativeKeyValueArrays<TKey, TValue> MLIIDDKFCCE<TKey, TValue>(this Dictionary<TKey, TValue> JAGEKIFCALJ, Allocator POJKLAFAMOD) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FHEHFAFKLJE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82FECF0", Offset = "0x82FD6F0", VA = "0x1882FECF0")]
	public static void MANPENHPKPJ(this GameObject CEENMGBCJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82FEC50", Offset = "0x82FD650", VA = "0x1882FEC50")]
	public static void MANPENHPKPJ(this Component BIMLKJFNDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82FED90", Offset = "0x82FD790", VA = "0x1882FED90")]
	public static void MANPENHPKPJ(this ScriptableObject DLHGOLKIKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HCPMDIKGBJG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82FEF40", Offset = "0x82FD940", VA = "0x1882FEF40")]
	public static void MOENCCMOPDH(this NativeList<byte> CKDFPBCCFHO, ReadOnlySpan<byte> MBBNCDGBEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CB10", Offset = "0x3C7B510", VA = "0x183C7CB10")]
	public static void DOHNBFEOIPB<T>(this NativeList<T> CKDFPBCCFHO, T PDKJBMPOMNC, int CDCPIGCEABM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HMDOMIMHBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B520", Offset = "0x3C89F20", VA = "0x183C8B520")]
	public static T KODDKAPBNEI<T>(this ReadOnlySpan<byte> PDKJBMPOMNC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B400", Offset = "0x3C89E00", VA = "0x183C8B400")]
	public static T HANJEKBGBKG<T>(this Span<T> MBBNCDGBEGF, Func<T, bool> OFGJPLHBNGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BC20", Offset = "0x3C8A620", VA = "0x183C8BC20")]
	public static bool OIOIOOMAHOM<T>(this Span<T> MBBNCDGBEGF, Func<T, bool> OFGJPLHBNGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B490", Offset = "0x3C89E90", VA = "0x183C8B490")]
	public static bool IINHIGIGIEE<T>(this Span<T> MBBNCDGBEGF, Func<T, bool> OFGJPLHBNGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C8AE20", Offset = "0x3C89820", VA = "0x183C8AE20")]
	public static T DHBICMHDGKM<T>([In] this ReadOnlySpan<byte> MBBNCDGBEGF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BBE0", Offset = "0x3C8A5E0", VA = "0x183C8BBE0")]
	public static Span<TTo> MKIPBEAFCEO<TTo, TFrom>(this Span<TFrom> MBBNCDGBEGF) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BBE0", Offset = "0x3C8A5E0", VA = "0x183C8BBE0")]
	public static ReadOnlySpan<TTo> MKIPBEAFCEO<TTo, TFrom>(this ReadOnlySpan<TFrom> MBBNCDGBEGF) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BBE0", Offset = "0x3C8A5E0", VA = "0x183C8BBE0")]
	public static ReadOnlySpan<TTo> MKIPBEAFCEO<TTo>(this ReadOnlySpan<byte> MBBNCDGBEGF) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B280", Offset = "0x3C89C80", VA = "0x183C8B280")]
	public static Span<T> GICKIFLNCPB<T>(this ReadOnlySpan<T> GJFINIAHPMG) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B760", Offset = "0x3C8A160", VA = "0x183C8B760")]
	public static Span<byte> MAAIKGLMNNO<T>([In] this Span<byte> MBBNCDGBEGF, T PDKJBMPOMNC) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82FEFC0", Offset = "0x82FD9C0", VA = "0x1882FEFC0")]
	private static Enum GAEJCNCLLCJ([In] ReadOnlySpan<byte> MBBNCDGBEGF, Type OMAGHKKMDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82FFA50", Offset = "0x82FE450", VA = "0x1882FFA50")]
	public static Enum ODIENJKDJGO([In] this Span<byte> MBBNCDGBEGF, Type OMAGHKKMDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82FF570", Offset = "0x82FDF70", VA = "0x1882FF570")]
	public static void MOLJIDKGKCC([In] this Span<byte> MBBNCDGBEGF, Enum IGABBOEDEPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DGFACODMGOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PBFPFKPKFOD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x83008A0", Offset = "0x82FF2A0", VA = "0x1883008A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82FE780", Offset = "0x82FD180", VA = "0x1882FE780")]
	[AsyncStateMachine(typeof(PBFPFKPKFOD))]
	public static void MCAGECPIDEJ(this Task JCAFCJGCHAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class INKBFCMFHPA
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3CD82F0", Offset = "0x3CD6CF0", VA = "0x183CD82F0")]
	public static NativeArray<T> EGDJCLDFCKK<T>(this UnsafeList<T> CKDFPBCCFHO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CD8340", Offset = "0x3CD6D40", VA = "0x183CD8340")]
	public static NativeArray<T> FFFHFCOOOFJ<T>(this UnsafeList<T> CKDFPBCCFHO, bool EGONONGDDCE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CD83B0", Offset = "0x3CD6DB0", VA = "0x183CD83B0")]
	public static UnsafeList<T> GICKIFLNCPB<T>(this UnsafeList<T> CKDFPBCCFHO, Allocator POJKLAFAMOD) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JBDMMBALMJE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum NJCHIOGICJO : short
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
	public struct ICLJHNNCIBI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly NJCHIOGICJO LNBCHJPEENA;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3161120", Offset = "0x315FB20", VA = "0x183161120")]
		public ICLJHNNCIBI(NJCHIOGICJO LNBCHJPEENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory COBMGFAEIIO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	public static void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82FFAE0", Offset = "0x82FE4E0", VA = "0x1882FFAE0")]
	static JBDMMBALMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3915E30", Offset = "0x3914830", VA = "0x183915E30")]
	public static ICLJHNNCIBI GAPLBJNMJLD(NJCHIOGICJO LNBCHJPEENA)
	{
		return default(ICLJHNNCIBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	public static void OLMOCAKNIGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MGCDPOAHCMM
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2C76300", Offset = "0x2C74D00", VA = "0x182C76300")]
	public static OGKIHECBJJF<T1, T2> OANPFDMKFKM<T1, T2>(this (T1, T2) KLBEGKACJOH) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(OGKIHECBJJF<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3D43830", Offset = "0x3D42230", VA = "0x183D43830")]
	public static LNAGMCGOAAI<T1, T2, T3> OANPFDMKFKM<T1, T2, T3>(this (T1, T2, T3) KLBEGKACJOH) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(LNAGMCGOAAI<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OGKIHECBJJF<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) KLBEGKACJOH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2C761D0", Offset = "0x2C74BD0", VA = "0x182C761D0")]
	public OGKIHECBJJF((T1, T2) KLBEGKACJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5A02C90", Offset = "0x5A01690", VA = "0x185A02C90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LNAGMCGOAAI<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) KLBEGKACJOH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x561CEC0", Offset = "0x561B8C0", VA = "0x18561CEC0")]
	public LNAGMCGOAAI((T1, T2, T3) KLBEGKACJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x561CE20", Offset = "0x561B820", VA = "0x18561CE20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LGGCCEACNAB
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8300020", Offset = "0x82FEA20", VA = "0x188300020")]
	public static Range HDBLMFICDMO(this NFNHCBCLHDC OPPACCCPKCM)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JCGFBLGAFNJ
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct IJCOMOPKKIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int DLHGOHOFAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int GFFPHFAAMLF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x82FFAD0", Offset = "0x82FE4D0", VA = "0x1882FFAD0")]
		public IJCOMOPKKIL(int PAEPPOFDFDK, int GFFPHFAAMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82FFAC0", Offset = "0x82FE4C0", VA = "0x1882FFAC0")]
		public bool HBILBACFKKG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82FFB50", Offset = "0x82FE550", VA = "0x1882FFB50")]
	public static IJCOMOPKKIL IBBMHAHFLHH(this Range OPPACCCPKCM)
	{
		return default(IJCOMOPKKIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PIKLFDNGHBJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle OFBHFOIEGGG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PJEEIMDJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C3E0", Offset = "0x5B1ADE0", VA = "0x185B1C3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C250", Offset = "0x5B1AC50", VA = "0x185B1C250")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C6C0", Offset = "0x5B1B0C0", VA = "0x185B1C6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5B1C9E0", Offset = "0x5B1B3E0", VA = "0x185B1C9E0")]
	public PIKLFDNGHBJ(T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5B1C3B0", Offset = "0x5B1ADB0", VA = "0x185B1C3B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class HFFCNCDJFNA<THandle, TValue> : IDisposable where THandle : struct, NDJHBLEGILP where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> LNOBELKHMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> EJKNLPOFFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> GOIKAFBACMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> BFKLNFFBKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int OMJEMEAFHHD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x503DCF0", Offset = "0x503C6F0", VA = "0x18503DCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x503E270", Offset = "0x503CC70", VA = "0x18503E270")]
	public HFFCNCDJFNA(Action<TValue> BFKLNFFBKEJ, [Optional] Func<TValue> GOIKAFBACMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x503D950", Offset = "0x503C350", VA = "0x18503D950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C910", VA = "0x18503DF10")]
	public THandle MJGPLOFFIKO(TValue PDKJBMPOMNC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x503DFD0", Offset = "0x503C9D0", VA = "0x18503DFD0")]
	public bool NHMIPJFACPH(THandle OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x503DDC0", Offset = "0x503C7C0", VA = "0x18503DDC0")]
	public bool KPLGLDIBGLN(THandle OFBHFOIEGGG, [Out] TValue PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x503D900", Offset = "0x503C300", VA = "0x18503D900")]
	public TValue DHBICMHDGKM(THandle OFBHFOIEGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x503D800", Offset = "0x503C200", VA = "0x18503D800")]
	public bool DBCKAGIKEII(THandle OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x503DEC0", Offset = "0x503C8C0", VA = "0x18503DEC0")]
	private THandle LCANCMIDGAF(int FILGHJLFKAL)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x503DE70", Offset = "0x503C870", VA = "0x18503DE70")]
	private TValue LAFPCILEMFP(int FILGHJLFKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x503DF90", Offset = "0x503C990", VA = "0x18503DF90")]
	private void MMNDEHIBMOD(int FILGHJLFKAL, [In] THandle OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x503DB40", Offset = "0x503C540", VA = "0x18503DB40")]
	private void GGPINOLOFNI(int FILGHJLFKAL, [In] TValue PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x503DB80", Offset = "0x503C580", VA = "0x18503DB80")]
	private THandle IFOIOLDECNK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x503E0C0", Offset = "0x503CAC0", VA = "0x18503E0C0")]
	private void OALLCNGHJNK(THandle OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x503D9D0", Offset = "0x503C3D0", VA = "0x18503D9D0")]
	private int ECODJFOGHID(int OHBCMIBMOPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x503DCE0", Offset = "0x503C6E0", VA = "0x18503DCE0")]
	private bool IMKNHJFDJCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA93AE0", Offset = "0xA924E0", VA = "0x180A93AE0")]
	private void LGOJGBILEIO(THandle OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x503DD20", Offset = "0x503C720", VA = "0x18503DD20")]
	private bool KOLIEEGDIGK([Out] THandle OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x503E190", Offset = "0x503CB90", VA = "0x18503E190")]
	private bool OJLLGEJLJBC([Out] THandle OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x503D9E0", Offset = "0x503C3E0", VA = "0x18503D9E0")]
	private void GAAEFNHEOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NDJHBLEGILP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int ODEBCJMJOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int LDLHHBCPGMK
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
public static class GPPEICDOIOG
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C78580", Offset = "0x3C76F80", VA = "0x183C78580")]
	public static bool FADBMFEJCCC<T>(this T OFBHFOIEGGG, T EFNHKCDKOGH) where T : struct, NDJHBLEGILP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C78570", Offset = "0x3C76F70", VA = "0x183C78570")]
	public static bool DKCDJFPCHCL<T>(this T OFBHFOIEGGG) where T : struct, NDJHBLEGILP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82FEE30", Offset = "0x82FD830", VA = "0x1882FEE30")]
	public static string JLOJPOJABLJ(this NDJHBLEGILP OFBHFOIEGGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct ABPGLBAPOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type GGCBJDOCJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> KJBAFKJCJHL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5576340", Offset = "0x5574D40", VA = "0x185576340")]
	public ABPGLBAPOBA(Type OFGKNOAMHMF, Span<byte> MBBNCDGBEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x31BFCD0", Offset = "0x31BE6D0", VA = "0x1831BFCD0")]
	public static ABPGLBAPOBA DIKKIOCKMLC<T>(T PDKJBMPOMNC) where T : struct
	{
		return default(ABPGLBAPOBA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x82FE670", Offset = "0x82FD070", VA = "0x1882FE670")]
	public static EHAAGAELBON LHJBCIIELME([In] ABPGLBAPOBA PENFKHFIGID)
	{
		return default(EHAAGAELBON);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x82FE700", Offset = "0x82FD100", VA = "0x1882FE700")]
	public Enum ODIENJKDJGO(Type OMAGHKKMDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x31C05D0", Offset = "0x31BEFD0", VA = "0x1831C05D0")]
	public void MAAIKGLMNNO<T>([In] T PDKJBMPOMNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x82FE6F0", Offset = "0x82FD0F0", VA = "0x1882FE6F0")]
	public void MOLJIDKGKCC(Enum IGABBOEDEPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct EHAAGAELBON
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct CJIOHKIJOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* MFGLFNMFHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* CFFIKMAEANB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type GGCBJDOCJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> KJBAFKJCJHL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DMAGJKHKJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82FE8A0", Offset = "0x82FD2A0", VA = "0x1882FE8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IKHNOGFCLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x82FE8B0", Offset = "0x82FD2B0", VA = "0x1882FE8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5576340", Offset = "0x5574D40", VA = "0x185576340")]
	public EHAAGAELBON(Type OFGKNOAMHMF, ReadOnlySpan<byte> MBBNCDGBEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3AE0870", Offset = "0x3ADF270", VA = "0x183AE0870")]
	public static EHAAGAELBON DIKKIOCKMLC<T>(T PDKJBMPOMNC) where T : struct
	{
		return default(EHAAGAELBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x82FEAD0", Offset = "0x82FD4D0", VA = "0x1882FEAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x82FE900", Offset = "0x82FD300", VA = "0x1882FE900")]
	public object OAGIFGFOLMN(int FILGHJLFKAL = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct LMGKCMJFOHP
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BF60", Offset = "0x3D4A960", VA = "0x183D4BF60")]
	public static NativeArray<T> DIKKIOCKMLC<T>(T PDKJBMPOMNC, bool EGONONGDDCE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BFD0", Offset = "0x3D4A9D0", VA = "0x183D4BFD0")]
	public static NativeArray<T> GKDIILBAKFK<T>(T PDKJBMPOMNC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BFA0", Offset = "0x3D4A9A0", VA = "0x183D4BFA0")]
	public static NativeArray<T> EAAPICGAAOM<T>(T PDKJBMPOMNC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x83001B0", Offset = "0x82FEBB0", VA = "0x1883001B0")]
	public static NativeArray<byte> EAAPICGAAOM(ReadOnlySpan<byte> PDKJBMPOMNC)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8300100", Offset = "0x82FEB00", VA = "0x188300100")]
	public static NativeArray<byte> DIKKIOCKMLC(ReadOnlySpan<byte> PDKJBMPOMNC, bool EGONONGDDCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8300080", Offset = "0x82FEA80", VA = "0x188300080")]
	public unsafe static NativeArray<byte> DIKKIOCKMLC(byte* LBCOHPIMHLF, int KLLLBPFLPCD, bool EGONONGDDCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C000", Offset = "0x3D4AA00", VA = "0x183D4C000")]
	public static NativeArray<T> MFNPHNGAJMG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct NMMGMOFEDIP : IEquatable<NMMGMOFEDIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int JLDKDBJGAAK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type MMPEDFAPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8300620", Offset = "0x82FF020", VA = "0x188300620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x83007A0", Offset = "0x82FF1A0", VA = "0x1883007A0")]
	public NMMGMOFEDIP(Type AEOGKDPPBBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x83006D0", Offset = "0x82FF0D0", VA = "0x1883006D0")]
	public static NMMGMOFEDIP LHJBCIIELME(Type AEOGKDPPBBE)
	{
		return default(NMMGMOFEDIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x245F210", Offset = "0x245DC10", VA = "0x18245F210", Slot = "4")]
	public bool Equals(NMMGMOFEDIP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x83005A0", Offset = "0x82FEFA0", VA = "0x1883005A0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8300760", Offset = "0x82FF160", VA = "0x188300760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JHJDCIHPKBO
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> AIIKAPADMKM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> FBAODDILCMG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x82FFE90", Offset = "0x82FE890", VA = "0x1882FFE90")]
	static JHJDCIHPKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x82FFE30", Offset = "0x82FE830", VA = "0x1882FFE30")]
	public static bool MJGPLOFFIKO(Type AEOGKDPPBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82FFC80", Offset = "0x82FE680", VA = "0x1882FFC80")]
	private static bool MJGPLOFFIKO(Type AEOGKDPPBBE, [Out] int FILGHJLFKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x82FFC20", Offset = "0x82FE620", VA = "0x1882FFC20")]
	public static int GIIOOEECEFJ(Type AEOGKDPPBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x82FFBA0", Offset = "0x82FE5A0", VA = "0x1882FFBA0")]
	public static Type DHBICMHDGKM(int FILGHJLFKAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct EFNJFBMKGKF<Handle> where Handle : NDJHBLEGILP, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct CFPJLBNOKBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly EFNJFBMKGKF<Handle> FOHPIGBHJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int FILGHJLFKAL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle CPOBGICAJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6A36CD0", Offset = "0x6A356D0", VA = "0x186A36CD0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A36E40", Offset = "0x6A35840", VA = "0x186A36E40")]
		public CFPJLBNOKBK(EFNJFBMKGKF<Handle> FOHPIGBHJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A36AC0", Offset = "0x6A354C0", VA = "0x186A36AC0")]
		public FCPHDKIAHPL MDDJOGPLAFO([In] FCPHDKIAHPL GIGDEGEMDAC)
		{
			return default(FCPHDKIAHPL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A368A0", Offset = "0x6A352A0", VA = "0x186A368A0")]
		public bool HBILBACFKKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A36840", Offset = "0x6A35240", VA = "0x186A36840")]
		private Handle AMNPOFEIJIB(string ONGDPODJNBL)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct FCPHDKIAHPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CFPJLBNOKBK FGJFIKIJHIK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4DF0E90", Offset = "0x4DEF890", VA = "0x184DF0E90")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4DF0F10", Offset = "0x4DEF910", VA = "0x184DF0F10")]
		public FCPHDKIAHPL(EFNJFBMKGKF<Handle> FOHPIGBHJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4DF0DD0", Offset = "0x4DEF7D0", VA = "0x184DF0DD0")]
		public bool HBILBACFKKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4DF0E10", Offset = "0x4DEF810", VA = "0x184DF0E10")]
		public FCPHDKIAHPL IBBMHAHFLHH()
		{
			return default(FCPHDKIAHPL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> GEJHLBEOMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> OGMDNEPLHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int PPMPHGDIHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int CGEMJPIIEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool HKKMDCLBODN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PCFFJHIKDDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4930E20", Offset = "0x492F820", VA = "0x184930E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FCPHDKIAHPL HHFMFKBJOOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4932100", Offset = "0x4930B00", VA = "0x184932100")]
		get
		{
			return default(FCPHDKIAHPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4932800", Offset = "0x4931200", VA = "0x184932800")]
	public EFNJFBMKGKF(int DPLIGPEBLKP, Allocator POJKLAFAMOD = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x49321A0", Offset = "0x4930BA0", VA = "0x1849321A0")]
	public void MEOELJAGFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x24EEEC0", Offset = "0x24ED8C0", VA = "0x1824EEEC0")]
	public static int ECODJFOGHID(int ELPCBPJLJEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x317DAA0", Offset = "0x317C4A0", VA = "0x18317DAA0")]
	public static bool MLBJGKANPOI(int ELPCBPJLJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4931860", Offset = "0x4930260", VA = "0x184931860")]
	public bool JBFGHFIBOHO(int FILGHJLFKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4931020", Offset = "0x492FA20", VA = "0x184931020")]
	public bool DHCMJNFNGNE(Handle OFBHFOIEGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4932660", Offset = "0x4931060", VA = "0x184932660")]
	public Handle PMAGNLMMIDJ()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4931DE0", Offset = "0x49307E0", VA = "0x184931DE0")]
	public void KCDNHBMCGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4932520", Offset = "0x4930F20", VA = "0x184932520")]
	public void PCFJCJDPDFF(Handle OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050")]
	private bool DKFFFFPCACH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4931520", Offset = "0x492FF20", VA = "0x184931520")]
	private bool GGDCGKGNFIM(int FILGHJLFKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4931580", Offset = "0x492FF80", VA = "0x184931580")]
	private void GNMMAEMHEOH([Out] int FILGHJLFKAL, [Out] int OHBCMIBMOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4931380", Offset = "0x492FD80", VA = "0x184931380")]
	private void FMMEKADAEGK(Handle OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x49311E0", Offset = "0x492FBE0", VA = "0x1849311E0")]
	private void EHCHILMGDJG(int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4930CC0", Offset = "0x492F6C0", VA = "0x184930CC0")]
	private bool AFAIMCBDJME([Out] int FILGHJLFKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4932400", Offset = "0x4930E00", VA = "0x184932400")]
	private static Handle MHPIHCBKCLJ(int FILGHJLFKAL, int OHBCMIBMOPM)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct CAAPKKGPCNK<Handle, T> where Handle : NDJHBLEGILP, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private EFNJFBMKGKF<Handle> ABPMHJLKMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] GOBILBPNJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> BGCAFDFCBMJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6959C80", Offset = "0x6958680", VA = "0x186959C80")]
	public CAAPKKGPCNK(int DPLIGPEBLKP, [Optional] Action<T> BGCAFDFCBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6959350", Offset = "0x6957D50", VA = "0x186959350")]
	public void MEOELJAGFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x69592A0", Offset = "0x6957CA0", VA = "0x1869592A0")]
	public bool KPLGLDIBGLN(Handle OFBHFOIEGGG, [Out] T CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x69595A0", Offset = "0x6957FA0", VA = "0x1869595A0")]
	public Handle MJGPLOFFIKO(T CEFJEHJNIAP)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6959710", Offset = "0x6958110", VA = "0x186959710")]
	public void NBPKCCHGFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6959040", Offset = "0x6957A40", VA = "0x186959040")]
	public void BBOPECIHIDA(Handle OFBHFOIEGGG, [Out] T BMJOKJHMKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6958F70", Offset = "0x6957970", VA = "0x186958F70")]
	public void BBOPECIHIDA(Handle OFBHFOIEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x69596B0", Offset = "0x69580B0", VA = "0x1869596B0")]
	private T MLIFBPNJBCL(int FILGHJLFKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6959120", Offset = "0x6957B20", VA = "0x186959120")]
	private void KKBBFBKLAEP(int COCLBCJFAIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct ANIKCFOIBKJ<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct JFMJOMOANOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private ANIKCFOIBKJ<T> JCEJMKLBKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int FILGHJLFKAL;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x53D2F60", Offset = "0x53D1960", VA = "0x1853D2F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A91910", Offset = "0x2A90310", VA = "0x182A91910")]
		public JFMJOMOANOM(ANIKCFOIBKJ<T> JCEJMKLBKKB, int FILGHJLFKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x53D2F10", Offset = "0x53D1910", VA = "0x1853D2F10")]
		public bool HBILBACFKKG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HHAFHODHGPE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public ANIKCFOIBKJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public HHAFHODHGPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5043800", Offset = "0x5042200", VA = "0x185043800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x50438A0", Offset = "0x50422A0", VA = "0x1850438A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BDJMJAEHAMD : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public ANIKCFOIBKJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public BDJMJAEHAMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x64B5760", Offset = "0x64B4160", VA = "0x1864B5760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x64B5800", Offset = "0x64B4200", VA = "0x1864B5800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] GPCDCFCPGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint PDKJBMPOMNC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x53185A0", Offset = "0x5316FA0", VA = "0x1853185A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OFLDDHIICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5317C60", Offset = "0x5316660", VA = "0x185317C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GAMFHFGHFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x19C0830", Offset = "0x19BF230", VA = "0x1819C0830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool JJIGDIBKKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5317EC0", Offset = "0x53168C0", VA = "0x185317EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PMOBBKELFLM<T> KJBAFKJCJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5318390", Offset = "0x5316D90", VA = "0x185318390")]
		get
		{
			return default(PMOBBKELFLM<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x53182C0", Offset = "0x5316CC0", VA = "0x1853182C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5317FD0", Offset = "0x53169D0", VA = "0x185317FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5318830", Offset = "0x5317230", VA = "0x185318830")]
	internal ANIKCFOIBKJ(ANIKCFOIBKJ<T> JCEJMKLBKKB, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5318810", Offset = "0x5317210", VA = "0x185318810")]
	private ANIKCFOIBKJ(T[] JCEJMKLBKKB, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x53188C0", Offset = "0x53172C0", VA = "0x1853188C0")]
	public ANIKCFOIBKJ(IEnumerable<T> EJKNLPOFFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5318850", Offset = "0x5317250", VA = "0x185318850")]
	public ANIKCFOIBKJ(int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5317ED0", Offset = "0x53168D0", VA = "0x185317ED0")]
	public int GLFKDNIBEKK(T PDKJBMPOMNC, int PAEPPOFDFDK, int CDCPIGCEABM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5317BA0", Offset = "0x53165A0", VA = "0x185317BA0")]
	public void BHGMNGMDLBL(int EPAOOHANHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x53180F0", Offset = "0x5316AF0", VA = "0x1853180F0")]
	private void JBNENCNCOAK(int EPAOOHANHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5317F50", Offset = "0x5316950", VA = "0x185317F50")]
	public T[] HDEKOLOBFKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5317CF0", Offset = "0x53166F0", VA = "0x185317CF0")]
	public T[] DGBABFIBOIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5317E40", Offset = "0x5316840", VA = "0x185317E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5317BF0", Offset = "0x53165F0", VA = "0x185317BF0")]
	public void BHJKLINNDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5318080", Offset = "0x5316A80", VA = "0x185318080")]
	public JFMJOMOANOM IBBMHAHFLHH()
	{
		return default(JFMJOMOANOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5318630", Offset = "0x5317030", VA = "0x185318630", Slot = "5")]
	[IteratorStateMachine(typeof(ANIKCFOIBKJ<>.HHAFHODHGPE))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5318720", Offset = "0x5317120", VA = "0x185318720", Slot = "6")]
	[IteratorStateMachine(typeof(ANIKCFOIBKJ<>.BDJMJAEHAMD))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5317C90", Offset = "0x5316690", VA = "0x185317C90")]
	public static ANIKCFOIBKJ<T> CBGPGLENJPG(T[] JCEJMKLBKKB)
	{
		return default(ANIKCFOIBKJ<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5318510", Offset = "0x5316F10", VA = "0x185318510")]
	public static ANIKCFOIBKJ<T> LHJBCIIELME(T[] JCEJMKLBKKB)
	{
		return default(ANIKCFOIBKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x53185B0", Offset = "0x5316FB0", VA = "0x1853185B0")]
	private void NBEADICIOLJ(int FILGHJLFKAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FAGHPKPGGHF
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C404B0", Offset = "0x3C3EEB0", VA = "0x183C404B0")]
	public static ANIKCFOIBKJ<T> FHDFGMMHMMG<T>(this IEnumerable<T> PCAEHLGLCLJ) where T : class
	{
		return default(ANIKCFOIBKJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class MFJNMJILDKH<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct ADNHJJJFJEB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MFJNMJILDKH<T> CKDFPBCCFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int FILGHJLFKAL;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5234C80", Offset = "0x5233680", VA = "0x185234C80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5234CC0", Offset = "0x52336C0", VA = "0x185234CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4A00DE0", Offset = "0x49FF7E0", VA = "0x184A00DE0")]
		public ADNHJJJFJEB(MFJNMJILDKH<T> CKDFPBCCFHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5234BA0", Offset = "0x52335A0", VA = "0x185234BA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5234C30", Offset = "0x5233630", VA = "0x185234C30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private ANIKCFOIBKJ<T> GPCDCFCPGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int KLLLBPFLPCD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x581B1C0", Offset = "0x5819BC0", VA = "0x18581B1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5312430", Offset = "0x5310E30", VA = "0x185312430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4A50E40", Offset = "0x4A4F840", VA = "0x184A50E40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PCFFJHIKDDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5819FE0", Offset = "0x58189E0", VA = "0x185819FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool GAMFHFGHFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x581AE20", Offset = "0x5819820", VA = "0x18581AE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public PMOBBKELFLM<T> KJBAFKJCJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x581A760", Offset = "0x5819160", VA = "0x18581A760")]
		get
		{
			return default(PMOBBKELFLM<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x581B0C0", Offset = "0x5819AC0", VA = "0x18581B0C0")]
	public MFJNMJILDKH(IEnumerable<T> EJKNLPOFFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x581B150", Offset = "0x5819B50", VA = "0x18581B150")]
	public MFJNMJILDKH(int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x581A320", Offset = "0x5818D20", VA = "0x18581A320")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x581A3E0", Offset = "0x5818DE0", VA = "0x18581A3E0")]
	public ANIKCFOIBKJ<T> FAPHEDLOGFD()
	{
		return default(ANIKCFOIBKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x581AB10", Offset = "0x5819510", VA = "0x18581AB10")]
	public void MJGPLOFFIKO(T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x581A2E0", Offset = "0x5818CE0", VA = "0x18581A2E0")]
	private void BHGMNGMDLBL(int MOCOCCPAPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x581AC30", Offset = "0x5819630", VA = "0x18581AC30")]
	public void MOENCCMOPDH(List<T> DFFANDBINOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x581ADA0", Offset = "0x58197A0", VA = "0x18581ADA0")]
	public void MOENCCMOPDH(T[] DFFANDBINOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x581A260", Offset = "0x5818C60", VA = "0x18581A260")]
	public bool BBOPECIHIDA(T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x581AE40", Offset = "0x5819840", VA = "0x18581AE40")]
	public void PLNHHEMACDC(int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x581A8A0", Offset = "0x58192A0", VA = "0x18581A8A0")]
	public void LMIBHFJEMNK(int AACOEMGPHAE, int GFFPHFAAMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x581AC10", Offset = "0x5819610", VA = "0x18581AC10")]
	public void MLIFBPNJBCL(int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x581A000", Offset = "0x5818A00", VA = "0x18581A000")]
	public void ALDLIHHJDGD(int AACOEMGPHAE, int GFFPHFAAMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x581A430", Offset = "0x5818E30", VA = "0x18581A430")]
	public int GLFKDNIBEKK(T PDKJBMPOMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5653560", Offset = "0x5651F60", VA = "0x185653560")]
	public bool JBFDGOBACLK(T PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x581A340", Offset = "0x5818D40", VA = "0x18581A340")]
	public T[] DGBABFIBOIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x581A3B0", Offset = "0x5818DB0", VA = "0x18581A3B0", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x581A7F0", Offset = "0x58191F0", VA = "0x18581A7F0")]
	public static ANIKCFOIBKJ<T> LHJBCIIELME(MFJNMJILDKH<T> CKDFPBCCFHO)
	{
		return default(ANIKCFOIBKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x581A4B0", Offset = "0x5818EB0", VA = "0x18581A4B0", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x581B020", Offset = "0x5819A20", VA = "0x18581B020", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x581B050", Offset = "0x5819A50", VA = "0x18581B050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x581AED0", Offset = "0x58198D0", VA = "0x18581AED0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void PMOFFILGBOJ(int PDKJBMPOMNC, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x581A530", Offset = "0x5818F30", VA = "0x18581A530")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void HEKNGBCILAB(int AACOEMGPHAE, int GFFPHFAAMLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JOGPCMOGIGG
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3D061C0", Offset = "0x3D04BC0", VA = "0x183D061C0")]
	public static void BHJKLINNDAB<T>(this MFJNMJILDKH<T> CKDFPBCCFHO) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct PMOBBKELFLM<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> GPCDCFCPGFK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5B56710", Offset = "0x5B55110", VA = "0x185B56710")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B566E0", Offset = "0x5B550E0", VA = "0x185B566E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5B567A0", Offset = "0x5B551A0", VA = "0x185B567A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1486E20", Offset = "0x1485820", VA = "0x181486E20")]
	public PMOBBKELFLM(Span<object> MBBNCDGBEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5B568C0", Offset = "0x5B552C0", VA = "0x185B568C0")]
	public PMOBBKELFLM<T> NJKFMAJCCLL(int PAEPPOFDFDK)
	{
		return default(PMOBBKELFLM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5B567E0", Offset = "0x5B551E0", VA = "0x185B567E0")]
	public PMOBBKELFLM<T> NJKFMAJCCLL(int PAEPPOFDFDK, int KLLLBPFLPCD)
	{
		return default(PMOBBKELFLM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5B565E0", Offset = "0x5B54FE0", VA = "0x185B565E0")]
	public void ACFCGPIAPCE(PMOBBKELFLM<T> IJNILMDHBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5B56990", Offset = "0x5B55390", VA = "0x185B56990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5B56640", Offset = "0x5B55040", VA = "0x185B56640", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5B56690", Offset = "0x5B55090", VA = "0x185B56690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NFNHCBCLHDC : IEquatable<NFNHCBCLHDC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int KIOPHNHDMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int CDCPIGCEABM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MPEIPFAGFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2FA52F0", Offset = "0x2FA3CF0", VA = "0x182FA52F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int OHHEPHPCBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int LCNCPIGDBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x83003B0", Offset = "0x82FEDB0", VA = "0x1883003B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8300300", Offset = "0x82FED00", VA = "0x188300300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) PBMNDACGMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x83003C0", Offset = "0x82FEDC0", VA = "0x1883003C0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
	private NFNHCBCLHDC(int KIOPHNHDMKE, int CDCPIGCEABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D820", Offset = "0x2A7C220", VA = "0x182A7D820")]
	public static NFNHCBCLHDC MCILEBILMAO(int KIOPHNHDMKE, int CDCPIGCEABM)
	{
		return default(NFNHCBCLHDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x83003A0", Offset = "0x82FEDA0", VA = "0x1883003A0")]
	public static NFNHCBCLHDC FIBLIDFEAIO(int PAEPPOFDFDK, int GFFPHFAAMLF)
	{
		return default(NFNHCBCLHDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8300420", Offset = "0x82FEE20", VA = "0x188300420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x13BE6C0", Offset = "0x13BD0C0", VA = "0x1813BE6C0", Slot = "4")]
	public bool Equals(NFNHCBCLHDC EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x8300310", Offset = "0x82FED10", VA = "0x188300310", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x75DDE00", Offset = "0x75DC800", VA = "0x1875DDE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct OPEIMBMOJHB<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> GPCDCFCPGFK;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1486E20", Offset = "0x1485820", VA = "0x181486E20")]
	public OPEIMBMOJHB(NativeArray<T> GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5A370A0", Offset = "0x5A35AA0", VA = "0x185A370A0", Slot = "6")]
	public int Compare(int IECENJOJFJH, int OFOCBNJJIJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5A37190", Offset = "0x5A35B90", VA = "0x185A37190", Slot = "4")]
	public bool Equals(int IECENJOJFJH, int OFOCBNJJIJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5A37280", Offset = "0x5A35C80", VA = "0x185A37280", Slot = "5")]
	public int GetHashCode(int IECENJOJFJH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CKOGDLKOPKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3A6BA80", Offset = "0x3A6A480", VA = "0x183A6BA80")]
	public static T[] DLAOOIHFBFF<T>(List<T> CKDFPBCCFHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct APEJONNKNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* ONLJPGJGAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle JLEJKMDCOAG;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC480", Offset = "0x5FBAE80", VA = "0x185FBC480")]
	public void MEOELJAGFLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GDDLJMNIAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C63290", Offset = "0x3C61C90", VA = "0x183C63290")]
	public static APEJONNKNDJ IJKKOBMDEMK<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> EKGECJENMCF) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(APEJONNKNDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C63290", Offset = "0x3C61C90", VA = "0x183C63290")]
	public static UnsafeParallelHashMap<TKey, TValue> JNEOPKPNJMK<TKey, TValue>(this APEJONNKNDJ EKGECJENMCF) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class FMIAMNHKAKD
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3C55EE0", Offset = "0x3C548E0", VA = "0x183C55EE0")]
	public static int MEMJJFKLDJM<T>(ReadOnlySpan<T> OEGDKJLNPAF, ReadOnlySpan<T> IBIMDBBGBAI, int KLLLBPFLPCD) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class APIFHPLKHIE
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x31CECC0", Offset = "0x31CD6C0", VA = "0x1831CECC0")]
	public static T KBLLOONDKCE<T>(this NativeArray<byte> GJFINIAHPMG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x31CE8D0", Offset = "0x31CD2D0", VA = "0x1831CE8D0")]
	public static NativeArray<T> FCMIPJBEKJO<T>(this NativeArray<byte> GJFINIAHPMG, int CDCPIGCEABM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x31CEDE0", Offset = "0x31CD7E0", VA = "0x1831CEDE0")]
	public static void PHAKNALBEIB<T>(this NativeList<byte> ADMLFNMDFNO, [In] T PDKJBMPOMNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x31CED50", Offset = "0x31CD750", VA = "0x1831CED50")]
	public static void PHAKNALBEIB<T>(this NativeList<byte> ADMLFNMDFNO, NativeArray<T> PDKJBMPOMNC) where T : struct
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

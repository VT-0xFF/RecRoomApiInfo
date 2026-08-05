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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7909DC0", Offset = "0x79087C0", VA = "0x187909DC0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[NBDJNKBGAEA]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x37F3BF0", Offset = "0x37F25F0", VA = "0x1837F3BF0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[NBDJNKBGAEA]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x37F4AA0", Offset = "0x37F34A0", VA = "0x1837F4AA0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37F3CC0", Offset = "0x37F26C0", VA = "0x1837F3CC0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x37F3FC0", Offset = "0x37F29C0", VA = "0x1837F3FC0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x37FE420", Offset = "0x37FCE20", VA = "0x1837FE420")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x37FE130", Offset = "0x37FCB30", VA = "0x1837FE130")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x37FE2E0", Offset = "0x37FCCE0", VA = "0x1837FE2E0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37FEB10", Offset = "0x37FD510", VA = "0x1837FEB10")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37F50A0", Offset = "0x37F3AA0", VA = "0x1837F50A0")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x37F5180", Offset = "0x37F3B80", VA = "0x1837F5180")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37F5690", Offset = "0x37F4090", VA = "0x1837F5690")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, FOFEFKICODD range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37F56D0", Offset = "0x37F40D0", VA = "0x1837F56D0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x37F5500", Offset = "0x37F3F00", VA = "0x1837F5500")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x37FE220", Offset = "0x37FCC20", VA = "0x1837FE220")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[NBDJNKBGAEA]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37FEC00", Offset = "0x37FD600", VA = "0x1837FEC00")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3800BA0", Offset = "0x37FF5A0", VA = "0x183800BA0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3800B50", Offset = "0x37FF550", VA = "0x183800B50")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD880", Offset = "0x4DFC280", VA = "0x184DFD880")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x790A360", Offset = "0x7908D60", VA = "0x18790A360")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x790A390", Offset = "0x7908D90", VA = "0x18790A390")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37FFE50", Offset = "0x37FE850", VA = "0x1837FFE50")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x37FFE00", Offset = "0x37FE800", VA = "0x1837FFE00")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37FFE80", Offset = "0x37FE880", VA = "0x1837FFE80")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x38003A0", Offset = "0x37FEDA0", VA = "0x1838003A0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3800350", Offset = "0x37FED50", VA = "0x183800350")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3800230", Offset = "0x37FEC30", VA = "0x183800230")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3800590", Offset = "0x37FEF90", VA = "0x183800590")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3800420", Offset = "0x37FEE20", VA = "0x183800420")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38001B0", Offset = "0x37FEBB0", VA = "0x1838001B0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x37FFDA0", Offset = "0x37FE7A0", VA = "0x1837FFDA0")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37FFD80", Offset = "0x37FE780", VA = "0x1837FFD80")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3800F80", Offset = "0x37FF980", VA = "0x183800F80")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3800BB0", Offset = "0x37FF5B0", VA = "0x183800BB0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3800FB0", Offset = "0x37FF9B0", VA = "0x183800FB0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3801070", Offset = "0x37FFA70", VA = "0x183801070")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[NBDJNKBGAEA]
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
			[Cpp2IlInjected.Address(RVA = "0x4927860", Offset = "0x4926260", VA = "0x184927860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD409B0", Offset = "0xD3F3B0", VA = "0x180D409B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xEC09F0", Offset = "0xEBF3F0", VA = "0x180EC09F0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA02F0", Offset = "0x4E9ECF0", VA = "0x184EA02F0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x51CF840", Offset = "0x51CE240", VA = "0x1851CF840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x51CF5A0", Offset = "0x51CDFA0", VA = "0x1851CF5A0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BCDF90", Offset = "0x3BCC990", VA = "0x183BCDF90")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[NBDJNKBGAEA]
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
			[Cpp2IlInjected.Address(RVA = "0x5229B20", Offset = "0x5228520", VA = "0x185229B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5229B60", Offset = "0x5228560", VA = "0x185229B60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xEC09F0", Offset = "0xEBF3F0", VA = "0x180EC09F0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4EA02F0", Offset = "0x4E9ECF0", VA = "0x184EA02F0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5229780", Offset = "0x5228180", VA = "0x185229780")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x52298C0", Offset = "0x52282C0", VA = "0x1852298C0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5229A80", Offset = "0x5228480", VA = "0x185229A80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x52299C0", Offset = "0x52283C0", VA = "0x1852299C0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NBDJNKBGAEA]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NBDJNKBGAEA]
public static class IIOCKJLECGI
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7909860", Offset = "0x7908260", VA = "0x187909860")]
	public static JobHandle OPMIPDGDIPI(this JobHandle KEEADJCBJCP, JobHandle LKKBJAKGIGL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x79098A0", Offset = "0x79082A0", VA = "0x1879098A0")]
	public static JobHandle PPLOMMKPOOD(this Span<JobHandle> MECHNCGCANG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OMIKFAOKMLH
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3824D80", Offset = "0x3823780", VA = "0x183824D80")]
	public static NativeKeyValueArrays<TKey, TValue> EFALHAHFHNI<TKey, TValue>(this Dictionary<TKey, TValue> LCGNOGHMHOC, Allocator DDBBFOCJEFL) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JPNINCHCNNO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7909C10", Offset = "0x7908610", VA = "0x187909C10")]
	public static void DLCAMAJPBKH(this GameObject IHDAMAGFMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7909B70", Offset = "0x7908570", VA = "0x187909B70")]
	public static void DLCAMAJPBKH(this Component ANAFMCCHAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7909AD0", Offset = "0x79084D0", VA = "0x187909AD0")]
	public static void DLCAMAJPBKH(this ScriptableObject JODKDOFLJEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NGLABGOOJGO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x790A2E0", Offset = "0x7908CE0", VA = "0x18790A2E0")]
	public static void FAPPIOKLKNF(this NativeList<byte> FMFEHIEKOMI, ReadOnlySpan<byte> LHMOIMCENOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37EBE70", Offset = "0x37EA870", VA = "0x1837EBE70")]
	public static void FBKBGDMKPML<T>(this NativeList<T> FMFEHIEKOMI, T PPJFMHBDGNA, int PGJKBFGEJNK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BJBKFGCFIHE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33B7A70", Offset = "0x33B6470", VA = "0x1833B7A70")]
	public static T NCBNEFKAMLH<T>(this ReadOnlySpan<byte> PPJFMHBDGNA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33B7D60", Offset = "0x33B6760", VA = "0x1833B7D60")]
	public static T OBHJDKDBIFE<T>(this Span<T> LHMOIMCENOO, Func<T, bool> CIGJDFGAMAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33B7CB0", Offset = "0x33B66B0", VA = "0x1833B7CB0")]
	public static bool NOMMEILPFHJ<T>(this Span<T> LHMOIMCENOO, Func<T, bool> CIGJDFGAMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x33B78C0", Offset = "0x33B62C0", VA = "0x1833B78C0")]
	public static bool LEPHPCMDGGI<T>(this Span<T> LHMOIMCENOO, Func<T, bool> CIGJDFGAMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x33B7320", Offset = "0x33B5D20", VA = "0x1833B7320")]
	public static T BLCCCENAIKI<T>([In] this ReadOnlySpan<byte> LHMOIMCENOO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x33B7870", Offset = "0x33B6270", VA = "0x1833B7870")]
	public static Span<TTo> IELHNNEPHID<TTo, TFrom>(this Span<TFrom> LHMOIMCENOO) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x33B7870", Offset = "0x33B6270", VA = "0x1833B7870")]
	public static ReadOnlySpan<TTo> IELHNNEPHID<TTo, TFrom>(this ReadOnlySpan<TFrom> LHMOIMCENOO) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x33B7870", Offset = "0x33B6270", VA = "0x1833B7870")]
	public static ReadOnlySpan<TTo> IELHNNEPHID<TTo>(this ReadOnlySpan<byte> LHMOIMCENOO) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x33B7970", Offset = "0x33B6370", VA = "0x1833B7970")]
	public static Span<T> MBAELHOLOJC<T>(this ReadOnlySpan<T> KKMIKMKCMKE) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x33B7EC0", Offset = "0x33B68C0", VA = "0x1833B7EC0")]
	public static Span<byte> PMHEFKOCJCJ<T>([In] this Span<byte> LHMOIMCENOO, T PPJFMHBDGNA) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7908490", Offset = "0x7906E90", VA = "0x187908490")]
	private static Enum HFKBPNOLLNK([In] ReadOnlySpan<byte> LHMOIMCENOO, Type CFBHLGDMOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7908F10", Offset = "0x7907910", VA = "0x187908F10")]
	public static Enum KPIKBHKLBII([In] this Span<byte> LHMOIMCENOO, Type CFBHLGDMOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7908A30", Offset = "0x7907430", VA = "0x187908A30")]
	public static void KPELJKECNIJ([In] this Span<byte> LHMOIMCENOO, Enum PMMCFCOBIDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PILEOFALDIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JBDGADONPCK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7909950", Offset = "0x7908350", VA = "0x187909950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A10", Offset = "0x9F8410", VA = "0x1809F9A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x790A3C0", Offset = "0x7908DC0", VA = "0x18790A3C0")]
	[AsyncStateMachine(typeof(JBDGADONPCK))]
	public static void CBPAPCPJHHG(this Task PPOLMDFNGFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NAOBDLMPINJ
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37DF5C0", Offset = "0x37DDFC0", VA = "0x1837DF5C0")]
	public static NativeArray<T> DIIEMIIKEMA<T>(this UnsafeList<T> FMFEHIEKOMI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37DF6D0", Offset = "0x37DE0D0", VA = "0x1837DF6D0")]
	public static NativeArray<T> OKGKJNNKKIC<T>(this UnsafeList<T> FMFEHIEKOMI, bool BBNIOJNCAEJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x37DF620", Offset = "0x37DE020", VA = "0x1837DF620")]
	public static UnsafeList<T> MBAELHOLOJC<T>(this UnsafeList<T> FMFEHIEKOMI, Allocator DDBBFOCJEFL) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DFMBNPNJMHG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum HBAKNNODJLG : short
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

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct HBBBLLHGINH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly HBAKNNODJLG NJBPFCDJFGD;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3920", Offset = "0x2CC2320", VA = "0x182CC3920")]
		public HBBBLLHGINH(HBAKNNODJLG NJBPFCDJFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory PEBMNBDINBA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	public static void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7908FA0", Offset = "0x79079A0", VA = "0x187908FA0")]
	static DFMBNPNJMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x32E5F10", Offset = "0x32E4910", VA = "0x1832E5F10")]
	public static HBBBLLHGINH OLPIOACJLKA(HBAKNNODJLG NJBPFCDJFGD)
	{
		return default(HBBBLLHGINH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	public static void HCJACFKEGIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BCJBCHNBIFD
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x33AE570", Offset = "0x33ACF70", VA = "0x1833AE570")]
	public static HOKFIHGKLMH<T1, T2> CCHHHHFCHFI<T1, T2>(this (T1, T2) CAHPKFIIOEM) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(HOKFIHGKLMH<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x33AE590", Offset = "0x33ACF90", VA = "0x1833AE590")]
	public static CJBJDEOGOOG<T1, T2, T3> CCHHHHFCHFI<T1, T2, T3>(this (T1, T2, T3) CAHPKFIIOEM) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(CJBJDEOGOOG<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HOKFIHGKLMH<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) CAHPKFIIOEM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4978FD0", Offset = "0x49779D0", VA = "0x184978FD0")]
	public HOKFIHGKLMH((T1, T2) CAHPKFIIOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4978F60", Offset = "0x4977960", VA = "0x184978F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CJBJDEOGOOG<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) CAHPKFIIOEM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4978FE0", Offset = "0x49779E0", VA = "0x184978FE0")]
	public CJBJDEOGOOG((T1, T2, T3) CAHPKFIIOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x657A710", Offset = "0x6579110", VA = "0x18657A710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AFIOFEJFGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7908140", Offset = "0x7906B40", VA = "0x187908140")]
	public static Range AKJOJNNCJBL(this FOFEFKICODD BAKNOLAPDBG)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BCPBOAIJHLK
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct CJBOKHFPLGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int DBEGJIFAOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int BKICKHECIBO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7908F90", Offset = "0x7907990", VA = "0x187908F90")]
		public CJBOKHFPLGD(int GJCFLJFIOAP, int BKICKHECIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7908F80", Offset = "0x7907980", VA = "0x187908F80")]
		public bool FMNODPIACON()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x79081A0", Offset = "0x7906BA0", VA = "0x1879081A0")]
	public static CJBOKHFPLGD KCFKLFFNEEA(this Range BAKNOLAPDBG)
	{
		return default(CJBOKHFPLGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KENKEDPIIHE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle ENNBIIMEOCP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CMHKAJBCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD420", Offset = "0x4DFBE20", VA = "0x184DFD420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD970", Offset = "0x4DFC370", VA = "0x184DFD970")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4DFD430", Offset = "0x4DFBE30", VA = "0x184DFD430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4DFDB30", Offset = "0x4DFC530", VA = "0x184DFDB30")]
	public KENKEDPIIHE(T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4DFD880", Offset = "0x4DFC280", VA = "0x184DFD880", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class MLMAEEAINPM<THandle, TValue> : IDisposable where THandle : struct, KPKOEBEHBFB where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> MECHNCGCANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> IOMEFCNHNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> INAFMMLIFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> JJMADEJBFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int JMIBAHKHMAC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x513A480", Offset = "0x5138E80", VA = "0x18513A480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x513ACA0", Offset = "0x51396A0", VA = "0x18513ACA0")]
	public MLMAEEAINPM(Action<TValue> JJMADEJBFIJ, [Optional] Func<TValue> INAFMMLIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x513A080", Offset = "0x5138A80", VA = "0x18513A080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x513A640", Offset = "0x5139040", VA = "0x18513A640")]
	public THandle HEHCILJMFIP(TValue PPJFMHBDGNA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x513A6E0", Offset = "0x51390E0", VA = "0x18513A6E0")]
	public bool HEJCAAOAKNK(THandle ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x513A200", Offset = "0x5138C00", VA = "0x18513A200")]
	public bool EHJIJKOKNAC(THandle ENNBIIMEOCP, [Out] TValue PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5139FD0", Offset = "0x51389D0", VA = "0x185139FD0")]
	public TValue BLCCCENAIKI(THandle ENNBIIMEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x513A810", Offset = "0x5139210", VA = "0x18513A810")]
	public bool IKAEDGDPHLM(THandle ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x513A920", Offset = "0x5139320", VA = "0x18513A920")]
	private THandle JBDBJHKINNN(int DOAKEFBOPIA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x513AA90", Offset = "0x5139490", VA = "0x18513AA90")]
	private TValue LJEPDBELIAK(int DOAKEFBOPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x513A4C0", Offset = "0x5138EC0", VA = "0x18513A4C0")]
	private void GLDMIGAMLNJ(int DOAKEFBOPIA, [In] THandle ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x513A020", Offset = "0x5138A20", VA = "0x18513A020")]
	private void DMGHPFDEDAO(int DOAKEFBOPIA, [In] TValue PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x513AAF0", Offset = "0x51394F0", VA = "0x18513AAF0")]
	private THandle LMLGCJKJGIC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x513A980", Offset = "0x5139380", VA = "0x18513A980")]
	private void LBGKCFACEKC(THandle ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5139FC0", Offset = "0x51389C0", VA = "0x185139FC0")]
	private int ABKEJKFNIBG(int AIBPOENNNGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x513A070", Offset = "0x5138A70", VA = "0x18513A070")]
	private bool DNMCMNGCIID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9B6FE0", Offset = "0x9B59E0", VA = "0x1809B6FE0")]
	private void KPOMICPADLP(THandle ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x513A150", Offset = "0x5138B50", VA = "0x18513A150")]
	private bool EHFFAGDENAP([Out] THandle ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x513A510", Offset = "0x5138F10", VA = "0x18513A510")]
	private bool HEBILEJBIPL([Out] THandle ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x513A2D0", Offset = "0x5138CD0", VA = "0x18513A2D0")]
	private void EIJGDDPEIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KPKOEBEHBFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int FDJPACNIFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class KOFOFNCJMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x371CE80", Offset = "0x371B880", VA = "0x18371CE80")]
	public static bool GLNGLGPCOKH<T>(this T ENNBIIMEOCP, T OLKLGHOAKNE) where T : struct, KPKOEBEHBFB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x371CE70", Offset = "0x371B870", VA = "0x18371CE70")]
	public static bool BFBBKCKIDFH<T>(this T ENNBIIMEOCP) where T : struct, KPKOEBEHBFB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7909CB0", Offset = "0x79086B0", VA = "0x187909CB0")]
	public static string NIDKPEGHPIM(this KPKOEBEHBFB ENNBIIMEOCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct GDFAAFKOMOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type NBMBCFGMFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> OFPBFEMOGME;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FF70", Offset = "0x4E9E970", VA = "0x184E9FF70")]
	public GDFAAFKOMOG(Type IPLONCOBMAB, Span<byte> LHMOIMCENOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3638750", Offset = "0x3637150", VA = "0x183638750")]
	public static GDFAAFKOMOG JAENMCONLHL<T>(T PPJFMHBDGNA) where T : struct
	{
		return default(GDFAAFKOMOG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x79097E0", Offset = "0x79081E0", VA = "0x1879097E0")]
	public static FIDCCCBCGML MEHFEEABIDG([In] GDFAAFKOMOG LIFAHFCIJCG)
	{
		return default(FIDCCCBCGML);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7909760", Offset = "0x7908160", VA = "0x187909760")]
	public Enum KPIKBHKLBII(Type CFBHLGDMOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x36390E0", Offset = "0x3637AE0", VA = "0x1836390E0")]
	public void PMHEFKOCJCJ<T>([In] T PPJFMHBDGNA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7909750", Offset = "0x7908150", VA = "0x187909750")]
	public void KPELJKECNIJ(Enum PMMCFCOBIDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct FIDCCCBCGML
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GKMCFPJDJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* BHBJAHCANCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* JMJGBEDOJOP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type NBMBCFGMFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> OFPBFEMOGME;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BOCPIJHEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x79091F0", Offset = "0x7907BF0", VA = "0x1879091F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int FAMANNFDBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7909200", Offset = "0x7907C00", VA = "0x187909200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FF70", Offset = "0x4E9E970", VA = "0x184E9FF70")]
	public FIDCCCBCGML(Type IPLONCOBMAB, ReadOnlySpan<byte> LHMOIMCENOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3623210", Offset = "0x3621C10", VA = "0x183623210")]
	public static FIDCCCBCGML JAENMCONLHL<T>(T PPJFMHBDGNA) where T : struct
	{
		return default(FIDCCCBCGML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7909420", Offset = "0x7907E20", VA = "0x187909420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7909250", Offset = "0x7907C50", VA = "0x187909250")]
	public object NEIMOJMJAAF(int DOAKEFBOPIA = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct FGIEGMMAIDH
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3621AD0", Offset = "0x36204D0", VA = "0x183621AD0")]
	public static NativeArray<T> JAENMCONLHL<T>(T PPJFMHBDGNA, bool BBNIOJNCAEJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3621B90", Offset = "0x3620590", VA = "0x183621B90")]
	public static NativeArray<T> NPKNOPFDFEO<T>(T PPJFMHBDGNA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3621A80", Offset = "0x3620480", VA = "0x183621A80")]
	public static NativeArray<T> GEPFDGDKCDP<T>(T PPJFMHBDGNA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7909000", Offset = "0x7907A00", VA = "0x187909000")]
	public static NativeArray<byte> GEPFDGDKCDP(ReadOnlySpan<byte> PPJFMHBDGNA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x79090C0", Offset = "0x7907AC0", VA = "0x1879090C0")]
	public static NativeArray<byte> JAENMCONLHL(ReadOnlySpan<byte> PPJFMHBDGNA, bool BBNIOJNCAEJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7909170", Offset = "0x7907B70", VA = "0x187909170")]
	public unsafe static NativeArray<byte> JAENMCONLHL(byte* PCNDMJCNIPD, int ENHEICOLGJO, bool BBNIOJNCAEJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3621B20", Offset = "0x3620520", VA = "0x183621B20")]
	public static NativeArray<T> KPJGFDDMHFP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct BGPNALGOLIE : IEquatable<BGPNALGOLIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int DIMNPBKLDMO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type ABBLELNBDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x79081F0", Offset = "0x7906BF0", VA = "0x1879081F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x79083F0", Offset = "0x7906DF0", VA = "0x1879083F0")]
	public BGPNALGOLIE(Type OHCGINPDMEI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7908320", Offset = "0x7906D20", VA = "0x187908320")]
	public static BGPNALGOLIE MEHFEEABIDG(Type OHCGINPDMEI)
	{
		return default(BGPNALGOLIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2064E20", Offset = "0x2063820", VA = "0x182064E20", Slot = "4")]
	public bool Equals(BGPNALGOLIE OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x79082A0", Offset = "0x7906CA0", VA = "0x1879082A0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x79083B0", Offset = "0x7906DB0", VA = "0x1879083B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MEOBFGPGPOP
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> COOEMFMBEFG;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> EFMNOELBJLA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x790A160", Offset = "0x7908B60", VA = "0x18790A160")]
	static MEOBFGPGPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7909ED0", Offset = "0x79088D0", VA = "0x187909ED0")]
	public static bool HEHCILJMFIP(Type OHCGINPDMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7909F30", Offset = "0x7908930", VA = "0x187909F30")]
	private static bool HEHCILJMFIP(Type OHCGINPDMEI, [Out] int DOAKEFBOPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x790A100", Offset = "0x7908B00", VA = "0x18790A100")]
	public static int MOGAEEJPKMP(Type OHCGINPDMEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7909E50", Offset = "0x7908850", VA = "0x187909E50")]
	public static Type BLCCCENAIKI(int DOAKEFBOPIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HCEIENFMACN<Handle> where Handle : KPKOEBEHBFB, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct BMPBDOIJGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly HCEIENFMACN<Handle> KBEOLPOGFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int DOAKEFBOPIA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle BEHNLFNJOGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6495CE0", Offset = "0x64946E0", VA = "0x186495CE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6496350", Offset = "0x6494D50", VA = "0x186496350")]
		public BMPBDOIJGGK(HCEIENFMACN<Handle> KBEOLPOGFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6495FC0", Offset = "0x64949C0", VA = "0x186495FC0")]
		public NPFPNDLIDHK DDDHPONDPCL([In] NPFPNDLIDHK FOAJJFFCIFO)
		{
			return default(NPFPNDLIDHK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6496050", Offset = "0x6494A50", VA = "0x186496050")]
		public bool FMNODPIACON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x64962F0", Offset = "0x6494CF0", VA = "0x1864962F0")]
		private Handle INECFLAEKIL(string FLPDJFEEMLN)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct NPFPNDLIDHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BMPBDOIJGGK DHDCKACHAIK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x51C79A0", Offset = "0x51C63A0", VA = "0x1851C79A0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x51C7AD0", Offset = "0x51C64D0", VA = "0x1851C7AD0")]
		public NPFPNDLIDHK(HCEIENFMACN<Handle> KBEOLPOGFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x51C7A20", Offset = "0x51C6420", VA = "0x1851C7A20")]
		public bool FMNODPIACON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x51C7A60", Offset = "0x51C6460", VA = "0x1851C7A60")]
		public NPFPNDLIDHK KCFKLFFNEEA()
		{
			return default(NPFPNDLIDHK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> AFLNACEEEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> HOCFLEGHINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int IGBGDNOLONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int NKDEPABFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool GDGDNMKHGFO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AFGHANPJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x493B390", Offset = "0x4939D90", VA = "0x18493B390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NPFPNDLIDHK LPFBKNGNOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x493A470", Offset = "0x4938E70", VA = "0x18493A470")]
		get
		{
			return default(NPFPNDLIDHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x493BD00", Offset = "0x493A700", VA = "0x18493BD00")]
	public HCEIENFMACN(int AOMFOMGHHBK, Allocator DDBBFOCJEFL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x493A310", Offset = "0x4938D10", VA = "0x18493A310")]
	public void CHMHFDMILHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x200AA60", Offset = "0x2009460", VA = "0x18200AA60")]
	public static int ABKEJKFNIBG(int LFDANFLODKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF7F0", Offset = "0x2CCE1F0", VA = "0x182CCF7F0")]
	public static bool CIKHMPGFFHP(int LFDANFLODKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x493B6C0", Offset = "0x493A0C0", VA = "0x18493B6C0")]
	public bool NOJDGHJELLH(int DOAKEFBOPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x493A680", Offset = "0x4939080", VA = "0x18493A680")]
	public bool ENJGPBLKGFA(Handle ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x493A7F0", Offset = "0x49391F0", VA = "0x18493A7F0")]
	public Handle GFBPPFIMABC()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x493AD50", Offset = "0x4939750", VA = "0x18493AD50")]
	public void JPAJMOEOCNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x493AA00", Offset = "0x4939400", VA = "0x18493AA00")]
	public void HDDMPLGLHAK(Handle ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xD34A50", Offset = "0xD33450", VA = "0x180D34A50")]
	private bool DKGHLIDBGIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x493A1F0", Offset = "0x4938BF0", VA = "0x18493A1F0")]
	private bool BPMOCDLHOGG(int DOAKEFBOPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x493AA70", Offset = "0x4939470", VA = "0x18493AA70")]
	private void HHOHMOOOBMH([Out] int DOAKEFBOPIA, [Out] int AIBPOENNNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x493B410", Offset = "0x4939E10", VA = "0x18493B410")]
	private void LHKNDLJJBPM(Handle ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x493A420", Offset = "0x4938E20", VA = "0x18493A420")]
	private void CKHELCKKPIG(int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x493B920", Offset = "0x493A320", VA = "0x18493B920")]
	private bool PAEHGLJMHFG([Out] int DOAKEFBOPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x493BB70", Offset = "0x493A570", VA = "0x18493BB70")]
	private static Handle PDNMNMGGNIB(int DOAKEFBOPIA, int AIBPOENNNGG)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public struct OAGNPLEFMGD<Handle, T> where Handle : KPKOEBEHBFB, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HCEIENFMACN<Handle> IHMMLEIGMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] MBBAHFIEFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> CNEEHHFJPIB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x52C89D0", Offset = "0x52C73D0", VA = "0x1852C89D0")]
	public OAGNPLEFMGD(int AOMFOMGHHBK, [Optional] Action<T> CNEEHHFJPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x52C7F40", Offset = "0x52C6940", VA = "0x1852C7F40")]
	public void CHMHFDMILHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x52C8080", Offset = "0x52C6A80", VA = "0x1852C8080")]
	public bool EHJIJKOKNAC(Handle ENNBIIMEOCP, [Out] T OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x52C8320", Offset = "0x52C6D20", VA = "0x1852C8320")]
	public Handle HEHCILJMFIP(T OIIGDBLKEDN)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x52C86B0", Offset = "0x52C70B0", VA = "0x1852C86B0")]
	public void OANEELGHKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x52C7D10", Offset = "0x52C6710", VA = "0x1852C7D10")]
	public void CBCJJMKDJJC(Handle ENNBIIMEOCP, [Out] T BONJJDBLNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x52C7B50", Offset = "0x52C6550", VA = "0x1852C7B50")]
	public void CBCJJMKDJJC(Handle ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x52C8420", Offset = "0x52C6E20", VA = "0x1852C8420")]
	private T MEANJLPEEFF(int DOAKEFBOPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x52C7FC0", Offset = "0x52C69C0", VA = "0x1852C7FC0")]
	private void DCBGACJBEKO(int KPGLCHOFCJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct FFLBBHGNCDF<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct BGBHBMNPNEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private FFLBBHGNCDF<T> NAKGFAINKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int DOAKEFBOPIA;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x64632E0", Offset = "0x6461CE0", VA = "0x1864632E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x26C3230", Offset = "0x26C1C30", VA = "0x1826C3230")]
		public BGBHBMNPNEE(FFLBBHGNCDF<T> NAKGFAINKPB, int DOAKEFBOPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6463330", Offset = "0x6461D30", VA = "0x186463330")]
		public bool FMNODPIACON()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class BHKNBLNGMDL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FFLBBHGNCDF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public BHKNBLNGMDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x64656C0", Offset = "0x64640C0", VA = "0x1864656C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6465760", Offset = "0x6464160", VA = "0x186465760", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IFKMBBINAKC : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FFLBBHGNCDF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public IFKMBBINAKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4A7C340", Offset = "0x4A7AD40", VA = "0x184A7C340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4A7C3E0", Offset = "0x4A7ADE0", VA = "0x184A7C3E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] DFPGGEDGGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint PPJFMHBDGNA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x47C0840", Offset = "0x47BF240", VA = "0x1847C0840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DDFCNJDHCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x47C08C0", Offset = "0x47BF2C0", VA = "0x1847C08C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MNPGKBIJONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1646230", Offset = "0x1644C30", VA = "0x181646230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool LKHJMNPJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x47C06A0", Offset = "0x47BF0A0", VA = "0x1847C06A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public BPLFPGMHNFI<T> OFPBFEMOGME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x47C0CF0", Offset = "0x47BF6F0", VA = "0x1847C0CF0")]
		get
		{
			return default(BPLFPGMHNFI<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x47C06B0", Offset = "0x47BF0B0", VA = "0x1847C06B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x47C03F0", Offset = "0x47BEDF0", VA = "0x1847C03F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x47C1400", Offset = "0x47BFE00", VA = "0x1847C1400")]
	internal FFLBBHGNCDF(FFLBBHGNCDF<T> NAKGFAINKPB, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x47C1420", Offset = "0x47BFE20", VA = "0x1847C1420")]
	private FFLBBHGNCDF(T[] NAKGFAINKPB, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x47C10C0", Offset = "0x47BFAC0", VA = "0x1847C10C0")]
	public FFLBBHGNCDF(IEnumerable<T> IOMEFCNHNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x47C1050", Offset = "0x47BFA50", VA = "0x1847C1050")]
	public FFLBBHGNCDF(int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x47C04A0", Offset = "0x47BEEA0", VA = "0x1847C04A0")]
	public int BNJEHECAOFH(T PPJFMHBDGNA, int GJCFLJFIOAP, int PGJKBFGEJNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x47C08F0", Offset = "0x47BF2F0", VA = "0x1847C08F0")]
	public void KMBLEFFLBKG(int CFNOIPCHCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x47C09D0", Offset = "0x47BF3D0", VA = "0x1847C09D0")]
	private void MKPNGDKNPBF(int CFNOIPCHCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x47C0520", Offset = "0x47BEF20", VA = "0x1847C0520")]
	public T[] CCMLKBEADFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x47C0BA0", Offset = "0x47BF5A0", VA = "0x1847C0BA0")]
	public T[] OBPCLLMNCNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x47C0620", Offset = "0x47BF020", VA = "0x1847C0620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x47C0780", Offset = "0x47BF180", VA = "0x1847C0780")]
	public void GKFJNNPIOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x47C0850", Offset = "0x47BF250", VA = "0x1847C0850")]
	public BGBHBMNPNEE KCFKLFFNEEA()
	{
		return default(BGBHBMNPNEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x47C0E70", Offset = "0x47BF870", VA = "0x1847C0E70", Slot = "5")]
	[IteratorStateMachine(typeof(FFLBBHGNCDF<>.BHKNBLNGMDL))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x47C0F60", Offset = "0x47BF960", VA = "0x1847C0F60", Slot = "6")]
	[IteratorStateMachine(typeof(FFLBBHGNCDF<>.IFKMBBINAKC))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x47C07E0", Offset = "0x47BF1E0", VA = "0x1847C07E0")]
	public static FFLBBHGNCDF<T> GLJMFDOGEMA(T[] NAKGFAINKPB)
	{
		return default(FFLBBHGNCDF<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x47C0930", Offset = "0x47BF330", VA = "0x1847C0930")]
	public static FFLBBHGNCDF<T> MEHFEEABIDG(T[] NAKGFAINKPB)
	{
		return default(FFLBBHGNCDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x47C05A0", Offset = "0x47BEFA0", VA = "0x1847C05A0")]
	private void DBIOONCDMDO(int DOAKEFBOPIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class HPNOBMMHMAN<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct FMFECODFDPK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private HPNOBMMHMAN<T> FMFEHIEKOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int DOAKEFBOPIA;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x47DC480", Offset = "0x47DAE80", VA = "0x1847DC480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x47DC4C0", Offset = "0x47DAEC0", VA = "0x1847DC4C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4413950", Offset = "0x4412350", VA = "0x184413950")]
		public FMFECODFDPK(HPNOBMMHMAN<T> FMFEHIEKOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x47DC390", Offset = "0x47DAD90", VA = "0x1847DC390", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x47DC430", Offset = "0x47DAE30", VA = "0x1847DC430", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private FFLBBHGNCDF<T> DFPGGEDGGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int ENHEICOLGJO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x497ACF0", Offset = "0x49796F0", VA = "0x18497ACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB86090", Offset = "0xB84A90", VA = "0x180B86090")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF600", Offset = "0x3EDE000", VA = "0x183EDF600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int AFGHANPJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x497B1E0", Offset = "0x4979BE0", VA = "0x18497B1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool MNPGKBIJONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x497B540", Offset = "0x4979F40", VA = "0x18497B540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public BPLFPGMHNFI<T> OFPBFEMOGME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x497B4C0", Offset = "0x4979EC0", VA = "0x18497B4C0")]
		get
		{
			return default(BPLFPGMHNFI<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x497B610", Offset = "0x497A010", VA = "0x18497B610")]
	public HPNOBMMHMAN(IEnumerable<T> IOMEFCNHNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x497B690", Offset = "0x497A090", VA = "0x18497B690")]
	public HPNOBMMHMAN(int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x480BCF0", Offset = "0x480A6F0", VA = "0x18480BCF0")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x497B410", Offset = "0x4979E10", VA = "0x18497B410")]
	public FFLBBHGNCDF<T> MNINAEHKIGJ()
	{
		return default(FFLBBHGNCDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x497AFA0", Offset = "0x49799A0", VA = "0x18497AFA0")]
	public void HEHCILJMFIP(T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x497B1A0", Offset = "0x4979BA0", VA = "0x18497B1A0")]
	private void KMBLEFFLBKG(int CIIHPLFOGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x497AB70", Offset = "0x4979570", VA = "0x18497AB70")]
	public void FAPPIOKLKNF(List<T> NOGFBEHEDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x497AAD0", Offset = "0x49794D0", VA = "0x18497AAD0")]
	public void FAPPIOKLKNF(T[] NOGFBEHEDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x497B0C0", Offset = "0x4979AC0", VA = "0x18497B0C0")]
	public void JDKMPEEHLEK(int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x497AD60", Offset = "0x4979760", VA = "0x18497AD60")]
	public void GGKLBAKAHAO(int AFGOPCMMLLP, int BKICKHECIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x497A790", Offset = "0x4979190", VA = "0x18497A790")]
	public int BNJEHECAOFH(T PPJFMHBDGNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x497AA80", Offset = "0x4979480", VA = "0x18497AA80")]
	public bool EGACGLIMIFH(T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x497B450", Offset = "0x4979E50", VA = "0x18497B450")]
	public T[] OBPCLLMNCNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x497AA60", Offset = "0x4979460", VA = "0x18497AA60", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x497B350", Offset = "0x4979D50", VA = "0x18497B350")]
	public static FFLBBHGNCDF<T> MEHFEEABIDG(HPNOBMMHMAN<T> FMFEHIEKOMI)
	{
		return default(FFLBBHGNCDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x497AF30", Offset = "0x4979930", VA = "0x18497AF30", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x497B560", Offset = "0x4979F60", VA = "0x18497B560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x497B5A0", Offset = "0x4979FA0", VA = "0x18497B5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x497B200", Offset = "0x4979C00", VA = "0x18497B200")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void LIAAFFHPCCJ(int PPJFMHBDGNA, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x497A810", Offset = "0x4979210", VA = "0x18497A810")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void BOLAKJGPLMM(int AFGOPCMMLLP, int BKICKHECIBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DPGIKOHHAFL
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3488D60", Offset = "0x3487760", VA = "0x183488D60")]
	public static void GKFJNNPIOOE<T>(this HPNOBMMHMAN<T> FMFEHIEKOMI) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public ref struct BPLFPGMHNFI<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> DFPGGEDGGGN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x64C38C0", Offset = "0x64C22C0", VA = "0x1864C38C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x64C3630", Offset = "0x64C2030", VA = "0x1864C3630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x64C3990", Offset = "0x64C2390", VA = "0x1864C3990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public BPLFPGMHNFI(Span<object> LHMOIMCENOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x64C3740", Offset = "0x64C2140", VA = "0x1864C3740")]
	public BPLFPGMHNFI<T> COONBMAOFAC(int GJCFLJFIOAP)
	{
		return default(BPLFPGMHNFI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x64C3660", Offset = "0x64C2060", VA = "0x1864C3660")]
	public BPLFPGMHNFI<T> COONBMAOFAC(int GJCFLJFIOAP, int ENHEICOLGJO)
	{
		return default(BPLFPGMHNFI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x64C3810", Offset = "0x64C2210", VA = "0x1864C3810")]
	public void ECPAKGCPJJJ(BPLFPGMHNFI<T> MCNEPHNAFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x64C39D0", Offset = "0x64C23D0", VA = "0x1864C39D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x64C3870", Offset = "0x64C2270", VA = "0x1864C3870", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x64C3940", Offset = "0x64C2340", VA = "0x1864C3940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct FOFEFKICODD : IEquatable<FOFEFKICODD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int LMGBAALNFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int PGJKBFGEJNK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int KHMMHBDHIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC650", Offset = "0x2CDB050", VA = "0x182CDC650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C4D0", Offset = "0x6B6AED0", VA = "0x186B6C4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int HBCEMKKIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LLJAPGMKKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7909650", Offset = "0x7908050", VA = "0x187909650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7909630", Offset = "0x7908030", VA = "0x187909630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public (int begin, int end) OONBEMANOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7909660", Offset = "0x7908060", VA = "0x187909660")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
	private FOFEFKICODD(int LMGBAALNFHC, int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x26B2C00", Offset = "0x26B1600", VA = "0x1826B2C00")]
	public static FOFEFKICODD ICIAHDMHJAC(int LMGBAALNFHC, int PGJKBFGEJNK)
	{
		return default(FOFEFKICODD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7909640", Offset = "0x7908040", VA = "0x187909640")]
	public static FOFEFKICODD IDNNPCBAKCI(int GJCFLJFIOAP, int BKICKHECIBO)
	{
		return default(FOFEFKICODD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x79096C0", Offset = "0x79080C0", VA = "0x1879096C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x17C7BC0", Offset = "0x17C65C0", VA = "0x1817C7BC0", Slot = "4")]
	public bool Equals(FOFEFKICODD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x79095A0", Offset = "0x7907FA0", VA = "0x1879095A0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB130", Offset = "0x6CC9B30", VA = "0x186CCB130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct NMJGPLMGJDJ<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> DFPGGEDGGGN;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
	public NMJGPLMGJDJ(NativeArray<T> DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x51BCF60", Offset = "0x51BB960", VA = "0x1851BCF60", Slot = "6")]
	public int Compare(int CJBFFOKBLHB, int CNBLFOFLDDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51BD050", Offset = "0x51BBA50", VA = "0x1851BD050", Slot = "4")]
	public bool Equals(int CJBFFOKBLHB, int CNBLFOFLDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x51BD140", Offset = "0x51BBB40", VA = "0x1851BD140", Slot = "5")]
	public int GetHashCode(int CJBFFOKBLHB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EONJHPBBAKC
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x34CF1B0", Offset = "0x34CDBB0", VA = "0x1834CF1B0")]
	public static T[] LNAEJFNOGHC<T>(List<T> FMFEHIEKOMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MDIANDBCGGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* MBHBANPHKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle IGGFIOFFFOP;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x57FE360", Offset = "0x57FCD60", VA = "0x1857FE360")]
	public void CHMHFDMILHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DMGLFDPBNLO
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3467D90", Offset = "0x3466790", VA = "0x183467D90")]
	public static MDIANDBCGGA GLOLLAAGFCL<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> NCNKGDJFDBF) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(MDIANDBCGGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3467D90", Offset = "0x3466790", VA = "0x183467D90")]
	public static UnsafeParallelHashMap<TKey, TValue> ALCDONCPJKF<TKey, TValue>(this MDIANDBCGGA NCNKGDJFDBF) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HAEPPFHFHGP
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3673460", Offset = "0x3671E60", VA = "0x183673460")]
	public static int EDNALABBHPK<T>(ReadOnlySpan<T> AILPEEALNKP, ReadOnlySpan<T> OKMPLDFKDAB, int ENHEICOLGJO) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class MFEIPMBGGNB
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x374F820", Offset = "0x374E220", VA = "0x18374F820")]
	public static T GEMJEIFKNLH<T>(this NativeArray<byte> KKMIKMKCMKE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x374F8B0", Offset = "0x374E2B0", VA = "0x18374F8B0")]
	public static NativeArray<T> LNBMLCIDJKN<T>(this NativeArray<byte> KKMIKMKCMKE, int PGJKBFGEJNK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x374F590", Offset = "0x374DF90", VA = "0x18374F590")]
	public static void EIMCNBJPGEJ<T>(this NativeList<byte> GNMBGILIMLJ, [In] T PPJFMHBDGNA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x374F640", Offset = "0x374E040", VA = "0x18374F640")]
	public static void EIMCNBJPGEJ<T>(this NativeList<byte> GNMBGILIMLJ, NativeArray<T> PPJFMHBDGNA) where T : struct
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

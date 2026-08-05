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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8385C70", Offset = "0x8384A70", VA = "0x188385C70", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[LNEGMIAHHAA]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3E80B10", Offset = "0x3E7F910", VA = "0x183E80B10")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[LNEGMIAHHAA]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E81D80", Offset = "0x3E80B80", VA = "0x183E81D80")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E80D10", Offset = "0x3E7FB10", VA = "0x183E80D10")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3E80F20", Offset = "0x3E7FD20", VA = "0x183E80F20")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AB50", Offset = "0x3E89950", VA = "0x183E8AB50")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A8E0", Offset = "0x3E896E0", VA = "0x183E8A8E0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AA50", Offset = "0x3E89850", VA = "0x183E8AA50")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B210", Offset = "0x3E8A010", VA = "0x183E8B210")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E82460", Offset = "0x3E81260", VA = "0x183E82460")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E82520", Offset = "0x3E81320", VA = "0x183E82520")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E82980", Offset = "0x3E81780", VA = "0x183E82980")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, EFHLFJNDJJB range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E829C0", Offset = "0x3E817C0", VA = "0x183E829C0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3E82800", Offset = "0x3E81600", VA = "0x183E82800")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3E80B60", Offset = "0x3E7F960", VA = "0x183E80B60")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A990", Offset = "0x3E89790", VA = "0x183E8A990")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[LNEGMIAHHAA]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C330", Offset = "0x3E8B130", VA = "0x183E8C330")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D2B0", Offset = "0x3E8C0B0", VA = "0x183E8D2B0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D260", Offset = "0x3E8C060", VA = "0x183E8D260")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x518E300", Offset = "0x518D100", VA = "0x18518E300")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8386030", Offset = "0x8384E30", VA = "0x188386030")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8386060", Offset = "0x8384E60", VA = "0x188386060")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C7E0", Offset = "0x3E8B5E0", VA = "0x183E8C7E0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C5F0", Offset = "0x3E8B3F0", VA = "0x183E8C5F0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C8E0", Offset = "0x3E8B6E0", VA = "0x183E8C8E0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C840", Offset = "0x3E8B640", VA = "0x183E8C840")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C890", Offset = "0x3E8B690", VA = "0x183E8C890")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C740", Offset = "0x3E8B540", VA = "0x183E8C740")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CBE0", Offset = "0x3E8B9E0", VA = "0x183E8CBE0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CA40", Offset = "0x3E8B840", VA = "0x183E8CA40")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C640", Offset = "0x3E8B440", VA = "0x183E8C640")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C590", Offset = "0x3E8B390", VA = "0x183E8C590")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C570", Offset = "0x3E8B370", VA = "0x183E8C570")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D690", Offset = "0x3E8C490", VA = "0x183E8D690")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D2C0", Offset = "0x3E8C0C0", VA = "0x183E8D2C0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D6C0", Offset = "0x3E8C4C0", VA = "0x183E8D6C0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D770", Offset = "0x3E8C570", VA = "0x183E8D770")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[LNEGMIAHHAA]
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
			[Cpp2IlInjected.Address(RVA = "0x503EDA0", Offset = "0x503DBA0", VA = "0x18503EDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF5B8C0", Offset = "0xF5A6C0", VA = "0x180F5B8C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x56650F0", Offset = "0x5663EF0", VA = "0x1856650F0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x59B7D00", Offset = "0x59B6B00", VA = "0x1859B7D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x59B7B90", Offset = "0x59B6990", VA = "0x1859B7B90")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x449C2E0", Offset = "0x449B0E0", VA = "0x18449C2E0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[LNEGMIAHHAA]
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
			[Cpp2IlInjected.Address(RVA = "0x5A22750", Offset = "0x5A21550", VA = "0x185A22750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5A22790", Offset = "0x5A21590", VA = "0x185A22790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x56650F0", Offset = "0x5663EF0", VA = "0x1856650F0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5A223A0", Offset = "0x5A211A0", VA = "0x185A223A0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5A224F0", Offset = "0x5A212F0", VA = "0x185A224F0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5A226B0", Offset = "0x5A214B0", VA = "0x185A226B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5A22530", Offset = "0x5A21330", VA = "0x185A22530")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[LNEGMIAHHAA]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[LNEGMIAHHAA]
public static class MJGHDBCMNDG
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8385E00", Offset = "0x8384C00", VA = "0x188385E00")]
	public static JobHandle HMGGBNPGEPA(this JobHandle GENJGFGGINA, JobHandle KMNEIBIPMKI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8385D50", Offset = "0x8384B50", VA = "0x188385D50")]
	public static JobHandle GMEFBHGIJPE(this Span<JobHandle> KELIIEBDMOM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DPOLDBCKMEI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39AD6E0", Offset = "0x39AC4E0", VA = "0x1839AD6E0")]
	public static void FMJEOCFJDAJ<T>(this T[] ELLFIONNNHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NPIBGKLFANH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7FC70", Offset = "0x3E7EA70", VA = "0x183E7FC70")]
	public static NativeKeyValueArrays<TKey, TValue> HAHBDAEMNEM<TKey, TValue>(this Dictionary<TKey, TValue> IMNNEOMDPNB, Allocator GIEDOJCOPKP) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class INJCLNBHKPC
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8385630", Offset = "0x8384430", VA = "0x188385630")]
	public static void HAJMMGOBAOA(this GameObject DFFAMKHOIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8385770", Offset = "0x8384570", VA = "0x188385770")]
	public static void HAJMMGOBAOA(this Component PGJHFGMMOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83856D0", Offset = "0x83844D0", VA = "0x1883856D0")]
	public static void HAJMMGOBAOA(this ScriptableObject OIOBJDGHGHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DLDGNDCHIED
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8384560", Offset = "0x8383360", VA = "0x188384560")]
	public static void GLPBDGMBMAM(this NativeList<byte> NGGCNGNMEBF, ReadOnlySpan<byte> INBGDIBHMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B5CC30", Offset = "0x3B5BA30", VA = "0x183B5CC30")]
	public static void JFMGAAKFFGP<T>(this NativeList<T> NGGCNGNMEBF, T HGMAIPELJHM, int FFKCBONKOOM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EINGCEILFJM
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B81640", Offset = "0x3B80440", VA = "0x183B81640")]
	public static T DJBBKGPCMKO<T>(this ReadOnlySpan<byte> HGMAIPELJHM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B81040", Offset = "0x3B7FE40", VA = "0x183B81040")]
	public static T ABDDMMDPDCL<T>(this Span<T> INBGDIBHMOE, Func<T, bool> CAAIBDKKFOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B81DB0", Offset = "0x3B80BB0", VA = "0x183B81DB0")]
	public static bool KMFDFFMMCIL<T>(this Span<T> INBGDIBHMOE, Func<T, bool> CAAIBDKKFOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B81D20", Offset = "0x3B80B20", VA = "0x183B81D20")]
	public static bool JPJLLJHEHAE<T>(this Span<T> INBGDIBHMOE, Func<T, bool> CAAIBDKKFOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B81880", Offset = "0x3B80680", VA = "0x183B81880")]
	public static T DPMBHNJHJDJ<T>([In] this ReadOnlySpan<byte> INBGDIBHMOE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B81CE0", Offset = "0x3B80AE0", VA = "0x183B81CE0")]
	public static Span<TTo> HCPOBLLBIMN<TTo, TFrom>(this Span<TFrom> INBGDIBHMOE) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B81CE0", Offset = "0x3B80AE0", VA = "0x183B81CE0")]
	public static ReadOnlySpan<TTo> HCPOBLLBIMN<TTo, TFrom>(this ReadOnlySpan<TFrom> INBGDIBHMOE) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B81CE0", Offset = "0x3B80AE0", VA = "0x183B81CE0")]
	public static ReadOnlySpan<TTo> HCPOBLLBIMN<TTo>(this ReadOnlySpan<byte> INBGDIBHMOE) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B810D0", Offset = "0x3B7FED0", VA = "0x183B810D0")]
	public static Span<T> BKCDCCJFPOM<T>(this ReadOnlySpan<T> HNLFFLNNKGK) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B811C0", Offset = "0x3B7FFC0", VA = "0x183B811C0")]
	public static Span<byte> BNFJAIPBEBA<T>([In] this Span<byte> INBGDIBHMOE, T HGMAIPELJHM) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8384790", Offset = "0x8383590", VA = "0x188384790")]
	private static Enum BMIHMJAJJCP([In] ReadOnlySpan<byte> INBGDIBHMOE, Type JCNMFMNCKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8385210", Offset = "0x8384010", VA = "0x188385210")]
	public static Enum NJAJNAANEON([In] this Span<byte> INBGDIBHMOE, Type JCNMFMNCKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8384D30", Offset = "0x8383B30", VA = "0x188384D30")]
	public static void IBPKDPOOMKD([In] this Span<byte> INBGDIBHMOE, Enum AGNBPCKNDIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ILEHIPAEJEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IEFCMNOHMDO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8385390", Offset = "0x8384190", VA = "0x188385390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8385510", Offset = "0x8384310", VA = "0x188385510")]
	[AsyncStateMachine(typeof(IEFCMNOHMDO))]
	public static void JOLJGICKCKI(this Task DDCPKPIHIOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NLGCGNJIFOC
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3E77830", Offset = "0x3E76630", VA = "0x183E77830")]
	public static NativeArray<T> EMGIFBIFKPO<T>(this UnsafeList<T> NGGCNGNMEBF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E777C0", Offset = "0x3E765C0", VA = "0x183E777C0")]
	public static NativeArray<T> DBBOIKENCAN<T>(this UnsafeList<T> NGGCNGNMEBF, bool GEOECIKGMFI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E77710", Offset = "0x3E76510", VA = "0x183E77710")]
	public static UnsafeList<T> BKCDCCJFPOM<T>(this UnsafeList<T> NGGCNGNMEBF, Allocator GIEDOJCOPKP) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PPACMAIENIA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum MGFLALCBOJD : short
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
	public struct KIKFJMEOAIE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly MGFLALCBOJD OPGJHIOADCK;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x31D2E30", Offset = "0x31D1C30", VA = "0x1831D2E30")]
		public KIKFJMEOAIE(MGFLALCBOJD OPGJHIOADCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory IBMBMDODBPF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	public static void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x83860B0", Offset = "0x8384EB0", VA = "0x1883860B0")]
	static PPACMAIENIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x39B5D10", Offset = "0x39B4B10", VA = "0x1839B5D10")]
	public static KIKFJMEOAIE DIHJPECCIPE(MGFLALCBOJD OPGJHIOADCK)
	{
		return default(KIKFJMEOAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	public static void BMJIPCAILHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JKGNJMIOPJG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9DA0", Offset = "0x2CF8BA0", VA = "0x182CF9DA0")]
	public static DCNHOOGNADL<T1, T2> BHHEKOLJLIG<T1, T2>(this (T1, T2) KAJECCAKEMA) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(DCNHOOGNADL<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7710", Offset = "0x3CF6510", VA = "0x183CF7710")]
	public static FMNPFHALJOJ<T1, T2, T3> BHHEKOLJLIG<T1, T2, T3>(this (T1, T2, T3) KAJECCAKEMA) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(FMNPFHALJOJ<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DCNHOOGNADL<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) KAJECCAKEMA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9D90", Offset = "0x2CF8B90", VA = "0x182CF9D90")]
	public DCNHOOGNADL((T1, T2) KAJECCAKEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4530FD0", Offset = "0x452FDD0", VA = "0x184530FD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FMNPFHALJOJ<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) KAJECCAKEMA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4531040", Offset = "0x452FE40", VA = "0x184531040")]
	public FMNPFHALJOJ((T1, T2, T3) KAJECCAKEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4F30230", Offset = "0x4F2F030", VA = "0x184F30230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AKMGJIALLHH
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8383DA0", Offset = "0x8382BA0", VA = "0x188383DA0")]
	public static Range ICDGEIPNJBL(this EFHLFJNDJJB JBEBIIPBGHG)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MFHIDIOBFNL
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct PCCINLAAIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int NKNCDMONMEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int MLFFNDAMMCP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83860A0", Offset = "0x8384EA0", VA = "0x1883860A0")]
		public PCCINLAAIBJ(int NBLNCONJINM, int MLFFNDAMMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8386090", Offset = "0x8384E90", VA = "0x188386090")]
		public bool DMJFHJJLFGD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8385D00", Offset = "0x8384B00", VA = "0x188385D00")]
	public static PCCINLAAIBJ OLGNAIIDMLF(this Range JBEBIIPBGHG)
	{
		return default(PCCINLAAIBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct AALCANLDFKA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle MJIBDELKIML;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool POLGLNEFCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x518E2F0", Offset = "0x518D0F0", VA = "0x18518E2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x518E400", Offset = "0x518D200", VA = "0x18518E400")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x518E060", Offset = "0x518CE60", VA = "0x18518E060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x518E6D0", Offset = "0x518D4D0", VA = "0x18518E6D0")]
	public AALCANLDFKA(T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x518E300", Offset = "0x518D100", VA = "0x18518E300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class MKBANPGEJBM<THandle, TValue> : IDisposable where THandle : struct, JNOBALCJGHO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> KELIIEBDMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> OOFDDMCKJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> JIPCPNNIKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> NCHHGBOPDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int JAOKCCFAANN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x58BD240", Offset = "0x58BC040", VA = "0x1858BD240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x58BDCB0", Offset = "0x58BCAB0", VA = "0x1858BDCB0")]
	public MKBANPGEJBM(Action<TValue> NCHHGBOPDPC, [Optional] Func<TValue> JIPCPNNIKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x58BD470", Offset = "0x58BC270", VA = "0x1858BD470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x58BD3A0", Offset = "0x58BC1A0", VA = "0x1858BD3A0")]
	public THandle DPHJBDIDPOG(TValue HGMAIPELJHM)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x58BDB60", Offset = "0x58BC960", VA = "0x1858BDB60")]
	public bool MFDBANBONAB(THandle MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x58BD2B0", Offset = "0x58BC0B0", VA = "0x1858BD2B0")]
	public bool DDAKMEGCLEF(THandle MJIBDELKIML, [Out] TValue HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x58BD420", Offset = "0x58BC220", VA = "0x1858BD420")]
	public TValue DPMBHNJHJDJ(THandle MJIBDELKIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x58BDA10", Offset = "0x58BC810", VA = "0x1858BDA10")]
	public bool LHCDGKCPPOM(THandle MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x58BDC50", Offset = "0x58BCA50", VA = "0x1858BDC50")]
	private THandle MKPJNGBALIK(int JJJJBEGKNIN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x58BDB10", Offset = "0x58BC910", VA = "0x1858BDB10")]
	private TValue LHIIIPAFAOC(int JJJJBEGKNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x58BD270", Offset = "0x58BC070", VA = "0x1858BD270")]
	private void BIIBEMBEDDA(int JJJJBEGKNIN, [In] THandle MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x58BD360", Offset = "0x58BC160", VA = "0x1858BD360")]
	private void DNEFPNGCBKL(int JJJJBEGKNIN, [In] TValue HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x58BD810", Offset = "0x58BC610", VA = "0x1858BD810")]
	private THandle KPCAIEIBALC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x58BD500", Offset = "0x58BC300", VA = "0x1858BD500")]
	private void GOACEEMNJKP(THandle MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x58BDCA0", Offset = "0x58BCAA0", VA = "0x1858BDCA0")]
	private int NAGAEEJDNMK(int HNEGIKALKJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x58BD4F0", Offset = "0x58BC2F0", VA = "0x1858BD4F0")]
	private bool EGLJEKNDBLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAA23A0", Offset = "0xAA11A0", VA = "0x180AA23A0")]
	private void MJLMAAMCHDC(THandle MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x58BD970", Offset = "0x58BC770", VA = "0x1858BD970")]
	private bool LBJLHAEBLIP([Out] THandle MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x58BD730", Offset = "0x58BC530", VA = "0x1858BD730")]
	private bool KKKMNCGAFBN([Out] THandle MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x58BD5D0", Offset = "0x58BC3D0", VA = "0x1858BD5D0")]
	private void HLDEMGNEPAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JNOBALCJGHO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int ALOAEDJGJPK
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
public static class GFFMPMJIOOB
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CF76E0", Offset = "0x3CF64E0", VA = "0x183CF76E0")]
	public static bool BFCCCAIOIEN<T>(this T MJIBDELKIML, T FGAEAFBDBPK) where T : struct, JNOBALCJGHO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7700", Offset = "0x3CF6500", VA = "0x183CF7700")]
	public static bool HCIMLNOEIII<T>(this T MJIBDELKIML) where T : struct, JNOBALCJGHO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8385280", Offset = "0x8384080", VA = "0x188385280")]
	public static string BBJEFBHKLHG(this JNOBALCJGHO MJIBDELKIML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct CIBOKDDAPGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type JGGBIBBAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> OLAENKCJPEM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x56651E0", Offset = "0x5663FE0", VA = "0x1856651E0")]
	public CIBOKDDAPGP(Type BFOOPIEHLFO, Span<byte> INBGDIBHMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A820", Offset = "0x3B09620", VA = "0x183B0A820")]
	public static CIBOKDDAPGP BADAHKFBFDJ<T>(T HGMAIPELJHM) where T : struct
	{
		return default(CIBOKDDAPGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x83840B0", Offset = "0x8382EB0", VA = "0x1883840B0")]
	public static CLNFADJCCND MIDAFINGFAP([In] CIBOKDDAPGP BIHPDMNFJGD)
	{
		return default(CLNFADJCCND);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8384130", Offset = "0x8382F30", VA = "0x188384130")]
	public Enum NJAJNAANEON(Type JCNMFMNCKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B120", Offset = "0x3B09F20", VA = "0x183B0B120")]
	public void BNFJAIPBEBA<T>([In] T HGMAIPELJHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x83840A0", Offset = "0x8382EA0", VA = "0x1883840A0")]
	public void IBPKDPOOMKD(Enum AGNBPCKNDIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct CLNFADJCCND
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct OBJKNELPEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* LBOKDDCAPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* KNFFIEOCHJM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type JGGBIBBAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> OLAENKCJPEM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LINFLLBJLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83841B0", Offset = "0x8382FB0", VA = "0x1883841B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DBFEHFMHJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8384390", Offset = "0x8383190", VA = "0x188384390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x56651E0", Offset = "0x5663FE0", VA = "0x1856651E0")]
	public CLNFADJCCND(Type BFOOPIEHLFO, ReadOnlySpan<byte> INBGDIBHMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B12CF0", Offset = "0x3B11AF0", VA = "0x183B12CF0")]
	public static CLNFADJCCND BADAHKFBFDJ<T>(T HGMAIPELJHM) where T : struct
	{
		return default(CLNFADJCCND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x83843E0", Offset = "0x83831E0", VA = "0x1883843E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x83841C0", Offset = "0x8382FC0", VA = "0x1883841C0")]
	public object IJNNPKHDPFO(int JJJJBEGKNIN = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NEEBPKPOJCP
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E739F0", Offset = "0x3E727F0", VA = "0x183E739F0")]
	public static NativeArray<T> BADAHKFBFDJ<T>(T HGMAIPELJHM, bool GEOECIKGMFI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E73AA0", Offset = "0x3E728A0", VA = "0x183E73AA0")]
	public static NativeArray<T> HGDABCMCAEL<T>(T HGMAIPELJHM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E73AD0", Offset = "0x3E728D0", VA = "0x183E73AD0")]
	public static NativeArray<T> JBCBFLNNPFH<T>(T HGMAIPELJHM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8385F70", Offset = "0x8384D70", VA = "0x188385F70")]
	public static NativeArray<byte> JBCBFLNNPFH(ReadOnlySpan<byte> HGMAIPELJHM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8385EC0", Offset = "0x8384CC0", VA = "0x188385EC0")]
	public static NativeArray<byte> BADAHKFBFDJ(ReadOnlySpan<byte> HGMAIPELJHM, bool GEOECIKGMFI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8385E40", Offset = "0x8384C40", VA = "0x188385E40")]
	public unsafe static NativeArray<byte> BADAHKFBFDJ(byte* LGPJFIDCEDB, int MCJGICKIGFF, bool GEOECIKGMFI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3E73A30", Offset = "0x3E72830", VA = "0x183E73A30")]
	public static NativeArray<T> FBGBKFBLNFL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct BDMCEKHODPO : IEquatable<BDMCEKHODPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int BIAFEEFNILC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8383F10", Offset = "0x8382D10", VA = "0x188383F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8384000", Offset = "0x8382E00", VA = "0x188384000")]
	public BDMCEKHODPO(Type ADGMECOLKNH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8383E80", Offset = "0x8382C80", VA = "0x188383E80")]
	public static BDMCEKHODPO MIDAFINGFAP(Type ADGMECOLKNH)
	{
		return default(BDMCEKHODPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x24B4C10", Offset = "0x24B3A10", VA = "0x1824B4C10", Slot = "4")]
	public bool Equals(BDMCEKHODPO FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8383E00", Offset = "0x8382C00", VA = "0x188383E00", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8383FC0", Offset = "0x8382DC0", VA = "0x188383FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JDDJLKMJJNI
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> GFPPFKPDGNG;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> CLGMHOBPKID;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8385AF0", Offset = "0x83848F0", VA = "0x188385AF0")]
	static JDDJLKMJJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x83859B0", Offset = "0x83847B0", VA = "0x1883859B0")]
	public static bool DPHJBDIDPOG(Type ADGMECOLKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8385810", Offset = "0x8384610", VA = "0x188385810")]
	private static bool DPHJBDIDPOG(Type ADGMECOLKNH, [Out] int JJJJBEGKNIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8385A90", Offset = "0x8384890", VA = "0x188385A90")]
	public static int HNALGEGIBAF(Type ADGMECOLKNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8385A10", Offset = "0x8384810", VA = "0x188385A10")]
	public static Type DPMBHNJHJDJ(int JJJJBEGKNIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PNPACNOPGIC<Handle> where Handle : JNOBALCJGHO, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct DFAALDGOMOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly PNPACNOPGIC<Handle> NMIHGIEBNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int JJJJBEGKNIN;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle CBBDLIFFEOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x4538060", Offset = "0x4536E60", VA = "0x184538060")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4538290", Offset = "0x4537090", VA = "0x184538290")]
		public DFAALDGOMOG(PNPACNOPGIC<Handle> NMIHGIEBNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4537E50", Offset = "0x4536C50", VA = "0x184537E50")]
		public DNJEPKKPCKJ ELDPFIHNJDG([In] DNJEPKKPCKJ OGPILIPEPKA)
		{
			return default(DNJEPKKPCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4537D40", Offset = "0x4536B40", VA = "0x184537D40")]
		public bool DMJFHJJLFGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x45381D0", Offset = "0x4536FD0", VA = "0x1845381D0")]
		private Handle OAAHGOAKAHN(string JDFCBBCKOGJ)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct DNJEPKKPCKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private DFAALDGOMOG DEDMPEHJFDB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x45B2B10", Offset = "0x45B1910", VA = "0x1845B2B10")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x45B2BD0", Offset = "0x45B19D0", VA = "0x1845B2BD0")]
		public DNJEPKKPCKJ(PNPACNOPGIC<Handle> NMIHGIEBNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x45B2A90", Offset = "0x45B1890", VA = "0x1845B2A90")]
		public bool DMJFHJJLFGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x45B2B50", Offset = "0x45B1950", VA = "0x1845B2B50")]
		public DNJEPKKPCKJ OLGNAIIDMLF()
		{
			return default(DNJEPKKPCKJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> HFNLOCHKFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> NCIPHGEMLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int DEKGHGKIJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int IHAFLPECOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool FMAHBHFBOOA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int APDEGNKEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C12AE0", Offset = "0x5C118E0", VA = "0x185C12AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DNJEPKKPCKJ DLGJIHMHGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5C11210", Offset = "0x5C10010", VA = "0x185C11210")]
		get
		{
			return default(DNJEPKKPCKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5C12C80", Offset = "0x5C11A80", VA = "0x185C12C80")]
	public PNPACNOPGIC(int LABFPKGJNOB, Allocator GIEDOJCOPKP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5C11350", Offset = "0x5C10150", VA = "0x185C11350")]
	public void FFICDEPBOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x251B530", Offset = "0x251A330", VA = "0x18251B530")]
	public static int NAGAEEJDNMK(int MHBJBKNNPOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x31DDBA0", Offset = "0x31DC9A0", VA = "0x1831DDBA0")]
	public static bool NLGGCGJJMMM(int MHBJBKNNPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5C11990", Offset = "0x5C10790", VA = "0x185C11990")]
	public bool IOPDJHPEHGH(int JJJJBEGKNIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5C12600", Offset = "0x5C11400", VA = "0x185C12600")]
	public bool LAGIBAGPHPB(Handle MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5C12840", Offset = "0x5C11640", VA = "0x185C12840")]
	public Handle MMNBJMHADEN()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5C11DF0", Offset = "0x5C10BF0", VA = "0x185C11DF0")]
	public void JMJPDNKAHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5C12110", Offset = "0x5C10F10", VA = "0x185C12110")]
	public void KADHEBIEELE(Handle MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800")]
	private bool LNKJDMGBIOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5C11530", Offset = "0x5C10330", VA = "0x185C11530")]
	private bool FIOJMGLPKDM(int JJJJBEGKNIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5C11700", Offset = "0x5C10500", VA = "0x185C11700")]
	private void GNBJMLCKBCK([Out] int JJJJBEGKNIN, [Out] int HNEGIKALKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5C12340", Offset = "0x5C11140", VA = "0x185C12340")]
	private void KDJMCLCIIBH(Handle MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5C11300", Offset = "0x5C10100", VA = "0x185C11300")]
	private void DKOJBFPBNPO(int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5C12BD0", Offset = "0x5C119D0", VA = "0x185C12BD0")]
	private bool PIHBAMAEOMB([Out] int JJJJBEGKNIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5C12910", Offset = "0x5C11710", VA = "0x185C12910")]
	private static Handle ODAGGLNGICI(int JJJJBEGKNIN, int HNEGIKALKJG)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct KJFLFLNJIOG<Handle, T> where Handle : JNOBALCJGHO, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PNPACNOPGIC<Handle> DDLNECKNDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] MMKHNMJIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> LHLCDJMBDAA;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55EB3F0", Offset = "0x55EA1F0", VA = "0x1855EB3F0")]
	public KJFLFLNJIOG(int LABFPKGJNOB, [Optional] Action<T> LHLCDJMBDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55EAF30", Offset = "0x55E9D30", VA = "0x1855EAF30")]
	public void FFICDEPBOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55EA600", Offset = "0x55E9400", VA = "0x1855EA600")]
	public bool DDAKMEGCLEF(Handle MJIBDELKIML, [Out] T ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55EAD30", Offset = "0x55E9B30", VA = "0x1855EAD30")]
	public Handle DPHJBDIDPOG(T ALGAKMGCCLO)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55EA9C0", Offset = "0x55E97C0", VA = "0x1855EA9C0")]
	public void DENDFBFLMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55EAFC0", Offset = "0x55E9DC0", VA = "0x1855EAFC0")]
	public void MDNHCHGJFLC(Handle MJIBDELKIML, [Out] T IGJIFKAJKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55EB170", Offset = "0x55E9F70", VA = "0x1855EB170")]
	public void MDNHCHGJFLC(Handle MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55EAE40", Offset = "0x55E9C40", VA = "0x1855EAE40")]
	private T FCAPKDJNHHB(int JJJJBEGKNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55EB340", Offset = "0x55EA140", VA = "0x1855EB340")]
	private void NMLOAFKJAMK(int ANKNNDAHHKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct AICGKLKDKDK<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct HBDANKOCOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private AICGKLKDKDK<T> ELLFIONNNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int JJJJBEGKNIN;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5077010", Offset = "0x5075E10", VA = "0x185077010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB410", Offset = "0x2AFA210", VA = "0x182AFB410")]
		public HBDANKOCOFL(AICGKLKDKDK<T> ELLFIONNNHC, int JJJJBEGKNIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5076FC0", Offset = "0x5075DC0", VA = "0x185076FC0")]
		public bool DMJFHJJLFGD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DKPOFBHEHKA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AICGKLKDKDK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public DKPOFBHEHKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4574AC0", Offset = "0x45738C0", VA = "0x184574AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4574B60", Offset = "0x4573960", VA = "0x184574B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GMMBBMHAIPL : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AICGKLKDKDK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public GMMBBMHAIPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x500AA80", Offset = "0x5009880", VA = "0x18500AA80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x500AB20", Offset = "0x5009920", VA = "0x18500AB20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] KANAIIDGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint HGMAIPELJHM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x52AB9B0", Offset = "0x52AA7B0", VA = "0x1852AB9B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MJLOMDJHNBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x52ABBC0", Offset = "0x52AA9C0", VA = "0x1852ABBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BHENCPOLICP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1A12F50", Offset = "0x1A11D50", VA = "0x181A12F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool CLMJJJAKNMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x52AB480", Offset = "0x52AA280", VA = "0x1852AB480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KMPBMGCGCKO<T> OLAENKCJPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x52AB830", Offset = "0x52AA630", VA = "0x1852AB830")]
		get
		{
			return default(KMPBMGCGCKO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x52AB3B0", Offset = "0x52AA1B0", VA = "0x1852AB3B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x52AB300", Offset = "0x52AA100", VA = "0x1852AB300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x52ABF80", Offset = "0x52AAD80", VA = "0x1852ABF80")]
	internal AICGKLKDKDK(AICGKLKDKDK<T> ELLFIONNNHC, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x52ABF60", Offset = "0x52AAD60", VA = "0x1852ABF60")]
	private AICGKLKDKDK(T[] ELLFIONNNHC, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x52ABFA0", Offset = "0x52AADA0", VA = "0x1852ABFA0")]
	public AICGKLKDKDK(IEnumerable<T> OOFDDMCKJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x52ABEF0", Offset = "0x52AACF0", VA = "0x1852ABEF0")]
	public AICGKLKDKDK(int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x52AB280", Offset = "0x52AA080", VA = "0x1852AB280")]
	public int AAEPANPJFBI(T HGMAIPELJHM, int NBLNCONJINM, int FFKCBONKOOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x52ABC60", Offset = "0x52AAA60", VA = "0x1852ABC60")]
	public void PFNKFIDFFDF(int CDAOAIGMHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x52AB490", Offset = "0x52AA290", VA = "0x1852AB490")]
	private void CKHPNGILIKE(int CDAOAIGMHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x52ABAB0", Offset = "0x52AA8B0", VA = "0x1852ABAB0")]
	public T[] KFHDIFMEKND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x52AB6E0", Offset = "0x52AA4E0", VA = "0x1852AB6E0")]
	public T[] EKFIPPAFKPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x52AB660", Offset = "0x52AA460", VA = "0x1852AB660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x52AB9C0", Offset = "0x52AA7C0", VA = "0x1852AB9C0")]
	public void HKCIFCADJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x52ABBF0", Offset = "0x52AA9F0", VA = "0x1852ABBF0")]
	public HBDANKOCOFL OLGNAIIDMLF()
	{
		return default(HBDANKOCOFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x52ABD10", Offset = "0x52AAB10", VA = "0x1852ABD10", Slot = "5")]
	[IteratorStateMachine(typeof(AICGKLKDKDK<>.DKPOFBHEHKA))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x52ABE00", Offset = "0x52AAC00", VA = "0x1852ABE00", Slot = "6")]
	[IteratorStateMachine(typeof(AICGKLKDKDK<>.GMMBBMHAIPL))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x52ABCB0", Offset = "0x52AAAB0", VA = "0x1852ABCB0")]
	public static AICGKLKDKDK<T> PLOHCHLFPED(T[] ELLFIONNNHC)
	{
		return default(AICGKLKDKDK<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x52ABB30", Offset = "0x52AA930", VA = "0x1852ABB30")]
	public static AICGKLKDKDK<T> MIDAFINGFAP(T[] ELLFIONNNHC)
	{
		return default(AICGKLKDKDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x52ABA30", Offset = "0x52AA830", VA = "0x1852ABA30")]
	private void KAPEGOLMNLL(int JJJJBEGKNIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class OAMMABHBAOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3EA4320", Offset = "0x3EA3120", VA = "0x183EA4320")]
	public static AICGKLKDKDK<T> CPENKBOPADE<T>(this IEnumerable<T> LNMKEAJCKJL) where T : class
	{
		return default(AICGKLKDKDK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class LIJJHMMHNOE<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct CEGPCNALDPM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private LIJJHMMHNOE<T> NGGCNGNMEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int JJJJBEGKNIN;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x6C63B00", Offset = "0x6C62900", VA = "0x186C63B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x6C63B40", Offset = "0x6C62940", VA = "0x186C63B40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x45B1410", Offset = "0x45B0210", VA = "0x1845B1410")]
		public CEGPCNALDPM(LIJJHMMHNOE<T> NGGCNGNMEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C63A20", Offset = "0x6C62820", VA = "0x186C63A20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6C63AB0", Offset = "0x6C628B0", VA = "0x186C63AB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private AICGKLKDKDK<T> KANAIIDGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int MCJGICKIGFF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x568FF80", Offset = "0x568ED80", VA = "0x18568FF80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4A64FF0", Offset = "0x4A63DF0", VA = "0x184A64FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4548630", Offset = "0x4547430", VA = "0x184548630", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int APDEGNKEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x568FC70", Offset = "0x568EA70", VA = "0x18568FC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool BHENCPOLICP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x568F050", Offset = "0x568DE50", VA = "0x18568F050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public KMPBMGCGCKO<T> OLAENKCJPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x568F490", Offset = "0x568E290", VA = "0x18568F490")]
		get
		{
			return default(KMPBMGCGCKO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x568FEF0", Offset = "0x568ECF0", VA = "0x18568FEF0")]
	public LIJJHMMHNOE(IEnumerable<T> OOFDDMCKJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x568FE80", Offset = "0x568EC80", VA = "0x18568FE80")]
	public LIJJHMMHNOE(int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x568F570", Offset = "0x568E370", VA = "0x18568F570")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x568F520", Offset = "0x568E320", VA = "0x18568F520")]
	public AICGKLKDKDK<T> FJHGHEHHMMJ()
	{
		return default(AICGKLKDKDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x568F070", Offset = "0x568DE70", VA = "0x18568F070")]
	public void DPHJBDIDPOG(T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x568FC30", Offset = "0x568EA30", VA = "0x18568FC30")]
	private void PFNKFIDFFDF(int FIBLEJKLMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x568F590", Offset = "0x568E390", VA = "0x18568F590")]
	public void GLPBDGMBMAM(List<T> HHGHCHEOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x568F700", Offset = "0x568E500", VA = "0x18568F700")]
	public void GLPBDGMBMAM(T[] HHGHCHEOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x568FB00", Offset = "0x568E900", VA = "0x18568FB00")]
	public bool MDNHCHGJFLC(T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x568F800", Offset = "0x568E600", VA = "0x18568F800")]
	public void IEHBKJDDIBO(int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x568F890", Offset = "0x568E690", VA = "0x18568F890")]
	public void KPALPFPIDBF(int NLFFHHCCMNK, int MLFFNDAMMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x568F210", Offset = "0x568E010", VA = "0x18568F210")]
	public void FCAPKDJNHHB(int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x568F230", Offset = "0x568E030", VA = "0x18568F230")]
	public void FDPMNNKGFAG(int NLFFHHCCMNK, int MLFFNDAMMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x568ED60", Offset = "0x568DB60", VA = "0x18568ED60")]
	public int AAEPANPJFBI(T HGMAIPELJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x568F010", Offset = "0x568DE10", VA = "0x18568F010")]
	public bool DHFLKPINICF(T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x568F1A0", Offset = "0x568DFA0", VA = "0x18568F1A0")]
	public T[] EKFIPPAFKPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x568F170", Offset = "0x568DF70", VA = "0x18568F170", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x568FB80", Offset = "0x568E980", VA = "0x18568FB80")]
	public static AICGKLKDKDK<T> MIDAFINGFAP(LIJJHMMHNOE<T> NGGCNGNMEBF)
	{
		return default(AICGKLKDKDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x568F780", Offset = "0x568E580", VA = "0x18568F780", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x568FDE0", Offset = "0x568EBE0", VA = "0x18568FDE0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x568FE10", Offset = "0x568EC10", VA = "0x18568FE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x568FC90", Offset = "0x568EA90", VA = "0x18568FC90")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void PINKHJLEPKI(int HGMAIPELJHM, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x568EDE0", Offset = "0x568DBE0", VA = "0x18568EDE0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CMKBBEDDGAK(int NLFFHHCCMNK, int MLFFNDAMMCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PPMJGOFJLFL
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3F07740", Offset = "0x3F06540", VA = "0x183F07740")]
	public static void HKCIFCADJPO<T>(this LIJJHMMHNOE<T> NGGCNGNMEBF) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct KMPBMGCGCKO<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> KANAIIDGHCH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x55F5E50", Offset = "0x55F4C50", VA = "0x1855F5E50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x55F5E20", Offset = "0x55F4C20", VA = "0x1855F5E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x55F5F30", Offset = "0x55F4D30", VA = "0x1855F5F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public KMPBMGCGCKO(Span<object> INBGDIBHMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x55F60A0", Offset = "0x55F4EA0", VA = "0x1855F60A0")]
	public KMPBMGCGCKO<T> HHCPPMHEPIO(int NBLNCONJINM)
	{
		return default(KMPBMGCGCKO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x55F5FC0", Offset = "0x55F4DC0", VA = "0x1855F5FC0")]
	public KMPBMGCGCKO<T> HHCPPMHEPIO(int NBLNCONJINM, int MCJGICKIGFF)
	{
		return default(KMPBMGCGCKO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x55F6170", Offset = "0x55F4F70", VA = "0x1855F6170")]
	public void PHBHCKKHAEI(KMPBMGCGCKO<T> IFMFGPNJMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x55F61D0", Offset = "0x55F4FD0", VA = "0x1855F61D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x55F5EE0", Offset = "0x55F4CE0", VA = "0x1855F5EE0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x55F5F70", Offset = "0x55F4D70", VA = "0x1855F5F70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct EFHLFJNDJJB : IEquatable<EFHLFJNDJJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int IBOFMHFOKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int FFKCBONKOOM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CFPFFIDODCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x300A170", Offset = "0x3008F70", VA = "0x18300A170")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x300A160", Offset = "0x3008F60", VA = "0x18300A160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int MGHFNHPKFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int OKAPFDDJAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x83846F0", Offset = "0x83834F0", VA = "0x1883846F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x83845E0", Offset = "0x83833E0", VA = "0x1883845E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) NHNLBIGNCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8384690", Offset = "0x8383490", VA = "0x188384690")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
	private EFHLFJNDJJB(int IBOFMHFOKKF, int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE240", Offset = "0x2ADD040", VA = "0x182ADE240")]
	public static EFHLFJNDJJB CEGOIDDOJBC(int IBOFMHFOKKF, int FFKCBONKOOM)
	{
		return default(EFHLFJNDJJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8384680", Offset = "0x8383480", VA = "0x188384680")]
	public static EFHLFJNDJJB GAPOHHLCALB(int NBLNCONJINM, int MLFFNDAMMCP)
	{
		return default(EFHLFJNDJJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8384700", Offset = "0x8383500", VA = "0x188384700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x13E9210", Offset = "0x13E8010", VA = "0x1813E9210", Slot = "4")]
	public bool Equals(EFHLFJNDJJB FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x83845F0", Offset = "0x83833F0", VA = "0x1883845F0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7677710", Offset = "0x7676510", VA = "0x187677710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct JDNPJKPBNNL<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> KANAIIDGHCH;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public JDNPJKPBNNL(NativeArray<T> KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x545D4B0", Offset = "0x545C2B0", VA = "0x18545D4B0", Slot = "6")]
	public int Compare(int DBBMOEGPNPP, int COFKGIHGCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x545D5A0", Offset = "0x545C3A0", VA = "0x18545D5A0", Slot = "4")]
	public bool Equals(int DBBMOEGPNPP, int COFKGIHGCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x545D690", Offset = "0x545C490", VA = "0x18545D690", Slot = "5")]
	public int GetHashCode(int DBBMOEGPNPP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NKGCIBJIJNP
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3E76D70", Offset = "0x3E75B70", VA = "0x183E76D70")]
	public static T[] MPPCJOAAFJO<T>(List<T> NGGCNGNMEBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct CLGJBBHJFHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* NOHCCEDGFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle MJJLFMFGODA;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x608C550", Offset = "0x608B350", VA = "0x18608C550")]
	public void FFICDEPBOPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class AHDAFNLBNII
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3251D30", Offset = "0x3250B30", VA = "0x183251D30")]
	public static CLGJBBHJFHF ELOIDEBBJDK<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> OKBODOGBGNF) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(CLGJBBHJFHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3251D30", Offset = "0x3250B30", VA = "0x183251D30")]
	public static UnsafeParallelHashMap<TKey, TValue> PNBPJFHFPPH<TKey, TValue>(this CLGJBBHJFHF OKBODOGBGNF) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JCLANAAOGIM
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3D64290", Offset = "0x3D63090", VA = "0x183D64290")]
	public static int FFCEFIJKGAB<T>(ReadOnlySpan<T> LPAODBOAJON, ReadOnlySpan<T> HNIHCDDPKMO, int MCJGICKIGFF) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class AEPBIJHNNBP
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x324FA60", Offset = "0x324E860", VA = "0x18324FA60")]
	public static T HKFLJHHOJDB<T>(this NativeArray<byte> HNLFFLNNKGK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x324F670", Offset = "0x324E470", VA = "0x18324F670")]
	public static NativeArray<T> DPPMINNKLEO<T>(this NativeArray<byte> HNLFFLNNKGK, int FFKCBONKOOM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x324FAF0", Offset = "0x324E8F0", VA = "0x18324FAF0")]
	public static void JKBMBEKOIPJ<T>(this NativeList<byte> AGEFPDLPNLM, [In] T HGMAIPELJHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x324FB80", Offset = "0x324E980", VA = "0x18324FB80")]
	public static void JKBMBEKOIPJ<T>(this NativeList<byte> AGEFPDLPNLM, NativeArray<T> HGMAIPELJHM) where T : struct
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

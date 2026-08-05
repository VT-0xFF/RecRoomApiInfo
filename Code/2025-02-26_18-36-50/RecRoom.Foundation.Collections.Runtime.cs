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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7463890", Offset = "0x7462C90", VA = "0x187463890", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[EDNMIOGDLLP]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3541100", Offset = "0x3540500", VA = "0x183541100")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[EDNMIOGDLLP]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x35451D0", Offset = "0x35445D0", VA = "0x1835451D0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3544EE0", Offset = "0x35442E0", VA = "0x183544EE0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3545090", Offset = "0x3544490", VA = "0x183545090")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3545850", Offset = "0x3544C50", VA = "0x183545850")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3541240", Offset = "0x3540640", VA = "0x183541240")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x35411D0", Offset = "0x35405D0", VA = "0x1835411D0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35417C0", Offset = "0x3540BC0", VA = "0x1835417C0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, AFAOEOIHAIH range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3541800", Offset = "0x3540C00", VA = "0x183541800")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3541630", Offset = "0x3540A30", VA = "0x183541630")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3544FD0", Offset = "0x35443D0", VA = "0x183544FD0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[EDNMIOGDLLP]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x357F7C0", Offset = "0x357EBC0", VA = "0x18357F7C0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3580AC0", Offset = "0x357FEC0", VA = "0x183580AC0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x357F640", Offset = "0x357EA40", VA = "0x18357F640")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x357F860", Offset = "0x357EC60", VA = "0x18357F860")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3581C10", Offset = "0x3581010", VA = "0x183581C10")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3581BC0", Offset = "0x3580FC0", VA = "0x183581BC0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x496BF10", Offset = "0x496B310", VA = "0x18496BF10")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7463A30", Offset = "0x7462E30", VA = "0x187463A30")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7463A60", Offset = "0x7462E60", VA = "0x187463A60")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x35811C0", Offset = "0x35805C0", VA = "0x1835811C0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x35811F0", Offset = "0x35805F0", VA = "0x1835811F0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3581490", Offset = "0x3580890", VA = "0x183581490")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x35813F0", Offset = "0x35807F0", VA = "0x1835813F0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3581440", Offset = "0x3580840", VA = "0x183581440")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3581610", Offset = "0x3580A10", VA = "0x183581610")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x35816E0", Offset = "0x3580AE0", VA = "0x1835816E0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3581540", Offset = "0x3580940", VA = "0x183581540")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3581140", Offset = "0x3580540", VA = "0x183581140")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x35810E0", Offset = "0x35804E0", VA = "0x1835810E0")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x35810C0", Offset = "0x35804C0", VA = "0x1835810C0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3581FF0", Offset = "0x35813F0", VA = "0x183581FF0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3581C20", Offset = "0x3581020", VA = "0x183581C20")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3582020", Offset = "0x3581420", VA = "0x183582020")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x35820E0", Offset = "0x35814E0", VA = "0x1835820E0")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[EDNMIOGDLLP]
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
			[Cpp2IlInjected.Address(RVA = "0x458C170", Offset = "0x458B570", VA = "0x18458C170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2555060", Offset = "0x2554460", VA = "0x182555060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xACB980", Offset = "0xACAD80", VA = "0x180ACB980")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D960", Offset = "0x4B3CD60", VA = "0x184B3D960")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4E92A30", Offset = "0x4E91E30", VA = "0x184E92A30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4E92B50", Offset = "0x4E91F50", VA = "0x184E92B50")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3990160", Offset = "0x398F560", VA = "0x183990160")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[EDNMIOGDLLP]
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
			[Cpp2IlInjected.Address(RVA = "0x4EE6550", Offset = "0x4EE5950", VA = "0x184EE6550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4EE6590", Offset = "0x4EE5990", VA = "0x184EE6590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xACB980", Offset = "0xACAD80", VA = "0x180ACB980")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D960", Offset = "0x4B3CD60", VA = "0x184B3D960")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4EE61B0", Offset = "0x4EE55B0", VA = "0x184EE61B0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4EE62F0", Offset = "0x4EE56F0", VA = "0x184EE62F0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4EE64B0", Offset = "0x4EE58B0", VA = "0x184EE64B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6330", Offset = "0x4EE5730", VA = "0x184EE6330")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[EDNMIOGDLLP]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[EDNMIOGDLLP]
public static class LNMBIPKJDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x74637A0", Offset = "0x7462BA0", VA = "0x1874637A0")]
	public static JobHandle HNIKNNELLAL(this JobHandle AMGCKABOOPF, JobHandle PPCFCAEIJMM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x74637E0", Offset = "0x7462BE0", VA = "0x1874637E0")]
	public static JobHandle JJAAMCHCLPC(this Span<JobHandle> FEJHOLHIAPJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FOAAFPIHHGH
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x337FC20", Offset = "0x337F020", VA = "0x18337FC20")]
	public static NativeKeyValueArrays<TKey, TValue> HBGANJMMBAD<TKey, TValue>(this Dictionary<TKey, TValue> EIEEOCBNIGD, Allocator LEILKJFLDFN) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class APIMBBEFLJL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7461FE0", Offset = "0x74613E0", VA = "0x187461FE0")]
	public static void DCMMGEFINKN(this GameObject HHDLNMHBJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7462120", Offset = "0x7461520", VA = "0x187462120")]
	public static void DCMMGEFINKN(this Component MEFMJJOMDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7462080", Offset = "0x7461480", VA = "0x187462080")]
	public static void DCMMGEFINKN(this ScriptableObject CKOHFGFHCIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GGDEPLJEGEK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7462F00", Offset = "0x7462300", VA = "0x187462F00")]
	public static void JLBOABPGIKD(this NativeList<byte> BHMKCPLLJPF, ReadOnlySpan<byte> CAGFJFFHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3394F10", Offset = "0x3394310", VA = "0x183394F10")]
	public static void GKAMGOGHNAO<T>(this NativeList<T> BHMKCPLLJPF, T KBGCCIOIGBD, int BBEJNKBNMID) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EKLCEMIBDIK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x322C450", Offset = "0x322B850", VA = "0x18322C450")]
	public static T NEHNPOHBODH<T>(this ReadOnlySpan<byte> KBGCCIOIGBD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x322BCE0", Offset = "0x322B0E0", VA = "0x18322BCE0")]
	public static T BLJNCGENIAP<T>(this Span<T> CAGFJFFHONE, Func<T, bool> AIHIPPFIJLI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x322C650", Offset = "0x322BA50", VA = "0x18322C650")]
	public static bool NJEKHJPFBEM<T>(this Span<T> CAGFJFFHONE, Func<T, bool> AIHIPPFIJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x322C3A0", Offset = "0x322B7A0", VA = "0x18322C3A0")]
	public static bool EMECIEAELEF<T>(this Span<T> CAGFJFFHONE, Func<T, bool> AIHIPPFIJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x322C700", Offset = "0x322BB00", VA = "0x18322C700")]
	public static T NPPDIJEBOHO<T>([In] this ReadOnlySpan<byte> CAGFJFFHONE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x322BE40", Offset = "0x322B240", VA = "0x18322BE40")]
	public static Span<TTo> CMDEJKOIBKH<TTo, TFrom>(this Span<TFrom> CAGFJFFHONE) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x322BE40", Offset = "0x322B240", VA = "0x18322BE40")]
	public static ReadOnlySpan<TTo> CMDEJKOIBKH<TTo, TFrom>(this ReadOnlySpan<TFrom> CAGFJFFHONE) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x322BE40", Offset = "0x322B240", VA = "0x18322BE40")]
	public static ReadOnlySpan<TTo> CMDEJKOIBKH<TTo>(this ReadOnlySpan<byte> CAGFJFFHONE) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x322BE90", Offset = "0x322B290", VA = "0x18322BE90")]
	public static Span<byte> ECFLGDLFBIO<T>([In] this Span<byte> CAGFJFFHONE, T KBGCCIOIGBD) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74628E0", Offset = "0x7461CE0", VA = "0x1874628E0")]
	private static Enum MCHNPDDCJEI([In] ReadOnlySpan<byte> CAGFJFFHONE, Type IEJJAFNKCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7462E90", Offset = "0x7462290", VA = "0x187462E90")]
	public static Enum MDJIJLHFHGI([In] this Span<byte> CAGFJFFHONE, Type IEJJAFNKCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74623D0", Offset = "0x74617D0", VA = "0x1874623D0")]
	public static void JEOKEBJLLNO([In] this Span<byte> CAGFJFFHONE, Enum JJFHAAOAACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JNCENHIHDLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IPABHDPNPGJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7463090", Offset = "0x7462490", VA = "0x187463090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74635C0", Offset = "0x74629C0", VA = "0x1874635C0")]
	[AsyncStateMachine(typeof(IPABHDPNPGJ))]
	public static void NAMLEHAPDOO(this Task CHBEBLKFDBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LBECJPEGAMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum EFNEDGACPCL : short
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

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct CMHCELEIKIE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly EFNEDGACPCL LKMGECEEGEE;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D860", Offset = "0x2B6CC60", VA = "0x182B6D860")]
		public CMHCELEIKIE(EFNEDGACPCL LKMGECEEGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory AJKIFLFMGBI;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	public static void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74636E0", Offset = "0x7462AE0", VA = "0x1874636E0")]
	static LBECJPEGAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x308A340", Offset = "0x3089740", VA = "0x18308A340")]
	public static CMHCELEIKIE BCMPJAIBHNF(EFNEDGACPCL LKMGECEEGEE)
	{
		return default(CMHCELEIKIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	public static void NGAFOAHPACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ABPKAFOEOHH
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B26AF0", Offset = "0x3B25EF0", VA = "0x183B26AF0")]
	public static PDLABPLNAOP<T1, T2> GJKBPIFNAEB<T1, T2>(this (T1, T2) IEFMBDGJEHE) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(PDLABPLNAOP<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x35B7AC0", Offset = "0x35B6EC0", VA = "0x1835B7AC0")]
	public static BKELICJOKPA<T1, T2, T3> GJKBPIFNAEB<T1, T2, T3>(this (T1, T2, T3) IEFMBDGJEHE) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(BKELICJOKPA<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PDLABPLNAOP<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) IEFMBDGJEHE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5080210", Offset = "0x507F610", VA = "0x185080210")]
	public PDLABPLNAOP((T1, T2) IEFMBDGJEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x507FE90", Offset = "0x507F290", VA = "0x18507FE90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BKELICJOKPA<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) IEFMBDGJEHE;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5080220", Offset = "0x507F620", VA = "0x185080220")]
	public BKELICJOKPA((T1, T2, T3) IEFMBDGJEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5848D40", Offset = "0x5848140", VA = "0x185848D40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OJOBBOEKOMG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7463A90", Offset = "0x7462E90", VA = "0x187463A90")]
	public static Range ILDEHEFLBGE(this AFAOEOIHAIH OLCJMBGBODB)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LCNCDDIAODD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct DFGFKHBGPJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int PCGMGDLNIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int PDNKBEEOLID;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x74623C0", Offset = "0x74617C0", VA = "0x1874623C0")]
		public DFGFKHBGPJF(int HHIGALLBHNK, int PDNKBEEOLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x74623B0", Offset = "0x74617B0", VA = "0x1874623B0")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7463750", Offset = "0x7462B50", VA = "0x187463750")]
	public static DFGFKHBGPJF BNIMLGJMJBK(this Range OLCJMBGBODB)
	{
		return default(DFGFKHBGPJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JEJGOOFIOCM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle ILIIBOPHLDK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OMELLALBLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x496BF00", Offset = "0x496B300", VA = "0x18496BF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x496C0B0", Offset = "0x496B4B0", VA = "0x18496C0B0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x496BC90", Offset = "0x496B090", VA = "0x18496BC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x496C160", Offset = "0x496B560", VA = "0x18496C160")]
	public JEJGOOFIOCM(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x496BF10", Offset = "0x496B310", VA = "0x18496BF10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class CMGKHFLMPCH<THandle, TValue> : IDisposable where THandle : struct, KBLKBJHICLE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> FEJHOLHIAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> BMKDAHEBDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> LIIDCFJPENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> LGOBFOJKGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int FADPNACOMMP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F8F0", Offset = "0x5C0ECF0", VA = "0x185C0F8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FE40", Offset = "0x5C0F240", VA = "0x185C0FE40")]
	public CMGKHFLMPCH(Action<TValue> LGOBFOJKGCH, [Optional] Func<TValue> LIIDCFJPENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F320", Offset = "0x5C0E720", VA = "0x185C0F320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F750", Offset = "0x5C0EB50", VA = "0x185C0F750")]
	public THandle HBHDBABAKDP(TValue KBGCCIOIGBD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FC10", Offset = "0x5C0F010", VA = "0x185C0FC10")]
	public bool MHAKNCNBNPL(THandle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F510", Offset = "0x5C0E910", VA = "0x185C0F510")]
	public bool FKKNKLKECHH(THandle ILIIBOPHLDK, [Out] TValue KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FDF0", Offset = "0x5C0F1F0", VA = "0x185C0FDF0")]
	public TValue NPPDIJEBOHO(THandle ILIIBOPHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F5E0", Offset = "0x5C0E9E0", VA = "0x185C0F5E0")]
	public bool GAJJJBGADKG(THandle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F6F0", Offset = "0x5C0EAF0", VA = "0x185C0F6F0")]
	private THandle GLJEICIMAEJ(int EAHKFAJBNDN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F890", Offset = "0x5C0EC90", VA = "0x185C0F890")]
	private TValue KBDHOHCCAKN(int EAHKFAJBNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F7F0", Offset = "0x5C0EBF0", VA = "0x185C0F7F0")]
	private void IMAPNKAICOL(int EAHKFAJBNDN, [In] THandle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F840", Offset = "0x5C0EC40", VA = "0x185C0F840")]
	private void INPBODAIAMI(int EAHKFAJBNDN, [In] TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F160", Offset = "0x5C0E560", VA = "0x185C0F160")]
	private THandle CFLAEGMIOFH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F3F0", Offset = "0x5C0E7F0", VA = "0x185C0F3F0")]
	private void EKEOGCPLEOI(THandle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F310", Offset = "0x5C0E710", VA = "0x185C0F310")]
	private int CKANCLANFDB(int EPKMALKPPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F500", Offset = "0x5C0E900", VA = "0x185C0F500")]
	private bool EPJLPDFGFGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x94B9F0", Offset = "0x94ADF0", VA = "0x18094B9F0")]
	private void GGHNFGMGMPM(THandle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FD40", Offset = "0x5C0F140", VA = "0x185C0FD40")]
	private bool MJBJCBCFDFF([Out] THandle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F930", Offset = "0x5C0ED30", VA = "0x185C0F930")]
	private bool LADECMHPOEK([Out] THandle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FA60", Offset = "0x5C0EE60", VA = "0x185C0FA60")]
	private void LGJECBMFPKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KBLKBJHICLE
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int EMCKBBMGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class GHLEINEKGDH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3396B00", Offset = "0x3395F00", VA = "0x183396B00")]
	public static bool CDIGNFEMAPE<T>(this T ILIIBOPHLDK, T OKCHLIEAIJP) where T : struct, KBLKBJHICLE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3396B20", Offset = "0x3395F20", VA = "0x183396B20")]
	public static bool DLCFPDABHIK<T>(this T ILIIBOPHLDK) where T : struct, KBLKBJHICLE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7462F80", Offset = "0x7462380", VA = "0x187462F80")]
	public static string AOHMNHJEEBA(this KBLKBJHICLE ILIIBOPHLDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public ref struct MCJIKLCEHHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type CGEBKNPACFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> JJPHGJAOIKO;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4B424A0", Offset = "0x4B418A0", VA = "0x184B424A0")]
	public MCJIKLCEHHO(Type JPONOFBEDEB, Span<byte> CAGFJFFHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x34B72C0", Offset = "0x34B66C0", VA = "0x1834B72C0")]
	public static MCJIKLCEHHO BIBMBKHCCLP<T>(T KBGCCIOIGBD) where T : struct
	{
		return default(MCJIKLCEHHO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7463920", Offset = "0x7462D20", VA = "0x187463920")]
	public static JIDNOMDMPBK HEGJABMHLEC([In] MCJIKLCEHHO FBIKENCMLKN)
	{
		return default(JIDNOMDMPBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x74639B0", Offset = "0x7462DB0", VA = "0x1874639B0")]
	public Enum MDJIJLHFHGI(Type IEJJAFNKCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x34B7C50", Offset = "0x34B7050", VA = "0x1834B7C50")]
	public void ECFLGDLFBIO<T>([In] T KBGCCIOIGBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x74639A0", Offset = "0x7462DA0", VA = "0x1874639A0")]
	public void JEOKEBJLLNO(Enum JJFHAAOAACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct JIDNOMDMPBK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct OJFOCGFODOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* APEAIFHAOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* OLMIKPCCIFF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type CGEBKNPACFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> JJPHGJAOIKO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ENBIOKPCFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7463260", Offset = "0x7462660", VA = "0x187463260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KDJLCLFKAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7463210", Offset = "0x7462610", VA = "0x187463210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4B424A0", Offset = "0x4B418A0", VA = "0x184B424A0")]
	public JIDNOMDMPBK(Type JPONOFBEDEB, ReadOnlySpan<byte> CAGFJFFHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3426460", Offset = "0x3425860", VA = "0x183426460")]
	public static JIDNOMDMPBK BIBMBKHCCLP<T>(T KBGCCIOIGBD) where T : struct
	{
		return default(JIDNOMDMPBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7463440", Offset = "0x7462840", VA = "0x187463440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7463270", Offset = "0x7462670", VA = "0x187463270")]
	public object KELOPMBBOJL(int EAHKFAJBNDN = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DBGDHCGFMPH
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x31FA2C0", Offset = "0x31F96C0", VA = "0x1831FA2C0")]
	public static NativeArray<T> BIBMBKHCCLP<T>(T KBGCCIOIGBD, bool PALJJFCJPCE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x31FA3D0", Offset = "0x31F97D0", VA = "0x1831FA3D0")]
	public static NativeArray<T> IBBPPCPNOLA<T>(T KBGCCIOIGBD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x31FA380", Offset = "0x31F9780", VA = "0x1831FA380")]
	public static NativeArray<T> GPJKILNJIOO<T>(T KBGCCIOIGBD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74622F0", Offset = "0x74616F0", VA = "0x1874622F0")]
	public static NativeArray<byte> GPJKILNJIOO(ReadOnlySpan<byte> KBGCCIOIGBD)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7462240", Offset = "0x7461640", VA = "0x187462240")]
	public static NativeArray<byte> BIBMBKHCCLP(ReadOnlySpan<byte> KBGCCIOIGBD, bool PALJJFCJPCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x74621C0", Offset = "0x74615C0", VA = "0x1874621C0")]
	public unsafe static NativeArray<byte> BIBMBKHCCLP(byte* IDAHGADPNKM, int GIGAFKHMOHH, bool PALJJFCJPCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x31FA310", Offset = "0x31F9710", VA = "0x1831FA310")]
	public static NativeArray<T> DGEEMDAPOEK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct OGDNAOAMJJL<Handle> where Handle : KBLKBJHICLE, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct HKNCJECFPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly OGDNAOAMJJL<Handle> DFPGJPGNKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Handle EDAHNBNCAEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x4628E00", Offset = "0x4628200", VA = "0x184628E00")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x46290E0", Offset = "0x46284E0", VA = "0x1846290E0")]
		public HKNCJECFPEM(OGDNAOAMJJL<Handle> DFPGJPGNKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4628CB0", Offset = "0x46280B0", VA = "0x184628CB0")]
		public HPNDEBFFHBG FEOBEKOIKMG([In] HPNDEBFFHBG MEBAFDHEDIN)
		{
			return default(HPNDEBFFHBG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4628A70", Offset = "0x4627E70", VA = "0x184628A70")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4628DA0", Offset = "0x46281A0", VA = "0x184628DA0")]
		private Handle FIBIOINKBBP(string MIALAMIFNLM)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct HPNDEBFFHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HKNCJECFPEM HAAEOILGJLD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x466E560", Offset = "0x466D960", VA = "0x18466E560")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x466E5E0", Offset = "0x466D9E0", VA = "0x18466E5E0")]
		public HPNDEBFFHBG(OGDNAOAMJJL<Handle> DFPGJPGNKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x466E4E0", Offset = "0x466D8E0", VA = "0x18466E4E0")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x466E470", Offset = "0x466D870", VA = "0x18466E470")]
		public HPNDEBFFHBG BNIMLGJMJBK()
		{
			return default(HPNDEBFFHBG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeList<int> IEDHOBIHJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<int> CBAHMKNCGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int BPJGJKNGDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int MOPCAPILDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool PDELIBIHBKB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JLPIJPCEGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4F9AF90", Offset = "0x4F9A390", VA = "0x184F9AF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HPNDEBFFHBG DOHKIOHAABD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4F9AC60", Offset = "0x4F9A060", VA = "0x184F9AC60")]
		get
		{
			return default(HPNDEBFFHBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B860", Offset = "0x4F9AC60", VA = "0x184F9B860")]
	public OGDNAOAMJJL(int ALOJAOINMGK, Allocator LEILKJFLDFN = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4F9AA40", Offset = "0x4F99E40", VA = "0x184F9AA40")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA2FA0", Offset = "0x1EA23A0", VA = "0x181EA2FA0")]
	public static int CKANCLANFDB(int EFDAGALIIFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA5C0", Offset = "0x2BA99C0", VA = "0x182BAA5C0")]
	public static bool DPFEFMJJMNM(int EFDAGALIIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4F9ACF0", Offset = "0x4F9A0F0", VA = "0x184F9ACF0")]
	public bool JDIHHNAAADB(int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B150", Offset = "0x4F9A550", VA = "0x184F9B150")]
	public bool LFDEKKFNDAO(Handle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A7C0", Offset = "0x4F99BC0", VA = "0x184F9A7C0")]
	public Handle DNPGFAAICNC()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F99CF0", Offset = "0x4F990F0", VA = "0x184F99CF0")]
	public void AMGEOOLHBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A3A0", Offset = "0x4F997A0", VA = "0x184F9A3A0")]
	public void BDCGGEAMIMP(Handle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60")]
	private bool HPDDBOHGAII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B570", Offset = "0x4F9A970", VA = "0x184F9B570")]
	private bool NFAFJFIOIBD(int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A410", Offset = "0x4F99810", VA = "0x184F9A410")]
	private void DNIDHMCDGHN([Out] int EAHKFAJBNDN, [Out] int EPKMALKPPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B420", Offset = "0x4F9A820", VA = "0x184F9B420")]
	private void LKCHNLDAAPK(Handle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F9ABC0", Offset = "0x4F99FC0", VA = "0x184F9ABC0")]
	private void GMLHACOCGBN(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B6E0", Offset = "0x4F9AAE0", VA = "0x184F9B6E0")]
	private bool OGHPJEGGALN([Out] int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A890", Offset = "0x4F99C90", VA = "0x184F9A890")]
	private static Handle ELBCCBGKJIO(int EAHKFAJBNDN, int EPKMALKPPHD)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public struct EIGPGNLJKGL<Handle, T> where Handle : KBLKBJHICLE, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private OGDNAOAMJJL<Handle> EKNOEAJIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] JFNIOBJOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Action<T> ICBKKFJOOIE;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4008C10", Offset = "0x4008010", VA = "0x184008C10")]
	public EIGPGNLJKGL(int ALOJAOINMGK, [Optional] Action<T> ICBKKFJOOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4007F90", Offset = "0x4007390", VA = "0x184007F90")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4007E60", Offset = "0x4007260", VA = "0x184007E60")]
	public bool FKKNKLKECHH(Handle ILIIBOPHLDK, [Out] T GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4008010", Offset = "0x4007410", VA = "0x184008010")]
	public Handle HBHDBABAKDP(T GMFKPONAANG)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4008350", Offset = "0x4007750", VA = "0x184008350")]
	public void LMPMJJEOBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4008880", Offset = "0x4007C80", VA = "0x184008880")]
	public void OCDDHDAHAOD(Handle ILIIBOPHLDK, [Out] T HEEPFINKPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x40087B0", Offset = "0x4007BB0", VA = "0x1840087B0")]
	public void OCDDHDAHAOD(Handle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4008230", Offset = "0x4007630", VA = "0x184008230")]
	private T IKJELBOAPFN(int EAHKFAJBNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4008290", Offset = "0x4007690", VA = "0x184008290")]
	private void JMCNAKAKFPM(int ENCJEFBIFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public struct JLFIEIINFCM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LAKENFPFPMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private JLFIEIINFCM<T> CJFOOLJEHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4B45310", Offset = "0x4B44710", VA = "0x184B45310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x257FA90", Offset = "0x257EE90", VA = "0x18257FA90")]
		public LAKENFPFPMK(JLFIEIINFCM<T> CJFOOLJEHLK, int EAHKFAJBNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B452C0", Offset = "0x4B446C0", VA = "0x184B452C0")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OPJIBDHPGHD : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JLFIEIINFCM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public OPJIBDHPGHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4FD4600", Offset = "0x4FD3A00", VA = "0x184FD4600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4FD46A0", Offset = "0x4FD3AA0", VA = "0x184FD46A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OPNMKPPOPMO : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JLFIEIINFCM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public OPNMKPPOPMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4FD46F0", Offset = "0x4FD3AF0", VA = "0x184FD46F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4FD4790", Offset = "0x4FD3B90", VA = "0x184FD4790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private object[] GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private uint KBGCCIOIGBD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x497BDB0", Offset = "0x497B1B0", VA = "0x18497BDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x497B3C0", Offset = "0x497A7C0", VA = "0x18497B3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x14FB340", Offset = "0x14FA740", VA = "0x1814FB340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal bool NLLLLJCPONE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x497B340", Offset = "0x497A740", VA = "0x18497B340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PBNFEBACEHD<T> JJPHGJAOIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x497B780", Offset = "0x497AB80", VA = "0x18497B780")]
		get
		{
			return default(PBNFEBACEHD<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x497B980", Offset = "0x497AD80", VA = "0x18497B980")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x497B4D0", Offset = "0x497A8D0", VA = "0x18497B4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x497C010", Offset = "0x497B410", VA = "0x18497C010")]
	internal JLFIEIINFCM(JLFIEIINFCM<T> CJFOOLJEHLK, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x497C030", Offset = "0x497B430", VA = "0x18497C030")]
	private JLFIEIINFCM(T[] CJFOOLJEHLK, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x497C050", Offset = "0x497B450", VA = "0x18497C050")]
	public JLFIEIINFCM(IEnumerable<T> BMKDAHEBDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x497BFA0", Offset = "0x497B3A0", VA = "0x18497BFA0")]
	public JLFIEIINFCM(int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x497B660", Offset = "0x497AA60", VA = "0x18497B660")]
	public int FBHOADIJODJ(T KBGCCIOIGBD, int HHIGALLBHNK, int BBEJNKBNMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x497BD70", Offset = "0x497B170", VA = "0x18497BD70")]
	public void PLHNLDBAEHM(int JEDDAOEOEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x497BA50", Offset = "0x497AE50", VA = "0x18497BA50")]
	private void NJDFGCLIKLM(int JEDDAOEOEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x497B900", Offset = "0x497AD00", VA = "0x18497B900")]
	public T[] KCDBGCDLIIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x497BC20", Offset = "0x497B020", VA = "0x18497BC20")]
	public T[] OMBEABDDNID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x497B450", Offset = "0x497A850", VA = "0x18497B450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x497B580", Offset = "0x497A980", VA = "0x18497B580")]
	public void EEBKPKCHGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x497B350", Offset = "0x497A750", VA = "0x18497B350")]
	public LAKENFPFPMK BNIMLGJMJBK()
	{
		return default(LAKENFPFPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x497BDC0", Offset = "0x497B1C0", VA = "0x18497BDC0", Slot = "5")]
	[IteratorStateMachine(typeof(JLFIEIINFCM<>.OPJIBDHPGHD))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x497BEB0", Offset = "0x497B2B0", VA = "0x18497BEB0", Slot = "6")]
	[IteratorStateMachine(typeof(JLFIEIINFCM<>.OPNMKPPOPMO))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x497B3F0", Offset = "0x497A7F0", VA = "0x18497B3F0")]
	public static JLFIEIINFCM<T> CFHFHHCEJLA(T[] CJFOOLJEHLK)
	{
		return default(JLFIEIINFCM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x497B6E0", Offset = "0x497AAE0", VA = "0x18497B6E0")]
	public static JLFIEIINFCM<T> HEGJABMHLEC(T[] CJFOOLJEHLK)
	{
		return default(JLFIEIINFCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x497B5E0", Offset = "0x497A9E0", VA = "0x18497B5E0")]
	private void EGKGAANGNIA(int EAHKFAJBNDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class EFMCPKJOHAF<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct IHGAFFHLEAP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EFMCPKJOHAF<T> BHMKCPLLJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4721140", Offset = "0x4720540", VA = "0x184721140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4721180", Offset = "0x4720580", VA = "0x184721180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x409D920", Offset = "0x409CD20", VA = "0x18409D920")]
		public IHGAFFHLEAP(EFMCPKJOHAF<T> BHMKCPLLJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4721050", Offset = "0x4720450", VA = "0x184721050", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x47210F0", Offset = "0x47204F0", VA = "0x1847210F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private JLFIEIINFCM<T> GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int GIGAFKHMOHH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE8E0", Offset = "0x3FFDCE0", VA = "0x183FFE8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE270", Offset = "0x3FFD670", VA = "0x183FFE270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int JLPIJPCEGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE640", Offset = "0x3FFDA40", VA = "0x183FFE640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE8C0", Offset = "0x3FFDCC0", VA = "0x183FFE8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PBNFEBACEHD<T> JJPHGJAOIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE4E0", Offset = "0x3FFD8E0", VA = "0x183FFE4E0")]
		get
		{
			return default(PBNFEBACEHD<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEB60", Offset = "0x3FFDF60", VA = "0x183FFEB60")]
	public EFMCPKJOHAF(IEnumerable<T> BMKDAHEBDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEAF0", Offset = "0x3FFDEF0", VA = "0x183FFEAF0")]
	public EFMCPKJOHAF(int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE950", Offset = "0x3FFDD50", VA = "0x183FFE950")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE880", Offset = "0x3FFDC80", VA = "0x183FFE880")]
	public JLFIEIINFCM<T> JMMFOEIKCJJ()
	{
		return default(JLFIEIINFCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE2B0", Offset = "0x3FFD6B0", VA = "0x183FFE2B0")]
	public void HBHDBABAKDP(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEA00", Offset = "0x3FFDE00", VA = "0x183FFEA00")]
	private void PLHNLDBAEHM(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE660", Offset = "0x3FFDA60", VA = "0x183FFE660")]
	public void JLBOABPGIKD(List<T> BHJLHIOPPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE7E0", Offset = "0x3FFDBE0", VA = "0x183FFE7E0")]
	public void JLBOABPGIKD(T[] BHJLHIOPPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE560", Offset = "0x3FFD960", VA = "0x183FFE560")]
	public void JFBBKNCFILH(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3FFDBF0", Offset = "0x3FFCFF0", VA = "0x183FFDBF0")]
	public void BMPFKKHNCGP(int LMPADJBGAAM, int PDNKBEEOLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3FFDF30", Offset = "0x3FFD330", VA = "0x183FFDF30")]
	public int FBHOADIJODJ(T KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE3D0", Offset = "0x3FFD7D0", VA = "0x183FFE3D0")]
	public bool HBIAGPPOPJF(T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE990", Offset = "0x3FFDD90", VA = "0x183FFE990")]
	public T[] OMBEABDDNID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3FFDF10", Offset = "0x3FFD310", VA = "0x183FFDF10", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE420", Offset = "0x3FFD820", VA = "0x183FFE420")]
	public static JLFIEIINFCM<T> HEGJABMHLEC(EFMCPKJOHAF<T> BHMKCPLLJPF)
	{
		return default(JLFIEIINFCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3FFE200", Offset = "0x3FFD600", VA = "0x183FFE200", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEA40", Offset = "0x3FFDE40", VA = "0x183FFEA40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEA80", Offset = "0x3FFDE80", VA = "0x183FFEA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3FFDDC0", Offset = "0x3FFD1C0", VA = "0x183FFDDC0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DIJOOPFNHKC(int KBGCCIOIGBD, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3FFDFB0", Offset = "0x3FFD3B0", VA = "0x183FFDFB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void FCICMLALJCK(int LMPADJBGAAM, int PDNKBEEOLID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class CLEFMLOBIHF
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x31C4790", Offset = "0x31C3B90", VA = "0x1831C4790")]
	public static void EEBKPKCHGJJ<T>(this EFMCPKJOHAF<T> BHMKCPLLJPF) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public ref struct PBNFEBACEHD<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Span<object> GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x507BE20", Offset = "0x507B220", VA = "0x18507BE20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x507BD50", Offset = "0x507B150", VA = "0x18507BD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x507C050", Offset = "0x507B450", VA = "0x18507C050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public PBNFEBACEHD(Span<object> CAGFJFFHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x507BEA0", Offset = "0x507B2A0", VA = "0x18507BEA0")]
	public PBNFEBACEHD<T> LDOCMGHKFNG(int HHIGALLBHNK)
	{
		return default(PBNFEBACEHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x507BF70", Offset = "0x507B370", VA = "0x18507BF70")]
	public PBNFEBACEHD<T> LDOCMGHKFNG(int HHIGALLBHNK, int GIGAFKHMOHH)
	{
		return default(PBNFEBACEHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x507BCF0", Offset = "0x507B0F0", VA = "0x18507BCF0")]
	public void DCNHFJIJBBF(PBNFEBACEHD<T> MLMIGGIAIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x507C090", Offset = "0x507B490", VA = "0x18507C090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x507BD80", Offset = "0x507B180", VA = "0x18507BD80", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x507BDD0", Offset = "0x507B1D0", VA = "0x18507BDD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct AFAOEOIHAIH : IEquatable<AFAOEOIHAIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int FDJGEFDKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int BBEJNKBNMID;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int MBLKEEKGIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B85210", Offset = "0x2B84610", VA = "0x182B85210")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x675E500", Offset = "0x675D900", VA = "0x18675E500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BFKEFBLNOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int BMHADMIFCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7461F40", Offset = "0x7461340", VA = "0x187461F40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7461ED0", Offset = "0x74612D0", VA = "0x187461ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public (int begin, int end) NJEGBGKCJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7461EE0", Offset = "0x74612E0", VA = "0x187461EE0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
	private AFAOEOIHAIH(int FDJGEFDKBBO, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2564A70", Offset = "0x2563E70", VA = "0x182564A70")]
	public static AFAOEOIHAIH KCCEFNCOCIC(int FDJGEFDKBBO, int BBEJNKBNMID)
	{
		return default(AFAOEOIHAIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7461E30", Offset = "0x7461230", VA = "0x187461E30")]
	public static AFAOEOIHAIH ACIIKDEHCMN(int HHIGALLBHNK, int PDNKBEEOLID)
	{
		return default(AFAOEOIHAIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7461F50", Offset = "0x7461350", VA = "0x187461F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1681370", Offset = "0x1680770", VA = "0x181681370", Slot = "4")]
	public bool Equals(AFAOEOIHAIH OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7461E40", Offset = "0x7461240", VA = "0x187461E40", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x68BE450", Offset = "0x68BD850", VA = "0x1868BE450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PLFMFBLNNFB<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NativeArray<T> GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public PLFMFBLNNFB(NativeArray<T> GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x50ACB50", Offset = "0x50ABF50", VA = "0x1850ACB50", Slot = "6")]
	public int Compare(int IKAEODCKAIP, int ACCJFOPIMAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x50ACC40", Offset = "0x50AC040", VA = "0x1850ACC40", Slot = "4")]
	public bool Equals(int IKAEODCKAIP, int ACCJFOPIMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x50ACD30", Offset = "0x50AC130", VA = "0x1850ACD30", Slot = "5")]
	public int GetHashCode(int IKAEODCKAIP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MFKDGFIANHO
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x34BE660", Offset = "0x34BDA60", VA = "0x1834BE660")]
	public static T[] GEHKPALOLCO<T>(List<T> BHMKCPLLJPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MDJGHHKHMIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* DPHPPGLEIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal AllocatorManager.AllocatorHandle OFIGJAJEHHD;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54C2210", Offset = "0x54C1610", VA = "0x1854C2210")]
	public void GDCMIOJAIMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DJPPAONDOIH
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3208300", Offset = "0x3207700", VA = "0x183208300")]
	public static MDJGHHKHMIF BPCCLCENHJA<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> JAGFBALGAPL) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(MDJGHHKHMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3208300", Offset = "0x3207700", VA = "0x183208300")]
	public static UnsafeParallelHashMap<TKey, TValue> FGOEKJJOLFI<TKey, TValue>(this MDJGHHKHMIF JAGFBALGAPL) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MANMMJOBDIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x34B6BE0", Offset = "0x34B5FE0", VA = "0x1834B6BE0")]
	public static int JKBHAJNPHJH<T>(ReadOnlySpan<T> IHKMBGJFAJG, ReadOnlySpan<T> LOGJMEEGKLF, int GIGAFKHMOHH) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KBHCBKICLGD
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x344CDE0", Offset = "0x344C1E0", VA = "0x18344CDE0")]
	public static T ECCIGIDPGHK<T>(this NativeArray<byte> MOEBIEOOLFC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x344CE70", Offset = "0x344C270", VA = "0x18344CE70")]
	public static NativeArray<T> GCIKDJEKOFO<T>(this NativeArray<byte> MOEBIEOOLFC, int BBEJNKBNMID) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x344D330", Offset = "0x344C730", VA = "0x18344D330")]
	public static void KAOFGLNGLFA<T>(this NativeList<byte> JEFFDGNDMGE, [In] T KBGCCIOIGBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x344D290", Offset = "0x344C690", VA = "0x18344D290")]
	public static void KAOFGLNGLFA<T>(this NativeList<byte> JEFFDGNDMGE, NativeArray<T> KBGCCIOIGBD) where T : struct
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

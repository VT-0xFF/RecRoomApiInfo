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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7883620", Offset = "0x7882A20", VA = "0x187883620", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[MDNIADKOPPG]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x37CD940", Offset = "0x37CCD40", VA = "0x1837CD940")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[MDNIADKOPPG]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x37D2CE0", Offset = "0x37D20E0", VA = "0x1837D2CE0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37D29F0", Offset = "0x37D1DF0", VA = "0x1837D29F0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x37D2BA0", Offset = "0x37D1FA0", VA = "0x1837D2BA0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x37D3370", Offset = "0x37D2770", VA = "0x1837D3370")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x37CDA10", Offset = "0x37CCE10", VA = "0x1837CDA10")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x37CDAF0", Offset = "0x37CCEF0", VA = "0x1837CDAF0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37CE000", Offset = "0x37CD400", VA = "0x1837CE000")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, GIEALLIDLLC range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37CE040", Offset = "0x37CD440", VA = "0x1837CE040")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x37CDE70", Offset = "0x37CD270", VA = "0x1837CDE70")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37D2AE0", Offset = "0x37D1EE0", VA = "0x1837D2AE0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[MDNIADKOPPG]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37D6E40", Offset = "0x37D6240", VA = "0x1837D6E40")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x37D8AA0", Offset = "0x37D7EA0", VA = "0x1837D8AA0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x37D6D80", Offset = "0x37D6180", VA = "0x1837D6D80")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37D7220", Offset = "0x37D6620", VA = "0x1837D7220")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x37D9C70", Offset = "0x37D9070", VA = "0x1837D9C70")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37D9C20", Offset = "0x37D9020", VA = "0x1837D9C20")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4703CF0", Offset = "0x47030F0", VA = "0x184703CF0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7883C90", Offset = "0x7883090", VA = "0x187883C90")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7883CC0", Offset = "0x78830C0", VA = "0x187883CC0")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37D9310", Offset = "0x37D8710", VA = "0x1837D9310")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x37D9100", Offset = "0x37D8500", VA = "0x1837D9100")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37D9370", Offset = "0x37D8770", VA = "0x1837D9370")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37D9270", Offset = "0x37D8670", VA = "0x1837D9270")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x37D92C0", Offset = "0x37D86C0", VA = "0x1837D92C0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37D9060", Offset = "0x37D8460", VA = "0x1837D9060")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37D95F0", Offset = "0x37D89F0", VA = "0x1837D95F0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x37D9450", Offset = "0x37D8850", VA = "0x1837D9450")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37D9150", Offset = "0x37D8550", VA = "0x1837D9150")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x37D9000", Offset = "0x37D8400", VA = "0x1837D9000")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37D8FE0", Offset = "0x37D83E0", VA = "0x1837D8FE0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37DA050", Offset = "0x37D9450", VA = "0x1837DA050")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x37D9C80", Offset = "0x37D9080", VA = "0x1837D9C80")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37DA080", Offset = "0x37D9480", VA = "0x1837DA080")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x37DA140", Offset = "0x37D9540", VA = "0x1837DA140")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[MDNIADKOPPG]
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
			[Cpp2IlInjected.Address(RVA = "0x48C1810", Offset = "0x48C0C10", VA = "0x1848C1810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD18FD0", Offset = "0xD183D0", VA = "0x180D18FD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB9CB20", Offset = "0xB9BF20", VA = "0x180B9CB20")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4E098D0", Offset = "0x4E08CD0", VA = "0x184E098D0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x50F1330", Offset = "0x50F0730", VA = "0x1850F1330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x50F1930", Offset = "0x50F0D30", VA = "0x1850F1930")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB44F0", Offset = "0x3BB38F0", VA = "0x183BB44F0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[MDNIADKOPPG]
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
			[Cpp2IlInjected.Address(RVA = "0x48C1810", Offset = "0x48C0C10", VA = "0x1848C1810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x514F0C0", Offset = "0x514E4C0", VA = "0x18514F0C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB9CB20", Offset = "0xB9BF20", VA = "0x180B9CB20")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4E098D0", Offset = "0x4E08CD0", VA = "0x184E098D0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x514EC40", Offset = "0x514E040", VA = "0x18514EC40")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x514EDF0", Offset = "0x514E1F0", VA = "0x18514EDF0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x514EF00", Offset = "0x514E300", VA = "0x18514EF00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x514EFF0", Offset = "0x514E3F0", VA = "0x18514EFF0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[MDNIADKOPPG]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[MDNIADKOPPG]
public static class DAMJBDCDEMO
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x78824C0", Offset = "0x78818C0", VA = "0x1878824C0")]
	public static JobHandle OENPBPJFBKL(this JobHandle PCMHLCLONGN, JobHandle IAJJOLNCJOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7882410", Offset = "0x7881810", VA = "0x187882410")]
	public static JobHandle DGKKPDKMODG(this Span<JobHandle> JGEIDAMJLAD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PFBFGKICCLN
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x380FBA0", Offset = "0x380EFA0", VA = "0x18380FBA0")]
	public static NativeKeyValueArrays<TKey, TValue> GMBDOLMBAOG<TKey, TValue>(this Dictionary<TKey, TValue> JLLDPNEPEEK, Allocator JMEGNHGDHIA) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MMFEIJBEGIE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7883860", Offset = "0x7882C60", VA = "0x187883860")]
	public static void FIDGOFLNEPF(this GameObject GIIGFIAPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x78839A0", Offset = "0x7882DA0", VA = "0x1878839A0")]
	public static void FIDGOFLNEPF(this Component DMJKAPFLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7883900", Offset = "0x7882D00", VA = "0x187883900")]
	public static void FIDGOFLNEPF(this ScriptableObject CPAKJFLJKMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MKLFOMHKEBE
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x78836B0", Offset = "0x7882AB0", VA = "0x1878836B0")]
	public static void KJPCKFGIEPN(this NativeList<byte> CEFIHBLEFNG, ReadOnlySpan<byte> BGFHEKCGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37263F0", Offset = "0x37257F0", VA = "0x1837263F0")]
	public static void BMKPIHBENHF<T>(this NativeList<T> CEFIHBLEFNG, T FFOEEMKIKJO, int ECKHNAPCKGD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KIJFNCAEIKM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36C9AB0", Offset = "0x36C8EB0", VA = "0x1836C9AB0")]
	public static T MKICJFAIPFG<T>(this ReadOnlySpan<byte> FFOEEMKIKJO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36C8EF0", Offset = "0x36C82F0", VA = "0x1836C8EF0")]
	public static T IHENIMNENIN<T>(this Span<T> BGFHEKCGLFH, Func<T, bool> MECCCCBLPIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36C8D90", Offset = "0x36C8190", VA = "0x1836C8D90")]
	public static bool BNKNLEKIIAJ<T>(this Span<T> BGFHEKCGLFH, Func<T, bool> MECCCCBLPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36C8E40", Offset = "0x36C8240", VA = "0x1836C8E40")]
	public static bool FLKJNJEHKOH<T>(this Span<T> BGFHEKCGLFH, Func<T, bool> MECCCCBLPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36C9050", Offset = "0x36C8450", VA = "0x1836C9050")]
	public static T IOLMGDEDCOJ<T>([In] this ReadOnlySpan<byte> BGFHEKCGLFH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3375120", Offset = "0x3374520", VA = "0x183375120")]
	public static Span<TTo> IDKNKAINIJK<TTo, TFrom>(this Span<TFrom> BGFHEKCGLFH) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3375120", Offset = "0x3374520", VA = "0x183375120")]
	public static ReadOnlySpan<TTo> IDKNKAINIJK<TTo, TFrom>(this ReadOnlySpan<TFrom> BGFHEKCGLFH) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3375120", Offset = "0x3374520", VA = "0x183375120")]
	public static ReadOnlySpan<TTo> IDKNKAINIJK<TTo>(this ReadOnlySpan<byte> BGFHEKCGLFH) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36C95A0", Offset = "0x36C89A0", VA = "0x1836C95A0")]
	public static Span<byte> JFGGMENNDNP<T>([In] this Span<byte> BGFHEKCGLFH, T FFOEEMKIKJO) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7883020", Offset = "0x7882420", VA = "0x187883020")]
	private static Enum PIGHBJMHBOJ([In] ReadOnlySpan<byte> BGFHEKCGLFH, Type JBNOGMDBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7882AD0", Offset = "0x7881ED0", VA = "0x187882AD0")]
	public static Enum AFDKDGHCFCH([In] this Span<byte> BGFHEKCGLFH, Type JBNOGMDBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7882B40", Offset = "0x7881F40", VA = "0x187882B40")]
	public static void BAKNINPOMCH([In] this Span<byte> BGFHEKCGLFH, Enum OEAPKNBFGIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IDGHPBBDDAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NNFIMGJMJGN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7883B10", Offset = "0x7882F10", VA = "0x187883B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9F4FB0", Offset = "0x9F43B0", VA = "0x1809F4FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x78827C0", Offset = "0x7881BC0", VA = "0x1878827C0")]
	[AsyncStateMachine(typeof(NNFIMGJMJGN))]
	public static void NBPDAKGKOMJ(this Task OOLNPDLPIEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MOCNEELALJE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PAEFHBPEPCE : short
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
	public struct AGPJLCPDGFD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly PAEFHBPEPCE DJBLFBEBKGO;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2CA53E0", Offset = "0x2CA47E0", VA = "0x182CA53E0")]
		public AGPJLCPDGFD(PAEFHBPEPCE DJBLFBEBKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory CMAMNCPNLFL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	public static void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7883A40", Offset = "0x7882E40", VA = "0x187883A40")]
	static MOCNEELALJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x32A9B50", Offset = "0x32A8F50", VA = "0x1832A9B50")]
	public static AGPJLCPDGFD GBKDKALCALN(PAEFHBPEPCE DJBLFBEBKGO)
	{
		return default(AGPJLCPDGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	public static void ELABNEBMAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OFLJHFBNOBK
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x37F3CE0", Offset = "0x37F30E0", VA = "0x1837F3CE0")]
	public static AIKJFIOOKIH<T1, T2> EHANHKPHNHP<T1, T2>(this (T1, T2) DCMKKNIGNIA) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(AIKJFIOOKIH<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x35F3A60", Offset = "0x35F2E60", VA = "0x1835F3A60")]
	public static KOBEJCIENHO<T1, T2, T3> EHANHKPHNHP<T1, T2, T3>(this (T1, T2, T3) DCMKKNIGNIA) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(KOBEJCIENHO<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct AIKJFIOOKIH<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) DCMKKNIGNIA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x48DFC70", Offset = "0x48DF070", VA = "0x1848DFC70")]
	public AIKJFIOOKIH((T1, T2) DCMKKNIGNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x48DF8D0", Offset = "0x48DECD0", VA = "0x1848DF8D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KOBEJCIENHO<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) DCMKKNIGNIA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x48DFC50", Offset = "0x48DF050", VA = "0x1848DFC50")]
	public KOBEJCIENHO((T1, T2, T3) DCMKKNIGNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D92740", Offset = "0x4D91B40", VA = "0x184D92740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NBGAIALIGCE
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7883AB0", Offset = "0x7882EB0", VA = "0x187883AB0")]
	public static Range HJDNPFPENGN(this GIEALLIDLLC KEDOGBHAGPB)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KLDBEFFLMIH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct MLFELMHHMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int OBGLHJKOJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int FNNKAHMFNCJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7883740", Offset = "0x7882B40", VA = "0x187883740")]
		public MLFELMHHMOA(int HCJENEHBBIC, int FNNKAHMFNCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7883730", Offset = "0x7882B30", VA = "0x187883730")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x78835D0", Offset = "0x78829D0", VA = "0x1878835D0")]
	public static MLFELMHHMOA DBEEDGEHMMA(this Range KEDOGBHAGPB)
	{
		return default(MLFELMHHMOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FEADOCLIOOK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle GGBKPDHLOJF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FLPBCAMFFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4703D20", Offset = "0x4703120", VA = "0x184703D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4703730", Offset = "0x4702B30", VA = "0x184703730")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4703A80", Offset = "0x4702E80", VA = "0x184703A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4703E20", Offset = "0x4703220", VA = "0x184703E20")]
	public FEADOCLIOOK(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4703CF0", Offset = "0x47030F0", VA = "0x184703CF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class IGHFGDGAJBN<THandle, TValue> : IDisposable where THandle : struct, PFGKJOCFDIP where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> JGEIDAMJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> JGMAGBDHLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> PDPLEMLLMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> BDIBKGEPJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int CIGPFLOOLOA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x49E7120", Offset = "0x49E6520", VA = "0x1849E7120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x49E7CF0", Offset = "0x49E70F0", VA = "0x1849E7CF0")]
	public IGHFGDGAJBN(Action<TValue> BDIBKGEPJCN, [Optional] Func<TValue> PDPLEMLLMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x49E7160", Offset = "0x49E6560", VA = "0x1849E7160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x49E7920", Offset = "0x49E6D20", VA = "0x1849E7920")]
	public THandle JJBKLNLGAIJ(TValue FFOEEMKIKJO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x49E7BA0", Offset = "0x49E6FA0", VA = "0x1849E7BA0")]
	public bool OAHDOECNNKP(THandle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x49E7430", Offset = "0x49E6830", VA = "0x1849E7430")]
	public bool GLKKFIAAGGI(THandle GGBKPDHLOJF, [Out] TValue FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x49E78D0", Offset = "0x49E6CD0", VA = "0x1849E78D0")]
	public TValue IOLMGDEDCOJ(THandle GGBKPDHLOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49E7010", Offset = "0x49E6410", VA = "0x1849E7010")]
	public bool BGMHGMOKIKN(THandle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x49E75B0", Offset = "0x49E69B0", VA = "0x1849E75B0")]
	private THandle HGDMAMHMFAO(int CJFNAFNJJLB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x49E7A10", Offset = "0x49E6E10", VA = "0x1849E7A10")]
	private TValue MLACMEICEMO(int CJFNAFNJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49E79C0", Offset = "0x49E6DC0", VA = "0x1849E79C0")]
	private void KLOHBJBDCAD(int CJFNAFNJJLB, [In] THandle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x49E73E0", Offset = "0x49E67E0", VA = "0x1849E73E0")]
	private void GBGCNCIFPPL(int CJFNAFNJJLB, [In] TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x49E7230", Offset = "0x49E6630", VA = "0x1849E7230")]
	private THandle GBEBNLNKHEK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x49E7610", Offset = "0x49E6A10", VA = "0x1849E7610")]
	private void IAFJCNDGLFN(THandle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x49E7CE0", Offset = "0x49E70E0", VA = "0x1849E7CE0")]
	private int PIKPCKFEKPG(int IOFNCNFBMGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x49E7CD0", Offset = "0x49E70D0", VA = "0x1849E7CD0")]
	private bool OIEPOBJFCJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x99A280", Offset = "0x999680", VA = "0x18099A280")]
	private void INKPKNPMFHK(THandle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49E7500", Offset = "0x49E6900", VA = "0x1849E7500")]
	private bool HAKOHOONAAH([Out] THandle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49E7A70", Offset = "0x49E6E70", VA = "0x1849E7A70")]
	private bool NCIAHJBGBCE([Out] THandle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x49E7720", Offset = "0x49E6B20", VA = "0x1849E7720")]
	private void IJNOHGNHBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PFGKJOCFDIP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int EGOLIAJEBDH
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
public static class DCECLNGJLNP
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x343A860", Offset = "0x3439C60", VA = "0x18343A860")]
	public static bool EGBCCLIGMMM<T>(this T GGBKPDHLOJF, T KNCKFHOKGJM) where T : struct, PFGKJOCFDIP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x343A880", Offset = "0x3439C80", VA = "0x18343A880")]
	public static bool PNPLPCMDCBA<T>(this T GGBKPDHLOJF) where T : struct, PFGKJOCFDIP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7882500", Offset = "0x7881900", VA = "0x187882500")]
	public static string KOFAFINMIGB(this PFGKJOCFDIP GGBKPDHLOJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public ref struct MMCAHBLJMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type BLPEHEPGJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> MPDMFCNAFMB;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4E10590", Offset = "0x4E0F990", VA = "0x184E10590")]
	public MMCAHBLJMAC(Type BLPOIAMMJHJ, Span<byte> BGFHEKCGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37266F0", Offset = "0x3725AF0", VA = "0x1837266F0")]
	public static MMCAHBLJMAC NFJOOPGCIPO<T>(T FFOEEMKIKJO) where T : struct
	{
		return default(MMCAHBLJMAC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x78837E0", Offset = "0x7882BE0", VA = "0x1878837E0")]
	public static OEMNHEJOOLM CLMIANKGGAM([In] MMCAHBLJMAC IEDBNFIMLNL)
	{
		return default(OEMNHEJOOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7883750", Offset = "0x7882B50", VA = "0x187883750")]
	public Enum AFDKDGHCFCH(Type JBNOGMDBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37266B0", Offset = "0x3725AB0", VA = "0x1837266B0")]
	public void JFGGMENNDNP<T>([In] T FFOEEMKIKJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x78837D0", Offset = "0x7882BD0", VA = "0x1878837D0")]
	public void BAKNINPOMCH(Enum OEAPKNBFGIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct OEMNHEJOOLM
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct CJDLLGEDCGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* DIBPPNFCEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* GHLFDDFLBOK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type BLPEHEPGJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> MPDMFCNAFMB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NFAPPIKJDMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7883F10", Offset = "0x7883310", VA = "0x187883F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int AODCCKACEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7883EC0", Offset = "0x78832C0", VA = "0x187883EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E10590", Offset = "0x4E0F990", VA = "0x184E10590")]
	public OEMNHEJOOLM(Type BLPOIAMMJHJ, ReadOnlySpan<byte> BGFHEKCGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37F2310", Offset = "0x37F1710", VA = "0x1837F2310")]
	public static OEMNHEJOOLM NFJOOPGCIPO<T>(T FFOEEMKIKJO) where T : struct
	{
		return default(OEMNHEJOOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7883F20", Offset = "0x7883320", VA = "0x187883F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7883CF0", Offset = "0x78830F0", VA = "0x187883CF0")]
	public object BEEIPIJNFIF(int CJFNAFNJJLB = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JNBFEBABKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x367E200", Offset = "0x367D600", VA = "0x18367E200")]
	public static NativeArray<T> NFJOOPGCIPO<T>(T FFOEEMKIKJO, bool GPPDNEDPIAM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x367E1B0", Offset = "0x367D5B0", VA = "0x18367E1B0")]
	public static NativeArray<T> KLGMHHPMCPJ<T>(T FFOEEMKIKJO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x367E0F0", Offset = "0x367D4F0", VA = "0x18367E0F0")]
	public static NativeArray<T> EECPPLFOAGA<T>(T FFOEEMKIKJO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x78828E0", Offset = "0x7881CE0", VA = "0x1878828E0")]
	public static NativeArray<byte> EECPPLFOAGA(ReadOnlySpan<byte> FFOEEMKIKJO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x78829A0", Offset = "0x7881DA0", VA = "0x1878829A0")]
	public static NativeArray<byte> NFJOOPGCIPO(ReadOnlySpan<byte> FFOEEMKIKJO, bool GPPDNEDPIAM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7882A50", Offset = "0x7881E50", VA = "0x187882A50")]
	public unsafe static NativeArray<byte> NFJOOPGCIPO(byte* EOMGFLGAEJK, int BFBCILDCBHG, bool GPPDNEDPIAM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x367E140", Offset = "0x367D540", VA = "0x18367E140")]
	public static NativeArray<T> GBADJOAJCAL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KIHLKBLGLBJ<Handle> where Handle : PFGKJOCFDIP, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct OOAMFFCEJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly KIHLKBLGLBJ<Handle> LHNFDMCLNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Handle JJIFNMNPGIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5200790", Offset = "0x51FFB90", VA = "0x185200790")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5200B30", Offset = "0x51FFF30", VA = "0x185200B30")]
		public OOAMFFCEJGD(KIHLKBLGLBJ<Handle> LHNFDMCLNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x52004C0", Offset = "0x51FF8C0", VA = "0x1852004C0")]
		public DCAHGGFJKHB HBLBJMFGHFK([In] DCAHGGFJKHB FKPHPPGPLLD)
		{
			return default(DCAHGGFJKHB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5200670", Offset = "0x51FFA70", VA = "0x185200670")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5200A70", Offset = "0x51FFE70", VA = "0x185200A70")]
		private Handle PJMPFPOBCOK(string DAMFJFKKFBI)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct DCAHGGFJKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private OOAMFFCEJGD ANGMIICCOPN;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6656A20", Offset = "0x6655E20", VA = "0x186656A20")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6656A60", Offset = "0x6655E60", VA = "0x186656A60")]
		public DCAHGGFJKHB(KIHLKBLGLBJ<Handle> LHNFDMCLNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x66569A0", Offset = "0x6655DA0", VA = "0x1866569A0")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x66568F0", Offset = "0x6655CF0", VA = "0x1866568F0")]
		public DCAHGGFJKHB DBEEDGEHMMA()
		{
			return default(DCAHGGFJKHB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeList<int> KOLBGJBPNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<int> KEHJNCFOBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int KAAPEBLBJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int CCDHECHLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool PNDLFGBKAKL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int DIPAECOCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4D74380", Offset = "0x4D73780", VA = "0x184D74380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DCAHGGFJKHB MHMEDPEHAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4D73110", Offset = "0x4D72510", VA = "0x184D73110")]
		get
		{
			return default(DCAHGGFJKHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4D74BB0", Offset = "0x4D73FB0", VA = "0x184D74BB0")]
	public KIHLKBLGLBJ(int OPFOLNCOPBG, Allocator JMEGNHGDHIA = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4D74280", Offset = "0x4D73680", VA = "0x184D74280")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0E80", Offset = "0x1FB0280", VA = "0x181FB0E80")]
	public static int PIKPCKFEKPG(int CHAOGBKCKEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE14E0", Offset = "0x2CE08E0", VA = "0x182CE14E0")]
	public static bool DPAEDEBIHKP(int CHAOGBKCKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4D734E0", Offset = "0x4D728E0", VA = "0x184D734E0")]
	public bool FJOEKFBMJCP(int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4D73D70", Offset = "0x4D73170", VA = "0x184D73D70")]
	public bool JOFPEANDPKF(Handle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4D73340", Offset = "0x4D72740", VA = "0x184D73340")]
	public Handle FDNMHCOKAPB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D748A0", Offset = "0x4D73CA0", VA = "0x184D748A0")]
	public void PPPHLLKFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4D73260", Offset = "0x4D72660", VA = "0x184D73260")]
	public void ENNHDAONJDC(Handle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD09A80", Offset = "0xD08E80", VA = "0x180D09A80")]
	private bool JJKDKBCPGBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4D73200", Offset = "0x4D72600", VA = "0x184D73200")]
	private bool BIBIPGEAPBC(int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4D73EE0", Offset = "0x4D732E0", VA = "0x184D73EE0")]
	private void LDPGFBHNLNA([Out] int CJFNAFNJJLB, [Out] int IOFNCNFBMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D73AA0", Offset = "0x4D72EA0", VA = "0x184D73AA0")]
	private void IBHGKEMNJOM(Handle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4D738A0", Offset = "0x4D72CA0", VA = "0x184D738A0")]
	private void HDHNEGDIJIP(int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4D737F0", Offset = "0x4D72BF0", VA = "0x184D737F0")]
	private bool GALFFJEJGNB([Out] int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D743C0", Offset = "0x4D737C0", VA = "0x184D743C0")]
	private static Handle NEPCHIJCKJL(int CJFNAFNJJLB, int IOFNCNFBMGK)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public struct GNANIDDMMPE<Handle, T> where Handle : PFGKJOCFDIP, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private KIHLKBLGLBJ<Handle> HNINDEDPKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] CGNLJHFMGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Action<T> HJOFJNMLEPJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x485D070", Offset = "0x485C470", VA = "0x18485D070")]
	public GNANIDDMMPE(int OPFOLNCOPBG, [Optional] Action<T> HJOFJNMLEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x485CAD0", Offset = "0x485BED0", VA = "0x18485CAD0")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x485C3B0", Offset = "0x485B7B0", VA = "0x18485C3B0")]
	public bool GLKKFIAAGGI(Handle GGBKPDHLOJF, [Out] T BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x485C950", Offset = "0x485BD50", VA = "0x18485C950")]
	public Handle JJBKLNLGAIJ(T BLFGIKOAKOL)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x485CD80", Offset = "0x485C180", VA = "0x18485CD80")]
	public void LJEBPLPBEMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x485C4C0", Offset = "0x485B8C0", VA = "0x18485C4C0")]
	public void JEBJOEBLLEI(Handle GGBKPDHLOJF, [Out] T JIBOLAMBBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x485C670", Offset = "0x485BA70", VA = "0x18485C670")]
	public void JEBJOEBLLEI(Handle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x485C460", Offset = "0x485B860", VA = "0x18485C460")]
	private T IGICEDPNCHE(int CJFNAFNJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x485CFB0", Offset = "0x485C3B0", VA = "0x18485CFB0")]
	private void PHNLOPOKADA(int NJFDBPMLEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public struct CBMPFOIIPEM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct FHKIIGBCMNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private CBMPFOIIPEM<T> LLPLHOOOAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x47416B0", Offset = "0x4740AB0", VA = "0x1847416B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x26A5290", Offset = "0x26A4690", VA = "0x1826A5290")]
		public FHKIIGBCMNP(CBMPFOIIPEM<T> LLPLHOOOAEB, int CJFNAFNJJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4741660", Offset = "0x4740A60", VA = "0x184741660")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class LOAFOMDCCBJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CBMPFOIIPEM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public LOAFOMDCCBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E57DB0", Offset = "0x4E571B0", VA = "0x184E57DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4E57E50", Offset = "0x4E57250", VA = "0x184E57E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FGGKIGONHDO : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CBMPFOIIPEM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public FGGKIGONHDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x47328D0", Offset = "0x4731CD0", VA = "0x1847328D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4732970", Offset = "0x4731D70", VA = "0x184732970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private object[] HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private uint FFOEEMKIKJO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5493670", Offset = "0x5492A70", VA = "0x185493670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KCBHPIPJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6304710", Offset = "0x6303B10", VA = "0x186304710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool IDHODAIBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x15F77B0", Offset = "0x15F6BB0", VA = "0x1815F77B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal bool NGMHJJPGNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x63048A0", Offset = "0x6303CA0", VA = "0x1863048A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public HJOPONMGOMN<T> MPDMFCNAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x63049A0", Offset = "0x6303DA0", VA = "0x1863049A0")]
		get
		{
			return default(HJOPONMGOMN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6304360", Offset = "0x6303760", VA = "0x186304360")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x63048B0", Offset = "0x6303CB0", VA = "0x1863048B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6305340", Offset = "0x6304740", VA = "0x186305340")]
	internal CBMPFOIIPEM(CBMPFOIIPEM<T> LLPLHOOOAEB, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6304FB0", Offset = "0x63043B0", VA = "0x186304FB0")]
	private CBMPFOIIPEM(T[] LLPLHOOOAEB, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6305040", Offset = "0x6304440", VA = "0x186305040")]
	public CBMPFOIIPEM(IEnumerable<T> JGMAGBDHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6304FD0", Offset = "0x63043D0", VA = "0x186304FD0")]
	public CBMPFOIIPEM(int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6304CF0", Offset = "0x63040F0", VA = "0x186304CF0")]
	public int NDOEKMMOHNB(T FFOEEMKIKJO, int HCJENEHBBIC, int ECKHNAPCKGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6304960", Offset = "0x6303D60", VA = "0x186304960")]
	public void HNHCMIBBMLF(int BGMFPCBOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6304B20", Offset = "0x6303F20", VA = "0x186304B20")]
	private void KLCFMPNFHMO(int BGMFPCBOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6304690", Offset = "0x6303A90", VA = "0x186304690")]
	public T[] DEADDHJIDDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x63044D0", Offset = "0x63038D0", VA = "0x1863044D0")]
	public T[] CNGHJFEEEPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x63047C0", Offset = "0x6303BC0", VA = "0x1863047C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6304840", Offset = "0x6303C40", VA = "0x186304840")]
	public void EHNIGEHKPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6304620", Offset = "0x6303A20", VA = "0x186304620")]
	public FHKIIGBCMNP DBEEDGEHMMA()
	{
		return default(FHKIIGBCMNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6304DD0", Offset = "0x63041D0", VA = "0x186304DD0", Slot = "5")]
	[IteratorStateMachine(typeof(CBMPFOIIPEM<>.LOAFOMDCCBJ))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6304EC0", Offset = "0x63042C0", VA = "0x186304EC0", Slot = "6")]
	[IteratorStateMachine(typeof(CBMPFOIIPEM<>.FGGKIGONHDO))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6304D70", Offset = "0x6304170", VA = "0x186304D70")]
	public static CBMPFOIIPEM<T> OMGLNNFDCFB(T[] LLPLHOOOAEB)
	{
		return default(CBMPFOIIPEM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6304430", Offset = "0x6303830", VA = "0x186304430")]
	public static CBMPFOIIPEM<T> CLMIANKGGAM(T[] LLPLHOOOAEB)
	{
		return default(CBMPFOIIPEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6304740", Offset = "0x6303B40", VA = "0x186304740")]
	private void DKHMGHICAHC(int CJFNAFNJJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class LEHDJFKJBJH<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct FDJKOJEHMLB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private LEHDJFKJBJH<T> CEFIHBLEFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x47035B0", Offset = "0x47029B0", VA = "0x1847035B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x47035F0", Offset = "0x47029F0", VA = "0x1847035F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4362D30", Offset = "0x4362130", VA = "0x184362D30")]
		public FDJKOJEHMLB(LEHDJFKJBJH<T> CEFIHBLEFNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x47034C0", Offset = "0x47028C0", VA = "0x1847034C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4703560", Offset = "0x4702960", VA = "0x184703560", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private CBMPFOIIPEM<T> HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int BFBCILDCBHG;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4E37360", Offset = "0x4E36760", VA = "0x184E37360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xB35CF0", Offset = "0xB350F0", VA = "0x180B35CF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4A20930", Offset = "0x4A1FD30", VA = "0x184A20930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int DIPAECOCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4E37E60", Offset = "0x4E37260", VA = "0x184E37E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IDHODAIBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4E37F40", Offset = "0x4E37340", VA = "0x184E37F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public HJOPONMGOMN<T> MPDMFCNAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4E376B0", Offset = "0x4E36AB0", VA = "0x184E376B0")]
		get
		{
			return default(HJOPONMGOMN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4E38250", Offset = "0x4E37650", VA = "0x184E38250")]
	public LEHDJFKJBJH(IEnumerable<T> JGMAGBDHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4E381E0", Offset = "0x4E375E0", VA = "0x184E381E0")]
	public LEHDJFKJBJH(int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x47922D0", Offset = "0x47916D0", VA = "0x1847922D0")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4E37E80", Offset = "0x4E37280", VA = "0x184E37E80")]
	public CBMPFOIIPEM<T> MGBCIHAOMIF()
	{
		return default(CBMPFOIIPEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4E37730", Offset = "0x4E36B30", VA = "0x184E37730")]
	public void JJBKLNLGAIJ(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E37590", Offset = "0x4E36990", VA = "0x184E37590")]
	private void HNHCMIBBMLF(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4E37CE0", Offset = "0x4E370E0", VA = "0x184E37CE0")]
	public void KJPCKFGIEPN(List<T> KLIMJMOCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4E37C40", Offset = "0x4E37040", VA = "0x184E37C40")]
	public void KJPCKFGIEPN(T[] KLIMJMOCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E375D0", Offset = "0x4E369D0", VA = "0x184E375D0")]
	public void ICCNAFAJNNM(int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4E37F60", Offset = "0x4E37360", VA = "0x184E37F60")]
	public void OECNDFKLHBB(int OEGAPGHOHKE, int FNNKAHMFNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E37EC0", Offset = "0x4E372C0", VA = "0x184E37EC0")]
	public int NDOEKMMOHNB(T FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4E379A0", Offset = "0x4E36DA0", VA = "0x184E379A0")]
	public bool JOEMDCADNHJ(T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E37490", Offset = "0x4E36890", VA = "0x184E37490")]
	public T[] CNGHJFEEEPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4E37500", Offset = "0x4E36900", VA = "0x184E37500", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E373D0", Offset = "0x4E367D0", VA = "0x184E373D0")]
	public static CBMPFOIIPEM<T> CLMIANKGGAM(LEHDJFKJBJH<T> CEFIHBLEFNG)
	{
		return default(CBMPFOIIPEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E37520", Offset = "0x4E36920", VA = "0x184E37520", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E38130", Offset = "0x4E37530", VA = "0x184E38130", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E38170", Offset = "0x4E37570", VA = "0x184E38170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E37850", Offset = "0x4E36C50", VA = "0x184E37850")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JODMICLOIJM(int FFOEEMKIKJO, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E379F0", Offset = "0x4E36DF0", VA = "0x184E379F0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void KCJILOIDDFB(int OEGAPGHOHKE, int FNNKAHMFNCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class AFMKLFADKHD
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C7B0", Offset = "0x3D6BBB0", VA = "0x183D6C7B0")]
	public static void EHNIGEHKPEH<T>(this LEHDJFKJBJH<T> CEFIHBLEFNG) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public ref struct HJOPONMGOMN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Span<object> HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4903A30", Offset = "0x4902E30", VA = "0x184903A30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4903BA0", Offset = "0x4902FA0", VA = "0x184903BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4903B10", Offset = "0x4902F10", VA = "0x184903B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public HJOPONMGOMN(Span<object> BGFHEKCGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4903C20", Offset = "0x4903020", VA = "0x184903C20")]
	public HJOPONMGOMN<T> IDOMHGEABJN(int HCJENEHBBIC)
	{
		return default(HJOPONMGOMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4903CF0", Offset = "0x49030F0", VA = "0x184903CF0")]
	public HJOPONMGOMN<T> IDOMHGEABJN(int HCJENEHBBIC, int BFBCILDCBHG)
	{
		return default(HJOPONMGOMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4903AB0", Offset = "0x4902EB0", VA = "0x184903AB0")]
	public void DHDJJANPOHF(HJOPONMGOMN<T> NDGLCGNJECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4903DD0", Offset = "0x49031D0", VA = "0x184903DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4903B50", Offset = "0x4902F50", VA = "0x184903B50", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4903BD0", Offset = "0x4902FD0", VA = "0x184903BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct GIEALLIDLLC : IEquatable<GIEALLIDLLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int HGHGCNDALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int ECKHNAPCKGD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int MPKJDDCJPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2CBED00", Offset = "0x2CBE100", VA = "0x182CBED00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1DE0", Offset = "0x6AE11E0", VA = "0x186AE1DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int LDHNLFPMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int NJIDHPODGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7882710", Offset = "0x7881B10", VA = "0x187882710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7882720", Offset = "0x7881B20", VA = "0x187882720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public (int begin, int end) FODAKNAGMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7882610", Offset = "0x7881A10", VA = "0x187882610")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
	private GIEALLIDLLC(int HGHGCNDALFP, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2691E60", Offset = "0x2691260", VA = "0x182691E60")]
	public static GIEALLIDLLC NDNDMPBEJKE(int HGHGCNDALFP, int ECKHNAPCKGD)
	{
		return default(GIEALLIDLLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7882670", Offset = "0x7881A70", VA = "0x187882670")]
	public static GIEALLIDLLC DNGGOLJFNBC(int HCJENEHBBIC, int FNNKAHMFNCJ)
	{
		return default(GIEALLIDLLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7882730", Offset = "0x7881B30", VA = "0x187882730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x17815D0", Offset = "0x17809D0", VA = "0x1817815D0", Slot = "4")]
	public bool Equals(GIEALLIDLLC KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7882680", Offset = "0x7881A80", VA = "0x187882680", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C43EA0", Offset = "0x6C432A0", VA = "0x186C43EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct GCEFBEMEOOI<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NativeArray<T> HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public GCEFBEMEOOI(NativeArray<T> HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4809840", Offset = "0x4808C40", VA = "0x184809840", Slot = "6")]
	public int Compare(int MEAMPLHPPKP, int KDELALKKKOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4809930", Offset = "0x4808D30", VA = "0x184809930", Slot = "4")]
	public bool Equals(int MEAMPLHPPKP, int KDELALKKKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4809A20", Offset = "0x4808E20", VA = "0x184809A20", Slot = "5")]
	public int GetHashCode(int MEAMPLHPPKP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FONMCDAGOGO
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x35CE4E0", Offset = "0x35CD8E0", VA = "0x1835CE4E0")]
	public static T[] EEFINHJGNPA<T>(List<T> CEFIHBLEFNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EFACDNEGJCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* COHOKDLBNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal AllocatorManager.AllocatorHandle DIKBIJGLAED;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x574D3C0", Offset = "0x574C7C0", VA = "0x18574D3C0")]
	public void LIPICMLEJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class ADPKPBLAPDI
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3CDFBD0", Offset = "0x3CDEFD0", VA = "0x183CDFBD0")]
	public static EFACDNEGJCI OHKDDCJCGFC<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> IMOLDFICHHJ) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(EFACDNEGJCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3CDFBD0", Offset = "0x3CDEFD0", VA = "0x183CDFBD0")]
	public static UnsafeParallelHashMap<TKey, TValue> GFGOMIGFCBI<TKey, TValue>(this EFACDNEGJCI IMOLDFICHHJ) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NLOMMKFJPKM
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x37C61A0", Offset = "0x37C55A0", VA = "0x1837C61A0")]
	public static int APLOFAMPINA<T>(ReadOnlySpan<T> OMEDFPNJPPO, ReadOnlySpan<T> OLFLJLGBKMP, int BFBCILDCBHG) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class CKLCAAGKPGO
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x33EC060", Offset = "0x33EB460", VA = "0x1833EC060")]
	public static T DDCLNCKPBBO<T>(this NativeArray<byte> IEAOMLJNJLM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x33EBC40", Offset = "0x33EB040", VA = "0x1833EBC40")]
	public static NativeArray<T> BIIKBJMPPII<T>(this NativeArray<byte> IEAOMLJNJLM, int ECKHNAPCKGD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x33EC190", Offset = "0x33EB590", VA = "0x1833EC190")]
	public static void FEAAJMEOMKD<T>(this NativeList<byte> NOOEFABFCIC, [In] T FFOEEMKIKJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x33EC0F0", Offset = "0x33EB4F0", VA = "0x1833EC0F0")]
	public static void FEAAJMEOMKD<T>(this NativeList<byte> NOOEFABFCIC, NativeArray<T> FFOEEMKIKJO) where T : struct
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

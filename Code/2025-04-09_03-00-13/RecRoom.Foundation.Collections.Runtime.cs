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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D14A0", Offset = "0x78D08A0", VA = "0x1878D14A0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DFC70", Offset = "0x37DF070", VA = "0x1837DFC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x37E0A60", Offset = "0x37DFE60", VA = "0x1837E0A60")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37DFD40", Offset = "0x37DF140", VA = "0x1837DFD40")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x37DFEC0", Offset = "0x37DF2C0", VA = "0x1837DFEC0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x37EA4A0", Offset = "0x37E98A0", VA = "0x1837EA4A0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x37EA1B0", Offset = "0x37E95B0", VA = "0x1837EA1B0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x37EA360", Offset = "0x37E9760", VA = "0x1837EA360")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37EAB30", Offset = "0x37E9F30", VA = "0x1837EAB30")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37E1120", Offset = "0x37E0520", VA = "0x1837E1120")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x37E1200", Offset = "0x37E0600", VA = "0x1837E1200")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37E1710", Offset = "0x37E0B10", VA = "0x1837E1710")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, GIEALLIDLLC range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37E1750", Offset = "0x37E0B50", VA = "0x1837E1750")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x37E1580", Offset = "0x37E0980", VA = "0x1837E1580")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x37EA2A0", Offset = "0x37E96A0", VA = "0x1837EA2A0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[MDNIADKOPPG]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37EAC20", Offset = "0x37EA020", VA = "0x1837EAC20")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x37ECB70", Offset = "0x37EBF70", VA = "0x1837ECB70")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37ECB20", Offset = "0x37EBF20", VA = "0x1837ECB20")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x471CBC0", Offset = "0x471BFC0", VA = "0x18471CBC0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78D1B00", Offset = "0x78D0F00", VA = "0x1878D1B00")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78D1B30", Offset = "0x78D0F30", VA = "0x1878D1B30")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37EBF10", Offset = "0x37EB310", VA = "0x1837EBF10")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x37EBE20", Offset = "0x37EB220", VA = "0x1837EBE20")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37EBF70", Offset = "0x37EB370", VA = "0x1837EBF70")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37EBE70", Offset = "0x37EB270", VA = "0x1837EBE70")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x37EBEC0", Offset = "0x37EB2C0", VA = "0x1837EBEC0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37EC340", Offset = "0x37EB740", VA = "0x1837EC340")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37EC670", Offset = "0x37EBA70", VA = "0x1837EC670")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x37EC500", Offset = "0x37EB900", VA = "0x1837EC500")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37EC3E0", Offset = "0x37EB7E0", VA = "0x1837EC3E0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x37EBDC0", Offset = "0x37EB1C0", VA = "0x1837EBDC0")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37EBDA0", Offset = "0x37EB1A0", VA = "0x1837EBDA0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37ECF50", Offset = "0x37EC350", VA = "0x1837ECF50")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x37ECB80", Offset = "0x37EBF80", VA = "0x1837ECB80")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37ECF80", Offset = "0x37EC380", VA = "0x1837ECF80")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x37ED040", Offset = "0x37EC440", VA = "0x1837ED040")]
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
			[Cpp2IlInjected.Address(RVA = "0x48F25B0", Offset = "0x48F19B0", VA = "0x1848F25B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD1DB70", Offset = "0xD1CF70", VA = "0x180D1DB70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4E2D760", Offset = "0x4E2CB60", VA = "0x184E2D760")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5112330", Offset = "0x5111730", VA = "0x185112330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5112930", Offset = "0x5111D30", VA = "0x185112930")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0790", Offset = "0x3BAFB90", VA = "0x183BB0790")]
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
			[Cpp2IlInjected.Address(RVA = "0x5171B20", Offset = "0x5170F20", VA = "0x185171B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5171B60", Offset = "0x5170F60", VA = "0x185171B60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4E2D760", Offset = "0x4E2CB60", VA = "0x184E2D760")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5171780", Offset = "0x5170B80", VA = "0x185171780")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x51718C0", Offset = "0x5170CC0", VA = "0x1851718C0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x51719C0", Offset = "0x5170DC0", VA = "0x1851719C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5171A60", Offset = "0x5170E60", VA = "0x185171A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x78D00B0", Offset = "0x78CF4B0", VA = "0x1878D00B0")]
	public static JobHandle OENPBPJFBKL(this JobHandle PCMHLCLONGN, JobHandle IAJJOLNCJOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x78D0000", Offset = "0x78CF400", VA = "0x1878D0000")]
	public static JobHandle DGKKPDKMODG(this Span<JobHandle> JGEIDAMJLAD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PFBFGKICCLN
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3823350", Offset = "0x3822750", VA = "0x183823350")]
	public static NativeKeyValueArrays<TKey, TValue> GMBDOLMBAOG<TKey, TValue>(this Dictionary<TKey, TValue> JLLDPNEPEEK, Allocator JMEGNHGDHIA) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MMFEIJBEGIE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x78D16E0", Offset = "0x78D0AE0", VA = "0x1878D16E0")]
	public static void FIDGOFLNEPF(this GameObject GIIGFIAPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x78D1820", Offset = "0x78D0C20", VA = "0x1878D1820")]
	public static void FIDGOFLNEPF(this Component DMJKAPFLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x78D1780", Offset = "0x78D0B80", VA = "0x1878D1780")]
	public static void FIDGOFLNEPF(this ScriptableObject CPAKJFLJKMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MKLFOMHKEBE
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x78D1530", Offset = "0x78D0930", VA = "0x1878D1530")]
	public static void KJPCKFGIEPN(this NativeList<byte> CEFIHBLEFNG, ReadOnlySpan<byte> BGFHEKCGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3739AE0", Offset = "0x3738EE0", VA = "0x183739AE0")]
	public static void BMKPIHBENHF<T>(this NativeList<T> CEFIHBLEFNG, T FFOEEMKIKJO, int ECKHNAPCKGD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KIJFNCAEIKM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36DCBF0", Offset = "0x36DBFF0", VA = "0x1836DCBF0")]
	public static T MKICJFAIPFG<T>(this ReadOnlySpan<byte> FFOEEMKIKJO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36DBF30", Offset = "0x36DB330", VA = "0x1836DBF30")]
	public static T IHENIMNENIN<T>(this Span<T> BGFHEKCGLFH, Func<T, bool> MECCCCBLPIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36DBDD0", Offset = "0x36DB1D0", VA = "0x1836DBDD0")]
	public static bool BNKNLEKIIAJ<T>(this Span<T> BGFHEKCGLFH, Func<T, bool> MECCCCBLPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36DBE80", Offset = "0x36DB280", VA = "0x1836DBE80")]
	public static bool FLKJNJEHKOH<T>(this Span<T> BGFHEKCGLFH, Func<T, bool> MECCCCBLPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36DC090", Offset = "0x36DB490", VA = "0x1836DC090")]
	public static T IOLMGDEDCOJ<T>([In] this ReadOnlySpan<byte> BGFHEKCGLFH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x338B2E0", Offset = "0x338A6E0", VA = "0x18338B2E0")]
	public static Span<TTo> IDKNKAINIJK<TTo, TFrom>(this Span<TFrom> BGFHEKCGLFH) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x338B2E0", Offset = "0x338A6E0", VA = "0x18338B2E0")]
	public static ReadOnlySpan<TTo> IDKNKAINIJK<TTo, TFrom>(this ReadOnlySpan<TFrom> BGFHEKCGLFH) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x338B2E0", Offset = "0x338A6E0", VA = "0x18338B2E0")]
	public static ReadOnlySpan<TTo> IDKNKAINIJK<TTo>(this ReadOnlySpan<byte> BGFHEKCGLFH) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36DC5E0", Offset = "0x36DB9E0", VA = "0x1836DC5E0")]
	public static Span<T> IPLKNPADEBH<T>(this ReadOnlySpan<T> IEAOMLJNJLM) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x36DC6E0", Offset = "0x36DBAE0", VA = "0x1836DC6E0")]
	public static Span<byte> JFGGMENNDNP<T>([In] this Span<byte> BGFHEKCGLFH, T FFOEEMKIKJO) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x78D0EB0", Offset = "0x78D02B0", VA = "0x1878D0EB0")]
	private static Enum PIGHBJMHBOJ([In] ReadOnlySpan<byte> BGFHEKCGLFH, Type JBNOGMDBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x78D0960", Offset = "0x78CFD60", VA = "0x1878D0960")]
	public static Enum AFDKDGHCFCH([In] this Span<byte> BGFHEKCGLFH, Type JBNOGMDBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x78D09D0", Offset = "0x78CFDD0", VA = "0x1878D09D0")]
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

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x78D1980", Offset = "0x78D0D80", VA = "0x1878D1980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x78D03B0", Offset = "0x78CF7B0", VA = "0x1878D03B0")]
	[AsyncStateMachine(typeof(NNFIMGJMJGN))]
	public static void NBPDAKGKOMJ(this Task OOLNPDLPIEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CDPIIJMPLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x33FCFE0", Offset = "0x33FC3E0", VA = "0x1833FCFE0")]
	public static NativeArray<T> NKHGDJOOCLK<T>(this UnsafeList<T> CEFIHBLEFNG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x33FCF60", Offset = "0x33FC360", VA = "0x1833FCF60")]
	public static NativeArray<T> KPBOEAFFEON<T>(this UnsafeList<T> CEFIHBLEFNG, bool GPPDNEDPIAM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x33FCEB0", Offset = "0x33FC2B0", VA = "0x1833FCEB0")]
	public static UnsafeList<T> IPLKNPADEBH<T>(this UnsafeList<T> CEFIHBLEFNG, Allocator JMEGNHGDHIA) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MOCNEELALJE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
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

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct AGPJLCPDGFD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly PAEFHBPEPCE DJBLFBEBKGO;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0120", Offset = "0x2C9F520", VA = "0x182CA0120")]
		public AGPJLCPDGFD(PAEFHBPEPCE DJBLFBEBKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory CMAMNCPNLFL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	public static void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x78D18C0", Offset = "0x78D0CC0", VA = "0x1878D18C0")]
	static MOCNEELALJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x32BF9A0", Offset = "0x32BEDA0", VA = "0x1832BF9A0")]
	public static AGPJLCPDGFD GBKDKALCALN(PAEFHBPEPCE DJBLFBEBKGO)
	{
		return default(AGPJLCPDGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	public static void ELABNEBMAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OFLJHFBNOBK
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x38071C0", Offset = "0x38065C0", VA = "0x1838071C0")]
	public static AIKJFIOOKIH<T1, T2> EHANHKPHNHP<T1, T2>(this (T1, T2) DCMKKNIGNIA) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(AIKJFIOOKIH<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3609B30", Offset = "0x3608F30", VA = "0x183609B30")]
	public static KOBEJCIENHO<T1, T2, T3> EHANHKPHNHP<T1, T2, T3>(this (T1, T2, T3) DCMKKNIGNIA) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(KOBEJCIENHO<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AIKJFIOOKIH<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) DCMKKNIGNIA;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x48DA3E0", Offset = "0x48D97E0", VA = "0x1848DA3E0")]
	public AIKJFIOOKIH((T1, T2) DCMKKNIGNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x48D9F00", Offset = "0x48D9300", VA = "0x1848D9F00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KOBEJCIENHO<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) DCMKKNIGNIA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x48DA3C0", Offset = "0x48D97C0", VA = "0x1848DA3C0")]
	public KOBEJCIENHO((T1, T2, T3) DCMKKNIGNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4DC8880", Offset = "0x4DC7C80", VA = "0x184DC8880", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NBGAIALIGCE
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x78D1920", Offset = "0x78D0D20", VA = "0x1878D1920")]
	public static Range HJDNPFPENGN(this GIEALLIDLLC KEDOGBHAGPB)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KLDBEFFLMIH
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
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
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x78D15C0", Offset = "0x78D09C0", VA = "0x1878D15C0")]
		public MLFELMHHMOA(int HCJENEHBBIC, int FNNKAHMFNCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x78D15B0", Offset = "0x78D09B0", VA = "0x1878D15B0")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x78D1450", Offset = "0x78D0850", VA = "0x1878D1450")]
	public static MLFELMHHMOA DBEEDGEHMMA(this Range KEDOGBHAGPB)
	{
		return default(MLFELMHHMOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FEADOCLIOOK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle GGBKPDHLOJF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FLPBCAMFFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x471CBF0", Offset = "0x471BFF0", VA = "0x18471CBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x471C600", Offset = "0x471BA00", VA = "0x18471C600")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x471C950", Offset = "0x471BD50", VA = "0x18471C950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x471CCF0", Offset = "0x471C0F0", VA = "0x18471CCF0")]
	public FEADOCLIOOK(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x471CBC0", Offset = "0x471BFC0", VA = "0x18471CBC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
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
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4A11BF0", Offset = "0x4A10FF0", VA = "0x184A11BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A127C0", Offset = "0x4A11BC0", VA = "0x184A127C0")]
	public IGHFGDGAJBN(Action<TValue> BDIBKGEPJCN, [Optional] Func<TValue> PDPLEMLLMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4A11C30", Offset = "0x4A11030", VA = "0x184A11C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A123F0", Offset = "0x4A117F0", VA = "0x184A123F0")]
	public THandle JJBKLNLGAIJ(TValue FFOEEMKIKJO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A12670", Offset = "0x4A11A70", VA = "0x184A12670")]
	public bool OAHDOECNNKP(THandle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4A11F00", Offset = "0x4A11300", VA = "0x184A11F00")]
	public bool GLKKFIAAGGI(THandle GGBKPDHLOJF, [Out] TValue FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4A123A0", Offset = "0x4A117A0", VA = "0x184A123A0")]
	public TValue IOLMGDEDCOJ(THandle GGBKPDHLOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A11AE0", Offset = "0x4A10EE0", VA = "0x184A11AE0")]
	public bool BGMHGMOKIKN(THandle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A12080", Offset = "0x4A11480", VA = "0x184A12080")]
	private THandle HGDMAMHMFAO(int CJFNAFNJJLB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A124E0", Offset = "0x4A118E0", VA = "0x184A124E0")]
	private TValue MLACMEICEMO(int CJFNAFNJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4A12490", Offset = "0x4A11890", VA = "0x184A12490")]
	private void KLOHBJBDCAD(int CJFNAFNJJLB, [In] THandle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A11EB0", Offset = "0x4A112B0", VA = "0x184A11EB0")]
	private void GBGCNCIFPPL(int CJFNAFNJJLB, [In] TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4A11D00", Offset = "0x4A11100", VA = "0x184A11D00")]
	private THandle GBEBNLNKHEK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A120E0", Offset = "0x4A114E0", VA = "0x184A120E0")]
	private void IAFJCNDGLFN(THandle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4A127B0", Offset = "0x4A11BB0", VA = "0x184A127B0")]
	private int PIKPCKFEKPG(int IOFNCNFBMGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A127A0", Offset = "0x4A11BA0", VA = "0x184A127A0")]
	private bool OIEPOBJFCJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9B01C0", Offset = "0x9AF5C0", VA = "0x1809B01C0")]
	private void INKPKNPMFHK(THandle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4A11FD0", Offset = "0x4A113D0", VA = "0x184A11FD0")]
	private bool HAKOHOONAAH([Out] THandle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4A12540", Offset = "0x4A11940", VA = "0x184A12540")]
	private bool NCIAHJBGBCE([Out] THandle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4A121F0", Offset = "0x4A115F0", VA = "0x184A121F0")]
	private void IJNOHGNHBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PFGKJOCFDIP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int EGOLIAJEBDH
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
public static class DCECLNGJLNP
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x344F690", Offset = "0x344EA90", VA = "0x18344F690")]
	public static bool EGBCCLIGMMM<T>(this T GGBKPDHLOJF, T KNCKFHOKGJM) where T : struct, PFGKJOCFDIP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x344F6B0", Offset = "0x344EAB0", VA = "0x18344F6B0")]
	public static bool PNPLPCMDCBA<T>(this T GGBKPDHLOJF) where T : struct, PFGKJOCFDIP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x78D00F0", Offset = "0x78CF4F0", VA = "0x1878D00F0")]
	public static string KOFAFINMIGB(this PFGKJOCFDIP GGBKPDHLOJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct MMCAHBLJMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type BLPEHEPGJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> MPDMFCNAFMB;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D980", Offset = "0x4E2CD80", VA = "0x184E2D980")]
	public MMCAHBLJMAC(Type BLPOIAMMJHJ, Span<byte> BGFHEKCGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3739DE0", Offset = "0x37391E0", VA = "0x183739DE0")]
	public static MMCAHBLJMAC NFJOOPGCIPO<T>(T FFOEEMKIKJO) where T : struct
	{
		return default(MMCAHBLJMAC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x78D1660", Offset = "0x78D0A60", VA = "0x1878D1660")]
	public static OEMNHEJOOLM CLMIANKGGAM([In] MMCAHBLJMAC IEDBNFIMLNL)
	{
		return default(OEMNHEJOOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x78D15D0", Offset = "0x78D09D0", VA = "0x1878D15D0")]
	public Enum AFDKDGHCFCH(Type JBNOGMDBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3739DA0", Offset = "0x37391A0", VA = "0x183739DA0")]
	public void JFGGMENNDNP<T>([In] T FFOEEMKIKJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x78D1650", Offset = "0x78D0A50", VA = "0x1878D1650")]
	public void BAKNINPOMCH(Enum OEAPKNBFGIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct OEMNHEJOOLM
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
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
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x78D1D80", Offset = "0x78D1180", VA = "0x1878D1D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int AODCCKACEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x78D1D30", Offset = "0x78D1130", VA = "0x1878D1D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D980", Offset = "0x4E2CD80", VA = "0x184E2D980")]
	public OEMNHEJOOLM(Type BLPOIAMMJHJ, ReadOnlySpan<byte> BGFHEKCGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38057F0", Offset = "0x3804BF0", VA = "0x1838057F0")]
	public static OEMNHEJOOLM NFJOOPGCIPO<T>(T FFOEEMKIKJO) where T : struct
	{
		return default(OEMNHEJOOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x78D1D90", Offset = "0x78D1190", VA = "0x1878D1D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x78D1B60", Offset = "0x78D0F60", VA = "0x1878D1B60")]
	public object BEEIPIJNFIF(int CJFNAFNJJLB = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct JNBFEBABKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3691620", Offset = "0x3690A20", VA = "0x183691620")]
	public static NativeArray<T> NFJOOPGCIPO<T>(T FFOEEMKIKJO, bool GPPDNEDPIAM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x36915D0", Offset = "0x36909D0", VA = "0x1836915D0")]
	public static NativeArray<T> KLGMHHPMCPJ<T>(T FFOEEMKIKJO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3691510", Offset = "0x3690910", VA = "0x183691510")]
	public static NativeArray<T> EECPPLFOAGA<T>(T FFOEEMKIKJO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x78D0770", Offset = "0x78CFB70", VA = "0x1878D0770")]
	public static NativeArray<byte> EECPPLFOAGA(ReadOnlySpan<byte> FFOEEMKIKJO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x78D0830", Offset = "0x78CFC30", VA = "0x1878D0830")]
	public static NativeArray<byte> NFJOOPGCIPO(ReadOnlySpan<byte> FFOEEMKIKJO, bool GPPDNEDPIAM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x78D08E0", Offset = "0x78CFCE0", VA = "0x1878D08E0")]
	public unsafe static NativeArray<byte> NFJOOPGCIPO(byte* EOMGFLGAEJK, int BFBCILDCBHG, bool GPPDNEDPIAM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3691560", Offset = "0x3690960", VA = "0x183691560")]
	public static NativeArray<T> GBADJOAJCAL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct JHMCBPNIPFI : IEquatable<JHMCBPNIPFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int HIALDCJGAPD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type KAFGKIIBACB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78D0560", Offset = "0x78CF960", VA = "0x1878D0560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x78D06D0", Offset = "0x78CFAD0", VA = "0x1878D06D0")]
	public JHMCBPNIPFI(Type HAFNBBNOLPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x78D04D0", Offset = "0x78CF8D0", VA = "0x1878D04D0")]
	public static JHMCBPNIPFI CLMIANKGGAM(Type HAFNBBNOLPO)
	{
		return default(JHMCBPNIPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2036D50", Offset = "0x2036150", VA = "0x182036D50", Slot = "4")]
	public bool Equals(JHMCBPNIPFI KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x78D0610", Offset = "0x78CFA10", VA = "0x1878D0610", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x78D0690", Offset = "0x78CFA90", VA = "0x1878D0690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class BDNBEKCIPEF
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> GIDGPAEMGFK;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> MJDJDBBAPPM;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x78CFE80", Offset = "0x78CF280", VA = "0x1878CFE80")]
	static BDNBEKCIPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x78CFDC0", Offset = "0x78CF1C0", VA = "0x1878CFDC0")]
	public static bool JJBKLNLGAIJ(Type HAFNBBNOLPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x78CFBF0", Offset = "0x78CEFF0", VA = "0x1878CFBF0")]
	private static bool JJBKLNLGAIJ(Type HAFNBBNOLPO, [Out] int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x78CFE20", Offset = "0x78CF220", VA = "0x1878CFE20")]
	public static int NLKEOLDKCDH(Type HAFNBBNOLPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x78CFB70", Offset = "0x78CEF70", VA = "0x1878CFB70")]
	public static Type IOLMGDEDCOJ(int CJFNAFNJJLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KIHLKBLGLBJ<Handle> where Handle : PFGKJOCFDIP, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct OOAMFFCEJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly KIHLKBLGLBJ<Handle> LHNFDMCLNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle JJIFNMNPGIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5231DF0", Offset = "0x52311F0", VA = "0x185231DF0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5232190", Offset = "0x5231590", VA = "0x185232190")]
		public OOAMFFCEJGD(KIHLKBLGLBJ<Handle> LHNFDMCLNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5231B20", Offset = "0x5230F20", VA = "0x185231B20")]
		public DCAHGGFJKHB HBLBJMFGHFK([In] DCAHGGFJKHB FKPHPPGPLLD)
		{
			return default(DCAHGGFJKHB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5231CD0", Offset = "0x52310D0", VA = "0x185231CD0")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x52320D0", Offset = "0x52314D0", VA = "0x1852320D0")]
		private Handle PJMPFPOBCOK(string DAMFJFKKFBI)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct DCAHGGFJKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private OOAMFFCEJGD ANGMIICCOPN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x66BE830", Offset = "0x66BDC30", VA = "0x1866BE830")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x66BE870", Offset = "0x66BDC70", VA = "0x1866BE870")]
		public DCAHGGFJKHB(KIHLKBLGLBJ<Handle> LHNFDMCLNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x66BE7B0", Offset = "0x66BDBB0", VA = "0x1866BE7B0")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x66BE700", Offset = "0x66BDB00", VA = "0x1866BE700")]
		public DCAHGGFJKHB DBEEDGEHMMA()
		{
			return default(DCAHGGFJKHB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> KOLBGJBPNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> KEHJNCFOBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int KAAPEBLBJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int CCDHECHLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool PNDLFGBKAKL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DIPAECOCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4D92B30", Offset = "0x4D91F30", VA = "0x184D92B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DCAHGGFJKHB MHMEDPEHAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4D918C0", Offset = "0x4D90CC0", VA = "0x184D918C0")]
		get
		{
			return default(DCAHGGFJKHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4D93360", Offset = "0x4D92760", VA = "0x184D93360")]
	public KIHLKBLGLBJ(int OPFOLNCOPBG, Allocator JMEGNHGDHIA = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D92A30", Offset = "0x4D91E30", VA = "0x184D92A30")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE150", Offset = "0x1FBD550", VA = "0x181FBE150")]
	public static int PIKPCKFEKPG(int CHAOGBKCKEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CDBE50", Offset = "0x2CDB250", VA = "0x182CDBE50")]
	public static bool DPAEDEBIHKP(int CHAOGBKCKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4D91C90", Offset = "0x4D91090", VA = "0x184D91C90")]
	public bool FJOEKFBMJCP(int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4D92520", Offset = "0x4D91920", VA = "0x184D92520")]
	public bool JOFPEANDPKF(Handle GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D91AF0", Offset = "0x4D90EF0", VA = "0x184D91AF0")]
	public Handle FDNMHCOKAPB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D93050", Offset = "0x4D92450", VA = "0x184D93050")]
	public void PPPHLLKFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D91A10", Offset = "0x4D90E10", VA = "0x184D91A10")]
	public void ENNHDAONJDC(Handle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xD0E7C0", Offset = "0xD0DBC0", VA = "0x180D0E7C0")]
	private bool JJKDKBCPGBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D919B0", Offset = "0x4D90DB0", VA = "0x184D919B0")]
	private bool BIBIPGEAPBC(int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D92690", Offset = "0x4D91A90", VA = "0x184D92690")]
	private void LDPGFBHNLNA([Out] int CJFNAFNJJLB, [Out] int IOFNCNFBMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4D92250", Offset = "0x4D91650", VA = "0x184D92250")]
	private void IBHGKEMNJOM(Handle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4D92050", Offset = "0x4D91450", VA = "0x184D92050")]
	private void HDHNEGDIJIP(int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4D91FA0", Offset = "0x4D913A0", VA = "0x184D91FA0")]
	private bool GALFFJEJGNB([Out] int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D92B70", Offset = "0x4D91F70", VA = "0x184D92B70")]
	private static Handle NEPCHIJCKJL(int CJFNAFNJJLB, int IOFNCNFBMGK)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public struct GNANIDDMMPE<Handle, T> where Handle : PFGKJOCFDIP, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private KIHLKBLGLBJ<Handle> HNINDEDPKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] CGNLJHFMGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> HJOFJNMLEPJ;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x48755C0", Offset = "0x48749C0", VA = "0x1848755C0")]
	public GNANIDDMMPE(int OPFOLNCOPBG, [Optional] Action<T> HJOFJNMLEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4875020", Offset = "0x4874420", VA = "0x184875020")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4874900", Offset = "0x4873D00", VA = "0x184874900")]
	public bool GLKKFIAAGGI(Handle GGBKPDHLOJF, [Out] T BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4874EA0", Offset = "0x48742A0", VA = "0x184874EA0")]
	public Handle JJBKLNLGAIJ(T BLFGIKOAKOL)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x48752D0", Offset = "0x48746D0", VA = "0x1848752D0")]
	public void LJEBPLPBEMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4874A10", Offset = "0x4873E10", VA = "0x184874A10")]
	public void JEBJOEBLLEI(Handle GGBKPDHLOJF, [Out] T JIBOLAMBBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4874BC0", Offset = "0x4873FC0", VA = "0x184874BC0")]
	public void JEBJOEBLLEI(Handle GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x48749B0", Offset = "0x4873DB0", VA = "0x1848749B0")]
	private T IGICEDPNCHE(int CJFNAFNJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4875500", Offset = "0x4874900", VA = "0x184875500")]
	private void PHNLOPOKADA(int NJFDBPMLEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct CBMPFOIIPEM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct FHKIIGBCMNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private CBMPFOIIPEM<T> LLPLHOOOAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x475A080", Offset = "0x4759480", VA = "0x18475A080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x26A86E0", Offset = "0x26A7AE0", VA = "0x1826A86E0")]
		public FHKIIGBCMNP(CBMPFOIIPEM<T> LLPLHOOOAEB, int CJFNAFNJJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x475A030", Offset = "0x4759430", VA = "0x18475A030")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LOAFOMDCCBJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CBMPFOIIPEM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public LOAFOMDCCBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EA10", Offset = "0x4E7DE10", VA = "0x184E7EA10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4E7EAB0", Offset = "0x4E7DEB0", VA = "0x184E7EAB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FGGKIGONHDO : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CBMPFOIIPEM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public FGGKIGONHDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x474B580", Offset = "0x474A980", VA = "0x18474B580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x474B620", Offset = "0x474AA20", VA = "0x18474B620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint FFOEEMKIKJO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x54B5750", Offset = "0x54B4B50", VA = "0x1854B5750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KCBHPIPJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x62F9750", Offset = "0x62F8B50", VA = "0x1862F9750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IDHODAIBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x160D060", Offset = "0x160C460", VA = "0x18160D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool NGMHJJPGNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x62F98E0", Offset = "0x62F8CE0", VA = "0x1862F98E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HJOPONMGOMN<T> MPDMFCNAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x62F99E0", Offset = "0x62F8DE0", VA = "0x1862F99E0")]
		get
		{
			return default(HJOPONMGOMN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x62F93A0", Offset = "0x62F87A0", VA = "0x1862F93A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x62F98F0", Offset = "0x62F8CF0", VA = "0x1862F98F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x62FA3C0", Offset = "0x62F97C0", VA = "0x1862FA3C0")]
	internal CBMPFOIIPEM(CBMPFOIIPEM<T> LLPLHOOOAEB, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62F9FF0", Offset = "0x62F93F0", VA = "0x1862F9FF0")]
	private CBMPFOIIPEM(T[] LLPLHOOOAEB, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62FA080", Offset = "0x62F9480", VA = "0x1862FA080")]
	public CBMPFOIIPEM(IEnumerable<T> JGMAGBDHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x62FA010", Offset = "0x62F9410", VA = "0x1862FA010")]
	public CBMPFOIIPEM(int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x62F9D30", Offset = "0x62F9130", VA = "0x1862F9D30")]
	public int NDOEKMMOHNB(T FFOEEMKIKJO, int HCJENEHBBIC, int ECKHNAPCKGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62F99A0", Offset = "0x62F8DA0", VA = "0x1862F99A0")]
	public void HNHCMIBBMLF(int BGMFPCBOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x62F9B60", Offset = "0x62F8F60", VA = "0x1862F9B60")]
	private void KLCFMPNFHMO(int BGMFPCBOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62F96D0", Offset = "0x62F8AD0", VA = "0x1862F96D0")]
	public T[] DEADDHJIDDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x62F9510", Offset = "0x62F8910", VA = "0x1862F9510")]
	public T[] CNGHJFEEEPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x62F9800", Offset = "0x62F8C00", VA = "0x1862F9800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62F9880", Offset = "0x62F8C80", VA = "0x1862F9880")]
	public void EHNIGEHKPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62F9660", Offset = "0x62F8A60", VA = "0x1862F9660")]
	public FHKIIGBCMNP DBEEDGEHMMA()
	{
		return default(FHKIIGBCMNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x62F9E10", Offset = "0x62F9210", VA = "0x1862F9E10", Slot = "5")]
	[IteratorStateMachine(typeof(CBMPFOIIPEM<>.LOAFOMDCCBJ))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x62F9F00", Offset = "0x62F9300", VA = "0x1862F9F00", Slot = "6")]
	[IteratorStateMachine(typeof(CBMPFOIIPEM<>.FGGKIGONHDO))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x62F9DB0", Offset = "0x62F91B0", VA = "0x1862F9DB0")]
	public static CBMPFOIIPEM<T> OMGLNNFDCFB(T[] LLPLHOOOAEB)
	{
		return default(CBMPFOIIPEM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x62F9470", Offset = "0x62F8870", VA = "0x1862F9470")]
	public static CBMPFOIIPEM<T> CLMIANKGGAM(T[] LLPLHOOOAEB)
	{
		return default(CBMPFOIIPEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x62F9780", Offset = "0x62F8B80", VA = "0x1862F9780")]
	private void DKHMGHICAHC(int CJFNAFNJJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class LEHDJFKJBJH<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct FDJKOJEHMLB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private LEHDJFKJBJH<T> CEFIHBLEFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x471C480", Offset = "0x471B880", VA = "0x18471C480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x471C4C0", Offset = "0x471B8C0", VA = "0x18471C4C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4380150", Offset = "0x437F550", VA = "0x184380150")]
		public FDJKOJEHMLB(LEHDJFKJBJH<T> CEFIHBLEFNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x471C390", Offset = "0x471B790", VA = "0x18471C390", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x471C430", Offset = "0x471B830", VA = "0x18471C430", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private CBMPFOIIPEM<T> HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int BFBCILDCBHG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E5CE80", Offset = "0x4E5C280", VA = "0x184E5CE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x49FC380", Offset = "0x49FB780", VA = "0x1849FC380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int DIPAECOCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4E5D980", Offset = "0x4E5CD80", VA = "0x184E5D980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool IDHODAIBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DA60", Offset = "0x4E5CE60", VA = "0x184E5DA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public HJOPONMGOMN<T> MPDMFCNAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4E5D1D0", Offset = "0x4E5C5D0", VA = "0x184E5D1D0")]
		get
		{
			return default(HJOPONMGOMN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DD70", Offset = "0x4E5D170", VA = "0x184E5DD70")]
	public LEHDJFKJBJH(IEnumerable<T> JGMAGBDHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DD00", Offset = "0x4E5D100", VA = "0x184E5DD00")]
	public LEHDJFKJBJH(int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x47AA800", Offset = "0x47A9C00", VA = "0x1847AA800")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D9A0", Offset = "0x4E5CDA0", VA = "0x184E5D9A0")]
	public CBMPFOIIPEM<T> MGBCIHAOMIF()
	{
		return default(CBMPFOIIPEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D250", Offset = "0x4E5C650", VA = "0x184E5D250")]
	public void JJBKLNLGAIJ(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D0B0", Offset = "0x4E5C4B0", VA = "0x184E5D0B0")]
	private void HNHCMIBBMLF(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D800", Offset = "0x4E5CC00", VA = "0x184E5D800")]
	public void KJPCKFGIEPN(List<T> KLIMJMOCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D760", Offset = "0x4E5CB60", VA = "0x184E5D760")]
	public void KJPCKFGIEPN(T[] KLIMJMOCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D0F0", Offset = "0x4E5C4F0", VA = "0x184E5D0F0")]
	public void ICCNAFAJNNM(int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DA80", Offset = "0x4E5CE80", VA = "0x184E5DA80")]
	public void OECNDFKLHBB(int OEGAPGHOHKE, int FNNKAHMFNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D9E0", Offset = "0x4E5CDE0", VA = "0x184E5D9E0")]
	public int NDOEKMMOHNB(T FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D4C0", Offset = "0x4E5C8C0", VA = "0x184E5D4C0")]
	public bool JOEMDCADNHJ(T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4E5CFB0", Offset = "0x4E5C3B0", VA = "0x184E5CFB0")]
	public T[] CNGHJFEEEPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D020", Offset = "0x4E5C420", VA = "0x184E5D020", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4E5CEF0", Offset = "0x4E5C2F0", VA = "0x184E5CEF0")]
	public static CBMPFOIIPEM<T> CLMIANKGGAM(LEHDJFKJBJH<T> CEFIHBLEFNG)
	{
		return default(CBMPFOIIPEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D040", Offset = "0x4E5C440", VA = "0x184E5D040", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DC50", Offset = "0x4E5D050", VA = "0x184E5DC50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4E5DC90", Offset = "0x4E5D090", VA = "0x184E5DC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D370", Offset = "0x4E5C770", VA = "0x184E5D370")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void JODMICLOIJM(int FFOEEMKIKJO, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4E5D510", Offset = "0x4E5C910", VA = "0x184E5D510")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void KCJILOIDDFB(int OEGAPGHOHKE, int FNNKAHMFNCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class AFMKLFADKHD
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3D87590", Offset = "0x3D86990", VA = "0x183D87590")]
	public static void EHNIGEHKPEH<T>(this LEHDJFKJBJH<T> CEFIHBLEFNG) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public ref struct HJOPONMGOMN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x491C1B0", Offset = "0x491B5B0", VA = "0x18491C1B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x491C320", Offset = "0x491B720", VA = "0x18491C320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x491C290", Offset = "0x491B690", VA = "0x18491C290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public HJOPONMGOMN(Span<object> BGFHEKCGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x491C3A0", Offset = "0x491B7A0", VA = "0x18491C3A0")]
	public HJOPONMGOMN<T> IDOMHGEABJN(int HCJENEHBBIC)
	{
		return default(HJOPONMGOMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x491C470", Offset = "0x491B870", VA = "0x18491C470")]
	public HJOPONMGOMN<T> IDOMHGEABJN(int HCJENEHBBIC, int BFBCILDCBHG)
	{
		return default(HJOPONMGOMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x491C230", Offset = "0x491B630", VA = "0x18491C230")]
	public void DHDJJANPOHF(HJOPONMGOMN<T> NDGLCGNJECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x491C550", Offset = "0x491B950", VA = "0x18491C550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x491C2D0", Offset = "0x491B6D0", VA = "0x18491C2D0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x491C350", Offset = "0x491B750", VA = "0x18491C350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct GIEALLIDLLC : IEquatable<GIEALLIDLLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int HGHGCNDALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int ECKHNAPCKGD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int MPKJDDCJPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB98E0", Offset = "0x2CB8CE0", VA = "0x182CB98E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C890", Offset = "0x6B3BC90", VA = "0x186B3C890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LDHNLFPMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int NJIDHPODGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x78D0300", Offset = "0x78CF700", VA = "0x1878D0300")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x78D0310", Offset = "0x78CF710", VA = "0x1878D0310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public (int begin, int end) FODAKNAGMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x78D0200", Offset = "0x78CF600", VA = "0x1878D0200")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
	private GIEALLIDLLC(int HGHGCNDALFP, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2695630", Offset = "0x2694A30", VA = "0x182695630")]
	public static GIEALLIDLLC NDNDMPBEJKE(int HGHGCNDALFP, int ECKHNAPCKGD)
	{
		return default(GIEALLIDLLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x78D0260", Offset = "0x78CF660", VA = "0x1878D0260")]
	public static GIEALLIDLLC DNGGOLJFNBC(int HCJENEHBBIC, int FNNKAHMFNCJ)
	{
		return default(GIEALLIDLLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x78D0320", Offset = "0x78CF720", VA = "0x1878D0320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1796AF0", Offset = "0x1795EF0", VA = "0x181796AF0", Slot = "4")]
	public bool Equals(GIEALLIDLLC KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x78D0270", Offset = "0x78CF670", VA = "0x1878D0270", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C9D0", Offset = "0x6C9BDD0", VA = "0x186C9C9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct GCEFBEMEOOI<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public GCEFBEMEOOI(NativeArray<T> HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4821DE0", Offset = "0x48211E0", VA = "0x184821DE0", Slot = "6")]
	public int Compare(int MEAMPLHPPKP, int KDELALKKKOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4821ED0", Offset = "0x48212D0", VA = "0x184821ED0", Slot = "4")]
	public bool Equals(int MEAMPLHPPKP, int KDELALKKKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4821FC0", Offset = "0x48213C0", VA = "0x184821FC0", Slot = "5")]
	public int GetHashCode(int MEAMPLHPPKP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FONMCDAGOGO
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x35E4850", Offset = "0x35E3C50", VA = "0x1835E4850")]
	public static T[] EEFINHJGNPA<T>(List<T> CEFIHBLEFNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EFACDNEGJCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* COHOKDLBNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle DIKBIJGLAED;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x577E3D0", Offset = "0x577D7D0", VA = "0x18577E3D0")]
	public void LIPICMLEJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class ADPKPBLAPDI
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3D021A0", Offset = "0x3D015A0", VA = "0x183D021A0")]
	public static EFACDNEGJCI OHKDDCJCGFC<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> IMOLDFICHHJ) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(EFACDNEGJCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3D021A0", Offset = "0x3D015A0", VA = "0x183D021A0")]
	public static UnsafeParallelHashMap<TKey, TValue> GFGOMIGFCBI<TKey, TValue>(this EFACDNEGJCI IMOLDFICHHJ) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class NLOMMKFJPKM
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x37D84E0", Offset = "0x37D78E0", VA = "0x1837D84E0")]
	public static int APLOFAMPINA<T>(ReadOnlySpan<T> OMEDFPNJPPO, ReadOnlySpan<T> OLFLJLGBKMP, int BFBCILDCBHG) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class CKLCAAGKPGO
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3400260", Offset = "0x33FF660", VA = "0x183400260")]
	public static T DDCLNCKPBBO<T>(this NativeArray<byte> IEAOMLJNJLM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x33FFE40", Offset = "0x33FF240", VA = "0x1833FFE40")]
	public static NativeArray<T> BIIKBJMPPII<T>(this NativeArray<byte> IEAOMLJNJLM, int ECKHNAPCKGD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3400390", Offset = "0x33FF790", VA = "0x183400390")]
	public static void FEAAJMEOMKD<T>(this NativeList<byte> NOOEFABFCIC, [In] T FFOEEMKIKJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x34002F0", Offset = "0x33FF6F0", VA = "0x1834002F0")]
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

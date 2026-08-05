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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84FADB0", Offset = "0x84F93B0", VA = "0x1884FADB0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AFJFHHNIBMF]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F55810", Offset = "0x3F53E10", VA = "0x183F55810")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AFJFHHNIBMF]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F569D0", Offset = "0x3F54FD0", VA = "0x183F569D0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F55A10", Offset = "0x3F54010", VA = "0x183F55A10")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F55C20", Offset = "0x3F54220", VA = "0x183F55C20")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F950", Offset = "0x3F5DF50", VA = "0x183F5F950")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F6E0", Offset = "0x3F5DCE0", VA = "0x183F5F6E0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F850", Offset = "0x3F5DE50", VA = "0x183F5F850")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3F5FFA0", Offset = "0x3F5E5A0", VA = "0x183F5FFA0")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3F57160", Offset = "0x3F55760", VA = "0x183F57160")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3F57220", Offset = "0x3F55820", VA = "0x183F57220")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F57680", Offset = "0x3F55C80", VA = "0x183F57680")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, NDDIGIFKAJC range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F576C0", Offset = "0x3F55CC0", VA = "0x183F576C0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3F57500", Offset = "0x3F55B00", VA = "0x183F57500")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F55860", Offset = "0x3F53E60", VA = "0x183F55860")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F790", Offset = "0x3F5DD90", VA = "0x183F5F790")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AFJFHHNIBMF]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F61260", Offset = "0x3F5F860", VA = "0x183F61260")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F62140", Offset = "0x3F60740", VA = "0x183F62140")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3F62150", Offset = "0x3F60750", VA = "0x183F62150")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x54C21A0", Offset = "0x54C07A0", VA = "0x1854C21A0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84FB3D0", Offset = "0x84F99D0", VA = "0x1884FB3D0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84FB400", Offset = "0x84F9A00", VA = "0x1884FB400")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F61640", Offset = "0x3F5FC40", VA = "0x183F61640")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F615F0", Offset = "0x3F5FBF0", VA = "0x183F615F0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F618B0", Offset = "0x3F5FEB0", VA = "0x183F618B0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F61520", Offset = "0x3F5FB20", VA = "0x183F61520")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F61860", Offset = "0x3F5FE60", VA = "0x183F61860")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F616F0", Offset = "0x3F5FCF0", VA = "0x183F616F0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F61BB0", Offset = "0x3F601B0", VA = "0x183F61BB0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F61A10", Offset = "0x3F60010", VA = "0x183F61A10")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F61670", Offset = "0x3F5FC70", VA = "0x183F61670")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F614C0", Offset = "0x3F5FAC0", VA = "0x183F614C0")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F614A0", Offset = "0x3F5FAA0", VA = "0x183F614A0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F62570", Offset = "0x3F60B70", VA = "0x183F62570")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F621A0", Offset = "0x3F607A0", VA = "0x183F621A0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F625A0", Offset = "0x3F60BA0", VA = "0x183F625A0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3F62650", Offset = "0x3F60C50", VA = "0x183F62650")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AFJFHHNIBMF]
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
			[Cpp2IlInjected.Address(RVA = "0x51447B0", Offset = "0x5142DB0", VA = "0x1851447B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF79720", Offset = "0xF77D20", VA = "0x180F79720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x578EE90", Offset = "0x578D490", VA = "0x18578EE90")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5A9E7D0", Offset = "0x5A9CDD0", VA = "0x185A9E7D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5A9E6F0", Offset = "0x5A9CCF0", VA = "0x185A9E6F0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4542AF0", Offset = "0x45410F0", VA = "0x184542AF0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AFJFHHNIBMF]
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
			[Cpp2IlInjected.Address(RVA = "0x51447B0", Offset = "0x5142DB0", VA = "0x1851447B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5AF0450", Offset = "0x5AEEA50", VA = "0x185AF0450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x578EE90", Offset = "0x578D490", VA = "0x18578EE90")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5AEFDC0", Offset = "0x5AEE3C0", VA = "0x185AEFDC0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5AF00C0", Offset = "0x5AEE6C0", VA = "0x185AF00C0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5AF0330", Offset = "0x5AEE930", VA = "0x185AF0330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5AF0260", Offset = "0x5AEE860", VA = "0x185AF0260")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AFJFHHNIBMF]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AFJFHHNIBMF]
public static class NDCJPNJGNAM
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84FB130", Offset = "0x84F9730", VA = "0x1884FB130")]
	public static JobHandle HDLPEMINNAL(this JobHandle JGPEJMANNEB, JobHandle PDHHCOODKIC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84FB170", Offset = "0x84F9770", VA = "0x1884FB170")]
	public static JobHandle OHHMFMBLAHM(this Span<JobHandle> NMIBJADALJH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JACPKPHBDHA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A50620", Offset = "0x3A4EC20", VA = "0x183A50620")]
	public static void ELFNJAKNOMA<T>(this T[] GHKPAFFMJAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HKDEONFHHCF
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DECB10", Offset = "0x3DEB110", VA = "0x183DECB10")]
	public static NativeKeyValueArrays<TKey, TValue> JPGCALDCLMO<TKey, TValue>(this Dictionary<TKey, TValue> LLNAAJAADDM, Allocator EEDCBHBBPKF) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MEGPFGDMCNO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84FAF80", Offset = "0x84F9580", VA = "0x1884FAF80")]
	public static void NEJONKPCKNN(this GameObject JJEACKINPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84FAE40", Offset = "0x84F9440", VA = "0x1884FAE40")]
	public static void NEJONKPCKNN(this Component IDFKPPKNONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84FAEE0", Offset = "0x84F94E0", VA = "0x1884FAEE0")]
	public static void NEJONKPCKNN(this ScriptableObject GKPPKJFGJFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BMIEOIHDLFA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84F9980", Offset = "0x84F7F80", VA = "0x1884F9980")]
	public static void DMIIHNGPKJN(this NativeList<byte> BBBJHCKNPGO, ReadOnlySpan<byte> KGKBFOGHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CE50", Offset = "0x3B6B450", VA = "0x183B6CE50")]
	public static void FBIOKBPPFJO<T>(this NativeList<T> BBBJHCKNPGO, T KOPHBHGIACG, int LMJBLNOIBOL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GLKMAIBJLLK
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DDED90", Offset = "0x3DDD390", VA = "0x183DDED90")]
	public static T CEGGFJCLNBL<T>(this ReadOnlySpan<byte> KOPHBHGIACG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEFD0", Offset = "0x3DDD5D0", VA = "0x183DDEFD0")]
	public static T CKFBNIJFHMN<T>(this Span<T> KGKBFOGHBGD, Func<T, bool> KIPJKBOOFDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF5E0", Offset = "0x3DDDBE0", VA = "0x183DDF5E0")]
	public static bool HJGBFDBNFPJ<T>(this Span<T> KGKBFOGHBGD, Func<T, bool> KIPJKBOOFDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF550", Offset = "0x3DDDB50", VA = "0x183DDF550")]
	public static bool HFFLANANDOD<T>(this Span<T> KGKBFOGHBGD, Func<T, bool> KIPJKBOOFDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF0F0", Offset = "0x3DDD6F0", VA = "0x183DDF0F0")]
	public static T HBAOOBIPNDD<T>([In] this ReadOnlySpan<byte> KGKBFOGHBGD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DDED50", Offset = "0x3DDD350", VA = "0x183DDED50")]
	public static Span<TTo> BBKJLFGOLHE<TTo, TFrom>(this Span<TFrom> KGKBFOGHBGD) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DDED50", Offset = "0x3DDD350", VA = "0x183DDED50")]
	public static ReadOnlySpan<TTo> BBKJLFGOLHE<TTo, TFrom>(this ReadOnlySpan<TFrom> KGKBFOGHBGD) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DDED50", Offset = "0x3DDD350", VA = "0x183DDED50")]
	public static ReadOnlySpan<TTo> BBKJLFGOLHE<TTo>(this ReadOnlySpan<byte> KGKBFOGHBGD) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFAF0", Offset = "0x3DDE0F0", VA = "0x183DDFAF0")]
	public static Span<T> JGHKMFOJCLP<T>(this ReadOnlySpan<T> PPEFJKBNOEP) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF670", Offset = "0x3DDDC70", VA = "0x183DDF670")]
	public static Span<byte> IAMMACFOCIM<T>([In] this Span<byte> KGKBFOGHBGD, T KOPHBHGIACG) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84F9F70", Offset = "0x84F8570", VA = "0x1884F9F70")]
	private static Enum PPCFLJOAMFM([In] ReadOnlySpan<byte> KGKBFOGHBGD, Type EFHHFOIKMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84F9A20", Offset = "0x84F8020", VA = "0x1884F9A20")]
	public static Enum JAHCILGLMKE([In] this Span<byte> KGKBFOGHBGD, Type EFHHFOIKMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84F9A90", Offset = "0x84F8090", VA = "0x1884F9A90")]
	public static void LNNNIINIEHJ([In] this Span<byte> KGKBFOGHBGD, Enum KCKCBGONOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JPJEOHANMMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HFPCOHJLAME : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x84FA520", Offset = "0x84F8B20", VA = "0x1884FA520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84FA6A0", Offset = "0x84F8CA0", VA = "0x1884FA6A0")]
	[AsyncStateMachine(typeof(HFPCOHJLAME))]
	public static void KJPOAFCDBLI(this Task DHDFDKFCOJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HLACKIJEJPF
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DECD60", Offset = "0x3DEB360", VA = "0x183DECD60")]
	public static NativeArray<T> GNHMJJBEBGN<T>(this UnsafeList<T> BBBJHCKNPGO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3DECCF0", Offset = "0x3DEB2F0", VA = "0x183DECCF0")]
	public static NativeArray<T> CPDHGNBODDH<T>(this UnsafeList<T> BBBJHCKNPGO, bool MJCFBEAEKHN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DECDB0", Offset = "0x3DEB3B0", VA = "0x183DECDB0")]
	public static UnsafeList<T> JGHKMFOJCLP<T>(this UnsafeList<T> BBBJHCKNPGO, Allocator EEDCBHBBPKF) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ODHPMNKFNNH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum FMOIECCGJFJ : short
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
	public struct OGKIOCBJGMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly FMOIECCGJFJ HAELBKGFDIJ;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3276BC0", Offset = "0x32751C0", VA = "0x183276BC0")]
		public OGKIOCBJGMH(FMOIECCGJFJ HAELBKGFDIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory OKIBPDDCDLN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public static void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84FB430", Offset = "0x84F9A30", VA = "0x1884FB430")]
	static ODHPMNKFNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A68090", Offset = "0x3A66690", VA = "0x183A68090")]
	public static OGKIOCBJGMH FDJOKDEJDEI(FMOIECCGJFJ HAELBKGFDIJ)
	{
		return default(OGKIOCBJGMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public static void JFHJPHGNNBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class FNBMBFKOHPF
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D98820", Offset = "0x2D96E20", VA = "0x182D98820")]
	public static EEOHEFGAENL<T1, T2> PCFJMLLMJLI<T1, T2>(this (T1, T2) COLOJJOBMEE) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(EEOHEFGAENL<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5040", Offset = "0x3DC3640", VA = "0x183DC5040")]
	public static AKCPGDKBELF<T1, T2, T3> PCFJMLLMJLI<T1, T2, T3>(this (T1, T2, T3) COLOJJOBMEE) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(AKCPGDKBELF<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EEOHEFGAENL<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) COLOJJOBMEE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D98460", Offset = "0x2D96A60", VA = "0x182D98460")]
	public EEOHEFGAENL((T1, T2) COLOJJOBMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4B338B0", Offset = "0x4B31EB0", VA = "0x184B338B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AKCPGDKBELF<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) COLOJJOBMEE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4B33920", Offset = "0x4B31F20", VA = "0x184B33920")]
	public AKCPGDKBELF((T1, T2, T3) COLOJJOBMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x57A41F0", Offset = "0x57A27F0", VA = "0x1857A41F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LNAIIACMMBF
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84FAD50", Offset = "0x84F9350", VA = "0x1884FAD50")]
	public static Range JJPHAOJANNC(this NDDIGIFKAJC ICKFEKPLGLA)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PDMBGAFIOOK
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct EAFCIBGEGKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int AHHPNEGFFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int PAHJFGCGJNK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84F9A10", Offset = "0x84F8010", VA = "0x1884F9A10")]
		public EAFCIBGEGKF(int GHOFJOJMCOI, int PAHJFGCGJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84F9A00", Offset = "0x84F8000", VA = "0x1884F9A00")]
		public bool DDPDBHDONME()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84FB4A0", Offset = "0x84F9AA0", VA = "0x1884FB4A0")]
	public static EAFCIBGEGKF ABGODHCJODA(this Range ICKFEKPLGLA)
	{
		return default(EAFCIBGEGKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JGGNBNENHFG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle MNHLJANEAIO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EBLECNDEEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x54C21D0", Offset = "0x54C07D0", VA = "0x1854C21D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x54C22B0", Offset = "0x54C08B0", VA = "0x1854C22B0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x54C2410", Offset = "0x54C0A10", VA = "0x1854C2410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x54C2A00", Offset = "0x54C1000", VA = "0x1854C2A00")]
	public JGGNBNENHFG(T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x54C21A0", Offset = "0x54C07A0", VA = "0x1854C21A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class BJGPALKLGOJ<THandle, TValue> : IDisposable where THandle : struct, EDMHOEDPFHJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> NMIBJADALJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> LGMBOCEBOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> LHGGIIMDMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> KLAPLLHGIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int NKANOANDPDM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7A20", Offset = "0x6AF6020", VA = "0x186AF7A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7B80", Offset = "0x6AF6180", VA = "0x186AF7B80")]
	public BJGPALKLGOJ(Action<TValue> KLAPLLHGIJM, [Optional] Func<TValue> LHGGIIMDMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7220", Offset = "0x6AF5820", VA = "0x186AF7220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF79A0", Offset = "0x6AF5FA0", VA = "0x186AF79A0")]
	public THandle MEFAAGOGBHI(TValue KOPHBHGIACG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF72A0", Offset = "0x6AF58A0", VA = "0x186AF72A0")]
	public bool GELLEPHLJAH(THandle MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7AD0", Offset = "0x6AF60D0", VA = "0x186AF7AD0")]
	public bool PKCFNJDKDMF(THandle MNHLJANEAIO, [Out] TValue KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AF73E0", Offset = "0x6AF59E0", VA = "0x186AF73E0")]
	public TValue HBAOOBIPNDD(THandle MNHLJANEAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7110", Offset = "0x6AF5710", VA = "0x186AF7110")]
	public bool CCCINLIBFDH(THandle MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7390", Offset = "0x6AF5990", VA = "0x186AF7390")]
	private THandle GLPLOAJDCKD(int PMIGBJGNLLP)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7520", Offset = "0x6AF5B20", VA = "0x186AF7520")]
	private TValue JCJJAHBLGNJ(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7A90", Offset = "0x6AF6090", VA = "0x186AF7A90")]
	private void PBNECOBHDAI(int PMIGBJGNLLP, [In] THandle MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7A50", Offset = "0x6AF6050", VA = "0x186AF7A50")]
	private void ODEJKIDCLNB(int PMIGBJGNLLP, [In] TValue KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7570", Offset = "0x6AF5B70", VA = "0x186AF7570")]
	private THandle JGPCLLCGEAK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7830", Offset = "0x6AF5E30", VA = "0x186AF7830")]
	private void JMNEPBMIJDC(THandle MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7510", Offset = "0x6AF5B10", VA = "0x186AF7510")]
	private int IPIPMDGEBIO(int AENIMEGPBEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7210", Offset = "0x6AF5810", VA = "0x186AF7210")]
	private bool CONLGDKFBAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAAA0C0", Offset = "0xAA86C0", VA = "0x180AAA0C0")]
	private void PPOEDKLPCIC(THandle MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7900", Offset = "0x6AF5F00", VA = "0x186AF7900")]
	private bool KJENEIODEKM([Out] THandle MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7430", Offset = "0x6AF5A30", VA = "0x186AF7430")]
	private bool IDGNBGNEOFD([Out] THandle MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF76D0", Offset = "0x6AF5CD0", VA = "0x186AF76D0")]
	private void JMNBCKEEOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EDMHOEDPFHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int AMOFDJHKCMK
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
public static class KPDPGBGHMDN
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2E30", Offset = "0x3EB1430", VA = "0x183EB2E30")]
	public static bool BEMMJBDKFNH<T>(this T MNHLJANEAIO, T AAGCKLPFJME) where T : struct, EDMHOEDPFHJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2E50", Offset = "0x3EB1450", VA = "0x183EB2E50")]
	public static bool GLJIKBGGLIL<T>(this T MNHLJANEAIO) where T : struct, EDMHOEDPFHJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84FA7C0", Offset = "0x84F8DC0", VA = "0x1884FA7C0")]
	public static string AGMDOGNLGKG(this EDMHOEDPFHJ MNHLJANEAIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct MKIABNBOMIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type NHGFJENKCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> OMAHIPILJNH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x57AFB10", Offset = "0x57AE110", VA = "0x1857AFB10")]
	public MKIABNBOMIK(Type FAECPPMLNNN, Span<byte> KGKBFOGHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7440", Offset = "0x3ED5A40", VA = "0x183ED7440")]
	public static MKIABNBOMIK IJMKJHNKLOK<T>(T KOPHBHGIACG) where T : struct
	{
		return default(MKIABNBOMIK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x84FB020", Offset = "0x84F9620", VA = "0x1884FB020")]
	public static BCHOKPBGIPC HNGLNPFKABH([In] MKIABNBOMIK OCNJDNNPAAP)
	{
		return default(BCHOKPBGIPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x84FB0A0", Offset = "0x84F96A0", VA = "0x1884FB0A0")]
	public Enum JAHCILGLMKE(Type EFHHFOIKMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7410", Offset = "0x3ED5A10", VA = "0x183ED7410")]
	public void IAMMACFOCIM<T>([In] T KOPHBHGIACG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x84FB120", Offset = "0x84F9720", VA = "0x1884FB120")]
	public void LNNNIINIEHJ(Enum KCKCBGONOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct BCHOKPBGIPC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct HBIIKLGHEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* OAPJNBEGPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* BICCKJAFAJE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type NHGFJENKCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> OMAHIPILJNH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JLGGGHNPGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84F9600", Offset = "0x84F7C00", VA = "0x1884F9600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LKLFNLEBPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84F95B0", Offset = "0x84F7BB0", VA = "0x1884F95B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x57AFB10", Offset = "0x57AE110", VA = "0x1857AFB10")]
	public BCHOKPBGIPC(Type FAECPPMLNNN, ReadOnlySpan<byte> KGKBFOGHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B57F80", Offset = "0x3B56580", VA = "0x183B57F80")]
	public static BCHOKPBGIPC IJMKJHNKLOK<T>(T KOPHBHGIACG) where T : struct
	{
		return default(BCHOKPBGIPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x84F9610", Offset = "0x84F7C10", VA = "0x1884F9610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x84F93E0", Offset = "0x84F79E0", VA = "0x1884F93E0")]
	public object AIKLNCHGHGD(int PMIGBJGNLLP = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BMDHMGCGIJN
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CDA0", Offset = "0x3B6B3A0", VA = "0x183B6CDA0")]
	public static NativeArray<T> IJMKJHNKLOK<T>(T KOPHBHGIACG, bool MJCFBEAEKHN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CD70", Offset = "0x3B6B370", VA = "0x183B6CD70")]
	public static NativeArray<T> IEHGJJJLMCF<T>(T KOPHBHGIACG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CDE0", Offset = "0x3B6B3E0", VA = "0x183B6CDE0")]
	public static NativeArray<T> KJEEFNMKKLN<T>(T KOPHBHGIACG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x84F98C0", Offset = "0x84F7EC0", VA = "0x1884F98C0")]
	public static NativeArray<byte> KJEEFNMKKLN(ReadOnlySpan<byte> KOPHBHGIACG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x84F9790", Offset = "0x84F7D90", VA = "0x1884F9790")]
	public static NativeArray<byte> IJMKJHNKLOK(ReadOnlySpan<byte> KOPHBHGIACG, bool MJCFBEAEKHN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x84F9840", Offset = "0x84F7E40", VA = "0x1884F9840")]
	public unsafe static NativeArray<byte> IJMKJHNKLOK(byte* JHHCFBDKMFB, int NODGHDHCBPE, bool MJCFBEAEKHN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CD00", Offset = "0x3B6B300", VA = "0x183B6CD00")]
	public static NativeArray<T> HPOBBIFAPGN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct ALENKJJJMPF : IEquatable<ALENKJJJMPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int FHIPANGHNKE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type HIKNDMJOAGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84F9140", Offset = "0x84F7740", VA = "0x1884F9140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84F9340", Offset = "0x84F7940", VA = "0x1884F9340")]
	public ALENKJJJMPF(Type GPEIAHGICNA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84F9270", Offset = "0x84F7870", VA = "0x1884F9270")]
	public static ALENKJJJMPF HNGLNPFKABH(Type GPEIAHGICNA)
	{
		return default(ALENKJJJMPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x25282D0", Offset = "0x25268D0", VA = "0x1825282D0", Slot = "4")]
	public bool Equals(ALENKJJJMPF AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x84F91F0", Offset = "0x84F77F0", VA = "0x1884F91F0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x84F9300", Offset = "0x84F7900", VA = "0x1884F9300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LEKEKOIKGOC
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> KAEPFNKPCID;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> BEFJPMLHLFF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84FABC0", Offset = "0x84F91C0", VA = "0x1884FABC0")]
	static LEKEKOIKGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x84FA9B0", Offset = "0x84F8FB0", VA = "0x1884FA9B0")]
	public static bool MEFAAGOGBHI(Type GPEIAHGICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x84FAA10", Offset = "0x84F9010", VA = "0x1884FAA10")]
	private static bool MEFAAGOGBHI(Type GPEIAHGICNA, [Out] int PMIGBJGNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x84FA950", Offset = "0x84F8F50", VA = "0x1884FA950")]
	public static int LPOKKBOJPBB(Type GPEIAHGICNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84FA8D0", Offset = "0x84F8ED0", VA = "0x1884FA8D0")]
	public static Type HBAOOBIPNDD(int PMIGBJGNLLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PJMDAJBDILH<Handle> where Handle : EDMHOEDPFHJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct ABLIPJFBMJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly PJMDAJBDILH<Handle> BHPJDAFOMDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int PMIGBJGNLLP;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle GBBENNHLKDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x531ECE0", Offset = "0x531D2E0", VA = "0x18531ECE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x531EF10", Offset = "0x531D510", VA = "0x18531EF10")]
		public ABLIPJFBMJF(PJMDAJBDILH<Handle> BHPJDAFOMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x531E8B0", Offset = "0x531CEB0", VA = "0x18531E8B0")]
		public EAOGEEOCMNC CPNHECDILPK([In] EAOGEEOCMNC APAPCLFINDP)
		{
			return default(EAOGEEOCMNC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x531E950", Offset = "0x531CF50", VA = "0x18531E950")]
		public bool DDPDBHDONME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x531EE50", Offset = "0x531D450", VA = "0x18531EE50")]
		private Handle PHJKCANBILE(string GKNICJPCIJJ)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct EAOGEEOCMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private ABLIPJFBMJF HCHKBIFBHCB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4AF7DF0", Offset = "0x4AF63F0", VA = "0x184AF7DF0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4AF7E70", Offset = "0x4AF6470", VA = "0x184AF7E70")]
		public EAOGEEOCMNC(PJMDAJBDILH<Handle> BHPJDAFOMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4AF7D70", Offset = "0x4AF6370", VA = "0x184AF7D70")]
		public bool DDPDBHDONME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4AF7CF0", Offset = "0x4AF62F0", VA = "0x184AF7CF0")]
		public EAOGEEOCMNC ABGODHCJODA()
		{
			return default(EAOGEEOCMNC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> MEHCNEMJDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> KCDIEOBLOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int LDCMJGPKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int JMGJANAFKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool ELGKLHGPIBA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MEPOLPJPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5CD68D0", Offset = "0x5CD4ED0", VA = "0x185CD68D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EAOGEEOCMNC PCHLMMCJLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5CD63A0", Offset = "0x5CD49A0", VA = "0x185CD63A0")]
		get
		{
			return default(EAOGEEOCMNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6DB0", Offset = "0x5CD53B0", VA = "0x185CD6DB0")]
	public PJMDAJBDILH(int PFDNBMJFENE, Allocator EEDCBHBBPKF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CD62E0", Offset = "0x5CD48E0", VA = "0x185CD62E0")]
	public void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x257EC30", Offset = "0x257D230", VA = "0x18257EC30")]
	public static int IPIPMDGEBIO(int KMDIJJMODFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3295640", Offset = "0x3293C40", VA = "0x183295640")]
	public static bool AJJFFCJELND(int KMDIJJMODFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6A30", Offset = "0x5CD5030", VA = "0x185CD6A30")]
	public bool LHEDJNHBAHP(int PMIGBJGNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5CD60C0", Offset = "0x5CD46C0", VA = "0x185CD60C0")]
	public bool CNCGDBDLGMN(Handle MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6910", Offset = "0x5CD4F10", VA = "0x185CD6910")]
	public Handle KMAHEOCBAPO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6440", Offset = "0x5CD4A40", VA = "0x185CD6440")]
	public void IJJCNGJFKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6D40", Offset = "0x5CD5340", VA = "0x185CD6D40")]
	public void PEOAHCNJBCD(Handle MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290")]
	private bool EMDOFCFNEDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6060", Offset = "0x5CD4660", VA = "0x185CD6060")]
	private bool CFGMCAMBIKO(int PMIGBJGNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6760", Offset = "0x5CD4D60", VA = "0x185CD6760")]
	private void ILKBPEMMDFM([Out] int PMIGBJGNLLP, [Out] int AENIMEGPBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6C00", Offset = "0x5CD5200", VA = "0x185CD6C00")]
	private void OBJJGMFLCJM(Handle MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD69E0", Offset = "0x5CD4FE0", VA = "0x185CD69E0")]
	private void LBILAIIMIKF(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6230", Offset = "0x5CD4830", VA = "0x185CD6230")]
	private bool EKNEJMGHLCB([Out] int PMIGBJGNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6B50", Offset = "0x5CD5150", VA = "0x185CD6B50")]
	private static Handle NKKHJEFOAOO(int PMIGBJGNLLP, int AENIMEGPBEO)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct DAKCEKOKKEA<Handle, T> where Handle : EDMHOEDPFHJ, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PJMDAJBDILH<Handle> OMILEEGLPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] EJNOGMMAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> AAGFNFPNDHC;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x462BE60", Offset = "0x462A460", VA = "0x18462BE60")]
	public DAKCEKOKKEA(int PFDNBMJFENE, [Optional] Action<T> AAGFNFPNDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x462B920", Offset = "0x4629F20", VA = "0x18462B920")]
	public void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x462BDB0", Offset = "0x462A3B0", VA = "0x18462BDB0")]
	public bool PKCFNJDKDMF(Handle MNHLJANEAIO, [Out] T MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x462BCA0", Offset = "0x462A2A0", VA = "0x18462BCA0")]
	public Handle MEFAAGOGBHI(T MPIDDJPOOMJ)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x462BA60", Offset = "0x462A060", VA = "0x18462BA60")]
	public void KMFFMDGDNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x462B7E0", Offset = "0x4629DE0", VA = "0x18462B7E0")]
	public void CBELOMAGFLH(Handle MNHLJANEAIO, [Out] T GIFECICDPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x462B710", Offset = "0x4629D10", VA = "0x18462B710")]
	public void CBELOMAGFLH(Handle MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x462B8C0", Offset = "0x4629EC0", VA = "0x18462B8C0")]
	private T DJKPDGOGCDJ(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x462B9B0", Offset = "0x4629FB0", VA = "0x18462B9B0")]
	private void JIIFKNHJLID(int DJJCBNMJCLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct KIOIAGMFEML<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct DPELCDJHPII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private KIOIAGMFEML<T> GHKPAFFMJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int PMIGBJGNLLP;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x467C550", Offset = "0x467AB50", VA = "0x18467C550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B828F0", Offset = "0x2B80EF0", VA = "0x182B828F0")]
		public DPELCDJHPII(KIOIAGMFEML<T> GHKPAFFMJAO, int PMIGBJGNLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x467C500", Offset = "0x467AB00", VA = "0x18467C500")]
		public bool DDPDBHDONME()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ICJFDENPLLF : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KIOIAGMFEML<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public ICJFDENPLLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5258E30", Offset = "0x5257430", VA = "0x185258E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5258ED0", Offset = "0x52574D0", VA = "0x185258ED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CHILELGEJEE : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KIOIAGMFEML<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public CHILELGEJEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F89DB0", Offset = "0x6F883B0", VA = "0x186F89DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F89E50", Offset = "0x6F88450", VA = "0x186F89E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] CDDIADBJAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint KOPHBHGIACG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x567A460", Offset = "0x5678A60", VA = "0x18567A460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DEKPKOANCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x567A7A0", Offset = "0x5678DA0", VA = "0x18567A7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OBNBONBFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1A8CDE0", Offset = "0x1A8B3E0", VA = "0x181A8CDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool PLKPFKECKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x567AD40", Offset = "0x5679340", VA = "0x18567AD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JGNNNHCJFKD<T> OMAHIPILJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x567A570", Offset = "0x5678B70", VA = "0x18567A570")]
		get
		{
			return default(JGNNNHCJFKD<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x567AC70", Offset = "0x5679270", VA = "0x18567AC70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x567A6F0", Offset = "0x5678CF0", VA = "0x18567A6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x567AF30", Offset = "0x5679530", VA = "0x18567AF30")]
	internal KIOIAGMFEML(KIOIAGMFEML<T> GHKPAFFMJAO, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x567AF50", Offset = "0x5679550", VA = "0x18567AF50")]
	private KIOIAGMFEML(T[] GHKPAFFMJAO, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x567AFE0", Offset = "0x56795E0", VA = "0x18567AFE0")]
	public KIOIAGMFEML(IEnumerable<T> LGMBOCEBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x567AF70", Offset = "0x5679570", VA = "0x18567AF70")]
	public KIOIAGMFEML(int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x567A390", Offset = "0x5678990", VA = "0x18567A390")]
	public int CKEBEBFKOFK(T KOPHBHGIACG, int GHOFJOJMCOI, int LMJBLNOIBOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x567A410", Offset = "0x5678A10", VA = "0x18567A410")]
	public void CKKIDHMLGMG(int BKHCHGPBPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x567A950", Offset = "0x5678F50", VA = "0x18567A950")]
	private void JFAFOFMJLNF(int BKHCHGPBPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x567A4F0", Offset = "0x5678AF0", VA = "0x18567A4F0")]
	public T[] EFLPEFKHOLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x567AB20", Offset = "0x5679120", VA = "0x18567AB20")]
	public T[] NGACLBPFFMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x567A470", Offset = "0x5678A70", VA = "0x18567A470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x567A850", Offset = "0x5678E50", VA = "0x18567A850")]
	public void GMFLONMMAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x567A2C0", Offset = "0x56788C0", VA = "0x18567A2C0")]
	public DPELCDJHPII ABGODHCJODA()
	{
		return default(DPELCDJHPII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x567AD50", Offset = "0x5679350", VA = "0x18567AD50", Slot = "5")]
	[IteratorStateMachine(typeof(KIOIAGMFEML<>.ICJFDENPLLF))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x567AE40", Offset = "0x5679440", VA = "0x18567AE40", Slot = "6")]
	[IteratorStateMachine(typeof(KIOIAGMFEML<>.CHILELGEJEE))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x567A330", Offset = "0x5678930", VA = "0x18567A330")]
	public static KIOIAGMFEML<T> AFPICCJJJHL(T[] GHKPAFFMJAO)
	{
		return default(KIOIAGMFEML<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x567A8C0", Offset = "0x5678EC0", VA = "0x18567A8C0")]
	public static KIOIAGMFEML<T> HNGLNPFKABH(T[] GHKPAFFMJAO)
	{
		return default(KIOIAGMFEML<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x567A7D0", Offset = "0x5678DD0", VA = "0x18567A7D0")]
	private void GKGPCAEIMCJ(int PMIGBJGNLLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NMGBPLFPDOI
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F52CA0", Offset = "0x3F512A0", VA = "0x183F52CA0")]
	public static KIOIAGMFEML<T> HGLAJKEINAG<T>(this IEnumerable<T> CCHHGJKFHNJ) where T : class
	{
		return default(KIOIAGMFEML<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class BEHKKOBPFOO<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct AOFLBECFKMB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private BEHKKOBPFOO<T> BBBJHCKNPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int PMIGBJGNLLP;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x583FE50", Offset = "0x583E450", VA = "0x18583FE50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x583FE90", Offset = "0x583E490", VA = "0x18583FE90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4BFDE90", Offset = "0x4BFC490", VA = "0x184BFDE90")]
		public AOFLBECFKMB(BEHKKOBPFOO<T> BBBJHCKNPGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x583FD70", Offset = "0x583E370", VA = "0x18583FD70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x583FE00", Offset = "0x583E400", VA = "0x18583FE00", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private KIOIAGMFEML<T> CDDIADBJAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int NODGHDHCBPE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A18710", Offset = "0x6A16D10", VA = "0x186A18710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4FFDB20", Offset = "0x4FFC120", VA = "0x184FFDB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C505D0", Offset = "0x4C4EBD0", VA = "0x184C505D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MEPOLPJPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A17F50", Offset = "0x6A16550", VA = "0x186A17F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool OBNBONBFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A181E0", Offset = "0x6A167E0", VA = "0x186A181E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public JGNNNHCJFKD<T> OMAHIPILJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A17C20", Offset = "0x6A16220", VA = "0x186A17C20")]
		get
		{
			return default(JGNNNHCJFKD<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A18610", Offset = "0x6A16C10", VA = "0x186A18610")]
	public BEHKKOBPFOO(IEnumerable<T> LGMBOCEBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A186A0", Offset = "0x6A16CA0", VA = "0x186A186A0")]
	public BEHKKOBPFOO(int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A17CB0", Offset = "0x6A162B0", VA = "0x186A17CB0")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A17850", Offset = "0x6A15E50", VA = "0x186A17850")]
	public KIOIAGMFEML<T> CACDKEJBKIL()
	{
		return default(KIOIAGMFEML<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A18430", Offset = "0x6A16A30", VA = "0x186A18430")]
	public void MEFAAGOGBHI(T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A179A0", Offset = "0x6A15FA0", VA = "0x186A179A0")]
	private void CKKIDHMLGMG(int AHIAOIDMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A17A80", Offset = "0x6A16080", VA = "0x186A17A80")]
	public void DMIIHNGPKJN(List<T> FLDLNFIMHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A17A00", Offset = "0x6A16000", VA = "0x186A17A00")]
	public void DMIIHNGPKJN(T[] FLDLNFIMHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A178A0", Offset = "0x6A15EA0", VA = "0x186A178A0")]
	public bool CBELOMAGFLH(T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A17560", Offset = "0x6A15B60", VA = "0x186A17560")]
	public void ABLCCENBDNE(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A17F70", Offset = "0x6A16570", VA = "0x186A17F70")]
	public void KHNHIBIMMCC(int KAHKGNAPGHL, int PAHJFGCGJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A179E0", Offset = "0x6A15FE0", VA = "0x186A179E0")]
	public void DJKPDGOGCDJ(int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A175F0", Offset = "0x6A15BF0", VA = "0x186A175F0")]
	public void AIMENPCMGGF(int KAHKGNAPGHL, int PAHJFGCGJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A17920", Offset = "0x6A15F20", VA = "0x186A17920")]
	public int CKEBEBFKOFK(T KOPHBHGIACG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x580B540", Offset = "0x5809B40", VA = "0x18580B540")]
	public bool AOFBHNFGAFG(T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6A18530", Offset = "0x6A16B30", VA = "0x186A18530")]
	public T[] NGACLBPFFMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6A17BF0", Offset = "0x6A161F0", VA = "0x186A17BF0", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6A17D50", Offset = "0x6A16350", VA = "0x186A17D50")]
	public static KIOIAGMFEML<T> HNGLNPFKABH(BEHKKOBPFOO<T> BBBJHCKNPGO)
	{
		return default(KIOIAGMFEML<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6A17CD0", Offset = "0x6A162D0", VA = "0x186A17CD0", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED18B0", Offset = "0x5ECFEB0", VA = "0x185ED18B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A185A0", Offset = "0x6A16BA0", VA = "0x186A185A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A17E00", Offset = "0x6A16400", VA = "0x186A17E00")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void JILOBEDIIOB(int KOPHBHGIACG, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A18200", Offset = "0x6A16800", VA = "0x186A18200")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void LNPLIAHNOME(int KAHKGNAPGHL, int PAHJFGCGJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NKPLIMCPFPA
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3F500D0", Offset = "0x3F4E6D0", VA = "0x183F500D0")]
	public static void GMFLONMMAMH<T>(this BEHKKOBPFOO<T> BBBJHCKNPGO) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct JGNNNHCJFKD<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> CDDIADBJAOB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x54C33A0", Offset = "0x54C19A0", VA = "0x1854C33A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x54C3170", Offset = "0x54C1770", VA = "0x1854C3170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54C30E0", Offset = "0x54C16E0", VA = "0x1854C30E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public JGNNNHCJFKD(Span<object> KGKBFOGHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x54C31F0", Offset = "0x54C17F0", VA = "0x1854C31F0")]
	public JGNNNHCJFKD<T> LCFGJCJPPIO(int GHOFJOJMCOI)
	{
		return default(JGNNNHCJFKD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x54C32C0", Offset = "0x54C18C0", VA = "0x1854C32C0")]
	public JGNNNHCJFKD<T> LCFGJCJPPIO(int GHOFJOJMCOI, int NODGHDHCBPE)
	{
		return default(JGNNNHCJFKD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x54C3430", Offset = "0x54C1A30", VA = "0x1854C3430")]
	public void OCEKIKEEKEK(JGNNNHCJFKD<T> LGFPKFJKGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54C3490", Offset = "0x54C1A90", VA = "0x1854C3490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x54C3120", Offset = "0x54C1720", VA = "0x1854C3120", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x54C31A0", Offset = "0x54C17A0", VA = "0x1854C31A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NDDIGIFKAJC : IEquatable<NDDIGIFKAJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int PIOCNHLFCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int LMJBLNOIBOL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CDOMHMKBDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309E950", VA = "0x1830A0350")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x30A0340", Offset = "0x309E940", VA = "0x1830A0340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int OPIAKOPOKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int KBLDJAMLPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x84FB310", Offset = "0x84F9910", VA = "0x1884FB310")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x84FB320", Offset = "0x84F9920", VA = "0x1884FB320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) PGGGCNJHJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x84FB220", Offset = "0x84F9820", VA = "0x1884FB220")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
	private NDDIGIFKAJC(int PIOCNHLFCNE, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2B67120", Offset = "0x2B65720", VA = "0x182B67120")]
	public static NDDIGIFKAJC FPKKBIBCMMC(int PIOCNHLFCNE, int LMJBLNOIBOL)
	{
		return default(NDDIGIFKAJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x84FB330", Offset = "0x84F9930", VA = "0x1884FB330")]
	public static NDDIGIFKAJC MMHJPGBAGFN(int GHOFJOJMCOI, int PAHJFGCGJNK)
	{
		return default(NDDIGIFKAJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x84FB340", Offset = "0x84F9940", VA = "0x1884FB340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1434A70", Offset = "0x1433070", VA = "0x181434A70", Slot = "4")]
	public bool Equals(NDDIGIFKAJC AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x84FB280", Offset = "0x84F9880", VA = "0x1884FB280", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x77B2390", Offset = "0x77B0990", VA = "0x1877B2390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct HFKKFEABCOM<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> CDDIADBJAOB;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public HFKKFEABCOM(NativeArray<T> CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5160E10", Offset = "0x515F410", VA = "0x185160E10", Slot = "6")]
	public int Compare(int GBNAKFLHCOE, int ODEKEFJCIIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5160F00", Offset = "0x515F500", VA = "0x185160F00", Slot = "4")]
	public bool Equals(int GBNAKFLHCOE, int ODEKEFJCIIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5160FF0", Offset = "0x515F5F0", VA = "0x185160FF0", Slot = "5")]
	public int GetHashCode(int GBNAKFLHCOE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class KOMOPHEKBPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2DD0", Offset = "0x3EB13D0", VA = "0x183EB2DD0")]
	public static T[] CEGCGCPLNDC<T>(List<T> BBBJHCKNPGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct POHDAGHMAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* IPPLPDGABCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle EFCOKAOAKDN;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6171520", Offset = "0x616FB20", VA = "0x186171520")]
	public void ELCJDKMDHCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class KNBENJPOJEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0420", Offset = "0x3EAEA20", VA = "0x183EB0420")]
	public static POHDAGHMAFI IAAINCONNPF<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> PLDHKFPNKBN) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(POHDAGHMAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0420", Offset = "0x3EAEA20", VA = "0x183EB0420")]
	public static UnsafeParallelHashMap<TKey, TValue> OMJKFFGBFBG<TKey, TValue>(this POHDAGHMAFI PLDHKFPNKBN) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class PAGDOGOIKOI
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3F89600", Offset = "0x3F87C00", VA = "0x183F89600")]
	public static int DMBICIOICCO<T>(ReadOnlySpan<T> EJOAGHBOKJA, ReadOnlySpan<T> LCHNJGIPOHE, int NODGHDHCBPE) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IGFJOIKIOEG
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3E139E0", Offset = "0x3E11FE0", VA = "0x183E139E0")]
	public static T LOKAKHLJJDB<T>(this NativeArray<byte> PPEFJKBNOEP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3E135F0", Offset = "0x3E11BF0", VA = "0x183E135F0")]
	public static NativeArray<T> FBMDDAJADBJ<T>(this NativeArray<byte> PPEFJKBNOEP, int LMJBLNOIBOL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3E13A70", Offset = "0x3E12070", VA = "0x183E13A70")]
	public static void OMIKOFLNMMP<T>(this NativeList<byte> DNPKCGAKHLK, [In] T KOPHBHGIACG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3E13B00", Offset = "0x3E12100", VA = "0x183E13B00")]
	public static void OMIKOFLNMMP<T>(this NativeList<byte> DNPKCGAKHLK, NativeArray<T> KOPHBHGIACG) where T : struct
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

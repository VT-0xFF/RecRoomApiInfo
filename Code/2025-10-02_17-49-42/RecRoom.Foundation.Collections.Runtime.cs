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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84F05B0", Offset = "0x84EEFB0", VA = "0x1884F05B0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[IAHBKBKDOEJ]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F13C10", Offset = "0x3F12610", VA = "0x183F13C10")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[IAHBKBKDOEJ]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F14EE0", Offset = "0x3F138E0", VA = "0x183F14EE0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F13E10", Offset = "0x3F12810", VA = "0x183F13E10")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F14020", Offset = "0x3F12A20", VA = "0x183F14020")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DD40", Offset = "0x3F1C740", VA = "0x183F1DD40")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DBE0", Offset = "0x3F1C5E0", VA = "0x183F1DBE0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E3F0", Offset = "0x3F1CDF0", VA = "0x183F1E3F0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E4F0", Offset = "0x3F1CEF0", VA = "0x183F1E4F0")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3F15580", Offset = "0x3F13F80", VA = "0x183F15580")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3F15510", Offset = "0x3F13F10", VA = "0x183F15510")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F15A30", Offset = "0x3F14430", VA = "0x183F15A30")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, JDHBPJJENDI range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F15A70", Offset = "0x3F14470", VA = "0x183F15A70")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3F158B0", Offset = "0x3F142B0", VA = "0x183F158B0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F13C60", Offset = "0x3F12660", VA = "0x183F13C60")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DC80", Offset = "0x3F1C680", VA = "0x183F1DC80")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[IAHBKBKDOEJ]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AD10", Offset = "0x3F29710", VA = "0x183F2AD10")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BC40", Offset = "0x3F2A640", VA = "0x183F2BC40")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BBF0", Offset = "0x3F2A5F0", VA = "0x183F2BBF0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x55557A0", Offset = "0x55541A0", VA = "0x1855557A0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84F0CD0", Offset = "0x84EF6D0", VA = "0x1884F0CD0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84F0D00", Offset = "0x84EF700", VA = "0x1884F0D00")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B020", Offset = "0x3F29A20", VA = "0x183F2B020")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AFD0", Offset = "0x3F299D0", VA = "0x183F2AFD0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B0B0", Offset = "0x3F29AB0", VA = "0x183F2B0B0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B310", Offset = "0x3F29D10", VA = "0x183F2B310")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B360", Offset = "0x3F29D60", VA = "0x183F2B360")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B270", Offset = "0x3F29C70", VA = "0x183F2B270")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B5D0", Offset = "0x3F29FD0", VA = "0x183F2B5D0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B460", Offset = "0x3F29E60", VA = "0x183F2B460")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B1F0", Offset = "0x3F29BF0", VA = "0x183F2B1F0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AF70", Offset = "0x3F29970", VA = "0x183F2AF70")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AF50", Offset = "0x3F29950", VA = "0x183F2AF50")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C020", Offset = "0x3F2AA20", VA = "0x183F2C020")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BC50", Offset = "0x3F2A650", VA = "0x183F2BC50")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C050", Offset = "0x3F2AA50", VA = "0x183F2C050")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C100", Offset = "0x3F2AB00", VA = "0x183F2C100")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[IAHBKBKDOEJ]
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
			[Cpp2IlInjected.Address(RVA = "0x5185DB0", Offset = "0x51847B0", VA = "0x185185DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF91E00", Offset = "0xF90800", VA = "0x180F91E00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x56EEC50", Offset = "0x56ED650", VA = "0x1856EEC50")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5A89400", Offset = "0x5A87E00", VA = "0x185A89400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5A89240", Offset = "0x5A87C40", VA = "0x185A89240")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x45401F0", Offset = "0x453EBF0", VA = "0x1845401F0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[IAHBKBKDOEJ]
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
			[Cpp2IlInjected.Address(RVA = "0x5185DB0", Offset = "0x51847B0", VA = "0x185185DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5AEE700", Offset = "0x5AED100", VA = "0x185AEE700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x56EEC50", Offset = "0x56ED650", VA = "0x1856EEC50")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE290", Offset = "0x5AECC90", VA = "0x185AEE290")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE440", Offset = "0x5AECE40", VA = "0x185AEE440")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE620", Offset = "0x5AED020", VA = "0x185AEE620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE480", Offset = "0x5AECE80", VA = "0x185AEE480")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[IAHBKBKDOEJ]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[IAHBKBKDOEJ]
public static class MLLPBGLMIHO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84F0AB0", Offset = "0x84EF4B0", VA = "0x1884F0AB0")]
	public static JobHandle LHJLJOKNHMC(this JobHandle EICJFDNFOCB, JobHandle MIBIEOGGIAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84F0A00", Offset = "0x84EF400", VA = "0x1884F0A00")]
	public static JobHandle BHJHADPNFKI(this Span<JobHandle> AEBBDAOLLLI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AEGJLANHDOH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x32D4410", Offset = "0x32D2E10", VA = "0x1832D4410")]
	public static void EMMOLKMNHIK<T>(this T[] BHEONMJLANC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BEMPLIPPJJO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B28720", Offset = "0x3B27120", VA = "0x183B28720")]
	public static NativeKeyValueArrays<TKey, TValue> PIMMDIHFNBD<TKey, TValue>(this Dictionary<TKey, TValue> DDMHDBLMGFA, Allocator EIOOMONCLID) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NHICEODFHHK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84F0AF0", Offset = "0x84EF4F0", VA = "0x1884F0AF0")]
	public static void EMJNINPHCLL(this GameObject FNCBMCHNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84F0C30", Offset = "0x84EF630", VA = "0x1884F0C30")]
	public static void EMJNINPHCLL(this Component ADKKEOFFDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84F0B90", Offset = "0x84EF590", VA = "0x1884F0B90")]
	public static void EMJNINPHCLL(this ScriptableObject LMCIJMLAMNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DEEANLKPDAP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84EF1D0", Offset = "0x84EDBD0", VA = "0x1884EF1D0")]
	public static void KNKHDDEKIFO(this NativeList<byte> GBEHGKLEJFE, ReadOnlySpan<byte> FIHCKPHHMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF490", Offset = "0x3BCDE90", VA = "0x183BCF490")]
	public static void HKCHBKBCEMG<T>(this NativeList<T> GBEHGKLEJFE, T KMAFNKGMDCF, int MHMCOJIKNCI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HMLIPLONOHE
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DD94A0", Offset = "0x3DD7EA0", VA = "0x183DD94A0")]
	public static T MLOHGMBLHNL<T>(this ReadOnlySpan<byte> KMAFNKGMDCF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9380", Offset = "0x3DD7D80", VA = "0x183DD9380")]
	public static T MAKECBHGMDB<T>(this Span<T> FIHCKPHHMLP, Func<T, bool> DLNEOLEEFAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DD89D0", Offset = "0x3DD73D0", VA = "0x183DD89D0")]
	public static bool CGKCNALJMGO<T>(this Span<T> FIHCKPHHMLP, Func<T, bool> DLNEOLEEFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DD96E0", Offset = "0x3DD80E0", VA = "0x183DD96E0")]
	public static bool PDALKDGOBEE<T>(this Span<T> FIHCKPHHMLP, Func<T, bool> DLNEOLEEFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8F20", Offset = "0x3DD7920", VA = "0x183DD8F20")]
	public static T GFFPJLNAMHB<T>([In] this ReadOnlySpan<byte> FIHCKPHHMLP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8A60", Offset = "0x3DD7460", VA = "0x183DD8A60")]
	public static Span<TTo> FFADCICBEGC<TTo, TFrom>(this Span<TFrom> FIHCKPHHMLP) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8A60", Offset = "0x3DD7460", VA = "0x183DD8A60")]
	public static ReadOnlySpan<TTo> FFADCICBEGC<TTo, TFrom>(this ReadOnlySpan<TFrom> FIHCKPHHMLP) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8A60", Offset = "0x3DD7460", VA = "0x183DD8A60")]
	public static ReadOnlySpan<TTo> FFADCICBEGC<TTo>(this ReadOnlySpan<byte> FIHCKPHHMLP) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD88E0", Offset = "0x3DD72E0", VA = "0x183DD88E0")]
	public static Span<T> AFCIIKKNNFA<T>(this ReadOnlySpan<T> KGCMICBGABJ) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8AA0", Offset = "0x3DD74A0", VA = "0x183DD8AA0")]
	public static Span<byte> FNAEMEPGHFK<T>([In] this Span<byte> FIHCKPHHMLP, T KMAFNKGMDCF) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84EF2A0", Offset = "0x84EDCA0", VA = "0x1884EF2A0")]
	private static Enum BAPGHBDLIKO([In] ReadOnlySpan<byte> FIHCKPHHMLP, Type LIPDCJPBGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84EF840", Offset = "0x84EE240", VA = "0x1884EF840")]
	public static Enum LMDIIJBNPKC([In] this Span<byte> FIHCKPHHMLP, Type LIPDCJPBGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84EF8B0", Offset = "0x84EE2B0", VA = "0x1884EF8B0")]
	public static void OPAPLEMPLLI([In] this Span<byte> FIHCKPHHMLP, Enum OGMIMHJKKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MFHLNNHPEMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IEPDAHNKBAE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x84EFD90", Offset = "0x84EE790", VA = "0x1884EFD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84F0640", Offset = "0x84EF040", VA = "0x1884F0640")]
	[AsyncStateMachine(typeof(IEPDAHNKBAE))]
	public static void KNOMDJDOFEK(this Task GGMLEPFJHKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GNIMGBKFPIF
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9F50", Offset = "0x3DB8950", VA = "0x183DB9F50")]
	public static NativeArray<T> FBDJEGCAHCC<T>(this UnsafeList<T> GBEHGKLEJFE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9EE0", Offset = "0x3DB88E0", VA = "0x183DB9EE0")]
	public static NativeArray<T> ANLILBMFNIP<T>(this UnsafeList<T> GBEHGKLEJFE, bool KPANGEBBCJL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9E30", Offset = "0x3DB8830", VA = "0x183DB9E30")]
	public static UnsafeList<T> AFCIIKKNNFA<T>(this UnsafeList<T> GBEHGKLEJFE, Allocator EIOOMONCLID) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JEPONHBEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum BPILEJMFDNK : short
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
	public struct BHFOEPMCFHC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly BPILEJMFDNK HPFHOBCPNEF;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3278110", Offset = "0x3276B10", VA = "0x183278110")]
		public BHFOEPMCFHC(BPILEJMFDNK HPFHOBCPNEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory NOJNONODDMI;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	public static void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84F0540", Offset = "0x84EEF40", VA = "0x1884F0540")]
	static JEPONHBEKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A32FB0", Offset = "0x3A319B0", VA = "0x183A32FB0")]
	public static BHFOEPMCFHC CBKOGNLGOMG(BPILEJMFDNK HPFHOBCPNEF)
	{
		return default(BHFOEPMCFHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	public static void FEOJGAPBEJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CGAHAEIBEID
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CCD0", Offset = "0x2D9B6D0", VA = "0x182D9CCD0")]
	public static KMBHCJCIJDB<T1, T2> GNHJEMKPHCP<T1, T2>(this (T1, T2) GBHGHMJMBIL) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(KMBHCJCIJDB<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3B8AE70", Offset = "0x3B89870", VA = "0x183B8AE70")]
	public static CEKHJCHNEOE<T1, T2, T3> GNHJEMKPHCP<T1, T2, T3>(this (T1, T2, T3) GBHGHMJMBIL) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(CEKHJCHNEOE<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KMBHCJCIJDB<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) GBHGHMJMBIL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C790", Offset = "0x2D9B190", VA = "0x182D9C790")]
	public KMBHCJCIJDB((T1, T2) GBHGHMJMBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x567B610", Offset = "0x567A010", VA = "0x18567B610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CEKHJCHNEOE<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) GBHGHMJMBIL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x567B840", Offset = "0x567A240", VA = "0x18567B840")]
	public CEKHJCHNEOE((T1, T2, T3) GBHGHMJMBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7F80", Offset = "0x6CD6980", VA = "0x186CD7F80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PJPAJIKLEEA
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84F13E0", Offset = "0x84EFDE0", VA = "0x1884F13E0")]
	public static Range OGFHMDEIIKD(this JDHBPJJENDI FBOHMIMNCKO)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class GGCGJGCEELJ
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct CFEPDLGPDBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int KEABKJMLOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int IEEBKKJDLGC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84EF0B0", Offset = "0x84EDAB0", VA = "0x1884EF0B0")]
		public CFEPDLGPDBA(int NPCHJIPLCII, int IEEBKKJDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84EF0A0", Offset = "0x84EDAA0", VA = "0x1884EF0A0")]
		public bool MDPBHDIHDFH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84EF250", Offset = "0x84EDC50", VA = "0x1884EF250")]
	public static CFEPDLGPDBA FIIFAFDLDFC(this Range FBOHMIMNCKO)
	{
		return default(CFEPDLGPDBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JPGDPAFIJNF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle NOJLBGFGHBD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FFKHAMNIECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x55557D0", Offset = "0x55541D0", VA = "0x1855557D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5555640", Offset = "0x5554040", VA = "0x185555640")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x55557E0", Offset = "0x55541E0", VA = "0x1855557E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5555CD0", Offset = "0x55546D0", VA = "0x185555CD0")]
	public JPGDPAFIJNF(T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55557A0", Offset = "0x55541A0", VA = "0x1855557A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class IHFJNMPAEIO<THandle, TValue> : IDisposable where THandle : struct, BJILBADDCFN where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> AEBBDAOLLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> FDOLNIMJMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> NIDPMIGMPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> PJENINLCAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int KNBJKLOCHEP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x52EC0A0", Offset = "0x52EAAA0", VA = "0x1852EC0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x52EC710", Offset = "0x52EB110", VA = "0x1852EC710")]
	public IHFJNMPAEIO(Action<TValue> PJENINLCAGP, [Optional] Func<TValue> NIDPMIGMPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52EBE20", Offset = "0x52EA820", VA = "0x1852EBE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x52EC0D0", Offset = "0x52EAAD0", VA = "0x1852EC0D0")]
	public THandle HMDNMGBNKIA(TValue KMAFNKGMDCF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x52EC620", Offset = "0x52EB020", VA = "0x1852EC620")]
	public bool PIIFCIMJIKL(THandle NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x52EC3D0", Offset = "0x52EADD0", VA = "0x1852EC3D0")]
	public bool NLKHMGDKJML(THandle NOJLBGFGHBD, [Out] TValue KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x52EC050", Offset = "0x52EAA50", VA = "0x1852EC050")]
	public TValue GFFPJLNAMHB(THandle NOJLBGFGHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x52EC150", Offset = "0x52EAB50", VA = "0x1852EC150")]
	public bool JBKJHIIAKGB(THandle NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x52EBD00", Offset = "0x52EA700", VA = "0x1852EBD00")]
	private THandle BNFDNBKGJEM(int KABGMIEBEFC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x52EBEA0", Offset = "0x52EA8A0", VA = "0x1852EBEA0")]
	private TValue ECELJOPBPCF(int KABGMIEBEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x52EBCC0", Offset = "0x52EA6C0", VA = "0x1852EBCC0")]
	private void BKLLFEHNGGL(int KABGMIEBEFC, [In] THandle NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x52EC5E0", Offset = "0x52EAFE0", VA = "0x1852EC5E0")]
	private void PHABBDPNAFH(int KABGMIEBEFC, [In] TValue KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x52EBEF0", Offset = "0x52EA8F0", VA = "0x1852EBEF0")]
	private THandle FLIAIJJPODC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x52EBD50", Offset = "0x52EA750", VA = "0x1852EBD50")]
	private void CFEGJPDMBNM(THandle NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x52EC040", Offset = "0x52EAA40", VA = "0x1852EC040")]
	private int GBKKGMCFDKO(int PKNNCMNKNHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x52EBCB0", Offset = "0x52EA6B0", VA = "0x1852EBCB0")]
	private bool ALIOPPMOECG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
	private void DCPOJLJFMIK(THandle NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x52EC250", Offset = "0x52EAC50", VA = "0x1852EC250")]
	private bool KMOHPKAJGLF([Out] THandle NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x52EC2F0", Offset = "0x52EACF0", VA = "0x1852EC2F0")]
	private bool LIHIFMDBLIN([Out] THandle NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x52EC480", Offset = "0x52EAE80", VA = "0x1852EC480")]
	private void PAGANCJJCMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BJILBADDCFN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int OKKDIMNKADE
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
public static class PFMNPFDILCN
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3F67EF0", Offset = "0x3F668F0", VA = "0x183F67EF0")]
	public static bool KPJCJLIEMAG<T>(this T NOJLBGFGHBD, T GOCNHGEHNFD) where T : struct, BJILBADDCFN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F67F10", Offset = "0x3F66910", VA = "0x183F67F10")]
	public static bool OEBGFPNJFBL<T>(this T NOJLBGFGHBD) where T : struct, BJILBADDCFN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84F12D0", Offset = "0x84EFCD0", VA = "0x1884F12D0")]
	public static string FBDDGGHHLDL(this BJILBADDCFN NOJLBGFGHBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct CFIMNPCFKGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type LHIAIDEBCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> IDPMFLKFPGL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x56EE9E0", Offset = "0x56ED3E0", VA = "0x1856EE9E0")]
	public CFIMNPCFKGP(Type DKALAHNFPJK, Span<byte> FIHCKPHHMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B88CA0", Offset = "0x3B876A0", VA = "0x183B88CA0")]
	public static CFIMNPCFKGP DIHLONADDEL<T>(T KMAFNKGMDCF) where T : struct
	{
		return default(CFIMNPCFKGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x84EF0C0", Offset = "0x84EDAC0", VA = "0x1884EF0C0")]
	public static OCOCKGMMAFM HDPJNBPLGPE([In] CFIMNPCFKGP OLMEHKPIJHD)
	{
		return default(OCOCKGMMAFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x84EF140", Offset = "0x84EDB40", VA = "0x1884EF140")]
	public Enum LMDIIJBNPKC(Type LIPDCJPBGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3B895A0", Offset = "0x3B87FA0", VA = "0x183B895A0")]
	public void FNAEMEPGHFK<T>([In] T KMAFNKGMDCF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x84EF1C0", Offset = "0x84EDBC0", VA = "0x1884EF1C0")]
	public void OPAPLEMPLLI(Enum OGMIMHJKKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct OCOCKGMMAFM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct JPIAFEBAECO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* FNOCLJOJOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* KIEBAHDGBCK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type LHIAIDEBCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> IDPMFLKFPGL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AAFEBIALOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84F0D80", Offset = "0x84EF780", VA = "0x1884F0D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KCLELDILMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84F0D30", Offset = "0x84EF730", VA = "0x1884F0D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x56EE9E0", Offset = "0x56ED3E0", VA = "0x1856EE9E0")]
	public OCOCKGMMAFM(Type DKALAHNFPJK, ReadOnlySpan<byte> FIHCKPHHMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F45330", Offset = "0x3F43D30", VA = "0x183F45330")]
	public static OCOCKGMMAFM DIHLONADDEL<T>(T KMAFNKGMDCF) where T : struct
	{
		return default(OCOCKGMMAFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x84F0F60", Offset = "0x84EF960", VA = "0x1884F0F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x84F0D90", Offset = "0x84EF790", VA = "0x1884F0D90")]
	public object HEFLOAMOCMO(int KABGMIEBEFC = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct OLNJEEOFECD
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F56820", Offset = "0x3F55220", VA = "0x183F56820")]
	public static NativeArray<T> DIHLONADDEL<T>(T KMAFNKGMDCF, bool KPANGEBBCJL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F56860", Offset = "0x3F55260", VA = "0x183F56860")]
	public static NativeArray<T> FEKPGHJKPNA<T>(T KMAFNKGMDCF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3F56890", Offset = "0x3F55290", VA = "0x183F56890")]
	public static NativeArray<T> PFGJEMHPLEI<T>(T KMAFNKGMDCF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x84F1210", Offset = "0x84EFC10", VA = "0x1884F1210")]
	public static NativeArray<byte> PFGJEMHPLEI(ReadOnlySpan<byte> KMAFNKGMDCF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x84F1160", Offset = "0x84EFB60", VA = "0x1884F1160")]
	public static NativeArray<byte> DIHLONADDEL(ReadOnlySpan<byte> KMAFNKGMDCF, bool KPANGEBBCJL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x84F10E0", Offset = "0x84EFAE0", VA = "0x1884F10E0")]
	public unsafe static NativeArray<byte> DIHLONADDEL(byte* NLEDNJIMIPJ, int AJDEGEPLAEO, bool KPANGEBBCJL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3F567B0", Offset = "0x3F551B0", VA = "0x183F567B0")]
	public static NativeArray<T> BENGIKOEPPE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MKNGDGFPGGL : IEquatable<MKNGDGFPGGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int OEIMJBPIFAB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84F0870", Offset = "0x84EF270", VA = "0x1884F0870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84F0960", Offset = "0x84EF360", VA = "0x1884F0960")]
	public MKNGDGFPGGL(Type DGNODDPLLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84F07E0", Offset = "0x84EF1E0", VA = "0x1884F07E0")]
	public static MKNGDGFPGGL HDPJNBPLGPE(Type DGNODDPLLPC)
	{
		return default(MKNGDGFPGGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x252D260", Offset = "0x252BC60", VA = "0x18252D260", Slot = "4")]
	public bool Equals(MKNGDGFPGGL GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x84F0760", Offset = "0x84EF160", VA = "0x1884F0760", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x84F0920", Offset = "0x84EF320", VA = "0x1884F0920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IHLNPDKPKAO
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> GMBBFLGJEHJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> BBBLCBOPBMB;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84F0200", Offset = "0x84EEC00", VA = "0x1884F0200")]
	static IHLNPDKPKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x84EFF90", Offset = "0x84EE990", VA = "0x1884EFF90")]
	public static bool HMDNMGBNKIA(Type DGNODDPLLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x84EFFF0", Offset = "0x84EE9F0", VA = "0x1884EFFF0")]
	private static bool HMDNMGBNKIA(Type DGNODDPLLPC, [Out] int KABGMIEBEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x84F01A0", Offset = "0x84EEBA0", VA = "0x1884F01A0")]
	public static int IPJDHKGAIHO(Type DGNODDPLLPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84EFF10", Offset = "0x84EE910", VA = "0x1884EFF10")]
	public static Type GFFPJLNAMHB(int KABGMIEBEFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct EILLFGMMOMM<Handle> where Handle : BJILBADDCFN, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct CKPDNBLMGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly EILLFGMMOMM<Handle> DDFKDPINPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int KABGMIEBEFC;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle ALPHEBBFKBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6CEBB90", Offset = "0x6CEA590", VA = "0x186CEBB90")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6CEC1F0", Offset = "0x6CEABF0", VA = "0x186CEC1F0")]
		public CKPDNBLMGMO(EILLFGMMOMM<Handle> DDFKDPINPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6CEBE70", Offset = "0x6CEA870", VA = "0x186CEBE70")]
		public GDNDNHKDFAH KDBDJPAJKDJ([In] GDNDNHKDFAH HBELCFIJGKE)
		{
			return default(GDNDNHKDFAH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6CEC020", Offset = "0x6CEAA20", VA = "0x186CEC020")]
		public bool MDPBHDIHDFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6CEC130", Offset = "0x6CEAB30", VA = "0x186CEC130")]
		private Handle NOAGNMLELLO(string JEBOHIALEMJ)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct GDNDNHKDFAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CKPDNBLMGMO LLEGHONDNPP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x51241A0", Offset = "0x5122BA0", VA = "0x1851241A0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5124320", Offset = "0x5122D20", VA = "0x185124320")]
		public GDNDNHKDFAH(EILLFGMMOMM<Handle> DDFKDPINPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x51242A0", Offset = "0x5122CA0", VA = "0x1851242A0")]
		public bool MDPBHDIHDFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5124220", Offset = "0x5122C20", VA = "0x185124220")]
		public GDNDNHKDFAH FIIFAFDLDFC()
		{
			return default(GDNDNHKDFAH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> FJCKPJDAGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> HCNMABIMEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int EBGPEIOIHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int JALFPONHJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool AOMECDEFPPJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EJPLDFLIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C040", Offset = "0x4B1AA40", VA = "0x184B1C040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GDNDNHKDFAH NJGGHGGBNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4B1BAD0", Offset = "0x4B1A4D0", VA = "0x184B1BAD0")]
		get
		{
			return default(GDNDNHKDFAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D210", Offset = "0x4B1BC10", VA = "0x184B1D210")]
	public EILLFGMMOMM(int AHBOODEOAJF, Allocator EIOOMONCLID = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D080", Offset = "0x4B1BA80", VA = "0x184B1D080")]
	public void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2598AC0", Offset = "0x25974C0", VA = "0x182598AC0")]
	public static int GBKKGMCFDKO(int FEBGNHCBECK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x328E1E0", Offset = "0x328CBE0", VA = "0x18328E1E0")]
	public static bool DBOGHNNFIML(int FEBGNHCBECK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BDC0", Offset = "0x4B1A7C0", VA = "0x184B1BDC0")]
	public bool FPJJCPLFKOA(int KABGMIEBEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C080", Offset = "0x4B1AA80", VA = "0x184B1C080")]
	public bool JKMEKIEJJII(Handle NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B930", Offset = "0x4B1A330", VA = "0x184B1B930")]
	public Handle BOKMHCNEBGA()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C400", Offset = "0x4B1AE00", VA = "0x184B1C400")]
	public void KCPEPGNMPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B850", Offset = "0x4B1A250", VA = "0x184B1B850")]
	public void BLAOAJJFHAF(Handle NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960")]
	private bool HMONCHHGEJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BB70", Offset = "0x4B1A570", VA = "0x184B1BB70")]
	private bool EFELBHIFIGJ(int KABGMIEBEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4B1CCE0", Offset = "0x4B1B6E0", VA = "0x184B1CCE0")]
	private void OFCAJIGPHMG([Out] int KABGMIEBEFC, [Out] int PKNNCMNKNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4B1CBA0", Offset = "0x4B1B5A0", VA = "0x184B1CBA0")]
	private void KELFGGOADAE(Handle NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C3B0", Offset = "0x4B1ADB0", VA = "0x184B1C3B0")]
	private void JLOKGEIOBGL(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B6F0", Offset = "0x4B1A0F0", VA = "0x184B1B6F0")]
	private bool BKMEMDINBLP([Out] int KABGMIEBEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BC30", Offset = "0x4B1A630", VA = "0x184B1BC30")]
	private static Handle FMNFONHDENO(int KABGMIEBEFC, int PKNNCMNKNHL)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct JPIODALEDMD<Handle, T> where Handle : BJILBADDCFN, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private EILLFGMMOMM<Handle> NBLLHDPGGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] DNPJIJJOMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> BNIBENIEOLE;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5556C20", Offset = "0x5555620", VA = "0x185556C20")]
	public JPIODALEDMD(int AHBOODEOAJF, [Optional] Action<T> BNIBENIEOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5556B90", Offset = "0x5555590", VA = "0x185556B90")]
	public void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5556980", Offset = "0x5555380", VA = "0x185556980")]
	public bool NLKHMGDKJML(Handle NOJLBGFGHBD, [Out] T PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55564F0", Offset = "0x5554EF0", VA = "0x1855564F0")]
	public Handle HMDNMGBNKIA(T PMNHIPACJLN)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5556180", Offset = "0x5554B80", VA = "0x185556180")]
	public void HKBGBDCPOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5556600", Offset = "0x5555000", VA = "0x185556600")]
	public void MCKODPOBNPM(Handle NOJLBGFGHBD, [Out] T IONOAPHPCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55567E0", Offset = "0x55551E0", VA = "0x1855567E0")]
	public void MCKODPOBNPM(Handle NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5555E30", Offset = "0x5554830", VA = "0x185555E30")]
	private T AEOLGKCAPHA(int KABGMIEBEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5555E90", Offset = "0x5554890", VA = "0x185555E90")]
	private void DHICIEGNKDO(int IBIIBDDMDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct OCCFPJFFJEE<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct LAMCHAIEJJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private OCCFPJFFJEE<T> BHEONMJLANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int KABGMIEBEFC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x56FEE50", Offset = "0x56FD850", VA = "0x1856FEE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B83AE0", Offset = "0x2B824E0", VA = "0x182B83AE0")]
		public LAMCHAIEJJN(OCCFPJFFJEE<T> BHEONMJLANC, int KABGMIEBEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x56FEEA0", Offset = "0x56FD8A0", VA = "0x1856FEEA0")]
		public bool MDPBHDIHDFH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KJDINGFMPFJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public OCCFPJFFJEE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public KJDINGFMPFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5673EE0", Offset = "0x56728E0", VA = "0x185673EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5673F80", Offset = "0x5672980", VA = "0x185673F80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AJNJMFNFPMA : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public OCCFPJFFJEE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public AJNJMFNFPMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x54091D0", Offset = "0x5407BD0", VA = "0x1854091D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5409270", Offset = "0x5407C70", VA = "0x185409270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] BLPDDGCLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint KMAFNKGMDCF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A9F0", Offset = "0x5B993F0", VA = "0x185B9A9F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DGOCJDKBCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A590", Offset = "0x5B98F90", VA = "0x185B9A590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PNGIKAIMAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1A9B5F0", Offset = "0x1A99FF0", VA = "0x181A9B5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool AHPKKLPBCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A400", Offset = "0x5B98E00", VA = "0x185B9A400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EBMGJMEEKJB<T> IDPMFLKFPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A410", Offset = "0x5B98E10", VA = "0x185B9A410")]
		get
		{
			return default(EBMGJMEEKJB<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A810", Offset = "0x5B99210", VA = "0x185B9A810")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5B9AC90", Offset = "0x5B99690", VA = "0x185B9AC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5B9B2D0", Offset = "0x5B99CD0", VA = "0x185B9B2D0")]
	internal OCCFPJFFJEE(OCCFPJFFJEE<T> BHEONMJLANC, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5B9AF20", Offset = "0x5B99920", VA = "0x185B9AF20")]
	private OCCFPJFFJEE(T[] BHEONMJLANC, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5B9AFB0", Offset = "0x5B999B0", VA = "0x185B9AFB0")]
	public OCCFPJFFJEE(IEnumerable<T> FDOLNIMJMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5B9AF40", Offset = "0x5B99940", VA = "0x185B9AF40")]
	public OCCFPJFFJEE(int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A620", Offset = "0x5B99020", VA = "0x185B9A620")]
	public int DBABOODDEOL(T KMAFNKGMDCF, int NPCHJIPLCII, int MHMCOJIKNCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5B9AC40", Offset = "0x5B99640", VA = "0x185B9AC40")]
	public void MNOELMBDGLJ(int IDCHDNLNDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B9AA70", Offset = "0x5B99470", VA = "0x185B9AA70")]
	private void MCIEFIFOONL(int IDCHDNLNDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A970", Offset = "0x5B99370", VA = "0x185B9A970")]
	public T[] IOHHHCHEDKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A2B0", Offset = "0x5B98CB0", VA = "0x185B9A2B0")]
	public T[] ABAGCAMAMIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A720", Offset = "0x5B99120", VA = "0x185B9A720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B9AA00", Offset = "0x5B99400", VA = "0x185B9AA00")]
	public void KMLKKFAFFMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A7A0", Offset = "0x5B991A0", VA = "0x185B9A7A0")]
	public LAMCHAIEJJN FIIFAFDLDFC()
	{
		return default(LAMCHAIEJJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B9AD40", Offset = "0x5B99740", VA = "0x185B9AD40", Slot = "5")]
	[IteratorStateMachine(typeof(OCCFPJFFJEE<>.KJDINGFMPFJ))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5B9AE30", Offset = "0x5B99830", VA = "0x185B9AE30", Slot = "6")]
	[IteratorStateMachine(typeof(OCCFPJFFJEE<>.AJNJMFNFPMA))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A5C0", Offset = "0x5B98FC0", VA = "0x185B9A5C0")]
	public static OCCFPJFFJEE<T> CLHNKKPNMDG(T[] BHEONMJLANC)
	{
		return default(OCCFPJFFJEE<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A8E0", Offset = "0x5B992E0", VA = "0x185B9A8E0")]
	public static OCCFPJFFJEE<T> HDPJNBPLGPE(T[] BHEONMJLANC)
	{
		return default(OCCFPJFFJEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5B9A6A0", Offset = "0x5B990A0", VA = "0x185B9A6A0")]
	private void DBHBNJFPCMA(int KABGMIEBEFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PDCODDNLDMO
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F64160", Offset = "0x3F62B60", VA = "0x183F64160")]
	public static OCCFPJFFJEE<T> EOGJJPPBIFI<T>(this IEnumerable<T> LGAPDHILJMI) where T : class
	{
		return default(OCCFPJFFJEE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class FMJHIDPKFMF<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct NDIIABFKNHG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FMJHIDPKFMF<T> GBEHGKLEJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int KABGMIEBEFC;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5A48C20", Offset = "0x5A47620", VA = "0x185A48C20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5A48C60", Offset = "0x5A47660", VA = "0x185A48C60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4BC87C0", Offset = "0x4BC71C0", VA = "0x184BC87C0")]
		public NDIIABFKNHG(FMJHIDPKFMF<T> GBEHGKLEJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5A48B40", Offset = "0x5A47540", VA = "0x185A48B40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5A48BD0", Offset = "0x5A475D0", VA = "0x185A48BD0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private OCCFPJFFJEE<T> BLPDDGCLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int AJDEGEPLAEO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x500F260", Offset = "0x500DC60", VA = "0x18500F260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x500E280", Offset = "0x500CC80", VA = "0x18500E280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C21790", Offset = "0x4C20190", VA = "0x184C21790", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EJPLDFLIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x500E7B0", Offset = "0x500D1B0", VA = "0x18500E7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PNGIKAIMAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x500E2C0", Offset = "0x500CCC0", VA = "0x18500E2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public EBMGJMEEKJB<T> IDPMFLKFPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x500E0B0", Offset = "0x500CAB0", VA = "0x18500E0B0")]
		get
		{
			return default(EBMGJMEEKJB<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x500F1D0", Offset = "0x500DBD0", VA = "0x18500F1D0")]
	public FMJHIDPKFMF(IEnumerable<T> FDOLNIMJMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x500F160", Offset = "0x500DB60", VA = "0x18500F160")]
	public FMJHIDPKFMF(int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x500E2A0", Offset = "0x500CCA0", VA = "0x18500E2A0")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x500F070", Offset = "0x500DA70", VA = "0x18500F070")]
	public OCCFPJFFJEE<T> PDMGLKGLJCL()
	{
		return default(OCCFPJFFJEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x500E6B0", Offset = "0x500D0B0", VA = "0x18500E6B0")]
	public void HMDNMGBNKIA(T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x500EB90", Offset = "0x500D590", VA = "0x18500EB90")]
	private void MNOELMBDGLJ(int JHAGJEMJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x500E920", Offset = "0x500D320", VA = "0x18500E920")]
	public void KNKHDDEKIFO(List<T> ENCMPDIEHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x500EA90", Offset = "0x500D490", VA = "0x18500EA90")]
	public void KNKHDDEKIFO(T[] ENCMPDIEHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x500EB10", Offset = "0x500D510", VA = "0x18500EB10")]
	public bool MCKODPOBNPM(T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x500E140", Offset = "0x500CB40", VA = "0x18500E140")]
	public void CDDBADFAPIE(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x500EBD0", Offset = "0x500D5D0", VA = "0x18500EBD0")]
	public void NGGEGCPNDHF(int NNJFDKEMLBN, int IEEBKKJDLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x500E090", Offset = "0x500CA90", VA = "0x18500E090")]
	public void AEOLGKCAPHA(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x500E320", Offset = "0x500CD20", VA = "0x18500E320")]
	public void GOPIOACLPOM(int NNJFDKEMLBN, int IEEBKKJDLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x500E1D0", Offset = "0x500CBD0", VA = "0x18500E1D0")]
	public int DBABOODDEOL(T KMAFNKGMDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x500E2E0", Offset = "0x500CCE0", VA = "0x18500E2E0")]
	public bool GMMHHEEELIA(T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x500E020", Offset = "0x500CA20", VA = "0x18500E020")]
	public T[] ABAGCAMAMIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x500E250", Offset = "0x500CC50", VA = "0x18500E250", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x500E600", Offset = "0x500D000", VA = "0x18500E600")]
	public static OCCFPJFFJEE<T> HDPJNBPLGPE(FMJHIDPKFMF<T> GBEHGKLEJFE)
	{
		return default(OCCFPJFFJEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x500E580", Offset = "0x500CF80", VA = "0x18500E580", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x500F0C0", Offset = "0x500DAC0", VA = "0x18500F0C0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x500F0F0", Offset = "0x500DAF0", VA = "0x18500F0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x500E7D0", Offset = "0x500D1D0", VA = "0x18500E7D0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void IMGPFJBCLAH(int KMAFNKGMDCF, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x500EE40", Offset = "0x500D840", VA = "0x18500EE40")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PALFOPNEDMM(int NNJFDKEMLBN, int IEEBKKJDLGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JHHJMHBCPKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3E23E20", Offset = "0x3E22820", VA = "0x183E23E20")]
	public static void KMLKKFAFFMD<T>(this FMJHIDPKFMF<T> GBEHGKLEJFE) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct EBMGJMEEKJB<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> BLPDDGCLNPE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4AF60D0", Offset = "0x4AF4AD0", VA = "0x184AF60D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6250", Offset = "0x4AF4C50", VA = "0x184AF6250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4AF61B0", Offset = "0x4AF4BB0", VA = "0x184AF61B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1531090", Offset = "0x152FA90", VA = "0x181531090")]
	public EBMGJMEEKJB(Span<object> FIHCKPHHMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5FB0", Offset = "0x4AF49B0", VA = "0x184AF5FB0")]
	public EBMGJMEEKJB<T> DNHEKHEFDEL(int NPCHJIPLCII)
	{
		return default(EBMGJMEEKJB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5ED0", Offset = "0x4AF48D0", VA = "0x184AF5ED0")]
	public EBMGJMEEKJB<T> DNHEKHEFDEL(int NPCHJIPLCII, int AJDEGEPLAEO)
	{
		return default(EBMGJMEEKJB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4AF61F0", Offset = "0x4AF4BF0", VA = "0x184AF61F0")]
	public void KPNIEKPKGAM(EBMGJMEEKJB<T> HDGNJBEMIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6280", Offset = "0x4AF4C80", VA = "0x184AF6280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6080", Offset = "0x4AF4A80", VA = "0x184AF6080", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6160", Offset = "0x4AF4B60", VA = "0x184AF6160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct JDHBPJJENDI : IEquatable<JDHBPJJENDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int JBCPGNDLJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int MHMCOJIKNCI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MMNMLIHNLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x30A52A0", Offset = "0x30A3CA0", VA = "0x1830A52A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HFBLIKOCLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PKAPPLHNNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x84F0430", Offset = "0x84EEE30", VA = "0x1884F0430")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x84F0390", Offset = "0x84EED90", VA = "0x1884F0390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) IADMKCPMJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x84F0440", Offset = "0x84EEE40", VA = "0x1884F0440")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
	private JDHBPJJENDI(int JBCPGNDLJHB, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A900", Offset = "0x2B69300", VA = "0x182B6A900")]
	public static JDHBPJJENDI AELLOPHHOFE(int JBCPGNDLJHB, int MHMCOJIKNCI)
	{
		return default(JDHBPJJENDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x84F04A0", Offset = "0x84EEEA0", VA = "0x1884F04A0")]
	public static JDHBPJJENDI PMFAKCMMGOF(int NPCHJIPLCII, int IEEBKKJDLGC)
	{
		return default(JDHBPJJENDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x84F04B0", Offset = "0x84EEEB0", VA = "0x1884F04B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x143A040", Offset = "0x1438A40", VA = "0x18143A040", Slot = "4")]
	public bool Equals(JDHBPJJENDI GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x84F03A0", Offset = "0x84EEDA0", VA = "0x1884F03A0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7799080", Offset = "0x7797A80", VA = "0x187799080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct HPMGHHIBPFH<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> BLPDDGCLNPE;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1531090", Offset = "0x152FA90", VA = "0x181531090")]
	public HPMGHHIBPFH(NativeArray<T> BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5221E30", Offset = "0x5220830", VA = "0x185221E30", Slot = "6")]
	public int Compare(int FKPKEFAKAOE, int KEEMKILMOML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5221F20", Offset = "0x5220920", VA = "0x185221F20", Slot = "4")]
	public bool Equals(int FKPKEFAKAOE, int KEEMKILMOML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5222010", Offset = "0x5220A10", VA = "0x185222010", Slot = "5")]
	public int GetHashCode(int FKPKEFAKAOE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class HCICDGMGNDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1CA0", Offset = "0x3DC06A0", VA = "0x183DC1CA0")]
	public static T[] KIDJINKAJOL<T>(List<T> GBEHGKLEJFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NEPLOLJKCEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* JODAAPGGBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle MDJABDLHNCO;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6144BF0", Offset = "0x61435F0", VA = "0x186144BF0")]
	public void OKCDDGFOJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class CHMPLLOKOND
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B6C0", Offset = "0x3B8A0C0", VA = "0x183B8B6C0")]
	public static NEPLOLJKCEP DADLKGAILPE<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> HJAOHCJPEIK) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(NEPLOLJKCEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B6C0", Offset = "0x3B8A0C0", VA = "0x183B8B6C0")]
	public static UnsafeParallelHashMap<TKey, TValue> JLFLKDBALGP<TKey, TValue>(this NEPLOLJKCEP HJAOHCJPEIK) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DFNEAMDNIKG
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD06C0", Offset = "0x3BCF0C0", VA = "0x183BD06C0")]
	public static int IBLAINLHBBI<T>(ReadOnlySpan<T> OPFGGODCNHI, ReadOnlySpan<T> DFJAOALFDNM, int AJDEGEPLAEO) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GLFFILMIOKA
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7AD0", Offset = "0x3DB64D0", VA = "0x183DB7AD0")]
	public static T NDHDDMEPDIA<T>(this NativeArray<byte> KGCMICBGABJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB74B0", Offset = "0x3DB5EB0", VA = "0x183DB74B0")]
	public static NativeArray<T> KPPNBGAJDNH<T>(this NativeArray<byte> KGCMICBGABJ, int MHMCOJIKNCI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7930", Offset = "0x3DB6330", VA = "0x183DB7930")]
	public static void MGCEPLPNMLJ<T>(this NativeList<byte> MPGFNEFLINC, [In] T KMAFNKGMDCF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB78A0", Offset = "0x3DB62A0", VA = "0x183DB78A0")]
	public static void MGCEPLPNMLJ<T>(this NativeList<byte> MPGFNEFLINC, NativeArray<T> KMAFNKGMDCF) where T : struct
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

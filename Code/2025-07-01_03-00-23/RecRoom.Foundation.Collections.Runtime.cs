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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7210", Offset = "0x7FA5810", VA = "0x187FA7210", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[KGJGHIMCBLN]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4B60", Offset = "0x3CC3160", VA = "0x183CC4B60")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[KGJGHIMCBLN]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5DD0", Offset = "0x3CC43D0", VA = "0x183CC5DD0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4D60", Offset = "0x3CC3360", VA = "0x183CC4D60")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4F70", Offset = "0x3CC3570", VA = "0x183CC4F70")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9240", Offset = "0x3CC7840", VA = "0x183CC9240")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8FD0", Offset = "0x3CC75D0", VA = "0x183CC8FD0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9140", Offset = "0x3CC7740", VA = "0x183CC9140")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9890", Offset = "0x3CC7E90", VA = "0x183CC9890")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6400", Offset = "0x3CC4A00", VA = "0x183CC6400")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC64C0", Offset = "0x3CC4AC0", VA = "0x183CC64C0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6920", Offset = "0x3CC4F20", VA = "0x183CC6920")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, HABDMPMOHEE range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6960", Offset = "0x3CC4F60", VA = "0x183CC6960")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3CC67A0", Offset = "0x3CC4DA0", VA = "0x183CC67A0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4BB0", Offset = "0x3CC31B0", VA = "0x183CC4BB0")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9080", Offset = "0x3CC7680", VA = "0x183CC9080")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[KGJGHIMCBLN]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3CCECC0", Offset = "0x3CCD2C0", VA = "0x183CCECC0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3CD09A0", Offset = "0x3CCEFA0", VA = "0x183CD09A0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0950", Offset = "0x3CCEF50", VA = "0x183CD0950")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2630", Offset = "0x4DF0C30", VA = "0x184DF2630")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7FA77D0", Offset = "0x7FA5DD0", VA = "0x187FA77D0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7800", Offset = "0x7FA5E00", VA = "0x187FA7800")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0000", Offset = "0x3CCE600", VA = "0x183CD0000")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFE10", Offset = "0x3CCE410", VA = "0x183CCFE10")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD00D0", Offset = "0x3CCE6D0", VA = "0x183CD00D0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0080", Offset = "0x3CCE680", VA = "0x183CD0080")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0030", Offset = "0x3CCE630", VA = "0x183CD0030")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFF60", Offset = "0x3CCE560", VA = "0x183CCFF60")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0350", Offset = "0x3CCE950", VA = "0x183CD0350")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CD01B0", Offset = "0x3CCE7B0", VA = "0x183CD01B0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFD90", Offset = "0x3CCE390", VA = "0x183CCFD90")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFD30", Offset = "0x3CCE330", VA = "0x183CCFD30")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFD10", Offset = "0x3CCE310", VA = "0x183CCFD10")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0D80", Offset = "0x3CCF380", VA = "0x183CD0D80")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3CD09B0", Offset = "0x3CCEFB0", VA = "0x183CD09B0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0DB0", Offset = "0x3CCF3B0", VA = "0x183CD0DB0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0E60", Offset = "0x3CCF460", VA = "0x183CD0E60")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[KGJGHIMCBLN]
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
			[Cpp2IlInjected.Address(RVA = "0x4DCF3E0", Offset = "0x4DCD9E0", VA = "0x184DCF3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE79D00", Offset = "0xE78300", VA = "0x180E79D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5369660", Offset = "0x5367C60", VA = "0x185369660")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x56A8950", Offset = "0x56A6F50", VA = "0x1856A8950", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x56A8750", Offset = "0x56A6D50", VA = "0x1856A8750")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x42B3750", Offset = "0x42B1D50", VA = "0x1842B3750")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[KGJGHIMCBLN]
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
			[Cpp2IlInjected.Address(RVA = "0x4DCF3E0", Offset = "0x4DCD9E0", VA = "0x184DCF3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x570AC20", Offset = "0x5709220", VA = "0x18570AC20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5369660", Offset = "0x5367C60", VA = "0x185369660")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x570A7B0", Offset = "0x5708DB0", VA = "0x18570A7B0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x570A960", Offset = "0x5708F60", VA = "0x18570A960")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x570A9A0", Offset = "0x5708FA0", VA = "0x18570A9A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x570AA80", Offset = "0x5709080", VA = "0x18570AA80")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[KGJGHIMCBLN]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KGJGHIMCBLN]
public static class GDDMMHPCDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6090", Offset = "0x7FA4690", VA = "0x187FA6090")]
	public static JobHandle CEMHKECABDC(this JobHandle DLGEPLKGJOC, JobHandle OKKFDNDPGLP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA60D0", Offset = "0x7FA46D0", VA = "0x187FA60D0")]
	public static JobHandle GOOEGNMOCOE(this Span<JobHandle> HKOOIOCCCHM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PECEPAHHFAP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37BA060", Offset = "0x37B8660", VA = "0x1837BA060")]
	public static void HHCEOPNNHLH<T>(this T[] DDENONPPKCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ANGEHNJBCOI
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30BCC00", Offset = "0x30BB200", VA = "0x1830BCC00")]
	public static NativeKeyValueArrays<TKey, TValue> LFKLKDPIONE<TKey, TValue>(this Dictionary<TKey, TValue> JJAIEIEJJFM, Allocator HOHBLCPFIEJ) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ODPEJAPICNF
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA78D0", Offset = "0x7FA5ED0", VA = "0x187FA78D0")]
	public static void IOMJALBGPPI(this GameObject KGMBEOBCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7970", Offset = "0x7FA5F70", VA = "0x187FA7970")]
	public static void IOMJALBGPPI(this Component DNCHHBPCLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7830", Offset = "0x7FA5E30", VA = "0x187FA7830")]
	public static void IOMJALBGPPI(this ScriptableObject FNMJAPKCKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FAHPKBJKCFL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5EE0", Offset = "0x7FA44E0", VA = "0x187FA5EE0")]
	public static void HPNNPOFAAPK(this NativeList<byte> BGGFBGFNIID, ReadOnlySpan<byte> OIFLPGNAJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C940", Offset = "0x3B1AF40", VA = "0x183B1C940")]
	public static void IKHNHNKKJDM<T>(this NativeList<T> BGGFBGFNIID, T KKGBKLFKCPO, int FOAMCIPOLAA) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JBNAKKBOKHP
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B98FC0", Offset = "0x3B975C0", VA = "0x183B98FC0")]
	public static T NOHDCODCGKF<T>(this ReadOnlySpan<byte> KKGBKLFKCPO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B98A40", Offset = "0x3B97040", VA = "0x183B98A40")]
	public static T IJFIMCBDMFN<T>(this Span<T> OIFLPGNAJPE, Func<T, bool> NPBLKCDNLDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B98920", Offset = "0x3B96F20", VA = "0x183B98920")]
	public static bool GIEFAJFLDNF<T>(this Span<T> OIFLPGNAJPE, Func<T, bool> NPBLKCDNLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B989B0", Offset = "0x3B96FB0", VA = "0x183B989B0")]
	public static bool IIEKDMAGAFB<T>(this Span<T> OIFLPGNAJPE, Func<T, bool> NPBLKCDNLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B98B60", Offset = "0x3B97160", VA = "0x183B98B60")]
	public static T KBGIPADPFGF<T>([In] this ReadOnlySpan<byte> OIFLPGNAJPE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AFE0", Offset = "0x3B495E0", VA = "0x183B4AFE0")]
	public static Span<TTo> KFKLNOPFPGB<TTo, TFrom>(this Span<TFrom> OIFLPGNAJPE) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AFE0", Offset = "0x3B495E0", VA = "0x183B4AFE0")]
	public static ReadOnlySpan<TTo> KFKLNOPFPGB<TTo, TFrom>(this ReadOnlySpan<TFrom> OIFLPGNAJPE) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AFE0", Offset = "0x3B495E0", VA = "0x183B4AFE0")]
	public static ReadOnlySpan<TTo> KFKLNOPFPGB<TTo>(this ReadOnlySpan<byte> OIFLPGNAJPE) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B99200", Offset = "0x3B97800", VA = "0x183B99200")]
	public static Span<T> PLEBMHKEBJO<T>(this ReadOnlySpan<T> LFMKIINCPNH) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B984A0", Offset = "0x3B96AA0", VA = "0x183B984A0")]
	public static Span<byte> BNAKHNGOEHD<T>([In] this Span<byte> OIFLPGNAJPE, T KKGBKLFKCPO) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6710", Offset = "0x7FA4D10", VA = "0x187FA6710")]
	private static Enum FOEAHFIJABO([In] ReadOnlySpan<byte> OIFLPGNAJPE, Type PFLBLPBNFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA66A0", Offset = "0x7FA4CA0", VA = "0x187FA66A0")]
	public static Enum DBJGNPACABL([In] this Span<byte> OIFLPGNAJPE, Type PFLBLPBNFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6CC0", Offset = "0x7FA52C0", VA = "0x187FA6CC0")]
	public static void GFDMHHJABHF([In] this Span<byte> OIFLPGNAJPE, Enum DANMPOCKLCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NCJICGBLLHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GJEBFIPOOFF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7FA6180", Offset = "0x7FA4780", VA = "0x187FA6180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7650", Offset = "0x7FA5C50", VA = "0x187FA7650")]
	[AsyncStateMachine(typeof(GJEBFIPOOFF))]
	public static void MBPJLCINCDL(this Task MMMCFFENLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HFIDANKPEOL
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F870", Offset = "0x3B5DE70", VA = "0x183B5F870")]
	public static NativeArray<T> FHHDBAKPMKP<T>(this UnsafeList<T> BGGFBGFNIID) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F8C0", Offset = "0x3B5DEC0", VA = "0x183B5F8C0")]
	public static NativeArray<T> PCLFFDPALDM<T>(this UnsafeList<T> BGGFBGFNIID, bool CDOBNCPPFGA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F930", Offset = "0x3B5DF30", VA = "0x183B5F930")]
	public static UnsafeList<T> PLEBMHKEBJO<T>(this UnsafeList<T> BGGFBGFNIID, Allocator HOHBLCPFIEJ) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KJCHHLNODFC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum OCCOFBIKNFE : short
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
	public struct EOMLENENIOD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly OCCOFBIKNFE BLIBAMJKLIA;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3050230", Offset = "0x304E830", VA = "0x183050230")]
		public EOMLENENIOD(OCCOFBIKNFE BLIBAMJKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory BAIHHLMIMOE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	public static void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FA71A0", Offset = "0x7FA57A0", VA = "0x187FA71A0")]
	static KJCHHLNODFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37CEE40", Offset = "0x37CD440", VA = "0x1837CEE40")]
	public static EOMLENENIOD HGMOCHDABLC(OCCOFBIKNFE BLIBAMJKLIA)
	{
		return default(EOMLENENIOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	public static void CJHAGPFOIME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HCOEPOJMJJL
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FCA0", Offset = "0x2B8E2A0", VA = "0x182B8FCA0")]
	public static NFNOBEKJJOA<T1, T2> JPFELNJKJKI<T1, T2>(this (T1, T2) JGPHMOHCCLH) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(NFNOBEKJJOA<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D6C0", Offset = "0x3B5BCC0", VA = "0x183B5D6C0")]
	public static HKKLKOCFAJD<T1, T2, T3> JPFELNJKJKI<T1, T2, T3>(this (T1, T2, T3) JGPHMOHCCLH) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(HKKLKOCFAJD<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NFNOBEKJJOA<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) JGPHMOHCCLH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FF60", Offset = "0x2B8E560", VA = "0x182B8FF60")]
	public NFNOBEKJJOA((T1, T2) JGPHMOHCCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x568A090", Offset = "0x5688690", VA = "0x18568A090", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HKKLKOCFAJD<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) JGPHMOHCCLH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A570", Offset = "0x4E18B70", VA = "0x184E1A570")]
	public HKKLKOCFAJD((T1, T2, T3) JGPHMOHCCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A4D0", Offset = "0x4E18AD0", VA = "0x184E1A4D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NOCGNKEDOJD
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7770", Offset = "0x7FA5D70", VA = "0x187FA7770")]
	public static Range BJMGFHOEGAI(this HABDMPMOHEE EHECCAJFJLF)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class BMIHEKMJHKP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct FPMEAHMNMJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int ADEAGMHJJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int KNOCDJABJLN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6080", Offset = "0x7FA4680", VA = "0x187FA6080")]
		public FPMEAHMNMJF(int BKJCDJJKAFA, int KNOCDJABJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6070", Offset = "0x7FA4670", VA = "0x187FA6070")]
		public bool FBIFJHFEFCO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5AE0", Offset = "0x7FA40E0", VA = "0x187FA5AE0")]
	public static FPMEAHMNMJF DHKFMABLBKB(this Range EHECCAJFJLF)
	{
		return default(FPMEAHMNMJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HGEMLOFJHBP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle MNCGAKBHIPL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LBOKENBBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2890", Offset = "0x4DF0E90", VA = "0x184DF2890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2730", Offset = "0x4DF0D30", VA = "0x184DF2730")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2A90", Offset = "0x4DF1090", VA = "0x184DF2A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4DF2E90", Offset = "0x4DF1490", VA = "0x184DF2E90")]
	public HGEMLOFJHBP(T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4DF2630", Offset = "0x4DF0C30", VA = "0x184DF2630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class JPLMPFLKABL<THandle, TValue> : IDisposable where THandle : struct, PEDJJCFICCD where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> HKOOIOCCCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> NIJLHKNCLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> LKLBHJPABNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> ADCEBNEEPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int DDCMPEDNMFB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x51E6660", Offset = "0x51E4C60", VA = "0x1851E6660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x51E6B50", Offset = "0x51E5150", VA = "0x1851E6B50")]
	public JPLMPFLKABL(Action<TValue> ADCEBNEEPFE, [Optional] Func<TValue> LKLBHJPABNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x51E6450", Offset = "0x51E4A50", VA = "0x1851E6450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x51E65E0", Offset = "0x51E4BE0", VA = "0x1851E65E0")]
	public THandle JDPCENHCAFL(TValue KKGBKLFKCPO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x51E6130", Offset = "0x51E4730", VA = "0x1851E6130")]
	public bool BNBAOKNGOBL(THandle MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x51E67C0", Offset = "0x51E4DC0", VA = "0x1851E67C0")]
	public bool MGMGGGDLPBE(THandle MNCGAKBHIPL, [Out] TValue KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51E6770", Offset = "0x51E4D70", VA = "0x1851E6770")]
	public TValue KBGIPADPFGF(THandle MNCGAKBHIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x51E64E0", Offset = "0x51E4AE0", VA = "0x1851E64E0")]
	public bool FMHHEEPBJPF(THandle MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x51E6870", Offset = "0x51E4E70", VA = "0x1851E6870")]
	private THandle MMPFDMDBILN(int KHMHPNKMLMD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x51E6B00", Offset = "0x51E5100", VA = "0x1851E6B00")]
	private TValue OAIFCNJJIAD(int KHMHPNKMLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51E6730", Offset = "0x51E4D30", VA = "0x1851E6730")]
	private void KAJJLNOKFOK(int KHMHPNKMLMD, [In] THandle MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51E60E0", Offset = "0x51E46E0", VA = "0x1851E60E0")]
	private void ALDAFJKHCIJ(int KHMHPNKMLMD, [In] TValue KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x51E69A0", Offset = "0x51E4FA0", VA = "0x1851E69A0")]
	private THandle NPMJIEHHIPP()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x51E6380", Offset = "0x51E4980", VA = "0x1851E6380")]
	private void DAHNCGEFIBN(THandle MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x51E6120", Offset = "0x51E4720", VA = "0x1851E6120")]
	private int AMEGNBHKAIJ(int PFGEKBLLNEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x51E64D0", Offset = "0x51E4AD0", VA = "0x1851E64D0")]
	private bool EKLJIPPIPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA47FD0", Offset = "0xA465D0", VA = "0x180A47FD0")]
	private void MFNIDIJCNPP(THandle MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x51E6690", Offset = "0x51E4C90", VA = "0x1851E6690")]
	private bool JKOILDLHMCN([Out] THandle MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x51E68C0", Offset = "0x51E4EC0", VA = "0x1851E68C0")]
	private bool NNAFJEAEDAE([Out] THandle MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x51E6220", Offset = "0x51E4820", VA = "0x1851E6220")]
	private void CNNKFJGNDJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PEDJJCFICCD
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int BPENJJIEFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int IECDKBKDFAE
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
public static class FCMBFFHNKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F1C0", Offset = "0x3B1D7C0", VA = "0x183B1F1C0")]
	public static bool HKDAHJNLGLC<T>(this T MNCGAKBHIPL, T HOPHFOOKMCC) where T : struct, PEDJJCFICCD
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F1E0", Offset = "0x3B1D7E0", VA = "0x183B1F1E0")]
	public static bool LAPKEHOOABF<T>(this T MNCGAKBHIPL) where T : struct, PEDJJCFICCD
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5F60", Offset = "0x7FA4560", VA = "0x187FA5F60")]
	public static string EGLLDOFPIDP(this PEDJJCFICCD MNCGAKBHIPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct BPPBNOIINPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type BELMINGOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> JBGEHKANNDD;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x53704D0", Offset = "0x536EAD0", VA = "0x1853704D0")]
	public BPPBNOIINPP(Type IOBBPBDHGDF, Span<byte> OIFLPGNAJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38D27B0", Offset = "0x38D0DB0", VA = "0x1838D27B0")]
	public static BPPBNOIINPP APGCMCCAODE<T>(T KKGBKLFKCPO) where T : struct
	{
		return default(BPPBNOIINPP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5BB0", Offset = "0x7FA41B0", VA = "0x187FA5BB0")]
	public static MOJBOGBFHOM EIMKEBEILPD([In] BPPBNOIINPP GBHEJJJMLLO)
	{
		return default(MOJBOGBFHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5B30", Offset = "0x7FA4130", VA = "0x187FA5B30")]
	public Enum DBJGNPACABL(Type PFLBLPBNFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38D30B0", Offset = "0x38D16B0", VA = "0x1838D30B0")]
	public void BNAKHNGOEHD<T>([In] T KKGBKLFKCPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5C30", Offset = "0x7FA4230", VA = "0x187FA5C30")]
	public void GFDMHHJABHF(Enum DANMPOCKLCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct MOJBOGBFHOM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct EBNEJOELOIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* BJNBHBEOKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* DBMJINMFNBJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type BELMINGOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> JBGEHKANNDD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JABLCKNOJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7FA74C0", Offset = "0x7FA5AC0", VA = "0x187FA74C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BNKCIPJPGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7470", Offset = "0x7FA5A70", VA = "0x187FA7470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53704D0", Offset = "0x536EAD0", VA = "0x1853704D0")]
	public MOJBOGBFHOM(Type IOBBPBDHGDF, ReadOnlySpan<byte> OIFLPGNAJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A7B0", Offset = "0x3C28DB0", VA = "0x183C2A7B0")]
	public static MOJBOGBFHOM APGCMCCAODE<T>(T KKGBKLFKCPO) where T : struct
	{
		return default(MOJBOGBFHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7FA74D0", Offset = "0x7FA5AD0", VA = "0x187FA74D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7FA72A0", Offset = "0x7FA58A0", VA = "0x187FA72A0")]
	public object CLCLLLMPPKM(int KHMHPNKMLMD = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct ILIEOAEEDFA
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B829E0", Offset = "0x3B80FE0", VA = "0x183B829E0")]
	public static NativeArray<T> APGCMCCAODE<T>(T KKGBKLFKCPO, bool CDOBNCPPFGA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B82A50", Offset = "0x3B81050", VA = "0x183B82A50")]
	public static NativeArray<T> JNNEPCEIGPB<T>(T KKGBKLFKCPO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B82A20", Offset = "0x3B81020", VA = "0x183B82A20")]
	public static NativeArray<T> APOGBDEAFHC<T>(T KKGBKLFKCPO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7FA65E0", Offset = "0x7FA4BE0", VA = "0x187FA65E0")]
	public static NativeArray<byte> APOGBDEAFHC(ReadOnlySpan<byte> KKGBKLFKCPO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6530", Offset = "0x7FA4B30", VA = "0x187FA6530")]
	public static NativeArray<byte> APGCMCCAODE(ReadOnlySpan<byte> KKGBKLFKCPO, bool CDOBNCPPFGA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA64B0", Offset = "0x7FA4AB0", VA = "0x187FA64B0")]
	public unsafe static NativeArray<byte> APGCMCCAODE(byte* JDDAHADHDDF, int PHABMFMJBEC, bool CDOBNCPPFGA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B82A80", Offset = "0x3B81080", VA = "0x183B82A80")]
	public static NativeArray<T> PBMJKPJDLCC<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct CBPLIDIFPPJ : IEquatable<CBPLIDIFPPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int DMAFLMBDGGM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5D50", Offset = "0x7FA4350", VA = "0x187FA5D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5E40", Offset = "0x7FA4440", VA = "0x187FA5E40")]
	public CBPLIDIFPPJ(Type JLPANLJHHFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5C40", Offset = "0x7FA4240", VA = "0x187FA5C40")]
	public static CBPLIDIFPPJ EIMKEBEILPD(Type JLPANLJHHFI)
	{
		return default(CBPLIDIFPPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x234F3A0", Offset = "0x234D9A0", VA = "0x18234F3A0", Slot = "4")]
	public bool Equals(CBPLIDIFPPJ HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5CD0", Offset = "0x7FA42D0", VA = "0x187FA5CD0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5E00", Offset = "0x7FA4400", VA = "0x187FA5E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ABNLFFCDMBG
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> ABLAHILCLMP;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> JFADGDELJDL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5950", Offset = "0x7FA3F50", VA = "0x187FA5950")]
	static ABNLFFCDMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7FA56C0", Offset = "0x7FA3CC0", VA = "0x187FA56C0")]
	public static bool JDPCENHCAFL(Type JLPANLJHHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5720", Offset = "0x7FA3D20", VA = "0x187FA5720")]
	private static bool JDPCENHCAFL(Type JLPANLJHHFI, [Out] int KHMHPNKMLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5660", Offset = "0x7FA3C60", VA = "0x187FA5660")]
	public static int EFGLLEDOIBC(Type JLPANLJHHFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7FA58D0", Offset = "0x7FA3ED0", VA = "0x187FA58D0")]
	public static Type KBGIPADPFGF(int KHMHPNKMLMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GMADCBCCMMP<Handle> where Handle : PEDJJCFICCD, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct MEJEDDJHALI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly GMADCBCCMMP<Handle> GEKOKKIKPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int KHMHPNKMLMD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle IGDANPPHBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x5604D60", Offset = "0x5603360", VA = "0x185604D60")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5605100", Offset = "0x5603700", VA = "0x185605100")]
		public MEJEDDJHALI(GMADCBCCMMP<Handle> GEKOKKIKPJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5604AA0", Offset = "0x56030A0", VA = "0x185604AA0")]
		public DEENFEJEKEI BFOPDLPDKBM([In] DEENFEJEKEI HKKDKDDKEBF)
		{
			return default(DEENFEJEKEI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5604B40", Offset = "0x5603140", VA = "0x185604B40")]
		public bool FBIFJHFEFCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x56050A0", Offset = "0x56036A0", VA = "0x1856050A0")]
		private Handle LGAKALJLJAD(string CJIMOMNMAGD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct DEENFEJEKEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MEJEDDJHALI MADJBIIOOLM;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6CC3660", Offset = "0x6CC1C60", VA = "0x186CC3660")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6CC37E0", Offset = "0x6CC1DE0", VA = "0x186CC37E0")]
		public DEENFEJEKEI(GMADCBCCMMP<Handle> GEKOKKIKPJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6CC37A0", Offset = "0x6CC1DA0", VA = "0x186CC37A0")]
		public bool FBIFJHFEFCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6CC36E0", Offset = "0x6CC1CE0", VA = "0x186CC36E0")]
		public DEENFEJEKEI DHKFMABLBKB()
		{
			return default(DEENFEJEKEI);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> FBIJDHHBGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> LHFBDPOFBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int JHGALEHJKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int FLJAMFPABNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool HJGJCADCCBC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int JPIBFMDDODB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4D675F0", Offset = "0x4D65BF0", VA = "0x184D675F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DEENFEJEKEI FDMHNAKMCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4D67EA0", Offset = "0x4D664A0", VA = "0x184D67EA0")]
		get
		{
			return default(DEENFEJEKEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4D682F0", Offset = "0x4D668F0", VA = "0x184D682F0")]
	public GMADCBCCMMP(int AHOJNIBNPCF, Allocator HOHBLCPFIEJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4D66A00", Offset = "0x4D65000", VA = "0x184D66A00")]
	public void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x22A99C0", Offset = "0x22A7FC0", VA = "0x1822A99C0")]
	public static int AMEGNBHKAIJ(int JIJNMCDLDDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3066BF0", Offset = "0x30651F0", VA = "0x183066BF0")]
	public static bool AMECDDCPGDH(int JIJNMCDLDDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D67240", Offset = "0x4D65840", VA = "0x184D67240")]
	public bool GIKJFFGEANA(int KHMHPNKMLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D67BB0", Offset = "0x4D661B0", VA = "0x184D67BB0")]
	public bool OHHKFOILGOF(Handle MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D67A10", Offset = "0x4D66010", VA = "0x184D67A10")]
	public Handle OEDFMCPCFMF()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D66E00", Offset = "0x4D65400", VA = "0x184D66E00")]
	public void FHFKCENHEEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D67900", Offset = "0x4D65F00", VA = "0x184D67900")]
	public void MDNHLLBJFDH(Handle MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0")]
	private bool GHPFBFJHOML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4D676D0", Offset = "0x4D65CD0", VA = "0x184D676D0")]
	private bool KANAMMLPANA(int KHMHPNKMLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4D680B0", Offset = "0x4D666B0", VA = "0x184D680B0")]
	private void PHEFLEADPOP([Out] int KHMHPNKMLMD, [Out] int PFGEKBLLNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4D674B0", Offset = "0x4D65AB0", VA = "0x184D674B0")]
	private void HFAOJLJHJFH(Handle MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D67970", Offset = "0x4D65F70", VA = "0x184D67970")]
	private void OCCCNDGGHHB(int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4D677E0", Offset = "0x4D65DE0", VA = "0x184D677E0")]
	private bool KPBEKJDBLFG([Out] int KHMHPNKMLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4D667B0", Offset = "0x4D64DB0", VA = "0x184D667B0")]
	private static Handle AFEDNPIIDKE(int KHMHPNKMLMD, int PFGEKBLLNEL)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct CDDOMKLENMF<Handle, T> where Handle : PEDJJCFICCD, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GMADCBCCMMP<Handle> DDAIAFBFKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] MGOECPNDODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> KIBPLDEABEJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6795B00", Offset = "0x6794100", VA = "0x186795B00")]
	public CDDOMKLENMF(int AHOJNIBNPCF, [Optional] Action<T> KIBPLDEABEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6795030", Offset = "0x6793630", VA = "0x186795030")]
	public void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6795480", Offset = "0x6793A80", VA = "0x186795480")]
	public bool MGMGGGDLPBE(Handle MNCGAKBHIPL, [Out] T ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67952A0", Offset = "0x67938A0", VA = "0x1867952A0")]
	public Handle JDPCENHCAFL(T ODCICEDDLMB)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6795530", Offset = "0x6793B30", VA = "0x186795530")]
	public void MNGPIKBEKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6794DC0", Offset = "0x67933C0", VA = "0x186794DC0")]
	public void BAFGFGCDOJB(Handle MNCGAKBHIPL, [Out] T NCFHFLHJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6794C20", Offset = "0x6793220", VA = "0x186794C20")]
	public void BAFGFGCDOJB(Handle MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67959B0", Offset = "0x6793FB0", VA = "0x1867959B0")]
	private T NIKCJECJEEC(int KHMHPNKMLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67950C0", Offset = "0x67936C0", VA = "0x1867950C0")]
	private void JADEPKMAONK(int NKEKKKBNGLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct LCBPMIKIJMM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct JIKBPMNGILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private LCBPMIKIJMM<T> DDENONPPKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int KHMHPNKMLMD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x51D5BD0", Offset = "0x51D41D0", VA = "0x1851D5BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x29A6EB0", Offset = "0x29A54B0", VA = "0x1829A6EB0")]
		public JIKBPMNGILG(LCBPMIKIJMM<T> DDENONPPKCL, int KHMHPNKMLMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x51D5C20", Offset = "0x51D4220", VA = "0x1851D5C20")]
		public bool FBIFJHFEFCO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class AEBCLOGFHGP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public LCBPMIKIJMM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public AEBCLOGFHGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4E66190", Offset = "0x4E64790", VA = "0x184E66190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4E66230", Offset = "0x4E64830", VA = "0x184E66230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AJEDJNBJGBP : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public LCBPMIKIJMM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public AJEDJNBJGBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E6FDB0", Offset = "0x4E6E3B0", VA = "0x184E6FDB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E6FE50", Offset = "0x4E6E450", VA = "0x184E6FE50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] ACJFHCNBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint KKGBKLFKCPO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x53765D0", Offset = "0x5374BD0", VA = "0x1853765D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NGPOKKIJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x53765E0", Offset = "0x5374BE0", VA = "0x1853765E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MAFFJMNGDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x19166C0", Offset = "0x1914CC0", VA = "0x1819166C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool ACLFKLCKMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5376820", Offset = "0x5374E20", VA = "0x185376820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DNDOFGECFKA<T> JBGEHKANNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5376280", Offset = "0x5374880", VA = "0x185376280")]
		get
		{
			return default(DNDOFGECFKA<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5376610", Offset = "0x5374C10", VA = "0x185376610")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5375DA0", Offset = "0x53743A0", VA = "0x185375DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5376A80", Offset = "0x5375080", VA = "0x185376A80")]
	internal LCBPMIKIJMM(LCBPMIKIJMM<T> DDENONPPKCL, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5376E00", Offset = "0x5375400", VA = "0x185376E00")]
	private LCBPMIKIJMM(T[] DDENONPPKCL, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5376AA0", Offset = "0x53750A0", VA = "0x185376AA0")]
	public LCBPMIKIJMM(IEnumerable<T> NIJLHKNCLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5376A10", Offset = "0x5375010", VA = "0x185376A10")]
	public LCBPMIKIJMM(int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5376170", Offset = "0x5374770", VA = "0x185376170")]
	public int EFKJNNOOGEF(T KKGBKLFKCPO, int BKJCDJJKAFA, int FOAMCIPOLAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x53767D0", Offset = "0x5374DD0", VA = "0x1853767D0")]
	public void NKJLCJJBKOC(int BLNOEDMPECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5376400", Offset = "0x5374A00", VA = "0x185376400")]
	private void IAEAMLKIPED(int BLNOEDMPECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x53766E0", Offset = "0x5374CE0", VA = "0x1853766E0")]
	public T[] JKGPFHCOKOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5375EB0", Offset = "0x53744B0", VA = "0x185375EB0")]
	public T[] DCHHGDINECP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x53760F0", Offset = "0x53746F0", VA = "0x1853760F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5376760", Offset = "0x5374D60", VA = "0x185376760")]
	public void MJFJAMIKMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5376000", Offset = "0x5374600", VA = "0x185376000")]
	public JIKBPMNGILG DHKFMABLBKB()
	{
		return default(JIKBPMNGILG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5376830", Offset = "0x5374E30", VA = "0x185376830", Slot = "5")]
	[IteratorStateMachine(typeof(LCBPMIKIJMM<>.AEBCLOGFHGP))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5376920", Offset = "0x5374F20", VA = "0x185376920", Slot = "6")]
	[IteratorStateMachine(typeof(LCBPMIKIJMM<>.AJEDJNBJGBP))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5375E50", Offset = "0x5374450", VA = "0x185375E50")]
	public static LCBPMIKIJMM<T> CPMDNILPHCH(T[] DDENONPPKCL)
	{
		return default(LCBPMIKIJMM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x53761F0", Offset = "0x53747F0", VA = "0x1853761F0")]
	public static LCBPMIKIJMM<T> EIMKEBEILPD(T[] DDENONPPKCL)
	{
		return default(LCBPMIKIJMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5376070", Offset = "0x5374670", VA = "0x185376070")]
	private void DPKIJPNDPBP(int KHMHPNKMLMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NHCEOBNMPGM
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C9E5A0", Offset = "0x3C9CBA0", VA = "0x183C9E5A0")]
	public static LCBPMIKIJMM<T> MLEKFCAHEDL<T>(this IEnumerable<T> MHKKLCCALJI) where T : class
	{
		return default(LCBPMIKIJMM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class POIJGDNEEOK<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct DILLHAGMPIO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private POIJGDNEEOK<T> BGGFBGFNIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int KHMHPNKMLMD;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6D12940", Offset = "0x6D10F40", VA = "0x186D12940", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6D12980", Offset = "0x6D10F80", VA = "0x186D12980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4818B70", Offset = "0x4817170", VA = "0x184818B70")]
		public DILLHAGMPIO(POIJGDNEEOK<T> BGGFBGFNIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6D12860", Offset = "0x6D10E60", VA = "0x186D12860", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6D128F0", Offset = "0x6D10EF0", VA = "0x186D128F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LCBPMIKIJMM<T> ACJFHCNBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int PHABMFMJBEC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5901C60", Offset = "0x5900260", VA = "0x185901C60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF380", Offset = "0x4DED980", VA = "0x184DEF380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x486B5E0", Offset = "0x4869BE0", VA = "0x18486B5E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JPIBFMDDODB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x59018F0", Offset = "0x58FFEF0", VA = "0x1859018F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool MAFFJMNGDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5901910", Offset = "0x58FFF10", VA = "0x185901910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DNDOFGECFKA<T> JBGEHKANNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5901260", Offset = "0x58FF860", VA = "0x185901260")]
		get
		{
			return default(DNDOFGECFKA<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5901B60", Offset = "0x5900160", VA = "0x185901B60")]
	public POIJGDNEEOK(IEnumerable<T> NIJLHKNCLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5901BF0", Offset = "0x59001F0", VA = "0x185901BF0")]
	public POIJGDNEEOK(int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5901370", Offset = "0x58FF970", VA = "0x185901370")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5901210", Offset = "0x58FF810", VA = "0x185901210")]
	public LCBPMIKIJMM<T> GGEOLIIBECF()
	{
		return default(LCBPMIKIJMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5901580", Offset = "0x58FFB80", VA = "0x185901580")]
	public void JDPCENHCAFL(T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5901930", Offset = "0x58FFF30", VA = "0x185901930")]
	private void NKJLCJJBKOC(int BJPLKLLFDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5901390", Offset = "0x58FF990", VA = "0x185901390")]
	public void HPNNPOFAAPK(List<T> BGKLAKBENNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5901500", Offset = "0x58FFB00", VA = "0x185901500")]
	public void HPNNPOFAAPK(T[] BGKLAKBENNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5901050", Offset = "0x58FF650", VA = "0x185901050")]
	public void EDPAJEFJMAB(int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5900D40", Offset = "0x58FF340", VA = "0x185900D40")]
	public void BPMFFIMOCDG(int LAMMPMJNEPG, int KNOCDJABJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x59010E0", Offset = "0x58FF6E0", VA = "0x1859010E0")]
	public int EFKJNNOOGEF(T KKGBKLFKCPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5901680", Offset = "0x58FFC80", VA = "0x185901680")]
	public bool JEFAFDBINCI(T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5900FB0", Offset = "0x58FF5B0", VA = "0x185900FB0")]
	public T[] DCHHGDINECP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5901020", Offset = "0x58FF620", VA = "0x185901020", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5901160", Offset = "0x58FF760", VA = "0x185901160")]
	public static LCBPMIKIJMM<T> EIMKEBEILPD(POIJGDNEEOK<T> BGGFBGFNIID)
	{
		return default(LCBPMIKIJMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x59012F0", Offset = "0x58FF8F0", VA = "0x1859012F0", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5901AC0", Offset = "0x59000C0", VA = "0x185901AC0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5901AF0", Offset = "0x59000F0", VA = "0x185901AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5901970", Offset = "0x58FFF70", VA = "0x185901970")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void OPAMKLMFMKL(int KKGBKLFKCPO, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x59016C0", Offset = "0x58FFCC0", VA = "0x1859016C0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JGINICDOAHE(int LAMMPMJNEPG, int KNOCDJABJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LCMOKEIKGFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE590", Offset = "0x3BECB90", VA = "0x183BEE590")]
	public static void MJFJAMIKMCK<T>(this POIJGDNEEOK<T> BGGFBGFNIID) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct DNDOFGECFKA<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> ACJFHCNBBBO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B090", Offset = "0x6D29690", VA = "0x186D2B090")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AF80", Offset = "0x6D29580", VA = "0x186D2AF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B050", Offset = "0x6D29650", VA = "0x186D2B050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public DNDOFGECFKA(Span<object> OIFLPGNAJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D2ADD0", Offset = "0x6D293D0", VA = "0x186D2ADD0")]
	public DNDOFGECFKA<T> APCDOOJNCAK(int BKJCDJJKAFA)
	{
		return default(DNDOFGECFKA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D2AEA0", Offset = "0x6D294A0", VA = "0x186D2AEA0")]
	public DNDOFGECFKA<T> APCDOOJNCAK(int BKJCDJJKAFA, int PHABMFMJBEC)
	{
		return default(DNDOFGECFKA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B120", Offset = "0x6D29720", VA = "0x186D2B120")]
	public void OGANFLEFEJB(DNDOFGECFKA<T> OJALILIFLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B180", Offset = "0x6D29780", VA = "0x186D2B180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2AFB0", Offset = "0x6D295B0", VA = "0x186D2AFB0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B000", Offset = "0x6D29600", VA = "0x186D2B000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct HABDMPMOHEE : IEquatable<HABDMPMOHEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int MOBKDJHFHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int FOAMCIPOLAA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FKCGNHACNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x306D380", Offset = "0x306B980", VA = "0x18306D380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7175C10", Offset = "0x7174210", VA = "0x187175C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int CNPBHEMMBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JKOBIMNAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6410", Offset = "0x7FA4A10", VA = "0x187FA6410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6400", Offset = "0x7FA4A00", VA = "0x187FA6400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) JDJEBFFOJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7FA63A0", Offset = "0x7FA49A0", VA = "0x187FA63A0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
	private HABDMPMOHEE(int MOBKDJHFHDL, int FOAMCIPOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2997260", Offset = "0x2995860", VA = "0x182997260")]
	public static HABDMPMOHEE HFFOILBMAJJ(int MOBKDJHFHDL, int FOAMCIPOLAA)
	{
		return default(HABDMPMOHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6300", Offset = "0x7FA4900", VA = "0x187FA6300")]
	public static HABDMPMOHEE CJMKKPFLACF(int BKJCDJJKAFA, int KNOCDJABJLN)
	{
		return default(HABDMPMOHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6420", Offset = "0x7FA4A20", VA = "0x187FA6420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x12E3250", Offset = "0x12E1850", VA = "0x1812E3250", Slot = "4")]
	public bool Equals(HABDMPMOHEE HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6310", Offset = "0x7FA4910", VA = "0x187FA6310", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72C5210", Offset = "0x72C3810", VA = "0x1872C5210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct HKNJKLLPHPM<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> ACJFHCNBBBO;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public HKNJKLLPHPM(NativeArray<T> ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A590", Offset = "0x4E18B90", VA = "0x184E1A590", Slot = "6")]
	public int Compare(int POMHCCBBBGD, int JKKMGDMGNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A680", Offset = "0x4E18C80", VA = "0x184E1A680", Slot = "4")]
	public bool Equals(int POMHCCBBBGD, int JKKMGDMGNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A770", Offset = "0x4E18D70", VA = "0x184E1A770", Slot = "5")]
	public int GetHashCode(int POMHCCBBBGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PMNCHIIFCHG
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3D052B0", Offset = "0x3D038B0", VA = "0x183D052B0")]
	public static T[] PIPCPCMBMHJ<T>(List<T> BGGFBGFNIID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct PAJFJLMHFIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* LIAABHPDDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle NIDDCKPCKNG;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D41640", Offset = "0x5D3FC40", VA = "0x185D41640")]
	public void DIGOPEEDGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class NDCJAMMOLOB
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3C91EB0", Offset = "0x3C904B0", VA = "0x183C91EB0")]
	public static PAJFJLMHFIO MCJHKCDDGNB<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> DIJLOLAHCLM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(PAJFJLMHFIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3C91EB0", Offset = "0x3C904B0", VA = "0x183C91EB0")]
	public static UnsafeParallelHashMap<TKey, TValue> OGIPBHCIGMP<TKey, TValue>(this PAJFJLMHFIO DIJLOLAHCLM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DEIPAJFFBNL
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x39968D0", Offset = "0x3994ED0", VA = "0x1839968D0")]
	public static int GJINBDAEAIG<T>(ReadOnlySpan<T> LLJHOBLFPIO, ReadOnlySpan<T> DBJJGBLOIJI, int PHABMFMJBEC) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PMFJPLAIPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3D01C90", Offset = "0x3D00290", VA = "0x183D01C90")]
	public static T CLPAOECJHKG<T>(this NativeArray<byte> LFMKIINCPNH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3D01F60", Offset = "0x3D00560", VA = "0x183D01F60")]
	public static NativeArray<T> NHEGCCENOEI<T>(this NativeArray<byte> LFMKIINCPNH, int FOAMCIPOLAA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3D01DB0", Offset = "0x3D003B0", VA = "0x183D01DB0")]
	public static void JEEPEEKFONJ<T>(this NativeList<byte> PFPDPIHOEAL, [In] T KKGBKLFKCPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3D01D20", Offset = "0x3D00320", VA = "0x183D01D20")]
	public static void JEEPEEKFONJ<T>(this NativeList<byte> PFPDPIHOEAL, NativeArray<T> KKGBKLFKCPO) where T : struct
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

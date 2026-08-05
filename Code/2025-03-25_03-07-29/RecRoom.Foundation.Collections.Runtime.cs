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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7813FA0", Offset = "0x78133A0", VA = "0x187813FA0", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[BOOMJLAHDJE]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x37A3570", Offset = "0x37A2970", VA = "0x1837A3570")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[BOOMJLAHDJE]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x37AC230", Offset = "0x37AB630", VA = "0x1837AC230")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37ABF40", Offset = "0x37AB340", VA = "0x1837ABF40")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x37AC0F0", Offset = "0x37AB4F0", VA = "0x1837AC0F0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x37AC8C0", Offset = "0x37ABCC0", VA = "0x1837AC8C0")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x37A3640", Offset = "0x37A2A40", VA = "0x1837A3640")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x37A3720", Offset = "0x37A2B20", VA = "0x1837A3720")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37A3C30", Offset = "0x37A3030", VA = "0x1837A3C30")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, JMJNMGPMDKG range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37A3C70", Offset = "0x37A3070", VA = "0x1837A3C70")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x37A3AA0", Offset = "0x37A2EA0", VA = "0x1837A3AA0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37AC030", Offset = "0x37AB430", VA = "0x1837AC030")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[BOOMJLAHDJE]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37AC9B0", Offset = "0x37ABDB0", VA = "0x1837AC9B0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x37AE6D0", Offset = "0x37ADAD0", VA = "0x1837AE6D0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x37ACA50", Offset = "0x37ABE50", VA = "0x1837ACA50")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37ACF10", Offset = "0x37AC310", VA = "0x1837ACF10")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x37AFAA0", Offset = "0x37AEEA0", VA = "0x1837AFAA0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37AFA50", Offset = "0x37AEE50", VA = "0x1837AFA50")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EB10", Offset = "0x4D8DF10", VA = "0x184D8EB10")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7814090", Offset = "0x7813490", VA = "0x187814090")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78140C0", Offset = "0x78134C0", VA = "0x1878140C0")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37AEEA0", Offset = "0x37AE2A0", VA = "0x1837AEEA0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x37AED30", Offset = "0x37AE130", VA = "0x1837AED30")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37AEF70", Offset = "0x37AE370", VA = "0x1837AEF70")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37AEED0", Offset = "0x37AE2D0", VA = "0x1837AEED0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x37AEF20", Offset = "0x37AE320", VA = "0x1837AEF20")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37AEC90", Offset = "0x37AE090", VA = "0x1837AEC90")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37AF240", Offset = "0x37AE640", VA = "0x1837AF240")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x37AF0A0", Offset = "0x37AE4A0", VA = "0x1837AF0A0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37AED80", Offset = "0x37AE180", VA = "0x1837AED80")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x37AEC30", Offset = "0x37AE030", VA = "0x1837AEC30")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37AEC10", Offset = "0x37AE010", VA = "0x1837AEC10")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37AFE80", Offset = "0x37AF280", VA = "0x1837AFE80")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x37AFAB0", Offset = "0x37AEEB0", VA = "0x1837AFAB0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37AFEB0", Offset = "0x37AF2B0", VA = "0x1837AFEB0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x37AFF70", Offset = "0x37AF370", VA = "0x1837AFF70")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BOOMJLAHDJE]
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
			[Cpp2IlInjected.Address(RVA = "0x48668D0", Offset = "0x4865CD0", VA = "0x1848668D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD074A0", Offset = "0xD068A0", VA = "0x180D074A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB9A2C0", Offset = "0xB996C0", VA = "0x180B9A2C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4D46DE0", Offset = "0x4D461E0", VA = "0x184D46DE0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x50573A0", Offset = "0x50567A0", VA = "0x1850573A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5057070", Offset = "0x5056470", VA = "0x185057070")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1140", Offset = "0x3BB0540", VA = "0x183BB1140")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BOOMJLAHDJE]
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
			[Cpp2IlInjected.Address(RVA = "0x48668D0", Offset = "0x4865CD0", VA = "0x1848668D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x50A5E60", Offset = "0x50A5260", VA = "0x1850A5E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB9A2C0", Offset = "0xB996C0", VA = "0x180B9A2C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D46DE0", Offset = "0x4D461E0", VA = "0x184D46DE0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x50A59E0", Offset = "0x50A4DE0", VA = "0x1850A59E0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x50A5B90", Offset = "0x50A4F90", VA = "0x1850A5B90")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x50A5BD0", Offset = "0x50A4FD0", VA = "0x1850A5BD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x50A5D90", Offset = "0x50A5190", VA = "0x1850A5D90")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[BOOMJLAHDJE]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BOOMJLAHDJE]
public static class LENJNAHOFNM
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7813390", Offset = "0x7812790", VA = "0x187813390")]
	public static JobHandle CALLOPNCBMI(this JobHandle NJNDFFALKHH, JobHandle NLOOBJLDIMA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x78133D0", Offset = "0x78127D0", VA = "0x1878133D0")]
	public static JobHandle FGDCPNOIICA(this Span<JobHandle> KKPPEGLJPBD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FHOLFENNLGA
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x35A08D0", Offset = "0x359FCD0", VA = "0x1835A08D0")]
	public static NativeKeyValueArrays<TKey, TValue> JFCFGJOBLIL<TKey, TValue>(this Dictionary<TKey, TValue> GCADBJPOPIH, Allocator LENIJMBFHJK) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BBNKEBDMNJI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x78127B0", Offset = "0x7811BB0", VA = "0x1878127B0")]
	public static void BMHJBHJHBJD(this GameObject MKMGIAEJNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7812670", Offset = "0x7811A70", VA = "0x187812670")]
	public static void BMHJBHJHBJD(this Component EJFPPCHJOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7812710", Offset = "0x7811B10", VA = "0x187812710")]
	public static void BMHJBHJHBJD(this ScriptableObject DCGDKENDHGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PHCEODNNGPB
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7814270", Offset = "0x7813670", VA = "0x187814270")]
	public static void IPLPGHMGFGO(this NativeList<byte> JMHKEMEJOPH, ReadOnlySpan<byte> FOGPNODEGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37E4DE0", Offset = "0x37E41E0", VA = "0x1837E4DE0")]
	public static void JGEJHIOOOIG<T>(this NativeList<T> JMHKEMEJOPH, T FIIKLGCIAGG, int PPLOBPJCNII) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LOPNALFLAHN
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36DB1C0", Offset = "0x36DA5C0", VA = "0x1836DB1C0")]
	public static T LJDEFMKBPAK<T>(this ReadOnlySpan<byte> FIIKLGCIAGG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36DB060", Offset = "0x36DA460", VA = "0x1836DB060")]
	public static T LFMANLNEAFP<T>(this Span<T> FOGPNODEGHL, Func<T, bool> OEDBBHLBGPF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36DB3C0", Offset = "0x36DA7C0", VA = "0x1836DB3C0")]
	public static bool PMLIOLBKHPC<T>(this Span<T> FOGPNODEGHL, Func<T, bool> OEDBBHLBGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36DAFB0", Offset = "0x36DA3B0", VA = "0x1836DAFB0")]
	public static bool DNHNBOLKIBO<T>(this Span<T> FOGPNODEGHL, Func<T, bool> OEDBBHLBGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36DAA60", Offset = "0x36D9E60", VA = "0x1836DAA60")]
	public static T CNKKCIMLPML<T>([In] this ReadOnlySpan<byte> FOGPNODEGHL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36AF720", Offset = "0x36AEB20", VA = "0x1836AF720")]
	public static Span<TTo> BMJMONCKIAH<TTo, TFrom>(this Span<TFrom> FOGPNODEGHL) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36AF720", Offset = "0x36AEB20", VA = "0x1836AF720")]
	public static ReadOnlySpan<TTo> BMJMONCKIAH<TTo, TFrom>(this ReadOnlySpan<TFrom> FOGPNODEGHL) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36AF720", Offset = "0x36AEB20", VA = "0x1836AF720")]
	public static ReadOnlySpan<TTo> BMJMONCKIAH<TTo>(this ReadOnlySpan<byte> FOGPNODEGHL) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36DA550", Offset = "0x36D9950", VA = "0x1836DA550")]
	public static Span<byte> AJAPKMAIBCL<T>([In] this Span<byte> FOGPNODEGHL, T FIIKLGCIAGG) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x78134F0", Offset = "0x78128F0", VA = "0x1878134F0")]
	private static Enum FOMMAELHINF([In] ReadOnlySpan<byte> FOGPNODEGHL, Type PNPFBMNGOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7813480", Offset = "0x7812880", VA = "0x187813480")]
	public static Enum BACGOCDPBPO([In] this Span<byte> FOGPNODEGHL, Type PNPFBMNGOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7813A90", Offset = "0x7812E90", VA = "0x187813A90")]
	public static void NAPPCBIKPDB([In] this Span<byte> FOGPNODEGHL, Enum KBBLKNKJAHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PBDHFFNIMDG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BFBEMHHMNMM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7812850", Offset = "0x7811C50", VA = "0x187812850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7814150", Offset = "0x7813550", VA = "0x187814150")]
	[AsyncStateMachine(typeof(BFBEMHHMNMM))]
	public static void HNODGFDAOIP(this Task CFOOONLCHLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OFMDCFKMPPD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum CFJONBKFNCE : short
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
	public struct ILHAMGAOJMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly CFJONBKFNCE MCBJECJLDOM;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C250", Offset = "0x2C6B650", VA = "0x182C6C250")]
		public ILHAMGAOJMB(CFJONBKFNCE MCBJECJLDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory LPMLMMNKNGK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	public static void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x78140F0", Offset = "0x78134F0", VA = "0x1878140F0")]
	static OFMDCFKMPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3292210", Offset = "0x3291610", VA = "0x183292210")]
	public static ILHAMGAOJMB GJGELFLKGEC(CFJONBKFNCE MCBJECJLDOM)
	{
		return default(ILHAMGAOJMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	public static void DAJEOCEIAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DOGIELCDLFD
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x341B8F0", Offset = "0x341ACF0", VA = "0x18341B8F0")]
	public static NHPEAHJEFGI<T1, T2> NMGBAAKBMJB<T1, T2>(this (T1, T2) LIHECGNHILG) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(NHPEAHJEFGI<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x341B910", Offset = "0x341AD10", VA = "0x18341B910")]
	public static JEOCHLBLPJB<T1, T2, T3> NMGBAAKBMJB<T1, T2, T3>(this (T1, T2, T3) LIHECGNHILG) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(JEOCHLBLPJB<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NHPEAHJEFGI<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) LIHECGNHILG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5028C60", Offset = "0x5028060", VA = "0x185028C60")]
	public NHPEAHJEFGI((T1, T2) LIHECGNHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5028BF0", Offset = "0x5027FF0", VA = "0x185028BF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JEOCHLBLPJB<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) LIHECGNHILG;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4BD2A70", Offset = "0x4BD1E70", VA = "0x184BD2A70")]
	public JEOCHLBLPJB((T1, T2, T3) LIHECGNHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4BD29D0", Offset = "0x4BD1DD0", VA = "0x184BD29D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MPLBDIEFKOH
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7814030", Offset = "0x7813430", VA = "0x187814030")]
	public static Range KLBMMBBDCEB(this JMJNMGPMDKG IAJIOGCMJAG)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CGPIBBIGNOP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct PMHFFCJEBBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int AFADNKNNDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int IDOPGLOKNFM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7814300", Offset = "0x7813700", VA = "0x187814300")]
		public PMHFFCJEBBJ(int LLNIGMDIFON, int IDOPGLOKNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x78142F0", Offset = "0x78136F0", VA = "0x1878142F0")]
		public bool OPMFPOJCPHB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x78129D0", Offset = "0x7811DD0", VA = "0x1878129D0")]
	public static PMHFFCJEBBJ NHFIHKFCIDL(this Range IAJIOGCMJAG)
	{
		return default(PMHFFCJEBBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LKKOIADGHLN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle ENGGEIHHCEE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MHCPIEIJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E6B0", Offset = "0x4D8DAB0", VA = "0x184D8E6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EB40", Offset = "0x4D8DF40", VA = "0x184D8EB40")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E6C0", Offset = "0x4D8DAC0", VA = "0x184D8E6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4D8EEC0", Offset = "0x4D8E2C0", VA = "0x184D8EEC0")]
	public LKKOIADGHLN(T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4D8EB10", Offset = "0x4D8DF10", VA = "0x184D8EB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class ICDFHOICLOE<THandle, TValue> : IDisposable where THandle : struct, GLCINBGBILH where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> KKPPEGLJPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> EDJBENPLFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> NEJIPIIEICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> BCLPLLMFAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int MDGABMODMLD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x49AE020", Offset = "0x49AD420", VA = "0x1849AE020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x49AE3E0", Offset = "0x49AD7E0", VA = "0x1849AE3E0")]
	public ICDFHOICLOE(Action<TValue> BCLPLLMFAJM, [Optional] Func<TValue> NEJIPIIEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x49ADAC0", Offset = "0x49ACEC0", VA = "0x1849ADAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x49ADF80", Offset = "0x49AD380", VA = "0x1849ADF80")]
	public THandle LLICHLCEEGA(TValue FIIKLGCIAGG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x49AD990", Offset = "0x49ACD90", VA = "0x1849AD990")]
	public bool DPGGICHIMDD(THandle ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x49AD700", Offset = "0x49ACB00", VA = "0x1849AD700")]
	public bool CJAKJEKDEBL(THandle ENGGEIHHCEE, [Out] TValue FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x49AD7D0", Offset = "0x49ACBD0", VA = "0x1849AD7D0")]
	public TValue CNKKCIMLPML(THandle ENGGEIHHCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49AE120", Offset = "0x49AD520", VA = "0x1849AE120")]
	public bool OECMCOFHLAA(THandle ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x49AD930", Offset = "0x49ACD30", VA = "0x1849AD930")]
	private THandle DHHJDOOLADG(int KDCAMOIGIMA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x49ADC40", Offset = "0x49AD040", VA = "0x1849ADC40")]
	private TValue IFFONPNJNJH(int KDCAMOIGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49ADBF0", Offset = "0x49ACFF0", VA = "0x1849ADBF0")]
	private void HGLKHCMMBCJ(int KDCAMOIGIMA, [In] THandle ENGGEIHHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x49ADBA0", Offset = "0x49ACFA0", VA = "0x1849ADBA0")]
	private void FFMDCEDPLLA(int KDCAMOIGIMA, [In] TValue FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x49ADDD0", Offset = "0x49AD1D0", VA = "0x1849ADDD0")]
	private THandle KGJDDJDHDOF()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x49AD820", Offset = "0x49ACC20", VA = "0x1849AD820")]
	private void DEBMNBHMJPL(THandle ENGGEIHHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x49AE060", Offset = "0x49AD460", VA = "0x1849AE060")]
	private int NPGJLAGFEAC(int DFDKLALNEIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x49ADB90", Offset = "0x49ACF90", VA = "0x1849ADB90")]
	private bool EOGFHMKIKMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x99F880", Offset = "0x99EC80", VA = "0x18099F880")]
	private void PNKEBDJNEOD(THandle ENGGEIHHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49AE070", Offset = "0x49AD470", VA = "0x1849AE070")]
	private bool ODBNDPLHDFH([Out] THandle ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49ADCA0", Offset = "0x49AD0A0", VA = "0x1849ADCA0")]
	private bool KDFLBGLLJAA([Out] THandle ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x49AE230", Offset = "0x49AD630", VA = "0x1849AE230")]
	private void OGEAHCIPLCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GLCINBGBILH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int BNBIOAJGDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int KIPMDJJPCPL
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
public static class DCBFJEDELOK
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3402060", Offset = "0x3401460", VA = "0x183402060")]
	public static bool FAMKIPBNIMH<T>(this T ENGGEIHHCEE, T JAPIEEBOJEA) where T : struct, GLCINBGBILH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3402080", Offset = "0x3401480", VA = "0x183402080")]
	public static bool MLDGJAOBMHH<T>(this T ENGGEIHHCEE) where T : struct, GLCINBGBILH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7812A20", Offset = "0x7811E20", VA = "0x187812A20")]
	public static string LFDHJFLIEOL(this GLCINBGBILH ENGGEIHHCEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public ref struct DCENJHJEFHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type FMCGDOBJAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> BPMDNCJMFCH;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4D46BA0", Offset = "0x4D45FA0", VA = "0x184D46BA0")]
	public DCENJHJEFHP(Type AFDNOIMIFPM, Span<byte> FOGPNODEGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3402250", Offset = "0x3401650", VA = "0x183402250")]
	public static DCENJHJEFHP KJCCMOBODJG<T>(T FIIKLGCIAGG) where T : struct
	{
		return default(DCENJHJEFHP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7812BB0", Offset = "0x7811FB0", VA = "0x187812BB0")]
	public static FNAGAENKAAF MDKCMNAEKLA([In] DCENJHJEFHP NAEIDONDAPA)
	{
		return default(FNAGAENKAAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7812B30", Offset = "0x7811F30", VA = "0x187812B30")]
	public Enum BACGOCDPBPO(Type PNPFBMNGOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3402210", Offset = "0x3401610", VA = "0x183402210")]
	public void AJAPKMAIBCL<T>([In] T FIIKLGCIAGG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7812C30", Offset = "0x7812030", VA = "0x187812C30")]
	public void NAPPCBIKPDB(Enum KBBLKNKJAHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct FNAGAENKAAF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct DFDANPANLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* PFGHBMEIMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* MCBOJPMNJCD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type FMCGDOBJAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> BPMDNCJMFCH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LJKCKNCBLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7812C40", Offset = "0x7812040", VA = "0x187812C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OEDLKCFGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7812C50", Offset = "0x7812050", VA = "0x187812C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4D46BA0", Offset = "0x4D45FA0", VA = "0x184D46BA0")]
	public FNAGAENKAAF(Type AFDNOIMIFPM, ReadOnlySpan<byte> FOGPNODEGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35AEC80", Offset = "0x35AE080", VA = "0x1835AEC80")]
	public static FNAGAENKAAF KJCCMOBODJG<T>(T FIIKLGCIAGG) where T : struct
	{
		return default(FNAGAENKAAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7812E70", Offset = "0x7812270", VA = "0x187812E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7812CA0", Offset = "0x78120A0", VA = "0x187812CA0")]
	public object NGNPDPIKAOC(int KDCAMOIGIMA = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KHBJIILHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36AF610", Offset = "0x36AEA10", VA = "0x1836AF610")]
	public static NativeArray<T> KJCCMOBODJG<T>(T FIIKLGCIAGG, bool MCGHHBDAMGJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x36AF5C0", Offset = "0x36AE9C0", VA = "0x1836AF5C0")]
	public static NativeArray<T> HBABACCFBCB<T>(T FIIKLGCIAGG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x36AF660", Offset = "0x36AEA60", VA = "0x1836AF660")]
	public static NativeArray<T> MHJOGDBGHGJ<T>(T FIIKLGCIAGG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x78132D0", Offset = "0x78126D0", VA = "0x1878132D0")]
	public static NativeArray<byte> MHJOGDBGHGJ(ReadOnlySpan<byte> FIIKLGCIAGG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x78131A0", Offset = "0x78125A0", VA = "0x1878131A0")]
	public static NativeArray<byte> KJCCMOBODJG(ReadOnlySpan<byte> FIIKLGCIAGG, bool MCGHHBDAMGJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7813250", Offset = "0x7812650", VA = "0x187813250")]
	public unsafe static NativeArray<byte> KJCCMOBODJG(byte* IBBLOPLBGPG, int GHDAIPOHNAO, bool MCGHHBDAMGJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x36AF6B0", Offset = "0x36AEAB0", VA = "0x1836AF6B0")]
	public static NativeArray<T> OGOLFLHIENG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LKKIGFHDJEP<Handle> where Handle : GLCINBGBILH, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct PCPCCPNOBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly LKKIGFHDJEP<Handle> BELFBFACPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int KDCAMOIGIMA;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Handle ENFIOPCGCCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x52C7FE0", Offset = "0x52C73E0", VA = "0x1852C7FE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x52C8390", Offset = "0x52C7790", VA = "0x1852C8390")]
		public PCPCCPNOBPG(LKKIGFHDJEP<Handle> BELFBFACPMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x52C7D20", Offset = "0x52C7120", VA = "0x1852C7D20")]
		public LMNJAIPPOKN AFLKMMODJAC([In] LMNJAIPPOKN OICAMEEFOOB)
		{
			return default(LMNJAIPPOKN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x52C8150", Offset = "0x52C7550", VA = "0x1852C8150")]
		public bool OPMFPOJCPHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x52C7E10", Offset = "0x52C7210", VA = "0x1852C7E10")]
		private Handle BECCFJADJPK(string EIGJGBPHOMK)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct LMNJAIPPOKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private PCPCCPNOBPG JLGGDODGOAC;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4D95B60", Offset = "0x4D94F60", VA = "0x184D95B60")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D95CD0", Offset = "0x4D950D0", VA = "0x184D95CD0")]
		public LMNJAIPPOKN(LKKIGFHDJEP<Handle> BELFBFACPMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4D95C90", Offset = "0x4D95090", VA = "0x184D95C90")]
		public bool OPMFPOJCPHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4D95BE0", Offset = "0x4D94FE0", VA = "0x184D95BE0")]
		public LMNJAIPPOKN NHFIHKFCIDL()
		{
			return default(LMNJAIPPOKN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeList<int> NFKPBAFNOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<int> ENDLGIPECIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int BLFCLHKFHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int LIBCCIGJHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool JMNMHJAHEBL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int LIHNDKDCAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D5E0", Offset = "0x4D8C9E0", VA = "0x184D8D5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LMNJAIPPOKN GLCBOOENKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C9A0", Offset = "0x4D8BDA0", VA = "0x184D8C9A0")]
		get
		{
			return default(LMNJAIPPOKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E510", Offset = "0x4D8D910", VA = "0x184D8E510")]
	public LKKIGFHDJEP(int LAIMGLECPGE, Allocator LENIJMBFHJK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E150", Offset = "0x4D8D550", VA = "0x184D8E150")]
	public void JNOHBLLEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F97580", Offset = "0x1F96980", VA = "0x181F97580")]
	public static int NPGJLAGFEAC(int AEPDMGGJHKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2CABF10", Offset = "0x2CAB310", VA = "0x182CABF10")]
	public static bool LPINLALIAPI(int AEPDMGGJHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4D8CC20", Offset = "0x4D8C020", VA = "0x184D8CC20")]
	public bool CEKFPEMAGBP(int KDCAMOIGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DA90", Offset = "0x4D8CE90", VA = "0x184D8DA90")]
	public bool FJHHEFHMAMG(Handle ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E380", Offset = "0x4D8D780", VA = "0x184D8E380")]
	public Handle KJIJICDEIHG()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D8CD50", Offset = "0x4D8C150", VA = "0x184D8CD50")]
	public void CFBBGJLGPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4D8CA10", Offset = "0x4D8BE10", VA = "0x184D8CA10")]
	public void BNPLCENGDCA(Handle ENGGEIHHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD13190", Offset = "0xD12590", VA = "0x180D13190")]
	private bool GLIMBOPGPJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E4B0", Offset = "0x4D8D8B0", VA = "0x184D8E4B0")]
	private bool ODGABNBLKIM(int KDCAMOIGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DD70", Offset = "0x4D8D170", VA = "0x184D8DD70")]
	private void GJHBLKHCMBG([Out] int KDCAMOIGIMA, [Out] int DFDKLALNEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D7C0", Offset = "0x4D8CBC0", VA = "0x184D8D7C0")]
	private void FDIAMKAOCDC(Handle ENGGEIHHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E210", Offset = "0x4D8D610", VA = "0x184D8E210")]
	private void KHCMGELNBBD(int KDCAMOIGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4D8D530", Offset = "0x4D8C930", VA = "0x184D8D530")]
	private bool EHFHFODAHFE([Out] int KDCAMOIGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DEE0", Offset = "0x4D8D2E0", VA = "0x184D8DEE0")]
	private static Handle JEICOHHJLDI(int KDCAMOIGIMA, int DFDKLALNEIC)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public struct OCIHKBLGDJN<Handle, T> where Handle : GLCINBGBILH, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LKKIGFHDJEP<Handle> NPGPJLMAIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] PDLEDFJPEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Action<T> NHOOAJPAIJN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5147500", Offset = "0x5146900", VA = "0x185147500")]
	public OCIHKBLGDJN(int LAIMGLECPGE, [Optional] Action<T> NHOOAJPAIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5147120", Offset = "0x5146520", VA = "0x185147120")]
	public void JNOHBLLEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5146840", Offset = "0x5145C40", VA = "0x185146840")]
	public bool CJAKJEKDEBL(Handle ENGGEIHHCEE, [Out] T HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x51472E0", Offset = "0x51466E0", VA = "0x1851472E0")]
	public Handle LLICHLCEEGA(T HAPOBHMBDHP)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5146C60", Offset = "0x5146060", VA = "0x185146C60")]
	public void GNGLCEHLGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5146A90", Offset = "0x5145E90", VA = "0x185146A90")]
	public void FBDLIPAFCGJ(Handle ENGGEIHHCEE, [Out] T GKAGEKJNPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x51468F0", Offset = "0x5145CF0", VA = "0x1851468F0")]
	public void FBDLIPAFCGJ(Handle ENGGEIHHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x51470C0", Offset = "0x51464C0", VA = "0x1851470C0")]
	private T IMCFFIFGEDE(int KDCAMOIGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5147220", Offset = "0x5146620", VA = "0x185147220")]
	private void KGHFCEGMAHC(int DBDJNDPHCBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public struct CACJNPHFLJO<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LLGDDJNPCDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private CACJNPHFLJO<T> KCPGIJAPEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int KDCAMOIGIMA;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4D8FF00", Offset = "0x4D8F300", VA = "0x184D8FF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x266D770", Offset = "0x266CB70", VA = "0x18266D770")]
		public LLGDDJNPCDI(CACJNPHFLJO<T> KCPGIJAPEHH, int KDCAMOIGIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4D8FF50", Offset = "0x4D8F350", VA = "0x184D8FF50")]
		public bool OPMFPOJCPHB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class HIKKGIOGOPN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CACJNPHFLJO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public HIKKGIOGOPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x488DA80", Offset = "0x488CE80", VA = "0x18488DA80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x488DB20", Offset = "0x488CF20", VA = "0x18488DB20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KHECKPFPIGH : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CACJNPHFLJO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public KHECKPFPIGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4CD3DA0", Offset = "0x4CD31A0", VA = "0x184CD3DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4CD3E40", Offset = "0x4CD3240", VA = "0x184CD3E40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private object[] AMHCLKHIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private uint FIIKLGCIAGG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HAABCAIFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5474B70", Offset = "0x5473F70", VA = "0x185474B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JKHINNGGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x612A150", Offset = "0x6129550", VA = "0x18612A150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MOKMGBCLCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x15F7740", Offset = "0x15F6B40", VA = "0x1815F7740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal bool FOIMBLOPIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x612A840", Offset = "0x6129C40", VA = "0x18612A840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MKPOFIPENHI<T> BPMDNCJMFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x612A180", Offset = "0x6129580", VA = "0x18612A180")]
		get
		{
			return default(MKPOFIPENHI<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x612A700", Offset = "0x6129B00", VA = "0x18612A700")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x612A450", Offset = "0x6129850", VA = "0x18612A450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x612AB40", Offset = "0x6129F40", VA = "0x18612AB40")]
	internal CACJNPHFLJO(CACJNPHFLJO<T> KCPGIJAPEHH, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x612AB20", Offset = "0x6129F20", VA = "0x18612AB20")]
	private CACJNPHFLJO(T[] KCPGIJAPEHH, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x612AB60", Offset = "0x6129F60", VA = "0x18612AB60")]
	public CACJNPHFLJO(IEnumerable<T> EDJBENPLFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x612AAB0", Offset = "0x6129EB0", VA = "0x18612AAB0")]
	public CACJNPHFLJO(int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x612A850", Offset = "0x6129C50", VA = "0x18612A850")]
	public int PHPPPHPHCBN(T FIIKLGCIAGG, int LLNIGMDIFON, int PPLOBPJCNII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6129EC0", Offset = "0x61292C0", VA = "0x186129EC0")]
	public void BJGCECBGPCO(int JJNOKPMEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6129F00", Offset = "0x6129300", VA = "0x186129F00")]
	private void COBACIKIMPC(int JJNOKPMEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x612A680", Offset = "0x6129A80", VA = "0x18612A680")]
	public T[] MINONHEGBMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x612A300", Offset = "0x6129700", VA = "0x18612A300")]
	public T[] ICFDPGCHGNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x612A0D0", Offset = "0x61294D0", VA = "0x18612A0D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6129E60", Offset = "0x6129260", VA = "0x186129E60")]
	public void BBEAHAOPFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x612A7D0", Offset = "0x6129BD0", VA = "0x18612A7D0")]
	public LLGDDJNPCDI NHFIHKFCIDL()
	{
		return default(LLGDDJNPCDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x612A8D0", Offset = "0x6129CD0", VA = "0x18612A8D0", Slot = "5")]
	[IteratorStateMachine(typeof(CACJNPHFLJO<>.HIKKGIOGOPN))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x612A9C0", Offset = "0x6129DC0", VA = "0x18612A9C0", Slot = "6")]
	[IteratorStateMachine(typeof(CACJNPHFLJO<>.KHECKPFPIGH))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x612A580", Offset = "0x6129980", VA = "0x18612A580")]
	public static CACJNPHFLJO<T> JHKEKEADDDB(T[] KCPGIJAPEHH)
	{
		return default(CACJNPHFLJO<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x612A5E0", Offset = "0x61299E0", VA = "0x18612A5E0")]
	public static CACJNPHFLJO<T> MDKCMNAEKLA(T[] KCPGIJAPEHH)
	{
		return default(CACJNPHFLJO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x612A500", Offset = "0x6129900", VA = "0x18612A500")]
	private void IPADPEGHGGG(int KDCAMOIGIMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class EIEPCDCEBED<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct NCGOJKCGFGJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EIEPCDCEBED<T> JMHKEMEJOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int KDCAMOIGIMA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4FE8EA0", Offset = "0x4FE82A0", VA = "0x184FE8EA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4FE8EE0", Offset = "0x4FE82E0", VA = "0x184FE8EE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4200BE0", Offset = "0x41FFFE0", VA = "0x184200BE0")]
		public NCGOJKCGFGJ(EIEPCDCEBED<T> JMHKEMEJOPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4FE8DB0", Offset = "0x4FE81B0", VA = "0x184FE8DB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4FE8E50", Offset = "0x4FE8250", VA = "0x184FE8E50", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private CACJNPHFLJO<T> AMHCLKHIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int GHDAIPOHNAO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x42808F0", Offset = "0x427FCF0", VA = "0x1842808F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HAABCAIFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xB327A0", Offset = "0xB31BA0", VA = "0x180B327A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4280010", Offset = "0x427F410", VA = "0x184280010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int LIHNDKDCAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x427FF30", Offset = "0x427F330", VA = "0x18427FF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool MOKMGBCLCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4280960", Offset = "0x427FD60", VA = "0x184280960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public MKPOFIPENHI<T> BPMDNCJMFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x427FF90", Offset = "0x427F390", VA = "0x18427FF90")]
		get
		{
			return default(MKPOFIPENHI<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4280B20", Offset = "0x427FF20", VA = "0x184280B20")]
	public EIEPCDCEBED(IEnumerable<T> EDJBENPLFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4280AB0", Offset = "0x427FEB0", VA = "0x184280AB0")]
	public EIEPCDCEBED(int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x427FF50", Offset = "0x427F350", VA = "0x18427FF50")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4280130", Offset = "0x427F530", VA = "0x184280130")]
	public CACJNPHFLJO<T> IHADMCEJLCH()
	{
		return default(CACJNPHFLJO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4280710", Offset = "0x427FB10", VA = "0x184280710")]
	public void LLICHLCEEGA(T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x427FD80", Offset = "0x427F180", VA = "0x18427FD80")]
	private void BJGCECBGPCO(int MFDGLHBGGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4280170", Offset = "0x427F570", VA = "0x184280170")]
	public void IPLPGHMGFGO(List<T> OBLBKNNLCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x42802F0", Offset = "0x427F6F0", VA = "0x1842802F0")]
	public void IPLPGHMGFGO(T[] OBLBKNNLCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4280390", Offset = "0x427F790", VA = "0x184280390")]
	public void KMFGPAKLNAM(int KDCAMOIGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x427FBB0", Offset = "0x427EFB0", VA = "0x18427FBB0")]
	public void BIODCCCAOBI(int MDKAIHFOKHG, int IDOPGLOKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4280980", Offset = "0x427FD80", VA = "0x184280980")]
	public int PHPPPHPHCBN(T FIIKLGCIAGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4280470", Offset = "0x427F870", VA = "0x184280470")]
	public bool LDBOOCLJOMK(T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x42800C0", Offset = "0x427F4C0", VA = "0x1842800C0")]
	public T[] ICFDPGCHGNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x427FF10", Offset = "0x427F310", VA = "0x18427FF10", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4280830", Offset = "0x427FC30", VA = "0x184280830")]
	public static CACJNPHFLJO<T> MDKCMNAEKLA(EIEPCDCEBED<T> JMHKEMEJOPH)
	{
		return default(CACJNPHFLJO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4280050", Offset = "0x427F450", VA = "0x184280050", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4280A00", Offset = "0x427FE00", VA = "0x184280A00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4280A40", Offset = "0x427FE40", VA = "0x184280A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x427FDC0", Offset = "0x427F1C0", VA = "0x18427FDC0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CHFEEFEOKPA(int FIIKLGCIAGG, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x42804C0", Offset = "0x427F8C0", VA = "0x1842804C0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void LHFJJELCHKH(int MDKAIHFOKHG, int IDOPGLOKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class EOGEKFPHCJM
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3448960", Offset = "0x3447D60", VA = "0x183448960")]
	public static void BBEAHAOPFCM<T>(this EIEPCDCEBED<T> JMHKEMEJOPH) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public ref struct MKPOFIPENHI<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Span<object> AMHCLKHIFKH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D800", Offset = "0x4F9CC00", VA = "0x184F9D800")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D620", Offset = "0x4F9CA20", VA = "0x184F9D620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int HAABCAIFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D590", Offset = "0x4F9C990", VA = "0x184F9D590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x110A3E0", Offset = "0x11097E0", VA = "0x18110A3E0")]
	public MKPOFIPENHI(Span<object> FOGPNODEGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D730", Offset = "0x4F9CB30", VA = "0x184F9D730")]
	public MKPOFIPENHI<T> LCMIFFDKEMJ(int LLNIGMDIFON)
	{
		return default(MKPOFIPENHI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D650", Offset = "0x4F9CA50", VA = "0x184F9D650")]
	public MKPOFIPENHI<T> LCMIFFDKEMJ(int LLNIGMDIFON, int GHDAIPOHNAO)
	{
		return default(MKPOFIPENHI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D4E0", Offset = "0x4F9C8E0", VA = "0x184F9D4E0")]
	public void CINELLCKMFL(MKPOFIPENHI<T> PIAHNGGJDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D880", Offset = "0x4F9CC80", VA = "0x184F9D880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D540", Offset = "0x4F9C940", VA = "0x184F9D540", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D5D0", Offset = "0x4F9C9D0", VA = "0x184F9D5D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct JMJNMGPMDKG : IEquatable<JMJNMGPMDKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int NPELPNMIGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int PPLOBPJCNII;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int MCKFPDMFILD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A510", Offset = "0x2C89910", VA = "0x182C8A510")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A94680", Offset = "0x6A93A80", VA = "0x186A94680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int ONGBGDOFLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int HBNMGDOLNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7813000", Offset = "0x7812400", VA = "0x187813000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7812FF0", Offset = "0x78123F0", VA = "0x187812FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public (int begin, int end) LPJGNAICMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x78130A0", Offset = "0x78124A0", VA = "0x1878130A0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
	private JMJNMGPMDKG(int NPELPNMIGOA, int PPLOBPJCNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2656ED0", Offset = "0x26562D0", VA = "0x182656ED0")]
	public static JMJNMGPMDKG FCEIGHAGBHL(int NPELPNMIGOA, int PPLOBPJCNII)
	{
		return default(JMJNMGPMDKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7813100", Offset = "0x7812500", VA = "0x187813100")]
	public static JMJNMGPMDKG JNHCBNHBMCN(int LLNIGMDIFON, int IDOPGLOKNFM)
	{
		return default(JMJNMGPMDKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7813110", Offset = "0x7812510", VA = "0x187813110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x176F820", Offset = "0x176EC20", VA = "0x18176F820", Slot = "4")]
	public bool Equals(JMJNMGPMDKG JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7813010", Offset = "0x7812410", VA = "0x187813010", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4DC0", Offset = "0x6BF41C0", VA = "0x186BF4DC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct FOLAFDIAJNH<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NativeArray<T> AMHCLKHIFKH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x110A3E0", Offset = "0x11097E0", VA = "0x18110A3E0")]
	public FOLAFDIAJNH(NativeArray<T> AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4718390", Offset = "0x4717790", VA = "0x184718390", Slot = "6")]
	public int Compare(int JFJPEDLJOKC, int MJINJIJLGDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4718480", Offset = "0x4717880", VA = "0x184718480", Slot = "4")]
	public bool Equals(int JFJPEDLJOKC, int MJINJIJLGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4718570", Offset = "0x4717970", VA = "0x184718570", Slot = "5")]
	public int GetHashCode(int JFJPEDLJOKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EKPALHPDCHH
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x34464B0", Offset = "0x34458B0", VA = "0x1834464B0")]
	public static T[] JNCPDDFLCPA<T>(List<T> JMHKEMEJOPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BIHJDDDACOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* AENJCHIKCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal AllocatorManager.AllocatorHandle ENKHAPALANC;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x572C070", Offset = "0x572B470", VA = "0x18572C070")]
	public void JNOHBLLEJCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OMCDDDHKACN
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x37D1D50", Offset = "0x37D1150", VA = "0x1837D1D50")]
	public static BIHJDDDACOI PLOOKKNLGFF<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> EBAHFMPNPGP) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(BIHJDDDACOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x37D1D50", Offset = "0x37D1150", VA = "0x1837D1D50")]
	public static UnsafeParallelHashMap<TKey, TValue> GIFFFLEMLFD<TKey, TValue>(this BIHJDDDACOI EBAHFMPNPGP) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class LFOBPEPDONP
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x36BCE60", Offset = "0x36BC260", VA = "0x1836BCE60")]
	public static int KBCNBLHJAIB<T>(ReadOnlySpan<T> IKPBMOPOECD, ReadOnlySpan<T> OKMLIAFACOH, int GHDAIPOHNAO) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HDLFPLPFEKM
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x35D19E0", Offset = "0x35D0DE0", VA = "0x1835D19E0")]
	public static T AHKKEODFCBM<T>(this NativeArray<byte> ICAPBAKKPBL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x35D1330", Offset = "0x35D0730", VA = "0x1835D1330")]
	public static NativeArray<T> AGIIAKMNLGM<T>(this NativeArray<byte> ICAPBAKKPBL, int PPLOBPJCNII) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x35D17F0", Offset = "0x35D0BF0", VA = "0x1835D17F0")]
	public static void AHGLPFENCIH<T>(this NativeList<byte> DHFBCDKDEBC, [In] T FIIKLGCIAGG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x35D1750", Offset = "0x35D0B50", VA = "0x1835D1750")]
	public static void AHGLPFENCIH<T>(this NativeList<byte> DHFBCDKDEBC, NativeArray<T> FIIKLGCIAGG) where T : struct
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

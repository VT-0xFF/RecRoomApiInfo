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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C63190", Offset = "0x7C62190", VA = "0x187C63190", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[BLHJELDGGCE]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x399E0B0", Offset = "0x399D0B0", VA = "0x18399E0B0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[BLHJELDGGCE]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x399EEA0", Offset = "0x399DEA0", VA = "0x18399EEA0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x399E180", Offset = "0x399D180", VA = "0x18399E180")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x399E240", Offset = "0x399D240", VA = "0x18399E240")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x39A40E0", Offset = "0x39A30E0", VA = "0x1839A40E0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x39A3DF0", Offset = "0x39A2DF0", VA = "0x1839A3DF0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x39A3FA0", Offset = "0x39A2FA0", VA = "0x1839A3FA0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x39A4760", Offset = "0x39A3760", VA = "0x1839A4760")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x399F690", Offset = "0x399E690", VA = "0x18399F690")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x399F620", Offset = "0x399E620", VA = "0x18399F620")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x399FC10", Offset = "0x399EC10", VA = "0x18399FC10")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, EIOEEPICKHB range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x399FC50", Offset = "0x399EC50", VA = "0x18399FC50")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x399FA80", Offset = "0x399EA80", VA = "0x18399FA80")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x39A3EE0", Offset = "0x39A2EE0", VA = "0x1839A3EE0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[BLHJELDGGCE]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x39A9630", Offset = "0x39A8630", VA = "0x1839A9630")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x39AB490", Offset = "0x39AA490", VA = "0x1839AB490")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39AB4A0", Offset = "0x39AA4A0", VA = "0x1839AB4A0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A5FCD0", Offset = "0x6A5ECD0", VA = "0x186A5FCD0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C63850", Offset = "0x7C62850", VA = "0x187C63850")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C63880", Offset = "0x7C62880", VA = "0x187C63880")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x39AA8D0", Offset = "0x39A98D0", VA = "0x1839AA8D0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x39AAA70", Offset = "0x39A9A70", VA = "0x1839AAA70")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39AACE0", Offset = "0x39A9CE0", VA = "0x1839AACE0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x39AA900", Offset = "0x39A9900", VA = "0x1839AA900")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x39AAC90", Offset = "0x39A9C90", VA = "0x1839AAC90")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39AA9D0", Offset = "0x39A99D0", VA = "0x1839AA9D0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39AB060", Offset = "0x39AA060", VA = "0x1839AB060")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x39AAEC0", Offset = "0x39A9EC0", VA = "0x1839AAEC0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39AAAC0", Offset = "0x39A9AC0", VA = "0x1839AAAC0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x39AA870", Offset = "0x39A9870", VA = "0x1839AA870")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39AA850", Offset = "0x39A9850", VA = "0x1839AA850")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39AB8C0", Offset = "0x39AA8C0", VA = "0x1839AB8C0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39AB4F0", Offset = "0x39AA4F0", VA = "0x1839AB4F0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39AB8F0", Offset = "0x39AA8F0", VA = "0x1839AB8F0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39AB9B0", Offset = "0x39AA9B0", VA = "0x1839AB9B0")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BLHJELDGGCE]
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
			[Cpp2IlInjected.Address(RVA = "0x4AC1A30", Offset = "0x4AC0A30", VA = "0x184AC1A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD949C0", Offset = "0xD939C0", VA = "0x180D949C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5093280", Offset = "0x5092280", VA = "0x185093280")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x540D400", Offset = "0x540C400", VA = "0x18540D400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x540D800", Offset = "0x540C800", VA = "0x18540D800")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC78B0", Offset = "0x3CC68B0", VA = "0x183CC78B0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BLHJELDGGCE]
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
			[Cpp2IlInjected.Address(RVA = "0x4AC1A30", Offset = "0x4AC0A30", VA = "0x184AC1A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x545F590", Offset = "0x545E590", VA = "0x18545F590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5093280", Offset = "0x5092280", VA = "0x185093280")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x545F100", Offset = "0x545E100", VA = "0x18545F100")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x545F2C0", Offset = "0x545E2C0", VA = "0x18545F2C0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x545F4A0", Offset = "0x545E4A0", VA = "0x18545F4A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x545F3D0", Offset = "0x545E3D0", VA = "0x18545F3D0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[BLHJELDGGCE]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BLHJELDGGCE]
public static class GOKEDHNKLDK
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C62600", Offset = "0x7C61600", VA = "0x187C62600")]
	public static JobHandle FPGGJNLFLIH(this JobHandle FDJHCIBLFFB, JobHandle CNIMJCCKEDM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C62640", Offset = "0x7C61640", VA = "0x187C62640")]
	public static JobHandle NFDEIIAHBAC(this Span<JobHandle> LPJEPOMELAF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PIFCDFHHJAE
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34C8520", Offset = "0x34C7520", VA = "0x1834C8520")]
	public static void INBDHNEFJBE<T>(this T[] NBBLCIBNPBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HNDDJHLLIBF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x386CAC0", Offset = "0x386BAC0", VA = "0x18386CAC0")]
	public static NativeKeyValueArrays<TKey, TValue> EBJLEFALMNB<TKey, TValue>(this Dictionary<TKey, TValue> BCFIBNCLPAG, Allocator NDFENJBGNOB) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DHOBCPFPCOP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C621F0", Offset = "0x7C611F0", VA = "0x187C621F0")]
	public static void DOGCOHFFAJC(this GameObject CEKGANCAJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C62290", Offset = "0x7C61290", VA = "0x187C62290")]
	public static void DOGCOHFFAJC(this Component HABFEKNHDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C62150", Offset = "0x7C61150", VA = "0x187C62150")]
	public static void DOGCOHFFAJC(this ScriptableObject LHACFNGANGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NNGGLPFNOLE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C637D0", Offset = "0x7C627D0", VA = "0x187C637D0")]
	public static void FONMAMFNLDF(this NativeList<byte> OLEDHEBBJPH, ReadOnlySpan<byte> ICCNHBNAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x399A350", Offset = "0x3999350", VA = "0x18399A350")]
	public static void DICGBPFJDFK<T>(this NativeList<T> OLEDHEBBJPH, T OHLIHBDBKCE, int JAALIADHHOC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BHEKHMGAIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35C4D70", Offset = "0x35C3D70", VA = "0x1835C4D70")]
	public static T PELDKDDJIOK<T>(this ReadOnlySpan<byte> OHLIHBDBKCE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35C4A60", Offset = "0x35C3A60", VA = "0x1835C4A60")]
	public static T EKDKJIDEBEH<T>(this Span<T> ICCNHBNAAFG, Func<T, bool> PMLBLGEPBDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35C4BC0", Offset = "0x35C3BC0", VA = "0x1835C4BC0")]
	public static bool JBMMPJAGPJN<T>(this Span<T> ICCNHBNAAFG, Func<T, bool> PMLBLGEPBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35C44A0", Offset = "0x35C34A0", VA = "0x1835C44A0")]
	public static bool AMMCPDCIEJN<T>(this Span<T> ICCNHBNAAFG, Func<T, bool> PMLBLGEPBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35C4FB0", Offset = "0x35C3FB0", VA = "0x1835C4FB0")]
	public static T PHDCGNDDLGA<T>([In] this ReadOnlySpan<byte> ICCNHBNAAFG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x359DF30", Offset = "0x359CF30", VA = "0x18359DF30")]
	public static Span<TTo> MJIANAMKMJD<TTo, TFrom>(this Span<TFrom> ICCNHBNAAFG) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x359DF30", Offset = "0x359CF30", VA = "0x18359DF30")]
	public static ReadOnlySpan<TTo> MJIANAMKMJD<TTo, TFrom>(this ReadOnlySpan<TFrom> ICCNHBNAAFG) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x359DF30", Offset = "0x359CF30", VA = "0x18359DF30")]
	public static ReadOnlySpan<TTo> MJIANAMKMJD<TTo>(this ReadOnlySpan<byte> ICCNHBNAAFG) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35C4C70", Offset = "0x35C3C70", VA = "0x1835C4C70")]
	public static Span<T> OKKBPPIELHH<T>(this ReadOnlySpan<T> KIDPOMGFMKB) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35C4550", Offset = "0x35C3550", VA = "0x1835C4550")]
	public static Span<byte> DGBNDJBCMEF<T>([In] this Span<byte> ICCNHBNAAFG, T OHLIHBDBKCE) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C61B40", Offset = "0x7C60B40", VA = "0x187C61B40")]
	private static Enum LMHPFKNPAFJ([In] ReadOnlySpan<byte> ICCNHBNAAFG, Type NNODEEMKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C620E0", Offset = "0x7C610E0", VA = "0x187C620E0")]
	public static Enum ONFGOEPLDDN([In] this Span<byte> ICCNHBNAAFG, Type NNODEEMKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C61630", Offset = "0x7C60630", VA = "0x187C61630")]
	public static void ICMBPEGPJJE([In] this Span<byte> ICCNHBNAAFG, Enum PCHMHBNEGIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GLBBPFMCGPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct ALOOCDNJOMN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C614B0", Offset = "0x7C604B0", VA = "0x187C614B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C624E0", Offset = "0x7C614E0", VA = "0x187C624E0")]
	[AsyncStateMachine(typeof(ALOOCDNJOMN))]
	public static void AFCEBPDGNMM(this Task LEMBKBGMCDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OLCPNIOFOHC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x39D8A30", Offset = "0x39D7A30", VA = "0x1839D8A30")]
	public static NativeArray<T> JIOMOOCKKND<T>(this UnsafeList<T> OLEDHEBBJPH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x39D89B0", Offset = "0x39D79B0", VA = "0x1839D89B0")]
	public static NativeArray<T> FNFLPDDAKGG<T>(this UnsafeList<T> OLEDHEBBJPH, bool IBIHDDIPMBP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39D8A90", Offset = "0x39D7A90", VA = "0x1839D8A90")]
	public static UnsafeList<T> OKKBPPIELHH<T>(this UnsafeList<T> OLEDHEBBJPH, Allocator NDFENJBGNOB) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JGBFMNCONFO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum MBONJAHPDHF : short
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
	public struct HIJHDIGIKBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly MBONJAHPDHF OEHHKNIGGMI;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2DD67E0", Offset = "0x2DD57E0", VA = "0x182DD67E0")]
		public HIJHDIGIKBE(MBONJAHPDHF OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory BMEHNMPPGJP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	public static void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C62E70", Offset = "0x7C61E70", VA = "0x187C62E70")]
	static JGBFMNCONFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34D07F0", Offset = "0x34CF7F0", VA = "0x1834D07F0")]
	public static HIJHDIGIKBE MPJFCCLMDOB(MBONJAHPDHF OEHHKNIGGMI)
	{
		return default(HIJHDIGIKBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	public static void IKLKFHLMHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MMOMCGDDPJE
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3924F20", Offset = "0x3923F20", VA = "0x183924F20")]
	public static ANFOGDGHFKE<T1, T2> IPBDIILNIAL<T1, T2>(this (T1, T2) DAPCBFLAHDI) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(ANFOGDGHFKE<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3924F40", Offset = "0x3923F40", VA = "0x183924F40")]
	public static JDNEIIIODIF<T1, T2, T3> IPBDIILNIAL<T1, T2, T3>(this (T1, T2, T3) DAPCBFLAHDI) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(JDNEIIIODIF<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ANFOGDGHFKE<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) DAPCBFLAHDI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4F60410", Offset = "0x4F5F410", VA = "0x184F60410")]
	public ANFOGDGHFKE((T1, T2) DAPCBFLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4F5FF50", Offset = "0x4F5EF50", VA = "0x184F5FF50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JDNEIIIODIF<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) DAPCBFLAHDI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4E2AD00", Offset = "0x4E29D00", VA = "0x184E2AD00")]
	public JDNEIIIODIF((T1, T2, T3) DAPCBFLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E2AC60", Offset = "0x4E29C60", VA = "0x184E2AC60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IKDONFCINFK
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C62820", Offset = "0x7C61820", VA = "0x187C62820")]
	public static Range DOEBCAEBCDJ(this EIOEEPICKHB OOGHBEFHNIB)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IPHHHLAKCND
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct HJHBDCKJOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int HFINKANMECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int LLDMNGOPBOL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C62700", Offset = "0x7C61700", VA = "0x187C62700")]
		public HJHBDCKJOPN(int IPAELMFFKOA, int LLDMNGOPBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C626F0", Offset = "0x7C616F0", VA = "0x187C626F0")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C62880", Offset = "0x7C61880", VA = "0x187C62880")]
	public static HJHBDCKJOPN OMLAPONJPHN(this Range OOGHBEFHNIB)
	{
		return default(HJHBDCKJOPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DINIMJBJPAM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle BOJCEMEJOMP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PMOBAACPJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A5FD00", Offset = "0x6A5ED00", VA = "0x186A5FD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A5FAA0", Offset = "0x6A5EAA0", VA = "0x186A5FAA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A5FFC0", Offset = "0x6A5EFC0", VA = "0x186A5FFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A602C0", Offset = "0x6A5F2C0", VA = "0x186A602C0")]
	public DINIMJBJPAM(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FCD0", Offset = "0x6A5ECD0", VA = "0x186A5FCD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class PEBNEEMIANK<THandle, TValue> : IDisposable where THandle : struct, PMKOIOKBFCO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> LPJEPOMELAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> DHLGAIMCINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> NIPILOBJGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> MIFONHGHFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int BGBBCIOILJC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x55FD620", Offset = "0x55FC620", VA = "0x1855FD620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55FE370", Offset = "0x55FD370", VA = "0x1855FE370")]
	public PEBNEEMIANK(Action<TValue> MIFONHGHFAE, [Optional] Func<TValue> NIPILOBJGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55FD8C0", Offset = "0x55FC8C0", VA = "0x1855FD8C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55FDAE0", Offset = "0x55FCAE0", VA = "0x1855FDAE0")]
	public THandle IIGLPCDPOEE(TValue OHLIHBDBKCE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55FD9A0", Offset = "0x55FC9A0", VA = "0x1855FD9A0")]
	public bool HMHHJKJOIHP(THandle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55FDDE0", Offset = "0x55FCDE0", VA = "0x1855FDDE0")]
	public bool LEDEGLNAGAD(THandle BOJCEMEJOMP, [Out] TValue OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55FE320", Offset = "0x55FD320", VA = "0x1855FE320")]
	public TValue PHDCGNDDLGA(THandle BOJCEMEJOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55FE190", Offset = "0x55FD190", VA = "0x1855FE190")]
	public bool NOMOJCGANNC(THandle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55FE2C0", Offset = "0x55FD2C0", VA = "0x1855FE2C0")]
	private THandle OHNOFFLEJLC(int OHHMJGCBCKD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x55FDF70", Offset = "0x55FCF70", VA = "0x1855FDF70")]
	private TValue LNLLCGCJJDK(int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55FD660", Offset = "0x55FC660", VA = "0x1855FD660")]
	private void AOPFKHIPNIJ(int OHHMJGCBCKD, [In] THandle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55FD860", Offset = "0x55FC860", VA = "0x1855FD860")]
	private void DKFJJBJKAHH(int OHHMJGCBCKD, [In] TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x55FDFD0", Offset = "0x55FCFD0", VA = "0x1855FDFD0")]
	private THandle MOMCNJLLCCH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x55FDB80", Offset = "0x55FCB80", VA = "0x1855FDB80")]
	private void JAGFMLGGMFD(THandle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x55FE2B0", Offset = "0x55FD2B0", VA = "0x1855FE2B0")]
	private int OBJINEPDOEG(int DJNGLBELENN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55FD8B0", Offset = "0x55FC8B0", VA = "0x1855FD8B0")]
	private bool DLKLDKCBIBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
	private void ODOBMJKJABM(THandle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55FDEB0", Offset = "0x55FCEB0", VA = "0x1855FDEB0")]
	private bool LHOHIJHAENN([Out] THandle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x55FDCA0", Offset = "0x55FCCA0", VA = "0x1855FDCA0")]
	private bool LDDLKBDDNDJ([Out] THandle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x55FD6B0", Offset = "0x55FC6B0", VA = "0x1855FD6B0")]
	private void DEGHHBIJMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PMKOIOKBFCO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HOIFNBMOKEA
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x386D0D0", Offset = "0x386C0D0", VA = "0x18386D0D0")]
	public static bool KDGLHGAKIGH<T>(this T BOJCEMEJOMP, T MIJLJBIHDMP) where T : struct, PMKOIOKBFCO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x386D0F0", Offset = "0x386C0F0", VA = "0x18386D0F0")]
	public static bool LKIDIFGHMGH<T>(this T BOJCEMEJOMP) where T : struct, PMKOIOKBFCO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C62710", Offset = "0x7C61710", VA = "0x187C62710")]
	public static string CAONNPCAEKB(this PMKOIOKBFCO BOJCEMEJOMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct NBDNAFKNLDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type BKLCKKFDJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> PJGJPCHJDEM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5093530", Offset = "0x5092530", VA = "0x185093530")]
	public NBDNAFKNLDM(Type MKOBJJFHGND, Span<byte> ICCNHBNAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3987270", Offset = "0x3986270", VA = "0x183987270")]
	public static NBDNAFKNLDM ECGNHAOMACM<T>(T OHLIHBDBKCE) where T : struct
	{
		return default(NBDNAFKNLDM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C636D0", Offset = "0x7C626D0", VA = "0x187C636D0")]
	public static JBPLEEKMCJK OIFHDJNIHDL([In] NBDNAFKNLDM NFFBJCCKPJF)
	{
		return default(JBPLEEKMCJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C63750", Offset = "0x7C62750", VA = "0x187C63750")]
	public Enum ONFGOEPLDDN(Type NNODEEMKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3987230", Offset = "0x3986230", VA = "0x183987230")]
	public void DGBNDJBCMEF<T>([In] T OHLIHBDBKCE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C636C0", Offset = "0x7C626C0", VA = "0x187C636C0")]
	public void ICMBPEGPJJE(Enum PCHMHBNEGIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct JBPLEEKMCJK
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct ODALPLOOIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* HPLOFABFHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* PPMLHPJGPIJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type BKLCKKFDJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> PJGJPCHJDEM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OLEFCKNPEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C62CE0", Offset = "0x7C61CE0", VA = "0x187C62CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OOKCMKIEOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C62AC0", Offset = "0x7C61AC0", VA = "0x187C62AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5093530", Offset = "0x5092530", VA = "0x185093530")]
	public JBPLEEKMCJK(Type MKOBJJFHGND, ReadOnlySpan<byte> ICCNHBNAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38A0220", Offset = "0x389F220", VA = "0x1838A0220")]
	public static JBPLEEKMCJK ECGNHAOMACM<T>(T OHLIHBDBKCE) where T : struct
	{
		return default(JBPLEEKMCJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C62CF0", Offset = "0x7C61CF0", VA = "0x187C62CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C62B10", Offset = "0x7C61B10", VA = "0x187C62B10")]
	public object KDGJOGBGMGL(int OHHMJGCBCKD = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JBLFPAGOOLL
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38A0110", Offset = "0x389F110", VA = "0x1838A0110")]
	public static NativeArray<T> ECGNHAOMACM<T>(T OHLIHBDBKCE, bool IBIHDDIPMBP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38A00C0", Offset = "0x389F0C0", VA = "0x1838A00C0")]
	public static NativeArray<T> AJHHGMCFPGA<T>(T OHLIHBDBKCE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38A0160", Offset = "0x389F160", VA = "0x1838A0160")]
	public static NativeArray<T> HJMCEKEBOGL<T>(T OHLIHBDBKCE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C62A00", Offset = "0x7C61A00", VA = "0x187C62A00")]
	public static NativeArray<byte> HJMCEKEBOGL(ReadOnlySpan<byte> OHLIHBDBKCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C628D0", Offset = "0x7C618D0", VA = "0x187C628D0")]
	public static NativeArray<byte> ECGNHAOMACM(ReadOnlySpan<byte> OHLIHBDBKCE, bool IBIHDDIPMBP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C62980", Offset = "0x7C61980", VA = "0x187C62980")]
	public unsafe static NativeArray<byte> ECGNHAOMACM(byte* DIPLOKEAIKB, int DDGBDMFPMAI, bool IBIHDDIPMBP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38A01B0", Offset = "0x389F1B0", VA = "0x1838A01B0")]
	public static NativeArray<T> KKKNNENCOAG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct LIIAANKIMBN : IEquatable<LIIAANKIMBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int IKGHDBJPNHK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C62F70", Offset = "0x7C61F70", VA = "0x187C62F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C630F0", Offset = "0x7C620F0", VA = "0x187C630F0")]
	public LIIAANKIMBN(Type MLCOGCMJLBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C63020", Offset = "0x7C62020", VA = "0x187C63020")]
	public static LIIAANKIMBN OIFHDJNIHDL(Type MLCOGCMJLBB)
	{
		return default(LIIAANKIMBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x213A3A0", Offset = "0x21393A0", VA = "0x18213A3A0", Slot = "4")]
	public bool Equals(LIIAANKIMBN MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C62EE0", Offset = "0x7C61EE0", VA = "0x187C62EE0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C630B0", Offset = "0x7C620B0", VA = "0x187C630B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class MHKPAEABHNE
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> GGKNCDEMPKD;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> KNKFMNBPHLH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C63530", Offset = "0x7C62530", VA = "0x187C63530")]
	static MHKPAEABHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C63280", Offset = "0x7C62280", VA = "0x187C63280")]
	public static bool IIGLPCDPOEE(Type MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C632E0", Offset = "0x7C622E0", VA = "0x187C632E0")]
	private static bool IIGLPCDPOEE(Type MLCOGCMJLBB, [Out] int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C63220", Offset = "0x7C62220", VA = "0x187C63220")]
	public static int DJBJOAFCKAH(Type MLCOGCMJLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C634B0", Offset = "0x7C624B0", VA = "0x187C634B0")]
	public static Type PHDCGNDDLGA(int OHHMJGCBCKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct BDKIHAAKCFG<Handle> where Handle : PMKOIOKBFCO, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct FFPJOPNBKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly BDKIHAAKCFG<Handle> CNODPANFMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int OHHMJGCBCKD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle FEAFDHOBIIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x495D8B0", Offset = "0x495C8B0", VA = "0x18495D8B0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x495DD30", Offset = "0x495CD30", VA = "0x18495DD30")]
		public FFPJOPNBKPL(BDKIHAAKCFG<Handle> CNODPANFMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x495D6A0", Offset = "0x495C6A0", VA = "0x18495D6A0")]
		public MNOKIOEPDJM ACADPGMDEBE([In] MNOKIOEPDJM COFBNOFIHKI)
		{
			return default(MNOKIOEPDJM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x495DC10", Offset = "0x495CC10", VA = "0x18495DC10")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x495DA90", Offset = "0x495CA90", VA = "0x18495DA90")]
		private Handle JBDCMHBHMBN(string NAAMEAFIHJI)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct MNOKIOEPDJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private FFPJOPNBKPL PNCNAPDJEHL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x53532B0", Offset = "0x53522B0", VA = "0x1853532B0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x53533F0", Offset = "0x53523F0", VA = "0x1853533F0")]
		public MNOKIOEPDJM(BDKIHAAKCFG<Handle> CNODPANFMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x53533B0", Offset = "0x53523B0", VA = "0x1853533B0")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x53532F0", Offset = "0x53522F0", VA = "0x1853532F0")]
		public MNOKIOEPDJM OMLAPONJPHN()
		{
			return default(MNOKIOEPDJM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> HPIGHBCLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> NDNGKKMONBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int BBHBOADACFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int IBKKBAKIJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool LENHLKJBPFL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EFJAAKPECFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x61B9C40", Offset = "0x61B8C40", VA = "0x1861B9C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MNOKIOEPDJM LGHPBCEONLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x61BA150", Offset = "0x61B9150", VA = "0x1861BA150")]
		get
		{
			return default(MNOKIOEPDJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61BB360", Offset = "0x61BA360", VA = "0x1861BB360")]
	public BDKIHAAKCFG(int HNDEALABJHB, Allocator NDFENJBGNOB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61BAB80", Offset = "0x61B9B80", VA = "0x1861BAB80")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x20BCF30", Offset = "0x20BBF30", VA = "0x1820BCF30")]
	public static int OBJINEPDOEG(int IINHKHEMEHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DEFA30", Offset = "0x2DEEA30", VA = "0x182DEFA30")]
	public static bool MOAAONALADM(int IINHKHEMEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61B9E30", Offset = "0x61B8E30", VA = "0x1861B9E30")]
	public bool FEKCOKLOFMJ(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61BA1E0", Offset = "0x61B91E0", VA = "0x1861BA1E0")]
	public bool JNCAOECEFKD(Handle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61BA640", Offset = "0x61B9640", VA = "0x1861BA640")]
	public Handle KNBPJIPPCJC()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61BB040", Offset = "0x61BA040", VA = "0x1861BB040")]
	public void OOPCMCKFHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x61B9870", Offset = "0x61B8870", VA = "0x1861B9870")]
	public void ALPHNEPABOE(Handle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA88B0", VA = "0x180DA98B0")]
	private bool OAGCHIGJFFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61BA0F0", Offset = "0x61B90F0", VA = "0x1861BA0F0")]
	private bool GIDLKDHDBGC(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61BA7E0", Offset = "0x61B97E0", VA = "0x1861BA7E0")]
	private void MJMKMMJAIMM([Out] int OHHMJGCBCKD, [Out] int DJNGLBELENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61B9AB0", Offset = "0x61B8AB0", VA = "0x1861B9AB0")]
	private void BFJFHCGJHBG(Handle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x61BAAE0", Offset = "0x61B9AE0", VA = "0x1861BAAE0")]
	private void NLNALAEIKLL(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x61BA590", Offset = "0x61B9590", VA = "0x1861BA590")]
	private bool JOKLEGIFMMP([Out] int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x61B9C80", Offset = "0x61B8C80", VA = "0x1861B9C80")]
	private static Handle FBGJEGDKIEJ(int OHHMJGCBCKD, int DJNGLBELENN)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct KEAENKDOBJK<Handle, T> where Handle : PMKOIOKBFCO, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private BDKIHAAKCFG<Handle> MNBFNNKBALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] FBGEPLFBKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> AJBEMMOIIJP;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F4FCA0", Offset = "0x4F4ECA0", VA = "0x184F4FCA0")]
	public KEAENKDOBJK(int HNDEALABJHB, [Optional] Action<T> AJBEMMOIIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F4FBB0", Offset = "0x4F4EBB0", VA = "0x184F4FBB0")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F4F9B0", Offset = "0x4F4E9B0", VA = "0x184F4F9B0")]
	public bool LEDEGLNAGAD(Handle BOJCEMEJOMP, [Out] T BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F4F7D0", Offset = "0x4F4E7D0", VA = "0x184F4F7D0")]
	public Handle IIGLPCDPOEE(T BOMDCGFKGKF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F4EE80", Offset = "0x4F4DE80", VA = "0x184F4EE80")]
	public void DPGGDFHGCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F4F4E0", Offset = "0x4F4E4E0", VA = "0x184F4F4E0")]
	public void GNAALOCCJEL(Handle BOJCEMEJOMP, [Out] T OFOGECGDEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F4F300", Offset = "0x4F4E300", VA = "0x184F4F300")]
	public void GNAALOCCJEL(Handle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F4FC40", Offset = "0x4F4EC40", VA = "0x184F4FC40")]
	private T PCPGCJBCFNA(int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F4FA60", Offset = "0x4F4EA60", VA = "0x184F4FA60")]
	private void MJFIPLOMOCL(int APLIMCOJDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct KOGLLFEDMCC<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct GCICOOEMNJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private KOGLLFEDMCC<T> NBBLCIBNPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int OHHMJGCBCKD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x4A50A60", Offset = "0x4A4FA60", VA = "0x184A50A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27B98F0", Offset = "0x27B88F0", VA = "0x1827B98F0")]
		public GCICOOEMNJJ(KOGLLFEDMCC<T> NBBLCIBNPBK, int OHHMJGCBCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4A50AB0", Offset = "0x4A4FAB0", VA = "0x184A50AB0")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NIAFNOJJCGD : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KOGLLFEDMCC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public NIAFNOJJCGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x53CA450", Offset = "0x53C9450", VA = "0x1853CA450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x53CA4F0", Offset = "0x53C94F0", VA = "0x1853CA4F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MEHKPMALGIJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KOGLLFEDMCC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public MEHKPMALGIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x531F9A0", Offset = "0x531E9A0", VA = "0x18531F9A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x531FA40", Offset = "0x531EA40", VA = "0x18531FA40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint OHLIHBDBKCE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0C30", Offset = "0x4FEFC30", VA = "0x184FF0C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0E60", Offset = "0x4FEFE60", VA = "0x184FF0E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x17118A0", Offset = "0x17108A0", VA = "0x1817118A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool NIJMEBKDACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0B40", Offset = "0x4FEFB40", VA = "0x184FF0B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IOEBHBCOCDK<T> PJGJPCHJDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0940", Offset = "0x4FEF940", VA = "0x184FF0940")]
		get
		{
			return default(IOEBHBCOCDK<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0450", Offset = "0x4FEF450", VA = "0x184FF0450")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0CE0", Offset = "0x4FEFCE0", VA = "0x184FF0CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1120", Offset = "0x4FF0120", VA = "0x184FF1120")]
	internal KOGLLFEDMCC(KOGLLFEDMCC<T> NBBLCIBNPBK, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1100", Offset = "0x4FF0100", VA = "0x184FF1100")]
	private KOGLLFEDMCC(T[] NBBLCIBNPBK, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1140", Offset = "0x4FF0140", VA = "0x184FF1140")]
	public KOGLLFEDMCC(IEnumerable<T> DHLGAIMCINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1090", Offset = "0x4FF0090", VA = "0x184FF1090")]
	public KOGLLFEDMCC(int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0AC0", Offset = "0x4FEFAC0", VA = "0x184FF0AC0")]
	public int KBEMGMDGBFE(T OHLIHBDBKCE, int IPAELMFFKOA, int JAALIADHHOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0400", Offset = "0x4FEF400", VA = "0x184FF0400")]
	public void ABGGKEGJDNP(int ADJKIMFDLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4FF05A0", Offset = "0x4FEF5A0", VA = "0x184FF05A0")]
	private void GCBHDIPHJML(int ADJKIMFDLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0770", Offset = "0x4FEF770", VA = "0x184FF0770")]
	public T[] GCDNHKGKKKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4FF07F0", Offset = "0x4FEF7F0", VA = "0x184FF07F0")]
	public T[] HGAAFLBNLDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0520", Offset = "0x4FEF520", VA = "0x184FF0520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0E00", Offset = "0x4FEFE00", VA = "0x184FF0E00")]
	public void PHJGHJKIEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0D90", Offset = "0x4FEFD90", VA = "0x184FF0D90")]
	public GCICOOEMNJJ OMLAPONJPHN()
	{
		return default(GCICOOEMNJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0E90", Offset = "0x4FEFE90", VA = "0x184FF0E90", Slot = "5")]
	[IteratorStateMachine(typeof(KOGLLFEDMCC<>.NIAFNOJJCGD))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0F90", Offset = "0x4FEFF90", VA = "0x184FF0F90", Slot = "6")]
	[IteratorStateMachine(typeof(KOGLLFEDMCC<>.MEHKPMALGIJ))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0BD0", Offset = "0x4FEFBD0", VA = "0x184FF0BD0")]
	public static KOGLLFEDMCC<T> KCAGPEGHBPE(T[] NBBLCIBNPBK)
	{
		return default(KOGLLFEDMCC<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0C40", Offset = "0x4FEFC40", VA = "0x184FF0C40")]
	public static KOGLLFEDMCC<T> OIFHDJNIHDL(T[] NBBLCIBNPBK)
	{
		return default(KOGLLFEDMCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0B50", Offset = "0x4FEFB50", VA = "0x184FF0B50")]
	private void KCABHMKLAHM(int OHHMJGCBCKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class IEALDBHBOML<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct LLCIBGPHFDF : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IEALDBHBOML<T> OLEDHEBBJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int OHHMJGCBCKD;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x51215F0", Offset = "0x51205F0", VA = "0x1851215F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5121630", Offset = "0x5120630", VA = "0x185121630", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4571860", Offset = "0x4570860", VA = "0x184571860")]
		public LLCIBGPHFDF(IEALDBHBOML<T> OLEDHEBBJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5121500", Offset = "0x5120500", VA = "0x185121500", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x51215A0", Offset = "0x51205A0", VA = "0x1851215A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private KOGLLFEDMCC<T> APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int DDGBDMFPMAI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9480", Offset = "0x4BF8480", VA = "0x184BF9480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4A93190", Offset = "0x4A92190", VA = "0x184A93190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int EFJAAKPECFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4BF95D0", Offset = "0x4BF85D0", VA = "0x184BF95D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4BF96D0", Offset = "0x4BF86D0", VA = "0x184BF96D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IOEBHBCOCDK<T> PJGJPCHJDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9B30", Offset = "0x4BF8B30", VA = "0x184BF9B30")]
		get
		{
			return default(IOEBHBCOCDK<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4BFA170", Offset = "0x4BF9170", VA = "0x184BFA170")]
	public IEALDBHBOML(int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4BF7530", Offset = "0x4BF6530", VA = "0x184BF7530")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9550", Offset = "0x4BF8550", VA = "0x184BF9550")]
	public KOGLLFEDMCC<T> DHMFHDDCNJK()
	{
		return default(KOGLLFEDMCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9A00", Offset = "0x4BF8A00", VA = "0x184BF9A00")]
	public void IIGLPCDPOEE(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9260", Offset = "0x4BF8260", VA = "0x184BF9260")]
	private void ABGGKEGJDNP(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4BF96F0", Offset = "0x4BF86F0", VA = "0x184BF96F0")]
	public void FONMAMFNLDF(List<T> PFOGKPFJJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9870", Offset = "0x4BF8870", VA = "0x184BF9870")]
	public void FONMAMFNLDF(T[] PFOGKPFJJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4BF95F0", Offset = "0x4BF85F0", VA = "0x184BF95F0")]
	public void FMOLGLEKKMF(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4BF92A0", Offset = "0x4BF82A0", VA = "0x184BF92A0")]
	public void AFGOFDHLLID(int HACDKCPGBDB, int LLDMNGOPBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9BC0", Offset = "0x4BF8BC0", VA = "0x184BF9BC0")]
	public int KBEMGMDGBFE(T OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9500", Offset = "0x4BF8500", VA = "0x184BF9500")]
	public bool DGAEJOHLCDJ(T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9980", Offset = "0x4BF8980", VA = "0x184BF9980")]
	public T[] HGAAFLBNLDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4BF95A0", Offset = "0x4BF85A0", VA = "0x184BF95A0", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9EA0", Offset = "0x4BF8EA0", VA = "0x184BF9EA0")]
	public static KOGLLFEDMCC<T> OIFHDJNIHDL(IEALDBHBOML<T> OLEDHEBBJPH)
	{
		return default(KOGLLFEDMCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9910", Offset = "0x4BF8910", VA = "0x184BF9910", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4BFA0C0", Offset = "0x4BF90C0", VA = "0x184BFA0C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4BFA100", Offset = "0x4BF9100", VA = "0x184BFA100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9F70", Offset = "0x4BF8F70", VA = "0x184BF9F70")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void POOJOINHCLF(int OHLIHBDBKCE, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9C50", Offset = "0x4BF8C50", VA = "0x184BF9C50")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void MBJBBBJHILA(int HACDKCPGBDB, int LLDMNGOPBOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class HCDGFPLDJNH
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3865EB0", Offset = "0x3864EB0", VA = "0x183865EB0")]
	public static void PHJGHJKIEBA<T>(this IEALDBHBOML<T> OLEDHEBBJPH) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public ref struct IOEBHBCOCDK<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4C11E90", Offset = "0x4C10E90", VA = "0x184C11E90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4C121B0", Offset = "0x4C111B0", VA = "0x184C121B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4C12170", Offset = "0x4C11170", VA = "0x184C12170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public IOEBHBCOCDK(Span<object> ICCNHBNAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4C11F20", Offset = "0x4C10F20", VA = "0x184C11F20")]
	public IOEBHBCOCDK<T> DHOEGPHJJLP(int IPAELMFFKOA)
	{
		return default(IOEBHBCOCDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4C11FF0", Offset = "0x4C10FF0", VA = "0x184C11FF0")]
	public IOEBHBCOCDK<T> DHOEGPHJJLP(int IPAELMFFKOA, int DDGBDMFPMAI)
	{
		return default(IOEBHBCOCDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4C121E0", Offset = "0x4C111E0", VA = "0x184C121E0")]
	public void PNJIDJCBNNF(IOEBHBCOCDK<T> EPEMIKPCAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4C12240", Offset = "0x4C11240", VA = "0x184C12240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4C120D0", Offset = "0x4C110D0", VA = "0x184C120D0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4C12120", Offset = "0x4C11120", VA = "0x184C12120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct EIOEEPICKHB : IEquatable<EIOEEPICKHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int LLPAIMMACAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int JAALIADHHOC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PFBGAKLJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0560", Offset = "0x2DDF560", VA = "0x182DE0560")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6E779C0", Offset = "0x6E769C0", VA = "0x186E779C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int HHLMEECNBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DCICOKIGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C62330", Offset = "0x7C61330", VA = "0x187C62330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7C62340", Offset = "0x7C61340", VA = "0x187C62340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public (int begin, int end) KBFNKDGLBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C62350", Offset = "0x7C61350", VA = "0x187C62350")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
	private EIOEEPICKHB(int LLPAIMMACAP, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x27A5450", Offset = "0x27A4450", VA = "0x1827A5450")]
	public static EIOEEPICKHB BGHKJDKNPHC(int LLPAIMMACAP, int JAALIADHHOC)
	{
		return default(EIOEEPICKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7C62440", Offset = "0x7C61440", VA = "0x187C62440")]
	public static EIOEEPICKHB FHNMMLMFCGK(int IPAELMFFKOA, int LLDMNGOPBOL)
	{
		return default(EIOEEPICKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C62450", Offset = "0x7C61450", VA = "0x187C62450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xEE20C0", Offset = "0xEE10C0", VA = "0x180EE20C0", Slot = "4")]
	public bool Equals(EIOEEPICKHB MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7C623B0", Offset = "0x7C613B0", VA = "0x187C623B0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9E70", Offset = "0x6FD8E70", VA = "0x186FD9E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct OGAFPOEDADH<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
	public OGAFPOEDADH(NativeArray<T> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x55160F0", Offset = "0x55150F0", VA = "0x1855160F0", Slot = "6")]
	public int Compare(int CEJAAIDLEPA, int IMNDAJIDDFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55161E0", Offset = "0x55151E0", VA = "0x1855161E0", Slot = "4")]
	public bool Equals(int CEJAAIDLEPA, int IMNDAJIDDFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x55162D0", Offset = "0x55152D0", VA = "0x1855162D0", Slot = "5")]
	public int GetHashCode(int CEJAAIDLEPA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KBKPKDPDPCB
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x38D6280", Offset = "0x38D5280", VA = "0x1838D6280")]
	public static T[] OOKNDGLJJPG<T>(List<T> OLEDHEBBJPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct EGHOIOJJHEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* KIDAPGAHABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle PLNGHIEJFBN;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5A94530", Offset = "0x5A93530", VA = "0x185A94530")]
	public void NNOHEEPCFHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class PEBNINJNAEF
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x39F27C0", Offset = "0x39F17C0", VA = "0x1839F27C0")]
	public static EGHOIOJJHEE DGBBDKEKCMM<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> DHPEMHCCIBM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(EGHOIOJJHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x39F27C0", Offset = "0x39F17C0", VA = "0x1839F27C0")]
	public static UnsafeParallelHashMap<TKey, TValue> FMCHJMCPGLK<TKey, TValue>(this EGHOIOJJHEE DHPEMHCCIBM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GGNPJJDPNHO
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x385C410", Offset = "0x385B410", VA = "0x18385C410")]
	public static int BFDJAHJGIPO<T>(ReadOnlySpan<T> GBIPICANJDM, ReadOnlySpan<T> PLGDMDDFJEF, int DDGBDMFPMAI) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class KMDJBOABELG
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x38F3250", Offset = "0x38F2250", VA = "0x1838F3250")]
	public static T NPNJAONMOHB<T>(this NativeArray<byte> KIDPOMGFMKB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x38F2E30", Offset = "0x38F1E30", VA = "0x1838F2E30")]
	public static NativeArray<T> JKKGILIGMEE<T>(this NativeArray<byte> KIDPOMGFMKB, int JAALIADHHOC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x38F2BA0", Offset = "0x38F1BA0", VA = "0x1838F2BA0")]
	public static void FOKICFNDJFF<T>(this NativeList<byte> ELDDEEODOKE, [In] T OHLIHBDBKCE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x38F2C50", Offset = "0x38F1C50", VA = "0x1838F2C50")]
	public static void FOKICFNDJFF<T>(this NativeList<byte> ELDDEEODOKE, NativeArray<T> OHLIHBDBKCE) where T : struct
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

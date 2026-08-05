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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2EAF0", Offset = "0x7C2D0F0", VA = "0x187C2EAF0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x39BA660", Offset = "0x39B8C60", VA = "0x1839BA660")]
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
		[Cpp2IlInjected.Address(RVA = "0x39BB510", Offset = "0x39B9B10", VA = "0x1839BB510")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x39BA730", Offset = "0x39B8D30", VA = "0x1839BA730")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x39BA7F0", Offset = "0x39B8DF0", VA = "0x1839BA7F0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x39C5620", Offset = "0x39C3C20", VA = "0x1839C5620")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x39C5330", Offset = "0x39C3930", VA = "0x1839C5330")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x39C54E0", Offset = "0x39C3AE0", VA = "0x1839C54E0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x39C5D10", Offset = "0x39C4310", VA = "0x1839C5D10")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x39BBD00", Offset = "0x39BA300", VA = "0x1839BBD00")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x39BBC90", Offset = "0x39BA290", VA = "0x1839BBC90")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x39BC280", Offset = "0x39BA880", VA = "0x1839BC280")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, EIOEEPICKHB range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x39BC2C0", Offset = "0x39BA8C0", VA = "0x1839BC2C0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x39BC0F0", Offset = "0x39BA6F0", VA = "0x1839BC0F0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x39C5420", Offset = "0x39C3A20", VA = "0x1839C5420")]
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
		[Cpp2IlInjected.Address(RVA = "0x39C5E00", Offset = "0x39C4400", VA = "0x1839C5E00")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x39C7CB0", Offset = "0x39C62B0", VA = "0x1839C7CB0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39C7CC0", Offset = "0x39C62C0", VA = "0x1839C7CC0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A410E0", Offset = "0x6A3F6E0", VA = "0x186A410E0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F1A0", Offset = "0x7C2D7A0", VA = "0x187C2F1A0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F1D0", Offset = "0x7C2D7D0", VA = "0x187C2F1D0")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x39C70A0", Offset = "0x39C56A0", VA = "0x1839C70A0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x39C7240", Offset = "0x39C5840", VA = "0x1839C7240")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39C74B0", Offset = "0x39C5AB0", VA = "0x1839C74B0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x39C70D0", Offset = "0x39C56D0", VA = "0x1839C70D0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x39C7460", Offset = "0x39C5A60", VA = "0x1839C7460")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39C71A0", Offset = "0x39C57A0", VA = "0x1839C71A0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39C7830", Offset = "0x39C5E30", VA = "0x1839C7830")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x39C7690", Offset = "0x39C5C90", VA = "0x1839C7690")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39C7290", Offset = "0x39C5890", VA = "0x1839C7290")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x39C7040", Offset = "0x39C5640", VA = "0x1839C7040")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39C7020", Offset = "0x39C5620", VA = "0x1839C7020")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39C80E0", Offset = "0x39C66E0", VA = "0x1839C80E0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39C7D10", Offset = "0x39C6310", VA = "0x1839C7D10")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39C8110", Offset = "0x39C6710", VA = "0x1839C8110")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39C81D0", Offset = "0x39C67D0", VA = "0x1839C81D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4AFBC30", Offset = "0x4AFA230", VA = "0x184AFBC30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xDA6E90", Offset = "0xDA5490", VA = "0x180DA6E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x50C5320", Offset = "0x50C3920", VA = "0x1850C5320")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x542B0B0", Offset = "0x54296B0", VA = "0x18542B0B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x542B4B0", Offset = "0x5429AB0", VA = "0x18542B4B0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E05180", Offset = "0x3E03780", VA = "0x183E05180")]
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
			[Cpp2IlInjected.Address(RVA = "0x547C5E0", Offset = "0x547ABE0", VA = "0x18547C5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x547C620", Offset = "0x547AC20", VA = "0x18547C620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50C5320", Offset = "0x50C3920", VA = "0x1850C5320")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x547C240", Offset = "0x547A840", VA = "0x18547C240")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x547C380", Offset = "0x547A980", VA = "0x18547C380")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x547C540", Offset = "0x547AB40", VA = "0x18547C540", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x547C480", Offset = "0x547AA80", VA = "0x18547C480")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C2DF80", Offset = "0x7C2C580", VA = "0x187C2DF80")]
	public static JobHandle FPGGJNLFLIH(this JobHandle FDJHCIBLFFB, JobHandle CNIMJCCKEDM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DFC0", Offset = "0x7C2C5C0", VA = "0x187C2DFC0")]
	public static JobHandle NFDEIIAHBAC(this Span<JobHandle> LPJEPOMELAF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PIFCDFHHJAE
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34DFCE0", Offset = "0x34DE2E0", VA = "0x1834DFCE0")]
	public static void INBDHNEFJBE<T>(this T[] NBBLCIBNPBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HNDDJHLLIBF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x388AC40", Offset = "0x3889240", VA = "0x18388AC40")]
	public static NativeKeyValueArrays<TKey, TValue> EBJLEFALMNB<TKey, TValue>(this Dictionary<TKey, TValue> BCFIBNCLPAG, Allocator NDFENJBGNOB) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DHOBCPFPCOP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DB70", Offset = "0x7C2C170", VA = "0x187C2DB70")]
	public static void DOGCOHFFAJC(this GameObject CEKGANCAJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DC10", Offset = "0x7C2C210", VA = "0x187C2DC10")]
	public static void DOGCOHFFAJC(this Component HABFEKNHDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DAD0", Offset = "0x7C2C0D0", VA = "0x187C2DAD0")]
	public static void DOGCOHFFAJC(this ScriptableObject LHACFNGANGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NNGGLPFNOLE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F120", Offset = "0x7C2D720", VA = "0x187C2F120")]
	public static void FONMAMFNLDF(this NativeList<byte> OLEDHEBBJPH, ReadOnlySpan<byte> ICCNHBNAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x39B6900", Offset = "0x39B4F00", VA = "0x1839B6900")]
	public static void DICGBPFJDFK<T>(this NativeList<T> OLEDHEBBJPH, T OHLIHBDBKCE, int JAALIADHHOC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BHEKHMGAIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35E2520", Offset = "0x35E0B20", VA = "0x1835E2520")]
	public static T PELDKDDJIOK<T>(this ReadOnlySpan<byte> OHLIHBDBKCE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35E2210", Offset = "0x35E0810", VA = "0x1835E2210")]
	public static T EKDKJIDEBEH<T>(this Span<T> ICCNHBNAAFG, Func<T, bool> PMLBLGEPBDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35E2370", Offset = "0x35E0970", VA = "0x1835E2370")]
	public static bool JBMMPJAGPJN<T>(this Span<T> ICCNHBNAAFG, Func<T, bool> PMLBLGEPBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35E1C50", Offset = "0x35E0250", VA = "0x1835E1C50")]
	public static bool AMMCPDCIEJN<T>(this Span<T> ICCNHBNAAFG, Func<T, bool> PMLBLGEPBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35E2760", Offset = "0x35E0D60", VA = "0x1835E2760")]
	public static T PHDCGNDDLGA<T>([In] this ReadOnlySpan<byte> ICCNHBNAAFG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35BBE60", Offset = "0x35BA460", VA = "0x1835BBE60")]
	public static Span<TTo> MJIANAMKMJD<TTo, TFrom>(this Span<TFrom> ICCNHBNAAFG) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35BBE60", Offset = "0x35BA460", VA = "0x1835BBE60")]
	public static ReadOnlySpan<TTo> MJIANAMKMJD<TTo, TFrom>(this ReadOnlySpan<TFrom> ICCNHBNAAFG) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x35BBE60", Offset = "0x35BA460", VA = "0x1835BBE60")]
	public static ReadOnlySpan<TTo> MJIANAMKMJD<TTo>(this ReadOnlySpan<byte> ICCNHBNAAFG) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35E2420", Offset = "0x35E0A20", VA = "0x1835E2420")]
	public static Span<T> OKKBPPIELHH<T>(this ReadOnlySpan<T> KIDPOMGFMKB) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35E1D00", Offset = "0x35E0300", VA = "0x1835E1D00")]
	public static Span<byte> DGBNDJBCMEF<T>([In] this Span<byte> ICCNHBNAAFG, T OHLIHBDBKCE) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C2D4B0", Offset = "0x7C2BAB0", VA = "0x187C2D4B0")]
	private static Enum LMHPFKNPAFJ([In] ReadOnlySpan<byte> ICCNHBNAAFG, Type NNODEEMKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DA60", Offset = "0x7C2C060", VA = "0x187C2DA60")]
	public static Enum ONFGOEPLDDN([In] this Span<byte> ICCNHBNAAFG, Type NNODEEMKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2CFD0", Offset = "0x7C2B5D0", VA = "0x187C2CFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2CE50", Offset = "0x7C2B450", VA = "0x187C2CE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DE60", Offset = "0x7C2C460", VA = "0x187C2DE60")]
	[AsyncStateMachine(typeof(ALOOCDNJOMN))]
	public static void AFCEBPDGNMM(this Task LEMBKBGMCDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OLCPNIOFOHC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x39F4C60", Offset = "0x39F3260", VA = "0x1839F4C60")]
	public static NativeArray<T> JIOMOOCKKND<T>(this UnsafeList<T> OLEDHEBBJPH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x39F4BE0", Offset = "0x39F31E0", VA = "0x1839F4BE0")]
	public static NativeArray<T> FNFLPDDAKGG<T>(this UnsafeList<T> OLEDHEBBJPH, bool IBIHDDIPMBP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39F4CC0", Offset = "0x39F32C0", VA = "0x1839F4CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DD6C20", Offset = "0x2DD5220", VA = "0x182DD6C20")]
		public HIJHDIGIKBE(MBONJAHPDHF OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory BMEHNMPPGJP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	public static void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E7F0", Offset = "0x7C2CDF0", VA = "0x187C2E7F0")]
	static JGBFMNCONFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34EC7D0", Offset = "0x34EADD0", VA = "0x1834EC7D0")]
	public static HIJHDIGIKBE MPJFCCLMDOB(MBONJAHPDHF OEHHKNIGGMI)
	{
		return default(HIJHDIGIKBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	public static void IKLKFHLMHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MMOMCGDDPJE
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3942860", Offset = "0x3940E60", VA = "0x183942860")]
	public static ANFOGDGHFKE<T1, T2> IPBDIILNIAL<T1, T2>(this (T1, T2) DAPCBFLAHDI) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(ANFOGDGHFKE<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3942880", Offset = "0x3940E80", VA = "0x183942880")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F591C0", Offset = "0x4F577C0", VA = "0x184F591C0")]
	public ANFOGDGHFKE((T1, T2) DAPCBFLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4F58D00", Offset = "0x4F57300", VA = "0x184F58D00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E73A30", Offset = "0x4E72030", VA = "0x184E73A30")]
	public JDNEIIIODIF((T1, T2, T3) DAPCBFLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E73990", Offset = "0x4E71F90", VA = "0x184E73990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IKDONFCINFK
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E1A0", Offset = "0x7C2C7A0", VA = "0x187C2E1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E080", Offset = "0x7C2C680", VA = "0x187C2E080")]
		public HJHBDCKJOPN(int IPAELMFFKOA, int LLDMNGOPBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E070", Offset = "0x7C2C670", VA = "0x187C2E070")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E200", Offset = "0x7C2C800", VA = "0x187C2E200")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A41110", Offset = "0x6A3F710", VA = "0x186A41110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A40ED0", Offset = "0x6A3F4D0", VA = "0x186A40ED0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A413D0", Offset = "0x6A3F9D0", VA = "0x186A413D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A416D0", Offset = "0x6A3FCD0", VA = "0x186A416D0")]
	public DINIMJBJPAM(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A410E0", Offset = "0x6A3F6E0", VA = "0x186A410E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x560DBF0", Offset = "0x560C1F0", VA = "0x18560DBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x560E8D0", Offset = "0x560CED0", VA = "0x18560E8D0")]
	public PEBNEEMIANK(Action<TValue> MIFONHGHFAE, [Optional] Func<TValue> NIPILOBJGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x560DE90", Offset = "0x560C490", VA = "0x18560DE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x560E090", Offset = "0x560C690", VA = "0x18560E090")]
	public THandle IIGLPCDPOEE(TValue OHLIHBDBKCE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x560DF60", Offset = "0x560C560", VA = "0x18560DF60")]
	public bool HMHHJKJOIHP(THandle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x560E370", Offset = "0x560C970", VA = "0x18560E370")]
	public bool LEDEGLNAGAD(THandle BOJCEMEJOMP, [Out] TValue OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x560E880", Offset = "0x560CE80", VA = "0x18560E880")]
	public TValue PHDCGNDDLGA(THandle BOJCEMEJOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x560E700", Offset = "0x560CD00", VA = "0x18560E700")]
	public bool NOMOJCGANNC(THandle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x560E820", Offset = "0x560CE20", VA = "0x18560E820")]
	private THandle OHNOFFLEJLC(int OHHMJGCBCKD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x560E4F0", Offset = "0x560CAF0", VA = "0x18560E4F0")]
	private TValue LNLLCGCJJDK(int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x560DC30", Offset = "0x560C230", VA = "0x18560DC30")]
	private void AOPFKHIPNIJ(int OHHMJGCBCKD, [In] THandle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x560DE30", Offset = "0x560C430", VA = "0x18560DE30")]
	private void DKFJJBJKAHH(int OHHMJGCBCKD, [In] TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x560E550", Offset = "0x560CB50", VA = "0x18560E550")]
	private THandle MOMCNJLLCCH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x560E130", Offset = "0x560C730", VA = "0x18560E130")]
	private void JAGFMLGGMFD(THandle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x560E810", Offset = "0x560CE10", VA = "0x18560E810")]
	private int OBJINEPDOEG(int DJNGLBELENN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x560DE80", Offset = "0x560C480", VA = "0x18560DE80")]
	private bool DLKLDKCBIBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EEE00", VA = "0x1809F0800")]
	private void ODOBMJKJABM(THandle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x560E440", Offset = "0x560CA40", VA = "0x18560E440")]
	private bool LHOHIJHAENN([Out] THandle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x560E240", Offset = "0x560C840", VA = "0x18560E240")]
	private bool LDDLKBDDNDJ([Out] THandle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x560DC80", Offset = "0x560C280", VA = "0x18560DC80")]
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
	[Cpp2IlInjected.Address(RVA = "0x388B250", Offset = "0x3889850", VA = "0x18388B250")]
	public static bool KDGLHGAKIGH<T>(this T BOJCEMEJOMP, T MIJLJBIHDMP) where T : struct, PMKOIOKBFCO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x388B270", Offset = "0x3889870", VA = "0x18388B270")]
	public static bool LKIDIFGHMGH<T>(this T BOJCEMEJOMP) where T : struct, PMKOIOKBFCO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E090", Offset = "0x7C2C690", VA = "0x187C2E090")]
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
	[Cpp2IlInjected.Address(RVA = "0x50C5840", Offset = "0x50C3E40", VA = "0x1850C5840")]
	public NBDNAFKNLDM(Type MKOBJJFHGND, Span<byte> ICCNHBNAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x39A3AB0", Offset = "0x39A20B0", VA = "0x1839A3AB0")]
	public static NBDNAFKNLDM ECGNHAOMACM<T>(T OHLIHBDBKCE) where T : struct
	{
		return default(NBDNAFKNLDM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F020", Offset = "0x7C2D620", VA = "0x187C2F020")]
	public static JBPLEEKMCJK OIFHDJNIHDL([In] NBDNAFKNLDM NFFBJCCKPJF)
	{
		return default(JBPLEEKMCJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F0A0", Offset = "0x7C2D6A0", VA = "0x187C2F0A0")]
	public Enum ONFGOEPLDDN(Type NNODEEMKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x39A3A70", Offset = "0x39A2070", VA = "0x1839A3A70")]
	public void DGBNDJBCMEF<T>([In] T OHLIHBDBKCE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F010", Offset = "0x7C2D610", VA = "0x187C2F010")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2E660", Offset = "0x7C2CC60", VA = "0x187C2E660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OOKCMKIEOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E440", Offset = "0x7C2CA40", VA = "0x187C2E440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x50C5840", Offset = "0x50C3E40", VA = "0x1850C5840")]
	public JBPLEEKMCJK(Type MKOBJJFHGND, ReadOnlySpan<byte> ICCNHBNAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38BE2D0", Offset = "0x38BC8D0", VA = "0x1838BE2D0")]
	public static JBPLEEKMCJK ECGNHAOMACM<T>(T OHLIHBDBKCE) where T : struct
	{
		return default(JBPLEEKMCJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E670", Offset = "0x7C2CC70", VA = "0x187C2E670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E490", Offset = "0x7C2CA90", VA = "0x187C2E490")]
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
	[Cpp2IlInjected.Address(RVA = "0x38BE1C0", Offset = "0x38BC7C0", VA = "0x1838BE1C0")]
	public static NativeArray<T> ECGNHAOMACM<T>(T OHLIHBDBKCE, bool IBIHDDIPMBP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38BE170", Offset = "0x38BC770", VA = "0x1838BE170")]
	public static NativeArray<T> AJHHGMCFPGA<T>(T OHLIHBDBKCE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38BE210", Offset = "0x38BC810", VA = "0x1838BE210")]
	public static NativeArray<T> HJMCEKEBOGL<T>(T OHLIHBDBKCE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E380", Offset = "0x7C2C980", VA = "0x187C2E380")]
	public static NativeArray<byte> HJMCEKEBOGL(ReadOnlySpan<byte> OHLIHBDBKCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E250", Offset = "0x7C2C850", VA = "0x187C2E250")]
	public static NativeArray<byte> ECGNHAOMACM(ReadOnlySpan<byte> OHLIHBDBKCE, bool IBIHDDIPMBP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E300", Offset = "0x7C2C900", VA = "0x187C2E300")]
	public unsafe static NativeArray<byte> ECGNHAOMACM(byte* DIPLOKEAIKB, int DDGBDMFPMAI, bool IBIHDDIPMBP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38BE260", Offset = "0x38BC860", VA = "0x1838BE260")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2E8D0", Offset = "0x7C2CED0", VA = "0x187C2E8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EA50", Offset = "0x7C2D050", VA = "0x187C2EA50")]
	public LIIAANKIMBN(Type MLCOGCMJLBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E980", Offset = "0x7C2CF80", VA = "0x187C2E980")]
	public static LIIAANKIMBN OIFHDJNIHDL(Type MLCOGCMJLBB)
	{
		return default(LIIAANKIMBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2151FC0", Offset = "0x21505C0", VA = "0x182151FC0", Slot = "4")]
	public bool Equals(LIIAANKIMBN MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E850", Offset = "0x7C2CE50", VA = "0x187C2E850", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EA10", Offset = "0x7C2D010", VA = "0x187C2EA10", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C2EE90", Offset = "0x7C2D490", VA = "0x187C2EE90")]
	static MHKPAEABHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EBE0", Offset = "0x7C2D1E0", VA = "0x187C2EBE0")]
	public static bool IIGLPCDPOEE(Type MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EC40", Offset = "0x7C2D240", VA = "0x187C2EC40")]
	private static bool IIGLPCDPOEE(Type MLCOGCMJLBB, [Out] int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EB80", Offset = "0x7C2D180", VA = "0x187C2EB80")]
	public static int DJBJOAFCKAH(Type MLCOGCMJLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EE10", Offset = "0x7C2D410", VA = "0x187C2EE10")]
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
			[Cpp2IlInjected.Address(RVA = "0x499D0D0", Offset = "0x499B6D0", VA = "0x18499D0D0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x499D540", Offset = "0x499BB40", VA = "0x18499D540")]
		public FFPJOPNBKPL(BDKIHAAKCFG<Handle> CNODPANFMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x499CED0", Offset = "0x499B4D0", VA = "0x18499CED0")]
		public MNOKIOEPDJM ACADPGMDEBE([In] MNOKIOEPDJM COFBNOFIHKI)
		{
			return default(MNOKIOEPDJM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x499D420", Offset = "0x499BA20", VA = "0x18499D420")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x499D2A0", Offset = "0x499B8A0", VA = "0x18499D2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5376630", Offset = "0x5374C30", VA = "0x185376630")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5376760", Offset = "0x5374D60", VA = "0x185376760")]
		public MNOKIOEPDJM(BDKIHAAKCFG<Handle> CNODPANFMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5376720", Offset = "0x5374D20", VA = "0x185376720")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5376670", Offset = "0x5374C70", VA = "0x185376670")]
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
		[Cpp2IlInjected.Address(RVA = "0x614F320", Offset = "0x614D920", VA = "0x18614F320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MNOKIOEPDJM LGHPBCEONLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x614F830", Offset = "0x614DE30", VA = "0x18614F830")]
		get
		{
			return default(MNOKIOEPDJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61509F0", Offset = "0x614EFF0", VA = "0x1861509F0")]
	public BDKIHAAKCFG(int HNDEALABJHB, Allocator NDFENJBGNOB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6150230", Offset = "0x614E830", VA = "0x186150230")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x20D0AE0", Offset = "0x20CF0E0", VA = "0x1820D0AE0")]
	public static int OBJINEPDOEG(int IINHKHEMEHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DEFD90", Offset = "0x2DEE390", VA = "0x182DEFD90")]
	public static bool MOAAONALADM(int IINHKHEMEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x614F510", Offset = "0x614DB10", VA = "0x18614F510")]
	public bool FEKCOKLOFMJ(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x614F8C0", Offset = "0x614DEC0", VA = "0x18614F8C0")]
	public bool JNCAOECEFKD(Handle BOJCEMEJOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x614FD10", Offset = "0x614E310", VA = "0x18614FD10")]
	public Handle KNBPJIPPCJC()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61506E0", Offset = "0x614ECE0", VA = "0x1861506E0")]
	public void OOPCMCKFHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x614EF50", Offset = "0x614D550", VA = "0x18614EF50")]
	public void ALPHNEPABOE(Handle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0")]
	private bool OAGCHIGJFFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x614F7D0", Offset = "0x614DDD0", VA = "0x18614F7D0")]
	private bool GIDLKDHDBGC(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x614FEB0", Offset = "0x614E4B0", VA = "0x18614FEB0")]
	private void MJMKMMJAIMM([Out] int OHHMJGCBCKD, [Out] int DJNGLBELENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x614F190", Offset = "0x614D790", VA = "0x18614F190")]
	private void BFJFHCGJHBG(Handle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6150190", Offset = "0x614E790", VA = "0x186150190")]
	private void NLNALAEIKLL(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x614FC60", Offset = "0x614E260", VA = "0x18614FC60")]
	private bool JOKLEGIFMMP([Out] int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614D960", VA = "0x18614F360")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F94990", Offset = "0x4F92F90", VA = "0x184F94990")]
	public KEAENKDOBJK(int HNDEALABJHB, [Optional] Action<T> AJBEMMOIIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F948B0", Offset = "0x4F92EB0", VA = "0x184F948B0")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F946C0", Offset = "0x4F92CC0", VA = "0x184F946C0")]
	public bool LEDEGLNAGAD(Handle BOJCEMEJOMP, [Out] T BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F944F0", Offset = "0x4F92AF0", VA = "0x184F944F0")]
	public Handle IIGLPCDPOEE(T BOMDCGFKGKF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F93C00", Offset = "0x4F92200", VA = "0x184F93C00")]
	public void DPGGDFHGCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F94220", Offset = "0x4F92820", VA = "0x184F94220")]
	public void GNAALOCCJEL(Handle BOJCEMEJOMP, [Out] T OFOGECGDEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F94060", Offset = "0x4F92660", VA = "0x184F94060")]
	public void GNAALOCCJEL(Handle BOJCEMEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F94930", Offset = "0x4F92F30", VA = "0x184F94930")]
	private T PCPGCJBCFNA(int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F94770", Offset = "0x4F92D70", VA = "0x184F94770")]
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
			[Cpp2IlInjected.Address(RVA = "0x4AA7F10", Offset = "0x4AA6510", VA = "0x184AA7F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27BA120", Offset = "0x27B8720", VA = "0x1827BA120")]
		public GCICOOEMNJJ(KOGLLFEDMCC<T> NBBLCIBNPBK, int OHHMJGCBCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4AA7F60", Offset = "0x4AA6560", VA = "0x184AA7F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public NIAFNOJJCGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x53F8EF0", Offset = "0x53F74F0", VA = "0x1853F8EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x53F8F90", Offset = "0x53F7590", VA = "0x1853F8F90", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public MEHKPMALGIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5343A10", Offset = "0x5342010", VA = "0x185343A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5343AB0", Offset = "0x53420B0", VA = "0x185343AB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5020A60", Offset = "0x501F060", VA = "0x185020A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5020C90", Offset = "0x501F290", VA = "0x185020C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x172C280", Offset = "0x172A880", VA = "0x18172C280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool NIJMEBKDACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5020970", Offset = "0x501EF70", VA = "0x185020970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IOEBHBCOCDK<T> PJGJPCHJDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5020770", Offset = "0x501ED70", VA = "0x185020770")]
		get
		{
			return default(IOEBHBCOCDK<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5020280", Offset = "0x501E880", VA = "0x185020280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5020B10", Offset = "0x501F110", VA = "0x185020B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5020F30", Offset = "0x501F530", VA = "0x185020F30")]
	internal KOGLLFEDMCC(KOGLLFEDMCC<T> NBBLCIBNPBK, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5020F10", Offset = "0x501F510", VA = "0x185020F10")]
	private KOGLLFEDMCC(T[] NBBLCIBNPBK, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5020F50", Offset = "0x501F550", VA = "0x185020F50")]
	public KOGLLFEDMCC(IEnumerable<T> DHLGAIMCINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5020EA0", Offset = "0x501F4A0", VA = "0x185020EA0")]
	public KOGLLFEDMCC(int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x50208F0", Offset = "0x501EEF0", VA = "0x1850208F0")]
	public int KBEMGMDGBFE(T OHLIHBDBKCE, int IPAELMFFKOA, int JAALIADHHOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5020240", Offset = "0x501E840", VA = "0x185020240")]
	public void ABGGKEGJDNP(int ADJKIMFDLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x50203D0", Offset = "0x501E9D0", VA = "0x1850203D0")]
	private void GCBHDIPHJML(int ADJKIMFDLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x50205A0", Offset = "0x501EBA0", VA = "0x1850205A0")]
	public T[] GCDNHKGKKKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5020620", Offset = "0x501EC20", VA = "0x185020620")]
	public T[] HGAAFLBNLDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5020350", Offset = "0x501E950", VA = "0x185020350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5020C30", Offset = "0x501F230", VA = "0x185020C30")]
	public void PHJGHJKIEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5020BC0", Offset = "0x501F1C0", VA = "0x185020BC0")]
	public GCICOOEMNJJ OMLAPONJPHN()
	{
		return default(GCICOOEMNJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5020CC0", Offset = "0x501F2C0", VA = "0x185020CC0", Slot = "5")]
	[IteratorStateMachine(typeof(KOGLLFEDMCC<>.NIAFNOJJCGD))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5020DB0", Offset = "0x501F3B0", VA = "0x185020DB0", Slot = "6")]
	[IteratorStateMachine(typeof(KOGLLFEDMCC<>.MEHKPMALGIJ))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5020A00", Offset = "0x501F000", VA = "0x185020A00")]
	public static KOGLLFEDMCC<T> KCAGPEGHBPE(T[] NBBLCIBNPBK)
	{
		return default(KOGLLFEDMCC<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5020A70", Offset = "0x501F070", VA = "0x185020A70")]
	public static KOGLLFEDMCC<T> OIFHDJNIHDL(T[] NBBLCIBNPBK)
	{
		return default(KOGLLFEDMCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5020980", Offset = "0x501EF80", VA = "0x185020980")]
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
			[Cpp2IlInjected.Address(RVA = "0x5150030", Offset = "0x514E630", VA = "0x185150030", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5150070", Offset = "0x514E670", VA = "0x185150070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x45AABC0", Offset = "0x45A91C0", VA = "0x1845AABC0")]
		public LLCIBGPHFDF(IEALDBHBOML<T> OLEDHEBBJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x514FF40", Offset = "0x514E540", VA = "0x18514FF40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x514FFE0", Offset = "0x514E5E0", VA = "0x18514FFE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C2F380", Offset = "0x4C2D980", VA = "0x184C2F380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4ACF810", Offset = "0x4ACDE10", VA = "0x184ACF810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int EFJAAKPECFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C2F4A0", Offset = "0x4C2DAA0", VA = "0x184C2F4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4C2F5A0", Offset = "0x4C2DBA0", VA = "0x184C2F5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IOEBHBCOCDK<T> PJGJPCHJDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C2F9E0", Offset = "0x4C2DFE0", VA = "0x184C2F9E0")]
		get
		{
			return default(IOEBHBCOCDK<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FFF0", Offset = "0x4C2E5F0", VA = "0x184C2FFF0")]
	public IEALDBHBOML(int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D530", Offset = "0x4C2BB30", VA = "0x184C2D530")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F440", Offset = "0x4C2DA40", VA = "0x184C2F440")]
	public KOGLLFEDMCC<T> DHMFHDDCNJK()
	{
		return default(KOGLLFEDMCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F8C0", Offset = "0x4C2DEC0", VA = "0x184C2F8C0")]
	public void IIGLPCDPOEE(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F170", Offset = "0x4C2D770", VA = "0x184C2F170")]
	private void ABGGKEGJDNP(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F5C0", Offset = "0x4C2DBC0", VA = "0x184C2F5C0")]
	public void FONMAMFNLDF(List<T> PFOGKPFJJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F740", Offset = "0x4C2DD40", VA = "0x184C2F740")]
	public void FONMAMFNLDF(T[] PFOGKPFJJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F4C0", Offset = "0x4C2DAC0", VA = "0x184C2F4C0")]
	public void FMOLGLEKKMF(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F1B0", Offset = "0x4C2D7B0", VA = "0x184C2F1B0")]
	public void AFGOFDHLLID(int HACDKCPGBDB, int LLDMNGOPBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FA60", Offset = "0x4C2E060", VA = "0x184C2FA60")]
	public int KBEMGMDGBFE(T OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F3F0", Offset = "0x4C2D9F0", VA = "0x184C2F3F0")]
	public bool DGAEJOHLCDJ(T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F850", Offset = "0x4C2DE50", VA = "0x184C2F850")]
	public T[] HGAAFLBNLDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F480", Offset = "0x4C2DA80", VA = "0x184C2F480", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FD30", Offset = "0x4C2E330", VA = "0x184C2FD30")]
	public static KOGLLFEDMCC<T> OIFHDJNIHDL(IEALDBHBOML<T> OLEDHEBBJPH)
	{
		return default(KOGLLFEDMCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F7E0", Offset = "0x4C2DDE0", VA = "0x184C2F7E0", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FF40", Offset = "0x4C2E540", VA = "0x184C2FF40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FF80", Offset = "0x4C2E580", VA = "0x184C2FF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FDF0", Offset = "0x4C2E3F0", VA = "0x184C2FDF0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void POOJOINHCLF(int OHLIHBDBKCE, int DDGBDMFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FAE0", Offset = "0x4C2E0E0", VA = "0x184C2FAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3884100", Offset = "0x3882700", VA = "0x183884100")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C464B0", Offset = "0x4C44AB0", VA = "0x184C464B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4C467C0", Offset = "0x4C44DC0", VA = "0x184C467C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4C46780", Offset = "0x4C44D80", VA = "0x184C46780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public IOEBHBCOCDK(Span<object> ICCNHBNAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4C46530", Offset = "0x4C44B30", VA = "0x184C46530")]
	public IOEBHBCOCDK<T> DHOEGPHJJLP(int IPAELMFFKOA)
	{
		return default(IOEBHBCOCDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4C46600", Offset = "0x4C44C00", VA = "0x184C46600")]
	public IOEBHBCOCDK<T> DHOEGPHJJLP(int IPAELMFFKOA, int DDGBDMFPMAI)
	{
		return default(IOEBHBCOCDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4C467F0", Offset = "0x4C44DF0", VA = "0x184C467F0")]
	public void PNJIDJCBNNF(IOEBHBCOCDK<T> EPEMIKPCAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4C46850", Offset = "0x4C44E50", VA = "0x184C46850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4C466E0", Offset = "0x4C44CE0", VA = "0x184C466E0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4C46730", Offset = "0x4C44D30", VA = "0x184C46730", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0910", Offset = "0x2DDEF10", VA = "0x182DE0910")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6E50640", Offset = "0x6E4EC40", VA = "0x186E50640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int HHLMEECNBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x12AC0B0", Offset = "0x12AA6B0", VA = "0x1812AC0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DCICOKIGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DCB0", Offset = "0x7C2C2B0", VA = "0x187C2DCB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DCC0", Offset = "0x7C2C2C0", VA = "0x187C2DCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public (int begin, int end) KBFNKDGLBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DCD0", Offset = "0x7C2C2D0", VA = "0x187C2DCD0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xD2E720", Offset = "0xD2CD20", VA = "0x180D2E720")]
	private EIOEEPICKHB(int LLPAIMMACAP, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x27A6010", Offset = "0x27A4610", VA = "0x1827A6010")]
	public static EIOEEPICKHB BGHKJDKNPHC(int LLPAIMMACAP, int JAALIADHHOC)
	{
		return default(EIOEEPICKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DDC0", Offset = "0x7C2C3C0", VA = "0x187C2DDC0")]
	public static EIOEEPICKHB FHNMMLMFCGK(int IPAELMFFKOA, int LLDMNGOPBOL)
	{
		return default(EIOEEPICKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DDD0", Offset = "0x7C2C3D0", VA = "0x187C2DDD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xEF3B10", Offset = "0xEF2110", VA = "0x180EF3B10", Slot = "4")]
	public bool Equals(EIOEEPICKHB MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DD30", Offset = "0x7C2C330", VA = "0x187C2DD30", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1000", Offset = "0x6FAF600", VA = "0x186FB1000", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
	public OGAFPOEDADH(NativeArray<T> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x552B8E0", Offset = "0x5529EE0", VA = "0x18552B8E0", Slot = "6")]
	public int Compare(int CEJAAIDLEPA, int IMNDAJIDDFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x552B9D0", Offset = "0x5529FD0", VA = "0x18552B9D0", Slot = "4")]
	public bool Equals(int CEJAAIDLEPA, int IMNDAJIDDFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x552BAC0", Offset = "0x552A0C0", VA = "0x18552BAC0", Slot = "5")]
	public int GetHashCode(int CEJAAIDLEPA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KBKPKDPDPCB
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x38F4280", Offset = "0x38F2880", VA = "0x1838F4280")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A92730", Offset = "0x5A90D30", VA = "0x185A92730")]
	public void NNOHEEPCFHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class PEBNINJNAEF
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F280", Offset = "0x3A0D880", VA = "0x183A0F280")]
	public static EGHOIOJJHEE DGBBDKEKCMM<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> DHPEMHCCIBM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(EGHOIOJJHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F280", Offset = "0x3A0D880", VA = "0x183A0F280")]
	public static UnsafeParallelHashMap<TKey, TValue> FMCHJMCPGLK<TKey, TValue>(this EGHOIOJJHEE DHPEMHCCIBM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GGNPJJDPNHO
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x387A860", Offset = "0x3878E60", VA = "0x18387A860")]
	public static int BFDJAHJGIPO<T>(ReadOnlySpan<T> GBIPICANJDM, ReadOnlySpan<T> PLGDMDDFJEF, int DDGBDMFPMAI) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class KMDJBOABELG
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3911820", Offset = "0x390FE20", VA = "0x183911820")]
	public static T NPNJAONMOHB<T>(this NativeArray<byte> KIDPOMGFMKB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3911400", Offset = "0x390FA00", VA = "0x183911400")]
	public static NativeArray<T> JKKGILIGMEE<T>(this NativeArray<byte> KIDPOMGFMKB, int JAALIADHHOC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3911170", Offset = "0x390F770", VA = "0x183911170")]
	public static void FOKICFNDJFF<T>(this NativeList<byte> ELDDEEODOKE, [In] T OHLIHBDBKCE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3911220", Offset = "0x390F820", VA = "0x183911220")]
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

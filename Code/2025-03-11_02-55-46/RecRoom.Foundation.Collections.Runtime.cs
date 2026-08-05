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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75E7C70", Offset = "0x75E7070", VA = "0x1875E7C70", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DKKFMDGBBED]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x362C510", Offset = "0x362B910", VA = "0x18362C510")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DKKFMDGBBED]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3634F00", Offset = "0x3634300", VA = "0x183634F00")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3634C10", Offset = "0x3634010", VA = "0x183634C10")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3634DC0", Offset = "0x36341C0", VA = "0x183634DC0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3635590", Offset = "0x3634990", VA = "0x183635590")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x362C5E0", Offset = "0x362B9E0", VA = "0x18362C5E0")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x362C880", Offset = "0x362BC80", VA = "0x18362C880")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x362CBD0", Offset = "0x362BFD0", VA = "0x18362CBD0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, AOIKGLJHPKL range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x362CC10", Offset = "0x362C010", VA = "0x18362CC10")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x362CA40", Offset = "0x362BE40", VA = "0x18362CA40")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3634D00", Offset = "0x3634100", VA = "0x183634D00")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DKKFMDGBBED]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3635800", Offset = "0x3634C00", VA = "0x183635800")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3636C80", Offset = "0x3636080", VA = "0x183636C80")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3635680", Offset = "0x3634A80", VA = "0x183635680")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x36359E0", Offset = "0x3634DE0", VA = "0x1836359E0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3637DD0", Offset = "0x36371D0", VA = "0x183637DD0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3637DE0", Offset = "0x36371E0", VA = "0x183637DE0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4838DB0", Offset = "0x48381B0", VA = "0x184838DB0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75E7F70", Offset = "0x75E7370", VA = "0x1875E7F70")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75E7FA0", Offset = "0x75E73A0", VA = "0x1875E7FA0")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x36374A0", Offset = "0x36368A0", VA = "0x1836374A0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3637380", Offset = "0x3636780", VA = "0x183637380")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3637650", Offset = "0x3636A50", VA = "0x183637650")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x36373D0", Offset = "0x36367D0", VA = "0x1836373D0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3637600", Offset = "0x3636A00", VA = "0x183637600")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3637850", Offset = "0x3636C50", VA = "0x183637850")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3637920", Offset = "0x3636D20", VA = "0x183637920")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3637780", Offset = "0x3636B80", VA = "0x183637780")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3637300", Offset = "0x3636700", VA = "0x183637300")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x36372A0", Offset = "0x36366A0", VA = "0x1836372A0")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3637280", Offset = "0x3636680", VA = "0x183637280")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3638200", Offset = "0x3637600", VA = "0x183638200")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3637E30", Offset = "0x3637230", VA = "0x183637E30")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3638230", Offset = "0x3637630", VA = "0x183638230")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x36382F0", Offset = "0x36376F0", VA = "0x1836382F0")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DKKFMDGBBED]
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
			[Cpp2IlInjected.Address(RVA = "0x470E350", Offset = "0x470D750", VA = "0x18470E350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x25BC6E0", Offset = "0x25BBAE0", VA = "0x1825BC6E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB40EA0", Offset = "0xB402A0", VA = "0x180B40EA0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4BA53A0", Offset = "0x4BA47A0", VA = "0x184BA53A0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1040", Offset = "0x4EA0440", VA = "0x184EA1040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0CD0", Offset = "0x4EA00D0", VA = "0x184EA0CD0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39AC690", Offset = "0x39ABA90", VA = "0x1839AC690")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DKKFMDGBBED]
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
			[Cpp2IlInjected.Address(RVA = "0x4F03590", Offset = "0x4F02990", VA = "0x184F03590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4F035D0", Offset = "0x4F029D0", VA = "0x184F035D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB40EA0", Offset = "0xB402A0", VA = "0x180B40EA0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4BA53A0", Offset = "0x4BA47A0", VA = "0x184BA53A0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4F031F0", Offset = "0x4F025F0", VA = "0x184F031F0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4F03330", Offset = "0x4F02730", VA = "0x184F03330")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4F03370", Offset = "0x4F02770", VA = "0x184F03370", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4F03410", Offset = "0x4F02810", VA = "0x184F03410")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DKKFMDGBBED]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DKKFMDGBBED]
public static class NENNEKBFPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x75E7F30", Offset = "0x75E7330", VA = "0x1875E7F30")]
	public static JobHandle JJDAIGCPLKL(this JobHandle FJLJDCJDABK, JobHandle DOGHGFGEHNK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x75E7E80", Offset = "0x75E7280", VA = "0x1875E7E80")]
	public static JobHandle CPEIPFIIEBB(this Span<JobHandle> OHJJNNCOGMN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OLNEAHDCABO
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x365E870", Offset = "0x365DC70", VA = "0x18365E870")]
	public static NativeKeyValueArrays<TKey, TValue> JDCLDBPEPJI<TKey, TValue>(this Dictionary<TKey, TValue> EHAMKEJBOAG, Allocator FALBINAEKDG) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LCCHMLFIGHG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x75E7BD0", Offset = "0x75E6FD0", VA = "0x1875E7BD0")]
	public static void DJFFPNFBBOG(this GameObject IIKFCCENKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x75E7B30", Offset = "0x75E6F30", VA = "0x1875E7B30")]
	public static void DJFFPNFBBOG(this Component LENGNFMPCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x75E7A90", Offset = "0x75E6E90", VA = "0x1875E7A90")]
	public static void DJFFPNFBBOG(this ScriptableObject FILFFHAMNHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class APFOMHAHCFM
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75E69E0", Offset = "0x75E5DE0", VA = "0x1875E69E0")]
	public static void FFIEOJBCHCJ(this NativeList<byte> DBJKHFJBKPC, ReadOnlySpan<byte> OLAHHEDJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1250", Offset = "0x3BD0650", VA = "0x183BD1250")]
	public static void MPAKADKPPEN<T>(this NativeList<T> DBJKHFJBKPC, T PEBNJNGMMHE, int LOHPPDCIAAL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GFFAAKLINNO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x34AF2C0", Offset = "0x34AE6C0", VA = "0x1834AF2C0")]
	public static T KDLLEGJFPLC<T>(this ReadOnlySpan<byte> PEBNJNGMMHE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x34AE700", Offset = "0x34ADB00", VA = "0x1834AE700")]
	public static T EBMLPCGDLCG<T>(this Span<T> OLAHHEDJOLN, Func<T, bool> GMHGBGHLFMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34AF4C0", Offset = "0x34AE8C0", VA = "0x1834AF4C0")]
	public static bool KMKKDOPEGHM<T>(this Span<T> OLAHHEDJOLN, Func<T, bool> GMHGBGHLFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34AF570", Offset = "0x34AE970", VA = "0x1834AF570")]
	public static bool MEFGNNMFJGO<T>(this Span<T> OLAHHEDJOLN, Func<T, bool> GMHGBGHLFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x34AE860", Offset = "0x34ADC60", VA = "0x1834AE860")]
	public static T FCPELJIOJPN<T>([In] this ReadOnlySpan<byte> OLAHHEDJOLN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x32D6760", Offset = "0x32D5B60", VA = "0x1832D6760")]
	public static Span<TTo> FHEMONIIPDN<TTo, TFrom>(this Span<TFrom> OLAHHEDJOLN) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x32D6760", Offset = "0x32D5B60", VA = "0x1832D6760")]
	public static ReadOnlySpan<TTo> FHEMONIIPDN<TTo, TFrom>(this ReadOnlySpan<TFrom> OLAHHEDJOLN) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x32D6760", Offset = "0x32D5B60", VA = "0x1832D6760")]
	public static ReadOnlySpan<TTo> FHEMONIIPDN<TTo>(this ReadOnlySpan<byte> OLAHHEDJOLN) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x34AEDB0", Offset = "0x34AE1B0", VA = "0x1834AEDB0")]
	public static Span<byte> FHPKMMCODGE<T>([In] this Span<byte> OLAHHEDJOLN, T PEBNJNGMMHE) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x75E6DC0", Offset = "0x75E61C0", VA = "0x1875E6DC0")]
	private static Enum EFNKGLPAIFC([In] ReadOnlySpan<byte> OLAHHEDJOLN, Type LMBFCHFPOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x75E7370", Offset = "0x75E6770", VA = "0x1875E7370")]
	public static Enum OFELFIPDDBG([In] this Span<byte> OLAHHEDJOLN, Type LMBFCHFPOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75E73E0", Offset = "0x75E67E0", VA = "0x1875E73E0")]
	public static void PGGJMOCPIBM([In] this Span<byte> OLAHHEDJOLN, Enum BJDHLMBEIKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GKPDMOGFBJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NAIKAMMEIHC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75E7D00", Offset = "0x75E7100", VA = "0x1875E7D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75E78C0", Offset = "0x75E6CC0", VA = "0x1875E78C0")]
	[AsyncStateMachine(typeof(NAIKAMMEIHC))]
	public static void ABBLAAKGKJL(this Task MPAMMAGABHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DFDHEBCLDBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum HOCGHOKHMLK : short
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
	public struct LNJCOGNECDN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly HOCGHOKHMLK MCNLCGLNHHO;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1A50", Offset = "0x2BD0E50", VA = "0x182BD1A50")]
		public LNJCOGNECDN(HOCGHOKHMLK MCNLCGLNHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory EFJBPHHNLAK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	public static void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75E6A60", Offset = "0x75E5E60", VA = "0x1875E6A60")]
	static DFDHEBCLDBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x312E670", Offset = "0x312DA70", VA = "0x18312E670")]
	public static LNJCOGNECDN LPPLPFNFFBE(HOCGHOKHMLK MCNLCGLNHHO)
	{
		return default(LNJCOGNECDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	public static void KGEBPJIIEGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OMFDMIOEGPL
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x365EB90", Offset = "0x365DF90", VA = "0x18365EB90")]
	public static BLPMNNBOBJE<T1, T2> BOOACMBNEOK<T1, T2>(this (T1, T2) EIMDPLKFIBM) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(BLPMNNBOBJE<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x327F710", Offset = "0x327EB10", VA = "0x18327F710")]
	public static APLOJBOOPPO<T1, T2, T3> BOOACMBNEOK<T1, T2, T3>(this (T1, T2, T3) EIMDPLKFIBM) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(APLOJBOOPPO<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BLPMNNBOBJE<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) EIMDPLKFIBM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D81750", Offset = "0x5D80B50", VA = "0x185D81750")]
	public BLPMNNBOBJE((T1, T2) EIMDPLKFIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D814B0", Offset = "0x5D808B0", VA = "0x185D814B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct APLOJBOOPPO<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) EIMDPLKFIBM;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x48728B0", Offset = "0x4871CB0", VA = "0x1848728B0")]
	public APLOJBOOPPO((T1, T2, T3) EIMDPLKFIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4872810", Offset = "0x4871C10", VA = "0x184872810", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class INEGDKAMNGJ
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75E79E0", Offset = "0x75E6DE0", VA = "0x1875E79E0")]
	public static Range DCLKBBNBLOC(this AOIKGLJHPKL NBKCBIBCKOC)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class JPBAPDPEIGM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct OGFAKOAKOII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int DODFDOFKJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int ONAEOJELNDF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75E80F0", Offset = "0x75E74F0", VA = "0x1875E80F0")]
		public OGFAKOAKOII(int BGLOMHIAAIH, int ONAEOJELNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x75E80E0", Offset = "0x75E74E0", VA = "0x1875E80E0")]
		public bool HGNGIMJAKLP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x75E7A40", Offset = "0x75E6E40", VA = "0x1875E7A40")]
	public static OGFAKOAKOII NFFMPMPKJEP(this Range NBKCBIBCKOC)
	{
		return default(OGFAKOAKOII);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IMPEFAECFJM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle ODHBLOGMAPO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FFCJDLJAPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4839230", Offset = "0x4838630", VA = "0x184839230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4838D00", Offset = "0x4838100", VA = "0x184838D00")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4838DE0", Offset = "0x48381E0", VA = "0x184838DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4839330", Offset = "0x4838730", VA = "0x184839330")]
	public IMPEFAECFJM(T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4838DB0", Offset = "0x48381B0", VA = "0x184838DB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class AACEAIAOALM<THandle, TValue> : IDisposable where THandle : struct, AOLNDNNNENI where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> OHJJNNCOGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> JPGIMCGBJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> GGIGNDGONJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> IJOOJODGKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int LGIPNONIEJH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4604E60", Offset = "0x4604260", VA = "0x184604E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x46055A0", Offset = "0x46049A0", VA = "0x1846055A0")]
	public AACEAIAOALM(Action<TValue> IJOOJODGKME, [Optional] Func<TValue> GGIGNDGONJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4604CE0", Offset = "0x46040E0", VA = "0x184604CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x46052C0", Offset = "0x46046C0", VA = "0x1846052C0")]
	public THandle KAAHFJDOOLK(TValue PEBNJNGMMHE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4604F00", Offset = "0x4604300", VA = "0x184604F00")]
	public bool FKLDNICNGJG(THandle ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x46054D0", Offset = "0x46048D0", VA = "0x1846054D0")]
	public bool MGNAAKJADEG(THandle ODHBLOGMAPO, [Out] TValue PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4604EA0", Offset = "0x46042A0", VA = "0x184604EA0")]
	public TValue FCPELJIOJPN(THandle ODHBLOGMAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x46053C0", Offset = "0x46047C0", VA = "0x1846053C0")]
	public bool KEKBKMEMPOB(THandle ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4604DB0", Offset = "0x46041B0", VA = "0x184604DB0")]
	private THandle EBEMBKPMEGG(int FFCBHHABFJN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4605360", Offset = "0x4604760", VA = "0x184605360")]
	private TValue KDOJKOMAMBG(int FFCBHHABFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4605140", Offset = "0x4604540", VA = "0x184605140")]
	private void HNMJKBJOFJP(int FFCBHHABFJN, [In] THandle ODHBLOGMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4604E10", Offset = "0x4604210", VA = "0x184604E10")]
	private void EEMHKMEOGED(int FFCBHHABFJN, [In] TValue PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x46048C0", Offset = "0x4603CC0", VA = "0x1846048C0")]
	private THandle AKKNDHFJBED()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4605030", Offset = "0x4604430", VA = "0x184605030")]
	private void GGPCHLAGIOB(THandle ODHBLOGMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4604EF0", Offset = "0x46042F0", VA = "0x184604EF0")]
	private int FDKOIJACEOB(int IFKCKGNMHDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4604A70", Offset = "0x4603E70", VA = "0x184604A70")]
	private bool BHECPCDBBJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9700A0", Offset = "0x96F4A0", VA = "0x1809700A0")]
	private void IEIGCKMIEGM(THandle ODHBLOGMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4604C30", Offset = "0x4604030", VA = "0x184604C30")]
	private bool DPDPIJDAIFP([Out] THandle ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4605190", Offset = "0x4604590", VA = "0x184605190")]
	private bool IGANHKBADGL([Out] THandle ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4604A80", Offset = "0x4603E80", VA = "0x184604A80")]
	private void DKENJKDOHGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface AOLNDNNNENI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int NGGCGOFGPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int NGJHPPMLGLM
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
public static class GDAFKPLNMLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x34AE540", Offset = "0x34AD940", VA = "0x1834AE540")]
	public static bool KBKFECGIGBO<T>(this T ODHBLOGMAPO, T MNALNBMKJLK) where T : struct, AOLNDNNNENI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x34AE530", Offset = "0x34AD930", VA = "0x1834AE530")]
	public static bool DAHIKGIHLLP<T>(this T ODHBLOGMAPO) where T : struct, AOLNDNNNENI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x75E6CB0", Offset = "0x75E60B0", VA = "0x1875E6CB0")]
	public static string IPOOHBAKFED(this AOLNDNNNENI ODHBLOGMAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public ref struct OBIFENBBCHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type AAHMKEJBALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> NMKKKNNKNEF;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4BA55A0", Offset = "0x4BA49A0", VA = "0x184BA55A0")]
	public OBIFENBBCHC(Type IMDMOOJOPJP, Span<byte> OLAHHEDJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3650850", Offset = "0x364FC50", VA = "0x183650850")]
	public static OBIFENBBCHC BONEJHCIKAG<T>(T PEBNJNGMMHE) where T : struct
	{
		return default(OBIFENBBCHC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x75E7FD0", Offset = "0x75E73D0", VA = "0x1875E7FD0")]
	public static OJNCLINIMLF JKGHIELMIOO([In] OBIFENBBCHC NPJNBFDHKLI)
	{
		return default(OJNCLINIMLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x75E8050", Offset = "0x75E7450", VA = "0x1875E8050")]
	public Enum OFELFIPDDBG(Type LMBFCHFPOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x36511E0", Offset = "0x36505E0", VA = "0x1836511E0")]
	public void FHPKMMCODGE<T>([In] T PEBNJNGMMHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x75E80D0", Offset = "0x75E74D0", VA = "0x1875E80D0")]
	public void PGGJMOCPIBM(Enum BJDHLMBEIKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct OJNCLINIMLF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct BMBDPAJODLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* ABBJHBCFJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* NGGHAELOJMG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type AAHMKEJBALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> NMKKKNNKNEF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BEEELNGFBKL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75E8150", Offset = "0x75E7550", VA = "0x1875E8150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LBKDHFCBOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75E8100", Offset = "0x75E7500", VA = "0x1875E8100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA55A0", Offset = "0x4BA49A0", VA = "0x184BA55A0")]
	public OJNCLINIMLF(Type IMDMOOJOPJP, ReadOnlySpan<byte> OLAHHEDJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3657EB0", Offset = "0x36572B0", VA = "0x183657EB0")]
	public static OJNCLINIMLF BONEJHCIKAG<T>(T PEBNJNGMMHE) where T : struct
	{
		return default(OJNCLINIMLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x75E8330", Offset = "0x75E7730", VA = "0x1875E8330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x75E8160", Offset = "0x75E7560", VA = "0x1875E8160")]
	public object LHJAOFEJHLF(int FFCBHHABFJN = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct GBJGDAPAJMB
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x34ABAA0", Offset = "0x34AAEA0", VA = "0x1834ABAA0")]
	public static NativeArray<T> BONEJHCIKAG<T>(T PEBNJNGMMHE, bool EGGKGINNCNH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x34ABAF0", Offset = "0x34AAEF0", VA = "0x1834ABAF0")]
	public static NativeArray<T> KKMJPPEAKKH<T>(T PEBNJNGMMHE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x34ABA50", Offset = "0x34AAE50", VA = "0x1834ABA50")]
	public static NativeArray<T> BLOICCLNIOI<T>(T PEBNJNGMMHE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75E6AC0", Offset = "0x75E5EC0", VA = "0x1875E6AC0")]
	public static NativeArray<byte> BLOICCLNIOI(ReadOnlySpan<byte> PEBNJNGMMHE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x75E6C00", Offset = "0x75E6000", VA = "0x1875E6C00")]
	public static NativeArray<byte> BONEJHCIKAG(ReadOnlySpan<byte> PEBNJNGMMHE, bool EGGKGINNCNH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x75E6B80", Offset = "0x75E5F80", VA = "0x1875E6B80")]
	public unsafe static NativeArray<byte> BONEJHCIKAG(byte* HCHMEPGOLJK, int EHCAJIFPCLL, bool EGGKGINNCNH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x34ABB40", Offset = "0x34AAF40", VA = "0x1834ABB40")]
	public static NativeArray<T> MAEOIBKNBOE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct JNPDMBIBINF<Handle> where Handle : AOLNDNNNENI, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct CCMCMDGDMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly JNPDMBIBINF<Handle> MJFKDNJHIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int FFCBHHABFJN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Handle KELINDAFEBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x606FF20", Offset = "0x606F320", VA = "0x18606FF20")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6070290", Offset = "0x606F690", VA = "0x186070290")]
		public CCMCMDGDMCJ(JNPDMBIBINF<Handle> MJFKDNJHIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6070200", Offset = "0x606F600", VA = "0x186070200")]
		public EEFGIJMODDC KMDIICJFNJF([In] EEFGIJMODDC NCCMNNBGHEA)
		{
			return default(EEFGIJMODDC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x606FCE0", Offset = "0x606F0E0", VA = "0x18606FCE0")]
		public bool HGNGIMJAKLP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x606FC20", Offset = "0x606F020", VA = "0x18606FC20")]
		private Handle EENCJOIHCNC(string LPIFIOEEOGF)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct EEFGIJMODDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private CCMCMDGDMCJ ANBLDGKCPIP;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x40EBFE0", Offset = "0x40EB3E0", VA = "0x1840EBFE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x40EC0D0", Offset = "0x40EB4D0", VA = "0x1840EC0D0")]
		public EEFGIJMODDC(JNPDMBIBINF<Handle> MJFKDNJHIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x40EBF60", Offset = "0x40EB360", VA = "0x1840EBF60")]
		public bool HGNGIMJAKLP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x40EC060", Offset = "0x40EB460", VA = "0x1840EC060")]
		public EEFGIJMODDC NFFMPMPKJEP()
		{
			return default(EEFGIJMODDC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeList<int> MGGIBLHEGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<int> EDDAFFNPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int PNEIGOCHONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int OCPHMCABOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool BFJMPDNBOHO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PCGHJECDELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4A3A7D0", Offset = "0x4A39BD0", VA = "0x184A3A7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public EEFGIJMODDC KHBGCGMFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4A3A590", Offset = "0x4A39990", VA = "0x184A3A590")]
		get
		{
			return default(EEFGIJMODDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AB80", Offset = "0x4A39F80", VA = "0x184A3AB80")]
	public JNPDMBIBINF(int HFNDDLFCAFE, Allocator FALBINAEKDG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4A39010", Offset = "0x4A38410", VA = "0x184A39010")]
	public void AICKIPOBPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F0BE90", Offset = "0x1F0B290", VA = "0x181F0BE90")]
	public static int FDKOIJACEOB(int CKLNAHKPEEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2C0BC50", Offset = "0x2C0B050", VA = "0x182C0BC50")]
	public static bool LDNAGJBMPHK(int CKLNAHKPEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A850", Offset = "0x4A39C50", VA = "0x184A3A850")]
	public bool OFDNBCIJDJP(int FFCBHHABFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4A39750", Offset = "0x4A38B50", VA = "0x184A39750")]
	public bool EBDGECJGMLG(Handle ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A130", Offset = "0x4A39530", VA = "0x184A3A130")]
	public Handle IEIJFMMLJBP()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A39BF0", Offset = "0x4A38FF0", VA = "0x184A39BF0")]
	public void EMHJFMFLEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A4B0", Offset = "0x4A398B0", VA = "0x184A3A4B0")]
	public void KPGHGDLAEAO(Handle ODHBLOGMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xCEB360", Offset = "0xCEA760", VA = "0x180CEB360")]
	private bool IGEOMPMCPKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4A39570", Offset = "0x4A38970", VA = "0x184A39570")]
	private bool DLGCEDLCDPH(int FFCBHHABFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4A39300", Offset = "0x4A38700", VA = "0x184A39300")]
	private void BGJOLAEGEHC([Out] int FFCBHHABFJN, [Out] int IFKCKGNMHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A360", Offset = "0x4A39760", VA = "0x184A3A360")]
	private void IKAMKPOBBBH(Handle ODHBLOGMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A394C0", Offset = "0x4A388C0", VA = "0x184A394C0")]
	private void DKPBOLGODPM(int FFCBHHABFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4A39FB0", Offset = "0x4A393B0", VA = "0x184A39FB0")]
	private bool FHKICGOJILO([Out] int FFCBHHABFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A620", Offset = "0x4A39A20", VA = "0x184A3A620")]
	private static Handle LHLHIBGHNOE(int FFCBHHABFJN, int IFKCKGNMHDI)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public struct GAAPGAHCHAH<Handle, T> where Handle : AOLNDNNNENI, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private JNPDMBIBINF<Handle> EGOEEALKJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] DIMLJCGLPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Action<T> NDCFLLEGBJN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4624FD0", Offset = "0x46243D0", VA = "0x184624FD0")]
	public GAAPGAHCHAH(int HFNDDLFCAFE, [Optional] Action<T> NDCFLLEGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4624150", Offset = "0x4623550", VA = "0x184624150")]
	public void AICKIPOBPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4624A00", Offset = "0x4623E00", VA = "0x184624A00")]
	public bool MGNAAKJADEG(Handle ODHBLOGMAPO, [Out] T NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4624830", Offset = "0x4623C30", VA = "0x184624830")]
	public Handle KAAHFJDOOLK(T NBAMGPFDMIB)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4624480", Offset = "0x4623880", VA = "0x184624480")]
	public void DCNGIMHDCNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4624D10", Offset = "0x4624110", VA = "0x184624D10")]
	public void PBIACPFCCPC(Handle ODHBLOGMAPO, [Out] T LAICPNPNIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4624B70", Offset = "0x4623F70", VA = "0x184624B70")]
	public void PBIACPFCCPC(Handle ODHBLOGMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x46246B0", Offset = "0x4623AB0", VA = "0x1846246B0")]
	private T JMIIGEJFAIO(int FFCBHHABFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4624AB0", Offset = "0x4623EB0", VA = "0x184624AB0")]
	private void OGOLNCCOBLC(int IODBKAEJOHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public struct DNFLDBAGMME<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct NPDAACPKBJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private DNFLDBAGMME<T> PHAPILEGACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int FFCBHHABFJN;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4E9B940", Offset = "0x4E9AD40", VA = "0x184E9B940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x25DEAA0", Offset = "0x25DDEA0", VA = "0x1825DEAA0")]
		public NPDAACPKBJE(DNFLDBAGMME<T> PHAPILEGACC, int FFCBHHABFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B8F0", Offset = "0x4E9ACF0", VA = "0x184E9B8F0")]
		public bool HGNGIMJAKLP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CHMKEJAIJJF : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DNFLDBAGMME<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public CHMKEJAIJJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6076150", Offset = "0x6075550", VA = "0x186076150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60761F0", Offset = "0x60755F0", VA = "0x1860761F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PMOEIJNAOGI : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DNFLDBAGMME<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public PMOEIJNAOGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x50D6740", Offset = "0x50D5B40", VA = "0x1850D6740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x50D67E0", Offset = "0x50D5BE0", VA = "0x1850D67E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private object[] MJFOKKFMONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private uint PEBNJNGMMHE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AKPIBKEABKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5229EF0", Offset = "0x52292F0", VA = "0x185229EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EAANCJCJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x640F050", Offset = "0x640E450", VA = "0x18640F050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MEKKKKJOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1568130", Offset = "0x1567530", VA = "0x181568130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal bool LDIBLIAAIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x640F040", Offset = "0x640E440", VA = "0x18640F040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LGFGCHCPGKC<T> NMKKKNNKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x640F0E0", Offset = "0x640E4E0", VA = "0x18640F0E0")]
		get
		{
			return default(LGFGCHCPGKC<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x640EDF0", Offset = "0x640E1F0", VA = "0x18640EDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x640F2E0", Offset = "0x640E6E0", VA = "0x18640F2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x640FB80", Offset = "0x640EF80", VA = "0x18640FB80")]
	internal DNFLDBAGMME(DNFLDBAGMME<T> PHAPILEGACC, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x640F7B0", Offset = "0x640EBB0", VA = "0x18640F7B0")]
	private DNFLDBAGMME(T[] PHAPILEGACC, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x640F840", Offset = "0x640EC40", VA = "0x18640F840")]
	public DNFLDBAGMME(IEnumerable<T> JPGIMCGBJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x640F7D0", Offset = "0x640EBD0", VA = "0x18640F7D0")]
	public DNFLDBAGMME(int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x640EF20", Offset = "0x640E320", VA = "0x18640EF20")]
	public int IMLLPNOEGNC(T PEBNJNGMMHE, int BGLOMHIAAIH, int LOHPPDCIAAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x640ED30", Offset = "0x640E130", VA = "0x18640ED30")]
	public void DBFIKJPIBAC(int ABIBKDOFNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x640EB60", Offset = "0x640DF60", VA = "0x18640EB60")]
	private void BIOHEJOKNBH(int ABIBKDOFNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x640F260", Offset = "0x640E660", VA = "0x18640F260")]
	public T[] MOOONMJMHCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x640F400", Offset = "0x640E800", VA = "0x18640F400")]
	public T[] PGFHNJLOBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x640ED70", Offset = "0x640E170", VA = "0x18640ED70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x640EEC0", Offset = "0x640E2C0", VA = "0x18640EEC0")]
	public void FDCBLBOKAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x640F390", Offset = "0x640E790", VA = "0x18640F390")]
	public NPDAACPKBJE NFFMPMPKJEP()
	{
		return default(NPDAACPKBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x640F5D0", Offset = "0x640E9D0", VA = "0x18640F5D0", Slot = "5")]
	[IteratorStateMachine(typeof(DNFLDBAGMME<>.CHMKEJAIJJF))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x640F6C0", Offset = "0x640EAC0", VA = "0x18640F6C0", Slot = "6")]
	[IteratorStateMachine(typeof(DNFLDBAGMME<>.PMOEIJNAOGI))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x640F080", Offset = "0x640E480", VA = "0x18640F080")]
	public static DNFLDBAGMME<T> MHMLFLGKEPG(T[] PHAPILEGACC)
	{
		return default(DNFLDBAGMME<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x640EFA0", Offset = "0x640E3A0", VA = "0x18640EFA0")]
	public static DNFLDBAGMME<T> JKGHIELMIOO(T[] PHAPILEGACC)
	{
		return default(DNFLDBAGMME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x640F550", Offset = "0x640E950", VA = "0x18640F550")]
	private void POGPCLBBNID(int FFCBHHABFJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class LAEKEAJIIJD<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct KPPOEHCDMHC : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private LAEKEAJIIJD<T> DBJKHFJBKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int FFCBHHABFJN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4B48A10", Offset = "0x4B47E10", VA = "0x184B48A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4B48A50", Offset = "0x4B47E50", VA = "0x184B48A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x41C6D20", Offset = "0x41C6120", VA = "0x1841C6D20")]
		public KPPOEHCDMHC(LAEKEAJIIJD<T> DBJKHFJBKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4B48920", Offset = "0x4B47D20", VA = "0x184B48920", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4B489C0", Offset = "0x4B47DC0", VA = "0x184B489C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DNFLDBAGMME<T> MJFOKKFMONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int EHCAJIFPCLL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4BC6A10", Offset = "0x4BC5E10", VA = "0x184BC6A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AKPIBKEABKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x46569D0", Offset = "0x4655DD0", VA = "0x1846569D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PCGHJECDELA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4BC7460", Offset = "0x4BC6860", VA = "0x184BC7460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool MEKKKKJOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4BC74F0", Offset = "0x4BC68F0", VA = "0x184BC74F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public LGFGCHCPGKC<T> NMKKKNNKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4BC73E0", Offset = "0x4BC67E0", VA = "0x184BC73E0")]
		get
		{
			return default(LGFGCHCPGKC<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4BC75C0", Offset = "0x4BC69C0", VA = "0x184BC75C0")]
	public LAEKEAJIIJD(IEnumerable<T> JPGIMCGBJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7640", Offset = "0x4BC6A40", VA = "0x184BC7640")]
	public LAEKEAJIIJD(int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x45CA860", Offset = "0x45C9C60", VA = "0x1845CA860")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6740", Offset = "0x4BC5B40", VA = "0x184BC6740")]
	public DNFLDBAGMME<T> AIFOLHBDIOD()
	{
		return default(DNFLDBAGMME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7020", Offset = "0x4BC6420", VA = "0x184BC7020")]
	public void KAAHFJDOOLK(T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4BC69B0", Offset = "0x4BC5DB0", VA = "0x184BC69B0")]
	private void DBFIKJPIBAC(int JJLMBBEIKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6A80", Offset = "0x4BC5E80", VA = "0x184BC6A80")]
	public void FFIEOJBCHCJ(List<T> HEAMOKBMKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6C00", Offset = "0x4BC6000", VA = "0x184BC6C00")]
	public void FFIEOJBCHCJ(T[] HEAMOKBMKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6780", Offset = "0x4BC5B80", VA = "0x184BC6780")]
	public void BAMMEBECKNL(int FFCBHHABFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6D10", Offset = "0x4BC6110", VA = "0x184BC6D10")]
	public void IEANFNEFJBL(int OOPCGCJBHID, int ONAEOJELNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6EE0", Offset = "0x4BC62E0", VA = "0x184BC6EE0")]
	public int IMLLPNOEGNC(T PEBNJNGMMHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7390", Offset = "0x4BC6790", VA = "0x184BC7390")]
	public bool KLNGAEBDGOB(T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7480", Offset = "0x4BC6880", VA = "0x184BC7480")]
	public T[] PGFHNJLOBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4BC69F0", Offset = "0x4BC5DF0", VA = "0x184BC69F0", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6F60", Offset = "0x4BC6360", VA = "0x184BC6F60")]
	public static DNFLDBAGMME<T> JKGHIELMIOO(LAEKEAJIIJD<T> DBJKHFJBKPC)
	{
		return default(DNFLDBAGMME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6CA0", Offset = "0x4BC60A0", VA = "0x184BC6CA0", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7510", Offset = "0x4BC6910", VA = "0x184BC7510", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7550", Offset = "0x4BC6950", VA = "0x184BC7550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4BC6860", Offset = "0x4BC5C60", VA = "0x184BC6860")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void BMBLFHGIIJB(int PEBNJNGMMHE, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7140", Offset = "0x4BC6540", VA = "0x184BC7140")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void KDHPJANAJJG(int OOPCGCJBHID, int ONAEOJELNDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JJLBDANDFFI
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x351C780", Offset = "0x351BB80", VA = "0x18351C780")]
	public static void FDCBLBOKAOI<T>(this LAEKEAJIIJD<T> DBJKHFJBKPC) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public ref struct LGFGCHCPGKC<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Span<object> MJFOKKFMONL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4BF4300", Offset = "0x4BF3700", VA = "0x184BF4300")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4BF4580", Offset = "0x4BF3980", VA = "0x184BF4580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int AKPIBKEABKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4BF4270", Offset = "0x4BF3670", VA = "0x184BF4270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public LGFGCHCPGKC(Span<object> OLAHHEDJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4BF44B0", Offset = "0x4BF38B0", VA = "0x184BF44B0")]
	public LGFGCHCPGKC<T> KKPACHMAMDA(int BGLOMHIAAIH)
	{
		return default(LGFGCHCPGKC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4BF43D0", Offset = "0x4BF37D0", VA = "0x184BF43D0")]
	public LGFGCHCPGKC<T> KKPACHMAMDA(int BGLOMHIAAIH, int EHCAJIFPCLL)
	{
		return default(LGFGCHCPGKC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4BF4210", Offset = "0x4BF3610", VA = "0x184BF4210")]
	public void BENBCGCNJFB(LGFGCHCPGKC<T> PKPMPKLKPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4BF45B0", Offset = "0x4BF39B0", VA = "0x184BF45B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4BF42B0", Offset = "0x4BF36B0", VA = "0x184BF42B0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4BF4380", Offset = "0x4BF3780", VA = "0x184BF4380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct AOIKGLJHPKL : IEquatable<AOIKGLJHPKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int FGCNBOMLCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int LOHPPDCIAAL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int CDNMPCJCEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE380", Offset = "0x2BED780", VA = "0x182BEE380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF10", Offset = "0x68AC310", VA = "0x1868ACF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JONEIDKENEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int KIFNJPGIHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x75E6830", Offset = "0x75E5C30", VA = "0x1875E6830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x75E6940", Offset = "0x75E5D40", VA = "0x1875E6940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public (int begin, int end) GIOCPHKHGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x75E68D0", Offset = "0x75E5CD0", VA = "0x1875E68D0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
	private AOIKGLJHPKL(int FGCNBOMLCIC, int LOHPPDCIAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x25D2C10", Offset = "0x25D2010", VA = "0x1825D2C10")]
	public static AOIKGLJHPKL AMPCFDAJGFG(int FGCNBOMLCIC, int LOHPPDCIAAL)
	{
		return default(AOIKGLJHPKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x75E6930", Offset = "0x75E5D30", VA = "0x1875E6930")]
	public static AOIKGLJHPKL HIHOGNCGKHL(int BGLOMHIAAIH, int ONAEOJELNDF)
	{
		return default(AOIKGLJHPKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x75E6950", Offset = "0x75E5D50", VA = "0x1875E6950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x16EE6E0", Offset = "0x16EDAE0", VA = "0x1816EE6E0", Slot = "4")]
	public bool Equals(AOIKGLJHPKL MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x75E6840", Offset = "0x75E5C40", VA = "0x1875E6840", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x69F9A50", Offset = "0x69F8E50", VA = "0x1869F9A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct EAHLEBKODCC<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NativeArray<T> MJFOKKFMONL;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public EAHLEBKODCC(NativeArray<T> MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x40E2050", Offset = "0x40E1450", VA = "0x1840E2050", Slot = "6")]
	public int Compare(int COMHOHNLIIN, int PJGBAACMKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x40E2140", Offset = "0x40E1540", VA = "0x1840E2140", Slot = "4")]
	public bool Equals(int COMHOHNLIIN, int PJGBAACMKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x40E2230", Offset = "0x40E1630", VA = "0x1840E2230", Slot = "5")]
	public int GetHashCode(int COMHOHNLIIN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class AACIJPCFGII
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5DA0", Offset = "0x3BB51A0", VA = "0x183BB5DA0")]
	public static T[] PGCKCBAADBH<T>(List<T> DBJKHFJBKPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KGIOFCPKGDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* OALIBPHJOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal AllocatorManager.AllocatorHandle HGAENFHHNLF;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54D84D0", Offset = "0x54D78D0", VA = "0x1854D84D0")]
	public void AICKIPOBPIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GBDIBIMNLJE
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x34AB410", Offset = "0x34AA810", VA = "0x1834AB410")]
	public static KGIOFCPKGDA AGMCOODPOBA<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> MHJIECJLKAG) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(KGIOFCPKGDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x34AB410", Offset = "0x34AA810", VA = "0x1834AB410")]
	public static UnsafeParallelHashMap<TKey, TValue> GKAJNOBDLII<TKey, TValue>(this KGIOFCPKGDA MHJIECJLKAG) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DJMENDIJPGL
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x32D6170", Offset = "0x32D5570", VA = "0x1832D6170")]
	public static int IEFKMCKFHCC<T>(ReadOnlySpan<T> CJKGDAIGCBJ, ReadOnlySpan<T> FNPJODLGIAA, int EHCAJIFPCLL) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FEGIHFGEDGD
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x347F810", Offset = "0x347EC10", VA = "0x18347F810")]
	public static T DKFKDLDOCOB<T>(this NativeArray<byte> BLMGNEDEHDK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x347FB30", Offset = "0x347EF30", VA = "0x18347FB30")]
	public static NativeArray<T> KHNOFCCNKJB<T>(this NativeArray<byte> BLMGNEDEHDK, int LOHPPDCIAAL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x347F940", Offset = "0x347ED40", VA = "0x18347F940")]
	public static void IJMBEPNCDBE<T>(this NativeList<byte> EBNFGKDLPAC, [In] T PEBNJNGMMHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x347F8A0", Offset = "0x347ECA0", VA = "0x18347F8A0")]
	public static void IJMBEPNCDBE<T>(this NativeList<byte> EBNFGKDLPAC, NativeArray<T> PEBNJNGMMHE) where T : struct
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

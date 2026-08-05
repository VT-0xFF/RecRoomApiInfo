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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB940", Offset = "0x7AFAD40", VA = "0x187AFB940", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AJKLAOIGCIP]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3867230", Offset = "0x3866630", VA = "0x183867230")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AJKLAOIGCIP]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3867F60", Offset = "0x3867360", VA = "0x183867F60")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x38673E0", Offset = "0x38667E0", VA = "0x1838673E0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3867300", Offset = "0x3866700", VA = "0x183867300")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3871AD0", Offset = "0x3870ED0", VA = "0x183871AD0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3871920", Offset = "0x3870D20", VA = "0x183871920")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x38721D0", Offset = "0x38715D0", VA = "0x1838721D0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3872310", Offset = "0x3871710", VA = "0x183872310")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3868810", Offset = "0x3867C10", VA = "0x183868810")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x38687A0", Offset = "0x3867BA0", VA = "0x1838687A0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3868D90", Offset = "0x3868190", VA = "0x183868D90")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, OIJNMGBLDKP range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3868DD0", Offset = "0x38681D0", VA = "0x183868DD0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3868C00", Offset = "0x3868000", VA = "0x183868C00")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3871A10", Offset = "0x3870E10", VA = "0x183871A10")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AJKLAOIGCIP]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3872400", Offset = "0x3871800", VA = "0x183872400")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3874260", Offset = "0x3873660", VA = "0x183874260")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3874210", Offset = "0x3873610", VA = "0x183874210")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5192EF0", Offset = "0x51922F0", VA = "0x185192EF0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCA20", Offset = "0x7AFBE20", VA = "0x187AFCA20")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCA50", Offset = "0x7AFBE50", VA = "0x187AFCA50")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3873770", Offset = "0x3872B70", VA = "0x183873770")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3873600", Offset = "0x3872A00", VA = "0x183873600")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3873840", Offset = "0x3872C40", VA = "0x183873840")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x38737F0", Offset = "0x3872BF0", VA = "0x1838737F0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x38737A0", Offset = "0x3872BA0", VA = "0x1838737A0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x38736D0", Offset = "0x3872AD0", VA = "0x1838736D0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3873B70", Offset = "0x3872F70", VA = "0x183873B70")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x38739D0", Offset = "0x3872DD0", VA = "0x1838739D0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3873650", Offset = "0x3872A50", VA = "0x183873650")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x38735A0", Offset = "0x38729A0", VA = "0x1838735A0")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3873580", Offset = "0x3872980", VA = "0x183873580")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3874640", Offset = "0x3873A40", VA = "0x183874640")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3874270", Offset = "0x3873670", VA = "0x183874270")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3874670", Offset = "0x3873A70", VA = "0x183874670")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3874730", Offset = "0x3873B30", VA = "0x183874730")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AJKLAOIGCIP]
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
			[Cpp2IlInjected.Address(RVA = "0x49011A0", Offset = "0x49005A0", VA = "0x1849011A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD736B0", Offset = "0xD72AB0", VA = "0x180D736B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4E81480", Offset = "0x4E80880", VA = "0x184E81480")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5232FB0", Offset = "0x52323B0", VA = "0x185232FB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5232ED0", Offset = "0x52322D0", VA = "0x185232ED0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D720", Offset = "0x3D9CB20", VA = "0x183D9D720")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AJKLAOIGCIP]
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
			[Cpp2IlInjected.Address(RVA = "0x5292840", Offset = "0x5291C40", VA = "0x185292840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5292880", Offset = "0x5291C80", VA = "0x185292880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4E81480", Offset = "0x4E80880", VA = "0x184E81480")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5292490", Offset = "0x5291890", VA = "0x185292490")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x52925E0", Offset = "0x52919E0", VA = "0x1852925E0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5292620", Offset = "0x5291A20", VA = "0x185292620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x52926C0", Offset = "0x5291AC0", VA = "0x1852926C0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AJKLAOIGCIP]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AJKLAOIGCIP]
public static class DIHBEBNAFPA
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7AFA930", Offset = "0x7AF9D30", VA = "0x187AFA930")]
	public static JobHandle BHEFLNGNLLJ(this JobHandle EHIMHGHKFCP, JobHandle MDCPFJBHOAB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7AFA970", Offset = "0x7AF9D70", VA = "0x187AFA970")]
	public static JobHandle JDAEAALLBCC(this Span<JobHandle> OGLMLGNLLKL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ECHMDDDDLEH
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3527430", Offset = "0x3526830", VA = "0x183527430")]
	public static NativeKeyValueArrays<TKey, TValue> NBBMMEEAJDC<TKey, TValue>(this Dictionary<TKey, TValue> CGCBFDCMBPH, Allocator LMMGDELCIGC) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GAHLAJOJDPD
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAEC0", Offset = "0x7AFA2C0", VA = "0x187AFAEC0")]
	public static void EDAOMPBBJCD(this GameObject GMFIIANHHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB000", Offset = "0x7AFA400", VA = "0x187AFB000")]
	public static void EDAOMPBBJCD(this Component FBIFMODNLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAF60", Offset = "0x7AFA360", VA = "0x187AFAF60")]
	public static void EDAOMPBBJCD(this ScriptableObject CEGJMGHBLIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MPKEEKOHEOK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB9D0", Offset = "0x7AFADD0", VA = "0x187AFB9D0")]
	public static void EIANDGJLNFO(this NativeList<byte> ANHMDLEGCDL, ReadOnlySpan<byte> EOJIKPFPLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37CBCA0", Offset = "0x37CB0A0", VA = "0x1837CBCA0")]
	public static void AJDKNEKLFIN<T>(this NativeList<T> ANHMDLEGCDL, T OOEMJLHLIHJ, int PCGLBCNIEAP) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NANDKBNCAEP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38560E0", Offset = "0x38554E0", VA = "0x1838560E0")]
	public static T HFHLAONONAI<T>(this ReadOnlySpan<byte> OOEMJLHLIHJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3856A30", Offset = "0x3855E30", VA = "0x183856A30")]
	public static T MOGFIHGLOIP<T>(this Span<T> EOJIKPFPLED, Func<T, bool> CACIIGCOCCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3856320", Offset = "0x3855720", VA = "0x183856320")]
	public static bool HPGPCFPJOPF<T>(this Span<T> EOJIKPFPLED, Func<T, bool> CACIIGCOCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3856B90", Offset = "0x3855F90", VA = "0x183856B90")]
	public static bool PELKGMENHII<T>(this Span<T> EOJIKPFPLED, Func<T, bool> CACIIGCOCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3855B90", Offset = "0x3854F90", VA = "0x183855B90")]
	public static T DANLDNLMJMK<T>([In] this ReadOnlySpan<byte> EOJIKPFPLED) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x38563D0", Offset = "0x38557D0", VA = "0x1838563D0")]
	public static Span<TTo> JOBLDFBDAEN<TTo, TFrom>(this Span<TFrom> EOJIKPFPLED) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x38563D0", Offset = "0x38557D0", VA = "0x1838563D0")]
	public static ReadOnlySpan<TTo> JOBLDFBDAEN<TTo, TFrom>(this ReadOnlySpan<TFrom> EOJIKPFPLED) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x38563D0", Offset = "0x38557D0", VA = "0x1838563D0")]
	public static ReadOnlySpan<TTo> JOBLDFBDAEN<TTo>(this ReadOnlySpan<byte> EOJIKPFPLED) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3856930", Offset = "0x3855D30", VA = "0x183856930")]
	public static Span<T> LEEDLDCPNEM<T>(this ReadOnlySpan<T> BHCEDEKBMHE) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3856420", Offset = "0x3855820", VA = "0x183856420")]
	public static Span<byte> KFMFOPCGNHM<T>([In] this Span<byte> EOJIKPFPLED, T OOEMJLHLIHJ) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7AFBF60", Offset = "0x7AFB360", VA = "0x187AFBF60")]
	private static Enum CMPHMMHDJCO([In] ReadOnlySpan<byte> EOJIKPFPLED, Type HGEDOBCBGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AFC500", Offset = "0x7AFB900", VA = "0x187AFC500")]
	public static Enum MDLLLHCGCCP([In] this Span<byte> EOJIKPFPLED, Type HGEDOBCBGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AFBA50", Offset = "0x7AFAE50", VA = "0x187AFBA50")]
	public static void CLOGGJEPAMH([In] this Span<byte> EOJIKPFPLED, Enum AGBLNABJHCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FIBNPDAIEDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ELBJILJLNIK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7AFAC20", Offset = "0x7AFA020", VA = "0x187AFAC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AFADA0", Offset = "0x7AFA1A0", VA = "0x187AFADA0")]
	[AsyncStateMachine(typeof(ELBJILJLNIK))]
	public static void HHKBIPJMFOD(this Task DEEHPBDAIHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MEFDKKKGGMA
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37B8350", Offset = "0x37B7750", VA = "0x1837B8350")]
	public static NativeArray<T> DBEFIAJPJDF<T>(this UnsafeList<T> ANHMDLEGCDL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37B83B0", Offset = "0x37B77B0", VA = "0x1837B83B0")]
	public static NativeArray<T> IOMLIIBMGFN<T>(this UnsafeList<T> ANHMDLEGCDL, bool BOACKDBINIF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x37B8430", Offset = "0x37B7830", VA = "0x1837B8430")]
	public static UnsafeList<T> LEEDLDCPNEM<T>(this UnsafeList<T> ANHMDLEGCDL, Allocator LMMGDELCIGC) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DKJCIOBIIBK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum GFDLAFAKJBA : short
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
	public struct BLCNMDJKPIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly GFDLAFAKJBA IICGAABOENK;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2D36000", Offset = "0x2D35400", VA = "0x182D36000")]
		public BLCNMDJKPIP(GFDLAFAKJBA IICGAABOENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory AKJBFKHJGJP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	public static void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAA20", Offset = "0x7AF9E20", VA = "0x187AFAA20")]
	static DKJCIOBIIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x33739A0", Offset = "0x3372DA0", VA = "0x1833739A0")]
	public static BLCNMDJKPIP MBENIALIEIF(GFDLAFAKJBA IICGAABOENK)
	{
		return default(BLCNMDJKPIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	public static void NGMGOMMIMAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FDAMMHKELFG
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36857E0", Offset = "0x3684BE0", VA = "0x1836857E0")]
	public static LCDDPFMKHIM<T1, T2> BKJBINEALJJ<T1, T2>(this (T1, T2) OFDLFCAMOAE) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(LCDDPFMKHIM<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x35277E0", Offset = "0x3526BE0", VA = "0x1835277E0")]
	public static PCNKGHALNBH<T1, T2, T3> BKJBINEALJJ<T1, T2, T3>(this (T1, T2, T3) OFDLFCAMOAE) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(PCNKGHALNBH<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LCDDPFMKHIM<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) OFDLFCAMOAE;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F6A0", Offset = "0x4E8EAA0", VA = "0x184E8F6A0")]
	public LCDDPFMKHIM((T1, T2) OFDLFCAMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F400", Offset = "0x4E8E800", VA = "0x184E8F400", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PCNKGHALNBH<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) OFDLFCAMOAE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F6B0", Offset = "0x4E8EAB0", VA = "0x184E8F6B0")]
	public PCNKGHALNBH((T1, T2, T3) OFDLFCAMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x547ED60", Offset = "0x547E160", VA = "0x18547ED60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class EDCBNBODPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAA90", Offset = "0x7AF9E90", VA = "0x187AFAA90")]
	public static Range FOHKENBNAOP(this OIJNMGBLDKP OGPEFHDLAJP)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JHJMPDAPHLD
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct EJEEGBGCICK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int LHJMLBMBFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int CBHCNOAGPIM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAC10", Offset = "0x7AFA010", VA = "0x187AFAC10")]
		public EJEEGBGCICK(int KAHCMHKHPHM, int CBHCNOAGPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAC00", Offset = "0x7AFA000", VA = "0x187AFAC00")]
		public bool OOODFKMFOLP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB8F0", Offset = "0x7AFACF0", VA = "0x187AFB8F0")]
	public static EJEEGBGCICK PMMOLBDEIOM(this Range OGPEFHDLAJP)
	{
		return default(EJEEGBGCICK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NENGMKEFOKJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle PAOMPCHHBKF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HHEAHHAENPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5192F20", Offset = "0x5192320", VA = "0x185192F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5192E30", Offset = "0x5192230", VA = "0x185192E30")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5193200", Offset = "0x5192600", VA = "0x185193200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5193420", Offset = "0x5192820", VA = "0x185193420")]
	public NENGMKEFOKJ(T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5192EF0", Offset = "0x51922F0", VA = "0x185192EF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class LCKAOPFCAON<THandle, TValue> : IDisposable where THandle : struct, KPKDAMONEJC where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> OGLMLGNLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> LMNAOMMMDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> JEDAOMGFHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> MHFKIKCNJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int MJOEAKMICAA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4E903F0", Offset = "0x4E8F7F0", VA = "0x184E903F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4E90680", Offset = "0x4E8FA80", VA = "0x184E90680")]
	public LCKAOPFCAON(Action<TValue> MHFKIKCNJPJ, [Optional] Func<TValue> JEDAOMGFHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FC40", Offset = "0x4E8F040", VA = "0x184E8FC40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FD80", Offset = "0x4E8F180", VA = "0x184E8FD80")]
	public THandle FGAAHPGCDNG(TValue OOEMJLHLIHJ)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E900A0", Offset = "0x4E8F4A0", VA = "0x184E900A0")]
	public bool JLKCCHLFIFB(THandle PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F910", Offset = "0x4E8ED10", VA = "0x184E8F910")]
	public bool ACKDGLPEIGD(THandle PAOMPCHHBKF, [Out] TValue OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FBA0", Offset = "0x4E8EFA0", VA = "0x184E8FBA0")]
	public TValue DANLDNLMJMK(THandle PAOMPCHHBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4E90550", Offset = "0x4E8F950", VA = "0x184E90550")]
	public bool OJMAIFCODDD(THandle PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FF00", Offset = "0x4E8F300", VA = "0x184E8FF00")]
	private THandle HAEPOHDMOGP(int COPLIEINKOF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FD20", Offset = "0x4E8F120", VA = "0x184E8FD20")]
	private TValue EJGBPDLFOAE(int COPLIEINKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FBF0", Offset = "0x4E8EFF0", VA = "0x184E8FBF0")]
	private void DCFFONLICJC(int COPLIEINKOF, [In] THandle PAOMPCHHBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4E901E0", Offset = "0x4E8F5E0", VA = "0x184E901E0")]
	private void KGKLHKNNLNM(int COPLIEINKOF, [In] TValue OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4E90230", Offset = "0x4E8F630", VA = "0x184E90230")]
	private THandle LEHOAHCMCKK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4E90430", Offset = "0x4E8F830", VA = "0x184E90430")]
	private void NBHBGOBBDAM(THandle PAOMPCHHBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FE30", Offset = "0x4E8F230", VA = "0x184E8FE30")]
	private int GHNOACFNDMO(int IPCFHGIMHJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E90670", Offset = "0x4E8FA70", VA = "0x184E90670")]
	private bool PJGAAFNKNIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9D9630", Offset = "0x9D8A30", VA = "0x1809D9630")]
	private void JKKPGANMMBK(THandle PAOMPCHHBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FE40", Offset = "0x4E8F240", VA = "0x184E8FE40")]
	private bool GKJFJMHCJNB([Out] THandle PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FF60", Offset = "0x4E8F360", VA = "0x184E8FF60")]
	private bool ICPGBCBFKGN([Out] THandle PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F9E0", Offset = "0x4E8EDE0", VA = "0x184E8F9E0")]
	private void BIBFLPDLECG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KPKDAMONEJC
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int PINFDPDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int LGHILPCJELG
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
public static class PLDAPOCJMOE
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38C4AF0", Offset = "0x38C3EF0", VA = "0x1838C4AF0")]
	public static bool FEEEMBKAOOF<T>(this T PAOMPCHHBKF, T DMMBOHMLHLF) where T : struct, KPKDAMONEJC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38C4AE0", Offset = "0x38C3EE0", VA = "0x1838C4AE0")]
	public static bool CMMDKLGDPDP<T>(this T PAOMPCHHBKF) where T : struct, KPKDAMONEJC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7AFCC30", Offset = "0x7AFC030", VA = "0x187AFCC30")]
	public static string IHLKNIGAMIE(this KPKDAMONEJC PAOMPCHHBKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct EFACPNDLDKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type EAEMJJOLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> PBOIKHPFLNB;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E81240", Offset = "0x4E80640", VA = "0x184E81240")]
	public EFACPNDLDKE(Type IPAAGGLPAIB, Span<byte> EOJIKPFPLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3528850", Offset = "0x3527C50", VA = "0x183528850")]
	public static EFACPNDLDKE AIJMHMNEAAE<T>(T OOEMJLHLIHJ) where T : struct
	{
		return default(EFACPNDLDKE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAB00", Offset = "0x7AF9F00", VA = "0x187AFAB00")]
	public static HLLDEEKGDLK HIHFKEJHDAH([In] EFACPNDLDKE DEBKLEONCCD)
	{
		return default(HLLDEEKGDLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAB80", Offset = "0x7AF9F80", VA = "0x187AFAB80")]
	public Enum MDLLLHCGCCP(Type HGEDOBCBGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x35291E0", Offset = "0x35285E0", VA = "0x1835291E0")]
	public void KFMFOPCGNHM<T>([In] T OOEMJLHLIHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAAF0", Offset = "0x7AF9EF0", VA = "0x187AFAAF0")]
	public void CLOGGJEPAMH(Enum AGBLNABJHCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct HLLDEEKGDLK
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct DEIHCKGCJEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* CCGDKJCMOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* LOBDIIAEBDB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type EAEMJJOLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> PBOIKHPFLNB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ICPKKBDGIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB0A0", Offset = "0x7AFA4A0", VA = "0x187AFB0A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KDKCIBNKBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB0B0", Offset = "0x7AFA4B0", VA = "0x187AFB0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E81240", Offset = "0x4E80640", VA = "0x184E81240")]
	public HLLDEEKGDLK(Type IPAAGGLPAIB, ReadOnlySpan<byte> EOJIKPFPLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3706AD0", Offset = "0x3705ED0", VA = "0x183706AD0")]
	public static HLLDEEKGDLK AIJMHMNEAAE<T>(T OOEMJLHLIHJ) where T : struct
	{
		return default(HLLDEEKGDLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB2D0", Offset = "0x7AFA6D0", VA = "0x187AFB2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB100", Offset = "0x7AFA500", VA = "0x187AFB100")]
	public object GHAJDLBLKPC(int COPLIEINKOF = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IHNEMCEODAC
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3729920", Offset = "0x3728D20", VA = "0x183729920")]
	public static NativeArray<T> AIJMHMNEAAE<T>(T OOEMJLHLIHJ, bool BOACKDBINIF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3729A30", Offset = "0x3728E30", VA = "0x183729A30")]
	public static NativeArray<T> KJOKLLMOMOM<T>(T OOEMJLHLIHJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3729970", Offset = "0x3728D70", VA = "0x183729970")]
	public static NativeArray<T> DKDCPCNPCGD<T>(T OOEMJLHLIHJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB830", Offset = "0x7AFAC30", VA = "0x187AFB830")]
	public static NativeArray<byte> DKDCPCNPCGD(ReadOnlySpan<byte> OOEMJLHLIHJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB780", Offset = "0x7AFAB80", VA = "0x187AFB780")]
	public static NativeArray<byte> AIJMHMNEAAE(ReadOnlySpan<byte> OOEMJLHLIHJ, bool BOACKDBINIF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB700", Offset = "0x7AFAB00", VA = "0x187AFB700")]
	public unsafe static NativeArray<byte> AIJMHMNEAAE(byte* JDDKEDJPIJN, int CFKBLDHNBAA, bool BOACKDBINIF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x37299C0", Offset = "0x3728DC0", VA = "0x1837299C0")]
	public static NativeArray<T> HGNIBOKIJFN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct ICJGAEHAHDO : IEquatable<ICJGAEHAHDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int EMPFLKDGLPP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type PLJKCMOLLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB450", Offset = "0x7AFA850", VA = "0x187AFB450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB660", Offset = "0x7AFAA60", VA = "0x187AFB660")]
	public ICJGAEHAHDO(Type KHNCICOHHHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB590", Offset = "0x7AFA990", VA = "0x187AFB590")]
	public static ICJGAEHAHDO HIHFKEJHDAH(Type KHNCICOHHHJ)
	{
		return default(ICJGAEHAHDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x20CB7E0", Offset = "0x20CABE0", VA = "0x1820CB7E0", Slot = "4")]
	public bool Equals(ICJGAEHAHDO DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB500", Offset = "0x7AFA900", VA = "0x187AFB500", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB620", Offset = "0x7AFAA20", VA = "0x187AFB620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class NLMPFCIFEPP
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> DDMGOOJIONM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> ODDDBNLFEFP;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7AFC890", Offset = "0x7AFBC90", VA = "0x187AFC890")]
	static NLMPFCIFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7AFC7D0", Offset = "0x7AFBBD0", VA = "0x187AFC7D0")]
	public static bool FGAAHPGCDNG(Type KHNCICOHHHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AFC5F0", Offset = "0x7AFB9F0", VA = "0x187AFC5F0")]
	private static bool FGAAHPGCDNG(Type KHNCICOHHHJ, [Out] int COPLIEINKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AFC830", Offset = "0x7AFBC30", VA = "0x187AFC830")]
	public static int KCMPOCLEKNE(Type KHNCICOHHHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7AFC570", Offset = "0x7AFB970", VA = "0x187AFC570")]
	public static Type DANLDNLMJMK(int COPLIEINKOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DHMDOJHKMAO<Handle> where Handle : KPKDAMONEJC, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct BOKDEJCKALD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly DHMDOJHKMAO<Handle> CJKIKLHHFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int COPLIEINKOF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle MDDBKHMECMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6088E20", Offset = "0x6088220", VA = "0x186088E20")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x60891E0", Offset = "0x60885E0", VA = "0x1860891E0")]
		public BOKDEJCKALD(DHMDOJHKMAO<Handle> CJKIKLHHFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6088C00", Offset = "0x6088000", VA = "0x186088C00")]
		public MDIBAFICDHB FABCCGGAHMJ([In] MDIBAFICDHB PLCJAHDMBHK)
		{
			return default(MDIBAFICDHB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6088FA0", Offset = "0x60883A0", VA = "0x186088FA0")]
		public bool OOODFKMFOLP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6088BA0", Offset = "0x6087FA0", VA = "0x186088BA0")]
		private Handle EDELCEBOLKM(string FGEBHLNNMNH)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct MDIBAFICDHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BOKDEJCKALD PLGJGJDBPDG;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x50B2320", Offset = "0x50B1720", VA = "0x1850B2320")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x50B2460", Offset = "0x50B1860", VA = "0x1850B2460")]
		public MDIBAFICDHB(DHMDOJHKMAO<Handle> CJKIKLHHFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x50B2360", Offset = "0x50B1760", VA = "0x1850B2360")]
		public bool OOODFKMFOLP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x50B23E0", Offset = "0x50B17E0", VA = "0x1850B23E0")]
		public MDIBAFICDHB PMMOLBDEIOM()
		{
			return default(MDIBAFICDHB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> FJKKEGONJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> PDLHECOOOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int CCNGJNMAAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int PJGMFILACFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool KLABIGKGKFB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MMGEIDHINCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6895650", Offset = "0x6894A50", VA = "0x186895650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MDIBAFICDHB PMNLDDPMBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6896F60", Offset = "0x6896360", VA = "0x186896F60")]
		get
		{
			return default(MDIBAFICDHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x68970D0", Offset = "0x68964D0", VA = "0x1868970D0")]
	public DHMDOJHKMAO(int LFOHOAHFJHB, Allocator LMMGDELCIGC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6895590", Offset = "0x6894990", VA = "0x186895590")]
	public void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x206FEE0", Offset = "0x206F2E0", VA = "0x18206FEE0")]
	public static int GHNOACFNDMO(int LLEKGMDPLMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D4CFA0", Offset = "0x2D4C3A0", VA = "0x182D4CFA0")]
	public static bool MKJNNNLEAJF(int LLEKGMDPLMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x68967B0", Offset = "0x6895BB0", VA = "0x1868967B0")]
	public bool KHEOOIEHAPK(int COPLIEINKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6895F80", Offset = "0x6895380", VA = "0x186895F80")]
	public bool GJMMJGPKPKP(Handle PAOMPCHHBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6896100", Offset = "0x6895500", VA = "0x186896100")]
	public Handle IFDMHBFAJGG()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x68956D0", Offset = "0x6894AD0", VA = "0x1868956D0")]
	public void GCLFLNCHOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x68962A0", Offset = "0x68956A0", VA = "0x1868962A0")]
	public void IGOHOLENKCO(Handle PAOMPCHHBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xD74840", Offset = "0xD73C40", VA = "0x180D74840")]
	private bool CGGAHCMEFMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6896B90", Offset = "0x6895F90", VA = "0x186896B90")]
	private bool KOFJCHNKDHF(int COPLIEINKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6896380", Offset = "0x6895780", VA = "0x186896380")]
	private void JPEBEOBFAIC([Out] int COPLIEINKOF, [Out] int IPCFHGIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6896A40", Offset = "0x6895E40", VA = "0x186896A40")]
	private void KIPACOEJFGO(Handle PAOMPCHHBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6895D50", Offset = "0x6895150", VA = "0x186895D50")]
	private void GGGPGGGGBHE(int COPLIEINKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6896C50", Offset = "0x6896050", VA = "0x186896C50")]
	private bool LKCKLLAEBLP([Out] int COPLIEINKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6896EA0", Offset = "0x68962A0", VA = "0x186896EA0")]
	private static Handle OGMFBCFHPIL(int COPLIEINKOF, int IPCFHGIMHJJ)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public struct DCJAOLDOCPL<Handle, T> where Handle : KPKDAMONEJC, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private DHMDOJHKMAO<Handle> OEOHKAIMFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] AIKGAOGLPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> IDJDLPLNJGB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6884030", Offset = "0x6883430", VA = "0x186884030")]
	public DCJAOLDOCPL(int LFOHOAHFJHB, [Optional] Action<T> IDJDLPLNJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6883370", Offset = "0x6882770", VA = "0x186883370")]
	public void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6883100", Offset = "0x6882500", VA = "0x186883100")]
	public bool ACKDGLPEIGD(Handle PAOMPCHHBKF, [Out] T KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6883400", Offset = "0x6882800", VA = "0x186883400")]
	public Handle FGAAHPGCDNG(T KLANNNFBLNB)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6883950", Offset = "0x6882D50", VA = "0x186883950")]
	public void MKMIPFJGBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6883D80", Offset = "0x6883180", VA = "0x186883D80")]
	public void NMPKBAOEGPN(Handle PAOMPCHHBKF, [Out] T OIIKLAKEKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6883CA0", Offset = "0x68830A0", VA = "0x186883CA0")]
	public void NMPKBAOEGPN(Handle PAOMPCHHBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6883280", Offset = "0x6882680", VA = "0x186883280")]
	private T AKADCJIMEOM(int COPLIEINKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6883640", Offset = "0x6882A40", VA = "0x186883640")]
	private void KKKALFDJHEM(int MEDJJOGDLEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct CCAHPDNPJJM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct DAJAIOPGCBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private CCAHPDNPJJM<T> IMLJIFPAFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int COPLIEINKOF;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x684C380", Offset = "0x684B780", VA = "0x18684C380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2725570", Offset = "0x2724970", VA = "0x182725570")]
		public DAJAIOPGCBC(CCAHPDNPJJM<T> IMLJIFPAFGH, int COPLIEINKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x684C3D0", Offset = "0x684B7D0", VA = "0x18684C3D0")]
		public bool OOODFKMFOLP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class BENJFDAPAIG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CCAHPDNPJJM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public BENJFDAPAIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F8FE10", Offset = "0x5F8F210", VA = "0x185F8FE10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5F8FEB0", Offset = "0x5F8F2B0", VA = "0x185F8FEB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DAMCPBLNCIG : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CCAHPDNPJJM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public DAMCPBLNCIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x684CD90", Offset = "0x684C190", VA = "0x18684CD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x684CE30", Offset = "0x684C230", VA = "0x18684CE30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] AOFGGGKINCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint OOEMJLHLIHJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GHEOBFHNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5630FD0", Offset = "0x56303D0", VA = "0x185630FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GHONCNALJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x645FB70", Offset = "0x645EF70", VA = "0x18645FB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HAHEDGIEFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x168C330", Offset = "0x168B730", VA = "0x18168C330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool EGOKCJBDEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6460170", Offset = "0x645F570", VA = "0x186460170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AENCKLAHHLP<T> PBOIKHPFLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x645FE90", Offset = "0x645F290", VA = "0x18645FE90")]
		get
		{
			return default(AENCKLAHHLP<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6460200", Offset = "0x645F600", VA = "0x186460200")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x64600C0", Offset = "0x645F4C0", VA = "0x1864600C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6460930", Offset = "0x645FD30", VA = "0x186460930")]
	internal CCAHPDNPJJM(CCAHPDNPJJM<T> IMLJIFPAFGH, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6460910", Offset = "0x645FD10", VA = "0x186460910")]
	private CCAHPDNPJJM(T[] IMLJIFPAFGH, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x64605C0", Offset = "0x645F9C0", VA = "0x1864605C0")]
	public CCAHPDNPJJM(IEnumerable<T> LMNAOMMMDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6460950", Offset = "0x645FD50", VA = "0x186460950")]
	public CCAHPDNPJJM(int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x64602D0", Offset = "0x645F6D0", VA = "0x1864602D0")]
	public int MJHCAIKEHEA(T OOEMJLHLIHJ, int KAHCMHKHPHM, int PCGLBCNIEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6460010", Offset = "0x645F410", VA = "0x186460010")]
	public void JEJPKCIOKAC(int MIDEJNJHKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x645FBA0", Offset = "0x645EFA0", VA = "0x18645FBA0")]
	private void EOBLMKNJIAH(int MIDEJNJHKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x645F920", Offset = "0x645ED20", VA = "0x18645F920")]
	public T[] BCACFNJEPFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x645FA20", Offset = "0x645EE20", VA = "0x18645FA20")]
	public T[] ECCHMOFPDMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x645F9A0", Offset = "0x645EDA0", VA = "0x18645F9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x645FD70", Offset = "0x645F170", VA = "0x18645FD70")]
	public void FIJOHEGOJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6460350", Offset = "0x645F750", VA = "0x186460350")]
	public DAJAIOPGCBC PMMOLBDEIOM()
	{
		return default(DAJAIOPGCBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x64603C0", Offset = "0x645F7C0", VA = "0x1864603C0", Slot = "5")]
	[IteratorStateMachine(typeof(CCAHPDNPJJM<>.BENJFDAPAIG))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x64604C0", Offset = "0x645F8C0", VA = "0x1864604C0", Slot = "6")]
	[IteratorStateMachine(typeof(CCAHPDNPJJM<>.DAMCPBLNCIG))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6460060", Offset = "0x645F460", VA = "0x186460060")]
	public static CCAHPDNPJJM<T> JIKEBJHHCNA(T[] IMLJIFPAFGH)
	{
		return default(CCAHPDNPJJM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x645FDE0", Offset = "0x645F1E0", VA = "0x18645FDE0")]
	public static CCAHPDNPJJM<T> HIHFKEJHDAH(T[] IMLJIFPAFGH)
	{
		return default(CCAHPDNPJJM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6460180", Offset = "0x645F580", VA = "0x186460180")]
	private void LCAPEMGCNEF(int COPLIEINKOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class OAGGALGHDAH<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct MGEPLODAKKK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private OAGGALGHDAH<T> ANHMDLEGCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int COPLIEINKOF;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x50BCAE0", Offset = "0x50BBEE0", VA = "0x1850BCAE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x50BCB20", Offset = "0x50BBF20", VA = "0x1850BCB20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4437690", Offset = "0x4436A90", VA = "0x184437690")]
		public MGEPLODAKKK(OAGGALGHDAH<T> ANHMDLEGCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x50BC9E0", Offset = "0x50BBDE0", VA = "0x1850BC9E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x50BCA90", Offset = "0x50BBE90", VA = "0x1850BCA90", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private CCAHPDNPJJM<T> AOFGGGKINCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int CFKBLDHNBAA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x532C5D0", Offset = "0x532B9D0", VA = "0x18532C5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int GHEOBFHNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x43AA570", Offset = "0x43A9970", VA = "0x1843AA570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int MMGEIDHINCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x532C000", Offset = "0x532B400", VA = "0x18532C000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool HAHEDGIEFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x532BFE0", Offset = "0x532B3E0", VA = "0x18532BFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public AENCKLAHHLP<T> PBOIKHPFLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x532C310", Offset = "0x532B710", VA = "0x18532C310")]
		get
		{
			return default(AENCKLAHHLP<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x532CA50", Offset = "0x532BE50", VA = "0x18532CA50")]
	public OAGGALGHDAH(IEnumerable<T> LMNAOMMMDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x532C9E0", Offset = "0x532BDE0", VA = "0x18532C9E0")]
	public OAGGALGHDAH(int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x481A3C0", Offset = "0x48197C0", VA = "0x18481A3C0")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x532BB80", Offset = "0x532AF80", VA = "0x18532BB80")]
	public CCAHPDNPJJM<T> AOIKOACMAPJ()
	{
		return default(CCAHPDNPJJM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x532BEB0", Offset = "0x532B2B0", VA = "0x18532BEB0")]
	public void FGAAHPGCDNG(T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x532C3A0", Offset = "0x532B7A0", VA = "0x18532C3A0")]
	private void JEJPKCIOKAC(int NPKCINNDJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x532BC80", Offset = "0x532B080", VA = "0x18532BC80")]
	public void EIANDGJLNFO(List<T> NFMDGGFOHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x532BE10", Offset = "0x532B210", VA = "0x18532BE10")]
	public void EIANDGJLNFO(T[] NFMDGGFOHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x532BA90", Offset = "0x532AE90", VA = "0x18532BA90")]
	public void ADMEPAJDPKD(int COPLIEINKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x532C3E0", Offset = "0x532B7E0", VA = "0x18532C3E0")]
	public void KNDFCGGGKBI(int HABFONNAGNK, int CBHCNOAGPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x532C650", Offset = "0x532BA50", VA = "0x18532C650")]
	public int MJHCAIKEHEA(T OOEMJLHLIHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x532C1F0", Offset = "0x532B5F0", VA = "0x18532C1F0")]
	public bool HEMHPGJLPIO(T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x532BC00", Offset = "0x532B000", VA = "0x18532BC00")]
	public T[] ECCHMOFPDMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x532BBD0", Offset = "0x532AFD0", VA = "0x18532BBD0", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x532C240", Offset = "0x532B640", VA = "0x18532C240")]
	public static CCAHPDNPJJM<T> HIHFKEJHDAH(OAGGALGHDAH<T> ANHMDLEGCDL)
	{
		return default(CCAHPDNPJJM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x532C170", Offset = "0x532B570", VA = "0x18532C170", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x532C930", Offset = "0x532BD30", VA = "0x18532C930", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x532C970", Offset = "0x532BD70", VA = "0x18532C970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x532C020", Offset = "0x532B420", VA = "0x18532C020")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void GDPBCCCKBFM(int OOEMJLHLIHJ, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x532C6E0", Offset = "0x532BAE0", VA = "0x18532C6E0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PDJMICJBDNB(int HABFONNAGNK, int CBHCNOAGPIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class IACHKALEDCD
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3720D00", Offset = "0x3720100", VA = "0x183720D00")]
	public static void FIJOHEGOJLD<T>(this OAGGALGHDAH<T> ANHMDLEGCDL) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public ref struct AENCKLAHHLP<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> AOFGGGKINCN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x48B0A10", Offset = "0x48AFE10", VA = "0x1848B0A10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x48B09E0", Offset = "0x48AFDE0", VA = "0x1848B09E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int GHEOBFHNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x48B0AA0", Offset = "0x48AFEA0", VA = "0x1848B0AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public AENCKLAHHLP(Span<object> EOJIKPFPLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x48B0730", Offset = "0x48AFB30", VA = "0x1848B0730")]
	public AENCKLAHHLP<T> AELFOHHBELB(int KAHCMHKHPHM)
	{
		return default(AENCKLAHHLP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x48B0800", Offset = "0x48AFC00", VA = "0x1848B0800")]
	public AENCKLAHHLP<T> AELFOHHBELB(int KAHCMHKHPHM, int CFKBLDHNBAA)
	{
		return default(AENCKLAHHLP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x48B0930", Offset = "0x48AFD30", VA = "0x1848B0930")]
	public void GEKINDBKALD(AENCKLAHHLP<T> OLFPLCPBLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x48B0AE0", Offset = "0x48AFEE0", VA = "0x1848B0AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x48B08E0", Offset = "0x48AFCE0", VA = "0x1848B08E0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x48B0990", Offset = "0x48AFD90", VA = "0x1848B0990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct OIJNMGBLDKP : IEquatable<OIJNMGBLDKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int IALPEJIGIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int PCGLBCNIEAP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int BGMAPKEKIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AC0", Offset = "0x2D40EC0", VA = "0x182D41AC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6D25A80", Offset = "0x6D24E80", VA = "0x186D25A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int OFAOKNAOJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int JKFMEKJLDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCAE0", Offset = "0x7AFBEE0", VA = "0x187AFCAE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCB90", Offset = "0x7AFBF90", VA = "0x187AFCB90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public (int begin, int end) LBIGOHKBAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCA80", Offset = "0x7AFBE80", VA = "0x187AFCA80")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xCE0AB0", Offset = "0xCDFEB0", VA = "0x180CE0AB0")]
	private OIJNMGBLDKP(int IALPEJIGIPD, int PCGLBCNIEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x27170F0", Offset = "0x27164F0", VA = "0x1827170F0")]
	public static OIJNMGBLDKP KECCIMMHNCK(int IALPEJIGIPD, int PCGLBCNIEAP)
	{
		return default(OIJNMGBLDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7AFCB80", Offset = "0x7AFBF80", VA = "0x187AFCB80")]
	public static OIJNMGBLDKP JOEOHAAOJPK(int KAHCMHKHPHM, int CBHCNOAGPIM)
	{
		return default(OIJNMGBLDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7AFCBA0", Offset = "0x7AFBFA0", VA = "0x187AFCBA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x18550E0", Offset = "0x18544E0", VA = "0x1818550E0", Slot = "4")]
	public bool Equals(OIJNMGBLDKP DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7AFCAF0", Offset = "0x7AFBEF0", VA = "0x187AFCAF0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E74080", Offset = "0x6E73480", VA = "0x186E74080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct NADMNDBKFCC<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> AOFGGGKINCN;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
	public NADMNDBKFCC(NativeArray<T> AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5152F90", Offset = "0x5152390", VA = "0x185152F90", Slot = "6")]
	public int Compare(int COBPEJEHIHC, int CEJJJCAALLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5153080", Offset = "0x5152480", VA = "0x185153080", Slot = "4")]
	public bool Equals(int COBPEJEHIHC, int CEJJJCAALLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5153170", Offset = "0x5152570", VA = "0x185153170", Slot = "5")]
	public int GetHashCode(int COBPEJEHIHC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NNKCEMJFCAG
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3862C60", Offset = "0x3862060", VA = "0x183862C60")]
	public static T[] EDDLKFOMDHG<T>(List<T> ANHMDLEGCDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct KLEIOCOMPJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* PLCOMHNDHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle LGJKMOHOBMI;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5914B90", Offset = "0x5913F90", VA = "0x185914B90")]
	public void BKMLDGFOOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DFFHNHFNCGI
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x34FD090", Offset = "0x34FC490", VA = "0x1834FD090")]
	public static KLEIOCOMPJC NDOPJHAJLBH<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> PPJCHOKILKM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(KLEIOCOMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x34FD090", Offset = "0x34FC490", VA = "0x1834FD090")]
	public static UnsafeParallelHashMap<TKey, TValue> PLBOAANKADN<TKey, TValue>(this KLEIOCOMPJC PPJCHOKILKM) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CNPKMJDBBHN
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x34C6F10", Offset = "0x34C6310", VA = "0x1834C6F10")]
	public static int DFPLBBHCLAL<T>(ReadOnlySpan<T> IJEJHIHAMBN, ReadOnlySpan<T> BOCKPIHNKLD, int CFKBLDHNBAA) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class FPDPFPOMCCI
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3695580", Offset = "0x3694980", VA = "0x183695580")]
	public static T PIILCCNLJDB<T>(this NativeArray<byte> BHCEDEKBMHE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3694ED0", Offset = "0x36942D0", VA = "0x183694ED0")]
	public static NativeArray<T> KMKPPHJNFAI<T>(this NativeArray<byte> BHCEDEKBMHE, int PCGLBCNIEAP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3695390", Offset = "0x3694790", VA = "0x183695390")]
	public static void NCDIIFOABOB<T>(this NativeList<byte> CMLCOMAALAL, [In] T OOEMJLHLIHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x36952F0", Offset = "0x36946F0", VA = "0x1836952F0")]
	public static void NCDIIFOABOB<T>(this NativeList<byte> CMLCOMAALAL, NativeArray<T> OOEMJLHLIHJ) where T : struct
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

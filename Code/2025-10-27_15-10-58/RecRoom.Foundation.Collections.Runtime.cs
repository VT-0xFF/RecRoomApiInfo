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
using RecRoom.Foundation.Attributes;
using RecRoom.Foundation.Collections;
using RecRoom.Logging;
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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Foundation_Collections_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x871FC10", Offset = "0x871EC10", VA = "0x18871FC10", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[NamespaceException]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3B55350", Offset = "0x3B54350", VA = "0x183B55350")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[NamespaceException]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B55AC0", Offset = "0x3B54AC0", VA = "0x183B55AC0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3B5B170", Offset = "0x3B5A170", VA = "0x183B5B170")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3B5A310", Offset = "0x3B59310", VA = "0x183B5A310")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3B5A680", Offset = "0x3B59680", VA = "0x183B5A680")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B5B840", Offset = "0x3B5A840", VA = "0x183B5B840")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3B55CC0", Offset = "0x3B54CC0", VA = "0x183B55CC0")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B55F10", Offset = "0x3B54F10", VA = "0x183B55F10")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B57140", Offset = "0x3B56140", VA = "0x183B57140")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, RecRoom.Foundation.Collections.Range range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B56D30", Offset = "0x3B55D30", VA = "0x183B56D30")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B566F0", Offset = "0x3B556F0", VA = "0x183B566F0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B553D0", Offset = "0x3B543D0", VA = "0x183B553D0")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3B5A4C0", Offset = "0x3B594C0", VA = "0x183B5A4C0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[NamespaceException]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B66C80", Offset = "0x3B65C80", VA = "0x183B66C80")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B68430", Offset = "0x3B67430", VA = "0x183B68430")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B683D0", Offset = "0x3B673D0", VA = "0x183B683D0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5289030", Offset = "0x5288030", VA = "0x185289030")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x871FDA0", Offset = "0x871EDA0", VA = "0x18871FDA0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x871FDD0", Offset = "0x871EDD0", VA = "0x18871FDD0")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B672E0", Offset = "0x3B662E0", VA = "0x183B672E0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B68380", Offset = "0x3B67380", VA = "0x183B68380")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B67600", Offset = "0x3B66600", VA = "0x183B67600")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B675A0", Offset = "0x3B665A0", VA = "0x183B675A0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B67540", Offset = "0x3B66540", VA = "0x183B67540")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B66F40", Offset = "0x3B65F40", VA = "0x183B66F40")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B67970", Offset = "0x3B66970", VA = "0x183B67970")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B677C0", Offset = "0x3B667C0", VA = "0x183B677C0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3B67040", Offset = "0x3B66040", VA = "0x183B67040")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B66E50", Offset = "0x3B65E50", VA = "0x183B66E50")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B66DA0", Offset = "0x3B65DA0", VA = "0x183B66DA0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3B68930", Offset = "0x3B67930", VA = "0x183B68930")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3B68530", Offset = "0x3B67530", VA = "0x183B68530")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B68CB0", Offset = "0x3B67CB0", VA = "0x183B68CB0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B68D50", Offset = "0x3B67D50", VA = "0x183B68D50")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[NamespaceException]
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
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5257130", Offset = "0x5256130", VA = "0x185257130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x137A0E0", Offset = "0x13790E0", VA = "0x18137A0E0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x510B4A0", Offset = "0x510A4A0", VA = "0x18510B4A0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B87830", Offset = "0x5B86830", VA = "0x185B87830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B87B70", Offset = "0x5B86B70", VA = "0x185B87B70")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F610", Offset = "0x3C7E610", VA = "0x183C7F610")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[NamespaceException]
	public readonly struct NativeListAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly NativeList<T> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5C1A780", Offset = "0x5C19780", VA = "0x185C1A780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5C1A7B0", Offset = "0x5C197B0", VA = "0x185C1A7B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2D80E90", Offset = "0x2D7FE90", VA = "0x182D80E90")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NativeList<T> List
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xC10050", Offset = "0xC0F050", VA = "0x180C10050")]
			get
			{
				return default(NativeList<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x55BB910", Offset = "0x55BA910", VA = "0x1855BB910")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C19CD0", Offset = "0x5C18CD0", VA = "0x185C19CD0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5C19FA0", Offset = "0x5C18FA0", VA = "0x185C19FA0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C1A630", Offset = "0x5C19630", VA = "0x185C1A630", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5C1A470", Offset = "0x5C19470", VA = "0x185C1A470")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NamespaceException]
	public static class RRAllocator
	{
	}
}
namespace Unity.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[NamespaceException]
	public static class HKMURMNAMSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x871F140", Offset = "0x871E140", VA = "0x18871F140")]
		public static JobHandle ZWYTQESVSOF(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x871F090", Offset = "0x871E090", VA = "0x18871F090")]
		public static JobHandle ABNOZLHRGXY(this Span<JobHandle> a)
		{
			return default(JobHandle);
		}
	}
}
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class OKOXMIBHDDW
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x35CF3A0", Offset = "0x35CE3A0", VA = "0x1835CF3A0")]
		public static void Clear<T>(this T[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class UNVYPYFUXNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3EEE930", Offset = "0x3EED930", VA = "0x183EEE930")]
		public static NativeKeyValueArrays<TKey, TValue> OAXFLSPASHT<TKey, TValue>(this Dictionary<TKey, TValue> a, Allocator b) where TKey : struct where TValue : struct
		{
			return default(NativeKeyValueArrays<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class FPJJJINLHVU
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x871EE10", Offset = "0x871DE10", VA = "0x18871EE10")]
		public static void HRRILZOLWBM(this GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x871EED0", Offset = "0x871DED0", VA = "0x18871EED0")]
		public static void HRRILZOLWBM(this Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x871ED50", Offset = "0x871DD50", VA = "0x18871ED50")]
		public static void HRRILZOLWBM(this ScriptableObject a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class OXNWTEXMMQQ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87206F0", Offset = "0x871F6F0", VA = "0x1887206F0")]
		public static void ZIGIXXBWWGZ(this NativeList<byte> a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3B938B0", Offset = "0x3B928B0", VA = "0x183B938B0")]
		public static void RDOWHFKLBTH<T>(this NativeList<T> a, T b, int c) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class IOKKZEIMZMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x39EED00", Offset = "0x39EDD00", VA = "0x1839EED00")]
		public static d MTIYOTODKSM<d>(this ReadOnlySpan<byte> a) where d : struct
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x39EE310", Offset = "0x39ED310", VA = "0x1839EE310")]
		public static k HNZRSNBGJKB<k>(this Span<k> a, Func<k, bool> b)
		{
			return (k)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x39ED8B0", Offset = "0x39EC8B0", VA = "0x1839ED8B0")]
		public static bool All<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x39EDB10", Offset = "0x39ECB10", VA = "0x1839EDB10")]
		public static bool Any<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x39EDD90", Offset = "0x39ECD90", VA = "0x1839EDD90")]
		public static T Get<T>([In] this ReadOnlySpan<byte> span) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x39EEBC0", Offset = "0x39EDBC0", VA = "0x1839EEBC0")]
		public static Span<q> MEAPSJCTBNU<q, p>(this Span<p> a) where q : struct where p : struct
		{
			return default(Span<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x39EE5A0", Offset = "0x39ED5A0", VA = "0x1839EE5A0")]
		public static ReadOnlySpan<s> MEAPSJCTBNU<s, r>(this ReadOnlySpan<r> a) where s : struct where r : struct
		{
			return default(ReadOnlySpan<s>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x39EEB10", Offset = "0x39EDB10", VA = "0x1839EEB10")]
		public static ReadOnlySpan<t> MEAPSJCTBNU<t>(this ReadOnlySpan<byte> a) where t : struct
		{
			return default(ReadOnlySpan<t>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x39EDBB0", Offset = "0x39ECBB0", VA = "0x1839EDBB0")]
		public static Span<T> Clone<T>(this ReadOnlySpan<T> src) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x39EEFC0", Offset = "0x39EDFC0", VA = "0x1839EEFC0")]
		public static Span<byte> Set<T>([In] this Span<byte> span, T value) where T : struct
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x871F690", Offset = "0x871E690", VA = "0x18871F690")]
		private static Enum ZKLZAUTYXGM([In] ReadOnlySpan<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x871F620", Offset = "0x871E620", VA = "0x18871F620")]
		public static Enum KGTMDYWDJWS([In] this Span<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x871F180", Offset = "0x871E180", VA = "0x18871F180")]
		public static void EIDPDKEHQJM([In] this Span<byte> span, Enum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class VHISKPYTOOO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <TrapExceptions>d__1 : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x8720CB0", Offset = "0x871FCB0", VA = "0x188720CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8720E60", Offset = "0x871FE60", VA = "0x188720E60")]
		[AsyncStateMachine(typeof(<TrapExceptions>d__1))]
		public static void NUZSLCBDOCA(this Task a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class XPUSXLKZAOZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3F56C90", Offset = "0x3F55C90", VA = "0x183F56C90")]
		public static NativeArray<T> GZEGILNTYBA<T>(this UnsafeList<T> a) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3F56DB0", Offset = "0x3F55DB0", VA = "0x183F56DB0")]
		public static NativeArray<T> QPBEWOMMLIV<T>(this UnsafeList<T> a, bool b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3F56B80", Offset = "0x3F55B80", VA = "0x183F56B80")]
		public static UnsafeList<T> Clone<T>(this UnsafeList<T> list, Allocator allocator) where T : struct
		{
			return default(UnsafeList<T>);
		}
	}
}
namespace RecRoom.Foundation.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class DWNHBZQBHHG
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum Key : short
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
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Key key;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x327D090", Offset = "0x327C090", VA = "0x18327D090")]
			public Scope(Key key)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static ProfilerCategory ACWIOVHNSUV;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x871ECC0", Offset = "0x871DCC0", VA = "0x18871ECC0")]
		static DWNHBZQBHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x35EB600", Offset = "0x35EA600", VA = "0x1835EB600")]
		public static Scope CJAMBFSELHG(Key a)
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public static void YUJHIPRWVQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class ONWWWUJDEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3B8AFF0", Offset = "0x3B89FF0", VA = "0x183B8AFF0")]
		public static DisposableTuple<a, b> CSUOVCCAHVR<a, b>(this (a, b) a) where a : struct, IDisposable where b : struct, IDisposable
		{
			return default(DisposableTuple<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3B8B070", Offset = "0x3B8A070", VA = "0x183B8B070")]
		public static DisposableTuple<c, d, e> CSUOVCCAHVR<c, d, e>(this (c, d, e) a) where c : struct, IDisposable where d : struct, IDisposable where e : struct, IDisposable
		{
			return default(DisposableTuple<c, d, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct DisposableTuple<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private (T1, T2) tuple;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2D968F0", Offset = "0x2D958F0", VA = "0x182D968F0")]
		public DisposableTuple((T1, T2) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4EFC0", Offset = "0x4A4DFC0", VA = "0x184A4EFC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct DisposableTuple<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private (T1, T2, T3) tuple;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4A4F320", Offset = "0x4A4E320", VA = "0x184A4F320")]
		public DisposableTuple((T1, T2, T3) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4A4F730", Offset = "0x4A4E730", VA = "0x184A4F730", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ZQIHTJXDWUA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8720F80", Offset = "0x871FF80", VA = "0x188720F80")]
		public static System.Range DRZWSSCHSTP(this Range a)
		{
			return default(System.Range);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class APDTISPSEKY
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct Enumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private int current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly int end;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int NHMTQMXSIMG
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x871ED40", Offset = "0x871DD40", VA = "0x18871ED40")]
			public Enumerator(int start, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x871ED30", Offset = "0x871DD30", VA = "0x18871ED30")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x871EC70", Offset = "0x871DC70", VA = "0x18871EC70")]
		public static Enumerator GetEnumerator(this System.Range range)
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Handle<T> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GCHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool YKYKIBMBZCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2DD9180", Offset = "0x2DD8180", VA = "0x182DD9180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5289750", Offset = "0x5288750", VA = "0x185289750")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5289060", Offset = "0x5288060", VA = "0x185289060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5289D70", Offset = "0x5288D70", VA = "0x185289D70")]
		public Handle(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5289030", Offset = "0x5288030", VA = "0x185289030", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HWQUGTLNKCM<a, b> : IDisposable where a : struct, DCWCRPUQWSC where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly List<a> GSOIESSQCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly List<b> GFYWHAFSBXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Func<b> FQALLBEEKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<b> AGRJRNYQAWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int TMKTDDYLLZF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public b this[a handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5275BB0", Offset = "0x5274BB0", VA = "0x185275BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5275920", Offset = "0x5274920", VA = "0x185275920")]
		public HWQUGTLNKCM(Action<b> a, [Optional] Func<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5273930", Offset = "0x5272930", VA = "0x185273930", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5272CB0", Offset = "0x5271CB0", VA = "0x185272CB0")]
		public a Add(b value)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x52737F0", Offset = "0x52727F0", VA = "0x1852737F0")]
		public bool Destroy(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5274450", Offset = "0x5273450", VA = "0x185274450")]
		public bool KGQSFJCPHOW(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5274260", Offset = "0x5273260", VA = "0x185274260")]
		public b Get(a handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5273B10", Offset = "0x5272B10", VA = "0x185273B10")]
		public bool Exists(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5274090", Offset = "0x5273090", VA = "0x185274090")]
		private a FCZCSZHWJDD(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5274930", Offset = "0x5273930", VA = "0x185274930")]
		private b ULHBYTJZYOM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5274650", Offset = "0x5273650", VA = "0x185274650")]
		private void NRDPXNHCVIF(int a, [In] a handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x52735B0", Offset = "0x52725B0", VA = "0x1852735B0")]
		private void DXOIUIGRXFW(int a, [In] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5272F20", Offset = "0x5271F20", VA = "0x185272F20")]
		private a CXVPZLJAQGE()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5274FB0", Offset = "0x5273FB0", VA = "0x185274FB0")]
		private void XMUGNCFXCLX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5274960", Offset = "0x5273960", VA = "0x185274960")]
		private int UYYVLNYUXOO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5272F10", Offset = "0x5271F10", VA = "0x185272F10")]
		private bool BNYQCZNUTRJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xACFF80", Offset = "0xACEF80", VA = "0x180ACFF80")]
		private void NBGSIGLEFJB(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5274770", Offset = "0x5273770", VA = "0x185274770")]
		private bool SBLPFSHNUPM([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5275050", Offset = "0x5274050", VA = "0x185275050")]
		private bool YHCLRGZYSSX([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5274A90", Offset = "0x5273A90", VA = "0x185274A90")]
		private void VOKXVAFXNES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface DCWCRPUQWSC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class FTALXXLPUVX
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x397ECD0", Offset = "0x397DCD0", VA = "0x18397ECD0")]
		public static bool ZYMPQSOILYK<a>(this a a, a b) where a : struct, DCWCRPUQWSC
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x397EA40", Offset = "0x397DA40", VA = "0x18397EA40")]
		public static bool IsValid<T>(this T handle) where T : struct, DCWCRPUQWSC
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x871EF90", Offset = "0x871DF90", VA = "0x18871EF90")]
		public static string LELNCMIMJST(this DCWCRPUQWSC a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public ref struct MutableRef
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly Type ValueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly Span<byte> Span;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x55BB910", Offset = "0x55BA910", VA = "0x1855BB910")]
		public MutableRef(Type valueType, Span<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3B4ECC0", Offset = "0x3B4DCC0", VA = "0x183B4ECC0")]
		public static MutableRef From<T>(T value) where T : struct
		{
			return default(MutableRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x871FD20", Offset = "0x871ED20", VA = "0x18871FD20")]
		public static implicit operator ReadOnlyRef([In] MutableRef r)
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x871FCA0", Offset = "0x871ECA0", VA = "0x18871FCA0")]
		public Enum KGTMDYWDJWS(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3B4F350", Offset = "0x3B4E350", VA = "0x183B4F350")]
		public void Set<T>([In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x871FC90", Offset = "0x871EC90", VA = "0x18871FC90")]
		public void EIDPDKEHQJM(Enum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public ref struct ReadOnlyRef
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private struct ObjectOffsetType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private unsafe void* v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private unsafe void* v1;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly Type ValueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly ReadOnlySpan<byte> Span;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int BRIGWJLJSBI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8720CA0", Offset = "0x871FCA0", VA = "0x188720CA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int JXPVANCLBFE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8720C50", Offset = "0x871FC50", VA = "0x188720C50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x55BB910", Offset = "0x55BA910", VA = "0x1855BB910")]
		public ReadOnlyRef(Type valueType, ReadOnlySpan<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DAC0", Offset = "0x3D4CAC0", VA = "0x183D4DAC0")]
		public static ReadOnlyRef From<T>(T value) where T : struct
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8720AD0", Offset = "0x871FAD0", VA = "0x188720AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8720900", Offset = "0x871F900", VA = "0x188720900")]
		public object EAJMDFBRQDR(int a = 0)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct NativeElement
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3B69520", Offset = "0x3B68520", VA = "0x183B69520")]
		public static NativeArray<T> From<T>(T value, bool isReadOnly) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3B69610", Offset = "0x3B68610", VA = "0x183B69610")]
		public static NativeArray<a> NBQYBOUSIGG<a>(a a) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3B69610", Offset = "0x3B68610", VA = "0x183B69610")]
		public static NativeArray<b> NGNHNVEHASO<b>(b a) where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x871FF30", Offset = "0x871EF30", VA = "0x18871FF30")]
		public static NativeArray<byte> NGNHNVEHASO(ReadOnlySpan<byte> a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x871FE80", Offset = "0x871EE80", VA = "0x18871FE80")]
		public static NativeArray<byte> From(ReadOnlySpan<byte> value, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x871FE00", Offset = "0x871EE00", VA = "0x18871FE00")]
		public unsafe static NativeArray<byte> From(byte* ptr, int length, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3B69410", Offset = "0x3B68410", VA = "0x183B69410")]
		public static NativeArray<T> Empty<T>() where T : struct
		{
			return default(NativeArray<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public readonly struct NativeTypeHandle : IEquatable<NativeTypeHandle>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int typeIndex;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Type OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x871FFF0", Offset = "0x871EFF0", VA = "0x18871FFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8720170", Offset = "0x871F170", VA = "0x188720170")]
		public NativeTypeHandle(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8720210", Offset = "0x871F210", VA = "0x188720210")]
		public static implicit operator NativeTypeHandle(Type type)
		{
			return default(NativeTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x25CB800", Offset = "0x25CA800", VA = "0x1825CB800", Slot = "4")]
		public bool Equals(NativeTypeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x87200A0", Offset = "0x871F0A0", VA = "0x1887200A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8720130", Offset = "0x871F130", VA = "0x188720130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class OGYQJJYCVKH
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static Dictionary<Type, int> UGQGEXZPOAU;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<Type> JWVOZPNJBQW;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8720590", Offset = "0x871F590", VA = "0x188720590")]
		static OGYQJJYCVKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8720450", Offset = "0x871F450", VA = "0x188720450")]
		public static bool Add(Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x87202A0", Offset = "0x871F2A0", VA = "0x1887202A0")]
		private static bool Add(Type type, [Out] int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x87204B0", Offset = "0x871F4B0", VA = "0x1887204B0")]
		public static int FOCTAALLYUZ(Type a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8720510", Offset = "0x871F510", VA = "0x188720510")]
		public static Type Get(int index)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct HandlePool<Handle> where Handle : DCWCRPUQWSC, new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private struct BaseIndexEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private readonly HandlePool<Handle> pool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public Handle ISPDKJIMNTG
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x40F6D90", Offset = "0x40F5D90", VA = "0x1840F6D90")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x40F74B0", Offset = "0x40F64B0", VA = "0x1840F74B0")]
			public BaseIndexEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x40F7430", Offset = "0x40F6430", VA = "0x1840F7430")]
			public LiveHandleEnumerator New([In] LiveHandleEnumerator _)
			{
				return default(LiveHandleEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x40F7330", Offset = "0x40F6330", VA = "0x1840F7330")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x40F71B0", Offset = "0x40F61B0", VA = "0x1840F71B0")]
			private Handle MYGRPTPVIAS(string a)
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct LiveHandleEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private BaseIndexEnumerator @base;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public Handle NHMTQMXSIMG
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x5AC8B40", Offset = "0x5AC7B40", VA = "0x185AC8B40")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x5AC8CB0", Offset = "0x5AC7CB0", VA = "0x185AC8CB0")]
			public LiveHandleEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5AC8C70", Offset = "0x5AC7C70", VA = "0x185AC8C70")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5AC8AD0", Offset = "0x5AC7AD0", VA = "0x185AC8AD0")]
			public LiveHandleEnumerator GetEnumerator()
			{
				return default(LiveHandleEnumerator);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NativeList<int> versionTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeList<int> freeIndexStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int liveIndexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool isCreated;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int TJKWDSPKIXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5288000", Offset = "0x5287000", VA = "0x185288000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LiveHandleEnumerator MZBLAQKTBXA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x5287A20", Offset = "0x5286A20", VA = "0x185287A20")]
			get
			{
				return default(LiveHandleEnumerator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5288F60", Offset = "0x5287F60", VA = "0x185288F60")]
		public HandlePool(int initialCapacity, Allocator allocator = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5287890", Offset = "0x5286890", VA = "0x185287890")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2600300", Offset = "0x25FF300", VA = "0x182600300")]
		public static int UYYVLNYUXOO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x329F1B0", Offset = "0x329E1B0", VA = "0x18329F1B0")]
		public static bool DHPYQRBMJUB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5288DA0", Offset = "0x5287DA0", VA = "0x185288DA0")]
		public bool XFHJQXRPAEJ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5288640", Offset = "0x5287640", VA = "0x185288640")]
		public bool QFTZICNPBHD(Handle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5287040", Offset = "0x5286040", VA = "0x185287040")]
		public Handle BWRXLPYKLFL()
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5287140", Offset = "0x5286140", VA = "0x185287140")]
		public void CMMWJQPDYCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5288920", Offset = "0x5287920", VA = "0x185288920")]
		public void SCTNDQUPUTG(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xBF9560", Offset = "0xBF8560", VA = "0x180BF9560")]
		private bool GTXXMLBYGBX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5287940", Offset = "0x5286940", VA = "0x185287940")]
		private bool EJODCJTFAMB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5286B40", Offset = "0x5285B40", VA = "0x185286B40")]
		private void AZYSSHWUKOE([Out] int a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5287AA0", Offset = "0x5286AA0", VA = "0x185287AA0")]
		private void GQJQIMUBVKK(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5288B90", Offset = "0x5287B90", VA = "0x185288B90")]
		private void TSPHUIWXDEZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5288990", Offset = "0x5287990", VA = "0x185288990")]
		private bool SPFDXWGLTJP([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x52867A0", Offset = "0x52857A0", VA = "0x1852867A0")]
		private static Handle AFRUSKTGJRN(int a, int b)
		{
			return (Handle)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DefaultMember("Item")]
	public struct ManagedObjectPool<Handle, T> where Handle : DCWCRPUQWSC, new() where T : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private HandlePool<Handle> handlePool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T[] objectPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Action<T> onRemoved;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D740", Offset = "0x5B1C740", VA = "0x185B1D740")]
		public ManagedObjectPool(int initialCapacity, [Optional] Action<T> onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D1B0", Offset = "0x5B1C1B0", VA = "0x185B1D1B0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D2A0", Offset = "0x5B1C2A0", VA = "0x185B1D2A0")]
		public bool KGQSFJCPHOW(Handle a, [Out] T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D0A0", Offset = "0x5B1C0A0", VA = "0x185B1D0A0")]
		public Handle Add(T obj)
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D530", Offset = "0x5B1C530", VA = "0x185B1D530")]
		public void UBYPHYYJOEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D350", Offset = "0x5B1C350", VA = "0x185B1D350")]
		public void Remove(Handle handle, [Out] T oldObj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D430", Offset = "0x5B1C430", VA = "0x185B1D430")]
		public void Remove(Handle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D4D0", Offset = "0x5B1C4D0", VA = "0x185B1D4D0")]
		private T TENYFZSMMXG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5B1D230", Offset = "0x5B1C230", VA = "0x185B1D230")]
		private void JLGLSOTVVZB(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct RentedArray<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public struct Enumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private RentedArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public T NHMTQMXSIMG
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x4ACA720", Offset = "0x4AC9720", VA = "0x184ACA720")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B9AF90", Offset = "0x2B99F90", VA = "0x182B9AF90")]
			public Enumerator(RentedArray<T> array, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x4ACAD50", Offset = "0x4AC9D50", VA = "0x184ACAD50")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class FCPVAGYCOAG : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private T IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RentedArray<T> FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int GLLQGAOFNOJ;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private T PEDEZSFHGFS
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public FCPVAGYCOAG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x508C1B0", Offset = "0x508B1B0", VA = "0x18508C1B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x405A760", Offset = "0x4059760", VA = "0x18405A760", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class IFNCROUEUOT : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private object IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public RentedArray<T> FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private int GLLQGAOFNOJ;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private object YFFTPSTGFHY
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public IFNCROUEUOT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x508C1B0", Offset = "0x508B1B0", VA = "0x18508C1B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x405A760", Offset = "0x4059760", VA = "0x18405A760", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private object[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private uint value;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6022AA0", Offset = "0x6021AA0", VA = "0x186022AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool TECFEJJOIIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x60BC720", Offset = "0x60BB720", VA = "0x1860BC720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool VPWVGDBDRGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1B28B00", Offset = "0x1B27B00", VA = "0x181B28B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal bool HXFNANWIWNQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x60BCB20", Offset = "0x60BBB20", VA = "0x1860BCB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public RentedSpan<T> PABJBXNBIMV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x60BC9A0", Offset = "0x60BB9A0", VA = "0x1860BC9A0")]
			get
			{
				return default(RentedSpan<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x60BCF60", Offset = "0x60BBF60", VA = "0x1860BCF60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x60BD0C0", Offset = "0x60BC0C0", VA = "0x1860BD0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x60BCF20", Offset = "0x60BBF20", VA = "0x1860BCF20")]
		internal RentedArray(RentedArray<T> array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60BCF40", Offset = "0x60BBF40", VA = "0x1860BCF40")]
		private RentedArray(T[] array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x60BCC20", Offset = "0x60BBC20", VA = "0x1860BCC20")]
		public RentedArray(IEnumerable<T> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x60BCBB0", Offset = "0x60BBBB0", VA = "0x1860BCBB0")]
		public RentedArray(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x60BC750", Offset = "0x60BB750", VA = "0x1860BC750")]
		public int XHFPNJIIPWS(T a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x60BC390", Offset = "0x60BB390", VA = "0x1860BC390")]
		public void GXDDXFJJIDX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x60BC7D0", Offset = "0x60BB7D0", VA = "0x1860BC7D0")]
		private void XWWYTVURDCL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x60BCB30", Offset = "0x60BBB30", VA = "0x1860BCB30")]
		public T[] ZTGPHHWYDCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60BC1B0", Offset = "0x60BB1B0", VA = "0x1860BC1B0")]
		public T[] BYZVBLKPVJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60BC310", Offset = "0x60BB310", VA = "0x1860BC310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x60BC6B0", Offset = "0x60BB6B0", VA = "0x1860BC6B0")]
		public void WLMSFQTYJAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60BC3E0", Offset = "0x60BB3E0", VA = "0x1860BC3E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60BC570", Offset = "0x60BB570", VA = "0x1860BC570", Slot = "5")]
		[IteratorStateMachine(typeof(RentedArray<>.FCPVAGYCOAG))]
		private IEnumerator<T> MRFDCRTHSSH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x60BC4B0", Offset = "0x60BB4B0", VA = "0x1860BC4B0", Slot = "6")]
		[IteratorStateMachine(typeof(RentedArray<>.IFNCROUEUOT))]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60BC450", Offset = "0x60BB450", VA = "0x1860BC450")]
		public static RentedArray<T> JHHCYSSPCBR(T[] a)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60BD030", Offset = "0x60BC030", VA = "0x1860BD030")]
		public static implicit operator RentedArray<T>(T[] array)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x60BC630", Offset = "0x60BB630", VA = "0x1860BC630")]
		private void OTVAACKYROX(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class GVEDBMWNADA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x39A0080", Offset = "0x399F080", VA = "0x1839A0080")]
		public static RentedArray<b> YYUHVFSJQZR<b>(this IEnumerable<b> a) where b : class
		{
			return default(RentedArray<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class BUNJATOENNW<a> : IReadOnlyList<a>, IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>, IDisposable where a : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private BUNJATOENNW<a> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x4ACC870", Offset = "0x4ACB870", VA = "0x184ACC870", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public a Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x4ACD870", Offset = "0x4ACC870", VA = "0x184ACD870", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4ACCD60", Offset = "0x4ACBD60", VA = "0x184ACCD60")]
			public Enumerator(BUNJATOENNW<a> list)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4ACB710", Offset = "0x4ACA710", VA = "0x184ACB710", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x409CB80", Offset = "0x409BB80", VA = "0x18409CB80", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private RentedArray<a> UMFUZCETKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int UPMTRKCXOSV;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x405F130", Offset = "0x405E130", VA = "0x18405F130", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x405EC30", Offset = "0x405DC30", VA = "0x18405EC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int TJKWDSPKIXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x405E780", Offset = "0x405D780", VA = "0x18405E780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool VPWVGDBDRGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x405E370", Offset = "0x405D370", VA = "0x18405E370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public RentedSpan<a> PABJBXNBIMV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x405EC80", Offset = "0x405DC80", VA = "0x18405EC80")]
			get
			{
				return default(RentedSpan<a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x405F030", Offset = "0x405E030", VA = "0x18405F030")]
		public BUNJATOENNW(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x405F0C0", Offset = "0x405E0C0", VA = "0x18405F0C0")]
		public BUNJATOENNW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x405E0D0", Offset = "0x405D0D0", VA = "0x18405E0D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x405E7A0", Offset = "0x405D7A0", VA = "0x18405E7A0")]
		public RentedArray<a> OMRGUZPJNFE()
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x405DD80", Offset = "0x405CD80", VA = "0x18405DD80")]
		public void Add(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x405E3C0", Offset = "0x405D3C0", VA = "0x18405E3C0")]
		private void GXDDXFJJIDX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x405EE40", Offset = "0x405DE40", VA = "0x18405EE40")]
		public void ZIGIXXBWWGZ(List<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x405ED10", Offset = "0x405DD10", VA = "0x18405ED10")]
		public void ZIGIXXBWWGZ(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x405E930", Offset = "0x405D930", VA = "0x18405E930")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x405E7F0", Offset = "0x405D7F0", VA = "0x18405E7F0")]
		public void RKOMIOJMQOE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x405DE50", Offset = "0x405CE50", VA = "0x18405DE50")]
		public void BQWGBIQMLNY(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x405E9C0", Offset = "0x405D9C0", VA = "0x18405E9C0")]
		public void TENYFZSMMXG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x405E180", Offset = "0x405D180", VA = "0x18405E180")]
		public void DFGEHTTWBES(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x405EC00", Offset = "0x405DC00", VA = "0x18405EC00")]
		public int XHFPNJIIPWS(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x405E130", Offset = "0x405D130", VA = "0x18405E130")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x405E050", Offset = "0x405D050", VA = "0x18405E050")]
		public a[] BYZVBLKPVJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x405E390", Offset = "0x405D390", VA = "0x18405E390", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x405F1A0", Offset = "0x405E1A0", VA = "0x18405F1A0")]
		public static implicit operator RentedArray<a>(BUNJATOENNW<a> list)
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x405E400", Offset = "0x405D400", VA = "0x18405E400", Slot = "6")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x405E460", Offset = "0x405D460", VA = "0x18405E460", Slot = "7")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x405EBA0", Offset = "0x405DBA0", VA = "0x18405EBA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x405E4D0", Offset = "0x405D4D0", VA = "0x18405E4D0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void LKADHXVPYVF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x405E5F0", Offset = "0x405D5F0", VA = "0x18405E5F0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void NBBQCGBUWGV(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class AZSCYFNOAQZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x33282D0", Offset = "0x33272D0", VA = "0x1833282D0")]
		public static void WLMSFQTYJAR<c>(this BUNJATOENNW<c> a) where c : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public ref struct RentedSpan<T> where T : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private Span<object> data;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x60BD400", Offset = "0x60BC400", VA = "0x1860BD400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x60BD490", Offset = "0x60BC490", VA = "0x1860BD490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x60BD3C0", Offset = "0x60BC3C0", VA = "0x1860BD3C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x15E4F60", Offset = "0x15E3F60", VA = "0x1815E4F60")]
		public RentedSpan(Span<object> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x60BD2B0", Offset = "0x60BC2B0", VA = "0x1860BD2B0")]
		public RentedSpan<T> GKQGLVALXMJ(int a)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x60BD1D0", Offset = "0x60BC1D0", VA = "0x1860BD1D0")]
		public RentedSpan<T> GKQGLVALXMJ(int a, int b)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x60BD170", Offset = "0x60BC170", VA = "0x1860BD170")]
		public void CopyTo(RentedSpan<T> destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60BD380", Offset = "0x60BC380", VA = "0x1860BD380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x41F7E80", Offset = "0x41F6E80", VA = "0x1841F7E80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x405A760", Offset = "0x4059760", VA = "0x18405A760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct Range : IEquatable<Range>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int count;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int KEZYADECSKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x30BACC0", Offset = "0x30B9CC0", VA = "0x1830BACC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x30BACD0", Offset = "0x30B9CD0", VA = "0x1830BACD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int PZMODGNNSPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int YTBFAQLEKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8720810", Offset = "0x871F810", VA = "0x188720810")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8720760", Offset = "0x871F760", VA = "0x188720760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public (int begin, int end) IQBKZHOHSHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x87208A0", Offset = "0x871F8A0", VA = "0x1887208A0")]
			get
			{
				return default((int, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
		private Range(int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B87D70", Offset = "0x2B86D70", VA = "0x182B87D70")]
		public static Range UIZBIOBIOKJ(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8720800", Offset = "0x871F800", VA = "0x188720800")]
		public static Range QAFMWBVYUGM(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8720820", Offset = "0x871F820", VA = "0x188720820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x14E4CF0", Offset = "0x14E3CF0", VA = "0x1814E4CF0", Slot = "4")]
		public bool Equals(Range other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8720770", Offset = "0x871F770", VA = "0x188720770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7A18200", Offset = "0x7A17200", VA = "0x187A18200", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct SortIndicesByData<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly NativeArray<T> data;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x15E4F60", Offset = "0x15E3F60", VA = "0x1815E4F60")]
		public SortIndicesByData(NativeArray<T> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x61DE5F0", Offset = "0x61DD5F0", VA = "0x1861DE5F0", Slot = "6")]
		public int Compare(int x, int y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x61DE980", Offset = "0x61DD980", VA = "0x1861DE980", Slot = "4")]
		public bool Equals(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x61DEC80", Offset = "0x61DDC80", VA = "0x1861DEC80", Slot = "5")]
		public int GetHashCode(int x)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class DKUBWSOMPWZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x382FB20", Offset = "0x382EB20", VA = "0x18382FB20")]
		public static a[] QPEGOPKZPXF<a>(List<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct UnsafeParallelHashMapProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8720E30", Offset = "0x871FE30", VA = "0x188720E30")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class ZGBHPXVPMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3B655A0", Offset = "0x3B645A0", VA = "0x183B655A0")]
		public static UnsafeParallelHashMapProxy DDXQBXAORKY<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMapProxy);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3B655A0", Offset = "0x3B645A0", VA = "0x183B655A0")]
		public static UnsafeParallelHashMap<TKey, TValue> GMVTKOJAZTE<TKey, TValue>(this UnsafeParallelHashMapProxy a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMap<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class HGFGENORWUX
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x39A61D0", Offset = "0x39A51D0", VA = "0x1839A61D0")]
		public static int OYGEMSHSHDM<a>(ReadOnlySpan<a> a, ReadOnlySpan<a> b, int c) where a : struct
		{
			return default(int);
		}
	}
}
namespace RecRoom.Foundation.Collections.Stream
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class FCWPCACDCUJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x395A5A0", Offset = "0x39595A0", VA = "0x18395A5A0")]
		public static b HCZJXBJJVIF<b>(this NativeArray<byte> a) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x395A770", Offset = "0x3959770", VA = "0x18395A770")]
		public static NativeArray<T> TYYGJGVICDE<T>(this NativeArray<byte> a, int b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x395AC00", Offset = "0x3959C00", VA = "0x18395AC00")]
		public static void UHEUJRAAHAM<c>(this NativeList<byte> a, [In] c value) where c : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x395AC70", Offset = "0x3959C70", VA = "0x18395AC70")]
		public static void UHEUJRAAHAM<T>(this NativeList<byte> a, NativeArray<T> b) where T : struct
		{
		}
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

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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B27430", Offset = "0x7B25C30", VA = "0x187B27430", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[FKPBJDKEECD]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3937E50", Offset = "0x3936650", VA = "0x183937E50")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[FKPBJDKEECD]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3938C40", Offset = "0x3937440", VA = "0x183938C40")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3937F20", Offset = "0x3936720", VA = "0x183937F20")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3938160", Offset = "0x3936960", VA = "0x183938160")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x393C140", Offset = "0x393A940", VA = "0x18393C140")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x393BF90", Offset = "0x393A790", VA = "0x18393BF90")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x393C7C0", Offset = "0x393AFC0", VA = "0x18393C7C0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x393C900", Offset = "0x393B100", VA = "0x18393C900")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3939430", Offset = "0x3937C30", VA = "0x183939430")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x39393C0", Offset = "0x3937BC0", VA = "0x1839393C0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x39399B0", Offset = "0x39381B0", VA = "0x1839399B0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, CFCDJGMMHDE range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x39399F0", Offset = "0x39381F0", VA = "0x1839399F0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3939820", Offset = "0x3938020", VA = "0x183939820")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x393C080", Offset = "0x393A880", VA = "0x18393C080")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[FKPBJDKEECD]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x39433D0", Offset = "0x3941BD0", VA = "0x1839433D0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x39452D0", Offset = "0x3943AD0", VA = "0x1839452D0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3945280", Offset = "0x3943A80", VA = "0x183945280")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x48C1640", Offset = "0x48BFE40", VA = "0x1848C1640")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B27960", Offset = "0x7B26160", VA = "0x187B27960")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B27990", Offset = "0x7B26190", VA = "0x187B27990")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3944860", Offset = "0x3943060", VA = "0x183944860")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3944670", Offset = "0x3942E70", VA = "0x183944670")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39449E0", Offset = "0x39431E0", VA = "0x1839449E0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3944990", Offset = "0x3943190", VA = "0x183944990")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3944940", Offset = "0x3943140", VA = "0x183944940")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39447C0", Offset = "0x3942FC0", VA = "0x1839447C0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3944CE0", Offset = "0x39434E0", VA = "0x183944CE0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3944B40", Offset = "0x3943340", VA = "0x183944B40")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39446C0", Offset = "0x3942EC0", VA = "0x1839446C0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3944610", Offset = "0x3942E10", VA = "0x183944610")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39445F0", Offset = "0x3942DF0", VA = "0x1839445F0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39456B0", Offset = "0x3943EB0", VA = "0x1839456B0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39452E0", Offset = "0x3943AE0", VA = "0x1839452E0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39456E0", Offset = "0x3943EE0", VA = "0x1839456E0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39457A0", Offset = "0x3943FA0", VA = "0x1839457A0")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[FKPBJDKEECD]
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
			[Cpp2IlInjected.Address(RVA = "0x4A24B20", Offset = "0x4A23320", VA = "0x184A24B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD87030", Offset = "0xD85830", VA = "0x180D87030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7370", Offset = "0x4FB5B70", VA = "0x184FB7370")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x535BB60", Offset = "0x535A360", VA = "0x18535BB60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x535B9F0", Offset = "0x535A1F0", VA = "0x18535B9F0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBE50", Offset = "0x3DDA650", VA = "0x183DDBE50")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[FKPBJDKEECD]
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
			[Cpp2IlInjected.Address(RVA = "0x53AE700", Offset = "0x53ACF00", VA = "0x1853AE700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x53AE740", Offset = "0x53ACF40", VA = "0x1853AE740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7370", Offset = "0x4FB5B70", VA = "0x184FB7370")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x53AE360", Offset = "0x53ACB60", VA = "0x1853AE360")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x53AE4A0", Offset = "0x53ACCA0", VA = "0x1853AE4A0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x53AE4E0", Offset = "0x53ACCE0", VA = "0x1853AE4E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x53AE580", Offset = "0x53ACD80", VA = "0x1853AE580")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[FKPBJDKEECD]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[FKPBJDKEECD]
public static class MAFCKBGKPFD
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B274C0", Offset = "0x7B25CC0", VA = "0x187B274C0")]
	public static JobHandle GLJDIBKELPM(this JobHandle BINANFFLHIK, JobHandle NOAPPAEGHOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B27500", Offset = "0x7B25D00", VA = "0x187B27500")]
	public static JobHandle POFEGDEIIHL(this Span<JobHandle> HAIKNNMBBDO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MDINFLGODAA
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3406EC0", Offset = "0x34056C0", VA = "0x183406EC0")]
	public static void NNEMBDPLFBE<T>(this T[] CPIDEKBKOPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BBPFGBPOAGK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34FE700", Offset = "0x34FCF00", VA = "0x1834FE700")]
	public static NativeKeyValueArrays<TKey, TValue> KNBPIGMKKAI<TKey, TValue>(this Dictionary<TKey, TValue> BFIDNFGDLKJ, Allocator KKCJNCNIICO) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BPNOFJJMBOA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B267F0", Offset = "0x7B24FF0", VA = "0x187B267F0")]
	public static void HGKHJPCPLGA(this GameObject KJMBGAPFJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B26890", Offset = "0x7B25090", VA = "0x187B26890")]
	public static void HGKHJPCPLGA(this Component IKKBFHNKIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B26750", Offset = "0x7B24F50", VA = "0x187B26750")]
	public static void HGKHJPCPLGA(this ScriptableObject AGJAGNKJNAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LBJKMABHGHL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B271C0", Offset = "0x7B259C0", VA = "0x187B271C0")]
	public static void MHBJMNLLPDN(this NativeList<byte> GIPAMJGJGNH, ReadOnlySpan<byte> LEFNJFKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3841E60", Offset = "0x3840660", VA = "0x183841E60")]
	public static void KILKLAMOJFC<T>(this NativeList<T> GIPAMJGJGNH, T OPMIAMEJKDH, int PCFOAHIEPDL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BCEBCBHCPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x34FF750", Offset = "0x34FDF50", VA = "0x1834FF750")]
	public static T FJMGDNIOOON<T>(this ReadOnlySpan<byte> OPMIAMEJKDH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34FFB90", Offset = "0x34FE390", VA = "0x1834FFB90")]
	public static T MAPBHDNAHMG<T>(this Span<T> LEFNJFKJPEL, Func<T, bool> GPFOLMONPIN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34FF990", Offset = "0x34FE190", VA = "0x1834FF990")]
	public static bool HAHJHPCKFHL<T>(this Span<T> LEFNJFKJPEL, Func<T, bool> GPFOLMONPIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x34FFCF0", Offset = "0x34FE4F0", VA = "0x1834FFCF0")]
	public static bool OKBFOKOBPGL<T>(this Span<T> LEFNJFKJPEL, Func<T, bool> GPFOLMONPIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x34FF200", Offset = "0x34FDA00", VA = "0x1834FF200")]
	public static T EFPADONOPCC<T>([In] this ReadOnlySpan<byte> LEFNJFKJPEL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x34FFA40", Offset = "0x34FE240", VA = "0x1834FFA40")]
	public static Span<TTo> JLOCCOOKKID<TTo, TFrom>(this Span<TFrom> LEFNJFKJPEL) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34FFA40", Offset = "0x34FE240", VA = "0x1834FFA40")]
	public static ReadOnlySpan<TTo> JLOCCOOKKID<TTo, TFrom>(this ReadOnlySpan<TFrom> LEFNJFKJPEL) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x34FFA40", Offset = "0x34FE240", VA = "0x1834FFA40")]
	public static ReadOnlySpan<TTo> JLOCCOOKKID<TTo>(this ReadOnlySpan<byte> LEFNJFKJPEL) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34FFA90", Offset = "0x34FE290", VA = "0x1834FFA90")]
	public static Span<T> LMNLEEHCNJH<T>(this ReadOnlySpan<T> GGBFBJAOFOK) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x34FECF0", Offset = "0x34FD4F0", VA = "0x1834FECF0")]
	public static Span<byte> AFOHMCJECDO<T>([In] this Span<byte> LEFNJFKJPEL, T OPMIAMEJKDH) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B261B0", Offset = "0x7B249B0", VA = "0x187B261B0")]
	private static Enum OBOOGMDBFKA([In] ReadOnlySpan<byte> LEFNJFKJPEL, Type IAKHMPNNHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B25C60", Offset = "0x7B24460", VA = "0x187B25C60")]
	public static Enum IEMKJIICNEI([In] this Span<byte> LEFNJFKJPEL, Type IAKHMPNNHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B25CD0", Offset = "0x7B244D0", VA = "0x187B25CD0")]
	public static void JAIPKAFDGCB([In] this Span<byte> LEFNJFKJPEL, Enum IPCBOKHNPCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DBDKPLCFNAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PBHBDAKNFHN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7B27AD0", Offset = "0x7B262D0", VA = "0x187B27AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B26B00", Offset = "0x7B25300", VA = "0x187B26B00")]
	[AsyncStateMachine(typeof(PBHBDAKNFHN))]
	public static void IMDAAPDFCDF(this Task NACLDKPPPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IIAPFAONIAD
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37E9210", Offset = "0x37E7A10", VA = "0x1837E9210")]
	public static NativeArray<T> BACEAFLJMNG<T>(this UnsafeList<T> GIPAMJGJGNH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x37E9270", Offset = "0x37E7A70", VA = "0x1837E9270")]
	public static NativeArray<T> CHLBNHKGNKF<T>(this UnsafeList<T> GIPAMJGJGNH, bool LLMFDIDBMNA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37E92F0", Offset = "0x37E7AF0", VA = "0x1837E92F0")]
	public static UnsafeList<T> LMNLEEHCNJH<T>(this UnsafeList<T> GIPAMJGJGNH, Allocator KKCJNCNIICO) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GPKEEDCDABL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum JPEOAMPDGHP : short
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
	public struct DEMAPMLIINE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly JPEOAMPDGHP BELIEAFHDAH;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2D9A6D0", Offset = "0x2D98ED0", VA = "0x182D9A6D0")]
		public DEMAPMLIINE(JPEOAMPDGHP BELIEAFHDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory NACCBIPFJIO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	public static void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B26C70", Offset = "0x7B25470", VA = "0x187B26C70")]
	static GPKEEDCDABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x342B250", Offset = "0x3429A50", VA = "0x18342B250")]
	public static DEMAPMLIINE JOEDAJGCDBG(JPEOAMPDGHP BELIEAFHDAH)
	{
		return default(DEMAPMLIINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	public static void PLBOJGLAHJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OFCLFDGENGC
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x395E070", Offset = "0x395C870", VA = "0x18395E070")]
	public static FMNJOONOBGP<T1, T2> IDJILJFMBEE<T1, T2>(this (T1, T2) LNPNEODPLIC) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(FMNJOONOBGP<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x37999D0", Offset = "0x37981D0", VA = "0x1837999D0")]
	public static IGEMGNJLCFI<T1, T2, T3> IDJILJFMBEE<T1, T2, T3>(this (T1, T2, T3) LNPNEODPLIC) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(IGEMGNJLCFI<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FMNJOONOBGP<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) LNPNEODPLIC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x48E27E0", Offset = "0x48E0FE0", VA = "0x1848E27E0")]
	public FMNJOONOBGP((T1, T2) LNPNEODPLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x48E2770", Offset = "0x48E0F70", VA = "0x1848E2770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IGEMGNJLCFI<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) LNPNEODPLIC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x48E27F0", Offset = "0x48E0FF0", VA = "0x1848E27F0")]
	public IGEMGNJLCFI((T1, T2, T3) LNPNEODPLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4B70D20", Offset = "0x4B6F520", VA = "0x184B70D20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JLJJBAHLGBF
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B26CD0", Offset = "0x7B254D0", VA = "0x187B26CD0")]
	public static Range JANIMLJKDDG(this CFCDJGMMHDE LPANGBAAEHJ)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class DBLCHIHCDBM
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct CBEDMKABBCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int BOLFPBFEDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int HDGKPCMCJDM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B26940", Offset = "0x7B25140", VA = "0x187B26940")]
		public CBEDMKABBCH(int MLFBDFDDHEO, int HDGKPCMCJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7B26930", Offset = "0x7B25130", VA = "0x187B26930")]
		public bool EPAECCABOFG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B26C20", Offset = "0x7B25420", VA = "0x187B26C20")]
	public static CBEDMKABBCH DPNIJJHCOGM(this Range LPANGBAAEHJ)
	{
		return default(CBEDMKABBCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FGOIDNMNHAG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle EKNJAMPDKID;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OPOOHMGBHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x48C1630", Offset = "0x48BFE30", VA = "0x1848C1630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x48C1580", Offset = "0x48BFD80", VA = "0x1848C1580")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x48C1920", Offset = "0x48C0120", VA = "0x1848C1920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x48C1B30", Offset = "0x48C0330", VA = "0x1848C1B30")]
	public FGOIDNMNHAG(T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x48C1640", Offset = "0x48BFE40", VA = "0x1848C1640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class AEHEJFJGOCI<THandle, TValue> : IDisposable where THandle : struct, KAICMPMFPHE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> HAIKNNMBBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> MGEDIIGJIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> KDMGHAMNKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> IIGBMCGCPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int NAMAKAFBAJD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x49E4710", Offset = "0x49E2F10", VA = "0x1849E4710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x49E53A0", Offset = "0x49E3BA0", VA = "0x1849E53A0")]
	public AEHEJFJGOCI(Action<TValue> IIGBMCGCPIN, [Optional] Func<TValue> KDMGHAMNKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x49E4750", Offset = "0x49E2F50", VA = "0x1849E4750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49E5150", Offset = "0x49E3950", VA = "0x1849E5150")]
	public THandle OIHLAKEIFNH(TValue OPMIAMEJKDH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x49E4CE0", Offset = "0x49E34E0", VA = "0x1849E4CE0")]
	public bool KNAKPKDGKOD(THandle EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x49E4E20", Offset = "0x49E3620", VA = "0x1849E4E20")]
	public bool MMIGFMCEJDL(THandle EKNJAMPDKID, [Out] TValue OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49E4820", Offset = "0x49E3020", VA = "0x1849E4820")]
	public TValue EFPADONOPCC(THandle EKNJAMPDKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x49E49F0", Offset = "0x49E31F0", VA = "0x1849E49F0")]
	public bool IPJBOCLFEHF(THandle EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x49E4980", Offset = "0x49E3180", VA = "0x1849E4980")]
	private THandle HHEIDANLPFD(int FPEOONOJHML)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x49E4EF0", Offset = "0x49E36F0", VA = "0x1849E4EF0")]
	private TValue NJJMECDNEFH(int FPEOONOJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x49E4F50", Offset = "0x49E3750", VA = "0x1849E4F50")]
	private void NPMILICEKNL(int FPEOONOJHML, [In] THandle EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x49E46C0", Offset = "0x49E2EC0", VA = "0x1849E46C0")]
	private void CDJBNKOKNEH(int FPEOONOJHML, [In] TValue OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49E51F0", Offset = "0x49E39F0", VA = "0x1849E51F0")]
	private THandle PAHEDLLCNOI()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49E4870", Offset = "0x49E3070", VA = "0x1849E4870")]
	private void GFNOJCIKEAI(THandle EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x49E4E10", Offset = "0x49E3610", VA = "0x1849E4E10")]
	private int LOKNNDFGOMI(int JLNEBEJFOHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x49E49E0", Offset = "0x49E31E0", VA = "0x1849E49E0")]
	private bool IICLBLPGBNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9E4110", Offset = "0x9E2910", VA = "0x1809E4110")]
	private void BHACKMAENLJ(THandle EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x49E4C30", Offset = "0x49E3430", VA = "0x1849E4C30")]
	private bool JPODHCGDAKM([Out] THandle EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x49E4B00", Offset = "0x49E3300", VA = "0x1849E4B00")]
	private bool JODKDAJCCCP([Out] THandle EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x49E4FA0", Offset = "0x49E37A0", VA = "0x1849E4FA0")]
	private void OBMLADJHILO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KAICMPMFPHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int ILGJIFNMLEF
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
public static class OLAMCCMGIIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x39615E0", Offset = "0x395FDE0", VA = "0x1839615E0")]
	public static bool EEMGCGODEKP<T>(this T EKNJAMPDKID, T PGPJMFPAKOO) where T : struct, KAICMPMFPHE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3961600", Offset = "0x395FE00", VA = "0x183961600")]
	public static bool FFFKLPKJBMG<T>(this T EKNJAMPDKID) where T : struct, KAICMPMFPHE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7B279C0", Offset = "0x7B261C0", VA = "0x187B279C0")]
	public static string BGDNLEIBFLG(this KAICMPMFPHE EKNJAMPDKID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct MCGLDLPOEGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type MDOGNDDDHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> KGMEOIBOOOM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4FBDB90", Offset = "0x4FBC390", VA = "0x184FBDB90")]
	public MCGLDLPOEGP(Type LCGNDMOPIFP, Span<byte> LEFNJFKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x38B2C30", Offset = "0x38B1430", VA = "0x1838B2C30")]
	public static MCGLDLPOEGP FJFLDAKDOLM<T>(T OPMIAMEJKDH) where T : struct
	{
		return default(MCGLDLPOEGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7B275B0", Offset = "0x7B25DB0", VA = "0x187B275B0")]
	public static AEHALCLIFBM FGIKKMMHFBO([In] MCGLDLPOEGP GGILEDABHIF)
	{
		return default(AEHALCLIFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7B27630", Offset = "0x7B25E30", VA = "0x187B27630")]
	public Enum IEMKJIICNEI(Type IAKHMPNNHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38B2BF0", Offset = "0x38B13F0", VA = "0x1838B2BF0")]
	public void AFOHMCJECDO<T>([In] T OPMIAMEJKDH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7B276B0", Offset = "0x7B25EB0", VA = "0x187B276B0")]
	public void JAIPKAFDGCB(Enum IPCBOKHNPCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct AEHALCLIFBM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct APAMJKDFKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* FPPLMBAPGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* HLKKJFHDJAB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type MDOGNDDDHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> KGMEOIBOOOM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EJBDOBMPEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B25AD0", Offset = "0x7B242D0", VA = "0x187B25AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int FHJIBIMNGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B25A80", Offset = "0x7B24280", VA = "0x187B25A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4FBDB90", Offset = "0x4FBC390", VA = "0x184FBDB90")]
	public AEHALCLIFBM(Type LCGNDMOPIFP, ReadOnlySpan<byte> LEFNJFKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3F03B40", Offset = "0x3F02340", VA = "0x183F03B40")]
	public static AEHALCLIFBM FJFLDAKDOLM<T>(T OPMIAMEJKDH) where T : struct
	{
		return default(AEHALCLIFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B25AE0", Offset = "0x7B242E0", VA = "0x187B25AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B258B0", Offset = "0x7B240B0", VA = "0x187B258B0")]
	public object BCPKKMMOBKB(int FPEOONOJHML = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct LIBCOAGHHLO
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38867B0", Offset = "0x3884FB0", VA = "0x1838867B0")]
	public static NativeArray<T> FJFLDAKDOLM<T>(T OPMIAMEJKDH, bool LLMFDIDBMNA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3886760", Offset = "0x3884F60", VA = "0x183886760")]
	public static NativeArray<T> DIKHMNIEJKC<T>(T OPMIAMEJKDH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3886800", Offset = "0x3885000", VA = "0x183886800")]
	public static NativeArray<T> GPNMOLJGJGN<T>(T OPMIAMEJKDH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B27370", Offset = "0x7B25B70", VA = "0x187B27370")]
	public static NativeArray<byte> GPNMOLJGJGN(ReadOnlySpan<byte> OPMIAMEJKDH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B27240", Offset = "0x7B25A40", VA = "0x187B27240")]
	public static NativeArray<byte> FJFLDAKDOLM(ReadOnlySpan<byte> OPMIAMEJKDH, bool LLMFDIDBMNA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B272F0", Offset = "0x7B25AF0", VA = "0x187B272F0")]
	public unsafe static NativeArray<byte> FJFLDAKDOLM(byte* FLGMBAIHNIN, int IMNFCKGEMOH, bool LLMFDIDBMNA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3886850", Offset = "0x3885050", VA = "0x183886850")]
	public static NativeArray<T> HMAILHHHNAA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct NLIGMJPKGIC : IEquatable<NLIGMJPKGIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int HHKKDJCOGMF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type PALJBODIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B277D0", Offset = "0x7B25FD0", VA = "0x187B277D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B278C0", Offset = "0x7B260C0", VA = "0x187B278C0")]
	public NLIGMJPKGIC(Type PIJHKCJDAHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B27740", Offset = "0x7B25F40", VA = "0x187B27740")]
	public static NLIGMJPKGIC FGIKKMMHFBO(Type PIJHKCJDAHO)
	{
		return default(NLIGMJPKGIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x210E570", Offset = "0x210CD70", VA = "0x18210E570", Slot = "4")]
	public bool Equals(NLIGMJPKGIC PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7B276C0", Offset = "0x7B25EC0", VA = "0x187B276C0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B27880", Offset = "0x7B26080", VA = "0x187B27880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class KKMPEOLPGDG
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> JIMEIEIOJEJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> ODBIALHKJJK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B27040", Offset = "0x7B25840", VA = "0x187B27040")]
	static KKMPEOLPGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7B26F80", Offset = "0x7B25780", VA = "0x187B26F80")]
	public static bool OIHLAKEIFNH(Type PIJHKCJDAHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B26DB0", Offset = "0x7B255B0", VA = "0x187B26DB0")]
	private static bool OIHLAKEIFNH(Type PIJHKCJDAHO, [Out] int FPEOONOJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7B26FE0", Offset = "0x7B257E0", VA = "0x187B26FE0")]
	public static int OOPEOBNCHCJ(Type PIJHKCJDAHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B26D30", Offset = "0x7B25530", VA = "0x187B26D30")]
	public static Type EFPADONOPCC(int FPEOONOJHML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct CHEKMJILMDA<Handle> where Handle : KAICMPMFPHE, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct GHBNGLJPAOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly CHEKMJILMDA<Handle> BODBBJKKCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int FPEOONOJHML;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle LMIIADFHEKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4998440", Offset = "0x4996C40", VA = "0x184998440")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x49987F0", Offset = "0x4996FF0", VA = "0x1849987F0")]
		public GHBNGLJPAOG(CHEKMJILMDA<Handle> BODBBJKKCJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4998180", Offset = "0x4996980", VA = "0x184998180")]
		public AOEIHJLJNMJ CJOJELENPLJ([In] AOEIHJLJNMJ LDIOMGMJIGF)
		{
			return default(AOEIHJLJNMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x49986D0", Offset = "0x4996ED0", VA = "0x1849986D0")]
		public bool EPAECCABOFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4998270", Offset = "0x4996A70", VA = "0x184998270")]
		private Handle EGPHKPMBPOH(string NJAAPDELBNN)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct AOEIHJLJNMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private GHBNGLJPAOG EIPFMOFFCAE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x4AED100", Offset = "0x4AEB900", VA = "0x184AED100")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4AED140", Offset = "0x4AEB940", VA = "0x184AED140")]
		public AOEIHJLJNMJ(CHEKMJILMDA<Handle> BODBBJKKCJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4AED040", Offset = "0x4AEB840", VA = "0x184AED040")]
		public bool EPAECCABOFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4AECFD0", Offset = "0x4AEB7D0", VA = "0x184AECFD0")]
		public AOEIHJLJNMJ DPNIJJHCOGM()
		{
			return default(AOEIHJLJNMJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> CFAIEGDMMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> EDPEBNPDLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int HJBLCJBDEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int FMKKKAFECLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool AHHMEIEJPBE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EHFFNOLNOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x63EA4A0", Offset = "0x63E8CA0", VA = "0x1863EA4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AOEIHJLJNMJ LCKIDEMHCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x63EA7D0", Offset = "0x63E8FD0", VA = "0x1863EA7D0")]
		get
		{
			return default(AOEIHJLJNMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x63EB700", Offset = "0x63E9F00", VA = "0x1863EB700")]
	public CHEKMJILMDA(int GCLDKHIFCPL, Allocator KKCJNCNIICO = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63EB0C0", Offset = "0x63E98C0", VA = "0x1863EB0C0")]
	public void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x20ACA90", Offset = "0x20AB290", VA = "0x1820ACA90")]
	public static int LOKNNDFGOMI(int AALALMNDJKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB4B0", Offset = "0x2DB9CB0", VA = "0x182DBB4B0")]
	public static bool IDGLCGDOMLO(int AALALMNDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x63EB500", Offset = "0x63E9D00", VA = "0x1863EB500")]
	public bool POPBCADNPAC(int FPEOONOJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x63E9E70", Offset = "0x63E8670", VA = "0x1863E9E70")]
	public bool ALKJMEIKHAO(Handle EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x63EA2F0", Offset = "0x63E8AF0", VA = "0x1863EA2F0")]
	public Handle BMHBEPCENOB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x63EA9C0", Offset = "0x63E91C0", VA = "0x1863EA9C0")]
	public void GKIIKOEJINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x63EA430", Offset = "0x63E8C30", VA = "0x1863EA430")]
	public void BPIHKJMDJFM(Handle EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850")]
	private bool FMGPEGGLIPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63EA1C0", Offset = "0x63E89C0", VA = "0x1863EA1C0")]
	private bool BGEJCOPDMJC(int FPEOONOJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63E9D00", Offset = "0x63E8500", VA = "0x1863E9D00")]
	private void AHLHFFGPDFA([Out] int FPEOONOJHML, [Out] int JLNEBEJFOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x63EA680", Offset = "0x63E8E80", VA = "0x1863EA680")]
	private void EHNLGNJKDAG(Handle EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x63EB380", Offset = "0x63E9B80", VA = "0x1863EB380")]
	private void ONEDAGHGGOE(int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x63EA860", Offset = "0x63E9060", VA = "0x1863EA860")]
	private bool FMCCNHGEMEJ([Out] int FPEOONOJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x63EB270", Offset = "0x63E9A70", VA = "0x1863EB270")]
	private static Handle OMMJGDPHHBH(int FPEOONOJHML, int JLNEBEJFOHB)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct MCMJDBAFPKC<Handle, T> where Handle : KAICMPMFPHE, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CHEKMJILMDA<Handle> IIDKGKKLGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] IKHPACCHHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> OLBNJHJLCMM;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x51F0630", Offset = "0x51EEE30", VA = "0x1851F0630")]
	public MCMJDBAFPKC(int GCLDKHIFCPL, [Optional] Action<T> OLBNJHJLCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x51EFEB0", Offset = "0x51EE6B0", VA = "0x1851EFEB0")]
	public void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x51EFCD0", Offset = "0x51EE4D0", VA = "0x1851EFCD0")]
	public bool MMIGFMCEJDL(Handle EKNJAMPDKID, [Out] T PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x51EFFB0", Offset = "0x51EE7B0", VA = "0x1851EFFB0")]
	public Handle OIHLAKEIFNH(T PNHCNFOFAFI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x51F0400", Offset = "0x51EEC00", VA = "0x1851F0400")]
	public void PFGHNIMPFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x51EF970", Offset = "0x51EE170", VA = "0x1851EF970")]
	public void AHELLINFOCL(Handle EKNJAMPDKID, [Out] T LBNMHKLGMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x51EFA50", Offset = "0x51EE250", VA = "0x1851EFA50")]
	public void AHELLINFOCL(Handle EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x51EFE50", Offset = "0x51EE650", VA = "0x1851EFE50")]
	private T MPKPFGMPGFE(int FPEOONOJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x51EFC10", Offset = "0x51EE410", VA = "0x1851EFC10")]
	private void BCFNJBPBPNN(int OJBJOCLEBAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct JMGGLJLNFLA<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct NNPLAKBOCGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JMGGLJLNFLA<T> CPIDEKBKOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int FPEOONOJHML;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5358320", Offset = "0x5356B20", VA = "0x185358320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27893A0", Offset = "0x2787BA0", VA = "0x1827893A0")]
		public NNPLAKBOCGO(JMGGLJLNFLA<T> CPIDEKBKOPO, int FPEOONOJHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x53582D0", Offset = "0x5356AD0", VA = "0x1853582D0")]
		public bool EPAECCABOFG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NOPCAKNGBJI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JMGGLJLNFLA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public NOPCAKNGBJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5359720", Offset = "0x5357F20", VA = "0x185359720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x53597C0", Offset = "0x5357FC0", VA = "0x1853597C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KAOIBFBBLFA : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public JMGGLJLNFLA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public KAOIBFBBLFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4EE98E0", Offset = "0x4EE80E0", VA = "0x184EE98E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4EE9980", Offset = "0x4EE8180", VA = "0x184EE9980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] NFNBKNAJBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint OPMIAMEJKDH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4E299D0", Offset = "0x4E281D0", VA = "0x184E299D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KBDBMNHHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4E29DA0", Offset = "0x4E285A0", VA = "0x184E29DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IIAMENEAPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x16F7390", Offset = "0x16F5B90", VA = "0x1816F7390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool DPDBPEDDHGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4E299E0", Offset = "0x4E281E0", VA = "0x184E299E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MENIHLGCDFO<T> KGMEOIBOOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4E29590", Offset = "0x4E27D90", VA = "0x184E29590")]
		get
		{
			return default(MENIHLGCDFO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4E294C0", Offset = "0x4E27CC0", VA = "0x184E294C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E29410", Offset = "0x4E27C10", VA = "0x184E29410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4E2A030", Offset = "0x4E28830", VA = "0x184E2A030")]
	internal JMGGLJLNFLA(JMGGLJLNFLA<T> CPIDEKBKOPO, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4E2A460", Offset = "0x4E28C60", VA = "0x184E2A460")]
	private JMGGLJLNFLA(T[] CPIDEKBKOPO, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E2A0C0", Offset = "0x4E288C0", VA = "0x184E2A0C0")]
	public JMGGLJLNFLA(IEnumerable<T> MGEDIIGJIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4E2A050", Offset = "0x4E28850", VA = "0x184E2A050")]
	public JMGGLJLNFLA(int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4E299F0", Offset = "0x4E281F0", VA = "0x184E299F0")]
	public int EPEAOGKBKKK(T OPMIAMEJKDH, int MLFBDFDDHEO, int PCFOAHIEPDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E293D0", Offset = "0x4E27BD0", VA = "0x184E293D0")]
	public void ADPAHPIPJMH(int AHDGLDHNNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E29710", Offset = "0x4E27F10", VA = "0x184E29710")]
	private void DIFHCCDLHEF(int AHDGLDHNNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E29DD0", Offset = "0x4E285D0", VA = "0x184E29DD0")]
	public T[] OAMEEIJIFJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E29B10", Offset = "0x4E28310", VA = "0x184E29B10")]
	public T[] FINOOPDOPBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E29950", Offset = "0x4E28150", VA = "0x184E29950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E29D40", Offset = "0x4E28540", VA = "0x184E29D40")]
	public void HMPMAMNBMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E298E0", Offset = "0x4E280E0", VA = "0x184E298E0")]
	public NNPLAKBOCGO DPNIJJHCOGM()
	{
		return default(NNPLAKBOCGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E29E50", Offset = "0x4E28650", VA = "0x184E29E50", Slot = "5")]
	[IteratorStateMachine(typeof(JMGGLJLNFLA<>.NOPCAKNGBJI))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E29F40", Offset = "0x4E28740", VA = "0x184E29F40", Slot = "6")]
	[IteratorStateMachine(typeof(JMGGLJLNFLA<>.KAOIBFBBLFA))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E29C60", Offset = "0x4E28460", VA = "0x184E29C60")]
	public static JMGGLJLNFLA<T> FLAHEKHACEJ(T[] CPIDEKBKOPO)
	{
		return default(JMGGLJLNFLA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E29A70", Offset = "0x4E28270", VA = "0x184E29A70")]
	public static JMGGLJLNFLA<T> FGIKKMMHFBO(T[] CPIDEKBKOPO)
	{
		return default(JMGGLJLNFLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E29CC0", Offset = "0x4E284C0", VA = "0x184E29CC0")]
	private void FOPKOGCOMKL(int FPEOONOJHML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class JNOBHPMEBLN<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct NECIDEECKLN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JNOBHPMEBLN<T> GIPAMJGJGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int FPEOONOJHML;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x52E0460", Offset = "0x52DEC60", VA = "0x1852E0460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x52E04A0", Offset = "0x52DECA0", VA = "0x1852E04A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x44BF160", Offset = "0x44BD960", VA = "0x1844BF160")]
		public NECIDEECKLN(JNOBHPMEBLN<T> GIPAMJGJGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x52E0370", Offset = "0x52DEB70", VA = "0x1852E0370", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x52E0410", Offset = "0x52DEC10", VA = "0x1852E0410", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private JMGGLJLNFLA<T> NFNBKNAJBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int IMNFCKGEMOH;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4E2D500", Offset = "0x4E2BD00", VA = "0x184E2D500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x49EB010", Offset = "0x49E9810", VA = "0x1849EB010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int EHFFNOLNOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4E2D4F0", Offset = "0x4E2BCF0", VA = "0x184E2D4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool IIAMENEAPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D820", Offset = "0xA2C020", VA = "0x180A2D820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public MENIHLGCDFO<T> KGMEOIBOOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E2D570", Offset = "0x4E2BD70", VA = "0x184E2D570")]
		get
		{
			return default(MENIHLGCDFO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E280", Offset = "0x4E2CA80", VA = "0x184E2E280")]
	public JNOBHPMEBLN(int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E020", Offset = "0x4E2C820", VA = "0x184E2E020")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DFD0", Offset = "0x4E2C7D0", VA = "0x184E2DFD0")]
	public JMGGLJLNFLA<T> NMBEIPAKAAG()
	{
		return default(JMGGLJLNFLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E060", Offset = "0x4E2C860", VA = "0x184E2E060")]
	public void OIHLAKEIFNH(T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D3A0", Offset = "0x4E2BBA0", VA = "0x184E2D3A0")]
	private void ADPAHPIPJMH(int CFHPBCCHEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DB60", Offset = "0x4E2C360", VA = "0x184E2DB60")]
	public void MHBJMNLLPDN(List<T> FBJFJEKNKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DCE0", Offset = "0x4E2C4E0", VA = "0x184E2DCE0")]
	public void MHBJMNLLPDN(T[] FBJFJEKNKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D410", Offset = "0x4E2BC10", VA = "0x184E2D410")]
	public void AGPFKFDFKFP(int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D990", Offset = "0x4E2C190", VA = "0x184E2D990")]
	public void ILLEHOBKMGC(int DAIGCINLBCI, int HDGKPCMCJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D770", Offset = "0x4E2BF70", VA = "0x184E2D770")]
	public int EPEAOGKBKKK(T OPMIAMEJKDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E180", Offset = "0x4E2C980", VA = "0x184E2E180")]
	public bool PHEIEKKHJKM(T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D8B0", Offset = "0x4E2C0B0", VA = "0x184E2D8B0")]
	public T[] FINOOPDOPBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D600", Offset = "0x4E2BE00", VA = "0x184E2D600", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D7F0", Offset = "0x4E2BFF0", VA = "0x184E2D7F0")]
	public static JMGGLJLNFLA<T> FGIKKMMHFBO(JNOBHPMEBLN<T> GIPAMJGJGNH)
	{
		return default(JMGGLJLNFLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D920", Offset = "0x4E2C120", VA = "0x184E2D920", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E1D0", Offset = "0x4E2C9D0", VA = "0x184E2E1D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E210", Offset = "0x4E2CA10", VA = "0x184E2E210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D620", Offset = "0x4E2BE20", VA = "0x184E2D620")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void ELMDCKLEODC(int OPMIAMEJKDH, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DD80", Offset = "0x4E2C580", VA = "0x184E2DD80")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void NHNIBENHFOO(int DAIGCINLBCI, int HDGKPCMCJDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OANIFNOAMCP
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x395CC10", Offset = "0x395B410", VA = "0x18395CC10")]
	public static void HMPMAMNBMIE<T>(this JNOBHPMEBLN<T> GIPAMJGJGNH) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public ref struct MENIHLGCDFO<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> NFNBKNAJBPN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x51F35B0", Offset = "0x51F1DB0", VA = "0x1851F35B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x51F3580", Offset = "0x51F1D80", VA = "0x1851F3580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x51F3630", Offset = "0x51F1E30", VA = "0x1851F3630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public MENIHLGCDFO(Span<object> LEFNJFKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x51F3770", Offset = "0x51F1F70", VA = "0x1851F3770")]
	public MENIHLGCDFO<T> JHBIPFIKHLE(int MLFBDFDDHEO)
	{
		return default(MENIHLGCDFO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x51F3840", Offset = "0x51F2040", VA = "0x1851F3840")]
	public MENIHLGCDFO<T> JHBIPFIKHLE(int MLFBDFDDHEO, int IMNFCKGEMOH)
	{
		return default(MENIHLGCDFO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x51F3710", Offset = "0x51F1F10", VA = "0x1851F3710")]
	public void IBCENFPGIMP(MENIHLGCDFO<T> NFEFBDLCPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x51F3920", Offset = "0x51F2120", VA = "0x1851F3920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x51F3670", Offset = "0x51F1E70", VA = "0x1851F3670", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x51F36C0", Offset = "0x51F1EC0", VA = "0x1851F36C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct CFCDJGMMHDE : IEquatable<CFCDJGMMHDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int BFKGIFAKMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int PCFOAHIEPDL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AAMJOBPGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0CE0", Offset = "0x2DAF4E0", VA = "0x182DB0CE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6D588B0", Offset = "0x6D570B0", VA = "0x186D588B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int JIHNEJGHACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int AHCBKJCMCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B26A60", Offset = "0x7B25260", VA = "0x187B26A60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7B26A50", Offset = "0x7B25250", VA = "0x187B26A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public (int begin, int end) NDACODPNADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7B269F0", Offset = "0x7B251F0", VA = "0x187B269F0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xCEB9D0", Offset = "0xCEA1D0", VA = "0x180CEB9D0")]
	private CFCDJGMMHDE(int BFKGIFAKMAP, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2769F90", Offset = "0x2768790", VA = "0x182769F90")]
	public static CFCDJGMMHDE MIDHMCMBANF(int BFKGIFAKMAP, int PCFOAHIEPDL)
	{
		return default(CFCDJGMMHDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B26950", Offset = "0x7B25150", VA = "0x187B26950")]
	public static CFCDJGMMHDE DNEANDJHPHP(int MLFBDFDDHEO, int HDGKPCMCJDM)
	{
		return default(CFCDJGMMHDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7B26A70", Offset = "0x7B25270", VA = "0x187B26A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xEC9860", Offset = "0xEC8060", VA = "0x180EC9860", Slot = "4")]
	public bool Equals(CFCDJGMMHDE PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7B26960", Offset = "0x7B25160", VA = "0x187B26960", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA69B0", Offset = "0x6EA51B0", VA = "0x186EA69B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct CPDBABAGGPA<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> NFNBKNAJBPN;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
	public CPDBABAGGPA(NativeArray<T> NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x64E2A20", Offset = "0x64E1220", VA = "0x1864E2A20", Slot = "6")]
	public int Compare(int LEFBJAGNHCD, int LLGPJHIECFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x64E2B10", Offset = "0x64E1310", VA = "0x1864E2B10", Slot = "4")]
	public bool Equals(int LEFBJAGNHCD, int LLGPJHIECFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x64E2C00", Offset = "0x64E1400", VA = "0x1864E2C00", Slot = "5")]
	public int GetHashCode(int LEFBJAGNHCD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KAPNHGHHHCF
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3831350", Offset = "0x382FB50", VA = "0x183831350")]
	public static T[] IHJHKDDDCHP<T>(List<T> GIPAMJGJGNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FANCPHLCEAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* KJKKBCCPGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle JKFBMKMBGDG;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x59CE340", Offset = "0x59CCB40", VA = "0x1859CE340")]
	public void OCOBEACFBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class MGPCNFEBCMD
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x38C16D0", Offset = "0x38BFED0", VA = "0x1838C16D0")]
	public static FANCPHLCEAG EODBLICDEAH<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> BGBFHIDBILE) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(FANCPHLCEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x38C16D0", Offset = "0x38BFED0", VA = "0x1838C16D0")]
	public static UnsafeParallelHashMap<TKey, TValue> FDJFKFHEMBK<TKey, TValue>(this FANCPHLCEAG BGBFHIDBILE) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class CPDJAJJMJHA
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3598AA0", Offset = "0x35972A0", VA = "0x183598AA0")]
	public static int ELOLIALJGNL<T>(ReadOnlySpan<T> JMIKAGBCFHB, ReadOnlySpan<T> BNOGKOAGACH, int IMNFCKGEMOH) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class IDOBPILAAFC
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x37DFB40", Offset = "0x37DE340", VA = "0x1837DFB40")]
	public static T OABFAPACBPL<T>(this NativeArray<byte> GGBFBJAOFOK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x37DF720", Offset = "0x37DDF20", VA = "0x1837DF720")]
	public static NativeArray<T> MAKEJDDOIBA<T>(this NativeArray<byte> GGBFBJAOFOK, int PCFOAHIEPDL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x37DF530", Offset = "0x37DDD30", VA = "0x1837DF530")]
	public static void AMAEHFOLFGF<T>(this NativeList<byte> EFGFBKMBCFL, [In] T OPMIAMEJKDH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x37DF490", Offset = "0x37DDC90", VA = "0x1837DF490")]
	public static void AMAEHFOLFGF<T>(this NativeList<byte> EFGFBKMBCFL, NativeArray<T> OPMIAMEJKDH) where T : struct
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

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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7501B70", Offset = "0x7500170", VA = "0x187501B70", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[EDNMIOGDLLP]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x35BA910", Offset = "0x35B8F10", VA = "0x1835BA910")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[EDNMIOGDLLP]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x35C3300", Offset = "0x35C1900", VA = "0x1835C3300")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x35C3010", Offset = "0x35C1610", VA = "0x1835C3010")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x35C31C0", Offset = "0x35C17C0", VA = "0x1835C31C0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x35C3980", Offset = "0x35C1F80", VA = "0x1835C3980")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x35BAA50", Offset = "0x35B9050", VA = "0x1835BAA50")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x35BA9E0", Offset = "0x35B8FE0", VA = "0x1835BA9E0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35BAFD0", Offset = "0x35B95D0", VA = "0x1835BAFD0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, AFAOEOIHAIH range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x35BB010", Offset = "0x35B9610", VA = "0x1835BB010")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x35BAE40", Offset = "0x35B9440", VA = "0x1835BAE40")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x35C3100", Offset = "0x35C1700", VA = "0x1835C3100")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[EDNMIOGDLLP]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x35C3BF0", Offset = "0x35C21F0", VA = "0x1835C3BF0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x35C4EF0", Offset = "0x35C34F0", VA = "0x1835C4EF0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x35C3A70", Offset = "0x35C2070", VA = "0x1835C3A70")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x35C3C90", Offset = "0x35C2290", VA = "0x1835C3C90")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x35C6090", Offset = "0x35C4690", VA = "0x1835C6090")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x35C6040", Offset = "0x35C4640", VA = "0x1835C6040")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x49C78F0", Offset = "0x49C5EF0", VA = "0x1849C78F0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7501D10", Offset = "0x7500310", VA = "0x187501D10")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7501D40", Offset = "0x7500340", VA = "0x187501D40")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x35C55F0", Offset = "0x35C3BF0", VA = "0x1835C55F0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x35C5620", Offset = "0x35C3C20", VA = "0x1835C5620")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x35C58C0", Offset = "0x35C3EC0", VA = "0x1835C58C0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x35C5820", Offset = "0x35C3E20", VA = "0x1835C5820")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x35C5870", Offset = "0x35C3E70", VA = "0x1835C5870")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35C5A40", Offset = "0x35C4040", VA = "0x1835C5A40")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x35C5B10", Offset = "0x35C4110", VA = "0x1835C5B10")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x35C5970", Offset = "0x35C3F70", VA = "0x1835C5970")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35C5570", Offset = "0x35C3B70", VA = "0x1835C5570")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x35C5510", Offset = "0x35C3B10", VA = "0x1835C5510")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x35C54F0", Offset = "0x35C3AF0", VA = "0x1835C54F0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x35C6620", Offset = "0x35C4C20", VA = "0x1835C6620")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x35C60A0", Offset = "0x35C46A0", VA = "0x1835C60A0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x35C6650", Offset = "0x35C4C50", VA = "0x1835C6650")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x35C6710", Offset = "0x35C4D10", VA = "0x1835C6710")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[EDNMIOGDLLP]
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
			[Cpp2IlInjected.Address(RVA = "0x45E61C0", Offset = "0x45E47C0", VA = "0x1845E61C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2587DE0", Offset = "0x25863E0", VA = "0x182587DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAD38D0", Offset = "0xAD1ED0", VA = "0x180AD38D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1048800", Offset = "0x1046E00", VA = "0x181048800")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4B97450", Offset = "0x4B95A50", VA = "0x184B97450")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0D00", Offset = "0x4EEF300", VA = "0x184EF0D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0E20", Offset = "0x4EEF420", VA = "0x184EF0E20")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39C8540", Offset = "0x39C6B40", VA = "0x1839C8540")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[EDNMIOGDLLP]
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
			[Cpp2IlInjected.Address(RVA = "0x4F44810", Offset = "0x4F42E10", VA = "0x184F44810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4F44850", Offset = "0x4F42E50", VA = "0x184F44850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAD38D0", Offset = "0xAD1ED0", VA = "0x180AD38D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4B97450", Offset = "0x4B95A50", VA = "0x184B97450")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4F44470", Offset = "0x4F42A70", VA = "0x184F44470")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4F445B0", Offset = "0x4F42BB0", VA = "0x184F445B0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4F44770", Offset = "0x4F42D70", VA = "0x184F44770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4F445F0", Offset = "0x4F42BF0", VA = "0x184F445F0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[EDNMIOGDLLP]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[EDNMIOGDLLP]
public static class LNMBIPKJDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7501A80", Offset = "0x7500080", VA = "0x187501A80")]
	public static JobHandle HNIKNNELLAL(this JobHandle AMGCKABOOPF, JobHandle PPCFCAEIJMM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7501AC0", Offset = "0x75000C0", VA = "0x187501AC0")]
	public static JobHandle JJAAMCHCLPC(this Span<JobHandle> FEJHOLHIAPJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FOAAFPIHHGH
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33C43F0", Offset = "0x33C29F0", VA = "0x1833C43F0")]
	public static NativeKeyValueArrays<TKey, TValue> HBGANJMMBAD<TKey, TValue>(this Dictionary<TKey, TValue> EIEEOCBNIGD, Allocator LEILKJFLDFN) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class APIMBBEFLJL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x75002C0", Offset = "0x74FE8C0", VA = "0x1875002C0")]
	public static void DCMMGEFINKN(this GameObject HHDLNMHBJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7500400", Offset = "0x74FEA00", VA = "0x187500400")]
	public static void DCMMGEFINKN(this Component MEFMJJOMDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7500360", Offset = "0x74FE960", VA = "0x187500360")]
	public static void DCMMGEFINKN(this ScriptableObject CKOHFGFHCIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GGDEPLJEGEK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75011E0", Offset = "0x74FF7E0", VA = "0x1875011E0")]
	public static void JLBOABPGIKD(this NativeList<byte> BHMKCPLLJPF, ReadOnlySpan<byte> CAGFJFFHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x33D9630", Offset = "0x33D7C30", VA = "0x1833D9630")]
	public static void GKAMGOGHNAO<T>(this NativeList<T> BHMKCPLLJPF, T KBGCCIOIGBD, int BBEJNKBNMID) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EKLCEMIBDIK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x32755B0", Offset = "0x3273BB0", VA = "0x1832755B0")]
	public static T NEHNPOHBODH<T>(this ReadOnlySpan<byte> KBGCCIOIGBD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3274E40", Offset = "0x3273440", VA = "0x183274E40")]
	public static T BLJNCGENIAP<T>(this Span<T> CAGFJFFHONE, Func<T, bool> AIHIPPFIJLI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x32757B0", Offset = "0x3273DB0", VA = "0x1832757B0")]
	public static bool NJEKHJPFBEM<T>(this Span<T> CAGFJFFHONE, Func<T, bool> AIHIPPFIJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3275500", Offset = "0x3273B00", VA = "0x183275500")]
	public static bool EMECIEAELEF<T>(this Span<T> CAGFJFFHONE, Func<T, bool> AIHIPPFIJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3275860", Offset = "0x3273E60", VA = "0x183275860")]
	public static T NPPDIJEBOHO<T>([In] this ReadOnlySpan<byte> CAGFJFFHONE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3274FA0", Offset = "0x32735A0", VA = "0x183274FA0")]
	public static Span<TTo> CMDEJKOIBKH<TTo, TFrom>(this Span<TFrom> CAGFJFFHONE) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3274FA0", Offset = "0x32735A0", VA = "0x183274FA0")]
	public static ReadOnlySpan<TTo> CMDEJKOIBKH<TTo, TFrom>(this ReadOnlySpan<TFrom> CAGFJFFHONE) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3274FA0", Offset = "0x32735A0", VA = "0x183274FA0")]
	public static ReadOnlySpan<TTo> CMDEJKOIBKH<TTo>(this ReadOnlySpan<byte> CAGFJFFHONE) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3274FF0", Offset = "0x32735F0", VA = "0x183274FF0")]
	public static Span<byte> ECFLGDLFBIO<T>([In] this Span<byte> CAGFJFFHONE, T KBGCCIOIGBD) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7500BC0", Offset = "0x74FF1C0", VA = "0x187500BC0")]
	private static Enum MCHNPDDCJEI([In] ReadOnlySpan<byte> CAGFJFFHONE, Type IEJJAFNKCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7501170", Offset = "0x74FF770", VA = "0x187501170")]
	public static Enum MDJIJLHFHGI([In] this Span<byte> CAGFJFFHONE, Type IEJJAFNKCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75006B0", Offset = "0x74FECB0", VA = "0x1875006B0")]
	public static void JEOKEBJLLNO([In] this Span<byte> CAGFJFFHONE, Enum JJFHAAOAACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JNCENHIHDLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IPABHDPNPGJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7501370", Offset = "0x74FF970", VA = "0x187501370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75018A0", Offset = "0x74FFEA0", VA = "0x1875018A0")]
	[AsyncStateMachine(typeof(IPABHDPNPGJ))]
	public static void NAMLEHAPDOO(this Task CHBEBLKFDBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LBECJPEGAMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum EFNEDGACPCL : short
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
	public struct CMHCELEIKIE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly EFNEDGACPCL LKMGECEEGEE;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3840", Offset = "0x2BA1E40", VA = "0x182BA3840")]
		public CMHCELEIKIE(EFNEDGACPCL LKMGECEEGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory AJKIFLFMGBI;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	public static void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75019C0", Offset = "0x74FFFC0", VA = "0x1875019C0")]
	static LBECJPEGAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x30C7F00", Offset = "0x30C6500", VA = "0x1830C7F00")]
	public static CMHCELEIKIE BCMPJAIBHNF(EFNEDGACPCL LKMGECEEGEE)
	{
		return default(CMHCELEIKIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	public static void NGAFOAHPACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ABPKAFOEOHH
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B71700", Offset = "0x3B6FD00", VA = "0x183B71700")]
	public static PDLABPLNAOP<T1, T2> GJKBPIFNAEB<T1, T2>(this (T1, T2) IEFMBDGJEHE) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(PDLABPLNAOP<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x35FB4D0", Offset = "0x35F9AD0", VA = "0x1835FB4D0")]
	public static BKELICJOKPA<T1, T2, T3> GJKBPIFNAEB<T1, T2, T3>(this (T1, T2, T3) IEFMBDGJEHE) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(BKELICJOKPA<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PDLABPLNAOP<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) IEFMBDGJEHE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x50DE8C0", Offset = "0x50DCEC0", VA = "0x1850DE8C0")]
	public PDLABPLNAOP((T1, T2) IEFMBDGJEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x50DE540", Offset = "0x50DCB40", VA = "0x1850DE540", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BKELICJOKPA<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) IEFMBDGJEHE;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x50DE8D0", Offset = "0x50DCED0", VA = "0x1850DE8D0")]
	public BKELICJOKPA((T1, T2, T3) IEFMBDGJEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x58AC630", Offset = "0x58AAC30", VA = "0x1858AC630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OJOBBOEKOMG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7501D70", Offset = "0x7500370", VA = "0x187501D70")]
	public static Range ILDEHEFLBGE(this AFAOEOIHAIH OLCJMBGBODB)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LCNCDDIAODD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct DFGFKHBGPJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int PCGMGDLNIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int PDNKBEEOLID;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75006A0", Offset = "0x74FECA0", VA = "0x1875006A0")]
		public DFGFKHBGPJF(int HHIGALLBHNK, int PDNKBEEOLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7500690", Offset = "0x74FEC90", VA = "0x187500690")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7501A30", Offset = "0x7500030", VA = "0x187501A30")]
	public static DFGFKHBGPJF BNIMLGJMJBK(this Range OLCJMBGBODB)
	{
		return default(DFGFKHBGPJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JEJGOOFIOCM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle ILIIBOPHLDK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OMELLALBLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x49C78E0", Offset = "0x49C5EE0", VA = "0x1849C78E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x49C7AA0", Offset = "0x49C60A0", VA = "0x1849C7AA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x49C7670", Offset = "0x49C5C70", VA = "0x1849C7670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x49C7B50", Offset = "0x49C6150", VA = "0x1849C7B50")]
	public JEJGOOFIOCM(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x49C78F0", Offset = "0x49C5EF0", VA = "0x1849C78F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class CMGKHFLMPCH<THandle, TValue> : IDisposable where THandle : struct, KBLKBJHICLE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> FEJHOLHIAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> BMKDAHEBDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> LIIDCFJPENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> LGOBFOJKGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int FADPNACOMMP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5C47C00", Offset = "0x5C46200", VA = "0x185C47C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5C48150", Offset = "0x5C46750", VA = "0x185C48150")]
	public CMGKHFLMPCH(Action<TValue> LGOBFOJKGCH, [Optional] Func<TValue> LIIDCFJPENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5C47630", Offset = "0x5C45C30", VA = "0x185C47630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5C47A60", Offset = "0x5C46060", VA = "0x185C47A60")]
	public THandle HBHDBABAKDP(TValue KBGCCIOIGBD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5C47F20", Offset = "0x5C46520", VA = "0x185C47F20")]
	public bool MHAKNCNBNPL(THandle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5C47820", Offset = "0x5C45E20", VA = "0x185C47820")]
	public bool FKKNKLKECHH(THandle ILIIBOPHLDK, [Out] TValue KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5C48100", Offset = "0x5C46700", VA = "0x185C48100")]
	public TValue NPPDIJEBOHO(THandle ILIIBOPHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5C478F0", Offset = "0x5C45EF0", VA = "0x185C478F0")]
	public bool GAJJJBGADKG(THandle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5C47A00", Offset = "0x5C46000", VA = "0x185C47A00")]
	private THandle GLJEICIMAEJ(int EAHKFAJBNDN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C47BA0", Offset = "0x5C461A0", VA = "0x185C47BA0")]
	private TValue KBDHOHCCAKN(int EAHKFAJBNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C47B00", Offset = "0x5C46100", VA = "0x185C47B00")]
	private void IMAPNKAICOL(int EAHKFAJBNDN, [In] THandle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5C47B50", Offset = "0x5C46150", VA = "0x185C47B50")]
	private void INPBODAIAMI(int EAHKFAJBNDN, [In] TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5C47470", Offset = "0x5C45A70", VA = "0x185C47470")]
	private THandle CFLAEGMIOFH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5C47700", Offset = "0x5C45D00", VA = "0x185C47700")]
	private void EKEOGCPLEOI(THandle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5C47620", Offset = "0x5C45C20", VA = "0x185C47620")]
	private int CKANCLANFDB(int EPKMALKPPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5C47810", Offset = "0x5C45E10", VA = "0x185C47810")]
	private bool EPJLPDFGFGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9529F0", Offset = "0x950FF0", VA = "0x1809529F0")]
	private void GGHNFGMGMPM(THandle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5C48050", Offset = "0x5C46650", VA = "0x185C48050")]
	private bool MJBJCBCFDFF([Out] THandle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5C47C40", Offset = "0x5C46240", VA = "0x185C47C40")]
	private bool LADECMHPOEK([Out] THandle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5C47D70", Offset = "0x5C46370", VA = "0x185C47D70")]
	private void LGJECBMFPKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KBLKBJHICLE
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int EMCKBBMGOCJ
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
public static class GHLEINEKGDH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x33DB220", Offset = "0x33D9820", VA = "0x1833DB220")]
	public static bool CDIGNFEMAPE<T>(this T ILIIBOPHLDK, T OKCHLIEAIJP) where T : struct, KBLKBJHICLE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x33DB240", Offset = "0x33D9840", VA = "0x1833DB240")]
	public static bool DLCFPDABHIK<T>(this T ILIIBOPHLDK) where T : struct, KBLKBJHICLE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7501260", Offset = "0x74FF860", VA = "0x187501260")]
	public static string AOHMNHJEEBA(this KBLKBJHICLE ILIIBOPHLDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public ref struct MCJIKLCEHHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type CGEBKNPACFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> JJPHGJAOIKO;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4B9E320", Offset = "0x4B9C920", VA = "0x184B9E320")]
	public MCJIKLCEHHO(Type JPONOFBEDEB, Span<byte> CAGFJFFHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3501E10", Offset = "0x3500410", VA = "0x183501E10")]
	public static MCJIKLCEHHO BIBMBKHCCLP<T>(T KBGCCIOIGBD) where T : struct
	{
		return default(MCJIKLCEHHO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7501C00", Offset = "0x7500200", VA = "0x187501C00")]
	public static JIDNOMDMPBK HEGJABMHLEC([In] MCJIKLCEHHO FBIKENCMLKN)
	{
		return default(JIDNOMDMPBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7501C90", Offset = "0x7500290", VA = "0x187501C90")]
	public Enum MDJIJLHFHGI(Type IEJJAFNKCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x35027A0", Offset = "0x3500DA0", VA = "0x1835027A0")]
	public void ECFLGDLFBIO<T>([In] T KBGCCIOIGBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7501C80", Offset = "0x7500280", VA = "0x187501C80")]
	public void JEOKEBJLLNO(Enum JJFHAAOAACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct JIDNOMDMPBK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct OJFOCGFODOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* APEAIFHAOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* OLMIKPCCIFF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type CGEBKNPACFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> JJPHGJAOIKO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ENBIOKPCFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7501540", Offset = "0x74FFB40", VA = "0x187501540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KDJLCLFKAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75014F0", Offset = "0x74FFAF0", VA = "0x1875014F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4B9E320", Offset = "0x4B9C920", VA = "0x184B9E320")]
	public JIDNOMDMPBK(Type JPONOFBEDEB, ReadOnlySpan<byte> CAGFJFFHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3470940", Offset = "0x346EF40", VA = "0x183470940")]
	public static JIDNOMDMPBK BIBMBKHCCLP<T>(T KBGCCIOIGBD) where T : struct
	{
		return default(JIDNOMDMPBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7501720", Offset = "0x74FFD20", VA = "0x187501720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7501550", Offset = "0x74FFB50", VA = "0x187501550")]
	public object KELOPMBBOJL(int EAHKFAJBNDN = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DBGDHCGFMPH
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3243360", Offset = "0x3241960", VA = "0x183243360")]
	public static NativeArray<T> BIBMBKHCCLP<T>(T KBGCCIOIGBD, bool PALJJFCJPCE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3243470", Offset = "0x3241A70", VA = "0x183243470")]
	public static NativeArray<T> IBBPPCPNOLA<T>(T KBGCCIOIGBD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3243420", Offset = "0x3241A20", VA = "0x183243420")]
	public static NativeArray<T> GPJKILNJIOO<T>(T KBGCCIOIGBD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75005D0", Offset = "0x74FEBD0", VA = "0x1875005D0")]
	public static NativeArray<byte> GPJKILNJIOO(ReadOnlySpan<byte> KBGCCIOIGBD)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7500520", Offset = "0x74FEB20", VA = "0x187500520")]
	public static NativeArray<byte> BIBMBKHCCLP(ReadOnlySpan<byte> KBGCCIOIGBD, bool PALJJFCJPCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x75004A0", Offset = "0x74FEAA0", VA = "0x1875004A0")]
	public unsafe static NativeArray<byte> BIBMBKHCCLP(byte* IDAHGADPNKM, int GIGAFKHMOHH, bool PALJJFCJPCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x32433B0", Offset = "0x32419B0", VA = "0x1832433B0")]
	public static NativeArray<T> DGEEMDAPOEK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct OGDNAOAMJJL<Handle> where Handle : KBLKBJHICLE, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct HKNCJECFPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly OGDNAOAMJJL<Handle> DFPGJPGNKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Handle EDAHNBNCAEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x4692980", Offset = "0x4690F80", VA = "0x184692980")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4692C60", Offset = "0x4691260", VA = "0x184692C60")]
		public HKNCJECFPEM(OGDNAOAMJJL<Handle> DFPGJPGNKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4692830", Offset = "0x4690E30", VA = "0x184692830")]
		public HPNDEBFFHBG FEOBEKOIKMG([In] HPNDEBFFHBG MEBAFDHEDIN)
		{
			return default(HPNDEBFFHBG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x46925F0", Offset = "0x4690BF0", VA = "0x1846925F0")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4692920", Offset = "0x4690F20", VA = "0x184692920")]
		private Handle FIBIOINKBBP(string MIALAMIFNLM)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct HPNDEBFFHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HKNCJECFPEM HAAEOILGJLD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x46C7930", Offset = "0x46C5F30", VA = "0x1846C7930")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x46C79B0", Offset = "0x46C5FB0", VA = "0x1846C79B0")]
		public HPNDEBFFHBG(OGDNAOAMJJL<Handle> DFPGJPGNKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x46C78B0", Offset = "0x46C5EB0", VA = "0x1846C78B0")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x46C7840", Offset = "0x46C5E40", VA = "0x1846C7840")]
		public HPNDEBFFHBG BNIMLGJMJBK()
		{
			return default(HPNDEBFFHBG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeList<int> IEDHOBIHJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<int> CBAHMKNCGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int BPJGJKNGDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int MOPCAPILDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool PDELIBIHBKB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JLPIJPCEGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9A10", Offset = "0x4FF8010", VA = "0x184FF9A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HPNDEBFFHBG DOHKIOHAABD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4FF96E0", Offset = "0x4FF7CE0", VA = "0x184FF96E0")]
		get
		{
			return default(HPNDEBFFHBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA2E0", Offset = "0x4FF88E0", VA = "0x184FFA2E0")]
	public OGDNAOAMJJL(int ALOJAOINMGK, Allocator LEILKJFLDFN = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4FF94C0", Offset = "0x4FF7AC0", VA = "0x184FF94C0")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4720", Offset = "0x1EC2D20", VA = "0x181EC4720")]
	public static int CKANCLANFDB(int EFDAGALIIFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0590", Offset = "0x2BDEB90", VA = "0x182BE0590")]
	public static bool DPFEFMJJMNM(int EFDAGALIIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9770", Offset = "0x4FF7D70", VA = "0x184FF9770")]
	public bool JDIHHNAAADB(int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9BD0", Offset = "0x4FF81D0", VA = "0x184FF9BD0")]
	public bool LFDEKKFNDAO(Handle ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9240", Offset = "0x4FF7840", VA = "0x184FF9240")]
	public Handle DNPGFAAICNC()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8770", Offset = "0x4FF6D70", VA = "0x184FF8770")]
	public void AMGEOOLHBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8E20", Offset = "0x4FF7420", VA = "0x184FF8E20")]
	public void BDCGGEAMIMP(Handle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9C3E0", VA = "0x180C9DDE0")]
	private bool HPDDBOHGAII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9FF0", Offset = "0x4FF85F0", VA = "0x184FF9FF0")]
	private bool NFAFJFIOIBD(int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8E90", Offset = "0x4FF7490", VA = "0x184FF8E90")]
	private void DNIDHMCDGHN([Out] int EAHKFAJBNDN, [Out] int EPKMALKPPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9EA0", Offset = "0x4FF84A0", VA = "0x184FF9EA0")]
	private void LKCHNLDAAPK(Handle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9640", Offset = "0x4FF7C40", VA = "0x184FF9640")]
	private void GMLHACOCGBN(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA160", Offset = "0x4FF8760", VA = "0x184FFA160")]
	private bool OGHPJEGGALN([Out] int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9310", Offset = "0x4FF7910", VA = "0x184FF9310")]
	private static Handle ELBCCBGKJIO(int EAHKFAJBNDN, int EPKMALKPPHD)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public struct EIGPGNLJKGL<Handle, T> where Handle : KBLKBJHICLE, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private OGDNAOAMJJL<Handle> EKNOEAJIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] JFNIOBJOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Action<T> ICBKKFJOOIE;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x405B890", Offset = "0x4059E90", VA = "0x18405B890")]
	public EIGPGNLJKGL(int ALOJAOINMGK, [Optional] Action<T> ICBKKFJOOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x405AC10", Offset = "0x4059210", VA = "0x18405AC10")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x405AAE0", Offset = "0x40590E0", VA = "0x18405AAE0")]
	public bool FKKNKLKECHH(Handle ILIIBOPHLDK, [Out] T GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x405AC90", Offset = "0x4059290", VA = "0x18405AC90")]
	public Handle HBHDBABAKDP(T GMFKPONAANG)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x405AFD0", Offset = "0x40595D0", VA = "0x18405AFD0")]
	public void LMPMJJEOBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x405B500", Offset = "0x4059B00", VA = "0x18405B500")]
	public void OCDDHDAHAOD(Handle ILIIBOPHLDK, [Out] T HEEPFINKPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x405B430", Offset = "0x4059A30", VA = "0x18405B430")]
	public void OCDDHDAHAOD(Handle ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x405AEB0", Offset = "0x40594B0", VA = "0x18405AEB0")]
	private T IKJELBOAPFN(int EAHKFAJBNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x405AF10", Offset = "0x4059510", VA = "0x18405AF10")]
	private void JMCNAKAKFPM(int ENCJEFBIFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public struct JLFIEIINFCM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LAKENFPFPMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private JLFIEIINFCM<T> CJFOOLJEHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4BA20E0", Offset = "0x4BA06E0", VA = "0x184BA20E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x25B2810", Offset = "0x25B0E10", VA = "0x1825B2810")]
		public LAKENFPFPMK(JLFIEIINFCM<T> CJFOOLJEHLK, int EAHKFAJBNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2090", Offset = "0x4BA0690", VA = "0x184BA2090")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OPJIBDHPGHD : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JLFIEIINFCM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public OPJIBDHPGHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x50330E0", Offset = "0x50316E0", VA = "0x1850330E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5033180", Offset = "0x5031780", VA = "0x185033180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OPNMKPPOPMO : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JLFIEIINFCM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public OPNMKPPOPMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x50331D0", Offset = "0x50317D0", VA = "0x1850331D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5033270", Offset = "0x5031870", VA = "0x185033270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private object[] GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private uint KBGCCIOIGBD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x49D7810", Offset = "0x49D5E10", VA = "0x1849D7810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x49D6E20", Offset = "0x49D5420", VA = "0x1849D6E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1511EB0", Offset = "0x15104B0", VA = "0x181511EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal bool NLLLLJCPONE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x49D6DA0", Offset = "0x49D53A0", VA = "0x1849D6DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PBNFEBACEHD<T> JJPHGJAOIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x49D71E0", Offset = "0x49D57E0", VA = "0x1849D71E0")]
		get
		{
			return default(PBNFEBACEHD<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x49D73E0", Offset = "0x49D59E0", VA = "0x1849D73E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x49D6F30", Offset = "0x49D5530", VA = "0x1849D6F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x49D7A70", Offset = "0x49D6070", VA = "0x1849D7A70")]
	internal JLFIEIINFCM(JLFIEIINFCM<T> CJFOOLJEHLK, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x49D7A90", Offset = "0x49D6090", VA = "0x1849D7A90")]
	private JLFIEIINFCM(T[] CJFOOLJEHLK, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x49D7AB0", Offset = "0x49D60B0", VA = "0x1849D7AB0")]
	public JLFIEIINFCM(IEnumerable<T> BMKDAHEBDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x49D7A00", Offset = "0x49D6000", VA = "0x1849D7A00")]
	public JLFIEIINFCM(int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x49D70C0", Offset = "0x49D56C0", VA = "0x1849D70C0")]
	public int FBHOADIJODJ(T KBGCCIOIGBD, int HHIGALLBHNK, int BBEJNKBNMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x49D77D0", Offset = "0x49D5DD0", VA = "0x1849D77D0")]
	public void PLHNLDBAEHM(int JEDDAOEOEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x49D74B0", Offset = "0x49D5AB0", VA = "0x1849D74B0")]
	private void NJDFGCLIKLM(int JEDDAOEOEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x49D7360", Offset = "0x49D5960", VA = "0x1849D7360")]
	public T[] KCDBGCDLIIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x49D7680", Offset = "0x49D5C80", VA = "0x1849D7680")]
	public T[] OMBEABDDNID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x49D6EB0", Offset = "0x49D54B0", VA = "0x1849D6EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x49D6FE0", Offset = "0x49D55E0", VA = "0x1849D6FE0")]
	public void EEBKPKCHGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x49D6DB0", Offset = "0x49D53B0", VA = "0x1849D6DB0")]
	public LAKENFPFPMK BNIMLGJMJBK()
	{
		return default(LAKENFPFPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x49D7820", Offset = "0x49D5E20", VA = "0x1849D7820", Slot = "5")]
	[IteratorStateMachine(typeof(JLFIEIINFCM<>.OPJIBDHPGHD))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x49D7910", Offset = "0x49D5F10", VA = "0x1849D7910", Slot = "6")]
	[IteratorStateMachine(typeof(JLFIEIINFCM<>.OPNMKPPOPMO))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x49D6E50", Offset = "0x49D5450", VA = "0x1849D6E50")]
	public static JLFIEIINFCM<T> CFHFHHCEJLA(T[] CJFOOLJEHLK)
	{
		return default(JLFIEIINFCM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x49D7140", Offset = "0x49D5740", VA = "0x1849D7140")]
	public static JLFIEIINFCM<T> HEGJABMHLEC(T[] CJFOOLJEHLK)
	{
		return default(JLFIEIINFCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x49D7040", Offset = "0x49D5640", VA = "0x1849D7040")]
	private void EGKGAANGNIA(int EAHKFAJBNDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class EFMCPKJOHAF<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct IHGAFFHLEAP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EFMCPKJOHAF<T> BHMKCPLLJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x477A4F0", Offset = "0x4778AF0", VA = "0x18477A4F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x477A530", Offset = "0x4778B30", VA = "0x18477A530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x40F2660", Offset = "0x40F0C60", VA = "0x1840F2660")]
		public IHGAFFHLEAP(EFMCPKJOHAF<T> BHMKCPLLJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x477A400", Offset = "0x4778A00", VA = "0x18477A400", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x477A4A0", Offset = "0x4778AA0", VA = "0x18477A4A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private JLFIEIINFCM<T> GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int GIGAFKHMOHH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4051560", Offset = "0x404FB60", VA = "0x184051560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4050EF0", Offset = "0x404F4F0", VA = "0x184050EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int JLPIJPCEGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x40512C0", Offset = "0x404F8C0", VA = "0x1840512C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4051540", Offset = "0x404FB40", VA = "0x184051540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PBNFEBACEHD<T> JJPHGJAOIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4051160", Offset = "0x404F760", VA = "0x184051160")]
		get
		{
			return default(PBNFEBACEHD<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x40517E0", Offset = "0x404FDE0", VA = "0x1840517E0")]
	public EFMCPKJOHAF(IEnumerable<T> BMKDAHEBDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4051770", Offset = "0x404FD70", VA = "0x184051770")]
	public EFMCPKJOHAF(int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x40515D0", Offset = "0x404FBD0", VA = "0x1840515D0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4051500", Offset = "0x404FB00", VA = "0x184051500")]
	public JLFIEIINFCM<T> JMMFOEIKCJJ()
	{
		return default(JLFIEIINFCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4050F30", Offset = "0x404F530", VA = "0x184050F30")]
	public void HBHDBABAKDP(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4051680", Offset = "0x404FC80", VA = "0x184051680")]
	private void PLHNLDBAEHM(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x40512E0", Offset = "0x404F8E0", VA = "0x1840512E0")]
	public void JLBOABPGIKD(List<T> BHJLHIOPPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4051460", Offset = "0x404FA60", VA = "0x184051460")]
	public void JLBOABPGIKD(T[] BHJLHIOPPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x40511E0", Offset = "0x404F7E0", VA = "0x1840511E0")]
	public void JFBBKNCFILH(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4050870", Offset = "0x404EE70", VA = "0x184050870")]
	public void BMPFKKHNCGP(int LMPADJBGAAM, int PDNKBEEOLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4050BB0", Offset = "0x404F1B0", VA = "0x184050BB0")]
	public int FBHOADIJODJ(T KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4051050", Offset = "0x404F650", VA = "0x184051050")]
	public bool HBIAGPPOPJF(T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4051610", Offset = "0x404FC10", VA = "0x184051610")]
	public T[] OMBEABDDNID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4050B90", Offset = "0x404F190", VA = "0x184050B90", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x40510A0", Offset = "0x404F6A0", VA = "0x1840510A0")]
	public static JLFIEIINFCM<T> HEGJABMHLEC(EFMCPKJOHAF<T> BHMKCPLLJPF)
	{
		return default(JLFIEIINFCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4050E80", Offset = "0x404F480", VA = "0x184050E80", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x40516C0", Offset = "0x404FCC0", VA = "0x1840516C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4051700", Offset = "0x404FD00", VA = "0x184051700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4050A40", Offset = "0x404F040", VA = "0x184050A40")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DIJOOPFNHKC(int KBGCCIOIGBD, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4050C30", Offset = "0x404F230", VA = "0x184050C30")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void FCICMLALJCK(int LMPADJBGAAM, int PDNKBEEOLID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class CLEFMLOBIHF
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x320D5E0", Offset = "0x320BBE0", VA = "0x18320D5E0")]
	public static void EEBKPKCHGJJ<T>(this EFMCPKJOHAF<T> BHMKCPLLJPF) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public ref struct PBNFEBACEHD<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Span<object> GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x50DA320", Offset = "0x50D8920", VA = "0x1850DA320")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x50DA250", Offset = "0x50D8850", VA = "0x1850DA250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x50DA550", Offset = "0x50D8B50", VA = "0x1850DA550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x10488D0", Offset = "0x1046ED0", VA = "0x1810488D0")]
	public PBNFEBACEHD(Span<object> CAGFJFFHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x50DA3A0", Offset = "0x50D89A0", VA = "0x1850DA3A0")]
	public PBNFEBACEHD<T> LDOCMGHKFNG(int HHIGALLBHNK)
	{
		return default(PBNFEBACEHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x50DA470", Offset = "0x50D8A70", VA = "0x1850DA470")]
	public PBNFEBACEHD<T> LDOCMGHKFNG(int HHIGALLBHNK, int GIGAFKHMOHH)
	{
		return default(PBNFEBACEHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x50DA1F0", Offset = "0x50D87F0", VA = "0x1850DA1F0")]
	public void DCNHFJIJBBF(PBNFEBACEHD<T> MLMIGGIAIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x50DA590", Offset = "0x50D8B90", VA = "0x1850DA590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x50DA280", Offset = "0x50D8880", VA = "0x1850DA280", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x50DA2D0", Offset = "0x50D88D0", VA = "0x1850DA2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct AFAOEOIHAIH : IEquatable<AFAOEOIHAIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int FDJGEFDKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int BBEJNKBNMID;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int MBLKEEKGIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BB97F0", VA = "0x182BBB1F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67C36C0", Offset = "0x67C1CC0", VA = "0x1867C36C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BFKEFBLNOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int BMHADMIFCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7500220", Offset = "0x74FE820", VA = "0x187500220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x75001B0", Offset = "0x74FE7B0", VA = "0x1875001B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public (int begin, int end) NJEGBGKCJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x75001C0", Offset = "0x74FE7C0", VA = "0x1875001C0")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xBD0F00", Offset = "0xBCF500", VA = "0x180BD0F00")]
	private AFAOEOIHAIH(int FDJGEFDKBBO, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x25977F0", Offset = "0x2595DF0", VA = "0x1825977F0")]
	public static AFAOEOIHAIH KCCEFNCOCIC(int FDJGEFDKBBO, int BBEJNKBNMID)
	{
		return default(AFAOEOIHAIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7500110", Offset = "0x74FE710", VA = "0x187500110")]
	public static AFAOEOIHAIH ACIIKDEHCMN(int HHIGALLBHNK, int PDNKBEEOLID)
	{
		return default(AFAOEOIHAIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7500230", Offset = "0x74FE830", VA = "0x187500230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1699F90", Offset = "0x1698590", VA = "0x181699F90", Slot = "4")]
	public bool Equals(AFAOEOIHAIH OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7500120", Offset = "0x74FE720", VA = "0x187500120", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6923A50", Offset = "0x6922050", VA = "0x186923A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PLFMFBLNNFB<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NativeArray<T> GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x10488D0", Offset = "0x1046ED0", VA = "0x1810488D0")]
	public PLFMFBLNNFB(NativeArray<T> GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x510B160", Offset = "0x5109760", VA = "0x18510B160", Slot = "6")]
	public int Compare(int IKAEODCKAIP, int ACCJFOPIMAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x510B250", Offset = "0x5109850", VA = "0x18510B250", Slot = "4")]
	public bool Equals(int IKAEODCKAIP, int ACCJFOPIMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x510B340", Offset = "0x5109940", VA = "0x18510B340", Slot = "5")]
	public int GetHashCode(int IKAEODCKAIP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MFKDGFIANHO
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x35092F0", Offset = "0x35078F0", VA = "0x1835092F0")]
	public static T[] GEHKPALOLCO<T>(List<T> BHMKCPLLJPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MDJGHHKHMIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* DPHPPGLEIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal AllocatorManager.AllocatorHandle OFIGJAJEHHD;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x55238E0", Offset = "0x5521EE0", VA = "0x1855238E0")]
	public void GDCMIOJAIMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DJPPAONDOIH
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x32513F0", Offset = "0x324F9F0", VA = "0x1832513F0")]
	public static MDJGHHKHMIF BPCCLCENHJA<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> JAGFBALGAPL) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(MDJGHHKHMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x32513F0", Offset = "0x324F9F0", VA = "0x1832513F0")]
	public static UnsafeParallelHashMap<TKey, TValue> FGOEKJJOLFI<TKey, TValue>(this MDJGHHKHMIF JAGFBALGAPL) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MANMMJOBDIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3501730", Offset = "0x34FFD30", VA = "0x183501730")]
	public static int JKBHAJNPHJH<T>(ReadOnlySpan<T> IHKMBGJFAJG, ReadOnlySpan<T> LOGJMEEGKLF, int GIGAFKHMOHH) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KBHCBKICLGD
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3497300", Offset = "0x3495900", VA = "0x183497300")]
	public static T ECCIGIDPGHK<T>(this NativeArray<byte> MOEBIEOOLFC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3497390", Offset = "0x3495990", VA = "0x183497390")]
	public static NativeArray<T> GCIKDJEKOFO<T>(this NativeArray<byte> MOEBIEOOLFC, int BBEJNKBNMID) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3497850", Offset = "0x3495E50", VA = "0x183497850")]
	public static void KAOFGLNGLFA<T>(this NativeList<byte> JEFFDGNDMGE, [In] T KBGCCIOIGBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x34977B0", Offset = "0x3495DB0", VA = "0x1834977B0")]
	public static void KAOFGLNGLFA<T>(this NativeList<byte> JEFFDGNDMGE, NativeArray<T> KBGCCIOIGBD) where T : struct
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

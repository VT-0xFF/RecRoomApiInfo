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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75FA150", Offset = "0x75F9350", VA = "0x1875FA150", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[HFEDOFECIGO]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x361B450", Offset = "0x361A650", VA = "0x18361B450")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[HFEDOFECIGO]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3623CB0", Offset = "0x3622EB0", VA = "0x183623CB0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x36239E0", Offset = "0x3622BE0", VA = "0x1836239E0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3623B80", Offset = "0x3622D80", VA = "0x183623B80")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3624330", Offset = "0x3623530", VA = "0x183624330")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x361B520", Offset = "0x361A720", VA = "0x18361B520")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x361B6E0", Offset = "0x361A8E0", VA = "0x18361B6E0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x361BB00", Offset = "0x361AD00", VA = "0x18361BB00")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, AIKFLEGLMCF range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x361BB40", Offset = "0x361AD40", VA = "0x18361BB40")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x361B970", Offset = "0x361AB70", VA = "0x18361B970")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3623AC0", Offset = "0x3622CC0", VA = "0x183623AC0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[HFEDOFECIGO]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3624660", Offset = "0x3623860", VA = "0x183624660")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3625A20", Offset = "0x3624C20", VA = "0x183625A20")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3624420", Offset = "0x3623620", VA = "0x183624420")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3624700", Offset = "0x3623900", VA = "0x183624700")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3626D20", Offset = "0x3625F20", VA = "0x183626D20")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3626CD0", Offset = "0x3625ED0", VA = "0x183626CD0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x46567D0", Offset = "0x46559D0", VA = "0x1846567D0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75FA1E0", Offset = "0x75F93E0", VA = "0x1875FA1E0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75FA210", Offset = "0x75F9410", VA = "0x1875FA210")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x36260F0", Offset = "0x36252F0", VA = "0x1836260F0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x36260A0", Offset = "0x36252A0", VA = "0x1836260A0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x36264A0", Offset = "0x36256A0", VA = "0x1836264A0")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3626450", Offset = "0x3625650", VA = "0x183626450")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3626400", Offset = "0x3625600", VA = "0x183626400")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3626720", Offset = "0x3625920", VA = "0x183626720")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x36267F0", Offset = "0x36259F0", VA = "0x1836267F0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3626650", Offset = "0x3625850", VA = "0x183626650")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x36262D0", Offset = "0x36254D0", VA = "0x1836262D0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3626040", Offset = "0x3625240", VA = "0x183626040")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3626020", Offset = "0x3625220", VA = "0x183626020")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3627100", Offset = "0x3626300", VA = "0x183627100")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3626D30", Offset = "0x3625F30", VA = "0x183626D30")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3627130", Offset = "0x3626330", VA = "0x183627130")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x36271F0", Offset = "0x36263F0", VA = "0x1836271F0")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[HFEDOFECIGO]
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
			[Cpp2IlInjected.Address(RVA = "0x46813A0", Offset = "0x46805A0", VA = "0x1846813A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x25BDAC0", Offset = "0x25BCCC0", VA = "0x1825BDAC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB45CB0", Offset = "0xB44EB0", VA = "0x180B45CB0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4B14DE0", Offset = "0x4B13FE0", VA = "0x184B14DE0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4E5FB80", Offset = "0x4E5ED80", VA = "0x184E5FB80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4E5F9C0", Offset = "0x4E5EBC0", VA = "0x184E5F9C0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3847C00", Offset = "0x3846E00", VA = "0x183847C00")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[HFEDOFECIGO]
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
			[Cpp2IlInjected.Address(RVA = "0x46813A0", Offset = "0x46805A0", VA = "0x1846813A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4EB2F20", Offset = "0x4EB2120", VA = "0x184EB2F20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB45CB0", Offset = "0xB44EB0", VA = "0x180B45CB0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4B14DE0", Offset = "0x4B13FE0", VA = "0x184B14DE0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2990", Offset = "0x4EB1B90", VA = "0x184EB2990")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2B40", Offset = "0x4EB1D40", VA = "0x184EB2B40")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2D10", Offset = "0x4EB1F10", VA = "0x184EB2D10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2C40", Offset = "0x4EB1E40", VA = "0x184EB2C40")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[HFEDOFECIGO]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HFEDOFECIGO]
public static class BIAMJBNHDJK
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x75F8F20", Offset = "0x75F8120", VA = "0x1875F8F20")]
	public static JobHandle EJFEHMMHMFL(this JobHandle IHGFIECIOLJ, JobHandle FHOBAJOBBGC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x75F8E70", Offset = "0x75F8070", VA = "0x1875F8E70")]
	public static JobHandle CMINOELPDKH(this Span<JobHandle> OPEHJJPEJMB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EOFIHAPAADP
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32F7720", Offset = "0x32F6920", VA = "0x1832F7720")]
	public static NativeKeyValueArrays<TKey, TValue> LPJPCKJHMIE<TKey, TValue>(this Dictionary<TKey, TValue> AJOKDFPIHEH, Allocator JNKCCGKBKPB) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class CGCCOAMIDOO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x75F9000", Offset = "0x75F8200", VA = "0x1875F9000")]
	public static void MEAEBCPMDFJ(this GameObject LNIONOAAAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x75F8F60", Offset = "0x75F8160", VA = "0x1875F8F60")]
	public static void MEAEBCPMDFJ(this Component BNCELPABAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x75F90A0", Offset = "0x75F82A0", VA = "0x1875F90A0")]
	public static void MEAEBCPMDFJ(this ScriptableObject FGGBIOOLAMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PIPCPHEPDGK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75FA670", Offset = "0x75F9870", VA = "0x1875FA670")]
	public static void GHMFFPPBIMB(this NativeList<byte> KBPAKCCMOCP, ReadOnlySpan<byte> HKNNPOLHEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3673B60", Offset = "0x3672D60", VA = "0x183673B60")]
	public static void NCMHHOGCHIG<T>(this NativeList<T> KBPAKCCMOCP, T OMFJNFBDJCA, int IPBKHOJKHLJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LLJOCDGCCEC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x353D7A0", Offset = "0x353C9A0", VA = "0x18353D7A0")]
	public static T CAJCDEHJDGM<T>(this ReadOnlySpan<byte> OMFJNFBDJCA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x353E450", Offset = "0x353D650", VA = "0x18353E450")]
	public static T OKMDMABMPBP<T>(this Span<T> HKNNPOLHEOK, Func<T, bool> OAOFEGDJFKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x353DEB0", Offset = "0x353D0B0", VA = "0x18353DEB0")]
	public static bool IODKNLGJFGL<T>(this Span<T> HKNNPOLHEOK, Func<T, bool> OAOFEGDJFKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x353D6B0", Offset = "0x353C8B0", VA = "0x18353D6B0")]
	public static bool AAKMJHEDOHN<T>(this Span<T> HKNNPOLHEOK, Func<T, bool> OAOFEGDJFKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x353DF50", Offset = "0x353D150", VA = "0x18353DF50")]
	public static T NKAAMPBENGI<T>([In] this ReadOnlySpan<byte> HKNNPOLHEOK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x353D750", Offset = "0x353C950", VA = "0x18353D750")]
	public static Span<TTo> BLFHADDGAGK<TTo, TFrom>(this Span<TFrom> HKNNPOLHEOK) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x353D750", Offset = "0x353C950", VA = "0x18353D750")]
	public static ReadOnlySpan<TTo> BLFHADDGAGK<TTo, TFrom>(this ReadOnlySpan<TFrom> HKNNPOLHEOK) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x353D750", Offset = "0x353C950", VA = "0x18353D750")]
	public static ReadOnlySpan<TTo> BLFHADDGAGK<TTo>(this ReadOnlySpan<byte> HKNNPOLHEOK) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x353D9A0", Offset = "0x353CBA0", VA = "0x18353D9A0")]
	public static Span<byte> GFIEJLHFJLN<T>([In] this Span<byte> HKNNPOLHEOK, T OMFJNFBDJCA) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x75F9630", Offset = "0x75F8830", VA = "0x1875F9630")]
	private static Enum EFKJIBBJHBC([In] ReadOnlySpan<byte> HKNNPOLHEOK, Type GHOKLIOMHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x75FA0E0", Offset = "0x75F92E0", VA = "0x1875FA0E0")]
	public static Enum NDBNEMKOOFG([In] this Span<byte> HKNNPOLHEOK, Type GHOKLIOMHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75F9BD0", Offset = "0x75F8DD0", VA = "0x1875F9BD0")]
	public static void JEKNFMPCIEF([In] this Span<byte> HKNNPOLHEOK, Enum PMBHGOELOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EDMGFNJGIFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct FBJFNDKFKJJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75F9450", Offset = "0x75F8650", VA = "0x1875F9450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75F9330", Offset = "0x75F8530", VA = "0x1875F9330")]
	[AsyncStateMachine(typeof(FBJFNDKFKJJ))]
	public static void FBHIKHBOOCB(this Task FDDEDLKEPIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OCGIBJNDKKD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PIFNDFKNPCM : short
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
	public struct OOBEEGPEMII : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly PIFNDFKNPCM MBDBONINAPC;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BD61F0", Offset = "0x2BD53F0", VA = "0x182BD61F0")]
		public OOBEEGPEMII(PIFNDFKNPCM MBDBONINAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory KDIPEHDJNCB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	public static void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75FA240", Offset = "0x75F9440", VA = "0x1875FA240")]
	static OCGIBJNDKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x312CE70", Offset = "0x312C070", VA = "0x18312CE70")]
	public static OOBEEGPEMII MCDNPIFEBPP(PIFNDFKNPCM MBDBONINAPC)
	{
		return default(OOBEEGPEMII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	public static void GODFKLMBCHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DEBFFNMOKPK
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x32C71C0", Offset = "0x32C63C0", VA = "0x1832C71C0")]
	public static LCGKFAFGHII<T1, T2> CMLDJMKOGGA<T1, T2>(this (T1, T2) KEAIILCALFE) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(LCGKFAFGHII<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x32C71E0", Offset = "0x32C63E0", VA = "0x1832C71E0")]
	public static DKALJFMLBDA<T1, T2, T3> CMLDJMKOGGA<T1, T2, T3>(this (T1, T2, T3) KEAIILCALFE) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(DKALJFMLBDA<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LCGKFAFGHII<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) KEAIILCALFE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F240", Offset = "0x4B2E440", VA = "0x184B2F240")]
	public LCGKFAFGHII((T1, T2) KEAIILCALFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4B2EE30", Offset = "0x4B2E030", VA = "0x184B2EE30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DKALJFMLBDA<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) KEAIILCALFE;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F220", Offset = "0x4B2E420", VA = "0x184B2F220")]
	public DKALJFMLBDA((T1, T2, T3) KEAIILCALFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x63E1B50", Offset = "0x63E0D50", VA = "0x1863E1B50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HKBJNHHAGGM
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75F95D0", Offset = "0x75F87D0", VA = "0x1875F95D0")]
	public static Range PJPBMJFGMAL(this AIKFLEGLMCF GFOLFGHIKIM)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AAFKIBILGDE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct OHILJGKMMKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int HOMHJOFIEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int ANMKOMFFHBH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75FA2B0", Offset = "0x75F94B0", VA = "0x1875FA2B0")]
		public OHILJGKMMKL(int MGKDKECOLOJ, int ANMKOMFFHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x75FA2A0", Offset = "0x75F94A0", VA = "0x1875FA2A0")]
		public bool NFFHEIPLBGA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x75F8A50", Offset = "0x75F7C50", VA = "0x1875F8A50")]
	public static OHILJGKMMKL PACLDABBHPO(this Range GFOLFGHIKIM)
	{
		return default(OHILJGKMMKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AGFEANBACOC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle PBLKLOBKEHJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JHNGPLIKGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4656C50", Offset = "0x4655E50", VA = "0x184656C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4656680", Offset = "0x4655880", VA = "0x184656680")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4656800", Offset = "0x4655A00", VA = "0x184656800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4656DC0", Offset = "0x4655FC0", VA = "0x184656DC0")]
	public AGFEANBACOC(T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x46567D0", Offset = "0x46559D0", VA = "0x1846567D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class CPHCCEMMPHG<THandle, TValue> : IDisposable where THandle : struct, FGEPICOCPFA where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> OPEHJJPEJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> ALKPNNHBNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> AIMKIBGOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> CCMBHHBAMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int MBCMBLHPCMN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE110", Offset = "0x5DCD310", VA = "0x185DCE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE9D0", Offset = "0x5DCDBD0", VA = "0x185DCE9D0")]
	public CPHCCEMMPHG(Action<TValue> CCMBHHBAMGA, [Optional] Func<TValue> AIMKIBGOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDEB0", Offset = "0x5DCD0B0", VA = "0x185DCDEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE800", Offset = "0x5DCDA00", VA = "0x185DCE800")]
	public THandle OFEFHMDJLMD(TValue OMFJNFBDJCA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDFE0", Offset = "0x5DCD1E0", VA = "0x185DCDFE0")]
	public bool FFMIMIFACMK(THandle PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE6E0", Offset = "0x5DCD8E0", VA = "0x185DCE6E0")]
	public bool NHGJGBKEDKC(THandle PBLKLOBKEHJ, [Out] TValue OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE7B0", Offset = "0x5DCD9B0", VA = "0x185DCE7B0")]
	public TValue NKAAMPBENGI(THandle PBLKLOBKEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDD50", Offset = "0x5DCCF50", VA = "0x185DCDD50")]
	public bool DFFCJNIAGEE(THandle PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDF80", Offset = "0x5DCD180", VA = "0x185DCDF80")]
	private THandle FEKLHGINGEC(int KOOLKCPAFBB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDCF0", Offset = "0x5DCCEF0", VA = "0x185DCDCF0")]
	private TValue AOLELDFNFOC(int KOOLKCPAFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDE60", Offset = "0x5DCD060", VA = "0x185DCDE60")]
	private void DKPNGGPFCJG(int KOOLKCPAFBB, [In] THandle PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE690", Offset = "0x5DCD890", VA = "0x185DCE690")]
	private void KOOFDNPAJKG(int KOOLKCPAFBB, [In] TValue OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE4F0", Offset = "0x5DCD6F0", VA = "0x185DCE4F0")]
	private THandle KBMDGJHKEMG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE150", Offset = "0x5DCD350", VA = "0x185DCE150")]
	private void FNILPPILLAA(THandle PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE270", Offset = "0x5DCD470", VA = "0x185DCE270")]
	private int GOPCAEFOJDP(int LCLBPLEFKON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE260", Offset = "0x5DCD460", VA = "0x185DCE260")]
	private bool GMJKGFEKCDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x96E8A0", Offset = "0x96DAA0", VA = "0x18096E8A0")]
	private void FBGBFPAFNLN(THandle PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE440", Offset = "0x5DCD640", VA = "0x185DCE440")]
	private bool IJLCKLEPHGP([Out] THandle PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE8A0", Offset = "0x5DCDAA0", VA = "0x185DCE8A0")]
	private bool PCNCFNIPKMH([Out] THandle PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE280", Offset = "0x5DCD480", VA = "0x185DCE280")]
	private void IALDNKLBCMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FGEPICOCPFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int PGEMEJBADFN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int DAIODIGKFHG
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
public static class APKGNCKDMBE
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8070", Offset = "0x3BD7270", VA = "0x183BD8070")]
	public static bool OGNAFKMJGJC<T>(this T PBLKLOBKEHJ, T LDKNLBHIGFL) where T : struct, FGEPICOCPFA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8060", Offset = "0x3BD7260", VA = "0x183BD8060")]
	public static bool IEIFJCLJNMH<T>(this T PBLKLOBKEHJ) where T : struct, FGEPICOCPFA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x75F8D60", Offset = "0x75F7F60", VA = "0x1875F8D60")]
	public static string CHJAAOGJEEN(this FGEPICOCPFA PBLKLOBKEHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public ref struct AIPPNDPMCFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type EFODIFPFOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> CKNBDBFOJOC;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4B14C30", Offset = "0x4B13E30", VA = "0x184B14C30")]
	public AIPPNDPMCFL(Type JABJHLHDMOD, Span<byte> HKNNPOLHEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3BD10A0", Offset = "0x3BD02A0", VA = "0x183BD10A0")]
	public static AIPPNDPMCFL DALNKPHMLDL<T>(T OMFJNFBDJCA) where T : struct
	{
		return default(AIPPNDPMCFL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x75F8C50", Offset = "0x75F7E50", VA = "0x1875F8C50")]
	public static PHBPGJEJBAB AJAOLMPMCKD([In] AIPPNDPMCFL LIBECIMLPKK)
	{
		return default(PHBPGJEJBAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x75F8CE0", Offset = "0x75F7EE0", VA = "0x1875F8CE0")]
	public Enum NDBNEMKOOFG(Type GHOKLIOMHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1A30", Offset = "0x3BD0C30", VA = "0x183BD1A30")]
	public void GFIEJLHFJLN<T>([In] T OMFJNFBDJCA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x75F8CD0", Offset = "0x75F7ED0", VA = "0x1875F8CD0")]
	public void JEKNFMPCIEF(Enum PMBHGOELOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public ref struct PHBPGJEJBAB
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct MKEOHILDNKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* FBKMLNAGKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* AGBMNABOOAG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type EFODIFPFOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> CKNBDBFOJOC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AKGACOJACKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4E0", Offset = "0x75F96E0", VA = "0x1875FA4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LBHBDNMPMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75FA2C0", Offset = "0x75F94C0", VA = "0x1875FA2C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4B14C30", Offset = "0x4B13E30", VA = "0x184B14C30")]
	public PHBPGJEJBAB(Type JABJHLHDMOD, ReadOnlySpan<byte> HKNNPOLHEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3672720", Offset = "0x3671920", VA = "0x183672720")]
	public static PHBPGJEJBAB DALNKPHMLDL<T>(T OMFJNFBDJCA) where T : struct
	{
		return default(PHBPGJEJBAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x75FA4F0", Offset = "0x75F96F0", VA = "0x1875FA4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x75FA310", Offset = "0x75F9510", VA = "0x1875FA310")]
	public object DFCCDHOGIEM(int KOOLKCPAFBB = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DEJFHCJEEND
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x32C82A0", Offset = "0x32C74A0", VA = "0x1832C82A0")]
	public static NativeArray<T> DALNKPHMLDL<T>(T OMFJNFBDJCA, bool AAEKHNFFBKG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x32C8340", Offset = "0x32C7540", VA = "0x1832C8340")]
	public static NativeArray<T> PEGEPOGGAJC<T>(T OMFJNFBDJCA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x32C82F0", Offset = "0x32C74F0", VA = "0x1832C82F0")]
	public static NativeArray<T> FBIFPMHJMPG<T>(T OMFJNFBDJCA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75F9270", Offset = "0x75F8470", VA = "0x1875F9270")]
	public static NativeArray<byte> FBIFPMHJMPG(ReadOnlySpan<byte> OMFJNFBDJCA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x75F9140", Offset = "0x75F8340", VA = "0x1875F9140")]
	public static NativeArray<byte> DALNKPHMLDL(ReadOnlySpan<byte> OMFJNFBDJCA, bool AAEKHNFFBKG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x75F91F0", Offset = "0x75F83F0", VA = "0x1875F91F0")]
	public unsafe static NativeArray<byte> DALNKPHMLDL(byte* HDGBMIBHCDB, int EEBDBIBAAFF, bool AAEKHNFFBKG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x32C8230", Offset = "0x32C7430", VA = "0x1832C8230")]
	public static NativeArray<T> CENLOHBLGNG<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LEBOMFBJJKI<Handle> where Handle : FGEPICOCPFA, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct KHNCIMDEIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly LEBOMFBJJKI<Handle> OAOKGDDADJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int KOOLKCPAFBB;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Handle EJEJKKIMPFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x4A83C50", Offset = "0x4A82E50", VA = "0x184A83C50")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4A842C0", Offset = "0x4A834C0", VA = "0x184A842C0")]
		public KHNCIMDEIEJ(LEBOMFBJJKI<Handle> OAOKGDDADJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4A84230", Offset = "0x4A83430", VA = "0x184A84230")]
		public JFAMJEJNEGK PEFMILKIAFF([In] JFAMJEJNEGK JEBOOCGPANP)
		{
			return default(JFAMJEJNEGK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4A83FF0", Offset = "0x4A831F0", VA = "0x184A83FF0")]
		public bool NFFHEIPLBGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A83F90", Offset = "0x4A83190", VA = "0x184A83F90")]
		private Handle KHOKPLJMLCA(string DCEACFEGBDC)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct JFAMJEJNEGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private KHNCIMDEIEJ FNHNFFKIJIF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4977CA0", Offset = "0x4976EA0", VA = "0x184977CA0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4977D20", Offset = "0x4976F20", VA = "0x184977D20")]
		public JFAMJEJNEGK(LEBOMFBJJKI<Handle> OAOKGDDADJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4977BF0", Offset = "0x4976DF0", VA = "0x184977BF0")]
		public bool NFFHEIPLBGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4977C30", Offset = "0x4976E30", VA = "0x184977C30")]
		public JFAMJEJNEGK PACLDABBHPO()
		{
			return default(JFAMJEJNEGK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeList<int> OCOCGBNEGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<int> FHAJBIAFJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ILCAGJDEEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int ENLJMOPJPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool PLHHJLDDLIO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AABBHHFGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4B376F0", Offset = "0x4B368F0", VA = "0x184B376F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JFAMJEJNEGK HNHKFEFPLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4B377D0", Offset = "0x4B369D0", VA = "0x184B377D0")]
		get
		{
			return default(JFAMJEJNEGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4B38CD0", Offset = "0x4B37ED0", VA = "0x184B38CD0")]
	public LEBOMFBJJKI(int NNCKPODCGGK, Allocator JNKCCGKBKPB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4B37AD0", Offset = "0x4B36CD0", VA = "0x184B37AD0")]
	public void GNPGDFFJFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F27930", Offset = "0x1F26B30", VA = "0x181F27930")]
	public static int GOPCAEFOJDP(int OKAELCMAFHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2C0B2C0", Offset = "0x2C0A4C0", VA = "0x182C0B2C0")]
	public static bool KCEEALBGMAL(int OKAELCMAFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4B37FC0", Offset = "0x4B371C0", VA = "0x184B37FC0")]
	public bool LJFKDKHCPHB(int KOOLKCPAFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4B388B0", Offset = "0x4B37AB0", VA = "0x184B388B0")]
	public bool NMPCJBJFNGO(Handle PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4B37230", Offset = "0x4B36430", VA = "0x184B37230")]
	public Handle CAOMPJLNCGB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4B38420", Offset = "0x4B37620", VA = "0x184B38420")]
	public void NHMGKLMBMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4B37E20", Offset = "0x4B37020", VA = "0x184B37E20")]
	public void LDHCIPNCFNL(Handle PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xCE51A0", Offset = "0xCE43A0", VA = "0x180CE51A0")]
	private bool ICIMJDHOOOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B37BF0", Offset = "0x4B36DF0", VA = "0x184B37BF0")]
	private bool HGNNIDCFLML(int KOOLKCPAFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B373D0", Offset = "0x4B365D0", VA = "0x184B373D0")]
	private void COAPCDBMDCF([Out] int KOOLKCPAFBB, [Out] int LCLBPLEFKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B38A20", Offset = "0x4B37C20", VA = "0x184B38A20")]
	private void OMANLKOHPHM(Handle PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4B37780", Offset = "0x4B36980", VA = "0x184B37780")]
	private void EEFJNOCAILB(int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4B37C50", Offset = "0x4B36E50", VA = "0x184B37C50")]
	private bool HOHDCKNBEEA([Out] int KOOLKCPAFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4B37860", Offset = "0x4B36A60", VA = "0x184B37860")]
	private static Handle GKGJHJOILAH(int KOOLKCPAFBB, int LCLBPLEFKON)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public struct EPBMNOKABIC<Handle, T> where Handle : FGEPICOCPFA, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LEBOMFBJJKI<Handle> AAMLGIPHPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] MDLDMEENBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Action<T> HGBKHPMHMHI;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x41248B0", Offset = "0x4123AB0", VA = "0x1841248B0")]
	public EPBMNOKABIC(int NNCKPODCGGK, [Optional] Action<T> HGBKHPMHMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4123BE0", Offset = "0x4122DE0", VA = "0x184123BE0")]
	public void GNPGDFFJFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4124210", Offset = "0x4123410", VA = "0x184124210")]
	public bool NHGJGBKEDKC(Handle PBLKLOBKEHJ, [Out] T ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x41242C0", Offset = "0x41234C0", VA = "0x1841242C0")]
	public Handle OFEFHMDJLMD(T ONELFPFEALD)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4123CE0", Offset = "0x4122EE0", VA = "0x184123CE0")]
	public void LHOIHOHKAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4124540", Offset = "0x4123740", VA = "0x184124540")]
	public void OGPGHNCGHLC(Handle PBLKLOBKEHJ, [Out] T CPBCDDFCNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4124620", Offset = "0x4123820", VA = "0x184124620")]
	public void OGPGHNCGHLC(Handle PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x41244E0", Offset = "0x41236E0", VA = "0x1841244E0")]
	private T OFIGKBFCILK(int KOOLKCPAFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4123B20", Offset = "0x4122D20", VA = "0x184123B20")]
	private void DEMOBBOFCGO(int OBMJMKDGOHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public struct AIPBCFHHAOO<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct MDIOHGGKHBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private AIPBCFHHAOO<T> LGLFHJLCKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int KOOLKCPAFBB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4D94790", Offset = "0x4D93990", VA = "0x184D94790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x25E0D40", Offset = "0x25DFF40", VA = "0x1825E0D40")]
		public MDIOHGGKHBB(AIPBCFHHAOO<T> LGLFHJLCKKH, int KOOLKCPAFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4D94740", Offset = "0x4D93940", VA = "0x184D94740")]
		public bool NFFHEIPLBGA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DCCBNPNGGGO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AIPBCFHHAOO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public DCCBNPNGGGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x63789B0", Offset = "0x6377BB0", VA = "0x1863789B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6378A50", Offset = "0x6377C50", VA = "0x186378A50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DNEEEAJBJHC : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AIPBCFHHAOO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public DNEEEAJBJHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x63EA8C0", Offset = "0x63E9AC0", VA = "0x1863EA8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x63EA960", Offset = "0x63E9B60", VA = "0x1863EA960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private object[] LJELDKAOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private uint OMFJNFBDJCA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x46629F0", Offset = "0x4661BF0", VA = "0x1846629F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KHBFGBFEAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4662850", Offset = "0x4661A50", VA = "0x184662850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NLGAJPMMPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x157BCB0", Offset = "0x157AEB0", VA = "0x18157BCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal bool JFDIIJMAHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4662960", Offset = "0x4661B60", VA = "0x184662960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public HHHEOGCAMKO<T> CKNBDBFOJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4662430", Offset = "0x4661630", VA = "0x184662430")]
		get
		{
			return default(HHHEOGCAMKO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4662630", Offset = "0x4661830", VA = "0x184662630")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4662300", Offset = "0x4661500", VA = "0x184662300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4662F10", Offset = "0x4662110", VA = "0x184662F10")]
	internal AIPBCFHHAOO(AIPBCFHHAOO<T> LGLFHJLCKKH, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4662E80", Offset = "0x4662080", VA = "0x184662E80")]
	private AIPBCFHHAOO(T[] LGLFHJLCKKH, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4662F30", Offset = "0x4662130", VA = "0x184662F30")]
	public AIPBCFHHAOO(IEnumerable<T> ALKPNNHBNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4662EA0", Offset = "0x46620A0", VA = "0x184662EA0")]
	public AIPBCFHHAOO(int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46623B0", Offset = "0x46615B0", VA = "0x1846623B0")]
	public int ANDIFPOIJPH(T OMFJNFBDJCA, int MGKDKECOLOJ, int IPBKHOJKHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4662220", Offset = "0x4661420", VA = "0x184662220")]
	public void ADEJKABMGPN(int OOMCEAFDIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4662A00", Offset = "0x4661C00", VA = "0x184662A00")]
	private void OJABOBMGLDH(int OOMCEAFDIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4662880", Offset = "0x4661A80", VA = "0x184662880")]
	public T[] ILCCOBLOHML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4662700", Offset = "0x4661900", VA = "0x184662700")]
	public T[] GAFBHFGGNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x46625B0", Offset = "0x46617B0", VA = "0x1846625B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4662BD0", Offset = "0x4661DD0", VA = "0x184662BD0")]
	public void ONBIFNNEIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4662C30", Offset = "0x4661E30", VA = "0x184662C30")]
	public MDIOHGGKHBB PACLDABBHPO()
	{
		return default(MDIOHGGKHBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4662CA0", Offset = "0x4661EA0", VA = "0x184662CA0", Slot = "5")]
	[IteratorStateMachine(typeof(AIPBCFHHAOO<>.DCCBNPNGGGO))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4662D90", Offset = "0x4661F90", VA = "0x184662D90", Slot = "6")]
	[IteratorStateMachine(typeof(AIPBCFHHAOO<>.DNEEEAJBJHC))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4662900", Offset = "0x4661B00", VA = "0x184662900")]
	public static AIPBCFHHAOO<T> KCINLMBEFCG(T[] LGLFHJLCKKH)
	{
		return default(AIPBCFHHAOO<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4662260", Offset = "0x4661460", VA = "0x184662260")]
	public static AIPBCFHHAOO<T> AJAOLMPMCKD(T[] LGLFHJLCKKH)
	{
		return default(AIPBCFHHAOO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4662970", Offset = "0x4661B70", VA = "0x184662970")]
	private void NBJOEBNPKCA(int KOOLKCPAFBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class HKOOMBBGJCN<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct DPMCDJBBEMN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private HKOOMBBGJCN<T> KBPAKCCMOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int KOOLKCPAFBB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x63F1A10", Offset = "0x63F0C10", VA = "0x1863F1A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x63F1A50", Offset = "0x63F0C50", VA = "0x1863F1A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4199F50", Offset = "0x4199150", VA = "0x184199F50")]
		public DPMCDJBBEMN(HKOOMBBGJCN<T> KBPAKCCMOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x63F1920", Offset = "0x63F0B20", VA = "0x1863F1920", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x63F19C0", Offset = "0x63F0BC0", VA = "0x1863F19C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private AIPBCFHHAOO<T> LJELDKAOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int EEBDBIBAAFF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x46B5540", Offset = "0x46B4740", VA = "0x1846B5540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x44C10A0", Offset = "0x44C02A0", VA = "0x1844C10A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int AABBHHFGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x46B5500", Offset = "0x46B4700", VA = "0x1846B5500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool NLGAJPMMPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x46B54E0", Offset = "0x46B46E0", VA = "0x1846B54E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public HHHEOGCAMKO<T> CKNBDBFOJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x46B5290", Offset = "0x46B4490", VA = "0x1846B5290")]
		get
		{
			return default(HHHEOGCAMKO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x46B5FE0", Offset = "0x46B51E0", VA = "0x1846B5FE0")]
	public HKOOMBBGJCN(IEnumerable<T> ALKPNNHBNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x46B5F70", Offset = "0x46B5170", VA = "0x1846B5F70")]
	public HKOOMBBGJCN(int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4585610", Offset = "0x4584810", VA = "0x184585610")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x46B5A50", Offset = "0x46B4C50", VA = "0x1846B5A50")]
	public AIPBCFHHAOO<T> JOBDBOBBBNI()
	{
		return default(AIPBCFHHAOO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x46B5B60", Offset = "0x46B4D60", VA = "0x1846B5B60")]
	public void OFEFHMDJLMD(T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x46B5110", Offset = "0x46B4310", VA = "0x1846B5110")]
	private void ADEJKABMGPN(int ECPBKIMJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x46B5620", Offset = "0x46B4820", VA = "0x1846B5620")]
	public void GHMFFPPBIMB(List<T> FKONFNGBCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x46B57A0", Offset = "0x46B49A0", VA = "0x1846B57A0")]
	public void GHMFFPPBIMB(T[] FKONFNGBCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x46B5A90", Offset = "0x46B4C90", VA = "0x1846B5A90")]
	public void LLIFKGKFHNH(int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x46B5310", Offset = "0x46B4510", VA = "0x1846B5310")]
	public void BLCOBEOCHFA(int NJPDMHJIABC, int ANMKOMFFHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x46B5210", Offset = "0x46B4410", VA = "0x1846B5210")]
	public int ANDIFPOIJPH(T OMFJNFBDJCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x46B5A00", Offset = "0x46B4C00", VA = "0x1846B5A00")]
	public bool JMGJGLJLLLB(T OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x46B55B0", Offset = "0x46B47B0", VA = "0x1846B55B0")]
	public T[] GAFBHFGGNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x46B5520", Offset = "0x46B4720", VA = "0x1846B5520", Slot = "6")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x46B5150", Offset = "0x46B4350", VA = "0x1846B5150")]
	public static AIPBCFHHAOO<T> AJAOLMPMCKD(HKOOMBBGJCN<T> KBPAKCCMOCP)
	{
		return default(AIPBCFHHAOO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x46B5840", Offset = "0x46B4A40", VA = "0x1846B5840", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x46B5EC0", Offset = "0x46B50C0", VA = "0x1846B5EC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x46B5F00", Offset = "0x46B5100", VA = "0x1846B5F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x46B58B0", Offset = "0x46B4AB0", VA = "0x1846B58B0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void HBCCJBFLLOP(int OMFJNFBDJCA, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x46B5C70", Offset = "0x46B4E70", VA = "0x1846B5C70")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void PLHMACEPLJE(int NJPDMHJIABC, int ANMKOMFFHBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HLNJFIKONMC
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x34BC4E0", Offset = "0x34BB6E0", VA = "0x1834BC4E0")]
	public static void ONBIFNNEIHA<T>(this HKOOMBBGJCN<T> KBPAKCCMOCP) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public ref struct HHHEOGCAMKO<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Span<object> LJELDKAOCJM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x46ADE10", Offset = "0x46AD010", VA = "0x1846ADE10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x46ADBE0", Offset = "0x46ACDE0", VA = "0x1846ADBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x46ADF40", Offset = "0x46AD140", VA = "0x1846ADF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public HHHEOGCAMKO(Span<object> HKNNPOLHEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x46ADC10", Offset = "0x46ACE10", VA = "0x1846ADC10")]
	public HHHEOGCAMKO<T> EEKFHCMDJDN(int MGKDKECOLOJ)
	{
		return default(HHHEOGCAMKO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x46ADCE0", Offset = "0x46ACEE0", VA = "0x1846ADCE0")]
	public HHHEOGCAMKO<T> EEKFHCMDJDN(int MGKDKECOLOJ, int EEBDBIBAAFF)
	{
		return default(HHHEOGCAMKO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x46ADEE0", Offset = "0x46AD0E0", VA = "0x1846ADEE0")]
	public void MPPBMNJFIOP(HHHEOGCAMKO<T> IFNOJEFGFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x46ADF80", Offset = "0x46AD180", VA = "0x1846ADF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x46ADDC0", Offset = "0x46ACFC0", VA = "0x1846ADDC0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x46ADE90", Offset = "0x46AD090", VA = "0x1846ADE90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct AIKFLEGLMCF : IEquatable<AIKFLEGLMCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int DCNPLBBIONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int IPBKHOJKHLJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int CAGALMNONCE
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF38E0", VA = "0x182BF46E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68B29B0", Offset = "0x68B1BB0", VA = "0x1868B29B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int DAOJBEFJGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LEJEEGJNHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x75F8BB0", Offset = "0x75F7DB0", VA = "0x1875F8BB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x75F8AA0", Offset = "0x75F7CA0", VA = "0x1875F8AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public (int begin, int end) CHHENGDIOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x75F8B50", Offset = "0x75F7D50", VA = "0x1875F8B50")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xC25680", Offset = "0xC24880", VA = "0x180C25680")]
	private AIKFLEGLMCF(int DCNPLBBIONO, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x25D6760", Offset = "0x25D5960", VA = "0x1825D6760")]
	public static AIKFLEGLMCF HAFEIGGDOHA(int DCNPLBBIONO, int IPBKHOJKHLJ)
	{
		return default(AIKFLEGLMCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x75F8B40", Offset = "0x75F7D40", VA = "0x1875F8B40")]
	public static AIKFLEGLMCF JMDJHEMLIPL(int MGKDKECOLOJ, int ANMKOMFFHBH)
	{
		return default(AIKFLEGLMCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x75F8BC0", Offset = "0x75F7DC0", VA = "0x1875F8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x16EEFA0", Offset = "0x16EE1A0", VA = "0x1816EEFA0", Slot = "4")]
	public bool Equals(AIKFLEGLMCF LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x75F8AB0", Offset = "0x75F7CB0", VA = "0x1875F8AB0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A125D0", Offset = "0x6A117D0", VA = "0x186A125D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct OPEMBFAIGPH<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NativeArray<T> LJELDKAOCJM;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
	public OPEMBFAIGPH(NativeArray<T> LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x501EAF0", Offset = "0x501DCF0", VA = "0x18501EAF0", Slot = "6")]
	public int Compare(int NNDJDIFFAID, int AMFIBFNKFFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x501EBE0", Offset = "0x501DDE0", VA = "0x18501EBE0", Slot = "4")]
	public bool Equals(int NNDJDIFFAID, int AMFIBFNKFFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x501ECD0", Offset = "0x501DED0", VA = "0x18501ECD0", Slot = "5")]
	public int GetHashCode(int NNDJDIFFAID)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NJEEBMHCBAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3610C10", Offset = "0x360FE10", VA = "0x183610C10")]
	public static T[] KMPGJPMDBKC<T>(List<T> KBPAKCCMOCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct LEDMHMJFLMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* POBDHHHODGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal AllocatorManager.AllocatorHandle FLFNAMLHCMC;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x553BF30", Offset = "0x553B130", VA = "0x18553BF30")]
	public void GNPGDFFJFNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KKPGCMDFGAA
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x352C680", Offset = "0x352B880", VA = "0x18352C680")]
	public static LEDMHMJFLMK IPBLKHIPGOG<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> INMHGMBPIOL) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(LEDMHMJFLMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x352C680", Offset = "0x352B880", VA = "0x18352C680")]
	public static UnsafeParallelHashMap<TKey, TValue> LFMGGNKPLKI<TKey, TValue>(this LEDMHMJFLMK INMHGMBPIOL) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OOPNPFOAPIL
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3667CB0", Offset = "0x3666EB0", VA = "0x183667CB0")]
	public static int EIJGCEAPNOI<T>(ReadOnlySpan<T> IEJGBMNBNPN, ReadOnlySpan<T> PNOOLNCAFFL, int EEBDBIBAAFF) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IHMIDOFDHOE
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x34D3BE0", Offset = "0x34D2DE0", VA = "0x1834D3BE0")]
	public static T PFEJMKEAOBH<T>(this NativeArray<byte> HDPIMFNJLMN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x34D37C0", Offset = "0x34D29C0", VA = "0x1834D37C0")]
	public static NativeArray<T> PCKCPBHKMOH<T>(this NativeArray<byte> HDPIMFNJLMN, int IPBKHOJKHLJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x34D35D0", Offset = "0x34D27D0", VA = "0x1834D35D0")]
	public static void BKDLAHCGGNN<T>(this NativeList<byte> NHGKIMEFJKJ, [In] T OMFJNFBDJCA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x34D3530", Offset = "0x34D2730", VA = "0x1834D3530")]
	public static void BKDLAHCGGNN<T>(this NativeList<byte> NHGKIMEFJKJ, NativeArray<T> OMFJNFBDJCA) where T : struct
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

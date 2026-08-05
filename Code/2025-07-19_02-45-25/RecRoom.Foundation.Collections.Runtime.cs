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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x816D770", Offset = "0x816C770", VA = "0x18816D770", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[FEFLOOEJFLF]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF630", Offset = "0x3DFE630", VA = "0x183DFF630")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[FEFLOOEJFLF]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E008A0", Offset = "0x3DFF8A0", VA = "0x183E008A0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF830", Offset = "0x3DFE830", VA = "0x183DFF830")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF990", Offset = "0x3DFE990", VA = "0x183DFF990")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3E09590", Offset = "0x3E08590", VA = "0x183E09590")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E09320", Offset = "0x3E08320", VA = "0x183E09320")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E09490", Offset = "0x3E08490", VA = "0x183E09490")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E09C50", Offset = "0x3E08C50", VA = "0x183E09C50")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E010A0", Offset = "0x3E000A0", VA = "0x183E010A0")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E01030", Offset = "0x3E00030", VA = "0x183E01030")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E01590", Offset = "0x3E00590", VA = "0x183E01590")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, LKKNDHJDELB range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E01550", Offset = "0x3E00550", VA = "0x183E01550")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3E013D0", Offset = "0x3E003D0", VA = "0x183E013D0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF680", Offset = "0x3DFE680", VA = "0x183DFF680")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3E093D0", Offset = "0x3E083D0", VA = "0x183E093D0")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[FEFLOOEJFLF]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3E09D20", Offset = "0x3E08D20", VA = "0x183E09D20")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B9B0", Offset = "0x3E0A9B0", VA = "0x183E0B9B0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B9C0", Offset = "0x3E0A9C0", VA = "0x183E0B9C0")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x490B420", Offset = "0x490A420", VA = "0x18490B420")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x816DDE0", Offset = "0x816CDE0", VA = "0x18816DDE0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x816DE10", Offset = "0x816CE10", VA = "0x18816DE10")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AE90", Offset = "0x3E09E90", VA = "0x183E0AE90")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AEC0", Offset = "0x3E09EC0", VA = "0x183E0AEC0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B190", Offset = "0x3E0A190", VA = "0x183E0B190")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AE40", Offset = "0x3E09E40", VA = "0x183E0AE40")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E0ADF0", Offset = "0x3E09DF0", VA = "0x183E0ADF0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B010", Offset = "0x3E0A010", VA = "0x183E0B010")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B3E0", Offset = "0x3E0A3E0", VA = "0x183E0B3E0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B240", Offset = "0x3E0A240", VA = "0x183E0B240")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AF10", Offset = "0x3E09F10", VA = "0x183E0AF10")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AD90", Offset = "0x3E09D90", VA = "0x183E0AD90")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AD70", Offset = "0x3E09D70", VA = "0x183E0AD70")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BDE0", Offset = "0x3E0ADE0", VA = "0x183E0BDE0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BA10", Offset = "0x3E0AA10", VA = "0x183E0BA10")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BE10", Offset = "0x3E0AE10", VA = "0x183E0BE10")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BEC0", Offset = "0x3E0AEC0", VA = "0x183E0BEC0")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[FEFLOOEJFLF]
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
			[Cpp2IlInjected.Address(RVA = "0x4F27B20", Offset = "0x4F26B20", VA = "0x184F27B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xEE6980", Offset = "0xEE5980", VA = "0x180EE6980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5443E50", Offset = "0x5442E50", VA = "0x185443E50")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x57A1A10", Offset = "0x57A0A10", VA = "0x1857A1A10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x57A1930", Offset = "0x57A0930", VA = "0x1857A1930")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x42C6A50", Offset = "0x42C5A50", VA = "0x1842C6A50")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[FEFLOOEJFLF]
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
			[Cpp2IlInjected.Address(RVA = "0x57F9680", Offset = "0x57F8680", VA = "0x1857F9680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x57F96C0", Offset = "0x57F86C0", VA = "0x1857F96C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5443E50", Offset = "0x5442E50", VA = "0x185443E50")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x57F92E0", Offset = "0x57F82E0", VA = "0x1857F92E0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x57F9420", Offset = "0x57F8420", VA = "0x1857F9420")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x57F95E0", Offset = "0x57F85E0", VA = "0x1857F95E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x57F9460", Offset = "0x57F8460", VA = "0x1857F9460")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[FEFLOOEJFLF]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[FEFLOOEJFLF]
public static class MILGCGAFDNC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x816D9F0", Offset = "0x816C9F0", VA = "0x18816D9F0")]
	public static JobHandle GELMOKPLAHK(this JobHandle JDINPJIAKOC, JobHandle LDPKBPICKKH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x816DA30", Offset = "0x816CA30", VA = "0x18816DA30")]
	public static JobHandle KCJOAAEJNCJ(this Span<JobHandle> KNFPKIKAMOM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LHFDPPHCCDJ
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38E7950", Offset = "0x38E6950", VA = "0x1838E7950")]
	public static void JPJFAMEFLHG<T>(this T[] MFIJBPNIELL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LBAFCIKFGHA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3D4DB40", Offset = "0x3D4CB40", VA = "0x183D4DB40")]
	public static NativeKeyValueArrays<TKey, TValue> HHHNDKOLGJA<TKey, TValue>(this Dictionary<TKey, TValue> PBIFPLDBICK, Allocator FKPBEKMFPLB) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PNPEDCBPIEN
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x816DFE0", Offset = "0x816CFE0", VA = "0x18816DFE0")]
	public static void PLIGGFBLDAL(this GameObject GLGAAAMILBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x816DF40", Offset = "0x816CF40", VA = "0x18816DF40")]
	public static void PLIGGFBLDAL(this Component LDEFIHHDIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x816DEA0", Offset = "0x816CEA0", VA = "0x18816DEA0")]
	public static void PLIGGFBLDAL(this ScriptableObject FGICKCMBEMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FCPKPECHHEC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x816CE50", Offset = "0x816BE50", VA = "0x18816CE50")]
	public static void ADIOIPAEJCH(this NativeList<byte> KKAPDLIJLLM, ReadOnlySpan<byte> AFIGADGOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C309C0", Offset = "0x3C2F9C0", VA = "0x183C309C0")]
	public static void EOJJEPAHMGG<T>(this NativeList<T> KKAPDLIJLLM, T IOALKPFEKEK, int MFFPIAPMHCN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AHOJFCHOADI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x319EE50", Offset = "0x319DE50", VA = "0x18319EE50")]
	public static T MAJMELDHFPI<T>(this ReadOnlySpan<byte> IOALKPFEKEK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x319E7B0", Offset = "0x319D7B0", VA = "0x18319E7B0")]
	public static T DOJLMPFPGJL<T>(this Span<T> AFIGADGOLFA, Func<T, bool> HCLFHIGJCBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x319E8D0", Offset = "0x319D8D0", VA = "0x18319E8D0")]
	public static bool KPKKJEMJAFH<T>(this Span<T> AFIGADGOLFA, Func<T, bool> HCLFHIGJCBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x319E960", Offset = "0x319D960", VA = "0x18319E960")]
	public static bool LILKJIGGIHI<T>(this Span<T> AFIGADGOLFA, Func<T, bool> HCLFHIGJCBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x319E9F0", Offset = "0x319D9F0", VA = "0x18319E9F0")]
	public static T LMKONLJOAEP<T>([In] this ReadOnlySpan<byte> AFIGADGOLFA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x319E770", Offset = "0x319D770", VA = "0x18319E770")]
	public static Span<TTo> BLJMCOPGOPK<TTo, TFrom>(this Span<TFrom> AFIGADGOLFA) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x319E770", Offset = "0x319D770", VA = "0x18319E770")]
	public static ReadOnlySpan<TTo> BLJMCOPGOPK<TTo, TFrom>(this ReadOnlySpan<TFrom> AFIGADGOLFA) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x319E770", Offset = "0x319D770", VA = "0x18319E770")]
	public static ReadOnlySpan<TTo> BLJMCOPGOPK<TTo>(this ReadOnlySpan<byte> AFIGADGOLFA) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x319E680", Offset = "0x319D680", VA = "0x18319E680")]
	public static Span<T> AABAGJPEDHJ<T>(this ReadOnlySpan<T> BKFMBMLFOLE) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x319F090", Offset = "0x319E090", VA = "0x18319F090")]
	public static Span<byte> ODADMGGOEJG<T>([In] this Span<byte> AFIGADGOLFA, T IOALKPFEKEK) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x816BCA0", Offset = "0x816ACA0", VA = "0x18816BCA0")]
	private static Enum EAJMEDNEONM([In] ReadOnlySpan<byte> AFIGADGOLFA, Type NJDEACBHLAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x816C240", Offset = "0x816B240", VA = "0x18816C240")]
	public static Enum HALKNJDFEHK([In] this Span<byte> AFIGADGOLFA, Type NJDEACBHLAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x816C2B0", Offset = "0x816B2B0", VA = "0x18816C2B0")]
	public static void HPAEEFFCELP([In] this Span<byte> AFIGADGOLFA, Enum EINBKGFECKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JGHFOHLMLIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EOAHAPBHJPO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x816CC40", Offset = "0x816BC40", VA = "0x18816CC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x816D4A0", Offset = "0x816C4A0", VA = "0x18816D4A0")]
	[AsyncStateMachine(typeof(EOAHAPBHJPO))]
	public static void KKLHDPDKMPB(this Task HBPDACJCCKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OHDLFKNADIE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3E267D0", Offset = "0x3E257D0", VA = "0x183E267D0")]
	public static NativeArray<T> AFKEGLPECOE<T>(this UnsafeList<T> KKAPDLIJLLM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E26820", Offset = "0x3E25820", VA = "0x183E26820")]
	public static NativeArray<T> FGLICLEPHMO<T>(this UnsafeList<T> KKAPDLIJLLM, bool GCOHKCLGAHL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E26720", Offset = "0x3E25720", VA = "0x183E26720")]
	public static UnsafeList<T> AABAGJPEDHJ<T>(this UnsafeList<T> KKAPDLIJLLM, Allocator FKPBEKMFPLB) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EPFJGMIFHHK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum PCDBGOILBBL : short
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
	public struct AEDOBOMPHIA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly PCDBGOILBBL DAKIIEIEKNI;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x312CE10", Offset = "0x312BE10", VA = "0x18312CE10")]
		public AEDOBOMPHIA(PCDBGOILBBL DAKIIEIEKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory AJJONCKACFM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	public static void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x816CDC0", Offset = "0x816BDC0", VA = "0x18816CDC0")]
	static EPFJGMIFHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38EE240", Offset = "0x38ED240", VA = "0x1838EE240")]
	public static AEDOBOMPHIA PFDOLJJBPLF(PCDBGOILBBL DAKIIEIEKNI)
	{
		return default(AEDOBOMPHIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	public static void EMANOLBEIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JGJHANLKGAI
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2C45F00", Offset = "0x2C44F00", VA = "0x182C45F00")]
	public static IJCECAKEELP<T1, T2> IDJPDHCAPMO<T1, T2>(this (T1, T2) KGHFFCFCOKP) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(IJCECAKEELP<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE80E0", Offset = "0x3CE70E0", VA = "0x183CE80E0")]
	public static FNIEHCOMCFO<T1, T2, T3> IDJPDHCAPMO<T1, T2, T3>(this (T1, T2, T3) KGHFFCFCOKP) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(FNIEHCOMCFO<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IJCECAKEELP<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) KGHFFCFCOKP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2C458A0", Offset = "0x2C448A0", VA = "0x182C458A0")]
	public IJCECAKEELP((T1, T2) KGHFFCFCOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50221A0", Offset = "0x50211A0", VA = "0x1850221A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FNIEHCOMCFO<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) KGHFFCFCOKP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4DB06A0", Offset = "0x4DAF6A0", VA = "0x184DB06A0")]
	public FNIEHCOMCFO((T1, T2, T3) KGHFFCFCOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4DB0600", Offset = "0x4DAF600", VA = "0x184DB0600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ODDLGIBJMPL
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x816DE40", Offset = "0x816CE40", VA = "0x18816DE40")]
	public static Range GLELKFGNOIL(this LKKNDHJDELB GHPPGCHDHHL)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MJOOGNKHFMH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct EPKLHCEMKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int EBMOGPINHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int KLLLDNANLEJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x816CE40", Offset = "0x816BE40", VA = "0x18816CE40")]
		public EPKLHCEMKCC(int LMLEMDDGACN, int KLLLDNANLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x816CE30", Offset = "0x816BE30", VA = "0x18816CE30")]
		public bool MJEALNFGLBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x816DAE0", Offset = "0x816CAE0", VA = "0x18816DAE0")]
	public static EPKLHCEMKCC GHDHEBFDHCI(this Range GHPPGCHDHHL)
	{
		return default(EPKLHCEMKCC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EKICHJEPNGL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle EBEJPHPLJAD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HIJCINKGIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x490B670", Offset = "0x490A670", VA = "0x18490B670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x490B5C0", Offset = "0x490A5C0", VA = "0x18490B5C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x490B860", Offset = "0x490A860", VA = "0x18490B860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x490BC30", Offset = "0x490AC30", VA = "0x18490BC30")]
	public EKICHJEPNGL(T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x490B420", Offset = "0x490A420", VA = "0x18490B420", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class JLKNCNOPDGN<THandle, TValue> : IDisposable where THandle : struct, BDFEHDIGKLJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> KNFPKIKAMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> NCIPNLHDHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> CGNBADAJKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> IHPPDHMIJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int LNECAEGEOAH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x52B0A10", Offset = "0x52AFA10", VA = "0x1852B0A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x52B1100", Offset = "0x52B0100", VA = "0x1852B1100")]
	public JLKNCNOPDGN(Action<TValue> IHPPDHMIJLD, [Optional] Func<TValue> CGNBADAJKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52B0AB0", Offset = "0x52AFAB0", VA = "0x1852B0AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x52B0A40", Offset = "0x52AFA40", VA = "0x1852B0A40")]
	public THandle DOPEKGIEJEC(TValue IOALKPFEKEK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x52B0CE0", Offset = "0x52AFCE0", VA = "0x1852B0CE0")]
	public bool GBLOHGCCHFB(THandle EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x52B0E00", Offset = "0x52AFE00", VA = "0x1852B0E00")]
	public bool HOOMFBIAHPE(THandle EBEJPHPLJAD, [Out] TValue IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x52B1060", Offset = "0x52B0060", VA = "0x1852B1060")]
	public TValue LMKONLJOAEP(THandle EBEJPHPLJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x52B0F70", Offset = "0x52AFF70", VA = "0x1852B0F70")]
	public bool KLJIOEKBNLN(THandle EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x52B0DC0", Offset = "0x52AFDC0", VA = "0x1852B0DC0")]
	private THandle HOGHLCBPLCM(int HLGKMAPOEBE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x52B10C0", Offset = "0x52B00C0", VA = "0x1852B10C0")]
	private TValue PBNFLAJHCHK(int HLGKMAPOEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x52B0CA0", Offset = "0x52AFCA0", VA = "0x1852B0CA0")]
	private void FCIGFIEFBDD(int HLGKMAPOEBE, [In] THandle EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x52B0C70", Offset = "0x52AFC70", VA = "0x1852B0C70")]
	private void EOIEFHJOFII(int HLGKMAPOEBE, [In] TValue IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x52B0770", Offset = "0x52AF770", VA = "0x1852B0770")]
	private THandle BGELENGMLDE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x52B0EB0", Offset = "0x52AFEB0", VA = "0x1852B0EB0")]
	private void KANEJMPEDLF(THandle EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x52B10B0", Offset = "0x52B00B0", VA = "0x1852B10B0")]
	private int OMGJOPNOFKN(int LMOHNMMFGMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x52B1050", Offset = "0x52B0050", VA = "0x1852B1050")]
	private bool KMEMIKPODLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA672E0", Offset = "0xA662E0", VA = "0x180A672E0")]
	private void FFLKMCAOHBM(THandle EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x52B0980", Offset = "0x52AF980", VA = "0x1852B0980")]
	private bool DAIAHIOALGG([Out] THandle EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x52B08B0", Offset = "0x52AF8B0", VA = "0x1852B08B0")]
	private bool CFBMKJPOGHD([Out] THandle EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x52B0B30", Offset = "0x52AFB30", VA = "0x1852B0B30")]
	private void EAELABDLFDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BDFEHDIGKLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MKOCHPIICKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int IPPLPEJMEJJ
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
public static class JAFDPIBMLNP
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CDEFA0", Offset = "0x3CDDFA0", VA = "0x183CDEFA0")]
	public static bool GNEOCJBHLMA<T>(this T EBEJPHPLJAD, T EDJHHGMLKFA) where T : struct, BDFEHDIGKLJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CDEFC0", Offset = "0x3CDDFC0", VA = "0x183CDEFC0")]
	public static bool KJIKLILMPOK<T>(this T EBEJPHPLJAD) where T : struct, BDFEHDIGKLJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x816D390", Offset = "0x816C390", VA = "0x18816D390")]
	public static string AMOEGIOLJEC(this BDFEHDIGKLJ EBEJPHPLJAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct FPIECMLDEPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type AGOKGDADODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> GKPFEKOJOLO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5443E40", Offset = "0x5442E40", VA = "0x185443E40")]
	public FPIECMLDEPF(Type JFCMJJOFKBN, Span<byte> AFIGADGOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C46ED0", Offset = "0x3C45ED0", VA = "0x183C46ED0")]
	public static FPIECMLDEPF PGHEBAMGCKG<T>(T IOALKPFEKEK) where T : struct
	{
		return default(FPIECMLDEPF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x816CF60", Offset = "0x816BF60", VA = "0x18816CF60")]
	public static IKOBAGMLKNP MJOOONLKLLN([In] FPIECMLDEPF AEJLPHJDEHN)
	{
		return default(IKOBAGMLKNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x816CED0", Offset = "0x816BED0", VA = "0x18816CED0")]
	public Enum HALKNJDFEHK(Type NJDEACBHLAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3C46EA0", Offset = "0x3C45EA0", VA = "0x183C46EA0")]
	public void ODADMGGOEJG<T>([In] T IOALKPFEKEK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x816CF50", Offset = "0x816BF50", VA = "0x18816CF50")]
	public void HPAEEFFCELP(Enum EINBKGFECKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct IKOBAGMLKNP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct NIALOHMMJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* PLOFEJMHNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* PNDBLCMBLNO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type AGOKGDADODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> GKPFEKOJOLO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PAFPMHAEIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x816D030", Offset = "0x816C030", VA = "0x18816D030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BKDBIAEKMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x816CFE0", Offset = "0x816BFE0", VA = "0x18816CFE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5443E40", Offset = "0x5442E40", VA = "0x185443E40")]
	public IKOBAGMLKNP(Type JFCMJJOFKBN, ReadOnlySpan<byte> AFIGADGOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAE50", Offset = "0x3CC9E50", VA = "0x183CCAE50")]
	public static IKOBAGMLKNP PGHEBAMGCKG<T>(T IOALKPFEKEK) where T : struct
	{
		return default(IKOBAGMLKNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x816D210", Offset = "0x816C210", VA = "0x18816D210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x816D040", Offset = "0x816C040", VA = "0x18816D040")]
	public object OAHEOBFBEND(int HLGKMAPOEBE = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct MDFKCBFCKLO
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BFD0", Offset = "0x3D7AFD0", VA = "0x183D7BFD0")]
	public static NativeArray<T> PGHEBAMGCKG<T>(T IOALKPFEKEK, bool GCOHKCLGAHL) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BF00", Offset = "0x3D7AF00", VA = "0x183D7BF00")]
	public static NativeArray<T> ILMAIDOLCIN<T>(T IOALKPFEKEK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BFA0", Offset = "0x3D7AFA0", VA = "0x183D7BFA0")]
	public static NativeArray<T> KKIKPAHAIDB<T>(T IOALKPFEKEK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x816D800", Offset = "0x816C800", VA = "0x18816D800")]
	public static NativeArray<byte> KKIKPAHAIDB(ReadOnlySpan<byte> IOALKPFEKEK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x816D8C0", Offset = "0x816C8C0", VA = "0x18816D8C0")]
	public static NativeArray<byte> PGHEBAMGCKG(ReadOnlySpan<byte> IOALKPFEKEK, bool GCOHKCLGAHL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x816D970", Offset = "0x816C970", VA = "0x18816D970")]
	public unsafe static NativeArray<byte> PGHEBAMGCKG(byte* MMMCPOLNOHC, int FCCMJLNEMIB, bool GCOHKCLGAHL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BF30", Offset = "0x3D7AF30", VA = "0x183D7BF30")]
	public static NativeArray<T> JBLEAIPIMOC<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct NDLKHBAKJMK : IEquatable<NDLKHBAKJMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int NKBEHDNFLEC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x816DC50", Offset = "0x816CC50", VA = "0x18816DC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x816DD40", Offset = "0x816CD40", VA = "0x18816DD40")]
	public NDLKHBAKJMK(Type BJLNCBFOGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x816DBC0", Offset = "0x816CBC0", VA = "0x18816DBC0")]
	public static NDLKHBAKJMK MJOOONLKLLN(Type BJLNCBFOGNL)
	{
		return default(NDLKHBAKJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x242CF30", Offset = "0x242BF30", VA = "0x18242CF30", Slot = "4")]
	public bool Equals(NDLKHBAKJMK EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x816DB30", Offset = "0x816CB30", VA = "0x18816DB30", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x816DD00", Offset = "0x816CD00", VA = "0x18816DD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class BLDDLOBEBCB
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> MIOOALOMEDM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> BNCJBDBOOGA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x816CAB0", Offset = "0x816BAB0", VA = "0x18816CAB0")]
	static BLDDLOBEBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x816C970", Offset = "0x816B970", VA = "0x18816C970")]
	public static bool DOPEKGIEJEC(Type BJLNCBFOGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x816C7C0", Offset = "0x816B7C0", VA = "0x18816C7C0")]
	private static bool DOPEKGIEJEC(Type BJLNCBFOGNL, [Out] int HLGKMAPOEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x816CA50", Offset = "0x816BA50", VA = "0x18816CA50")]
	public static int LOMPPLNIHPJ(Type BJLNCBFOGNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x816C9D0", Offset = "0x816B9D0", VA = "0x18816C9D0")]
	public static Type LMKONLJOAEP(int HLGKMAPOEBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PKCJBMMHIFE<Handle> where Handle : BDFEHDIGKLJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct BJIBJNHLPKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly PKCJBMMHIFE<Handle> LNCIHDIOBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int HLGKMAPOEBE;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle GLCKEACAFJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x643C6C0", Offset = "0x643B6C0", VA = "0x18643C6C0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x643CB90", Offset = "0x643BB90", VA = "0x18643CB90")]
		public BJIBJNHLPKE(PKCJBMMHIFE<Handle> LNCIHDIOBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x643CB00", Offset = "0x643BB00", VA = "0x18643CB00")]
		public GMJGODDLCOH MPFKOOIPONO([In] GMJGODDLCOH CIABMLDDFBB)
		{
			return default(GMJGODDLCOH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x643C8E0", Offset = "0x643B8E0", VA = "0x18643C8E0")]
		public bool MJEALNFGLBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x643C820", Offset = "0x643B820", VA = "0x18643C820")]
		private Handle DIHGCGMCFOC(string OBCNAJEENCI)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct GMJGODDLCOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BJIBJNHLPKE OGAIKFBMPEP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4DD0", Offset = "0x4ED3DD0", VA = "0x184ED4DD0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4F00", Offset = "0x4ED3F00", VA = "0x184ED4F00")]
		public GMJGODDLCOH(PKCJBMMHIFE<Handle> LNCIHDIOBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4EC0", Offset = "0x4ED3EC0", VA = "0x184ED4EC0")]
		public bool MJEALNFGLBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4E10", Offset = "0x4ED3E10", VA = "0x184ED4E10")]
		public GMJGODDLCOH GHDHEBFDHCI()
		{
			return default(GMJGODDLCOH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> HBDMJEBJDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> BCDLHJKFANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int IBJJJCOFGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int PIOJHCDICJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool PNBBCECDEHF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int OJEKMOODCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5A7B060", Offset = "0x5A7A060", VA = "0x185A7B060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GMJGODDLCOH FPDKJJCPANF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A7A450", Offset = "0x5A79450", VA = "0x185A7A450")]
		get
		{
			return default(GMJGODDLCOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5A7B250", Offset = "0x5A7A250", VA = "0x185A7B250")]
	public PKCJBMMHIFE(int NHNOMPICMAD, Allocator FKPBEKMFPLB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A7AEA0", Offset = "0x5A79EA0", VA = "0x185A7AEA0")]
	public void NIIIKCLLCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x24B4730", Offset = "0x24B3730", VA = "0x1824B4730")]
	public static int OMGJOPNOFKN(int LJALOPCLDCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x31363A0", Offset = "0x31353A0", VA = "0x1831363A0")]
	public static bool FCAJJHOAIPO(int LJALOPCLDCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5A7AC80", Offset = "0x5A79C80", VA = "0x185A7AC80")]
	public bool LKPKJOIFMNN(int HLGKMAPOEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5A79940", Offset = "0x5A78940", VA = "0x185A79940")]
	public bool BIIMJHHNNPD(Handle EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A230", Offset = "0x5A79230", VA = "0x185A7A230")]
	public Handle CJMPFJJMODH()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5A79C10", Offset = "0x5A78C10", VA = "0x185A79C10")]
	public void CGCNOLELLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5A7B0A0", Offset = "0x5A7A0A0", VA = "0x185A7B0A0")]
	public void PKJFMHMLPPG(Handle EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0")]
	private bool GNLJBMDFOAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A800", Offset = "0x5A79800", VA = "0x185A7A800")]
	private bool FHGLOKNAAOM(int HLGKMAPOEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A4E0", Offset = "0x5A794E0", VA = "0x185A7A4E0")]
	private void EHGKGHHLAKF([Out] int HLGKMAPOEBE, [Out] int LMOHNMMFGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A9B0", Offset = "0x5A799B0", VA = "0x185A7A9B0")]
	private void IBPPIHPJNIM(Handle EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A3B0", Offset = "0x5A793B0", VA = "0x185A7A3B0")]
	private void CMJLAPEFADJ(int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5A79890", Offset = "0x5A78890", VA = "0x185A79890")]
	private bool AIIMHACKCOK([Out] int HLGKMAPOEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5A7AAF0", Offset = "0x5A79AF0", VA = "0x185A7AAF0")]
	private static Handle KCGPCIMAGPN(int HLGKMAPOEBE, int LMOHNMMFGMP)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct HGLMLEOGACH<Handle, T> where Handle : BDFEHDIGKLJ, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PKCJBMMHIFE<Handle> CJLHEIOMJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] KMGEDJEAOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> KMIOHKFDJPD;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F41560", Offset = "0x4F40560", VA = "0x184F41560")]
	public HGLMLEOGACH(int NHNOMPICMAD, [Optional] Action<T> KMIOHKFDJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F414E0", Offset = "0x4F404E0", VA = "0x184F414E0")]
	public void NIIIKCLLCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F40EC0", Offset = "0x4F3FEC0", VA = "0x184F40EC0")]
	public bool HOOMFBIAHPE(Handle EBEJPHPLJAD, [Out] T PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F40860", Offset = "0x4F3F860", VA = "0x184F40860")]
	public Handle DOPEKGIEJEC(T PGIOEBKALDP)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F40CA0", Offset = "0x4F3FCA0", VA = "0x184F40CA0")]
	public void HECLJDIOLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F41380", Offset = "0x4F40380", VA = "0x184F41380")]
	public void LKIPLGLLFFP(Handle EBEJPHPLJAD, [Out] T JJFDBHOACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F410F0", Offset = "0x4F400F0", VA = "0x184F410F0")]
	public void LKIPLGLLFFP(Handle EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F40800", Offset = "0x4F3F800", VA = "0x184F40800")]
	private T CKPCCNNFBHK(int HLGKMAPOEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F41040", Offset = "0x4F40040", VA = "0x184F41040")]
	private void LHKKJKNLHBG(int NKNLIELFIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct FHHKDIEHOCM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct DCFBIGKJEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private FHHKDIEHOCM<T> MFIJBPNIELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int HLGKMAPOEBE;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6E7DF60", Offset = "0x6E7CF60", VA = "0x186E7DF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A60660", Offset = "0x2A5F660", VA = "0x182A60660")]
		public DCFBIGKJEPP(FHHKDIEHOCM<T> MFIJBPNIELL, int HLGKMAPOEBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E7DFB0", Offset = "0x6E7CFB0", VA = "0x186E7DFB0")]
		public bool MJEALNFGLBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ACALOCBBKPI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FHHKDIEHOCM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public ACALOCBBKPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x50C86A0", Offset = "0x50C76A0", VA = "0x1850C86A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x50C8740", Offset = "0x50C7740", VA = "0x1850C8740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OOBMKNLCLCF : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FHHKDIEHOCM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public OOBMKNLCLCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x595AB70", Offset = "0x5959B70", VA = "0x18595AB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x595AC10", Offset = "0x5959C10", VA = "0x18595AC10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] INCJDDLACNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint IOALKPFEKEK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E030", Offset = "0x4D8D030", VA = "0x184D8E030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BMKKEHNACIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DC00", Offset = "0x4D8CC00", VA = "0x184D8DC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OJMOGCONOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x199CC70", Offset = "0x199BC70", VA = "0x18199CC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool EHHJEDPDIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E040", Offset = "0x4D8D040", VA = "0x184D8E040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public OBNIEHMAELE<T> GKPFEKOJOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E050", Offset = "0x4D8D050", VA = "0x184D8E050")]
		get
		{
			return default(OBNIEHMAELE<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DCF0", Offset = "0x4D8CCF0", VA = "0x184D8DCF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E430", Offset = "0x4D8D430", VA = "0x184D8E430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D8EBD0", Offset = "0x4D8DBD0", VA = "0x184D8EBD0")]
	internal FHHKDIEHOCM(FHHKDIEHOCM<T> MFIJBPNIELL, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D8EB40", Offset = "0x4D8DB40", VA = "0x184D8EB40")]
	private FHHKDIEHOCM(T[] MFIJBPNIELL, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E830", Offset = "0x4D8D830", VA = "0x184D8E830")]
	public FHHKDIEHOCM(IEnumerable<T> NCIPNLHDHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D8EB60", Offset = "0x4D8DB60", VA = "0x184D8EB60")]
	public FHHKDIEHOCM(int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DE40", Offset = "0x4D8CE40", VA = "0x184D8DE40")]
	public int EEGEMFPJFIH(T IOALKPFEKEK, int LMLEMDDGACN, int MFFPIAPMHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E4E0", Offset = "0x4D8D4E0", VA = "0x184D8E4E0")]
	public void OAMHCLAEGFH(int OAAFNNIHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E260", Offset = "0x4D8D260", VA = "0x184D8E260")]
	private void NEBMDDDJNKL(int OAAFNNIHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DF30", Offset = "0x4D8CF30", VA = "0x184D8DF30")]
	public T[] JEHIPAFJJMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E520", Offset = "0x4D8D520", VA = "0x184D8E520")]
	public T[] OLMNNADJINC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DDC0", Offset = "0x4D8CDC0", VA = "0x184D8DDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DC90", Offset = "0x4D8CC90", VA = "0x184D8DC90")]
	public void CKFNBFGFEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DEC0", Offset = "0x4D8CEC0", VA = "0x184D8DEC0")]
	public DCFBIGKJEPP GHDHEBFDHCI()
	{
		return default(DCFBIGKJEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E670", Offset = "0x4D8D670", VA = "0x184D8E670", Slot = "5")]
	[IteratorStateMachine(typeof(FHHKDIEHOCM<>.ACALOCBBKPI))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E750", Offset = "0x4D8D750", VA = "0x184D8E750", Slot = "6")]
	[IteratorStateMachine(typeof(FHHKDIEHOCM<>.OOBMKNLCLCF))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DC30", Offset = "0x4D8CC30", VA = "0x184D8DC30")]
	public static FHHKDIEHOCM<T> ANKJPMIDFJM(T[] MFIJBPNIELL)
	{
		return default(FHHKDIEHOCM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E1D0", Offset = "0x4D8D1D0", VA = "0x184D8E1D0")]
	public static FHHKDIEHOCM<T> MJOOONLKLLN(T[] MFIJBPNIELL)
	{
		return default(FHHKDIEHOCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DFB0", Offset = "0x4D8CFB0", VA = "0x184D8DFB0")]
	private void KMIMJJJGKLE(int HLGKMAPOEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LJDFCGPENNM
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3D52D70", Offset = "0x3D51D70", VA = "0x183D52D70")]
	public static FHHKDIEHOCM<T> EFNPFLFCEPD<T>(this IEnumerable<T> JHCPJPFFKMM) where T : class
	{
		return default(FHHKDIEHOCM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public class FNGMMGDEDMM<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct HNANALGAOOC : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FNGMMGDEDMM<T> KKAPDLIJLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int HLGKMAPOEBE;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4F52930", Offset = "0x4F51930", VA = "0x184F52930", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4F52970", Offset = "0x4F51970", VA = "0x184F52970", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x49A7FD0", Offset = "0x49A6FD0", VA = "0x1849A7FD0")]
		public HNANALGAOOC(FNGMMGDEDMM<T> KKAPDLIJLLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4F52850", Offset = "0x4F51850", VA = "0x184F52850", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4F528E0", Offset = "0x4F518E0", VA = "0x184F528E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private FHHKDIEHOCM<T> INCJDDLACNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int FCCMJLNEMIB;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4DAFAE0", Offset = "0x4DAEAE0", VA = "0x184DAFAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4DAED20", Offset = "0x4DADD20", VA = "0x184DAED20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x449CC30", Offset = "0x449BC30", VA = "0x18449CC30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OJEKMOODCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF8C0", Offset = "0x4DAE8C0", VA = "0x184DAF8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool OJMOGCONOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF390", Offset = "0x4DAE390", VA = "0x184DAF390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public OBNIEHMAELE<T> GKPFEKOJOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF750", Offset = "0x4DAE750", VA = "0x184DAF750")]
		get
		{
			return default(OBNIEHMAELE<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4DAFA60", Offset = "0x4DAEA60", VA = "0x184DAFA60")]
	public FNGMMGDEDMM(IEnumerable<T> NCIPNLHDHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF9F0", Offset = "0x4DAE9F0", VA = "0x184DAF9F0")]
	public FNGMMGDEDMM(int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF680", Offset = "0x4DAE680", VA = "0x184DAF680")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4DAEB70", Offset = "0x4DADB70", VA = "0x184DAEB70")]
	public FHHKDIEHOCM<T> BMDDEIAGIBJ()
	{
		return default(FHHKDIEHOCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4DAED40", Offset = "0x4DADD40", VA = "0x184DAED40")]
	public void DOPEKGIEJEC(T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF880", Offset = "0x4DAE880", VA = "0x184DAF880")]
	private void OAMHCLAEGFH(int HDEDDOIEPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4DAEA10", Offset = "0x4DADA10", VA = "0x184DAEA10")]
	public void ADIOIPAEJCH(List<T> LFNABJKONLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE990", Offset = "0x4DAD990", VA = "0x184DAE990")]
	public void ADIOIPAEJCH(T[] LFNABJKONLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF6A0", Offset = "0x4DAE6A0", VA = "0x184DAF6A0")]
	public bool LKIPLGLLFFP(T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF600", Offset = "0x4DAE600", VA = "0x184DAF600")]
	public void JCHFIOPIJFJ(int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF3B0", Offset = "0x4DAE3B0", VA = "0x184DAF3B0")]
	public void HKKNNHMLGDC(int NBHLPJDCMON, int KLLLDNANLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4DAED00", Offset = "0x4DADD00", VA = "0x184DAED00")]
	public void CKPCCNNFBHK(int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4DAEEC0", Offset = "0x4DADEC0", VA = "0x184DAEEC0")]
	public void EMBLGGAKCDI(int NBHLPJDCMON, int KLLLDNANLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4DAEE50", Offset = "0x4DADE50", VA = "0x184DAEE50")]
	public int EEGEMFPJFIH(T IOALKPFEKEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF710", Offset = "0x4DAE710", VA = "0x184DAF710")]
	public bool MBIHOFJOLNE(T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF8E0", Offset = "0x4DAE8E0", VA = "0x184DAF8E0")]
	public T[] OLMNNADJINC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4DAEE30", Offset = "0x4DADE30", VA = "0x184DAEE30", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF7D0", Offset = "0x4DAE7D0", VA = "0x184DAF7D0")]
	public static FHHKDIEHOCM<T> MJOOONLKLLN(FNGMMGDEDMM<T> KKAPDLIJLLM)
	{
		return default(FHHKDIEHOCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF320", Offset = "0x4DAE320", VA = "0x184DAF320", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF950", Offset = "0x4DAE950", VA = "0x184DAF950", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF980", Offset = "0x4DAE980", VA = "0x184DAF980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4DAEBB0", Offset = "0x4DADBB0", VA = "0x184DAEBB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CHNGJFBDKFG(int IOALKPFEKEK, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF0F0", Offset = "0x4DAE0F0", VA = "0x184DAF0F0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void FGEJGACKBCG(int NBHLPJDCMON, int KLLLDNANLEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class APLAHKJEJOM
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x31AFB20", Offset = "0x31AEB20", VA = "0x1831AFB20")]
	public static void CKFNBFGFEBB<T>(this FNGMMGDEDMM<T> KKAPDLIJLLM) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public ref struct OBNIEHMAELE<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> INCJDDLACNP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x58989D0", Offset = "0x58979D0", VA = "0x1858989D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5898CE0", Offset = "0x5897CE0", VA = "0x185898CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5898AF0", Offset = "0x5897AF0", VA = "0x185898AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public OBNIEHMAELE(Span<object> AFIGADGOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5898C10", Offset = "0x5897C10", VA = "0x185898C10")]
	public OBNIEHMAELE<T> MHNPFFFFMAH(int LMLEMDDGACN)
	{
		return default(OBNIEHMAELE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5898B30", Offset = "0x5897B30", VA = "0x185898B30")]
	public OBNIEHMAELE<T> MHNPFFFFMAH(int LMLEMDDGACN, int FCCMJLNEMIB)
	{
		return default(OBNIEHMAELE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5898970", Offset = "0x5897970", VA = "0x185898970")]
	public void CNNAEIEFJDJ(OBNIEHMAELE<T> DNPCKHGLBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5898D10", Offset = "0x5897D10", VA = "0x185898D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5898A50", Offset = "0x5897A50", VA = "0x185898A50", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5898AA0", Offset = "0x5897AA0", VA = "0x185898AA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LKKNDHJDELB : IEquatable<LKKNDHJDELB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int MOAJDMPNBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int MFFPIAPMHCN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CNDJAMFAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x314D220", Offset = "0x314C220", VA = "0x18314D220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6EC13E0", Offset = "0x6EC03E0", VA = "0x186EC13E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int OPAPIJDGDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int KJPCIMAPFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x816D5C0", Offset = "0x816C5C0", VA = "0x18816D5C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x816D5D0", Offset = "0x816C5D0", VA = "0x18816D5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) IPJNLKEFJME
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x816D670", Offset = "0x816C670", VA = "0x18816D670")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE5E0E0", Offset = "0xE5D0E0", VA = "0x180E5E0E0")]
	private LKKNDHJDELB(int MOAJDMPNBPN, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2A46530", Offset = "0x2A45530", VA = "0x182A46530")]
	public static LKKNDHJDELB ADFMGHPDLGB(int MOAJDMPNBPN, int MFFPIAPMHCN)
	{
		return default(LKKNDHJDELB);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x816D6D0", Offset = "0x816C6D0", VA = "0x18816D6D0")]
	public static LKKNDHJDELB HOEFOCAMIEF(int LMLEMDDGACN, int KLLLDNANLEJ)
	{
		return default(LKKNDHJDELB);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x816D6E0", Offset = "0x816C6E0", VA = "0x18816D6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1365660", Offset = "0x1364660", VA = "0x181365660", Slot = "4")]
	public bool Equals(LKKNDHJDELB EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x816D5E0", Offset = "0x816C5E0", VA = "0x18816D5E0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x74598C0", Offset = "0x74588C0", VA = "0x1874598C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct MFAFMAGFCPI<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> INCJDDLACNP;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
	public MFAFMAGFCPI(NativeArray<T> INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x56B2600", Offset = "0x56B1600", VA = "0x1856B2600", Slot = "6")]
	public int Compare(int OEFDFBLCHHF, int GDBEEAKMPMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x56B26F0", Offset = "0x56B16F0", VA = "0x1856B26F0", Slot = "4")]
	public bool Equals(int OEFDFBLCHHF, int GDBEEAKMPMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x56B27E0", Offset = "0x56B17E0", VA = "0x1856B27E0", Slot = "5")]
	public int GetHashCode(int OEFDFBLCHHF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IIDCGAGKPAA
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3CC70D0", Offset = "0x3CC60D0", VA = "0x183CC70D0")]
	public static T[] JJGECGIIDPO<T>(List<T> KKAPDLIJLLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NAKMJLFKOHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* LMJPLHDEFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle MFCKLFMCCKP;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD1C0", Offset = "0x5ECC1C0", VA = "0x185ECD1C0")]
	public void NIIIKCLLCBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GMPFMEGMKNK
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C64980", Offset = "0x3C63980", VA = "0x183C64980")]
	public static NAKMJLFKOHJ AKPIFDKGOPP<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> JPAPECBEEIF) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(NAKMJLFKOHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C64980", Offset = "0x3C63980", VA = "0x183C64980")]
	public static UnsafeParallelHashMap<TKey, TValue> NGAMCCPFNIA<TKey, TValue>(this NAKMJLFKOHJ JPAPECBEEIF) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JAABEAEHFPK
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDEEA0", Offset = "0x3CDDEA0", VA = "0x183CDEEA0")]
	public static int MFMJLOJKKHJ<T>(ReadOnlySpan<T> BAGMNOMNPJJ, ReadOnlySpan<T> KMCNHLOMKAB, int FCCMJLNEMIB) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GDMMNICEFCC
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A2C0", Offset = "0x3C592C0", VA = "0x183C5A2C0")]
	public static T KBNPPCHGIKL<T>(this NativeArray<byte> BKFMBMLFOLE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A590", Offset = "0x3C59590", VA = "0x183C5A590")]
	public static NativeArray<T> NDOAMFKMFON<T>(this NativeArray<byte> BKFMBMLFOLE, int MFFPIAPMHCN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A3E0", Offset = "0x3C593E0", VA = "0x183C5A3E0")]
	public static void KENBDFDJMJH<T>(this NativeList<byte> HCPHGFGFIBL, [In] T IOALKPFEKEK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A350", Offset = "0x3C59350", VA = "0x183C5A350")]
	public static void KENBDFDJMJH<T>(this NativeList<byte> HCPHGFGFIBL, NativeArray<T> IOALKPFEKEK) where T : struct
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

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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x858D310", Offset = "0x858C110", VA = "0x18858D310", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AD3290", Offset = "0x3AD2090", VA = "0x183AD3290")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AD3A00", Offset = "0x3AD2800", VA = "0x183AD3A00")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8FA0", Offset = "0x3AD7DA0", VA = "0x183AD8FA0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8140", Offset = "0x3AD6F40", VA = "0x183AD8140")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3AD84B0", Offset = "0x3AD72B0", VA = "0x183AD84B0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9680", Offset = "0x3AD8480", VA = "0x183AD9680")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3C00", Offset = "0x3AD2A00", VA = "0x183AD3C00")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3E50", Offset = "0x3AD2C50", VA = "0x183AD3E50")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5080", Offset = "0x3AD3E80", VA = "0x183AD5080")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, RecRoom.Foundation.Collections.Range range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4C70", Offset = "0x3AD3A70", VA = "0x183AD4C70")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4630", Offset = "0x3AD3430", VA = "0x183AD4630")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3310", Offset = "0x3AD2110", VA = "0x183AD3310")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AD82F0", Offset = "0x3AD70F0", VA = "0x183AD82F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3ADA980", Offset = "0x3AD9780", VA = "0x183ADA980")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC1B0", Offset = "0x3ADAFB0", VA = "0x183ADC1B0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC150", Offset = "0x3ADAF50", VA = "0x183ADC150")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x522C180", Offset = "0x522AF80", VA = "0x18522C180")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x858D6E0", Offset = "0x858C4E0", VA = "0x18858D6E0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x858D710", Offset = "0x858C510", VA = "0x18858D710")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAFE0", Offset = "0x3AD9DE0", VA = "0x183ADAFE0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC100", Offset = "0x3ADAF00", VA = "0x183ADC100")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB300", Offset = "0x3ADA100", VA = "0x183ADB300")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB2A0", Offset = "0x3ADA0A0", VA = "0x183ADB2A0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB240", Offset = "0x3ADA040", VA = "0x183ADB240")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAC40", Offset = "0x3AD9A40", VA = "0x183ADAC40")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB670", Offset = "0x3ADA470", VA = "0x183ADB670")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB4C0", Offset = "0x3ADA2C0", VA = "0x183ADB4C0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAD40", Offset = "0x3AD9B40", VA = "0x183ADAD40")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAB50", Offset = "0x3AD9950", VA = "0x183ADAB50")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAAA0", Offset = "0x3AD98A0", VA = "0x183ADAAA0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC6B0", Offset = "0x3ADB4B0", VA = "0x183ADC6B0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC2B0", Offset = "0x3ADB0B0", VA = "0x183ADC2B0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3ADCA30", Offset = "0x3ADB830", VA = "0x183ADCA30")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3ADCAD0", Offset = "0x3ADB8D0", VA = "0x183ADCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x51D55D0", Offset = "0x51D43D0", VA = "0x1851D55D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x12B3B60", Offset = "0x12B2960", VA = "0x1812B3B60")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x508CB50", Offset = "0x508B950", VA = "0x18508CB50")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B453F0", Offset = "0x5B441F0", VA = "0x185B453F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B45730", Offset = "0x5B44530", VA = "0x185B45730")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF05B0", Offset = "0x3AEF3B0", VA = "0x183AF05B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5BCB200", Offset = "0x5BCA000", VA = "0x185BCB200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5BCB230", Offset = "0x5BCA030", VA = "0x185BCB230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2CE9DA0", Offset = "0x2CE8BA0", VA = "0x182CE9DA0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NativeList<T> List
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(NativeList<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x55738C0", Offset = "0x55726C0", VA = "0x1855738C0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA750", Offset = "0x5BC9550", VA = "0x185BCA750")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BCAA20", Offset = "0x5BC9820", VA = "0x185BCAA20")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB0B0", Offset = "0x5BC9EB0", VA = "0x185BCB0B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5BCAEF0", Offset = "0x5BC9CF0", VA = "0x185BCAEF0")]
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
	public static class KRKLQSPRYCW
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x858D1D0", Offset = "0x858BFD0", VA = "0x18858D1D0")]
		public static JobHandle YDOAPOLHNOX(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x858D120", Offset = "0x858BF20", VA = "0x18858D120")]
		public static JobHandle PUPQYHCOATS(this Span<JobHandle> a)
		{
			return default(JobHandle);
		}
	}
}
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class IOHUDOXARWO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3544BC0", Offset = "0x35439C0", VA = "0x183544BC0")]
		public static void Clear<T>(this T[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class MVXOJJEPUWN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A32950", Offset = "0x3A31750", VA = "0x183A32950")]
		public static NativeKeyValueArrays<TKey, TValue> VRPPELUBIIL<TKey, TValue>(this Dictionary<TKey, TValue> a, Allocator b) where TKey : struct where TValue : struct
		{
			return default(NativeKeyValueArrays<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class MIKVKNFOEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x858D450", Offset = "0x858C250", VA = "0x18858D450")]
		public static void QYNPJOSYTJG(this GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x858D390", Offset = "0x858C190", VA = "0x18858D390")]
		public static void QYNPJOSYTJG(this Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x858D510", Offset = "0x858C310", VA = "0x18858D510")]
		public static void QYNPJOSYTJG(this ScriptableObject a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class SSBLFKNTBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x858EFF0", Offset = "0x858DDF0", VA = "0x18858EFF0")]
		public static void MFKYJUABGPJ(this NativeList<byte> a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFB50", Offset = "0x3CEE950", VA = "0x183CEFB50")]
		public static void ZBNUZBNHNTJ<T>(this NativeList<T> a, T b, int c) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class ORZTKFWOCSZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3B11D60", Offset = "0x3B10B60", VA = "0x183B11D60")]
		public static d HTANCLBAJIC<d>(this ReadOnlySpan<byte> a) where d : struct
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B11970", Offset = "0x3B10770", VA = "0x183B11970")]
		public static k DHECOMYPMCD<k>(this Span<k> a, Func<k, bool> b)
		{
			return (k)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3B11280", Offset = "0x3B10080", VA = "0x183B11280")]
		public static bool All<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B114D0", Offset = "0x3B102D0", VA = "0x183B114D0")]
		public static bool Any<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B11A10", Offset = "0x3B10810", VA = "0x183B11A10")]
		public static T Get<T>([In] this ReadOnlySpan<byte> span) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3B12B50", Offset = "0x3B11950", VA = "0x183B12B50")]
		public static Span<q> VVAKYHLKVOY<q, p>(this Span<p> a) where q : struct where p : struct
		{
			return default(Span<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B12530", Offset = "0x3B11330", VA = "0x183B12530")]
		public static ReadOnlySpan<s> VVAKYHLKVOY<s, r>(this ReadOnlySpan<r> a) where s : struct where r : struct
		{
			return default(ReadOnlySpan<s>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B12AA0", Offset = "0x3B118A0", VA = "0x183B12AA0")]
		public static ReadOnlySpan<t> VVAKYHLKVOY<t>(this ReadOnlySpan<byte> a) where t : struct
		{
			return default(ReadOnlySpan<t>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3B11570", Offset = "0x3B10370", VA = "0x183B11570")]
		public static Span<T> Clone<T>(this ReadOnlySpan<T> src) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B12020", Offset = "0x3B10E20", VA = "0x183B12020")]
		public static Span<byte> Set<T>([In] this Span<byte> span, T value) where T : struct
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x858E0F0", Offset = "0x858CEF0", VA = "0x18858E0F0")]
		private static Enum ZZWMCSJRPOS([In] ReadOnlySpan<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x858DBE0", Offset = "0x858C9E0", VA = "0x18858DBE0")]
		public static Enum SKLACFIFGUE([In] this Span<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x858DC50", Offset = "0x858CA50", VA = "0x18858DC50")]
		public static void TWISAGZBTBK([In] this Span<byte> span, Enum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class TKTKEHHSXZW
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
			[Cpp2IlInjected.Address(RVA = "0x858F180", Offset = "0x858DF80", VA = "0x18858F180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x858F060", Offset = "0x858DE60", VA = "0x18858F060")]
		[AsyncStateMachine(typeof(<TrapExceptions>d__1))]
		public static void LZRPYXFGOAO(this Task a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JAZPGYCQATZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x39AFBF0", Offset = "0x39AE9F0", VA = "0x1839AFBF0")]
		public static NativeArray<T> BNABTBGFDAA<T>(this UnsafeList<T> a) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x39AFE70", Offset = "0x39AEC70", VA = "0x1839AFE70")]
		public static NativeArray<T> XCHEXOMQJUH<T>(this UnsafeList<T> a, bool b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x39AFD40", Offset = "0x39AEB40", VA = "0x1839AFD40")]
		public static UnsafeList<T> Clone<T>(this UnsafeList<T> list, Allocator allocator) where T : struct
		{
			return default(UnsafeList<T>);
		}
	}
}
namespace RecRoom.Foundation.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ELZVOCOOHMG
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
			[Cpp2IlInjected.Address(RVA = "0x31E3810", Offset = "0x31E2610", VA = "0x1831E3810")]
			public Scope(Key key)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static ProfilerCategory JFSYNELQYIL;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x858CFF0", Offset = "0x858BDF0", VA = "0x18858CFF0")]
		static ELZVOCOOHMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3556BB0", Offset = "0x35559B0", VA = "0x183556BB0")]
		public static Scope ZWNHLYRZYBA(Key a)
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void OKMDGZROTXT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class VBKJMALOUKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3E706D0", Offset = "0x3E6F4D0", VA = "0x183E706D0")]
		public static DisposableTuple<a, b> UFWTSPGCTRH<a, b>(this (a, b) a) where a : struct, IDisposable where b : struct, IDisposable
		{
			return default(DisposableTuple<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3E70710", Offset = "0x3E6F510", VA = "0x183E70710")]
		public static DisposableTuple<c, d, e> UFWTSPGCTRH<c, d, e>(this (c, d, e) a) where c : struct, IDisposable where d : struct, IDisposable where e : struct, IDisposable
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
		[Cpp2IlInjected.Address(RVA = "0x2CFFA90", Offset = "0x2CFE890", VA = "0x182CFFA90")]
		public DisposableTuple((T1, T2) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4932030", Offset = "0x4930E30", VA = "0x184932030", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4932390", Offset = "0x4931190", VA = "0x184932390")]
		public DisposableTuple((T1, T2, T3) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4932790", Offset = "0x4931590", VA = "0x184932790", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ENBMKWWHONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x858D050", Offset = "0x858BE50", VA = "0x18858D050")]
		public static System.Range EXFRQRRMACT(this Range a)
		{
			return default(System.Range);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class GXNBHIKMEPQ
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
			public int ZJUSDRVWEMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x858D0C0", Offset = "0x858BEC0", VA = "0x18858D0C0")]
			public Enumerator(int start, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x858D0B0", Offset = "0x858BEB0", VA = "0x18858D0B0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x858D0D0", Offset = "0x858BED0", VA = "0x18858D0D0")]
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
		public bool MLUUWVZDCLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2D3D260", Offset = "0x2D3C060", VA = "0x182D3D260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T REKHREVTQMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x522C930", Offset = "0x522B730", VA = "0x18522C930")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x522C1B0", Offset = "0x522AFB0", VA = "0x18522C1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x522CEC0", Offset = "0x522BCC0", VA = "0x18522CEC0")]
		public Handle(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x522C180", Offset = "0x522AF80", VA = "0x18522C180", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class CRQUIMYAXZI<a, b> : IDisposable where a : struct, VJTUBMNJJFG where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly List<a> SGYLMQCMVJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly List<b> MIKCMZWBJTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Func<b> TLBRCYJCGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<b> XUWFDZHSPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int VRHRYIPFIWR;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public b this[a handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A6C0", Offset = "0x3F794C0", VA = "0x183F7A6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A1C0", Offset = "0x3F78FC0", VA = "0x183F7A1C0")]
		public CRQUIMYAXZI(Action<b> a, [Optional] Func<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3F77F40", Offset = "0x3F76D40", VA = "0x183F77F40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3F777E0", Offset = "0x3F765E0", VA = "0x183F777E0")]
		public a Add(b value)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3F77C00", Offset = "0x3F76A00", VA = "0x183F77C00")]
		public bool Destroy(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3F79790", Offset = "0x3F78590", VA = "0x183F79790")]
		public bool UYCPXVCHFQY(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3F788E0", Offset = "0x3F776E0", VA = "0x183F788E0")]
		public b Get(a handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3F78260", Offset = "0x3F77060", VA = "0x183F78260")]
		public bool Exists(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3F78120", Offset = "0x3F76F20", VA = "0x183F78120")]
		private a EEGBWJWEZLN(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3F787E0", Offset = "0x3F775E0", VA = "0x183F787E0")]
		private b FMTKGWDYXNQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A0A0", Offset = "0x3F78EA0", VA = "0x183F7A0A0")]
		private void XBAZNUOOHOT(int a, [In] a handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3F78220", Offset = "0x3F77020", VA = "0x183F78220")]
		private void EGOQNEXNQBA(int a, [In] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3F78E00", Offset = "0x3F77C00", VA = "0x183F78E00")]
		private a OVHTEYGGPDA()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3F78D50", Offset = "0x3F77B50", VA = "0x183F78D50")]
		private void IQGWYTZEMPN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3F79780", Offset = "0x3F78580", VA = "0x183F79780")]
		private int TSZCNFBCGAI(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3F78DF0", Offset = "0x3F77BF0", VA = "0x183F78DF0")]
		private bool NEJZWRNFOJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAC6870", Offset = "0xAC5670", VA = "0x180AC6870")]
		private void QDIQDXFYMBX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3F77A40", Offset = "0x3F76840", VA = "0x183F77A40")]
		private bool CERWAXKFFMA([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3F79A60", Offset = "0x3F78860", VA = "0x183F79A60")]
		private bool VFGWOXSKLCF([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3F79570", Offset = "0x3F78370", VA = "0x183F79570")]
		private void TATQHNAICOE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface VJTUBMNJJFG
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
	public static class KSNISHBUKFV
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x39EACC0", Offset = "0x39E9AC0", VA = "0x1839EACC0")]
		public static bool SHYUZPBODOA<a>(this a a, a b) where a : struct, VJTUBMNJJFG
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x39EAA30", Offset = "0x39E9830", VA = "0x1839EAA30")]
		public static bool IsValid<T>(this T handle) where T : struct, VJTUBMNJJFG
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x858D210", Offset = "0x858C010", VA = "0x18858D210")]
		public static string WUSRPKBOIXH(this VJTUBMNJJFG a)
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
		[Cpp2IlInjected.Address(RVA = "0x55738C0", Offset = "0x55726C0", VA = "0x1855738C0")]
		public MutableRef(Type valueType, Span<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3ACE130", Offset = "0x3ACCF30", VA = "0x183ACE130")]
		public static MutableRef From<T>(T value) where T : struct
		{
			return default(MutableRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x858D660", Offset = "0x858C460", VA = "0x18858D660")]
		public static implicit operator ReadOnlyRef([In] MutableRef r)
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x858D5D0", Offset = "0x858C3D0", VA = "0x18858D5D0")]
		public Enum SKLACFIFGUE(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3ACE7C0", Offset = "0x3ACD5C0", VA = "0x183ACE7C0")]
		public void Set<T>([In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x858D650", Offset = "0x858C450", VA = "0x18858D650")]
		public void TWISAGZBTBK(Enum a)
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
		public int QIYLFYFWUXC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x858EC40", Offset = "0x858DA40", VA = "0x18858EC40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int FWDMLDMKWAY
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x858EFA0", Offset = "0x858DDA0", VA = "0x18858EFA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x55738C0", Offset = "0x55726C0", VA = "0x1855738C0")]
		public ReadOnlyRef(Type valueType, ReadOnlySpan<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2240", Offset = "0x3CC1040", VA = "0x183CC2240")]
		public static ReadOnlyRef From<T>(T value) where T : struct
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x858EE20", Offset = "0x858DC20", VA = "0x18858EE20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x858EC50", Offset = "0x858DA50", VA = "0x18858EC50")]
		public object SMWCKTLXZMV(int a = 0)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct NativeElement
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD2A0", Offset = "0x3ADC0A0", VA = "0x183ADD2A0")]
		public static NativeArray<T> From<T>(T value, bool isReadOnly) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD390", Offset = "0x3ADC190", VA = "0x183ADD390")]
		public static NativeArray<a> QQTADSXBLRG<a>(a a) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD390", Offset = "0x3ADC190", VA = "0x183ADD390")]
		public static NativeArray<b> QSJDHVAGJEA<b>(b a) where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x858D870", Offset = "0x858C670", VA = "0x18858D870")]
		public static NativeArray<byte> QSJDHVAGJEA(ReadOnlySpan<byte> a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x858D7C0", Offset = "0x858C5C0", VA = "0x18858D7C0")]
		public static NativeArray<byte> From(ReadOnlySpan<byte> value, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x858D740", Offset = "0x858C540", VA = "0x18858D740")]
		public unsafe static NativeArray<byte> From(byte* ptr, int length, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADD190", Offset = "0x3ADBF90", VA = "0x183ADD190")]
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
		public Type QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x858D9C0", Offset = "0x858C7C0", VA = "0x18858D9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x858DAB0", Offset = "0x858C8B0", VA = "0x18858DAB0")]
		public NativeTypeHandle(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x858DB50", Offset = "0x858C950", VA = "0x18858DB50")]
		public static implicit operator NativeTypeHandle(Type type)
		{
			return default(NativeTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x24D03F0", Offset = "0x24CF1F0", VA = "0x1824D03F0", Slot = "4")]
		public bool Equals(NativeTypeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x858D930", Offset = "0x858C730", VA = "0x18858D930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x858DA70", Offset = "0x858C870", VA = "0x18858DA70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class PWCIZFPKXWB
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static Dictionary<Type, int> WJPCLYXISVE;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<Type> KYZCWIODRXS;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x858E950", Offset = "0x858D750", VA = "0x18858E950")]
		static PWCIZFPKXWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x858E670", Offset = "0x858D470", VA = "0x18858E670")]
		public static bool Add(Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x858E6D0", Offset = "0x858D4D0", VA = "0x18858E6D0")]
		private static bool Add(Type type, [Out] int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x858E8F0", Offset = "0x858D6F0", VA = "0x18858E8F0")]
		public static int NKHNLSZGRDJ(Type a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x858E870", Offset = "0x858D670", VA = "0x18858E870")]
		public static Type Get(int index)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct HandlePool<Handle> where Handle : VJTUBMNJJFG, new()
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
			public Handle NVXOHGAZHPU
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x732B740", Offset = "0x732A540", VA = "0x18732B740")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x732BE60", Offset = "0x732AC60", VA = "0x18732BE60")]
			public BaseIndexEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x732BDE0", Offset = "0x732ABE0", VA = "0x18732BDE0")]
			public LiveHandleEnumerator New([In] LiveHandleEnumerator _)
			{
				return default(LiveHandleEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x732BCE0", Offset = "0x732AAE0", VA = "0x18732BCE0")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x732BB60", Offset = "0x732A960", VA = "0x18732BB60")]
			private Handle GQXTEDVCIIY(string a)
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
			public Handle ZJUSDRVWEMA
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x5A318C0", Offset = "0x5A306C0", VA = "0x185A318C0")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x5A319F0", Offset = "0x5A307F0", VA = "0x185A319F0")]
			public LiveHandleEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5A31880", Offset = "0x5A30680", VA = "0x185A31880")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5A31810", Offset = "0x5A30610", VA = "0x185A31810")]
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
		public int YZTXNFOMMLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x522B830", Offset = "0x522A630", VA = "0x18522B830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LiveHandleEnumerator RLEWJCIYKRW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x522B3C0", Offset = "0x522A1C0", VA = "0x18522B3C0")]
			get
			{
				return default(LiveHandleEnumerator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x522C0B0", Offset = "0x522AEB0", VA = "0x18522C0B0")]
		public HandlePool(int initialCapacity, Allocator allocator = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5229AB0", Offset = "0x52288B0", VA = "0x185229AB0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2542F40", Offset = "0x2541D40", VA = "0x182542F40")]
		public static int TSZCNFBCGAI(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x31EE720", Offset = "0x31ED520", VA = "0x1831EE720")]
		public static bool FJGXCPJXTMH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x522AAE0", Offset = "0x52298E0", VA = "0x18522AAE0")]
		public bool LFHYRTGOPFR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x522A3A0", Offset = "0x52291A0", VA = "0x18522A3A0")]
		public bool GUUBKZGKSPJ(Handle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x522A9E0", Offset = "0x52297E0", VA = "0x18522A9E0")]
		public Handle LCGGIVFNBUD()
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x522B0E0", Offset = "0x5229EE0", VA = "0x18522B0E0")]
		public void NEOWYOOAEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5229B60", Offset = "0x5228960", VA = "0x185229B60")]
		public void GDOZUCVILQG(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50")]
		private bool IIJQPRIFYXZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5229970", Offset = "0x5228770", VA = "0x185229970")]
		private bool CYBCOUFKCGL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x522A6B0", Offset = "0x52294B0", VA = "0x18522A6B0")]
		private void JCKXPZFXTYC([Out] int a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x522B880", Offset = "0x522A680", VA = "0x18522B880")]
		private void TZAPGZAKMAY(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5229D70", Offset = "0x5228B70", VA = "0x185229D70")]
		private void GOKZXCSJJYD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x522BDE0", Offset = "0x522ABE0", VA = "0x18522BDE0")]
		private bool WBQPLFKGGET([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x522B760", Offset = "0x522A560", VA = "0x18522B760")]
		private static Handle OMBZIGSKCAB(int a, int b)
		{
			return (Handle)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DefaultMember("Item")]
	public struct ManagedObjectPool<Handle, T> where Handle : VJTUBMNJJFG, new() where T : class
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
		[Cpp2IlInjected.Address(RVA = "0x5AAA230", Offset = "0x5AA9030", VA = "0x185AAA230")]
		public ManagedObjectPool(int initialCapacity, [Optional] Action<T> onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9260", Offset = "0x5AA8060", VA = "0x185AA9260")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9EF0", Offset = "0x5AA8CF0", VA = "0x185AA9EF0")]
		public bool UYCPXVCHFQY(Handle a, [Out] T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9080", Offset = "0x5AA7E80", VA = "0x185AA9080")]
		public Handle Add(T obj)
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9350", Offset = "0x5AA8150", VA = "0x185AA9350")]
		public void OMCGEFMJKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9920", Offset = "0x5AA8720", VA = "0x185AA9920")]
		public void Remove(Handle handle, [Out] T oldObj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9A00", Offset = "0x5AA8800", VA = "0x185AA9A00")]
		public void Remove(Handle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5AA98C0", Offset = "0x5AA86C0", VA = "0x185AA98C0")]
		private T PSNHEXCBCXI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5AA92E0", Offset = "0x5AA80E0", VA = "0x185AA92E0")]
		private void NCUUHYOAZGB(int a)
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
			public T ZJUSDRVWEMA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x4A9BB00", Offset = "0x4A9A900", VA = "0x184A9BB00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B06670", Offset = "0x2B05470", VA = "0x182B06670")]
			public Enumerator(RentedArray<T> array, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x4A99B20", Offset = "0x4A98920", VA = "0x184A99B20")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class ALIKIFWCGFC : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private T QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RentedArray<T> WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int ZTWVKUQIWZR;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private T QAORDEUFUHM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public ALIKIFWCGFC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5059E70", Offset = "0x5058C70", VA = "0x185059E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class FPEDEVZNNOF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public RentedArray<T> WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private int ZTWVKUQIWZR;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public FPEDEVZNNOF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5059E70", Offset = "0x5058C70", VA = "0x185059E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
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
		public int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7130", Offset = "0x5FF5F30", VA = "0x185FF7130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool UMHDIKUBNMU
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6091B70", Offset = "0x6090970", VA = "0x186091B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DGRJVBSKFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1A72C20", Offset = "0x1A71A20", VA = "0x181A72C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal bool TZKSIZZLNWM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6091AE0", Offset = "0x60908E0", VA = "0x186091AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public RentedSpan<T> RORRVOLNNAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6091610", Offset = "0x6090410", VA = "0x186091610")]
			get
			{
				return default(RentedSpan<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6092300", Offset = "0x6091100", VA = "0x186092300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6092460", Offset = "0x6091260", VA = "0x186092460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x60922C0", Offset = "0x60910C0", VA = "0x1860922C0")]
		internal RentedArray(RentedArray<T> array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60922E0", Offset = "0x60910E0", VA = "0x1860922E0")]
		private RentedArray(T[] array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6091FC0", Offset = "0x6090DC0", VA = "0x186091FC0")]
		public RentedArray(IEnumerable<T> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6091F50", Offset = "0x6090D50", VA = "0x186091F50")]
		public RentedArray(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6091790", Offset = "0x6090590", VA = "0x186091790")]
		public int CEFOTAJSKFG(T a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6091F00", Offset = "0x6090D00", VA = "0x186091F00")]
		public void VKFBARTBBEL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6091C70", Offset = "0x6090A70", VA = "0x186091C70")]
		private void RKFPNEIVOKV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6091AF0", Offset = "0x60908F0", VA = "0x186091AF0")]
		public T[] NDTBBIUBAUF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6091810", Offset = "0x6090610", VA = "0x186091810")]
		public T[] CGTPUCJMRRV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6091970", Offset = "0x6090770", VA = "0x186091970", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6091BA0", Offset = "0x60909A0", VA = "0x186091BA0")]
		public void PBXGCSJRMSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60919F0", Offset = "0x60907F0", VA = "0x1860919F0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6091550", Offset = "0x6090350", VA = "0x186091550", Slot = "5")]
		[IteratorStateMachine(typeof(RentedArray<>.ALIKIFWCGFC))]
		private IEnumerator<T> BDJRHOPGRSB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6091E40", Offset = "0x6090C40", VA = "0x186091E40", Slot = "6")]
		[IteratorStateMachine(typeof(RentedArray<>.FPEDEVZNNOF))]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6091C10", Offset = "0x6090A10", VA = "0x186091C10")]
		public static RentedArray<T> QVQVWMAXIMF(T[] a)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60923D0", Offset = "0x60911D0", VA = "0x1860923D0")]
		public static implicit operator RentedArray<T>(T[] array)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6091A60", Offset = "0x6090860", VA = "0x186091A60")]
		private void IOWBTRAZPOJ(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class KBADFVVPOBS
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x39E31D0", Offset = "0x39E1FD0", VA = "0x1839E31D0")]
		public static RentedArray<b> KJAPVZXZIWN<b>(this IEnumerable<b> a) where b : class
		{
			return default(RentedArray<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class ODUSMGRZXRA<a> : IReadOnlyList<a>, IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>, IDisposable where a : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private ODUSMGRZXRA<a> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x4A9BB50", Offset = "0x4A9A950", VA = "0x184A9BB50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public a Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x4A9CD10", Offset = "0x4A9BB10", VA = "0x184A9CD10", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4A9C040", Offset = "0x4A9AE40", VA = "0x184A9C040")]
			public Enumerator(ODUSMGRZXRA<a> list)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4A99B70", Offset = "0x4A98970", VA = "0x184A99B70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x493D230", Offset = "0x493C030", VA = "0x18493D230", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private RentedArray<a> UZOZEZLFZLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int QCYQTYQUXNJ;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5C66410", Offset = "0x5C65210", VA = "0x185C66410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5C65EA0", Offset = "0x5C64CA0", VA = "0x185C65EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int YZTXNFOMMLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5C65E80", Offset = "0x5C64C80", VA = "0x185C65E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool DGRJVBSKFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5C65BF0", Offset = "0x5C649F0", VA = "0x185C65BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public RentedSpan<a> RORRVOLNNAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5C65130", Offset = "0x5C63F30", VA = "0x185C65130")]
			get
			{
				return default(RentedSpan<a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5C66380", Offset = "0x5C65180", VA = "0x185C66380")]
		public ODUSMGRZXRA(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5C66310", Offset = "0x5C65110", VA = "0x185C66310")]
		public ODUSMGRZXRA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5C65270", Offset = "0x5C64070", VA = "0x185C65270")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5C653B0", Offset = "0x5C641B0", VA = "0x185C653B0")]
		public RentedArray<a> JETWRKWBATC()
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5C65060", Offset = "0x5C63E60", VA = "0x185C65060")]
		public void Add(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5C661B0", Offset = "0x5C64FB0", VA = "0x185C661B0")]
		private void VKFBARTBBEL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5C656C0", Offset = "0x5C644C0", VA = "0x185C656C0")]
		public void MFKYJUABGPJ(List<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5C65590", Offset = "0x5C64390", VA = "0x185C65590")]
		public void MFKYJUABGPJ(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5C65DF0", Offset = "0x5C64BF0", VA = "0x185C65DF0")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5C65AB0", Offset = "0x5C648B0", VA = "0x185C65AB0")]
		public void MOVAXTNBDLE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5C658B0", Offset = "0x5C646B0", VA = "0x185C658B0")]
		public void MJFYQUPLIPO(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5C65C10", Offset = "0x5C64A10", VA = "0x185C65C10")]
		public void PSNHEXCBCXI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5C65F50", Offset = "0x5C64D50", VA = "0x185C65F50")]
		public void UTJEVZEYMRG(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5C651C0", Offset = "0x5C63FC0", VA = "0x185C651C0")]
		public int CEFOTAJSKFG(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5C652D0", Offset = "0x5C640D0", VA = "0x185C652D0")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5C651F0", Offset = "0x5C63FF0", VA = "0x185C651F0")]
		public a[] CGTPUCJMRRV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5C65320", Offset = "0x5C64120", VA = "0x185C65320", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5C66480", Offset = "0x5C65280", VA = "0x185C66480")]
		public static implicit operator RentedArray<a>(ODUSMGRZXRA<a> list)
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5C65350", Offset = "0x5C64150", VA = "0x185C65350", Slot = "6")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5C66140", Offset = "0x5C64F40", VA = "0x185C66140", Slot = "7")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5C65EF0", Offset = "0x5C64CF0", VA = "0x185C65EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5C661F0", Offset = "0x5C64FF0", VA = "0x185C661F0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void ZVFUZZHXOHX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5C65400", Offset = "0x5C64200", VA = "0x185C65400")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void LDSGOUHORTN(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class OWPEOXTTTNZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3B14960", Offset = "0x3B13760", VA = "0x183B14960")]
		public static void PBXGCSJRMSP<c>(this ODUSMGRZXRA<c> a) where c : class
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
			[Cpp2IlInjected.Address(RVA = "0x60927A0", Offset = "0x60915A0", VA = "0x1860927A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6092830", Offset = "0x6091630", VA = "0x186092830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6092510", Offset = "0x6091310", VA = "0x186092510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x151F1E0", Offset = "0x151DFE0", VA = "0x18151F1E0")]
		public RentedSpan(Span<object> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x60925F0", Offset = "0x60913F0", VA = "0x1860925F0")]
		public RentedSpan<T> XNEGBKEZGST(int a)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x60926C0", Offset = "0x60914C0", VA = "0x1860926C0")]
		public RentedSpan<T> XNEGBKEZGST(int a, int b)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6092550", Offset = "0x6091350", VA = "0x186092550")]
		public void CopyTo(RentedSpan<T> destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60925B0", Offset = "0x60913B0", VA = "0x1860925B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD4D0", Offset = "0x5ABC2D0", VA = "0x185ABD4D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "2")]
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
		public int APVUGZXIKWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int ODIIXCYNYBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x30206B0", Offset = "0x301F4B0", VA = "0x1830206B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x30206C0", Offset = "0x301F4C0", VA = "0x1830206C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int FXMFIGIXULC
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int WSFNWRHTUQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x858EBA0", Offset = "0x858D9A0", VA = "0x18858EBA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x858EBB0", Offset = "0x858D9B0", VA = "0x18858EBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public (int begin, int end) SIXMWYYJNPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x858EB40", Offset = "0x858D940", VA = "0x18858EB40")]
			get
			{
				return default((int, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
		private Range(int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9A50", Offset = "0x2AF8850", VA = "0x182AF9A50")]
		public static Range GIHGUGPNEZV(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x858EAA0", Offset = "0x858D8A0", VA = "0x18858EAA0")]
		public static Range ABNSGVKWHFA(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x858EBC0", Offset = "0x858D9C0", VA = "0x18858EBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x141FD90", Offset = "0x141EB90", VA = "0x18141FD90", Slot = "4")]
		public bool Equals(Range other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x858EAB0", Offset = "0x858D8B0", VA = "0x18858EAB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x78C7900", Offset = "0x78C6700", VA = "0x1878C7900", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x151F1E0", Offset = "0x151DFE0", VA = "0x18151F1E0")]
		public SortIndicesByData(NativeArray<T> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6160B40", Offset = "0x615F940", VA = "0x186160B40", Slot = "6")]
		public int Compare(int x, int y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6160ED0", Offset = "0x615FCD0", VA = "0x186160ED0", Slot = "4")]
		public bool Equals(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x61611D0", Offset = "0x615FFD0", VA = "0x1861611D0", Slot = "5")]
		public int GetHashCode(int x)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class FJXQFUMOMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x38E5A70", Offset = "0x38E4870", VA = "0x1838E5A70")]
		public static a[] TFHFCKEYGLX<a>(List<a> a)
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
		[Cpp2IlInjected.Address(RVA = "0x858F300", Offset = "0x858E100", VA = "0x18858F300")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class MLWHLXCLXTY
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3A16850", Offset = "0x3A15650", VA = "0x183A16850")]
		public static UnsafeParallelHashMapProxy ZJNLIZHORSG<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMapProxy);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3A16850", Offset = "0x3A15650", VA = "0x183A16850")]
		public static UnsafeParallelHashMap<TKey, TValue> WRJKRROZAYY<TKey, TValue>(this UnsafeParallelHashMapProxy a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMap<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class UJXHMEEPBRT
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3E3D070", Offset = "0x3E3BE70", VA = "0x183E3D070")]
		public static int LFQHSHJGVUM<a>(ReadOnlySpan<a> a, ReadOnlySpan<a> b, int c) where a : struct
		{
			return default(int);
		}
	}
}
namespace RecRoom.Foundation.Collections.Stream
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class XSJUOOIWKLR
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3E98580", Offset = "0x3E97380", VA = "0x183E98580")]
		public static b MYNUIMAJKFJ<b>(this NativeArray<byte> a) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3E98170", Offset = "0x3E96F70", VA = "0x183E98170")]
		public static NativeArray<T> ITHCHFPJSYA<T>(this NativeArray<byte> a, int b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3E97E10", Offset = "0x3E96C10", VA = "0x183E97E10")]
		public static void BMAIBKUWEXE<c>(this NativeList<byte> a, [In] c value) where c : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3E97E80", Offset = "0x3E96C80", VA = "0x183E97E80")]
		public static void BMAIBKUWEXE<T>(this NativeList<byte> a, NativeArray<T> b) where T : struct
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

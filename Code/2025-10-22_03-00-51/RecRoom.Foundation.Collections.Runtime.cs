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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8507050", Offset = "0x8505650", VA = "0x188507050", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AD8130", Offset = "0x3AD6730", VA = "0x183AD8130")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AD88A0", Offset = "0x3AD6EA0", VA = "0x183AD88A0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3ADBA00", Offset = "0x3ADA000", VA = "0x183ADBA00")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3ADABA0", Offset = "0x3AD91A0", VA = "0x183ADABA0")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAF10", Offset = "0x3AD9510", VA = "0x183ADAF10")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC0D0", Offset = "0x3ADA6D0", VA = "0x183ADC0D0")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8A90", Offset = "0x3AD7090", VA = "0x183AD8A90")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8CE0", Offset = "0x3AD72E0", VA = "0x183AD8CE0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9F10", Offset = "0x3AD8510", VA = "0x183AD9F10")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, RecRoom.Foundation.Collections.Range range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9B00", Offset = "0x3AD8100", VA = "0x183AD9B00")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD94C0", Offset = "0x3AD7AC0", VA = "0x183AD94C0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3AD81B0", Offset = "0x3AD67B0", VA = "0x183AD81B0")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAD50", Offset = "0x3AD9350", VA = "0x183ADAD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3ADF800", Offset = "0x3ADDE00", VA = "0x183ADF800")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0FB0", Offset = "0x3ADF5B0", VA = "0x183AE0FB0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0F50", Offset = "0x3ADF550", VA = "0x183AE0F50")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5133200", Offset = "0x5131800", VA = "0x185133200")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8507230", Offset = "0x8505830", VA = "0x188507230")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8507260", Offset = "0x8505860", VA = "0x188507260")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFE60", Offset = "0x3ADE460", VA = "0x183ADFE60")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0F00", Offset = "0x3ADF500", VA = "0x183AE0F00")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0180", Offset = "0x3ADE780", VA = "0x183AE0180")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0120", Offset = "0x3ADE720", VA = "0x183AE0120")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE00C0", Offset = "0x3ADE6C0", VA = "0x183AE00C0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFAC0", Offset = "0x3ADE0C0", VA = "0x183ADFAC0")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE04F0", Offset = "0x3ADEAF0", VA = "0x183AE04F0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0340", Offset = "0x3ADE940", VA = "0x183AE0340")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFBC0", Offset = "0x3ADE1C0", VA = "0x183ADFBC0")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF9D0", Offset = "0x3ADDFD0", VA = "0x183ADF9D0")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF920", Offset = "0x3ADDF20", VA = "0x183ADF920")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AE14B0", Offset = "0x3ADFAB0", VA = "0x183AE14B0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AE10B0", Offset = "0x3ADF6B0", VA = "0x183AE10B0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1830", Offset = "0x3ADFE30", VA = "0x183AE1830")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AE18D0", Offset = "0x3ADFED0", VA = "0x183AE18D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B7A90", Offset = "0x50B6090", VA = "0x1850B7A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xF396D0", Offset = "0xF37CD0", VA = "0x180F396D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1317F10", Offset = "0x1316510", VA = "0x181317F10")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4F752A0", Offset = "0x4F738A0", VA = "0x184F752A0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5A91840", Offset = "0x5A8FE40", VA = "0x185A91840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5A91A90", Offset = "0x5A90090", VA = "0x185A91A90")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3A4DD20", Offset = "0x3A4C320", VA = "0x183A4DD20")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B189C0", Offset = "0x5B16FC0", VA = "0x185B189C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5B189F0", Offset = "0x5B16FF0", VA = "0x185B189F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2D072D0", Offset = "0x2D058D0", VA = "0x182D072D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NativeList<T> List
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(NativeList<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5457880", Offset = "0x5455E80", VA = "0x185457880")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B17FA0", Offset = "0x5B165A0", VA = "0x185B17FA0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B18260", Offset = "0x5B16860", VA = "0x185B18260")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5B18890", Offset = "0x5B16E90", VA = "0x185B18890", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B186D0", Offset = "0x5B16CD0", VA = "0x185B186D0")]
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
	public static class BMJAHPNPTYP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85068E0", Offset = "0x8504EE0", VA = "0x1885068E0")]
		public static JobHandle MGTWCZWWOBC(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8506920", Offset = "0x8504F20", VA = "0x188506920")]
		public static JobHandle RXTQRNFSIYB(this Span<JobHandle> a)
		{
			return default(JobHandle);
		}
	}
}
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class WZFTMKJMZKT
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3551BF0", Offset = "0x35501F0", VA = "0x183551BF0")]
		public static void Clear<T>(this T[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class RGBCXYXDNMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BB40", Offset = "0x3C5A140", VA = "0x183C5BB40")]
		public static NativeKeyValueArrays<TKey, TValue> UWNNZDTAMXE<TKey, TValue>(this Dictionary<TKey, TValue> a, Allocator b) where TKey : struct where TValue : struct
		{
			return default(NativeKeyValueArrays<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class YTTGGDZMOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8508AC0", Offset = "0x85070C0", VA = "0x188508AC0")]
		public static void XRDTERBDALP(this GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8508A00", Offset = "0x8507000", VA = "0x188508A00")]
		public static void XRDTERBDALP(this Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8508B80", Offset = "0x8507180", VA = "0x188508B80")]
		public static void XRDTERBDALP(this ScriptableObject a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class SIDDDCGWRXD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8507CE0", Offset = "0x85062E0", VA = "0x188507CE0")]
		public static void EIIARTIDLHW(this NativeList<byte> a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3D19F30", Offset = "0x3D18530", VA = "0x183D19F30")]
		public static void SIUPSLYRSDQ<T>(this NativeList<T> a, T b, int c) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class TXGMCSQYKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3D637C0", Offset = "0x3D61DC0", VA = "0x183D637C0")]
		public static d RUDEBMRICCL<d>(this ReadOnlySpan<byte> a) where d : struct
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D63720", Offset = "0x3D61D20", VA = "0x183D63720")]
		public static k KQSJOFJXKRS<k>(this Span<k> a, Func<k, bool> b)
		{
			return (k)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3D62CC0", Offset = "0x3D612C0", VA = "0x183D62CC0")]
		public static bool All<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D62F20", Offset = "0x3D61520", VA = "0x183D62F20")]
		public static bool Any<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3D631A0", Offset = "0x3D617A0", VA = "0x183D631A0")]
		public static T Get<T>([In] this ReadOnlySpan<byte> span) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3D64470", Offset = "0x3D62A70", VA = "0x183D64470")]
		public static Span<q> UKIMDYNJUJF<q, p>(this Span<p> a) where q : struct where p : struct
		{
			return default(Span<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D63F90", Offset = "0x3D62590", VA = "0x183D63F90")]
		public static ReadOnlySpan<s> UKIMDYNJUJF<s, r>(this ReadOnlySpan<r> a) where s : struct where r : struct
		{
			return default(ReadOnlySpan<s>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D643C0", Offset = "0x3D629C0", VA = "0x183D643C0")]
		public static ReadOnlySpan<t> UKIMDYNJUJF<t>(this ReadOnlySpan<byte> a) where t : struct
		{
			return default(ReadOnlySpan<t>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D62FC0", Offset = "0x3D615C0", VA = "0x183D62FC0")]
		public static Span<T> Clone<T>(this ReadOnlySpan<T> src) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D63A80", Offset = "0x3D62080", VA = "0x183D63A80")]
		public static Span<byte> Set<T>([In] this Span<byte> span, T value) where T : struct
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8508260", Offset = "0x8506860", VA = "0x188508260")]
		private static Enum WMPBKWZHALF([In] ReadOnlySpan<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8507D50", Offset = "0x8506350", VA = "0x188507D50")]
		public static Enum LAWYBKNKGTL([In] this Span<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8507DC0", Offset = "0x85063C0", VA = "0x188507DC0")]
		public static void MWTHJIVPCND([In] this Span<byte> span, Enum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class GGKQSXEGWJR
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
			[Cpp2IlInjected.Address(RVA = "0x85087F0", Offset = "0x8506DF0", VA = "0x1885087F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8506AF0", Offset = "0x85050F0", VA = "0x188506AF0")]
		[AsyncStateMachine(typeof(<TrapExceptions>d__1))]
		public static void DULFSONMWOB(this Task a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class LPZGITTSHTW
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x39BC8B0", Offset = "0x39BAEB0", VA = "0x1839BC8B0")]
		public static NativeArray<T> AJDSJNQHKQR<T>(this UnsafeList<T> a) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x39BC9D0", Offset = "0x39BAFD0", VA = "0x1839BC9D0")]
		public static NativeArray<T> BWNHPDBXRVQ<T>(this UnsafeList<T> a, bool b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x39BCB10", Offset = "0x39BB110", VA = "0x1839BCB10")]
		public static UnsafeList<T> Clone<T>(this UnsafeList<T> list, Allocator allocator) where T : struct
		{
			return default(UnsafeList<T>);
		}
	}
}
namespace RecRoom.Foundation.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class XRXKEMGWLHF
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
			[Cpp2IlInjected.Address(RVA = "0x31FE520", Offset = "0x31FCB20", VA = "0x1831FE520")]
			public Scope(Key key)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static ProfilerCategory KBXSVEWKXFS;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85089A0", Offset = "0x8506FA0", VA = "0x1885089A0")]
		static XRXKEMGWLHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x355B270", Offset = "0x3559870", VA = "0x18355B270")]
		public static Scope CVANIJKNFMR(Key a)
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void XLRNKAWCKHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class VXXNUKCVXYC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3EBCEB0", Offset = "0x3EBB4B0", VA = "0x183EBCEB0")]
		public static DisposableTuple<a, b> HGTXZARRUVQ<a, b>(this (a, b) a) where a : struct, IDisposable where b : struct, IDisposable
		{
			return default(DisposableTuple<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3EBCEF0", Offset = "0x3EBB4F0", VA = "0x183EBCEF0")]
		public static DisposableTuple<c, d, e> HGTXZARRUVQ<c, d, e>(this (c, d, e) a) where c : struct, IDisposable where d : struct, IDisposable where e : struct, IDisposable
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
		[Cpp2IlInjected.Address(RVA = "0x2D21AD0", Offset = "0x2D200D0", VA = "0x182D21AD0")]
		public DisposableTuple((T1, T2) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x49006E0", Offset = "0x48FECE0", VA = "0x1849006E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4900A40", Offset = "0x48FF040", VA = "0x184900A40")]
		public DisposableTuple((T1, T2, T3) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4900E10", Offset = "0x48FF410", VA = "0x184900E10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class OVPNLDQYIYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8507730", Offset = "0x8505D30", VA = "0x188507730")]
		public static System.Range GKIJXODBBJQ(this Range a)
		{
			return default(System.Range);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class MHSRAENTTMH
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
			public int BUONWNCQTMJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8506AE0", Offset = "0x85050E0", VA = "0x188506AE0")]
			public Enumerator(int start, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8506AD0", Offset = "0x85050D0", VA = "0x188506AD0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85070D0", Offset = "0x85056D0", VA = "0x1885070D0")]
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
		public bool WRSBKMAGEAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2D5C500", Offset = "0x2D5AB00", VA = "0x182D5C500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T HOYELULZOXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5133A10", Offset = "0x5132010", VA = "0x185133A10")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5133230", Offset = "0x5131830", VA = "0x185133230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5133ED0", Offset = "0x51324D0", VA = "0x185133ED0")]
		public Handle(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5133200", Offset = "0x5131800", VA = "0x185133200", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ZIUJDOESLBJ<a, b> : IDisposable where a : struct, FKATZDKRTHL where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly List<a> AXJECUIAYCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly List<b> EJHSPXJBXKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Func<b> AAAXRSMWPBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<b> BPXSULVYROS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int FBZDGRPIGEY;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public b this[a handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x40D9FE0", Offset = "0x40D85E0", VA = "0x1840D9FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x40D9B20", Offset = "0x40D8120", VA = "0x1840D9B20")]
		public ZIUJDOESLBJ(Action<b> a, [Optional] Func<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x40D7EF0", Offset = "0x40D64F0", VA = "0x1840D7EF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x40D7300", Offset = "0x40D5900", VA = "0x1840D7300")]
		public a Add(b value)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x40D7B50", Offset = "0x40D6150", VA = "0x1840D7B50")]
		public bool Destroy(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x40D96D0", Offset = "0x40D7CD0", VA = "0x1840D96D0")]
		public bool XTYYQLAKLBN(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x40D8A30", Offset = "0x40D7030", VA = "0x1840D8A30")]
		public b Get(a handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x40D8030", Offset = "0x40D6630", VA = "0x1840D8030")]
		public bool Exists(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x40D94A0", Offset = "0x40D7AA0", VA = "0x1840D94A0")]
		private a ROTYBXFJYXM(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x40D92C0", Offset = "0x40D78C0", VA = "0x1840D92C0")]
		private b MSUQGLLKEHH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x40D9180", Offset = "0x40D7780", VA = "0x1840D9180")]
		private void LGXVMCOKWTI(int a, [In] a handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x40D9290", Offset = "0x40D7890", VA = "0x1840D9290")]
		private void MHYZRYTYABP(int a, [In] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x40D8B40", Offset = "0x40D7140", VA = "0x1840D8B40")]
		private a JXPKCLCNLRD()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x40D8590", Offset = "0x40D6B90", VA = "0x1840D8590")]
		private void GUJUSKMQBEC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x40D8580", Offset = "0x40D6B80", VA = "0x1840D8580")]
		private int GMOIFFGJUFF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x40D7540", Offset = "0x40D5B40", VA = "0x1840D7540")]
		private bool BDUMSRQLJBQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAB0780", Offset = "0xAAED80", VA = "0x180AB0780")]
		private void QFZCZKLUXMI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x40D9A30", Offset = "0x40D8030", VA = "0x1840D9A30")]
		private bool ZAMYXVYEFHJ([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x40D7550", Offset = "0x40D5B50", VA = "0x1840D7550")]
		private bool DNFJJHKMOHW([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x40D95E0", Offset = "0x40D7BE0", VA = "0x1840D95E0")]
		private void UAUPBNSZHOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface FKATZDKRTHL
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
	public static class CECTXFBNVAQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x36C0200", Offset = "0x36BE800", VA = "0x1836C0200")]
		public static bool ODLHQSGSJOL<a>(this a a, a b) where a : struct, FKATZDKRTHL
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x36BFF70", Offset = "0x36BE570", VA = "0x1836BFF70")]
		public static bool IsValid<T>(this T handle) where T : struct, FKATZDKRTHL
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85069D0", Offset = "0x8504FD0", VA = "0x1885069D0")]
		public static string ZUEYFWBFRDA(this FKATZDKRTHL a)
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
		[Cpp2IlInjected.Address(RVA = "0x5457880", Offset = "0x5455E80", VA = "0x185457880")]
		public MutableRef(Type valueType, Span<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3AC2C30", Offset = "0x3AC1230", VA = "0x183AC2C30")]
		public static MutableRef From<T>(T value) where T : struct
		{
			return default(MutableRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85071B0", Offset = "0x85057B0", VA = "0x1885071B0")]
		public static implicit operator ReadOnlyRef([In] MutableRef r)
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8507120", Offset = "0x8505720", VA = "0x188507120")]
		public Enum LAWYBKNKGTL(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3AC32C0", Offset = "0x3AC18C0", VA = "0x183AC32C0")]
		public void Set<T>([In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x85071A0", Offset = "0x85057A0", VA = "0x1885071A0")]
		public void MWTHJIVPCND(Enum a)
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
		public int WQRBTGHEKBP
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8507B00", Offset = "0x8506100", VA = "0x188507B00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int ZDOSNDMBJEL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8507B10", Offset = "0x8506110", VA = "0x188507B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5457880", Offset = "0x5455E80", VA = "0x185457880")]
		public ReadOnlyRef(Type valueType, ReadOnlySpan<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0F20", Offset = "0x3CEF520", VA = "0x183CF0F20")]
		public static ReadOnlyRef From<T>(T value) where T : struct
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8507B60", Offset = "0x8506160", VA = "0x188507B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8507930", Offset = "0x8505F30", VA = "0x188507930")]
		public object CRXFDJISVFY(int a = 0)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct NativeElement
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3AE20A0", Offset = "0x3AE06A0", VA = "0x183AE20A0")]
		public static NativeArray<T> From<T>(T value, bool isReadOnly) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3AE21E0", Offset = "0x3AE07E0", VA = "0x183AE21E0")]
		public static NativeArray<a> ROEHOPKAVHB<a>(a a) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3AE21E0", Offset = "0x3AE07E0", VA = "0x183AE21E0")]
		public static NativeArray<b> RPUKSRNFSTV<b>(b a) where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85073C0", Offset = "0x85059C0", VA = "0x1885073C0")]
		public static NativeArray<byte> RPUKSRNFSTV(ReadOnlySpan<byte> a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8507310", Offset = "0x8505910", VA = "0x188507310")]
		public static NativeArray<byte> From(ReadOnlySpan<byte> value, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8507290", Offset = "0x8505890", VA = "0x188507290")]
		public unsafe static NativeArray<byte> From(byte* ptr, int length, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1F90", Offset = "0x3AE0590", VA = "0x183AE1F90")]
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
		public Type BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8507550", Offset = "0x8505B50", VA = "0x188507550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8507600", Offset = "0x8505C00", VA = "0x188507600")]
		public NativeTypeHandle(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85076A0", Offset = "0x8505CA0", VA = "0x1885076A0")]
		public static implicit operator NativeTypeHandle(Type type)
		{
			return default(NativeTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2542510", Offset = "0x2540B10", VA = "0x182542510", Slot = "4")]
		public bool Equals(NativeTypeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8507480", Offset = "0x8505A80", VA = "0x188507480", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8507510", Offset = "0x8505B10", VA = "0x188507510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class KAEXIXOTQBS
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static Dictionary<Type, int> JKAOWXKODQD;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<Type> NQGXDFONPHL;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8506EF0", Offset = "0x85054F0", VA = "0x188506EF0")]
		static KAEXIXOTQBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8506DB0", Offset = "0x85053B0", VA = "0x188506DB0")]
		public static bool Add(Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8506C10", Offset = "0x8505210", VA = "0x188506C10")]
		private static bool Add(Type type, [Out] int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8506E90", Offset = "0x8505490", VA = "0x188506E90")]
		public static int MPKFVNXTCYQ(Type a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8506E10", Offset = "0x8505410", VA = "0x188506E10")]
		public static Type Get(int index)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct HandlePool<Handle> where Handle : FKATZDKRTHL, new()
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
			public Handle MGNUWVQMPUH
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x72D48D0", Offset = "0x72D2ED0", VA = "0x1872D48D0")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x72D49F0", Offset = "0x72D2FF0", VA = "0x1872D49F0")]
			public BaseIndexEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x72D4610", Offset = "0x72D2C10", VA = "0x1872D4610")]
			public LiveHandleEnumerator New([In] LiveHandleEnumerator _)
			{
				return default(LiveHandleEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x72D4510", Offset = "0x72D2B10", VA = "0x1872D4510")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x72D4300", Offset = "0x72D2900", VA = "0x1872D4300")]
			private Handle AWYAYENMJKN(string a)
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
			public Handle BUONWNCQTMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x592FF70", Offset = "0x592E570", VA = "0x18592FF70")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x59300E0", Offset = "0x592E6E0", VA = "0x1859300E0")]
			public LiveHandleEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x59300A0", Offset = "0x592E6A0", VA = "0x1859300A0")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x592FF00", Offset = "0x592E500", VA = "0x18592FF00")]
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
		public int ITMGZAGWEWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5132A10", Offset = "0x5131010", VA = "0x185132A10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LiveHandleEnumerator FBPMJYGDUEV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x5132AB0", Offset = "0x51310B0", VA = "0x185132AB0")]
			get
			{
				return default(LiveHandleEnumerator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5133130", Offset = "0x5131730", VA = "0x185133130")]
		public HandlePool(int initialCapacity, Allocator allocator = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5130EB0", Offset = "0x512F4B0", VA = "0x185130EB0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x257B0E0", Offset = "0x25796E0", VA = "0x18257B0E0")]
		public static int GMOIFFGJUFF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x32156A0", Offset = "0x3213CA0", VA = "0x1832156A0")]
		public static bool ZUEPWAXPJCO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5130F50", Offset = "0x512F550", VA = "0x185130F50")]
		public bool EXMVBUXIVOG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x51319D0", Offset = "0x512FFD0", VA = "0x1851319D0")]
		public bool FUBGLYAQXAA(Handle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5132390", Offset = "0x5130990", VA = "0x185132390")]
		public Handle MEDTZSXUMSO()
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x51313A0", Offset = "0x512F9A0", VA = "0x1851313A0")]
		public void FJGSFVCQBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5131330", Offset = "0x512F930", VA = "0x185131330")]
		public void FAHVTQXPPWT(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00")]
		private bool ZWURHQRAUHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5132100", Offset = "0x5130700", VA = "0x185132100")]
		private bool HJARMRKDBSY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5130C70", Offset = "0x512F270", VA = "0x185130C70")]
		private void AZAMKVCAARL([Out] int a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5132B30", Offset = "0x5131130", VA = "0x185132B30")]
		private void XRUAAITPGDR(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x51320B0", Offset = "0x51306B0", VA = "0x1851320B0")]
		private void FUCIWIWYCGC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5132590", Offset = "0x5130B90", VA = "0x185132590")]
		private bool PUHJRZOVNHE([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5132690", Offset = "0x5130C90", VA = "0x185132690")]
		private static Handle TGKAVUHXFCQ(int a, int b)
		{
			return (Handle)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DefaultMember("Item")]
	public struct ManagedObjectPool<Handle, T> where Handle : FKATZDKRTHL, new() where T : class
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
		[Cpp2IlInjected.Address(RVA = "0x5A39680", Offset = "0x5A37C80", VA = "0x185A39680")]
		public ManagedObjectPool(int initialCapacity, [Optional] Action<T> onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5A38740", Offset = "0x5A36D40", VA = "0x185A38740")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5A39350", Offset = "0x5A37950", VA = "0x185A39350")]
		public bool XTYYQLAKLBN(Handle a, [Out] T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5A38570", Offset = "0x5A36B70", VA = "0x185A38570")]
		public Handle Add(T obj)
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5A387C0", Offset = "0x5A36DC0", VA = "0x185A387C0")]
		public void LWGFZGZGELV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5A38D50", Offset = "0x5A37350", VA = "0x185A38D50")]
		public void Remove(Handle handle, [Out] T oldObj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5A38E30", Offset = "0x5A37430", VA = "0x185A38E30")]
		public void Remove(Handle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5A38CF0", Offset = "0x5A372F0", VA = "0x185A38CF0")]
		private T RXWITETQETH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5A392E0", Offset = "0x5A378E0", VA = "0x185A392E0")]
		private void ULLOLHXVYXE(int a)
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
			public T BUONWNCQTMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x49888C0", Offset = "0x4986EC0", VA = "0x1849888C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2B23F20", Offset = "0x2B22520", VA = "0x182B23F20")]
			public Enumerator(RentedArray<T> array, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x4989110", Offset = "0x4987710", VA = "0x184989110")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class XGGDDPCNNJN : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private T MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RentedArray<T> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int HAOYDNHAFWO;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private T HNCVYZVQHWH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public XGGDDPCNNJN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4085540", Offset = "0x4083B40", VA = "0x184085540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class OZLJDHPECNC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public RentedArray<T> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private int HAOYDNHAFWO;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public OZLJDHPECNC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x4085540", Offset = "0x4083B40", VA = "0x184085540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
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
		public int VQADIKBXVTK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5E99720", Offset = "0x5E97D20", VA = "0x185E99720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool XEAGQKLOKWN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5F310B0", Offset = "0x5F2F6B0", VA = "0x185F310B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool JYNGXFGZZJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1AC2160", Offset = "0x1AC0760", VA = "0x181AC2160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal bool NEUFPVKEVUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x5F319D0", Offset = "0x5F2FFD0", VA = "0x185F319D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public RentedSpan<T> QHFNLQZGNYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5F31690", Offset = "0x5F2FC90", VA = "0x185F31690")]
			get
			{
				return default(RentedSpan<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5F31D80", Offset = "0x5F30380", VA = "0x185F31D80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5F31EE0", Offset = "0x5F304E0", VA = "0x185F31EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F31D40", Offset = "0x5F30340", VA = "0x185F31D40")]
		internal RentedArray(RentedArray<T> array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5F31D60", Offset = "0x5F30360", VA = "0x185F31D60")]
		private RentedArray(T[] array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F31A50", Offset = "0x5F30050", VA = "0x185F31A50")]
		public RentedArray(IEnumerable<T> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F319E0", Offset = "0x5F2FFE0", VA = "0x185F319E0")]
		public RentedArray(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F31190", Offset = "0x5F2F790", VA = "0x185F31190")]
		public int DAWBYAWITUB(T a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5F31650", Offset = "0x5F2FC50", VA = "0x185F31650")]
		public void RDPGFJFUXYE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F31800", Offset = "0x5F2FE00", VA = "0x185F31800")]
		private void UCUCRNXLUKA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5F31300", Offset = "0x5F2F900", VA = "0x185F31300")]
		public T[] HDDCECHWVQY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5F31500", Offset = "0x5F2FB00", VA = "0x185F31500")]
		public T[] QQZVJXILBMW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5F31210", Offset = "0x5F2F810", VA = "0x185F31210", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5F31490", Offset = "0x5F2FA90", VA = "0x185F31490")]
		public void PLXMKQDSCXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5F31290", Offset = "0x5F2F890", VA = "0x185F31290")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5F310E0", Offset = "0x5F2F6E0", VA = "0x185F310E0", Slot = "5")]
		[IteratorStateMachine(typeof(RentedArray<>.XGGDDPCNNJN))]
		private IEnumerator<T> CDFQCYMHDZO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5F313E0", Offset = "0x5F2F9E0", VA = "0x185F313E0", Slot = "6")]
		[IteratorStateMachine(typeof(RentedArray<>.OZLJDHPECNC))]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5F31380", Offset = "0x5F2F980", VA = "0x185F31380")]
		public static RentedArray<T> MHJZJLJZSWC(T[] a)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5F31E50", Offset = "0x5F30450", VA = "0x185F31E50")]
		public static implicit operator RentedArray<T>(T[] array)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5F31030", Offset = "0x5F2F630", VA = "0x185F31030")]
		private void AVBMSWODTJK(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class TEETHCZJYBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D5DE60", Offset = "0x3D5C460", VA = "0x183D5DE60")]
		public static RentedArray<b> KLLKIJPQBEA<b>(this IEnumerable<b> a) where b : class
		{
			return default(RentedArray<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class IMEKMSZAYDL<a> : IReadOnlyList<a>, IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>, IDisposable where a : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private IMEKMSZAYDL<a> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x49886F0", Offset = "0x4986CF0", VA = "0x1849886F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public a Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x498B4D0", Offset = "0x4989AD0", VA = "0x18498B4D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x498B180", Offset = "0x4989780", VA = "0x18498B180")]
			public Enumerator(IMEKMSZAYDL<a> list)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x49894F0", Offset = "0x4987AF0", VA = "0x1849894F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4909320", Offset = "0x4907920", VA = "0x184909320", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private RentedArray<a> QHPHTAHQMYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int ZIGOAKWPXJW;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x51D9FC0", Offset = "0x51D85C0", VA = "0x1851D9FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int VQADIKBXVTK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x51D97A0", Offset = "0x51D7DA0", VA = "0x1851D97A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int ITMGZAGWEWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x51D9BE0", Offset = "0x51D81E0", VA = "0x1851D9BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool JYNGXFGZZJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x51D9230", Offset = "0x51D7830", VA = "0x1851D9230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public RentedSpan<a> QHFNLQZGNYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x51D9B00", Offset = "0x51D8100", VA = "0x1851D9B00")]
			get
			{
				return default(RentedSpan<a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x51D9ED0", Offset = "0x51D84D0", VA = "0x1851D9ED0")]
		public IMEKMSZAYDL(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x51D9F50", Offset = "0x51D8550", VA = "0x1851D9F50")]
		public IMEKMSZAYDL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x51D9150", Offset = "0x51D7750", VA = "0x1851D9150")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x51D95C0", Offset = "0x51D7BC0", VA = "0x1851D95C0")]
		public RentedArray<a> JGYONLDRSWJ()
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x51D9090", Offset = "0x51D7690", VA = "0x1851D9090")]
		public void Add(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x51D9870", Offset = "0x51D7E70", VA = "0x1851D9870")]
		private void RDPGFJFUXYE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x51D9390", Offset = "0x51D7990", VA = "0x1851D9390")]
		public void EIIARTIDLHW(List<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x51D9270", Offset = "0x51D7870", VA = "0x1851D9270")]
		public void EIIARTIDLHW(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x51D9A80", Offset = "0x51D8080", VA = "0x1851D9A80")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x51D9C00", Offset = "0x51D8200", VA = "0x1851D9C00")]
		public void WOIIYSZWVEB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x51D8EA0", Offset = "0x51D74A0", VA = "0x1851D8EA0")]
		public void AZHZJTDFJVP(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x51D98B0", Offset = "0x51D7EB0", VA = "0x1851D98B0")]
		public void RXWITETQETH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x51D8CC0", Offset = "0x51D72C0", VA = "0x1851D8CC0")]
		public void AVJQBDRIYCB(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x51D9200", Offset = "0x51D7800", VA = "0x1851D9200")]
		public int DAWBYAWITUB(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x51D91B0", Offset = "0x51D77B0", VA = "0x1851D91B0")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x51D97F0", Offset = "0x51D7DF0", VA = "0x1851D97F0")]
		public a[] QQZVJXILBMW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x51D9250", Offset = "0x51D7850", VA = "0x1851D9250", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x51DA030", Offset = "0x51D8630", VA = "0x1851DA030")]
		public static implicit operator RentedArray<a>(IMEKMSZAYDL<a> list)
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x51D9560", Offset = "0x51D7B60", VA = "0x1851D9560", Slot = "6")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x51D9730", Offset = "0x51D7D30", VA = "0x1851D9730", Slot = "7")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x51D9B80", Offset = "0x51D8180", VA = "0x1851D9B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x51D9610", Offset = "0x51D7C10", VA = "0x1851D9610")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void JSMPCERSXUU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x51D9D40", Offset = "0x51D8340", VA = "0x1851D9D40")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void YCHDSZBGNVE(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class NTUSDWJTQJS
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7A80", Offset = "0x3AD6080", VA = "0x183AD7A80")]
		public static void PLXMKQDSCXY<c>(this IMEKMSZAYDL<c> a) where c : class
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
			[Cpp2IlInjected.Address(RVA = "0x5F32220", Offset = "0x5F30820", VA = "0x185F32220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5F322A0", Offset = "0x5F308A0", VA = "0x185F322A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int VQADIKBXVTK
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x5F32030", Offset = "0x5F30630", VA = "0x185F32030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x157CC10", Offset = "0x157B210", VA = "0x18157CC10")]
		public RentedSpan(Span<object> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5F32150", Offset = "0x5F30750", VA = "0x185F32150")]
		public RentedSpan<T> ZGAFYNZCHUW(int a)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5F32070", Offset = "0x5F30670", VA = "0x185F32070")]
		public RentedSpan<T> ZGAFYNZCHUW(int a, int b)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5F31F90", Offset = "0x5F30590", VA = "0x185F31F90")]
		public void CopyTo(RentedSpan<T> destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5F31FF0", Offset = "0x5F305F0", VA = "0x185F31FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6CE0", Offset = "0x3FF52E0", VA = "0x183FF6CE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "2")]
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
		public int YKTGULEOTLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x303B5B0", Offset = "0x3039BB0", VA = "0x18303B5B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x303B5C0", Offset = "0x3039BC0", VA = "0x18303B5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int MMOZYBUGEIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int BESFLJVUAJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8507910", Offset = "0x8505F10", VA = "0x188507910")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8507920", Offset = "0x8505F20", VA = "0x188507920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public (int begin, int end) WKQORYIBXJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8507820", Offset = "0x8505E20", VA = "0x188507820")]
			get
			{
				return default((int, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
		private Range(int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C90", Offset = "0x2B10290", VA = "0x182B11C90")]
		public static Range LCPICCWYHJU(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8507880", Offset = "0x8505E80", VA = "0x188507880")]
		public static Range SLWDEMDDPYF(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8507890", Offset = "0x8505E90", VA = "0x188507890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x146D670", Offset = "0x146BC70", VA = "0x18146D670", Slot = "4")]
		public bool Equals(Range other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8507790", Offset = "0x8505D90", VA = "0x188507790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7830F20", Offset = "0x782F520", VA = "0x187830F20", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x157CC10", Offset = "0x157B210", VA = "0x18157CC10")]
		public SortIndicesByData(NativeArray<T> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x607FCA0", Offset = "0x607E2A0", VA = "0x18607FCA0", Slot = "6")]
		public int Compare(int x, int y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6080020", Offset = "0x607E620", VA = "0x186080020", Slot = "4")]
		public bool Equals(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6080310", Offset = "0x607E910", VA = "0x186080310", Slot = "5")]
		public int GetHashCode(int x)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class SBNOXOOUCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3D163C0", Offset = "0x3D149C0", VA = "0x183D163C0")]
		public static a[] LONXRLOOUNA<a>(List<a> a)
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
		[Cpp2IlInjected.Address(RVA = "0x8508970", Offset = "0x8506F70", VA = "0x188508970")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class QDMFMMXWETB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x38FCA40", Offset = "0x38FB040", VA = "0x1838FCA40")]
		public static UnsafeParallelHashMapProxy HFIROXVDADB<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMapProxy);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x38FCA40", Offset = "0x38FB040", VA = "0x1838FCA40")]
		public static UnsafeParallelHashMap<TKey, TValue> OJHPSCMHLCB<TKey, TValue>(this UnsafeParallelHashMapProxy a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMap<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class LYJKZZPLHMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x39C4CC0", Offset = "0x39C32C0", VA = "0x1839C4CC0")]
		public static int WGQHUDNOACX<a>(ReadOnlySpan<a> a, ReadOnlySpan<a> b, int c) where a : struct
		{
			return default(int);
		}
	}
}
namespace RecRoom.Foundation.Collections.Stream
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class EVWCYPYMIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x37F9000", Offset = "0x37F7600", VA = "0x1837F9000")]
		public static b JMIEBPCXEWY<b>(this NativeArray<byte> a) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x37F91D0", Offset = "0x37F77D0", VA = "0x1837F91D0")]
		public static NativeArray<T> RIVZLQHGWXD<T>(this NativeArray<byte> a, int b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x37F8D30", Offset = "0x37F7330", VA = "0x1837F8D30")]
		public static void GYNQACGGPQL<c>(this NativeList<byte> a, [In] c value) where c : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x37F8DA0", Offset = "0x37F73A0", VA = "0x1837F8DA0")]
		public static void GYNQACGGPQL<T>(this NativeList<byte> a, NativeArray<T> b) where T : struct
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

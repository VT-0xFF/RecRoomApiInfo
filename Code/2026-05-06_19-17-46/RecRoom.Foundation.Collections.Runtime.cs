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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9868B10", Offset = "0x9867510", VA = "0x189868B10", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D1AEF0", Offset = "0x3D198F0", VA = "0x183D1AEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D1B660", Offset = "0x3D1A060", VA = "0x183D1B660")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FD90", Offset = "0x3D1E790", VA = "0x183D1FD90")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EF30", Offset = "0x3D1D930", VA = "0x183D1EF30")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F2A0", Offset = "0x3D1DCA0", VA = "0x183D1F2A0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D20460", Offset = "0x3D1EE60", VA = "0x183D20460")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B850", Offset = "0x3D1A250", VA = "0x183D1B850")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BAA0", Offset = "0x3D1A4A0", VA = "0x183D1BAA0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CD50", Offset = "0x3D1B750", VA = "0x183D1CD50")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, RecRoom.Foundation.Collections.Range range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C7C0", Offset = "0x3D1B1C0", VA = "0x183D1C7C0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C280", Offset = "0x3D1AC80", VA = "0x183D1C280")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D1AF70", Offset = "0x3D19970", VA = "0x183D1AF70")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F0E0", Offset = "0x3D1DAE0", VA = "0x183D1F0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D21390", Offset = "0x3D1FD90", VA = "0x183D21390")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D22BC0", Offset = "0x3D215C0", VA = "0x183D22BC0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D22B60", Offset = "0x3D21560", VA = "0x183D22B60")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64E4540", Offset = "0x64E2F40", VA = "0x1864E4540")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9868CA0", Offset = "0x98676A0", VA = "0x189868CA0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9868CD0", Offset = "0x98676D0", VA = "0x189868CD0")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D219F0", Offset = "0x3D203F0", VA = "0x183D219F0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D22B10", Offset = "0x3D21510", VA = "0x183D22B10")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D21D10", Offset = "0x3D20710", VA = "0x183D21D10")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D21CB0", Offset = "0x3D206B0", VA = "0x183D21CB0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D21C50", Offset = "0x3D20650", VA = "0x183D21C50")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D21650", Offset = "0x3D20050", VA = "0x183D21650")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D22080", Offset = "0x3D20A80", VA = "0x183D22080")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D21ED0", Offset = "0x3D208D0", VA = "0x183D21ED0")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D21750", Offset = "0x3D20150", VA = "0x183D21750")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D21560", Offset = "0x3D1FF60", VA = "0x183D21560")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D214B0", Offset = "0x3D1FEB0", VA = "0x183D214B0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D230C0", Offset = "0x3D21AC0", VA = "0x183D230C0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D22CC0", Offset = "0x3D216C0", VA = "0x183D22CC0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D23440", Offset = "0x3D21E40", VA = "0x183D23440")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D234E0", Offset = "0x3D21EE0", VA = "0x183D234E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6495470", Offset = "0x6493E70", VA = "0x186495470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xEFDE50", Offset = "0xEFC850", VA = "0x180EFDE50")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x12B5BE0", Offset = "0x12B45E0", VA = "0x1812B5BE0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6333720", Offset = "0x6332120", VA = "0x186333720")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72817E0", Offset = "0x72801E0", VA = "0x1872817E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7281B10", Offset = "0x7280510", VA = "0x187281B10")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39D5160", Offset = "0x39D3B60", VA = "0x1839D5160")]
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
			[Cpp2IlInjected.Address(RVA = "0x7341170", Offset = "0x733FB70", VA = "0x187341170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x73411A0", Offset = "0x733FBA0", VA = "0x1873411A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2D895F0", Offset = "0x2D87FF0", VA = "0x182D895F0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NativeList<T> List
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10")]
			get
			{
				return default(NativeList<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68FA780", Offset = "0x68F9180", VA = "0x1868FA780")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7340930", Offset = "0x733F330", VA = "0x187340930")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7340A80", Offset = "0x733F480", VA = "0x187340A80")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7341040", Offset = "0x733FA40", VA = "0x187341040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7340EC0", Offset = "0x733F8C0", VA = "0x187340EC0")]
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
	public static class POWSPXBGLOR
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98695E0", Offset = "0x9867FE0", VA = "0x1898695E0")]
		public static JobHandle GBLHGBQXKTU(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9869620", Offset = "0x9868020", VA = "0x189869620")]
		public static JobHandle YMTRFGJAFCL(this Span<JobHandle> a)
		{
			return default(JobHandle);
		}
	}
}
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class YCZIWTOTVDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3663A10", Offset = "0x3662410", VA = "0x183663A10")]
		public static void Clear<T>(this T[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class HPBPTFSFBWA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9E70", Offset = "0x3AE8870", VA = "0x183AE9E70")]
		public static NativeKeyValueArrays<TKey, TValue> FYLMSBRWKSY<TKey, TValue>(this Dictionary<TKey, TValue> a, Allocator b) where TKey : struct where TValue : struct
		{
			return default(NativeKeyValueArrays<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class EOHYSCBIBZP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9867E00", Offset = "0x9866800", VA = "0x189867E00")]
		public static void JMFGVNNOMED(this GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9867D40", Offset = "0x9866740", VA = "0x189867D40")]
		public static void JMFGVNNOMED(this Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9867EC0", Offset = "0x98668C0", VA = "0x189867EC0")]
		public static void JMFGVNNOMED(this ScriptableObject a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class TZDKMLJPSGH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9869D40", Offset = "0x9868740", VA = "0x189869D40")]
		public static void CXTOSJAUCLM(this NativeList<byte> a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A400", Offset = "0x3F28E00", VA = "0x183F2A400")]
		public static void ZIHPVSNCVUE<T>(this NativeList<T> a, T b, int c) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class FTSEUNXSGVS
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3AB56D0", Offset = "0x3AB40D0", VA = "0x183AB56D0")]
		public static d RTPJLYWGVQR<d>(this ReadOnlySpan<byte> a) where d : struct
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5630", Offset = "0x3AB4030", VA = "0x183AB5630")]
		public static k QZMBRNEPCXE<k>(this Span<k> a, Func<k, bool> b)
		{
			return (k)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4290", Offset = "0x3AB2C90", VA = "0x183AB4290")]
		public static bool All<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3AB44F0", Offset = "0x3AB2EF0", VA = "0x183AB44F0")]
		public static bool Any<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4770", Offset = "0x3AB3170", VA = "0x183AB4770")]
		public static T Get<T>([In] this ReadOnlySpan<byte> span) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3AB52D0", Offset = "0x3AB3CD0", VA = "0x183AB52D0")]
		public static Span<q> HULXNHXEAJD<q, p>(this Span<p> a) where q : struct where p : struct
		{
			return default(Span<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4CB0", Offset = "0x3AB36B0", VA = "0x183AB4CB0")]
		public static ReadOnlySpan<s> HULXNHXEAJD<s, r>(this ReadOnlySpan<r> a) where s : struct where r : struct
		{
			return default(ReadOnlySpan<s>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5220", Offset = "0x3AB3C20", VA = "0x183AB5220")]
		public static ReadOnlySpan<t> HULXNHXEAJD<t>(this ReadOnlySpan<byte> a) where t : struct
		{
			return default(ReadOnlySpan<t>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4590", Offset = "0x3AB2F90", VA = "0x183AB4590")]
		public static Span<T> Clone<T>(this ReadOnlySpan<T> src) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5990", Offset = "0x3AB4390", VA = "0x183AB5990")]
		public static Span<byte> Set<T>([In] this Span<byte> span, T value) where T : struct
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x98680A0", Offset = "0x9866AA0", VA = "0x1898680A0")]
		private static Enum HKXLJXKNOQZ([In] ReadOnlySpan<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9868630", Offset = "0x9867030", VA = "0x189868630")]
		public static Enum VCACDJFMWCH([In] this Span<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x98686A0", Offset = "0x98670A0", VA = "0x1898686A0")]
		public static void ZYTDGLTLKFN([In] this Span<byte> span, Enum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class TWRMUERISUN
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
			[Cpp2IlInjected.Address(RVA = "0x9869DB0", Offset = "0x98687B0", VA = "0x189869DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD39FE0", Offset = "0xD389E0", VA = "0x180D39FE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9869C20", Offset = "0x9868620", VA = "0x189869C20")]
		[AsyncStateMachine(typeof(<TrapExceptions>d__1))]
		public static void FLANISCWPSP(this Task a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DDKRGALKYLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x38CAC00", Offset = "0x38C9600", VA = "0x1838CAC00")]
		public static NativeArray<T> OFHQKPDZLJV<T>(this UnsafeList<T> a) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x38CAB10", Offset = "0x38C9510", VA = "0x1838CAB10")]
		public static NativeArray<T> FHMFPSYORTW<T>(this UnsafeList<T> a, bool b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x38CA9E0", Offset = "0x38C93E0", VA = "0x1838CA9E0")]
		public static UnsafeList<T> Clone<T>(this UnsafeList<T> list, Allocator allocator) where T : struct
		{
			return default(UnsafeList<T>);
		}
	}
}
namespace RecRoom.Foundation.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class UQVURKWZBSR
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
			[Cpp2IlInjected.Address(RVA = "0x328D560", Offset = "0x328BF60", VA = "0x18328D560")]
			public Scope(Key key)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static ProfilerCategory GSLCWCNGNUS;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9869F30", Offset = "0x9868930", VA = "0x189869F30")]
		static UQVURKWZBSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x36865B0", Offset = "0x3684FB0", VA = "0x1836865B0")]
		public static Scope PMMPCJRTIKT(Key a)
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public static void ZHECRUHJONO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class YEDPUUCJSJS
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4127120", Offset = "0x4125B20", VA = "0x184127120")]
		public static DisposableTuple<a, b> DJDLSERISXK<a, b>(this (a, b) a) where a : struct, IDisposable where b : struct, IDisposable
		{
			return default(DisposableTuple<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4127160", Offset = "0x4125B60", VA = "0x184127160")]
		public static DisposableTuple<c, d, e> DJDLSERISXK<c, d, e>(this (c, d, e) a) where c : struct, IDisposable where d : struct, IDisposable where e : struct, IDisposable
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
		[Cpp2IlInjected.Address(RVA = "0x2D9F7C0", Offset = "0x2D9E1C0", VA = "0x182D9F7C0")]
		public DisposableTuple((T1, T2) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9F00", Offset = "0x5AE8900", VA = "0x185AE9F00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AEA260", Offset = "0x5AE8C60", VA = "0x185AEA260")]
		public DisposableTuple((T1, T2, T3) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA640", Offset = "0x5AE9040", VA = "0x185AEA640", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class CBIEKWXMVKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9867CE0", Offset = "0x98666E0", VA = "0x189867CE0")]
		public static System.Range WSWPORCTRFS(this Range a)
		{
			return default(System.Range);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class ATCRLPBMTSF
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
			public int MHGYPCJQMJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9868090", Offset = "0x9866A90", VA = "0x189868090")]
			public Enumerator(int start, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9868080", Offset = "0x9866A80", VA = "0x189868080")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9867C90", Offset = "0x9866690", VA = "0x189867C90")]
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
		public bool RRXNMIEIOKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2DDAF30", Offset = "0x2DD9930", VA = "0x182DDAF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x64E46D0", Offset = "0x64E30D0", VA = "0x1864E46D0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x64E4D60", Offset = "0x64E3760", VA = "0x1864E4D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x64E51F0", Offset = "0x64E3BF0", VA = "0x1864E51F0")]
		public Handle(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x64E4540", Offset = "0x64E2F40", VA = "0x1864E4540", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class BBLMRXWKOTH<a, b> : IDisposable where a : struct, NSHUFTJMBEP where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly List<a> COMZMHGFWCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly List<b> CNEXRUBOKSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Func<b> QOUYPWUTLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<b> LFNUJIBMVLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int IANXCVZOJUW;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public b this[a handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4EF2660", Offset = "0x4EF1060", VA = "0x184EF2660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF20F0", Offset = "0x4EF0AF0", VA = "0x184EF20F0")]
		public BBLMRXWKOTH(Action<b> a, [Optional] Func<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4EEFEE0", Offset = "0x4EEE8E0", VA = "0x184EEFEE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4EEFA90", Offset = "0x4EEE490", VA = "0x184EEFA90")]
		public a Add(b value)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4EEFB40", Offset = "0x4EEE540", VA = "0x184EEFB40")]
		public bool Destroy(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1E40", Offset = "0x4EF0840", VA = "0x184EF1E40")]
		public bool YSUOHJHYAIZ(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0E70", Offset = "0x4EEF870", VA = "0x184EF0E70")]
		public b Get(a handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4EF05D0", Offset = "0x4EEEFD0", VA = "0x184EF05D0")]
		public bool Exists(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0C90", Offset = "0x4EEF690", VA = "0x184EF0C90")]
		private a GDRIUJLMPUY(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1E10", Offset = "0x4EF0810", VA = "0x184EF1E10")]
		private b VSWVGZQYENZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0020", Offset = "0x4EEEA20", VA = "0x184EF0020")]
		private void ENZLPQNZPYU(int a, [In] a handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4EEFB10", Offset = "0x4EEE510", VA = "0x184EEFB10")]
		private void CCJTOXJVQPR(int a, [In] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4EF13A0", Offset = "0x4EEFDA0", VA = "0x184EF13A0")]
		private a HXDVDRNJSAT()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1970", Offset = "0x4EF0370", VA = "0x184EF1970")]
		private void UOWCRNPYMWI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0C80", Offset = "0x4EEF680", VA = "0x184EF0C80")]
		private int FZWASSHFRCB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4EF17C0", Offset = "0x4EF01C0", VA = "0x184EF17C0")]
		private bool OVFIOVCVZAU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCE3460", Offset = "0xCE1E60", VA = "0x180CE3460")]
		private void GMIEFCTQTFI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4EF17D0", Offset = "0x4EF01D0", VA = "0x184EF17D0")]
		private bool UBGQGPIAHNP([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0680", Offset = "0x4EEF080", VA = "0x184EF0680")]
		private bool FFNWJQYHBWO([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4EF16D0", Offset = "0x4EF00D0", VA = "0x184EF16D0")]
		private void NVFBFSUHACV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface NSHUFTJMBEP
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
	public static class EUQEWIXBVZU
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3938250", Offset = "0x3936C50", VA = "0x183938250")]
		public static bool ZUDUWAKSPRH<a>(this a a, a b) where a : struct, NSHUFTJMBEP
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3937FC0", Offset = "0x39369C0", VA = "0x183937FC0")]
		public static bool IsValid<T>(this T handle) where T : struct, NSHUFTJMBEP
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9867F80", Offset = "0x9866980", VA = "0x189867F80")]
		public static string PXZDOFMZFQA(this NSHUFTJMBEP a)
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
		[Cpp2IlInjected.Address(RVA = "0x68FA780", Offset = "0x68F9180", VA = "0x1868FA780")]
		public MutableRef(Type valueType, Span<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3D15010", Offset = "0x3D13A10", VA = "0x183D15010")]
		public static MutableRef From<T>(T value) where T : struct
		{
			return default(MutableRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9868C20", Offset = "0x9867620", VA = "0x189868C20")]
		public static implicit operator ReadOnlyRef([In] MutableRef r)
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9868B90", Offset = "0x9867590", VA = "0x189868B90")]
		public Enum VCACDJFMWCH(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3D156A0", Offset = "0x3D140A0", VA = "0x183D156A0")]
		public void Set<T>([In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9868C10", Offset = "0x9867610", VA = "0x189868C10")]
		public void ZYTDGLTLKFN(Enum a)
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
		public int EYHXJXUJANV
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9869BC0", Offset = "0x98685C0", VA = "0x189869BC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int JAQOBPQYSAF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9869BD0", Offset = "0x98685D0", VA = "0x189869BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x68FA780", Offset = "0x68F9180", VA = "0x1868FA780")]
		public ReadOnlyRef(Type valueType, ReadOnlySpan<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3EAFBE0", Offset = "0x3EAE5E0", VA = "0x183EAFBE0")]
		public static ReadOnlyRef From<T>(T value) where T : struct
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9869A40", Offset = "0x9868440", VA = "0x189869A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9869870", Offset = "0x9868270", VA = "0x189869870")]
		public object NUOVVQETMII(int a = 0)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct NativeElement
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3D23CB0", Offset = "0x3D226B0", VA = "0x183D23CB0")]
		public static NativeArray<T> From<T>(T value, bool isReadOnly) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3D23DF0", Offset = "0x3D227F0", VA = "0x183D23DF0")]
		public static NativeArray<a> LORCNUOTGSR<a>(a a) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3D23DF0", Offset = "0x3D227F0", VA = "0x183D23DF0")]
		public static NativeArray<b> LNAZJSLOJFX<b>(b a) where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9868E30", Offset = "0x9867830", VA = "0x189868E30")]
		public static NativeArray<byte> LNAZJSLOJFX(ReadOnlySpan<byte> a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9868D80", Offset = "0x9867780", VA = "0x189868D80")]
		public static NativeArray<byte> From(ReadOnlySpan<byte> value, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9868D00", Offset = "0x9867700", VA = "0x189868D00")]
		public unsafe static NativeArray<byte> From(byte* ptr, int length, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3D23BA0", Offset = "0x3D225A0", VA = "0x183D23BA0")]
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
		public Type UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9868F70", Offset = "0x9867970", VA = "0x189868F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9869060", Offset = "0x9867A60", VA = "0x189869060")]
		public NativeTypeHandle(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9869100", Offset = "0x9867B00", VA = "0x189869100")]
		public static implicit operator NativeTypeHandle(Type type)
		{
			return default(NativeTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2385590", Offset = "0x2383F90", VA = "0x182385590", Slot = "4")]
		public bool Equals(NativeTypeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9868EF0", Offset = "0x98678F0", VA = "0x189868EF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9869020", Offset = "0x9867A20", VA = "0x189869020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class OGXGCWDUKWK
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static Dictionary<Type, int> KRCZYOJEYYR;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<Type> QUSBASFHHDV;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9869480", Offset = "0x9867E80", VA = "0x189869480")]
		static OGXGCWDUKWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9869190", Offset = "0x9867B90", VA = "0x189869190")]
		public static bool Add(Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x98691F0", Offset = "0x9867BF0", VA = "0x1898691F0")]
		private static bool Add(Type type, [Out] int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9869420", Offset = "0x9867E20", VA = "0x189869420")]
		public static int MZMYSFGSYRA(Type a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x98693A0", Offset = "0x9867DA0", VA = "0x1898693A0")]
		public static Type Get(int index)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct HandlePool<Handle> where Handle : NSHUFTJMBEP, new()
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
			public Handle HIIAOQCWMQB
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x4F7E500", Offset = "0x4F7CF00", VA = "0x184F7E500")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x4F7E860", Offset = "0x4F7D260", VA = "0x184F7E860")]
			public BaseIndexEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4F7E390", Offset = "0x4F7CD90", VA = "0x184F7E390")]
			public LiveHandleEnumerator New([In] LiveHandleEnumerator _)
			{
				return default(LiveHandleEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x4F7E290", Offset = "0x4F7CC90", VA = "0x184F7E290")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4F7E4B0", Offset = "0x4F7CEB0", VA = "0x184F7E4B0")]
			private Handle OQARXUYWDYX(string a)
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
			public Handle MHGYPCJQMJF
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x6FF5680", Offset = "0x6FF4080", VA = "0x186FF5680")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6FF57F0", Offset = "0x6FF41F0", VA = "0x186FF57F0")]
			public LiveHandleEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6FF57B0", Offset = "0x6FF41B0", VA = "0x186FF57B0")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6FF5610", Offset = "0x6FF4010", VA = "0x186FF5610")]
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
		public int MMFNGNHMKCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x64E3BF0", Offset = "0x64E25F0", VA = "0x1864E3BF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LiveHandleEnumerator RMLILPEMSLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x64E3C90", Offset = "0x64E2690", VA = "0x1864E3C90")]
			get
			{
				return default(LiveHandleEnumerator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64E4470", Offset = "0x64E2E70", VA = "0x1864E4470")]
		public HandlePool(int initialCapacity, Allocator allocator = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x64E2230", Offset = "0x64E0C30", VA = "0x1864E2230")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x25F4880", Offset = "0x25F3280", VA = "0x1825F4880")]
		public static int FZWASSHFRCB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x329E5E0", Offset = "0x329CFE0", VA = "0x18329E5E0")]
		public static bool PYOSZFFPOSY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64E3190", Offset = "0x64E1B90", VA = "0x1864E3190")]
		public bool LNKYQESTVUI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x64E3D10", Offset = "0x64E2710", VA = "0x1864E3D10")]
		public bool YENIPKSHKGK(Handle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x64E2800", Offset = "0x64E1200", VA = "0x1864E2800")]
		public Handle ILXJLFNMHKY()
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64E3280", Offset = "0x64E1C80", VA = "0x1864E3280")]
		public void NBQUQOXCULX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64E1F60", Offset = "0x64E0960", VA = "0x1864E1F60")]
		public void DDXSMOSBSXL(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550")]
		private bool INOUBOFIRTC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x64E1E50", Offset = "0x64E0850", VA = "0x1864E1E50")]
		private bool AQLGZHKDHAK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x64E38B0", Offset = "0x64E22B0", VA = "0x1864E38B0")]
		private void TUBSRLDUYNJ([Out] int a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x64E2B00", Offset = "0x64E1500", VA = "0x1864E2B00")]
		private void LDRMHBJICRL(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x64E1F10", Offset = "0x64E0910", VA = "0x1864E1F10")]
		private void BTBUKBYASQQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x64E2A00", Offset = "0x64E1400", VA = "0x1864E2A00")]
		private bool JTBHQIJOINS([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x64E25D0", Offset = "0x64E0FD0", VA = "0x1864E25D0")]
		private static Handle FVWBLARDUUG(int a, int b)
		{
			return (Handle)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DefaultMember("Item")]
	public struct ManagedObjectPool<Handle, T> where Handle : NSHUFTJMBEP, new() where T : class
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
		[Cpp2IlInjected.Address(RVA = "0x7073080", Offset = "0x7071A80", VA = "0x187073080")]
		public ManagedObjectPool(int initialCapacity, [Optional] Action<T> onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7072140", Offset = "0x7070B40", VA = "0x187072140")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7072D50", Offset = "0x7071750", VA = "0x187072D50")]
		public bool YSUOHJHYAIZ(Handle a, [Out] T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7071F70", Offset = "0x7070970", VA = "0x187071F70")]
		public Handle Add(T obj)
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7072570", Offset = "0x7070F70", VA = "0x187072570")]
		public void NOUQCKWWAXD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7072760", Offset = "0x7071160", VA = "0x187072760")]
		public void Remove(Handle handle, [Out] T oldObj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7072840", Offset = "0x7071240", VA = "0x187072840")]
		public void Remove(Handle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7072CF0", Offset = "0x70716F0", VA = "0x187072CF0")]
		private T TMHGMBQCLNZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x70721C0", Offset = "0x7070BC0", VA = "0x1870721C0")]
		private void KSSRCICPRRO(int a)
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
			public T MHGYPCJQMJF
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x5C043E0", Offset = "0x5C02DE0", VA = "0x185C043E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0E50", Offset = "0x2B9F850", VA = "0x182BA0E50")]
			public Enumerator(RentedArray<T> array, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5C049E0", Offset = "0x5C033E0", VA = "0x185C049E0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class YQHJHRWCBFL : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private T BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RentedArray<T> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int ZWVNFXOIPAU;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private T NZYGQNLOMZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public YQHJHRWCBFL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x50F0B10", Offset = "0x50EF510", VA = "0x1850F0B10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class SOGYIFYUQBQ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private object BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public RentedArray<T> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private int ZWVNFXOIPAU;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private object BIQZSYBZPAT
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public SOGYIFYUQBQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x50F0B10", Offset = "0x50EF510", VA = "0x1850F0B10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
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
		public int JEDXTOZKJHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x78B5350", Offset = "0x78B3D50", VA = "0x1878B5350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool OMTUQXOFEHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7965AE0", Offset = "0x79644E0", VA = "0x187965AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool LRUHMFXBSGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1A84DF0", Offset = "0x1A837F0", VA = "0x181A84DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal bool RVPTPTZFJWL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7965AD0", Offset = "0x79644D0", VA = "0x187965AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public RentedSpan<T> AQUGGENJZKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7965960", Offset = "0x7964360", VA = "0x187965960")]
			get
			{
				return default(RentedSpan<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7965EB0", Offset = "0x79648B0", VA = "0x187965EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7966010", Offset = "0x7964A10", VA = "0x187966010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7965E70", Offset = "0x7964870", VA = "0x187965E70")]
		internal RentedArray(RentedArray<T> array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7965E90", Offset = "0x7964890", VA = "0x187965E90")]
		private RentedArray(T[] array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7965B80", Offset = "0x7964580", VA = "0x187965B80")]
		public RentedArray(IEnumerable<T> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7965B10", Offset = "0x7964510", VA = "0x187965B10")]
		public RentedArray(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7965770", Offset = "0x7964170", VA = "0x187965770")]
		public int MKCMEGJCBST(T a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7965920", Offset = "0x7964320", VA = "0x187965920")]
		public void UGIIEWRRBOC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x79655A0", Offset = "0x7963FA0", VA = "0x1879655A0")]
		private void KGWUGPDTQAC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x79657F0", Offset = "0x79641F0", VA = "0x1879657F0")]
		public T[] OQLBDITQZHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7965380", Offset = "0x7963D80", VA = "0x187965380")]
		public T[] GCFCJAORPHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7965280", Offset = "0x7963C80", VA = "0x187965280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7965210", Offset = "0x7963C10", VA = "0x187965210")]
		public void DXNINAEYNRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7965530", Offset = "0x7963F30", VA = "0x187965530")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7965160", Offset = "0x7963B60", VA = "0x187965160", Slot = "5")]
		[IteratorStateMachine(typeof(RentedArray<>.YQHJHRWCBFL))]
		private IEnumerator<T> CGPFBVATFDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7965870", Offset = "0x7964270", VA = "0x187965870", Slot = "6")]
		[IteratorStateMachine(typeof(RentedArray<>.SOGYIFYUQBQ))]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x79654D0", Offset = "0x7963ED0", VA = "0x1879654D0")]
		public static RentedArray<T> GRSSYNIMLHW(T[] a)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7965F80", Offset = "0x7964980", VA = "0x187965F80")]
		public static implicit operator RentedArray<T>(T[] array)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7965300", Offset = "0x7963D00", VA = "0x187965300")]
		private void FWCSAEDVHPY(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class FWQSMQZOHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5CB0", Offset = "0x3AB46B0", VA = "0x183AB5CB0")]
		public static RentedArray<b> RSRXRTFHKVQ<b>(this IEnumerable<b> a) where b : class
		{
			return default(RentedArray<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class TTRPJPMYOCH<a> : IReadOnlyList<a>, IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>, IDisposable where a : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TTRPJPMYOCH<a> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x5C05880", Offset = "0x5C04280", VA = "0x185C05880", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public a Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x5C078D0", Offset = "0x5C062D0", VA = "0x185C078D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x5C070A0", Offset = "0x5C05AA0", VA = "0x185C070A0")]
			public Enumerator(TTRPJPMYOCH<a> list)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5C04DD0", Offset = "0x5C037D0", VA = "0x185C04DD0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4F484B0", Offset = "0x4F46EB0", VA = "0x184F484B0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private RentedArray<a> ZTAAYLQAUCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int FOSSYHYPWQS;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B59860", Offset = "0x7B58260", VA = "0x187B59860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int JEDXTOZKJHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7B59000", Offset = "0x7B57A00", VA = "0x187B59000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int MMFNGNHMKCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7B59610", Offset = "0x7B58010", VA = "0x187B59610")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool LRUHMFXBSGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7B59630", Offset = "0x7B58030", VA = "0x187B59630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public RentedSpan<a> AQUGGENJZKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7B59590", Offset = "0x7B57F90", VA = "0x187B59590")]
			get
			{
				return default(RentedSpan<a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B59770", Offset = "0x7B58170", VA = "0x187B59770")]
		public TTRPJPMYOCH(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B597F0", Offset = "0x7B581F0", VA = "0x187B597F0")]
		public TTRPJPMYOCH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B58AF0", Offset = "0x7B574F0", VA = "0x187B58AF0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B59140", Offset = "0x7B57B40", VA = "0x187B59140")]
		public RentedArray<a> TGNCJFBQTOL()
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B58560", Offset = "0x7B56F60", VA = "0x187B58560")]
		public void Add(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B59550", Offset = "0x7B57F50", VA = "0x187B59550")]
		private void UGIIEWRRBOC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7B58920", Offset = "0x7B57320", VA = "0x187B58920")]
		public void CXTOSJAUCLM(List<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7B58800", Offset = "0x7B57200", VA = "0x187B58800")]
		public void CXTOSJAUCLM(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B59050", Offset = "0x7B57A50", VA = "0x187B59050")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B58E90", Offset = "0x7B57890", VA = "0x187B58E90")]
		public void LQLUZRUGVAX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B58BC0", Offset = "0x7B575C0", VA = "0x187B58BC0")]
		public void FKZKGAGYLJN(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7B59190", Offset = "0x7B57B90", VA = "0x187B59190")]
		public void TMHGMBQCLNZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B58620", Offset = "0x7B57020", VA = "0x187B58620")]
		public void BNBLIVITZYT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7B58FD0", Offset = "0x7B579D0", VA = "0x187B58FD0")]
		public int MKCMEGJCBST(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B58B50", Offset = "0x7B57550", VA = "0x187B58B50")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7B58DB0", Offset = "0x7B577B0", VA = "0x187B58DB0")]
		public a[] GCFCJAORPHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7B58BA0", Offset = "0x7B575A0", VA = "0x187B58BA0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7B598D0", Offset = "0x7B582D0", VA = "0x187B598D0")]
		public static implicit operator RentedArray<a>(TTRPJPMYOCH<a> list)
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7B58E30", Offset = "0x7B57830", VA = "0x187B58E30", Slot = "6")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7B590D0", Offset = "0x7B57AD0", VA = "0x187B590D0", Slot = "7")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7B59360", Offset = "0x7B57D60", VA = "0x187B59360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7B59650", Offset = "0x7B58050", VA = "0x187B59650")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void ZIUHDNUIDSW(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B593C0", Offset = "0x7B57DC0", VA = "0x187B593C0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void UDEIMPASCUY(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class ZCFRXQAIENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x412BF10", Offset = "0x412A910", VA = "0x18412BF10")]
		public static void DXNINAEYNRG<c>(this TTRPJPMYOCH<c> a) where c : class
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
			[Cpp2IlInjected.Address(RVA = "0x7966350", Offset = "0x7964D50", VA = "0x187966350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x79663D0", Offset = "0x7964DD0", VA = "0x1879663D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int JEDXTOZKJHI
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7966310", Offset = "0x7964D10", VA = "0x187966310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x150EED0", Offset = "0x150D8D0", VA = "0x18150EED0")]
		public RentedSpan(Span<object> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7966120", Offset = "0x7964B20", VA = "0x187966120")]
		public RentedSpan<T> JLLLRNIDADO(int a)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x79661F0", Offset = "0x7964BF0", VA = "0x1879661F0")]
		public RentedSpan<T> JLLLRNIDADO(int a, int b)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x79660C0", Offset = "0x7964AC0", VA = "0x1879660C0")]
		public void CopyTo(RentedSpan<T> destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x79662D0", Offset = "0x7964CD0", VA = "0x1879662D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5018D80", Offset = "0x5017780", VA = "0x185018D80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "2")]
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
		public int GVPRWZNHLDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int AGNSAISSRJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x30C2C60", Offset = "0x30C1660", VA = "0x1830C2C60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x30C2C70", Offset = "0x30C1670", VA = "0x1830C2C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int GYMJYDCNRDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int ISHNKJMJOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x9869860", Offset = "0x9868260", VA = "0x189869860")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x98696D0", Offset = "0x98680D0", VA = "0x1898696D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public (int begin, int end) TSIBKDCMTRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9869800", Offset = "0x9868200", VA = "0x189869800")]
			get
			{
				return default((int, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
		private Range(int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D390", Offset = "0x2B8BD90", VA = "0x182B8D390")]
		public static Range UWSLQPSGVAA(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9869770", Offset = "0x9868170", VA = "0x189869770")]
		public static Range OKYNMGROIVV(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9869780", Offset = "0x9868180", VA = "0x189869780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x141B360", Offset = "0x1419D60", VA = "0x18141B360", Slot = "4")]
		public bool Equals(Range other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x98696E0", Offset = "0x98680E0", VA = "0x1898696E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B65100", Offset = "0x8B63B00", VA = "0x188B65100", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x150EED0", Offset = "0x150D8D0", VA = "0x18150EED0")]
		public SortIndicesByData(NativeArray<T> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A8D0", Offset = "0x7A192D0", VA = "0x187A1A8D0", Slot = "6")]
		public int Compare(int x, int y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A1AC50", Offset = "0x7A19650", VA = "0x187A1AC50", Slot = "4")]
		public bool Equals(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7A1AF40", Offset = "0x7A19940", VA = "0x187A1AF40", Slot = "5")]
		public int GetHashCode(int x)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class WTYBVNDHTCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x40FFEE0", Offset = "0x40FE8E0", VA = "0x1840FFEE0")]
		public static a[] ATDTHNMRVGA<a>(List<a> a)
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
		[Cpp2IlInjected.Address(RVA = "0x9869FA0", Offset = "0x98689A0", VA = "0x189869FA0")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class MTVLNADJIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x37D2CD0", Offset = "0x37D16D0", VA = "0x1837D2CD0")]
		public static UnsafeParallelHashMapProxy YCDVZECETIJ<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMapProxy);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x37D2CD0", Offset = "0x37D16D0", VA = "0x1837D2CD0")]
		public static UnsafeParallelHashMap<TKey, TValue> PPTNWOHFYRJ<TKey, TValue>(this UnsafeParallelHashMapProxy a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMap<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class XBUZCYGECYC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x410F6C0", Offset = "0x410E0C0", VA = "0x18410F6C0")]
		public static int IBUYCJGDTDD<a>(ReadOnlySpan<a> a, ReadOnlySpan<a> b, int c) where a : struct
		{
			return default(int);
		}
	}
}
namespace RecRoom.Foundation.Collections.Stream
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class WYJUYJHCXNS
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4101C40", Offset = "0x4100640", VA = "0x184101C40")]
		public static b DWMISJDBTWO<b>(this NativeArray<byte> a) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4101E10", Offset = "0x4100810", VA = "0x184101E10")]
		public static NativeArray<T> QSTCCTBXDQD<T>(this NativeArray<byte> a, int b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x41022A0", Offset = "0x4100CA0", VA = "0x1841022A0")]
		public static void SISZBYWUTCR<c>(this NativeList<byte> a, [In] c value) where c : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4102310", Offset = "0x4100D10", VA = "0x184102310")]
		public static void SISZBYWUTCR<T>(this NativeList<byte> a, NativeArray<T> b) where T : struct
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

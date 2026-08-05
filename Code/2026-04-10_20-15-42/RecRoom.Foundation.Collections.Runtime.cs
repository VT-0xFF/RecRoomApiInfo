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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x99FCBC0", Offset = "0x99FBBC0", VA = "0x1899FCBC0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D6F010", Offset = "0x3D6E010", VA = "0x183D6F010")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D6F780", Offset = "0x3D6E780", VA = "0x183D6F780")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D73EC0", Offset = "0x3D72EC0", VA = "0x183D73EC0")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D73060", Offset = "0x3D72060", VA = "0x183D73060")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3D733D0", Offset = "0x3D723D0", VA = "0x183D733D0")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D74590", Offset = "0x3D73590", VA = "0x183D74590")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F980", Offset = "0x3D6E980", VA = "0x183D6F980")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6FBD0", Offset = "0x3D6EBD0", VA = "0x183D6FBD0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D70E80", Offset = "0x3D6FE80", VA = "0x183D70E80")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, RecRoom.Foundation.Collections.Range range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D708F0", Offset = "0x3D6F8F0", VA = "0x183D708F0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D703B0", Offset = "0x3D6F3B0", VA = "0x183D703B0")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F090", Offset = "0x3D6E090", VA = "0x183D6F090")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D73210", Offset = "0x3D72210", VA = "0x183D73210")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D754C0", Offset = "0x3D744C0", VA = "0x183D754C0")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D76CF0", Offset = "0x3D75CF0", VA = "0x183D76CF0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D76C90", Offset = "0x3D75C90", VA = "0x183D76C90")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x659C320", Offset = "0x659B320", VA = "0x18659C320")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99FCDC0", Offset = "0x99FBDC0", VA = "0x1899FCDC0")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99FCDF0", Offset = "0x99FBDF0", VA = "0x1899FCDF0")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D75B20", Offset = "0x3D74B20", VA = "0x183D75B20")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D76C40", Offset = "0x3D75C40", VA = "0x183D76C40")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D75E40", Offset = "0x3D74E40", VA = "0x183D75E40")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D75DE0", Offset = "0x3D74DE0", VA = "0x183D75DE0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D75D80", Offset = "0x3D74D80", VA = "0x183D75D80")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D75780", Offset = "0x3D74780", VA = "0x183D75780")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D761B0", Offset = "0x3D751B0", VA = "0x183D761B0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D76000", Offset = "0x3D75000", VA = "0x183D76000")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D75880", Offset = "0x3D74880", VA = "0x183D75880")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D75690", Offset = "0x3D74690", VA = "0x183D75690")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D755E0", Offset = "0x3D745E0", VA = "0x183D755E0")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D771F0", Offset = "0x3D761F0", VA = "0x183D771F0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D76DF0", Offset = "0x3D75DF0", VA = "0x183D76DF0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D77570", Offset = "0x3D76570", VA = "0x183D77570")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D77610", Offset = "0x3D76610", VA = "0x183D77610")]
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
			[Cpp2IlInjected.Address(RVA = "0x653D660", Offset = "0x653C660", VA = "0x18653D660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xF1C290", Offset = "0xF1B290", VA = "0x180F1C290")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x12D4C20", Offset = "0x12D3C20", VA = "0x1812D4C20")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6382CB0", Offset = "0x6381CB0", VA = "0x186382CB0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7283430", Offset = "0x7282430", VA = "0x187283430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7283770", Offset = "0x7282770", VA = "0x187283770")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3A03C30", Offset = "0x3A02C30", VA = "0x183A03C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x7330110", Offset = "0x732F110", VA = "0x187330110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7330140", Offset = "0x732F140", VA = "0x187330140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2D9CEC0", Offset = "0x2D9BEC0", VA = "0x182D9CEC0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NativeList<T> List
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(NativeList<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6939580", Offset = "0x6938580", VA = "0x186939580")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x732F660", Offset = "0x732E660", VA = "0x18732F660")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x732F930", Offset = "0x732E930", VA = "0x18732F930")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x732FFC0", Offset = "0x732EFC0", VA = "0x18732FFC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x732FE00", Offset = "0x732EE00", VA = "0x18732FE00")]
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
	public static class YDWHUTIEHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99FE750", Offset = "0x99FD750", VA = "0x1899FE750")]
		public static JobHandle IDXNGAPTSJS(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99FE790", Offset = "0x99FD790", VA = "0x1899FE790")]
		public static JobHandle JHBDBFOELAN(this Span<JobHandle> a)
		{
			return default(JobHandle);
		}
	}
}
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class OZMWYSEWRIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3686690", Offset = "0x3685690", VA = "0x183686690")]
		public static void Clear<T>(this T[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class MWOCQOKNKSK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D500", Offset = "0x3C3C500", VA = "0x183C3D500")]
		public static NativeKeyValueArrays<TKey, TValue> RMWDMYRRIQK<TKey, TValue>(this Dictionary<TKey, TValue> a, Allocator b) where TKey : struct where TValue : struct
		{
			return default(NativeKeyValueArrays<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class VVBWZNVPCEX
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99FE630", Offset = "0x99FD630", VA = "0x1899FE630")]
		public static void STVWISPVRJX(this GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99FE570", Offset = "0x99FD570", VA = "0x1899FE570")]
		public static void STVWISPVRJX(this Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99FE4B0", Offset = "0x99FD4B0", VA = "0x1899FE4B0")]
		public static void STVWISPVRJX(this ScriptableObject a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GKVSEETJCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99FCB50", Offset = "0x99FBB50", VA = "0x1899FCB50")]
		public static void XAMNTPPYGQQ(this NativeList<byte> a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF630", Offset = "0x3AEE630", VA = "0x183AEF630")]
		public static void IZBDMGBTOJM<T>(this NativeList<T> a, T b, int c) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class SYIFEHPAZAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3F22100", Offset = "0x3F21100", VA = "0x183F22100")]
		public static d CLKORIBWNYL<d>(this ReadOnlySpan<byte> a) where d : struct
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3F227C0", Offset = "0x3F217C0", VA = "0x183F227C0")]
		public static k ENPMZMGSUAE<k>(this Span<k> a, Func<k, bool> b)
		{
			return (k)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3F21E10", Offset = "0x3F20E10", VA = "0x183F21E10")]
		public static bool All<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3F22060", Offset = "0x3F21060", VA = "0x183F22060")]
		public static bool Any<T>(this Span<T> span, Func<T, bool> predicate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3F23070", Offset = "0x3F22070", VA = "0x183F23070")]
		public static T Get<T>([In] this ReadOnlySpan<byte> span) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3F22F30", Offset = "0x3F21F30", VA = "0x183F22F30")]
		public static Span<q> FYSIZBSZAST<q, p>(this Span<p> a) where q : struct where p : struct
		{
			return default(Span<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F22A50", Offset = "0x3F21A50", VA = "0x183F22A50")]
		public static ReadOnlySpan<s> FYSIZBSZAST<s, r>(this ReadOnlySpan<r> a) where s : struct where r : struct
		{
			return default(ReadOnlySpan<s>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F22E80", Offset = "0x3F21E80", VA = "0x183F22E80")]
		public static ReadOnlySpan<t> FYSIZBSZAST<t>(this ReadOnlySpan<byte> a) where t : struct
		{
			return default(ReadOnlySpan<t>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3F223C0", Offset = "0x3F213C0", VA = "0x183F223C0")]
		public static Span<T> Clone<T>(this ReadOnlySpan<T> src) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3F233C0", Offset = "0x3F223C0", VA = "0x183F233C0")]
		public static Span<byte> Set<T>([In] this Span<byte> span, T value) where T : struct
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99FDD00", Offset = "0x99FCD00", VA = "0x1899FDD00")]
		private static Enum WEXLGKDPQWP([In] ReadOnlySpan<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99FE290", Offset = "0x99FD290", VA = "0x1899FE290")]
		public static Enum XQFVNRTHHPP([In] this Span<byte> span, Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99FD860", Offset = "0x99FC860", VA = "0x1899FD860")]
		public static void GHOQKDRILRX([In] this Span<byte> span, Enum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZTNXOWONUFB
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
			[Cpp2IlInjected.Address(RVA = "0x99FE300", Offset = "0x99FD300", VA = "0x1899FE300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD6E050", Offset = "0xD6D050", VA = "0x180D6E050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99FE840", Offset = "0x99FD840", VA = "0x1899FE840")]
		[AsyncStateMachine(typeof(<TrapExceptions>d__1))]
		public static void PWNMSWUEFER(this Task a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class WHTHDNRRTSA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x411AF10", Offset = "0x4119F10", VA = "0x18411AF10")]
		public static NativeArray<T> STOVZOKOOTT<T>(this UnsafeList<T> a) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x411AE20", Offset = "0x4119E20", VA = "0x18411AE20")]
		public static NativeArray<T> HTEPZYULQJE<T>(this UnsafeList<T> a, bool b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x411ACF0", Offset = "0x4119CF0", VA = "0x18411ACF0")]
		public static UnsafeList<T> Clone<T>(this UnsafeList<T> list, Allocator allocator) where T : struct
		{
			return default(UnsafeList<T>);
		}
	}
}
namespace RecRoom.Foundation.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class NDCYSYWGRKX
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
			[Cpp2IlInjected.Address(RVA = "0x329FA90", Offset = "0x329EA90", VA = "0x18329FA90")]
			public Scope(Key key)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static ProfilerCategory BNGFGCSOOBW;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99FCD50", Offset = "0x99FBD50", VA = "0x1899FCD50")]
		static NDCYSYWGRKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x36A82A0", Offset = "0x36A72A0", VA = "0x1836A82A0")]
		public static Scope TZRMGOAOTYR(Key a)
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		public static void NRUGLQNWOBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class XHJMLEVXKJU
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x413F460", Offset = "0x413E460", VA = "0x18413F460")]
		public static DisposableTuple<a, b> GLXCIKTITVE<a, b>(this (a, b) a) where a : struct, IDisposable where b : struct, IDisposable
		{
			return default(DisposableTuple<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x413F4A0", Offset = "0x413E4A0", VA = "0x18413F4A0")]
		public static DisposableTuple<c, d, e> GLXCIKTITVE<c, d, e>(this (c, d, e) a) where c : struct, IDisposable where d : struct, IDisposable where e : struct, IDisposable
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
		[Cpp2IlInjected.Address(RVA = "0x2DB3990", Offset = "0x2DB2990", VA = "0x182DB3990")]
		public DisposableTuple((T1, T2) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5BA4660", Offset = "0x5BA3660", VA = "0x185BA4660", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BA49C0", Offset = "0x5BA39C0", VA = "0x185BA49C0")]
		public DisposableTuple((T1, T2, T3) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5BA4DC0", Offset = "0x5BA3DC0", VA = "0x185BA4DC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class WPPEXVXYSVX
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99FE6F0", Offset = "0x99FD6F0", VA = "0x1899FE6F0")]
		public static System.Range NZGQKTTVVNQ(this Range a)
		{
			return default(System.Range);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class QOQUNVVRLEP
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
			public int LYYKBIYSXZP
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0xF6CF10", Offset = "0xF6BF10", VA = "0x180F6CF10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x99FCB40", Offset = "0x99FBB40", VA = "0x1899FCB40")]
			public Enumerator(int start, int end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x99FCB30", Offset = "0x99FBB30", VA = "0x1899FCB30")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99FD2C0", Offset = "0x99FC2C0", VA = "0x1899FD2C0")]
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
		public bool IWFXVTWKEQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2E07820", Offset = "0x2E06820", VA = "0x182E07820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x659C490", Offset = "0x659B490", VA = "0x18659C490")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x659C850", Offset = "0x659B850", VA = "0x18659C850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x659D060", Offset = "0x659C060", VA = "0x18659D060")]
		public Handle(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x659C320", Offset = "0x659B320", VA = "0x18659C320", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class NKWNEKKDFNZ<a, b> : IDisposable where a : struct, QLTKPKJZZYR where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly List<a> ZDDBNHZLOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly List<b> OQIWLEHREZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Func<b> AFHZXGHDYOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<b> GRRXRVNYHQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int IFFFWUDVOTS;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public b this[a handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7261170", Offset = "0x7260170", VA = "0x187261170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7260BB0", Offset = "0x725FBB0", VA = "0x187260BB0")]
		public NKWNEKKDFNZ(Action<b> a, [Optional] Func<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x725E870", Offset = "0x725D870", VA = "0x18725E870", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x725E2D0", Offset = "0x725D2D0", VA = "0x18725E2D0")]
		public a Add(b value)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x725E530", Offset = "0x725D530", VA = "0x18725E530")]
		public bool Destroy(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x725FF30", Offset = "0x725EF30", VA = "0x18725FF30")]
		public bool PXXJOAVVPYH(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x725F000", Offset = "0x725E000", VA = "0x18725F000")]
		public b Get(a handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x725EA50", Offset = "0x725DA50", VA = "0x18725EA50")]
		public bool Exists(a handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x725E2A0", Offset = "0x725D2A0", VA = "0x18725E2A0")]
		private a AAGDMOXIOQK(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x725EFD0", Offset = "0x725DFD0", VA = "0x18725EFD0")]
		private b GNZHNXANGJL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x725F870", Offset = "0x725E870", VA = "0x18725F870")]
		private void LUBMLNTRFVI(int a, [In] a handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x725F750", Offset = "0x725E750", VA = "0x18725F750")]
		private void LELFZVOHOWV(int a, [In] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72604A0", Offset = "0x725F4A0", VA = "0x1872604A0")]
		private a VSTILUKUEON()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7260B10", Offset = "0x725FB10", VA = "0x187260B10")]
		private void ZBKJIBJKHBA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x725FD70", Offset = "0x725ED70", VA = "0x18725FD70")]
		private int PNBPOYJBKAH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x725F990", Offset = "0x725E990", VA = "0x18725F990")]
		private bool MTTOAHDYOKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD16060", Offset = "0xD15060", VA = "0x180D16060")]
		private void LGDQJSRNBUA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x725FBB0", Offset = "0x725EBB0", VA = "0x18725FBB0")]
		private bool OQEMHVVRLXR([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x725F110", Offset = "0x725E110", VA = "0x18725F110")]
		private bool IEAHKYEFJVO([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x725FAC0", Offset = "0x725EAC0", VA = "0x18725FAC0")]
		private void OAOATQAOZWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface QLTKPKJZZYR
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
	public static class ASFCKFALYIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x337D8A0", Offset = "0x337C8A0", VA = "0x18337D8A0")]
		public static bool CYOYFTZKSMD<a>(this a a, a b) where a : struct, QLTKPKJZZYR
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x337D9C0", Offset = "0x337C9C0", VA = "0x18337D9C0")]
		public static bool IsValid<T>(this T handle) where T : struct, QLTKPKJZZYR
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x99FC5E0", Offset = "0x99FB5E0", VA = "0x1899FC5E0")]
		public static string YYOLTQKYRXI(this QLTKPKJZZYR a)
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
		[Cpp2IlInjected.Address(RVA = "0x6939580", Offset = "0x6938580", VA = "0x186939580")]
		public MutableRef(Type valueType, Span<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A530", Offset = "0x3D39530", VA = "0x183D3A530")]
		public static MutableRef From<T>(T value) where T : struct
		{
			return default(MutableRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x99FCCD0", Offset = "0x99FBCD0", VA = "0x1899FCCD0")]
		public static implicit operator ReadOnlyRef([In] MutableRef r)
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x99FCC50", Offset = "0x99FBC50", VA = "0x1899FCC50")]
		public Enum XQFVNRTHHPP(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3ABC0", Offset = "0x3D39BC0", VA = "0x183D3ABC0")]
		public void Set<T>([In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x99FCC40", Offset = "0x99FBC40", VA = "0x1899FCC40")]
		public void GHOQKDRILRX(Enum a)
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
		public int BABOAUSTHFD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x99FD850", Offset = "0x99FC850", VA = "0x1899FD850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int ONHFOACNAZV
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x99FD680", Offset = "0x99FC680", VA = "0x1899FD680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6939580", Offset = "0x6938580", VA = "0x186939580")]
		public ReadOnlyRef(Type valueType, ReadOnlySpan<byte> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2710", Offset = "0x3EF1710", VA = "0x183EF2710")]
		public static ReadOnlyRef From<T>(T value) where T : struct
		{
			return default(ReadOnlyRef);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99FD6D0", Offset = "0x99FC6D0", VA = "0x1899FD6D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x99FD4B0", Offset = "0x99FC4B0", VA = "0x1899FD4B0")]
		public object HEFEMNSJRDM(int a = 0)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct NativeElement
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3D77DE0", Offset = "0x3D76DE0", VA = "0x183D77DE0")]
		public static NativeArray<T> From<T>(T value, bool isReadOnly) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3D77F20", Offset = "0x3D76F20", VA = "0x183D77F20")]
		public static NativeArray<a> NASTYCRWXBN<a>(a a) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3D77F20", Offset = "0x3D76F20", VA = "0x183D77F20")]
		public static NativeArray<b> MZCQUAORZOT<b>(b a) where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x99FCF50", Offset = "0x99FBF50", VA = "0x1899FCF50")]
		public static NativeArray<byte> MZCQUAORZOT(ReadOnlySpan<byte> a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x99FCEA0", Offset = "0x99FBEA0", VA = "0x1899FCEA0")]
		public static NativeArray<byte> From(ReadOnlySpan<byte> value, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x99FCE20", Offset = "0x99FBE20", VA = "0x1899FCE20")]
		public unsafe static NativeArray<byte> From(byte* ptr, int length, bool isReadOnly)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3D77CD0", Offset = "0x3D76CD0", VA = "0x183D77CD0")]
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
		public Type XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x99FD0A0", Offset = "0x99FC0A0", VA = "0x1899FD0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x99FD190", Offset = "0x99FC190", VA = "0x1899FD190")]
		public NativeTypeHandle(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x99FD230", Offset = "0x99FC230", VA = "0x1899FD230")]
		public static implicit operator NativeTypeHandle(Type type)
		{
			return default(NativeTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x239D930", Offset = "0x239C930", VA = "0x18239D930", Slot = "4")]
		public bool Equals(NativeTypeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x99FD010", Offset = "0x99FC010", VA = "0x1899FD010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xF6CF10", Offset = "0xF6BF10", VA = "0x180F6CF10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x99FD150", Offset = "0x99FC150", VA = "0x1899FD150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class BMAABOGJHBO
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static Dictionary<Type, int> SDRDEAPHPOH;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<Type> YZEKRLWYNMR;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x99FC9D0", Offset = "0x99FB9D0", VA = "0x1899FC9D0")]
		static BMAABOGJHBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x99FC6E0", Offset = "0x99FB6E0", VA = "0x1899FC6E0")]
		public static bool Add(Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x99FC740", Offset = "0x99FB740", VA = "0x1899FC740")]
		private static bool Add(Type type, [Out] int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x99FC8F0", Offset = "0x99FB8F0", VA = "0x1899FC8F0")]
		public static int GSIAUGCYMBO(Type a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x99FC950", Offset = "0x99FB950", VA = "0x1899FC950")]
		public static Type Get(int index)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct HandlePool<Handle> where Handle : QLTKPKJZZYR, new()
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
			public Handle WVGKYYHGIWX
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x50846C0", Offset = "0x50836C0", VA = "0x1850846C0")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x5084DE0", Offset = "0x5083DE0", VA = "0x185084DE0")]
			public BaseIndexEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5084C70", Offset = "0x5083C70", VA = "0x185084C70")]
			public LiveHandleEnumerator New([In] LiveHandleEnumerator _)
			{
				return default(LiveHandleEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5084B70", Offset = "0x5083B70", VA = "0x185084B70")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x5084CF0", Offset = "0x5083CF0", VA = "0x185084CF0")]
			private Handle TODMPGFGVLL(string a)
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
			public Handle LYYKBIYSXZP
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x6FAEF90", Offset = "0x6FADF90", VA = "0x186FAEF90")]
				get
				{
					return (Handle)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6FAEFD0", Offset = "0x6FADFD0", VA = "0x186FAEFD0")]
			public LiveHandleEnumerator(HandlePool<Handle> pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6FAEE60", Offset = "0x6FADE60", VA = "0x186FAEE60")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6FAEDF0", Offset = "0x6FADDF0", VA = "0x186FAEDF0")]
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
		public int IYQTFMJRTNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x659C0E0", Offset = "0x659B0E0", VA = "0x18659C0E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LiveHandleEnumerator CJZPOQQHZMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x659B810", Offset = "0x659A810", VA = "0x18659B810")]
			get
			{
				return default(LiveHandleEnumerator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x659C250", Offset = "0x659B250", VA = "0x18659C250")]
		public HandlePool(int initialCapacity, Allocator allocator = Allocator.Persistent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x659A110", Offset = "0x6599110", VA = "0x18659A110")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x25F4450", Offset = "0x25F3450", VA = "0x1825F4450")]
		public static int PNBPOYJBKAH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x32AEF80", Offset = "0x32ADF80", VA = "0x1832AEF80")]
		public static bool UUKITDRGSUG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x659BDE0", Offset = "0x659ADE0", VA = "0x18659BDE0")]
		public bool XOFLKGKEWLI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x659AD90", Offset = "0x6599D90", VA = "0x18659AD90")]
		public bool MPWMAIGFKSQ(Handle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x659AED0", Offset = "0x6599ED0", VA = "0x18659AED0")]
		public Handle OAOLHSMXBUG()
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x659B530", Offset = "0x659A530", VA = "0x18659B530")]
		public void OFIWWJIZCJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x659C070", Offset = "0x659B070", VA = "0x18659C070")]
		public void XZNUQPTUQHV(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620")]
		private bool LPKNUVJNKGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x659A720", Offset = "0x6599720", VA = "0x18659A720")]
		private bool LFZWZPJQRPW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x659BA60", Offset = "0x659AA60", VA = "0x18659BA60")]
		private void WYRDRSNYWAV([Out] int a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x659A600", Offset = "0x6599600", VA = "0x18659A600")]
		private void IOSHGHTTXAT(Handle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x659BBD0", Offset = "0x659ABD0", VA = "0x18659BBD0")]
		private void XBCAWAJQSFU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6599E40", Offset = "0x6598E40", VA = "0x186599E40")]
		private bool CTIIHELCQDA([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6599DC0", Offset = "0x6598DC0", VA = "0x186599DC0")]
		private static Handle BEYZOAMTLQE(int a, int b)
		{
			return (Handle)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DefaultMember("Item")]
	public struct ManagedObjectPool<Handle, T> where Handle : QLTKPKJZZYR, new() where T : class
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
		[Cpp2IlInjected.Address(RVA = "0x7070C20", Offset = "0x706FC20", VA = "0x187070C20")]
		public ManagedObjectPool(int initialCapacity, [Optional] Action<T> onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x706FCC0", Offset = "0x706ECC0", VA = "0x18706FCC0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7070310", Offset = "0x706F310", VA = "0x187070310")]
		public bool PXXJOAVVPYH(Handle a, [Out] T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x706FA70", Offset = "0x706EA70", VA = "0x18706FA70")]
		public Handle Add(T obj)
		{
			return (Handle)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x706FD40", Offset = "0x706ED40", VA = "0x18706FD40")]
		public void GWARAUJNDTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7070650", Offset = "0x706F650", VA = "0x187070650")]
		public void Remove(Handle handle, [Out] T oldObj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7070730", Offset = "0x706F730", VA = "0x187070730")]
		public void Remove(Handle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x70702B0", Offset = "0x706F2B0", VA = "0x1870702B0")]
		private T PWQUCYFMOWJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x706FB80", Offset = "0x706EB80", VA = "0x18706FB80")]
		private void BOYVYBEOXUG(int a)
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
			public T LYYKBIYSXZP
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x5C3A8C0", Offset = "0x5C398C0", VA = "0x185C3A8C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2BB3B10", Offset = "0x2BB2B10", VA = "0x182BB3B10")]
			public Enumerator(RentedArray<T> array, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5C37930", Offset = "0x5C36930", VA = "0x185C37930")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class RCLYMPHZVTB : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private T PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RentedArray<T> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int LPBUJELINTU;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private T AREJNBRCORV
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public RCLYMPHZVTB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7504430", Offset = "0x7503430", VA = "0x187504430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class POXXEIZEQLG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public RentedArray<T> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private int LPBUJELINTU;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public POXXEIZEQLG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7504430", Offset = "0x7503430", VA = "0x187504430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
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
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7944510", Offset = "0x7943510", VA = "0x187944510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ZTVEKVOKXHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x79EF940", Offset = "0x79EE940", VA = "0x1879EF940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool PSZZBSHCGGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1AAD840", Offset = "0x1AAC840", VA = "0x181AAD840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal bool LVRYMTYTCMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x79EF970", Offset = "0x79EE970", VA = "0x1879EF970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public RentedSpan<T> SPGTQZNHBFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x79EFCB0", Offset = "0x79EECB0", VA = "0x1879EFCB0")]
			get
			{
				return default(RentedSpan<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x79F01E0", Offset = "0x79EF1E0", VA = "0x1879F01E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x79F0340", Offset = "0x79EF340", VA = "0x1879F0340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x79F01A0", Offset = "0x79EF1A0", VA = "0x1879F01A0")]
		internal RentedArray(RentedArray<T> array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x79F01C0", Offset = "0x79EF1C0", VA = "0x1879F01C0")]
		private RentedArray(T[] array, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x79EFEA0", Offset = "0x79EEEA0", VA = "0x1879EFEA0")]
		public RentedArray(IEnumerable<T> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x79EFE30", Offset = "0x79EEE30", VA = "0x1879EFE30")]
		public RentedArray(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x79EFC30", Offset = "0x79EEC30", VA = "0x1879EFC30")]
		public int UZIXKKPPECR(T a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x79EFBE0", Offset = "0x79EEBE0", VA = "0x1879EFBE0")]
		public void TOGLCTJEZLG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x79EF5D0", Offset = "0x79EE5D0", VA = "0x1879EF5D0")]
		private void EPDINMSSLZO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x79EFB60", Offset = "0x79EEB60", VA = "0x1879EFB60")]
		public T[] TIRUJKDLPAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x79EF980", Offset = "0x79EE980", VA = "0x1879EF980")]
		public T[] PEQGZCFKKEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x79EF4F0", Offset = "0x79EE4F0", VA = "0x1879EF4F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x79EF7A0", Offset = "0x79EE7A0", VA = "0x1879EF7A0")]
		public void FEHVEIVPPXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x79EF810", Offset = "0x79EE810", VA = "0x1879EF810")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x79EF430", Offset = "0x79EE430", VA = "0x1879EF430", Slot = "5")]
		[IteratorStateMachine(typeof(RentedArray<>.RCLYMPHZVTB))]
		private IEnumerator<T> CTAZIZCYNRG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x79EF880", Offset = "0x79EE880", VA = "0x1879EF880", Slot = "6")]
		[IteratorStateMachine(typeof(RentedArray<>.POXXEIZEQLG))]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x79EF570", Offset = "0x79EE570", VA = "0x1879EF570")]
		public static RentedArray<T> EKONIUQWPXE(T[] a)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x79F02B0", Offset = "0x79EF2B0", VA = "0x1879F02B0")]
		public static implicit operator RentedArray<T>(T[] array)
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x79EFAE0", Offset = "0x79EEAE0", VA = "0x1879EFAE0")]
		private void SEYXEXFCRGA(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class YBSBMCLKIQV
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4149A10", Offset = "0x4148A10", VA = "0x184149A10")]
		public static RentedArray<b> HCNWCACWXUA<b>(this IEnumerable<b> a) where b : class
		{
			return default(RentedArray<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class WRLHKUPPYHT<a> : IReadOnlyList<a>, IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>, IDisposable where a : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private WRLHKUPPYHT<a> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x5C36ED0", Offset = "0x5C35ED0", VA = "0x185C36ED0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public a Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x5C3BBB0", Offset = "0x5C3ABB0", VA = "0x185C3BBB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x5C3AD60", Offset = "0x5C39D60", VA = "0x185C3AD60")]
			public Enumerator(WRLHKUPPYHT<a> list)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5C38210", Offset = "0x5C37210", VA = "0x185C38210", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x503CB50", Offset = "0x503BB50", VA = "0x18503CB50", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private RentedArray<a> GEHCEZHJWAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int LHMPAKHADNO;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x87760C0", Offset = "0x87750C0", VA = "0x1887760C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x87758D0", Offset = "0x87748D0", VA = "0x1887758D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int IYQTFMJRTNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8775FA0", Offset = "0x8774FA0", VA = "0x188775FA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PSZZBSHCGGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8774F90", Offset = "0x8773F90", VA = "0x188774F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public RentedSpan<a> SPGTQZNHBFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8775C40", Offset = "0x8774C40", VA = "0x188775C40")]
			get
			{
				return default(RentedSpan<a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8775FC0", Offset = "0x8774FC0", VA = "0x188775FC0")]
		public WRLHKUPPYHT(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8776050", Offset = "0x8775050", VA = "0x188776050")]
		public WRLHKUPPYHT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8774DE0", Offset = "0x8773DE0", VA = "0x188774DE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8775530", Offset = "0x8774530", VA = "0x188775530")]
		public RentedArray<a> QSFRYGVNZZX()
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8774D10", Offset = "0x8773D10", VA = "0x188774D10")]
		public void Add(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8775800", Offset = "0x8774800", VA = "0x188775800")]
		private void TOGLCTJEZLG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8775920", Offset = "0x8774920", VA = "0x188775920")]
		public void XAMNTPPYGQQ(List<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8775B10", Offset = "0x8774B10", VA = "0x188775B10")]
		public void XAMNTPPYGQQ(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8775770", Offset = "0x8774770", VA = "0x188775770")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8775E60", Offset = "0x8774E60", VA = "0x188775E60")]
		public void ZKRVIAEFVNX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8775330", Offset = "0x8774330", VA = "0x188775330")]
		public void QBHEBUKKPSV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8775030", Offset = "0x8774030", VA = "0x188775030")]
		public void PWQUCYFMOWJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8775580", Offset = "0x8774580", VA = "0x188775580")]
		public void RRNQLSNKYGB(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x87758A0", Offset = "0x87748A0", VA = "0x1887758A0")]
		public int UZIXKKPPECR(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8774E40", Offset = "0x8773E40", VA = "0x188774E40")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8774FB0", Offset = "0x8773FB0", VA = "0x188774FB0")]
		public a[] PEQGZCFKKEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8774E90", Offset = "0x8773E90", VA = "0x188774E90", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8776130", Offset = "0x8775130", VA = "0x188776130")]
		public static implicit operator RentedArray<a>(WRLHKUPPYHT<a> list)
		{
			return default(RentedArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8774EC0", Offset = "0x8773EC0", VA = "0x188774EC0", Slot = "6")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8774F20", Offset = "0x8773F20", VA = "0x188774F20", Slot = "7")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8775840", Offset = "0x8774840", VA = "0x188775840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8775210", Offset = "0x8774210", VA = "0x188775210")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void PYQDVOMJVNC(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8775CD0", Offset = "0x8774CD0", VA = "0x188775CD0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void YBQRTUYKRMG(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class UVCNPVACYZC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x40B0660", Offset = "0x40AF660", VA = "0x1840B0660")]
		public static void FEHVEIVPPXE<c>(this WRLHKUPPYHT<c> a) where c : class
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
			[Cpp2IlInjected.Address(RVA = "0x79F0680", Offset = "0x79EF680", VA = "0x1879F0680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x79F0710", Offset = "0x79EF710", VA = "0x1879F0710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x79F0640", Offset = "0x79EF640", VA = "0x1879F0640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1546720", Offset = "0x1545720", VA = "0x181546720")]
		public RentedSpan(Span<object> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x79F04D0", Offset = "0x79EF4D0", VA = "0x1879F04D0")]
		public RentedSpan<T> ASFSATLORTQ(int a)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x79F03F0", Offset = "0x79EF3F0", VA = "0x1879F03F0")]
		public RentedSpan<T> ASFSATLORTQ(int a, int b)
		{
			return default(RentedSpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x79F05A0", Offset = "0x79EF5A0", VA = "0x1879F05A0")]
		public void CopyTo(RentedSpan<T> destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x79F0600", Offset = "0x79EF600", VA = "0x1879F0600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5107710", Offset = "0x5106710", VA = "0x185107710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "2")]
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
		public int RFBIZEQGAWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xF6CF10", Offset = "0xF6BF10", VA = "0x180F6CF10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x30D4A70", Offset = "0x30D3A70", VA = "0x1830D4A70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x30D4A80", Offset = "0x30D3A80", VA = "0x1830D4A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int SIUHUEYRRON
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xF6CF10", Offset = "0xF6BF10", VA = "0x180F6CF10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int CLJSAMBXECZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x99FD4A0", Offset = "0x99FC4A0", VA = "0x1899FD4A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x99FD3B0", Offset = "0x99FC3B0", VA = "0x1899FD3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public (int begin, int end) DSABMPRZNXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x99FD3C0", Offset = "0x99FC3C0", VA = "0x1899FD3C0")]
			get
			{
				return default((int, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
		private Range(int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0B00", Offset = "0x2B9FB00", VA = "0x182BA0B00")]
		public static Range SPQJEQGGXCS(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x99FD3A0", Offset = "0x99FC3A0", VA = "0x1899FD3A0")]
		public static Range FQHORFGHVDH(int a, int b)
		{
			return default(Range);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x99FD420", Offset = "0x99FC420", VA = "0x1899FD420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1449E30", Offset = "0x1448E30", VA = "0x181449E30", Slot = "4")]
		public bool Equals(Range other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x99FD310", Offset = "0x99FC310", VA = "0x1899FD310", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8D0E3A0", Offset = "0x8D0D3A0", VA = "0x188D0E3A0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x1546720", Offset = "0x1545720", VA = "0x181546720")]
		public SortIndicesByData(NativeArray<T> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD370", Offset = "0x7ACC370", VA = "0x187ACD370", Slot = "6")]
		public int Compare(int x, int y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD700", Offset = "0x7ACC700", VA = "0x187ACD700", Slot = "4")]
		public bool Equals(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDA00", Offset = "0x7ACCA00", VA = "0x187ACDA00", Slot = "5")]
		public int GetHashCode(int x)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class IOSOIPYJQPU
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3B60810", Offset = "0x3B5F810", VA = "0x183B60810")]
		public static a[] LPYHIBWIRSS<a>(List<a> a)
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
		[Cpp2IlInjected.Address(RVA = "0x99FE480", Offset = "0x99FD480", VA = "0x1899FE480")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class IELYABKLRGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x37ED650", Offset = "0x37EC650", VA = "0x1837ED650")]
		public static UnsafeParallelHashMapProxy LJAKUBVUDVB<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMapProxy);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x37ED650", Offset = "0x37EC650", VA = "0x1837ED650")]
		public static UnsafeParallelHashMap<TKey, TValue> IUCRAHBIJQN<TKey, TValue>(this UnsafeParallelHashMapProxy a) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
			return default(UnsafeParallelHashMap<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class ONPODNOBXWI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3D9A4C0", Offset = "0x3D994C0", VA = "0x183D9A4C0")]
		public static int QTTNSRBZLHZ<a>(ReadOnlySpan<a> a, ReadOnlySpan<a> b, int c) where a : struct
		{
			return default(int);
		}
	}
}
namespace RecRoom.Foundation.Collections.Stream
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class PHFJEKEIRQG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6B80", Offset = "0x3DA5B80", VA = "0x183DA6B80")]
		public static b LYKZYHORDOU<b>(this NativeArray<byte> a) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6770", Offset = "0x3DA5770", VA = "0x183DA6770")]
		public static NativeArray<T> BLYRCTESPYN<T>(this NativeArray<byte> a, int b) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6D40", Offset = "0x3DA5D40", VA = "0x183DA6D40")]
		public static void SQIRBZBNMTZ<c>(this NativeList<byte> a, [In] c value) where c : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6DB0", Offset = "0x3DA5DB0", VA = "0x183DA6DB0")]
		public static void SQIRBZBNMTZ<T>(this NativeList<byte> a, NativeArray<T> b) where T : struct
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

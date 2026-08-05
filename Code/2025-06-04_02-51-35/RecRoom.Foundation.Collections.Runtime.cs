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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EB10", Offset = "0x7F9D310", VA = "0x187F9EB10", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[BBCMHIHLIOF]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3B504D0", Offset = "0x3B4ECD0", VA = "0x183B504D0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[BBCMHIHLIOF]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B517F0", Offset = "0x3B4FFF0", VA = "0x183B517F0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3B506D0", Offset = "0x3B4EED0", VA = "0x183B506D0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3B50850", Offset = "0x3B4F050", VA = "0x183B50850")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3B57580", Offset = "0x3B55D80", VA = "0x183B57580")]
		public static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B57290", Offset = "0x3B55A90", VA = "0x183B57290")]
		public static int MemCmp<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3B57440", Offset = "0x3B55C40", VA = "0x183B57440")]
		public static NativeArray<T> ToNativeArray<T>(this NativeList<T> list, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B57C00", Offset = "0x3B56400", VA = "0x183B57C00")]
		public static NativeArray<T> ToTempNativeArray<T>(this NativeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B51DF0", Offset = "0x3B505F0", VA = "0x183B51DF0")]
		public static NativeList<T> Clone<T>(this NativeList<T> array, Allocator allocator) where T : struct
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B51FB0", Offset = "0x3B507B0", VA = "0x183B51FB0")]
		public static NativeArray<T> Clone<T>(this NativeArray<T> array, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B523E0", Offset = "0x3B50BE0", VA = "0x183B523E0")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, OFIADOPPLCJ range) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B52420", Offset = "0x3B50C20", VA = "0x183B52420")]
		public static NativeArray<T> GetSubArray<T>(this NativeArray<T> array, int start) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3B52250", Offset = "0x3B50A50", VA = "0x183B52250")]
		public static void EnqueueRange<T>(this NativeQueue<T> queue, NativeArray<T> array) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B50520", Offset = "0x3B4ED20", VA = "0x183B50520")]
		public static void AddRange<T>(this NativeList<T> list, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B57380", Offset = "0x3B55B80", VA = "0x183B57380")]
		public static (NativeArray<T>, NativeArray<T>) Partition<T>(this NativeArray<T> array, int count) where T : struct
		{
			return default((NativeArray<T>, NativeArray<T>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[BBCMHIHLIOF]
	public static class NativeContainerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B5BD10", Offset = "0x3B5A510", VA = "0x183B5BD10")]
		public static ReadOnlySpan<byte> AsReadOnlySpan<T>(this T value) where T : struct
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DBC0", Offset = "0x3B5C3C0", VA = "0x183B5DBC0")]
		public static int SafeLength<T>(this NativeArray<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DB70", Offset = "0x3B5C370", VA = "0x183B5DB70")]
		public static int SafeLength<T>(this NativeList<T> value) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51AEFC0", Offset = "0x51AD7C0", VA = "0x1851AEFC0")]
		public static void SafeDispose(this GCHandle value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F9ED20", Offset = "0x7F9D520", VA = "0x187F9ED20")]
		public static void SafeDispose(this TransformAccessArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F9ED50", Offset = "0x7F9D550", VA = "0x187F9ED50")]
		public static void SafeDispose(this NativeBitArray value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D1A0", Offset = "0x3B5B9A0", VA = "0x183B5D1A0")]
		public static void SafeDispose<T>(this NativeArray<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B5CFB0", Offset = "0x3B5B7B0", VA = "0x183B5CFB0")]
		public static void SafeDispose<T>(this NativeList<T> value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D270", Offset = "0x3B5BA70", VA = "0x183B5D270")]
		public static void SafeDispose<T>(this NativeParallelHashSet<T> value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D1D0", Offset = "0x3B5B9D0", VA = "0x183B5D1D0")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D220", Offset = "0x3B5BA20", VA = "0x183B5D220")]
		public static void SafeDispose<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> value) where TKey : struct, IEquatable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D100", Offset = "0x3B5B900", VA = "0x183B5D100")]
		public static JobHandle SafeDispose<T>(this NativeArrayAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D5C0", Offset = "0x3B5BDC0", VA = "0x183B5D5C0")]
		public static JobHandle SafeDispose<T>(this NativeListAsync<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D420", Offset = "0x3B5BC20", VA = "0x183B5D420")]
		public static JobHandle SafeDispose<T>(this NativeArray<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B5D000", Offset = "0x3B5B800", VA = "0x183B5D000")]
		public static JobHandle SafeDispose<T>(this NativeList<T> value, JobHandle dependsOn) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3B5CF50", Offset = "0x3B5B750", VA = "0x183B5CF50")]
		public static NativeArray<T> SafeAsArray<T>(this NativeList<T> value) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3B5CF30", Offset = "0x3B5B730", VA = "0x183B5CF30")]
		public static bool IsEmpty<T>(this NativeArray<T> value) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DFA0", Offset = "0x3B5C7A0", VA = "0x183B5DFA0")]
		public static void Swap<T>(this NativeArray<T> array, int a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DBD0", Offset = "0x3B5C3D0", VA = "0x183B5DBD0")]
		public static void SliceRemoveSwapback<T>(this NativeArray<T> array, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DFD0", Offset = "0x3B5C7D0", VA = "0x183B5DFD0")]
		public static string ToFormattedString<T>(this NativeList<T> list, string separator = ", ") where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B5E090", Offset = "0x3B5C890", VA = "0x183B5E090")]
		public static string ToFormattedString<T>(this NativeArray<T> array, string separator = ", ") where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BBCMHIHLIOF]
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
			[Cpp2IlInjected.Address(RVA = "0x4CE5FC0", Offset = "0x4CE47C0", VA = "0x184CE5FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE48A70", Offset = "0xE47270", VA = "0x180E48A70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x524B4E0", Offset = "0x5249CE0", VA = "0x18524B4E0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x55F7A30", Offset = "0x55F6230", VA = "0x1855F7A30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x55F7790", Offset = "0x55F5F90", VA = "0x1855F7790")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4187B80", Offset = "0x4186380", VA = "0x184187B80")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BBCMHIHLIOF]
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
			[Cpp2IlInjected.Address(RVA = "0x4CE5FC0", Offset = "0x4CE47C0", VA = "0x184CE5FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x56495A0", Offset = "0x5647DA0", VA = "0x1856495A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x524B4E0", Offset = "0x5249CE0", VA = "0x18524B4E0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5648EF0", Offset = "0x56476F0", VA = "0x185648EF0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5649200", Offset = "0x5647A00", VA = "0x185649200")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5649470", Offset = "0x5647C70", VA = "0x185649470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x56492E0", Offset = "0x5647AE0", VA = "0x1856492E0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[BBCMHIHLIOF]
	public static class RRAllocator
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BBCMHIHLIOF]
public static class AAIFIMCLGJP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CFF0", Offset = "0x7F9B7F0", VA = "0x187F9CFF0")]
	public static JobHandle JIODNHONKKH(this JobHandle HBMOFOICGEH, JobHandle LDEEDNGKJOE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CF40", Offset = "0x7F9B740", VA = "0x187F9CF40")]
	public static JobHandle IAPELKLJDDM(this Span<JobHandle> NBGKLLBKMKP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ECIDIFNDEIH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3648880", Offset = "0x3647080", VA = "0x183648880")]
	public static void CGGBONADGHB<T>(this T[] LPBOBEPEKNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AKKFBGBFFLB
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x41F2200", Offset = "0x41F0A00", VA = "0x1841F2200")]
	public static NativeKeyValueArrays<TKey, TValue> MBAFJAEDODB<TKey, TValue>(this Dictionary<TKey, TValue> FDLLKGDBNDF, Allocator GFNKGIEEHMD) where TKey : struct where TValue : struct
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AEDLJCOPEAK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D170", Offset = "0x7F9B970", VA = "0x187F9D170")]
	public static void MGADBOKLGFC(this GameObject EMOLHEPHCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D0D0", Offset = "0x7F9B8D0", VA = "0x187F9D0D0")]
	public static void MGADBOKLGFC(this Component EIBGHDHLJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D030", Offset = "0x7F9B830", VA = "0x187F9D030")]
	public static void MGADBOKLGFC(this ScriptableObject ONMCEGHAMAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GOIJAGLKAGD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DED0", Offset = "0x7F9C6D0", VA = "0x187F9DED0")]
	public static void CBOMIAJEOHK(this NativeList<byte> NFJJCCDFOPE, ReadOnlySpan<byte> KOICJAPMBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39E97E0", Offset = "0x39E7FE0", VA = "0x1839E97E0")]
	public static void KCNHJJBAPFC<T>(this NativeList<T> NFJJCCDFOPE, T MGONBEDEDON, int FMGALNGIOGC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KACOGPEALIK
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C110", Offset = "0x3A8A910", VA = "0x183A8C110")]
	public static T CNGCMHCMKGB<T>(this ReadOnlySpan<byte> MGONBEDEDON) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C450", Offset = "0x3A8AC50", VA = "0x183A8C450")]
	public static T GIELHPLHMIN<T>(this Span<T> KOICJAPMBOK, Func<T, bool> NGMBOMGIPMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CB70", Offset = "0x3A8B370", VA = "0x183A8CB70")]
	public static bool PNAENJCKDBB<T>(this Span<T> KOICJAPMBOK, Func<T, bool> NGMBOMGIPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C5B0", Offset = "0x3A8ADB0", VA = "0x183A8C5B0")]
	public static bool NIMCODDBGHP<T>(this Span<T> KOICJAPMBOK, Func<T, bool> NGMBOMGIPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A8BBC0", Offset = "0x3A8A3C0", VA = "0x183A8BBC0")]
	public static T CEJDCFFPPDB<T>([In] this ReadOnlySpan<byte> KOICJAPMBOK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39A58B0", Offset = "0x39A40B0", VA = "0x1839A58B0")]
	public static Span<TTo> LLMFLFNMPEH<TTo, TFrom>(this Span<TFrom> KOICJAPMBOK) where TTo : struct where TFrom : struct
	{
		return default(Span<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39A58B0", Offset = "0x39A40B0", VA = "0x1839A58B0")]
	public static ReadOnlySpan<TTo> LLMFLFNMPEH<TTo, TFrom>(this ReadOnlySpan<TFrom> KOICJAPMBOK) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39A58B0", Offset = "0x39A40B0", VA = "0x1839A58B0")]
	public static ReadOnlySpan<TTo> LLMFLFNMPEH<TTo>(this ReadOnlySpan<byte> KOICJAPMBOK) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C350", Offset = "0x3A8AB50", VA = "0x183A8C350")]
	public static Span<T> FGIKHGILDDC<T>(this ReadOnlySpan<T> GJKNNKIANJJ) where T : struct
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C660", Offset = "0x3A8AE60", VA = "0x183A8C660")]
	public static Span<byte> NNLOAAEAPBJ<T>([In] this Span<byte> KOICJAPMBOK, T MGONBEDEDON) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E040", Offset = "0x7F9C840", VA = "0x187F9E040")]
	private static Enum MJFEEAICGKB([In] ReadOnlySpan<byte> KOICJAPMBOK, Type LHEHOGAPCOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DFD0", Offset = "0x7F9C7D0", VA = "0x187F9DFD0")]
	public static Enum MEOKBIKCOEK([In] this Span<byte> KOICJAPMBOK, Type LHEHOGAPCOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E5E0", Offset = "0x7F9CDE0", VA = "0x187F9E5E0")]
	public static void PMHBGEAGKJA([In] this Span<byte> KOICJAPMBOK, Enum IJLILEGPOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CDNEMOLMHDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MMHAPBGHLJI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7F9EBA0", Offset = "0x7F9D3A0", VA = "0x187F9EBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D810", Offset = "0x7F9C010", VA = "0x187F9D810")]
	[AsyncStateMachine(typeof(MMHAPBGHLJI))]
	public static void HDDPIKEOIKO(this Task ODKLOJBBLOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MDHHBDLNLOG
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3AC00C0", Offset = "0x3ABE8C0", VA = "0x183AC00C0")]
	public static NativeArray<T> OLPMBJELBCM<T>(this UnsafeList<T> NFJJCCDFOPE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0040", Offset = "0x3ABE840", VA = "0x183AC0040")]
	public static NativeArray<T> OBLDLBNOOFB<T>(this UnsafeList<T> NFJJCCDFOPE, bool JOOPKFKHMDP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFF90", Offset = "0x3ABE790", VA = "0x183ABFF90")]
	public static UnsafeList<T> FGIKHGILDDC<T>(this UnsafeList<T> NFJJCCDFOPE, Allocator GFNKGIEEHMD) where T : struct
	{
		return default(UnsafeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JFHBMILIGOI
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum PNNEFNKIJEO : short
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
	public struct CCAMHJDJFGF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly PNNEFNKIJEO MNMCNOJCKAF;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2F14EA0", Offset = "0x2F136A0", VA = "0x182F14EA0")]
		public CCAMHJDJFGF(PNNEFNKIJEO MNMCNOJCKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static ProfilerCategory PAOIAAAHGOA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	public static void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DF70", Offset = "0x7F9C770", VA = "0x187F9DF70")]
	static JFHBMILIGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x36546B0", Offset = "0x3652EB0", VA = "0x1836546B0")]
	public static CCAMHJDJFGF GGNAGLGHPLM(PNNEFNKIJEO MNMCNOJCKAF)
	{
		return default(CCAMHJDJFGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	public static void JLIHKGEMAMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DGDPNHMHOIB
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A748C0", Offset = "0x2A730C0", VA = "0x182A748C0")]
	public static NKFLCFKEPIN<T1, T2> AEIFJJBMLMI<T1, T2>(this (T1, T2) MLFPMFCIJCE) where T1 : struct, IDisposable where T2 : struct, IDisposable
	{
		return default(NKFLCFKEPIN<T1, T2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37F9800", Offset = "0x37F8000", VA = "0x1837F9800")]
	public static BENPFJIKLAF<T1, T2, T3> AEIFJJBMLMI<T1, T2, T3>(this (T1, T2, T3) MLFPMFCIJCE) where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
	{
		return default(BENPFJIKLAF<T1, T2, T3>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NKFLCFKEPIN<T1, T2> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private (T1, T2) MLFPMFCIJCE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A74640", Offset = "0x2A72E40", VA = "0x182A74640")]
	public NKFLCFKEPIN((T1, T2) MLFPMFCIJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x55D5920", Offset = "0x55D4120", VA = "0x1855D5920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BENPFJIKLAF<T1, T2, T3> : IDisposable where T1 : struct, IDisposable where T2 : struct, IDisposable where T3 : struct, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private (T1, T2, T3) MLFPMFCIJCE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x55D5D40", Offset = "0x55D4540", VA = "0x1855D5D40")]
	public BENPFJIKLAF((T1, T2, T3) MLFPMFCIJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6167E80", Offset = "0x6166680", VA = "0x186167E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BLNAJIMPGCD
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D5C0", Offset = "0x7F9BDC0", VA = "0x187F9D5C0")]
	public static Range CECEGCHDCPP(this OFIADOPPLCJ LGACFNJFHND)
	{
		return default(Range);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class LLHCFACEHKP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct HNFIEMGEAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int HIMJFHGCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int LLHBGCFGAEG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7F9DF60", Offset = "0x7F9C760", VA = "0x187F9DF60")]
		public HNFIEMGEAEL(int BAGLBFCLNDM, int LLHBGCFGAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F9DF50", Offset = "0x7F9C750", VA = "0x187F9DF50")]
		public bool LMBOCOKIDAD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EAC0", Offset = "0x7F9D2C0", VA = "0x187F9EAC0")]
	public static HNFIEMGEAEL KFPOPIJHFBP(this Range LGACFNJFHND)
	{
		return default(HNFIEMGEAEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KHAIHKFBMAA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private GCHandle DAMJGGDGMEF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KOENCHEMOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x51AEFF0", Offset = "0x51AD7F0", VA = "0x1851AEFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x51AF600", Offset = "0x51ADE00", VA = "0x1851AF600")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x51AF2D0", Offset = "0x51ADAD0", VA = "0x1851AF2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x51AF6B0", Offset = "0x51ADEB0", VA = "0x1851AF6B0")]
	public KHAIHKFBMAA(T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x51AEFC0", Offset = "0x51AD7C0", VA = "0x1851AEFC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class NFCEJELNCKA<THandle, TValue> : IDisposable where THandle : struct, OACALCJJELJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<THandle> NBGKLLBKMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TValue> IFMNLKCJNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Func<TValue> GJJHHKPDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<TValue> JPLLPONFNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int CINBGNNBENA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TValue NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x55B82B0", Offset = "0x55B6AB0", VA = "0x1855B82B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55B8300", Offset = "0x55B6B00", VA = "0x1855B8300")]
	public NFCEJELNCKA(Action<TValue> JPLLPONFNID, [Optional] Func<TValue> GJJHHKPDOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55B7860", Offset = "0x55B6060", VA = "0x1855B7860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55B7B70", Offset = "0x55B6370", VA = "0x1855B7B70")]
	public THandle GGGBGBDKNKJ(TValue MGONBEDEDON)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55B7F60", Offset = "0x55B6760", VA = "0x1855B7F60")]
	public bool MMIAFMKGHIE(THandle DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55B7780", Offset = "0x55B5F80", VA = "0x1855B7780")]
	public bool CLCEOBPBAJN(THandle DAMJGGDGMEF, [Out] TValue MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55B7730", Offset = "0x55B5F30", VA = "0x1855B7730")]
	public TValue CEJDCFFPPDB(THandle DAMJGGDGMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55B7E40", Offset = "0x55B6640", VA = "0x1855B7E40")]
	public bool KPPNCAJEGHJ(THandle DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x55B7590", Offset = "0x55B5D90", VA = "0x1855B7590")]
	private THandle ACMLFHCCBAB(int PNJCJGEIDHG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55B7C20", Offset = "0x55B6420", VA = "0x1855B7C20")]
	private TValue IGJBJAKHOGI(int PNJCJGEIDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55B8260", Offset = "0x55B6A60", VA = "0x1855B8260")]
	private void PDFAJFCMOIH(int PNJCJGEIDHG, [In] THandle DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x55B7B20", Offset = "0x55B6320", VA = "0x1855B7B20")]
	private void GEEFJFFEMNC(int PNJCJGEIDHG, [In] TValue MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x55B80A0", Offset = "0x55B68A0", VA = "0x1855B80A0")]
	private THandle OBIBDDLAGEF()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x55B7A00", Offset = "0x55B6200", VA = "0x1855B7A00")]
	private void FOHJDOOMNOF(THandle DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55B82F0", Offset = "0x55B6AF0", VA = "0x1855B82F0")]
	private int PODEFBFJBEO(int EHCBHNLMEHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55B7850", Offset = "0x55B6050", VA = "0x1855B7850")]
	private bool DFLPAAEGNHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA2FE60", Offset = "0xA2E660", VA = "0x180A2FE60")]
	private void FPCLICKKKNM(THandle DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x55B7940", Offset = "0x55B6140", VA = "0x1855B7940")]
	private bool FJFBKHDAFJH([Out] THandle DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x55B75F0", Offset = "0x55B5DF0", VA = "0x1855B75F0")]
	private bool BCKKCCGDPPA([Out] THandle DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x55B7C80", Offset = "0x55B6480", VA = "0x1855B7C80")]
	private void KOEALEPGCAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OACALCJJELJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int MOHDHMLGIAN
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
public static class EKEFIBPCAEO
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3844970", Offset = "0x3843170", VA = "0x183844970")]
	public static bool NIGNOBFHNNI<T>(this T DAMJGGDGMEF, T KEKEFPAJGHD) where T : struct, OACALCJJELJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3844960", Offset = "0x3843160", VA = "0x183844960")]
	public static bool KBFIABEIPGM<T>(this T DAMJGGDGMEF) where T : struct, OACALCJJELJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DDC0", Offset = "0x7F9C5C0", VA = "0x187F9DDC0")]
	public static string BDIANNPEPMK(this OACALCJJELJ DAMJGGDGMEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public ref struct AFPIKACBKKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Type OICMPOACPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Span<byte> FNNICGFGIPD;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x524AF80", Offset = "0x5249780", VA = "0x18524AF80")]
	public AFPIKACBKKH(Type FHMCGHGIMCB, Span<byte> KOICJAPMBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x41E8610", Offset = "0x41E6E10", VA = "0x1841E8610")]
	public static AFPIKACBKKH COODOOJDJHL<T>(T MGONBEDEDON) where T : struct
	{
		return default(AFPIKACBKKH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D210", Offset = "0x7F9BA10", VA = "0x187F9D210")]
	public static OMJAECGKPPJ KEINEINMKGA([In] AFPIKACBKKH NLCEHLDPLPE)
	{
		return default(OMJAECGKPPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D290", Offset = "0x7F9BA90", VA = "0x187F9D290")]
	public Enum MEOKBIKCOEK(Type LHEHOGAPCOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x41E8FA0", Offset = "0x41E77A0", VA = "0x1841E8FA0")]
	public void NNLOAAEAPBJ<T>([In] T MGONBEDEDON) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D310", Offset = "0x7F9BB10", VA = "0x187F9D310")]
	public void PMHBGEAGKJA(Enum IJLILEGPOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public ref struct OMJAECGKPPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct JBANDFDPHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private unsafe void* MHNGFMELCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private unsafe void* ANPHCPJJGOJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Type OICMPOACPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ReadOnlySpan<byte> FNNICGFGIPD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AHPAEMFBOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EF80", Offset = "0x7F9D780", VA = "0x187F9EF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LKIEBFOEGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EF30", Offset = "0x7F9D730", VA = "0x187F9EF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x524AF80", Offset = "0x5249780", VA = "0x18524AF80")]
	public OMJAECGKPPJ(Type FHMCGHGIMCB, ReadOnlySpan<byte> KOICJAPMBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B88BD0", Offset = "0x3B873D0", VA = "0x183B88BD0")]
	public static OMJAECGKPPJ COODOOJDJHL<T>(T MGONBEDEDON) where T : struct
	{
		return default(OMJAECGKPPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F160", Offset = "0x7F9D960", VA = "0x187F9F160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EF90", Offset = "0x7F9D790", VA = "0x187F9EF90")]
	public object KJPBGHOPCIP(int PNJCJGEIDHG = 0)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BNBPHBKMFMK
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3735270", Offset = "0x3733A70", VA = "0x183735270")]
	public static NativeArray<T> COODOOJDJHL<T>(T MGONBEDEDON, bool JOOPKFKHMDP) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x37352C0", Offset = "0x3733AC0", VA = "0x1837352C0")]
	public static NativeArray<T> DHCBEBCFHIC<T>(T MGONBEDEDON) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3735380", Offset = "0x3733B80", VA = "0x183735380")]
	public static NativeArray<T> JOOIBFGKEEP<T>(T MGONBEDEDON) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D750", Offset = "0x7F9BF50", VA = "0x187F9D750")]
	public static NativeArray<byte> JOOIBFGKEEP(ReadOnlySpan<byte> MGONBEDEDON)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D620", Offset = "0x7F9BE20", VA = "0x187F9D620")]
	public static NativeArray<byte> COODOOJDJHL(ReadOnlySpan<byte> MGONBEDEDON, bool JOOPKFKHMDP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D6D0", Offset = "0x7F9BED0", VA = "0x187F9D6D0")]
	public unsafe static NativeArray<byte> COODOOJDJHL(byte* LKMEPECNEMO, int AEPPOMGGPKB, bool JOOPKFKHMDP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3735310", Offset = "0x3733B10", VA = "0x183735310")]
	public static NativeArray<T> EBKBGKJDDBM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct BAPIOFMDIIH : IEquatable<BAPIOFMDIIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int BEIKFCEAAEK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Type PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F9D320", Offset = "0x7F9BB20", VA = "0x187F9D320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D520", Offset = "0x7F9BD20", VA = "0x187F9D520")]
	public BAPIOFMDIIH(Type CEPGAJKBPDM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D450", Offset = "0x7F9BC50", VA = "0x187F9D450")]
	public static BAPIOFMDIIH KEINEINMKGA(Type CEPGAJKBPDM)
	{
		return default(BAPIOFMDIIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x22673C0", Offset = "0x2265BC0", VA = "0x1822673C0", Slot = "4")]
	public bool Equals(BAPIOFMDIIH KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D3D0", Offset = "0x7F9BBD0", VA = "0x187F9D3D0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D4E0", Offset = "0x7F9BCE0", VA = "0x187F9D4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DHMMBNIKGEC
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Dictionary<Type, int> PEJHEHHHGLI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static List<Type> KMEFPDEBILD;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DC40", Offset = "0x7F9C440", VA = "0x187F9DC40")]
	static DHMMBNIKGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D9B0", Offset = "0x7F9C1B0", VA = "0x187F9D9B0")]
	public static bool GGGBGBDKNKJ(Type CEPGAJKBPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DA10", Offset = "0x7F9C210", VA = "0x187F9DA10")]
	private static bool GGGBGBDKNKJ(Type CEPGAJKBPDM, [Out] int PNJCJGEIDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DBE0", Offset = "0x7F9C3E0", VA = "0x187F9DBE0")]
	public static int HPMGOHHMHCH(Type CEPGAJKBPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D930", Offset = "0x7F9C130", VA = "0x187F9D930")]
	public static Type CEJDCFFPPDB(int PNJCJGEIDHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct NENFCIJKKMI<Handle> where Handle : OACALCJJELJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct ABGBNEPHDEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly NENFCIJKKMI<Handle> KFIOJDEKGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int PNJCJGEIDHG;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Handle JLAJANPPGEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x4C5C6D0", Offset = "0x4C5AED0", VA = "0x184C5C6D0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4C5CB50", Offset = "0x4C5B350", VA = "0x184C5CB50")]
		public ABGBNEPHDEH(NENFCIJKKMI<Handle> KFIOJDEKGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4C5C4B0", Offset = "0x4C5ACB0", VA = "0x184C5C4B0")]
		public BLMIFAFJHKG CCPKJDCALBG([In] BLMIFAFJHKG FOIMOKIBLGB)
		{
			return default(BLMIFAFJHKG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4C5C910", Offset = "0x4C5B110", VA = "0x184C5C910")]
		public bool LMBOCOKIDAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4C5C850", Offset = "0x4C5B050", VA = "0x184C5C850")]
		private Handle JLECJGLJJPJ(string ILBALOOKKCP)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct BLMIFAFJHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private ABGBNEPHDEH PIBDGLMPMIE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Handle EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x617AC60", Offset = "0x6179460", VA = "0x18617AC60")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x617ADE0", Offset = "0x61795E0", VA = "0x18617ADE0")]
		public BLMIFAFJHKG(NENFCIJKKMI<Handle> KFIOJDEKGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x617ADA0", Offset = "0x61795A0", VA = "0x18617ADA0")]
		public bool LMBOCOKIDAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x617ACE0", Offset = "0x61794E0", VA = "0x18617ACE0")]
		public BLMIFAFJHKG KFPOPIJHFBP()
		{
			return default(BLMIFAFJHKG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<int> NEENKDLMOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeList<int> KIECDCOHMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int IOPNNCDIOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int HDCFFBOKEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool DENJOKLHMJB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KCIKODHLHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x55B49F0", Offset = "0x55B31F0", VA = "0x1855B49F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BLMIFAFJHKG JELGEDLJOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x55B4170", Offset = "0x55B2970", VA = "0x1855B4170")]
		get
		{
			return default(BLMIFAFJHKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x55B4A70", Offset = "0x55B3270", VA = "0x1855B4A70")]
	public NENFCIJKKMI(int DOKKPGJAENM, Allocator GFNKGIEEHMD = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55B37E0", Offset = "0x55B1FE0", VA = "0x1855B37E0")]
	public void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x231C990", Offset = "0x231B190", VA = "0x18231C990")]
	public static int PODEFBFJBEO(int KENANDNBOGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2F31130", Offset = "0x2F2F930", VA = "0x182F31130")]
	public static bool NPLKFNGCGKJ(int KENANDNBOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x55B4040", Offset = "0x55B2840", VA = "0x1855B4040")]
	public bool MOEEAPEEEHK(int PNJCJGEIDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x55B33F0", Offset = "0x55B1BF0", VA = "0x1855B33F0")]
	public bool FEEIDGIECLD(Handle DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x55B3250", Offset = "0x55B1A50", VA = "0x1855B3250")]
	public Handle EFPLLJAKEON()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x55B4370", Offset = "0x55B2B70", VA = "0x1855B4370")]
	public void NFPHBPKBFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x55B3770", Offset = "0x55B1F70", VA = "0x1855B3770")]
	public void GAJLOPIKHOB(Handle DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0")]
	private bool AHCBAKNGCNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x55B3040", Offset = "0x55B1840", VA = "0x1855B3040")]
	private bool CJECNJIOGPL(int PNJCJGEIDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x55B3AE0", Offset = "0x55B22E0", VA = "0x1855B3AE0")]
	private void JOBCMGHBLDH([Out] int PNJCJGEIDHG, [Out] int EHCBHNLMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x55B3C60", Offset = "0x55B2460", VA = "0x1855B3C60")]
	private void MBLDNGNPHKD(Handle DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x55B2F40", Offset = "0x55B1740", VA = "0x1855B2F40")]
	private void CDNCINEEIAK(int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x55B42C0", Offset = "0x55B2AC0", VA = "0x1855B42C0")]
	private bool NFKCHIGLIHK([Out] int PNJCJGEIDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x55B3190", Offset = "0x55B1990", VA = "0x1855B3190")]
	private static Handle DCMFCIFDNKO(int PNJCJGEIDHG, int EHCBHNLMEHF)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public struct NEGGAKIBKNL<Handle, T> where Handle : OACALCJJELJ, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NENFCIJKKMI<Handle> PDPHPEEGONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T[] PECLEFPCPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Action<T> LIDDLLCBNGM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55B1CE0", Offset = "0x55B04E0", VA = "0x1855B1CE0")]
	public NEGGAKIBKNL(int DOKKPGJAENM, [Optional] Action<T> LIDDLLCBNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55B1620", Offset = "0x55AFE20", VA = "0x1855B1620")]
	public void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55B0DD0", Offset = "0x55AF5D0", VA = "0x1855B0DD0")]
	public bool CLCEOBPBAJN(Handle DAMJGGDGMEF, [Out] T HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55B0F40", Offset = "0x55AF740", VA = "0x1855B0F40")]
	public Handle GGGBGBDKNKJ(T HPLLAPMNIJF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55B1740", Offset = "0x55AFF40", VA = "0x1855B1740")]
	public void PBGMKAAANLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55B13C0", Offset = "0x55AFBC0", VA = "0x1855B13C0")]
	public void HKOLMKDGPPH(Handle DAMJGGDGMEF, [Out] T ABCCNBBCMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55B11A0", Offset = "0x55AF9A0", VA = "0x1855B11A0")]
	public void HKOLMKDGPPH(Handle DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55B15C0", Offset = "0x55AFDC0", VA = "0x1855B15C0")]
	private T HNMLFODLNIF(int PNJCJGEIDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55B0E80", Offset = "0x55AF680", VA = "0x1855B0E80")]
	private void FJIBMLFNLAC(int KNGACGPHDMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public struct IBGBEKHIABD<T> : IDisposable, IEnumerable<T>, IEnumerable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct EONFGLNEOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IBGBEKHIABD<T> LPBOBEPEKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int PNJCJGEIDHG;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4752B00", Offset = "0x4751300", VA = "0x184752B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28A85D0", Offset = "0x28A6DD0", VA = "0x1828A85D0")]
		public EONFGLNEOBG(IBGBEKHIABD<T> LPBOBEPEKNH, int PNJCJGEIDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4752B50", Offset = "0x4751350", VA = "0x184752B50")]
		public bool LMBOCOKIDAD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ODABAFFNFOP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public IBGBEKHIABD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public ODABAFFNFOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5726B80", Offset = "0x5725380", VA = "0x185726B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5726C20", Offset = "0x5725420", VA = "0x185726C20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GNMFILNIOED : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IBGBEKHIABD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public GNMFILNIOED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB2F0", Offset = "0x4CA9AF0", VA = "0x184CAB2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB390", Offset = "0x4CA9B90", VA = "0x184CAB390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private object[] IMINNNCPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private uint MGONBEDEDON;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4DDD000", Offset = "0x4DDB800", VA = "0x184DDD000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KBMDKILMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4DDD320", Offset = "0x4DDBB20", VA = "0x184DDD320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AGNMEGAEAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x182E280", Offset = "0x182CA80", VA = "0x18182E280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	internal bool MMOPBOMGPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4DDD240", Offset = "0x4DDBA40", VA = "0x184DDD240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DMFKDPEPHKH<T> FNNICGFGIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4DDD770", Offset = "0x4DDBF70", VA = "0x184DDD770")]
		get
		{
			return default(DMFKDPEPHKH<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4DDD8F0", Offset = "0x4DDC0F0", VA = "0x184DDD8F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4DDD470", Offset = "0x4DDBC70", VA = "0x184DDD470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDFA0", Offset = "0x4DDC7A0", VA = "0x184DDDFA0")]
	internal IBGBEKHIABD(IBGBEKHIABD<T> LPBOBEPEKNH, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDC30", Offset = "0x4DDC430", VA = "0x184DDDC30")]
	private IBGBEKHIABD(T[] LPBOBEPEKNH, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDC50", Offset = "0x4DDC450", VA = "0x184DDDC50")]
	public IBGBEKHIABD(IEnumerable<T> IFMNLKCJNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDBC0", Offset = "0x4DDC3C0", VA = "0x184DDDBC0")]
	public IBGBEKHIABD(int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD2A0", Offset = "0x4DDBAA0", VA = "0x184DDD2A0")]
	public int JJKEKPCJLBP(T MGONBEDEDON, int BAGLBFCLNDM, int FMGALNGIOGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD250", Offset = "0x4DDBA50", VA = "0x184DDD250")]
	public void IPALAJAGNMD(int JHJLLGGGKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD5A0", Offset = "0x4DDBDA0", VA = "0x184DDD5A0")]
	private void MMHLGCOOICG(int JHJLLGGGKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD160", Offset = "0x4DDB960", VA = "0x184DDD160")]
	public T[] FMAPKFJABFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD010", Offset = "0x4DDB810", VA = "0x184DDD010")]
	public T[] FJIGKPPDAMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4DDCF80", Offset = "0x4DDB780", VA = "0x184DDCF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4DDCF10", Offset = "0x4DDB710", VA = "0x184DDCF10")]
	public void BLNEDHKGIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD400", Offset = "0x4DDBC00", VA = "0x184DDD400")]
	public EONFGLNEOBG KFPOPIJHFBP()
	{
		return default(EONFGLNEOBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD9C0", Offset = "0x4DDC1C0", VA = "0x184DDD9C0", Slot = "5")]
	[IteratorStateMachine(typeof(IBGBEKHIABD<>.ODABAFFNFOP))]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDAC0", Offset = "0x4DDC2C0", VA = "0x184DDDAC0", Slot = "6")]
	[IteratorStateMachine(typeof(IBGBEKHIABD<>.GNMFILNIOED))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD1E0", Offset = "0x4DDB9E0", VA = "0x184DDD1E0")]
	public static IBGBEKHIABD<T> GDNILLMMNLM(T[] LPBOBEPEKNH)
	{
		return default(IBGBEKHIABD<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD350", Offset = "0x4DDBB50", VA = "0x184DDD350")]
	public static IBGBEKHIABD<T> KEINEINMKGA(T[] LPBOBEPEKNH)
	{
		return default(IBGBEKHIABD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD520", Offset = "0x4DDBD20", VA = "0x184DDD520")]
	private void KJMIIANOBOL(int PNJCJGEIDHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class FJODPEEPKJK<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct LAEMDCPHNMH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FJODPEEPKJK<T> NFJJCCDFOPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int PNJCJGEIDHG;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5252D50", Offset = "0x5251550", VA = "0x185252D50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5252D90", Offset = "0x5251590", VA = "0x185252D90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x47DA000", Offset = "0x47D8800", VA = "0x1847DA000")]
		public LAEMDCPHNMH(FJODPEEPKJK<T> NFJJCCDFOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5252C50", Offset = "0x5251450", VA = "0x185252C50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5252D00", Offset = "0x5251500", VA = "0x185252D00", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IBGBEKHIABD<T> IMINNNCPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int AEPPOMGGPKB;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2380", Offset = "0x4BB0B80", VA = "0x184BB2380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4BB13C0", Offset = "0x4BAFBC0", VA = "0x184BB13C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4826820", Offset = "0x4825020", VA = "0x184826820", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int KCIKODHLHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1F40", Offset = "0x4BB0740", VA = "0x184BB1F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool AGNMEGAEAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1F60", Offset = "0x4BB0760", VA = "0x184BB1F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DMFKDPEPHKH<T> FNNICGFGIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4BB21D0", Offset = "0x4BB09D0", VA = "0x184BB21D0")]
		get
		{
			return default(DMFKDPEPHKH<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4BB2310", Offset = "0x4BB0B10", VA = "0x184BB2310")]
	public FJODPEEPKJK(int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1630", Offset = "0x4BAFE30", VA = "0x184BB1630")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1920", Offset = "0x4BB0120", VA = "0x184BB1920")]
	public IBGBEKHIABD<T> HMNKAHFBHBF()
	{
		return default(IBGBEKHIABD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1720", Offset = "0x4BAFF20", VA = "0x184BB1720")]
	public void GGGBGBDKNKJ(T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1970", Offset = "0x4BB0170", VA = "0x184BB1970")]
	private void IPALAJAGNMD(int BEMGFNOEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4BB14A0", Offset = "0x4BAFCA0", VA = "0x184BB14A0")]
	public void CBOMIAJEOHK(List<T> IDAPMLPCJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1400", Offset = "0x4BAFC00", VA = "0x184BB1400")]
	public void CBOMIAJEOHK(T[] IDAPMLPCJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1A40", Offset = "0x4BB0240", VA = "0x184BB1A40")]
	public void KCKKIFBMGKH(int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1C00", Offset = "0x4BB0400", VA = "0x184BB1C00")]
	public void MAOEJMOBKBN(int CODPBPONOKF, int LLHBGCFGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4BB19B0", Offset = "0x4BB01B0", VA = "0x184BB19B0")]
	public int JJKEKPCJLBP(T MGONBEDEDON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4BB18D0", Offset = "0x4BB00D0", VA = "0x184BB18D0")]
	public bool HKLOAKDICEJ(T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4BB16A0", Offset = "0x4BAFEA0", VA = "0x184BB16A0")]
	public T[] FJIGKPPDAMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1670", Offset = "0x4BAFE70", VA = "0x184BB1670", Slot = "8")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1B30", Offset = "0x4BB0330", VA = "0x184BB1B30")]
	public static IBGBEKHIABD<T> KEINEINMKGA(FJODPEEPKJK<T> NFJJCCDFOPE)
	{
		return default(IBGBEKHIABD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1850", Offset = "0x4BB0050", VA = "0x184BB1850", Slot = "6")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4BB2260", Offset = "0x4BB0A60", VA = "0x184BB2260", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4BB22A0", Offset = "0x4BB0AA0", VA = "0x184BB22A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1DF0", Offset = "0x4BB05F0", VA = "0x184BB1DF0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void NGLFDHCBBMN(int MGONBEDEDON, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4BB1F80", Offset = "0x4BB0780", VA = "0x184BB1F80")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void OCCAEHFDAPK(int CODPBPONOKF, int LLHBGCFGAEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GDLHLMFBDJP
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x39E2FC0", Offset = "0x39E17C0", VA = "0x1839E2FC0")]
	public static void BLNEDHKGIJE<T>(this FJODPEEPKJK<T> NFJJCCDFOPE) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public ref struct DMFKDPEPHKH<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Span<object> IMINNNCPCJF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AA20", Offset = "0x6D59220", VA = "0x186D5AA20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A840", Offset = "0x6D59040", VA = "0x186D5A840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A700", Offset = "0x6D58F00", VA = "0x186D5A700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public DMFKDPEPHKH(Span<object> KOICJAPMBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A870", Offset = "0x6D59070", VA = "0x186D5A870")]
	public DMFKDPEPHKH<T> MGCJLBGPFLI(int BAGLBFCLNDM)
	{
		return default(DMFKDPEPHKH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A940", Offset = "0x6D59140", VA = "0x186D5A940")]
	public DMFKDPEPHKH<T> MGCJLBGPFLI(int BAGLBFCLNDM, int AEPPOMGGPKB)
	{
		return default(DMFKDPEPHKH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A7E0", Offset = "0x6D58FE0", VA = "0x186D5A7E0")]
	public void HBCBFICEHBC(DMFKDPEPHKH<T> PLPNNLPKPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AAB0", Offset = "0x6D592B0", VA = "0x186D5AAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A740", Offset = "0x6D58F40", VA = "0x186D5A740", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A790", Offset = "0x6D58F90", VA = "0x186D5A790", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OFIADOPPLCJ : IEquatable<OFIADOPPLCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int BJCMHPBMOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int FMGALNGIOGC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int DNFFEFMJBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2F364C0", Offset = "0x2F34CC0", VA = "0x182F364C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x71B2930", Offset = "0x71B1130", VA = "0x1871B2930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int NHJIDAAFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int AEOJNBIMJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EE90", Offset = "0x7F9D690", VA = "0x187F9EE90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7F9ED80", Offset = "0x7F9D580", VA = "0x187F9ED80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public (int begin, int end) DHPECDHFIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EE20", Offset = "0x7F9D620", VA = "0x187F9EE20")]
		get
		{
			return default((int, int));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
	private OFIADOPPLCJ(int BJCMHPBMOOK, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x28976F0", Offset = "0x2895EF0", VA = "0x1828976F0")]
	public static OFIADOPPLCJ IJEELKKOGDE(int BJCMHPBMOOK, int FMGALNGIOGC)
	{
		return default(OFIADOPPLCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EE80", Offset = "0x7F9D680", VA = "0x187F9EE80")]
	public static OFIADOPPLCJ LALPDELDFBA(int BAGLBFCLNDM, int LLHBGCFGAEG)
	{
		return default(OFIADOPPLCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EEA0", Offset = "0x7F9D6A0", VA = "0x187F9EEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x129E8D0", Offset = "0x129D0D0", VA = "0x18129E8D0", Slot = "4")]
	public bool Equals(OFIADOPPLCJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9ED90", Offset = "0x7F9D590", VA = "0x187F9ED90", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x731A090", Offset = "0x7318890", VA = "0x18731A090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct FHEECBFOJOG<T> : IEqualityComparer<int>, IComparer<int> where T : struct, IComparable<T>, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NativeArray<T> IMINNNCPCJF;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
	public FHEECBFOJOG(NativeArray<T> IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC460", Offset = "0x4BAAC60", VA = "0x184BAC460", Slot = "6")]
	public int Compare(int BDGPJOKJNIL, int HDAFCDJNHAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC550", Offset = "0x4BAAD50", VA = "0x184BAC550", Slot = "4")]
	public bool Equals(int BDGPJOKJNIL, int HDAFCDJNHAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC640", Offset = "0x4BAAE40", VA = "0x184BAC640", Slot = "5")]
	public int GetHashCode(int BDGPJOKJNIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DEGCIJDIIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x37F67A0", Offset = "0x37F4FA0", VA = "0x1837F67A0")]
	public static T[] ABDKNMKLEPD<T>(List<T> NFJJCCDFOPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct GGDPNKNBOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* ADHFCMKPLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal AllocatorManager.AllocatorHandle DHAPIAGBANI;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D2ABB0", Offset = "0x5D293B0", VA = "0x185D2ABB0")]
	public void JGAHMDKPFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class LOLNBLFMGML
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE2F0", Offset = "0x3AACAF0", VA = "0x183AAE2F0")]
	public static GGDPNKNBOHF IIALDPBHHDP<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> LILGCKMMEFL) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(GGDPNKNBOHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE2F0", Offset = "0x3AACAF0", VA = "0x183AAE2F0")]
	public static UnsafeParallelHashMap<TKey, TValue> MIMEDEKLELE<TKey, TValue>(this GGDPNKNBOHF LILGCKMMEFL) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeParallelHashMap<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class MFNBFEOLNPI
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBD10", Offset = "0x3ACA510", VA = "0x183ACBD10")]
	public static int BGDLJHOPGCO<T>(ReadOnlySpan<T> GKJGJJFMBCP, ReadOnlySpan<T> DBFFHODMFKH, int AEPPOMGGPKB) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JOCJMLDNLJD
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3A66D00", Offset = "0x3A65500", VA = "0x183A66D00")]
	public static T CDCGONEOHDP<T>(this NativeArray<byte> GJKNNKIANJJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3A67020", Offset = "0x3A65820", VA = "0x183A67020")]
	public static NativeArray<T> OOBPPGMBJMH<T>(this NativeArray<byte> GJKNNKIANJJ, int FMGALNGIOGC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3A66D90", Offset = "0x3A65590", VA = "0x183A66D90")]
	public static void NGNIADILBPN<T>(this NativeList<byte> NMNMOFPMJKK, [In] T MGONBEDEDON) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3A66E40", Offset = "0x3A65640", VA = "0x183A66E40")]
	public static void NGNIADILBPN<T>(this NativeList<byte> NMNMOFPMJKK, NativeArray<T> MGONBEDEDON) where T : struct
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

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class LDUBEAYTBRI
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate ProfilerRecorderHandle ProfilerRecorderHandleGetter(ProfilerCategory category, string statName);

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ProfilerRecorderHandleGetter MTDSWQMDKDQ;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x951A0A0", Offset = "0x9518CA0", VA = "0x18951A0A0")]
		static LDUBEAYTBRI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7830", Offset = "0x3CA6430", VA = "0x183CA7830")]
		public static byte PPPJVDUOBEI<a>()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x951A020", Offset = "0x9518C20", VA = "0x18951A020")]
		public static ProfilerRecorderHandle JVHYUMLVYGU(ProfilerCategory a, string b)
		{
			return default(ProfilerRecorderHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x951A010", Offset = "0x9518C10", VA = "0x18951A010")]
		public static ProfilerCategory DVFNNUBQNQY(string a)
		{
			return default(ProfilerCategory);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct RuntimeCounterValue<T> : IEquatable<RuntimeCounterValue<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly T* valuePtr;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x64EAB70", Offset = "0x64E9770", VA = "0x1864EAB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64EADC0", Offset = "0x64E99C0", VA = "0x1864EADC0")]
		public RuntimeCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x34C59D0", Offset = "0x34C45D0", VA = "0x1834C59D0", Slot = "4")]
		public bool Equals(RuntimeCounterValue<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64EAA50", Offset = "0x64E9650", VA = "0x1864EAA50", Slot = "5")]
		public bool Equals(ProfilerCounterValue<T> other)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)2, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct RuntimeMarker : IEquatable<RuntimeMarker>, IEquatable<ProfilerMarker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public readonly struct AutoScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			[NativeDisableUnsafePtrRestriction]
			internal readonly IntPtr markerPtr;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x951A000", Offset = "0x9518C00", VA = "0x18951A000")]
			internal AutoScope(IntPtr markerPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9519FF0", Offset = "0x9518BF0", VA = "0x189519FF0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal readonly IntPtr markerPtr;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x951A3F0", Offset = "0x9518FF0", VA = "0x18951A3F0")]
		public RuntimeMarker(ushort categoryID, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x951A420", Offset = "0x9519020", VA = "0x18951A420")]
		public RuntimeMarker(ProfilerCategory category, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x951A3D0", Offset = "0x9518FD0", VA = "0x18951A3D0")]
		public AutoScope Auto()
		{
			return default(AutoScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x34C59D0", Offset = "0x34C45D0", VA = "0x1834C59D0", Slot = "4")]
		public bool Equals(RuntimeMarker other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x34C59D0", Offset = "0x34C45D0", VA = "0x1834C59D0", Slot = "5")]
		public bool Equals(ProfilerMarker other)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Profiling.Unsafe
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class SQWQXRFEABW
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA720", Offset = "0x3FE9320", VA = "0x183FEA720")]
		internal unsafe static bool KXUWVEMLFCP<T>(ProfilerCounterValue<T> a, [Out] T* b) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3826600", Offset = "0x3825200", VA = "0x183826600")]
		public static ProfilerCategory OAASQQMYEBR(ushort a)
		{
			return default(ProfilerCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x951A470", Offset = "0x9519070", VA = "0x18951A470")]
		public static ushort QZHOFMRYAAM(string a)
		{
			return default(ushort);
		}
	}
	[StructLayout((LayoutKind)2, Size = 2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ProfilerCategoryProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public ushort m_CategoryId;
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

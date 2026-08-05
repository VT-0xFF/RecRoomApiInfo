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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NDJKMMFBOCI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle GGCBJDKLBMC(ProfilerCategory CJIPCCCFEPA, string MOCCJJKGGFC);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static GGCBJDKLBMC AAIHEAOJBDN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8C34F30", Offset = "0x8C33B30", VA = "0x188C34F30")]
	static NDJKMMFBOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1640", Offset = "0x3DC0240", VA = "0x183DC1640")]
	public static byte PFPHGOFPIEF<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8C34EA0", Offset = "0x8C33AA0", VA = "0x188C34EA0")]
	public static ProfilerRecorderHandle DAANLNJDPHB(ProfilerCategory GMIIHIMKIIH, string INDJBOBMAFC)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8C34F20", Offset = "0x8C33B20", VA = "0x188C34F20")]
	public static ProfilerCategory MCDCLDKNHOB(string GMIIHIMKIIH)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BGGKBFBGIHC<T> : IEquatable<BGGKBFBGIHC<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* NDBFJINMNNC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6433200", Offset = "0x6431E00", VA = "0x186433200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6433230", Offset = "0x6431E30", VA = "0x186433230")]
	public BGGKBFBGIHC(ProfilerCategory CJIPCCCFEPA, string BKILENEPEEB, ProfilerMarkerDataUnit OAEHEGJNCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2409BB0", Offset = "0x24087B0", VA = "0x182409BB0", Slot = "4")]
	public bool Equals(BGGKBFBGIHC<T> IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6433150", Offset = "0x6431D50", VA = "0x186433150", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IFJIFILNNFC : IEquatable<IFJIFILNNFC>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct IFNHGIEAMHE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr LGFOFEBCPMP;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C34E90", Offset = "0x8C33A90", VA = "0x188C34E90")]
		internal IFNHGIEAMHE(IntPtr LGFOFEBCPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C34E80", Offset = "0x8C33A80", VA = "0x188C34E80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr LGFOFEBCPMP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8C34E50", Offset = "0x8C33A50", VA = "0x188C34E50")]
	public IFJIFILNNFC(ushort ELDPFMNKGGK, string BKILENEPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8C34E00", Offset = "0x8C33A00", VA = "0x188C34E00")]
	public IFJIFILNNFC(ProfilerCategory CJIPCCCFEPA, string BKILENEPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8C34DE0", Offset = "0x8C339E0", VA = "0x188C34DE0")]
	public IFNHGIEAMHE KHBMLLMGHCC()
	{
		return default(IFNHGIEAMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8C34DD0", Offset = "0x8C339D0", VA = "0x188C34DD0", Slot = "4")]
	public bool Equals(IFJIFILNNFC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8C34DD0", Offset = "0x8C339D0", VA = "0x188C34DD0", Slot = "5")]
	public bool Equals(ProfilerMarker IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class OLKNNLDAPFD
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3E02F40", Offset = "0x3E01B40", VA = "0x183E02F40")]
	internal unsafe static bool MJKGMKCDCMB<T>(ProfilerCounterValue<T> IPCEKCFMOIP, [Out] T* AECANIAANPG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38DD1A0", Offset = "0x38DBDA0", VA = "0x1838DD1A0")]
	public static ProfilerCategory NCKEKDOLEHD(ushort CJALGKPGNIE)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8C351C0", Offset = "0x8C33DC0", VA = "0x188C351C0")]
	public static ushort FPNOHOKAKJI(string MGONFFHNBGH)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NHAFBDKPKIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort LGKJBFGLGBN;
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

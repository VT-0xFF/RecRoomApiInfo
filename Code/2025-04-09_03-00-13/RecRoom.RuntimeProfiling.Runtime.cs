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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NDIBAIODMFF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle NPPEFAKFMCD(ProfilerCategory CMAMNCPNLFL, string AGGCDNLDFCJ);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static NPPEFAKFMCD JBOCHFOJJIN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8327880", Offset = "0x8326C80", VA = "0x188327880")]
	static NDIBAIODMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x37CAA50", Offset = "0x37C9E50", VA = "0x1837CAA50")]
	public static byte OPJEJIJHHFI<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83277F0", Offset = "0x8326BF0", VA = "0x1883277F0")]
	public static ProfilerRecorderHandle EBEALGBMIBB(ProfilerCategory HOOOCOBIOEI, string NMNCEIFABGL)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8327870", Offset = "0x8326C70", VA = "0x188327870")]
	public static ProfilerCategory OPKHFCKMNIM(string HOOOCOBIOEI)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DOFFHKEJPEM<T> : IEquatable<DOFFHKEJPEM<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* EBPAMCHNFHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66FC780", Offset = "0x66FBB80", VA = "0x1866FC780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66FCCB0", Offset = "0x66FC0B0", VA = "0x1866FCCB0")]
	public DOFFHKEJPEM(ProfilerCategory CMAMNCPNLFL, string IGEPDAOOLBO, ProfilerMarkerDataUnit POMIPFBFPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x203B450", Offset = "0x203A850", VA = "0x18203B450", Slot = "4")]
	public bool Equals(DOFFHKEJPEM<T> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66FC7C0", Offset = "0x66FBBC0", VA = "0x1866FC7C0", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DLPKLFDJGNC : IEquatable<DLPKLFDJGNC>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AAALLBFFEBH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr OHICDMELKFO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8327660", Offset = "0x8326A60", VA = "0x188327660")]
		internal AAALLBFFEBH(IntPtr OHICDMELKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8327650", Offset = "0x8326A50", VA = "0x188327650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr OHICDMELKFO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x83276F0", Offset = "0x8326AF0", VA = "0x1883276F0")]
	public DLPKLFDJGNC(ushort MBDIDMHEMIB, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x83276A0", Offset = "0x8326AA0", VA = "0x1883276A0")]
	public DLPKLFDJGNC(ProfilerCategory CMAMNCPNLFL, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8327680", Offset = "0x8326A80", VA = "0x188327680")]
	public AAALLBFFEBH FJFFMLEDJFG()
	{
		return default(AAALLBFFEBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8327670", Offset = "0x8326A70", VA = "0x188327670", Slot = "4")]
	public bool Equals(DLPKLFDJGNC KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8327670", Offset = "0x8326A70", VA = "0x188327670", Slot = "5")]
	public bool Equals(ProfilerMarker KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class KFMCBGJJHMH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36BCAE0", Offset = "0x36BBEE0", VA = "0x1836BCAE0")]
	internal unsafe static bool FNIMBAFGBMK<T>(ProfilerCounterValue<T> CNCLCOOJCND, [Out] T* LEAOLDPINHO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32BF9A0", Offset = "0x32BEDA0", VA = "0x1832BF9A0")]
	public static ProfilerCategory OCNBHBIMDDA(ushort EOPEOHEMDAF)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8327720", Offset = "0x8326B20", VA = "0x188327720")]
	public static ushort HGDHIBOOIOB(string OLPKHAIGBMN)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DEAKAOOAAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort KIOOMMLNBEM;
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

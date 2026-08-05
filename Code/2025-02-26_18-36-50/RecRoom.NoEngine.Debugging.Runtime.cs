using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MHMGNNGJBHL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class CCBJKAFBKEO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x31BBE40", Offset = "0x31BB240", VA = "0x1831BBE40")]
	public static Func<Type, bool> LNPKNDAFNOC<T>(this MHMGNNGJBHL JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x31BBFF0", Offset = "0x31BB3F0", VA = "0x1831BBFF0")]
	private static bool MOBAFLPHDJI<T>(Type FJCDLCFJEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x31BBA20", Offset = "0x31BAE20", VA = "0x1831BBA20")]
	private static bool DLOGLGOEMKL<T>(Type FJCDLCFJEBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MOANFNGHBLO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x34D19E0", Offset = "0x34D0DE0", VA = "0x1834D19E0")]
	public static string EBCCIKAPDDK<T>(T JJFHAAOAACO, string HBIPJPJMJHP = ", ", [Optional] T IDJBNLNBJCD) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34D1A80", Offset = "0x34D0E80", VA = "0x1834D1A80")]
	public static string LPCLMBCBCJG<T>(T JJFHAAOAACO, string HBIPJPJMJHP = ", ", params T[] DJOCELOJEOC) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x34D1D40", Offset = "0x34D1140", VA = "0x1834D1D40")]
	private static bool NNJEFDGJGLD<T>(T[] DJOCELOJEOC, T JFJMJEFHFHO, IEqualityComparer<T> BLMEGMHOING)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class PIKGMCHFOIM<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> AGBGCOFJPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> JKJGHOKFHFO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x50A6640", Offset = "0x50A5A40", VA = "0x1850A6640", Slot = "6")]
	public override bool CanConvert(Type FJCDLCFJEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50A6B50", Offset = "0x50A5F50", VA = "0x1850A6B50", Slot = "5")]
	public override object ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, object JOJNEODOMKD, JsonSerializer HICOCDDBAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50A6E30", Offset = "0x50A6230", VA = "0x1850A6E30", Slot = "4")]
	public override void WriteJson(JsonWriter BMEAHINCLAG, object KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4963E60", Offset = "0x4963260", VA = "0x184963E60")]
	internal PIKGMCHFOIM(Func<Type, bool> AGBGCOFJPDL, Action<JsonWriter, T> JKJGHOKFHFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HKACIJGPFOE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x33A8EA0", Offset = "0x33A82A0", VA = "0x1833A8EA0")]
	public static PIKGMCHFOIM<T> FEOBEKOIKMG<T>(Action<JsonWriter, T> JKJGHOKFHFO, MHMGNNGJBHL DDGNIIIMBCA = MHMGNNGJBHL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HFCDCOKLCHK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] NJEKHJPFBEM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter HDMABCBEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x757FFB0", Offset = "0x757F3B0", VA = "0x18757FFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter MHIDJGGKOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x757FE70", Offset = "0x757F270", VA = "0x18757FE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter DPNPJLFAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x757FF60", Offset = "0x757F360", VA = "0x18757FF60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter NBHLKFBEOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x757FEC0", Offset = "0x757F2C0", VA = "0x18757FEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter BDCFLAIIEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x757FF10", Offset = "0x757F310", VA = "0x18757FF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ENNGFPCCMJE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x757FE10", Offset = "0x757F210", VA = "0x18757FE10")]
	public static string FJAJAGDLKBG(this object JDCFMPOHCEA, JsonConverter[] FDECMJGPFNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DKNLAKOAAIK<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> AGBGCOFJPDL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x50A6640", Offset = "0x50A5A40", VA = "0x1850A6640", Slot = "6")]
	public override bool CanConvert(Type FJCDLCFJEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62B5770", Offset = "0x62B4B70", VA = "0x1862B5770", Slot = "5")]
	public override object ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, object JOJNEODOMKD, JsonSerializer HICOCDDBAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62B5840", Offset = "0x62B4C40", VA = "0x1862B5840", Slot = "4")]
	public override void WriteJson(JsonWriter BMEAHINCLAG, object KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
	internal DKNLAKOAAIK(Func<Type, bool> AGBGCOFJPDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EFKBAPNAAIJ
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3226DD0", Offset = "0x32261D0", VA = "0x183226DD0")]
	public static DKNLAKOAAIK<T> FEOBEKOIKMG<T>(MHMGNNGJBHL DDGNIIIMBCA = MHMGNNGJBHL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class PBILCJFFFJH : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> AGBGCOFJPDL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50A6640", Offset = "0x50A5A40", VA = "0x1850A6640", Slot = "6")]
	public override bool CanConvert(Type FJCDLCFJEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7580560", Offset = "0x757F960", VA = "0x187580560", Slot = "5")]
	public override object ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, object JOJNEODOMKD, JsonSerializer HICOCDDBAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7580600", Offset = "0x757FA00", VA = "0x187580600", Slot = "4")]
	public override void WriteJson(JsonWriter BMEAHINCLAG, object KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
	public PBILCJFFFJH(Func<Type, bool> AGBGCOFJPDL)
	{
	}
}
namespace Cpp2IlInjected;

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

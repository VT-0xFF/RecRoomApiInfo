using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IHIAFOOBLAL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class IOIAHCNOEMB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3E17420", Offset = "0x3E15A20", VA = "0x183E17420")]
	public static Func<Type, bool> CKKFOEABJHB<T>(this IHIAFOOBLAL CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B310", Offset = "0x3B09910", VA = "0x183B0B310")]
	private static bool EOONKFCAHMJ<T>(Type JEMGDFOINDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3E17800", Offset = "0x3E15E00", VA = "0x183E17800")]
	private static bool JEFONDCJGGA<T>(Type JEMGDFOINDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GKPOPEEBAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3DAB250", Offset = "0x3DA9850", VA = "0x183DAB250")]
	public static string NOMPDCDGOGC<T>(T FBLLKKIPJDD, string MJECFIDDIHL = ", ", [Optional] T DAKPJNHJLJO) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAD60", Offset = "0x3DA9360", VA = "0x183DAAD60")]
	public static string FDADOMGJDEM<T>(T FBLLKKIPJDD, string MJECFIDDIHL = ", ", params T[] LALHHKMCKNE) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3DAAFF0", Offset = "0x3DA95F0", VA = "0x183DAAFF0")]
	private static bool ILKHKFCBMKG<T>(T[] LALHHKMCKNE, T KNIHNMIOGJJ, IEqualityComparer<T> NBPCHKHLAIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class OLKHHEENLKG<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> JNNONGILEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> MGIJKGMLLBE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AE70", Offset = "0x2A79470", VA = "0x182A7AE70", Slot = "6")]
	public override bool CanConvert(Type JEMGDFOINDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5B89C30", Offset = "0x5B88230", VA = "0x185B89C30", Slot = "5")]
	public override object ReadJson(JsonReader EMPLJNKCONI, Type JEMGDFOINDM, object KKBDIMMDKHH, JsonSerializer KLAOHOGIDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5B8A300", Offset = "0x5B88900", VA = "0x185B8A300", Slot = "4")]
	public override void WriteJson(JsonWriter ENKMBIEHHDM, object FKMNCAKIOFK, JsonSerializer KLAOHOGIDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x567B110", Offset = "0x5679710", VA = "0x18567B110")]
	internal OLKHHEENLKG(Func<Type, bool> JNNONGILEOC, Action<JsonWriter, T> MGIJKGMLLBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NLPLDHOJFDO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F1A060", Offset = "0x3F18660", VA = "0x183F1A060")]
	public static OLKHHEENLKG<T> BPFPEFLIIPC<T>(Action<JsonWriter, T> MGIJKGMLLBE, IHIAFOOBLAL OONECBDDEBJ = IHIAFOOBLAL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BBBHMGGGGHG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] KIGHNCLMJPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter KKDAMKMLMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85CFAE0", Offset = "0x85CE0E0", VA = "0x1885CFAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter JBKCFICGJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85CFA90", Offset = "0x85CE090", VA = "0x1885CFA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter BBLLLIFEJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85CFB80", Offset = "0x85CE180", VA = "0x1885CFB80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter AHKAGPKGDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85CFA40", Offset = "0x85CE040", VA = "0x1885CFA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter JMEGLJMNEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85CFB30", Offset = "0x85CE130", VA = "0x1885CFB30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AMGAKDMEHKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85CF9E0", Offset = "0x85CDFE0", VA = "0x1885CF9E0")]
	public static string AEDPBAMPCNI(this object CCKLBDLJPNG, JsonConverter[] ENKIDODOBIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class EENBNOJEEHN<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> JNNONGILEOC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AE70", Offset = "0x2A79470", VA = "0x182A7AE70", Slot = "6")]
	public override bool CanConvert(Type JEMGDFOINDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A756A0", Offset = "0x4A73CA0", VA = "0x184A756A0", Slot = "5")]
	public override object ReadJson(JsonReader EMPLJNKCONI, Type JEMGDFOINDM, object KKBDIMMDKHH, JsonSerializer KLAOHOGIDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A75780", Offset = "0x4A73D80", VA = "0x184A75780", Slot = "4")]
	public override void WriteJson(JsonWriter ENKMBIEHHDM, object FKMNCAKIOFK, JsonSerializer KLAOHOGIDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
	internal EENBNOJEEHN(Func<Type, bool> JNNONGILEOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CKBMJEODMDJ
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A200", Offset = "0x3B88800", VA = "0x183B8A200")]
	public static EENBNOJEEHN<T> BPFPEFLIIPC<T>(IHIAFOOBLAL OONECBDDEBJ = IHIAFOOBLAL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class DHMOKCKCCHP : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> JNNONGILEOC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AE70", Offset = "0x2A79470", VA = "0x182A7AE70", Slot = "6")]
	public override bool CanConvert(Type JEMGDFOINDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85D0130", Offset = "0x85CE730", VA = "0x1885D0130", Slot = "5")]
	public override object ReadJson(JsonReader EMPLJNKCONI, Type JEMGDFOINDM, object KKBDIMMDKHH, JsonSerializer KLAOHOGIDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85D01D0", Offset = "0x85CE7D0", VA = "0x1885D01D0", Slot = "4")]
	public override void WriteJson(JsonWriter ENKMBIEHHDM, object FKMNCAKIOFK, JsonSerializer KLAOHOGIDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
	public DHMOKCKCCHP(Func<Type, bool> JNNONGILEOC)
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

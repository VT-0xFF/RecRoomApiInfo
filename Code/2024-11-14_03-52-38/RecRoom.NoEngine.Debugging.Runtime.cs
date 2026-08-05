using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BHAHFCHOHAE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class OCAMDKHFCKN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3085860", Offset = "0x3084C60", VA = "0x183085860")]
	public static Func<Type, bool> OHJBFMFJDGA<T>(this BHAHFCHOHAE EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9420", Offset = "0x2CA8820", VA = "0x182CA9420")]
	private static bool KNCINDLILKM<T>(Type GFDJLFACKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3085440", Offset = "0x3084840", VA = "0x183085440")]
	private static bool NDEENGJPFAE<T>(Type GFDJLFACKJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JBMHBEEDDMN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2F03E70", Offset = "0x2F03270", VA = "0x182F03E70")]
	public static string AANCEOHMHGD<T>(T LFKMIMEIEKO, string DODFMGCBGGJ = ", ", [Optional] T POOOEFHFGKB) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F03F10", Offset = "0x2F03310", VA = "0x182F03F10")]
	public static string CPMPPGIGMMC<T>(T LFKMIMEIEKO, string DODFMGCBGGJ = ", ", params T[] IHLJOPEBIJL) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F041D0", Offset = "0x2F035D0", VA = "0x182F041D0")]
	private static bool JKNNNFJHLGG<T>(T[] IHLJOPEBIJL, T DALMNKBBCBK, IEqualityComparer<T> LFBKIIFECDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DCNGPNONJAD<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> NLAPEPPHPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> NDGLANCBAFK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x48CBDA0", Offset = "0x48CB1A0", VA = "0x1848CBDA0", Slot = "6")]
	public override bool CanConvert(Type GFDJLFACKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7350", Offset = "0x5BE6750", VA = "0x185BE7350", Slot = "5")]
	public override object ReadJson(JsonReader ILEMOHLPHEC, Type GFDJLFACKJN, object NEAMDOJEIOJ, JsonSerializer ELCOBHNBMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7A20", Offset = "0x5BE6E20", VA = "0x185BE7A20", Slot = "4")]
	public override void WriteJson(JsonWriter FJOPPBPMLFL, object PFKKDHPJFEH, JsonSerializer ELCOBHNBMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4315AF0", Offset = "0x4314EF0", VA = "0x184315AF0")]
	internal DCNGPNONJAD(Func<Type, bool> NLAPEPPHPCJ, Action<JsonWriter, T> NDGLANCBAFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ABBNKPGEIFA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x35BF990", Offset = "0x35BED90", VA = "0x1835BF990")]
	public static DCNGPNONJAD<T> GIIIFAJNKEL<T>(Action<JsonWriter, T> NDGLANCBAFK, BHAHFCHOHAE CLJIHJBHDEH = BHAHFCHOHAE.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LGILNKGLOGJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] CDFJKABCJJL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter DNPEDOIPLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E2EDB0", Offset = "0x6E2E1B0", VA = "0x186E2EDB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter DICCGJMDEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E2EE50", Offset = "0x6E2E250", VA = "0x186E2EE50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter AKOIPKIMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2ED10", Offset = "0x6E2E110", VA = "0x186E2ED10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter BNOBBKMGEML
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2EE00", Offset = "0x6E2E200", VA = "0x186E2EE00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter IINHDGFCEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E2ED60", Offset = "0x6E2E160", VA = "0x186E2ED60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HOAPLOIBLGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E2ECB0", Offset = "0x6E2E0B0", VA = "0x186E2ECB0")]
	public static string PHBANGBKKLI(this object EAFEIEDNLNL, JsonConverter[] KNOBKCCKDIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class MHMNCFAJNKJ<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> NLAPEPPHPCJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x48CBDA0", Offset = "0x48CB1A0", VA = "0x1848CBDA0", Slot = "6")]
	public override bool CanConvert(Type GFDJLFACKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x48CBDD0", Offset = "0x48CB1D0", VA = "0x1848CBDD0", Slot = "5")]
	public override object ReadJson(JsonReader ILEMOHLPHEC, Type GFDJLFACKJN, object NEAMDOJEIOJ, JsonSerializer ELCOBHNBMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x48CBEA0", Offset = "0x48CB2A0", VA = "0x1848CBEA0", Slot = "4")]
	public override void WriteJson(JsonWriter FJOPPBPMLFL, object PFKKDHPJFEH, JsonSerializer ELCOBHNBMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
	internal MHMNCFAJNKJ(Func<Type, bool> NLAPEPPHPCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JMPEGKJJHHN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F45900", Offset = "0x2F44D00", VA = "0x182F45900")]
	public static MHMNCFAJNKJ<T> GIIIFAJNKEL<T>(BHAHFCHOHAE CLJIHJBHDEH = BHAHFCHOHAE.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class NEDNGNMIJMG : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> NLAPEPPHPCJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x48CBDA0", Offset = "0x48CB1A0", VA = "0x1848CBDA0", Slot = "6")]
	public override bool CanConvert(Type GFDJLFACKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F3F0", Offset = "0x6E2E7F0", VA = "0x186E2F3F0", Slot = "5")]
	public override object ReadJson(JsonReader ILEMOHLPHEC, Type GFDJLFACKJN, object NEAMDOJEIOJ, JsonSerializer ELCOBHNBMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F490", Offset = "0x6E2E890", VA = "0x186E2F490", Slot = "4")]
	public override void WriteJson(JsonWriter FJOPPBPMLFL, object PFKKDHPJFEH, JsonSerializer ELCOBHNBMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
	public NEDNGNMIJMG(Func<Type, bool> NLAPEPPHPCJ)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum DKMGNNIDGLL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class PGBHEHIAOPG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F68E30", Offset = "0x3F67830", VA = "0x183F68E30")]
	public static Func<Type, bool> PEFEKMLHCII<T>(this DKMGNNIDGLL DKGBCFDLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x32D3210", Offset = "0x32D1C10", VA = "0x1832D3210")]
	private static bool BKJHCPLLBDG<T>(Type EGBJFHNDMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F68A10", Offset = "0x3F67410", VA = "0x183F68A10")]
	private static bool LPLDOAAAGME<T>(Type EGBJFHNDMCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CCLBELFILOH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B86750", Offset = "0x3B85150", VA = "0x183B86750")]
	public static string AGADDCFEMNK<T>(T OGMIMHJKKEG, string HHMDGFGENDA = ", ", [Optional] T KJMOBDOKFBF) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B867E0", Offset = "0x3B851E0", VA = "0x183B867E0")]
	public static string GHBHFHCICLB<T>(T OGMIMHJKKEG, string HHMDGFGENDA = ", ", params T[] MOINBODLBEG) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B86A70", Offset = "0x3B85470", VA = "0x183B86A70")]
	private static bool LFMAEOOPLME<T>(T[] MOINBODLBEG, T MAFBHNHEGDO, IEqualityComparer<T> MELOCBAJPHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LLGHNMOOCBP<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> KMAJDDHFBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> GGFGJDHFCNB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9A70", Offset = "0x2AE8470", VA = "0x182AE9A70", Slot = "6")]
	public override bool CanConvert(Type EGBJFHNDMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5740670", Offset = "0x573F070", VA = "0x185740670", Slot = "5")]
	public override object ReadJson(JsonReader DIKMKPGIBMB, Type EGBJFHNDMCP, object IPBDJBGKODN, JsonSerializer PKOJFJHILAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5740A70", Offset = "0x573F470", VA = "0x185740A70", Slot = "4")]
	public override void WriteJson(JsonWriter EAPDKLFLMNB, object KMAFNKGMDCF, JsonSerializer PKOJFJHILAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x54EF1C0", Offset = "0x54EDBC0", VA = "0x1854EF1C0")]
	internal LLGHNMOOCBP(Func<Type, bool> KMAJDDHFBHK, Action<JsonWriter, T> GGFGJDHFCNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IAHCNGBOOKI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8EC0", Offset = "0x3DE78C0", VA = "0x183DE8EC0")]
	public static LLGHNMOOCBP<T> KDBDJPAJKDJ<T>(Action<JsonWriter, T> GGFGJDHFCNB, DKMGNNIDGLL GECNGBMCBHH = DKMGNNIDGLL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HNIEPDFIMNA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] CGKCNALJMGO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter CNHPGGBNLME
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86658B0", Offset = "0x86642B0", VA = "0x1886658B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter DMMOLLGIEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8665900", Offset = "0x8664300", VA = "0x188665900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter GOOHFOINCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8665810", Offset = "0x8664210", VA = "0x188665810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter CGJGMAOCKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8665950", Offset = "0x8664350", VA = "0x188665950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter LILPHEPCDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8665860", Offset = "0x8664260", VA = "0x188665860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HEIIPAAOPOI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86657B0", Offset = "0x86641B0", VA = "0x1886657B0")]
	public static string GDHKOMNONJO(this object DKGBCFDLMOI, JsonConverter[] NOMFAOGPKCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class EKNNHEFGDAA<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> KMAJDDHFBHK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9A70", Offset = "0x2AE8470", VA = "0x182AE9A70", Slot = "6")]
	public override bool CanConvert(Type EGBJFHNDMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B2FCA0", Offset = "0x4B2E6A0", VA = "0x184B2FCA0", Slot = "5")]
	public override object ReadJson(JsonReader DIKMKPGIBMB, Type EGBJFHNDMCP, object IPBDJBGKODN, JsonSerializer PKOJFJHILAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B2FD80", Offset = "0x4B2E780", VA = "0x184B2FD80", Slot = "4")]
	public override void WriteJson(JsonWriter EAPDKLFLMNB, object KMAFNKGMDCF, JsonSerializer PKOJFJHILAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
	internal EKNNHEFGDAA(Func<Type, bool> KMAJDDHFBHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OLCDDIANIGF
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F4EC80", Offset = "0x3F4D680", VA = "0x183F4EC80")]
	public static EKNNHEFGDAA<T> KDBDJPAJKDJ<T>(DKMGNNIDGLL GECNGBMCBHH = DKMGNNIDGLL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class EELMLCCKHID : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> KMAJDDHFBHK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9A70", Offset = "0x2AE8470", VA = "0x182AE9A70", Slot = "6")]
	public override bool CanConvert(Type EGBJFHNDMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86656A0", Offset = "0x86640A0", VA = "0x1886656A0", Slot = "5")]
	public override object ReadJson(JsonReader DIKMKPGIBMB, Type EGBJFHNDMCP, object IPBDJBGKODN, JsonSerializer PKOJFJHILAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8665740", Offset = "0x8664140", VA = "0x188665740", Slot = "4")]
	public override void WriteJson(JsonWriter EAPDKLFLMNB, object KMAFNKGMDCF, JsonSerializer PKOJFJHILAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
	public EELMLCCKHID(Func<Type, bool> KMAJDDHFBHK)
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

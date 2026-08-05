using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AFNMOBMKDHH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class BMDCAPLFFDC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x339CC70", Offset = "0x339C070", VA = "0x18339CC70")]
	public static Func<Type, bool> CFDMMGJIHBP<T>(this AFNMOBMKDHH JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x338C560", Offset = "0x338B960", VA = "0x18338C560")]
	private static bool FKFCFEBAENN<T>(Type NILLICCLHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x339D050", Offset = "0x339C450", VA = "0x18339D050")]
	private static bool MJGLIBFGBKF<T>(Type NILLICCLHIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AFPFCBDJNGC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D87610", Offset = "0x3D86A10", VA = "0x183D87610")]
	public static string BCCGNMABEGN<T>(T OEAPKNBFGIB, string JMENPDPJFNM = ", ", [Optional] T PFCPDJEHNAP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D87910", Offset = "0x3D86D10", VA = "0x183D87910")]
	public static string MKIJPPJLCBF<T>(T OEAPKNBFGIB, string JMENPDPJFNM = ", ", params T[] BGCAKDPIGDG) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D876B0", Offset = "0x3D86AB0", VA = "0x183D876B0")]
	private static bool HMIEFIADHEM<T>(T[] BGCAKDPIGDG, T JKBGMEDEBBN, IEqualityComparer<T> BJPBKLBLNPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ILNPKCBDLHB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> INIKKKADHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> IGFKABJGHBG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A23CF0", Offset = "0x4A230F0", VA = "0x184A23CF0", Slot = "6")]
	public override bool CanConvert(Type NILLICCLHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A23EC0", Offset = "0x4A232C0", VA = "0x184A23EC0", Slot = "5")]
	public override object ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, object IAGJKNIMAKN, JsonSerializer ILLAJGPAKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A244E0", Offset = "0x4A238E0", VA = "0x184A244E0", Slot = "4")]
	public override void WriteJson(JsonWriter CEAJPINGICH, object FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A04850", Offset = "0x4A03C50", VA = "0x184A04850")]
	internal ILNPKCBDLHB(Func<Type, bool> INIKKKADHFI, Action<JsonWriter, T> IGFKABJGHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MCDLGAHJONN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3727610", Offset = "0x3726A10", VA = "0x183727610")]
	public static ILNPKCBDLHB<T> HBLBJMFGHFK<T>(Action<JsonWriter, T> IGFKABJGHBG, AFNMOBMKDHH LEDHINELCFL = AFNMOBMKDHH.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DLFPNLJDJDJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] BNKNLEKIIAJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter DEAIEJOOCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79F2E80", Offset = "0x79F2280", VA = "0x1879F2E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter LFKGJENCHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x79F2F20", Offset = "0x79F2320", VA = "0x1879F2F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter GLNCHIOGPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79F2E30", Offset = "0x79F2230", VA = "0x1879F2E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter BGMBBBCMJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x79F2F70", Offset = "0x79F2370", VA = "0x1879F2F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter PJINMABBEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79F2ED0", Offset = "0x79F22D0", VA = "0x1879F2ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PMGEOAJHHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79F35E0", Offset = "0x79F29E0", VA = "0x1879F35E0")]
	public static string LCHIBOGNELL(this object JOCJBPPJMJJ, JsonConverter[] PCFFOBIIDDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class PNGMCCCFIOL<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> INIKKKADHFI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A23CF0", Offset = "0x4A230F0", VA = "0x184A23CF0", Slot = "6")]
	public override bool CanConvert(Type NILLICCLHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5359E20", Offset = "0x5359220", VA = "0x185359E20", Slot = "5")]
	public override object ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, object IAGJKNIMAKN, JsonSerializer ILLAJGPAKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5359EF0", Offset = "0x53592F0", VA = "0x185359EF0", Slot = "4")]
	public override void WriteJson(JsonWriter CEAJPINGICH, object FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
	internal PNGMCCCFIOL(Func<Type, bool> INIKKKADHFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BBIACOEGFLK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3388310", Offset = "0x3387710", VA = "0x183388310")]
	public static PNGMCCCFIOL<T> HBLBJMFGHFK<T>(AFNMOBMKDHH LEDHINELCFL = AFNMOBMKDHH.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OHFNCGMKFHG : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> INIKKKADHFI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A23CF0", Offset = "0x4A230F0", VA = "0x184A23CF0", Slot = "6")]
	public override bool CanConvert(Type NILLICCLHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x79F34D0", Offset = "0x79F28D0", VA = "0x1879F34D0", Slot = "5")]
	public override object ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, object IAGJKNIMAKN, JsonSerializer ILLAJGPAKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79F3570", Offset = "0x79F2970", VA = "0x1879F3570", Slot = "4")]
	public override void WriteJson(JsonWriter CEAJPINGICH, object FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
	public OHFNCGMKFHG(Func<Type, bool> INIKKKADHFI)
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

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MDMPOADKICD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class LLIDMPIIPLH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x244F8A0", Offset = "0x244ECA0", VA = "0x18244F8A0")]
	public static Func<Type, bool> ONJAOFCAOMM<T>(this MDMPOADKICD CLFMFOEGLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1FF24F0", Offset = "0x1FF18F0", VA = "0x181FF24F0")]
	private static bool KELKJFBDLCG<T>(Type LOCBBBKMLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x244F480", Offset = "0x244E880", VA = "0x18244F480")]
	private static bool KNHOBGFKADG<T>(Type LOCBBBKMLDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class OLKOOBHENDK<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> KMCJOCAFMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> GBDEGNGCCFO;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2390", Offset = "0x3CF1790", VA = "0x183CF2390", Slot = "6")]
	public override bool CanConvert(Type LOCBBBKMLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2900", Offset = "0x3CF1D00", VA = "0x183CF2900", Slot = "5")]
	public override object ReadJson(JsonReader FCCGPHFBEFP, Type LOCBBBKMLDK, object JDABKOELJDP, JsonSerializer EHDKAJFMMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2CE0", Offset = "0x3CF20E0", VA = "0x183CF2CE0", Slot = "4")]
	public override void WriteJson(JsonWriter OKFNJFEOHFM, object LPCGJALKADL, JsonSerializer EHDKAJFMMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35F39F0", Offset = "0x35F2DF0", VA = "0x1835F39F0")]
	internal OLKOOBHENDK(Func<Type, bool> KMCJOCAFMKD, Action<JsonWriter, T> GBDEGNGCCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LFKNCKCKNFA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x244CF30", Offset = "0x244C330", VA = "0x18244CF30")]
	public static OLKOOBHENDK<T> CLFIPFKIGEN<T>(Action<JsonWriter, T> GBDEGNGCCFO, MDMPOADKICD JANHMOCJFGE = MDMPOADKICD.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OCOACMKHCEO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] LABENJBBPNC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter JBGPIIKOIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D50C70", Offset = "0x5D50070", VA = "0x185D50C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter IICLHNDJAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D50D10", Offset = "0x5D50110", VA = "0x185D50D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter ABIDOGGGPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D50D60", Offset = "0x5D50160", VA = "0x185D50D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter MJEHPPPHCMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D50DB0", Offset = "0x5D501B0", VA = "0x185D50DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter NODOBIFOHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D50CC0", Offset = "0x5D500C0", VA = "0x185D50CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OILPOIBNPIA
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D51350", Offset = "0x5D50750", VA = "0x185D51350")]
	public static string KFKGJADCCPK(this object CLFMFOEGLFG, JsonConverter[] EPHPGKPOPKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DPGKEFFDIHJ<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> KMCJOCAFMKD;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2390", Offset = "0x3CF1790", VA = "0x183CF2390", Slot = "6")]
	public override bool CanConvert(Type LOCBBBKMLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D24100", Offset = "0x4D23500", VA = "0x184D24100", Slot = "5")]
	public override object ReadJson(JsonReader FCCGPHFBEFP, Type LOCBBBKMLDK, object JDABKOELJDP, JsonSerializer EHDKAJFMMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D241E0", Offset = "0x4D235E0", VA = "0x184D241E0", Slot = "4")]
	public override void WriteJson(JsonWriter OKFNJFEOHFM, object LPCGJALKADL, JsonSerializer EHDKAJFMMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
	internal DPGKEFFDIHJ(Func<Type, bool> KMCJOCAFMKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NJMDCPACHIC
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x24E5B50", Offset = "0x24E4F50", VA = "0x1824E5B50")]
	public static DPGKEFFDIHJ<T> CLFIPFKIGEN<T>(MDMPOADKICD JANHMOCJFGE = MDMPOADKICD.Assignable)
	{
		return null;
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

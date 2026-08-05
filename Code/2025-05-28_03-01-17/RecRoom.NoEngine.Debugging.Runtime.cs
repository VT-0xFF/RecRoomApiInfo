using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GOIMEJAJLHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class NDDJKPGKEDC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3A96E60", Offset = "0x3A95C60", VA = "0x183A96E60")]
	public static Func<Type, bool> LPPEJFIMLGI<T>(this GOIMEJAJLHJ FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36A6380", Offset = "0x36A5180", VA = "0x1836A6380")]
	private static bool GIPLFFNCGFH<T>(Type AOLGCDMJHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3A96A40", Offset = "0x3A95840", VA = "0x183A96A40")]
	private static bool HNFOOHIFJGC<T>(Type AOLGCDMJHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PGICDJEALNO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D760", Offset = "0x3B1C560", VA = "0x183B1D760")]
	public static string HPIGPPDBJOA<T>(T JMDMECFGMML, string GKEIAPNDPFM = ", ", [Optional] T LDGCNLHOBMI) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D800", Offset = "0x3B1C600", VA = "0x183B1D800")]
	public static string NLMDDGEJGGM<T>(T JMDMECFGMML, string GKEIAPNDPFM = ", ", params T[] EDMMMPAFBIG) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D500", Offset = "0x3B1C300", VA = "0x183B1D500")]
	private static bool HGFHBDDALPC<T>(T[] EDMMMPAFBIG, T BFCGDPAMADE, IEqualityComparer<T> EDPFJJMAPIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class AMMENEPGHOJ<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> EMLPJIOKDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> HPPAAPPKHLE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80", Slot = "6")]
	public override bool CanConvert(Type AOLGCDMJHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4DC5750", Offset = "0x4DC4550", VA = "0x184DC5750", Slot = "5")]
	public override object ReadJson(JsonReader JFLBMHOJFED, Type AOLGCDMJHLF, object EHICLHKBCNI, JsonSerializer NLHBNAANHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4DC58F0", Offset = "0x4DC46F0", VA = "0x184DC58F0", Slot = "4")]
	public override void WriteJson(JsonWriter KMFJBCLMGLE, object OAIIHELJHLG, JsonSerializer NLHBNAANHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4DC5B80", Offset = "0x4DC4980", VA = "0x184DC5B80")]
	internal AMMENEPGHOJ(Func<Type, bool> EMLPJIOKDHP, Action<JsonWriter, T> HPPAAPPKHLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AAMDFNBONGG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x41369E0", Offset = "0x41357E0", VA = "0x1841369E0")]
	public static AMMENEPGHOJ<T> NBEICDCLFEE<T>(Action<JsonWriter, T> HPPAAPPKHLE, GOIMEJAJLHJ BPOFCHPPCHH = GOIMEJAJLHJ.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OACGDCDFONK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] JCPINDJNAKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter KPICCKMHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F07850", Offset = "0x7F06650", VA = "0x187F07850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter IFJAAMPJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F07760", Offset = "0x7F06560", VA = "0x187F07760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter GIFAAAJHGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F077B0", Offset = "0x7F065B0", VA = "0x187F077B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter DCMLJPAEFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F07800", Offset = "0x7F06600", VA = "0x187F07800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter DKGEDFLKKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F07710", Offset = "0x7F06510", VA = "0x187F07710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DDFDDMDNNKP
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F075A0", Offset = "0x7F063A0", VA = "0x187F075A0")]
	public static string KNBCJGHNNJD(this object FPFHIDBMBMI, JsonConverter[] GCOJBHPPBFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class IAFCOIDLHAM<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> EMLPJIOKDHP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80", Slot = "6")]
	public override bool CanConvert(Type AOLGCDMJHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D23A20", Offset = "0x4D22820", VA = "0x184D23A20", Slot = "5")]
	public override object ReadJson(JsonReader JFLBMHOJFED, Type AOLGCDMJHLF, object EHICLHKBCNI, JsonSerializer NLHBNAANHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D23AF0", Offset = "0x4D228F0", VA = "0x184D23AF0", Slot = "4")]
	public override void WriteJson(JsonWriter KMFJBCLMGLE, object OAIIHELJHLG, JsonSerializer NLHBNAANHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
	internal IAFCOIDLHAM(Func<Type, bool> EMLPJIOKDHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FJENIDPAJPE
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38E8EB0", Offset = "0x38E7CB0", VA = "0x1838E8EB0")]
	public static IAFCOIDLHAM<T> NBEICDCLFEE<T>(GOIMEJAJLHJ BPOFCHPPCHH = GOIMEJAJLHJ.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class DLGALMIMFMG : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> EMLPJIOKDHP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80", Slot = "6")]
	public override bool CanConvert(Type AOLGCDMJHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F07600", Offset = "0x7F06400", VA = "0x187F07600", Slot = "5")]
	public override object ReadJson(JsonReader JFLBMHOJFED, Type AOLGCDMJHLF, object EHICLHKBCNI, JsonSerializer NLHBNAANHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F076A0", Offset = "0x7F064A0", VA = "0x187F076A0", Slot = "4")]
	public override void WriteJson(JsonWriter KMFJBCLMGLE, object OAIIHELJHLG, JsonSerializer NLHBNAANHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
	public DLGALMIMFMG(Func<Type, bool> EMLPJIOKDHP)
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

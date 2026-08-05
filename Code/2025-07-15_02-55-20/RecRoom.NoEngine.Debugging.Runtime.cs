using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HEAPOJJHFBB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class EGPDPLMCDGH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3ABADB0", Offset = "0x3AB99B0", VA = "0x183ABADB0")]
	public static Func<Type, bool> CGEGMMNGFMD<T>(this HEAPOJJHFBB JBDFDFABHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x39BF2F0", Offset = "0x39BDEF0", VA = "0x1839BF2F0")]
	private static bool OADEPGJNBGP<T>(Type JGFNGJHIJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB190", Offset = "0x3AB9D90", VA = "0x183ABB190")]
	private static bool JHCLKODKDFA<T>(Type JGFNGJHIJOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FMOMFMLCAMB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BFF0", Offset = "0x3C2ABF0", VA = "0x183C2BFF0")]
	public static string HLNLPDBABNF<T>(T IILFEKLIFDP, string DMHFJKFIMDK = ", ", [Optional] T PLEDLJICBFM) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C2E0", Offset = "0x3C2AEE0", VA = "0x183C2C2E0")]
	public static string KBLLLLBLJDC<T>(T IILFEKLIFDP, string DMHFJKFIMDK = ", ", params T[] NJAFMHANIPF) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C080", Offset = "0x3C2AC80", VA = "0x183C2C080")]
	private static bool JFGLCFHCJFP<T>(T[] NJAFMHANIPF, T KDCPEPKOEEE, IEqualityComparer<T> FLFBEHPGIBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NAFLHDAFMMO<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> FJMGFPPLGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> KNMBALONDEG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x299F790", Offset = "0x299E390", VA = "0x18299F790", Slot = "6")]
	public override bool CanConvert(Type JGFNGJHIJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x56ED640", Offset = "0x56EC240", VA = "0x1856ED640", Slot = "5")]
	public override object ReadJson(JsonReader NOIAIJBDKGG, Type JGFNGJHIJOE, object ABLHOHBPANP, JsonSerializer JKAPPJFLKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x56ED980", Offset = "0x56EC580", VA = "0x1856ED980", Slot = "4")]
	public override void WriteJson(JsonWriter HDDCOPOMJML, object BKMPCFIAHIG, JsonSerializer JKAPPJFLKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x525B0D0", Offset = "0x5259CD0", VA = "0x18525B0D0")]
	internal NAFLHDAFMMO(Func<Type, bool> FJMGFPPLGFA, Action<JsonWriter, T> KNMBALONDEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NLAFLPMNLJO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9C70", Offset = "0x3DC8870", VA = "0x183DC9C70")]
	public static NAFLHDAFMMO<T> MJMNOIPJNFN<T>(Action<JsonWriter, T> KNMBALONDEG, HEAPOJJHFBB DOBFMNGADOA = HEAPOJJHFBB.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ANHGBDLDAHG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] HNABLFCAAEN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter CLHHBHFGCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8269360", Offset = "0x8267F60", VA = "0x188269360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter HLEDIPHIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8269450", Offset = "0x8268050", VA = "0x188269450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter IHMLILNJEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82694A0", Offset = "0x82680A0", VA = "0x1882694A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter GKOAGIIPHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82693B0", Offset = "0x8267FB0", VA = "0x1882693B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter HELFHNLDLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8269400", Offset = "0x8268000", VA = "0x188269400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CGCEBPNKCCE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8269A50", Offset = "0x8268650", VA = "0x188269A50")]
	public static string FOADPCLGDCE(this object JBDFDFABHKD, JsonConverter[] NAAEEAGAKOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class MEJNGEFCBAF<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> FJMGFPPLGFA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x299F790", Offset = "0x299E390", VA = "0x18299F790", Slot = "6")]
	public override bool CanConvert(Type JGFNGJHIJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x566C9E0", Offset = "0x566B5E0", VA = "0x18566C9E0", Slot = "5")]
	public override object ReadJson(JsonReader NOIAIJBDKGG, Type JGFNGJHIJOE, object ABLHOHBPANP, JsonSerializer JKAPPJFLKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x566CAB0", Offset = "0x566B6B0", VA = "0x18566CAB0", Slot = "4")]
	public override void WriteJson(JsonWriter HDDCOPOMJML, object BKMPCFIAHIG, JsonSerializer JKAPPJFLKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
	internal MEJNGEFCBAF(Func<Type, bool> FJMGFPPLGFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EKCGIAJMOAK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD220", Offset = "0x3ABBE20", VA = "0x183ABD220")]
	public static MEJNGEFCBAF<T> MJMNOIPJNFN<T>(HEAPOJJHFBB DOBFMNGADOA = HEAPOJJHFBB.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class IFILAEKALJL : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> FJMGFPPLGFA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x299F790", Offset = "0x299E390", VA = "0x18299F790", Slot = "6")]
	public override bool CanConvert(Type JGFNGJHIJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8269AB0", Offset = "0x82686B0", VA = "0x188269AB0", Slot = "5")]
	public override object ReadJson(JsonReader NOIAIJBDKGG, Type JGFNGJHIJOE, object ABLHOHBPANP, JsonSerializer JKAPPJFLKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8269B50", Offset = "0x8268750", VA = "0x188269B50", Slot = "4")]
	public override void WriteJson(JsonWriter HDDCOPOMJML, object BKMPCFIAHIG, JsonSerializer JKAPPJFLKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
	public IFILAEKALJL(Func<Type, bool> FJMGFPPLGFA)
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

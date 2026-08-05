using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BOBINLEBJMP
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class HLFNNGMMFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x338FC30", Offset = "0x338E830", VA = "0x18338FC30")]
	public static Func<Type, bool> HCMMIFONJAJ<T>(this BOBINLEBJMP DKGDAEBOJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x30EA910", Offset = "0x30E9510", VA = "0x1830EA910")]
	private static bool AEJLPEEKKDC<T>(Type NCAKCNAOHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x338F810", Offset = "0x338E410", VA = "0x18338F810")]
	private static bool GGKMELLAFBC<T>(Type NCAKCNAOHMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ADHLCHAFGKI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA730", Offset = "0x3AB9330", VA = "0x183ABA730")]
	public static string BKHFKEAIKAI<T>(T HLFIFJFGNJJ, string KHKEPDLCAMC = ", ", [Optional] T NBKBMLNEBHK) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAA30", Offset = "0x3AB9630", VA = "0x183ABAA30")]
	public static string KALPMGMOHCK<T>(T HLFIFJFGNJJ, string KHKEPDLCAMC = ", ", params T[] JGDMHAGBHOB) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA7D0", Offset = "0x3AB93D0", VA = "0x183ABA7D0")]
	private static bool CMLOHDEJFMJ<T>(T[] JGDMHAGBHOB, T DLDAGIPJFND, IEqualityComparer<T> CFOLKBKPHDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FAELIOPNJKL<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> HLEKCPPLELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> DFIGPMAHPIB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4388150", Offset = "0x4386D50", VA = "0x184388150", Slot = "6")]
	public override bool CanConvert(Type NCAKCNAOHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43886C0", Offset = "0x43872C0", VA = "0x1843886C0", Slot = "5")]
	public override object ReadJson(JsonReader KLCLFHDKNAH, Type NCAKCNAOHMK, object KFKMMPLHILJ, JsonSerializer EEPGGELCPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4388880", Offset = "0x4387480", VA = "0x184388880", Slot = "4")]
	public override void WriteJson(JsonWriter DGOPMEPLAFF, object MPDLOLIOGJL, JsonSerializer EEPGGELCPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4388E80", Offset = "0x4387A80", VA = "0x184388E80")]
	internal FAELIOPNJKL(Func<Type, bool> HLEKCPPLELP, Action<JsonWriter, T> DFIGPMAHPIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MEABFNHMKKM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3469F00", Offset = "0x3468B00", VA = "0x183469F00")]
	public static FAELIOPNJKL<T> JPHABLICNHB<T>(Action<JsonWriter, T> DFIGPMAHPIB, BOBINLEBJMP KCNLAACPMMO = BOBINLEBJMP.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PLOJNMNCJAH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] EHDJICMHPPO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter DHKPAECKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75BFE40", Offset = "0x75BEA40", VA = "0x1875BFE40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter FGHBIJIOHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75BFD50", Offset = "0x75BE950", VA = "0x1875BFD50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter BCPMABILOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75BFD00", Offset = "0x75BE900", VA = "0x1875BFD00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter BEBOOLEPACP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75BFDA0", Offset = "0x75BE9A0", VA = "0x1875BFDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter BGHJEBFFCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75BFDF0", Offset = "0x75BE9F0", VA = "0x1875BFDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HPEPPDJGMCP
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75BFCA0", Offset = "0x75BE8A0", VA = "0x1875BFCA0")]
	public static string AKGANNHDGAI(this object DKGDAEBOJKO, JsonConverter[] AEBOBJJKNGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BNMJCINNAJB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> HLEKCPPLELP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4388150", Offset = "0x4386D50", VA = "0x184388150", Slot = "6")]
	public override bool CanConvert(Type NCAKCNAOHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x581FAE0", Offset = "0x581E6E0", VA = "0x18581FAE0", Slot = "5")]
	public override object ReadJson(JsonReader KLCLFHDKNAH, Type NCAKCNAOHMK, object KFKMMPLHILJ, JsonSerializer EEPGGELCPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x581FBC0", Offset = "0x581E7C0", VA = "0x18581FBC0", Slot = "4")]
	public override void WriteJson(JsonWriter DGOPMEPLAFF, object MPDLOLIOGJL, JsonSerializer EEPGGELCPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
	internal BNMJCINNAJB(Func<Type, bool> HLEKCPPLELP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AHGKDKJEBCN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE8C0", Offset = "0x3ABD4C0", VA = "0x183ABE8C0")]
	public static BNMJCINNAJB<T> JPHABLICNHB<T>(BOBINLEBJMP KCNLAACPMMO = BOBINLEBJMP.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class BAEMDJPEION : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> HLEKCPPLELP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4388150", Offset = "0x4386D50", VA = "0x184388150", Slot = "6")]
	public override bool CanConvert(Type NCAKCNAOHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x75BFB90", Offset = "0x75BE790", VA = "0x1875BFB90", Slot = "5")]
	public override object ReadJson(JsonReader KLCLFHDKNAH, Type NCAKCNAOHMK, object KFKMMPLHILJ, JsonSerializer EEPGGELCPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75BFC30", Offset = "0x75BE830", VA = "0x1875BFC30", Slot = "4")]
	public override void WriteJson(JsonWriter DGOPMEPLAFF, object MPDLOLIOGJL, JsonSerializer EEPGGELCPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
	public BAEMDJPEION(Func<Type, bool> HLEKCPPLELP)
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

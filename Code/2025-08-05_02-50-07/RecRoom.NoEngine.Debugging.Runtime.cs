using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BLBDJDJELBO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class AKGMHCPHJIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x31F9FA0", Offset = "0x31F93A0", VA = "0x1831F9FA0")]
	public static Func<Type, bool> HPDEPFEPGIK<T>(this BLBDJDJELBO DMFKPMONDPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FD0", Offset = "0x31E73D0", VA = "0x1831E7FD0")]
	private static bool OBOFFLFLFCL<T>(Type LKHMPELKIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x31FA380", Offset = "0x31F9780", VA = "0x1831FA380")]
	private static bool OIMKIPIDFBD<T>(Type LKHMPELKIJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HAINNPIGKPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD220", Offset = "0x3CBC620", VA = "0x183CBD220")]
	public static string DBHOLKCMKIH<T>(T JFDJMGGLGMC, string DPGBFBHJPDN = ", ", [Optional] T ABINAMGBLJP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD2B0", Offset = "0x3CBC6B0", VA = "0x183CBD2B0")]
	public static string FNGCMBILCHI<T>(T JFDJMGGLGMC, string DPGBFBHJPDN = ", ", params T[] LPDHCDKMCIJ) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD540", Offset = "0x3CBC940", VA = "0x183CBD540")]
	private static bool GGCJNBPKJPO<T>(T[] LPDHCDKMCIJ, T HMHEELDKLNE, IEqualityComparer<T> LJGHFBEMAIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ANMGBCBMNBL<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> PJAALDNNBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> BNMOHHIAFMO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B0B0", Offset = "0x2A0A4B0", VA = "0x182A0B0B0", Slot = "6")]
	public override bool CanConvert(Type LKHMPELKIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x52BF250", Offset = "0x52BE650", VA = "0x1852BF250", Slot = "5")]
	public override object ReadJson(JsonReader BPCOJLPPMNI, Type LKHMPELKIJH, object PJEFBKKJBCH, JsonSerializer GBOEJHCDIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x52BF710", Offset = "0x52BEB10", VA = "0x1852BF710", Slot = "4")]
	public override void WriteJson(JsonWriter HNNLPFDFOLO, object CBMEHPPMEEA, JsonSerializer GBOEJHCDIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x52BF940", Offset = "0x52BED40", VA = "0x1852BF940")]
	internal ANMGBCBMNBL(Func<Type, bool> PJAALDNNBCN, Action<JsonWriter, T> BNMOHHIAFMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DKBPFNPBHMD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3B0AA10", Offset = "0x3B09E10", VA = "0x183B0AA10")]
	public static ANMGBCBMNBL<T> EJOLKNBPCJB<T>(Action<JsonWriter, T> BNMOHHIAFMO, BLBDJDJELBO PAELKHJNIJL = BLBDJDJELBO.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LCFLKKBEPLO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] HCEJPJJABBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter HBLGFPBODAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8419EB0", Offset = "0x84192B0", VA = "0x188419EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter HCDCHGDIFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8419E10", Offset = "0x8419210", VA = "0x188419E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter NONAMAPDNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8419DC0", Offset = "0x84191C0", VA = "0x188419DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter ILGMJAJILCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8419E60", Offset = "0x8419260", VA = "0x188419E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter FFBMFIGMNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8419D70", Offset = "0x8419170", VA = "0x188419D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LOEBFFOPMGF
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x841A460", Offset = "0x8419860", VA = "0x18841A460")]
	public static string FLAGDIGOKCD(this object DMFKPMONDPO, JsonConverter[] ODBNFKPEGIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class MBOFJPAPJEM<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> PJAALDNNBCN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B0B0", Offset = "0x2A0A4B0", VA = "0x182A0B0B0", Slot = "6")]
	public override bool CanConvert(Type LKHMPELKIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x576AB80", Offset = "0x5769F80", VA = "0x18576AB80", Slot = "5")]
	public override object ReadJson(JsonReader BPCOJLPPMNI, Type LKHMPELKIJH, object PJEFBKKJBCH, JsonSerializer GBOEJHCDIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x576AC50", Offset = "0x576A050", VA = "0x18576AC50", Slot = "4")]
	public override void WriteJson(JsonWriter HNNLPFDFOLO, object CBMEHPPMEEA, JsonSerializer GBOEJHCDIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
	internal MBOFJPAPJEM(Func<Type, bool> PJAALDNNBCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LAOJPLDJPPC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D924C0", Offset = "0x3D918C0", VA = "0x183D924C0")]
	public static MBOFJPAPJEM<T> EJOLKNBPCJB<T>(BLBDJDJELBO PAELKHJNIJL = BLBDJDJELBO.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class LCDPGGHCHAI : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> PJAALDNNBCN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B0B0", Offset = "0x2A0A4B0", VA = "0x182A0B0B0", Slot = "6")]
	public override bool CanConvert(Type LKHMPELKIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8419C60", Offset = "0x8419060", VA = "0x188419C60", Slot = "5")]
	public override object ReadJson(JsonReader BPCOJLPPMNI, Type LKHMPELKIJH, object PJEFBKKJBCH, JsonSerializer GBOEJHCDIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8419D00", Offset = "0x8419100", VA = "0x188419D00", Slot = "4")]
	public override void WriteJson(JsonWriter HNNLPFDFOLO, object CBMEHPPMEEA, JsonSerializer GBOEJHCDIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
	public LCDPGGHCHAI(Func<Type, bool> PJAALDNNBCN)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CIHKKBOICFP
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class PBDDEDJPPEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3456150", Offset = "0x3455350", VA = "0x183456150")]
	public static Func<Type, bool> EBFNHCEECBK<T>(this CIHKKBOICFP MLNFAKCEGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3053920", Offset = "0x3052B20", VA = "0x183053920")]
	private static bool FAMFGCGFJEJ<T>(Type GJIPAHMPFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3456530", Offset = "0x3455730", VA = "0x183456530")]
	private static bool IJIDPLLAHEB<T>(Type GJIPAHMPFDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MGENABHLKFN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3370700", Offset = "0x336F900", VA = "0x183370700")]
	public static string EEKAKOABOFN<T>(T NEBBNLAKKGH, string PEEMFFODCDP = ", ", [Optional] T JEBHMGJFPIP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3370440", Offset = "0x336F640", VA = "0x183370440")]
	public static string CLAFOFAPHPC<T>(T NEBBNLAKKGH, string PEEMFFODCDP = ", ", params T[] NOAOEFCHOID) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x33707A0", Offset = "0x336F9A0", VA = "0x1833707A0")]
	private static bool IHBAAOJIKLH<T>(T[] NOAOEFCHOID, T CGDNKIJMMML, IEqualityComparer<T> FHMDPOEGNHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NMCBEBMMDHC<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> ILIODPJCCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> CLKCDCMCGPJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C84050", Offset = "0x4C83250", VA = "0x184C84050", Slot = "6")]
	public override bool CanConvert(Type GJIPAHMPFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C8DDE0", Offset = "0x4C8CFE0", VA = "0x184C8DDE0", Slot = "5")]
	public override object ReadJson(JsonReader NHPBIOODHLE, Type GJIPAHMPFDJ, object NOPDOCHAACL, JsonSerializer PDHMGKJMMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E7A0", Offset = "0x4C8D9A0", VA = "0x184C8E7A0", Slot = "4")]
	public override void WriteJson(JsonWriter JPECNBJOJNA, object OMEFCJCOLII, JsonSerializer PDHMGKJMMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4651700", Offset = "0x4650900", VA = "0x184651700")]
	internal NMCBEBMMDHC(Func<Type, bool> ILIODPJCCPK, Action<JsonWriter, T> CLKCDCMCGPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FECPFMCJKCE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x32488A0", Offset = "0x3247AA0", VA = "0x1832488A0")]
	public static NMCBEBMMDHC<T> PAJOIGLPBMN<T>(Action<JsonWriter, T> CLKCDCMCGPJ, CIHKKBOICFP GEHJLPHGKEG = CIHKKBOICFP.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NDENJFMPJDJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] IEEDPJIFCHL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter AJKMPHDBGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x732D4B0", Offset = "0x732C6B0", VA = "0x18732D4B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter MAAGOGHPEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x732D3C0", Offset = "0x732C5C0", VA = "0x18732D3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter IBMOPPFKMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x732D500", Offset = "0x732C700", VA = "0x18732D500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter MDJIDHMPFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x732D410", Offset = "0x732C610", VA = "0x18732D410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter EDCDONDKOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x732D460", Offset = "0x732C660", VA = "0x18732D460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MAKBECGJEPC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x732D360", Offset = "0x732C560", VA = "0x18732D360")]
	public static string ALJPJLMKBFO(this object MLNFAKCEGNM, JsonConverter[] NCCEDKKAGDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class NJBMNHIAJJF<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> ILIODPJCCPK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4C84050", Offset = "0x4C83250", VA = "0x184C84050", Slot = "6")]
	public override bool CanConvert(Type GJIPAHMPFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4C84080", Offset = "0x4C83280", VA = "0x184C84080", Slot = "5")]
	public override object ReadJson(JsonReader NHPBIOODHLE, Type GJIPAHMPFDJ, object NOPDOCHAACL, JsonSerializer PDHMGKJMMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4C84150", Offset = "0x4C83350", VA = "0x184C84150", Slot = "4")]
	public override void WriteJson(JsonWriter JPECNBJOJNA, object OMEFCJCOLII, JsonSerializer PDHMGKJMMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
	internal NJBMNHIAJJF(Func<Type, bool> ILIODPJCCPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BKNKBOJKMNA
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3053400", Offset = "0x3052600", VA = "0x183053400")]
	public static NJBMNHIAJJF<T> PAJOIGLPBMN<T>(CIHKKBOICFP GEHJLPHGKEG = CIHKKBOICFP.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class FNNPBEMFDDO : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> ILIODPJCCPK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C84050", Offset = "0x4C83250", VA = "0x184C84050", Slot = "6")]
	public override bool CanConvert(Type GJIPAHMPFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x732D250", Offset = "0x732C450", VA = "0x18732D250", Slot = "5")]
	public override object ReadJson(JsonReader NHPBIOODHLE, Type GJIPAHMPFDJ, object NOPDOCHAACL, JsonSerializer PDHMGKJMMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x732D2F0", Offset = "0x732C4F0", VA = "0x18732D2F0", Slot = "4")]
	public override void WriteJson(JsonWriter JPECNBJOJNA, object OMEFCJCOLII, JsonSerializer PDHMGKJMMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
	public FNNPBEMFDDO(Func<Type, bool> ILIODPJCCPK)
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

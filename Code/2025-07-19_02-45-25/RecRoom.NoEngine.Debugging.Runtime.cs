using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FOPHEIPECBP
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class BIMKENOLGKF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x39D7DE0", Offset = "0x39D6DE0", VA = "0x1839D7DE0")]
	public static Func<Type, bool> IFLDMPFMPHD<T>(this FOPHEIPECBP OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x39D7AF0", Offset = "0x39D6AF0", VA = "0x1839D7AF0")]
	private static bool DBJNCIBBKOD<T>(Type LOAKNADDLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x39D81C0", Offset = "0x39D71C0", VA = "0x1839D81C0")]
	private static bool LIIDCJPAEOA<T>(Type LOAKNADDLOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PGJPJODKIIC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3E38F00", Offset = "0x3E37F00", VA = "0x183E38F00")]
	public static string LLEEFEAJPGB<T>(T EINBKGFECKN, string CJPCENHFFFB = ", ", [Optional] T CAILINJCNIJ) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3E38F90", Offset = "0x3E37F90", VA = "0x183E38F90")]
	public static string OCNFEELJIHG<T>(T EINBKGFECKN, string CJPCENHFFFB = ", ", params T[] OIBLNIGDNHA) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E39220", Offset = "0x3E38220", VA = "0x183E39220")]
	private static bool OMFJJGOOGEL<T>(T[] OIBLNIGDNHA, T HOJOECLHBEJ, IEqualityComparer<T> FFIFKGOLOOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LPEGBGLLFOE<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> NHKHFFCNGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> OHKGJCGHMFB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29C57B0", Offset = "0x29C47B0", VA = "0x1829C57B0", Slot = "6")]
	public override bool CanConvert(Type LOAKNADDLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x54BECE0", Offset = "0x54BDCE0", VA = "0x1854BECE0", Slot = "5")]
	public override object ReadJson(JsonReader AMPJMGIAGBB, Type LOAKNADDLOC, object NJJANHLNDFL, JsonSerializer EPFLIAPJNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x54BF460", Offset = "0x54BE460", VA = "0x1854BF460", Slot = "4")]
	public override void WriteJson(JsonWriter NMCAGOGLPLD, object IOALKPFEKEK, JsonSerializer EPFLIAPJNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5375110", Offset = "0x5374110", VA = "0x185375110")]
	internal LPEGBGLLFOE(Func<Type, bool> NHKHFFCNGGB, Action<JsonWriter, T> OHKGJCGHMFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NFONKFACABA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF26B0", Offset = "0x3DF16B0", VA = "0x183DF26B0")]
	public static LPEGBGLLFOE<T> MPFKOOIPONO<T>(Action<JsonWriter, T> OHKGJCGHMFB, FOPHEIPECBP PJELHHJBILL = FOPHEIPECBP.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PPOMEJNKACO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] KPKKJEMJAFH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter OCJIJJECOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82E03A0", Offset = "0x82DF3A0", VA = "0x1882E03A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter IPIGNCIIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82E0440", Offset = "0x82DF440", VA = "0x1882E0440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter IBKHFOOACBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82E04E0", Offset = "0x82DF4E0", VA = "0x1882E04E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter NLLEKMLJIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82E03F0", Offset = "0x82DF3F0", VA = "0x1882E03F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter NECLCCIPOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82E0490", Offset = "0x82DF490", VA = "0x1882E0490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FJGILICMJHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82E0230", Offset = "0x82DF230", VA = "0x1882E0230")]
	public static string CGBAJPPPECO(this object OLHDOIOOPGE, JsonConverter[] MBLJHAMBOHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class CFEJMFLJLIO<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> NHKHFFCNGGB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29C57B0", Offset = "0x29C47B0", VA = "0x1829C57B0", Slot = "6")]
	public override bool CanConvert(Type LOAKNADDLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68B5680", Offset = "0x68B4680", VA = "0x1868B5680", Slot = "5")]
	public override object ReadJson(JsonReader AMPJMGIAGBB, Type LOAKNADDLOC, object NJJANHLNDFL, JsonSerializer EPFLIAPJNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68B5750", Offset = "0x68B4750", VA = "0x1868B5750", Slot = "4")]
	public override void WriteJson(JsonWriter NMCAGOGLPLD, object IOALKPFEKEK, JsonSerializer EPFLIAPJNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
	internal CFEJMFLJLIO(Func<Type, bool> NHKHFFCNGGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BBLIKGGCHLL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x39D0B60", Offset = "0x39CFB60", VA = "0x1839D0B60")]
	public static CFEJMFLJLIO<T> MPFKOOIPONO<T>(FOPHEIPECBP PJELHHJBILL = FOPHEIPECBP.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class JFFILPHDJOH : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> NHKHFFCNGGB;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29C57B0", Offset = "0x29C47B0", VA = "0x1829C57B0", Slot = "6")]
	public override bool CanConvert(Type LOAKNADDLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82E0290", Offset = "0x82DF290", VA = "0x1882E0290", Slot = "5")]
	public override object ReadJson(JsonReader AMPJMGIAGBB, Type LOAKNADDLOC, object NJJANHLNDFL, JsonSerializer EPFLIAPJNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82E0330", Offset = "0x82DF330", VA = "0x1882E0330", Slot = "4")]
	public override void WriteJson(JsonWriter NMCAGOGLPLD, object IOALKPFEKEK, JsonSerializer EPFLIAPJNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
	public JFFILPHDJOH(Func<Type, bool> NHKHFFCNGGB)
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

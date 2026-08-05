using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MHMGNNGJBHL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class CCBJKAFBKEO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x32027B0", Offset = "0x3200DB0", VA = "0x1832027B0")]
	public static Func<Type, bool> LNPKNDAFNOC<T>(this MHMGNNGJBHL JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3202960", Offset = "0x3200F60", VA = "0x183202960")]
	private static bool MOBAFLPHDJI<T>(Type FJCDLCFJEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3202390", Offset = "0x3200990", VA = "0x183202390")]
	private static bool DLOGLGOEMKL<T>(Type FJCDLCFJEBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MOANFNGHBLO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x351C510", Offset = "0x351AB10", VA = "0x18351C510")]
	public static string EBCCIKAPDDK<T>(T JJFHAAOAACO, string HBIPJPJMJHP = ", ", [Optional] T IDJBNLNBJCD) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x351C5B0", Offset = "0x351ABB0", VA = "0x18351C5B0")]
	public static string LPCLMBCBCJG<T>(T JJFHAAOAACO, string HBIPJPJMJHP = ", ", params T[] DJOCELOJEOC) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x351C870", Offset = "0x351AE70", VA = "0x18351C870")]
	private static bool NNJEFDGJGLD<T>(T[] DJOCELOJEOC, T JFJMJEFHFHO, IEqualityComparer<T> BLMEGMHOING)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class PIKGMCHFOIM<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> AGBGCOFJPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> JKJGHOKFHFO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5104C50", Offset = "0x5103250", VA = "0x185104C50", Slot = "6")]
	public override bool CanConvert(Type FJCDLCFJEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5105160", Offset = "0x5103760", VA = "0x185105160", Slot = "5")]
	public override object ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, object JOJNEODOMKD, JsonSerializer HICOCDDBAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5105440", Offset = "0x5103A40", VA = "0x185105440", Slot = "4")]
	public override void WriteJson(JsonWriter BMEAHINCLAG, object KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49A6EC0", Offset = "0x49A54C0", VA = "0x1849A6EC0")]
	internal PIKGMCHFOIM(Func<Type, bool> AGBGCOFJPDL, Action<JsonWriter, T> JKJGHOKFHFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HKACIJGPFOE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x33ED860", Offset = "0x33EBE60", VA = "0x1833ED860")]
	public static PIKGMCHFOIM<T> FEOBEKOIKMG<T>(Action<JsonWriter, T> JKJGHOKFHFO, MHMGNNGJBHL DDGNIIIMBCA = MHMGNNGJBHL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HFCDCOKLCHK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] NJEKHJPFBEM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter HDMABCBEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x761E540", Offset = "0x761CB40", VA = "0x18761E540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter MHIDJGGKOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x761E400", Offset = "0x761CA00", VA = "0x18761E400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter DPNPJLFAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x761E4F0", Offset = "0x761CAF0", VA = "0x18761E4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter NBHLKFBEOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x761E450", Offset = "0x761CA50", VA = "0x18761E450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter BDCFLAIIEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x761E4A0", Offset = "0x761CAA0", VA = "0x18761E4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ENNGFPCCMJE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x761E3A0", Offset = "0x761C9A0", VA = "0x18761E3A0")]
	public static string FJAJAGDLKBG(this object JDCFMPOHCEA, JsonConverter[] FDECMJGPFNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DKNLAKOAAIK<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> AGBGCOFJPDL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5104C50", Offset = "0x5103250", VA = "0x185104C50", Slot = "6")]
	public override bool CanConvert(Type FJCDLCFJEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x631D8E0", Offset = "0x631BEE0", VA = "0x18631D8E0", Slot = "5")]
	public override object ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, object JOJNEODOMKD, JsonSerializer HICOCDDBAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x631D9B0", Offset = "0x631BFB0", VA = "0x18631D9B0", Slot = "4")]
	public override void WriteJson(JsonWriter BMEAHINCLAG, object KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
	internal DKNLAKOAAIK(Func<Type, bool> AGBGCOFJPDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EFKBAPNAAIJ
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x326FF30", Offset = "0x326E530", VA = "0x18326FF30")]
	public static DKNLAKOAAIK<T> FEOBEKOIKMG<T>(MHMGNNGJBHL DDGNIIIMBCA = MHMGNNGJBHL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class PBILCJFFFJH : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> AGBGCOFJPDL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5104C50", Offset = "0x5103250", VA = "0x185104C50", Slot = "6")]
	public override bool CanConvert(Type FJCDLCFJEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x761EAF0", Offset = "0x761D0F0", VA = "0x18761EAF0", Slot = "5")]
	public override object ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, object JOJNEODOMKD, JsonSerializer HICOCDDBAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x761EB90", Offset = "0x761D190", VA = "0x18761EB90", Slot = "4")]
	public override void WriteJson(JsonWriter BMEAHINCLAG, object KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
	public PBILCJFFFJH(Func<Type, bool> AGBGCOFJPDL)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum POJGDNKCDMI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class JEPCCILAFPM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x36DEA60", Offset = "0x36DD460", VA = "0x1836DEA60")]
	public static Func<Type, bool> GIEAJCJJEJI<T>(this POJGDNKCDMI IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x33BB790", Offset = "0x33BA190", VA = "0x1833BB790")]
	private static bool MNCMBJCLPEJ<T>(Type GKHIEBGMKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x36DEE40", Offset = "0x36DD840", VA = "0x1836DEE40")]
	private static bool NLBGCDCAMFF<T>(Type GKHIEBGMKJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ADMKFADGFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3DA72D0", Offset = "0x3DA5CD0", VA = "0x183DA72D0")]
	public static string GAHFHJLOMDL<T>(T PMMCFCOBIDM, string JOACNILBNMG = ", ", [Optional] T LPJIMLBFHAO) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7010", Offset = "0x3DA5A10", VA = "0x183DA7010")]
	public static string FNKDGPMHBFM<T>(T PMMCFCOBIDM, string JOACNILBNMG = ", ", params T[] BKBALNBBBIF) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3DA6DB0", Offset = "0x3DA57B0", VA = "0x183DA6DB0")]
	private static bool AHOPOJHAPOI<T>(T[] BKBALNBBBIF, T ADHFHCKDLLB, IEqualityComparer<T> KADCJBCBGFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class IEBCNKLKOMH<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> NAIOCJHCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> AJBKHCDKCLF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A77630", Offset = "0x4A76030", VA = "0x184A77630", Slot = "6")]
	public override bool CanConvert(Type GKHIEBGMKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A77A70", Offset = "0x4A76470", VA = "0x184A77A70", Slot = "5")]
	public override object ReadJson(JsonReader BDHKEKKPKBC, Type GKHIEBGMKJK, object LNJBLKNMANO, JsonSerializer LGMJFLOIPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A77E00", Offset = "0x4A76800", VA = "0x184A77E00", Slot = "4")]
	public override void WriteJson(JsonWriter IFAFIMFGJBL, object PPJFMHBDGNA, JsonSerializer LGMJFLOIPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A782B0", Offset = "0x4A76CB0", VA = "0x184A782B0")]
	internal IEBCNKLKOMH(Func<Type, bool> NAIOCJHCBLN, Action<JsonWriter, T> AJBKHCDKCLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JEHCLCKIPMP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x36DE2E0", Offset = "0x36DCCE0", VA = "0x1836DE2E0")]
	public static IEBCNKLKOMH<T> DDDHPONDPCL<T>(Action<JsonWriter, T> AJBKHCDKCLF, POJGDNKCDMI LLAKKIJKPFN = POJGDNKCDMI.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CGKFOHLOFMN
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] NOMMEILPFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter MDLFIEMDHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B540", Offset = "0x7A29F40", VA = "0x187A2B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter KEGNKKELHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B5E0", Offset = "0x7A29FE0", VA = "0x187A2B5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter CFNHOAEKADG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B680", Offset = "0x7A2A080", VA = "0x187A2B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter MDCIJKAFIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B630", Offset = "0x7A2A030", VA = "0x187A2B630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter EOMFGDBGABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B590", Offset = "0x7A29F90", VA = "0x187A2B590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GBKJGCDOIFO
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BCF0", Offset = "0x7A2A6F0", VA = "0x187A2BCF0")]
	public static string JLMKCKMBMHK(this object IJPDNJELPLO, JsonConverter[] GHFANLJKHLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AOGLIODNCLD<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> NAIOCJHCBLN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A77630", Offset = "0x4A76030", VA = "0x184A77630", Slot = "6")]
	public override bool CanConvert(Type GKHIEBGMKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x50C3BA0", Offset = "0x50C25A0", VA = "0x1850C3BA0", Slot = "5")]
	public override object ReadJson(JsonReader BDHKEKKPKBC, Type GKHIEBGMKJK, object LNJBLKNMANO, JsonSerializer LGMJFLOIPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50C3C70", Offset = "0x50C2670", VA = "0x1850C3C70", Slot = "4")]
	public override void WriteJson(JsonWriter IFAFIMFGJBL, object PPJFMHBDGNA, JsonSerializer LGMJFLOIPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
	internal AOGLIODNCLD(Func<Type, bool> NAIOCJHCBLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JCKDICKKFHC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36D22F0", Offset = "0x36D0CF0", VA = "0x1836D22F0")]
	public static AOGLIODNCLD<T> DDDHPONDPCL<T>(POJGDNKCDMI LLAKKIJKPFN = POJGDNKCDMI.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class EOCAHCNEJDF : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> NAIOCJHCBLN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A77630", Offset = "0x4A76030", VA = "0x184A77630", Slot = "6")]
	public override bool CanConvert(Type GKHIEBGMKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BBE0", Offset = "0x7A2A5E0", VA = "0x187A2BBE0", Slot = "5")]
	public override object ReadJson(JsonReader BDHKEKKPKBC, Type GKHIEBGMKJK, object LNJBLKNMANO, JsonSerializer LGMJFLOIPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BC80", Offset = "0x7A2A680", VA = "0x187A2BC80", Slot = "4")]
	public override void WriteJson(JsonWriter IFAFIMFGJBL, object PPJFMHBDGNA, JsonSerializer LGMJFLOIPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
	public EOCAHCNEJDF(Func<Type, bool> NAIOCJHCBLN)
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

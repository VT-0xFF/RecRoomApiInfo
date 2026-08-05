using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PADFPDOFNHK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class KIKOAPKJGAC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC980", Offset = "0x3DAB780", VA = "0x183DAC980")]
	public static Func<Type, bool> DIFBFKJEHCK<T>(this PADFPDOFNHK DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9630", Offset = "0x3CD8430", VA = "0x183CD9630")]
	private static bool LPJHNDBEFLN<T>(Type GNGCPFDIMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC560", Offset = "0x3DAB360", VA = "0x183DAC560")]
	private static bool BEBPHBDOJOE<T>(Type GNGCPFDIMFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MPNPDDLOFLK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3E14DC0", Offset = "0x3E13BC0", VA = "0x183E14DC0")]
	public static string FKFJELMEHIL<T>(T AGNBPCKNDIK, string JNKGCLHBDBE = ", ", [Optional] T PGFMONBPOJI) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3E14E50", Offset = "0x3E13C50", VA = "0x183E14E50")]
	public static string NLLGACMPGEF<T>(T AGNBPCKNDIK, string JNKGCLHBDBE = ", ", params T[] EGKMJBKEKIM) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E14B60", Offset = "0x3E13960", VA = "0x183E14B60")]
	private static bool CAGBBOGLPOB<T>(T[] EGKMJBKEKIM, T FFAHAEGEIFG, IEqualityComparer<T> IFGHMFNGBPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class OHAMMKGDLBO<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> KNCOHBJCLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> GPLKOJAPCJC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B1C0", Offset = "0x2A59FC0", VA = "0x182A5B1C0", Slot = "6")]
	public override bool CanConvert(Type GNGCPFDIMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5ACDF30", Offset = "0x5ACCD30", VA = "0x185ACDF30", Slot = "5")]
	public override object ReadJson(JsonReader CCOEJPOOOPD, Type GNGCPFDIMFH, object KHKPDNBCFEG, JsonSerializer OJPPMHCIDCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE110", Offset = "0x5ACCF10", VA = "0x185ACE110", Slot = "4")]
	public override void WriteJson(JsonWriter AOOOLDFNADH, object HGMAIPELJHM, JsonSerializer OJPPMHCIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5562070", Offset = "0x5560E70", VA = "0x185562070")]
	internal OHAMMKGDLBO(Func<Type, bool> KNCOHBJCLGB, Action<JsonWriter, T> GPLKOJAPCJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HCIOBPICKDN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AD90", Offset = "0x3D09B90", VA = "0x183D0AD90")]
	public static OHAMMKGDLBO<T> ELDPFIHNJDG<T>(Action<JsonWriter, T> GPLKOJAPCJC, PADFPDOFNHK CDEHHEMAGDM = PADFPDOFNHK.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GFOAEJGMKLN
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] KMFDFFMMCIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter NHONFLCDGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84F52A0", Offset = "0x84F40A0", VA = "0x1884F52A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter LCIKAJIMALN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84F5250", Offset = "0x84F4050", VA = "0x1884F5250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter BDNFOEKOKAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84F52F0", Offset = "0x84F40F0", VA = "0x1884F52F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter DCAPEEMHKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84F5200", Offset = "0x84F4000", VA = "0x1884F5200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter JCCNALDHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84F51B0", Offset = "0x84F3FB0", VA = "0x1884F51B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EAFBONGKAGO
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84F5040", Offset = "0x84F3E40", VA = "0x1884F5040")]
	public static string DPBFNAKCOGK(this object DBBEADIHLKO, JsonConverter[] DCIDONOGODK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class MOPIDIKFJBB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> KNCOHBJCLGB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B1C0", Offset = "0x2A59FC0", VA = "0x182A5B1C0", Slot = "6")]
	public override bool CanConvert(Type GNGCPFDIMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5903280", Offset = "0x5902080", VA = "0x185903280", Slot = "5")]
	public override object ReadJson(JsonReader CCOEJPOOOPD, Type GNGCPFDIMFH, object KHKPDNBCFEG, JsonSerializer OJPPMHCIDCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5903360", Offset = "0x5902160", VA = "0x185903360", Slot = "4")]
	public override void WriteJson(JsonWriter AOOOLDFNADH, object HGMAIPELJHM, JsonSerializer OJPPMHCIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
	internal MOPIDIKFJBB(Func<Type, bool> KNCOHBJCLGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IELHCHDEPLK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D47850", Offset = "0x3D46650", VA = "0x183D47850")]
	public static MOPIDIKFJBB<T> ELDPFIHNJDG<T>(PADFPDOFNHK CDEHHEMAGDM = PADFPDOFNHK.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class EFHGNFFBPBL : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> KNCOHBJCLGB;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B1C0", Offset = "0x2A59FC0", VA = "0x182A5B1C0", Slot = "6")]
	public override bool CanConvert(Type GNGCPFDIMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84F50A0", Offset = "0x84F3EA0", VA = "0x1884F50A0", Slot = "5")]
	public override object ReadJson(JsonReader CCOEJPOOOPD, Type GNGCPFDIMFH, object KHKPDNBCFEG, JsonSerializer OJPPMHCIDCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84F5140", Offset = "0x84F3F40", VA = "0x1884F5140", Slot = "4")]
	public override void WriteJson(JsonWriter AOOOLDFNADH, object HGMAIPELJHM, JsonSerializer OJPPMHCIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
	public EFHGNFFBPBL(Func<Type, bool> KNCOHBJCLGB)
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

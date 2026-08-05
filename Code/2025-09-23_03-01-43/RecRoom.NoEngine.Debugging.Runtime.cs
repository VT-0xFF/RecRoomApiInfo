using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JMCBBMMLFFF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class FBEGCMIEGAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3DB2690", Offset = "0x3DB0C90", VA = "0x183DB2690")]
	public static Func<Type, bool> FHGEBIMBNFI<T>(this JMCBBMMLFFF JNMMMBJNOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x32DA140", Offset = "0x32D8740", VA = "0x1832DA140")]
	private static bool INFPGJJDDGJ<T>(Type CEIIOJHLMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3DB2A70", Offset = "0x3DB1070", VA = "0x183DB2A70")]
	private static bool JOFPILDDFEL<T>(Type CEIIOJHLMOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EKLCIFPLDLF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C61A40", Offset = "0x3C60040", VA = "0x183C61A40")]
	public static string MFPDMPOBFFK<T>(T KCKCBGONOJI, string MKKLCFLHMFH = ", ", [Optional] T APJDJFMLEAP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3C617B0", Offset = "0x3C5FDB0", VA = "0x183C617B0")]
	public static string IJEKJMPJGMO<T>(T KCKCBGONOJI, string MKKLCFLHMFH = ", ", params T[] IFABLFIECDH) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C61AD0", Offset = "0x3C600D0", VA = "0x183C61AD0")]
	private static bool PPCPBEAGNMG<T>(T[] IFABLFIECDH, T NLFMOKELAPM, IEqualityComparer<T> HPIFCOACPPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class JFJEOKEJCLJ<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> LJAFGFNECAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> MJKEBJKCPOP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3590", Offset = "0x2AE1B90", VA = "0x182AE3590", Slot = "6")]
	public override bool CanConvert(Type CEIIOJHLMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x54BF550", Offset = "0x54BDB50", VA = "0x1854BF550", Slot = "5")]
	public override object ReadJson(JsonReader KLIAOPJFDOK, Type CEIIOJHLMOO, object ACFKNGEDBPB, JsonSerializer CLMFOECLAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x54BFC50", Offset = "0x54BE250", VA = "0x1854BFC50", Slot = "4")]
	public override void WriteJson(JsonWriter CKPHLHCIFLA, object KOPHBHGIACG, JsonSerializer CLMFOECLAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x54C01A0", Offset = "0x54BE7A0", VA = "0x1854C01A0")]
	internal JFJEOKEJCLJ(Func<Type, bool> LJAFGFNECAL, Action<JsonWriter, T> MJKEBJKCPOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FEDMEPFNACI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB2A0", Offset = "0x3DB98A0", VA = "0x183DBB2A0")]
	public static JFJEOKEJCLJ<T> CPNHECDILPK<T>(Action<JsonWriter, T> MJKEBJKCPOP, JMCBBMMLFFF EFOFNBNNCIK = JMCBBMMLFFF.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HPHBMJJIDJH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] HJGBFDBNFPJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter AMAJMNBFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x866FB70", Offset = "0x866E170", VA = "0x18866FB70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter FHCILHGCGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x866FB20", Offset = "0x866E120", VA = "0x18866FB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter JMEGOFOGCGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x866FC10", Offset = "0x866E210", VA = "0x18866FC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter BHAFPNDFJLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x866FC60", Offset = "0x866E260", VA = "0x18866FC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter EJJAACMJAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x866FBC0", Offset = "0x866E1C0", VA = "0x18866FBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LGFHPLLBICA
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8670200", Offset = "0x866E800", VA = "0x188670200")]
	public static string PKGDPIDGBJB(this object JNMMMBJNOND, JsonConverter[] FICPCCKLIHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LHBELIBEJLH<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> LJAFGFNECAL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3590", Offset = "0x2AE1B90", VA = "0x182AE3590", Slot = "6")]
	public override bool CanConvert(Type CEIIOJHLMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57C8B20", Offset = "0x57C7120", VA = "0x1857C8B20", Slot = "5")]
	public override object ReadJson(JsonReader KLIAOPJFDOK, Type CEIIOJHLMOO, object ACFKNGEDBPB, JsonSerializer CLMFOECLAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57C8C00", Offset = "0x57C7200", VA = "0x1857C8C00", Slot = "4")]
	public override void WriteJson(JsonWriter CKPHLHCIFLA, object KOPHBHGIACG, JsonSerializer CLMFOECLAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
	internal LHBELIBEJLH(Func<Type, bool> LJAFGFNECAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HOCJCBJEPDG
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7500", Offset = "0x3DF5B00", VA = "0x183DF7500")]
	public static LHBELIBEJLH<T> CPNHECDILPK<T>(JMCBBMMLFFF EFOFNBNNCIK = JMCBBMMLFFF.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class NNANJKALJKI : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> LJAFGFNECAL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3590", Offset = "0x2AE1B90", VA = "0x182AE3590", Slot = "6")]
	public override bool CanConvert(Type CEIIOJHLMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8670260", Offset = "0x866E860", VA = "0x188670260", Slot = "5")]
	public override object ReadJson(JsonReader KLIAOPJFDOK, Type CEIIOJHLMOO, object ACFKNGEDBPB, JsonSerializer CLMFOECLAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8670300", Offset = "0x866E900", VA = "0x188670300", Slot = "4")]
	public override void WriteJson(JsonWriter CKPHLHCIFLA, object KOPHBHGIACG, JsonSerializer CLMFOECLAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
	public NNANJKALJKI(Func<Type, bool> LJAFGFNECAL)
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

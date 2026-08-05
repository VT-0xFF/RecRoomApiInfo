using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NILBMLKDBHD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class JCCHIBPFNPP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3FB0", Offset = "0x3CF29B0", VA = "0x183CF3FB0")]
	public static Func<Type, bool> BCPPDNCNACM<T>(this NILBMLKDBHD NLDLHIJAJBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C40190", Offset = "0x3C3EB90", VA = "0x183C40190")]
	private static bool GFOLAMKLPFC<T>(Type EMOKFILPBJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4390", Offset = "0x3CF2D90", VA = "0x183CF4390")]
	private static bool GHMLLBMEDBJ<T>(Type EMOKFILPBJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LILPNKNGKAH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D46590", Offset = "0x3D44F90", VA = "0x183D46590")]
	public static string FKHDAOOHLJF<T>(T IGABBOEDEPP, string AINMJOMOAII = ", ", [Optional] T KKCMINIPIBD) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D46880", Offset = "0x3D45280", VA = "0x183D46880")]
	public static string OFILEBIICIJ<T>(T IGABBOEDEPP, string AINMJOMOAII = ", ", params T[] LBOHMEBFJAD) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D46620", Offset = "0x3D45020", VA = "0x183D46620")]
	private static bool HLBBJIOKCMC<T>(T[] LBOHMEBFJAD, T BILOCDLBGBK, IEqualityComparer<T> MJKIOFPPIML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GACPHNFOONN<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> KDEKOCHJEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> JMGIBKNEFKM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29EF890", Offset = "0x29EE290", VA = "0x1829EF890", Slot = "6")]
	public override bool CanConvert(Type EMOKFILPBJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4ECFA80", Offset = "0x4ECE480", VA = "0x184ECFA80", Slot = "5")]
	public override object ReadJson(JsonReader IOMONBOBJAC, Type EMOKFILPBJD, object GNLNMAFIGHG, JsonSerializer OEPNAGFCALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4ECFD20", Offset = "0x4ECE720", VA = "0x184ECFD20", Slot = "4")]
	public override void WriteJson(JsonWriter ADMHNJGGGLG, object PDKJBMPOMNC, JsonSerializer OEPNAGFCALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0270", Offset = "0x4ECEC70", VA = "0x184ED0270")]
	internal GACPHNFOONN(Func<Type, bool> KDEKOCHJEAM, Action<JsonWriter, T> JMGIBKNEFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AFAIDKOGPJL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x31C3DE0", Offset = "0x31C27E0", VA = "0x1831C3DE0")]
	public static GACPHNFOONN<T> MDDJOGPLAFO<T>(Action<JsonWriter, T> JMGIBKNEFKM, NILBMLKDBHD OJFDJAKFNLH = NILBMLKDBHD.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ANFPPHFHLGI
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] OIOIOOMAHOM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter HADLDIAEOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8472940", Offset = "0x8471340", VA = "0x188472940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter BOBAHAGMBND
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8472990", Offset = "0x8471390", VA = "0x188472990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter HFACPJHKFND
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84728F0", Offset = "0x84712F0", VA = "0x1884728F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter FJADHLIMKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84729E0", Offset = "0x84713E0", VA = "0x1884729E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter PNKLGKIDJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84728A0", Offset = "0x84712A0", VA = "0x1884728A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HJHPMMGAIFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8473090", Offset = "0x8471A90", VA = "0x188473090")]
	public static string LOPDMNBOKIK(this object NLDLHIJAJBO, JsonConverter[] AOCAMFBCBNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DDGFBLFBDNC<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> KDEKOCHJEAM;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29EF890", Offset = "0x29EE290", VA = "0x1829EF890", Slot = "6")]
	public override bool CanConvert(Type EMOKFILPBJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5D80", Offset = "0x6FF4780", VA = "0x186FF5D80", Slot = "5")]
	public override object ReadJson(JsonReader IOMONBOBJAC, Type EMOKFILPBJD, object GNLNMAFIGHG, JsonSerializer OEPNAGFCALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5E60", Offset = "0x6FF4860", VA = "0x186FF5E60", Slot = "4")]
	public override void WriteJson(JsonWriter ADMHNJGGGLG, object PDKJBMPOMNC, JsonSerializer OEPNAGFCALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
	internal DDGFBLFBDNC(Func<Type, bool> KDEKOCHJEAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IDFJACINGKO
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CAB120", Offset = "0x3CA9B20", VA = "0x183CAB120")]
	public static DDGFBLFBDNC<T> MDDJOGPLAFO<T>(NILBMLKDBHD OJFDJAKFNLH = NILBMLKDBHD.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class GKEMOJJFNBE : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> KDEKOCHJEAM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29EF890", Offset = "0x29EE290", VA = "0x1829EF890", Slot = "6")]
	public override bool CanConvert(Type EMOKFILPBJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8472F80", Offset = "0x8471980", VA = "0x188472F80", Slot = "5")]
	public override object ReadJson(JsonReader IOMONBOBJAC, Type EMOKFILPBJD, object GNLNMAFIGHG, JsonSerializer OEPNAGFCALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8473020", Offset = "0x8471A20", VA = "0x188473020", Slot = "4")]
	public override void WriteJson(JsonWriter ADMHNJGGGLG, object PDKJBMPOMNC, JsonSerializer OEPNAGFCALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
	public GKEMOJJFNBE(Func<Type, bool> KDEKOCHJEAM)
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

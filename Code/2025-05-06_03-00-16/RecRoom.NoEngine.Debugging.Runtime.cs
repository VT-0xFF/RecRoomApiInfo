using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IDMOECGNFKL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class CONACFPONOO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3597E30", Offset = "0x3596630", VA = "0x183597E30")]
	public static Func<Type, bool> LCAJMEBONOO<T>(this IDMOECGNFKL NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x34FFF20", Offset = "0x34FE720", VA = "0x1834FFF20")]
	private static bool FLBEIFDKADB<T>(Type EAAOLJJLFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3597A10", Offset = "0x3596210", VA = "0x183597A10")]
	private static bool GAOIDMCEHMA<T>(Type EAAOLJJLFCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IPMCHAOPMHD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x37F5500", Offset = "0x37F3D00", VA = "0x1837F5500")]
	public static string KGHPCANGFMM<T>(T IPCBOKHNPCP, string ANFAAAPOCEN = ", ", [Optional] T LHCNPHOLELG) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37F4FE0", Offset = "0x37F37E0", VA = "0x1837F4FE0")]
	public static string GMPCFKCHCAH<T>(T IPCBOKHNPCP, string ANFAAAPOCEN = ", ", params T[] LPJGBELPDJO) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37F52A0", Offset = "0x37F3AA0", VA = "0x1837F52A0")]
	private static bool JDOHJGKGHAJ<T>(T[] LPJGBELPDJO, T GAKNJCMEOCN, IEqualityComparer<T> OHBECKLCOCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BODANPDOIPF<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> PCBEEPBGJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> IAIPLHLFGOE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26F97E0", Offset = "0x26F7FE0", VA = "0x1826F97E0", Slot = "6")]
	public override bool CanConvert(Type EAAOLJJLFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60171E0", Offset = "0x60159E0", VA = "0x1860171E0", Slot = "5")]
	public override object ReadJson(JsonReader DMPKKEDJKBJ, Type EAAOLJJLFCF, object GIOGNHBBPCP, JsonSerializer KKFPDDCHJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6017590", Offset = "0x6015D90", VA = "0x186017590", Slot = "4")]
	public override void WriteJson(JsonWriter HIKMEOJBJOJ, object OPMIAMEJKDH, JsonSerializer KKFPDDCHJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2C80", Offset = "0x4AF1480", VA = "0x184AF2C80")]
	internal BODANPDOIPF(Func<Type, bool> PCBEEPBGJBL, Action<JsonWriter, T> IAIPLHLFGOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ANPNEOOLJCD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F6A0", Offset = "0x3F0DEA0", VA = "0x183F0F6A0")]
	public static BODANPDOIPF<T> CJOJELENPLJ<T>(Action<JsonWriter, T> IAIPLHLFGOE, IDMOECGNFKL BMFLFLLBOFM = IDMOECGNFKL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KODFAKAJKIF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] HAHJHPCKFHL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter AIKOFEEJHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DF20", Offset = "0x7C4C720", VA = "0x187C4DF20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter MGPIHLBJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DFC0", Offset = "0x7C4C7C0", VA = "0x187C4DFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter CKGEAOPOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DED0", Offset = "0x7C4C6D0", VA = "0x187C4DED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter HMLLFHPJBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DF70", Offset = "0x7C4C770", VA = "0x187C4DF70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter GKPNDEHFDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E010", Offset = "0x7C4C810", VA = "0x187C4E010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NNDDHDKCEKM
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E570", Offset = "0x7C4CD70", VA = "0x187C4E570")]
	public static string HJCLFKLBOGG(this object NFOGFJOGLPE, JsonConverter[] DOAHOKBAEGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LLIJNDAAIKJ<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> PCBEEPBGJBL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26F97E0", Offset = "0x26F7FE0", VA = "0x1826F97E0", Slot = "6")]
	public override bool CanConvert(Type EAAOLJJLFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x500C750", Offset = "0x500AF50", VA = "0x18500C750", Slot = "5")]
	public override object ReadJson(JsonReader DMPKKEDJKBJ, Type EAAOLJJLFCF, object GIOGNHBBPCP, JsonSerializer KKFPDDCHJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x500C820", Offset = "0x500B020", VA = "0x18500C820", Slot = "4")]
	public override void WriteJson(JsonWriter HIKMEOJBJOJ, object OPMIAMEJKDH, JsonSerializer KKFPDDCHJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
	internal LLIJNDAAIKJ(Func<Type, bool> PCBEEPBGJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LLCIAFGGLCA
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3887910", Offset = "0x3886110", VA = "0x183887910")]
	public static LLIJNDAAIKJ<T> CJOJELENPLJ<T>(IDMOECGNFKL BMFLFLLBOFM = IDMOECGNFKL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class HBOGDGLFAHD : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> PCBEEPBGJBL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26F97E0", Offset = "0x26F7FE0", VA = "0x1826F97E0", Slot = "6")]
	public override bool CanConvert(Type EAAOLJJLFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DDC0", Offset = "0x7C4C5C0", VA = "0x187C4DDC0", Slot = "5")]
	public override object ReadJson(JsonReader DMPKKEDJKBJ, Type EAAOLJJLFCF, object GIOGNHBBPCP, JsonSerializer KKFPDDCHJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DE60", Offset = "0x7C4C660", VA = "0x187C4DE60", Slot = "4")]
	public override void WriteJson(JsonWriter HIKMEOJBJOJ, object OPMIAMEJKDH, JsonSerializer KKFPDDCHJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
	public HBOGDGLFAHD(Func<Type, bool> PCBEEPBGJBL)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HEBOOCNIACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class JOBJJOOEHIM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3B36820", Offset = "0x3B35420", VA = "0x183B36820")]
	public static Func<Type, bool> OAJCKGMPCDJ<T>(this HEBOOCNIACJ LAAPKLDJLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A58220", Offset = "0x3A56E20", VA = "0x183A58220")]
	private static bool JAHDOAGMIGI<T>(Type ABAJKHLOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3B36400", Offset = "0x3B35000", VA = "0x183B36400")]
	private static bool MBINBCONNHL<T>(Type ABAJKHLOBLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ABEOCIKEGJB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3032230", Offset = "0x3030E30", VA = "0x183032230")]
	public static string IBOPPCOBNLE<T>(T NBOMHMDCNPE, string KAJGCMFBCAF = ", ", [Optional] T IPOLOHBNCGD) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3031FA0", Offset = "0x3030BA0", VA = "0x183031FA0")]
	public static string DODHCGNBLBO<T>(T NBOMHMDCNPE, string KAJGCMFBCAF = ", ", params T[] MKEOMEFPFON) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3031D40", Offset = "0x3030940", VA = "0x183031D40")]
	private static bool ALNPDMIJICK<T>(T[] MKEOMEFPFON, T FCCNKGNGPGC, IEqualityComparer<T> DIMPLJBNCJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ACHIBEMJGAB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> EILOGLCAFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> BKOIHDMMEEK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270", Slot = "6")]
	public override bool CanConvert(Type ABAJKHLOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4CE0B60", Offset = "0x4CDF760", VA = "0x184CE0B60", Slot = "5")]
	public override object ReadJson(JsonReader EENAIFHJAJK, Type ABAJKHLOBLK, object DJEBBNDINOA, JsonSerializer PBIAIHKJAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4CE1100", Offset = "0x4CDFD00", VA = "0x184CE1100", Slot = "4")]
	public override void WriteJson(JsonWriter JKKEKKKNJIN, object OOHGFGHCOAJ, JsonSerializer PBIAIHKJAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4CE1230", Offset = "0x4CDFE30", VA = "0x184CE1230")]
	internal ACHIBEMJGAB(Func<Type, bool> EILOGLCAFDG, Action<JsonWriter, T> BKOIHDMMEEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FNAEHEBOKJN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DC20", Offset = "0x3A6C820", VA = "0x183A6DC20")]
	public static ACHIBEMJGAB<T> JHMOIFLKJAD<T>(Action<JsonWriter, T> BKOIHDMMEEK, HEBOOCNIACJ KGFKCPKKELF = HEBOOCNIACJ.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KJLOFNDBLBH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] NLLJMKHKBND;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter ILJBIBCDGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F307C0", Offset = "0x7F2F3C0", VA = "0x187F307C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter OPFBDLDNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F308B0", Offset = "0x7F2F4B0", VA = "0x187F308B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter EFNPGFJGNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F30900", Offset = "0x7F2F500", VA = "0x187F30900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter LNBDOJMIGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F30860", Offset = "0x7F2F460", VA = "0x187F30860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter ENEDMBDLEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F30810", Offset = "0x7F2F410", VA = "0x187F30810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PGDMNKHCNPL
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F30E60", Offset = "0x7F2FA60", VA = "0x187F30E60")]
	public static string BDNKNJMKGBP(this object LAAPKLDJLPE, JsonConverter[] KDEKOOBNDNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class EAIDONCHAEG<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> EILOGLCAFDG;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270", Slot = "6")]
	public override bool CanConvert(Type ABAJKHLOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x470A240", Offset = "0x4708E40", VA = "0x18470A240", Slot = "5")]
	public override object ReadJson(JsonReader EENAIFHJAJK, Type ABAJKHLOBLK, object DJEBBNDINOA, JsonSerializer PBIAIHKJAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x470A310", Offset = "0x4708F10", VA = "0x18470A310", Slot = "4")]
	public override void WriteJson(JsonWriter JKKEKKKNJIN, object OOHGFGHCOAJ, JsonSerializer PBIAIHKJAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
	internal EAIDONCHAEG(Func<Type, bool> EILOGLCAFDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MMGHGMEFOEN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB71A0", Offset = "0x3BB5DA0", VA = "0x183BB71A0")]
	public static EAIDONCHAEG<T> JHMOIFLKJAD<T>(HEBOOCNIACJ KGFKCPKKELF = HEBOOCNIACJ.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class JPANIDKKCFD : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> EILOGLCAFDG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x28B8270", Offset = "0x28B6E70", VA = "0x1828B8270", Slot = "6")]
	public override bool CanConvert(Type ABAJKHLOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F306B0", Offset = "0x7F2F2B0", VA = "0x187F306B0", Slot = "5")]
	public override object ReadJson(JsonReader EENAIFHJAJK, Type ABAJKHLOBLK, object DJEBBNDINOA, JsonSerializer PBIAIHKJAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F30750", Offset = "0x7F2F350", VA = "0x187F30750", Slot = "4")]
	public override void WriteJson(JsonWriter JKKEKKKNJIN, object OOHGFGHCOAJ, JsonSerializer PBIAIHKJAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
	public JPANIDKKCFD(Func<Type, bool> EILOGLCAFDG)
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

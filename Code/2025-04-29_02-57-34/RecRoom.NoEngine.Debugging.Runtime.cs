using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FOCNIANHICM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class LMMBEKKDGKB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x37A49D0", Offset = "0x37A3DD0", VA = "0x1837A49D0")]
	public static Func<Type, bool> JAPKBAOALKF<T>(this FOCNIANHICM KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x34638E0", Offset = "0x3462CE0", VA = "0x1834638E0")]
	private static bool NKIJCJHNEPK<T>(Type ACOKEOAFGJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x37A4DB0", Offset = "0x37A41B0", VA = "0x1837A4DB0")]
	private static bool JMFGGGAALIO<T>(Type ACOKEOAFGJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LLEJNMGENHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x379E320", Offset = "0x379D720", VA = "0x18379E320")]
	public static string BPDJMHNOFLJ<T>(T AGBLNABJHCB, string BFKKIGFICPL = ", ", [Optional] T JMBBJHIBCGJ) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x379E3C0", Offset = "0x379D7C0", VA = "0x18379E3C0")]
	public static string OHFIDPDFAJB<T>(T AGBLNABJHCB, string BFKKIGFICPL = ", ", params T[] NILLLLHJPEN) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x379E140", Offset = "0x379D540", VA = "0x18379E140")]
	private static bool BNHJKIIPIMG<T>(T[] NILLLLHJPEN, T GPLLJCODACJ, IEqualityComparer<T> CIEFMHCOCHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class AIIKCMLPEHA<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> HBJIEADLJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> FDICHDLJHII;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x48880D0", Offset = "0x48874D0", VA = "0x1848880D0", Slot = "6")]
	public override bool CanConvert(Type ACOKEOAFGJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4BC0530", Offset = "0x4BBF930", VA = "0x184BC0530", Slot = "5")]
	public override object ReadJson(JsonReader PABEDPKBAJJ, Type ACOKEOAFGJO, object JKJJEIMNCHD, JsonSerializer EKNFDDNNCCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4BC0FB0", Offset = "0x4BC03B0", VA = "0x184BC0FB0", Slot = "4")]
	public override void WriteJson(JsonWriter CELBHBDDEKA, object OOEMJLHLIHJ, JsonSerializer EKNFDDNNCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1230", Offset = "0x4BC0630", VA = "0x184BC1230")]
	internal AIIKCMLPEHA(Func<Type, bool> HBJIEADLJIO, Action<JsonWriter, T> FDICHDLJHII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BFJKBHEPKEK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3443F10", Offset = "0x3443310", VA = "0x183443F10")]
	public static AIIKCMLPEHA<T> FABCCGGAHMJ<T>(Action<JsonWriter, T> FDICHDLJHII, FOCNIANHICM DIBMGHDEGAK = FOCNIANHICM.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AIOCCBKNLHO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] HPGPCFPJOPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter DEFJEOKFENF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C23560", Offset = "0x7C22960", VA = "0x187C23560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter EKJHMKMMJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C235B0", Offset = "0x7C229B0", VA = "0x187C235B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter KKEFALCMMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C23600", Offset = "0x7C22A00", VA = "0x187C23600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter GOBFFEJMHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C236A0", Offset = "0x7C22AA0", VA = "0x187C236A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter BBNOIEHNGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C23650", Offset = "0x7C22A50", VA = "0x187C23650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IMKOGEHMDDC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C23C50", Offset = "0x7C23050", VA = "0x187C23C50")]
	public static string JKOCGHPBEOG(this object KBBJDOAJMAF, JsonConverter[] CCBMMOHNFFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class GADPDNBCIFN<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> HBJIEADLJIO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x48880D0", Offset = "0x48874D0", VA = "0x1848880D0", Slot = "6")]
	public override bool CanConvert(Type ACOKEOAFGJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4888100", Offset = "0x4887500", VA = "0x184888100", Slot = "5")]
	public override object ReadJson(JsonReader PABEDPKBAJJ, Type ACOKEOAFGJO, object JKJJEIMNCHD, JsonSerializer EKNFDDNNCCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x48881E0", Offset = "0x48875E0", VA = "0x1848881E0", Slot = "4")]
	public override void WriteJson(JsonWriter CELBHBDDEKA, object OOEMJLHLIHJ, JsonSerializer EKNFDDNNCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
	internal GADPDNBCIFN(Func<Type, bool> HBJIEADLJIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LCCCMLLGCFA
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3794AA0", Offset = "0x3793EA0", VA = "0x183794AA0")]
	public static GADPDNBCIFN<T> FABCCGGAHMJ<T>(FOCNIANHICM DIBMGHDEGAK = FOCNIANHICM.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KHPIOLOGIBB : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> HBJIEADLJIO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x48880D0", Offset = "0x48874D0", VA = "0x1848880D0", Slot = "6")]
	public override bool CanConvert(Type ACOKEOAFGJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C23CB0", Offset = "0x7C230B0", VA = "0x187C23CB0", Slot = "5")]
	public override object ReadJson(JsonReader PABEDPKBAJJ, Type ACOKEOAFGJO, object JKJJEIMNCHD, JsonSerializer EKNFDDNNCCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C23D50", Offset = "0x7C23150", VA = "0x187C23D50", Slot = "4")]
	public override void WriteJson(JsonWriter CELBHBDDEKA, object OOEMJLHLIHJ, JsonSerializer EKNFDDNNCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
	public KHPIOLOGIBB(Func<Type, bool> HBJIEADLJIO)
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

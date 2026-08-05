using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class KAOBLLBKEJN<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void KBFANICHHKC(Utf8JsonReader DGCKGHIBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x51CA200", Offset = "0x51C8E00", VA = "0x1851CA200", Slot = "27")]
	public override T Read(Utf8JsonReader EENAIFHJAJK, Type ACECCBFELHD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51CA3F0", Offset = "0x51C8FF0", VA = "0x1851CA3F0", Slot = "28")]
	public override void Write(Utf8JsonWriter JKKEKKKNJIN, T OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void JIAAMFBNKCF(Utf8JsonReader EENAIFHJAJK, JsonSerializerOptions LEKHKJDBHCI, string HGJNKBHNLKN, T ONKLOOMCJOM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void LPNDGAKPJGL(Utf8JsonWriter JKKEKKKNJIN, T OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x46E0820", Offset = "0x46DF420", VA = "0x1846E0820")]
	protected KAOBLLBKEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KHHPDMCHNFP : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E095C0", Offset = "0x7E081C0", VA = "0x187E095C0")]
	public KHHPDMCHNFP(string HGJNKBHNLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HMAAOMAKHJE<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5960", Offset = "0x4DB4560", VA = "0x184DB5960", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader EENAIFHJAJK, Type ACECCBFELHD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5B50", Offset = "0x4DB4750", VA = "0x184DB5B50", Slot = "28")]
	public override void Write(Utf8JsonWriter JKKEKKKNJIN, Dictionary<TKey, int> OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C7B3A0", Offset = "0x4C79FA0", VA = "0x184C7B3A0")]
	public HMAAOMAKHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class MGFDGJINEOH<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x54BA7C0", Offset = "0x54B93C0", VA = "0x1854BA7C0", Slot = "27")]
	public override T[] Read(Utf8JsonReader EENAIFHJAJK, Type ACECCBFELHD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x54BAA80", Offset = "0x54B9680", VA = "0x1854BAA80", Slot = "28")]
	public override void Write(Utf8JsonWriter JKKEKKKNJIN, T[] OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46FCAF0", Offset = "0x46FB6F0", VA = "0x1846FCAF0")]
	protected MGFDGJINEOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class DDNAOLIBDMH<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? FIKAOJBLDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA246C0", Offset = "0xA232C0", VA = "0x180A246C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MIBHOBGDAEB(float[] AIPJHMCGMIB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] DCHGJGHKDIF(T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B888A0", Offset = "0x6B874A0", VA = "0x186B888A0", Slot = "27")]
	public override T Read(Utf8JsonReader EENAIFHJAJK, Type ACECCBFELHD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B88DA0", Offset = "0x6B879A0", VA = "0x186B88DA0", Slot = "28")]
	public override void Write(Utf8JsonWriter JKKEKKKNJIN, T OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46FCAF0", Offset = "0x46FB6F0", VA = "0x1846FCAF0")]
	protected DDNAOLIBDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NKOEKEMNEGN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E097B0", Offset = "0x7E083B0", VA = "0x187E097B0")]
	public static void PJAAKOGDNDO(this Utf8JsonWriter JKKEKKKNJIN, string HGJNKBHNLKN, bool OOHGFGHCOAJ, bool IPOLOHBNCGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E09630", Offset = "0x7E08230", VA = "0x187E09630")]
	public static bool GPAEMFIDOAM(this Utf8JsonReader EENAIFHJAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E09700", Offset = "0x7E08300", VA = "0x187E09700")]
	public static void JLOHCAHKMNO(this Utf8JsonWriter JKKEKKKNJIN, string HGJNKBHNLKN, int? OOHGFGHCOAJ, int IPOLOHBNCGD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E09650", Offset = "0x7E08250", VA = "0x187E09650")]
	public static void HFIKGLAMGPH(this Utf8JsonWriter JKKEKKKNJIN, string HGJNKBHNLKN, long? OOHGFGHCOAJ, long IPOLOHBNCGD = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C422B0", Offset = "0x3C40EB0", VA = "0x183C422B0")]
	public static void BLBGLHBDAPA<T>(this Utf8JsonWriter JKKEKKKNJIN, string HGJNKBHNLKN, JsonSerializerOptions LEKHKJDBHCI, T AGKJLFOJIKC, T LJDCGJPOMFP) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E097E0", Offset = "0x7E083E0", VA = "0x187E097E0")]
	public static void PJFJPNHIENI(this Utf8JsonWriter JKKEKKKNJIN, float OOHGFGHCOAJ, int FGDPHFDKPBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class COECDCGMKKC<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x699A300", Offset = "0x6998F00", VA = "0x18699A300", Slot = "27")]
	public override T Read(Utf8JsonReader EENAIFHJAJK, Type ACECCBFELHD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x699A3A0", Offset = "0x6998FA0", VA = "0x18699A3A0", Slot = "28")]
	public override void Write(Utf8JsonWriter JKKEKKKNJIN, T OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x47A0950", Offset = "0x479F550", VA = "0x1847A0950")]
	public COECDCGMKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ACAIECLPCEP : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CKHLDPPPBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA28290", Offset = "0xA26E90", VA = "0x180A28290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA27D50", Offset = "0xA26950", VA = "0x180A27D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E093D0", Offset = "0x7E07FD0", VA = "0x187E093D0", Slot = "27")]
	public override float Read(Utf8JsonReader EENAIFHJAJK, Type ACECCBFELHD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E093E0", Offset = "0x7E07FE0", VA = "0x187E093E0", Slot = "28")]
	public override void Write(Utf8JsonWriter JKKEKKKNJIN, float OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E09580", Offset = "0x7E08180", VA = "0x187E09580")]
	public ACAIECLPCEP()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class MCKNLIHMKLH<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void MEJGFGGBKIB(Utf8JsonReader FBIKENCMLKN);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D653A0", Offset = "0x4D647A0", VA = "0x184D653A0", Slot = "27")]
	public override T Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D65590", Offset = "0x4D64990", VA = "0x184D65590", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, T KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, T MBDDOPABDGG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, T KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3FCA700", Offset = "0x3FC9B00", VA = "0x183FCA700")]
	protected MCKNLIHMKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DKBEFAKOBPI : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x749E8B0", Offset = "0x749DCB0", VA = "0x18749E8B0")]
	public DKBEFAKOBPI(string BPEJALFMHHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KLJCIACBBCP<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A66180", Offset = "0x4A65580", VA = "0x184A66180", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A663C0", Offset = "0x4A657C0", VA = "0x184A663C0", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, Dictionary<TKey, int> KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4405BB0", Offset = "0x4404FB0", VA = "0x184405BB0")]
	public KLJCIACBBCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class MPEPLCFNKMJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD700", Offset = "0x4DDCB00", VA = "0x184DDD700", Slot = "27")]
	public override T[] Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDA10", Offset = "0x4DDCE10", VA = "0x184DDDA10", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, T[] KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6DC0", Offset = "0x3FE61C0", VA = "0x183FE6DC0")]
	protected MPEPLCFNKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class MLFHGJIKKIA<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? EKCGNLJECKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x94FC80", Offset = "0x94F080", VA = "0x18094FC80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T JMNOLPHHGGE(float[] BMKDAHEBDHE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] OMBEABDDNID(T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DB24A0", Offset = "0x4DB18A0", VA = "0x184DB24A0", Slot = "27")]
	public override T Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2820", Offset = "0x4DB1C20", VA = "0x184DB2820", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, T KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6DC0", Offset = "0x3FE61C0", VA = "0x183FE6DC0")]
	protected MLFHGJIKKIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KAAOHLGKJGD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x749EAE0", Offset = "0x749DEE0", VA = "0x18749EAE0")]
	public static void ELKJHNFGHMC(this Utf8JsonWriter BMEAHINCLAG, string BPEJALFMHHI, bool KBGCCIOIGBD, bool IDJBNLNBJCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x749E920", Offset = "0x749DD20", VA = "0x18749E920")]
	public static bool AEAGOAMOEHI(this Utf8JsonReader AJLILPPHPPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x749EB10", Offset = "0x749DF10", VA = "0x18749EB10")]
	public static void HCGLGNMCLDG(this Utf8JsonWriter BMEAHINCLAG, string BPEJALFMHHI, int? KBGCCIOIGBD, int IDJBNLNBJCD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3449C80", Offset = "0x3449080", VA = "0x183449C80")]
	public static void GBAOHAKPNJP<T>(this Utf8JsonWriter BMEAHINCLAG, string BPEJALFMHHI, JsonSerializerOptions DCEHMKPFEJH, T DGOEGFOLJJL, T PLLGKDEGIEI) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x749E940", Offset = "0x749DD40", VA = "0x18749E940")]
	public static void CMCFABIMLFC(this Utf8JsonWriter BMEAHINCLAG, float KBGCCIOIGBD, int GKCHACFDAOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CLJFMOCFBOB<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D2F0", Offset = "0x5B2C6F0", VA = "0x185B2D2F0", Slot = "27")]
	public override T Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D390", Offset = "0x5B2C790", VA = "0x185B2D390", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, T KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x40740E0", Offset = "0x40734E0", VA = "0x1840740E0")]
	public CLJFMOCFBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NAPGFJHHACP : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GHKGHFNCCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x94BDE0", Offset = "0x94B1E0", VA = "0x18094BDE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x94B9F0", Offset = "0x94ADF0", VA = "0x18094B9F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x749EBC0", Offset = "0x749DFC0", VA = "0x18749EBC0", Slot = "27")]
	public override float Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x749EBD0", Offset = "0x749DFD0", VA = "0x18749EBD0", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, float KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x749ED70", Offset = "0x749E170", VA = "0x18749ED70")]
	public NAPGFJHHACP()
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

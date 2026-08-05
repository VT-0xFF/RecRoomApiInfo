using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class OGBPIIOBEFD<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void CDCLALPIPPN(Utf8JsonReader LIBECIMLPKK);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5000570", Offset = "0x4FFF770", VA = "0x185000570", Slot = "27")]
	public override T Read(Utf8JsonReader KLIFEKFIIAG, Type EANGNGDFNDB, JsonSerializerOptions ONCKKBCCJPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5000760", Offset = "0x4FFF960", VA = "0x185000760", Slot = "28")]
	public override void Write(Utf8JsonWriter DKHAABKGBIG, T OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void FNMEBBDMDJB(Utf8JsonReader KLIFEKFIIAG, JsonSerializerOptions ONCKKBCCJPH, string AMJCEKJIGLL, T LOKFKJLCEOD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void EBALPPJCBHM(Utf8JsonWriter DKHAABKGBIG, T OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x40A9000", Offset = "0x40A8200", VA = "0x1840A9000")]
	protected OGBPIIOBEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DMCKNFJGONE : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7635450", Offset = "0x7634650", VA = "0x187635450")]
	public DMCKNFJGONE(string AMJCEKJIGLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JCADAIPIHOC<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4954F30", Offset = "0x4954130", VA = "0x184954F30", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader KLIFEKFIIAG, Type EANGNGDFNDB, JsonSerializerOptions ONCKKBCCJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4955160", Offset = "0x4954360", VA = "0x184955160", Slot = "28")]
	public override void Write(Utf8JsonWriter DKHAABKGBIG, Dictionary<TKey, int> OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4585C30", Offset = "0x4584E30", VA = "0x184585C30")]
	public JCADAIPIHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JBKHBAPKHFE<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4954330", Offset = "0x4953530", VA = "0x184954330", Slot = "27")]
	public override T[] Read(Utf8JsonReader KLIFEKFIIAG, Type EANGNGDFNDB, JsonSerializerOptions ONCKKBCCJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4954630", Offset = "0x4953830", VA = "0x184954630", Slot = "28")]
	public override void Write(Utf8JsonWriter DKHAABKGBIG, T[] OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x40C3FF0", Offset = "0x40C31F0", VA = "0x1840C3FF0")]
	protected JBKHBAPKHFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EAGDLIHHJJL<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? HAOEFJPIGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x964F20", Offset = "0x964120", VA = "0x180964F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T FKGIIODNLPB(float[] ALKPNNHBNLO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] GAFBHFGGNLH(T OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x40D32B0", Offset = "0x40D24B0", VA = "0x1840D32B0", Slot = "27")]
	public override T Read(Utf8JsonReader KLIFEKFIIAG, Type EANGNGDFNDB, JsonSerializerOptions ONCKKBCCJPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40D4200", Offset = "0x40D3400", VA = "0x1840D4200", Slot = "28")]
	public override void Write(Utf8JsonWriter DKHAABKGBIG, T OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40C3FF0", Offset = "0x40C31F0", VA = "0x1840C3FF0")]
	protected EAGDLIHHJJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DNAAJMAGCEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x76357E0", Offset = "0x76349E0", VA = "0x1876357E0")]
	public static void OJIJBJNIDPA(this Utf8JsonWriter DKHAABKGBIG, string AMJCEKJIGLL, bool OMFJNFBDJCA, bool OGPHJJMKHNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76354C0", Offset = "0x76346C0", VA = "0x1876354C0")]
	public static bool BLCOLBCOOHB(this Utf8JsonReader KLIFEKFIIAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7635590", Offset = "0x7634790", VA = "0x187635590")]
	public static void HOKKBBOGMAN(this Utf8JsonWriter DKHAABKGBIG, string AMJCEKJIGLL, int? OMFJNFBDJCA, int OGPHJJMKHNA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76354E0", Offset = "0x76346E0", VA = "0x1876354E0")]
	public static void CGBIPBFNBOC(this Utf8JsonWriter DKHAABKGBIG, string AMJCEKJIGLL, long? OMFJNFBDJCA, long OGPHJJMKHNA = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32D1740", Offset = "0x32D0940", VA = "0x1832D1740")]
	public static void AAFFFGFCBHH<T>(this Utf8JsonWriter DKHAABKGBIG, string AMJCEKJIGLL, JsonSerializerOptions ONCKKBCCJPH, T HBMPJOCKNNL, T PFKNNNAGPCF) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7635640", Offset = "0x7634840", VA = "0x187635640")]
	public static void MEENIDELEEI(this Utf8JsonWriter DKHAABKGBIG, float OMFJNFBDJCA, int PHJJMGPLAED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JGEAKEHOMLG<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x497ADE0", Offset = "0x4979FE0", VA = "0x18497ADE0", Slot = "27")]
	public override T Read(Utf8JsonReader KLIFEKFIIAG, Type EANGNGDFNDB, JsonSerializerOptions ONCKKBCCJPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x497AE80", Offset = "0x497A080", VA = "0x18497AE80", Slot = "28")]
	public override void Write(Utf8JsonWriter DKHAABKGBIG, T OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x416F230", Offset = "0x416E430", VA = "0x18416F230")]
	public JGEAKEHOMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MAPEBDEKIDK : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BOJLLIEMECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96EC20", Offset = "0x96DE20", VA = "0x18096EC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x96E8A0", Offset = "0x96DAA0", VA = "0x18096E8A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7635810", Offset = "0x7634A10", VA = "0x187635810", Slot = "27")]
	public override float Read(Utf8JsonReader KLIFEKFIIAG, Type EANGNGDFNDB, JsonSerializerOptions ONCKKBCCJPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7635820", Offset = "0x7634A20", VA = "0x187635820", Slot = "28")]
	public override void Write(Utf8JsonWriter DKHAABKGBIG, float OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76359C0", Offset = "0x7634BC0", VA = "0x1876359C0")]
	public MAPEBDEKIDK()
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

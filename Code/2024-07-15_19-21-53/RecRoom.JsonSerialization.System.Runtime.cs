using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class FNDCECLGCKD<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void JDMJGNHFJHL(Utf8JsonReader DLFEHJOHIIJ);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C02100", Offset = "0x3C00900", VA = "0x183C02100", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C022F0", Offset = "0x3C00AF0", VA = "0x183C022F0", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, T JNHGHHKKNBB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, T JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37C35A0", Offset = "0x37C1DA0", VA = "0x1837C35A0")]
	protected FNDCECLGCKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NAJKGFLHJIB : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68FE9F0", Offset = "0x68FD1F0", VA = "0x1868FE9F0")]
	public NAJKGFLHJIB(string LMFCCDBJMHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HLIGMJABDBM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BA00", Offset = "0x3D2A200", VA = "0x183D2BA00", Slot = "27")]
	public override T[] Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BD00", Offset = "0x3D2A500", VA = "0x183D2BD00", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T[] JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37C2E50", Offset = "0x37C1650", VA = "0x1837C2E50")]
	protected HLIGMJABDBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JFPEEGOPLEO<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? BJPALHBLDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x856B80", Offset = "0x855380", VA = "0x180856B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T KKPICIHMFNP(float[] MNHECFLLMJH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] MCENKMDFCLO(T JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4094810", Offset = "0x4093010", VA = "0x184094810", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x40952C0", Offset = "0x4093AC0", VA = "0x1840952C0", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37C2E50", Offset = "0x37C1650", VA = "0x1837C2E50")]
	protected JFPEEGOPLEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HLKKLOKPKOI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68FE820", Offset = "0x68FD020", VA = "0x1868FE820")]
	public static void LKMJKNMLHIK(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, bool JMDCGOKJIDA, bool LIAHLPBCKNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68FE750", Offset = "0x68FCF50", VA = "0x1868FE750")]
	public static bool CNPAGILMOPE(this Utf8JsonReader ELOKBGPKALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68FE770", Offset = "0x68FCF70", VA = "0x1868FE770")]
	public static void IBICHLNHHLC(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, int? JMDCGOKJIDA, int LIAHLPBCKNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F090", Offset = "0x2B6D890", VA = "0x182B6F090")]
	public static void GGHNKAFPDNG<T>(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, JsonSerializerOptions FDGBBGJEJMA, T GPBAFILNEOM, T EGNEHDMGCGA) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68FE850", Offset = "0x68FD050", VA = "0x1868FE850")]
	public static void ODJBHMNGIGH(this Utf8JsonWriter JLIOPEDCMBE, float JMDCGOKJIDA, int HHMFIBPPHNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GJEBJFOHKBB<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFFB0", Offset = "0x3CBE7B0", VA = "0x183CBFFB0", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0050", Offset = "0x3CBE850", VA = "0x183CC0050", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x384D5C0", Offset = "0x384BDC0", VA = "0x18384D5C0")]
	public GJEBJFOHKBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NKPPJBFJABJ : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PCGPMDKHFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x858FA0", Offset = "0x8577A0", VA = "0x180858FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8577B0", VA = "0x180858FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68FEA60", Offset = "0x68FD260", VA = "0x1868FEA60", Slot = "27")]
	public override float Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68FEA70", Offset = "0x68FD270", VA = "0x1868FEA70", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, float JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68FEC10", Offset = "0x68FD410", VA = "0x1868FEC10")]
	public NKPPJBFJABJ()
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

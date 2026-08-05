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
	[Cpp2IlInjected.Address(RVA = "0x3C02200", Offset = "0x3C00C00", VA = "0x183C02200", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C023F0", Offset = "0x3C00DF0", VA = "0x183C023F0", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x37C36A0", Offset = "0x37C20A0", VA = "0x1837C36A0")]
	protected FNDCECLGCKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NAJKGFLHJIB : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68FEAF0", Offset = "0x68FD4F0", VA = "0x1868FEAF0")]
	public NAJKGFLHJIB(string LMFCCDBJMHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HLIGMJABDBM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BB00", Offset = "0x3D2A500", VA = "0x183D2BB00", Slot = "27")]
	public override T[] Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BE00", Offset = "0x3D2A800", VA = "0x183D2BE00", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T[] JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37C2F50", Offset = "0x37C1950", VA = "0x1837C2F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x856B80", Offset = "0x855580", VA = "0x180856B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x4094910", Offset = "0x4093310", VA = "0x184094910", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x40953C0", Offset = "0x4093DC0", VA = "0x1840953C0", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37C2F50", Offset = "0x37C1950", VA = "0x1837C2F50")]
	protected JFPEEGOPLEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HLKKLOKPKOI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68FE920", Offset = "0x68FD320", VA = "0x1868FE920")]
	public static void LKMJKNMLHIK(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, bool JMDCGOKJIDA, bool LIAHLPBCKNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68FE850", Offset = "0x68FD250", VA = "0x1868FE850")]
	public static bool CNPAGILMOPE(this Utf8JsonReader ELOKBGPKALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68FE870", Offset = "0x68FD270", VA = "0x1868FE870")]
	public static void IBICHLNHHLC(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, int? JMDCGOKJIDA, int LIAHLPBCKNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EE10", Offset = "0x2B6D810", VA = "0x182B6EE10")]
	public static void GGHNKAFPDNG<T>(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, JsonSerializerOptions FDGBBGJEJMA, T GPBAFILNEOM, T EGNEHDMGCGA) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68FE950", Offset = "0x68FD350", VA = "0x1868FE950")]
	public static void ODJBHMNGIGH(this Utf8JsonWriter JLIOPEDCMBE, float JMDCGOKJIDA, int HHMFIBPPHNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GJEBJFOHKBB<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CC00B0", Offset = "0x3CBEAB0", VA = "0x183CC00B0", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0150", Offset = "0x3CBEB50", VA = "0x183CC0150", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x384D6C0", Offset = "0x384C0C0", VA = "0x18384D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x858FA0", Offset = "0x8579A0", VA = "0x180858FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8579B0", VA = "0x180858FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68FEB60", Offset = "0x68FD560", VA = "0x1868FEB60", Slot = "27")]
	public override float Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68FEB70", Offset = "0x68FD570", VA = "0x1868FEB70", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, float JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68FED10", Offset = "0x68FD710", VA = "0x1868FED10")]
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

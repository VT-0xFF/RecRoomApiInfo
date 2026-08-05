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
	[Cpp2IlInjected.Address(RVA = "0x3C14E90", Offset = "0x3C14090", VA = "0x183C14E90", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C15080", Offset = "0x3C14280", VA = "0x183C15080", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x37D8380", Offset = "0x37D7580", VA = "0x1837D8380")]
	protected FNDCECLGCKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NAJKGFLHJIB : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6918DE0", Offset = "0x6917FE0", VA = "0x186918DE0")]
	public NAJKGFLHJIB(string LMFCCDBJMHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HLIGMJABDBM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D3FD30", Offset = "0x3D3EF30", VA = "0x183D3FD30", Slot = "27")]
	public override T[] Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D40030", Offset = "0x3D3F230", VA = "0x183D40030", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T[] JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37D7C30", Offset = "0x37D6E30", VA = "0x1837D7C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x856B80", Offset = "0x855D80", VA = "0x180856B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x40A9F00", Offset = "0x40A9100", VA = "0x1840A9F00", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x40AA9B0", Offset = "0x40A9BB0", VA = "0x1840AA9B0", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37D7C30", Offset = "0x37D6E30", VA = "0x1837D7C30")]
	protected JFPEEGOPLEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HLKKLOKPKOI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6918C10", Offset = "0x6917E10", VA = "0x186918C10")]
	public static void LKMJKNMLHIK(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, bool JMDCGOKJIDA, bool LIAHLPBCKNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6918B40", Offset = "0x6917D40", VA = "0x186918B40")]
	public static bool CNPAGILMOPE(this Utf8JsonReader ELOKBGPKALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6918B60", Offset = "0x6917D60", VA = "0x186918B60")]
	public static void IBICHLNHHLC(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, int? JMDCGOKJIDA, int LIAHLPBCKNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D580", Offset = "0x2B7C780", VA = "0x182B7D580")]
	public static void GGHNKAFPDNG<T>(this Utf8JsonWriter JLIOPEDCMBE, string LMFCCDBJMHJ, JsonSerializerOptions FDGBBGJEJMA, T GPBAFILNEOM, T EGNEHDMGCGA) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6918C40", Offset = "0x6917E40", VA = "0x186918C40")]
	public static void ODJBHMNGIGH(this Utf8JsonWriter JLIOPEDCMBE, float JMDCGOKJIDA, int HHMFIBPPHNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GJEBJFOHKBB<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4280", Offset = "0x3CD3480", VA = "0x183CD4280", Slot = "27")]
	public override T Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4320", Offset = "0x3CD3520", VA = "0x183CD4320", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, T JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3862330", Offset = "0x3861530", VA = "0x183862330")]
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
		[Cpp2IlInjected.Address(RVA = "0x858FA0", Offset = "0x8581A0", VA = "0x180858FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8581B0", VA = "0x180858FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6918E50", Offset = "0x6918050", VA = "0x186918E50", Slot = "27")]
	public override float Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6918E60", Offset = "0x6918060", VA = "0x186918E60", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, float JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6919000", Offset = "0x6918200", VA = "0x186919000")]
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

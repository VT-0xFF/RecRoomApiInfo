using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class OIFIHGEMFMA<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void JLFGNJNKAOF(Utf8JsonReader LONPDOIHFKH);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4697350", Offset = "0x4696750", VA = "0x184697350", Slot = "27")]
	public override T Read(Utf8JsonReader CKPGDBBGEAK, Type KDPCMKEFAIB, JsonSerializerOptions ANGMLGCFELB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4697540", Offset = "0x4696940", VA = "0x184697540", Slot = "28")]
	public override void Write(Utf8JsonWriter CCOPEDCAMKJ, T OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void BCBLELBBGAA(Utf8JsonReader CKPGDBBGEAK, JsonSerializerOptions ANGMLGCFELB, string DHNNKKAIOAA, T OFMNHGBOMAP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void GGFPEBJNGLO(Utf8JsonWriter CCOPEDCAMKJ, T OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37CFC30", Offset = "0x37CF030", VA = "0x1837CFC30")]
	protected OIFIHGEMFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EEIHMEILHHK : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x691D1C0", Offset = "0x691C5C0", VA = "0x18691D1C0")]
	public EEIHMEILHHK(string DHNNKKAIOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DPOKMEOCCDO<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x57AFA00", Offset = "0x57AEE00", VA = "0x1857AFA00", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader CKPGDBBGEAK, Type KDPCMKEFAIB, JsonSerializerOptions ANGMLGCFELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x57AFC40", Offset = "0x57AF040", VA = "0x1857AFC40", Slot = "28")]
	public override void Write(Utf8JsonWriter CCOPEDCAMKJ, Dictionary<TKey, int> OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x575DFD0", Offset = "0x575D3D0", VA = "0x18575DFD0")]
	public DPOKMEOCCDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class INIMJDAJNIO<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E79AB0", Offset = "0x3E78EB0", VA = "0x183E79AB0", Slot = "27")]
	public override T[] Read(Utf8JsonReader CKPGDBBGEAK, Type KDPCMKEFAIB, JsonSerializerOptions ANGMLGCFELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E79DB0", Offset = "0x3E791B0", VA = "0x183E79DB0", Slot = "28")]
	public override void Write(Utf8JsonWriter CCOPEDCAMKJ, T[] OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x37CF4D0", Offset = "0x37CE8D0", VA = "0x1837CF4D0")]
	protected INIMJDAJNIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class FALJPGJCKKB<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? MBLPPGDMHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8541F0", Offset = "0x8535F0", VA = "0x1808541F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T BKOBFJAFNAK(float[] FJJNGLOPNDO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] DDIJPMGPJCD(T OBEEJPGJPFD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C04790", Offset = "0x3C03B90", VA = "0x183C04790", Slot = "27")]
	public override T Read(Utf8JsonReader CKPGDBBGEAK, Type KDPCMKEFAIB, JsonSerializerOptions ANGMLGCFELB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C04E40", Offset = "0x3C04240", VA = "0x183C04E40", Slot = "28")]
	public override void Write(Utf8JsonWriter CCOPEDCAMKJ, T OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37CF4D0", Offset = "0x37CE8D0", VA = "0x1837CF4D0")]
	protected FALJPGJCKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OPFHOHCJJPK
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x691D4D0", Offset = "0x691C8D0", VA = "0x18691D4D0")]
	public static void CMANKCLANKE(this Utf8JsonWriter CCOPEDCAMKJ, string DHNNKKAIOAA, bool OBEEJPGJPFD, bool DFNADAHDJII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x691D6A0", Offset = "0x691CAA0", VA = "0x18691D6A0")]
	public static bool NGAJHBABICO(this Utf8JsonReader CKPGDBBGEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x691D420", Offset = "0x691C820", VA = "0x18691D420")]
	public static void BJPLCMJCHAP(this Utf8JsonWriter CCOPEDCAMKJ, string DHNNKKAIOAA, int? OBEEJPGJPFD, int DFNADAHDJII = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C3F0", Offset = "0x2D2B7F0", VA = "0x182D2C3F0")]
	public static void BCIPNKCPIOE<T>(this Utf8JsonWriter CCOPEDCAMKJ, string DHNNKKAIOAA, JsonSerializerOptions ANGMLGCFELB, T ELOBPEFBAOG, T LDGGHLEPBMA) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x691D500", Offset = "0x691C900", VA = "0x18691D500")]
	public static void HBLOECOHOLP(this Utf8JsonWriter CCOPEDCAMKJ, float OBEEJPGJPFD, int ODLCCOCLKJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JMDGIKMLPCM<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4075D70", Offset = "0x4075170", VA = "0x184075D70", Slot = "27")]
	public override T Read(Utf8JsonReader CKPGDBBGEAK, Type KDPCMKEFAIB, JsonSerializerOptions ANGMLGCFELB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4075E10", Offset = "0x4075210", VA = "0x184075E10", Slot = "28")]
	public override void Write(Utf8JsonWriter CCOPEDCAMKJ, T OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38EF990", Offset = "0x38EED90", VA = "0x1838EF990")]
	public JMDGIKMLPCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OOACEMAILNE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EHJCLKOPFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x857630", Offset = "0x856A30", VA = "0x180857630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x857290", Offset = "0x856690", VA = "0x180857290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x691D230", Offset = "0x691C630", VA = "0x18691D230", Slot = "27")]
	public override float Read(Utf8JsonReader CKPGDBBGEAK, Type KDPCMKEFAIB, JsonSerializerOptions ANGMLGCFELB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x691D240", Offset = "0x691C640", VA = "0x18691D240", Slot = "28")]
	public override void Write(Utf8JsonWriter CCOPEDCAMKJ, float OBEEJPGJPFD, JsonSerializerOptions ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x691D3E0", Offset = "0x691C7E0", VA = "0x18691D3E0")]
	public OOACEMAILNE()
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

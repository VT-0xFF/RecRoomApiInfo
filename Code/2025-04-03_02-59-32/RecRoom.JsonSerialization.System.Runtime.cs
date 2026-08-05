using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GNKEGOAIBDC<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void JPNAFGCHICO(Utf8JsonReader IEDBNFIMLNL);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x485D580", Offset = "0x485C980", VA = "0x18485D580", Slot = "27")]
	public override T Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x485D770", Offset = "0x485CB70", VA = "0x18485D770", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, T FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, T MGCEJOCCONP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, T FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x423E320", Offset = "0x423D720", VA = "0x18423E320")]
	protected GNKEGOAIBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MEDOMJABPDO : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78C2E60", Offset = "0x78C2260", VA = "0x1878C2E60")]
	public MEDOMJABPDO(string MOIADMOIDPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AMMAOJIAKND<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A1CC80", Offset = "0x4A1C080", VA = "0x184A1CC80", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A1CEC0", Offset = "0x4A1C2C0", VA = "0x184A1CEC0", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, Dictionary<TKey, int> FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4792960", Offset = "0x4791D60", VA = "0x184792960")]
	public AMMAOJIAKND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NMFNFBPBDIM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50E2E20", Offset = "0x50E2220", VA = "0x1850E2E20", Slot = "27")]
	public override T[] Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x50E3120", Offset = "0x50E2520", VA = "0x1850E3120", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, T[] FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4259870", Offset = "0x4258C70", VA = "0x184259870")]
	protected NMFNFBPBDIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class NKIFMCNCECJ<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? FJONFOIINAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x994530", Offset = "0x993930", VA = "0x180994530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T KGKMLPCLAEP(float[] JGMAGBDHLIF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] CNGHJFEEEPF(T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50E0140", Offset = "0x50DF540", VA = "0x1850E0140", Slot = "27")]
	public override T Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50E0980", Offset = "0x50DFD80", VA = "0x1850E0980", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, T FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4259870", Offset = "0x4258C70", VA = "0x184259870")]
	protected NKIFMCNCECJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JEJPPGOJPJL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x78C2BC0", Offset = "0x78C1FC0", VA = "0x1878C2BC0")]
	public static void HCFAKBJPMAP(this Utf8JsonWriter CEAJPINGICH, string MOIADMOIDPH, bool FFOEEMKIKJO, bool PFCPDJEHNAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x78C2BF0", Offset = "0x78C1FF0", VA = "0x1878C2BF0")]
	public static bool HKILFMMBOLC(this Utf8JsonReader HGFGHNJEEAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x78C2B10", Offset = "0x78C1F10", VA = "0x1878C2B10")]
	public static void FJDMNPKMPIF(this Utf8JsonWriter CEAJPINGICH, string MOIADMOIDPH, int? FFOEEMKIKJO, int PFCPDJEHNAP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x78C2C10", Offset = "0x78C2010", VA = "0x1878C2C10")]
	public static void IEMGDADFFGJ(this Utf8JsonWriter CEAJPINGICH, string MOIADMOIDPH, long? FFOEEMKIKJO, long PFCPDJEHNAP = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3671D10", Offset = "0x3671110", VA = "0x183671D10")]
	public static void GGBJPKGGFEB<T>(this Utf8JsonWriter CEAJPINGICH, string MOIADMOIDPH, JsonSerializerOptions FBCMGOKFCPJ, T PCJCDFNKKKE, T KFNAEGPBIND) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x78C2CC0", Offset = "0x78C20C0", VA = "0x1878C2CC0")]
	public static void LPOKPFECPIE(this Utf8JsonWriter CEAJPINGICH, float FFOEEMKIKJO, int FCFDEMHKDIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ONJIGMEGOAE<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x51FFF10", Offset = "0x51FF310", VA = "0x1851FFF10", Slot = "27")]
	public override T Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x51FFFB0", Offset = "0x51FF3B0", VA = "0x1851FFFB0", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, T FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4335F20", Offset = "0x4335320", VA = "0x184335F20")]
	public ONJIGMEGOAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NICGDHJJACM : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DFLGFDJHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99A290", Offset = "0x999690", VA = "0x18099A290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99A280", Offset = "0x999680", VA = "0x18099A280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x78C2ED0", Offset = "0x78C22D0", VA = "0x1878C2ED0", Slot = "27")]
	public override float Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78C2EE0", Offset = "0x78C22E0", VA = "0x1878C2EE0", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, float FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x78C3080", Offset = "0x78C2480", VA = "0x1878C3080")]
	public NICGDHJJACM()
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

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
	[Cpp2IlInjected.Address(RVA = "0x4875AD0", Offset = "0x4874ED0", VA = "0x184875AD0", Slot = "27")]
	public override T Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4875CC0", Offset = "0x48750C0", VA = "0x184875CC0", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x425BC30", Offset = "0x425B030", VA = "0x18425BC30")]
	protected GNKEGOAIBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MEDOMJABPDO : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7911700", Offset = "0x7910B00", VA = "0x187911700")]
	public MEDOMJABPDO(string MOIADMOIDPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AMMAOJIAKND<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49F87B0", Offset = "0x49F7BB0", VA = "0x1849F87B0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49F89F0", Offset = "0x49F7DF0", VA = "0x1849F89F0", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, Dictionary<TKey, int> FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x47AAE90", Offset = "0x47AA290", VA = "0x1847AAE90")]
	public AMMAOJIAKND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NMFNFBPBDIM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5103E50", Offset = "0x5103250", VA = "0x185103E50", Slot = "27")]
	public override T[] Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5104150", Offset = "0x5103550", VA = "0x185104150", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, T[] FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4278540", Offset = "0x4277940", VA = "0x184278540")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9AA500", Offset = "0x9A9900", VA = "0x1809AA500")]
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
	[Cpp2IlInjected.Address(RVA = "0x51011A0", Offset = "0x51005A0", VA = "0x1851011A0", Slot = "27")]
	public override T Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x51019E0", Offset = "0x5100DE0", VA = "0x1851019E0", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, T FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4278540", Offset = "0x4277940", VA = "0x184278540")]
	protected NKIFMCNCECJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JEJPPGOJPJL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7911460", Offset = "0x7910860", VA = "0x187911460")]
	public static void HCFAKBJPMAP(this Utf8JsonWriter CEAJPINGICH, string MOIADMOIDPH, bool FFOEEMKIKJO, bool PFCPDJEHNAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7911490", Offset = "0x7910890", VA = "0x187911490")]
	public static bool HKILFMMBOLC(this Utf8JsonReader HGFGHNJEEAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x79113B0", Offset = "0x79107B0", VA = "0x1879113B0")]
	public static void FJDMNPKMPIF(this Utf8JsonWriter CEAJPINGICH, string MOIADMOIDPH, int? FFOEEMKIKJO, int PFCPDJEHNAP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x79114B0", Offset = "0x79108B0", VA = "0x1879114B0")]
	public static void IEMGDADFFGJ(this Utf8JsonWriter CEAJPINGICH, string MOIADMOIDPH, long? FFOEEMKIKJO, long PFCPDJEHNAP = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3685190", Offset = "0x3684590", VA = "0x183685190")]
	public static void GGBJPKGGFEB<T>(this Utf8JsonWriter CEAJPINGICH, string MOIADMOIDPH, JsonSerializerOptions FBCMGOKFCPJ, T PCJCDFNKKKE, T KFNAEGPBIND) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7911560", Offset = "0x7910960", VA = "0x187911560")]
	public static void LPOKPFECPIE(this Utf8JsonWriter CEAJPINGICH, float FFOEEMKIKJO, int FCFDEMHKDIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ONJIGMEGOAE<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5231570", Offset = "0x5230970", VA = "0x185231570", Slot = "27")]
	public override T Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5231610", Offset = "0x5230A10", VA = "0x185231610", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, T FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4355490", Offset = "0x4354890", VA = "0x184355490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B01D0", Offset = "0x9AF5D0", VA = "0x1809B01D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B01C0", Offset = "0x9AF5C0", VA = "0x1809B01C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7911770", Offset = "0x7910B70", VA = "0x187911770", Slot = "27")]
	public override float Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7911780", Offset = "0x7910B80", VA = "0x187911780", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, float FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7911920", Offset = "0x7910D20", VA = "0x187911920")]
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

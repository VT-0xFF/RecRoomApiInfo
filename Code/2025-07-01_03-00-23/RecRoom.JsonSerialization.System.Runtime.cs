using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class LPPGONGBJCO<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void CLEOOCOJAIP(Utf8JsonReader GBHEJJJMLLO);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x543A550", Offset = "0x5438B50", VA = "0x18543A550", Slot = "27")]
	public override T Read(Utf8JsonReader KMBIKKJCMFN, Type OAJKAHMGCDM, JsonSerializerOptions PANLLLBJFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x543A740", Offset = "0x5438D40", VA = "0x18543A740", Slot = "28")]
	public override void Write(Utf8JsonWriter DCGAFNKBAGF, T KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void CMDBACILNBC(Utf8JsonReader KMBIKKJCMFN, JsonSerializerOptions PANLLLBJFBB, string ALIOJODOECN, T GANFJJCKLGF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void DIDJPEEPPFE(Utf8JsonWriter DCGAFNKBAGF, T KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4725F70", Offset = "0x4724570", VA = "0x184725F70")]
	protected LPPGONGBJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IAHJCHFIGHG : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC780", Offset = "0x7FEAD80", VA = "0x187FEC780")]
	public IAHJCHFIGHG(string ALIOJODOECN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MNFPOJBAMOB<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5615140", Offset = "0x5613740", VA = "0x185615140", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader KMBIKKJCMFN, Type OAJKAHMGCDM, JsonSerializerOptions PANLLLBJFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5615340", Offset = "0x5613940", VA = "0x185615340", Slot = "28")]
	public override void Write(Utf8JsonWriter DCGAFNKBAGF, Dictionary<TKey, int> KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7610", Offset = "0x4CB5C10", VA = "0x184CB7610")]
	public MNFPOJBAMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HCIDKGLAJGD<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4DDB560", Offset = "0x4DD9B60", VA = "0x184DDB560", Slot = "27")]
	public override T[] Read(Utf8JsonReader KMBIKKJCMFN, Type OAJKAHMGCDM, JsonSerializerOptions PANLLLBJFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DDB840", Offset = "0x4DD9E40", VA = "0x184DDB840", Slot = "28")]
	public override void Write(Utf8JsonWriter DCGAFNKBAGF, T[] KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4743F10", Offset = "0x4742510", VA = "0x184743F10")]
	protected HCIDKGLAJGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class LKGEIDDIFOA<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? ECOBPOGDOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA50C90", Offset = "0xA4F290", VA = "0x180A50C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T AOMMIPJHIMA(float[] NIJLHKNCLKB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] DCHHGDINECP(T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5427080", Offset = "0x5425680", VA = "0x185427080", Slot = "27")]
	public override T Read(Utf8JsonReader KMBIKKJCMFN, Type OAJKAHMGCDM, JsonSerializerOptions PANLLLBJFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5428370", Offset = "0x5426970", VA = "0x185428370", Slot = "28")]
	public override void Write(Utf8JsonWriter DCGAFNKBAGF, T KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4743F10", Offset = "0x4742510", VA = "0x184743F10")]
	protected LKGEIDDIFOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GLBECHGFOHE
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC430", Offset = "0x7FEAA30", VA = "0x187FEC430")]
	public static void APJJCHALMMG(this Utf8JsonWriter DCGAFNKBAGF, string ALIOJODOECN, bool KKGBKLFKCPO, bool COMAGLLDBOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC6B0", Offset = "0x7FEACB0", VA = "0x187FEC6B0")]
	public static bool MEBGICKFBEC(this Utf8JsonReader KMBIKKJCMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC600", Offset = "0x7FEAC00", VA = "0x187FEC600")]
	public static void HGGNEBIACGF(this Utf8JsonWriter DCGAFNKBAGF, string ALIOJODOECN, int? KKGBKLFKCPO, int COMAGLLDBOM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC6D0", Offset = "0x7FEACD0", VA = "0x187FEC6D0")]
	public static void PHCPMJODEKB(this Utf8JsonWriter DCGAFNKBAGF, string ALIOJODOECN, long? KKGBKLFKCPO, long COMAGLLDBOM = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B53130", Offset = "0x3B51730", VA = "0x183B53130")]
	public static void CGJLGLOFEEB<T>(this Utf8JsonWriter DCGAFNKBAGF, string ALIOJODOECN, JsonSerializerOptions PANLLLBJFBB, T FADBOFNILPL, T KABEHHHCHDA) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC460", Offset = "0x7FEAA60", VA = "0x187FEC460")]
	public static void BBOIAMPKOBB(this Utf8JsonWriter DCGAFNKBAGF, float KKGBKLFKCPO, int IALMOEPBFNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KLHDJOLHMMG<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x52DDCD0", Offset = "0x52DC2D0", VA = "0x1852DDCD0", Slot = "27")]
	public override T Read(Utf8JsonReader KMBIKKJCMFN, Type OAJKAHMGCDM, JsonSerializerOptions PANLLLBJFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x52DDD70", Offset = "0x52DC370", VA = "0x1852DDD70", Slot = "28")]
	public override void Write(Utf8JsonWriter DCGAFNKBAGF, T KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x47EDA40", Offset = "0x47EC040", VA = "0x1847EDA40")]
	public KLHDJOLHMMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MPEOODHOLIA : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DAPDMGMBEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA47FE0", Offset = "0xA465E0", VA = "0x180A47FE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA47FD0", Offset = "0xA465D0", VA = "0x180A47FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC7F0", Offset = "0x7FEADF0", VA = "0x187FEC7F0", Slot = "27")]
	public override float Read(Utf8JsonReader KMBIKKJCMFN, Type OAJKAHMGCDM, JsonSerializerOptions PANLLLBJFBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC800", Offset = "0x7FEAE00", VA = "0x187FEC800", Slot = "28")]
	public override void Write(Utf8JsonWriter DCGAFNKBAGF, float KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC9A0", Offset = "0x7FEAFA0", VA = "0x187FEC9A0")]
	public MPEOODHOLIA()
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

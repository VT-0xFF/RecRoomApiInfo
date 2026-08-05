using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class AFKCBBDDCBO<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void OPCHDNAAGCG(Utf8JsonReader GGILEDABHIF);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x49E8130", Offset = "0x49E6930", VA = "0x1849E8130", Slot = "27")]
	public override T Read(Utf8JsonReader DMPKKEDJKBJ, Type BFFDAIGKELI, JsonSerializerOptions AKIEDMONOFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49E8320", Offset = "0x49E6B20", VA = "0x1849E8320", Slot = "28")]
	public override void Write(Utf8JsonWriter HIKMEOJBJOJ, T OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void OOGJENLGCFO(Utf8JsonReader DMPKKEDJKBJ, JsonSerializerOptions AKIEDMONOFM, string KCHPJMPLPDP, T BLFLGKHLJNB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void MOGDIDIMJKC(Utf8JsonWriter HIKMEOJBJOJ, T OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x43AB170", Offset = "0x43A9970", VA = "0x1843AB170")]
	protected AFKCBBDDCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FPEEJFLAHCN : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B67640", Offset = "0x7B65E40", VA = "0x187B67640")]
	public FPEEJFLAHCN(string KCHPJMPLPDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BNNNFIHMOFB<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6016970", Offset = "0x6015170", VA = "0x186016970", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader DMPKKEDJKBJ, Type BFFDAIGKELI, JsonSerializerOptions AKIEDMONOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6016BB0", Offset = "0x60153B0", VA = "0x186016BB0", Slot = "28")]
	public override void Write(Utf8JsonWriter HIKMEOJBJOJ, Dictionary<TKey, int> OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x490C1E0", Offset = "0x490A9E0", VA = "0x18490C1E0")]
	public BNNNFIHMOFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OINGPPAIFMB<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5473BE0", Offset = "0x54723E0", VA = "0x185473BE0", Slot = "27")]
	public override T[] Read(Utf8JsonReader DMPKKEDJKBJ, Type BFFDAIGKELI, JsonSerializerOptions AKIEDMONOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5473EE0", Offset = "0x54726E0", VA = "0x185473EE0", Slot = "28")]
	public override void Write(Utf8JsonWriter HIKMEOJBJOJ, T[] OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x43C7A80", Offset = "0x43C6280", VA = "0x1843C7A80")]
	protected OINGPPAIFMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GEBLCJMBEGI<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? JADKNOJCJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DF0", Offset = "0x9DF5F0", VA = "0x1809E0DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T APBJPKEFBJG(float[] MGEDIIGJIGC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] FINOOPDOPBB(T OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x498A380", Offset = "0x4988B80", VA = "0x18498A380", Slot = "27")]
	public override T Read(Utf8JsonReader DMPKKEDJKBJ, Type BFFDAIGKELI, JsonSerializerOptions AKIEDMONOFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x498B1B0", Offset = "0x49899B0", VA = "0x18498B1B0", Slot = "28")]
	public override void Write(Utf8JsonWriter HIKMEOJBJOJ, T OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x43C7A80", Offset = "0x43C6280", VA = "0x1843C7A80")]
	protected GEBLCJMBEGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OCNIEJOBAEB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B67BC0", Offset = "0x7B663C0", VA = "0x187B67BC0")]
	public static void PMJONEBEFEH(this Utf8JsonWriter HIKMEOJBJOJ, string KCHPJMPLPDP, bool OPMIAMEJKDH, bool LHCNPHOLELG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B678A0", Offset = "0x7B660A0", VA = "0x187B678A0")]
	public static bool DNIFPFNNDBI(this Utf8JsonReader DMPKKEDJKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B67B10", Offset = "0x7B66310", VA = "0x187B67B10")]
	public static void PAHGFLIEHBB(this Utf8JsonWriter HIKMEOJBJOJ, string KCHPJMPLPDP, int? OPMIAMEJKDH, int LHCNPHOLELG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B67A60", Offset = "0x7B66260", VA = "0x187B67A60")]
	public static void LCNIHGFIMPC(this Utf8JsonWriter HIKMEOJBJOJ, string KCHPJMPLPDP, long? OPMIAMEJKDH, long LHCNPHOLELG = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x395D3E0", Offset = "0x395BBE0", VA = "0x18395D3E0")]
	public static void BDFHBILPBFH<T>(this Utf8JsonWriter HIKMEOJBJOJ, string KCHPJMPLPDP, JsonSerializerOptions AKIEDMONOFM, T DDLBJHGGANE, T AAKLAFGNGHI) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B678C0", Offset = "0x7B660C0", VA = "0x187B678C0")]
	public static void EJOOKAPBAHH(this Utf8JsonWriter HIKMEOJBJOJ, float OPMIAMEJKDH, int MHOBPLDMJPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EJJIFOKHCPC<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4404C40", Offset = "0x4403440", VA = "0x184404C40", Slot = "27")]
	public override T Read(Utf8JsonReader DMPKKEDJKBJ, Type BFFDAIGKELI, JsonSerializerOptions AKIEDMONOFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4404CE0", Offset = "0x44034E0", VA = "0x184404CE0", Slot = "28")]
	public override void Write(Utf8JsonWriter HIKMEOJBJOJ, T OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4404D90", Offset = "0x4403590", VA = "0x184404D90")]
	public EJJIFOKHCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class INPGHBMGOLN : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PEHAPGEAELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9E4120", Offset = "0x9E2920", VA = "0x1809E4120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9E4110", Offset = "0x9E2910", VA = "0x1809E4110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B676B0", Offset = "0x7B65EB0", VA = "0x187B676B0", Slot = "27")]
	public override float Read(Utf8JsonReader DMPKKEDJKBJ, Type BFFDAIGKELI, JsonSerializerOptions AKIEDMONOFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B676C0", Offset = "0x7B65EC0", VA = "0x187B676C0", Slot = "28")]
	public override void Write(Utf8JsonWriter HIKMEOJBJOJ, float OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B67860", Offset = "0x7B66060", VA = "0x187B67860")]
	public INPGHBMGOLN()
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

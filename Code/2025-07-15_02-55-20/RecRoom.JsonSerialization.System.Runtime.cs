using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class FIDLINEMCBP<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void GBOAMLDHGEM(Utf8JsonReader KFNDMAAELJD);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D74D80", Offset = "0x4D73980", VA = "0x184D74D80", Slot = "27")]
	public override T Read(Utf8JsonReader NOIAIJBDKGG, Type LBIMBFLANBF, JsonSerializerOptions ENJHAFMCLFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D74F70", Offset = "0x4D73B70", VA = "0x184D74F70", Slot = "28")]
	public override void Write(Utf8JsonWriter HDDCOPOMJML, T BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void JLHIOODMPMC(Utf8JsonReader NOIAIJBDKGG, JsonSerializerOptions ENJHAFMCLFP, string BABLEGNKCCH, T BHNJKAEPJMN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void KFKEOJGPMGB(Utf8JsonWriter HDDCOPOMJML, T BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4894B70", Offset = "0x4893770", VA = "0x184894B70")]
	protected FIDLINEMCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LKKDCBEMBBH : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8140560", Offset = "0x813F160", VA = "0x188140560")]
	public LKKDCBEMBBH(string BABLEGNKCCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OBLBLBANEOG<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x584A530", Offset = "0x5849130", VA = "0x18584A530", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader NOIAIJBDKGG, Type LBIMBFLANBF, JsonSerializerOptions ENJHAFMCLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x584A720", Offset = "0x5849320", VA = "0x18584A720", Slot = "28")]
	public override void Write(Utf8JsonWriter HDDCOPOMJML, Dictionary<TKey, int> BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1720", Offset = "0x4DE0320", VA = "0x184DE1720")]
	public OBLBLBANEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GLKPEHOPLMI<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD280", Offset = "0x4EABE80", VA = "0x184EAD280", Slot = "27")]
	public override T[] Read(Utf8JsonReader NOIAIJBDKGG, Type LBIMBFLANBF, JsonSerializerOptions ENJHAFMCLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD550", Offset = "0x4EAC150", VA = "0x184EAD550", Slot = "28")]
	public override void Write(Utf8JsonWriter HDDCOPOMJML, T[] BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48B2B90", Offset = "0x48B1790", VA = "0x1848B2B90")]
	protected GLKPEHOPLMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GOFILILCCIB<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? HCFCBDDGCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5B570", Offset = "0xA5A170", VA = "0x180A5B570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T IHEDANNNKDB(float[] OKFGGFMLPHB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] CLDFJMLAOLG(T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F261C0", Offset = "0x4F24DC0", VA = "0x184F261C0", Slot = "27")]
	public override T Read(Utf8JsonReader NOIAIJBDKGG, Type LBIMBFLANBF, JsonSerializerOptions ENJHAFMCLFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F26BD0", Offset = "0x4F257D0", VA = "0x184F26BD0", Slot = "28")]
	public override void Write(Utf8JsonWriter HDDCOPOMJML, T BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x48B2B90", Offset = "0x48B1790", VA = "0x1848B2B90")]
	protected GOFILILCCIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GLBHBHGJMGP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8140340", Offset = "0x813EF40", VA = "0x188140340")]
	public static void CJAFNDCLDCN(this Utf8JsonWriter HDDCOPOMJML, string BABLEGNKCCH, bool BKMPCFIAHIG, bool PLEDLJICBFM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8140270", Offset = "0x813EE70", VA = "0x188140270")]
	public static bool BDJPDOOLBIL(this Utf8JsonReader NOIAIJBDKGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8140290", Offset = "0x813EE90", VA = "0x188140290")]
	public static void CGABJDACNCE(this Utf8JsonWriter HDDCOPOMJML, string BABLEGNKCCH, int? BKMPCFIAHIG, int PLEDLJICBFM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8140020", Offset = "0x813EC20", VA = "0x188140020")]
	public static void ACFDNNGENOG(this Utf8JsonWriter HDDCOPOMJML, string BABLEGNKCCH, long? BKMPCFIAHIG, long PLEDLJICBFM = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C49A10", Offset = "0x3C48610", VA = "0x183C49A10")]
	public static void FKKEECLFEMD<T>(this Utf8JsonWriter HDDCOPOMJML, string BABLEGNKCCH, JsonSerializerOptions ENJHAFMCLFP, T PINMHDANIAH, T IMMGKAMOJHP) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81400D0", Offset = "0x813ECD0", VA = "0x1881400D0")]
	public static void APCJDLFIIIO(this Utf8JsonWriter HDDCOPOMJML, float BKMPCFIAHIG, int BCDCLEIDBEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MFPDFJOHFOG<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5671080", Offset = "0x566FC80", VA = "0x185671080", Slot = "27")]
	public override T Read(Utf8JsonReader NOIAIJBDKGG, Type LBIMBFLANBF, JsonSerializerOptions ENJHAFMCLFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5671120", Offset = "0x566FD20", VA = "0x185671120", Slot = "28")]
	public override void Write(Utf8JsonWriter HDDCOPOMJML, T BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4953260", Offset = "0x4951E60", VA = "0x184953260")]
	public MFPDFJOHFOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JBCGNHPLPBM : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int AOGKJMBLDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA681D0", Offset = "0xA66DD0", VA = "0x180A681D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA681E0", Offset = "0xA66DE0", VA = "0x180A681E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8140370", Offset = "0x813EF70", VA = "0x188140370", Slot = "27")]
	public override float Read(Utf8JsonReader NOIAIJBDKGG, Type LBIMBFLANBF, JsonSerializerOptions ENJHAFMCLFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8140380", Offset = "0x813EF80", VA = "0x188140380", Slot = "28")]
	public override void Write(Utf8JsonWriter HDDCOPOMJML, float BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8140520", Offset = "0x813F120", VA = "0x188140520")]
	public JBCGNHPLPBM()
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

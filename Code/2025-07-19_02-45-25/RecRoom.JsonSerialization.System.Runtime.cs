using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GLCOHBJJKID<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void IOANKPEHFGH(Utf8JsonReader AEJLPHJDEHN);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0CE0", Offset = "0x4ECFCE0", VA = "0x184ED0CE0", Slot = "27")]
	public override T Read(Utf8JsonReader AMPJMGIAGBB, Type GPLIAMMNPOC, JsonSerializerOptions EGBMNBJEHHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0ED0", Offset = "0x4ECFED0", VA = "0x184ED0ED0", Slot = "28")]
	public override void Write(Utf8JsonWriter NMCAGOGLPLD, T IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, T ADPMEPGEIDH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, T IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x48B5BD0", Offset = "0x48B4BD0", VA = "0x1848B5BD0")]
	protected GLCOHBJJKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FFAICAGKMEF : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81B35D0", Offset = "0x81B25D0", VA = "0x1881B35D0")]
	public FFAICAGKMEF(string JFNKBOFNMLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FOFJGKAGOOD<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4DBD330", Offset = "0x4DBC330", VA = "0x184DBD330", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader AMPJMGIAGBB, Type GPLIAMMNPOC, JsonSerializerOptions EGBMNBJEHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4DBD520", Offset = "0x4DBC520", VA = "0x184DBD520", Slot = "28")]
	public override void Write(Utf8JsonWriter NMCAGOGLPLD, Dictionary<TKey, int> IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4DBD730", Offset = "0x4DBC730", VA = "0x184DBD730")]
	public FOFJGKAGOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PNOKOIDNBAN<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5A85750", Offset = "0x5A84750", VA = "0x185A85750", Slot = "27")]
	public override T[] Read(Utf8JsonReader AMPJMGIAGBB, Type GPLIAMMNPOC, JsonSerializerOptions EGBMNBJEHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5A85A20", Offset = "0x5A84A20", VA = "0x185A85A20", Slot = "28")]
	public override void Write(Utf8JsonWriter NMCAGOGLPLD, T[] IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48D77F0", Offset = "0x48D67F0", VA = "0x1848D77F0")]
	protected PNOKOIDNBAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class HLCMFNOIKAG<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? JINBBFIOLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA68450", Offset = "0xA67450", VA = "0x180A68450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T BOCAPBDHLOM(float[] NCIPNLHDHEI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] OLMNNADJINC(T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F4CA00", Offset = "0x4F4BA00", VA = "0x184F4CA00", Slot = "27")]
	public override T Read(Utf8JsonReader AMPJMGIAGBB, Type GPLIAMMNPOC, JsonSerializerOptions EGBMNBJEHHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F4DB20", Offset = "0x4F4CB20", VA = "0x184F4DB20", Slot = "28")]
	public override void Write(Utf8JsonWriter NMCAGOGLPLD, T IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x48D77F0", Offset = "0x48D67F0", VA = "0x1848D77F0")]
	protected HLCMFNOIKAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JICEKEIKODM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81B37E0", Offset = "0x81B27E0", VA = "0x1881B37E0")]
	public static void FCNCKAGPPDB(this Utf8JsonWriter NMCAGOGLPLD, string JFNKBOFNMLM, bool IOALKPFEKEK, bool CAILINJCNIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81B38C0", Offset = "0x81B28C0", VA = "0x1881B38C0")]
	public static bool KFBFDEFKBFP(this Utf8JsonReader AMPJMGIAGBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81B38E0", Offset = "0x81B28E0", VA = "0x1881B38E0")]
	public static void KJKEFJDCNBB(this Utf8JsonWriter NMCAGOGLPLD, string JFNKBOFNMLM, int? IOALKPFEKEK, int CAILINJCNIJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81B3810", Offset = "0x81B2810", VA = "0x1881B3810")]
	public static void JNIIFNHLCON(this Utf8JsonWriter NMCAGOGLPLD, string JFNKBOFNMLM, long? IOALKPFEKEK, long CAILINJCNIJ = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9900", Offset = "0x3CE8900", VA = "0x183CE9900")]
	public static void ONFPEHDGCNP<T>(this Utf8JsonWriter NMCAGOGLPLD, string JFNKBOFNMLM, JsonSerializerOptions EGBMNBJEHHO, T GHNFCHHGJAG, T DCAJOHGIJAK) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81B3640", Offset = "0x81B2640", VA = "0x1881B3640")]
	public static void BFJNHMALNFC(this Utf8JsonWriter NMCAGOGLPLD, float IOALKPFEKEK, int PCKHJIMKLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FAFECMDBJCL<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D74BA0", Offset = "0x4D73BA0", VA = "0x184D74BA0", Slot = "27")]
	public override T Read(Utf8JsonReader AMPJMGIAGBB, Type GPLIAMMNPOC, JsonSerializerOptions EGBMNBJEHHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D74C40", Offset = "0x4D73C40", VA = "0x184D74C40", Slot = "28")]
	public override void Write(Utf8JsonWriter NMCAGOGLPLD, T IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x497A020", Offset = "0x4979020", VA = "0x18497A020")]
	public FAFECMDBJCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MGMHJOIPDFO : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BNIHPPMDNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA674E0", Offset = "0xA664E0", VA = "0x180A674E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA672E0", Offset = "0xA662E0", VA = "0x180A672E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81B3990", Offset = "0x81B2990", VA = "0x1881B3990", Slot = "27")]
	public override float Read(Utf8JsonReader AMPJMGIAGBB, Type GPLIAMMNPOC, JsonSerializerOptions EGBMNBJEHHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81B39A0", Offset = "0x81B29A0", VA = "0x1881B39A0", Slot = "28")]
	public override void Write(Utf8JsonWriter NMCAGOGLPLD, float IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81B3B40", Offset = "0x81B2B40", VA = "0x1881B3B40")]
	public MGMHJOIPDFO()
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

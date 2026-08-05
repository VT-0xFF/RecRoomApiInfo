using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class KFJGKIPCBIG<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void IALMHMGJBAJ(Utf8JsonReader FJIOIPCNGKD);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x43191F0", Offset = "0x4317BF0", VA = "0x1843191F0", Slot = "27")]
	public override T Read(Utf8JsonReader PHJKOICFNBE, Type CMMDFNLIMFD, JsonSerializerOptions IIPNOBBMFOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x43193F0", Offset = "0x4317DF0", VA = "0x1843193F0", Slot = "28")]
	public override void Write(Utf8JsonWriter GMONMLMLDAL, T CLMKDBDPNNH, JsonSerializerOptions IIPNOBBMFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void NNDOEBFNCIL(Utf8JsonReader PHJKOICFNBE, JsonSerializerOptions IIPNOBBMFOE, string HEOHALDGBKH, T EDKOAHIAMMF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void OANLPLFJNFO(Utf8JsonWriter GMONMLMLDAL, T CLMKDBDPNNH, JsonSerializerOptions IIPNOBBMFOE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x393EF50", Offset = "0x393D950", VA = "0x18393EF50")]
	protected KFJGKIPCBIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PDLOKEKDJJL : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1A30", Offset = "0x6BD0430", VA = "0x186BD1A30")]
	public PDLOKEKDJJL(string HEOHALDGBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LNABFGEEBGI<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x443EFB0", Offset = "0x443D9B0", VA = "0x18443EFB0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader PHJKOICFNBE, Type CMMDFNLIMFD, JsonSerializerOptions IIPNOBBMFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x443F1F0", Offset = "0x443DBF0", VA = "0x18443F1F0", Slot = "28")]
	public override void Write(Utf8JsonWriter GMONMLMLDAL, Dictionary<TKey, int> CLMKDBDPNNH, JsonSerializerOptions IIPNOBBMFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x443F410", Offset = "0x443DE10", VA = "0x18443F410")]
	public LNABFGEEBGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class IHCGCAHLDGJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x400DF70", Offset = "0x400C970", VA = "0x18400DF70", Slot = "27")]
	public override T[] Read(Utf8JsonReader PHJKOICFNBE, Type CMMDFNLIMFD, JsonSerializerOptions IIPNOBBMFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x400E290", Offset = "0x400CC90", VA = "0x18400E290", Slot = "28")]
	public override void Write(Utf8JsonWriter GMONMLMLDAL, T[] CLMKDBDPNNH, JsonSerializerOptions IIPNOBBMFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x393E7C0", Offset = "0x393D1C0", VA = "0x18393E7C0")]
	protected IHCGCAHLDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class DIFHDEMOHDL<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? PKDCIILJHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x891620", Offset = "0x890020", VA = "0x180891620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T DIGNHJAIOOG(float[] ACOKCANBLGD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] NHDDGBECIGN(T CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5A64240", Offset = "0x5A62C40", VA = "0x185A64240", Slot = "27")]
	public override T Read(Utf8JsonReader PHJKOICFNBE, Type CMMDFNLIMFD, JsonSerializerOptions IIPNOBBMFOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5A64970", Offset = "0x5A63370", VA = "0x185A64970", Slot = "28")]
	public override void Write(Utf8JsonWriter GMONMLMLDAL, T CLMKDBDPNNH, JsonSerializerOptions IIPNOBBMFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x393E7C0", Offset = "0x393D1C0", VA = "0x18393E7C0")]
	protected DIFHDEMOHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DNNAJNAJEPI
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1650", Offset = "0x6BD0050", VA = "0x186BD1650")]
	public static void DLPKLNEODOE(this Utf8JsonWriter GMONMLMLDAL, string HEOHALDGBKH, bool CLMKDBDPNNH, bool PEMAOEALEHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1820", Offset = "0x6BD0220", VA = "0x186BD1820")]
	public static bool OMLJKEAAKBP(this Utf8JsonReader PHJKOICFNBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BD15A0", Offset = "0x6BCFFA0", VA = "0x186BD15A0")]
	public static void BFLJNIFMCKA(this Utf8JsonWriter GMONMLMLDAL, string HEOHALDGBKH, int? CLMKDBDPNNH, int PEMAOEALEHB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B08D30", Offset = "0x2B07730", VA = "0x182B08D30")]
	public static void IPKHCIDEGPK<T>(this Utf8JsonWriter GMONMLMLDAL, string HEOHALDGBKH, JsonSerializerOptions IIPNOBBMFOE, T APKMEEHDCOG, T KGBONDMIDKG) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1680", Offset = "0x6BD0080", VA = "0x186BD1680")]
	public static void IMMCNPOJGBK(this Utf8JsonWriter GMONMLMLDAL, float CLMKDBDPNNH, int EEGJHMDGDEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MGJCIBDPDAK<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4615680", Offset = "0x4614080", VA = "0x184615680", Slot = "27")]
	public override T Read(Utf8JsonReader PHJKOICFNBE, Type CMMDFNLIMFD, JsonSerializerOptions IIPNOBBMFOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4615730", Offset = "0x4614130", VA = "0x184615730", Slot = "28")]
	public override void Write(Utf8JsonWriter GMONMLMLDAL, T CLMKDBDPNNH, JsonSerializerOptions IIPNOBBMFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x39F7780", Offset = "0x39F6180", VA = "0x1839F7780")]
	public MGJCIBDPDAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EFJINPLGKJO : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NKCACCCEKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x886B70", Offset = "0x885570", VA = "0x180886B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x886980", Offset = "0x885380", VA = "0x180886980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1840", Offset = "0x6BD0240", VA = "0x186BD1840", Slot = "27")]
	public override float Read(Utf8JsonReader PHJKOICFNBE, Type CMMDFNLIMFD, JsonSerializerOptions IIPNOBBMFOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1850", Offset = "0x6BD0250", VA = "0x186BD1850", Slot = "28")]
	public override void Write(Utf8JsonWriter GMONMLMLDAL, float CLMKDBDPNNH, JsonSerializerOptions IIPNOBBMFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BD19F0", Offset = "0x6BD03F0", VA = "0x186BD19F0")]
	public EFJINPLGKJO()
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

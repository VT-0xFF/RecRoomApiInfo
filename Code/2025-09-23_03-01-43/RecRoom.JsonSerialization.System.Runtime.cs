using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class JCIDINNKHCA<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void MBODJJJNKNL(Utf8JsonReader OCNJDNNPAAP);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x54B6980", Offset = "0x54B4F80", VA = "0x1854B6980", Slot = "27")]
	public override T Read(Utf8JsonReader KLIAOPJFDOK, Type GHELDBCOLBK, JsonSerializerOptions PLMLGIGGGNL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54B6BB0", Offset = "0x54B51B0", VA = "0x1854B6BB0", Slot = "28")]
	public override void Write(Utf8JsonWriter CKPHLHCIFLA, T KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "35")]
	protected virtual void FFALGPGFFKD(T NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "36")]
	protected virtual void PJNDDFDMCKN(T NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "37")]
	public abstract void PJLOBLPJLOA(Utf8JsonReader KLIAOPJFDOK, JsonSerializerOptions PLMLGIGGGNL, string JKLGGALPDGD, T NANHMPOBBLI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "38")]
	public abstract void ABGJNJOBCGP(Utf8JsonWriter CKPHLHCIFLA, T KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4691F80", Offset = "0x4690580", VA = "0x184691F80")]
	protected JCIDINNKHCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FKDOPCKEPCN : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85413A0", Offset = "0x853F9A0", VA = "0x1885413A0")]
	public FKDOPCKEPCN(string JKLGGALPDGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HNNOAAFNHMH<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5178F40", Offset = "0x5177540", VA = "0x185178F40", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader KLIAOPJFDOK, Type GHELDBCOLBK, JsonSerializerOptions PLMLGIGGGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5179140", Offset = "0x5177740", VA = "0x185179140", Slot = "28")]
	public override void Write(Utf8JsonWriter CKPHLHCIFLA, Dictionary<TKey, int> KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4614DC0", Offset = "0x46133C0", VA = "0x184614DC0")]
	public HNNOAAFNHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DEEPMGALBGG<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x464B390", Offset = "0x4649990", VA = "0x18464B390", Slot = "27")]
	public override T[] Read(Utf8JsonReader KLIAOPJFDOK, Type GHELDBCOLBK, JsonSerializerOptions PLMLGIGGGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x464B670", Offset = "0x4649C70", VA = "0x18464B670", Slot = "28")]
	public override void Write(Utf8JsonWriter CKPHLHCIFLA, T[] KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x464B780", Offset = "0x4649D80", VA = "0x18464B780")]
	protected DEEPMGALBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class NGIPAAPAACN<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? HAJHBNCKGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAA54E0", Offset = "0xAA3AE0", VA = "0x180AA54E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T PFBLLIEPMLB(float[] LGMBOCEBOMM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] NGACLBPFFMM(T KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5A80F20", Offset = "0x5A7F520", VA = "0x185A80F20", Slot = "27")]
	public override T Read(Utf8JsonReader KLIAOPJFDOK, Type GHELDBCOLBK, JsonSerializerOptions PLMLGIGGGNL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5A81430", Offset = "0x5A7FA30", VA = "0x185A81430", Slot = "28")]
	public override void Write(Utf8JsonWriter CKPHLHCIFLA, T KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x464B780", Offset = "0x4649D80", VA = "0x18464B780")]
	protected NGIPAAPAACN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AEPPMAIFLIP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8541050", Offset = "0x853F650", VA = "0x188541050")]
	public static void BBGJHMECBKI(this Utf8JsonWriter CKPHLHCIFLA, string JKLGGALPDGD, bool KOPHBHGIACG, bool APJDJFMLEAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8541080", Offset = "0x853F680", VA = "0x188541080")]
	public static bool IIEKNLNNLID(this Utf8JsonReader KLIAOPJFDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85412F0", Offset = "0x853F8F0", VA = "0x1885412F0")]
	public static void LDKHHIMPEAB(this Utf8JsonWriter CKPHLHCIFLA, string JKLGGALPDGD, int? KOPHBHGIACG, int APJDJFMLEAP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8541240", Offset = "0x853F840", VA = "0x188541240")]
	public static void JLCOIINCJNH(this Utf8JsonWriter CKPHLHCIFLA, string JKLGGALPDGD, long? KOPHBHGIACG, long APJDJFMLEAP = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32FD1F0", Offset = "0x32FB7F0", VA = "0x1832FD1F0")]
	public static void EBIJMLEEOGE<T>(this Utf8JsonWriter CKPHLHCIFLA, string JKLGGALPDGD, JsonSerializerOptions PLMLGIGGGNL, T IKJAADLGNCL, T GNLNAAOPLFJ) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85410A0", Offset = "0x853F6A0", VA = "0x1885410A0")]
	public static void IMLFHFDCDNK(this Utf8JsonWriter CKPHLHCIFLA, float KOPHBHGIACG, int HCLMLFHLBBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EEJFKOGCNCF<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F4B0", Offset = "0x4B2DAB0", VA = "0x184B2F4B0", Slot = "27")]
	public override T Read(Utf8JsonReader KLIAOPJFDOK, Type GHELDBCOLBK, JsonSerializerOptions PLMLGIGGGNL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F550", Offset = "0x4B2DB50", VA = "0x184B2F550", Slot = "28")]
	public override void Write(Utf8JsonWriter CKPHLHCIFLA, T KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x46134A0", Offset = "0x4611AA0", VA = "0x1846134A0")]
	public EEJFKOGCNCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NPODBPDMNGE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EGKJICHIILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAAA0E0", Offset = "0xAA86E0", VA = "0x180AAA0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAAA0C0", Offset = "0xAA86C0", VA = "0x180AAA0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8541410", Offset = "0x853FA10", VA = "0x188541410", Slot = "27")]
	public override float Read(Utf8JsonReader KLIAOPJFDOK, Type GHELDBCOLBK, JsonSerializerOptions PLMLGIGGGNL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8541420", Offset = "0x853FA20", VA = "0x188541420", Slot = "28")]
	public override void Write(Utf8JsonWriter CKPHLHCIFLA, float KOPHBHGIACG, JsonSerializerOptions PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85415C0", Offset = "0x853FBC0", VA = "0x1885415C0")]
	public NPODBPDMNGE()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class AFBFFIIEDDJ<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void EKPHHKIDKOA(Utf8JsonReader OLMEHKPIJHD);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5305D00", Offset = "0x5304700", VA = "0x185305D00", Slot = "27")]
	public override T Read(Utf8JsonReader DIKMKPGIBMB, Type INNODLOAIOD, JsonSerializerOptions ALFCEIKBPNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5305F30", Offset = "0x5304930", VA = "0x185305F30", Slot = "28")]
	public override void Write(Utf8JsonWriter EAPDKLFLMNB, T KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "35")]
	protected virtual void EEPDCJGOOBD(T EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "36")]
	protected virtual void PLGOECLJNNM(T EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "37")]
	public abstract void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, T EOJOFJJBHLN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "38")]
	public abstract void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, T KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x469B260", Offset = "0x4699C60", VA = "0x18469B260")]
	protected AFBFFIIEDDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OPKJICMOMJA : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85375A0", Offset = "0x8535FA0", VA = "0x1885375A0")]
	public OPKJICMOMJA(string BIHHMEFECFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ELIHLCCKCDN<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B30110", Offset = "0x4B2EB10", VA = "0x184B30110", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader DIKMKPGIBMB, Type INNODLOAIOD, JsonSerializerOptions ALFCEIKBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B30310", Offset = "0x4B2ED10", VA = "0x184B30310", Slot = "28")]
	public override void Write(Utf8JsonWriter EAPDKLFLMNB, Dictionary<TKey, int> KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B30530", Offset = "0x4B2EF30", VA = "0x184B30530")]
	public ELIHLCCKCDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PJBJGPFNOCA<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CB2480", Offset = "0x5CB0E80", VA = "0x185CB2480", Slot = "27")]
	public override T[] Read(Utf8JsonReader DIKMKPGIBMB, Type INNODLOAIOD, JsonSerializerOptions ALFCEIKBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CB2760", Offset = "0x5CB1160", VA = "0x185CB2760", Slot = "28")]
	public override void Write(Utf8JsonWriter EAPDKLFLMNB, T[] KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4AE4D30", Offset = "0x4AE3730", VA = "0x184AE4D30")]
	protected PJBJGPFNOCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class BDLAEIDBOPF<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? IDHODBLOABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C90", Offset = "0xAB4690", VA = "0x180AB5C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T GNFEFGCNELH(float[] FDOLNIMJMJM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] ABAGCAMAMIA(T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6687270", Offset = "0x6685C70", VA = "0x186687270", Slot = "27")]
	public override T Read(Utf8JsonReader DIKMKPGIBMB, Type INNODLOAIOD, JsonSerializerOptions ALFCEIKBPNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6687E10", Offset = "0x6686810", VA = "0x186687E10", Slot = "28")]
	public override void Write(Utf8JsonWriter EAPDKLFLMNB, T KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4AE4D30", Offset = "0x4AE3730", VA = "0x184AE4D30")]
	protected BDLAEIDBOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AAKLNEICECG
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8537380", Offset = "0x8535D80", VA = "0x188537380")]
	public static void OCLNKJNHCGA(this Utf8JsonWriter EAPDKLFLMNB, string BIHHMEFECFM, bool KMAFNKGMDCF, bool KJMOBDOKFBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8537060", Offset = "0x8535A60", VA = "0x188537060")]
	public static bool CHJPEDCCKNI(this Utf8JsonReader DIKMKPGIBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8537080", Offset = "0x8535A80", VA = "0x188537080")]
	public static void CPNCDPELBNI(this Utf8JsonWriter EAPDKLFLMNB, string BIHHMEFECFM, int? KMAFNKGMDCF, int KJMOBDOKFBF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85372D0", Offset = "0x8535CD0", VA = "0x1885372D0")]
	public static void ENAJLLLLGKP(this Utf8JsonWriter EAPDKLFLMNB, string BIHHMEFECFM, long? KMAFNKGMDCF, long KJMOBDOKFBF = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32D1750", Offset = "0x32D0150", VA = "0x1832D1750")]
	public static void HDABAPEODCL<T>(this Utf8JsonWriter EAPDKLFLMNB, string BIHHMEFECFM, JsonSerializerOptions ALFCEIKBPNG, T MKDEBCJNKCE, T PNCJLBECKOB) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8537130", Offset = "0x8535B30", VA = "0x188537130")]
	public static void EMAMOPPADCN(this Utf8JsonWriter EAPDKLFLMNB, float KMAFNKGMDCF, int MAOJENFAMEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KKBJCOMPDIJ<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5674890", Offset = "0x5673290", VA = "0x185674890", Slot = "27")]
	public override T Read(Utf8JsonReader DIKMKPGIBMB, Type INNODLOAIOD, JsonSerializerOptions ALFCEIKBPNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5674930", Offset = "0x5673330", VA = "0x185674930", Slot = "28")]
	public override void Write(Utf8JsonWriter EAPDKLFLMNB, T KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4B948A0", Offset = "0x4B932A0", VA = "0x184B948A0")]
	public KKBJCOMPDIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DOHCEKINEFG : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PCGODFOLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85373B0", Offset = "0x8535DB0", VA = "0x1885373B0", Slot = "27")]
	public override float Read(Utf8JsonReader DIKMKPGIBMB, Type INNODLOAIOD, JsonSerializerOptions ALFCEIKBPNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85373C0", Offset = "0x8535DC0", VA = "0x1885373C0", Slot = "28")]
	public override void Write(Utf8JsonWriter EAPDKLFLMNB, float KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8537560", Offset = "0x8535F60", VA = "0x188537560")]
	public DOHCEKINEFG()
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

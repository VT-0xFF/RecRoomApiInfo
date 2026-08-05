using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class LIEJLPJOBJK<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void ECLIMODOOND(Utf8JsonReader JGFHGJBECJA);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5194F20", Offset = "0x5193D20", VA = "0x185194F20", Slot = "27")]
	public override T Read(Utf8JsonReader JFLBMHOJFED, Type MDJMHAPEKLA, JsonSerializerOptions FMKKHOLMGDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5195110", Offset = "0x5193F10", VA = "0x185195110", Slot = "28")]
	public override void Write(Utf8JsonWriter KMFJBCLMGLE, T OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void GLAFLIPMFDF(Utf8JsonReader JFLBMHOJFED, JsonSerializerOptions FMKKHOLMGDF, string JDKAHLJOMHL, T HHHFHHLBBIL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void FHKLCNGMMBJ(Utf8JsonWriter KMFJBCLMGLE, T OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4593E80", Offset = "0x4592C80", VA = "0x184593E80")]
	protected LIEJLPJOBJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PEABKDABHBJ : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF3B0", Offset = "0x7DDE1B0", VA = "0x187DDF3B0")]
	public PEABKDABHBJ(string JDKAHLJOMHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PEIJIPGDDBJ<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5773C70", Offset = "0x5772A70", VA = "0x185773C70", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader JFLBMHOJFED, Type MDJMHAPEKLA, JsonSerializerOptions FMKKHOLMGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5773EB0", Offset = "0x5772CB0", VA = "0x185773EB0", Slot = "28")]
	public override void Write(Utf8JsonWriter KMFJBCLMGLE, Dictionary<TKey, int> OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E730", Offset = "0x4B0D530", VA = "0x184B0E730")]
	public PEIJIPGDDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class LAHAINGHPEB<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x514FD20", Offset = "0x514EB20", VA = "0x18514FD20", Slot = "27")]
	public override T[] Read(Utf8JsonReader JFLBMHOJFED, Type MDJMHAPEKLA, JsonSerializerOptions FMKKHOLMGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5150020", Offset = "0x514EE20", VA = "0x185150020", Slot = "28")]
	public override void Write(Utf8JsonWriter KMFJBCLMGLE, T[] OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45B3850", Offset = "0x45B2650", VA = "0x1845B3850")]
	protected LAHAINGHPEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GDMMBAIPNKI<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? BNNKPCKEOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAE0", Offset = "0xA0D8E0", VA = "0x180A0EAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T FGCIBHABPPJ(float[] BGBLHEHBHCD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] ABDKJFIDJKI(T OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B85A80", Offset = "0x4B84880", VA = "0x184B85A80", Slot = "27")]
	public override T Read(Utf8JsonReader JFLBMHOJFED, Type MDJMHAPEKLA, JsonSerializerOptions FMKKHOLMGDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B864B0", Offset = "0x4B852B0", VA = "0x184B864B0", Slot = "28")]
	public override void Write(Utf8JsonWriter KMFJBCLMGLE, T OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x45B3850", Offset = "0x45B2650", VA = "0x1845B3850")]
	protected GDMMBAIPNKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FAHOJBLHIBC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF110", Offset = "0x7DDDF10", VA = "0x187DDF110")]
	public static void GOLIMKDIOHN(this Utf8JsonWriter KMFJBCLMGLE, string JDKAHLJOMHL, bool OAIIHELJHLG, bool LDGCNLHOBMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF1F0", Offset = "0x7DDDFF0", VA = "0x187DDF1F0")]
	public static bool NGNMLBOIHID(this Utf8JsonReader JFLBMHOJFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF060", Offset = "0x7DDDE60", VA = "0x187DDF060")]
	public static void EKDCPCPHOIP(this Utf8JsonWriter KMFJBCLMGLE, string JDKAHLJOMHL, int? OAIIHELJHLG, int LDGCNLHOBMI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF140", Offset = "0x7DDDF40", VA = "0x187DDF140")]
	public static void LANMCDJMNEE(this Utf8JsonWriter KMFJBCLMGLE, string JDKAHLJOMHL, long? OAIIHELJHLG, long LDGCNLHOBMI = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38DC840", Offset = "0x38DB640", VA = "0x1838DC840")]
	public static void LBHJOGGDLGE<T>(this Utf8JsonWriter KMFJBCLMGLE, string JDKAHLJOMHL, JsonSerializerOptions FMKKHOLMGDF, T AFBDJBIOHNP, T LJDGOEOEMHP) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF210", Offset = "0x7DDE010", VA = "0x187DDF210")]
	public static void PJBOFKJICHN(this Utf8JsonWriter KMFJBCLMGLE, float OAIIHELJHLG, int AOPOLLMPFOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GEFFNLCGOJL<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4BBE140", Offset = "0x4BBCF40", VA = "0x184BBE140", Slot = "27")]
	public override T Read(Utf8JsonReader JFLBMHOJFED, Type MDJMHAPEKLA, JsonSerializerOptions FMKKHOLMGDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4BBE1E0", Offset = "0x4BBCFE0", VA = "0x184BBE1E0", Slot = "28")]
	public override void Write(Utf8JsonWriter KMFJBCLMGLE, T OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4666790", Offset = "0x4665590", VA = "0x184666790")]
	public GEFFNLCGOJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EOMDCBOGJCJ : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NBHIGAMPEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA123A0", Offset = "0xA111A0", VA = "0x180A123A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11510", VA = "0x180A12710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEE70", Offset = "0x7DDDC70", VA = "0x187DDEE70", Slot = "27")]
	public override float Read(Utf8JsonReader JFLBMHOJFED, Type MDJMHAPEKLA, JsonSerializerOptions FMKKHOLMGDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEE80", Offset = "0x7DDDC80", VA = "0x187DDEE80", Slot = "28")]
	public override void Write(Utf8JsonWriter KMFJBCLMGLE, float OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF020", Offset = "0x7DDDE20", VA = "0x187DDF020")]
	public EOMDCBOGJCJ()
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

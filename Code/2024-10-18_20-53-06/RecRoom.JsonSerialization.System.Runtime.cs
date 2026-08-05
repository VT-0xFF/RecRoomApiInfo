using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GDLEBDKAKAC<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void BAFFPBNEMFC(Utf8JsonReader BHJLLDMOPFC);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4087CB0", Offset = "0x40870B0", VA = "0x184087CB0", Slot = "27")]
	public override T Read(Utf8JsonReader GDCGEJPDKCM, Type GLKOGOFNAAO, JsonSerializerOptions ALOJIDNACGI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4087EB0", Offset = "0x40872B0", VA = "0x184087EB0", Slot = "28")]
	public override void Write(Utf8JsonWriter HOKCJMCABPI, T EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void FDLIIDBIBGI(Utf8JsonReader GDCGEJPDKCM, JsonSerializerOptions ALOJIDNACGI, string BMAAJNANOMC, T HHDONFMCNBA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void GGBFJNKJJFL(Utf8JsonWriter HOKCJMCABPI, T EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C390", Offset = "0x3B1B790", VA = "0x183B1C390")]
	protected GDLEBDKAKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FJDPBPBLMLB : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E06580", Offset = "0x6E05980", VA = "0x186E06580")]
	public FJDPBPBLMLB(string BMAAJNANOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PJDHDIDFFNE<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B20220", Offset = "0x4B1F620", VA = "0x184B20220", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader GDCGEJPDKCM, Type GLKOGOFNAAO, JsonSerializerOptions ALOJIDNACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B20460", Offset = "0x4B1F860", VA = "0x184B20460", Slot = "28")]
	public override void Write(Utf8JsonWriter HOKCJMCABPI, Dictionary<TKey, int> EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B20690", Offset = "0x4B1FA90", VA = "0x184B20690")]
	public PJDHDIDFFNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OFMMMKFGKCD<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A12A40", Offset = "0x4A11E40", VA = "0x184A12A40", Slot = "27")]
	public override T[] Read(Utf8JsonReader GDCGEJPDKCM, Type GLKOGOFNAAO, JsonSerializerOptions ALOJIDNACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A12D60", Offset = "0x4A12160", VA = "0x184A12D60", Slot = "28")]
	public override void Write(Utf8JsonWriter HOKCJMCABPI, T[] EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B34FA0", Offset = "0x3B343A0", VA = "0x183B34FA0")]
	protected OFMMMKFGKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class DILCFNBHDLH<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? EJLFFNJPHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CF0", Offset = "0x8B20F0", VA = "0x1808B2CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T EJNAHOBOJHC(float[] BFAMJIIMLEB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] KHNNMIAFACK(T EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6FE0", Offset = "0x5CA63E0", VA = "0x185CA6FE0", Slot = "27")]
	public override T Read(Utf8JsonReader GDCGEJPDKCM, Type GLKOGOFNAAO, JsonSerializerOptions ALOJIDNACGI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7690", Offset = "0x5CA6A90", VA = "0x185CA7690", Slot = "28")]
	public override void Write(Utf8JsonWriter HOKCJMCABPI, T EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B34FA0", Offset = "0x3B343A0", VA = "0x183B34FA0")]
	protected DILCFNBHDLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DCKKHFPBEKF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E06550", Offset = "0x6E05950", VA = "0x186E06550")]
	public static void KKGNEGKDCLF(this Utf8JsonWriter HOKCJMCABPI, string BMAAJNANOMC, bool EEPLCHCGAIN, bool BMLEAJPEFAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E06530", Offset = "0x6E05930", VA = "0x186E06530")]
	public static bool DJIGICFOKOI(this Utf8JsonReader GDCGEJPDKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E062E0", Offset = "0x6E056E0", VA = "0x186E062E0")]
	public static void BNHKPPGIDJM(this Utf8JsonWriter HOKCJMCABPI, string BMAAJNANOMC, int? EEPLCHCGAIN, int BMLEAJPEFAD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FB30", Offset = "0x2C9EF30", VA = "0x182C9FB30")]
	public static void OBOLJCNJLJO<T>(this Utf8JsonWriter HOKCJMCABPI, string BMAAJNANOMC, JsonSerializerOptions ALOJIDNACGI, T OAKJBMEGCLP, T DFPDJPIKCJA) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E06390", Offset = "0x6E05790", VA = "0x186E06390")]
	public static void CHBKFMNAMME(this Utf8JsonWriter HOKCJMCABPI, float EEPLCHCGAIN, int CMPGFEAJHAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LJMFMDJKMPO<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x45BA320", Offset = "0x45B9720", VA = "0x1845BA320", Slot = "27")]
	public override T Read(Utf8JsonReader GDCGEJPDKCM, Type GLKOGOFNAAO, JsonSerializerOptions ALOJIDNACGI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x45BA3D0", Offset = "0x45B97D0", VA = "0x1845BA3D0", Slot = "28")]
	public override void Write(Utf8JsonWriter HOKCJMCABPI, T EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C08760", Offset = "0x3C07B60", VA = "0x183C08760")]
	public LJMFMDJKMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CDKDODDGGGN : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LONHBNNOBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD880", Offset = "0x8ACC80", VA = "0x1808AD880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8A0", Offset = "0x8ACCA0", VA = "0x1808AD8A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E060F0", Offset = "0x6E054F0", VA = "0x186E060F0", Slot = "27")]
	public override float Read(Utf8JsonReader GDCGEJPDKCM, Type GLKOGOFNAAO, JsonSerializerOptions ALOJIDNACGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E06100", Offset = "0x6E05500", VA = "0x186E06100", Slot = "28")]
	public override void Write(Utf8JsonWriter HOKCJMCABPI, float EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E062A0", Offset = "0x6E056A0", VA = "0x186E062A0")]
	public CDKDODDGGGN()
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

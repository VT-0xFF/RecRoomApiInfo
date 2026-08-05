using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class JHCFECAIPCG<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void AAHFHOGMKLH(Utf8JsonReader NFFBJCCKPJF);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E7DF30", Offset = "0x4E7C530", VA = "0x184E7DF30", Slot = "27")]
	public override T Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E120", Offset = "0x4E7C720", VA = "0x184E7E120", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, T OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, T HOJKNIMMINF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, T OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x44C73D0", Offset = "0x44C59D0", VA = "0x1844C73D0")]
	protected JHCFECAIPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NOEPCLGHGFG : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F110", Offset = "0x7C6D710", VA = "0x187C6F110")]
	public NOEPCLGHGFG(string DEMJFJNLMJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FPAIIBFIAIN<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49E0980", Offset = "0x49DEF80", VA = "0x1849E0980", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49E0BC0", Offset = "0x49DF1C0", VA = "0x1849E0BC0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, Dictionary<TKey, int> OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x49E0DE0", Offset = "0x49DF3E0", VA = "0x1849E0DE0")]
	public FPAIIBFIAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HBIAAJEKFLM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B004A0", Offset = "0x4AFEAA0", VA = "0x184B004A0", Slot = "27")]
	public override T[] Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B007A0", Offset = "0x4AFEDA0", VA = "0x184B007A0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, T[] OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x44E3CE0", Offset = "0x44E22E0", VA = "0x1844E3CE0")]
	protected HBIAAJEKFLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GCEODINLLMC<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? AJMKBLHIDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9EB520", Offset = "0x9E9B20", VA = "0x1809EB520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T NBGNNKLAJOA(float[] DHLGAIMCINE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] HGAAFLBNLDD(T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4AA25A0", Offset = "0x4AA0BA0", VA = "0x184AA25A0", Slot = "27")]
	public override T Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4AA3350", Offset = "0x4AA1950", VA = "0x184AA3350", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, T OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x44E3CE0", Offset = "0x44E22E0", VA = "0x1844E3CE0")]
	protected GCEODINLLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NJKOHHAKPPD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EDE0", Offset = "0x7C6D3E0", VA = "0x187C6EDE0")]
	public static void AMJHJFKGAKO(this Utf8JsonWriter NFOCFJIIPHM, string DEMJFJNLMJF, bool OHLIHBDBKCE, bool JMMNJNFGHEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EDC0", Offset = "0x7C6D3C0", VA = "0x187C6EDC0")]
	public static bool AHNPLFNLIAN(this Utf8JsonReader HBMFONPEIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F060", Offset = "0x7C6D660", VA = "0x187C6F060")]
	public static void MNDNECCHOJJ(this Utf8JsonWriter NFOCFJIIPHM, string DEMJFJNLMJF, int? OHLIHBDBKCE, int JMMNJNFGHEP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EFB0", Offset = "0x7C6D5B0", VA = "0x187C6EFB0")]
	public static void EOCFBIEPMNN(this Utf8JsonWriter NFOCFJIIPHM, string DEMJFJNLMJF, long? OHLIHBDBKCE, long JMMNJNFGHEP = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x39B05B0", Offset = "0x39AEBB0", VA = "0x1839B05B0")]
	public static void NOHNNALCLBM<T>(this Utf8JsonWriter NFOCFJIIPHM, string DEMJFJNLMJF, JsonSerializerOptions BFEGEHMOFBB, T GCDAJLDGOIF, T OALLDCKDILO) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EE10", Offset = "0x7C6D410", VA = "0x187C6EE10")]
	public static void DEALLPJFMDO(this Utf8JsonWriter NFOCFJIIPHM, float OHLIHBDBKCE, int JMNHAMMIMJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HGCPLADBHNC<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B14B90", Offset = "0x4B13190", VA = "0x184B14B90", Slot = "27")]
	public override T Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B14C30", Offset = "0x4B13230", VA = "0x184B14C30", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, T OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x457F8A0", Offset = "0x457DEA0", VA = "0x18457F8A0")]
	public HGCPLADBHNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AIOIHFNAHLB : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HPAIGCNIKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EEE00", VA = "0x1809F0800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EBD0", Offset = "0x7C6D1D0", VA = "0x187C6EBD0", Slot = "27")]
	public override float Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EBE0", Offset = "0x7C6D1E0", VA = "0x187C6EBE0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, float OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C6ED80", Offset = "0x7C6D380", VA = "0x187C6ED80")]
	public AIOIHFNAHLB()
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

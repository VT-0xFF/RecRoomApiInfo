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
	[Cpp2IlInjected.Address(RVA = "0x4E35690", Offset = "0x4E34690", VA = "0x184E35690", Slot = "27")]
	public override T Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E35890", Offset = "0x4E34890", VA = "0x184E35890", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x4488390", Offset = "0x4487390", VA = "0x184488390")]
	protected JHCFECAIPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NOEPCLGHGFG : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3A40", Offset = "0x7CA2A40", VA = "0x187CA3A40")]
	public NOEPCLGHGFG(string DEMJFJNLMJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FPAIIBFIAIN<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49A1D90", Offset = "0x49A0D90", VA = "0x1849A1D90", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49A1FD0", Offset = "0x49A0FD0", VA = "0x1849A1FD0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, Dictionary<TKey, int> OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x49A21F0", Offset = "0x49A11F0", VA = "0x1849A21F0")]
	public FPAIIBFIAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HBIAAJEKFLM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AC61E0", Offset = "0x4AC51E0", VA = "0x184AC61E0", Slot = "27")]
	public override T[] Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AC64F0", Offset = "0x4AC54F0", VA = "0x184AC64F0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, T[] OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x44A58F0", Offset = "0x44A48F0", VA = "0x1844A58F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F1520", Offset = "0x9F0520", VA = "0x1809F1520")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A4AEF0", Offset = "0x4A49EF0", VA = "0x184A4AEF0", Slot = "27")]
	public override T Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4A4BCC0", Offset = "0x4A4ACC0", VA = "0x184A4BCC0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, T OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x44A58F0", Offset = "0x44A48F0", VA = "0x1844A58F0")]
	protected GCEODINLLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NJKOHHAKPPD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3710", Offset = "0x7CA2710", VA = "0x187CA3710")]
	public static void AMJHJFKGAKO(this Utf8JsonWriter NFOCFJIIPHM, string DEMJFJNLMJF, bool OHLIHBDBKCE, bool JMMNJNFGHEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CA36F0", Offset = "0x7CA26F0", VA = "0x187CA36F0")]
	public static bool AHNPLFNLIAN(this Utf8JsonReader HBMFONPEIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3990", Offset = "0x7CA2990", VA = "0x187CA3990")]
	public static void MNDNECCHOJJ(this Utf8JsonWriter NFOCFJIIPHM, string DEMJFJNLMJF, int? OHLIHBDBKCE, int JMMNJNFGHEP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA38E0", Offset = "0x7CA28E0", VA = "0x187CA38E0")]
	public static void EOCFBIEPMNN(this Utf8JsonWriter NFOCFJIIPHM, string DEMJFJNLMJF, long? OHLIHBDBKCE, long JMMNJNFGHEP = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3994010", Offset = "0x3993010", VA = "0x183994010")]
	public static void NOHNNALCLBM<T>(this Utf8JsonWriter NFOCFJIIPHM, string DEMJFJNLMJF, JsonSerializerOptions BFEGEHMOFBB, T GCDAJLDGOIF, T OALLDCKDILO) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3740", Offset = "0x7CA2740", VA = "0x187CA3740")]
	public static void DEALLPJFMDO(this Utf8JsonWriter NFOCFJIIPHM, float OHLIHBDBKCE, int JMNHAMMIMJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HGCPLADBHNC<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC3D0", Offset = "0x4ADB3D0", VA = "0x184ADC3D0", Slot = "27")]
	public override T Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC480", Offset = "0x4ADB480", VA = "0x184ADC480", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, T OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4545210", Offset = "0x4544210", VA = "0x184545210")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F6440", Offset = "0x9F5440", VA = "0x1809F6440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3500", Offset = "0x7CA2500", VA = "0x187CA3500", Slot = "27")]
	public override float Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3510", Offset = "0x7CA2510", VA = "0x187CA3510", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, float OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CA36B0", Offset = "0x7CA26B0", VA = "0x187CA36B0")]
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

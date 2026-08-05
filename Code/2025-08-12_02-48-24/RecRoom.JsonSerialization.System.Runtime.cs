using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class NFCONJKAELH<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void IHDGHDNDECI(Utf8JsonReader FIECNFDCBKN);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x59D70B0", Offset = "0x59D56B0", VA = "0x1859D70B0", Slot = "27")]
	public override T Read(Utf8JsonReader EMPLJNKCONI, Type FEAPJKAJCPI, JsonSerializerOptions EEPOAHLOJPI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x59D72A0", Offset = "0x59D58A0", VA = "0x1859D72A0", Slot = "28")]
	public override void Write(Utf8JsonWriter ENKMBIEHHDM, T FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, T KGKOGFAMIIC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, T FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4A136C0", Offset = "0x4A11CC0", VA = "0x184A136C0")]
	protected NFCONJKAELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CMIJANMMKPI : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84A4170", Offset = "0x84A2770", VA = "0x1884A4170")]
	public CMIJANMMKPI(string NBPDNNFOMKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FFNJAJKODAI<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F3B040", Offset = "0x4F39640", VA = "0x184F3B040", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader EMPLJNKCONI, Type FEAPJKAJCPI, JsonSerializerOptions EEPOAHLOJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F3B240", Offset = "0x4F39840", VA = "0x184F3B240", Slot = "28")]
	public override void Write(Utf8JsonWriter ENKMBIEHHDM, Dictionary<TKey, int> FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4F3B470", Offset = "0x4F39A70", VA = "0x184F3B470")]
	public FFNJAJKODAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OHFBNPALMGD<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5B69510", Offset = "0x5B67B10", VA = "0x185B69510", Slot = "27")]
	public override T[] Read(Utf8JsonReader EMPLJNKCONI, Type FEAPJKAJCPI, JsonSerializerOptions EEPOAHLOJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5B697F0", Offset = "0x5B67DF0", VA = "0x185B697F0", Slot = "28")]
	public override void Write(Utf8JsonWriter ENKMBIEHHDM, T[] FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A32A40", Offset = "0x4A31040", VA = "0x184A32A40")]
	protected OHFBNPALMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class OABKFOFEKEL<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? MKIKOMHGHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA95020", Offset = "0xA93620", VA = "0x180A95020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MKMLKCAKKLA(float[] DMJEPOICLBJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] POAGEPOACJA(T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B256B0", Offset = "0x5B23CB0", VA = "0x185B256B0", Slot = "27")]
	public override T Read(Utf8JsonReader EMPLJNKCONI, Type FEAPJKAJCPI, JsonSerializerOptions EEPOAHLOJPI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B26250", Offset = "0x5B24850", VA = "0x185B26250", Slot = "28")]
	public override void Write(Utf8JsonWriter ENKMBIEHHDM, T FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A32A40", Offset = "0x4A31040", VA = "0x184A32A40")]
	protected OABKFOFEKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EEFOPBAFGNN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84A41E0", Offset = "0x84A27E0", VA = "0x1884A41E0")]
	public static void BMFIBCHNDPF(this Utf8JsonWriter ENKMBIEHHDM, string NBPDNNFOMKB, bool FKMNCAKIOFK, bool DAKPJNHJLJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84A42C0", Offset = "0x84A28C0", VA = "0x1884A42C0")]
	public static bool JHKMFDHHPHC(this Utf8JsonReader EMPLJNKCONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84A4210", Offset = "0x84A2810", VA = "0x1884A4210")]
	public static void FDBEFJGHGCK(this Utf8JsonWriter ENKMBIEHHDM, string NBPDNNFOMKB, int? FKMNCAKIOFK, int DAKPJNHJLJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84A42E0", Offset = "0x84A28E0", VA = "0x1884A42E0")]
	public static void JKEHODNCLKK(this Utf8JsonWriter ENKMBIEHHDM, string NBPDNNFOMKB, long? FKMNCAKIOFK, long DAKPJNHJLJO = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C09D40", Offset = "0x3C08340", VA = "0x183C09D40")]
	public static void FAGLAGIFKJM<T>(this Utf8JsonWriter ENKMBIEHHDM, string NBPDNNFOMKB, JsonSerializerOptions EEPOAHLOJPI, T PGNMBFKGLAH, T LINPOJPHBNG) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84A4390", Offset = "0x84A2990", VA = "0x1884A4390")]
	public static void MAAKBBCKGAA(this Utf8JsonWriter ENKMBIEHHDM, float FKMNCAKIOFK, int HGIOMFLPGFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KIJMAKAPMFM<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x55CA2F0", Offset = "0x55C88F0", VA = "0x1855CA2F0", Slot = "27")]
	public override T Read(Utf8JsonReader EMPLJNKCONI, Type FEAPJKAJCPI, JsonSerializerOptions EEPOAHLOJPI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55CA3A0", Offset = "0x55C89A0", VA = "0x1855CA3A0", Slot = "28")]
	public override void Write(Utf8JsonWriter ENKMBIEHHDM, T FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B013A0", Offset = "0x4AFF9A0", VA = "0x184B013A0")]
	public KIJMAKAPMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GENGIJIDGMG : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OINHMDBBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F10", Offset = "0xAA0510", VA = "0x180AA1F10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAA2490", Offset = "0xAA0A90", VA = "0x180AA2490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84A4530", Offset = "0x84A2B30", VA = "0x1884A4530", Slot = "27")]
	public override float Read(Utf8JsonReader EMPLJNKCONI, Type FEAPJKAJCPI, JsonSerializerOptions EEPOAHLOJPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84A4540", Offset = "0x84A2B40", VA = "0x1884A4540", Slot = "28")]
	public override void Write(Utf8JsonWriter ENKMBIEHHDM, float FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84A46E0", Offset = "0x84A2CE0", VA = "0x1884A46E0")]
	public GENGIJIDGMG()
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

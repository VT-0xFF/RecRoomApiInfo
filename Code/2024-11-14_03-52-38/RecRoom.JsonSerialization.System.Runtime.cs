using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class NKEIAHECAGE<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void LKEAPCEGNMF(Utf8JsonReader AKMABNIDADH);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x49552C0", Offset = "0x49546C0", VA = "0x1849552C0", Slot = "27")]
	public override T Read(Utf8JsonReader ILEMOHLPHEC, Type ALOADOBKPCM, JsonSerializerOptions POLCFNEEHMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49554B0", Offset = "0x49548B0", VA = "0x1849554B0", Slot = "28")]
	public override void Write(Utf8JsonWriter FJOPPBPMLFL, T PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void HAEAGGLGFOL(Utf8JsonReader ILEMOHLPHEC, JsonSerializerOptions POLCFNEEHMO, string CIOJHADPGDL, T DHLKAMHBBEP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void FOELCBDALIG(Utf8JsonWriter FJOPPBPMLFL, T PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B3A080", Offset = "0x3B39480", VA = "0x183B3A080")]
	protected NKEIAHECAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HLBIJLNODPK : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D80C30", Offset = "0x6D80030", VA = "0x186D80C30")]
	public HLBIJLNODPK(string CIOJHADPGDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NMAIKLPIIHC<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x495E860", Offset = "0x495DC60", VA = "0x18495E860", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader ILEMOHLPHEC, Type ALOADOBKPCM, JsonSerializerOptions POLCFNEEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x495EAA0", Offset = "0x495DEA0", VA = "0x18495EAA0", Slot = "28")]
	public override void Write(Utf8JsonWriter FJOPPBPMLFL, Dictionary<TKey, int> PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x495ECC0", Offset = "0x495E0C0", VA = "0x18495ECC0")]
	public NMAIKLPIIHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JIPOPCFHFGN<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x442E200", Offset = "0x442D600", VA = "0x18442E200", Slot = "27")]
	public override T[] Read(Utf8JsonReader ILEMOHLPHEC, Type ALOADOBKPCM, JsonSerializerOptions POLCFNEEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x442E500", Offset = "0x442D900", VA = "0x18442E500", Slot = "28")]
	public override void Write(Utf8JsonWriter FJOPPBPMLFL, T[] PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B52130", Offset = "0x3B51530", VA = "0x183B52130")]
	protected JIPOPCFHFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class HMAPNJNJCLH<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? GIDCMDIJHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F90", Offset = "0x8A1390", VA = "0x1808A1F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MKGHLAJCNAG(float[] MHFHLBKJCIO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] PHBKKJCGHEL(T PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x415FD40", Offset = "0x415F140", VA = "0x18415FD40", Slot = "27")]
	public override T Read(Utf8JsonReader ILEMOHLPHEC, Type ALOADOBKPCM, JsonSerializerOptions POLCFNEEHMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4160260", Offset = "0x415F660", VA = "0x184160260", Slot = "28")]
	public override void Write(Utf8JsonWriter FJOPPBPMLFL, T PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B52130", Offset = "0x3B51530", VA = "0x183B52130")]
	protected HMAPNJNJCLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HJGGEJNGFGM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D80990", Offset = "0x6D7FD90", VA = "0x186D80990")]
	public static void HBCCIJBGJHA(this Utf8JsonWriter FJOPPBPMLFL, string CIOJHADPGDL, bool PFKKDHPJFEH, bool POOOEFHFGKB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D80C10", Offset = "0x6D80010", VA = "0x186D80C10")]
	public static bool PBAKECGMMBH(this Utf8JsonReader ILEMOHLPHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D80B60", Offset = "0x6D7FF60", VA = "0x186D80B60")]
	public static void JLCAFHIKAOE(this Utf8JsonWriter FJOPPBPMLFL, string CIOJHADPGDL, int? PFKKDHPJFEH, int POOOEFHFGKB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBE70", Offset = "0x2ECB270", VA = "0x182ECBE70")]
	public static void COBOJGBDIEP<T>(this Utf8JsonWriter FJOPPBPMLFL, string CIOJHADPGDL, JsonSerializerOptions POLCFNEEHMO, T KCIHDEINMKL, T ANMBOIKIGAK) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D809C0", Offset = "0x6D7FDC0", VA = "0x186D809C0")]
	public static void IMIKBICOBIP(this Utf8JsonWriter FJOPPBPMLFL, float PFKKDHPJFEH, int NENKFBBNFEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OABGGDPGGEN<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A41610", Offset = "0x4A40A10", VA = "0x184A41610", Slot = "27")]
	public override T Read(Utf8JsonReader ILEMOHLPHEC, Type ALOADOBKPCM, JsonSerializerOptions POLCFNEEHMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A416B0", Offset = "0x4A40AB0", VA = "0x184A416B0", Slot = "28")]
	public override void Write(Utf8JsonWriter FJOPPBPMLFL, T PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFD2C0", Offset = "0x3BFC6C0", VA = "0x183BFD2C0")]
	public OABGGDPGGEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EFCOOPDFDHH : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int IIOCGFDPODN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A1360", Offset = "0x8A0760", VA = "0x1808A1360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F70", Offset = "0x8A0370", VA = "0x1808A0F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D807A0", Offset = "0x6D7FBA0", VA = "0x186D807A0", Slot = "27")]
	public override float Read(Utf8JsonReader ILEMOHLPHEC, Type ALOADOBKPCM, JsonSerializerOptions POLCFNEEHMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D807B0", Offset = "0x6D7FBB0", VA = "0x186D807B0", Slot = "28")]
	public override void Write(Utf8JsonWriter FJOPPBPMLFL, float PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D80950", Offset = "0x6D7FD50", VA = "0x186D80950")]
	public EFCOOPDFDHH()
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

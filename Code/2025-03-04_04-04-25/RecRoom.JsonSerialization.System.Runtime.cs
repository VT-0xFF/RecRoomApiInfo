using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class MCKNLIHMKLH<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void MEJGFGGBKIB(Utf8JsonReader FBIKENCMLKN);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2DA0", Offset = "0x4DC13A0", VA = "0x184DC2DA0", Slot = "27")]
	public override T Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2F90", Offset = "0x4DC1590", VA = "0x184DC2F90", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, T KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, T MBDDOPABDGG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, T KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x401CFB0", Offset = "0x401B5B0", VA = "0x18401CFB0")]
	protected MCKNLIHMKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DKBEFAKOBPI : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x753CC80", Offset = "0x753B280", VA = "0x18753CC80")]
	public DKBEFAKOBPI(string BPEJALFMHHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KLJCIACBBCP<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4AC22E0", Offset = "0x4AC08E0", VA = "0x184AC22E0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2520", Offset = "0x4AC0B20", VA = "0x184AC2520", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, Dictionary<TKey, int> KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x445F840", Offset = "0x445DE40", VA = "0x18445F840")]
	public KLJCIACBBCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class MPEPLCFNKMJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B240", Offset = "0x4E39840", VA = "0x184E3B240", Slot = "27")]
	public override T[] Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B550", Offset = "0x4E39B50", VA = "0x184E3B550", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, T[] KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4039670", Offset = "0x4037C70", VA = "0x184039670")]
	protected MPEPLCFNKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class MLFHGJIKKIA<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? EKCGNLJECKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x956C80", Offset = "0x955280", VA = "0x180956C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T JMNOLPHHGGE(float[] BMKDAHEBDHE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] OMBEABDDNID(T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E10050", Offset = "0x4E0E650", VA = "0x184E10050", Slot = "27")]
	public override T Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E103D0", Offset = "0x4E0E9D0", VA = "0x184E103D0", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, T KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4039670", Offset = "0x4037C70", VA = "0x184039670")]
	protected MLFHGJIKKIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KAAOHLGKJGD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x753CEB0", Offset = "0x753B4B0", VA = "0x18753CEB0")]
	public static void ELKJHNFGHMC(this Utf8JsonWriter BMEAHINCLAG, string BPEJALFMHHI, bool KBGCCIOIGBD, bool IDJBNLNBJCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x753CCF0", Offset = "0x753B2F0", VA = "0x18753CCF0")]
	public static bool AEAGOAMOEHI(this Utf8JsonReader AJLILPPHPPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x753CF90", Offset = "0x753B590", VA = "0x18753CF90")]
	public static void HCGLGNMCLDG(this Utf8JsonWriter BMEAHINCLAG, string BPEJALFMHHI, int? KBGCCIOIGBD, int IDJBNLNBJCD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x753CEE0", Offset = "0x753B4E0", VA = "0x18753CEE0")]
	public static void FLFNDDONEDN(this Utf8JsonWriter BMEAHINCLAG, string BPEJALFMHHI, long? KBGCCIOIGBD, long IDJBNLNBJCD = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x34941A0", Offset = "0x34927A0", VA = "0x1834941A0")]
	public static void GBAOHAKPNJP<T>(this Utf8JsonWriter BMEAHINCLAG, string BPEJALFMHHI, JsonSerializerOptions DCEHMKPFEJH, T DGOEGFOLJJL, T PLLGKDEGIEI) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x753CD10", Offset = "0x753B310", VA = "0x18753CD10")]
	public static void CMCFABIMLFC(this Utf8JsonWriter BMEAHINCLAG, float KBGCCIOIGBD, int GKCHACFDAOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CLJFMOCFBOB<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C421B0", Offset = "0x5C407B0", VA = "0x185C421B0", Slot = "27")]
	public override T Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C42250", Offset = "0x5C40850", VA = "0x185C42250", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, T KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x40C71E0", Offset = "0x40C57E0", VA = "0x1840C71E0")]
	public CLJFMOCFBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NAPGFJHHACP : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GHKGHFNCCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x952DE0", Offset = "0x9513E0", VA = "0x180952DE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9529F0", Offset = "0x950FF0", VA = "0x1809529F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x753D040", Offset = "0x753B640", VA = "0x18753D040", Slot = "27")]
	public override float Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x753D050", Offset = "0x753B650", VA = "0x18753D050", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, float KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x753D1F0", Offset = "0x753B7F0", VA = "0x18753D1F0")]
	public NAPGFJHHACP()
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

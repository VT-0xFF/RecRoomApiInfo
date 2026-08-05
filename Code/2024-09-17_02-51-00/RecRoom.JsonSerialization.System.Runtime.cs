using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class HIGAGHHDLLN<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void BPAAKCKANDO(Utf8JsonReader CGJIPKMEOFC);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F41490", Offset = "0x3F3FE90", VA = "0x183F41490", Slot = "27")]
	public override T Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3F41690", Offset = "0x3F40090", VA = "0x183F41690", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, T KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, T IFNDNLEGMFO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, T KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39EA3B0", Offset = "0x39E8DB0", VA = "0x1839EA3B0")]
	protected HIGAGHHDLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AFNIOECBNBH : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A290", Offset = "0x6C78C90", VA = "0x186C7A290")]
	public AFNIOECBNBH(string NJIGKJGJPBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BPCHBLBEEAG<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5196610", Offset = "0x5195010", VA = "0x185196610", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5196850", Offset = "0x5195250", VA = "0x185196850", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, Dictionary<TKey, int> KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5196A70", Offset = "0x5195470", VA = "0x185196A70")]
	public BPCHBLBEEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HJJMIBBJHEM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F44540", Offset = "0x3F42F40", VA = "0x183F44540", Slot = "27")]
	public override T[] Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F44850", Offset = "0x3F43250", VA = "0x183F44850", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, T[] KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A03580", Offset = "0x3A01F80", VA = "0x183A03580")]
	protected HJJMIBBJHEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GGNCCNOHGHL<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? ILGLNLNKFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x899AD0", Offset = "0x8984D0", VA = "0x180899AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T AHOFIDLNAIF(float[] ICLOFOKMOJF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] DAJAPAGKKGO(T KLABJGGMBGH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3ED6E10", Offset = "0x3ED5810", VA = "0x183ED6E10", Slot = "27")]
	public override T Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3ED7660", Offset = "0x3ED6060", VA = "0x183ED7660", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, T KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A03580", Offset = "0x3A01F80", VA = "0x183A03580")]
	protected GGNCCNOHGHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AHFEMGCJCMO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A3B0", Offset = "0x6C78DB0", VA = "0x186C7A3B0")]
	public static void EFBLMLFNEPO(this Utf8JsonWriter NFLODIHODLH, string NJIGKJGJPBF, bool KLABJGGMBGH, bool MCAGMGIJFIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A3E0", Offset = "0x6C78DE0", VA = "0x186C7A3E0")]
	public static bool GJAFIFNBFPI(this Utf8JsonReader JEAKAGANOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A300", Offset = "0x6C78D00", VA = "0x186C7A300")]
	public static void ECKFDJKEGKO(this Utf8JsonWriter NFLODIHODLH, string NJIGKJGJPBF, int? KLABJGGMBGH, int MCAGMGIJFIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x343E2A0", Offset = "0x343CCA0", VA = "0x18343E2A0")]
	public static void FNKDFGBADMP<T>(this Utf8JsonWriter NFLODIHODLH, string NJIGKJGJPBF, JsonSerializerOptions CLJCAFMAPFP, T AAJFAHDADNL, T EDJAAJOEMFL) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A400", Offset = "0x6C78E00", VA = "0x186C7A400")]
	public static void KOFIAIIOPNL(this Utf8JsonWriter NFLODIHODLH, float KLABJGGMBGH, int GDGJMEAJEOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OHBLNCDIFCM<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x48F6840", Offset = "0x48F5240", VA = "0x1848F6840", Slot = "27")]
	public override T Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x48F68E0", Offset = "0x48F52E0", VA = "0x1848F68E0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, T KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAB880", Offset = "0x3AAA280", VA = "0x183AAB880")]
	public OHBLNCDIFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NEFHMDEAONE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GHFPHPGPOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A64C0", Offset = "0x8A4EC0", VA = "0x1808A64C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F70", Offset = "0x8A4970", VA = "0x1808A5F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A5A0", Offset = "0x6C78FA0", VA = "0x186C7A5A0", Slot = "27")]
	public override float Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A5B0", Offset = "0x6C78FB0", VA = "0x186C7A5B0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, float KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A750", Offset = "0x6C79150", VA = "0x186C7A750")]
	public NEFHMDEAONE()
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

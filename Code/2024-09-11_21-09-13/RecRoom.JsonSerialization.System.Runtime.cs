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
	[Cpp2IlInjected.Address(RVA = "0x3E78760", Offset = "0x3E76D60", VA = "0x183E78760", Slot = "27")]
	public override T Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3E78960", Offset = "0x3E76F60", VA = "0x183E78960", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x3931320", Offset = "0x392F920", VA = "0x183931320")]
	protected HIGAGHHDLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AFNIOECBNBH : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B93000", Offset = "0x6B91600", VA = "0x186B93000")]
	public AFNIOECBNBH(string NJIGKJGJPBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BPCHBLBEEAG<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50B2FA0", Offset = "0x50B15A0", VA = "0x1850B2FA0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50B31E0", Offset = "0x50B17E0", VA = "0x1850B31E0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, Dictionary<TKey, int> KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x50B3400", Offset = "0x50B1A00", VA = "0x1850B3400")]
	public BPCHBLBEEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HJJMIBBJHEM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B810", Offset = "0x3E79E10", VA = "0x183E7B810", Slot = "27")]
	public override T[] Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BB20", Offset = "0x3E7A120", VA = "0x183E7BB20", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, T[] KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3930B90", Offset = "0x392F190", VA = "0x183930B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x887AD0", Offset = "0x8860D0", VA = "0x180887AD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DE8600", Offset = "0x3DE6C00", VA = "0x183DE8600", Slot = "27")]
	public override T Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8E50", Offset = "0x3DE7450", VA = "0x183DE8E50", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, T KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3930B90", Offset = "0x392F190", VA = "0x183930B90")]
	protected GGNCCNOHGHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AHFEMGCJCMO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B93120", Offset = "0x6B91720", VA = "0x186B93120")]
	public static void EFBLMLFNEPO(this Utf8JsonWriter NFLODIHODLH, string NJIGKJGJPBF, bool KLABJGGMBGH, bool MCAGMGIJFIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B93150", Offset = "0x6B91750", VA = "0x186B93150")]
	public static bool GJAFIFNBFPI(this Utf8JsonReader JEAKAGANOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B93070", Offset = "0x6B91670", VA = "0x186B93070")]
	public static void ECKFDJKEGKO(this Utf8JsonWriter NFLODIHODLH, string NJIGKJGJPBF, int? KLABJGGMBGH, int MCAGMGIJFIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3347090", Offset = "0x3345690", VA = "0x183347090")]
	public static void FNKDFGBADMP<T>(this Utf8JsonWriter NFLODIHODLH, string NJIGKJGJPBF, JsonSerializerOptions CLJCAFMAPFP, T AAJFAHDADNL, T EDJAAJOEMFL) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B93170", Offset = "0x6B91770", VA = "0x186B93170")]
	public static void KOFIAIIOPNL(this Utf8JsonWriter NFLODIHODLH, float KLABJGGMBGH, int GDGJMEAJEOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OHBLNCDIFCM<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4823580", Offset = "0x4821B80", VA = "0x184823580", Slot = "27")]
	public override T Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4823620", Offset = "0x4821C20", VA = "0x184823620", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, T KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x39D6BD0", Offset = "0x39D51D0", VA = "0x1839D6BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x892AC0", VA = "0x1808944C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x893F70", Offset = "0x892570", VA = "0x180893F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B93310", Offset = "0x6B91910", VA = "0x186B93310", Slot = "27")]
	public override float Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B93320", Offset = "0x6B91920", VA = "0x186B93320", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, float KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B934C0", Offset = "0x6B91AC0", VA = "0x186B934C0")]
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

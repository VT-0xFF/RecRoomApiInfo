using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class ONEMIHCAHBB<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void NHAELHLEDMH(Utf8JsonReader LNOMDCGJNHN);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x47CE480", Offset = "0x47CD080", VA = "0x1847CE480", Slot = "27")]
	public override T Read(Utf8JsonReader DMECMNHFOBP, Type JDCBADJPEPC, JsonSerializerOptions OGIKBJOPPCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47CE670", Offset = "0x47CD270", VA = "0x1847CE670", Slot = "28")]
	public override void Write(Utf8JsonWriter CDCPEBLNAND, T CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void POGBHJBKHLK(Utf8JsonReader DMECMNHFOBP, JsonSerializerOptions OGIKBJOPPCP, string NMDOFAJBOFG, T ANPIFEPGOLG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void LJCEODACPDA(Utf8JsonWriter CDCPEBLNAND, T CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A32B70", Offset = "0x3A31770", VA = "0x183A32B70")]
	protected ONEMIHCAHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BFALDBDPAMD : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C79A30", Offset = "0x6C78630", VA = "0x186C79A30")]
	public BFALDBDPAMD(string NMDOFAJBOFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class INJCJBCOKBP<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x40370D0", Offset = "0x4035CD0", VA = "0x1840370D0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader DMECMNHFOBP, Type JDCBADJPEPC, JsonSerializerOptions OGIKBJOPPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4037310", Offset = "0x4035F10", VA = "0x184037310", Slot = "28")]
	public override void Write(Utf8JsonWriter CDCPEBLNAND, Dictionary<TKey, int> CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4E340", Offset = "0x3E4CF40", VA = "0x183E4E340")]
	public INJCJBCOKBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class ANOBNMLLACN<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F1EA90", Offset = "0x3F1D690", VA = "0x183F1EA90", Slot = "27")]
	public override T[] Read(Utf8JsonReader DMECMNHFOBP, Type JDCBADJPEPC, JsonSerializerOptions OGIKBJOPPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F1ED90", Offset = "0x3F1D990", VA = "0x183F1ED90", Slot = "28")]
	public override void Write(Utf8JsonWriter CDCPEBLNAND, T[] CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A4BEC0", Offset = "0x3A4AAC0", VA = "0x183A4BEC0")]
	protected ANOBNMLLACN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class BPOCLIJIKEF<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? GLDHIBDJDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88C4E0", Offset = "0x88B0E0", VA = "0x18088C4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T BIACDEHNKOG(float[] ILAABJMNJPL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] GAPKACFFPLK(T CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50D45D0", Offset = "0x50D31D0", VA = "0x1850D45D0", Slot = "27")]
	public override T Read(Utf8JsonReader DMECMNHFOBP, Type JDCBADJPEPC, JsonSerializerOptions OGIKBJOPPCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50D4CF0", Offset = "0x50D38F0", VA = "0x1850D4CF0", Slot = "28")]
	public override void Write(Utf8JsonWriter CDCPEBLNAND, T CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A4BEC0", Offset = "0x3A4AAC0", VA = "0x183A4BEC0")]
	protected BPOCLIJIKEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OLNLAHDGPAI
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C79D40", Offset = "0x6C78940", VA = "0x186C79D40")]
	public static void CFKCAEFEJBC(this Utf8JsonWriter CDCPEBLNAND, string NMDOFAJBOFG, bool CABLCDOIFFL, bool IEDAFAANJNE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C79F10", Offset = "0x6C78B10", VA = "0x186C79F10")]
	public static bool PKHBJIGPPHA(this Utf8JsonReader DMECMNHFOBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C79C90", Offset = "0x6C78890", VA = "0x186C79C90")]
	public static void BMOAOHLCGDO(this Utf8JsonWriter CDCPEBLNAND, string NMDOFAJBOFG, int? CABLCDOIFFL, int IEDAFAANJNE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2FCCB50", Offset = "0x2FCB750", VA = "0x182FCCB50")]
	public static void OOLINGEMELB<T>(this Utf8JsonWriter CDCPEBLNAND, string NMDOFAJBOFG, JsonSerializerOptions OGIKBJOPPCP, T JEODFFDGHHF, T BDKCBCJLLEC) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C79D70", Offset = "0x6C78970", VA = "0x186C79D70")]
	public static void JNBPALMIPHM(this Utf8JsonWriter CDCPEBLNAND, float CABLCDOIFFL, int BFCAIGGCGJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NDCIELLONGP<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x464BE20", Offset = "0x464AA20", VA = "0x18464BE20", Slot = "27")]
	public override T Read(Utf8JsonReader DMECMNHFOBP, Type JDCBADJPEPC, JsonSerializerOptions OGIKBJOPPCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x464BEC0", Offset = "0x464AAC0", VA = "0x18464BEC0", Slot = "28")]
	public override void Write(Utf8JsonWriter CDCPEBLNAND, T CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEE90", Offset = "0x3ADDA90", VA = "0x183ADEE90")]
	public NDCIELLONGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JNFEPEDICIF : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FKKMHIAHNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x893E00", Offset = "0x892A00", VA = "0x180893E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x893E10", Offset = "0x892A10", VA = "0x180893E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C79AA0", Offset = "0x6C786A0", VA = "0x186C79AA0", Slot = "27")]
	public override float Read(Utf8JsonReader DMECMNHFOBP, Type JDCBADJPEPC, JsonSerializerOptions OGIKBJOPPCP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C79AB0", Offset = "0x6C786B0", VA = "0x186C79AB0", Slot = "28")]
	public override void Write(Utf8JsonWriter CDCPEBLNAND, float CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C79C50", Offset = "0x6C78850", VA = "0x186C79C50")]
	public JNFEPEDICIF()
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

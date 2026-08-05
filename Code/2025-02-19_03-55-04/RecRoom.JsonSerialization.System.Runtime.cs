using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class OIBAMKIBCCD<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void GDFMIFCDJEE(Utf8JsonReader JLCBCLJGOML);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D010", Offset = "0x4F7BC10", VA = "0x184F7D010", Slot = "27")]
	public override T Read(Utf8JsonReader KLCLFHDKNAH, Type PINGKJOMFPB, JsonSerializerOptions DAMABILEGII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F7D210", Offset = "0x4F7BE10", VA = "0x184F7D210", Slot = "28")]
	public override void Write(Utf8JsonWriter DGOPMEPLAFF, T MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void MGHLIJGHDCD(Utf8JsonReader KLCLFHDKNAH, JsonSerializerOptions DAMABILEGII, string MFGAOHOJBEJ, T HLGDOFMLIOK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void NNCKNFNCJNA(Utf8JsonWriter DGOPMEPLAFF, T MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3F81210", Offset = "0x3F7FE10", VA = "0x183F81210")]
	protected OIBAMKIBCCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MAFLGKGGFMF : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74E35F0", Offset = "0x74E21F0", VA = "0x1874E35F0")]
	public MAFLGKGGFMF(string MFGAOHOJBEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AHAKCKNOGLC<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4666720", Offset = "0x4665320", VA = "0x184666720", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader KLCLFHDKNAH, Type PINGKJOMFPB, JsonSerializerOptions DAMABILEGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4666960", Offset = "0x4665560", VA = "0x184666960", Slot = "28")]
	public override void Write(Utf8JsonWriter DGOPMEPLAFF, Dictionary<TKey, int> MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4449950", Offset = "0x4448550", VA = "0x184449950")]
	public AHAKCKNOGLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class EONOLCFOFFJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x400A480", Offset = "0x4009080", VA = "0x18400A480", Slot = "27")]
	public override T[] Read(Utf8JsonReader KLCLFHDKNAH, Type PINGKJOMFPB, JsonSerializerOptions DAMABILEGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x400A7A0", Offset = "0x40093A0", VA = "0x18400A7A0", Slot = "28")]
	public override void Write(Utf8JsonWriter DGOPMEPLAFF, T[] MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E660", Offset = "0x3F9D260", VA = "0x183F9E660")]
	protected EONOLCFOFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class ICDHHLOFGEF<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? BADALIJPGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x95D130", Offset = "0x95BD30", VA = "0x18095D130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MOHDGEOMNJO(float[] FKBJBKHIAAE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] DLCEHOIGCOP(T MPDLOLIOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x46E7240", Offset = "0x46E5E40", VA = "0x1846E7240", Slot = "27")]
	public override T Read(Utf8JsonReader KLCLFHDKNAH, Type PINGKJOMFPB, JsonSerializerOptions DAMABILEGII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46E7E40", Offset = "0x46E6A40", VA = "0x1846E7E40", Slot = "28")]
	public override void Write(Utf8JsonWriter DGOPMEPLAFF, T MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E660", Offset = "0x3F9D260", VA = "0x183F9E660")]
	protected ICDHHLOFGEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CDKGFAAMKPM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x74E33D0", Offset = "0x74E1FD0", VA = "0x1874E33D0")]
	public static void MFEEDMIJDAI(this Utf8JsonWriter DGOPMEPLAFF, string MFGAOHOJBEJ, bool MPDLOLIOGJL, bool NBKBMLNEBHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74E3300", Offset = "0x74E1F00", VA = "0x1874E3300")]
	public static bool HDALCCMGAGF(this Utf8JsonReader KLCLFHDKNAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74E3320", Offset = "0x74E1F20", VA = "0x1874E3320")]
	public static void MCKHMPFHOFI(this Utf8JsonWriter DGOPMEPLAFF, string MFGAOHOJBEJ, int? MPDLOLIOGJL, int NBKBMLNEBHK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3166050", Offset = "0x3164C50", VA = "0x183166050")]
	public static void LGELEMCIHLN<T>(this Utf8JsonWriter DGOPMEPLAFF, string MFGAOHOJBEJ, JsonSerializerOptions DAMABILEGII, T ODFJOPDFEGP, T JNGDNDGIODI) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74E3160", Offset = "0x74E1D60", VA = "0x1874E3160")]
	public static void BMIIJEAHHIK(this Utf8JsonWriter DGOPMEPLAFF, float MPDLOLIOGJL, int AKOIFBHEHHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HMDAPEKOIMB<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x46351F0", Offset = "0x4633DF0", VA = "0x1846351F0", Slot = "27")]
	public override T Read(Utf8JsonReader KLCLFHDKNAH, Type PINGKJOMFPB, JsonSerializerOptions DAMABILEGII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x46352A0", Offset = "0x4633EA0", VA = "0x1846352A0", Slot = "28")]
	public override void Write(Utf8JsonWriter DGOPMEPLAFF, T MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4055210", Offset = "0x4053E10", VA = "0x184055210")]
	public HMDAPEKOIMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LBBBNFBEHBE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int IEMHDCBCIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x966260", Offset = "0x964E60", VA = "0x180966260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x965EF0", Offset = "0x964AF0", VA = "0x180965EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74E3400", Offset = "0x74E2000", VA = "0x1874E3400", Slot = "27")]
	public override float Read(Utf8JsonReader KLCLFHDKNAH, Type PINGKJOMFPB, JsonSerializerOptions DAMABILEGII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74E3410", Offset = "0x74E2010", VA = "0x1874E3410", Slot = "28")]
	public override void Write(Utf8JsonWriter DGOPMEPLAFF, float MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74E35B0", Offset = "0x74E21B0", VA = "0x1874E35B0")]
	public LBBBNFBEHBE()
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

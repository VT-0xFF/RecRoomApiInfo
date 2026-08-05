using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class OMCBEMBLFNM<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void HOOCBABAFOM(Utf8JsonReader IBKPCEPDIIC);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x421B550", Offset = "0x4219F50", VA = "0x18421B550", Slot = "27")]
	public override T Read(Utf8JsonReader INBDAJDBDHK, Type OICKEOMAKFL, JsonSerializerOptions KCIHFJELBPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x421B740", Offset = "0x421A140", VA = "0x18421B740", Slot = "28")]
	public override void Write(Utf8JsonWriter KLKMGHMAEIH, T AEJBOLFACJC, JsonSerializerOptions KCIHFJELBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void BIEHFDNJIFG(Utf8JsonReader INBDAJDBDHK, JsonSerializerOptions KCIHFJELBPK, string AMPADKKCLFC, T ODDGLLCBILG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void KIEIEEPFKOG(Utf8JsonWriter KLKMGHMAEIH, T AEJBOLFACJC, JsonSerializerOptions KCIHFJELBPK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34C3F90", Offset = "0x34C2990", VA = "0x1834C3F90")]
	protected OMCBEMBLFNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LKLOEOOIFCD : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6360660", Offset = "0x635F060", VA = "0x186360660")]
	public LKLOEOOIFCD(string AMPADKKCLFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ODDGPOJCKMN<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x42050B0", Offset = "0x4203AB0", VA = "0x1842050B0", Slot = "27")]
	public override T[] Read(Utf8JsonReader INBDAJDBDHK, Type OICKEOMAKFL, JsonSerializerOptions KCIHFJELBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4205370", Offset = "0x4203D70", VA = "0x184205370", Slot = "28")]
	public override void Write(Utf8JsonWriter KLKMGHMAEIH, T[] AEJBOLFACJC, JsonSerializerOptions KCIHFJELBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x34C38F0", Offset = "0x34C22F0", VA = "0x1834C38F0")]
	protected ODDGPOJCKMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class MKIIJAOPOHM<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? NNENDKLOAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C99E0", Offset = "0x7C83E0", VA = "0x1807C99E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T POPEMBLLNDF(float[] KCNHIGOABNO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] FPDHCIJDOCM(T AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4047C90", Offset = "0x4046690", VA = "0x184047C90", Slot = "27")]
	public override T Read(Utf8JsonReader INBDAJDBDHK, Type OICKEOMAKFL, JsonSerializerOptions KCIHFJELBPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4048390", Offset = "0x4046D90", VA = "0x184048390", Slot = "28")]
	public override void Write(Utf8JsonWriter KLKMGHMAEIH, T AEJBOLFACJC, JsonSerializerOptions KCIHFJELBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34C38F0", Offset = "0x34C22F0", VA = "0x1834C38F0")]
	protected MKIIJAOPOHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KJPBCDPPMIM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6360470", Offset = "0x635EE70", VA = "0x186360470")]
	public static void DBABBJBGMEM(this Utf8JsonWriter KLKMGHMAEIH, string AMPADKKCLFC, bool AEJBOLFACJC, bool LFANPJOLHJB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6360640", Offset = "0x635F040", VA = "0x186360640")]
	public static bool OCKBGJMHKMB(this Utf8JsonReader INBDAJDBDHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63603C0", Offset = "0x635EDC0", VA = "0x1863603C0")]
	public static void BCCKFCPFMKJ(this Utf8JsonWriter KLKMGHMAEIH, string AMPADKKCLFC, int? AEJBOLFACJC, int LFANPJOLHJB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29CA1E0", Offset = "0x29C8BE0", VA = "0x1829CA1E0")]
	public static void IOIMLAPGGMD<T>(this Utf8JsonWriter KLKMGHMAEIH, string AMPADKKCLFC, JsonSerializerOptions KCIHFJELBPK, T OONFDHNBOBC, T BOEFOOGDLCC) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63604A0", Offset = "0x635EEA0", VA = "0x1863604A0")]
	public static void EDMIIPBJJFJ(this Utf8JsonWriter KLKMGHMAEIH, float AEJBOLFACJC, int NLNABFJPILF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KJKBMOBDIGD<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EE10", Offset = "0x3D6D810", VA = "0x183D6EE10", Slot = "27")]
	public override T Read(Utf8JsonReader INBDAJDBDHK, Type OICKEOMAKFL, JsonSerializerOptions KCIHFJELBPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EEB0", Offset = "0x3D6D8B0", VA = "0x183D6EEB0", Slot = "28")]
	public override void Write(Utf8JsonWriter KLKMGHMAEIH, T AEJBOLFACJC, JsonSerializerOptions KCIHFJELBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x356FF10", Offset = "0x356E910", VA = "0x18356FF10")]
	public KJKBMOBDIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GMCHEINNEDE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PNLELFBDBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5520", Offset = "0x7C3F20", VA = "0x1807C5520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C3EF0", VA = "0x1807C54F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63601D0", Offset = "0x635EBD0", VA = "0x1863601D0", Slot = "27")]
	public override float Read(Utf8JsonReader INBDAJDBDHK, Type OICKEOMAKFL, JsonSerializerOptions KCIHFJELBPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63601E0", Offset = "0x635EBE0", VA = "0x1863601E0", Slot = "28")]
	public override void Write(Utf8JsonWriter KLKMGHMAEIH, float AEJBOLFACJC, JsonSerializerOptions KCIHFJELBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6360380", Offset = "0x635ED80", VA = "0x186360380")]
	public GMCHEINNEDE()
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

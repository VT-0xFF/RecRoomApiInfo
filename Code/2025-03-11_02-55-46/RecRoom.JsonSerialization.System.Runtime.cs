using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class DKCAHGIKGPD<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void KNFEKEIDEFL(Utf8JsonReader NPJNBFDHKLI);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6405B00", Offset = "0x6404F00", VA = "0x186405B00", Slot = "27")]
	public override T Read(Utf8JsonReader AENCLAHFBDP, Type AOKJHOCMECN, JsonSerializerOptions OMCEIGOCOKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6405CF0", Offset = "0x64050F0", VA = "0x186405CF0", Slot = "28")]
	public override void Write(Utf8JsonWriter MGKMPBCECKN, T PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void LAFCDDNLBFK(Utf8JsonReader AENCLAHFBDP, JsonSerializerOptions OMCEIGOCOKM, string KIPNKJLFPED, T BBKCHLGPMMO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void CAKFIPEKMMJ(Utf8JsonWriter MGKMPBCECKN, T PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x40B57B0", Offset = "0x40B4BB0", VA = "0x1840B57B0")]
	protected DKCAHGIKGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CLCFDGIKFMK : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x76232F0", Offset = "0x76226F0", VA = "0x1876232F0")]
	public CLCFDGIKFMK(string KIPNKJLFPED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FBFEBDGOEBH<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x44E37C0", Offset = "0x44E2BC0", VA = "0x1844E37C0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader AENCLAHFBDP, Type AOKJHOCMECN, JsonSerializerOptions OMCEIGOCOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x44E3A00", Offset = "0x44E2E00", VA = "0x1844E3A00", Slot = "28")]
	public override void Write(Utf8JsonWriter MGKMPBCECKN, Dictionary<TKey, int> PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x44E3C20", Offset = "0x44E3020", VA = "0x1844E3C20")]
	public FBFEBDGOEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GKMFOALNJPK<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46782D0", Offset = "0x46776D0", VA = "0x1846782D0", Slot = "27")]
	public override T[] Read(Utf8JsonReader AENCLAHFBDP, Type AOKJHOCMECN, JsonSerializerOptions OMCEIGOCOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46785D0", Offset = "0x46779D0", VA = "0x1846785D0", Slot = "28")]
	public override void Write(Utf8JsonWriter MGKMPBCECKN, T[] PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x40D3C00", Offset = "0x40D3000", VA = "0x1840D3C00")]
	protected GKMFOALNJPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class MJCIJDHCKNN<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? GGBOEHHHCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x96A780", Offset = "0x969B80", VA = "0x18096A780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T CLDHNAJNEDB(float[] JPGIMCGBJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] PGFHNJLOBFL(T PEBNJNGMMHE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E077F0", Offset = "0x4E06BF0", VA = "0x184E077F0", Slot = "27")]
	public override T Read(Utf8JsonReader AENCLAHFBDP, Type AOKJHOCMECN, JsonSerializerOptions OMCEIGOCOKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E07F00", Offset = "0x4E07300", VA = "0x184E07F00", Slot = "28")]
	public override void Write(Utf8JsonWriter MGKMPBCECKN, T PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40D3C00", Offset = "0x40D3000", VA = "0x1840D3C00")]
	protected MJCIJDHCKNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EHEBJBJADIF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7623660", Offset = "0x7622A60", VA = "0x187623660")]
	public static void NCAKNBHJIIE(this Utf8JsonWriter MGKMPBCECKN, string KIPNKJLFPED, bool PEBNJNGMMHE, bool CIKOELCEFFM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7623690", Offset = "0x7622A90", VA = "0x187623690")]
	public static bool PIGOHKCICCB(this Utf8JsonReader AENCLAHFBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x76235B0", Offset = "0x76229B0", VA = "0x1876235B0")]
	public static void LIKJMAAOEDA(this Utf8JsonWriter MGKMPBCECKN, string KIPNKJLFPED, int? PEBNJNGMMHE, int CIKOELCEFFM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7623360", Offset = "0x7622760", VA = "0x187623360")]
	public static void BBMJIIFKICI(this Utf8JsonWriter MGKMPBCECKN, string KIPNKJLFPED, long? PEBNJNGMMHE, long CIKOELCEFFM = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33103B0", Offset = "0x330F7B0", VA = "0x1833103B0")]
	public static void HKMBKPNEAGK<T>(this Utf8JsonWriter MGKMPBCECKN, string KIPNKJLFPED, JsonSerializerOptions OMCEIGOCOKM, T GHFLHNCPIIL, T OPPGOIOMPCE) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7623410", Offset = "0x7622810", VA = "0x187623410")]
	public static void KKJOGPBMIEJ(this Utf8JsonWriter MGKMPBCECKN, float PEBNJNGMMHE, int EIKPIDLIEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CMMNMMOGFFJ<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61633E0", Offset = "0x61627E0", VA = "0x1861633E0", Slot = "27")]
	public override T Read(Utf8JsonReader AENCLAHFBDP, Type AOKJHOCMECN, JsonSerializerOptions OMCEIGOCOKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6163480", Offset = "0x6162880", VA = "0x186163480", Slot = "28")]
	public override void Write(Utf8JsonWriter MGKMPBCECKN, T PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x419A0E0", Offset = "0x41994E0", VA = "0x18419A0E0")]
	public CMMNMMOGFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ELMJKLLOPOH : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FFPGMKGCMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96FB20", Offset = "0x96EF20", VA = "0x18096FB20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9700A0", Offset = "0x96F4A0", VA = "0x1809700A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x76236B0", Offset = "0x7622AB0", VA = "0x1876236B0", Slot = "27")]
	public override float Read(Utf8JsonReader AENCLAHFBDP, Type AOKJHOCMECN, JsonSerializerOptions OMCEIGOCOKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x76236C0", Offset = "0x7622AC0", VA = "0x1876236C0", Slot = "28")]
	public override void Write(Utf8JsonWriter MGKMPBCECKN, float PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7623860", Offset = "0x7622C60", VA = "0x187623860")]
	public ELMJKLLOPOH()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class LMEJNNMKODG<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void JJCDOHJPLCI(Utf8JsonReader IIMGHHPJFMO);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x42E1D00", Offset = "0x42E0300", VA = "0x1842E1D00", Slot = "27")]
	public override T Read(Utf8JsonReader NOHOKOEFICC, Type FIEKCJDILDC, JsonSerializerOptions KMKBHLMADIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x42E1F00", Offset = "0x42E0500", VA = "0x1842E1F00", Slot = "28")]
	public override void Write(Utf8JsonWriter PLACLKJNIBM, T FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void IPBIFDBOCPN(Utf8JsonReader NOHOKOEFICC, JsonSerializerOptions KMKBHLMADIH, string LOPDMJPKEBC, T OKNDMMHNIOK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void FENAJLLICCN(Utf8JsonWriter PLACLKJNIBM, T FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37C3930", Offset = "0x37C1F30", VA = "0x1837C3930")]
	protected LMEJNNMKODG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GHPGFMHFPAB : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69D6780", Offset = "0x69D4D80", VA = "0x1869D6780")]
	public GHPGFMHFPAB(string LOPDMJPKEBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PIJOBHJBHEG<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x481C870", Offset = "0x481AE70", VA = "0x18481C870", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader NOHOKOEFICC, Type FIEKCJDILDC, JsonSerializerOptions KMKBHLMADIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x481CAB0", Offset = "0x481B0B0", VA = "0x18481CAB0", Slot = "28")]
	public override void Write(Utf8JsonWriter PLACLKJNIBM, Dictionary<TKey, int> FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x481CCD0", Offset = "0x481B2D0", VA = "0x18481CCD0")]
	public PIJOBHJBHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class LNHMBIMLCKJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x42E8B60", Offset = "0x42E7160", VA = "0x1842E8B60", Slot = "27")]
	public override T[] Read(Utf8JsonReader NOHOKOEFICC, Type FIEKCJDILDC, JsonSerializerOptions KMKBHLMADIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x42E8E70", Offset = "0x42E7470", VA = "0x1842E8E70", Slot = "28")]
	public override void Write(Utf8JsonWriter PLACLKJNIBM, T[] FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x37C31C0", Offset = "0x37C17C0", VA = "0x1837C31C0")]
	protected LNHMBIMLCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class NANCNCNLECN<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? EOMCIELNACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8656A0", Offset = "0x863CA0", VA = "0x1808656A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MPNPLBKLIFJ(float[] EGCOBBLGNBO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] AAHIFJHBHEG(T FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x456A260", Offset = "0x4568860", VA = "0x18456A260", Slot = "27")]
	public override T Read(Utf8JsonReader NOHOKOEFICC, Type FIEKCJDILDC, JsonSerializerOptions KMKBHLMADIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x456ACB0", Offset = "0x45692B0", VA = "0x18456ACB0", Slot = "28")]
	public override void Write(Utf8JsonWriter PLACLKJNIBM, T FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37C31C0", Offset = "0x37C17C0", VA = "0x1837C31C0")]
	protected NANCNCNLECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NFCNFCJDHJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69D6810", Offset = "0x69D4E10", VA = "0x1869D6810")]
	public static void OJIEPGHBIHA(this Utf8JsonWriter PLACLKJNIBM, string LOPDMJPKEBC, bool FEBGGALLBNN, bool PBAONJMDGEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69D67F0", Offset = "0x69D4DF0", VA = "0x1869D67F0")]
	public static bool DBINDDICOLO(this Utf8JsonReader NOHOKOEFICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69D69E0", Offset = "0x69D4FE0", VA = "0x1869D69E0")]
	public static void POOCOMFHOJD(this Utf8JsonWriter PLACLKJNIBM, string LOPDMJPKEBC, int? FEBGGALLBNN, int PBAONJMDGEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCD30", Offset = "0x2CBB330", VA = "0x182CBCD30")]
	public static void NCHBBACBPEK<T>(this Utf8JsonWriter PLACLKJNIBM, string LOPDMJPKEBC, JsonSerializerOptions KMKBHLMADIH, T GAELHANIPAM, T BFGENNACDPD) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69D6840", Offset = "0x69D4E40", VA = "0x1869D6840")]
	public static void OLDHPEMMHCP(this Utf8JsonWriter PLACLKJNIBM, float FEBGGALLBNN, int ACGHILPINKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HBGAFLKEMAG<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D2DA90", Offset = "0x3D2C090", VA = "0x183D2DA90", Slot = "27")]
	public override T Read(Utf8JsonReader NOHOKOEFICC, Type FIEKCJDILDC, JsonSerializerOptions KMKBHLMADIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D2DB30", Offset = "0x3D2C130", VA = "0x183D2DB30", Slot = "28")]
	public override void Write(Utf8JsonWriter PLACLKJNIBM, T FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x385D130", Offset = "0x385B730", VA = "0x18385D130")]
	public HBGAFLKEMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GCBIMIBBOJJ : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NDEKFPMKJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x862F60", Offset = "0x861560", VA = "0x180862F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8632F0", Offset = "0x8618F0", VA = "0x1808632F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69D6590", Offset = "0x69D4B90", VA = "0x1869D6590", Slot = "27")]
	public override float Read(Utf8JsonReader NOHOKOEFICC, Type FIEKCJDILDC, JsonSerializerOptions KMKBHLMADIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69D65A0", Offset = "0x69D4BA0", VA = "0x1869D65A0", Slot = "28")]
	public override void Write(Utf8JsonWriter PLACLKJNIBM, float FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69D6740", Offset = "0x69D4D40", VA = "0x1869D6740")]
	public GCBIMIBBOJJ()
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

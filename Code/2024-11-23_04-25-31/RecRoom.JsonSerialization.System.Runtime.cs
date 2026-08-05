using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class JDLKEOMFPEG<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void PPDAHMMNKNB(Utf8JsonReader ECOIDHGKBHK);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4412520", Offset = "0x4410F20", VA = "0x184412520", Slot = "27")]
	public override T Read(Utf8JsonReader NIEHEDECLKP, Type OMHNIBBACOF, JsonSerializerOptions JKPMAFPDDOK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4412720", Offset = "0x4411120", VA = "0x184412720", Slot = "28")]
	public override void Write(Utf8JsonWriter KPBMLLGEOOP, T PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void AEODACKECBB(Utf8JsonReader NIEHEDECLKP, JsonSerializerOptions JKPMAFPDDOK, string NHDAMJEEJKD, T GNDKBENMBLO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void AKNCPIBGBCB(Utf8JsonWriter KPBMLLGEOOP, T PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B39AB0", Offset = "0x3B384B0", VA = "0x183B39AB0")]
	protected JDLKEOMFPEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KLBJOOGJFMF : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E261F0", Offset = "0x6E24BF0", VA = "0x186E261F0")]
	public KLBJOOGJFMF(string NHDAMJEEJKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CJPOENLOAHI<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x560AE50", Offset = "0x5609850", VA = "0x18560AE50", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader NIEHEDECLKP, Type OMHNIBBACOF, JsonSerializerOptions JKPMAFPDDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x560B090", Offset = "0x5609A90", VA = "0x18560B090", Slot = "28")]
	public override void Write(Utf8JsonWriter KPBMLLGEOOP, Dictionary<TKey, int> PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x560B2C0", Offset = "0x5609CC0", VA = "0x18560B2C0")]
	public CJPOENLOAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class MBGFFLLLMGL<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x48740E0", Offset = "0x4872AE0", VA = "0x1848740E0", Slot = "27")]
	public override T[] Read(Utf8JsonReader NIEHEDECLKP, Type OMHNIBBACOF, JsonSerializerOptions JKPMAFPDDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x48743F0", Offset = "0x4872DF0", VA = "0x1848743F0", Slot = "28")]
	public override void Write(Utf8JsonWriter KPBMLLGEOOP, T[] PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B52890", Offset = "0x3B51290", VA = "0x183B52890")]
	protected MBGFFLLLMGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class MEMONMNJFAG<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? FBGKKFPMBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B00D0", Offset = "0x8AEAD0", VA = "0x1808B00D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T HCGMJONKNPD(float[] KJCKFFGBDON);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] KLJILCNGCPK(T PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x48AB360", Offset = "0x48A9D60", VA = "0x1848AB360", Slot = "27")]
	public override T Read(Utf8JsonReader NIEHEDECLKP, Type OMHNIBBACOF, JsonSerializerOptions JKPMAFPDDOK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48ABC20", Offset = "0x48AA620", VA = "0x1848ABC20", Slot = "28")]
	public override void Write(Utf8JsonWriter KPBMLLGEOOP, T PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B52890", Offset = "0x3B51290", VA = "0x183B52890")]
	protected MEMONMNJFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class COHDKNNAMKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E25D60", Offset = "0x6E24760", VA = "0x186E25D60")]
	public static void ELGAHBPHLLF(this Utf8JsonWriter KPBMLLGEOOP, string NHDAMJEEJKD, bool PKCLPFEIPFH, bool PFGHNJEFBFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E25D90", Offset = "0x6E24790", VA = "0x186E25D90")]
	public static bool JLLLAIMPHFP(this Utf8JsonReader NIEHEDECLKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E25DB0", Offset = "0x6E247B0", VA = "0x186E25DB0")]
	public static void LDAPIMKBHDL(this Utf8JsonWriter KPBMLLGEOOP, string NHDAMJEEJKD, int? PKCLPFEIPFH, int PFGHNJEFBFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF13A0", Offset = "0x2CEFDA0", VA = "0x182CF13A0")]
	public static void MOPDKMGKDFN<T>(this Utf8JsonWriter KPBMLLGEOOP, string NHDAMJEEJKD, JsonSerializerOptions JKPMAFPDDOK, T JBKDPHAINMM, T OHIIICDFHLK) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E25E60", Offset = "0x6E24860", VA = "0x186E25E60")]
	public static void LFPGFOKFAFC(this Utf8JsonWriter KPBMLLGEOOP, float PKCLPFEIPFH, int FCFALBJLBBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GJDGOPCAMDP<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x410B480", Offset = "0x4109E80", VA = "0x18410B480", Slot = "27")]
	public override T Read(Utf8JsonReader NIEHEDECLKP, Type OMHNIBBACOF, JsonSerializerOptions JKPMAFPDDOK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x410B520", Offset = "0x4109F20", VA = "0x18410B520", Slot = "28")]
	public override void Write(Utf8JsonWriter KPBMLLGEOOP, T PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3BF17E0", Offset = "0x3BF01E0", VA = "0x183BF17E0")]
	public GJDGOPCAMDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DLAHEEEONPN : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int AOHCMOOCPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8ABF70", VA = "0x1808AD570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8AD760", Offset = "0x8AC160", VA = "0x1808AD760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E26000", Offset = "0x6E24A00", VA = "0x186E26000", Slot = "27")]
	public override float Read(Utf8JsonReader NIEHEDECLKP, Type OMHNIBBACOF, JsonSerializerOptions JKPMAFPDDOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E26010", Offset = "0x6E24A10", VA = "0x186E26010", Slot = "28")]
	public override void Write(Utf8JsonWriter KPBMLLGEOOP, float PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E261B0", Offset = "0x6E24BB0", VA = "0x186E261B0")]
	public DLAHEEEONPN()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class CFPFFAGKCFA<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void NPJMPAMEEDG(Utf8JsonReader GDOMDKGJNLG);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FBC0", Offset = "0x6D6EFC0", VA = "0x186D6FBC0", Slot = "27")]
	public override T Read(Utf8JsonReader BPCOJLPPMNI, Type FONOGBJILNL, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FDB0", Offset = "0x6D6F1B0", VA = "0x186D6FDB0", Slot = "28")]
	public override void Write(Utf8JsonWriter HNNLPFDFOLO, T CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, T GBDPBDHPLOA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, T CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4538520", Offset = "0x4537920", VA = "0x184538520")]
	protected CFPFFAGKCFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MLECELODBLH : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82EE690", Offset = "0x82EDA90", VA = "0x1882EE690")]
	public MLECELODBLH(string MDDEFFMKGMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OONJLFMGNOE<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x59F0B50", Offset = "0x59EFF50", VA = "0x1859F0B50", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader BPCOJLPPMNI, Type FONOGBJILNL, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x59F0D40", Offset = "0x59F0140", VA = "0x1859F0D40", Slot = "28")]
	public override void Write(Utf8JsonWriter HNNLPFDFOLO, Dictionary<TKey, int> CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9FD0", Offset = "0x4ED93D0", VA = "0x184ED9FD0")]
	public OONJLFMGNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NHBDHGGCMAJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x57F9010", Offset = "0x57F8410", VA = "0x1857F9010", Slot = "27")]
	public override T[] Read(Utf8JsonReader BPCOJLPPMNI, Type FONOGBJILNL, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57F92E0", Offset = "0x57F86E0", VA = "0x1857F92E0", Slot = "28")]
	public override void Write(Utf8JsonWriter HNNLPFDFOLO, T[] CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x49A1000", Offset = "0x49A0400", VA = "0x1849A1000")]
	protected NHBDHGGCMAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class KCKIEAHOBFH<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? OGAEFDDNIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA70450", Offset = "0xA6F850", VA = "0x180A70450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T KCAKILMPLEO(float[] EJCCOPPBIIG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] GGJDOCMICNI(T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x54331D0", Offset = "0x54325D0", VA = "0x1854331D0", Slot = "27")]
	public override T Read(Utf8JsonReader BPCOJLPPMNI, Type FONOGBJILNL, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5434470", Offset = "0x5433870", VA = "0x185434470", Slot = "28")]
	public override void Write(Utf8JsonWriter HNNLPFDFOLO, T CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x49A1000", Offset = "0x49A0400", VA = "0x1849A1000")]
	protected KCKIEAHOBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MNBCJIAOKOA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82EE720", Offset = "0x82EDB20", VA = "0x1882EE720")]
	public static void FOLFJDPEBFK(this Utf8JsonWriter HNNLPFDFOLO, string MDDEFFMKGMP, bool CBMEHPPMEEA, bool ABINAMGBLJP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82EE700", Offset = "0x82EDB00", VA = "0x1882EE700")]
	public static bool CJHNAABGMCA(this Utf8JsonReader BPCOJLPPMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82EE9A0", Offset = "0x82EDDA0", VA = "0x1882EE9A0")]
	public static void OMLGIJIEGNL(this Utf8JsonWriter HNNLPFDFOLO, string MDDEFFMKGMP, int? CBMEHPPMEEA, int ABINAMGBLJP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82EE8F0", Offset = "0x82EDCF0", VA = "0x1882EE8F0")]
	public static void LKEGBIKMBCK(this Utf8JsonWriter HNNLPFDFOLO, string MDDEFFMKGMP, long? CBMEHPPMEEA, long ABINAMGBLJP = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7CE0", Offset = "0x3DF70E0", VA = "0x183DF7CE0")]
	public static void FANNOLLJHOH<T>(this Utf8JsonWriter HNNLPFDFOLO, string MDDEFFMKGMP, JsonSerializerOptions LFFPIIDBFOJ, T DIMKOEFIKCH, T PMDAAOANKGH) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82EE750", Offset = "0x82EDB50", VA = "0x1882EE750")]
	public static void IPEJIGDDLCE(this Utf8JsonWriter HNNLPFDFOLO, float CBMEHPPMEEA, int PDKBBBAHLDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KFMEIOFBEKB<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5447DF0", Offset = "0x54471F0", VA = "0x185447DF0", Slot = "27")]
	public override T Read(Utf8JsonReader BPCOJLPPMNI, Type FONOGBJILNL, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5447E90", Offset = "0x5447290", VA = "0x185447E90", Slot = "28")]
	public override void Write(Utf8JsonWriter HNNLPFDFOLO, T CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EBD0", Offset = "0x4A4DFD0", VA = "0x184A4EBD0")]
	public KFMEIOFBEKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FLLEPEKGCPI : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GOECMJLLDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDA0", Offset = "0xA7B1A0", VA = "0x180A7BDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA10", Offset = "0xA7AE10", VA = "0x180A7BA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82EE4A0", Offset = "0x82ED8A0", VA = "0x1882EE4A0", Slot = "27")]
	public override float Read(Utf8JsonReader BPCOJLPPMNI, Type FONOGBJILNL, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82EE4B0", Offset = "0x82ED8B0", VA = "0x1882EE4B0", Slot = "28")]
	public override void Write(Utf8JsonWriter HNNLPFDFOLO, float CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82EE650", Offset = "0x82EDA50", VA = "0x1882EE650")]
	public FLLEPEKGCPI()
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

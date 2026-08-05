using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class BHBKCEKEBDB<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void OKLNAAEMFOP(Utf8JsonReader CLCPGILFJHI);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50ADA00", Offset = "0x50AC400", VA = "0x1850ADA00", Slot = "27")]
	public override T Read(Utf8JsonReader BPJDDKOBEGL, Type LDKIIDHBEKA, JsonSerializerOptions JIEJKJIJPFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x50ADBF0", Offset = "0x50AC5F0", VA = "0x1850ADBF0", Slot = "28")]
	public override void Write(Utf8JsonWriter HJIMDHLCBKF, T IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void DEOHLMKMJOA(Utf8JsonReader BPJDDKOBEGL, JsonSerializerOptions JIEJKJIJPFC, string PCFKMOBOMBL, T LHFGBAJKEKO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void NMHFLKAFACB(Utf8JsonWriter HJIMDHLCBKF, T IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39D2BE0", Offset = "0x39D15E0", VA = "0x1839D2BE0")]
	protected BHBKCEKEBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OPOLHKJEMKF : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF130", Offset = "0x6BBDB30", VA = "0x186BBF130")]
	public OPOLHKJEMKF(string PCFKMOBOMBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FJLAMONIDOK<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE870", Offset = "0x3DFD270", VA = "0x183DFE870", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader BPJDDKOBEGL, Type LDKIIDHBEKA, JsonSerializerOptions JIEJKJIJPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFEAB0", Offset = "0x3DFD4B0", VA = "0x183DFEAB0", Slot = "28")]
	public override void Write(Utf8JsonWriter HJIMDHLCBKF, Dictionary<TKey, int> IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DFECD0", Offset = "0x3DFD6D0", VA = "0x183DFECD0")]
	public FJLAMONIDOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CLDMALMKIAL<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x55CFDF0", Offset = "0x55CE7F0", VA = "0x1855CFDF0", Slot = "27")]
	public override T[] Read(Utf8JsonReader BPJDDKOBEGL, Type LDKIIDHBEKA, JsonSerializerOptions JIEJKJIJPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x55D00F0", Offset = "0x55CEAF0", VA = "0x1855D00F0", Slot = "28")]
	public override void Write(Utf8JsonWriter HJIMDHLCBKF, T[] IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x39EAC50", Offset = "0x39E9650", VA = "0x1839EAC50")]
	protected CLDMALMKIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class JIDHCBOMFAE<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? CDFHGEMPBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88B2C0", Offset = "0x889CC0", VA = "0x18088B2C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T FKPGHHJGCLC(float[] KIAGDMGGGNM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] OPHIMHIMIKB(T IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x42F94A0", Offset = "0x42F7EA0", VA = "0x1842F94A0", Slot = "27")]
	public override T Read(Utf8JsonReader BPJDDKOBEGL, Type LDKIIDHBEKA, JsonSerializerOptions JIEJKJIJPFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x42FA2D0", Offset = "0x42F8CD0", VA = "0x1842FA2D0", Slot = "28")]
	public override void Write(Utf8JsonWriter HJIMDHLCBKF, T IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x39EAC50", Offset = "0x39E9650", VA = "0x1839EAC50")]
	protected JIDHCBOMFAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BAOILJADMII
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BBEEF0", Offset = "0x6BBD8F0", VA = "0x186BBEEF0")]
	public static void NONJBKKODJP(this Utf8JsonWriter HJIMDHLCBKF, string PCFKMOBOMBL, bool IPHMAHBENGI, bool FABNMHPKJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BBEF20", Offset = "0x6BBD920", VA = "0x186BBEF20")]
	public static bool OJNNBGKHGGA(this Utf8JsonReader BPJDDKOBEGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BBEE40", Offset = "0x6BBD840", VA = "0x186BBEE40")]
	public static void EMHIECIDFFB(this Utf8JsonWriter HJIMDHLCBKF, string PCFKMOBOMBL, int? IPHMAHBENGI, int FABNMHPKJIP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA990", Offset = "0x2AC9390", VA = "0x182ACA990")]
	public static void NDEDLHFEBPC<T>(this Utf8JsonWriter HJIMDHLCBKF, string PCFKMOBOMBL, JsonSerializerOptions JIEJKJIJPFC, T POCLHBJGKBH, T IAELDMKMACP) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBECA0", Offset = "0x6BBD6A0", VA = "0x186BBECA0")]
	public static void AEHGMFJIDEO(this Utf8JsonWriter HJIMDHLCBKF, float IPHMAHBENGI, int KNCGAACNEPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BDHNBMIEELD<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50A0CF0", Offset = "0x509F6F0", VA = "0x1850A0CF0", Slot = "27")]
	public override T Read(Utf8JsonReader BPJDDKOBEGL, Type LDKIIDHBEKA, JsonSerializerOptions JIEJKJIJPFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50A0D90", Offset = "0x509F790", VA = "0x1850A0D90", Slot = "28")]
	public override void Write(Utf8JsonWriter HJIMDHLCBKF, T IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3A92B20", Offset = "0x3A91520", VA = "0x183A92B20")]
	public BDHNBMIEELD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BMBHNMACEEE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KIOIAPGBINC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8892E0", Offset = "0x887CE0", VA = "0x1808892E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8890A0", Offset = "0x887AA0", VA = "0x1808890A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BBEF40", Offset = "0x6BBD940", VA = "0x186BBEF40", Slot = "27")]
	public override float Read(Utf8JsonReader BPJDDKOBEGL, Type LDKIIDHBEKA, JsonSerializerOptions JIEJKJIJPFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BBEF50", Offset = "0x6BBD950", VA = "0x186BBEF50", Slot = "28")]
	public override void Write(Utf8JsonWriter HJIMDHLCBKF, float IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF0F0", Offset = "0x6BBDAF0", VA = "0x186BBF0F0")]
	public BMBHNMACEEE()
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

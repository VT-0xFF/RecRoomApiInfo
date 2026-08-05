using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class ILEBALKLPGO<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void HFMHBKJHEFI(Utf8JsonReader MLFMLAODHNL);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x46EB920", Offset = "0x46EA720", VA = "0x1846EB920", Slot = "27")]
	public override T Read(Utf8JsonReader GGBMOFKDHMN, Type CPPCGHOOAKJ, JsonSerializerOptions IDEGCFOPFGC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46EBB10", Offset = "0x46EA910", VA = "0x1846EBB10", Slot = "28")]
	public override void Write(Utf8JsonWriter FEBAHPCKNJP, T IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void EMPDMAIKEOB(Utf8JsonReader GGBMOFKDHMN, JsonSerializerOptions IDEGCFOPFGC, string FINLDKJJAEK, T MJONLBMPPCK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void NHOBLPONFPM(Utf8JsonWriter FEBAHPCKNJP, T IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3F35FE0", Offset = "0x3F34DE0", VA = "0x183F35FE0")]
	protected ILEBALKLPGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BCDOEJECLMN : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72B22B0", Offset = "0x72B10B0", VA = "0x1872B22B0")]
	public BCDOEJECLMN(string FINLDKJJAEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GBHFPBDDMFI<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x44A26D0", Offset = "0x44A14D0", VA = "0x1844A26D0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader GGBMOFKDHMN, Type CPPCGHOOAKJ, JsonSerializerOptions IDEGCFOPFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x44A2910", Offset = "0x44A1710", VA = "0x1844A2910", Slot = "28")]
	public override void Write(Utf8JsonWriter FEBAHPCKNJP, Dictionary<TKey, int> IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x442FBD0", Offset = "0x442E9D0", VA = "0x18442FBD0")]
	public GBHFPBDDMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OJBMIAAMGIC<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E48A40", Offset = "0x4E47840", VA = "0x184E48A40", Slot = "27")]
	public override T[] Read(Utf8JsonReader GGBMOFKDHMN, Type CPPCGHOOAKJ, JsonSerializerOptions IDEGCFOPFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E48D50", Offset = "0x4E47B50", VA = "0x184E48D50", Slot = "28")]
	public override void Write(Utf8JsonWriter FEBAHPCKNJP, T[] IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FF50", Offset = "0x3F4ED50", VA = "0x183F4FF50")]
	protected OJBMIAAMGIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class DCAPDBPOKHG<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? FKKGLHDECCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F44F0", Offset = "0x8F32F0", VA = "0x1808F44F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MKDBDOHFNGI(float[] DCFFMJLJGJB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] OBAGPKOJJNI(T IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60F2CF0", Offset = "0x60F1AF0", VA = "0x1860F2CF0", Slot = "27")]
	public override T Read(Utf8JsonReader GGBMOFKDHMN, Type CPPCGHOOAKJ, JsonSerializerOptions IDEGCFOPFGC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60F3E40", Offset = "0x60F2C40", VA = "0x1860F3E40", Slot = "28")]
	public override void Write(Utf8JsonWriter FEBAHPCKNJP, T IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FF50", Offset = "0x3F4ED50", VA = "0x183F4FF50")]
	protected DCAPDBPOKHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JCKLNHBPAAA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72B25C0", Offset = "0x72B13C0", VA = "0x1872B25C0")]
	public static void DBAMELLPDAB(this Utf8JsonWriter FEBAHPCKNJP, string FINLDKJJAEK, bool IPHILEOFJLB, bool KBHDDKCAINE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72B2790", Offset = "0x72B1590", VA = "0x1872B2790")]
	public static bool OHOMAINPFNA(this Utf8JsonReader GGBMOFKDHMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72B2510", Offset = "0x72B1310", VA = "0x1872B2510")]
	public static void BGBGFJEELKI(this Utf8JsonWriter FEBAHPCKNJP, string FINLDKJJAEK, int? IPHILEOFJLB, int KBHDDKCAINE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x333A100", Offset = "0x3338F00", VA = "0x18333A100")]
	public static void LIMKILKEOML<T>(this Utf8JsonWriter FEBAHPCKNJP, string FINLDKJJAEK, JsonSerializerOptions IDEGCFOPFGC, T OAJCPHOOFGC, T JIPHPJFBLGH) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72B25F0", Offset = "0x72B13F0", VA = "0x1872B25F0")]
	public static void FLOPPKOBBKH(this Utf8JsonWriter FEBAHPCKNJP, float IPHILEOFJLB, int BIKGDGIEAIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JHHFCJEGLAG<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x48BFAB0", Offset = "0x48BE8B0", VA = "0x1848BFAB0", Slot = "27")]
	public override T Read(Utf8JsonReader GGBMOFKDHMN, Type CPPCGHOOAKJ, JsonSerializerOptions IDEGCFOPFGC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x48BFB50", Offset = "0x48BE950", VA = "0x1848BFB50", Slot = "28")]
	public override void Write(Utf8JsonWriter FEBAHPCKNJP, T IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4051ED0", Offset = "0x4050CD0", VA = "0x184051ED0")]
	public JHHFCJEGLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HBCBHCIOPAP : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FGCPEAACGFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AC0", Offset = "0x8F88C0", VA = "0x1808F9AC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8F9750", Offset = "0x8F8550", VA = "0x1808F9750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72B2320", Offset = "0x72B1120", VA = "0x1872B2320", Slot = "27")]
	public override float Read(Utf8JsonReader GGBMOFKDHMN, Type CPPCGHOOAKJ, JsonSerializerOptions IDEGCFOPFGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72B2330", Offset = "0x72B1130", VA = "0x1872B2330", Slot = "28")]
	public override void Write(Utf8JsonWriter FEBAHPCKNJP, float IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72B24D0", Offset = "0x72B12D0", VA = "0x1872B24D0")]
	public HBCBHCIOPAP()
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

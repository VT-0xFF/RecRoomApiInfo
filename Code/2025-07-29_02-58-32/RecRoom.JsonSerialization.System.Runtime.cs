using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class EJPKHNGHKON<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void AMPKEDDGJHP(Utf8JsonReader PENFKHFIGID);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4941E90", Offset = "0x4940890", VA = "0x184941E90", Slot = "27")]
	public override T Read(Utf8JsonReader IOMONBOBJAC, Type AGMDDAMPCMG, JsonSerializerOptions HHMKDMNANOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4942080", Offset = "0x4940A80", VA = "0x184942080", Slot = "28")]
	public override void Write(Utf8JsonWriter ADMHNJGGGLG, T PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, T HNLFGCKBFGI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, T PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x48D5650", Offset = "0x48D4050", VA = "0x1848D5650")]
	protected EJPKHNGHKON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FHFFBIELFGI : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8345DD0", Offset = "0x83447D0", VA = "0x188345DD0")]
	public FHFFBIELFGI(string GGDGFENODPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CHIKEDKLJJB<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F2D0", Offset = "0x6A3DCD0", VA = "0x186A3F2D0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader IOMONBOBJAC, Type AGMDDAMPCMG, JsonSerializerOptions HHMKDMNANOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F4D0", Offset = "0x6A3DED0", VA = "0x186A3F4D0", Slot = "28")]
	public override void Write(Utf8JsonWriter ADMHNJGGGLG, Dictionary<TKey, int> PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E785F0", Offset = "0x4E76FF0", VA = "0x184E785F0")]
	public CHIKEDKLJJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HANBNBGDNHB<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0AB0", Offset = "0x4FEF4B0", VA = "0x184FF0AB0", Slot = "27")]
	public override T[] Read(Utf8JsonReader IOMONBOBJAC, Type AGMDDAMPCMG, JsonSerializerOptions HHMKDMNANOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0D90", Offset = "0x4FEF790", VA = "0x184FF0D90", Slot = "28")]
	public override void Write(Utf8JsonWriter ADMHNJGGGLG, T[] PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48F4990", Offset = "0x48F3390", VA = "0x1848F4990")]
	protected HANBNBGDNHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class DIKNOIDHBIM<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? FCCCHEMLLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA882E0", Offset = "0xA86CE0", VA = "0x180A882E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T NLAPJHIELFO(float[] EJKNLPOFFNN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] DGBABFIBOIC(T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7001DE0", Offset = "0x70007E0", VA = "0x187001DE0", Slot = "27")]
	public override T Read(Utf8JsonReader IOMONBOBJAC, Type AGMDDAMPCMG, JsonSerializerOptions HHMKDMNANOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7002810", Offset = "0x7001210", VA = "0x187002810", Slot = "28")]
	public override void Write(Utf8JsonWriter ADMHNJGGGLG, T PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x48F4990", Offset = "0x48F3390", VA = "0x1848F4990")]
	protected DIKNOIDHBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GIFPKLKPCNM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8345E40", Offset = "0x8344840", VA = "0x188345E40")]
	public static void FOIHEPIINCE(this Utf8JsonWriter ADMHNJGGGLG, string GGDGFENODPM, bool PDKJBMPOMNC, bool KKCMINIPIBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83460C0", Offset = "0x8344AC0", VA = "0x1883460C0")]
	public static bool LCINOOGFBLN(this Utf8JsonReader IOMONBOBJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8345E70", Offset = "0x8344870", VA = "0x188345E70")]
	public static void JDCGJLJOMFE(this Utf8JsonWriter ADMHNJGGGLG, string GGDGFENODPM, int? PDKJBMPOMNC, int KKCMINIPIBD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x83460E0", Offset = "0x8344AE0", VA = "0x1883460E0")]
	public static void PLOJBAEHOPF(this Utf8JsonWriter ADMHNJGGGLG, string GGDGFENODPM, long? PDKJBMPOMNC, long KKCMINIPIBD = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C69380", Offset = "0x3C67D80", VA = "0x183C69380")]
	public static void NMIDBOAAMPH<T>(this Utf8JsonWriter ADMHNJGGGLG, string GGDGFENODPM, JsonSerializerOptions HHMKDMNANOF, T BEAEDIJJJJI, T HNNMFJCLHKJ) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8345F20", Offset = "0x8344920", VA = "0x188345F20")]
	public static void KOIOCHIKNBJ(this Utf8JsonWriter ADMHNJGGGLG, float PDKJBMPOMNC, int JHELGBEPFEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AHMDCBDPGAD<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5241850", Offset = "0x5240250", VA = "0x185241850", Slot = "27")]
	public override T Read(Utf8JsonReader IOMONBOBJAC, Type AGMDDAMPCMG, JsonSerializerOptions HHMKDMNANOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x52418F0", Offset = "0x52402F0", VA = "0x1852418F0", Slot = "28")]
	public override void Write(Utf8JsonWriter ADMHNJGGGLG, T PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49D3980", Offset = "0x49D2380", VA = "0x1849D3980")]
	public AHMDCBDPGAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JAJJMFOPBGE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JCKJJIJNEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA938E0", Offset = "0xA922E0", VA = "0x180A938E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA93AE0", Offset = "0xA924E0", VA = "0x180A93AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8346190", Offset = "0x8344B90", VA = "0x188346190", Slot = "27")]
	public override float Read(Utf8JsonReader IOMONBOBJAC, Type AGMDDAMPCMG, JsonSerializerOptions HHMKDMNANOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83461A0", Offset = "0x8344BA0", VA = "0x1883461A0", Slot = "28")]
	public override void Write(Utf8JsonWriter ADMHNJGGGLG, float PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8346340", Offset = "0x8344D40", VA = "0x188346340")]
	public JAJJMFOPBGE()
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

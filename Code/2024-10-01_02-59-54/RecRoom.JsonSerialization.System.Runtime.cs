using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class IDKHCCKBMBP<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void BCJGNGHCEBC(Utf8JsonReader CMEHKBHKHFB);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x41D6580", Offset = "0x41D5980", VA = "0x1841D6580", Slot = "27")]
	public override T Read(Utf8JsonReader OJMAIJPBMNC, Type JHLMNODJIJH, JsonSerializerOptions AHOANCKGKEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41D6780", Offset = "0x41D5B80", VA = "0x1841D6780", Slot = "28")]
	public override void Write(Utf8JsonWriter NPFBBELPJIH, T LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void IHFFJMLILDC(Utf8JsonReader OJMAIJPBMNC, JsonSerializerOptions AHOANCKGKEN, string IANCENADCFM, T BNDEDHKBDGD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void ALDJONEEECH(Utf8JsonWriter NPFBBELPJIH, T LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3AF09D0", Offset = "0x3AEFDD0", VA = "0x183AF09D0")]
	protected IDKHCCKBMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HFFPDKLOIGI : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E168F0", Offset = "0x6E15CF0", VA = "0x186E168F0")]
	public HFFPDKLOIGI(string IANCENADCFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GEAMJIFEMDH<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3FD6730", Offset = "0x3FD5B30", VA = "0x183FD6730", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader OJMAIJPBMNC, Type JHLMNODJIJH, JsonSerializerOptions AHOANCKGKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3FD6970", Offset = "0x3FD5D70", VA = "0x183FD6970", Slot = "28")]
	public override void Write(Utf8JsonWriter NPFBBELPJIH, Dictionary<TKey, int> LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3FD6BA0", Offset = "0x3FD5FA0", VA = "0x183FD6BA0")]
	public GEAMJIFEMDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OGMKMBGLJOJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D7A0", Offset = "0x4A7CBA0", VA = "0x184A7D7A0", Slot = "27")]
	public override T[] Read(Utf8JsonReader OJMAIJPBMNC, Type JHLMNODJIJH, JsonSerializerOptions AHOANCKGKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DAC0", Offset = "0x4A7CEC0", VA = "0x184A7DAC0", Slot = "28")]
	public override void Write(Utf8JsonWriter NPFBBELPJIH, T[] LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B09620", Offset = "0x3B08A20", VA = "0x183B09620")]
	protected OGMKMBGLJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class PKKIHAOBEAH<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? KCINACCGFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B81E0", Offset = "0x8B75E0", VA = "0x1808B81E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T BPAOEELBMMH(float[] BIHDACIMKFK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] KDAGEAEPDAP(T LIHHDPOHLDK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B6CA80", Offset = "0x4B6BE80", VA = "0x184B6CA80", Slot = "27")]
	public override T Read(Utf8JsonReader OJMAIJPBMNC, Type JHLMNODJIJH, JsonSerializerOptions AHOANCKGKEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D650", Offset = "0x4B6CA50", VA = "0x184B6D650", Slot = "28")]
	public override void Write(Utf8JsonWriter NPFBBELPJIH, T LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B09620", Offset = "0x3B08A20", VA = "0x183B09620")]
	protected PKKIHAOBEAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KDIGJDMGCHG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E16B70", Offset = "0x6E15F70", VA = "0x186E16B70")]
	public static void MLFFBKNGJEH(this Utf8JsonWriter NPFBBELPJIH, string IANCENADCFM, bool LIHHDPOHLDK, bool JGBDACMOCCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E16B50", Offset = "0x6E15F50", VA = "0x186E16B50")]
	public static bool ADEBDBNFJPE(this Utf8JsonReader OJMAIJPBMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E16BA0", Offset = "0x6E15FA0", VA = "0x186E16BA0")]
	public static void NGHCCKOEHCM(this Utf8JsonWriter NPFBBELPJIH, string IANCENADCFM, int? LIHHDPOHLDK, int JGBDACMOCCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9DF0", Offset = "0x2EF91F0", VA = "0x182EF9DF0")]
	public static void GFCHKLHMGOO<T>(this Utf8JsonWriter NPFBBELPJIH, string IANCENADCFM, JsonSerializerOptions AHOANCKGKEN, T HMBPNLCBEEJ, T NAMMODIDCFJ) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E16C50", Offset = "0x6E16050", VA = "0x186E16C50")]
	public static void OHPBDLOIGFP(this Utf8JsonWriter NPFBBELPJIH, float LIHHDPOHLDK, int OHKAHELAHLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class POACIPOHDFN<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B775A0", Offset = "0x4B769A0", VA = "0x184B775A0", Slot = "27")]
	public override T Read(Utf8JsonReader OJMAIJPBMNC, Type JHLMNODJIJH, JsonSerializerOptions AHOANCKGKEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B77650", Offset = "0x4B76A50", VA = "0x184B77650", Slot = "28")]
	public override void Write(Utf8JsonWriter NPFBBELPJIH, T LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD3F0", Offset = "0x3BBC7F0", VA = "0x183BBD3F0")]
	public POACIPOHDFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HFHHMEEFGGO : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GHBDOAHCJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D40", Offset = "0x8A9140", VA = "0x1808A9D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D30", Offset = "0x8A9130", VA = "0x1808A9D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E16960", Offset = "0x6E15D60", VA = "0x186E16960", Slot = "27")]
	public override float Read(Utf8JsonReader OJMAIJPBMNC, Type JHLMNODJIJH, JsonSerializerOptions AHOANCKGKEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E16970", Offset = "0x6E15D70", VA = "0x186E16970", Slot = "28")]
	public override void Write(Utf8JsonWriter NPFBBELPJIH, float LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E16B10", Offset = "0x6E15F10", VA = "0x186E16B10")]
	public HFHHMEEFGGO()
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

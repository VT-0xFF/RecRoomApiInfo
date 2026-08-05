using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class JJKENCPFCMM<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void EHPMOCOEFDO(Utf8JsonReader DEBKLEONCCD);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0A00", Offset = "0x4CAFE00", VA = "0x184CB0A00", Slot = "27")]
	public override T Read(Utf8JsonReader PABEDPKBAJJ, Type FEFILJPBGJM, JsonSerializerOptions EEANHGMNGAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0C00", Offset = "0x4CB0000", VA = "0x184CB0C00", Slot = "28")]
	public override void Write(Utf8JsonWriter CELBHBDDEKA, T OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void PBFKKEPNNDC(Utf8JsonReader PABEDPKBAJJ, JsonSerializerOptions EEANHGMNGAI, string PDAAGBJMEJF, T NNAMOJMJBHC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void JKCPEOONCBG(Utf8JsonWriter CELBHBDDEKA, T OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x434F830", Offset = "0x434EC30", VA = "0x18434F830")]
	protected JJKENCPFCMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MIIJNMDPAPL : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C6A0", Offset = "0x7B3BAA0", VA = "0x187B3C6A0")]
	public MIIJNMDPAPL(string PDAAGBJMEJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LPKGJKHELBG<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6C80", Offset = "0x4ED6080", VA = "0x184ED6C80", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader PABEDPKBAJJ, Type FEFILJPBGJM, JsonSerializerOptions EEANHGMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6EC0", Offset = "0x4ED62C0", VA = "0x184ED6EC0", Slot = "28")]
	public override void Write(Utf8JsonWriter CELBHBDDEKA, Dictionary<TKey, int> OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x481A6A0", Offset = "0x4819AA0", VA = "0x18481A6A0")]
	public LPKGJKHELBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CIPINDPBDAA<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6577B00", Offset = "0x6576F00", VA = "0x186577B00", Slot = "27")]
	public override T[] Read(Utf8JsonReader PABEDPKBAJJ, Type FEFILJPBGJM, JsonSerializerOptions EEANHGMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6577E20", Offset = "0x6577220", VA = "0x186577E20", Slot = "28")]
	public override void Write(Utf8JsonWriter CELBHBDDEKA, T[] OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x436EAE0", Offset = "0x436DEE0", VA = "0x18436EAE0")]
	protected CIPINDPBDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class APJKMNIFPBM<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? CNFJIGAJFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9C9220", Offset = "0x9C8620", VA = "0x1809C9220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MKAEABMNCIG(float[] LMNAOMMMDJP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] ECCHMOFPDMA(T OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4CA5700", Offset = "0x4CA4B00", VA = "0x184CA5700", Slot = "27")]
	public override T Read(Utf8JsonReader PABEDPKBAJJ, Type FEFILJPBGJM, JsonSerializerOptions EEANHGMNGAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CA5E00", Offset = "0x4CA5200", VA = "0x184CA5E00", Slot = "28")]
	public override void Write(Utf8JsonWriter CELBHBDDEKA, T OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x436EAE0", Offset = "0x436DEE0", VA = "0x18436EAE0")]
	protected APJKMNIFPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NIGLGPECLOG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B3CA30", Offset = "0x7B3BE30", VA = "0x187B3CA30")]
	public static void PLNEFPMCHMC(this Utf8JsonWriter CELBHBDDEKA, string PDAAGBJMEJF, bool OOEMJLHLIHJ, bool JMBBJHIBCGJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C710", Offset = "0x7B3BB10", VA = "0x187B3C710")]
	public static bool EFKNDNGFJDH(this Utf8JsonReader PABEDPKBAJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C980", Offset = "0x7B3BD80", VA = "0x187B3C980")]
	public static void PHBDDNGANNM(this Utf8JsonWriter CELBHBDDEKA, string PDAAGBJMEJF, int? OOEMJLHLIHJ, int JMBBJHIBCGJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C8D0", Offset = "0x7B3BCD0", VA = "0x187B3C8D0")]
	public static void NIEAOCJPMPN(this Utf8JsonWriter CELBHBDDEKA, string PDAAGBJMEJF, long? OOEMJLHLIHJ, long JMBBJHIBCGJ = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x385A0E0", Offset = "0x38594E0", VA = "0x18385A0E0")]
	public static void KFDLHICDKLM<T>(this Utf8JsonWriter CELBHBDDEKA, string PDAAGBJMEJF, JsonSerializerOptions EEANHGMNGAI, T DBALGCNBEDK, T ELLHMCFIBOM) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C730", Offset = "0x7B3BB30", VA = "0x187B3C730")]
	public static void HJKMGHLBMPI(this Utf8JsonWriter CELBHBDDEKA, float OOEMJLHLIHJ, int FHJKIPHGNBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FOGEBIIHFEN<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x47F3E90", Offset = "0x47F3290", VA = "0x1847F3E90", Slot = "27")]
	public override T Read(Utf8JsonReader PABEDPKBAJJ, Type FEFILJPBGJM, JsonSerializerOptions EEANHGMNGAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x47F3F40", Offset = "0x47F3340", VA = "0x1847F3F40", Slot = "28")]
	public override void Write(Utf8JsonWriter CELBHBDDEKA, T OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x440A610", Offset = "0x4409A10", VA = "0x18440A610")]
	public FOGEBIIHFEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DNDOKOKKKAN : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KEKAPCHKHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D9640", Offset = "0x9D8A40", VA = "0x1809D9640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9D9630", Offset = "0x9D8A30", VA = "0x1809D9630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C4B0", Offset = "0x7B3B8B0", VA = "0x187B3C4B0", Slot = "27")]
	public override float Read(Utf8JsonReader PABEDPKBAJJ, Type FEFILJPBGJM, JsonSerializerOptions EEANHGMNGAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C4C0", Offset = "0x7B3B8C0", VA = "0x187B3C4C0", Slot = "28")]
	public override void Write(Utf8JsonWriter CELBHBDDEKA, float OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C660", Offset = "0x7B3BA60", VA = "0x187B3C660")]
	public DNDOKOKKKAN()
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

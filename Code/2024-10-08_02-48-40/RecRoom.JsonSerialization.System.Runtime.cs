using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class BIOABCFDIOG<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void MNMNMLFCGDH(Utf8JsonReader KHFLFLECNEB);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x52DB7B0", Offset = "0x52DA9B0", VA = "0x1852DB7B0", Slot = "27")]
	public override T Read(Utf8JsonReader IDGMLEGKFGC, Type FBMBKANFAJC, JsonSerializerOptions PCHCKDDGLBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x52DB9A0", Offset = "0x52DABA0", VA = "0x1852DB9A0", Slot = "28")]
	public override void Write(Utf8JsonWriter MIOAACOLOAF, T JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void OLGKLOHBDJG(Utf8JsonReader IDGMLEGKFGC, JsonSerializerOptions PCHCKDDGLBA, string AHFDEHOMLEN, T LFDONPLGGIG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void BIMKDIDKGKA(Utf8JsonWriter MIOAACOLOAF, T JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DB60", Offset = "0x3A9CD60", VA = "0x183A9DB60")]
	protected BIOABCFDIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FNLPHKEBAGP : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C99F80", Offset = "0x6C99180", VA = "0x186C99F80")]
	public FNLPHKEBAGP(string AHFDEHOMLEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FHENEHKCIOG<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E988E0", Offset = "0x3E97AE0", VA = "0x183E988E0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader IDGMLEGKFGC, Type FBMBKANFAJC, JsonSerializerOptions PCHCKDDGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3E98B20", Offset = "0x3E97D20", VA = "0x183E98B20", Slot = "28")]
	public override void Write(Utf8JsonWriter MIOAACOLOAF, Dictionary<TKey, int> JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E98D40", Offset = "0x3E97F40", VA = "0x183E98D40")]
	public FHENEHKCIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NFFMCDDEIJG<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4829C60", Offset = "0x4828E60", VA = "0x184829C60", Slot = "27")]
	public override T[] Read(Utf8JsonReader IDGMLEGKFGC, Type FBMBKANFAJC, JsonSerializerOptions PCHCKDDGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4829F60", Offset = "0x4829160", VA = "0x184829F60", Slot = "28")]
	public override void Write(Utf8JsonWriter MIOAACOLOAF, T[] JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5BD0", Offset = "0x3AB4DD0", VA = "0x183AB5BD0")]
	protected NFFMCDDEIJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class NKDABMHPGHM<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? LHAPDHJLOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x894360", Offset = "0x893560", VA = "0x180894360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T FDHDHNOIOIH(float[] JFBMKPGOEFO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] KEDDAKPCPDO(T JECHHBGMFLN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x483DA50", Offset = "0x483CC50", VA = "0x18483DA50", Slot = "27")]
	public override T Read(Utf8JsonReader IDGMLEGKFGC, Type FBMBKANFAJC, JsonSerializerOptions PCHCKDDGLBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x483EBB0", Offset = "0x483DDB0", VA = "0x18483EBB0", Slot = "28")]
	public override void Write(Utf8JsonWriter MIOAACOLOAF, T JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5BD0", Offset = "0x3AB4DD0", VA = "0x183AB5BD0")]
	protected NKDABMHPGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HGJGFFLGFME
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A1B0", Offset = "0x6C993B0", VA = "0x186C9A1B0")]
	public static void NFDANLMOMCC(this Utf8JsonWriter MIOAACOLOAF, string AHFDEHOMLEN, bool JECHHBGMFLN, bool IIGPKDCCLGH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A190", Offset = "0x6C99390", VA = "0x186C9A190")]
	public static bool MAEEPBFPBJB(this Utf8JsonReader IDGMLEGKFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A1E0", Offset = "0x6C993E0", VA = "0x186C9A1E0")]
	public static void NPIKHBEENPA(this Utf8JsonWriter MIOAACOLOAF, string AHFDEHOMLEN, int? JECHHBGMFLN, int IIGPKDCCLGH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E15670", Offset = "0x2E14870", VA = "0x182E15670")]
	public static void IAFOMJKHOBF<T>(this Utf8JsonWriter MIOAACOLOAF, string AHFDEHOMLEN, JsonSerializerOptions PCHCKDDGLBA, T MIOIFIAKEJG, T ACPDMCOMANC) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C99FF0", Offset = "0x6C991F0", VA = "0x186C99FF0")]
	public static void FIFNIBKNBNC(this Utf8JsonWriter MIOAACOLOAF, float JECHHBGMFLN, int AEFEPHACGFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EMPONKEMAHP<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0E60", Offset = "0x3AF0060", VA = "0x183AF0E60", Slot = "27")]
	public override T Read(Utf8JsonReader IDGMLEGKFGC, Type FBMBKANFAJC, JsonSerializerOptions PCHCKDDGLBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0F00", Offset = "0x3AF0100", VA = "0x183AF0F00", Slot = "28")]
	public override void Write(Utf8JsonWriter MIOAACOLOAF, T JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0FB0", Offset = "0x3AF01B0", VA = "0x183AF0FB0")]
	public EMPONKEMAHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MPDEKPMAGDM : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ACNCDPOHCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89FAD0", Offset = "0x89ECD0", VA = "0x18089FAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89FAC0", Offset = "0x89ECC0", VA = "0x18089FAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A290", Offset = "0x6C99490", VA = "0x186C9A290", Slot = "27")]
	public override float Read(Utf8JsonReader IDGMLEGKFGC, Type FBMBKANFAJC, JsonSerializerOptions PCHCKDDGLBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A2A0", Offset = "0x6C994A0", VA = "0x186C9A2A0", Slot = "28")]
	public override void Write(Utf8JsonWriter MIOAACOLOAF, float JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A440", Offset = "0x6C99640", VA = "0x186C9A440")]
	public MPDEKPMAGDM()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class JCBKMEFONLN<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void PEOIGENGPBO(Utf8JsonReader EJNMHOGNAED);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5027780", Offset = "0x5026980", VA = "0x185027780", Slot = "27")]
	public override T Read(Utf8JsonReader GBOEOLHFKIL, Type MLPFAKIMNHM, JsonSerializerOptions AFJJJNJGALF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5027970", Offset = "0x5026B70", VA = "0x185027970", Slot = "28")]
	public override void Write(Utf8JsonWriter HLPFOKGJOHH, T KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void HPOIBLPMIOL(Utf8JsonReader GBOEOLHFKIL, JsonSerializerOptions AFJJJNJGALF, string KGBLLKPNCLE, T LHNFJLFIPMG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void DNJICJHEBDO(Utf8JsonWriter HLPFOKGJOHH, T KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x462EE40", Offset = "0x462E040", VA = "0x18462EE40")]
	protected JCBKMEFONLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AGDJGFEKHLK : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C96D10", Offset = "0x7C95F10", VA = "0x187C96D10")]
	public AGDJGFEKHLK(string KGBLLKPNCLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AJNCIGBAGND<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F34F00", Offset = "0x4F34100", VA = "0x184F34F00", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader GBOEOLHFKIL, Type MLPFAKIMNHM, JsonSerializerOptions AFJJJNJGALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F350F0", Offset = "0x4F342F0", VA = "0x184F350F0", Slot = "28")]
	public override void Write(Utf8JsonWriter HLPFOKGJOHH, Dictionary<TKey, int> KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B6CD50", Offset = "0x4B6BF50", VA = "0x184B6CD50")]
	public AJNCIGBAGND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KDNCFFODNBL<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x512A490", Offset = "0x5129690", VA = "0x18512A490", Slot = "27")]
	public override T[] Read(Utf8JsonReader GBOEOLHFKIL, Type MLPFAKIMNHM, JsonSerializerOptions AFJJJNJGALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x512A760", Offset = "0x5129960", VA = "0x18512A760", Slot = "28")]
	public override void Write(Utf8JsonWriter HLPFOKGJOHH, T[] KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4649390", Offset = "0x4648590", VA = "0x184649390")]
	protected KDNCFFODNBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class IADOEIIHEDH<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? JFKPCFBJDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA0D660", Offset = "0xA0C860", VA = "0x180A0D660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T OIMHDIKDLDO(float[] LMKJLPPFOFC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] LAKGJCBGJBH(T KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DA25F0", Offset = "0x4DA17F0", VA = "0x184DA25F0", Slot = "27")]
	public override T Read(Utf8JsonReader GBOEOLHFKIL, Type MLPFAKIMNHM, JsonSerializerOptions AFJJJNJGALF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DA2C60", Offset = "0x4DA1E60", VA = "0x184DA2C60", Slot = "28")]
	public override void Write(Utf8JsonWriter HLPFOKGJOHH, T KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4649390", Offset = "0x4648590", VA = "0x184649390")]
	protected IADOEIIHEDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HFPHJNKPKLN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C96F70", Offset = "0x7C96170", VA = "0x187C96F70")]
	public static void AFCKIANANCJ(this Utf8JsonWriter HLPFOKGJOHH, string KGBLLKPNCLE, bool KJIOHKMJAPE, bool FEOJADDJKIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C97050", Offset = "0x7C96250", VA = "0x187C97050")]
	public static bool BKPACALOPEC(this Utf8JsonReader GBOEOLHFKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C96FA0", Offset = "0x7C961A0", VA = "0x187C96FA0")]
	public static void BHPIDKCIPNJ(this Utf8JsonWriter HLPFOKGJOHH, string KGBLLKPNCLE, int? KJIOHKMJAPE, int FEOJADDJKIL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C97070", Offset = "0x7C96270", VA = "0x187C97070")]
	public static void KHNNMKHDAMM(this Utf8JsonWriter HLPFOKGJOHH, string KGBLLKPNCLE, long? KJIOHKMJAPE, long FEOJADDJKIL = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A1C6F0", Offset = "0x3A1B8F0", VA = "0x183A1C6F0")]
	public static void PGHPHAJEBLD<T>(this Utf8JsonWriter HLPFOKGJOHH, string KGBLLKPNCLE, JsonSerializerOptions AFJJJNJGALF, T DIPIKNPCGFJ, T CLENAHCIIEE) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C97120", Offset = "0x7C96320", VA = "0x187C97120")]
	public static void NNBPGKBPINN(this Utf8JsonWriter HLPFOKGJOHH, float KJIOHKMJAPE, int KDPPMLKNNBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HANDCEDPGKH<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4C946D0", Offset = "0x4C938D0", VA = "0x184C946D0", Slot = "27")]
	public override T Read(Utf8JsonReader GBOEOLHFKIL, Type MLPFAKIMNHM, JsonSerializerOptions AFJJJNJGALF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C94770", Offset = "0x4C93970", VA = "0x184C94770", Slot = "28")]
	public override void Write(Utf8JsonWriter HLPFOKGJOHH, T KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x473E320", Offset = "0x473D520", VA = "0x18473E320")]
	public HANDCEDPGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ENFDAIOMHLG : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BJKAJANLHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA00BB0", Offset = "0x9FFDB0", VA = "0x180A00BB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA00F40", Offset = "0xA00140", VA = "0x180A00F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C96D80", Offset = "0x7C95F80", VA = "0x187C96D80", Slot = "27")]
	public override float Read(Utf8JsonReader GBOEOLHFKIL, Type MLPFAKIMNHM, JsonSerializerOptions AFJJJNJGALF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C96D90", Offset = "0x7C95F90", VA = "0x187C96D90", Slot = "28")]
	public override void Write(Utf8JsonWriter HLPFOKGJOHH, float KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C96F30", Offset = "0x7C96130", VA = "0x187C96F30")]
	public ENFDAIOMHLG()
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

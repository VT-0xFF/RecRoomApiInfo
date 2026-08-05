using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class JJBCKBEFABL<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void EIGLBFOMFDD(Utf8JsonReader LIFAHFCIJCG);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4CC8830", Offset = "0x4CC7230", VA = "0x184CC8830", Slot = "27")]
	public override T Read(Utf8JsonReader BDHKEKKPKBC, Type FPEAAJEDKKO, JsonSerializerOptions LPHHENIAGIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4CC8A20", Offset = "0x4CC7420", VA = "0x184CC8A20", Slot = "28")]
	public override void Write(Utf8JsonWriter IFAFIMFGJBL, T PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void OFDADIFMNJO(Utf8JsonReader BDHKEKKPKBC, JsonSerializerOptions LPHHENIAGIG, string JHOCOFAFAFH, T OIBJKKOCOBE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void OAHECBKBEHP(Utf8JsonWriter IFAFIMFGJBL, T PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3F36F50", Offset = "0x3F35950", VA = "0x183F36F50")]
	protected JJBCKBEFABL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MGLLCMOPNPL : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x794A000", Offset = "0x7948A00", VA = "0x18794A000")]
	public MGLLCMOPNPL(string JHOCOFAFAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IJDCLHGAEIF<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A83A20", Offset = "0x4A82420", VA = "0x184A83A20", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader BDHKEKKPKBC, Type FPEAAJEDKKO, JsonSerializerOptions LPHHENIAGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A83C60", Offset = "0x4A82660", VA = "0x184A83C60", Slot = "28")]
	public override void Write(Utf8JsonWriter IFAFIMFGJBL, Dictionary<TKey, int> PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x480BD30", Offset = "0x480A730", VA = "0x18480BD30")]
	public IJDCLHGAEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PIPGHCHJAGC<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x53D6CC0", Offset = "0x53D56C0", VA = "0x1853D6CC0", Slot = "27")]
	public override T[] Read(Utf8JsonReader BDHKEKKPKBC, Type FPEAAJEDKKO, JsonSerializerOptions LPHHENIAGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x53D6FC0", Offset = "0x53D59C0", VA = "0x1853D6FC0", Slot = "28")]
	public override void Write(Utf8JsonWriter IFAFIMFGJBL, T[] PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4339FC0", Offset = "0x43389C0", VA = "0x184339FC0")]
	protected PIPGHCHJAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class MNINJHEOFEP<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? KMKNOODCDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9AED60", Offset = "0x9AD760", VA = "0x1809AED60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T INNBGDIIMOA(float[] IOMEFCNHNJN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] OBPCLLMNCNO(T PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5142FA0", Offset = "0x51419A0", VA = "0x185142FA0", Slot = "27")]
	public override T Read(Utf8JsonReader BDHKEKKPKBC, Type FPEAAJEDKKO, JsonSerializerOptions LPHHENIAGIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5144290", Offset = "0x5142C90", VA = "0x185144290", Slot = "28")]
	public override void Write(Utf8JsonWriter IFAFIMFGJBL, T PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4339FC0", Offset = "0x43389C0", VA = "0x184339FC0")]
	protected MNINJHEOFEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KCJGCGPHGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7949F00", Offset = "0x7948900", VA = "0x187949F00")]
	public static void DOECDAFNGOK(this Utf8JsonWriter IFAFIMFGJBL, string JHOCOFAFAFH, bool PPJFMHBDGNA, bool LPJIMLBFHAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7949F30", Offset = "0x7948930", VA = "0x187949F30")]
	public static bool JNAKMEMLBOM(this Utf8JsonReader BDHKEKKPKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7949E50", Offset = "0x7948850", VA = "0x187949E50")]
	public static void DFIIPPCBIOL(this Utf8JsonWriter IFAFIMFGJBL, string JHOCOFAFAFH, int? PPJFMHBDGNA, int LPJIMLBFHAO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7949F50", Offset = "0x7948950", VA = "0x187949F50")]
	public static void LNDPMGABNIL(this Utf8JsonWriter IFAFIMFGJBL, string JHOCOFAFAFH, long? PPJFMHBDGNA, long LPJIMLBFHAO = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x370D990", Offset = "0x370C390", VA = "0x18370D990")]
	public static void KEGMKJFPFHF<T>(this Utf8JsonWriter IFAFIMFGJBL, string JHOCOFAFAFH, JsonSerializerOptions LPHHENIAGIG, T OILNFPPOKDD, T CBHLIDJPBHC) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7949CB0", Offset = "0x79486B0", VA = "0x187949CB0")]
	public static void ANJOIGKGDLI(this Utf8JsonWriter IFAFIMFGJBL, float PPJFMHBDGNA, int OJHBMEEMJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NPCDPHCFCCP<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x51C56A0", Offset = "0x51C40A0", VA = "0x1851C56A0", Slot = "27")]
	public override T Read(Utf8JsonReader BDHKEKKPKBC, Type FPEAAJEDKKO, JsonSerializerOptions LPHHENIAGIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x51C5740", Offset = "0x51C4140", VA = "0x1851C5740", Slot = "28")]
	public override void Write(Utf8JsonWriter IFAFIMFGJBL, T PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x43EAB30", Offset = "0x43E9530", VA = "0x1843EAB30")]
	public NPCDPHCFCCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EEGKKPLMOBP : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FDNPPDFIGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FC0", Offset = "0x9B59C0", VA = "0x1809B6FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FE0", Offset = "0x9B59E0", VA = "0x1809B6FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7949AC0", Offset = "0x79484C0", VA = "0x187949AC0", Slot = "27")]
	public override float Read(Utf8JsonReader BDHKEKKPKBC, Type FPEAAJEDKKO, JsonSerializerOptions LPHHENIAGIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7949AD0", Offset = "0x79484D0", VA = "0x187949AD0", Slot = "28")]
	public override void Write(Utf8JsonWriter IFAFIMFGJBL, float PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7949C70", Offset = "0x7948670", VA = "0x187949C70")]
	public EEGKKPLMOBP()
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

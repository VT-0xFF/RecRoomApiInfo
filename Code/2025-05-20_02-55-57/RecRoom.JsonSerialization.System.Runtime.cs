using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class CBLLCDFAJDF<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void IMJGPAPJIDK(Utf8JsonReader DENDMCHJGLJ);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64455E0", Offset = "0x64447E0", VA = "0x1864455E0", Slot = "27")]
	public override T Read(Utf8JsonReader OHHBENOLPAE, Type HJKECCGFFIB, JsonSerializerOptions KDLGPMFPDII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64457D0", Offset = "0x64449D0", VA = "0x1864457D0", Slot = "28")]
	public override void Write(Utf8JsonWriter GDEDILINNBI, T MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void ICOBFJCILBI(Utf8JsonReader OHHBENOLPAE, JsonSerializerOptions KDLGPMFPDII, string LGOOKHKOCFM, T CKEIAGIGCJK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void MMEIHCMCFBN(Utf8JsonWriter GDEDILINNBI, T MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x44F54B0", Offset = "0x44F46B0", VA = "0x1844F54B0")]
	protected CBLLCDFAJDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BEKEOEIEENL : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CD63B0", Offset = "0x7CD55B0", VA = "0x187CD63B0")]
	public BEKEOEIEENL(string LGOOKHKOCFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MNGJAIGEAAM<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5327410", Offset = "0x5326610", VA = "0x185327410", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader OHHBENOLPAE, Type HJKECCGFFIB, JsonSerializerOptions KDLGPMFPDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5327650", Offset = "0x5326850", VA = "0x185327650", Slot = "28")]
	public override void Write(Utf8JsonWriter GDEDILINNBI, Dictionary<TKey, int> MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x49D9190", Offset = "0x49D8390", VA = "0x1849D9190")]
	public MNGJAIGEAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JOLGDGIKBLN<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4F09E30", Offset = "0x4F09030", VA = "0x184F09E30", Slot = "27")]
	public override T[] Read(Utf8JsonReader OHHBENOLPAE, Type HJKECCGFFIB, JsonSerializerOptions KDLGPMFPDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4F0A130", Offset = "0x4F09330", VA = "0x184F0A130", Slot = "28")]
	public override void Write(Utf8JsonWriter GDEDILINNBI, T[] MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4511DC0", Offset = "0x4510FC0", VA = "0x184511DC0")]
	protected JOLGDGIKBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class MKJPOOLKMMK<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? CKOBFFBKLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F24C0", Offset = "0x9F16C0", VA = "0x1809F24C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T CHDGMGDGCFH(float[] CPMBLPBIGIH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] EKNHBOFPBHM(T MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x52ECE40", Offset = "0x52EC040", VA = "0x1852ECE40", Slot = "27")]
	public override T Read(Utf8JsonReader OHHBENOLPAE, Type HJKECCGFFIB, JsonSerializerOptions KDLGPMFPDII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x52EDC10", Offset = "0x52ECE10", VA = "0x1852EDC10", Slot = "28")]
	public override void Write(Utf8JsonWriter GDEDILINNBI, T MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4511DC0", Offset = "0x4510FC0", VA = "0x184511DC0")]
	protected MKJPOOLKMMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LCGHNBIJLFH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6630", Offset = "0x7CD5830", VA = "0x187CD6630")]
	public static void JBABKCEAJHP(this Utf8JsonWriter GDEDILINNBI, string LGOOKHKOCFM, bool MLCDCHNOCFI, bool FAGKKFIFNNI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6610", Offset = "0x7CD5810", VA = "0x187CD6610")]
	public static bool BIGMKBPHFFF(this Utf8JsonReader OHHBENOLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6710", Offset = "0x7CD5910", VA = "0x187CD6710")]
	public static void LKCBGMHNPPD(this Utf8JsonWriter GDEDILINNBI, string LGOOKHKOCFM, int? MLCDCHNOCFI, int FAGKKFIFNNI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6660", Offset = "0x7CD5860", VA = "0x187CD6660")]
	public static void JHAKEJJMFNO(this Utf8JsonWriter GDEDILINNBI, string LGOOKHKOCFM, long? MLCDCHNOCFI, long FAGKKFIFNNI = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38BA480", Offset = "0x38B9680", VA = "0x1838BA480")]
	public static void CDFJNKIOADI<T>(this Utf8JsonWriter GDEDILINNBI, string LGOOKHKOCFM, JsonSerializerOptions KDLGPMFPDII, T KFEGNKODPFP, T MFACCPCFPBK) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD67C0", Offset = "0x7CD59C0", VA = "0x187CD67C0")]
	public static void NONJMGOFKEC(this Utf8JsonWriter GDEDILINNBI, float MLCDCHNOCFI, int HDDPOLJLNOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GNPPMNFJAAP<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4AA1330", Offset = "0x4AA0530", VA = "0x184AA1330", Slot = "27")]
	public override T Read(Utf8JsonReader OHHBENOLPAE, Type HJKECCGFFIB, JsonSerializerOptions KDLGPMFPDII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA13D0", Offset = "0x4AA05D0", VA = "0x184AA13D0", Slot = "28")]
	public override void Write(Utf8JsonWriter GDEDILINNBI, T MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x459F610", Offset = "0x459E810", VA = "0x18459F610")]
	public GNPPMNFJAAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HFOHEBGEHBK : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ODNMBKAJAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9FD530", Offset = "0x9FC730", VA = "0x1809FD530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8D0", Offset = "0x9FCAD0", VA = "0x1809FD8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6420", Offset = "0x7CD5620", VA = "0x187CD6420", Slot = "27")]
	public override float Read(Utf8JsonReader OHHBENOLPAE, Type HJKECCGFFIB, JsonSerializerOptions KDLGPMFPDII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6430", Offset = "0x7CD5630", VA = "0x187CD6430", Slot = "28")]
	public override void Write(Utf8JsonWriter GDEDILINNBI, float MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CD65D0", Offset = "0x7CD57D0", VA = "0x187CD65D0")]
	public HFOHEBGEHBK()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class NILCKJFPBBA<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void FCGAFELHKLJ(Utf8JsonReader FGEFHKAEIPE);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x550EA60", Offset = "0x550D460", VA = "0x18550EA60", Slot = "27")]
	public override T Read(Utf8JsonReader LJMOCEGEAFH, Type NOJGMMNNMLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x550EC50", Offset = "0x550D650", VA = "0x18550EC50", Slot = "28")]
	public override void Write(Utf8JsonWriter EDJIMCINKFD, T PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void OCFJDMKDCAO(Utf8JsonReader LJMOCEGEAFH, JsonSerializerOptions LCCNAOLCHEE, string NJOLLKLCOEF, T HMJJODPHKCG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void NNJCMOBICLJ(Utf8JsonWriter EDJIMCINKFD, T PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x465CCF0", Offset = "0x465B6F0", VA = "0x18465CCF0")]
	protected NILCKJFPBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AAGLMFLCEMD : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AAF0", Offset = "0x7D894F0", VA = "0x187D8AAF0")]
	public AAGLMFLCEMD(string NJOLLKLCOEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IOIEDLFOKKC<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E7B210", Offset = "0x4E79C10", VA = "0x184E7B210", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader LJMOCEGEAFH, Type NOJGMMNNMLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E7B400", Offset = "0x4E79E00", VA = "0x184E7B400", Slot = "28")]
	public override void Write(Utf8JsonWriter EDJIMCINKFD, Dictionary<TKey, int> PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4BC4B00", Offset = "0x4BC3500", VA = "0x184BC4B00")]
	public IOIEDLFOKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BJDGFIEJLAG<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6117320", Offset = "0x6115D20", VA = "0x186117320", Slot = "27")]
	public override T[] Read(Utf8JsonReader LJMOCEGEAFH, Type NOJGMMNNMLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61175F0", Offset = "0x6115FF0", VA = "0x1861175F0", Slot = "28")]
	public override void Write(Utf8JsonWriter EDJIMCINKFD, T[] PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4677240", Offset = "0x4675C40", VA = "0x184677240")]
	protected BJDGFIEJLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class HJKPDOCLIAB<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? DFLBDCGMKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA10FD0", Offset = "0xA0F9D0", VA = "0x180A10FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MCDIGFGLPFI(float[] OKEIIBNBBOL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] GHLGFMMOBOL(T PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D00EA0", Offset = "0x4CFF8A0", VA = "0x184D00EA0", Slot = "27")]
	public override T Read(Utf8JsonReader LJMOCEGEAFH, Type NOJGMMNNMLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D01720", Offset = "0x4D00120", VA = "0x184D01720", Slot = "28")]
	public override void Write(Utf8JsonWriter EDJIMCINKFD, T PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4677240", Offset = "0x4675C40", VA = "0x184677240")]
	protected HJKPDOCLIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JNMEHKOGMCN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AED0", Offset = "0x7D898D0", VA = "0x187D8AED0")]
	public static void KJLECLPCAFE(this Utf8JsonWriter EDJIMCINKFD, string NJOLLKLCOEF, bool PCDAHJCDHHF, bool ALKDPGOIFPD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AEB0", Offset = "0x7D898B0", VA = "0x187D8AEB0")]
	public static bool JBGFCFKLDJB(this Utf8JsonReader LJMOCEGEAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AD50", Offset = "0x7D89750", VA = "0x187D8AD50")]
	public static void AHCJEJPGKKG(this Utf8JsonWriter EDJIMCINKFD, string NJOLLKLCOEF, int? PCDAHJCDHHF, int ALKDPGOIFPD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AE00", Offset = "0x7D89800", VA = "0x187D8AE00")]
	public static void CBMCNNDJHIJ(this Utf8JsonWriter EDJIMCINKFD, string NJOLLKLCOEF, long? PCDAHJCDHHF, long ALKDPGOIFPD = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE400", Offset = "0x3ACCE00", VA = "0x183ACE400")]
	public static void KLNKDPHIEPM<T>(this Utf8JsonWriter EDJIMCINKFD, string NJOLLKLCOEF, JsonSerializerOptions LCCNAOLCHEE, T KPILPFEAJHA, T FKEKJBIOLAB) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AF00", Offset = "0x7D89900", VA = "0x187D8AF00")]
	public static void OPPEMEANLAG(this Utf8JsonWriter EDJIMCINKFD, float PCDAHJCDHHF, int FCBIJPHLGPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HBGJMDKEBHK<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6A10", Offset = "0x4CD5410", VA = "0x184CD6A10", Slot = "27")]
	public override T Read(Utf8JsonReader LJMOCEGEAFH, Type NOJGMMNNMLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6AB0", Offset = "0x4CD54B0", VA = "0x184CD6AB0", Slot = "28")]
	public override void Write(Utf8JsonWriter EDJIMCINKFD, T PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4747670", Offset = "0x4746070", VA = "0x184747670")]
	public HBGJMDKEBHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BKJGMLMNBNE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HKCJMDBJHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7C0", Offset = "0xA091C0", VA = "0x180A0A7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA0A550", Offset = "0xA08F50", VA = "0x180A0A550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AB60", Offset = "0x7D89560", VA = "0x187D8AB60", Slot = "27")]
	public override float Read(Utf8JsonReader LJMOCEGEAFH, Type NOJGMMNNMLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AB70", Offset = "0x7D89570", VA = "0x187D8AB70", Slot = "28")]
	public override void Write(Utf8JsonWriter EDJIMCINKFD, float PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AD10", Offset = "0x7D89710", VA = "0x187D8AD10")]
	public BKJGMLMNBNE()
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

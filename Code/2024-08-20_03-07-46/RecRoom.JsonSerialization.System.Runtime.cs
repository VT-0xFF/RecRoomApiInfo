using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class BCCMKHDNANG<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void JLHIPHDEEPF(Utf8JsonReader IELHIIDGIMN);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E73500", Offset = "0x4E72500", VA = "0x184E73500", Slot = "27")]
	public override T Read(Utf8JsonReader JBMHGCNDNMN, Type EMJCDFPIDEK, JsonSerializerOptions OLBNLJKBNFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E736F0", Offset = "0x4E726F0", VA = "0x184E736F0", Slot = "28")]
	public override void Write(Utf8JsonWriter KOHNEKCBPBH, T JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void LBNJAACLDOK(Utf8JsonReader JBMHGCNDNMN, JsonSerializerOptions OLBNLJKBNFE, string BGJCPPOHOEL, T LLGHCONMHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void IJJMPHCONDO(Utf8JsonWriter KOHNEKCBPBH, T JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x386EBF0", Offset = "0x386DBF0", VA = "0x18386EBF0")]
	protected BCCMKHDNANG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IIDOJAHHBJA : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69A1900", Offset = "0x69A0900", VA = "0x1869A1900")]
	public IIDOJAHHBJA(string BGJCPPOHOEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class INBDCOKMENO<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F49260", Offset = "0x3F48260", VA = "0x183F49260", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader JBMHGCNDNMN, Type EMJCDFPIDEK, JsonSerializerOptions OLBNLJKBNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F49490", Offset = "0x3F48490", VA = "0x183F49490", Slot = "28")]
	public override void Write(Utf8JsonWriter KOHNEKCBPBH, Dictionary<TKey, int> JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F496A0", Offset = "0x3F486A0", VA = "0x183F496A0")]
	public INBDCOKMENO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DHPIHIDKBFD<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5869D20", Offset = "0x5868D20", VA = "0x185869D20", Slot = "27")]
	public override T[] Read(Utf8JsonReader JBMHGCNDNMN, Type EMJCDFPIDEK, JsonSerializerOptions OLBNLJKBNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x586A020", Offset = "0x5869020", VA = "0x18586A020", Slot = "28")]
	public override void Write(Utf8JsonWriter KOHNEKCBPBH, T[] JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x386E430", Offset = "0x386D430", VA = "0x18386E430")]
	protected DHPIHIDKBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class NMFHLILIFGK<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? CMDAHHCPFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x851850", Offset = "0x850850", VA = "0x180851850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T APMFLAKFFKN(float[] ADLAOOMHAPB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] DGKGANFODBM(T JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x45FD8B0", Offset = "0x45FC8B0", VA = "0x1845FD8B0", Slot = "27")]
	public override T Read(Utf8JsonReader JBMHGCNDNMN, Type EMJCDFPIDEK, JsonSerializerOptions OLBNLJKBNFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45FEBA0", Offset = "0x45FDBA0", VA = "0x1845FEBA0", Slot = "28")]
	public override void Write(Utf8JsonWriter KOHNEKCBPBH, T JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x386E430", Offset = "0x386D430", VA = "0x18386E430")]
	protected NMFHLILIFGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ODNLJPHIDHI
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69A1D00", Offset = "0x69A0D00", VA = "0x1869A1D00")]
	public static void EEKCMOJGOKE(this Utf8JsonWriter KOHNEKCBPBH, string BGJCPPOHOEL, bool JJCEIJMGOAB, bool KCDEJIJHLPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69A1DE0", Offset = "0x69A0DE0", VA = "0x1869A1DE0")]
	public static bool JAPPMFPKHMB(this Utf8JsonReader JBMHGCNDNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69A1D30", Offset = "0x69A0D30", VA = "0x1869A1D30")]
	public static void GCMKCOINNGI(this Utf8JsonWriter KOHNEKCBPBH, string BGJCPPOHOEL, int? JJCEIJMGOAB, int KCDEJIJHLPJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D3DC00", Offset = "0x2D3CC00", VA = "0x182D3DC00")]
	public static void AGJNPGOONOJ<T>(this Utf8JsonWriter KOHNEKCBPBH, string BGJCPPOHOEL, JsonSerializerOptions OLBNLJKBNFE, T AAINAOCHJJJ, T EFLODNAHHNN) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69A1B60", Offset = "0x69A0B60", VA = "0x1869A1B60")]
	public static void ABEOOKHLKJJ(this Utf8JsonWriter KOHNEKCBPBH, float JJCEIJMGOAB, int HNFFHPCLFJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KODFLIIKOMN<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x425CBC0", Offset = "0x425BBC0", VA = "0x18425CBC0", Slot = "27")]
	public override T Read(Utf8JsonReader JBMHGCNDNMN, Type EMJCDFPIDEK, JsonSerializerOptions OLBNLJKBNFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x425CC60", Offset = "0x425BC60", VA = "0x18425CC60", Slot = "28")]
	public override void Write(Utf8JsonWriter KOHNEKCBPBH, T JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38FC910", Offset = "0x38FB910", VA = "0x1838FC910")]
	public KODFLIIKOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KNLJDFLMJLC : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ALFDMNNOCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8593D0", Offset = "0x8583D0", VA = "0x1808593D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x859750", Offset = "0x858750", VA = "0x180859750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69A1970", Offset = "0x69A0970", VA = "0x1869A1970", Slot = "27")]
	public override float Read(Utf8JsonReader JBMHGCNDNMN, Type EMJCDFPIDEK, JsonSerializerOptions OLBNLJKBNFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69A1980", Offset = "0x69A0980", VA = "0x1869A1980", Slot = "28")]
	public override void Write(Utf8JsonWriter KOHNEKCBPBH, float JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69A1B20", Offset = "0x69A0B20", VA = "0x1869A1B20")]
	public KNLJDFLMJLC()
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

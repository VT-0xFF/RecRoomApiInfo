using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class JFAIJMADLEC<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void OCBLMBAGIPP(Utf8JsonReader OFMNIPCGFAG);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x405A650", Offset = "0x4059050", VA = "0x18405A650", Slot = "27")]
	public override T Read(Utf8JsonReader DGAMLJBEAIK, Type BOBBLNKFPEA, JsonSerializerOptions FKJNBGBCACC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x405A840", Offset = "0x4059240", VA = "0x18405A840", Slot = "28")]
	public override void Write(Utf8JsonWriter AACOMNCLNFJ, T DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void NPAJABCOLMK(Utf8JsonReader DGAMLJBEAIK, JsonSerializerOptions FKJNBGBCACC, string NBNDOLIHNCP, T IMMLPPOHEAP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void BGPANCLAELF(Utf8JsonWriter AACOMNCLNFJ, T DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37C11F0", Offset = "0x37BFBF0", VA = "0x1837C11F0")]
	protected JFAIJMADLEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EJCAPLJINAO : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68F1770", Offset = "0x68F0170", VA = "0x1868F1770")]
	public EJCAPLJINAO(string NBNDOLIHNCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GDOFOCGEDDD<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D16830", Offset = "0x3D15230", VA = "0x183D16830", Slot = "27")]
	public override T[] Read(Utf8JsonReader DGAMLJBEAIK, Type BOBBLNKFPEA, JsonSerializerOptions FKJNBGBCACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D16B40", Offset = "0x3D15540", VA = "0x183D16B40", Slot = "28")]
	public override void Write(Utf8JsonWriter AACOMNCLNFJ, T[] DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37C0A90", Offset = "0x37BF490", VA = "0x1837C0A90")]
	protected GDOFOCGEDDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KCAFIDIBNAP<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? FLLMODDEEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84ECA0", Offset = "0x84D6A0", VA = "0x18084ECA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T LBMAAAIEHNB(float[] AHBFNFFEMPG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] MEAGOHACMGM(T DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x41B1100", Offset = "0x41AFB00", VA = "0x1841B1100", Slot = "27")]
	public override T Read(Utf8JsonReader DGAMLJBEAIK, Type BOBBLNKFPEA, JsonSerializerOptions FKJNBGBCACC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x41B23F0", Offset = "0x41B0DF0", VA = "0x1841B23F0", Slot = "28")]
	public override void Write(Utf8JsonWriter AACOMNCLNFJ, T DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37C0A90", Offset = "0x37BF490", VA = "0x1837C0A90")]
	protected KCAFIDIBNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CCHGGKECKFK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68F1740", Offset = "0x68F0140", VA = "0x1868F1740")]
	public static void HHPHOEAMLCJ(this Utf8JsonWriter AACOMNCLNFJ, string NBNDOLIHNCP, bool DBOBEHLEAAE, bool JIEGAHKKHCA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68F1720", Offset = "0x68F0120", VA = "0x1868F1720")]
	public static bool GOJNOKOOOPE(this Utf8JsonReader DGAMLJBEAIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68F14D0", Offset = "0x68EFED0", VA = "0x1868F14D0")]
	public static void BCCLDJGOFGP(this Utf8JsonWriter AACOMNCLNFJ, string NBNDOLIHNCP, int? DBOBEHLEAAE, int JIEGAHKKHCA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x292A820", Offset = "0x2929220", VA = "0x18292A820")]
	public static void OKGKCEGLIPA<T>(this Utf8JsonWriter AACOMNCLNFJ, string NBNDOLIHNCP, JsonSerializerOptions FKJNBGBCACC, T EHIEOLDDJEB, T PDHAEMLJEFL) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68F1580", Offset = "0x68EFF80", VA = "0x1868F1580")]
	public static void GJGKBKADPMI(this Utf8JsonWriter AACOMNCLNFJ, float DBOBEHLEAAE, int OBCCJIGAJFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NNAEDBDNBCJ<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x45030A0", Offset = "0x4501AA0", VA = "0x1845030A0", Slot = "27")]
	public override T Read(Utf8JsonReader DGAMLJBEAIK, Type BOBBLNKFPEA, JsonSerializerOptions FKJNBGBCACC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4503140", Offset = "0x4501B40", VA = "0x184503140", Slot = "28")]
	public override void Write(Utf8JsonWriter AACOMNCLNFJ, T DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38C94E0", Offset = "0x38C7EE0", VA = "0x1838C94E0")]
	public NNAEDBDNBCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JPJPPFCFJGP : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EGMDPPIGJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x858B50", Offset = "0x857550", VA = "0x180858B50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x858ED0", Offset = "0x8578D0", VA = "0x180858ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68F17E0", Offset = "0x68F01E0", VA = "0x1868F17E0", Slot = "27")]
	public override float Read(Utf8JsonReader DGAMLJBEAIK, Type BOBBLNKFPEA, JsonSerializerOptions FKJNBGBCACC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68F17F0", Offset = "0x68F01F0", VA = "0x1868F17F0", Slot = "28")]
	public override void Write(Utf8JsonWriter AACOMNCLNFJ, float DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68F1990", Offset = "0x68F0390", VA = "0x1868F1990")]
	public JPJPPFCFJGP()
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

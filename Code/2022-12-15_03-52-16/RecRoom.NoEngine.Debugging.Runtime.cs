using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NOFIIIGNMBC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class JLJPHHEMEDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2608960", Offset = "0x2607360", VA = "0x182608960")]
	public static Func<Type, bool> EKMKIGFPIOF<T>(this NOFIIIGNMBC DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2296360", Offset = "0x2294D60", VA = "0x182296360")]
	private static bool EINAALIGJEF<T>(Type OHIFCFJILKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2608D30", Offset = "0x2607730", VA = "0x182608D30")]
	private static bool OFOMNGLGAKL<T>(Type OHIFCFJILKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class COKJIJFGOGK<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> LOLBHDGEFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> LKLEEKOOEDF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x335C8B0", Offset = "0x335B2B0", VA = "0x18335C8B0", Slot = "6")]
	public override bool CanConvert(Type OHIFCFJILKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x335CF70", Offset = "0x335B970", VA = "0x18335CF70", Slot = "5")]
	public override object ReadJson(JsonReader ILDGEJAOOHJ, Type OHIFCFJILKH, object PEENLKBFIPN, JsonSerializer IOHHLKEMCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x335D9D0", Offset = "0x335C3D0", VA = "0x18335D9D0", Slot = "4")]
	public override void WriteJson(JsonWriter IEEJJNDPOHK, object MAKFNMHIJIF, JsonSerializer IOHHLKEMCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x316E2C0", Offset = "0x316CCC0", VA = "0x18316E2C0")]
	internal COKJIJFGOGK(Func<Type, bool> LOLBHDGEFNN, Action<JsonWriter, T> LKLEEKOOEDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DNDNEKPDLFA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1C538D0", Offset = "0x1C522D0", VA = "0x181C538D0")]
	public static global::COKJIJFGOGK<T> OJKIKDBCCPC<T>(Action<JsonWriter, T> LKLEEKOOEDF, NOFIIIGNMBC PLHMADOIMNG = NOFIIIGNMBC.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OIJDOEKBJCN
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] BJGBMDJKFHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter NEMBNFCHADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF4A310", Offset = "0xF48D10", VA = "0x180F4A310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter KIAGBLNMKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF4A250", Offset = "0xF48C50", VA = "0x180F4A250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter DMIEGLGFFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF4A370", Offset = "0xF48D70", VA = "0x180F4A370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter OJDHIGKGCHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF4A3D0", Offset = "0xF48DD0", VA = "0x180F4A3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter PCNHFDILHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF4A2B0", Offset = "0xF48CB0", VA = "0x180F4A2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JKIKDOKAFCB
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xF4A1E0", Offset = "0xF48BE0", VA = "0x180F4A1E0")]
	public static string OCOCINPKAMG(this object DKOFBKPNBJK, JsonConverter[] GDDHKKPMBIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GMHNIHBLNMH<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> LOLBHDGEFNN;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x35C6C60", Offset = "0x35C5660", VA = "0x1835C6C60", Slot = "6")]
	public override bool CanConvert(Type OHIFCFJILKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x35C6CC0", Offset = "0x35C56C0", VA = "0x1835C6CC0", Slot = "5")]
	public override object ReadJson(JsonReader ILDGEJAOOHJ, Type OHIFCFJILKH, object PEENLKBFIPN, JsonSerializer IOHHLKEMCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35C6DB0", Offset = "0x35C57B0", VA = "0x1835C6DB0", Slot = "4")]
	public override void WriteJson(JsonWriter IEEJJNDPOHK, object MAKFNMHIJIF, JsonSerializer IOHHLKEMCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E188B0", Offset = "0x2E172B0", VA = "0x182E188B0")]
	internal GMHNIHBLNMH(Func<Type, bool> LOLBHDGEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IMGEBCPKOMH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x25F2CF0", Offset = "0x25F16F0", VA = "0x1825F2CF0")]
	public static global::GMHNIHBLNMH<T> OJKIKDBCCPC<T>(NOFIIIGNMBC PLHMADOIMNG = NOFIIIGNMBC.Assignable)
	{
		return null;
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

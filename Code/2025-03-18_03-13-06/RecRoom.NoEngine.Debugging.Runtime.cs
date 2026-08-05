using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum OPNJMDAMIGF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class HIAPLBIPJKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x34AB680", Offset = "0x34AA880", VA = "0x1834AB680")]
	public static Func<Type, bool> PODDGFPAFOD<T>(this OPNJMDAMIGF NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x32C9360", Offset = "0x32C8560", VA = "0x1832C9360")]
	private static bool CNKMLMONKNC<T>(Type NOOGDGHCMBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x34AB260", Offset = "0x34AA460", VA = "0x1834AB260")]
	private static bool CBICAJGHKNF<T>(Type NOOGDGHCMBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ECINMANOKEK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x32E8B70", Offset = "0x32E7D70", VA = "0x1832E8B70")]
	public static string NOAKDLBAKCE<T>(T PMBHGOELOML, string KBKEENDAHNE = ", ", [Optional] T OGPHJJMKHNA) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32E8660", Offset = "0x32E7860", VA = "0x1832E8660")]
	public static string LADFMMOJCAK<T>(T PMBHGOELOML, string KBKEENDAHNE = ", ", params T[] GHLNBFPBEDH) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32E8910", Offset = "0x32E7B10", VA = "0x1832E8910")]
	private static bool LOJPCGABADO<T>(T[] GHLNBFPBEDH, T GONPIINPMBP, IEqualityComparer<T> DIHIGKEAOAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class POKNDGLCOBO<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> ECIFCLOFIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> IMMJJFLGFCJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x44AFCB0", Offset = "0x44AEEB0", VA = "0x1844AFCB0", Slot = "6")]
	public override bool CanConvert(Type NOOGDGHCMBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5139C20", Offset = "0x5138E20", VA = "0x185139C20", Slot = "5")]
	public override object ReadJson(JsonReader KLIFEKFIIAG, Type NOOGDGHCMBG, object BOGEEMFBEMN, JsonSerializer CLJAHMKEHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x513A420", Offset = "0x5139620", VA = "0x18513A420", Slot = "4")]
	public override void WriteJson(JsonWriter DKHAABKGBIG, object OMFJNFBDJCA, JsonSerializer CLJAHMKEHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x48683C0", Offset = "0x48675C0", VA = "0x1848683C0")]
	internal POKNDGLCOBO(Func<Type, bool> ECIFCLOFIHL, Action<JsonWriter, T> IMMJJFLGFCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BANMCCLJFJO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x31F0290", Offset = "0x31EF490", VA = "0x1831F0290")]
	public static POKNDGLCOBO<T> PEFMILKIAFF<T>(Action<JsonWriter, T> IMMJJFLGFCJ, OPNJMDAMIGF LLKDEFLIDGC = OPNJMDAMIGF.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BGFFLIBAAEB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] IODKNLGJFGL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter FBHFELJGOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77152E0", Offset = "0x77144E0", VA = "0x1877152E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter DOCECLOOCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7715330", Offset = "0x7714530", VA = "0x187715330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter IMHCKCCHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7715290", Offset = "0x7714490", VA = "0x187715290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter BIAJOAGEHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77151F0", Offset = "0x77143F0", VA = "0x1877151F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter CLBNEPDBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7715240", Offset = "0x7714440", VA = "0x187715240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FDECEKNBJDE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77158A0", Offset = "0x7714AA0", VA = "0x1877158A0")]
	public static string OIHKGBAFBFJ(this object NAELBAPCKEH, JsonConverter[] ANNJAOBCCJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class FCBGHFLJHAJ<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> ECIFCLOFIHL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x44AFCB0", Offset = "0x44AEEB0", VA = "0x1844AFCB0", Slot = "6")]
	public override bool CanConvert(Type NOOGDGHCMBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x44AFCE0", Offset = "0x44AEEE0", VA = "0x1844AFCE0", Slot = "5")]
	public override object ReadJson(JsonReader KLIFEKFIIAG, Type NOOGDGHCMBG, object BOGEEMFBEMN, JsonSerializer CLJAHMKEHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x44AFDB0", Offset = "0x44AEFB0", VA = "0x1844AFDB0", Slot = "4")]
	public override void WriteJson(JsonWriter DKHAABKGBIG, object OMFJNFBDJCA, JsonSerializer CLJAHMKEHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
	internal FCBGHFLJHAJ(Func<Type, bool> ECIFCLOFIHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EJEEKFAPADH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32ECE80", Offset = "0x32EC080", VA = "0x1832ECE80")]
	public static FCBGHFLJHAJ<T> PEFMILKIAFF<T>(OPNJMDAMIGF LLKDEFLIDGC = OPNJMDAMIGF.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class MFJBEJGHDGG : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> ECIFCLOFIHL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x44AFCB0", Offset = "0x44AEEB0", VA = "0x1844AFCB0", Slot = "6")]
	public override bool CanConvert(Type NOOGDGHCMBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7715900", Offset = "0x7714B00", VA = "0x187715900", Slot = "5")]
	public override object ReadJson(JsonReader KLIFEKFIIAG, Type NOOGDGHCMBG, object BOGEEMFBEMN, JsonSerializer CLJAHMKEHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77159A0", Offset = "0x7714BA0", VA = "0x1877159A0", Slot = "4")]
	public override void WriteJson(JsonWriter DKHAABKGBIG, object OMFJNFBDJCA, JsonSerializer CLJAHMKEHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
	public MFJBEJGHDGG(Func<Type, bool> ECIFCLOFIHL)
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

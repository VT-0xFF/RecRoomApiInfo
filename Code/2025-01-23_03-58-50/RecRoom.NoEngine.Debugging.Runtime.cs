using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CABAMKOEOFM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class OMHMHKNLBNL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x32047D0", Offset = "0x3202FD0", VA = "0x1832047D0")]
	public static Func<Type, bool> CIPBNGENJJA<T>(this CABAMKOEOFM EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DD40", Offset = "0x2E5C540", VA = "0x182E5DD40")]
	private static bool FKIEIBMFIPD<T>(Type PPHCDIDAADF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3204BB0", Offset = "0x32033B0", VA = "0x183204BB0")]
	private static bool LCONHFCLEAE<T>(Type PPHCDIDAADF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NAEKDPMMDAI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x31C21F0", Offset = "0x31C09F0", VA = "0x1831C21F0")]
	public static string OCCFJAHHBCA<T>(T HGBJJIKLGEJ, string MNOPJEMDPKP = ", ", [Optional] T DFEJJOPGBKP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x31C1F30", Offset = "0x31C0730", VA = "0x1831C1F30")]
	public static string GDFBOELAFAM<T>(T HGBJJIKLGEJ, string MNOPJEMDPKP = ", ", params T[] AKKFIKMBBFD) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x31C1CD0", Offset = "0x31C04D0", VA = "0x1831C1CD0")]
	private static bool EEKJIMIDFMJ<T>(T[] AKKFIKMBBFD, T PNPOCGOGHBA, IEqualityComparer<T> HADPFNKGDNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class OLBBKEOAPBE<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> MEFMACBKEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> JEKBNCMDOEP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4068CB0", Offset = "0x40674B0", VA = "0x184068CB0", Slot = "6")]
	public override bool CanConvert(Type PPHCDIDAADF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B5DB10", Offset = "0x4B5C310", VA = "0x184B5DB10", Slot = "5")]
	public override object ReadJson(JsonReader GKMNBDEFGCI, Type PPHCDIDAADF, object KBFJIEABPNP, JsonSerializer JLOPIBLIBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B5DCB0", Offset = "0x4B5C4B0", VA = "0x184B5DCB0", Slot = "4")]
	public override void WriteJson(JsonWriter PAOHHJOJGFD, object INDENPJBLHO, JsonSerializer JLOPIBLIBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4595180", Offset = "0x4593980", VA = "0x184595180")]
	internal OLBBKEOAPBE(Func<Type, bool> MEFMACBKEPC, Action<JsonWriter, T> JEKBNCMDOEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DACDNCMBFPH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E96740", Offset = "0x2E94F40", VA = "0x182E96740")]
	public static OLBBKEOAPBE<T> DFLBOLBHLFN<T>(Action<JsonWriter, T> JEKBNCMDOEP, CABAMKOEOFM HAICHGFLELA = CABAMKOEOFM.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MFPLBNNFHJI
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] BGPIJGAALJG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter ECDKNOGPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7051DC0", Offset = "0x70505C0", VA = "0x187051DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter DNNOMPADMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7051E10", Offset = "0x7050610", VA = "0x187051E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter COJALJELHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7051D70", Offset = "0x7050570", VA = "0x187051D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter FNPJAABJGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7051E60", Offset = "0x7050660", VA = "0x187051E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter OBBJOOPKMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7051EB0", Offset = "0x70506B0", VA = "0x187051EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PBAIGOIHKFI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7052450", Offset = "0x7050C50", VA = "0x187052450")]
	public static string MFJMMPCKIGN(this object EGGDEECAALI, JsonConverter[] KFDPMHCEPPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class FFLJNNKPEEG<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> MEFMACBKEPC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4068CB0", Offset = "0x40674B0", VA = "0x184068CB0", Slot = "6")]
	public override bool CanConvert(Type PPHCDIDAADF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4068CE0", Offset = "0x40674E0", VA = "0x184068CE0", Slot = "5")]
	public override object ReadJson(JsonReader GKMNBDEFGCI, Type PPHCDIDAADF, object KBFJIEABPNP, JsonSerializer JLOPIBLIBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4068DB0", Offset = "0x40675B0", VA = "0x184068DB0", Slot = "4")]
	public override void WriteJson(JsonWriter PAOHHJOJGFD, object INDENPJBLHO, JsonSerializer JLOPIBLIBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
	internal FFLJNNKPEEG(Func<Type, bool> MEFMACBKEPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LKFKPAHLKNP
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3111EC0", Offset = "0x31106C0", VA = "0x183111EC0")]
	public static FFLJNNKPEEG<T> DFLBOLBHLFN<T>(CABAMKOEOFM HAICHGFLELA = CABAMKOEOFM.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class IFGBKFMEEOC : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> MEFMACBKEPC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4068CB0", Offset = "0x40674B0", VA = "0x184068CB0", Slot = "6")]
	public override bool CanConvert(Type PPHCDIDAADF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7051C60", Offset = "0x7050460", VA = "0x187051C60", Slot = "5")]
	public override object ReadJson(JsonReader GKMNBDEFGCI, Type PPHCDIDAADF, object KBFJIEABPNP, JsonSerializer JLOPIBLIBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7051D00", Offset = "0x7050500", VA = "0x187051D00", Slot = "4")]
	public override void WriteJson(JsonWriter PAOHHJOJGFD, object INDENPJBLHO, JsonSerializer JLOPIBLIBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
	public IFGBKFMEEOC(Func<Type, bool> MEFMACBKEPC)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PAMJPCKGBHA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class OFJGDGEKLOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x39E2030", Offset = "0x39E1230", VA = "0x1839E2030")]
	public static Func<Type, bool> JKJMPDEIKGE<T>(this PAMJPCKGBHA CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3662070", Offset = "0x3661270", VA = "0x183662070")]
	private static bool ACEECHEPLCN<T>(Type ODHJIEMHPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x39E2410", Offset = "0x39E1610", VA = "0x1839E2410")]
	private static bool NNAPLLNBFJF<T>(Type ODHJIEMHPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AODJNLMOFCA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x401AB00", Offset = "0x4019D00", VA = "0x18401AB00")]
	public static string ALLEKIAPHJG<T>(T EJKIDBDKPMD, string DMCCJIIADJI = ", ", [Optional] T FAGKKFIFNNI) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x401ABA0", Offset = "0x4019DA0", VA = "0x18401ABA0")]
	public static string MNAEHJFFOFL<T>(T EJKIDBDKPMD, string DMCCJIIADJI = ", ", params T[] NAGBCLCOHAD) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x401AE60", Offset = "0x401A060", VA = "0x18401AE60")]
	private static bool PIDPJOAAMPH<T>(T[] NAGBCLCOHAD, T ONCELMGACCP, IEqualityComparer<T> LEABKHICHOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LEEGFKFEDHB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> HKMDFLNMMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> EBEMNKLFPLJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2760FD0", Offset = "0x27601D0", VA = "0x182760FD0", Slot = "6")]
	public override bool CanConvert(Type ODHJIEMHPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50BFEE0", Offset = "0x50BF0E0", VA = "0x1850BFEE0", Slot = "5")]
	public override object ReadJson(JsonReader OHHBENOLPAE, Type ODHJIEMHPHD, object CMFFOBHOCKM, JsonSerializer BMKNJFOIIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50C02E0", Offset = "0x50BF4E0", VA = "0x1850C02E0", Slot = "4")]
	public override void WriteJson(JsonWriter GDEDILINNBI, object MLCDCHNOCFI, JsonSerializer BMKNJFOIIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C97360", Offset = "0x4C96560", VA = "0x184C97360")]
	internal LEEGFKFEDHB(Func<Type, bool> HKMDFLNMMNH, Action<JsonWriter, T> EBEMNKLFPLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LJINGELEFJG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38BC680", Offset = "0x38BB880", VA = "0x1838BC680")]
	public static LEEGFKFEDHB<T> OIKMHICCLEP<T>(Action<JsonWriter, T> EBEMNKLFPLJ, PAMJPCKGBHA PEPCCEOLOKH = PAMJPCKGBHA.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GGKKJECCPEF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] PDAKPIPFOOE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter KECDAABCBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3AD0", Offset = "0x7DE2CD0", VA = "0x187DE3AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter HBKBHHEKFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3B20", Offset = "0x7DE2D20", VA = "0x187DE3B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter OOKHOKPCGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE39E0", Offset = "0x7DE2BE0", VA = "0x187DE39E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter NAJMHPGEOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3A80", Offset = "0x7DE2C80", VA = "0x187DE3A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter LNEGPNPOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3A30", Offset = "0x7DE2C30", VA = "0x187DE3A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ECCOJNBGKLB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3980", Offset = "0x7DE2B80", VA = "0x187DE3980")]
	public static string DPGIIPAIOJD(this object CEENCLMGJAM, JsonConverter[] GCLJBLAOINF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DNEBBPKAFGF<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> HKMDFLNMMNH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2760FD0", Offset = "0x27601D0", VA = "0x182760FD0", Slot = "6")]
	public override bool CanConvert(Type ODHJIEMHPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DDC0", Offset = "0x6A2CFC0", VA = "0x186A2DDC0", Slot = "5")]
	public override object ReadJson(JsonReader OHHBENOLPAE, Type ODHJIEMHPHD, object CMFFOBHOCKM, JsonSerializer BMKNJFOIIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DE90", Offset = "0x6A2D090", VA = "0x186A2DE90", Slot = "4")]
	public override void WriteJson(JsonWriter GDEDILINNBI, object MLCDCHNOCFI, JsonSerializer BMKNJFOIIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
	internal DNEBBPKAFGF(Func<Type, bool> HKMDFLNMMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LLILGPEOGKF
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38BE1E0", Offset = "0x38BD3E0", VA = "0x1838BE1E0")]
	public static DNEBBPKAFGF<T> OIKMHICCLEP<T>(PAMJPCKGBHA PEPCCEOLOKH = PAMJPCKGBHA.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class BNKLDCBJIMH : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> HKMDFLNMMNH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2760FD0", Offset = "0x27601D0", VA = "0x182760FD0", Slot = "6")]
	public override bool CanConvert(Type ODHJIEMHPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3870", Offset = "0x7DE2A70", VA = "0x187DE3870", Slot = "5")]
	public override object ReadJson(JsonReader OHHBENOLPAE, Type ODHJIEMHPHD, object CMFFOBHOCKM, JsonSerializer BMKNJFOIIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3910", Offset = "0x7DE2B10", VA = "0x187DE3910", Slot = "4")]
	public override void WriteJson(JsonWriter GDEDILINNBI, object MLCDCHNOCFI, JsonSerializer BMKNJFOIIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
	public BNKLDCBJIMH(Func<Type, bool> HKMDFLNMMNH)
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

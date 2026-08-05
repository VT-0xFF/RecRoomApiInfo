using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ILPDAKCCPAG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class CPPEBEDGCGC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3959D00", Offset = "0x3958300", VA = "0x183959D00")]
	public static Func<Type, bool> JMEOECDNFCK<T>(this ILPDAKCCPAG PIKMBNLEPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38C03A0", Offset = "0x38BE9A0", VA = "0x1838C03A0")]
	private static bool JNIMKFMCCCA<T>(Type GJMKDBPNFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x395A0E0", Offset = "0x39586E0", VA = "0x18395A0E0")]
	private static bool LJOAFLIHGCL<T>(Type GJMKDBPNFOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GEOIGHHMGCD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B4ACC0", Offset = "0x3B492C0", VA = "0x183B4ACC0")]
	public static string IKFNCCJIKGM<T>(T DANMPOCKLCI, string JMIBCOBLGAA = ", ", [Optional] T COMAGLLDBOM) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AD50", Offset = "0x3B49350", VA = "0x183B4AD50")]
	public static string KFNMCIDCMBE<T>(T DANMPOCKLCI, string JMIBCOBLGAA = ", ", params T[] ENMBMLPKKCD) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AA60", Offset = "0x3B49060", VA = "0x183B4AA60")]
	private static bool IBENJAIDOIB<T>(T[] ENMBMLPKKCD, T MGNCINIDNEO, IEqualityComparer<T> NJKFJEICBEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MJELJDLJIHJ<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> CHJJNKOMLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> NFDGHDGOBMO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29153E0", Offset = "0x29139E0", VA = "0x1829153E0", Slot = "6")]
	public override bool CanConvert(Type GJMKDBPNFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5610910", Offset = "0x560EF10", VA = "0x185610910", Slot = "5")]
	public override object ReadJson(JsonReader KMBIKKJCMFN, Type GJMKDBPNFOO, object BIKEPCPNLDG, JsonSerializer ABKNIBKILDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5611230", Offset = "0x560F830", VA = "0x185611230", Slot = "4")]
	public override void WriteJson(JsonWriter DCGAFNKBAGF, object KKGBKLFKCPO, JsonSerializer ABKNIBKILDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5078180", Offset = "0x5076780", VA = "0x185078180")]
	internal MJELJDLJIHJ(Func<Type, bool> CHJJNKOMLEH, Action<JsonWriter, T> NFDGHDGOBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GIFBGLFMLJO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3B4E820", Offset = "0x3B4CE20", VA = "0x183B4E820")]
	public static MJELJDLJIHJ<T> BFOPDLPDKBM<T>(Action<JsonWriter, T> NFDGHDGOBMO, ILPDAKCCPAG NDNLBPNGGOF = ILPDAKCCPAG.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NAJKJKJJNLH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] GIEFAJFLDNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter PMCPMLPELMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8114960", Offset = "0x8112F60", VA = "0x188114960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter BECPCDHOJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8114910", Offset = "0x8112F10", VA = "0x188114910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter NGNCGNBCEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8114A50", Offset = "0x8113050", VA = "0x188114A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter ALGJIOEKINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8114A00", Offset = "0x8113000", VA = "0x188114A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter JKBHIODKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81149B0", Offset = "0x8112FB0", VA = "0x1881149B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BPIFFOLOCLF
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81148B0", Offset = "0x8112EB0", VA = "0x1881148B0")]
	public static string HLNCLJEDJHL(this object PIKMBNLEPPK, JsonConverter[] BFAPBCEAKJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DMHFPEJDFNH<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> CHJJNKOMLEH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29153E0", Offset = "0x29139E0", VA = "0x1829153E0", Slot = "6")]
	public override bool CanConvert(Type GJMKDBPNFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D24940", Offset = "0x6D22F40", VA = "0x186D24940", Slot = "5")]
	public override object ReadJson(JsonReader KMBIKKJCMFN, Type GJMKDBPNFOO, object BIKEPCPNLDG, JsonSerializer ABKNIBKILDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D24A20", Offset = "0x6D23020", VA = "0x186D24A20", Slot = "4")]
	public override void WriteJson(JsonWriter DCGAFNKBAGF, object KKGBKLFKCPO, JsonSerializer ABKNIBKILDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
	internal DMHFPEJDFNH(Func<Type, bool> CHJJNKOMLEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NEGKEDLJHOM
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C93400", Offset = "0x3C91A00", VA = "0x183C93400")]
	public static DMHFPEJDFNH<T> BFOPDLPDKBM<T>(ILPDAKCCPAG NDNLBPNGGOF = ILPDAKCCPAG.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class BMBCMKAKLFE : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> CHJJNKOMLEH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29153E0", Offset = "0x29139E0", VA = "0x1829153E0", Slot = "6")]
	public override bool CanConvert(Type GJMKDBPNFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81147A0", Offset = "0x8112DA0", VA = "0x1881147A0", Slot = "5")]
	public override object ReadJson(JsonReader KMBIKKJCMFN, Type GJMKDBPNFOO, object BIKEPCPNLDG, JsonSerializer ABKNIBKILDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8114840", Offset = "0x8112E40", VA = "0x188114840", Slot = "4")]
	public override void WriteJson(JsonWriter DCGAFNKBAGF, object KKGBKLFKCPO, JsonSerializer ABKNIBKILDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
	public BMBCMKAKLFE(Func<Type, bool> CHJJNKOMLEH)
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

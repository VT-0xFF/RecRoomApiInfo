using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GFKANENKHPG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class PBOBCIAIMHO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x366C3C0", Offset = "0x366B7C0", VA = "0x18366C3C0")]
	public static Func<Type, bool> NFMJAFHFIOE<T>(this GFKANENKHPG IIICNLIAPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3278E40", Offset = "0x3278240", VA = "0x183278E40")]
	private static bool BAFHNBBJAML<T>(Type DIKJKPHGOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x366BFA0", Offset = "0x366B3A0", VA = "0x18366BFA0")]
	private static bool DANGCPOFFKD<T>(Type DIKJKPHGOEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NKFNOGLICOP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36288B0", Offset = "0x3627CB0", VA = "0x1836288B0")]
	public static string KNIKMKFHFMC<T>(T BJDHLMBEIKG, string PEGIOMLBJCG = ", ", [Optional] T CIKOELCEFFM) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3628950", Offset = "0x3627D50", VA = "0x183628950")]
	public static string NLHELPNOOEO<T>(T BJDHLMBEIKG, string PEGIOMLBJCG = ", ", params T[] ODGIPJPMIJB) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3628C10", Offset = "0x3628010", VA = "0x183628C10")]
	private static bool NPHPOKJDCFF<T>(T[] ODGIPJPMIJB, T KFEJIDFAIID, IEqualityComparer<T> HMLMHCLAIJJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MHBFEGHMOPG<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> LEANFCECJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> FKNGENIGPNM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E00070", Offset = "0x4DFF470", VA = "0x184E00070", Slot = "6")]
	public override bool CanConvert(Type DIKJKPHGOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E00240", Offset = "0x4DFF640", VA = "0x184E00240", Slot = "5")]
	public override object ReadJson(JsonReader AENCLAHFBDP, Type DIKJKPHGOEG, object LANBFFGLEHJ, JsonSerializer PLMEPNACBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E00A90", Offset = "0x4DFFE90", VA = "0x184E00A90", Slot = "4")]
	public override void WriteJson(JsonWriter MGKMPBCECKN, object PEBNJNGMMHE, JsonSerializer PLMEPNACBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4874990", Offset = "0x4873D90", VA = "0x184874990")]
	internal MHBFEGHMOPG(Func<Type, bool> LEANFCECJKF, Action<JsonWriter, T> FKNGENIGPNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EJOGBDBAAIK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3312160", Offset = "0x3311560", VA = "0x183312160")]
	public static MHBFEGHMOPG<T> KMDIICJFNJF<T>(Action<JsonWriter, T> FKNGENIGPNM, GFKANENKHPG ENOONOOIFHG = GFKANENKHPG.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LLBDCJCPLIG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] KMKKDOPEGHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter ONKFPJFKEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77048C0", Offset = "0x7703CC0", VA = "0x1877048C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter CJLJDNJGBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7704910", Offset = "0x7703D10", VA = "0x187704910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter BCFAEIOLDAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7704820", Offset = "0x7703C20", VA = "0x187704820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter INNPLLIIDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7704870", Offset = "0x7703C70", VA = "0x187704870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter OLHBNFDHMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77047D0", Offset = "0x7703BD0", VA = "0x1877047D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CPAMIBFPPHG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7704660", Offset = "0x7703A60", VA = "0x187704660")]
	public static string LNFNPNNCMAC(this object IIICNLIAPBJ, JsonConverter[] PNMKFOFKOHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DDMGPHACPNB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> LEANFCECJKF;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E00070", Offset = "0x4DFF470", VA = "0x184E00070", Slot = "6")]
	public override bool CanConvert(Type DIKJKPHGOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63E9A00", Offset = "0x63E8E00", VA = "0x1863E9A00", Slot = "5")]
	public override object ReadJson(JsonReader AENCLAHFBDP, Type DIKJKPHGOEG, object LANBFFGLEHJ, JsonSerializer PLMEPNACBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63E9AD0", Offset = "0x63E8ED0", VA = "0x1863E9AD0", Slot = "4")]
	public override void WriteJson(JsonWriter MGKMPBCECKN, object PEBNJNGMMHE, JsonSerializer PLMEPNACBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
	internal DDMGPHACPNB(Func<Type, bool> LEANFCECJKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class PFFGCJLBIPF
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x366E9E0", Offset = "0x366DDE0", VA = "0x18366E9E0")]
	public static DDMGPHACPNB<T> KMDIICJFNJF<T>(GFKANENKHPG ENOONOOIFHG = GFKANENKHPG.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class DCOEGKEBIMH : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> LEANFCECJKF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E00070", Offset = "0x4DFF470", VA = "0x184E00070", Slot = "6")]
	public override bool CanConvert(Type DIKJKPHGOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77046C0", Offset = "0x7703AC0", VA = "0x1877046C0", Slot = "5")]
	public override object ReadJson(JsonReader AENCLAHFBDP, Type DIKJKPHGOEG, object LANBFFGLEHJ, JsonSerializer PLMEPNACBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7704760", Offset = "0x7703B60", VA = "0x187704760", Slot = "4")]
	public override void WriteJson(JsonWriter MGKMPBCECKN, object PEBNJNGMMHE, JsonSerializer PLMEPNACBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
	public DCOEGKEBIMH(Func<Type, bool> LEANFCECJKF)
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

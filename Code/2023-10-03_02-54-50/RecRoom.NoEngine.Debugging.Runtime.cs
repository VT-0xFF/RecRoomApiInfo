using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IOPGMDCCFMO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class GNFCOJNBNKN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2385440", Offset = "0x2383C40", VA = "0x182385440")]
	public static Func<Type, bool> JGLNFPHDMFK<T>(this IOPGMDCCFMO CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x235C730", Offset = "0x235AF30", VA = "0x18235C730")]
	private static bool IENHIFMNBAN<T>(Type AJNPDAOMCIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2385820", Offset = "0x2384020", VA = "0x182385820")]
	private static bool OCJIMKEOGIE<T>(Type AJNPDAOMCIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class EHNCOLKMFHE<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> MOFLCDNMMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> HGLIEHKNFLP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2FF8920", Offset = "0x2FF7120", VA = "0x182FF8920", Slot = "6")]
	public override bool CanConvert(Type AJNPDAOMCIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FF8BF0", Offset = "0x2FF73F0", VA = "0x182FF8BF0", Slot = "5")]
	public override object ReadJson(JsonReader PBFIJMOIIIO, Type AJNPDAOMCIO, object CKCCBMBIFFA, JsonSerializer DKBOLDMDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9270", Offset = "0x2FF7A70", VA = "0x182FF9270", Slot = "4")]
	public override void WriteJson(JsonWriter OPKLFJAIALA, object IFKKLLBODIE, JsonSerializer DKBOLDMDFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1F130C0", Offset = "0x1F118C0", VA = "0x181F130C0")]
	internal EHNCOLKMFHE(Func<Type, bool> MOFLCDNMMJJ, Action<JsonWriter, T> HGLIEHKNFLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NOCOCIBKEGD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24D9980", Offset = "0x24D8180", VA = "0x1824D9980")]
	public static EHNCOLKMFHE<T> MJLGMKKAMEE<T>(Action<JsonWriter, T> HGLIEHKNFLP, IOPGMDCCFMO DBEBBECPFAG = IOPGMDCCFMO.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IHMCMEOCKEB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] FPJNCBCALEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter HGLJNAAPPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ED90", Offset = "0x5D1D590", VA = "0x185D1ED90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter BKAAHPGHNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ED40", Offset = "0x5D1D540", VA = "0x185D1ED40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter CEGOFNPKFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ECF0", Offset = "0x5D1D4F0", VA = "0x185D1ECF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter HLMHFEIHJML
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EC50", Offset = "0x5D1D450", VA = "0x185D1EC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter PMGGOBMHJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ECA0", Offset = "0x5D1D4A0", VA = "0x185D1ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PPMPEJOIKJI
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F330", Offset = "0x5D1DB30", VA = "0x185D1F330")]
	public static string INHJLHHPHJJ(this object CLEGCKJMIEA, JsonConverter[] OMLAPGDMGNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class IHBLMAFCLEB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> MOFLCDNMMJJ;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2FF8920", Offset = "0x2FF7120", VA = "0x182FF8920", Slot = "6")]
	public override bool CanConvert(Type AJNPDAOMCIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3662CD0", Offset = "0x36614D0", VA = "0x183662CD0", Slot = "5")]
	public override object ReadJson(JsonReader PBFIJMOIIIO, Type AJNPDAOMCIO, object CKCCBMBIFFA, JsonSerializer DKBOLDMDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3662DB0", Offset = "0x36615B0", VA = "0x183662DB0", Slot = "4")]
	public override void WriteJson(JsonWriter OPKLFJAIALA, object IFKKLLBODIE, JsonSerializer DKBOLDMDFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
	internal IHBLMAFCLEB(Func<Type, bool> MOFLCDNMMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DJLOADELEOF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x222BB60", Offset = "0x222A360", VA = "0x18222BB60")]
	public static IHBLMAFCLEB<T> MJLGMKKAMEE<T>(IOPGMDCCFMO DBEBBECPFAG = IOPGMDCCFMO.Assignable)
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

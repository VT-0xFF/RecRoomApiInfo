using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum DDEDKILAPHL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class DGDOGFOKDKC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2230700", Offset = "0x222FB00", VA = "0x182230700")]
	public static Func<Type, bool> EPPEIFAACKM<T>(this DDEDKILAPHL LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x21A0CF0", Offset = "0x21A00F0", VA = "0x1821A0CF0")]
	private static bool GHCCEBILDKO<T>(Type AFPOIHKNAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2230AE0", Offset = "0x222FEE0", VA = "0x182230AE0")]
	private static bool MLMLHPJMDAA<T>(Type AFPOIHKNAGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class GIOBBJNBOIA<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> KNIJJIGJFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> PEOFAINLBLC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x34C6920", Offset = "0x34C5D20", VA = "0x1834C6920", Slot = "6")]
	public override bool CanConvert(Type AFPOIHKNAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34C6950", Offset = "0x34C5D50", VA = "0x1834C6950", Slot = "5")]
	public override object ReadJson(JsonReader IOJEJAFBOHN, Type AFPOIHKNAGM, object DAFBCHEGMDD, JsonSerializer HOGACIGOPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x34C6A30", Offset = "0x34C5E30", VA = "0x1834C6A30", Slot = "4")]
	public override void WriteJson(JsonWriter MKIOBJMIBCN, object EOHMJBFGDPD, JsonSerializer HOGACIGOPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x34C6B60", Offset = "0x34C5F60", VA = "0x1834C6B60")]
	internal GIOBBJNBOIA(Func<Type, bool> KNIJJIGJFLE, Action<JsonWriter, T> PEOFAINLBLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JHMGJHHBKFK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x23F3C70", Offset = "0x23F3070", VA = "0x1823F3C70")]
	public static GIOBBJNBOIA<T> LJCGEPFBFCG<T>(Action<JsonWriter, T> PEOFAINLBLC, DDEDKILAPHL ELAEECEHAIF = DDEDKILAPHL.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BKPPAGGGINM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] IAKPCLICNKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter PBEOOJDFKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDAB0", Offset = "0x5CFCEB0", VA = "0x185CFDAB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter DMLHOFPLAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDBA0", Offset = "0x5CFCFA0", VA = "0x185CFDBA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter CENDMMIPILK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDB00", Offset = "0x5CFCF00", VA = "0x185CFDB00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter MCANFLDGCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDB50", Offset = "0x5CFCF50", VA = "0x185CFDB50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter AGJLEMLCOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDBF0", Offset = "0x5CFCFF0", VA = "0x185CFDBF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JGEOLOCJNAL
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE190", Offset = "0x5CFD590", VA = "0x185CFE190")]
	public static string GOGAGPNNGEL(this object LDMHFMNLDHG, JsonConverter[] AHLPFNCKADL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class CKHPIAPMFFI<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> KNIJJIGJFLE;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34C6920", Offset = "0x34C5D20", VA = "0x1834C6920", Slot = "6")]
	public override bool CanConvert(Type AFPOIHKNAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1FD0", Offset = "0x4AE13D0", VA = "0x184AE1FD0", Slot = "5")]
	public override object ReadJson(JsonReader IOJEJAFBOHN, Type AFPOIHKNAGM, object DAFBCHEGMDD, JsonSerializer HOGACIGOPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4AE20B0", Offset = "0x4AE14B0", VA = "0x184AE20B0", Slot = "4")]
	public override void WriteJson(JsonWriter MKIOBJMIBCN, object EOHMJBFGDPD, JsonSerializer HOGACIGOPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
	internal CKHPIAPMFFI(Func<Type, bool> KNIJJIGJFLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PGPDJIJDBDA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2509D40", Offset = "0x2509140", VA = "0x182509D40")]
	public static CKHPIAPMFFI<T> LJCGEPFBFCG<T>(DDEDKILAPHL ELAEECEHAIF = DDEDKILAPHL.Assignable)
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

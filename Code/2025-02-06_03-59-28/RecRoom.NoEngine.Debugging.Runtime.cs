using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GDOILFAKIGN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class HIJOJPJEBKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x32D6DD0", Offset = "0x32D5BD0", VA = "0x1832D6DD0")]
	public static Func<Type, bool> AOENJGAKAGH<T>(this GDOILFAKIGN DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3094C60", Offset = "0x3093A60", VA = "0x183094C60")]
	private static bool GCACFAMGBOB<T>(Type EFLHIFHHPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x32D71B0", Offset = "0x32D5FB0", VA = "0x1832D71B0")]
	private static bool BOKNPDDPAEE<T>(Type EFLHIFHHPPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BFCJIDBJGPF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3070B80", Offset = "0x306F980", VA = "0x183070B80")]
	public static string KIBLOAFBFAL<T>(T LJGAMICHBPH, string AIIFFCELLKN = ", ", [Optional] T KBHDDKCAINE) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x30708C0", Offset = "0x306F6C0", VA = "0x1830708C0")]
	public static string INLHIACEGOG<T>(T LJGAMICHBPH, string AIIFFCELLKN = ", ", params T[] PECPMHFFLEE) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3070C20", Offset = "0x306FA20", VA = "0x183070C20")]
	private static bool NLFPJHILMDJ<T>(T[] PECPMHFFLEE, T ACCBEMFKLOI, IEqualityComparer<T> LKDCBGBNMHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BBFMJINJGAH<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> OIACHHAEDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> KDBEILJHLKE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3F5E980", Offset = "0x3F5D780", VA = "0x183F5E980", Slot = "6")]
	public override bool CanConvert(Type EFLHIFHHPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x560F0B0", Offset = "0x560DEB0", VA = "0x18560F0B0", Slot = "5")]
	public override object ReadJson(JsonReader GGBMOFKDHMN, Type EFLHIFHHPPE, object IMPPLFDBNDE, JsonSerializer OJBOLHCJOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x560F970", Offset = "0x560E770", VA = "0x18560F970", Slot = "4")]
	public override void WriteJson(JsonWriter FEBAHPCKNJP, object IPHILEOFJLB, JsonSerializer OJBOLHCJOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x45311E0", Offset = "0x452FFE0", VA = "0x1845311E0")]
	internal BBFMJINJGAH(Func<Type, bool> OIACHHAEDKF, Action<JsonWriter, T> KDBEILJHLKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CPDOFBFBFIL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3114C90", Offset = "0x3113A90", VA = "0x183114C90")]
	public static BBFMJINJGAH<T> MKHEJJEDOII<T>(Action<JsonWriter, T> KDBEILJHLKE, GDOILFAKIGN NJAKHIPMBAE = GDOILFAKIGN.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GKNEMCKCBNC
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] IKIPDIONMNH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter NEJFEEKNLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x738C210", Offset = "0x738B010", VA = "0x18738C210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter LKNKMOMDDNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x738C120", Offset = "0x738AF20", VA = "0x18738C120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter OOHKJAIKGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x738C170", Offset = "0x738AF70", VA = "0x18738C170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter LIGIKENJMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x738C260", Offset = "0x738B060", VA = "0x18738C260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter IECCFIHNCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x738C1C0", Offset = "0x738AFC0", VA = "0x18738C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LGMMENKMNCH
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x738C810", Offset = "0x738B610", VA = "0x18738C810")]
	public static string NEIAGJPFFIB(this object DJAJDIFOIHP, JsonConverter[] BLEFKLJOFCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class EAFMCAGLCDB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> OIACHHAEDKF;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F5E980", Offset = "0x3F5D780", VA = "0x183F5E980", Slot = "6")]
	public override bool CanConvert(Type EFLHIFHHPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3F5E9B0", Offset = "0x3F5D7B0", VA = "0x183F5E9B0", Slot = "5")]
	public override object ReadJson(JsonReader GGBMOFKDHMN, Type EFLHIFHHPPE, object IMPPLFDBNDE, JsonSerializer OJBOLHCJOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F5EA80", Offset = "0x3F5D880", VA = "0x183F5EA80", Slot = "4")]
	public override void WriteJson(JsonWriter FEBAHPCKNJP, object IPHILEOFJLB, JsonSerializer OJBOLHCJOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
	internal EAFMCAGLCDB(Func<Type, bool> OIACHHAEDKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NCNKHKOINJH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3455630", Offset = "0x3454430", VA = "0x183455630")]
	public static EAFMCAGLCDB<T> MKHEJJEDOII<T>(GDOILFAKIGN NJAKHIPMBAE = GDOILFAKIGN.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class DCHGMGJOCLL : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> OIACHHAEDKF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3F5E980", Offset = "0x3F5D780", VA = "0x183F5E980", Slot = "6")]
	public override bool CanConvert(Type EFLHIFHHPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x738C010", Offset = "0x738AE10", VA = "0x18738C010", Slot = "5")]
	public override object ReadJson(JsonReader GGBMOFKDHMN, Type EFLHIFHHPPE, object IMPPLFDBNDE, JsonSerializer OJBOLHCJOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x738C0B0", Offset = "0x738AEB0", VA = "0x18738C0B0", Slot = "4")]
	public override void WriteJson(JsonWriter FEBAHPCKNJP, object IPHILEOFJLB, JsonSerializer OJBOLHCJOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
	public DCHGMGJOCLL(Func<Type, bool> OIACHHAEDKF)
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

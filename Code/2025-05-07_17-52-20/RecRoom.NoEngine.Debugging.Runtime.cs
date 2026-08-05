using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JJKPCHLOOFI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class ABHODOFGICG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F61EE0", Offset = "0x3F60EE0", VA = "0x183F61EE0")]
	public static Func<Type, bool> LDLDMNIHLEJ<T>(this JJKPCHLOOFI OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3838760", Offset = "0x3837760", VA = "0x183838760")]
	private static bool EFMMJEEECKE<T>(Type GENJGIKLGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F622C0", Offset = "0x3F612C0", VA = "0x183F622C0")]
	private static bool PNJIOKAPBLK<T>(Type GENJGIKLGPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NLOAPOJMGDO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3999C20", Offset = "0x3998C20", VA = "0x183999C20")]
	public static string JCPAKBOHJEP<T>(T PCHMHBNEGIN, string NGGGJIEBHDG = ", ", [Optional] T JMMNJNFGHEP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3999960", Offset = "0x3998960", VA = "0x183999960")]
	public static string DJEDJFMEOKH<T>(T PCHMHBNEGIN, string NGGGJIEBHDG = ", ", params T[] FODNADOJPAL) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3999700", Offset = "0x3998700", VA = "0x183999700")]
	private static bool AINDHBPABMJ<T>(T[] FODNADOJPAL, T CPNOKLLGBPJ, IEqualityComparer<T> EFGNCEEFOAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LACMMKIKABJ<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> HKFNAKOMHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> ADEFOFNAPAO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x272E390", Offset = "0x272D390", VA = "0x18272E390", Slot = "6")]
	public override bool CanConvert(Type GENJGIKLGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50A1140", Offset = "0x50A0140", VA = "0x1850A1140", Slot = "5")]
	public override object ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, object ELCIIJEPMCL, JsonSerializer AKEPDIDIPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50A19A0", Offset = "0x50A09A0", VA = "0x1850A19A0", Slot = "4")]
	public override void WriteJson(JsonWriter NFOCFJIIPHM, object OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F65A90", Offset = "0x4F64A90", VA = "0x184F65A90")]
	internal LACMMKIKABJ(Func<Type, bool> HKFNAKOMHFE, Action<JsonWriter, T> ADEFOFNAPAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KMOCKPEPHKJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38F35A0", Offset = "0x38F25A0", VA = "0x1838F35A0")]
	public static LACMMKIKABJ<T> ACADPGMDEBE<T>(Action<JsonWriter, T> ADEFOFNAPAO, JJKPCHLOOFI MDIOCGCLDHE = JJKPCHLOOFI.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ANONJIAIKEM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] JBMMPJAGPJN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter KHNPHEDEIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A780", Offset = "0x7D89780", VA = "0x187D8A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter GDGDALJIAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A870", Offset = "0x7D89870", VA = "0x187D8A870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter HLFLLJEJIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A7D0", Offset = "0x7D897D0", VA = "0x187D8A7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter DEGDPMNEEON
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A820", Offset = "0x7D89820", VA = "0x187D8A820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter LHAFCBNJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A8C0", Offset = "0x7D898C0", VA = "0x187D8A8C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NIOCCHDPECF
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AF80", Offset = "0x7D89F80", VA = "0x187D8AF80")]
	public static string GGDPAGAAIFJ(this object OCACDKEJIIB, JsonConverter[] IIEBDBIEGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LAGHHPBIBGG<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> HKFNAKOMHFE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x272E390", Offset = "0x272D390", VA = "0x18272E390", Slot = "6")]
	public override bool CanConvert(Type GENJGIKLGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x50A2080", Offset = "0x50A1080", VA = "0x1850A2080", Slot = "5")]
	public override object ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, object ELCIIJEPMCL, JsonSerializer AKEPDIDIPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50A2150", Offset = "0x50A1150", VA = "0x1850A2150", Slot = "4")]
	public override void WriteJson(JsonWriter NFOCFJIIPHM, object OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
	internal LAGHHPBIBGG(Func<Type, bool> HKFNAKOMHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EKJEAGDMOJK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36E49B0", Offset = "0x36E39B0", VA = "0x1836E49B0")]
	public static LAGHHPBIBGG<T> ACADPGMDEBE<T>(JJKPCHLOOFI MDIOCGCLDHE = JJKPCHLOOFI.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class GAAPEFNGNDJ : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> HKFNAKOMHFE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x272E390", Offset = "0x272D390", VA = "0x18272E390", Slot = "6")]
	public override bool CanConvert(Type GENJGIKLGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AE70", Offset = "0x7D89E70", VA = "0x187D8AE70", Slot = "5")]
	public override object ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, object ELCIIJEPMCL, JsonSerializer AKEPDIDIPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AF10", Offset = "0x7D89F10", VA = "0x187D8AF10", Slot = "4")]
	public override void WriteJson(JsonWriter NFOCFJIIPHM, object OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
	public GAAPEFNGNDJ(Func<Type, bool> HKFNAKOMHFE)
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

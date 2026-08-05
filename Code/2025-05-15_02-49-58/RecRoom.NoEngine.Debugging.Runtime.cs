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
	[Cpp2IlInjected.Address(RVA = "0x3FB8CE0", Offset = "0x3FB72E0", VA = "0x183FB8CE0")]
	public static Func<Type, bool> LDLDMNIHLEJ<T>(this JJKPCHLOOFI OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3857070", Offset = "0x3855670", VA = "0x183857070")]
	private static bool EFMMJEEECKE<T>(Type GENJGIKLGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3FB90C0", Offset = "0x3FB76C0", VA = "0x183FB90C0")]
	private static bool PNJIOKAPBLK<T>(Type GENJGIKLGPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NLOAPOJMGDO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x39B61D0", Offset = "0x39B47D0", VA = "0x1839B61D0")]
	public static string JCPAKBOHJEP<T>(T PCHMHBNEGIN, string NGGGJIEBHDG = ", ", [Optional] T JMMNJNFGHEP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39B5F10", Offset = "0x39B4510", VA = "0x1839B5F10")]
	public static string DJEDJFMEOKH<T>(T PCHMHBNEGIN, string NGGGJIEBHDG = ", ", params T[] FODNADOJPAL) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39B5CB0", Offset = "0x39B42B0", VA = "0x1839B5CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x272F700", Offset = "0x272DD00", VA = "0x18272F700", Slot = "6")]
	public override bool CanConvert(Type GENJGIKLGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50D0E40", Offset = "0x50CF440", VA = "0x1850D0E40", Slot = "5")]
	public override object ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, object ELCIIJEPMCL, JsonSerializer AKEPDIDIPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50D1690", Offset = "0x50CFC90", VA = "0x1850D1690", Slot = "4")]
	public override void WriteJson(JsonWriter NFOCFJIIPHM, object OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5066D00", Offset = "0x5065300", VA = "0x185066D00")]
	internal LACMMKIKABJ(Func<Type, bool> HKFNAKOMHFE, Action<JsonWriter, T> ADEFOFNAPAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KMOCKPEPHKJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3911B70", Offset = "0x3910170", VA = "0x183911B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7BF10", Offset = "0x7D7A510", VA = "0x187D7BF10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7C000", Offset = "0x7D7A600", VA = "0x187D7C000")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7BF60", Offset = "0x7D7A560", VA = "0x187D7BF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7BFB0", Offset = "0x7D7A5B0", VA = "0x187D7BFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7C050", Offset = "0x7D7A650", VA = "0x187D7C050")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D7C6C0", Offset = "0x7D7ACC0", VA = "0x187D7C6C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x272F700", Offset = "0x272DD00", VA = "0x18272F700", Slot = "6")]
	public override bool CanConvert(Type GENJGIKLGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x50D1D30", Offset = "0x50D0330", VA = "0x1850D1D30", Slot = "5")]
	public override object ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, object ELCIIJEPMCL, JsonSerializer AKEPDIDIPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50D1E00", Offset = "0x50D0400", VA = "0x1850D1E00", Slot = "4")]
	public override void WriteJson(JsonWriter NFOCFJIIPHM, object OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
	internal LAGHHPBIBGG(Func<Type, bool> HKFNAKOMHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EKJEAGDMOJK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3702600", Offset = "0x3700C00", VA = "0x183702600")]
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
	[Cpp2IlInjected.Address(RVA = "0x272F700", Offset = "0x272DD00", VA = "0x18272F700", Slot = "6")]
	public override bool CanConvert(Type GENJGIKLGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C5B0", Offset = "0x7D7ABB0", VA = "0x187D7C5B0", Slot = "5")]
	public override object ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, object ELCIIJEPMCL, JsonSerializer AKEPDIDIPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C650", Offset = "0x7D7AC50", VA = "0x187D7C650", Slot = "4")]
	public override void WriteJson(JsonWriter NFOCFJIIPHM, object OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AFNMOBMKDHH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class BMDCAPLFFDC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x33869F0", Offset = "0x3385DF0", VA = "0x1833869F0")]
	public static Func<Type, bool> CFDMMGJIHBP<T>(this AFNMOBMKDHH JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3376400", Offset = "0x3375800", VA = "0x183376400")]
	private static bool FKFCFEBAENN<T>(Type NILLICCLHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3386DD0", Offset = "0x33861D0", VA = "0x183386DD0")]
	private static bool MJGLIBFGBKF<T>(Type NILLICCLHIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AFPFCBDJNGC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C830", Offset = "0x3D6BC30", VA = "0x183D6C830")]
	public static string BCCGNMABEGN<T>(T OEAPKNBFGIB, string JMENPDPJFNM = ", ", [Optional] T PFCPDJEHNAP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D6CB30", Offset = "0x3D6BF30", VA = "0x183D6CB30")]
	public static string MKIJPPJLCBF<T>(T OEAPKNBFGIB, string JMENPDPJFNM = ", ", params T[] BGCAKDPIGDG) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C8D0", Offset = "0x3D6BCD0", VA = "0x183D6C8D0")]
	private static bool HMIEFIADHEM<T>(T[] BGCAKDPIGDG, T JKBGMEDEBBN, IEqualityComparer<T> BJPBKLBLNPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ILNPKCBDLHB<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> INIKKKADHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> IGFKABJGHBG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x49F9120", Offset = "0x49F8520", VA = "0x1849F9120", Slot = "6")]
	public override bool CanConvert(Type NILLICCLHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x49F92F0", Offset = "0x49F86F0", VA = "0x1849F92F0", Slot = "5")]
	public override object ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, object IAGJKNIMAKN, JsonSerializer ILLAJGPAKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49F9910", Offset = "0x49F8D10", VA = "0x1849F9910", Slot = "4")]
	public override void WriteJson(JsonWriter CEAJPINGICH, object FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49F9DA0", Offset = "0x49F91A0", VA = "0x1849F9DA0")]
	internal ILNPKCBDLHB(Func<Type, bool> INIKKKADHFI, Action<JsonWriter, T> IGFKABJGHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MCDLGAHJONN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3714110", Offset = "0x3713510", VA = "0x183714110")]
	public static ILNPKCBDLHB<T> HBLBJMFGHFK<T>(Action<JsonWriter, T> IGFKABJGHBG, AFNMOBMKDHH LEDHINELCFL = AFNMOBMKDHH.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DLFPNLJDJDJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] BNKNLEKIIAJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter DEAIEJOOCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79A4600", Offset = "0x79A3A00", VA = "0x1879A4600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter LFKGJENCHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x79A46A0", Offset = "0x79A3AA0", VA = "0x1879A46A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter GLNCHIOGPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79A45B0", Offset = "0x79A39B0", VA = "0x1879A45B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter BGMBBBCMJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x79A46F0", Offset = "0x79A3AF0", VA = "0x1879A46F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter PJINMABBEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79A4650", Offset = "0x79A3A50", VA = "0x1879A4650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PMGEOAJHHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79A4DA0", Offset = "0x79A41A0", VA = "0x1879A4DA0")]
	public static string LCHIBOGNELL(this object JOCJBPPJMJJ, JsonConverter[] PCFFOBIIDDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class PNGMCCCFIOL<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> INIKKKADHFI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x49F9120", Offset = "0x49F8520", VA = "0x1849F9120", Slot = "6")]
	public override bool CanConvert(Type NILLICCLHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5326AE0", Offset = "0x5325EE0", VA = "0x185326AE0", Slot = "5")]
	public override object ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, object IAGJKNIMAKN, JsonSerializer ILLAJGPAKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5326BB0", Offset = "0x5325FB0", VA = "0x185326BB0", Slot = "4")]
	public override void WriteJson(JsonWriter CEAJPINGICH, object FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
	internal PNGMCCCFIOL(Func<Type, bool> INIKKKADHFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BBIACOEGFLK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3372100", Offset = "0x3371500", VA = "0x183372100")]
	public static PNGMCCCFIOL<T> HBLBJMFGHFK<T>(AFNMOBMKDHH LEDHINELCFL = AFNMOBMKDHH.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OHFNCGMKFHG : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> INIKKKADHFI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x49F9120", Offset = "0x49F8520", VA = "0x1849F9120", Slot = "6")]
	public override bool CanConvert(Type NILLICCLHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x79A4C90", Offset = "0x79A4090", VA = "0x1879A4C90", Slot = "5")]
	public override object ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, object IAGJKNIMAKN, JsonSerializer ILLAJGPAKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79A4D30", Offset = "0x79A4130", VA = "0x1879A4D30", Slot = "4")]
	public override void WriteJson(JsonWriter CEAJPINGICH, object FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
	public OHFNCGMKFHG(Func<Type, bool> INIKKKADHFI)
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

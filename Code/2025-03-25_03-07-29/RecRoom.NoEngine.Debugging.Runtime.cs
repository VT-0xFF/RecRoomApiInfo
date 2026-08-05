using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HMBBPKGNNJG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class IOEDCBPACJM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x365EF30", Offset = "0x365E330", VA = "0x18365EF30")]
	public static Func<Type, bool> ONCNEPMLPPH<T>(this HMBBPKGNNJG CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3439390", Offset = "0x3438790", VA = "0x183439390")]
	private static bool HEPLKLNICNL<T>(Type HOAMBGIHCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x365EB10", Offset = "0x365DF10", VA = "0x18365EB10")]
	private static bool BGJDCKJJPFD<T>(Type HOAMBGIHCIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GFCDMEDPMNO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x35BC410", Offset = "0x35BB810", VA = "0x1835BC410")]
	public static string EHIJELMJMIA<T>(T KBBLKNKJAHB, string GCDELEHCOEH = ", ", [Optional] T MBADHELIPJM) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x35BC4B0", Offset = "0x35BB8B0", VA = "0x1835BC4B0")]
	public static string KAEJJBMADDM<T>(T KBBLKNKJAHB, string GCDELEHCOEH = ", ", params T[] LBMELCKLPPK) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35BC1B0", Offset = "0x35BB5B0", VA = "0x1835BC1B0")]
	private static bool ABFOGIPALKO<T>(T[] LBMELCKLPPK, T GNABMNHJHFF, IEqualityComparer<T> JNJOJFOHKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class OCPBBCHLGOL<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> LOAFALMDPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> CMDAECNFCKB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB7A0", Offset = "0x4CCABA0", VA = "0x184CCB7A0", Slot = "6")]
	public override bool CanConvert(Type HOAMBGIHCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5148140", Offset = "0x5147540", VA = "0x185148140", Slot = "5")]
	public override object ReadJson(JsonReader KILJCGGJECG, Type HOAMBGIHCIG, object OGJDCDCHPNF, JsonSerializer DKOOENLAMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5148740", Offset = "0x5147B40", VA = "0x185148740", Slot = "4")]
	public override void WriteJson(JsonWriter NACIMEJMHHK, object FIIKLGCIAGG, JsonSerializer DKOOENLAMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B003E0", Offset = "0x4AFF7E0", VA = "0x184B003E0")]
	internal OCPBBCHLGOL(Func<Type, bool> LOAFALMDPDH, Action<JsonWriter, T> CMDAECNFCKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EMEOBDGCEHC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3447FE0", Offset = "0x34473E0", VA = "0x183447FE0")]
	public static OCPBBCHLGOL<T> AFLKMMODJAC<T>(Action<JsonWriter, T> CMDAECNFCKB, HMBBPKGNNJG AKDCNKFIAGF = HMBBPKGNNJG.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ALLLLADECJG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] PMLIOLBKHPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter JMLMLNOBKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7932E70", Offset = "0x7932270", VA = "0x187932E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter PDMPBFACOID
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7932D30", Offset = "0x7932130", VA = "0x187932D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter MBNCOLJHPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7932DD0", Offset = "0x79321D0", VA = "0x187932DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter NECEEOKEMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7932D80", Offset = "0x7932180", VA = "0x187932D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter HABALCPMBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7932E20", Offset = "0x7932220", VA = "0x187932E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ACMKECLHAHB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7932CD0", Offset = "0x79320D0", VA = "0x187932CD0")]
	public static string PIMEMJFHDPH(this object CAMFIHKHJNG, JsonConverter[] OGICOCJMJNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KDOJJAFNBMF<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> LOAFALMDPDH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB7A0", Offset = "0x4CCABA0", VA = "0x184CCB7A0", Slot = "6")]
	public override bool CanConvert(Type HOAMBGIHCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB7D0", Offset = "0x4CCABD0", VA = "0x184CCB7D0", Slot = "5")]
	public override object ReadJson(JsonReader KILJCGGJECG, Type HOAMBGIHCIG, object OGJDCDCHPNF, JsonSerializer DKOOENLAMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB8A0", Offset = "0x4CCACA0", VA = "0x184CCB8A0", Slot = "4")]
	public override void WriteJson(JsonWriter NACIMEJMHHK, object FIIKLGCIAGG, JsonSerializer DKOOENLAMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
	internal KDOJJAFNBMF(Func<Type, bool> LOAFALMDPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CKFLFLBCLFC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33C26E0", Offset = "0x33C1AE0", VA = "0x1833C26E0")]
	public static KDOJJAFNBMF<T> AFLKMMODJAC<T>(HMBBPKGNNJG AKDCNKFIAGF = HMBBPKGNNJG.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KMFNMBHJKAP : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> LOAFALMDPDH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB7A0", Offset = "0x4CCABA0", VA = "0x184CCB7A0", Slot = "6")]
	public override bool CanConvert(Type HOAMBGIHCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x79333E0", Offset = "0x79327E0", VA = "0x1879333E0", Slot = "5")]
	public override object ReadJson(JsonReader KILJCGGJECG, Type HOAMBGIHCIG, object OGJDCDCHPNF, JsonSerializer DKOOENLAMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7933480", Offset = "0x7932880", VA = "0x187933480", Slot = "4")]
	public override void WriteJson(JsonWriter NACIMEJMHHK, object FIIKLGCIAGG, JsonSerializer DKOOENLAMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
	public KMFNMBHJKAP(Func<Type, bool> LOAFALMDPDH)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JCBKHIEKIEN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class NEOICHMCCKO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3B49140", Offset = "0x3B47940", VA = "0x183B49140")]
	public static Func<Type, bool> ABOANLAFODG<T>(this JCBKHIEKIEN DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37F6C00", Offset = "0x37F5400", VA = "0x1837F6C00")]
	private static bool LNJIJFJJJEF<T>(Type CEBILNINJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3B49520", Offset = "0x3B47D20", VA = "0x183B49520")]
	private static bool EEGCJHAMLJI<T>(Type CEBILNINJIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FIIFAELAPEB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x39BD5D0", Offset = "0x39BBDD0", VA = "0x1839BD5D0")]
	public static string NEKOPEPJGDD<T>(T IJLILEGPOCK, string EFKIABFDOKA = ", ", [Optional] T GJPLADDCFJL) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39BD310", Offset = "0x39BBB10", VA = "0x1839BD310")]
	public static string LAJMDJJOGPF<T>(T IJLILEGPOCK, string EFKIABFDOKA = ", ", params T[] MIIOELFLDKB) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39BD0B0", Offset = "0x39BB8B0", VA = "0x1839BD0B0")]
	private static bool EKFNNBDJCOD<T>(T[] MIIOELFLDKB, T KNDBAOCCLOM, IEqualityComparer<T> JPBEDJHBGMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NEMFILBJGDA<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> FIHAADOGEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> JIDJAHGGJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2818C70", Offset = "0x2817470", VA = "0x182818C70", Slot = "6")]
	public override bool CanConvert(Type CEBILNINJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x55B2780", Offset = "0x55B0F80", VA = "0x1855B2780", Slot = "5")]
	public override object ReadJson(JsonReader JEPFPDOKDAD, Type CEBILNINJIM, object ABJDBDDKHEI, JsonSerializer KDNIJMFFINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x55B2CC0", Offset = "0x55B14C0", VA = "0x1855B2CC0", Slot = "4")]
	public override void WriteJson(JsonWriter LFDMHEHCHCC, object MGONBEDEDON, JsonSerializer KDNIJMFFINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F3E8B0", Offset = "0x4F3D0B0", VA = "0x184F3E8B0")]
	internal NEMFILBJGDA(Func<Type, bool> FIHAADOGEOG, Action<JsonWriter, T> JIDJAHGGJOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LOIEHJDMEMC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE0A0", Offset = "0x3AAC8A0", VA = "0x183AAE0A0")]
	public static NEMFILBJGDA<T> CCPKJDCALBG<T>(Action<JsonWriter, T> JIDJAHGGJOJ, JCBKHIEKIEN JGNDGIIAIBN = JCBKHIEKIEN.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BEEOMPGFMBA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] PNAENJCKDBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter FPFAGPANEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8109A10", Offset = "0x8108210", VA = "0x188109A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter KANILIEOLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8109AB0", Offset = "0x81082B0", VA = "0x188109AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter HFHGHEALKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8109A60", Offset = "0x8108260", VA = "0x188109A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter JENACNDPMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8109B00", Offset = "0x8108300", VA = "0x188109B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter NNGNHNFKKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81099C0", Offset = "0x81081C0", VA = "0x1881099C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OGPBAAKJFMG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x810A170", Offset = "0x8108970", VA = "0x18810A170")]
	public static string ONDAOGFBHMB(this object DKBBJFIDEGB, JsonConverter[] ONLNBJKJEEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LHLANKJOCAA<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> FIHAADOGEOG;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2818C70", Offset = "0x2817470", VA = "0x182818C70", Slot = "6")]
	public override bool CanConvert(Type CEBILNINJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x52FDBB0", Offset = "0x52FC3B0", VA = "0x1852FDBB0", Slot = "5")]
	public override object ReadJson(JsonReader JEPFPDOKDAD, Type CEBILNINJIM, object ABJDBDDKHEI, JsonSerializer KDNIJMFFINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x52FDC90", Offset = "0x52FC490", VA = "0x1852FDC90", Slot = "4")]
	public override void WriteJson(JsonWriter LFDMHEHCHCC, object MGONBEDEDON, JsonSerializer KDNIJMFFINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
	internal LHLANKJOCAA(Func<Type, bool> FIHAADOGEOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CIAKHDGHALD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37B8000", Offset = "0x37B6800", VA = "0x1837B8000")]
	public static LHLANKJOCAA<T> CCPKJDCALBG<T>(JCBKHIEKIEN JGNDGIIAIBN = JCBKHIEKIEN.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class MFMALECGMIH : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> FIHAADOGEOG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2818C70", Offset = "0x2817470", VA = "0x182818C70", Slot = "6")]
	public override bool CanConvert(Type CEBILNINJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x810A060", Offset = "0x8108860", VA = "0x18810A060", Slot = "5")]
	public override object ReadJson(JsonReader JEPFPDOKDAD, Type CEBILNINJIM, object ABJDBDDKHEI, JsonSerializer KDNIJMFFINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x810A100", Offset = "0x8108900", VA = "0x18810A100", Slot = "4")]
	public override void WriteJson(JsonWriter LFDMHEHCHCC, object MGONBEDEDON, JsonSerializer KDNIJMFFINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
	public MFMALECGMIH(Func<Type, bool> FIHAADOGEOG)
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

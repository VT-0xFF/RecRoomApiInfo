using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class HKJHPMCOGNL<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void DGKKEIDGOMJ(Utf8JsonReader GCOEALJJGEI);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E080", Offset = "0x4E2CE80", VA = "0x184E2E080", Slot = "27")]
	public override T Read(Utf8JsonReader DGMHJDFFMEI, Type PLCOPFFBAPF, JsonSerializerOptions LHBNHKOPIFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E270", Offset = "0x4E2D070", VA = "0x184E2E270", Slot = "28")]
	public override void Write(Utf8JsonWriter JAIJDFCBLCH, T BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void DIKGNFELLJL(Utf8JsonReader DGMHJDFFMEI, JsonSerializerOptions LHBNHKOPIFM, string EEMELICKMHH, T EHKDLJBBGDB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void FADHNJNAHFI(Utf8JsonWriter JAIJDFCBLCH, T BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x47D3410", Offset = "0x47D2210", VA = "0x1847D3410")]
	protected HKJHPMCOGNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HBGOKNAFPCD : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80FE150", Offset = "0x80FCF50", VA = "0x1880FE150")]
	public HBGOKNAFPCD(string EEMELICKMHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HENPOEPLICO<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E6D0", Offset = "0x4E1D4D0", VA = "0x184E1E6D0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader DGMHJDFFMEI, Type PLCOPFFBAPF, JsonSerializerOptions LHBNHKOPIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E8D0", Offset = "0x4E1D6D0", VA = "0x184E1E8D0", Slot = "28")]
	public override void Write(Utf8JsonWriter JAIJDFCBLCH, Dictionary<TKey, int> BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4D075F0", Offset = "0x4D063F0", VA = "0x184D075F0")]
	public HENPOEPLICO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GFIGDKLFCNH<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D7FCB0", Offset = "0x4D7EAB0", VA = "0x184D7FCB0", Slot = "27")]
	public override T[] Read(Utf8JsonReader DGMHJDFFMEI, Type PLCOPFFBAPF, JsonSerializerOptions LHBNHKOPIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D7FF90", Offset = "0x4D7ED90", VA = "0x184D7FF90", Slot = "28")]
	public override void Write(Utf8JsonWriter JAIJDFCBLCH, T[] BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x47F13B0", Offset = "0x47F01B0", VA = "0x1847F13B0")]
	protected GFIGDKLFCNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class OCPPGIBCIHD<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? COPEKAECGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA60490", Offset = "0xA5F290", VA = "0x180A60490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T IOKAEMMHJOD(float[] FEBLBJIINOM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] OOHJPFAIEAE(T BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5846F40", Offset = "0x5845D40", VA = "0x185846F40", Slot = "27")]
	public override T Read(Utf8JsonReader DGMHJDFFMEI, Type PLCOPFFBAPF, JsonSerializerOptions LHBNHKOPIFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5847E90", Offset = "0x5846C90", VA = "0x185847E90", Slot = "28")]
	public override void Write(Utf8JsonWriter JAIJDFCBLCH, T BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47F13B0", Offset = "0x47F01B0", VA = "0x1847F13B0")]
	protected OCPPGIBCIHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GGCJLACDKPG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80FDE20", Offset = "0x80FCC20", VA = "0x1880FDE20")]
	public static void IAJMAIJMMOL(this Utf8JsonWriter JAIJDFCBLCH, string EEMELICKMHH, bool BNECONOIKOE, bool JILABBLHNAO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80FDE00", Offset = "0x80FCC00", VA = "0x1880FDE00")]
	public static bool EPIFEIFJLHO(this Utf8JsonReader DGMHJDFFMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80FE0A0", Offset = "0x80FCEA0", VA = "0x1880FE0A0")]
	public static void OLNOEMDDLLI(this Utf8JsonWriter JAIJDFCBLCH, string EEMELICKMHH, int? BNECONOIKOE, int JILABBLHNAO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80FDE50", Offset = "0x80FCC50", VA = "0x1880FDE50")]
	public static void MKBIGMFKLGC(this Utf8JsonWriter JAIJDFCBLCH, string EEMELICKMHH, long? BNECONOIKOE, long JILABBLHNAO = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B82AB0", Offset = "0x3B818B0", VA = "0x183B82AB0")]
	public static void EHEHFGMMADC<T>(this Utf8JsonWriter JAIJDFCBLCH, string EEMELICKMHH, JsonSerializerOptions LHBNHKOPIFM, T HBLCHHJHKAF, T BEPLKNEKLMF) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80FDF00", Offset = "0x80FCD00", VA = "0x1880FDF00")]
	public static void NJLGBEHCKMM(this Utf8JsonWriter JAIJDFCBLCH, float BNECONOIKOE, int JMINBKBMCHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OCEFDICIIHH<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5845E00", Offset = "0x5844C00", VA = "0x185845E00", Slot = "27")]
	public override T Read(Utf8JsonReader DGMHJDFFMEI, Type PLCOPFFBAPF, JsonSerializerOptions LHBNHKOPIFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5845EB0", Offset = "0x5844CB0", VA = "0x185845EB0", Slot = "28")]
	public override void Write(Utf8JsonWriter JAIJDFCBLCH, T BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x48957D0", Offset = "0x48945D0", VA = "0x1848957D0")]
	public OCEFDICIIHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MKMMHKMIMIP : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EANKKPMAJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA5C510", Offset = "0xA5B310", VA = "0x180A5C510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA5C500", Offset = "0xA5B300", VA = "0x180A5C500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80FE1C0", Offset = "0x80FCFC0", VA = "0x1880FE1C0", Slot = "27")]
	public override float Read(Utf8JsonReader DGMHJDFFMEI, Type PLCOPFFBAPF, JsonSerializerOptions LHBNHKOPIFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80FE1D0", Offset = "0x80FCFD0", VA = "0x1880FE1D0", Slot = "28")]
	public override void Write(Utf8JsonWriter JAIJDFCBLCH, float BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80FE370", Offset = "0x80FD170", VA = "0x1880FE370")]
	public MKMMHKMIMIP()
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

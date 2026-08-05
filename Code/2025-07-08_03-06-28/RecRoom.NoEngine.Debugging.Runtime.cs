using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NNLDGNPIGGM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class KLAEBAPPKJL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C43E50", Offset = "0x3C42C50", VA = "0x183C43E50")]
	public static Func<Type, bool> IHOBNFGAPFN<T>(this NNLDGNPIGGM FEOFEEGOGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3936570", Offset = "0x3935370", VA = "0x183936570")]
	private static bool EELDFOPBKMG<T>(Type BMPFINLAMLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C44230", Offset = "0x3C43030", VA = "0x183C44230")]
	private static bool PAFPPOEJPGP<T>(Type BMPFINLAMLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NJCAEJFPLEM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B590", Offset = "0x3D0A390", VA = "0x183D0B590")]
	public static string JGHKDOMMEHB<T>(T HECBCEDKAOK, string CFOAFPFMLDG = ", ", [Optional] T JILABBLHNAO) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B620", Offset = "0x3D0A420", VA = "0x183D0B620")]
	public static string KICAOLNBBBH<T>(T HECBCEDKAOK, string CFOAFPFMLDG = ", ", params T[] HIONJMOCFOF) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B330", Offset = "0x3D0A130", VA = "0x183D0B330")]
	private static bool ENBNDNMLBJC<T>(T[] HIONJMOCFOF, T DLAOKGLPMLD, IEqualityComparer<T> JPJEBIEBIKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MIEOIACIKFE<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> IOFCEIODFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> HAPJAPHKOKH;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2958E60", Offset = "0x2957C60", VA = "0x182958E60", Slot = "6")]
	public override bool CanConvert(Type BMPFINLAMLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5677A90", Offset = "0x5676890", VA = "0x185677A90", Slot = "5")]
	public override object ReadJson(JsonReader DGMHJDFFMEI, Type BMPFINLAMLL, object EBJHMLHNIIK, JsonSerializer MHJAFOGOHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5678290", Offset = "0x5677090", VA = "0x185678290", Slot = "4")]
	public override void WriteJson(JsonWriter JAIJDFCBLCH, object BNECONOIKOE, JsonSerializer MHJAFOGOHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51847C0", Offset = "0x51835C0", VA = "0x1851847C0")]
	internal MIEOIACIKFE(Func<Type, bool> IOFCEIODFEL, Action<JsonWriter, T> HAPJAPHKOKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LHHFKEEEJKA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C55600", Offset = "0x3C54400", VA = "0x183C55600")]
	public static MIEOIACIKFE<T> OGAKBGHEIKK<T>(Action<JsonWriter, T> HAPJAPHKOKH, NNLDGNPIGGM MLLAIEJPPGF = NNLDGNPIGGM.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LFEILHHBNFM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] PEKCMFLHDFP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter CIJIFOHKIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8226660", Offset = "0x8225460", VA = "0x188226660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter ALFHIMOCJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82265C0", Offset = "0x82253C0", VA = "0x1882265C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter FDEMDHBKLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8226610", Offset = "0x8225410", VA = "0x188226610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter DAFNHHGOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8226570", Offset = "0x8225370", VA = "0x188226570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter CHHONKHKMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8226520", Offset = "0x8225320", VA = "0x188226520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PPOPOBEKDDA
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8226D20", Offset = "0x8225B20", VA = "0x188226D20")]
	public static string FCEJMBIIKOJ(this object FEOFEEGOGIO, JsonConverter[] DOIICHFOMLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AAAIKHJJKAI<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> IOFCEIODFEL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2958E60", Offset = "0x2957C60", VA = "0x182958E60", Slot = "6")]
	public override bool CanConvert(Type BMPFINLAMLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E5D0", Offset = "0x4E9D3D0", VA = "0x184E9E5D0", Slot = "5")]
	public override object ReadJson(JsonReader DGMHJDFFMEI, Type BMPFINLAMLL, object EBJHMLHNIIK, JsonSerializer MHJAFOGOHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E6B0", Offset = "0x4E9D4B0", VA = "0x184E9E6B0", Slot = "4")]
	public override void WriteJson(JsonWriter JAIJDFCBLCH, object BNECONOIKOE, JsonSerializer MHJAFOGOHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
	internal AAAIKHJJKAI(Func<Type, bool> IOFCEIODFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GDMNOLDDAPA
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B81EA0", Offset = "0x3B80CA0", VA = "0x183B81EA0")]
	public static AAAIKHJJKAI<T> OGAKBGHEIKK<T>(NNLDGNPIGGM MLLAIEJPPGF = NNLDGNPIGGM.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OJKHODNBFBE : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> IOFCEIODFEL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2958E60", Offset = "0x2957C60", VA = "0x182958E60", Slot = "6")]
	public override bool CanConvert(Type BMPFINLAMLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8226C10", Offset = "0x8225A10", VA = "0x188226C10", Slot = "5")]
	public override object ReadJson(JsonReader DGMHJDFFMEI, Type BMPFINLAMLL, object EBJHMLHNIIK, JsonSerializer MHJAFOGOHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8226CB0", Offset = "0x8225AB0", VA = "0x188226CB0", Slot = "4")]
	public override void WriteJson(JsonWriter JAIJDFCBLCH, object BNECONOIKOE, JsonSerializer MHJAFOGOHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
	public OJKHODNBFBE(Func<Type, bool> IOFCEIODFEL)
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

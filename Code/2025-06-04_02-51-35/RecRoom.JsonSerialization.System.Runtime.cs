using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class BDDNLIMCNOC<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void KIHPLLCABIK(Utf8JsonReader NLCEHLDPLPE);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61638C0", Offset = "0x61620C0", VA = "0x1861638C0", Slot = "27")]
	public override T Read(Utf8JsonReader JEPFPDOKDAD, Type EOJKPDKKBGA, JsonSerializerOptions OJJIDCCJBBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6163AC0", Offset = "0x61622C0", VA = "0x186163AC0", Slot = "28")]
	public override void Write(Utf8JsonWriter LFDMHEHCHCC, T MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void KMKGHPILDNA(Utf8JsonReader JEPFPDOKDAD, JsonSerializerOptions OJJIDCCJBBN, string EMGNLEIBFNM, T NAGJHHJDFPB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void FMFGIHEADPF(Utf8JsonWriter LFDMHEHCHCC, T MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4666D40", Offset = "0x4665540", VA = "0x184666D40")]
	protected BDDNLIMCNOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NBIIOHKKBDH : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2F40", Offset = "0x7FE1740", VA = "0x187FE2F40")]
	public NBIIOHKKBDH(string EMGNLEIBFNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ALCENHBEMFH<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E30980", Offset = "0x4E2F180", VA = "0x184E30980", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader JEPFPDOKDAD, Type EOJKPDKKBGA, JsonSerializerOptions OJJIDCCJBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E30BC0", Offset = "0x4E2F3C0", VA = "0x184E30BC0", Slot = "28")]
	public override void Write(Utf8JsonWriter LFDMHEHCHCC, Dictionary<TKey, int> MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4BEE960", Offset = "0x4BED160", VA = "0x184BEE960")]
	public ALCENHBEMFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PHDKKHLFCPM<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x58A8910", Offset = "0x58A7110", VA = "0x1858A8910", Slot = "27")]
	public override T[] Read(Utf8JsonReader JEPFPDOKDAD, Type EOJKPDKKBGA, JsonSerializerOptions OJJIDCCJBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x58A8C20", Offset = "0x58A7420", VA = "0x1858A8C20", Slot = "28")]
	public override void Write(Utf8JsonWriter LFDMHEHCHCC, T[] MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4683A20", Offset = "0x4682220", VA = "0x184683A20")]
	protected PHDKKHLFCPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GEAHDMLOABK<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? JGPBMJOMODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA2D360", Offset = "0xA2BB60", VA = "0x180A2D360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T IKPJLBNBOMO(float[] IFMNLKCJNMD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] FJIGKPPDAMG(T MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C82260", Offset = "0x4C80A60", VA = "0x184C82260", Slot = "27")]
	public override T Read(Utf8JsonReader JEPFPDOKDAD, Type EOJKPDKKBGA, JsonSerializerOptions OJJIDCCJBBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4C825E0", Offset = "0x4C80DE0", VA = "0x184C825E0", Slot = "28")]
	public override void Write(Utf8JsonWriter LFDMHEHCHCC, T MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4683A20", Offset = "0x4682220", VA = "0x184683A20")]
	protected GEAHDMLOABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JLCNIFBIOLC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2D20", Offset = "0x7FE1520", VA = "0x187FE2D20")]
	public static void LFLMMPAKKPO(this Utf8JsonWriter LFDMHEHCHCC, string EMGNLEIBFNM, bool MGONBEDEDON, bool GJPLADDCFJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2AB0", Offset = "0x7FE12B0", VA = "0x187FE2AB0")]
	public static bool BKKJKMIGODM(this Utf8JsonReader JEPFPDOKDAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2C70", Offset = "0x7FE1470", VA = "0x187FE2C70")]
	public static void LCGBDPNKLDP(this Utf8JsonWriter LFDMHEHCHCC, string EMGNLEIBFNM, int? MGONBEDEDON, int GJPLADDCFJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2A00", Offset = "0x7FE1200", VA = "0x187FE2A00")]
	public static void BBAEDCALOEN(this Utf8JsonWriter LFDMHEHCHCC, string EMGNLEIBFNM, long? MGONBEDEDON, long GJPLADDCFJL = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A65690", Offset = "0x3A63E90", VA = "0x183A65690")]
	public static void ELAMEIDLCFK<T>(this Utf8JsonWriter LFDMHEHCHCC, string EMGNLEIBFNM, JsonSerializerOptions OJJIDCCJBBN, T AMJBMFFPJLL, T IHBFPICDFEB) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2AD0", Offset = "0x7FE12D0", VA = "0x187FE2AD0")]
	public static void FFOMLLHKBGA(this Utf8JsonWriter LFDMHEHCHCC, float MGONBEDEDON, int CEJCNDFHFEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BEBMIAMBMOI<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6167720", Offset = "0x6165F20", VA = "0x186167720", Slot = "27")]
	public override T Read(Utf8JsonReader JEPFPDOKDAD, Type EOJKPDKKBGA, JsonSerializerOptions OJJIDCCJBBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61677C0", Offset = "0x6165FC0", VA = "0x1861677C0", Slot = "28")]
	public override void Write(Utf8JsonWriter LFDMHEHCHCC, T MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x47ABA50", Offset = "0x47AA250", VA = "0x1847ABA50")]
	public BEBMIAMBMOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LIKBKIPBEIB : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KGIDBGJLJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA30050", Offset = "0xA2E850", VA = "0x180A30050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA2FE60", Offset = "0xA2E660", VA = "0x180A2FE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2D50", Offset = "0x7FE1550", VA = "0x187FE2D50", Slot = "27")]
	public override float Read(Utf8JsonReader JEPFPDOKDAD, Type EOJKPDKKBGA, JsonSerializerOptions OJJIDCCJBBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2D60", Offset = "0x7FE1560", VA = "0x187FE2D60", Slot = "28")]
	public override void Write(Utf8JsonWriter LFDMHEHCHCC, float MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2F00", Offset = "0x7FE1700", VA = "0x187FE2F00")]
	public LIKBKIPBEIB()
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

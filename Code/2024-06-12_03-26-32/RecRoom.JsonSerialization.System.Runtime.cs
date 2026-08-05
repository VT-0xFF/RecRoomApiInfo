using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class NLABBMPKDAL<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void MCBMDLCPLBD(Utf8JsonReader AAELGECAEGP);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x449B610", Offset = "0x449A210", VA = "0x18449B610", Slot = "27")]
	public override T Read(Utf8JsonReader GGPHPLOPODB, Type MJKOHJBNMGM, JsonSerializerOptions MMOLNDGHCHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x449B800", Offset = "0x449A400", VA = "0x18449B800", Slot = "28")]
	public override void Write(Utf8JsonWriter AKHHKFNOJLO, T GLMEMJNJKAN, JsonSerializerOptions MMOLNDGHCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void BODMDNBDMKL(Utf8JsonReader GGPHPLOPODB, JsonSerializerOptions MMOLNDGHCHC, string ALMPCPBBOLG, T LBACBPHHKAE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void IHBNELLMLGE(Utf8JsonWriter AKHHKFNOJLO, T GLMEMJNJKAN, JsonSerializerOptions MMOLNDGHCHC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x379C8C0", Offset = "0x379B4C0", VA = "0x18379C8C0")]
	protected NLABBMPKDAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PBKKMEPPFOD : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68F8420", Offset = "0x68F7020", VA = "0x1868F8420")]
	public PBKKMEPPFOD(string ALMPCPBBOLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ACPJDFFIDHC<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3CC29C0", Offset = "0x3CC15C0", VA = "0x183CC29C0", Slot = "27")]
	public override T[] Read(Utf8JsonReader GGPHPLOPODB, Type MJKOHJBNMGM, JsonSerializerOptions MMOLNDGHCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2CD0", Offset = "0x3CC18D0", VA = "0x183CC2CD0", Slot = "28")]
	public override void Write(Utf8JsonWriter AKHHKFNOJLO, T[] GLMEMJNJKAN, JsonSerializerOptions MMOLNDGHCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x379C170", Offset = "0x379AD70", VA = "0x18379C170")]
	protected ACPJDFFIDHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DHFDLMKCCFC<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? AOLEMCBABOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8434B0", Offset = "0x8420B0", VA = "0x1808434B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T KBMOLBFHOEM(float[] DJGHJNNEKKN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] KFDCBPFLHKE(T GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x57D47E0", Offset = "0x57D33E0", VA = "0x1857D47E0", Slot = "27")]
	public override T Read(Utf8JsonReader GGPHPLOPODB, Type MJKOHJBNMGM, JsonSerializerOptions MMOLNDGHCHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57D5420", Offset = "0x57D4020", VA = "0x1857D5420", Slot = "28")]
	public override void Write(Utf8JsonWriter AKHHKFNOJLO, T GLMEMJNJKAN, JsonSerializerOptions MMOLNDGHCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x379C170", Offset = "0x379AD70", VA = "0x18379C170")]
	protected DHFDLMKCCFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ANAELPKPLCM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68F7F90", Offset = "0x68F6B90", VA = "0x1868F7F90")]
	public static void EBKPPMHGOGE(this Utf8JsonWriter AKHHKFNOJLO, string ALMPCPBBOLG, bool GLMEMJNJKAN, bool NJMAFDCOBGL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68F7FC0", Offset = "0x68F6BC0", VA = "0x1868F7FC0")]
	public static bool GJIMGFHNALI(this Utf8JsonReader GGPHPLOPODB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68F8180", Offset = "0x68F6D80", VA = "0x1868F8180")]
	public static void OBBCEDEFIOA(this Utf8JsonWriter AKHHKFNOJLO, string ALMPCPBBOLG, int? GLMEMJNJKAN, int NJMAFDCOBGL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x31DF510", Offset = "0x31DE110", VA = "0x1831DF510")]
	public static void NIEPCIHINBI<T>(this Utf8JsonWriter AKHHKFNOJLO, string ALMPCPBBOLG, JsonSerializerOptions MMOLNDGHCHC, T CLJFFIBMODC, T JEJLOIMNLLI) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68F7FE0", Offset = "0x68F6BE0", VA = "0x1868F7FE0")]
	public static void MELFMFHFEBD(this Utf8JsonWriter AKHHKFNOJLO, float GLMEMJNJKAN, int IMNGHDGHKFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DMBJAGLCLIG<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57F2C00", Offset = "0x57F1800", VA = "0x1857F2C00", Slot = "27")]
	public override T Read(Utf8JsonReader GGPHPLOPODB, Type MJKOHJBNMGM, JsonSerializerOptions MMOLNDGHCHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57F2CA0", Offset = "0x57F18A0", VA = "0x1857F2CA0", Slot = "28")]
	public override void Write(Utf8JsonWriter AKHHKFNOJLO, T GLMEMJNJKAN, JsonSerializerOptions MMOLNDGHCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x386B7C0", Offset = "0x386A3C0", VA = "0x18386B7C0")]
	public DMBJAGLCLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LCMKCHNCLJJ : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DDLAMAEMKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84B560", Offset = "0x84A160", VA = "0x18084B560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84B8D0", Offset = "0x84A4D0", VA = "0x18084B8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68F8230", Offset = "0x68F6E30", VA = "0x1868F8230", Slot = "27")]
	public override float Read(Utf8JsonReader GGPHPLOPODB, Type MJKOHJBNMGM, JsonSerializerOptions MMOLNDGHCHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68F8240", Offset = "0x68F6E40", VA = "0x1868F8240", Slot = "28")]
	public override void Write(Utf8JsonWriter AKHHKFNOJLO, float GLMEMJNJKAN, JsonSerializerOptions MMOLNDGHCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68F83E0", Offset = "0x68F6FE0", VA = "0x1868F83E0")]
	public LCMKCHNCLJJ()
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class MEPDFMPCCKM<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void OLNJOGDINIJ(Utf8JsonReader EBAPCDIJGCL);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x49C5390", Offset = "0x49C3B90", VA = "0x1849C5390", Slot = "27")]
	public override T Read(Utf8JsonReader GKMNBDEFGCI, Type DNGGJNIDMCF, JsonSerializerOptions PJFCIKCGIIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49C5580", Offset = "0x49C3D80", VA = "0x1849C5580", Slot = "28")]
	public override void Write(Utf8JsonWriter PAOHHJOJGFD, T INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void EOMLPMAHEIH(Utf8JsonReader GKMNBDEFGCI, JsonSerializerOptions PJFCIKCGIIA, string FHDOKEGCLOA, T DEDDGCENOOL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void IJJMKJLJMHD(Utf8JsonWriter PAOHHJOJGFD, T INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3C8E2E0", Offset = "0x3C8CAE0", VA = "0x183C8E2E0")]
	protected MEPDFMPCCKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LCANFNDNFOB : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F800F0", Offset = "0x6F7E8F0", VA = "0x186F800F0")]
	public LCANFNDNFOB(string FHDOKEGCLOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OBHPNFAFPMF<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B3BEE0", Offset = "0x4B3A6E0", VA = "0x184B3BEE0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader GKMNBDEFGCI, Type DNGGJNIDMCF, JsonSerializerOptions PJFCIKCGIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B3C120", Offset = "0x4B3A920", VA = "0x184B3C120", Slot = "28")]
	public override void Write(Utf8JsonWriter PAOHHJOJGFD, Dictionary<TKey, int> INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x40B7F30", Offset = "0x40B6730", VA = "0x1840B7F30")]
	public OBHPNFAFPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NLJKHONKJHN<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A59670", Offset = "0x4A57E70", VA = "0x184A59670", Slot = "27")]
	public override T[] Read(Utf8JsonReader GKMNBDEFGCI, Type DNGGJNIDMCF, JsonSerializerOptions PJFCIKCGIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A59970", Offset = "0x4A58170", VA = "0x184A59970", Slot = "28")]
	public override void Write(Utf8JsonWriter PAOHHJOJGFD, T[] INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA81D0", Offset = "0x3CA69D0", VA = "0x183CA81D0")]
	protected NLJKHONKJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class FNCIJBJGMCP<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? FMKBHCGICEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BB230", Offset = "0x8B9A30", VA = "0x1808BB230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T FFHKMPFBLMA(float[] MCAFGDLBCDD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] KDPLNHBOMLF(T INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4077C50", Offset = "0x4076450", VA = "0x184077C50", Slot = "27")]
	public override T Read(Utf8JsonReader GKMNBDEFGCI, Type DNGGJNIDMCF, JsonSerializerOptions PJFCIKCGIIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4078490", Offset = "0x4076C90", VA = "0x184078490", Slot = "28")]
	public override void Write(Utf8JsonWriter PAOHHJOJGFD, T INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CA81D0", Offset = "0x3CA69D0", VA = "0x183CA81D0")]
	protected FNCIJBJGMCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PBJJPCDKEJM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F80180", Offset = "0x6F7E980", VA = "0x186F80180")]
	public static void CEBIMLJFHLA(this Utf8JsonWriter PAOHHJOJGFD, string FHDOKEGCLOA, bool INDENPJBLHO, bool DFEJJOPGBKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F80160", Offset = "0x6F7E960", VA = "0x186F80160")]
	public static bool CBAKHIIDACG(this Utf8JsonReader GKMNBDEFGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F801B0", Offset = "0x6F7E9B0", VA = "0x186F801B0")]
	public static void EKAKBKIJGHI(this Utf8JsonWriter PAOHHJOJGFD, string FHDOKEGCLOA, int? INDENPJBLHO, int DFEJJOPGBKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3221E70", Offset = "0x3220670", VA = "0x183221E70")]
	public static void KFOAKGPPKCO<T>(this Utf8JsonWriter PAOHHJOJGFD, string FHDOKEGCLOA, JsonSerializerOptions PJFCIKCGIIA, T DBIIPNGMHFP, T DIOMHAIBFJM) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F80260", Offset = "0x6F7EA60", VA = "0x186F80260")]
	public static void PLGOIGGLBDG(this Utf8JsonWriter PAOHHJOJGFD, float INDENPJBLHO, int BFMJNBEMPAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FJOKGBGEHBE<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x406D200", Offset = "0x406BA00", VA = "0x18406D200", Slot = "27")]
	public override T Read(Utf8JsonReader GKMNBDEFGCI, Type DNGGJNIDMCF, JsonSerializerOptions PJFCIKCGIIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x406D2A0", Offset = "0x406BAA0", VA = "0x18406D2A0", Slot = "28")]
	public override void Write(Utf8JsonWriter PAOHHJOJGFD, T INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D3D3E0", Offset = "0x3D3BBE0", VA = "0x183D3D3E0")]
	public FJOKGBGEHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GMOIKGPCBPF : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LGAMKGBLDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C1590", Offset = "0x8BFD90", VA = "0x1808C1590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C1910", Offset = "0x8C0110", VA = "0x1808C1910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FF00", Offset = "0x6F7E700", VA = "0x186F7FF00", Slot = "27")]
	public override float Read(Utf8JsonReader GKMNBDEFGCI, Type DNGGJNIDMCF, JsonSerializerOptions PJFCIKCGIIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FF10", Offset = "0x6F7E710", VA = "0x186F7FF10", Slot = "28")]
	public override void Write(Utf8JsonWriter PAOHHJOJGFD, float INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F800B0", Offset = "0x6F7E8B0", VA = "0x186F800B0")]
	public GMOIKGPCBPF()
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

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class ECGGJBINPCP<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void FFLMHCJDGMJ(Utf8JsonReader LJNBPEFJOFE);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x37E4D40", Offset = "0x37E3D40", VA = "0x1837E4D40", Slot = "27")]
	public override T Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37E4F40", Offset = "0x37E3F40", VA = "0x1837E4F40", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, T CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, T OPNLGJFHDEP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, T CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37D2890", Offset = "0x37D1890", VA = "0x1837D2890")]
	protected ECGGJBINPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CANHLDBKMHP : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6998640", Offset = "0x6997640", VA = "0x186998640")]
	public CANHLDBKMHP(string IJNPKFDDGPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IHJPOFOPHLN<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3ECCA40", Offset = "0x3ECBA40", VA = "0x183ECCA40", Slot = "27")]
	public override T[] Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3ECCD50", Offset = "0x3ECBD50", VA = "0x183ECCD50", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, T[] CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37D2120", Offset = "0x37D1120", VA = "0x1837D2120")]
	protected IHJPOFOPHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class AGMDFCHDNJC<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? MNKNCOKPMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86FEF0", Offset = "0x86EEF0", VA = "0x18086FEF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T FLABPMGGCIJ(float[] CNNODMDOLAC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] JNKPEPBDKEI(T CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D78770", Offset = "0x3D77770", VA = "0x183D78770", Slot = "27")]
	public override T Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D78E30", Offset = "0x3D77E30", VA = "0x183D78E30", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, T CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37D2120", Offset = "0x37D1120", VA = "0x1837D2120")]
	protected AGMDFCHDNJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FCALLIFOIJI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6998920", Offset = "0x6997920", VA = "0x186998920")]
	public static void LMMHNFHONGK(this Utf8JsonWriter OGONFGJBIBI, string IJNPKFDDGPP, bool CBAEIEAPLIH, bool AJMLHGDNPEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69986B0", Offset = "0x69976B0", VA = "0x1869986B0")]
	public static bool CGPAKANCPOL(this Utf8JsonReader DHKLMNOOPAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6998870", Offset = "0x6997870", VA = "0x186998870")]
	public static void GCJKFNBPKFO(this Utf8JsonWriter OGONFGJBIBI, string IJNPKFDDGPP, int? CBAEIEAPLIH, int AJMLHGDNPEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B055D0", Offset = "0x2B045D0", VA = "0x182B055D0")]
	public static void JENFKHDEDLN<T>(this Utf8JsonWriter OGONFGJBIBI, string IJNPKFDDGPP, JsonSerializerOptions HEBGDGGBJPN, T LECBAKCNNCK, T BAGGNPKNNDO) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69986D0", Offset = "0x69976D0", VA = "0x1869986D0")]
	public static void GCEHBNCJCAJ(this Utf8JsonWriter OGONFGJBIBI, float CBAEIEAPLIH, int DLFLKPBJIMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PDBMCPLDGHC<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x476D070", Offset = "0x476C070", VA = "0x18476D070", Slot = "27")]
	public override T Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x476D110", Offset = "0x476C110", VA = "0x18476D110", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, T CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38A4D60", Offset = "0x38A3D60", VA = "0x1838A4D60")]
	public PDBMCPLDGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GOHMLCPMHJC : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ONHPHFCHFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8711C0", Offset = "0x8701C0", VA = "0x1808711C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x870C60", Offset = "0x86FC60", VA = "0x180870C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6998950", Offset = "0x6997950", VA = "0x186998950", Slot = "27")]
	public override float Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6998960", Offset = "0x6997960", VA = "0x186998960", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, float CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6998B00", Offset = "0x6997B00", VA = "0x186998B00")]
	public GOHMLCPMHJC()
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

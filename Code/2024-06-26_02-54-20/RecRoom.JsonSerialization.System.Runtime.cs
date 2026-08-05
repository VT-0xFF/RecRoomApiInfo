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
	[Cpp2IlInjected.Address(RVA = "0x37CA1D0", Offset = "0x37C87D0", VA = "0x1837CA1D0", Slot = "27")]
	public override T Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37CA3D0", Offset = "0x37C89D0", VA = "0x1837CA3D0", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x37B7D20", Offset = "0x37B6320", VA = "0x1837B7D20")]
	protected ECGGJBINPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CANHLDBKMHP : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69656E0", Offset = "0x6963CE0", VA = "0x1869656E0")]
	public CANHLDBKMHP(string IJNPKFDDGPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IHJPOFOPHLN<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF330", Offset = "0x3EAD930", VA = "0x183EAF330", Slot = "27")]
	public override T[] Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF640", Offset = "0x3EADC40", VA = "0x183EAF640", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, T[] CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37B75B0", Offset = "0x37B5BB0", VA = "0x1837B75B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86CEF0", Offset = "0x86B4F0", VA = "0x18086CEF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D67AC0", Offset = "0x3D660C0", VA = "0x183D67AC0", Slot = "27")]
	public override T Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D68180", Offset = "0x3D66780", VA = "0x183D68180", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, T CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37B75B0", Offset = "0x37B5BB0", VA = "0x1837B75B0")]
	protected AGMDFCHDNJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FCALLIFOIJI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69659C0", Offset = "0x6963FC0", VA = "0x1869659C0")]
	public static void LMMHNFHONGK(this Utf8JsonWriter OGONFGJBIBI, string IJNPKFDDGPP, bool CBAEIEAPLIH, bool AJMLHGDNPEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6965750", Offset = "0x6963D50", VA = "0x186965750")]
	public static bool CGPAKANCPOL(this Utf8JsonReader DHKLMNOOPAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6965910", Offset = "0x6963F10", VA = "0x186965910")]
	public static void GCJKFNBPKFO(this Utf8JsonWriter OGONFGJBIBI, string IJNPKFDDGPP, int? CBAEIEAPLIH, int AJMLHGDNPEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2AECBD0", Offset = "0x2AEB1D0", VA = "0x182AECBD0")]
	public static void JENFKHDEDLN<T>(this Utf8JsonWriter OGONFGJBIBI, string IJNPKFDDGPP, JsonSerializerOptions HEBGDGGBJPN, T LECBAKCNNCK, T BAGGNPKNNDO) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6965770", Offset = "0x6963D70", VA = "0x186965770")]
	public static void GCEHBNCJCAJ(this Utf8JsonWriter OGONFGJBIBI, float CBAEIEAPLIH, int DLFLKPBJIMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PDBMCPLDGHC<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x474B810", Offset = "0x4749E10", VA = "0x18474B810", Slot = "27")]
	public override T Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x474B8B0", Offset = "0x4749EB0", VA = "0x18474B8B0", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, T CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x388A2B0", Offset = "0x38888B0", VA = "0x18388A2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E1C0", Offset = "0x86C7C0", VA = "0x18086E1C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86DC60", Offset = "0x86C260", VA = "0x18086DC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69659F0", Offset = "0x6963FF0", VA = "0x1869659F0", Slot = "27")]
	public override float Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6965A00", Offset = "0x6964000", VA = "0x186965A00", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, float CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6965BA0", Offset = "0x69641A0", VA = "0x186965BA0")]
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

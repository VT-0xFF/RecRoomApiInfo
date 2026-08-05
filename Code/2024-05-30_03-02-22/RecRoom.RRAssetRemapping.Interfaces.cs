using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B910", Offset = "0x6A9AB10", VA = "0x186A9B910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LLKOBCKBADP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GKNEHCEDNDE(LMGLPMBGHHO NBFGFAAMIMJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMGLPMBGHHO IHPADLGFHBL(string NBFGFAAMIMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct LMGLPMBGHHO : IEquatable<LMGLPMBGHHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PPFHPDKJCCM NOOALJHHCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IBBLFMEEAFP CJMNKCIKPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid KILFGOBNADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? LLHNACFBHLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ENEMPLGFKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A9AF50", Offset = "0x6A9A150", VA = "0x186A9AF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GGHHOBGDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B150", Offset = "0x6A9A350", VA = "0x186A9B150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B5B0", Offset = "0x6A9A7B0", VA = "0x186A9B5B0")]
	public LMGLPMBGHHO(LMGLPMBGHHO GPLGABLAOAN, [Optional] Guid CAJMEPMFBEN, [Optional] RRColor? LHAAJEOMGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B640", Offset = "0x6A9A840", VA = "0x186A9B640")]
	public LMGLPMBGHHO(PPFHPDKJCCM DEPNLIDGJAM, IBBLFMEEAFP ONLLACAPGBL, [Optional] Guid CAJMEPMFBEN, [Optional] RRColor? LHAAJEOMGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AEA0", Offset = "0x6A9A0A0", VA = "0x186A9AEA0", Slot = "4")]
	public bool Equals(LMGLPMBGHHO JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AD70", Offset = "0x6A99F70", VA = "0x186A9AD70", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B010", Offset = "0x6A9A210", VA = "0x186A9B010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AEA0", Offset = "0x6A9A0A0", VA = "0x186A9AEA0")]
	public static bool LOAKJDDAMKI(LMGLPMBGHHO ABPADDODFDF, LMGLPMBGHHO DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B0A0", Offset = "0x6A9A2A0", VA = "0x186A9B0A0")]
	public static bool IICOCCMJGPI(LMGLPMBGHHO ABPADDODFDF, LMGLPMBGHHO DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B190", Offset = "0x6A9A390", VA = "0x186A9B190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PPFHPDKJCCM : IEquatable<PPFHPDKJCCM>, IComparable<PPFHPDKJCCM>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly PPFHPDKJCCM NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public PPFHPDKJCCM(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(PPFHPDKJCCM JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(PPFHPDKJCCM JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BBD0", Offset = "0x6A9ADD0", VA = "0x186A9BBD0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0")]
	public static bool LOAKJDDAMKI(PPFHPDKJCCM ABPADDODFDF, PPFHPDKJCCM DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A99D70", Offset = "0x6A98F70", VA = "0x186A99D70")]
	public static bool IICOCCMJGPI(PPFHPDKJCCM ABPADDODFDF, PPFHPDKJCCM DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BC80", Offset = "0x6A9AE80", VA = "0x186A9BC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JMPHDKBEGLF : IEquatable<JMPHDKBEGLF>, IComparable<JMPHDKBEGLF>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JMPHDKBEGLF NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public JMPHDKBEGLF(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(JMPHDKBEGLF JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(JMPHDKBEGLF JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A920", Offset = "0x6A99B20", VA = "0x186A9A920", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0")]
	public static bool LOAKJDDAMKI(JMPHDKBEGLF ABPADDODFDF, JMPHDKBEGLF DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A99D70", Offset = "0x6A98F70", VA = "0x186A99D70")]
	public static bool IICOCCMJGPI(JMPHDKBEGLF ABPADDODFDF, JMPHDKBEGLF DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A9D0", Offset = "0x6A99BD0", VA = "0x186A9A9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KDLAJGECGFL : IEquatable<KDLAJGECGFL>, IComparable<KDLAJGECGFL>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly KDLAJGECGFL NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public KDLAJGECGFL(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(KDLAJGECGFL JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(KDLAJGECGFL JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AA40", Offset = "0x6A99C40", VA = "0x186A9AA40", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0")]
	public static bool LOAKJDDAMKI(KDLAJGECGFL ABPADDODFDF, KDLAJGECGFL DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A99D70", Offset = "0x6A98F70", VA = "0x186A99D70")]
	public static bool IICOCCMJGPI(KDLAJGECGFL ABPADDODFDF, KDLAJGECGFL DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AAF0", Offset = "0x6A99CF0", VA = "0x186A9AAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct IBBLFMEEAFP : IEquatable<IBBLFMEEAFP>, IComparable<IBBLFMEEAFP>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly IBBLFMEEAFP NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NFPPFNGGELC CMOKCFGNECA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450")]
		[CompilerGenerated]
		get
		{
			return default(NFPPFNGGELC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NFPPFNGGELC PEHHPFPIJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83B460", Offset = "0x83A660", VA = "0x18083B460")]
		[CompilerGenerated]
		get
		{
			return default(NFPPFNGGELC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NFPPFNGGELC NMGDGPGPKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84E960", Offset = "0x84DB60", VA = "0x18084E960")]
		[CompilerGenerated]
		get
		{
			return default(NFPPFNGGELC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A8E0", Offset = "0x6A99AE0", VA = "0x186A9A8E0")]
	public IBBLFMEEAFP(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A890", Offset = "0x6A99A90", VA = "0x186A9A890")]
	public IBBLFMEEAFP(NFPPFNGGELC CGGADBHPPLE, NFPPFNGGELC FPEPACJHACP, NFPPFNGGELC OPMENAGECCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A550", Offset = "0x6A99750", VA = "0x186A9A550")]
	private Guid ANGACMJOFHN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A6C0", Offset = "0x6A998C0", VA = "0x186A9A6C0", Slot = "4")]
	public bool Equals(IBBLFMEEAFP JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A6F0", Offset = "0x6A998F0", VA = "0x186A9A6F0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A7E0", Offset = "0x6A999E0", VA = "0x186A9A7E0")]
	public static bool LOAKJDDAMKI(IBBLFMEEAFP ABPADDODFDF, IBBLFMEEAFP DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A7A0", Offset = "0x6A999A0", VA = "0x186A9A7A0")]
	public static bool IICOCCMJGPI(IBBLFMEEAFP ABPADDODFDF, IBBLFMEEAFP DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A680", Offset = "0x6A99880", VA = "0x186A9A680", Slot = "5")]
	public int CompareTo(IBBLFMEEAFP JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A820", Offset = "0x6A99A20", VA = "0x186A9A820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FCBNLOPDJIL : IEquatable<FCBNLOPDJIL>, IComparable<FCBNLOPDJIL>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly FCBNLOPDJIL NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public FCBNLOPDJIL(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(FCBNLOPDJIL JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(FCBNLOPDJIL JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A99CC0", Offset = "0x6A98EC0", VA = "0x186A99CC0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0")]
	public static bool LOAKJDDAMKI(FCBNLOPDJIL ABPADDODFDF, FCBNLOPDJIL DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A99D70", Offset = "0x6A98F70", VA = "0x186A99D70")]
	public static bool IICOCCMJGPI(FCBNLOPDJIL ABPADDODFDF, FCBNLOPDJIL DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A99DA0", Offset = "0x6A98FA0", VA = "0x186A99DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PLPCONDGDMD : IEquatable<PLPCONDGDMD>, IComparable<PLPCONDGDMD>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PLPCONDGDMD NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public PLPCONDGDMD(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(PLPCONDGDMD JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(PLPCONDGDMD JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BAB0", Offset = "0x6A9ACB0", VA = "0x186A9BAB0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0")]
	public static bool LOAKJDDAMKI(PLPCONDGDMD ABPADDODFDF, PLPCONDGDMD DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A99D70", Offset = "0x6A98F70", VA = "0x186A99D70")]
	public static bool IICOCCMJGPI(PLPCONDGDMD ABPADDODFDF, PLPCONDGDMD DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BB60", Offset = "0x6A9AD60", VA = "0x186A9BB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct KOJBJIADMMM : IEquatable<KOJBJIADMMM>, IComparable<KOJBJIADMMM>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly KOJBJIADMMM NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public KOJBJIADMMM(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(KOJBJIADMMM JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(KOJBJIADMMM JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AB60", Offset = "0x6A99D60", VA = "0x186A9AB60", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0")]
	public static bool LOAKJDDAMKI(KOJBJIADMMM ABPADDODFDF, KOJBJIADMMM DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A99D70", Offset = "0x6A98F70", VA = "0x186A99D70")]
	public static bool IICOCCMJGPI(KOJBJIADMMM ABPADDODFDF, KOJBJIADMMM DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AC10", Offset = "0x6A99E10", VA = "0x186A9AC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PKFGAFHOMKH : IEquatable<PKFGAFHOMKH>, IComparable<PKFGAFHOMKH>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly PKFGAFHOMKH NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public PKFGAFHOMKH(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(PKFGAFHOMKH JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(PKFGAFHOMKH JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B990", Offset = "0x6A9AB90", VA = "0x186A9B990", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0")]
	public static bool LOAKJDDAMKI(PKFGAFHOMKH ABPADDODFDF, PKFGAFHOMKH DLCDCNECDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A99D70", Offset = "0x6A98F70", VA = "0x186A99D70")]
	public static bool IICOCCMJGPI(PKFGAFHOMKH ABPADDODFDF, PKFGAFHOMKH DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BA40", Offset = "0x6A9AC40", VA = "0x186A9BA40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FKCJCHOPJOM : IEquatable<FKCJCHOPJOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? MPGJEDJPMOL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KPPCPAJJDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6A99E10", Offset = "0x6A99010", VA = "0x186A99E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int GLPGFNPNPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3FFB370", Offset = "0x3FFA570", VA = "0x183FFB370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A390", Offset = "0x6A99590", VA = "0x186A9A390")]
	public FKCJCHOPJOM(string? IFLPILOGGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A4D0", Offset = "0x6A996D0", VA = "0x186A9A4D0")]
	public FKCJCHOPJOM(string?[] NFMNLHAEILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A99F90", Offset = "0x6A99190", VA = "0x186A99F90")]
	private static string?[]? GMBNEAHMJEE(string?[]? NFMNLHAEILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A2A0", Offset = "0x6A994A0", VA = "0x186A9A2A0")]
	public string LBMOJALALKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A99EC0", Offset = "0x6A990C0", VA = "0x186A99EC0", Slot = "4")]
	public bool Equals(FKCJCHOPJOM JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A99E30", Offset = "0x6A99030", VA = "0x186A99E30", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A1C0", Offset = "0x6A993C0", VA = "0x186A9A1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A300", Offset = "0x6A99500", VA = "0x186A9A300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NFPPFNGGELC : IEquatable<NFPPFNGGELC>, IComparable<NFPPFNGGELC>, HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NFPPFNGGELC NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public NFPPFNGGELC(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(NFPPFNGGELC JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(NFPPFNGGELC JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B7F0", Offset = "0x6A9A9F0", VA = "0x186A9B7F0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0")]
	public static bool LOAKJDDAMKI(NFPPFNGGELC ABPADDODFDF, NFPPFNGGELC DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B8A0", Offset = "0x6A9AAA0", VA = "0x186A9B8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MKLIBLDOELJ : IEquatable<MKLIBLDOELJ>, IComparable<MKLIBLDOELJ>, HJNDGGGNPJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Guid LDJEJDDHHLO;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
	public MKLIBLDOELJ(Guid LDJEJDDHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public Guid AOHJHMGCENG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AEC0", Offset = "0x4A4A0C0", VA = "0x184A4AEC0", Slot = "4")]
	public bool Equals(MKLIBLDOELJ JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AC30", Offset = "0x4A49E30", VA = "0x184A4AC30", Slot = "5")]
	public int CompareTo(MKLIBLDOELJ JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B6D0", Offset = "0x6A9A8D0", VA = "0x186A9B6D0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AE40", Offset = "0x4A4A040", VA = "0x184A4AE40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B780", Offset = "0x6A9A980", VA = "0x186A9B780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JKIKNNMOLHI<TModern> : HBDHPFBKEKE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FLNBPCOFLAD(TModern JBFKAFCIKIK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HJNDGGGNPJK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid AOHJHMGCENG();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HBDHPFBKEKE<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern HNAADKJFBDL(string JBFKAFCIKIK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PPPAOOBJLJE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JKIKNNMOLHI<PPFHPDKJCCM> PHCONKJJFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JKIKNNMOLHI<FCBNLOPDJIL> DPINEMICGBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JKIKNNMOLHI<PKFGAFHOMKH> BOCJHAFNMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JKIKNNMOLHI<IBBLFMEEAFP> KCHALDGLNMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JKIKNNMOLHI<KDLAJGECGFL> LDOJJECONNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JKIKNNMOLHI<KOJBJIADMMM> NNPBENAGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JKIKNNMOLHI<JMPHDKBEGLF> LCCENDEHMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JKIKNNMOLHI<PLPCONDGDMD> ADBADNBCAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LIEMMGILHAD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A9ACB0", Offset = "0x6A99EB0", VA = "0x186A9ACB0")]
	public static string[] NHECKLKNPHL(string? IFLPILOGGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AC80", Offset = "0x6A99E80", VA = "0x186A9AC80")]
	public static string? EGBIMPBDLFJ(string? DEPNLIDGJAM)
	{
		return null;
	}
}
namespace Cpp2IlInjected
{
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
}

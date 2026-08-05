using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x752F240", Offset = "0x752E640", VA = "0x18752F240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MNGLJMNKILG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KEEAKGCJIOB(KGFBNKJDMOF GJMNBMBONPJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KGFBNKJDMOF GEBAPMNFHGF(string GJMNBMBONPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KGFBNKJDMOF : IEquatable<KGFBNKJDMOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LIPMOPEKLJE DNBIALHAKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MLLCBKIBLJC BLJKBAILBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid CAKDFJCMEDM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FAAFPDFOIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x752E9A0", Offset = "0x752DDA0", VA = "0x18752E9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JHOJJLOLFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x752E6F0", Offset = "0x752DAF0", VA = "0x18752E6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x752ED40", Offset = "0x752E140", VA = "0x18752ED40")]
	public KGFBNKJDMOF(KGFBNKJDMOF IFKLICCODMM, [Optional] Guid GIIHIDHDOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50BD7E0", Offset = "0x50BCBE0", VA = "0x1850BD7E0")]
	public KGFBNKJDMOF(LIPMOPEKLJE MEKMCBBOPDI, MLLCBKIBLJC PGEAOLIDHPF, [Optional] Guid GIIHIDHDOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x752E7E0", Offset = "0x752DBE0", VA = "0x18752E7E0", Slot = "4")]
	public bool Equals(KGFBNKJDMOF OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x752E730", Offset = "0x752DB30", VA = "0x18752E730", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x752E8D0", Offset = "0x752DCD0", VA = "0x18752E8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x752E8A0", Offset = "0x752DCA0", VA = "0x18752E8A0")]
	public static bool GBDINLJCMBD(KGFBNKJDMOF EHOEECMJEAD, KGFBNKJDMOF CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x752E960", Offset = "0x752DD60", VA = "0x18752E960")]
	public static bool HNDJODBNLBB(KGFBNKJDMOF EHOEECMJEAD, KGFBNKJDMOF CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x752EA30", Offset = "0x752DE30", VA = "0x18752EA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LIPMOPEKLJE : IEquatable<LIPMOPEKLJE>, IComparable<LIPMOPEKLJE>, MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly LIPMOPEKLJE NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public LIPMOPEKLJE(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70", Slot = "4")]
	public bool Equals(LIPMOPEKLJE OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(LIPMOPEKLJE OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x752EFA0", Offset = "0x752E3A0", VA = "0x18752EFA0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70")]
	public static bool GBDINLJCMBD(LIPMOPEKLJE EHOEECMJEAD, LIPMOPEKLJE CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x752E190", Offset = "0x752D590", VA = "0x18752E190")]
	public static bool HNDJODBNLBB(LIPMOPEKLJE EHOEECMJEAD, LIPMOPEKLJE CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x752F050", Offset = "0x752E450", VA = "0x18752F050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CMJGNKBOLIJ : IEquatable<CMJGNKBOLIJ>, IComparable<CMJGNKBOLIJ>, MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly CMJGNKBOLIJ NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public CMJGNKBOLIJ(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70", Slot = "4")]
	public bool Equals(CMJGNKBOLIJ OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(CMJGNKBOLIJ OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x752E0E0", Offset = "0x752D4E0", VA = "0x18752E0E0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70")]
	public static bool GBDINLJCMBD(CMJGNKBOLIJ EHOEECMJEAD, CMJGNKBOLIJ CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x752E190", Offset = "0x752D590", VA = "0x18752E190")]
	public static bool HNDJODBNLBB(CMJGNKBOLIJ EHOEECMJEAD, CMJGNKBOLIJ CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x752E1C0", Offset = "0x752D5C0", VA = "0x18752E1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct DBKGLJPGPGA : IEquatable<DBKGLJPGPGA>, IComparable<DBKGLJPGPGA>, MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly DBKGLJPGPGA NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public DBKGLJPGPGA(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70", Slot = "4")]
	public bool Equals(DBKGLJPGPGA OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(DBKGLJPGPGA OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x752E230", Offset = "0x752D630", VA = "0x18752E230", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70")]
	public static bool GBDINLJCMBD(DBKGLJPGPGA EHOEECMJEAD, DBKGLJPGPGA CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x752E190", Offset = "0x752D590", VA = "0x18752E190")]
	public static bool HNDJODBNLBB(DBKGLJPGPGA EHOEECMJEAD, DBKGLJPGPGA CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x752E2E0", Offset = "0x752D6E0", VA = "0x18752E2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MLLCBKIBLJC : IEquatable<MLLCBKIBLJC>, IComparable<MLLCBKIBLJC>, MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly MLLCBKIBLJC NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public MLLCBKIBLJC(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x752F170", Offset = "0x752E570", VA = "0x18752F170", Slot = "4")]
	public bool Equals(MLLCBKIBLJC OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x752F0C0", Offset = "0x752E4C0", VA = "0x18752F0C0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x752F170", Offset = "0x752E570", VA = "0x18752F170")]
	public static bool GBDINLJCMBD(MLLCBKIBLJC EHOEECMJEAD, MLLCBKIBLJC CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x752F1A0", Offset = "0x752E5A0", VA = "0x18752F1A0")]
	public static bool HNDJODBNLBB(MLLCBKIBLJC EHOEECMJEAD, MLLCBKIBLJC CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(MLLCBKIBLJC OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x752F1D0", Offset = "0x752E5D0", VA = "0x18752F1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public MLLCBKIBLJC(LHIKMCDGAOP APMCJDKNHGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct IAOIAGHLOEC : IEquatable<IAOIAGHLOEC>, IComparable<IAOIAGHLOEC>, MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly IAOIAGHLOEC NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public IAOIAGHLOEC(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70", Slot = "4")]
	public bool Equals(IAOIAGHLOEC OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(IAOIAGHLOEC OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x752E5D0", Offset = "0x752D9D0", VA = "0x18752E5D0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70")]
	public static bool GBDINLJCMBD(IAOIAGHLOEC EHOEECMJEAD, IAOIAGHLOEC CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x752E190", Offset = "0x752D590", VA = "0x18752E190")]
	public static bool HNDJODBNLBB(IAOIAGHLOEC EHOEECMJEAD, IAOIAGHLOEC CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x752E680", Offset = "0x752DA80", VA = "0x18752E680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LGPPHCHPBNO : IEquatable<LGPPHCHPBNO>, IComparable<LGPPHCHPBNO>, MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly LGPPHCHPBNO NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public LGPPHCHPBNO(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70", Slot = "4")]
	public bool Equals(LGPPHCHPBNO OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(LGPPHCHPBNO OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x752ED60", Offset = "0x752E160", VA = "0x18752ED60", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70")]
	public static bool GBDINLJCMBD(LGPPHCHPBNO EHOEECMJEAD, LGPPHCHPBNO CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x752E190", Offset = "0x752D590", VA = "0x18752E190")]
	public static bool HNDJODBNLBB(LGPPHCHPBNO EHOEECMJEAD, LGPPHCHPBNO CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x752EE10", Offset = "0x752E210", VA = "0x18752EE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct EFGAFCFIFCC : IEquatable<EFGAFCFIFCC>, IComparable<EFGAFCFIFCC>, MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly EFGAFCFIFCC NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public EFGAFCFIFCC(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70", Slot = "4")]
	public bool Equals(EFGAFCFIFCC OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(EFGAFCFIFCC OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x752E4B0", Offset = "0x752D8B0", VA = "0x18752E4B0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70")]
	public static bool GBDINLJCMBD(EFGAFCFIFCC EHOEECMJEAD, EFGAFCFIFCC CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x752E190", Offset = "0x752D590", VA = "0x18752E190")]
	public static bool HNDJODBNLBB(EFGAFCFIFCC EHOEECMJEAD, EFGAFCFIFCC CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x752E560", Offset = "0x752D960", VA = "0x18752E560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PIAKFDEEEHG : IEquatable<PIAKFDEEEHG>, IComparable<PIAKFDEEEHG>, MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PIAKFDEEEHG NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public PIAKFDEEEHG(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70", Slot = "4")]
	public bool Equals(PIAKFDEEEHG OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(PIAKFDEEEHG OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x752F2C0", Offset = "0x752E6C0", VA = "0x18752F2C0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70")]
	public static bool GBDINLJCMBD(PIAKFDEEEHG EHOEECMJEAD, PIAKFDEEEHG CPKKNGGFDGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x752E190", Offset = "0x752D590", VA = "0x18752E190")]
	public static bool HNDJODBNLBB(PIAKFDEEEHG EHOEECMJEAD, PIAKFDEEEHG CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x752F370", Offset = "0x752E770", VA = "0x18752F370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct BFPCODFKEAD : IEquatable<BFPCODFKEAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? FINFONGEOJA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KGFOOIOHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x752DC30", Offset = "0x752D030", VA = "0x18752DC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EHHCPLAMJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4404FE0", Offset = "0x44043E0", VA = "0x184404FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x752DF90", Offset = "0x752D390", VA = "0x18752DF90")]
	public BFPCODFKEAD(string? OJJFDJNENKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x752DF10", Offset = "0x752D310", VA = "0x18752DF10")]
	public BFPCODFKEAD(string?[] BAIDNPDGIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x752DC50", Offset = "0x752D050", VA = "0x18752DC50")]
	private static string?[]? JAJDEMHCHJO(string?[]? BAIDNPDGIJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x752DAF0", Offset = "0x752CEF0", VA = "0x18752DAF0")]
	public string FICOBCMBHGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x752DA20", Offset = "0x752CE20", VA = "0x18752DA20", Slot = "4")]
	public bool Equals(BFPCODFKEAD OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x752D990", Offset = "0x752CD90", VA = "0x18752D990", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x752DB50", Offset = "0x752CF50", VA = "0x18752DB50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x752DE80", Offset = "0x752D280", VA = "0x18752DE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct LHIKMCDGAOP : IEquatable<LHIKMCDGAOP>, IComparable<LHIKMCDGAOP>, MFFOALEFBNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid FDANKBMKMCE;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
	public LHIKMCDGAOP(Guid FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public Guid BMGPLCBODMK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x43EAC70", Offset = "0x43EA070", VA = "0x1843EAC70", Slot = "4")]
	public bool Equals(LHIKMCDGAOP OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x43EACA0", Offset = "0x43EA0A0", VA = "0x1843EACA0", Slot = "5")]
	public int CompareTo(LHIKMCDGAOP OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x752EE80", Offset = "0x752E280", VA = "0x18752EE80", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x752EF30", Offset = "0x752E330", VA = "0x18752EF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DBFDHKFKOJC<TModern> : GHDJEDJDAEG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EMFOEIBKEOH(TModern JAAAKAOHBNF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MFFOALEFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BMGPLCBODMK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GHDJEDJDAEG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern JPMMNGNIBOF(string JAAAKAOHBNF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BGKIAOHIJGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DBFDHKFKOJC<LIPMOPEKLJE> DIFNNGJIABG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DBFDHKFKOJC<IAOIAGHLOEC> DECDKBFOACI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DBFDHKFKOJC<PIAKFDEEEHG> NHIEKJNPHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DBFDHKFKOJC<MLLCBKIBLJC> CGINFFLDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DBFDHKFKOJC<DBKGLJPGPGA> JICCCPCCANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DBFDHKFKOJC<EFGAFCFIFCC> ILOLHOCEIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DBFDHKFKOJC<CMJGNKBOLIJ> JHDKPBLJAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DBFDHKFKOJC<LGPPHCHPBNO> CLKCONBMBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DOKICPNJMNN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] EOGFLFPJFDG;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x752E380", Offset = "0x752D780", VA = "0x18752E380")]
	public static string[] MJGKNNMMFEP(string? OJJFDJNENKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x752E350", Offset = "0x752D750", VA = "0x18752E350")]
	public static string? JEDLFAFIOFJ(string? MEKMCBBOPDI)
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

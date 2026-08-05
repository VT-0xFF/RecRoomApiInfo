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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x79D07F0", Offset = "0x79CF9F0", VA = "0x1879D07F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ONBDNIOJJIC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LKDLAIOBOFF(PFMDOPPHAKG DFKGLBJBJGD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFMDOPPHAKG LAEIJKNHIPI(string DFKGLBJBJGD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct PFMDOPPHAKG : IEquatable<PFMDOPPHAKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KFNFGKAFGLE KDEOCDCPLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FLOHLNJAHJB LBKIPKCKAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid BKDGDAKDEOK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HKGOAHAFFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x79D0BE0", Offset = "0x79CFDE0", VA = "0x1879D0BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KCNOGGFPBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79D0B20", Offset = "0x79CFD20", VA = "0x1879D0B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79D0F70", Offset = "0x79D0170", VA = "0x1879D0F70")]
	public PFMDOPPHAKG(PFMDOPPHAKG MFKMKMIPIDD, [Optional] Guid IKEAMEFDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x54914C0", Offset = "0x54906C0", VA = "0x1854914C0")]
	public PFMDOPPHAKG(KFNFGKAFGLE ICHGECIHFKM, FLOHLNJAHJB ILCFDIAPIJB, [Optional] Guid IKEAMEFDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79D0A60", Offset = "0x79CFC60", VA = "0x1879D0A60", Slot = "4")]
	public bool Equals(PFMDOPPHAKG JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x79D09B0", Offset = "0x79CFBB0", VA = "0x1879D09B0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79D0B50", Offset = "0x79CFD50", VA = "0x1879D0B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x79D0980", Offset = "0x79CFB80", VA = "0x1879D0980")]
	public static bool CCHBIHOFELC(PFMDOPPHAKG LFOFDHEGDLC, PFMDOPPHAKG KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79D0C70", Offset = "0x79CFE70", VA = "0x1879D0C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KFNFGKAFGLE : IEquatable<KFNFGKAFGLE>, IComparable<KFNFGKAFGLE>, GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly KFNFGKAFGLE GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public KFNFGKAFGLE(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40", Slot = "4")]
	public bool Equals(KFNFGKAFGLE JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(KFNFGKAFGLE JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79D06E0", Offset = "0x79CF8E0", VA = "0x1879D06E0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40")]
	public static bool CCHBIHOFELC(KFNFGKAFGLE LFOFDHEGDLC, KFNFGKAFGLE KMPLOMOLJCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x79CFE10", Offset = "0x79CF010", VA = "0x1879CFE10")]
	public static bool IMFBACMHPLD(KFNFGKAFGLE LFOFDHEGDLC, KFNFGKAFGLE KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79D0780", Offset = "0x79CF980", VA = "0x1879D0780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FKHLDIGBEOP : IEquatable<FKHLDIGBEOP>, IComparable<FKHLDIGBEOP>, GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly FKHLDIGBEOP GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public FKHLDIGBEOP(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40", Slot = "4")]
	public bool Equals(FKHLDIGBEOP JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(FKHLDIGBEOP JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79D0240", Offset = "0x79CF440", VA = "0x1879D0240", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40")]
	public static bool CCHBIHOFELC(FKHLDIGBEOP LFOFDHEGDLC, FKHLDIGBEOP KMPLOMOLJCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79CFE10", Offset = "0x79CF010", VA = "0x1879CFE10")]
	public static bool IMFBACMHPLD(FKHLDIGBEOP LFOFDHEGDLC, FKHLDIGBEOP KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79D02E0", Offset = "0x79CF4E0", VA = "0x1879D02E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct OLKPCCCMIKF : IEquatable<OLKPCCCMIKF>, IComparable<OLKPCCCMIKF>, GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly OLKPCCCMIKF GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public OLKPCCCMIKF(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40", Slot = "4")]
	public bool Equals(OLKPCCCMIKF JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(OLKPCCCMIKF JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x79D0870", Offset = "0x79CFA70", VA = "0x1879D0870", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40")]
	public static bool CCHBIHOFELC(OLKPCCCMIKF LFOFDHEGDLC, OLKPCCCMIKF KMPLOMOLJCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x79CFE10", Offset = "0x79CF010", VA = "0x1879CFE10")]
	public static bool IMFBACMHPLD(OLKPCCCMIKF LFOFDHEGDLC, OLKPCCCMIKF KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x79D0910", Offset = "0x79CFB10", VA = "0x1879D0910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FLOHLNJAHJB : IEquatable<FLOHLNJAHJB>, IComparable<FLOHLNJAHJB>, GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly FLOHLNJAHJB GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public FLOHLNJAHJB(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x79D0350", Offset = "0x79CF550", VA = "0x1879D0350", Slot = "4")]
	public bool Equals(FLOHLNJAHJB JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x79D0380", Offset = "0x79CF580", VA = "0x1879D0380", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x79D0350", Offset = "0x79CF550", VA = "0x1879D0350")]
	public static bool CCHBIHOFELC(FLOHLNJAHJB LFOFDHEGDLC, FLOHLNJAHJB KMPLOMOLJCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x79D0420", Offset = "0x79CF620", VA = "0x1879D0420")]
	public static bool IMFBACMHPLD(FLOHLNJAHJB LFOFDHEGDLC, FLOHLNJAHJB KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(FLOHLNJAHJB JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x79D0450", Offset = "0x79CF650", VA = "0x1879D0450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public FLOHLNJAHJB(EMCONOFBEMC JFKKLHNAHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct DEBJIGNILIH : IEquatable<DEBJIGNILIH>, IComparable<DEBJIGNILIH>, GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly DEBJIGNILIH GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public DEBJIGNILIH(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40", Slot = "4")]
	public bool Equals(DEBJIGNILIH JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(DEBJIGNILIH JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x79D0020", Offset = "0x79CF220", VA = "0x1879D0020", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40")]
	public static bool CCHBIHOFELC(DEBJIGNILIH LFOFDHEGDLC, DEBJIGNILIH KMPLOMOLJCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x79CFE10", Offset = "0x79CF010", VA = "0x1879CFE10")]
	public static bool IMFBACMHPLD(DEBJIGNILIH LFOFDHEGDLC, DEBJIGNILIH KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79D00C0", Offset = "0x79CF2C0", VA = "0x1879D00C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IFNONIKJIIN : IEquatable<IFNONIKJIIN>, IComparable<IFNONIKJIIN>, GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly IFNONIKJIIN GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public IFNONIKJIIN(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40", Slot = "4")]
	public bool Equals(IFNONIKJIIN JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(IFNONIKJIIN JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x79D05D0", Offset = "0x79CF7D0", VA = "0x1879D05D0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40")]
	public static bool CCHBIHOFELC(IFNONIKJIIN LFOFDHEGDLC, IFNONIKJIIN KMPLOMOLJCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x79CFE10", Offset = "0x79CF010", VA = "0x1879CFE10")]
	public static bool IMFBACMHPLD(IFNONIKJIIN LFOFDHEGDLC, IFNONIKJIIN KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79D0670", Offset = "0x79CF870", VA = "0x1879D0670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct HEBNHOMKAPM : IEquatable<HEBNHOMKAPM>, IComparable<HEBNHOMKAPM>, GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HEBNHOMKAPM GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public HEBNHOMKAPM(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40", Slot = "4")]
	public bool Equals(HEBNHOMKAPM JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(HEBNHOMKAPM JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79D04C0", Offset = "0x79CF6C0", VA = "0x1879D04C0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40")]
	public static bool CCHBIHOFELC(HEBNHOMKAPM LFOFDHEGDLC, HEBNHOMKAPM KMPLOMOLJCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79CFE10", Offset = "0x79CF010", VA = "0x1879CFE10")]
	public static bool IMFBACMHPLD(HEBNHOMKAPM LFOFDHEGDLC, HEBNHOMKAPM KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x79D0560", Offset = "0x79CF760", VA = "0x1879D0560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BAGALCLENMK : IEquatable<BAGALCLENMK>, IComparable<BAGALCLENMK>, GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly BAGALCLENMK GNFCEACADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public BAGALCLENMK(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40", Slot = "4")]
	public bool Equals(BAGALCLENMK JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(BAGALCLENMK JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x79CFD70", Offset = "0x79CEF70", VA = "0x1879CFD70", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40")]
	public static bool CCHBIHOFELC(BAGALCLENMK LFOFDHEGDLC, BAGALCLENMK KMPLOMOLJCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x79CFE10", Offset = "0x79CF010", VA = "0x1879CFE10")]
	public static bool IMFBACMHPLD(BAGALCLENMK LFOFDHEGDLC, BAGALCLENMK KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x79CFE40", Offset = "0x79CF040", VA = "0x1879CFE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct AMGFKNBBJGP : IEquatable<AMGFKNBBJGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? FIGGODAHIFJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PHKHHDPEMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x79CF8C0", Offset = "0x79CEAC0", VA = "0x1879CF8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int OHHEEMCKMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x48F2FF0", Offset = "0x48F21F0", VA = "0x1848F2FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x79CFBA0", Offset = "0x79CEDA0", VA = "0x1879CFBA0")]
	public AMGFKNBBJGP(string? NMHNMKFFOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x79CFCF0", Offset = "0x79CEEF0", VA = "0x1879CFCF0")]
	public AMGFKNBBJGP(string?[] PHKGELHGIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x79CF8E0", Offset = "0x79CEAE0", VA = "0x1879CF8E0")]
	private static string?[]? POEBKAODJHF(string?[]? PHKGELHGIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x79CF620", Offset = "0x79CE820", VA = "0x1879CF620")]
	public string CEFAPCEIEAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x79CF710", Offset = "0x79CE910", VA = "0x1879CF710", Slot = "4")]
	public bool Equals(AMGFKNBBJGP JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x79CF680", Offset = "0x79CE880", VA = "0x1879CF680", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x79CF7E0", Offset = "0x79CE9E0", VA = "0x1879CF7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x79CFB10", Offset = "0x79CED10", VA = "0x1879CFB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EMCONOFBEMC : IEquatable<EMCONOFBEMC>, IComparable<EMCONOFBEMC>, GHLPHAHIDFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid IBPGMNEANFH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
	public EMCONOFBEMC(Guid IBPGMNEANFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
	public Guid MBMDCHCHBOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x563CE40", Offset = "0x563C040", VA = "0x18563CE40", Slot = "4")]
	public bool Equals(EMCONOFBEMC JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0", Slot = "5")]
	public int CompareTo(EMCONOFBEMC JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x79D0130", Offset = "0x79CF330", VA = "0x1879D0130", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x563CDC0", Offset = "0x563BFC0", VA = "0x18563CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x79D01D0", Offset = "0x79CF3D0", VA = "0x1879D01D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LNKDLEOEFBN<TModern> : JGGBNBCOJGO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GDCIFHIKKIF(TModern NJJJMPFFCLA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GHLPHAHIDFB
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid MBMDCHCHBOE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JGGBNBCOJGO<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern AOHFPECIEAL(string NJJJMPFFCLA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CNMCLAGJJKN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LNKDLEOEFBN<KFNFGKAFGLE> KHCMGGNEADC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LNKDLEOEFBN<DEBJIGNILIH> JNNGLGGAGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LNKDLEOEFBN<BAGALCLENMK> FNPLBNLFOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LNKDLEOEFBN<FLOHLNJAHJB> JDLMOFFIGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LNKDLEOEFBN<OLKPCCCMIKF> ENAPNLJHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LNKDLEOEFBN<HEBNHOMKAPM> PGEBJAKOLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LNKDLEOEFBN<FKHLDIGBEOP> AHAMBCIIFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LNKDLEOEFBN<IFNONIKJIIN> LPCLLALFNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BFPECPPBGFA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] FPBODCMLGKP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x79CFEB0", Offset = "0x79CF0B0", VA = "0x1879CFEB0")]
	public static string[] ABOOACBHEPD(string? NMHNMKFFOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x79CFF50", Offset = "0x79CF150", VA = "0x1879CFF50")]
	public static string? DLMCBNJFKNM(string? ICHGECIHFKM)
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

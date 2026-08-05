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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E277E0", Offset = "0x8E25DE0", VA = "0x188E277E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LNMALNIAPPD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ANHNANMIGBP(GIJENBMJDLP ECBHOIMIBKD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GIJENBMJDLP LPNJIHLFELG(string ECBHOIMIBKD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct GIJENBMJDLP : IEquatable<GIJENBMJDLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EPGMAHLDJMC AHKPGNJEBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DHFMHNGLGMC FDDFJHHGIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid BFLHNIJGHLK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PIIOBNOCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8E26620", Offset = "0x8E24C20", VA = "0x188E26620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KHIENGJLLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E263C0", Offset = "0x8E249C0", VA = "0x188E263C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8E269B0", Offset = "0x8E24FB0", VA = "0x188E269B0")]
	public GIJENBMJDLP(GIJENBMJDLP DKDBKLLEOBI, [Optional] Guid EJKPIOAFAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x631A7F0", Offset = "0x6318DF0", VA = "0x18631A7F0")]
	public GIJENBMJDLP(EPGMAHLDJMC BNHFGDNPPPD, DHFMHNGLGMC OGKINJEKMNP, [Optional] Guid EJKPIOAFAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8E263F0", Offset = "0x8E249F0", VA = "0x188E263F0", Slot = "4")]
	public bool Equals(GIJENBMJDLP AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8E264B0", Offset = "0x8E24AB0", VA = "0x188E264B0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8E26560", Offset = "0x8E24B60", VA = "0x188E26560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8E265F0", Offset = "0x8E24BF0", VA = "0x188E265F0")]
	public static bool MGLHCKHANFO(GIJENBMJDLP NEOIFOEJGFD, GIJENBMJDLP KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8E266B0", Offset = "0x8E24CB0", VA = "0x188E266B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct EPGMAHLDJMC : IEquatable<EPGMAHLDJMC>, IComparable<EPGMAHLDJMC>, CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly EPGMAHLDJMC HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public EPGMAHLDJMC(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0", Slot = "4")]
	public bool Equals(EPGMAHLDJMC AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(EPGMAHLDJMC AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8E261A0", Offset = "0x8E247A0", VA = "0x188E261A0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0")]
	public static bool MGLHCKHANFO(EPGMAHLDJMC NEOIFOEJGFD, EPGMAHLDJMC KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8E25F90", Offset = "0x8E24590", VA = "0x188E25F90")]
	public static bool HKOGMNAKMAE(EPGMAHLDJMC NEOIFOEJGFD, EPGMAHLDJMC KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8E26240", Offset = "0x8E24840", VA = "0x188E26240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CFGBLEDCLBI : IEquatable<CFGBLEDCLBI>, IComparable<CFGBLEDCLBI>, CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly CFGBLEDCLBI HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public CFGBLEDCLBI(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0", Slot = "4")]
	public bool Equals(CFGBLEDCLBI AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(CFGBLEDCLBI AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8E25EF0", Offset = "0x8E244F0", VA = "0x188E25EF0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0")]
	public static bool MGLHCKHANFO(CFGBLEDCLBI NEOIFOEJGFD, CFGBLEDCLBI KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8E25F90", Offset = "0x8E24590", VA = "0x188E25F90")]
	public static bool HKOGMNAKMAE(CFGBLEDCLBI NEOIFOEJGFD, CFGBLEDCLBI KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8E25FC0", Offset = "0x8E245C0", VA = "0x188E25FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HBALGBNKPFA : IEquatable<HBALGBNKPFA>, IComparable<HBALGBNKPFA>, CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly HBALGBNKPFA HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public HBALGBNKPFA(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0", Slot = "4")]
	public bool Equals(HBALGBNKPFA AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(HBALGBNKPFA AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8E269D0", Offset = "0x8E24FD0", VA = "0x188E269D0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0")]
	public static bool MGLHCKHANFO(HBALGBNKPFA NEOIFOEJGFD, HBALGBNKPFA KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8E25F90", Offset = "0x8E24590", VA = "0x188E25F90")]
	public static bool HKOGMNAKMAE(HBALGBNKPFA NEOIFOEJGFD, HBALGBNKPFA KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8E26A70", Offset = "0x8E25070", VA = "0x188E26A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DHFMHNGLGMC : IEquatable<DHFMHNGLGMC>, IComparable<DHFMHNGLGMC>, CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly DHFMHNGLGMC HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public DHFMHNGLGMC(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8E26030", Offset = "0x8E24630", VA = "0x188E26030", Slot = "4")]
	public bool Equals(DHFMHNGLGMC AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8E26060", Offset = "0x8E24660", VA = "0x188E26060", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8E26030", Offset = "0x8E24630", VA = "0x188E26030")]
	public static bool MGLHCKHANFO(DHFMHNGLGMC NEOIFOEJGFD, DHFMHNGLGMC KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8E26100", Offset = "0x8E24700", VA = "0x188E26100")]
	public static bool HKOGMNAKMAE(DHFMHNGLGMC NEOIFOEJGFD, DHFMHNGLGMC KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(DHFMHNGLGMC AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8E26130", Offset = "0x8E24730", VA = "0x188E26130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public DHFMHNGLGMC(NCLFEOAAANB IGDGNOPNECP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LDACNMBAKAL : IEquatable<LDACNMBAKAL>, IComparable<LDACNMBAKAL>, CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly LDACNMBAKAL HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public LDACNMBAKAL(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0", Slot = "4")]
	public bool Equals(LDACNMBAKAL AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(LDACNMBAKAL AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8E274B0", Offset = "0x8E25AB0", VA = "0x188E274B0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0")]
	public static bool MGLHCKHANFO(LDACNMBAKAL NEOIFOEJGFD, LDACNMBAKAL KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8E25F90", Offset = "0x8E24590", VA = "0x188E25F90")]
	public static bool HKOGMNAKMAE(LDACNMBAKAL NEOIFOEJGFD, LDACNMBAKAL KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8E27550", Offset = "0x8E25B50", VA = "0x188E27550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct KKNCLIFJEEB : IEquatable<KKNCLIFJEEB>, IComparable<KKNCLIFJEEB>, CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly KKNCLIFJEEB HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public KKNCLIFJEEB(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0", Slot = "4")]
	public bool Equals(KKNCLIFJEEB AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(KKNCLIFJEEB AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8E26C50", Offset = "0x8E25250", VA = "0x188E26C50", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0")]
	public static bool MGLHCKHANFO(KKNCLIFJEEB NEOIFOEJGFD, KKNCLIFJEEB KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8E25F90", Offset = "0x8E24590", VA = "0x188E25F90")]
	public static bool HKOGMNAKMAE(KKNCLIFJEEB NEOIFOEJGFD, KKNCLIFJEEB KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8E26CF0", Offset = "0x8E252F0", VA = "0x188E26CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct NACGCPOMKKF : IEquatable<NACGCPOMKKF>, IComparable<NACGCPOMKKF>, CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly NACGCPOMKKF HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public NACGCPOMKKF(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0", Slot = "4")]
	public bool Equals(NACGCPOMKKF AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(NACGCPOMKKF AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8E275C0", Offset = "0x8E25BC0", VA = "0x188E275C0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0")]
	public static bool MGLHCKHANFO(NACGCPOMKKF NEOIFOEJGFD, NACGCPOMKKF KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8E25F90", Offset = "0x8E24590", VA = "0x188E25F90")]
	public static bool HKOGMNAKMAE(NACGCPOMKKF NEOIFOEJGFD, NACGCPOMKKF KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8E27660", Offset = "0x8E25C60", VA = "0x188E27660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GDAILFHEPJD : IEquatable<GDAILFHEPJD>, IComparable<GDAILFHEPJD>, CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly GDAILFHEPJD HPOBBIFAPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public GDAILFHEPJD(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0", Slot = "4")]
	public bool Equals(GDAILFHEPJD AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(GDAILFHEPJD AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8E262B0", Offset = "0x8E248B0", VA = "0x188E262B0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0")]
	public static bool MGLHCKHANFO(GDAILFHEPJD NEOIFOEJGFD, GDAILFHEPJD KNACFLNMNOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8E25F90", Offset = "0x8E24590", VA = "0x188E25F90")]
	public static bool HKOGMNAKMAE(GDAILFHEPJD NEOIFOEJGFD, GDAILFHEPJD KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8E26350", Offset = "0x8E24950", VA = "0x188E26350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct KOBFNKPKHBD : IEquatable<KOBFNKPKHBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? DHKPDDMKMNK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DEKPKOANCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8E26EC0", Offset = "0x8E254C0", VA = "0x188E26EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int OPDLHEBPJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5971830", Offset = "0x596FE30", VA = "0x185971830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8E272E0", Offset = "0x8E258E0", VA = "0x188E272E0")]
	public KOBFNKPKHBD(string? MPIOANKALFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8E27430", Offset = "0x8E25A30", VA = "0x188E27430")]
	public KOBFNKPKHBD(string?[] GMKAKOONEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8E27020", Offset = "0x8E25620", VA = "0x188E27020")]
	private static string?[]? OLIDCIDDIFI(string?[]? GMKAKOONEJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8E26FC0", Offset = "0x8E255C0", VA = "0x188E26FC0")]
	public string MFMHLNHFOAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8E26D60", Offset = "0x8E25360", VA = "0x188E26D60", Slot = "4")]
	public bool Equals(KOBFNKPKHBD AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8E26E30", Offset = "0x8E25430", VA = "0x188E26E30", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8E26EE0", Offset = "0x8E254E0", VA = "0x188E26EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8E27250", Offset = "0x8E25850", VA = "0x188E27250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NCLFEOAAANB : IEquatable<NCLFEOAAANB>, IComparable<NCLFEOAAANB>, CCOONKOMFAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid JJCLDINKIFD;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
	public NCLFEOAAANB(Guid JJCLDINKIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public Guid JGIEIICPJCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5160CF0", Offset = "0x515F2F0", VA = "0x185160CF0", Slot = "4")]
	public bool Equals(NCLFEOAAANB AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5160990", Offset = "0x515EF90", VA = "0x185160990", Slot = "5")]
	public int CompareTo(NCLFEOAAANB AAGCKLPFJME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8E276D0", Offset = "0x8E25CD0", VA = "0x188E276D0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5160BD0", Offset = "0x515F1D0", VA = "0x185160BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8E27770", Offset = "0x8E25D70", VA = "0x188E27770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FMNKFJKCOEF<TModern> : AJNLLAOOPMG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OEGCKMMLIFM(TModern CDOKMBOBFFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CCOONKOMFAG
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid JGIEIICPJCB();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AJNLLAOOPMG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern DIOLLNNDLPB(string CDOKMBOBFFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HPEMFPFEPIB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FMNKFJKCOEF<EPGMAHLDJMC> KCJPFACCOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FMNKFJKCOEF<LDACNMBAKAL> PKJIKBOJOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FMNKFJKCOEF<GDAILFHEPJD> KODLABNDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FMNKFJKCOEF<DHFMHNGLGMC> KICMAEDPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FMNKFJKCOEF<HBALGBNKPFA> EIFJILBDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FMNKFJKCOEF<NACGCPOMKKF> IGBIDCNMIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FMNKFJKCOEF<CFGBLEDCLBI> EGFEMDMEIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FMNKFJKCOEF<KKNCLIFJEEB> LGMNDLMFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IOGGDKAKNLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] EMOPODPBEFH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8E26AE0", Offset = "0x8E250E0", VA = "0x188E26AE0")]
	public static string[] JEBIEDGDDGF(string? MPIOANKALFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8E26B80", Offset = "0x8E25180", VA = "0x188E26B80")]
	public static string? NNHGBPPOODD(string? BNHFGDNPPPD)
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

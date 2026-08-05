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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E7870", Offset = "0x65E6270", VA = "0x1865E7870")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MHEPMAMOHPL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LENOCDGJGPN(DEPKPIDHOHK KODNHMICLEA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DEPKPIDHOHK AFFCBAMFOKP(string KODNHMICLEA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DEPKPIDHOHK : IEquatable<DEPKPIDHOHK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DLCIPFPLACJ GOANGGKMFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FPOFKGIDGFO CBPMKHGHJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid BHNIEKNFOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? IOBPIGDBBDM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DIHLBDPNBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65E5C30", Offset = "0x65E4630", VA = "0x1865E5C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BHIJGFPPPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x65E60B0", Offset = "0x65E4AB0", VA = "0x1865E60B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65E64F0", Offset = "0x65E4EF0", VA = "0x1865E64F0")]
	public DEPKPIDHOHK(DEPKPIDHOHK CCFEOGJKODB, [Optional] Guid KCOBLCGOJEP, [Optional] RRColor? IKNGOAKEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x65E6580", Offset = "0x65E4F80", VA = "0x1865E6580")]
	public DEPKPIDHOHK(DLCIPFPLACJ BCIIPMHFIPL, FPOFKGIDGFO KLBHMHKPCDA, [Optional] Guid KCOBLCGOJEP, [Optional] RRColor? IKNGOAKEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65E5D60", Offset = "0x65E4760", VA = "0x1865E5D60", Slot = "4")]
	public bool Equals(DEPKPIDHOHK AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65E5E60", Offset = "0x65E4860", VA = "0x1865E5E60", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65E5FC0", Offset = "0x65E49C0", VA = "0x1865E5FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x65E5F50", Offset = "0x65E4950", VA = "0x1865E5F50")]
	public static bool FFFIMEBHMPG(DEPKPIDHOHK JIKBDKDLPCA, DEPKPIDHOHK DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65E5CF0", Offset = "0x65E46F0", VA = "0x1865E5CF0")]
	public static bool DKCGANGKMBM(DEPKPIDHOHK JIKBDKDLPCA, DEPKPIDHOHK DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x65E60F0", Offset = "0x65E4AF0", VA = "0x1865E60F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DLCIPFPLACJ : IEquatable<DLCIPFPLACJ>, IComparable<DLCIPFPLACJ>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly DLCIPFPLACJ FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public DLCIPFPLACJ(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(DLCIPFPLACJ AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(DLCIPFPLACJ AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x65E6610", Offset = "0x65E5010", VA = "0x1865E6610", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460")]
	public static bool FFFIMEBHMPG(DLCIPFPLACJ JIKBDKDLPCA, DLCIPFPLACJ DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E42D0", VA = "0x1865E58D0")]
	public static bool DKCGANGKMBM(DLCIPFPLACJ JIKBDKDLPCA, DLCIPFPLACJ DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65E66B0", Offset = "0x65E50B0", VA = "0x1865E66B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ILAFEIKLBFM : IEquatable<ILAFEIKLBFM>, IComparable<ILAFEIKLBFM>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly ILAFEIKLBFM FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public ILAFEIKLBFM(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(ILAFEIKLBFM AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(ILAFEIKLBFM AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x65E7340", Offset = "0x65E5D40", VA = "0x1865E7340", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460")]
	public static bool FFFIMEBHMPG(ILAFEIKLBFM JIKBDKDLPCA, ILAFEIKLBFM DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E42D0", VA = "0x1865E58D0")]
	public static bool DKCGANGKMBM(ILAFEIKLBFM JIKBDKDLPCA, ILAFEIKLBFM DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x65E73E0", Offset = "0x65E5DE0", VA = "0x1865E73E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct AEHFHAKAFIE : IEquatable<AEHFHAKAFIE>, IComparable<AEHFHAKAFIE>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly AEHFHAKAFIE FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public AEHFHAKAFIE(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(AEHFHAKAFIE AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(AEHFHAKAFIE AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65E5900", Offset = "0x65E4300", VA = "0x1865E5900", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460")]
	public static bool FFFIMEBHMPG(AEHFHAKAFIE JIKBDKDLPCA, AEHFHAKAFIE DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E42D0", VA = "0x1865E58D0")]
	public static bool DKCGANGKMBM(AEHFHAKAFIE JIKBDKDLPCA, AEHFHAKAFIE DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65E59A0", Offset = "0x65E43A0", VA = "0x1865E59A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FPOFKGIDGFO : IEquatable<FPOFKGIDGFO>, IComparable<FPOFKGIDGFO>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly FPOFKGIDGFO FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IMCFECPEKCC FEBAAINJKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0")]
		[CompilerGenerated]
		get
		{
			return default(IMCFECPEKCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IMCFECPEKCC LNHJBOFEPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEEEDE0", Offset = "0xEED7E0", VA = "0x180EEEDE0")]
		[CompilerGenerated]
		get
		{
			return default(IMCFECPEKCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IMCFECPEKCC CBBDBPNCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE56B70", Offset = "0xE55570", VA = "0x180E56B70")]
		[CompilerGenerated]
		get
		{
			return default(IMCFECPEKCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65E71A0", Offset = "0x65E5BA0", VA = "0x1865E71A0")]
	public FPOFKGIDGFO(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x65E71E0", Offset = "0x65E5BE0", VA = "0x1865E71E0")]
	public FPOFKGIDGFO(IMCFECPEKCC GEAABGECEPP, IMCFECPEKCC LICPAJIGAOC, IMCFECPEKCC OCBODKPNEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x65E7000", Offset = "0x65E5A00", VA = "0x1865E7000")]
	private Guid MGOIAJPBJGM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x65E6EE0", Offset = "0x65E58E0", VA = "0x1865E6EE0", Slot = "4")]
	public bool Equals(FPOFKGIDGFO AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65E6F10", Offset = "0x65E5910", VA = "0x1865E6F10", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x65E6FC0", Offset = "0x65E59C0", VA = "0x1865E6FC0")]
	public static bool FFFIMEBHMPG(FPOFKGIDGFO JIKBDKDLPCA, FPOFKGIDGFO DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x65E6EA0", Offset = "0x65E58A0", VA = "0x1865E6EA0")]
	public static bool DKCGANGKMBM(FPOFKGIDGFO JIKBDKDLPCA, FPOFKGIDGFO DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x65E6E60", Offset = "0x65E5860", VA = "0x1865E6E60", Slot = "5")]
	public int CompareTo(FPOFKGIDGFO AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65E7130", Offset = "0x65E5B30", VA = "0x1865E7130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct KDNOFOFAIJL : IEquatable<KDNOFOFAIJL>, IComparable<KDNOFOFAIJL>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KDNOFOFAIJL FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public KDNOFOFAIJL(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(KDNOFOFAIJL AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(KDNOFOFAIJL AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x65E7560", Offset = "0x65E5F60", VA = "0x1865E7560", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460")]
	public static bool FFFIMEBHMPG(KDNOFOFAIJL JIKBDKDLPCA, KDNOFOFAIJL DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E42D0", VA = "0x1865E58D0")]
	public static bool DKCGANGKMBM(KDNOFOFAIJL JIKBDKDLPCA, KDNOFOFAIJL DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x65E7600", Offset = "0x65E6000", VA = "0x1865E7600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IGJMEGNFAKG : IEquatable<IGJMEGNFAKG>, IComparable<IGJMEGNFAKG>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly IGJMEGNFAKG FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public IGJMEGNFAKG(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(IGJMEGNFAKG AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(IGJMEGNFAKG AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x65E7230", Offset = "0x65E5C30", VA = "0x1865E7230", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460")]
	public static bool FFFIMEBHMPG(IGJMEGNFAKG JIKBDKDLPCA, IGJMEGNFAKG DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E42D0", VA = "0x1865E58D0")]
	public static bool DKCGANGKMBM(IGJMEGNFAKG JIKBDKDLPCA, IGJMEGNFAKG DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x65E72D0", Offset = "0x65E5CD0", VA = "0x1865E72D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BGNICMAMCHH : IEquatable<BGNICMAMCHH>, IComparable<BGNICMAMCHH>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly BGNICMAMCHH FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public BGNICMAMCHH(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(BGNICMAMCHH AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(BGNICMAMCHH AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x65E5A10", Offset = "0x65E4410", VA = "0x1865E5A10", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460")]
	public static bool FFFIMEBHMPG(BGNICMAMCHH JIKBDKDLPCA, BGNICMAMCHH DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E42D0", VA = "0x1865E58D0")]
	public static bool DKCGANGKMBM(BGNICMAMCHH JIKBDKDLPCA, BGNICMAMCHH DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x65E5AB0", Offset = "0x65E44B0", VA = "0x1865E5AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct LLENMLIJPDM : IEquatable<LLENMLIJPDM>, IComparable<LLENMLIJPDM>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly LLENMLIJPDM FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public LLENMLIJPDM(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(LLENMLIJPDM AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(LLENMLIJPDM AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x65E7760", Offset = "0x65E6160", VA = "0x1865E7760", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460")]
	public static bool FFFIMEBHMPG(LLENMLIJPDM JIKBDKDLPCA, LLENMLIJPDM DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E42D0", VA = "0x1865E58D0")]
	public static bool DKCGANGKMBM(LLENMLIJPDM JIKBDKDLPCA, LLENMLIJPDM DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65E7800", Offset = "0x65E6200", VA = "0x1865E7800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FFMJJHCDAKC : IEquatable<FFMJJHCDAKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? DJJBHLNLOCN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool INMLDJBGPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x65E6950", Offset = "0x65E5350", VA = "0x1865E6950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int DEEBFOGJGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4E80", Offset = "0x3AE3880", VA = "0x183AE4E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x65E6D20", Offset = "0x65E5720", VA = "0x1865E6D20")]
	public FFMJJHCDAKC(string? LMGLNGKMGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x65E6CA0", Offset = "0x65E56A0", VA = "0x1865E6CA0")]
	public FFMJJHCDAKC(string?[] OACDMILJLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x65E6720", Offset = "0x65E5120", VA = "0x1865E6720")]
	private static string?[]? DCNEIGPJKCG(string?[]? OACDMILJLON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x65E6BB0", Offset = "0x65E55B0", VA = "0x1865E6BB0")]
	public string OAMNDLKFMEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x65E6970", Offset = "0x65E5370", VA = "0x1865E6970", Slot = "4")]
	public bool Equals(FFMJJHCDAKC AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65E6A40", Offset = "0x65E5440", VA = "0x1865E6A40", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x65E6AD0", Offset = "0x65E54D0", VA = "0x1865E6AD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x65E6C10", Offset = "0x65E5610", VA = "0x1865E6C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IMCFECPEKCC : IEquatable<IMCFECPEKCC>, IComparable<IMCFECPEKCC>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly IMCFECPEKCC FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public IMCFECPEKCC(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(IMCFECPEKCC AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(IMCFECPEKCC AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x65E7450", Offset = "0x65E5E50", VA = "0x1865E7450", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460")]
	public static bool FFFIMEBHMPG(IMCFECPEKCC JIKBDKDLPCA, IMCFECPEKCC DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x65E74F0", Offset = "0x65E5EF0", VA = "0x1865E74F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DDLEAKCFLIB : IEquatable<DDLEAKCFLIB>, IComparable<DDLEAKCFLIB>, HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly DDLEAKCFLIB FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid INAIFGAIEKH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
	public DDLEAKCFLIB(Guid INAIFGAIEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public Guid LFHKFANHHHH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3A27460", Offset = "0x3A25E60", VA = "0x183A27460", Slot = "4")]
	public bool Equals(DDLEAKCFLIB AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A27140", Offset = "0x3A25B40", VA = "0x183A27140", Slot = "5")]
	public int CompareTo(DDLEAKCFLIB AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x65E5B20", Offset = "0x65E4520", VA = "0x1865E5B20", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A272A0", Offset = "0x3A25CA0", VA = "0x183A272A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E42D0", VA = "0x1865E58D0")]
	public static bool DKCGANGKMBM(DDLEAKCFLIB JIKBDKDLPCA, DDLEAKCFLIB DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x65E5BC0", Offset = "0x65E45C0", VA = "0x1865E5BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LCNLILMMGHO<TModern> : HOAIMKGAGMM<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PPCIEDKPNMK(TModern GMJDFKDGHIN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HLNONMJKGEK
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid LFHKFANHHHH();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HOAIMKGAGMM<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern BHKEPPCFJEG(string GMJDFKDGHIN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CLLDHNDLCKB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LCNLILMMGHO<DLCIPFPLACJ> HCMNNPOEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LCNLILMMGHO<KDNOFOFAIJL> JDLIKKLICGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LCNLILMMGHO<LLENMLIJPDM> ONFMGPOBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LCNLILMMGHO<FPOFKGIDGFO> MCANIPAOLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LCNLILMMGHO<AEHFHAKAFIE> EDPPBKBIBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LCNLILMMGHO<BGNICMAMCHH> OPOELKENAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LCNLILMMGHO<ILAFEIKLBFM> BLKPAKHEJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	LCNLILMMGHO<IGJMEGNFAKG> AEEMKFMLPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KGIMMHNPFNO
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x65E7670", Offset = "0x65E6070", VA = "0x1865E7670")]
	public static string[] MAFFJPFDCBP(string? LMGLNGKMGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x65E7730", Offset = "0x65E6130", VA = "0x1865E7730")]
	public static string? MIPMFLAGADK(string? BCIIPMHFIPL)
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

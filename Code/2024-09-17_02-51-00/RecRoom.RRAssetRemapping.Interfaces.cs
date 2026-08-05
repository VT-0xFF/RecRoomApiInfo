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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x737FBE0", Offset = "0x737E5E0", VA = "0x18737FBE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BEECDDPFNOF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AMCHBAGBIFH(EBOIDAOENMM DIGEGMNKCOG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EBOIDAOENMM CENBFOHJAFB(string DIGEGMNKCOG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct EBOIDAOENMM : IEquatable<EBOIDAOENMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EHINIDBNANO PFPEECCDOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PELNEICAOKM DMONOEBCKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid GCIKBDPJIIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GHHKFLLMJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x737ECA0", Offset = "0x737D6A0", VA = "0x18737ECA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KHLAMNCHIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x737EC30", Offset = "0x737D630", VA = "0x18737EC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x737F030", Offset = "0x737DA30", VA = "0x18737F030")]
	public EBOIDAOENMM(EBOIDAOENMM FECDHPCPDHC, [Optional] Guid FLHPJBIPCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F3CCD0", Offset = "0x4F3B6D0", VA = "0x184F3CCD0")]
	public EBOIDAOENMM(EHINIDBNANO IMJOCPOEBDC, PELNEICAOKM JFPBOCJOGPG, [Optional] Guid FLHPJBIPCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x737EAA0", Offset = "0x737D4A0", VA = "0x18737EAA0", Slot = "4")]
	public bool Equals(EBOIDAOENMM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x737E9F0", Offset = "0x737D3F0", VA = "0x18737E9F0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x737EB60", Offset = "0x737D560", VA = "0x18737EB60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x737EC70", Offset = "0x737D670", VA = "0x18737EC70")]
	public static bool MNAFCOICNLK(EBOIDAOENMM NFCDCHABNCB, EBOIDAOENMM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x737EBF0", Offset = "0x737D5F0", VA = "0x18737EBF0")]
	public static bool KIKJPCCIIDN(EBOIDAOENMM NFCDCHABNCB, EBOIDAOENMM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x737ED30", Offset = "0x737D730", VA = "0x18737ED30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct EHINIDBNANO : IEquatable<EHINIDBNANO>, IComparable<EHINIDBNANO>, FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly EHINIDBNANO PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public EHINIDBNANO(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20", Slot = "4")]
	public bool Equals(EHINIDBNANO PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(EHINIDBNANO PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x737F050", Offset = "0x737DA50", VA = "0x18737F050", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20")]
	public static bool MNAFCOICNLK(EHINIDBNANO NFCDCHABNCB, EHINIDBNANO BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x737E950", Offset = "0x737D350", VA = "0x18737E950")]
	public static bool KIKJPCCIIDN(EHINIDBNANO NFCDCHABNCB, EHINIDBNANO BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x737F0F0", Offset = "0x737DAF0", VA = "0x18737F0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NCHIFEMIBHL : IEquatable<NCHIFEMIBHL>, IComparable<NCHIFEMIBHL>, FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly NCHIFEMIBHL PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public NCHIFEMIBHL(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20", Slot = "4")]
	public bool Equals(NCHIFEMIBHL PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(NCHIFEMIBHL PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x737FAD0", Offset = "0x737E4D0", VA = "0x18737FAD0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20")]
	public static bool MNAFCOICNLK(NCHIFEMIBHL NFCDCHABNCB, NCHIFEMIBHL BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x737E950", Offset = "0x737D350", VA = "0x18737E950")]
	public static bool KIKJPCCIIDN(NCHIFEMIBHL NFCDCHABNCB, NCHIFEMIBHL BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x737FB70", Offset = "0x737E570", VA = "0x18737FB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct IBPLBEBNLMD : IEquatable<IBPLBEBNLMD>, IComparable<IBPLBEBNLMD>, FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly IBPLBEBNLMD PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public IBPLBEBNLMD(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20", Slot = "4")]
	public bool Equals(IBPLBEBNLMD PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(IBPLBEBNLMD PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x737F9C0", Offset = "0x737E3C0", VA = "0x18737F9C0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20")]
	public static bool MNAFCOICNLK(IBPLBEBNLMD NFCDCHABNCB, IBPLBEBNLMD BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x737E950", Offset = "0x737D350", VA = "0x18737E950")]
	public static bool KIKJPCCIIDN(IBPLBEBNLMD NFCDCHABNCB, IBPLBEBNLMD BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x737FA60", Offset = "0x737E460", VA = "0x18737FA60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PELNEICAOKM : IEquatable<PELNEICAOKM>, IComparable<PELNEICAOKM>, FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly PELNEICAOKM PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public PELNEICAOKM(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x737FE80", Offset = "0x737E880", VA = "0x18737FE80", Slot = "4")]
	public bool Equals(PELNEICAOKM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x737FEB0", Offset = "0x737E8B0", VA = "0x18737FEB0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x737FE80", Offset = "0x737E880", VA = "0x18737FE80")]
	public static bool MNAFCOICNLK(PELNEICAOKM NFCDCHABNCB, PELNEICAOKM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x737FF50", Offset = "0x737E950", VA = "0x18737FF50")]
	public static bool KIKJPCCIIDN(PELNEICAOKM NFCDCHABNCB, PELNEICAOKM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(PELNEICAOKM PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x737FF80", Offset = "0x737E980", VA = "0x18737FF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public PELNEICAOKM(OBAADAMJMCC OAHGDGHMOMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HIKPLHMBBLA : IEquatable<HIKPLHMBBLA>, IComparable<HIKPLHMBBLA>, FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly HIKPLHMBBLA PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public HIKPLHMBBLA(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20", Slot = "4")]
	public bool Equals(HIKPLHMBBLA PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(HIKPLHMBBLA PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x737F8B0", Offset = "0x737E2B0", VA = "0x18737F8B0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20")]
	public static bool MNAFCOICNLK(HIKPLHMBBLA NFCDCHABNCB, HIKPLHMBBLA BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x737E950", Offset = "0x737D350", VA = "0x18737E950")]
	public static bool KIKJPCCIIDN(HIKPLHMBBLA NFCDCHABNCB, HIKPLHMBBLA BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x737F950", Offset = "0x737E350", VA = "0x18737F950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DFIACMOLAPM : IEquatable<DFIACMOLAPM>, IComparable<DFIACMOLAPM>, FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DFIACMOLAPM PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public DFIACMOLAPM(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20", Slot = "4")]
	public bool Equals(DFIACMOLAPM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(DFIACMOLAPM PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x737E8B0", Offset = "0x737D2B0", VA = "0x18737E8B0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20")]
	public static bool MNAFCOICNLK(DFIACMOLAPM NFCDCHABNCB, DFIACMOLAPM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x737E950", Offset = "0x737D350", VA = "0x18737E950")]
	public static bool KIKJPCCIIDN(DFIACMOLAPM NFCDCHABNCB, DFIACMOLAPM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x737E980", Offset = "0x737D380", VA = "0x18737E980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct OAGOEKHDGKK : IEquatable<OAGOEKHDGKK>, IComparable<OAGOEKHDGKK>, FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly OAGOEKHDGKK PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public OAGOEKHDGKK(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20", Slot = "4")]
	public bool Equals(OAGOEKHDGKK PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(OAGOEKHDGKK PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x737FC60", Offset = "0x737E660", VA = "0x18737FC60", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20")]
	public static bool MNAFCOICNLK(OAGOEKHDGKK NFCDCHABNCB, OAGOEKHDGKK BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x737E950", Offset = "0x737D350", VA = "0x18737E950")]
	public static bool KIKJPCCIIDN(OAGOEKHDGKK NFCDCHABNCB, OAGOEKHDGKK BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x737FD00", Offset = "0x737E700", VA = "0x18737FD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PJKGNECFBON : IEquatable<PJKGNECFBON>, IComparable<PJKGNECFBON>, FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PJKGNECFBON PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public PJKGNECFBON(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20", Slot = "4")]
	public bool Equals(PJKGNECFBON PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(PJKGNECFBON PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7380150", Offset = "0x737EB50", VA = "0x187380150", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20")]
	public static bool MNAFCOICNLK(PJKGNECFBON NFCDCHABNCB, PJKGNECFBON BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x737E950", Offset = "0x737D350", VA = "0x18737E950")]
	public static bool KIKJPCCIIDN(PJKGNECFBON NFCDCHABNCB, PJKGNECFBON BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x73801F0", Offset = "0x737EBF0", VA = "0x1873801F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FEDCEIEOEHM : IEquatable<FEDCEIEOEHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? LNEMBJEMEJJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FKPHAIMPOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x737F630", Offset = "0x737E030", VA = "0x18737F630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int HBFDEEMJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x43CAA30", Offset = "0x43C9430", VA = "0x1843CAA30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x737F6E0", Offset = "0x737E0E0", VA = "0x18737F6E0")]
	public FEDCEIEOEHM(string? GGAEGHOGGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x737F830", Offset = "0x737E230", VA = "0x18737F830")]
	public FEDCEIEOEHM(string?[] MPENFNOCBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x737F400", Offset = "0x737DE00", VA = "0x18737F400")]
	private static string?[]? IFANFOAIPJF(string?[]? MPENFNOCBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x737F2C0", Offset = "0x737DCC0", VA = "0x18737F2C0")]
	public string FLBHECEJJDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x737F1F0", Offset = "0x737DBF0", VA = "0x18737F1F0", Slot = "4")]
	public bool Equals(FEDCEIEOEHM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x737F160", Offset = "0x737DB60", VA = "0x18737F160", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x737F320", Offset = "0x737DD20", VA = "0x18737F320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x737F650", Offset = "0x737E050", VA = "0x18737F650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OBAADAMJMCC : IEquatable<OBAADAMJMCC>, IComparable<OBAADAMJMCC>, FFEKDPGODPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid GDCMEHKEAMI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
	public OBAADAMJMCC(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x427CA20", Offset = "0x427B420", VA = "0x18427CA20", Slot = "4")]
	public bool Equals(OBAADAMJMCC PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x427C910", Offset = "0x427B310", VA = "0x18427C910", Slot = "5")]
	public int CompareTo(OBAADAMJMCC PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x737FD70", Offset = "0x737E770", VA = "0x18737FD70", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x427CAE0", Offset = "0x427B4E0", VA = "0x18427CAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x737FE10", Offset = "0x737E810", VA = "0x18737FE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NBNELONLMLH<TModern> : NIEIFGIJBPP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EIBNLPNKOCH(TModern LPMOOBPJNHL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FFEKDPGODPD
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid CPCFJABKHLP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NIEIFGIJBPP<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern NJNDFGJBCAG(string LPMOOBPJNHL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IKLEIDMNHGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NBNELONLMLH<EHINIDBNANO> KHOBNAPJECF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NBNELONLMLH<HIKPLHMBBLA> GGIJEGCALME
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NBNELONLMLH<PJKGNECFBON> HFOCFHACDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NBNELONLMLH<PELNEICAOKM> PCODLKCIMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NBNELONLMLH<IBPLBEBNLMD> BIGFPKNDJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NBNELONLMLH<OAGOEKHDGKK> NKKINHBECDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NBNELONLMLH<NCHIFEMIBHL> DBJOMKCGFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NBNELONLMLH<DFIACMOLAPM> MPMIPMMIOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PIEEKCNMGFI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] GPCGBCOJFMK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7380020", Offset = "0x737EA20", VA = "0x187380020")]
	public static string[] GKAJICPMMPE(string? GGAEGHOGGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x737FFF0", Offset = "0x737E9F0", VA = "0x18737FFF0")]
	public static string? DBMHBPFDMGB(string? IMJOCPOEBDC)
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

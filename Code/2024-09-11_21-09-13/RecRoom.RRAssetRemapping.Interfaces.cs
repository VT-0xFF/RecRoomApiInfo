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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x72946E0", Offset = "0x7292CE0", VA = "0x1872946E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x72937A0", Offset = "0x7291DA0", VA = "0x1872937A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KHLAMNCHIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7293730", Offset = "0x7291D30", VA = "0x187293730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7293B30", Offset = "0x7292130", VA = "0x187293B30")]
	public EBOIDAOENMM(EBOIDAOENMM FECDHPCPDHC, [Optional] Guid FLHPJBIPCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DBB0", Offset = "0x4E6C1B0", VA = "0x184E6DBB0")]
	public EBOIDAOENMM(EHINIDBNANO IMJOCPOEBDC, PELNEICAOKM JFPBOCJOGPG, [Optional] Guid FLHPJBIPCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72935A0", Offset = "0x7291BA0", VA = "0x1872935A0", Slot = "4")]
	public bool Equals(EBOIDAOENMM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72934F0", Offset = "0x7291AF0", VA = "0x1872934F0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7293660", Offset = "0x7291C60", VA = "0x187293660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7293770", Offset = "0x7291D70", VA = "0x187293770")]
	public static bool MNAFCOICNLK(EBOIDAOENMM NFCDCHABNCB, EBOIDAOENMM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72936F0", Offset = "0x7291CF0", VA = "0x1872936F0")]
	public static bool KIKJPCCIIDN(EBOIDAOENMM NFCDCHABNCB, EBOIDAOENMM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7293830", Offset = "0x7291E30", VA = "0x187293830", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public EHINIDBNANO(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0", Slot = "4")]
	public bool Equals(EHINIDBNANO PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(EHINIDBNANO PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7293B50", Offset = "0x7292150", VA = "0x187293B50", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0")]
	public static bool MNAFCOICNLK(EHINIDBNANO NFCDCHABNCB, EHINIDBNANO BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7293450", Offset = "0x7291A50", VA = "0x187293450")]
	public static bool KIKJPCCIIDN(EHINIDBNANO NFCDCHABNCB, EHINIDBNANO BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7293BF0", Offset = "0x72921F0", VA = "0x187293BF0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public NCHIFEMIBHL(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0", Slot = "4")]
	public bool Equals(NCHIFEMIBHL PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(NCHIFEMIBHL PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72945D0", Offset = "0x7292BD0", VA = "0x1872945D0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0")]
	public static bool MNAFCOICNLK(NCHIFEMIBHL NFCDCHABNCB, NCHIFEMIBHL BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7293450", Offset = "0x7291A50", VA = "0x187293450")]
	public static bool KIKJPCCIIDN(NCHIFEMIBHL NFCDCHABNCB, NCHIFEMIBHL BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7294670", Offset = "0x7292C70", VA = "0x187294670", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public IBPLBEBNLMD(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0", Slot = "4")]
	public bool Equals(IBPLBEBNLMD PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(IBPLBEBNLMD PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72944C0", Offset = "0x7292AC0", VA = "0x1872944C0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0")]
	public static bool MNAFCOICNLK(IBPLBEBNLMD NFCDCHABNCB, IBPLBEBNLMD BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7293450", Offset = "0x7291A50", VA = "0x187293450")]
	public static bool KIKJPCCIIDN(IBPLBEBNLMD NFCDCHABNCB, IBPLBEBNLMD BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7294560", Offset = "0x7292B60", VA = "0x187294560", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public PELNEICAOKM(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7294980", Offset = "0x7292F80", VA = "0x187294980", Slot = "4")]
	public bool Equals(PELNEICAOKM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72949B0", Offset = "0x7292FB0", VA = "0x1872949B0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7294980", Offset = "0x7292F80", VA = "0x187294980")]
	public static bool MNAFCOICNLK(PELNEICAOKM NFCDCHABNCB, PELNEICAOKM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7294A50", Offset = "0x7293050", VA = "0x187294A50")]
	public static bool KIKJPCCIIDN(PELNEICAOKM NFCDCHABNCB, PELNEICAOKM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(PELNEICAOKM PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7294A80", Offset = "0x7293080", VA = "0x187294A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public HIKPLHMBBLA(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0", Slot = "4")]
	public bool Equals(HIKPLHMBBLA PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(HIKPLHMBBLA PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72943B0", Offset = "0x72929B0", VA = "0x1872943B0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0")]
	public static bool MNAFCOICNLK(HIKPLHMBBLA NFCDCHABNCB, HIKPLHMBBLA BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7293450", Offset = "0x7291A50", VA = "0x187293450")]
	public static bool KIKJPCCIIDN(HIKPLHMBBLA NFCDCHABNCB, HIKPLHMBBLA BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7294450", Offset = "0x7292A50", VA = "0x187294450", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public DFIACMOLAPM(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0", Slot = "4")]
	public bool Equals(DFIACMOLAPM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(DFIACMOLAPM PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72933B0", Offset = "0x72919B0", VA = "0x1872933B0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0")]
	public static bool MNAFCOICNLK(DFIACMOLAPM NFCDCHABNCB, DFIACMOLAPM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7293450", Offset = "0x7291A50", VA = "0x187293450")]
	public static bool KIKJPCCIIDN(DFIACMOLAPM NFCDCHABNCB, DFIACMOLAPM BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7293480", Offset = "0x7291A80", VA = "0x187293480", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public OAGOEKHDGKK(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0", Slot = "4")]
	public bool Equals(OAGOEKHDGKK PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(OAGOEKHDGKK PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7294760", Offset = "0x7292D60", VA = "0x187294760", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0")]
	public static bool MNAFCOICNLK(OAGOEKHDGKK NFCDCHABNCB, OAGOEKHDGKK BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7293450", Offset = "0x7291A50", VA = "0x187293450")]
	public static bool KIKJPCCIIDN(OAGOEKHDGKK NFCDCHABNCB, OAGOEKHDGKK BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7294800", Offset = "0x7292E00", VA = "0x187294800", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public PJKGNECFBON(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0", Slot = "4")]
	public bool Equals(PJKGNECFBON PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(PJKGNECFBON PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7294C50", Offset = "0x7293250", VA = "0x187294C50", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0")]
	public static bool MNAFCOICNLK(PJKGNECFBON NFCDCHABNCB, PJKGNECFBON BCBMNIEKAKB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7293450", Offset = "0x7291A50", VA = "0x187293450")]
	public static bool KIKJPCCIIDN(PJKGNECFBON NFCDCHABNCB, PJKGNECFBON BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7294CF0", Offset = "0x72932F0", VA = "0x187294CF0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7294130", Offset = "0x7292730", VA = "0x187294130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int HBFDEEMJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4307F40", Offset = "0x4306540", VA = "0x184307F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72941E0", Offset = "0x72927E0", VA = "0x1872941E0")]
	public FEDCEIEOEHM(string? GGAEGHOGGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7294330", Offset = "0x7292930", VA = "0x187294330")]
	public FEDCEIEOEHM(string?[] MPENFNOCBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7293F00", Offset = "0x7292500", VA = "0x187293F00")]
	private static string?[]? IFANFOAIPJF(string?[]? MPENFNOCBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7293DC0", Offset = "0x72923C0", VA = "0x187293DC0")]
	public string FLBHECEJJDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7293CF0", Offset = "0x72922F0", VA = "0x187293CF0", Slot = "4")]
	public bool Equals(FEDCEIEOEHM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7293C60", Offset = "0x7292260", VA = "0x187293C60", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7293E20", Offset = "0x7292420", VA = "0x187293E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7294150", Offset = "0x7292750", VA = "0x187294150", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
	public OBAADAMJMCC(Guid GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public Guid CPCFJABKHLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x41A48C0", Offset = "0x41A2EC0", VA = "0x1841A48C0", Slot = "4")]
	public bool Equals(OBAADAMJMCC PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x41A47B0", Offset = "0x41A2DB0", VA = "0x1841A47B0", Slot = "5")]
	public int CompareTo(OBAADAMJMCC PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7294870", Offset = "0x7292E70", VA = "0x187294870", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x41A4980", Offset = "0x41A2F80", VA = "0x1841A4980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7294910", Offset = "0x7292F10", VA = "0x187294910", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x7294B20", Offset = "0x7293120", VA = "0x187294B20")]
	public static string[] GKAJICPMMPE(string? GGAEGHOGGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7294AF0", Offset = "0x72930F0", VA = "0x187294AF0")]
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

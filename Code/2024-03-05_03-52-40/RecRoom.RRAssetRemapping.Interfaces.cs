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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x6701F90", Offset = "0x6700D90", VA = "0x186701F90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MEPLMICHKOM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CDDFPMJNNJO(PFPAGMCKFGF PMNEDIFJMIN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFPAGMCKFGF APHAODHFANA(string PMNEDIFJMIN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct PFPAGMCKFGF : IEquatable<PFPAGMCKFGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ADGNDEDLINL MLLAMNKINBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GMFGMGAOABD EDEMHFINPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid LLOHLIINHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? BFLCLDKIIOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LKLONBAOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67020F0", Offset = "0x6700EF0", VA = "0x1867020F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KDADCNIKHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6702490", Offset = "0x6701290", VA = "0x186702490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6702960", Offset = "0x6701760", VA = "0x186702960")]
	public PFPAGMCKFGF(PFPAGMCKFGF CNDHIPLONPI, [Optional] Guid AGMHCIFIINH, [Optional] RRColor? DNOKCMICDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67028D0", Offset = "0x67016D0", VA = "0x1867028D0")]
	public PFPAGMCKFGF(ADGNDEDLINL NCCIFMACHKF, GMFGMGAOABD ECMJEGFKPHE, [Optional] Guid AGMHCIFIINH, [Optional] RRColor? DNOKCMICDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67021B0", Offset = "0x6700FB0", VA = "0x1867021B0", Slot = "4")]
	public bool Equals(PFPAGMCKFGF EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67022B0", Offset = "0x67010B0", VA = "0x1867022B0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67023A0", Offset = "0x67011A0", VA = "0x1867023A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6702080", Offset = "0x6700E80", VA = "0x186702080")]
	public static bool EILLJGMDDAM(PFPAGMCKFGF LDPIALBNJEB, PFPAGMCKFGF HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6702010", Offset = "0x6700E10", VA = "0x186702010")]
	public static bool CDMEFABOJMD(PFPAGMCKFGF LDPIALBNJEB, PFPAGMCKFGF HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67024D0", Offset = "0x67012D0", VA = "0x1867024D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ADGNDEDLINL : IEquatable<ADGNDEDLINL>, IComparable<ADGNDEDLINL>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly ADGNDEDLINL DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public ADGNDEDLINL(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(ADGNDEDLINL EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(ADGNDEDLINL EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6700A00", Offset = "0x66FF800", VA = "0x186700A00", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0")]
	public static bool EILLJGMDDAM(ADGNDEDLINL LDPIALBNJEB, ADGNDEDLINL HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67009D0", Offset = "0x66FF7D0", VA = "0x1867009D0")]
	public static bool CDMEFABOJMD(ADGNDEDLINL LDPIALBNJEB, ADGNDEDLINL HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6700AA0", Offset = "0x66FF8A0", VA = "0x186700AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct MEPNECKLGOF : IEquatable<MEPNECKLGOF>, IComparable<MEPNECKLGOF>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly MEPNECKLGOF DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public MEPNECKLGOF(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(MEPNECKLGOF EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(MEPNECKLGOF EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6701D90", Offset = "0x6700B90", VA = "0x186701D90", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0")]
	public static bool EILLJGMDDAM(MEPNECKLGOF LDPIALBNJEB, MEPNECKLGOF HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67009D0", Offset = "0x66FF7D0", VA = "0x1867009D0")]
	public static bool CDMEFABOJMD(MEPNECKLGOF LDPIALBNJEB, MEPNECKLGOF HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6701E30", Offset = "0x6700C30", VA = "0x186701E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FHBFAIODCNH : IEquatable<FHBFAIODCNH>, IComparable<FHBFAIODCNH>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly FHBFAIODCNH DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public FHBFAIODCNH(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(FHBFAIODCNH EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(FHBFAIODCNH EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6701250", Offset = "0x6700050", VA = "0x186701250", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0")]
	public static bool EILLJGMDDAM(FHBFAIODCNH LDPIALBNJEB, FHBFAIODCNH HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67009D0", Offset = "0x66FF7D0", VA = "0x1867009D0")]
	public static bool CDMEFABOJMD(FHBFAIODCNH LDPIALBNJEB, FHBFAIODCNH HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67012F0", Offset = "0x67000F0", VA = "0x1867012F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct GMFGMGAOABD : IEquatable<GMFGMGAOABD>, IComparable<GMFGMGAOABD>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly GMFGMGAOABD DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KGAHOAGJHCA AIMBHGAMNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70")]
		[CompilerGenerated]
		get
		{
			return default(KGAHOAGJHCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KGAHOAGJHCA JPOGCIOOPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x104C300", Offset = "0x104B100", VA = "0x18104C300")]
		[CompilerGenerated]
		get
		{
			return default(KGAHOAGJHCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KGAHOAGJHCA MHKELEBKKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE93280", Offset = "0xE92080", VA = "0x180E93280")]
		[CompilerGenerated]
		get
		{
			return default(KGAHOAGJHCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67019D0", Offset = "0x67007D0", VA = "0x1867019D0")]
	public GMFGMGAOABD(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6701A10", Offset = "0x6700810", VA = "0x186701A10")]
	public GMFGMGAOABD(KGAHOAGJHCA OMICPFMCJNG, KGAHOAGJHCA AHOMMHKEPDA, KGAHOAGJHCA JLJGCOIIEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6701830", Offset = "0x6700630", VA = "0x186701830")]
	private Guid OHKOPPCHOGA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6701800", Offset = "0x6700600", VA = "0x186701800", Slot = "4")]
	public bool Equals(GMFGMGAOABD EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6701750", Offset = "0x6700550", VA = "0x186701750", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6701710", Offset = "0x6700510", VA = "0x186701710")]
	public static bool EILLJGMDDAM(GMFGMGAOABD LDPIALBNJEB, GMFGMGAOABD HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6701690", Offset = "0x6700490", VA = "0x186701690")]
	public static bool CDMEFABOJMD(GMFGMGAOABD LDPIALBNJEB, GMFGMGAOABD HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67016D0", Offset = "0x67004D0", VA = "0x1867016D0", Slot = "5")]
	public int CompareTo(GMFGMGAOABD EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6701960", Offset = "0x6700760", VA = "0x186701960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct GEDDPJGCMIG : IEquatable<GEDDPJGCMIG>, IComparable<GEDDPJGCMIG>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly GEDDPJGCMIG DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public GEDDPJGCMIG(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(GEDDPJGCMIG EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(GEDDPJGCMIG EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6701470", Offset = "0x6700270", VA = "0x186701470", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0")]
	public static bool EILLJGMDDAM(GEDDPJGCMIG LDPIALBNJEB, GEDDPJGCMIG HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67009D0", Offset = "0x66FF7D0", VA = "0x1867009D0")]
	public static bool CDMEFABOJMD(GEDDPJGCMIG LDPIALBNJEB, GEDDPJGCMIG HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6701510", Offset = "0x6700310", VA = "0x186701510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IHGNPHBMLMN : IEquatable<IHGNPHBMLMN>, IComparable<IHGNPHBMLMN>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly IHGNPHBMLMN DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public IHGNPHBMLMN(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(IHGNPHBMLMN EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(IHGNPHBMLMN EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6701A60", Offset = "0x6700860", VA = "0x186701A60", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0")]
	public static bool EILLJGMDDAM(IHGNPHBMLMN LDPIALBNJEB, IHGNPHBMLMN HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67009D0", Offset = "0x66FF7D0", VA = "0x1867009D0")]
	public static bool CDMEFABOJMD(IHGNPHBMLMN LDPIALBNJEB, IHGNPHBMLMN HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6701B00", Offset = "0x6700900", VA = "0x186701B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct FLODCCCKFPK : IEquatable<FLODCCCKFPK>, IComparable<FLODCCCKFPK>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly FLODCCCKFPK DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public FLODCCCKFPK(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(FLODCCCKFPK EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(FLODCCCKFPK EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6701360", Offset = "0x6700160", VA = "0x186701360", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0")]
	public static bool EILLJGMDDAM(FLODCCCKFPK LDPIALBNJEB, FLODCCCKFPK HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x67009D0", Offset = "0x66FF7D0", VA = "0x1867009D0")]
	public static bool CDMEFABOJMD(FLODCCCKFPK LDPIALBNJEB, FLODCCCKFPK HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6701400", Offset = "0x6700200", VA = "0x186701400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GKCFIGPLEPM : IEquatable<GKCFIGPLEPM>, IComparable<GKCFIGPLEPM>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly GKCFIGPLEPM DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public GKCFIGPLEPM(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(GKCFIGPLEPM EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(GKCFIGPLEPM EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6701580", Offset = "0x6700380", VA = "0x186701580", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0")]
	public static bool EILLJGMDDAM(GKCFIGPLEPM LDPIALBNJEB, GKCFIGPLEPM HLCIAKLFNHE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67009D0", Offset = "0x66FF7D0", VA = "0x1867009D0")]
	public static bool CDMEFABOJMD(GKCFIGPLEPM LDPIALBNJEB, GKCFIGPLEPM HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6701620", Offset = "0x6700420", VA = "0x186701620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct ECAADHJGDBJ : IEquatable<ECAADHJGDBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? IOHJMDDOIMN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KOELFDEDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6700B10", Offset = "0x66FF910", VA = "0x186700B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BFAGCPNEMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3C19E60", Offset = "0x3C18C60", VA = "0x183C19E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6701090", Offset = "0x66FFE90", VA = "0x186701090")]
	public ECAADHJGDBJ(string? KIOIBCKNMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67011D0", Offset = "0x66FFFD0", VA = "0x1867011D0")]
	public ECAADHJGDBJ(string?[] LNJDGIBCOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6700D70", Offset = "0x66FFB70", VA = "0x186700D70")]
	private static string?[]? LBJMMNBFMBA(string?[]? LNJDGIBCOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6700FA0", Offset = "0x66FFDA0", VA = "0x186700FA0")]
	public string LNOOMFEABBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6700B30", Offset = "0x66FF930", VA = "0x186700B30", Slot = "4")]
	public bool Equals(ECAADHJGDBJ EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6700C00", Offset = "0x66FFA00", VA = "0x186700C00", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6700C90", Offset = "0x66FFA90", VA = "0x186700C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6701000", Offset = "0x66FFE00", VA = "0x186701000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KGAHOAGJHCA : IEquatable<KGAHOAGJHCA>, IComparable<KGAHOAGJHCA>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly KGAHOAGJHCA DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public KGAHOAGJHCA(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(KGAHOAGJHCA EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(KGAHOAGJHCA EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6701C80", Offset = "0x6700A80", VA = "0x186701C80", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0")]
	public static bool EILLJGMDDAM(KGAHOAGJHCA LDPIALBNJEB, KGAHOAGJHCA HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6701D20", Offset = "0x6700B20", VA = "0x186701D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JEFFJPCJMOJ : IEquatable<JEFFJPCJMOJ>, IComparable<JEFFJPCJMOJ>, BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JEFFJPCJMOJ DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid MAAFBDMNKAP;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
	public JEFFJPCJMOJ(Guid MAAFBDMNKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public Guid EPGMPHNBOBG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x36FC7F0", Offset = "0x36FB5F0", VA = "0x1836FC7F0", Slot = "4")]
	public bool Equals(JEFFJPCJMOJ EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x36FC9D0", Offset = "0x36FB7D0", VA = "0x1836FC9D0", Slot = "5")]
	public int CompareTo(JEFFJPCJMOJ EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6701B70", Offset = "0x6700970", VA = "0x186701B70", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x36FCBA0", Offset = "0x36FB9A0", VA = "0x1836FCBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67009D0", Offset = "0x66FF7D0", VA = "0x1867009D0")]
	public static bool CDMEFABOJMD(JEFFJPCJMOJ LDPIALBNJEB, JEFFJPCJMOJ HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6701C10", Offset = "0x6700A10", VA = "0x186701C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NHJEHOCHOJO<TModern> : AIBPFEJCPAK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BGEDLCDNPNN(TModern KLJPBLHIECD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BJPIAGJCMGK
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid EPGMPHNBOBG();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AIBPFEJCPAK<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern GAMEKFHBONO(string KLJPBLHIECD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GONAOIFIFNM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NHJEHOCHOJO<ADGNDEDLINL> BIMPJOKNCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NHJEHOCHOJO<GEDDPJGCMIG> AHAGKJGEONK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NHJEHOCHOJO<GKCFIGPLEPM> OBFLBMOHPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NHJEHOCHOJO<GMFGMGAOABD> LKMHAKHNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NHJEHOCHOJO<FHBFAIODCNH> EDDIEPEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NHJEHOCHOJO<FLODCCCKFPK> INCHLMLNCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NHJEHOCHOJO<MEPNECKLGOF> HBACLGIMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NHJEHOCHOJO<IHGNPHBMLMN> JLAOIBADHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MLAOILNIKCO
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6701ED0", Offset = "0x6700CD0", VA = "0x186701ED0")]
	public static string[] NOPAIIPAAAN(string? KIOIBCKNMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6701EA0", Offset = "0x6700CA0", VA = "0x186701EA0")]
	public static string? DHDBIFLCMCD(string? NCCIFMACHKF)
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

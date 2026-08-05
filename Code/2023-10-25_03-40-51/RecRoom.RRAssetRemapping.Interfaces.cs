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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6280380", Offset = "0x627F180", VA = "0x186280380")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EFEDEMEGOBL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LJOKGFFEJKK(EJALALGJNMI KHNEEJJPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJALALGJNMI NLOFGFEMKNI(string KHNEEJJPNNH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct EJALALGJNMI : IEquatable<EJALALGJNMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HIDHCENBIKG LAIJKCLOFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MIIMNMCJACG IEJNFKHEKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid FBLGPGMJHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? HNJLJMMPEDA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CEAKMBEJPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x627EBB0", Offset = "0x627D9B0", VA = "0x18627EBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JNPAKKBPLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x627EC70", Offset = "0x627DA70", VA = "0x18627EC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x627F120", Offset = "0x627DF20", VA = "0x18627F120")]
	public EJALALGJNMI(EJALALGJNMI AMJBAHBEJPG, [Optional] Guid KPNALFBDCJJ, [Optional] RRColor? CEPDKAIKDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x627F1B0", Offset = "0x627DFB0", VA = "0x18627F1B0")]
	public EJALALGJNMI(HIDHCENBIKG MHEBAKDOMDP, MIIMNMCJACG LGHPFEJDHJL, [Optional] Guid KPNALFBDCJJ, [Optional] RRColor? CEPDKAIKDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x627E860", Offset = "0x627D660", VA = "0x18627E860", Slot = "4")]
	public bool Equals(EJALALGJNMI LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x627E960", Offset = "0x627D760", VA = "0x18627E960", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x627EA50", Offset = "0x627D850", VA = "0x18627EA50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x627ECB0", Offset = "0x627DAB0", VA = "0x18627ECB0")]
	public static bool PNFEPLLEJJK(EJALALGJNMI NLBDNIEIKMB, EJALALGJNMI NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x627EB40", Offset = "0x627D940", VA = "0x18627EB40")]
	public static bool IJDMLBHKDLI(EJALALGJNMI NLBDNIEIKMB, EJALALGJNMI NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x627ED20", Offset = "0x627DB20", VA = "0x18627ED20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HIDHCENBIKG : IEquatable<HIDHCENBIKG>, IComparable<HIDHCENBIKG>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly HIDHCENBIKG HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
	public HIDHCENBIKG(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750", Slot = "4")]
	public bool Equals(HIDHCENBIKG LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4781780", Offset = "0x4780580", VA = "0x184781780", Slot = "5")]
	public int CompareTo(HIDHCENBIKG LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x627F350", Offset = "0x627E150", VA = "0x18627F350", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750")]
	public static bool PNFEPLLEJJK(HIDHCENBIKG NLBDNIEIKMB, HIDHCENBIKG NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x627E5C0", Offset = "0x627D3C0", VA = "0x18627E5C0")]
	public static bool IJDMLBHKDLI(HIDHCENBIKG NLBDNIEIKMB, HIDHCENBIKG NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x627F3F0", Offset = "0x627E1F0", VA = "0x18627F3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DLCBBFAKOIG : IEquatable<DLCBBFAKOIG>, IComparable<DLCBBFAKOIG>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DLCBBFAKOIG HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
	public DLCBBFAKOIG(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750", Slot = "4")]
	public bool Equals(DLCBBFAKOIG LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4781780", Offset = "0x4780580", VA = "0x184781780", Slot = "5")]
	public int CompareTo(DLCBBFAKOIG LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x627E750", Offset = "0x627D550", VA = "0x18627E750", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750")]
	public static bool PNFEPLLEJJK(DLCBBFAKOIG NLBDNIEIKMB, DLCBBFAKOIG NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x627E5C0", Offset = "0x627D3C0", VA = "0x18627E5C0")]
	public static bool IJDMLBHKDLI(DLCBBFAKOIG NLBDNIEIKMB, DLCBBFAKOIG NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x627E7F0", Offset = "0x627D5F0", VA = "0x18627E7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GPBAPFLPPLK : IEquatable<GPBAPFLPPLK>, IComparable<GPBAPFLPPLK>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly GPBAPFLPPLK HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
	public GPBAPFLPPLK(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750", Slot = "4")]
	public bool Equals(GPBAPFLPPLK LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4781780", Offset = "0x4780580", VA = "0x184781780", Slot = "5")]
	public int CompareTo(GPBAPFLPPLK LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x627F240", Offset = "0x627E040", VA = "0x18627F240", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750")]
	public static bool PNFEPLLEJJK(GPBAPFLPPLK NLBDNIEIKMB, GPBAPFLPPLK NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x627E5C0", Offset = "0x627D3C0", VA = "0x18627E5C0")]
	public static bool IJDMLBHKDLI(GPBAPFLPPLK NLBDNIEIKMB, GPBAPFLPPLK NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x627F2E0", Offset = "0x627E0E0", VA = "0x18627F2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MIIMNMCJACG : IEquatable<MIIMNMCJACG>, IComparable<MIIMNMCJACG>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly MIIMNMCJACG HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IDMGPCABMLI LIPGKKONECN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return default(IDMGPCABMLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IDMGPCABMLI IICNOAEBDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD63290", Offset = "0xD62090", VA = "0x180D63290")]
		[CompilerGenerated]
		get
		{
			return default(IDMGPCABMLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IDMGPCABMLI PKLFHALOGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76870", VA = "0x180D77A70")]
		[CompilerGenerated]
		get
		{
			return default(IDMGPCABMLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62802F0", Offset = "0x627F0F0", VA = "0x1862802F0")]
	public MIIMNMCJACG(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6280330", Offset = "0x627F130", VA = "0x186280330")]
	public MIIMNMCJACG(IDMGPCABMLI AKMBNCOLKPK, IDMGPCABMLI JPMMMBBBIBL, IDMGPCABMLI IBJIFIHEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6280110", Offset = "0x627EF10", VA = "0x186280110")]
	private Guid NEOEHNDALAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D39900", Offset = "0x5D38700", VA = "0x185D39900", Slot = "4")]
	public bool Equals(MIIMNMCJACG LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6280020", Offset = "0x627EE20", VA = "0x186280020", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6280240", Offset = "0x627F040", VA = "0x186280240")]
	public static bool PNFEPLLEJJK(MIIMNMCJACG NLBDNIEIKMB, MIIMNMCJACG NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62800D0", Offset = "0x627EED0", VA = "0x1862800D0")]
	public static bool IJDMLBHKDLI(MIIMNMCJACG NLBDNIEIKMB, MIIMNMCJACG NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x627FFE0", Offset = "0x627EDE0", VA = "0x18627FFE0", Slot = "5")]
	public int CompareTo(MIIMNMCJACG LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6280280", Offset = "0x627F080", VA = "0x186280280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BOLEMINDPIJ : IEquatable<BOLEMINDPIJ>, IComparable<BOLEMINDPIJ>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BOLEMINDPIJ HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
	public BOLEMINDPIJ(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750", Slot = "4")]
	public bool Equals(BOLEMINDPIJ LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4781780", Offset = "0x4780580", VA = "0x184781780", Slot = "5")]
	public int CompareTo(BOLEMINDPIJ LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x627E520", Offset = "0x627D320", VA = "0x18627E520", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750")]
	public static bool PNFEPLLEJJK(BOLEMINDPIJ NLBDNIEIKMB, BOLEMINDPIJ NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x627E5C0", Offset = "0x627D3C0", VA = "0x18627E5C0")]
	public static bool IJDMLBHKDLI(BOLEMINDPIJ NLBDNIEIKMB, BOLEMINDPIJ NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x627E5F0", Offset = "0x627D3F0", VA = "0x18627E5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IGJNIAODAPD : IEquatable<IGJNIAODAPD>, IComparable<IGJNIAODAPD>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly IGJNIAODAPD HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
	public IGJNIAODAPD(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750", Slot = "4")]
	public bool Equals(IGJNIAODAPD LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4781780", Offset = "0x4780580", VA = "0x184781780", Slot = "5")]
	public int CompareTo(IGJNIAODAPD LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x627F570", Offset = "0x627E370", VA = "0x18627F570", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750")]
	public static bool PNFEPLLEJJK(IGJNIAODAPD NLBDNIEIKMB, IGJNIAODAPD NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x627E5C0", Offset = "0x627D3C0", VA = "0x18627E5C0")]
	public static bool IJDMLBHKDLI(IGJNIAODAPD NLBDNIEIKMB, IGJNIAODAPD NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x627F610", Offset = "0x627E410", VA = "0x18627F610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct MFMNMCECOHP : IEquatable<MFMNMCECOHP>, IComparable<MFMNMCECOHP>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly MFMNMCECOHP HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
	public MFMNMCECOHP(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750", Slot = "4")]
	public bool Equals(MFMNMCECOHP LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4781780", Offset = "0x4780580", VA = "0x184781780", Slot = "5")]
	public int CompareTo(MFMNMCECOHP LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x627FED0", Offset = "0x627ECD0", VA = "0x18627FED0", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750")]
	public static bool PNFEPLLEJJK(MFMNMCECOHP NLBDNIEIKMB, MFMNMCECOHP NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x627E5C0", Offset = "0x627D3C0", VA = "0x18627E5C0")]
	public static bool IJDMLBHKDLI(MFMNMCECOHP NLBDNIEIKMB, MFMNMCECOHP NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x627FF70", Offset = "0x627ED70", VA = "0x18627FF70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct INHNMLHBLPF : IEquatable<INHNMLHBLPF>, IComparable<INHNMLHBLPF>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly INHNMLHBLPF HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
	public INHNMLHBLPF(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750", Slot = "4")]
	public bool Equals(INHNMLHBLPF LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4781780", Offset = "0x4780580", VA = "0x184781780", Slot = "5")]
	public int CompareTo(INHNMLHBLPF LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x627F680", Offset = "0x627E480", VA = "0x18627F680", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750")]
	public static bool PNFEPLLEJJK(INHNMLHBLPF NLBDNIEIKMB, INHNMLHBLPF NFFCMKPCJPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x627E5C0", Offset = "0x627D3C0", VA = "0x18627E5C0")]
	public static bool IJDMLBHKDLI(INHNMLHBLPF NLBDNIEIKMB, INHNMLHBLPF NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x627F720", Offset = "0x627E520", VA = "0x18627F720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JJOIDFMIAGG : IEquatable<JJOIDFMIAGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? CDAEGHFBHCG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LOJCLMPHFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x627F790", Offset = "0x627E590", VA = "0x18627F790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int HIIAHCPKAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x394C790", Offset = "0x394B590", VA = "0x18394C790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x627FD10", Offset = "0x627EB10", VA = "0x18627FD10")]
	public JJOIDFMIAGG(string? DICEDJBLABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x627FE50", Offset = "0x627EC50", VA = "0x18627FE50")]
	public JJOIDFMIAGG(string?[] PCDLMMAENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x627F9F0", Offset = "0x627E7F0", VA = "0x18627F9F0")]
	private static string?[]? IOLDFKCGEIB(string?[]? PCDLMMAENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x627FC20", Offset = "0x627EA20", VA = "0x18627FC20")]
	public string PBKBEAMCDFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x627F7B0", Offset = "0x627E5B0", VA = "0x18627F7B0", Slot = "4")]
	public bool Equals(JJOIDFMIAGG LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x627F880", Offset = "0x627E680", VA = "0x18627F880", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x627F910", Offset = "0x627E710", VA = "0x18627F910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x627FC80", Offset = "0x627EA80", VA = "0x18627FC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IDMGPCABMLI : IEquatable<IDMGPCABMLI>, IComparable<IDMGPCABMLI>, MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly IDMGPCABMLI HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid EIODILKIKCN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
	public IDMGPCABMLI(Guid EIODILKIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
	public Guid FFALGHOMING()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750", Slot = "4")]
	public bool Equals(IDMGPCABMLI LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4781780", Offset = "0x4780580", VA = "0x184781780", Slot = "5")]
	public int CompareTo(IDMGPCABMLI LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x627F460", Offset = "0x627E260", VA = "0x18627F460", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x47817B0", Offset = "0x47805B0", VA = "0x1847817B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4781750", Offset = "0x4780550", VA = "0x184781750")]
	public static bool PNFEPLLEJJK(IDMGPCABMLI NLBDNIEIKMB, IDMGPCABMLI NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x627F500", Offset = "0x627E300", VA = "0x18627F500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JMEDKDICIGA<TModern> : FPAPHKPENMP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EEIAJEPCKGL(TModern AFHAOADGHLN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MBPBKCBPNCF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid FFALGHOMING();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FPAPHKPENMP<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern DNMBENHGPDL(string AFHAOADGHLN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FFPMEIHPAKG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JMEDKDICIGA<HIDHCENBIKG> OEJNLPLDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JMEDKDICIGA<BOLEMINDPIJ> BLOPDHPDIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JMEDKDICIGA<INHNMLHBLPF> NAKBOIMFGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JMEDKDICIGA<MIIMNMCJACG> DBOPANCGEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JMEDKDICIGA<GPBAPFLPPLK> CODPEADCNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JMEDKDICIGA<MFMNMCECOHP> PKOPECKMMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JMEDKDICIGA<DLCBBFAKOIG> PHOBFGPEOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JMEDKDICIGA<IGJNIAODAPD> ADJJAMBDANI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CIJLALMGDBJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x627E690", Offset = "0x627D490", VA = "0x18627E690")]
	public static string[] JDCFFIBKJBJ(string? DICEDJBLABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x627E660", Offset = "0x627D460", VA = "0x18627E660")]
	public static string? FFNCHAGINOK(string? MHEBAKDOMDP)
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

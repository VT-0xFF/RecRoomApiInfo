using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.CodeGen.Attributes;
using RecRoom.Components;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KHNEPCEOGCM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly List<(JFKJFANPLHM nameHash, FGAIDOMHKBP stableTypeHash, Type type)> PAFEIONPBED;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly List<(JFKJFANPLHM nameHash, FGAIDOMHKBP stableTypeHash, Type type)> ODJKMNGJPPM;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly List<(JFKJFANPLHM previousNameHash, FGAIDOMHKBP previousStableTypeHash, Type currentTypeName)> MENIOKPJDFK;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class POJHMOGEBFL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Rigidbody JICGNHIFHFC;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66600D0", Offset = "0x665E8D0", VA = "0x1866600D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public POJHMOGEBFL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DOGEPFFGMFC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EPNLGILPPDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public NNAEKKHECGM IBCDMIPMGAK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AKJDKHCJLLE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ICCNONLNGMC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public object JPFAAHPLONC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x665B550", Offset = "0x6659D50", VA = "0x18665B550", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public ICCNONLNGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct EAOCLJEOJCO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity CICDHHEGIAO;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FDCJKBDBGMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float CGJHCIBEHBB;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly LIJOCGCHMIA<FDCJKBDBGMB> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MNJIIPJLMEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float3 OPLDCFBNAIL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KBKBOPJCHOP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KBFDDENCLAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNNBPIJMIEA(LNBFOKMABPL MFLEOKKEBPK, LNBFOKMABPL KGDFMKBNLJD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLJENAHFIDF();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIGHMIOOHOC();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EECOEHINOGD(bool JMCPMHHMAPD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OBEPMJOPCLC();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFHAKCGIBMF();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OBFJGJKIHHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LODNBONEDKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int KEEDPPAHJPJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1560180", Offset = "0x155E980", VA = "0x181560180")]
	public static LODNBONEDKM HFMFJLJFEMO(int MENBIMCLIOI)
	{
		return default(LODNBONEDKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum NNAEKKHECGM
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum JOKBKMCLMIE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IKOMECBEPKO : KMINMJBDKBF, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MLDDGBCIKAP NOIOKMKEGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(MLDDGBCIKAP);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LKIAEAEEIOP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public KBFDDENCLAP OHFBJHBEFFM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x665EBF0", Offset = "0x665D3F0", VA = "0x18665EBF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public LKIAEAEEIOP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BOLMDIPGFEI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KFJMAPKFKBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3x3 IIFKPCGOIGB;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly LIJOCGCHMIA<KFJMAPKFKBG> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CEHALNOEPAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float MLOOOCKJLNH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly LIJOCGCHMIA<CEHALNOEPAK> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ABOACEBGBKB]
public struct KJJJOELHDGO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Entity AJDEFAPHMKF;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HJLIOPBHNPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float OJBLBIFAIOC;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly LIJOCGCHMIA<HJLIOPBHNPG> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ONJPNGGFKNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 NCJKCLECIAP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ILPFBDBNCND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Entity CEABICNIABB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NHNDFMMINBA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum LNBFOKMABPL
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ENDFBALMHBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3x3 IIFKPCGOIGB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly LIJOCGCHMIA<KFJMAPKFKBG> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FCACCBCICGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity GJPBCFJDGCH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct COOPNLNIIGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NFLPKFKCKMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NNAEKKHECGM KDOLIJGJLGC;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NENMLKMGLEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public RigidbodyConstraints DCLENAIADPL;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct ODFBOFBFIAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float EPNGJFALPNH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly LIJOCGCHMIA<ODFBOFBFIAC> GDCPNJEFLGI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct HOAIEPFLGBA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct ALJAHJLEEEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public LNBFOKMABPL OPEDHIKHGBE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly LIJOCGCHMIA<ALJAHJLEEEH> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IFPOBKGCLPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public CollisionDetectionMode NOPLHLDNABA;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PFFGODLOOAN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public object IMFLLHKCGOJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x665FCD0", Offset = "0x665E4D0", VA = "0x18665FCD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PFFGODLOOAN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct KGJLEHAFHEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PJDFFKOEKIO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OPDJEOBGGKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float3 PIFGOLLJLPC;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct CPIAGCFKGKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float HJCLBHJHBFA;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EJBMNHPHLOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 NMPHIMCIEGA;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[InternalBufferCapacity(8)]
public struct OEOKFMKAJDD : ISystemStateBufferElementData, IBufferElementData, IEquatable<OEOKFMKAJDD>, MLFKCOGAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity CICDHHEGIAO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity GGGEABJFICD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20")]
	public OEOKFMKAJDD(Entity CICDHHEGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x665F3B0", Offset = "0x665DBB0", VA = "0x18665F3B0", Slot = "4")]
	public bool Equals(OEOKFMKAJDD OALEAAIPGBP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static OEOKFMKAJDD HFMFJLJFEMO(Entity AJDEFAPHMKF)
	{
		return default(OEOKFMKAJDD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct AOAFFGHJAJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CBNALECLFEM(1)]
	public Entity BEELAINJGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CBNALECLFEM(2)]
	public bool DCMNDFGMEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[CBNALECLFEM(3)]
	public float AFDNKGNOCBE;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ECCCBJENADJ(1)]
public struct GGEPJACPGID : MIIOPAJPNBD, IEquatable<GGEPJACPGID>
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly GGEPJACPGID HCMFGAEBPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[EDAMJBCIJJF(1)]
	public int BMKPPKKOMAH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xB1A5C0", Offset = "0xB18DC0", VA = "0x180B1A5C0")]
	public GGEPJACPGID(int BMKPPKKOMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x665AB90", Offset = "0x6659390", VA = "0x18665AB90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x665AB00", Offset = "0x6659300", VA = "0x18665AB00", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3B90590", Offset = "0x3B8ED90", VA = "0x183B90590", Slot = "6")]
	public bool Equals(GGEPJACPGID OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x665AC20", Offset = "0x6659420", VA = "0x18665AC20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x665AC00", Offset = "0x6659400", VA = "0x18665AC00", Slot = "5")]
	public void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x665AAF0", Offset = "0x66592F0", VA = "0x18665AAF0", Slot = "4")]
	public void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct MEJJCGNBFDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[CBNALECLFEM(1)]
	public float HHDKGMDEOLP;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly LIJOCGCHMIA<MEJJCGNBFDD> GDCPNJEFLGI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal struct PBONIPIHCBN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal struct GMAFMCBNILP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Entity AJDEFAPHMKF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static GMAFMCBNILP HFMFJLJFEMO(Entity AJDEFAPHMKF)
	{
		return default(GMAFMCBNILP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CEPPHHGOGPN]
[OBFAKEELOOG("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct JBNEKLMDNOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(1)]
	public MHBLFBCIOOJ LPNNBGAFKLN;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Flags]
[DGFNELNJAIN(0, 15943)]
public enum MHBLFBCIOOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	MAX = 0x3E47
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct ACDCMPAFIMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KBBMKCOJHCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GCEFMAJHKHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct HPLFHJLHFKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct GBELHDKBGLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OOFNNLODJBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct ACCPALCMPOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct GAFJMMBBBNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct JEKPENKIIEF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct DMNFANICCBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[EDAMJBCIJJF(1)]
	public NDPOFJCDFMI MNJCDKNLLPF;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LIJOCGCHMIA<DMNFANICCBD> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum NDPOFJCDFMI : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct NIGPOFBMGGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[CBNALECLFEM(1)]
	public float3 PKMLPJIAAEM;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly LIJOCGCHMIA<NIGPOFBMGGH> GDCPNJEFLGI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1AB0740", Offset = "0x1AAEF40", VA = "0x181AB0740")]
	public static NIGPOFBMGGH HFMFJLJFEMO(float3 MENBIMCLIOI)
	{
		return default(NIGPOFBMGGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[NDNPAOIOIKJ]
[DJJAPEPHMOH(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct IJNGFCCADKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int IKBFNEIMMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[CBNALECLFEM(2)]
	public bool HNCCJEODHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[CBNALECLFEM(3)]
	public bool EBLAKDCFHBE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly LIJOCGCHMIA<IJNGFCCADKL> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct HBPOHKHILDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float IMBOBLNABFG;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly LIJOCGCHMIA<HBPOHKHILDB> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct FPOOIADGAHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[CBNALECLFEM(1)]
	public SerializableGuid KJOHEJEFBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[CBNALECLFEM(2)]
	public SerializableGuid IBOAMBHJEOF;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[CEPPHHGOGPN]
[OBFAKEELOOG("Container", 0)]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
public struct HMJCDHFLPNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[CBNALECLFEM(1)]
	[HOIGIBLKIIL(0)]
	public KOBJCHCIPDK MKKKJIKFMKD;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly LIJOCGCHMIA<HMJCDHFLPNL> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DGFNELNJAIN(0, 2)]
public enum KOBJCHCIPDK
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal enum DBKFFOAPDFN
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class NJECJNBEFBE
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct MIPIBKACLEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct CEDCPLEAPCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[CBNALECLFEM(1)]
	public bool JJEDPBPHNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[CBNALECLFEM(2)]
	public bool DCMNDFGMEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[CBNALECLFEM(3)]
	public float HFPJIMMMMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[CBNALECLFEM(4)]
	public float FFKEMABDPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[CBNALECLFEM(5)]
	public float JJHKIIGGPCB;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[ECCCBJENADJ(1)]
public struct CLPCIHAOJOM : MIIOPAJPNBD
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Flags]
	[DGFNELNJAIN(0, 7)]
	public enum PPNOHHHPODJ
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[EDAMJBCIJJF(1)]
	public float HAPLIIOKGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[EDAMJBCIJJF(2)]
	public int KOCKLMCKKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[EDAMJBCIJJF(3)]
	public PPNOHHHPODJ LPNNBGAFKLN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ANKPEBDKJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6659630", Offset = "0x6657E30", VA = "0x186659630")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x66596B0", Offset = "0x6657EB0", VA = "0x1866596B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool GIPMKFLMCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x66594B0", Offset = "0x6657CB0", VA = "0x1866594B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6659590", Offset = "0x6657D90", VA = "0x186659590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LGMAIFJAMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66595B0", Offset = "0x6657DB0", VA = "0x1866595B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x66596D0", Offset = "0x6657ED0", VA = "0x1866596D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x66596F0", Offset = "0x6657EF0", VA = "0x1866596F0", Slot = "5")]
	public void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6659530", Offset = "0x6657D30", VA = "0x186659530", Slot = "4")]
	public void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal struct OCIPAGPIHEI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct JMCPPLBMCKC : ISystemStateComponentData, IComponentData, MLFKCOGAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity KAPGLMHIFBJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity GGGEABJFICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct NHPCFCALLGM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct HIJMLIBNKEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HGFAFHFDBHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float4x4 LFDAGLDKHPP;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly LIJOCGCHMIA<HGFAFHFDBHB> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct GOLCMBJLMMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[CBNALECLFEM(1)]
	public GLALCNLDHGM ILHENAJOBAK;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct AHKFOICDACF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Flags]
	[DGFNELNJAIN(0, 7)]
	public enum FENFDOMFCLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[CBNALECLFEM(1)]
	public FENFDOMFCLG LPNNBGAFKLN;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly LIJOCGCHMIA<AHKFOICDACF> GDCPNJEFLGI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OILLMCCBOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6658E00", Offset = "0x6657600", VA = "0x186658E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FDMJKHJOCGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6658D80", Offset = "0x6657580", VA = "0x186658D80")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct DGPOBCIGCLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[CBNALECLFEM(1)]
	public float HHDKGMDEOLP;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly LIJOCGCHMIA<DGPOBCIGCLL> GDCPNJEFLGI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct PBLOLHFJJOF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
public struct NJJCFLHPOPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[CBNALECLFEM(1)]
	public NNDFHEKCGKG FJJDELDFPAO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct FBGGJGDHAOD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct NLLEHLHFEHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[CBNALECLFEM(1)]
	public Entity BENEHBIADLM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct PGHKLEOLKID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DGFNELNJAIN(0, 9)]
public enum APFIBDNJBME
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class JOOPDLFGFMA
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x665C1A0", Offset = "0x665A9A0", VA = "0x18665C1A0")]
	public static bool LKBHNKFGOAG(this APFIBDNJBME FOMBGLCHHME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DGFNELNJAIN(-1, 38)]
public enum JBOEKGNECFI
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[NDNPAOIOIKJ]
[DJJAPEPHMOH(15725208981563603541uL, 17017036095303668770uL)]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct LLBLIEDHHDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[CBNALECLFEM(1)]
	public KECBEHOHBCN MCBNACIDAGA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct NGMHPAKIICG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct GLMDKNEGLJD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DGFNELNJAIN(0, 2)]
public enum GCHPCFMMMFK
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DGFNELNJAIN(0, 1)]
public enum NNDFHEKCGKG
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	MAX = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct JKKFECOGKNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct MFIAFGCKMNH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct HJFDLKKNMEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[CBNALECLFEM(1)]
	public IHDIMGJIFBM OPDCNFCBIGP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static HJFDLKKNMEJ HFMFJLJFEMO(IHDIMGJIFBM MENBIMCLIOI)
	{
		return default(HJFDLKKNMEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[OBFAKEELOOG("Container", 0)]
public struct FIGCMCBLDEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[CBNALECLFEM(1)]
	[HOIGIBLKIIL(0)]
	public FixedString64Bytes MDOAADHDBMA;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class NJGOODHJLLM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x665F210", Offset = "0x665DA10", VA = "0x18665F210")]
	public static void OLFLGMGEIBD(this ref BDICFKJLAKB LPNNBGAFKLN, LEGGLPPFJFK NMEBMCGKJHJ, bool JEABKFCMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x665F1D0", Offset = "0x665D9D0", VA = "0x18665F1D0")]
	public static bool IPGKHEGJAHD(this BDICFKJLAKB LPNNBGAFKLN, LEGGLPPFJFK NMEBMCGKJHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x665F1C0", Offset = "0x665D9C0", VA = "0x18665F1C0")]
	public static BDICFKJLAKB GJLFGHLONAL(this LEGGLPPFJFK NMEBMCGKJHJ)
	{
		return default(BDICFKJLAKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x665F1F0", Offset = "0x665D9F0", VA = "0x18665F1F0")]
	public static void OLFLGMGEIBD(this ref EAAJLBIKIMH LPNNBGAFKLN, EAAJLBIKIMH KMIJNFGJKHN, bool JEABKFCMDDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum LEGGLPPFJFK
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Flags]
[DGFNELNJAIN(0, 16383)]
public enum BDICFKJLAKB
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[Flags]
[DGFNELNJAIN(0, 3)]
public enum EAAJLBIKIMH
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	MAX = 3
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[NDNPAOIOIKJ]
[DJJAPEPHMOH(17667479821163689808uL, 11946378475791123970uL)]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
public struct KACKGCNPIME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct CBEGJFJMDHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[NDNPAOIOIKJ]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[DJJAPEPHMOH(1029043735688538310uL, 14256247939851101839uL)]
public struct BOJBFBDFKJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public APFIBDNJBME FOMBGLCHHME;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[DGFNELNJAIN(int.MinValue, int.MaxValue)]
public enum EKMBBDEMLDN
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CEPPHHGOGPN]
[OBFAKEELOOG("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct AMLALONNIBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(1)]
	public bool HLEJICMEJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(2)]
	public float CDLGJODPKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(3)]
	public float CJCFMILPBKA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct DAOFBCEOLPL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[OBFAKEELOOG("Container", 0)]
public struct FNLIOICECPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(1)]
	public float IOJLBENOPAC;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct ODEOGNCDGLA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private NativeList<HFNGPMMDMJB> BDNDLOBMJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private NativeList<Entity> KNKHCJDCNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private JobHandle LELCJDGAKHL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KHGFECIPALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x665F5C0", Offset = "0x665DDC0", VA = "0x18665F5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x665F570", Offset = "0x665DD70", VA = "0x18665F570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x212C3E0", Offset = "0x212ABE0", VA = "0x18212C3E0")]
	public ODEOGNCDGLA(NativeList<HFNGPMMDMJB> BDNDLOBMJJM, NativeList<Entity> KNKHCJDCNOJ, JobHandle LELCJDGAKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x665F420", Offset = "0x665DC20", VA = "0x18665F420")]
	public (Entity, NativeSlice<Entity>) FKHGMCIEMLE(int NLNOELCPLOI)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x665F3C0", Offset = "0x665DBC0", VA = "0x18665F3C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OGGLOODKLFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public float3 PAOMABBDKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public quaternion APAHFEOKBOD;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static readonly LIJOCGCHMIA<OGGLOODKLFP> GDCPNJEFLGI;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x665F6B0", Offset = "0x665DEB0", VA = "0x18665F6B0")]
	public float3 KGGANHFBAII(float3 PKBCOAILGDK)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class BLINJLJGIDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[NDNPAOIOIKJ]
[DJJAPEPHMOH(218523523639012570uL, 15191719635551116065uL)]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
public struct DOELCNBBPCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private uint OIHBPNOIKDD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct LBOGIIBCODE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[OBFAKEELOOG("Light", 0)]
public struct NANIIMHGKNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(1)]
	public float HHDHKFPFAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct ECMJHACEEMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[CBNALECLFEM(1)]
	public quaternion CCIFDEOEEEF;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static readonly LIJOCGCHMIA<ECMJHACEEMJ> GDCPNJEFLGI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
	public static ECMJHACEEMJ HFMFJLJFEMO(quaternion MENBIMCLIOI)
	{
		return default(ECMJHACEEMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct DCGEHFAGMDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[CBNALECLFEM(1)]
	public Entity BEELAINJGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[CBNALECLFEM(2)]
	public bool JHMNKIGGINB;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct JMBHFLBPGKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public FixedString32Bytes MDOAADHDBMA;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[NDNPAOIOIKJ]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[DJJAPEPHMOH(4470189027631723570uL, 5922380073816386711uL)]
public struct HJDEIJHBJIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[EDAMJBCIJJF(1)]
	public BDICFKJLAKB LPNNBGAFKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[CBNALECLFEM(2)]
	public EGGMGCPFLGJ AGKMLABOMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(3)]
	public EAAJLBIKIMH EAEFKJEOJMD;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static readonly LIJOCGCHMIA<HJDEIJHBJIO> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct MHJCILPGKCM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Entity HNMLPOLOMNA;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[Flags]
[DGFNELNJAIN(0, 1)]
public enum OOPFAEOJNIK
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	All = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EDBDBPJJGNA : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[ECCCBJENADJ(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[EDAMJBCIJJF(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[EDAMJBCIJJF(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[EDAMJBCIJJF(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[EDAMJBCIJJF(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[ECCCBJENADJ(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, MIIOPAJPNBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[EDAMJBCIJJF(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		public static SerializableGuid HFMFJLJFEMO(Guid IBLFHKFALNL)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6660EF0", Offset = "0x665F6F0", VA = "0x186660EF0", Slot = "4")]
		public bool Equals(SerializableGuid OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6660ED0", Offset = "0x665F6D0", VA = "0x186660ED0", Slot = "5")]
		public int CompareTo(SerializableGuid OALEAAIPGBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6660DE0", Offset = "0x665F5E0", VA = "0x186660DE0", Slot = "6")]
		public void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6660F80", Offset = "0x665F780", VA = "0x186660F80", Slot = "7")]
		public void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6661000", Offset = "0x665F800", VA = "0x186661000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct NHDDGFKPEGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct HJLFNBLCAGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DGFNELNJAIN(0, 4)]
public enum JONPMFCOMPB
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct NBAJHOPBHNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[CBNALECLFEM(1)]
	public bool FMPEKBAGAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[CBNALECLFEM(2)]
	public byte GHPLFEIPCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[CBNALECLFEM(3)]
	public short NPPBKIHEBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[CBNALECLFEM(4)]
	public ushort GIENKGAMLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[CBNALECLFEM(5)]
	public int LGEEKKJCHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[CBNALECLFEM(6)]
	public uint JBGCFNODBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[CBNALECLFEM(7)]
	public long IEHIMNEBIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[CBNALECLFEM(8)]
	public ulong DINBPGNFAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[CBNALECLFEM(9)]
	public float IHEBDFGHKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[CBNALECLFEM(10)]
	public double PFJAJAKGDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[CBNALECLFEM(11)]
	public LGOEOKNNENI IALFNNLJBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[CBNALECLFEM(12)]
	public IHJMJDNBHHL DKEIENCDGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[CBNALECLFEM(13)]
	public AMCJAFDBOGF CKBGBJKJPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[CBNALECLFEM(14)]
	public EFMEBHEEBMH KMDBMJNGKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[CBNALECLFEM(15)]
	public OMCBBPNLNKB PJLKIMKHIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[CBNALECLFEM(16)]
	public KMKIKAMCGFN AJIMBDHKKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[CBNALECLFEM(17)]
	public AIBPONHNNBA LADEEAFABBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[CBNALECLFEM(18)]
	public BJFIEIGMJBP EJOEHDCHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[CBNALECLFEM(20)]
	public Quaternion OHIGDLAOPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[CBNALECLFEM(22)]
	public Vector3 DGNKJEGKPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[CBNALECLFEM(23)]
	public Vector4 CJFFEPPOOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[CBNALECLFEM(40)]
	public Entity DKLFDHNNHMG;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public enum LGOEOKNNENI : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum IHJMJDNBHHL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum AMCJAFDBOGF : short
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum EFMEBHEEBMH : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum OMCBBPNLNKB
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum KMKIKAMCGFN : uint
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum AIBPONHNNBA : long
{
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum BJFIEIGMJBP : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CEPPHHGOGPN]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CEPPHHGOGPN]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class KCIKMJBIGGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public int BLAINNBNMDK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public int FEKDFJCPPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public GameObject OAOEKKJFJKH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public KCIKMJBIGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class AEFIIDPAGPP : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public struct CHBIAAOPBAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Vector3 BNPHMAIACGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public List<SerializableGuid> IIOOKHNLPEN;
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class AOFIBFALKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CHBIAAOPBAD MBEHMCFEPCM;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AOFIBFALKJD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public SerializableGuid CDDPMJHGMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public List<int> BKJDJOJOPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public List<CHBIAAOPBAD> MKJLPJPMLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public List<AOFIBFALKJD> BJLDBDBDPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public GameObject OAOEKKJFJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Light PHAJGIHLCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Collider PINIOELHAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public string LLGFAHOPNHM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public AEFIIDPAGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[NDNPAOIOIKJ]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[DJJAPEPHMOH(2613756846563002039uL, 6372660366488563574uL)]
[OBFAKEELOOG("Container", 0)]
public struct BGEBONLFKKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	[CBNALECLFEM(1)]
	[HOIGIBLKIIL(0)]
	public IOGDDKOHLBN HEHMIMIGGGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[Flags]
[DGFNELNJAIN(0, 15)]
public enum IOGDDKOHLBN
{
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[NDNPAOIOIKJ]
[DJJAPEPHMOH(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct HCANGBOCOIJ : IComponentData, IEquatable<HCANGBOCOIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[CBNALECLFEM(1)]
	public FixedString64Bytes MDOAADHDBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[CBNALECLFEM(2)]
	public KOBJCHCIPDK MKKKJIKFMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[CBNALECLFEM(3)]
	public IOGDDKOHLBN HEHMIMIGGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[CBNALECLFEM(4)]
	public HDHEDBNENIA JEJIBJBDHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	[CBNALECLFEM(5)]
	public MHBLFBCIOOJ LPNNBGAFKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	[CBNALECLFEM(6)]
	public float IOJLBENOPAC;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x665B000", Offset = "0x6659800", VA = "0x18665B000", Slot = "4")]
	public bool Equals(HCANGBOCOIJ OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct CBIEAPMGLPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	[CBNALECLFEM(1)]
	public CLPCIHAOJOM LGKGBPHHHBD;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct ANGCGFBDCKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	[CBNALECLFEM(1)]
	public float3 GGKJMICDBEF;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly LIJOCGCHMIA<ANGCGFBDCKA> GDCPNJEFLGI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1AB0740", Offset = "0x1AAEF40", VA = "0x181AB0740")]
	public static ANGCGFBDCKA HFMFJLJFEMO(float3 MENBIMCLIOI)
	{
		return default(ANGCGFBDCKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct LFKGMFOLOLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Entity HNMLPOLOMNA;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[InternalBufferCapacity(8)]
public struct OCNLGAFGIKO : ISystemStateBufferElementData, IBufferElementData, IEquatable<OCNLGAFGIKO>, MLFKCOGAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public Entity CICDHHEGIAO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity GGGEABJFICD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x665F3B0", Offset = "0x665DBB0", VA = "0x18665F3B0", Slot = "4")]
	public bool Equals(OCNLGAFGIKO OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal struct JPEMLHJAMKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public Entity BENEHBIADLM;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DGFNELNJAIN(0, 4)]
public enum GLALCNLDHGM
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct PMHMNKDEJIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	[CBNALECLFEM(1)]
	public quaternion CCIFDEOEEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	[CBNALECLFEM(2)]
	public float3 GGKJMICDBEF;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly LIJOCGCHMIA<PMHMNKDEJIA> GDCPNJEFLGI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1AB04A0", Offset = "0x1AAECA0", VA = "0x181AB04A0")]
	public PMHMNKDEJIA(quaternion CCIFDEOEEEF, float3 GGKJMICDBEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66592E0", Offset = "0x6657AE0", VA = "0x1866592E0")]
	public static RigidTransform HFMFJLJFEMO(PMHMNKDEJIA JOGAOKKMAID)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x66592E0", Offset = "0x6657AE0", VA = "0x1866592E0")]
	public static PMHMNKDEJIA HFMFJLJFEMO(RigidTransform FGPBBIHDJMM)
	{
		return default(PMHMNKDEJIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class EHPDDFJIKDJ
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface MLFKCOGAANJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity JDPPHAELNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[NDNPAOIOIKJ]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[DJJAPEPHMOH(9807788745867066359uL, 15168486114979071194uL)]
public struct NEDHFDFGMNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	[CBNALECLFEM(1)]
	public BDICFKJLAKB LPNNBGAFKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	[CBNALECLFEM(2)]
	public EGGMGCPFLGJ AGKMLABOMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	[CBNALECLFEM(3)]
	[HOIGIBLKIIL(0)]
	public bool JBIINKGEGIM;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static readonly LIJOCGCHMIA<NEDHFDFGMNM> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[CEPPHHGOGPN]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
public struct LHGMHGJGEDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[CBNALECLFEM(2)]
	public bool HNCCJEODHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[CBNALECLFEM(3)]
	public bool EBLAKDCFHBE;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static readonly LIJOCGCHMIA<LHGMHGJGEDG> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[OBFAKEELOOG("Object", 0)]
[TypeManager.TypeVersion(2)]
public struct JIHGMPJLDLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[CBNALECLFEM(2)]
	public EGGMGCPFLGJ AGKMLABOMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(3)]
	public EAAJLBIKIMH EAEFKJEOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[EDAMJBCIJJF(4)]
	public BDICFKJLAKB LPNNBGAFKLN;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static readonly LIJOCGCHMIA<JIHGMPJLDLP> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct PHOIHECODLB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public int LDFNOAINHMF;
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct DFDHBAFKCHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public GCHandle FOIBMJHKOPH;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct OEFBIKKPGEE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private int GCPIAFPFHJG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AMOEKOMGDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x665F6A0", Offset = "0x665DEA0", VA = "0x18665F6A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x665F690", Offset = "0x665DE90", VA = "0x18665F690")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct HBJNHIIALEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	[CBNALECLFEM(1)]
	public Entity BCHLDPMNPEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static HBJNHIIALEP HFMFJLJFEMO(Entity AJDEFAPHMKF)
	{
		return default(HBJNHIIALEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[NDNPAOIOIKJ]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[DJJAPEPHMOH(14327281633525910712uL, 2559857777606771911uL)]
public struct AMJICEAFCFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	[CBNALECLFEM(1)]
	public KECBEHOHBCN MCBNACIDAGA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct AFCFPKNOMDF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct DIABMIKHCMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	[CBNALECLFEM(1)]
	public float3 MCKCDDPBJLE;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly LIJOCGCHMIA<DIABMIKHCMI> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[OBFAKEELOOG("Container", 0)]
public struct OGHBCJONOMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(1)]
	public HDHEDBNENIA JEJIBJBDHMB;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[DGFNELNJAIN(0, 1)]
public enum HDHEDBNENIA
{
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ECCCBJENADJ(1)]
public struct EGGMGCPFLGJ : MIIOPAJPNBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[EDAMJBCIJJF(1)]
	public bool HLEJICMEJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	[EDAMJBCIJJF(2)]
	public float3 MHGEPJHJHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	[EDAMJBCIJJF(3)]
	public float3 NBEEGJAGKME;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static readonly LIJOCGCHMIA<EGGMGCPFLGJ> GDCPNJEFLGI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x665A500", Offset = "0x6658D00", VA = "0x18665A500", Slot = "5")]
	public void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x665A4B0", Offset = "0x6658CB0", VA = "0x18665A4B0", Slot = "4")]
	public void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct JCINHADDLOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	[CBNALECLFEM(1)]
	public JBOEKGNECFI JAAFDDAIDED;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct LNGMAGHEJPN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public int LDFNOAINHMF;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public interface AFNIAKIMNEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALPIMOABOAJ(bool GOCFBHOEPON);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.TypeVersion(2)]
public struct GODBGECHIFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public uint OOGMCOCFAJK;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x665AF10", Offset = "0x6659710", VA = "0x18665AF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct LFLFGMFBBDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal struct POOOGNJPDHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct PBPCEGOHNKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ABOACEBGBKB]
internal struct HJKAJAPIIMN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public Entity JKAALOHMCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int AMOEKOMGDLG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct FFBFMGINHPD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[OBFAKEELOOG("Visual", 0)]
public struct FFBBABAKBKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(1)]
	public EKMBBDEMLDN JIINIIPALJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(2)]
	public KFMLNKEHNMN KKNFKPKFEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(3)]
	public float FJGMPDOGPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(4)]
	public Vector3 EGDBKLONMIO;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[CEPPHHGOGPN]
[OBFAKEELOOG("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct POCOCJLODBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[HOIGIBLKIIL(0)]
	[CBNALECLFEM(1)]
	public float IDLNACKMCGB;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public static readonly LIJOCGCHMIA<POCOCJLODBE> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ECCCBJENADJ(1)]
public struct IHDIMGJIFBM : IComparable<IHDIMGJIFBM>, IEquatable<IHDIMGJIFBM>, MIIOPAJPNBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[EDAMJBCIJJF(1)]
	public uint JHKLFNNDIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[EDAMJBCIJJF(2)]
	public uint IHIMHLHMKEL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint HPKHJKMOKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x665B6D0", Offset = "0x6659ED0", VA = "0x18665B6D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x665BA30", Offset = "0x665A230", VA = "0x18665BA30")]
	public IHDIMGJIFBM(int JHKLFNNDIEI, int HMPLGNJGBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x665BA30", Offset = "0x665A230", VA = "0x18665BA30")]
	public IHDIMGJIFBM(uint JHKLFNNDIEI, uint HMPLGNJGBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x665B8F0", Offset = "0x665A0F0", VA = "0x18665B8F0")]
	public IHDIMGJIFBM NALLMFLDBII(int CNJDAMBDKMB = 1)
	{
		return default(IHDIMGJIFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x665B7D0", Offset = "0x6659FD0", VA = "0x18665B7D0")]
	public IHDIMGJIFBM FBACGLAMIEK(int CNJDAMBDKMB = 1)
	{
		return default(IHDIMGJIFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x665B650", Offset = "0x6659E50", VA = "0x18665B650")]
	public static IHDIMGJIFBM DGBNEHEJNLK(IHDIMGJIFBM KJDIMBCAJIJ, IHDIMGJIFBM EAIBHFHJJFK)
	{
		return default(IHDIMGJIFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x665B7A0", Offset = "0x6659FA0", VA = "0x18665B7A0")]
	private static uint FANIPJEKNKD(uint MBLAPCMEEGI, uint NBEGIGNBOIE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x665B630", Offset = "0x6659E30", VA = "0x18665B630", Slot = "4")]
	public int CompareTo(IHDIMGJIFBM OALEAAIPGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x665B700", Offset = "0x6659F00", VA = "0x18665B700", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x665B950", Offset = "0x665A150", VA = "0x18665B950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x665B6E0", Offset = "0x6659EE0", VA = "0x18665B6E0", Slot = "5")]
	public bool Equals(IHDIMGJIFBM OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x665B830", Offset = "0x665A030", VA = "0x18665B830", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x665B5C0", Offset = "0x6659DC0", VA = "0x18665B5C0", Slot = "6")]
	public void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x665B880", Offset = "0x665A080", VA = "0x18665B880", Slot = "7")]
	public void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF4CD0", Offset = "0x2BF34D0", VA = "0x182BF4CD0")]
	public static bool MJNLEMCBPOF(IHDIMGJIFBM KJDIMBCAJIJ, IHDIMGJIFBM EAIBHFHJJFK)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CEPPHHGOGPN]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public KECBEHOHBCN prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class JPMFAEDLKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x665C1B0", Offset = "0x665A9B0", VA = "0x18665C1B0")]
	public static bool DBMIGKIMEBE(this KECBEHOHBCN EIOLDDJPDLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x665C200", Offset = "0x665AA00", VA = "0x18665C200")]
	public static string MLHHANFCGHL(this KECBEHOHBCN EIOLDDJPDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x665C1E0", Offset = "0x665A9E0", VA = "0x18665C1E0")]
	public static APFIBDNJBME JPCHGEPHIEH(this KECBEHOHBCN MCBNACIDAGA)
	{
		return default(APFIBDNJBME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x665C2A0", Offset = "0x665AAA0", VA = "0x18665C2A0")]
	internal static DBKFFOAPDFN POAHPEMMKBE(this APFIBDNJBME FOMBGLCHHME)
	{
		return default(DBKFFOAPDFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x665C280", Offset = "0x665AA80", VA = "0x18665C280")]
	internal static DBKFFOAPDFN POAHPEMMKBE(this KECBEHOHBCN MCBNACIDAGA)
	{
		return default(DBKFFOAPDFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class CODKKBFMIDG
{
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly Dictionary<KECBEHOHBCN, string> FDDBNCCMPDB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6659740", Offset = "0x6657F40", VA = "0x186659740")]
	public static string PKHEPKDONFG(this KECBEHOHBCN EIOLDDJPDLH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct KOLJBHBCONE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[NDNPAOIOIKJ]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[DJJAPEPHMOH(9898405628982320166uL, 2023375009558162791uL)]
public struct KCEEFPEFEBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	[CBNALECLFEM(1)]
	public BDICFKJLAKB LPNNBGAFKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	[CBNALECLFEM(2)]
	public EGGMGCPFLGJ AGKMLABOMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	[CBNALECLFEM(3)]
	[HOIGIBLKIIL(0)]
	public bool JBIINKGEGIM;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly LIJOCGCHMIA<KCEEFPEFEBB> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct DNDJOEPINGD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public Entity GAFGGKFEJOD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static DNDJOEPINGD HFMFJLJFEMO(Entity AJDEFAPHMKF)
	{
		return default(DNDJOEPINGD);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CEPPHHGOGPN]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[EDAMJBCIJJF(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct NPLLHNDBMGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public float3 EOALGJMFLBB;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public static readonly LIJOCGCHMIA<NPLLHNDBMGA> GDCPNJEFLGI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct GHGMNOMDHBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[CEPPHHGOGPN]
[OBFAKEELOOG("Container", 0)]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
public struct HGBMIMHDHLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	[CBNALECLFEM(1)]
	[HOIGIBLKIIL(0)]
	public GKNLHHGAJBJ PDONLOAMCIM;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly LIJOCGCHMIA<HGBMIMHDHLI> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DGFNELNJAIN(0, 127)]
public enum GKNLHHGAJBJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class JNOOJBABGJB
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum IEKPAJDGILI
	{
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public enum KOEFFHFJJFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x665C030", Offset = "0x665A830", VA = "0x18665C030")]
	public static (IEKPAJDGILI, KOEFFHFJJFI) BJEIKPGHEOB(this GKNLHHGAJBJ IKPOFFPJLJD)
	{
		return default((IEKPAJDGILI, KOEFFHFJJFI));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct HFNGPMMDMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public Entity CEABICNIABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public int CNJDAMBDKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public int AKLMFDJHPFM;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
public struct OEKNEICFKDA : IComponentData, MLFKCOGAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	[CBNALECLFEM(1)]
	public Entity GJPBCFJDGCH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity GGGEABJFICD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20")]
	public OEKNEICFKDA(Entity GJPBCFJDGCH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static OEKNEICFKDA HFMFJLJFEMO(Entity AJDEFAPHMKF)
	{
		return default(OEKNEICFKDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct ANDKGOKDDMF : ISystemStateComponentData, IComponentData, MLFKCOGAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Entity KAPGLMHIFBJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity GGGEABJFICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20")]
	public ANDKGOKDDMF(Entity GJPBCFJDGCH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static ANDKGOKDDMF HFMFJLJFEMO(Entity AJDEFAPHMKF)
	{
		return default(ANDKGOKDDMF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct FEHACGKKKFJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[DGFNELNJAIN(1000, 8000)]
public enum KECBEHOHBCN
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	GameObject_Prop = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public static class BIHDIKKMIFP
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct OMDEKGFHDHH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[DGFNELNJAIN(-2, 2)]
public enum PPKMOJCHJJD
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	MAX = 2
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct DMEPNENHELI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct CDPJJJJBOFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public uint FFJMFCLDCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public int LGDKFJCAPKE;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAB38B0", Offset = "0xAB20B0", VA = "0x180AB38B0")]
	public CDPJJJJBOFJ(uint DHFFCMNALII, int BEEHNOICEFC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public struct MNMDOJBLLKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[DGFNELNJAIN(-1, 31)]
public enum KFMLNKEHNMN
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct GFHBPMAEMDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	[CBNALECLFEM(1)]
	public GGEPJACPGID FAFAMPBOGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public GCHandle KLLABPMEFNM;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public struct BGNDJFIJAFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public float4x4 ILDEBNONBOL;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly LIJOCGCHMIA<BGNDJFIJAFN> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
public struct NBHKLDPKGLO : IComponentData, MLFKCOGAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	[CBNALECLFEM(1)]
	public Entity GJPBCFJDGCH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Entity GGGEABJFICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20")]
	public NBHKLDPKGLO(Entity GJPBCFJDGCH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static NBHKLDPKGLO HFMFJLJFEMO(Entity AJDEFAPHMKF)
	{
		return default(NBHKLDPKGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x665EF70", Offset = "0x665D770", VA = "0x18665EF70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct ENMBJJNMEAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[ABOACEBGBKB]
public struct BPOLDAELHOM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public Entity JJIAFDKCLGJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static BPOLDAELHOM HFMFJLJFEMO(Entity MENBIMCLIOI)
	{
		return default(BPOLDAELHOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct FKMPHPAHGBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[CBNALECLFEM(1)]
	public OOPFAEOJNIK LKEPIOBBDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[CBNALECLFEM(2)]
	public PPKMOJCHJJD EPAAOEMAFEI;
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct BLDKBFDENOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[CBNALECLFEM(1)]
	public bool JJEDPBPHNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	[CBNALECLFEM(2)]
	public bool DCMNDFGMEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[CBNALECLFEM(3)]
	public float AFDNKGNOCBE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct FIEPIGFPDKC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct KGHAAKPKAMB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct BLOFFPDIILE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[CBNALECLFEM(1)]
	public quaternion CCIFDEOEEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CBNALECLFEM(2)]
	public float3 GGKJMICDBEF;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly LIJOCGCHMIA<BLOFFPDIILE> GDCPNJEFLGI;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1AB04A0", Offset = "0x1AAECA0", VA = "0x181AB04A0")]
	public BLOFFPDIILE(quaternion CCIFDEOEEEF, float3 GGKJMICDBEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66592E0", Offset = "0x6657AE0", VA = "0x1866592E0")]
	public static BLOFFPDIILE HFMFJLJFEMO(RigidTransform FGPBBIHDJMM)
	{
		return default(BLOFFPDIILE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class EJABBJBPJIO
{
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[CEPPHHGOGPN]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct DGLJADLMJBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[CBNALECLFEM(1)]
	public GCHPCFMMMFK JAAFDDAIDED;
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : BBDIJCIAOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6661010", Offset = "0x665F810", VA = "0x186661010", Slot = "4")]
		public sealed override void NFAIEHMBJOE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class GHKPGDPDIEN : ContainerPropertyBag<POJHMOGEBFL>
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class GHFDIAOJGCE : Property<POJHMOGEBFL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x665ACB0", Offset = "0x66594B0", VA = "0x18665ACB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x665AC70", Offset = "0x6659470", VA = "0x18665AC70")]
		public GHFDIAOJGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2235820", Offset = "0x2234020", VA = "0x182235820", Slot = "14")]
		public override Rigidbody GetValue(ref POJHMOGEBFL KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2235840", Offset = "0x2234040", VA = "0x182235840", Slot = "15")]
		public override void SetValue(ref POJHMOGEBFL KEMGJJIKGPJ, Rigidbody MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x665ACE0", Offset = "0x66594E0", VA = "0x18665ACE0")]
	public GHKPGDPDIEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class GIOOAOFIFOI : ContainerPropertyBag<ICCNONLNGMC>
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class BKLPFFABFDD : Property<ICCNONLNGMC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x66592B0", Offset = "0x6657AB0", VA = "0x1866592B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6659270", Offset = "0x6657A70", VA = "0x186659270")]
		public BKLPFFABFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2235820", Offset = "0x2234020", VA = "0x182235820", Slot = "14")]
		public override object GetValue(ref ICCNONLNGMC KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2235840", Offset = "0x2234040", VA = "0x182235840", Slot = "15")]
		public override void SetValue(ref ICCNONLNGMC KEMGJJIKGPJ, object MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x665AE40", Offset = "0x6659640", VA = "0x18665AE40")]
	public GIOOAOFIFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class HEFHMDMJBEM : ContainerPropertyBag<LKIAEAEEIOP>
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class JCMECFEIJPP : Property<LKIAEAEEIOP, KBFDDENCLAP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x665BE40", Offset = "0x665A640", VA = "0x18665BE40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x665BE00", Offset = "0x665A600", VA = "0x18665BE00")]
		public JCMECFEIJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2235820", Offset = "0x2234020", VA = "0x182235820", Slot = "14")]
		public override KBFDDENCLAP GetValue(ref LKIAEAEEIOP KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2235840", Offset = "0x2234040", VA = "0x182235840", Slot = "15")]
		public override void SetValue(ref LKIAEAEEIOP KEMGJJIKGPJ, KBFDDENCLAP MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x665B0E0", Offset = "0x66598E0", VA = "0x18665B0E0")]
	public HEFHMDMJBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal class JFHBLJBNNFF : ContainerPropertyBag<PFFGODLOOAN>
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private class MGADJBKAMHA : Property<PFFGODLOOAN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x665EF40", Offset = "0x665D740", VA = "0x18665EF40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x665EF00", Offset = "0x665D700", VA = "0x18665EF00")]
		public MGADJBKAMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2235820", Offset = "0x2234020", VA = "0x182235820", Slot = "14")]
		public override object GetValue(ref PFFGODLOOAN KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2235840", Offset = "0x2234040", VA = "0x182235840", Slot = "15")]
		public override void SetValue(ref PFFGODLOOAN KEMGJJIKGPJ, object MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x665BE70", Offset = "0x665A670", VA = "0x18665BE70")]
	public JFHBLJBNNFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class EHGBGKNLJHH : ContainerPropertyBag<KCIKMJBIGGC>
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class EGEBLNBKAGL : Property<KCIKMJBIGGC, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x665A480", Offset = "0x6658C80", VA = "0x18665A480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x665A440", Offset = "0x6658C40", VA = "0x18665A440")]
		public EGEBLNBKAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x426F920", Offset = "0x426E120", VA = "0x18426F920", Slot = "14")]
		public override int GetValue(ref KCIKMJBIGGC KEMGJJIKGPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x665A420", Offset = "0x6658C20", VA = "0x18665A420", Slot = "15")]
		public override void SetValue(ref KCIKMJBIGGC KEMGJJIKGPJ, int MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class GHPHBICAMPG : Property<KCIKMJBIGGC, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x665AE10", Offset = "0x6659610", VA = "0x18665AE10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x665ADD0", Offset = "0x66595D0", VA = "0x18665ADD0")]
		public GHPHBICAMPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x426F9B0", Offset = "0x426E1B0", VA = "0x18426F9B0", Slot = "14")]
		public override int GetValue(ref KCIKMJBIGGC KEMGJJIKGPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x665ADB0", Offset = "0x66595B0", VA = "0x18665ADB0", Slot = "15")]
		public override void SetValue(ref KCIKMJBIGGC KEMGJJIKGPJ, int MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class LPPLAFHJFEP : Property<KCIKMJBIGGC, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x665ECF0", Offset = "0x665D4F0", VA = "0x18665ECF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x665ECB0", Offset = "0x665D4B0", VA = "0x18665ECB0")]
		public LPPLAFHJFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x665EC60", Offset = "0x665D460", VA = "0x18665EC60", Slot = "14")]
		public override GameObject GetValue(ref KCIKMJBIGGC KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x665EC80", Offset = "0x665D480", VA = "0x18665EC80", Slot = "15")]
		public override void SetValue(ref KCIKMJBIGGC KEMGJJIKGPJ, GameObject MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x665A610", Offset = "0x6658E10", VA = "0x18665A610")]
	public EHGBGKNLJHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class AAJIEPMBALB : ContainerPropertyBag<AEFIIDPAGPP>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class KOJEIIKBACG : Property<AEFIIDPAGPP, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x665EB60", Offset = "0x665D360", VA = "0x18665EB60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x665EB20", Offset = "0x665D320", VA = "0x18665EB20")]
		public KOJEIIKBACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x665EAD0", Offset = "0x665D2D0", VA = "0x18665EAD0", Slot = "14")]
		public override SerializableGuid GetValue(ref AEFIIDPAGPP KEMGJJIKGPJ)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x665EB00", Offset = "0x665D300", VA = "0x18665EB00", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP KEMGJJIKGPJ, SerializableGuid MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class NNDHPEHELGP : Property<AEFIIDPAGPP, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x665F2D0", Offset = "0x665DAD0", VA = "0x18665F2D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x665F290", Offset = "0x665DA90", VA = "0x18665F290")]
		public NNDHPEHELGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x665F240", Offset = "0x665DA40", VA = "0x18665F240", Slot = "14")]
		public override List<int> GetValue(ref AEFIIDPAGPP KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x665F260", Offset = "0x665DA60", VA = "0x18665F260", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP KEMGJJIKGPJ, List<int> MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class ABCDDNGEDNK : Property<AEFIIDPAGPP, List<AEFIIDPAGPP.CHBIAAOPBAD>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x66588D0", Offset = "0x66570D0", VA = "0x1866588D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6658890", Offset = "0x6657090", VA = "0x186658890")]
		public ABCDDNGEDNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6658840", Offset = "0x6657040", VA = "0x186658840", Slot = "14")]
		public override List<AEFIIDPAGPP.CHBIAAOPBAD> GetValue(ref AEFIIDPAGPP KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6658860", Offset = "0x6657060", VA = "0x186658860", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP KEMGJJIKGPJ, List<AEFIIDPAGPP.CHBIAAOPBAD> MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	private class BPPBBLIFEOL : Property<AEFIIDPAGPP, List<AEFIIDPAGPP.AOFIBFALKJD>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6659420", Offset = "0x6657C20", VA = "0x186659420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x66593E0", Offset = "0x6657BE0", VA = "0x1866593E0")]
		public BPPBBLIFEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6659390", Offset = "0x6657B90", VA = "0x186659390", Slot = "14")]
		public override List<AEFIIDPAGPP.AOFIBFALKJD> GetValue(ref AEFIIDPAGPP KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x66593B0", Offset = "0x6657BB0", VA = "0x1866593B0", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP KEMGJJIKGPJ, List<AEFIIDPAGPP.AOFIBFALKJD> MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class DIOPAIDFJGJ : Property<AEFIIDPAGPP, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x665A1F0", Offset = "0x66589F0", VA = "0x18665A1F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x665A1B0", Offset = "0x66589B0", VA = "0x18665A1B0")]
		public DIOPAIDFJGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x665A160", Offset = "0x6658960", VA = "0x18665A160", Slot = "14")]
		public override GameObject GetValue(ref AEFIIDPAGPP KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x665A180", Offset = "0x6658980", VA = "0x18665A180", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP KEMGJJIKGPJ, GameObject MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	private class NIDIOANBGDM : Property<AEFIIDPAGPP, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x665F120", Offset = "0x665D920", VA = "0x18665F120", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x665F0E0", Offset = "0x665D8E0", VA = "0x18665F0E0")]
		public NIDIOANBGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x665F090", Offset = "0x665D890", VA = "0x18665F090", Slot = "14")]
		public override Light GetValue(ref AEFIIDPAGPP KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x665F0B0", Offset = "0x665D8B0", VA = "0x18665F0B0", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP KEMGJJIKGPJ, Light MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class BGPPJENJIJB : Property<AEFIIDPAGPP, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6659240", Offset = "0x6657A40", VA = "0x186659240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6659200", Offset = "0x6657A00", VA = "0x186659200")]
		public BGPPJENJIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x66591B0", Offset = "0x66579B0", VA = "0x1866591B0", Slot = "14")]
		public override Collider GetValue(ref AEFIIDPAGPP KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x66591D0", Offset = "0x66579D0", VA = "0x1866591D0", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP KEMGJJIKGPJ, Collider MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class PBNOJJCOBDA : Property<AEFIIDPAGPP, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x665FC10", Offset = "0x665E410", VA = "0x18665FC10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x665FBD0", Offset = "0x665E3D0", VA = "0x18665FBD0")]
		public PBNOJJCOBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x665FB80", Offset = "0x665E380", VA = "0x18665FB80", Slot = "14")]
		public override string GetValue(ref AEFIIDPAGPP KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x665FBA0", Offset = "0x665E3A0", VA = "0x18665FBA0", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP KEMGJJIKGPJ, string MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6658460", Offset = "0x6656C60", VA = "0x186658460")]
	public AAJIEPMBALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class PAEGPGJOCNG : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class IMPFIKKADBD : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x665BCB0", Offset = "0x665A4B0", VA = "0x18665BCB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x665BBC0", Offset = "0x665A3C0", VA = "0x18665BBC0")]
		public IMPFIKKADBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1957540", Offset = "0x1955D40", VA = "0x181957540", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid KEMGJJIKGPJ)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x63651E0", Offset = "0x63639E0", VA = "0x1863651E0", Slot = "15")]
		public override void SetValue(ref SerializableGuid KEMGJJIKGPJ, Data128 MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x665F9F0", Offset = "0x665E1F0", VA = "0x18665F9F0")]
	public PAEGPGJOCNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal class AEOLNHCGMBF : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class PHGLOABKJHA : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x665FE30", Offset = "0x665E630", VA = "0x18665FE30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x665FD40", Offset = "0x665E540", VA = "0x18665FD40")]
		public PHGLOABKJHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xB74FC0", Offset = "0xB737C0", VA = "0x180B74FC0", Slot = "14")]
		public override int GetValue(ref Data128 KEMGJJIKGPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D498A0", Offset = "0x3D480A0", VA = "0x183D498A0", Slot = "15")]
		public override void SetValue(ref Data128 KEMGJJIKGPJ, int MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class INOLBPKCIFP : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x665BDD0", Offset = "0x665A5D0", VA = "0x18665BDD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x665BCE0", Offset = "0x665A4E0", VA = "0x18665BCE0")]
		public INOLBPKCIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6367510", Offset = "0x6365D10", VA = "0x186367510", Slot = "14")]
		public override int GetValue(ref Data128 KEMGJJIKGPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4281A60", Offset = "0x4280260", VA = "0x184281A60", Slot = "15")]
		public override void SetValue(ref Data128 KEMGJJIKGPJ, int MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class BALPFAOEJJG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x66590A0", Offset = "0x66578A0", VA = "0x1866590A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6658FB0", Offset = "0x66577B0", VA = "0x186658FB0")]
		public BALPFAOEJJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCC8A60", Offset = "0xCC7260", VA = "0x180CC8A60", Slot = "14")]
		public override int GetValue(ref Data128 KEMGJJIKGPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x636DB00", Offset = "0x636C300", VA = "0x18636DB00", Slot = "15")]
		public override void SetValue(ref Data128 KEMGJJIKGPJ, int MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class EFCBGKDMMMC : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x665A3F0", Offset = "0x6658BF0", VA = "0x18665A3F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x665A300", Offset = "0x6658B00", VA = "0x18665A300")]
		public EFCBGKDMMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x636D990", Offset = "0x636C190", VA = "0x18636D990", Slot = "14")]
		public override int GetValue(ref Data128 KEMGJJIKGPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x636D9A0", Offset = "0x636C1A0", VA = "0x18636D9A0", Slot = "15")]
		public override void SetValue(ref Data128 KEMGJJIKGPJ, int MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6658900", Offset = "0x6657100", VA = "0x186658900")]
	public AEOLNHCGMBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal class PIHGEPIBCAF : ContainerPropertyBag<AEFIIDPAGPP.CHBIAAOPBAD>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class KCFKNICNAGO : Property<AEFIIDPAGPP.CHBIAAOPBAD, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x665C420", Offset = "0x665AC20", VA = "0x18665C420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x665C3E0", Offset = "0x665ABE0", VA = "0x18665C3E0")]
		public KCFKNICNAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x105A0F0", Offset = "0x10588F0", VA = "0x18105A0F0", Slot = "14")]
		public override Vector3 GetValue(ref AEFIIDPAGPP.CHBIAAOPBAD KEMGJJIKGPJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x665C3C0", Offset = "0x665ABC0", VA = "0x18665C3C0", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP.CHBIAAOPBAD KEMGJJIKGPJ, Vector3 MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class PFEKHNIFLKN : Property<AEFIIDPAGPP.CHBIAAOPBAD, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x665FCA0", Offset = "0x665E4A0", VA = "0x18665FCA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x665FC60", Offset = "0x665E460", VA = "0x18665FC60")]
		public PFEKHNIFLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x665FC40", Offset = "0x665E440", VA = "0x18665FC40", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref AEFIIDPAGPP.CHBIAAOPBAD KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x665FC50", Offset = "0x665E450", VA = "0x18665FC50", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP.CHBIAAOPBAD KEMGJJIKGPJ, List<SerializableGuid> MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x665FE60", Offset = "0x665E660", VA = "0x18665FE60")]
	public PIHGEPIBCAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class MCAGDMIJEBH : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class GCEOAOEFJPH : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x665AAC0", Offset = "0x66592C0", VA = "0x18665AAC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x665AA80", Offset = "0x6659280", VA = "0x18665AA80")]
		public GCEOAOEFJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x665AA60", Offset = "0x6659260", VA = "0x18665AA60", Slot = "14")]
		public override float GetValue(ref Vector3 KEMGJJIKGPJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x665AA70", Offset = "0x6659270", VA = "0x18665AA70", Slot = "15")]
		public override void SetValue(ref Vector3 KEMGJJIKGPJ, float MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class OPJGGEMBAHD : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x665F9C0", Offset = "0x665E1C0", VA = "0x18665F9C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x665F980", Offset = "0x665E180", VA = "0x18665F980")]
		public OPJGGEMBAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x665F960", Offset = "0x665E160", VA = "0x18665F960", Slot = "14")]
		public override float GetValue(ref Vector3 KEMGJJIKGPJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x665F970", Offset = "0x665E170", VA = "0x18665F970", Slot = "15")]
		public override void SetValue(ref Vector3 KEMGJJIKGPJ, float MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class DIGMLNIAHEI : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x665A130", Offset = "0x6658930", VA = "0x18665A130", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x665A0F0", Offset = "0x66588F0", VA = "0x18665A0F0")]
		public DIGMLNIAHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA43FC0", Offset = "0xA427C0", VA = "0x180A43FC0", Slot = "14")]
		public override float GetValue(ref Vector3 KEMGJJIKGPJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x665A0E0", Offset = "0x66588E0", VA = "0x18665A0E0", Slot = "15")]
		public override void SetValue(ref Vector3 KEMGJJIKGPJ, float MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x665ED20", Offset = "0x665D520", VA = "0x18665ED20")]
	public MCAGDMIJEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class FNDKDMLBANK : ContainerPropertyBag<AEFIIDPAGPP.AOFIBFALKJD>
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class HLMPPGDJKAA : Property<AEFIIDPAGPP.AOFIBFALKJD, AEFIIDPAGPP.CHBIAAOPBAD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x665B4C0", Offset = "0x6659CC0", VA = "0x18665B4C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x665B480", Offset = "0x6659C80", VA = "0x18665B480")]
		public HLMPPGDJKAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6364040", Offset = "0x6362840", VA = "0x186364040", Slot = "14")]
		public override AEFIIDPAGPP.CHBIAAOPBAD GetValue(ref AEFIIDPAGPP.AOFIBFALKJD KEMGJJIKGPJ)
		{
			return default(AEFIIDPAGPP.CHBIAAOPBAD);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x665B440", Offset = "0x6659C40", VA = "0x18665B440", Slot = "15")]
		public override void SetValue(ref AEFIIDPAGPP.AOFIBFALKJD KEMGJJIKGPJ, AEFIIDPAGPP.CHBIAAOPBAD MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x665A990", Offset = "0x6659190", VA = "0x18665A990")]
	public FNDKDMLBANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class IJDEFIIGGBL : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class FIOKJOIOHNN : Property<RRObjectPrefabV2Data, KECBEHOHBCN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x665A960", Offset = "0x6659160", VA = "0x18665A960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x665A920", Offset = "0x6659120", VA = "0x18665A920")]
		public FIOKJOIOHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xB74FC0", Offset = "0xB737C0", VA = "0x180B74FC0", Slot = "14")]
		public override KECBEHOHBCN GetValue(ref RRObjectPrefabV2Data KEMGJJIKGPJ)
		{
			return default(KECBEHOHBCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3D498A0", Offset = "0x3D480A0", VA = "0x183D498A0", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data KEMGJJIKGPJ, KECBEHOHBCN MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x665BA80", Offset = "0x665A280", VA = "0x18665BA80")]
	public IJDEFIIGGBL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6660140", Offset = "0x665E940", VA = "0x186660140")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000104")]
public class PGBKCKFKJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PGBKCKFKJGL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public class AuthoredParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public class AuthoredPreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public class AuthoredChildrenData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public class ParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public class PreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public class ChildrenData
	{
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

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
public static class NFIFNFBHFAG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly List<(ACBMDIMIIAP nameHash, ILPAELJEFKD stableTypeHash, Type type)> KFNDCJJEGGA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly List<(ACBMDIMIIAP nameHash, ILPAELJEFKD stableTypeHash, Type type)> FANECMFLNDM;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly List<(ACBMDIMIIAP previousNameHash, ILPAELJEFKD previousStableTypeHash, Type currentTypeName)> AIHIHJAEIOG;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EPBBAOCLMKB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Rigidbody HCHEOFCJLMB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65FE8D0", Offset = "0x65FDCD0", VA = "0x1865FE8D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public EPBBAOCLMKB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LBEJGHCHJHM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HJPEEOGHDMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public BFEGGBIPHDI MCKIFIEILPL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HOGKEOFJJIC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FHIMMFIMNFM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public object IDEPEKGCBBF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65FEA10", Offset = "0x65FDE10", VA = "0x1865FEA10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public FHIMMFIMNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct EDAGJAGFEBJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity CDFHGECAPKI;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HPNOFMHKNOH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float KCMLGKKALGC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly ACMLBEEJFIH<HPNOFMHKNOH> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KFNAOALKEIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float3 AKHLHNOGIEK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MCDKFOKBADF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ELAIMCPDFHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCCKACDCBAD(GIOFAADFPJL NOHEHILFFFE, GIOFAADFPJL BMNLJMGMOCE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFBEFECEPNC();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCEMKNHLLCM();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IFCKMHMOBIO(bool KLOFHCIIDLL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KAMMMEIPBPK();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIDBIPDDMAK();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CCJKCOMBFEA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DHBHBGPLHKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int GMMFAMNGGHK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x142F0D0", Offset = "0x142E4D0", VA = "0x18142F0D0")]
	public static DHBHBGPLHKE PGDDHPNABOB(int KKIAKNLLHIO)
	{
		return default(DHBHBGPLHKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum BFEGGBIPHDI
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum PPADPBDPHGN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LFFHABKPMBP : KFABDBNJOME, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IKOLGHEENFH EKEDFBPLNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IKOLGHEENFH);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OEDLHJHPJCL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ELAIMCPDFHF EJBKHCOKMPF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6604B90", Offset = "0x6603F90", VA = "0x186604B90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OEDLHJHPJCL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FCKBKGNJOOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ODBMOHDEGEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3x3 KOKGDFJBDJP;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly ACMLBEEJFIH<ODBMOHDEGEO> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MDOIGDCGPBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float LCOFKBFBENG;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly ACMLBEEJFIH<MDOIGDCGPBM> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[NFMOBAODLHH]
public struct ONFAPBPICOJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Entity FKNFFDFGNMN;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LOKNJKCACCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float IJHDENPEBHM;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly ACMLBEEJFIH<LOKNJKCACCH> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EPPAOJFMIIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 JDCEHJHDJNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LGBDFCDPOFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Entity COMCNEGAGFF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct AMMFNGNLHII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GIOFAADFPJL
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
public struct OMMNMOHOHBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3x3 KOKGDFJBDJP;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly ACMLBEEJFIH<ODBMOHDEGEO> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CCLKOKAOONK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity ILDFJHMNOPJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HIBHHJCHGLN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct KLJDPBNKDKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public BFEGGBIPHDI HOIOBBOKLDL;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CCPILBLEFKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public RigidbodyConstraints JKGGBHCJEBE;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct MGPMOEOBPCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float FLKLFIJJMCL;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly ACMLBEEJFIH<MGPMOEOBPCJ> DEEICBABDMJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KDIMGNOEAOM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct NHFDNMIFLMP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public GIOFAADFPJL EKJLFDNPEGF;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly ACMLBEEJFIH<NHFDNMIFLMP> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct OKLEAGHPMOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public CollisionDetectionMode FLKFFLLKHDE;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JIMLGCDPNAA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public object EICACAFDAFB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6600480", Offset = "0x65FF880", VA = "0x186600480", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JIMLGCDPNAA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PGJHAOJNFIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JCLKPILGEGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct ACBCFIMCGBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float3 NCNEIKFOPKA;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct JDMENMELGEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float FENJALIMCOD;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EPCPKEPBALN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 FCMNAMHJMDB;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[InternalBufferCapacity(8)]
public struct OOENBAEOKLI : ISystemStateBufferElementData, IBufferElementData, IEquatable<OOENBAEOKLI>, GDGEAAKNBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity CDFHGECAPKI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity IBGCNNGCIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0")]
	public OOENBAEOKLI(Entity CDFHGECAPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6601A30", Offset = "0x6600E30", VA = "0x186601A30", Slot = "4")]
	public bool Equals(OOENBAEOKLI LNOOAJJNCAE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static OOENBAEOKLI PGDDHPNABOB(Entity FKNFFDFGNMN)
	{
		return default(OOENBAEOKLI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct NALNOOBCFNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CEBMHPKFAPE(1)]
	public Entity GDNOLIODDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CEBMHPKFAPE(2)]
	public bool OHGIFEGAFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[CEBMHPKFAPE(3)]
	public float MMEBBOKFEMI;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[OOHGJABINCL(1)]
public struct KKHDEPBDMGH : EKKONKFFCGH, IEquatable<KKHDEPBDMGH>
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly KKHDEPBDMGH GBNLDGHKLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[HNGEBFPDALN(1)]
	public int MLGAFKBKMCE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800")]
	public KKHDEPBDMGH(int MLGAFKBKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x66008F0", Offset = "0x65FFCF0", VA = "0x1866008F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6600860", Offset = "0x65FFC60", VA = "0x186600860", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2C90", Offset = "0x3BD2090", VA = "0x183BD2C90", Slot = "6")]
	public bool Equals(KKHDEPBDMGH LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6600990", Offset = "0x65FFD90", VA = "0x186600990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6600970", Offset = "0x65FFD70", VA = "0x186600970", Slot = "5")]
	public void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6600960", Offset = "0x65FFD60", VA = "0x186600960", Slot = "4")]
	public void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct ANCGJKBPAIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[CEBMHPKFAPE(1)]
	public float JOHKAAPFFLA;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly ACMLBEEJFIH<ANCGJKBPAIA> DEEICBABDMJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal struct GHPFGOIHCLA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal struct JKKDNEMHJFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Entity FKNFFDFGNMN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static JKKDNEMHJFM PGDDHPNABOB(Entity FKNFFDFGNMN)
	{
		return default(JKKDNEMHJFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DDOJNEGANHI]
[PKDDPLFKGBL("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct GBLMPIODHGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[JDHENIHDGLC(0)]
	[CEBMHPKFAPE(1)]
	public CPJLKGMKAHP NNGHEIFAPDC;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Flags]
[LOOHBIGMFNI(0, 15943)]
public enum CPJLKGMKAHP
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
public struct AEDEKHIHKAB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct AOBAEPBAJCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct IMANKLACLAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct OJJLHKMCBKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BNEBFNHFNOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BBLFBKOLNFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct HANPCJFALHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct FOOCOPMAHLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct OIHFDDIMKEB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct BAHBEHDKOOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[HNGEBFPDALN(1)]
	public EFNMGKCCGPP HEGEMCIFGEI;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly ACMLBEEJFIH<BAHBEHDKOOD> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum EFNMGKCCGPP : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct DIAHLMCFEAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[CEBMHPKFAPE(1)]
	public float3 HMCGKJPEMOF;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly ACMLBEEJFIH<DIAHLMCFEAG> DEEICBABDMJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
	public static DIAHLMCFEAG PGDDHPNABOB(float3 KKIAKNLLHIO)
	{
		return default(DIAHLMCFEAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[LOLFLGCGIPK]
[FKOOJCCLEPP(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct JDCPFOCIBJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int BIEMNBFHJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[CEBMHPKFAPE(2)]
	public bool AMNJFJGPIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[CEBMHPKFAPE(3)]
	public bool ELHKCDAEMAF;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly ACMLBEEJFIH<JDCPFOCIBJC> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct NEPPICPDJAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float CBIJGKILOHI;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly ACMLBEEJFIH<NEPPICPDJAN> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct ILOMABJPLIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[CEBMHPKFAPE(1)]
	public SerializableGuid AGMGFKBEKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[CEBMHPKFAPE(2)]
	public SerializableGuid GHNPAEHCAPA;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[PKDDPLFKGBL("Container", 0)]
public struct NABKNKHLMPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[CEBMHPKFAPE(1)]
	[JDHENIHDGLC(0)]
	public EAMGDIDKDJL FEAMFDCPIDJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly ACMLBEEJFIH<NABKNKHLMPP> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[LOOHBIGMFNI(0, 2)]
public enum EAMGDIDKDJL
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
internal enum OKJJCJANPMO
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
internal static class MAEGNFMNFIG
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct OCKEOGFHKCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct ONPPCDLGBPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[CEBMHPKFAPE(1)]
	public bool KDLMOBCGODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[CEBMHPKFAPE(2)]
	public bool OHGIFEGAFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[CEBMHPKFAPE(3)]
	public float FAMFJMPMIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[CEBMHPKFAPE(4)]
	public float JMCICGNCKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[CEBMHPKFAPE(5)]
	public float NMNMMIHHPBN;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[OOHGJABINCL(1)]
public struct NDDEKGODHLE : EKKONKFFCGH
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Flags]
	[LOOHBIGMFNI(0, 7)]
	public enum FJGDGJEAOKP
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
	[HNGEBFPDALN(1)]
	public float KBAKAIIKPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[HNGEBFPDALN(2)]
	public int KCGMFCCGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[HNGEBFPDALN(3)]
	public FJGDGJEAOKP NNGHEIFAPDC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KAMKBEGCFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6601CC0", Offset = "0x66010C0", VA = "0x186601CC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6601D40", Offset = "0x6601140", VA = "0x186601D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JEBPKEFIANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6601B50", Offset = "0x6600F50", VA = "0x186601B50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6601C30", Offset = "0x6601030", VA = "0x186601C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CIDAJEFHNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6601AD0", Offset = "0x6600ED0", VA = "0x186601AD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6601C50", Offset = "0x6601050", VA = "0x186601C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6601C70", Offset = "0x6601070", VA = "0x186601C70", Slot = "5")]
	public void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6601BD0", Offset = "0x6600FD0", VA = "0x186601BD0", Slot = "4")]
	public void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal struct LDPKLPHBKLN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct FNBFFOBOBID : ISystemStateComponentData, IComponentData, GDGEAAKNBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity FKBNJNEINDM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity IBGCNNGCIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct CHMLLDFPGPB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct MIBCGGPNNKH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct COEOEGLCBOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float4x4 MCKCJAFEJMB;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly ACMLBEEJFIH<COEOEGLCBOG> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct IEFCLMPILPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[CEBMHPKFAPE(1)]
	public IPKCLDKJBAH PKEBDLGLPAP;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct IDHJHPGNCJM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Flags]
	[LOOHBIGMFNI(0, 7)]
	public enum MONOIEELGHF
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
	[CEBMHPKFAPE(1)]
	public MONOIEELGHF NNGHEIFAPDC;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly ACMLBEEJFIH<IDHJHPGNCJM> DEEICBABDMJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FNOILKFCLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x65FF570", Offset = "0x65FE970", VA = "0x1865FF570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AENDOGACPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x65FF4F0", Offset = "0x65FE8F0", VA = "0x1865FF4F0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct GHNNNODAEGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[CEBMHPKFAPE(1)]
	public float JOHKAAPFFLA;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly ACMLBEEJFIH<GHNNNODAEGP> DEEICBABDMJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct CNFCEHFCOPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
public struct GJNKACOKKFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[CEBMHPKFAPE(1)]
	public CJECAANJEGO DLFLBPFDNJG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct AFKPEGDDEJH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct OCGHCEBJNGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[CEBMHPKFAPE(1)]
	public Entity BMBJJEDFMKB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct NCHJICEBODK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[LOOHBIGMFNI(0, 9)]
public enum CJNBAFDACBF
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
public static class FHDJMKHFELP
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x65FEA00", Offset = "0x65FDE00", VA = "0x1865FEA00")]
	public static bool NANEJAKMKKJ(this CJNBAFDACBF DNIJHALFNBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[LOOHBIGMFNI(-1, 38)]
public enum EHKHPDFBEJD
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
[LOLFLGCGIPK]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[FKOOJCCLEPP(15725208981563603541uL, 17017036095303668770uL)]
public struct ICGKPPOKBOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[CEBMHPKFAPE(1)]
	public LENINMGJJHF MNOKFAHHNHH;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct AGOEIPDLONO : IComponentData, IComparable<AGOEIPDLONO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int IDFGMEJHKKH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1BE7FE0", Offset = "0x1BE73E0", VA = "0x181BE7FE0", Slot = "4")]
	public int CompareTo(AGOEIPDLONO LNOOAJJNCAE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct NBMIGEPLFOM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[LOLFLGCGIPK]
[FKOOJCCLEPP(12226092714547765037uL, 15970362445488810630uL)]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct HOCGLGHDOPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[CEBMHPKFAPE(2)]
	public OAJFDCHLCGC IKCCAADCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[JDHENIHDGLC(0)]
	[CEBMHPKFAPE(3)]
	public LOICABBCFFI DPCIMGCLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[HNGEBFPDALN(4)]
	public BEFJNEGHDLH NNGHEIFAPDC;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static readonly ACMLBEEJFIH<HOCGLGHDOPG> DEEICBABDMJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct KOIBMPFCENP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[LOOHBIGMFNI(0, 2)]
public enum AKFHJJDFLNB
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[LOOHBIGMFNI(0, 1)]
public enum CJECAANJEGO
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	MAX = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct EFDMBPLKIGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct LLPLPNEIBNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct EOGEBMPBCME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[CEBMHPKFAPE(1)]
	public CMGJAEOCGHK OKFFEMCPFEB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static EOGEBMPBCME PGDDHPNABOB(CMGJAEOCGHK KKIAKNLLHIO)
	{
		return default(EOGEBMPBCME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[PKDDPLFKGBL("Container", 0)]
public struct CGPPJHKOKBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[CEBMHPKFAPE(1)]
	[JDHENIHDGLC(0)]
	public FixedString64Bytes DKPHPKDPBCM;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class NBJDPAIAEGB
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x66019B0", Offset = "0x6600DB0", VA = "0x1866019B0")]
	public static void DADPJLGDIHI(this ref BEFJNEGHDLH NNGHEIFAPDC, HIJJKEPGDCJ LNNLOBOHJFC, bool FNDDHDLBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6601A00", Offset = "0x6600E00", VA = "0x186601A00")]
	public static bool IOBNGHINOBH(this BEFJNEGHDLH NNGHEIFAPDC, HIJJKEPGDCJ LNNLOBOHJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6601A20", Offset = "0x6600E20", VA = "0x186601A20")]
	public static BEFJNEGHDLH NBHHKAOJJOJ(this HIJJKEPGDCJ LNNLOBOHJFC)
	{
		return default(BEFJNEGHDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x66019E0", Offset = "0x6600DE0", VA = "0x1866019E0")]
	public static void DADPJLGDIHI(this ref LOICABBCFFI NNGHEIFAPDC, LOICABBCFFI HJFEJJMKLEL, bool FNDDHDLBBFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public enum HIJJKEPGDCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Flags]
[LOOHBIGMFNI(0, 16383)]
public enum BEFJNEGHDLH
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Flags]
[LOOHBIGMFNI(0, 3)]
public enum LOICABBCFFI
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	MAX = 3
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[INMEPOGOHHK]
[LOOHBIGMFNI(0, 4)]
public enum MLJJMANCKBM
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class INMEPOGOHHK : EACCEKENHBD
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x65FF760", Offset = "0x65FEB60", VA = "0x1865FF760", Slot = "7")]
	public override string MIOHAAIMNDI(string EALIBHBPMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public INMEPOGOHHK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[LOLFLGCGIPK]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[FKOOJCCLEPP(17667479821163689808uL, 11946378475791123970uL)]
public struct CBKOKNFIMAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct CGMMIFBANFE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[LOLFLGCGIPK]
[FKOOJCCLEPP(1029043735688538310uL, 14256247939851101839uL)]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
public struct PFEJENPNDKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public CJNBAFDACBF DNIJHALFNBM;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[LOOHBIGMFNI(int.MinValue, int.MaxValue)]
public enum LIADJHCPFLA
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[DDOJNEGANHI]
[PKDDPLFKGBL("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct DONANGPPLNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[JDHENIHDGLC(0)]
	[CEBMHPKFAPE(1)]
	public bool GDHKPCGLKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[CEBMHPKFAPE(2)]
	[JDHENIHDGLC(0)]
	public float IPOHCNMMPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[JDHENIHDGLC(0)]
	[CEBMHPKFAPE(3)]
	public float PJNDNKMLPNK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct NAFAECHIGOI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[PKDDPLFKGBL("Container", 0)]
public struct OKDBCINIFCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[JDHENIHDGLC(0)]
	[CEBMHPKFAPE(1)]
	public float GAENOBMELFL;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct OCKLHPIJMNK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private NativeList<GNJBMJAPDOO> OLLDFGPFFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeList<Entity> CKGNHLFDFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private JobHandle FPNNHINBDNF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DDCIGFMHKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6604800", Offset = "0x6603C00", VA = "0x186604800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x66048D0", Offset = "0x6603CD0", VA = "0x1866048D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27717F0", Offset = "0x2770BF0", VA = "0x1827717F0")]
	public OCKLHPIJMNK(NativeList<GNJBMJAPDOO> OLLDFGPFFGN, NativeList<Entity> CKGNHLFDFMF, JobHandle FPNNHINBDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6604920", Offset = "0x6603D20", VA = "0x186604920")]
	public (Entity, NativeSlice<Entity>) PLNOEGBGHHK(int GNPGECNAJNK)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6604870", Offset = "0x6603C70", VA = "0x186604870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct HNDLOHCHOMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public float3 OMFIFBMFGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public quaternion PFHPGOOLCFP;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static readonly ACMLBEEJFIH<HNDLOHCHOMJ> DEEICBABDMJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x65FF0F0", Offset = "0x65FE4F0", VA = "0x1865FF0F0")]
	public float3 JDAEJDLAMCK(float3 GAKPKGDNIKB)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class AELDJJBJMHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[LOLFLGCGIPK]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[FKOOJCCLEPP(218523523639012570uL, 15191719635551116065uL)]
public struct FBPAKDBBNNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private uint POHMMNEJCAH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct LMAEJBKEBOI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DDOJNEGANHI]
[PKDDPLFKGBL("Light", 0)]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
public struct LOAEDEBIOBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[CEBMHPKFAPE(1)]
	[JDHENIHDGLC(0)]
	public float LBGKGNOGEBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct AMIMGINDEPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[CEBMHPKFAPE(1)]
	public quaternion EDHIFCBPMNM;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static readonly ACMLBEEJFIH<AMIMGINDEPK> DEEICBABDMJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0")]
	public static AMIMGINDEPK PGDDHPNABOB(quaternion KKIAKNLLHIO)
	{
		return default(AMIMGINDEPK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct BHALMHEHILJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[CEBMHPKFAPE(1)]
	public Entity GDNOLIODDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[CEBMHPKFAPE(2)]
	public bool FMICNMMGNLM;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct AIBBLFNNFIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public FixedString32Bytes DKPHPKDPBCM;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[LOLFLGCGIPK]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[FKOOJCCLEPP(4470189027631723570uL, 5922380073816386711uL)]
public struct DNJNACAIJOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[HNGEBFPDALN(1)]
	public BEFJNEGHDLH NNGHEIFAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[CEBMHPKFAPE(2)]
	public OAJFDCHLCGC IKCCAADCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[CEBMHPKFAPE(3)]
	[JDHENIHDGLC(0)]
	public LOICABBCFFI DPCIMGCLNIG;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly ACMLBEEJFIH<DNJNACAIJOD> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct NCBDLCCOLLK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public Entity GADLFIMOHJF;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
[LOOHBIGMFNI(0, 1)]
public enum BKNLNAKIJMF
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	All = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct FJMCLKCMELD : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[OOHGJABINCL(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[HNGEBFPDALN(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[HNGEBFPDALN(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[HNGEBFPDALN(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[HNGEBFPDALN(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[OOHGJABINCL(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, EKKONKFFCGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[HNGEBFPDALN(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0")]
		public static SerializableGuid PGDDHPNABOB(Guid EBABBHGKMJL)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x66060C0", Offset = "0x66054C0", VA = "0x1866060C0", Slot = "4")]
		public bool Equals(SerializableGuid LNOOAJJNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x66060A0", Offset = "0x66054A0", VA = "0x1866060A0", Slot = "5")]
		public int CompareTo(SerializableGuid LNOOAJJNCAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6606150", Offset = "0x6605550", VA = "0x186606150", Slot = "6")]
		public void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6606240", Offset = "0x6605640", VA = "0x186606240", Slot = "7")]
		public void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x66062C0", Offset = "0x66056C0", VA = "0x1866062C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct NHCDHNMEDLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct HPCPIEMJNKG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[LOOHBIGMFNI(0, 4)]
public enum ADPOFAHLCIJ
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct CCOHIPHICJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[CEBMHPKFAPE(1)]
	public bool PIAGFCIJCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[CEBMHPKFAPE(2)]
	public byte ENMLFFINFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[CEBMHPKFAPE(3)]
	public short FIBBOMOKMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[CEBMHPKFAPE(4)]
	public ushort OOPOCHPMLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[CEBMHPKFAPE(5)]
	public int GLCBHFKNCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[CEBMHPKFAPE(6)]
	public uint IDBICAJHDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[CEBMHPKFAPE(7)]
	public long KPNLNPPKOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[CEBMHPKFAPE(8)]
	public ulong CFFBHIKDOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[CEBMHPKFAPE(9)]
	public float OLBGPIDACHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[CEBMHPKFAPE(10)]
	public double PHCLKMEJBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[CEBMHPKFAPE(11)]
	public AIAHNKPBHDB FCCBNDBHLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[CEBMHPKFAPE(12)]
	public DOJMNKLOMCA GHFKDOPFHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[CEBMHPKFAPE(13)]
	public KNBGBNPPALG OBCCNDEFGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[CEBMHPKFAPE(14)]
	public KPOKNGKPOAO ALMNOFJKAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[CEBMHPKFAPE(15)]
	public HBFKLDFKEMN HKOBCDAKJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[CEBMHPKFAPE(16)]
	public DFJNMIMDDMD BBNJHHFBIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[CEBMHPKFAPE(17)]
	public LGDIHCLNIBF LCPPMCKKBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[CEBMHPKFAPE(18)]
	public FJEIKHLHPHB PCNIHLEOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[CEBMHPKFAPE(20)]
	public Quaternion OOPEEBJADOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[CEBMHPKFAPE(22)]
	public Vector3 CHEIPCBLGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[CEBMHPKFAPE(23)]
	public Vector4 CDPKJPALBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[CEBMHPKFAPE(40)]
	public Entity NPPPBPEHAJG;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum AIAHNKPBHDB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum DOJMNKLOMCA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum KNBGBNPPALG : short
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum KPOKNGKPOAO : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum HBFKLDFKEMN
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public enum DFJNMIMDDMD : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public enum LGDIHCLNIBF : long
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum FJEIKHLHPHB : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[DDOJNEGANHI]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[DDOJNEGANHI]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class NLLAHHEKEDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public int OEKDIKJACFK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int AOEGLBBBOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public GameObject GACFHLOJJGF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public NLLAHHEKEDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class JINKCBBLAPL : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public struct MIEPJMINLJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector3 CBNOICCCFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public List<SerializableGuid> OPOADBFCLCM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class MIDBBNEPPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MIEPJMINLJC DKLKHLLMKOC;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public MIDBBNEPPDF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public SerializableGuid KDPMCEEMIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public List<int> JILBFLCJMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public List<MIEPJMINLJC> MLHDOFFPPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public List<MIDBBNEPPDF> HDPGAEIBOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public GameObject GACFHLOJJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Light KGFPLOKHOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Collider JGLBLFOJFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public string AGGGCFIJJMB;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JINKCBBLAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[LOLFLGCGIPK]
[PKDDPLFKGBL("Container", 0)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[FKOOJCCLEPP(2613756846563002039uL, 6372660366488563574uL)]
public struct CHMANCDMCGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[CEBMHPKFAPE(1)]
	[JDHENIHDGLC(0)]
	public JJIEHNHLEGE JOLJGBNMBEL;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[Flags]
[LOOHBIGMFNI(0, 15)]
public enum JJIEHNHLEGE
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[LOLFLGCGIPK]
[FKOOJCCLEPP(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct GMLBDPBDFED : IComponentData, IEquatable<GMLBDPBDFED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[CEBMHPKFAPE(1)]
	public FixedString64Bytes DKPHPKDPBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	[CEBMHPKFAPE(2)]
	public EAMGDIDKDJL FEAMFDCPIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[CEBMHPKFAPE(3)]
	public JJIEHNHLEGE JOLJGBNMBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[CEBMHPKFAPE(4)]
	public NKDNJBIKNOF LPHIMHIOLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[CEBMHPKFAPE(5)]
	public CPJLKGMKAHP NNGHEIFAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	[CEBMHPKFAPE(6)]
	public float GAENOBMELFL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x65FEED0", Offset = "0x65FE2D0", VA = "0x1865FEED0", Slot = "4")]
	public bool Equals(GMLBDPBDFED LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct AJOCNBBAOJF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct JFIGADANBCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	[CEBMHPKFAPE(1)]
	public NDDEKGODHLE ANKHOKAAJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct NGCCGHIFCBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	[CEBMHPKFAPE(1)]
	public float3 KLNBLJCMMCM;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly ACMLBEEJFIH<NGCCGHIFCBM> DEEICBABDMJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
	public static NGCCGHIFCBM PGDDHPNABOB(float3 KKIAKNLLHIO)
	{
		return default(NGCCGHIFCBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct JLGOPHNCNPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public Entity GADLFIMOHJF;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[InternalBufferCapacity(8)]
public struct NCPFCBDGLKK : ISystemStateBufferElementData, IBufferElementData, IEquatable<NCPFCBDGLKK>, GDGEAAKNBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public Entity CDFHGECAPKI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity IBGCNNGCIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6601A30", Offset = "0x6600E30", VA = "0x186601A30", Slot = "4")]
	public bool Equals(NCPFCBDGLKK LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct FEJNLFHLHLG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public Entity BMBJJEDFMKB;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[LOOHBIGMFNI(0, 4)]
public enum IPKCLDKJBAH
{
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct KPMOMMGMLCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	[CEBMHPKFAPE(1)]
	public quaternion EDHIFCBPMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	[CEBMHPKFAPE(2)]
	public float3 KLNBLJCMMCM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static readonly ACMLBEEJFIH<KPMOMMGMLCH> DEEICBABDMJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x16CF5C0", Offset = "0x16CE9C0", VA = "0x1816CF5C0")]
	public KPMOMMGMLCH(quaternion EDHIFCBPMNM, float3 KLNBLJCMMCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x66009E0", Offset = "0x65FFDE0", VA = "0x1866009E0")]
	public static RigidTransform PGDDHPNABOB(KPMOMMGMLCH KMOJMCOHDKC)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66009E0", Offset = "0x65FFDE0", VA = "0x1866009E0")]
	public static KPMOMMGMLCH PGDDHPNABOB(RigidTransform FGPGCDAKBPB)
	{
		return default(KPMOMMGMLCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class MOOAKJHACMC
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface GDGEAAKNBIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity KONLACAKAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[LOLFLGCGIPK]
[FKOOJCCLEPP(9807788745867066359uL, 15168486114979071194uL)]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct EHBGDPJMKFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	[CEBMHPKFAPE(1)]
	public BEFJNEGHDLH NNGHEIFAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	[CEBMHPKFAPE(2)]
	public OAJFDCHLCGC IKCCAADCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	[CEBMHPKFAPE(3)]
	[JDHENIHDGLC(0)]
	public bool ACEJIJNMIPA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static readonly ACMLBEEJFIH<EHBGDPJMKFG> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[DDOJNEGANHI]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
public struct LCEBLCAALOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	[CEBMHPKFAPE(2)]
	public bool AMNJFJGPIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	[CEBMHPKFAPE(3)]
	public bool ELHKCDAEMAF;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly ACMLBEEJFIH<LCEBLCAALOE> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[TypeManager.TypeVersion(3)]
[PKDDPLFKGBL("Object", 0)]
public struct JDPPKCPDCCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	[CEBMHPKFAPE(2)]
	public OAJFDCHLCGC IKCCAADCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	[CEBMHPKFAPE(3)]
	[JDHENIHDGLC(0)]
	public LOICABBCFFI DPCIMGCLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	[JDHENIHDGLC(0)]
	[CEBMHPKFAPE(5)]
	public MLJJMANCKBM HKBDAKPECLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	[HNGEBFPDALN(4)]
	public BEFJNEGHDLH NNGHEIFAPDC;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly ACMLBEEJFIH<JDPPKCPDCCN> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct CKHCBEKGHBH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public int ELEHMFAPFEI;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct MBDEFCELPAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public GCHandle AOKLLHIDBBO;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct JHOHCLIGMLG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private int EPINEIONHKC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NANJAGEOPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6600470", Offset = "0x65FF870", VA = "0x186600470")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6600460", Offset = "0x65FF860", VA = "0x186600460")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct MBEJAMAPKDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	[CEBMHPKFAPE(1)]
	public Entity HPAAIDILGEN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static MBEJAMAPKDB PGDDHPNABOB(Entity FKNFFDFGNMN)
	{
		return default(MBEJAMAPKDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[LOLFLGCGIPK]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[FKOOJCCLEPP(14327281633525910712uL, 2559857777606771911uL)]
public struct OOINIJOGBJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	[CEBMHPKFAPE(1)]
	public LENINMGJJHF MNOKFAHHNHH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct AJNJIKFJJCL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct OGGOJLEGOPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[CEBMHPKFAPE(1)]
	public float3 ENFLOCFADOH;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static readonly ACMLBEEJFIH<OGGOJLEGOPG> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[DDOJNEGANHI]
[PKDDPLFKGBL("Container", 0)]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
public struct OCDNLHJAHOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[CEBMHPKFAPE(1)]
	[JDHENIHDGLC(0)]
	public NKDNJBIKNOF LPHIMHIOLOK;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[LOOHBIGMFNI(0, 1)]
public enum NKDNJBIKNOF
{
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[OOHGJABINCL(1)]
public struct OAJFDCHLCGC : EKKONKFFCGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[HNGEBFPDALN(1)]
	public bool GDHKPCGLKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[HNGEBFPDALN(2)]
	public float3 FIKEENDLCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[HNGEBFPDALN(3)]
	public float3 FHFINKEANBO;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public static readonly ACMLBEEJFIH<OAJFDCHLCGC> DEEICBABDMJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x66046F0", Offset = "0x6603AF0", VA = "0x1866046F0", Slot = "5")]
	public void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x66046A0", Offset = "0x6603AA0", VA = "0x1866046A0", Slot = "4")]
	public void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct BIDKPBGLPNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[CEBMHPKFAPE(1)]
	public EHKHPDFBEJD MHEFEHIKCFI;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct FNFJMLHBKBO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public int ELEHMFAPFEI;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface FAAACEJLHBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIHCNNMAEPH(bool NIEDLIODGPB);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.TypeVersion(2)]
public struct PCCFEGNEHCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public uint KAIBKLMLBFA;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6604FD0", Offset = "0x66043D0", VA = "0x186604FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct ECDMAAGJOJO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct NIJEJHBGOAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct BPGHOOKJCAM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[NFMOBAODLHH]
internal struct DHBCNOAODED : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public Entity HHGGGAMLHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public int NANJAGEOPJI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct GHLNMFNBDJO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[PKDDPLFKGBL("Visual", 0)]
public struct LDKCLEBDGJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[CEBMHPKFAPE(1)]
	[JDHENIHDGLC(0)]
	public LIADJHCPFLA FJGGIOBFKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	[JDHENIHDGLC(0)]
	[CEBMHPKFAPE(2)]
	public DCEBDMIDHCN JMOIMJGFABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	[CEBMHPKFAPE(3)]
	[JDHENIHDGLC(0)]
	public float BIANDFIBNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	[CEBMHPKFAPE(4)]
	[JDHENIHDGLC(0)]
	public Vector3 NKJOMNJDNPN;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[DDOJNEGANHI]
[PKDDPLFKGBL("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct JBOOJPNGIGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	[CEBMHPKFAPE(1)]
	[JDHENIHDGLC(0)]
	public float KIHNJIBBMJL;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly ACMLBEEJFIH<JBOOJPNGIGM> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[OOHGJABINCL(1)]
public struct CMGJAEOCGHK : IComparable<CMGJAEOCGHK>, IEquatable<CMGJAEOCGHK>, EKKONKFFCGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	[HNGEBFPDALN(1)]
	public uint HEMAMLALCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	[HNGEBFPDALN(2)]
	public uint OJNAAHDDOMD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint JGKLMAGIMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65FDE70", Offset = "0x65FD270", VA = "0x1865FDE70")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x65FE0F0", Offset = "0x65FD4F0", VA = "0x1865FE0F0")]
	public CMGJAEOCGHK(int HEMAMLALCHH, int IOLHHMEJKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x65FE0F0", Offset = "0x65FD4F0", VA = "0x1865FE0F0")]
	public CMGJAEOCGHK(uint HEMAMLALCHH, uint IOLHHMEJKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x65FDC80", Offset = "0x65FD080", VA = "0x1865FDC80")]
	public CMGJAEOCGHK CKDHMOPIOMI(int IFONHBAKCAB = 1)
	{
		return default(CMGJAEOCGHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x65FDE80", Offset = "0x65FD280", VA = "0x1865FDE80")]
	public CMGJAEOCGHK GMFEHFKPNIA(int IFONHBAKCAB = 1)
	{
		return default(CMGJAEOCGHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x65FDD00", Offset = "0x65FD100", VA = "0x1865FDD00")]
	public static CMGJAEOCGHK ECFPPFEFHCE(CMGJAEOCGHK OEMIPMEJOAJ, CMGJAEOCGHK NJNCIEAMKKF)
	{
		return default(CMGJAEOCGHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x65FDE40", Offset = "0x65FD240", VA = "0x1865FDE40")]
	private static uint FDIOPLNDKFE(uint EJOFMGLMADH, uint CMACFBOCONA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x65FDCE0", Offset = "0x65FD0E0", VA = "0x1865FDCE0", Slot = "4")]
	public int CompareTo(CMGJAEOCGHK LNOOAJJNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x65FDDA0", Offset = "0x65FD1A0", VA = "0x1865FDDA0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x65FE010", Offset = "0x65FD410", VA = "0x1865FE010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x65FDD80", Offset = "0x65FD180", VA = "0x1865FDD80", Slot = "5")]
	public bool Equals(CMGJAEOCGHK LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x65FDEE0", Offset = "0x65FD2E0", VA = "0x1865FDEE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x65FDF30", Offset = "0x65FD330", VA = "0x1865FDF30", Slot = "6")]
	public void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x65FDFA0", Offset = "0x65FD3A0", VA = "0x1865FDFA0", Slot = "7")]
	public void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x228CBB0", Offset = "0x228BFB0", VA = "0x18228CBB0")]
	public static bool MCJHDEKAHDI(CMGJAEOCGHK OEMIPMEJOAJ, CMGJAEOCGHK NJNCIEAMKKF)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[DDOJNEGANHI]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public LENINMGJJHF prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class KCBGAOMFFAM
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6600580", Offset = "0x65FF980", VA = "0x186600580")]
	public static bool BBCIHGAILLO(this LENINMGJJHF JLNNFEOBAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6600600", Offset = "0x65FFA00", VA = "0x186600600")]
	public static string NCPILENFOLB(this LENINMGJJHF JLNNFEOBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x66005B0", Offset = "0x65FF9B0", VA = "0x1866005B0")]
	public static CJNBAFDACBF DODEMOFAKND(this LENINMGJJHF MNOKFAHHNHH)
	{
		return default(CJNBAFDACBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x66005F0", Offset = "0x65FF9F0", VA = "0x1866005F0")]
	internal static OKJJCJANPMO LJBJMAHIPFA(this CJNBAFDACBF DNIJHALFNBM)
	{
		return default(OKJJCJANPMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x66005D0", Offset = "0x65FF9D0", VA = "0x1866005D0")]
	internal static OKJJCJANPMO LJBJMAHIPFA(this LENINMGJJHF MNOKFAHHNHH)
	{
		return default(OKJJCJANPMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class IPHADIEAMNO
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly Dictionary<LENINMGJJHF, string> MGAIFGGEEMH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x65FF830", Offset = "0x65FEC30", VA = "0x1865FF830")]
	public static string OCEJNPKJELE(this LENINMGJJHF JLNNFEOBAMK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct DCKILIBKJDA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[LOLFLGCGIPK]
[FKOOJCCLEPP(9898405628982320166uL, 2023375009558162791uL)]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
public struct MFEHEBNNCHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[CEBMHPKFAPE(1)]
	public BEFJNEGHDLH NNGHEIFAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	[CEBMHPKFAPE(2)]
	public OAJFDCHLCGC IKCCAADCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	[CEBMHPKFAPE(3)]
	[JDHENIHDGLC(0)]
	public bool ACEJIJNMIPA;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly ACMLBEEJFIH<MFEHEBNNCHG> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct MALNHGKPJOL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public Entity EKJMNMKLHOM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static MALNHGKPJOL PGDDHPNABOB(Entity FKNFFDFGNMN)
	{
		return default(MALNHGKPJOL);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[DDOJNEGANHI]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[HNGEBFPDALN(1)]
		public uint networkIdBits;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct OHIBNPJBFNH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct IGJCCCPFMIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public float3 LFCMEMLJNLK;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly ACMLBEEJFIH<IGJCCCPFMIK> DEEICBABDMJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct BPEMLPIONDL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[PKDDPLFKGBL("Container", 0)]
public struct JACBBANCLJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[JDHENIHDGLC(0)]
	[CEBMHPKFAPE(1)]
	public GLOKJOPHMOK PIAMNDKENMK;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly ACMLBEEJFIH<JACBBANCLJG> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[LOOHBIGMFNI(0, 127)]
public enum GLOKJOPHMOK
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class AFFBEDGFGOF
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public enum NLJNCBHAHFC
	{
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public enum ECKDCBJEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x65FD570", Offset = "0x65FC970", VA = "0x1865FD570")]
	public static (NLJNCBHAHFC, ECKDCBJEHBM) GMHPPCFADKI(this GLOKJOPHMOK AJPOMNKHCNB)
	{
		return default((NLJNCBHAHFC, ECKDCBJEHBM));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct GNJBMJAPDOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Entity COMCNEGAGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public int IFONHBAKCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public int PGBALNGGNPG;
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
public struct ELLKBCJMOKK : IComponentData, GDGEAAKNBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	[CEBMHPKFAPE(1)]
	public Entity ILDFJHMNOPJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity IBGCNNGCIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0")]
	public ELLKBCJMOKK(Entity ILDFJHMNOPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static ELLKBCJMOKK PGDDHPNABOB(Entity FKNFFDFGNMN)
	{
		return default(ELLKBCJMOKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct LGGMOLOMIMK : ISystemStateComponentData, IComponentData, GDGEAAKNBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Entity FKBNJNEINDM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity IBGCNNGCIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0")]
	public LGGMOLOMIMK(Entity ILDFJHMNOPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static LGGMOLOMIMK PGDDHPNABOB(Entity FKNFFDFGNMN)
	{
		return default(LGGMOLOMIMK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct IFLOCLHFHHI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[LOOHBIGMFNI(1000, 8000)]
public enum LENINMGJJHF
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	GameObject_Prop = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public static class DMIAHGHJPAP
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct AFKIDFBAFFI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[LOOHBIGMFNI(-2, 2)]
public enum IMFDFKNPFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	MAX = 2
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct GIEBHFOPPKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct ANMBIFMMJPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public uint CIFANPFDGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public int NAIINKBGJPL;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA281B0", VA = "0x180A28DB0")]
	public ANMBIFMMJPJ(uint JOJMFCGILKH, int GNEGMBIGDNK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct GCNILGBAOHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[LOOHBIGMFNI(-1, 31)]
public enum DCEBDMIDHCN
{
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct AAPMDMHDFAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[CEBMHPKFAPE(1)]
	public KKHDEPBDMGH BBCCHOEAGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public GCHandle PFLHMFKPPJD;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct BOIDEJCAFGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public float4x4 EDPPOHIOEHO;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly ACMLBEEJFIH<BOIDEJCAFGI> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
public struct GBNALMICONM : IComponentData, GDGEAAKNBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[CEBMHPKFAPE(1)]
	public Entity ILDFJHMNOPJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Entity IBGCNNGCIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0")]
	public GBNALMICONM(Entity ILDFJHMNOPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static GBNALMICONM PGDDHPNABOB(Entity FKNFFDFGNMN)
	{
		return default(GBNALMICONM);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x65FEA80", Offset = "0x65FDE80", VA = "0x1865FEA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct GMDDLLEBDJO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[NFMOBAODLHH]
public struct AACCMKHOGIP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public Entity EOOPPEEEACO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static AACCMKHOGIP PGDDHPNABOB(Entity KKIAKNLLHIO)
	{
		return default(AACCMKHOGIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct JNIDFKDGLIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[CEBMHPKFAPE(1)]
	public BKNLNAKIJMF FIFHBPPFAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[CEBMHPKFAPE(2)]
	public IMFDFKNPFMM LANCKCPOFDJ;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct APFFJEIGPOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[CEBMHPKFAPE(1)]
	public bool KDLMOBCGODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[CEBMHPKFAPE(2)]
	public bool OHGIFEGAFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[CEBMHPKFAPE(3)]
	public float MMEBBOKFEMI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct LIMNCIOFPGM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct DPJNHFIDPBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct NEHEFBBJJKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[CEBMHPKFAPE(1)]
	public quaternion EDHIFCBPMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[CEBMHPKFAPE(2)]
	public float3 KLNBLJCMMCM;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly ACMLBEEJFIH<NEHEFBBJJKL> DEEICBABDMJ;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x16CF5C0", Offset = "0x16CE9C0", VA = "0x1816CF5C0")]
	public NEHEFBBJJKL(quaternion EDHIFCBPMNM, float3 KLNBLJCMMCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66009E0", Offset = "0x65FFDE0", VA = "0x1866009E0")]
	public static NEHEFBBJJKL PGDDHPNABOB(RigidTransform FGPGCDAKBPB)
	{
		return default(NEHEFBBJJKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class DAIJOAMFBAN
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[DDOJNEGANHI]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct FBHOIFALACF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[CEBMHPKFAPE(1)]
	public AKFHJJDFLNB MHEFEHIKCFI;
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : DMCBJAFGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x66062D0", Offset = "0x66056D0", VA = "0x1866062D0", Slot = "4")]
		public sealed override void DGJCFGACDCK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal class PGEALFPJPCL : ContainerPropertyBag<EPBBAOCLMKB>
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private class AKALDHLEDKP : Property<EPBBAOCLMKB, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x65FD720", Offset = "0x65FCB20", VA = "0x1865FD720", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x65FD6E0", Offset = "0x65FCAE0", VA = "0x1865FD6E0")]
		public AKALDHLEDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2715A00", Offset = "0x2714E00", VA = "0x182715A00", Slot = "14")]
		public override Rigidbody GetValue(ref EPBBAOCLMKB OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2715A20", Offset = "0x2714E20", VA = "0x182715A20", Slot = "15")]
		public override void SetValue(ref EPBBAOCLMKB OHJGEOICJDB, Rigidbody KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6605120", Offset = "0x6604520", VA = "0x186605120")]
	public PGEALFPJPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class ADENHLGHJCF : ContainerPropertyBag<FHIMMFIMNFM>
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class HGAECGICNDE : Property<FHIMMFIMNFM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x65FEFF0", Offset = "0x65FE3F0", VA = "0x1865FEFF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x65FEFB0", Offset = "0x65FE3B0", VA = "0x1865FEFB0")]
		public HGAECGICNDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2715A00", Offset = "0x2714E00", VA = "0x182715A00", Slot = "14")]
		public override object GetValue(ref FHIMMFIMNFM OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2715A20", Offset = "0x2714E20", VA = "0x182715A20", Slot = "15")]
		public override void SetValue(ref FHIMMFIMNFM OHJGEOICJDB, object KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x65FD4A0", Offset = "0x65FC8A0", VA = "0x1865FD4A0")]
	public ADENHLGHJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal class HLPGKNGLGPL : ContainerPropertyBag<OEDLHJHPJCL>
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class MFKEGNFILAK : Property<OEDLHJHPJCL, ELAIMCPDFHF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6601380", Offset = "0x6600780", VA = "0x186601380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6601340", Offset = "0x6600740", VA = "0x186601340")]
		public MFKEGNFILAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2715A00", Offset = "0x2714E00", VA = "0x182715A00", Slot = "14")]
		public override ELAIMCPDFHF GetValue(ref OEDLHJHPJCL OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2715A20", Offset = "0x2714E20", VA = "0x182715A20", Slot = "15")]
		public override void SetValue(ref OEDLHJHPJCL OHJGEOICJDB, ELAIMCPDFHF KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x65FF020", Offset = "0x65FE420", VA = "0x1865FF020")]
	public HLPGKNGLGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class BMOBAFOHMBK : ContainerPropertyBag<JIMLGCDPNAA>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class JGLKBLJKBAC : Property<JIMLGCDPNAA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6600360", Offset = "0x65FF760", VA = "0x186600360", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6600320", Offset = "0x65FF720", VA = "0x186600320")]
		public JGLKBLJKBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2715A00", Offset = "0x2714E00", VA = "0x182715A00", Slot = "14")]
		public override object GetValue(ref JIMLGCDPNAA OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2715A20", Offset = "0x2714E20", VA = "0x182715A20", Slot = "15")]
		public override void SetValue(ref JIMLGCDPNAA OHJGEOICJDB, object KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x65FD890", Offset = "0x65FCC90", VA = "0x1865FD890")]
	public BMOBAFOHMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class MEKJFMGNICH : ContainerPropertyBag<NLLAHHEKEDN>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class NDAIOFOECFM : Property<NLLAHHEKEDN, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6601AA0", Offset = "0x6600EA0", VA = "0x186601AA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6601A60", Offset = "0x6600E60", VA = "0x186601A60")]
		public NDAIOFOECFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x42E8EF0", Offset = "0x42E82F0", VA = "0x1842E8EF0", Slot = "14")]
		public override int GetValue(ref NLLAHHEKEDN OHJGEOICJDB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6601A40", Offset = "0x6600E40", VA = "0x186601A40", Slot = "15")]
		public override void SetValue(ref NLLAHHEKEDN OHJGEOICJDB, int KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	private class JOFMOLAPIAB : Property<NLLAHHEKEDN, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6600550", Offset = "0x65FF950", VA = "0x186600550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6600510", Offset = "0x65FF910", VA = "0x186600510")]
		public JOFMOLAPIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x42E8F80", Offset = "0x42E8380", VA = "0x1842E8F80", Slot = "14")]
		public override int GetValue(ref NLLAHHEKEDN OHJGEOICJDB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x66004F0", Offset = "0x65FF8F0", VA = "0x1866004F0", Slot = "15")]
		public override void SetValue(ref NLLAHHEKEDN OHJGEOICJDB, int KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class PEHEINJKLMD : Property<NLLAHHEKEDN, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x66050F0", Offset = "0x66044F0", VA = "0x1866050F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x66050B0", Offset = "0x66044B0", VA = "0x1866050B0")]
		public PEHEINJKLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6605060", Offset = "0x6604460", VA = "0x186605060", Slot = "14")]
		public override GameObject GetValue(ref NLLAHHEKEDN OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6605080", Offset = "0x6604480", VA = "0x186605080", Slot = "15")]
		public override void SetValue(ref NLLAHHEKEDN OHJGEOICJDB, GameObject KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x66010A0", Offset = "0x66004A0", VA = "0x1866010A0")]
	public MEKJFMGNICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class GGKIEGCKIEL : ContainerPropertyBag<JINKCBBLAPL>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class ENGAAJJDKOE : Property<JINKCBBLAPL, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x65FE8A0", Offset = "0x65FDCA0", VA = "0x1865FE8A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x65FE860", Offset = "0x65FDC60", VA = "0x1865FE860")]
		public ENGAAJJDKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x65FE810", Offset = "0x65FDC10", VA = "0x1865FE810", Slot = "14")]
		public override SerializableGuid GetValue(ref JINKCBBLAPL OHJGEOICJDB)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x65FE840", Offset = "0x65FDC40", VA = "0x1865FE840", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL OHJGEOICJDB, SerializableGuid KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class KGAFMBIEAPM : Property<JINKCBBLAPL, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6600710", Offset = "0x65FFB10", VA = "0x186600710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x66006D0", Offset = "0x65FFAD0", VA = "0x1866006D0")]
		public KGAFMBIEAPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6600680", Offset = "0x65FFA80", VA = "0x186600680", Slot = "14")]
		public override List<int> GetValue(ref JINKCBBLAPL OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x66006A0", Offset = "0x65FFAA0", VA = "0x1866006A0", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL OHJGEOICJDB, List<int> KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private class LAIFDIEGNBE : Property<JINKCBBLAPL, List<JINKCBBLAPL.MIEPJMINLJC>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6600B60", Offset = "0x65FFF60", VA = "0x186600B60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6600B20", Offset = "0x65FFF20", VA = "0x186600B20")]
		public LAIFDIEGNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6600AD0", Offset = "0x65FFED0", VA = "0x186600AD0", Slot = "14")]
		public override List<JINKCBBLAPL.MIEPJMINLJC> GetValue(ref JINKCBBLAPL OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6600AF0", Offset = "0x65FFEF0", VA = "0x186600AF0", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL OHJGEOICJDB, List<JINKCBBLAPL.MIEPJMINLJC> KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class FDMAOGOCECD : Property<JINKCBBLAPL, List<JINKCBBLAPL.MIDBBNEPPDF>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x65FE9D0", Offset = "0x65FDDD0", VA = "0x1865FE9D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x65FE990", Offset = "0x65FDD90", VA = "0x1865FE990")]
		public FDMAOGOCECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x65FE940", Offset = "0x65FDD40", VA = "0x1865FE940", Slot = "14")]
		public override List<JINKCBBLAPL.MIDBBNEPPDF> GetValue(ref JINKCBBLAPL OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x65FE960", Offset = "0x65FDD60", VA = "0x1865FE960", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL OHJGEOICJDB, List<JINKCBBLAPL.MIDBBNEPPDF> KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class NIMHDOEMNAA : Property<JINKCBBLAPL, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x66045C0", Offset = "0x66039C0", VA = "0x1866045C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6604580", Offset = "0x6603980", VA = "0x186604580")]
		public NIMHDOEMNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6604530", Offset = "0x6603930", VA = "0x186604530", Slot = "14")]
		public override GameObject GetValue(ref JINKCBBLAPL OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6604550", Offset = "0x6603950", VA = "0x186604550", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL OHJGEOICJDB, GameObject KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class MGFKAACFILC : Property<JINKCBBLAPL, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6601440", Offset = "0x6600840", VA = "0x186601440", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6601400", Offset = "0x6600800", VA = "0x186601400")]
		public MGFKAACFILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x66013B0", Offset = "0x66007B0", VA = "0x1866013B0", Slot = "14")]
		public override Light GetValue(ref JINKCBBLAPL OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x66013D0", Offset = "0x66007D0", VA = "0x1866013D0", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL OHJGEOICJDB, Light KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class BPDNJFDDBDF : Property<JINKCBBLAPL, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x65FDAD0", Offset = "0x65FCED0", VA = "0x1865FDAD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x65FDA90", Offset = "0x65FCE90", VA = "0x1865FDA90")]
		public BPDNJFDDBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x65FDA40", Offset = "0x65FCE40", VA = "0x1865FDA40", Slot = "14")]
		public override Collider GetValue(ref JINKCBBLAPL OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x65FDA60", Offset = "0x65FCE60", VA = "0x1865FDA60", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL OHJGEOICJDB, Collider KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class PJANOJOEODM : Property<JINKCBBLAPL, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6605280", Offset = "0x6604680", VA = "0x186605280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6605240", Offset = "0x6604640", VA = "0x186605240")]
		public PJANOJOEODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x66051F0", Offset = "0x66045F0", VA = "0x1866051F0", Slot = "14")]
		public override string GetValue(ref JINKCBBLAPL OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6605210", Offset = "0x6604610", VA = "0x186605210", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL OHJGEOICJDB, string KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x65FEA90", Offset = "0x65FDE90", VA = "0x1865FEA90")]
	public GGKIEGCKIEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class DJIKFEKDMGK : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class LIAFPOJBDGO : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6600D70", Offset = "0x6600170", VA = "0x186600D70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6600C80", Offset = "0x6600080", VA = "0x186600C80")]
		public LIAFPOJBDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A3EF60", Offset = "0x1A3E360", VA = "0x181A3EF60", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid OHJGEOICJDB)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x63923F0", Offset = "0x63917F0", VA = "0x1863923F0", Slot = "15")]
		public override void SetValue(ref SerializableGuid OHJGEOICJDB, Data128 KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x65FE3F0", Offset = "0x65FD7F0", VA = "0x1865FE3F0")]
	public DJIKFEKDMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class MPIBECJIJOJ : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class KGILBFLFDDE : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6600830", Offset = "0x65FFC30", VA = "0x186600830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6600740", Offset = "0x65FFB40", VA = "0x186600740")]
		public KGILBFLFDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xD91170", Offset = "0xD90570", VA = "0x180D91170", Slot = "14")]
		public override int GetValue(ref Data128 OHJGEOICJDB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3CFCE10", Offset = "0x3CFC210", VA = "0x183CFCE10", Slot = "15")]
		public override void SetValue(ref Data128 OHJGEOICJDB, int KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class PBJOCHDFDJE : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6604FA0", Offset = "0x66043A0", VA = "0x186604FA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6604EB0", Offset = "0x66042B0", VA = "0x186604EB0")]
		public PBJOCHDFDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6394720", Offset = "0x6393B20", VA = "0x186394720", Slot = "14")]
		public override int GetValue(ref Data128 OHJGEOICJDB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x42FB030", Offset = "0x42FA430", VA = "0x1842FB030", Slot = "15")]
		public override void SetValue(ref Data128 OHJGEOICJDB, int KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class OKOBEPBBBCI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6604D60", Offset = "0x6604160", VA = "0x186604D60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6604C70", Offset = "0x6604070", VA = "0x186604C70")]
		public OKOBEPBBBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xCD2530", Offset = "0xCD1930", VA = "0x180CD2530", Slot = "14")]
		public override int GetValue(ref Data128 OHJGEOICJDB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x639AD10", Offset = "0x639A110", VA = "0x18639AD10", Slot = "15")]
		public override void SetValue(ref Data128 OHJGEOICJDB, int KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class MBICEJOIHEJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6601010", Offset = "0x6600410", VA = "0x186601010", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6600F20", Offset = "0x6600320", VA = "0x186600F20")]
		public MBICEJOIHEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x639ABA0", Offset = "0x6399FA0", VA = "0x18639ABA0", Slot = "14")]
		public override int GetValue(ref Data128 OHJGEOICJDB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x639ABB0", Offset = "0x6399FB0", VA = "0x18639ABB0", Slot = "15")]
		public override void SetValue(ref Data128 OHJGEOICJDB, int KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x66014D0", Offset = "0x66008D0", VA = "0x1866014D0")]
	public MPIBECJIJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class PNKGOOBDEGI : ContainerPropertyBag<JINKCBBLAPL.MIEPJMINLJC>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class DHMIHGFJLEH : Property<JINKCBBLAPL.MIEPJMINLJC, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x65FE350", Offset = "0x65FD750", VA = "0x1865FE350", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x65FE310", Offset = "0x65FD710", VA = "0x1865FE310")]
		public DHMIHGFJLEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xD7A690", Offset = "0xD79A90", VA = "0x180D7A690", Slot = "14")]
		public override Vector3 GetValue(ref JINKCBBLAPL.MIEPJMINLJC OHJGEOICJDB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x65FE2F0", Offset = "0x65FD6F0", VA = "0x1865FE2F0", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL.MIEPJMINLJC OHJGEOICJDB, Vector3 KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class LOCNLBLCLGO : Property<JINKCBBLAPL.MIEPJMINLJC, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6600E90", Offset = "0x6600290", VA = "0x186600E90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6600E50", Offset = "0x6600250", VA = "0x186600E50")]
		public LOCNLBLCLGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6600E30", Offset = "0x6600230", VA = "0x186600E30", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref JINKCBBLAPL.MIEPJMINLJC OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6600E40", Offset = "0x6600240", VA = "0x186600E40", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL.MIEPJMINLJC OHJGEOICJDB, List<SerializableGuid> KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x66052B0", Offset = "0x66046B0", VA = "0x1866052B0")]
	public PNKGOOBDEGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class CCFBNEBKODF : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class LLKKCFCPCPG : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6600E00", Offset = "0x6600200", VA = "0x186600E00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6600DC0", Offset = "0x66001C0", VA = "0x186600DC0")]
		public LLKKCFCPCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6600DA0", Offset = "0x66001A0", VA = "0x186600DA0", Slot = "14")]
		public override float GetValue(ref Vector3 OHJGEOICJDB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6600DB0", Offset = "0x66001B0", VA = "0x186600DB0", Slot = "15")]
		public override void SetValue(ref Vector3 OHJGEOICJDB, float KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class LDAKJACPKIA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6600C50", Offset = "0x6600050", VA = "0x186600C50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6600C10", Offset = "0x6600010", VA = "0x186600C10")]
		public LDAKJACPKIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6600BF0", Offset = "0x65FFFF0", VA = "0x186600BF0", Slot = "14")]
		public override float GetValue(ref Vector3 OHJGEOICJDB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6600C00", Offset = "0x6600000", VA = "0x186600C00", Slot = "15")]
		public override void SetValue(ref Vector3 OHJGEOICJDB, float KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class DPEILEKMHEC : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x65FE6D0", Offset = "0x65FDAD0", VA = "0x1865FE6D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x65FE690", Offset = "0x65FDA90", VA = "0x1865FE690")]
		public DPEILEKMHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xE27B80", Offset = "0xE26F80", VA = "0x180E27B80", Slot = "14")]
		public override float GetValue(ref Vector3 OHJGEOICJDB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x65FE680", Offset = "0x65FDA80", VA = "0x1865FE680", Slot = "15")]
		public override void SetValue(ref Vector3 OHJGEOICJDB, float KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x65FDB00", Offset = "0x65FCF00", VA = "0x1865FDB00")]
	public CCFBNEBKODF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class JGPKGNCKBPN : ContainerPropertyBag<JINKCBBLAPL.MIDBBNEPPDF>
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class NPGMKIGNHPJ : Property<JINKCBBLAPL.MIDBBNEPPDF, JINKCBBLAPL.MIEPJMINLJC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x6604670", Offset = "0x6603A70", VA = "0x186604670", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6604630", Offset = "0x6603A30", VA = "0x186604630")]
		public NPGMKIGNHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6391250", Offset = "0x6390650", VA = "0x186391250", Slot = "14")]
		public override JINKCBBLAPL.MIEPJMINLJC GetValue(ref JINKCBBLAPL.MIDBBNEPPDF OHJGEOICJDB)
		{
			return default(JINKCBBLAPL.MIEPJMINLJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x66045F0", Offset = "0x66039F0", VA = "0x1866045F0", Slot = "15")]
		public override void SetValue(ref JINKCBBLAPL.MIDBBNEPPDF OHJGEOICJDB, JINKCBBLAPL.MIEPJMINLJC KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6600390", Offset = "0x65FF790", VA = "0x186600390")]
	public JGPKGNCKBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class CPDFONHGIDA : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class IHHHHKANBMF : Property<RRObjectPrefabV2Data, LENINMGJJHF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x65FF730", Offset = "0x65FEB30", VA = "0x1865FF730", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x65FF6F0", Offset = "0x65FEAF0", VA = "0x1865FF6F0")]
		public IHHHHKANBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xD91170", Offset = "0xD90570", VA = "0x180D91170", Slot = "14")]
		public override LENINMGJJHF GetValue(ref RRObjectPrefabV2Data OHJGEOICJDB)
		{
			return default(LENINMGJJHF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3CFCE10", Offset = "0x3CFC210", VA = "0x183CFCE10", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data OHJGEOICJDB, LENINMGJJHF KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x65FE220", Offset = "0x65FD620", VA = "0x1865FE220")]
	public CPDFONHGIDA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6605400", Offset = "0x6604800", VA = "0x186605400")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200010A")]
public class CBCPDCNEBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CBCPDCNEBEL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public class AuthoredParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public class AuthoredPreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	public class AuthoredChildrenData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public class ParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public class PreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
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

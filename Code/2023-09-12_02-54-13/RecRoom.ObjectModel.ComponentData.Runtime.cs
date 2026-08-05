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
public static class EECOJAJPGJI
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly List<(ICBIKEFGDEP nameHash, MAFKLBIHIJI stableTypeHash, Type type)> IOJLIDNACCE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly List<(ICBIKEFGDEP nameHash, MAFKLBIHIJI stableTypeHash, Type type)> JHLPPBAEAGO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly List<(ICBIKEFGDEP previousNameHash, MAFKLBIHIJI previousStableTypeHash, Type currentTypeName)> FDENBKFJDMC;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NMONOCINAHL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Rigidbody MOJFAKMKAFL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6837AF0", Offset = "0x6836EF0", VA = "0x186837AF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public NMONOCINAHL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AEHAADPJKOM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NJJJFEECKLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public HIECNPEDPHM IAEICMCBOLA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GAHHFAMPHOJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EIEHOBLCIBF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public object BDAKLIJNGLA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68353A0", Offset = "0x68347A0", VA = "0x1868353A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EIEHOBLCIBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct PCOECCEBHCE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity KEGFIDMGBNO;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HLFMACLNIBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float KGIGLEACBMK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly LMDMHELMEME<HLFMACLNIBJ> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IPGCDFPMJBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float3 FDAAJDIIKME;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KEKECMDLGFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface COBFMFPIDNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPEAGFLPFEB(GFEODBLIPAM MKCCIDALIGJ, GFEODBLIPAM JGAEINHKEAP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMEICNJFNDL();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBDHCDDLGNH();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMGNIMIBHCI(bool NNFJFPAHDOG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EBJCGFCDLNA();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEGKIBOJNAN();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GHOPCENMJJA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PAHLFHGCJMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int ALONJDCNGDE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FACE80", Offset = "0x1FAC280", VA = "0x181FACE80")]
	public static PAHLFHGCJMB LFFBPOODCDC(int AGLCIEKHLEE)
	{
		return default(PAHLFHGCJMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum HIECNPEDPHM
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum JDKBOLPCEHA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BDPBKBOOLFE : GNJLMOPJNKA, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FDHLCBIMPBP HMMPIOKGEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FDHLCBIMPBP);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KGCLIDEHBDE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public COBFMFPIDNL CAEJEIBPKBD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6836C50", Offset = "0x6836050", VA = "0x186836C50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public KGCLIDEHBDE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HHPJKKPEILJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KBHNDPLFLBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3x3 OAIPLLGEDIK;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly LMDMHELMEME<KBHNDPLFLBD> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MMAPMHIADFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float LIBKIHNMBEC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly LMDMHELMEME<MMAPMHIADFP> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AIPCDKCBABC]
public struct IPEKGNLDKPL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Entity GKMECPLEALF;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MFNPNAGNGGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float BDBMEBNCLGF;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly LMDMHELMEME<MFNPNAGNGGD> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CABAKAOCBGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 BLNDJNFLCGB;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DEIPAKLKMIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Entity AOCBEEBNJPK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BBPODCHHJDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GFEODBLIPAM
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
public struct ALGMENNAOAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3x3 OAIPLLGEDIK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly LMDMHELMEME<KBHNDPLFLBD> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct AAGDBGKJCGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity OJBGDMNECON;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GEFDGJLDEOF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct AHONBHHKKHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public HIECNPEDPHM EKFBKIAPFMK;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BJIDLEMPHAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public RigidbodyConstraints JAEAAMFNBED;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LBJCBOHNPFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float BCDKOLJKODC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly LMDMHELMEME<LBJCBOHNPFD> KCIIGNIKLNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct FNPBHJNEBDK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HDPPOKAAIMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public GFEODBLIPAM PNBBIDEMGAD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly LMDMHELMEME<HDPPOKAAIMG> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct FMDNHCAKKCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public CollisionDetectionMode PFGJFMAKIOB;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OAECBANIOKB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public object CDACKABBBPE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6837D60", Offset = "0x6837160", VA = "0x186837D60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OAECBANIOKB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FJOLOMCEIBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct AGBICMPIMCD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MAHODLKEPGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float3 JAHEMHCOHKI;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct AKFJOFKDFLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float ODPCCEIIAEN;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CCGJGDJOIKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 JFOPBIMEOOI;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[InternalBufferCapacity(8)]
public struct NCPPJPJLJPP : ISystemStateBufferElementData, IBufferElementData, IEquatable<NCPPJPJLJPP>, LILBGEFEHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity KEGFIDMGBNO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity CMBBKNEMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10")]
	public NCPPJPJLJPP(Entity KEGFIDMGBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6837960", Offset = "0x6836D60", VA = "0x186837960", Slot = "4")]
	public bool Equals(NCPPJPJLJPP ICELKIGIKKP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static NCPPJPJLJPP LFFBPOODCDC(Entity GKMECPLEALF)
	{
		return default(NCPPJPJLJPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct ENKJEJBGCMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[KCNAOLEHLIG(1)]
	public Entity JNHEGOFDJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[KCNAOLEHLIG(2)]
	public bool MJGLAAJCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[KCNAOLEHLIG(3)]
	public float EMKLNGDPLLA;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BDAHAFGFILL(1)]
public struct LDPBHDEACKL : AKHJKCAIBOP, IEquatable<LDPBHDEACKL>
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly LDPBHDEACKL ENEHFIHPPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[IHIPOJOKOIJ(1)]
	public int JNHCLKAAKHA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
	public LDPBHDEACKL(int JNHCLKAAKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6837080", Offset = "0x6836480", VA = "0x186837080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6836FF0", Offset = "0x68363F0", VA = "0x186836FF0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DA53C0", Offset = "0x3DA47C0", VA = "0x183DA53C0", Slot = "6")]
	public bool Equals(LDPBHDEACKL ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68370F0", Offset = "0x68364F0", VA = "0x1868370F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6836FD0", Offset = "0x68363D0", VA = "0x186836FD0", Slot = "5")]
	public void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6836FC0", Offset = "0x68363C0", VA = "0x186836FC0", Slot = "4")]
	public void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct KIKJFGLKOHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[KCNAOLEHLIG(1)]
	public float DHHEBBKINNJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly LMDMHELMEME<KIKJFGLKOHO> KCIIGNIKLNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal struct BLJBEIOPNNG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal struct MHNCPPLJJKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Entity GKMECPLEALF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static MHNCPPLJJKH LFFBPOODCDC(Entity GKMECPLEALF)
	{
		return default(MHNCPPLJJKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[JFGLPCLMEGA]
[ILHNOICDLPN("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct CBLMAECOKDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[HNONLGLFLKI(0)]
	[KCNAOLEHLIG(1)]
	public CAIENIPDHPC BLBMFDIEDCO;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Flags]
[GHGPPNIDBEA(0, 15943)]
public enum CAIENIPDHPC
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
public struct NPKDBJGANIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DEKLAKINCJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OCKCHABFHAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct DECPKCFEKHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct EMPCPACGKII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FINFIGNLDOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct AAGPEMBOHKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct GIHEFMCJHKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct DIDDKMCDKME : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct ELFFHONIBJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[IHIPOJOKOIJ(1)]
	public NGEGBFMLEIK LJJHJABONIO;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LMDMHELMEME<ELFFHONIBJL> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum NGEGBFMLEIK : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct PPPFOFLFJIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[KCNAOLEHLIG(1)]
	public float3 ANIJDMIGILL;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly LMDMHELMEME<PPPFOFLFJIM> KCIIGNIKLNC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
	public static PPPFOFLFJIM LFFBPOODCDC(float3 AGLCIEKHLEE)
	{
		return default(PPPFOFLFJIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[HIEFLIGLDHA]
[HFDGEEOOBCM(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct HDNKACKGINB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int DHGEBDOILEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[KCNAOLEHLIG(2)]
	public bool DEAPJDNEFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[KCNAOLEHLIG(3)]
	public bool IIAKNJEBEGP;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly LMDMHELMEME<HDNKACKGINB> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct PODMOPJDKIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float DLPLCAGLFMP;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly LMDMHELMEME<PODMOPJDKIH> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct HEGLKDBKLOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[KCNAOLEHLIG(1)]
	public SerializableGuid MNLPDHHHFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[KCNAOLEHLIG(2)]
	public SerializableGuid AANELEBBHAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[ILHNOICDLPN("Container", 0)]
public struct EKIJOGFFHLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[KCNAOLEHLIG(1)]
	[HNONLGLFLKI(0)]
	public EHCJCADIMGK ECFHAHDOLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly LMDMHELMEME<EKIJOGFFHLI> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[GHGPPNIDBEA(0, 2)]
public enum EHCJCADIMGK
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
internal enum MIACLOCLIHO
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
internal static class GLAEMLDGEMJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct ALMAOEHGALE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct FLCECKBCNDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[KCNAOLEHLIG(1)]
	public bool GCNKNLGIDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[KCNAOLEHLIG(2)]
	public bool MJGLAAJCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[KCNAOLEHLIG(3)]
	public float HJHGEAOCBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[KCNAOLEHLIG(4)]
	public float BBMNFGPBPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[KCNAOLEHLIG(5)]
	public float KBFJHJENIED;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[BDAHAFGFILL(1)]
public struct MGFBLKCEIKC : AKHJKCAIBOP
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Flags]
	[GHGPPNIDBEA(0, 7)]
	public enum EHAOJCCOEHL
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
	[IHIPOJOKOIJ(1)]
	public float CKLJNHIGAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[IHIPOJOKOIJ(2)]
	public int EHLJHLOFNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[IHIPOJOKOIJ(3)]
	public EHAOJCCOEHL BLBMFDIEDCO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CNAELMLCLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6837480", Offset = "0x6836880", VA = "0x186837480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6837410", Offset = "0x6836810", VA = "0x186837410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CFDGEDGLCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6837500", Offset = "0x6836900", VA = "0x186837500")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6837580", Offset = "0x6836980", VA = "0x186837580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OJIKOKDOHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68375C0", Offset = "0x68369C0", VA = "0x1868375C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68375A0", Offset = "0x68369A0", VA = "0x1868375A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6837430", Offset = "0x6836830", VA = "0x186837430", Slot = "5")]
	public void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68373B0", Offset = "0x68367B0", VA = "0x1868373B0", Slot = "4")]
	public void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal struct JCGFELPDEAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct FJFOKCMNCHF : ISystemStateComponentData, IComponentData, LILBGEFEHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity LPAAFNPINOB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity CMBBKNEMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct GGIBOLJLMEB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct JFBKHJNMIHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct OADFAJIFNBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float4x4 KOLCPDECNBC;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly LMDMHELMEME<OADFAJIFNBN> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct MHICMHFBLBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[KCNAOLEHLIG(1)]
	public HMPGJEKMJBE FNKOCAHKOGL;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct DECAIEJILIK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Flags]
	[GHGPPNIDBEA(0, 7)]
	public enum ECDHKGGDKCM
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
	[KCNAOLEHLIG(1)]
	public ECDHKGGDKCM BLBMFDIEDCO;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly LMDMHELMEME<DECAIEJILIK> KCIIGNIKLNC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool ECOJGEDOOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6832490", Offset = "0x6831890", VA = "0x186832490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CBACLEFLHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6832410", Offset = "0x6831810", VA = "0x186832410")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct AMAHPEIBDEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[KCNAOLEHLIG(1)]
	public float DHHEBBKINNJ;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly LMDMHELMEME<AMAHPEIBDEI> KCIIGNIKLNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct MGJONIHFLGD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
public struct FFKNFIHKHPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[KCNAOLEHLIG(1)]
	public BAINPBEIELK JBILBNOABFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct JCENCOFDCNI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct OPILEFNOLAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[KCNAOLEHLIG(1)]
	public Entity EFDPMAIOLJO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct BGNPCOPLKAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[GHGPPNIDBEA(0, 9)]
public enum NILIGAKBOAA
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
public static class AAHEDCAENJO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6830CA0", Offset = "0x68300A0", VA = "0x186830CA0")]
	public static bool FKNDIMNEJFH(this NILIGAKBOAA FPMOMLONBEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[GHGPPNIDBEA(-1, 38)]
public enum DJOJBOPMMAC
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
[HIEFLIGLDHA]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[HFDGEEOOBCM(15725208981563603541uL, 17017036095303668770uL)]
public struct LDPEKMBFPGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[KCNAOLEHLIG(1)]
	public IMPAOGMALJN JBGKOICMKNG;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct PGKHOPAKMIE : IComponentData, IComparable<PGKHOPAKMIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int DBJKJGABAIG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA598D0", Offset = "0xA58CD0", VA = "0x180A598D0", Slot = "4")]
	public int CompareTo(PGKHOPAKMIE ICELKIGIKKP)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct LFKJHHMKPGF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[HIEFLIGLDHA]
[HFDGEEOOBCM(12226092714547765037uL, 15970362445488810630uL)]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct JFJAAJOMDDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[KCNAOLEHLIG(2)]
	public JCGNABNJLAL DAPHPHIBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[HNONLGLFLKI(0)]
	[KCNAOLEHLIG(3)]
	public JAGLKDCKPOP FBHEDDKIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[IHIPOJOKOIJ(4)]
	public PLFLDLIKPGM BLBMFDIEDCO;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static readonly LMDMHELMEME<JFJAAJOMDDN> KCIIGNIKLNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct HKJHDNBNFCI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[GHGPPNIDBEA(0, 2)]
public enum MEFJBIKHGAA
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
[GHGPPNIDBEA(0, 1)]
public enum BAINPBEIELK
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
internal struct JOCPLMMPLEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct HLAJPNICCFA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct ENDJAOGKOIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[KCNAOLEHLIG(1)]
	public EEICHPGJODP NFENHBLMAKH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static ENDJAOGKOIP LFFBPOODCDC(EEICHPGJODP AGLCIEKHLEE)
	{
		return default(ENDJAOGKOIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[ILHNOICDLPN("Container", 0)]
public struct APLGOFHMJJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[KCNAOLEHLIG(1)]
	[HNONLGLFLKI(0)]
	public FixedString64Bytes GDKOBCHHFLB;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class NGBGCOJJOLG
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6837A90", Offset = "0x6836E90", VA = "0x186837A90")]
	public static void AFLFAPDAOKF(this ref PLFLDLIKPGM BLBMFDIEDCO, DEGFEGGODAD MGBAMDAPEDI, bool MOLHIOPHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6837AC0", Offset = "0x6836EC0", VA = "0x186837AC0")]
	public static bool KFIAKGAPHCC(this PLFLDLIKPGM BLBMFDIEDCO, DEGFEGGODAD MGBAMDAPEDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6837AE0", Offset = "0x6836EE0", VA = "0x186837AE0")]
	public static PLFLDLIKPGM PHIKLPGJBKI(this DEGFEGGODAD MGBAMDAPEDI)
	{
		return default(PLFLDLIKPGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6837A70", Offset = "0x6836E70", VA = "0x186837A70")]
	public static void AFLFAPDAOKF(this ref JAGLKDCKPOP BLBMFDIEDCO, JAGLKDCKPOP BEAPEKCODAF, bool MOLHIOPHPBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public enum DEGFEGGODAD
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
[GHGPPNIDBEA(0, 16383)]
public enum PLFLDLIKPGM
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
[GHGPPNIDBEA(0, 3)]
public enum JAGLKDCKPOP
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
[POANHKIBECD]
[GHGPPNIDBEA(0, 4)]
public enum BCPJINOKPFK
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
public class POANHKIBECD : OKLEMMDOGED
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6838A60", Offset = "0x6837E60", VA = "0x186838A60", Slot = "7")]
	public override string EGDPOBLMKNF(string HIMOPIMKOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public POANHKIBECD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[HIEFLIGLDHA]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[HFDGEEOOBCM(17667479821163689808uL, 11946378475791123970uL)]
public struct CNMPOKOKCIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct ABMEGOFJLOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[HIEFLIGLDHA]
[HFDGEEOOBCM(1029043735688538310uL, 14256247939851101839uL)]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
public struct MCJBHLADOCK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public NILIGAKBOAA FPMOMLONBEI;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[GHGPPNIDBEA(int.MinValue, int.MaxValue)]
public enum CDPEKNFNMNM
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
[JFGLPCLMEGA]
[ILHNOICDLPN("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct GODMHMOAEJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[HNONLGLFLKI(0)]
	[KCNAOLEHLIG(1)]
	public bool OMIGIJBCKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[KCNAOLEHLIG(2)]
	[HNONLGLFLKI(0)]
	public float NKPEEOAHLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[HNONLGLFLKI(0)]
	[KCNAOLEHLIG(3)]
	public float KBMIFPNEOLH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct LIGGBCNLILA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[ILHNOICDLPN("Container", 0)]
public struct BFKHBOFEEPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[HNONLGLFLKI(0)]
	[KCNAOLEHLIG(1)]
	public float HEFLELEADFE;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct AOOJDPMKIIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private NativeList<GOJJIKKHBCG> LEIIMBCJOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeList<Entity> JBIGCBJOGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private JobHandle PDLPHPDOMPP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NDGDBIMBJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6831700", Offset = "0x6830B00", VA = "0x186831700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68316B0", Offset = "0x6830AB0", VA = "0x1868316B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x292D4F0", Offset = "0x292C8F0", VA = "0x18292D4F0")]
	public AOOJDPMKIIA(NativeList<GOJJIKKHBCG> LEIIMBCJOOL, NativeList<Entity> JBIGCBJOGEN, JobHandle PDLPHPDOMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6831500", Offset = "0x6830900", VA = "0x186831500")]
	public (Entity, NativeSlice<Entity>) AEHJJMLJJAA(int APEMPONKPBB)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6831650", Offset = "0x6830A50", VA = "0x186831650", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct AIMKNIFBJLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public float3 FGLOAKJBDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public quaternion OCEJJKMFIJB;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static readonly LMDMHELMEME<AIMKNIFBJLG> KCIIGNIKLNC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6830F40", Offset = "0x6830340", VA = "0x186830F40")]
	public float3 LEFHKIHKLAC(float3 EDCHAMDBOGG)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class MILKILLFNMA
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[HIEFLIGLDHA]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[HFDGEEOOBCM(218523523639012570uL, 15191719635551116065uL)]
public struct LBKHDDGKDOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private uint HOJPJLLPDJD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct LNFKIFAJNMB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[JFGLPCLMEGA]
[ILHNOICDLPN("Light", 0)]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
public struct GMDBFDEKJIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[KCNAOLEHLIG(1)]
	[HNONLGLFLKI(0)]
	public float ECLOLLCHPPM;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct KKNJLGBFGAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[KCNAOLEHLIG(1)]
	public quaternion IKMDCPAAKBK;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static readonly LMDMHELMEME<KKNJLGBFGAJ> KCIIGNIKLNC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0")]
	public static KKNJLGBFGAJ LFFBPOODCDC(quaternion AGLCIEKHLEE)
	{
		return default(KKNJLGBFGAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct JFJDKPCHDJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[KCNAOLEHLIG(1)]
	public Entity JNHEGOFDJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[KCNAOLEHLIG(2)]
	public bool PPOEOMECDGB;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct KFPHMNCPJAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public FixedString32Bytes GDKOBCHHFLB;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[HIEFLIGLDHA]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[HFDGEEOOBCM(4470189027631723570uL, 5922380073816386711uL)]
public struct NEKAOFOHDGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[IHIPOJOKOIJ(1)]
	public PLFLDLIKPGM BLBMFDIEDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[KCNAOLEHLIG(2)]
	public JCGNABNJLAL DAPHPHIBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[KCNAOLEHLIG(3)]
	[HNONLGLFLKI(0)]
	public JAGLKDCKPOP FBHEDDKIAKO;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly LMDMHELMEME<NEKAOFOHDGA> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct NDOFDMPLNDB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public Entity JFCBKPIOALE;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
[GHGPPNIDBEA(0, 1)]
public enum BJFGHKIIBEA
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
public struct AIAFGHHIMIC : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[BDAHAFGFILL(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[IHIPOJOKOIJ(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[IHIPOJOKOIJ(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[IHIPOJOKOIJ(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[IHIPOJOKOIJ(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BDAHAFGFILL(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, AKHJKCAIBOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[IHIPOJOKOIJ(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0")]
		public static SerializableGuid LFFBPOODCDC(Guid DDJMKPCJBFO)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6839A30", Offset = "0x6838E30", VA = "0x186839A30", Slot = "4")]
		public bool Equals(SerializableGuid ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6839990", Offset = "0x6838D90", VA = "0x186839990", Slot = "5")]
		public int CompareTo(SerializableGuid ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68398A0", Offset = "0x6838CA0", VA = "0x1868398A0", Slot = "6")]
		public void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68399B0", Offset = "0x6838DB0", VA = "0x1868399B0", Slot = "7")]
		public void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6839AC0", Offset = "0x6838EC0", VA = "0x186839AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct AKBGFAFMEJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct AOGFIBDDDIC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[GHGPPNIDBEA(0, 4)]
public enum LLEALHDNAML
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
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct KHDGMDDCJCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[KCNAOLEHLIG(1)]
	public bool LJMOJNCFEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[KCNAOLEHLIG(2)]
	public byte CBICPPGLEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[KCNAOLEHLIG(3)]
	public short MJAMKEMHANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[KCNAOLEHLIG(4)]
	public ushort EIONEPCIHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[KCNAOLEHLIG(5)]
	public int IJOMBLHPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[KCNAOLEHLIG(6)]
	public uint FKLGKNHDODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[KCNAOLEHLIG(7)]
	public long AMIHLPNFKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[KCNAOLEHLIG(8)]
	public ulong PCDCFMHPHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[KCNAOLEHLIG(9)]
	public float CHDLJOCKEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[KCNAOLEHLIG(10)]
	public double IHIFMJDEHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[KCNAOLEHLIG(11)]
	public KACNCJIOGPH LGKHEPFGKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[KCNAOLEHLIG(12)]
	public KCJOMMDHHDN GOOFHJBIKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[KCNAOLEHLIG(13)]
	public NOGNNCENONC EOMJOPBKBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[KCNAOLEHLIG(14)]
	public AMNFOPKOAGH BLDLPPBBOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[KCNAOLEHLIG(15)]
	public DCJIJDPGGEF IDBECGGDGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[KCNAOLEHLIG(16)]
	public DPLBKAOOHJO PONCBFMGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[KCNAOLEHLIG(17)]
	public IJHLHCFMMGM ALBNLJDBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[KCNAOLEHLIG(18)]
	public OPMKOEIHKPL EBEBJHEBBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[KCNAOLEHLIG(20)]
	public Quaternion PLFFHAMOKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[KCNAOLEHLIG(22)]
	public Vector3 FDADJNCEACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[KCNAOLEHLIG(23)]
	public Vector4 KJDBILGILMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[KCNAOLEHLIG(40)]
	public Entity LABINHHILJA;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum KACNCJIOGPH : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum KCJOMMDHHDN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum NOGNNCENONC : short
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum AMNFOPKOAGH : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum DCJIJDPGGEF
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public enum DPLBKAOOHJO : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public enum IJHLHCFMMGM : long
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum OPMKOEIHKPL : ulong
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
	[JFGLPCLMEGA]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[JFGLPCLMEGA]
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
public class JCIMAMOBEKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public int DCBJJADOEJL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int ICFNFCHJAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public GameObject NNAKJIJAOJG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public JCIMAMOBEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class EELKMIABKIM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public struct MIMDFLIGBPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector3 IJAKDAPNHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public List<SerializableGuid> DMCJJAKCLPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ILNCPLKCPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MIMDFLIGBPH AKCMKBGJCFP;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ILNCPLKCPOL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public SerializableGuid NIGFCPFJHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public List<int> ODCBELPGCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public List<MIMDFLIGBPH> JCLJJBHPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public List<ILNCPLKCPOL> JKIIDIGHEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public GameObject NNAKJIJAOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Light HDJLPNABGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Collider MPDBOOOIMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public string LOPOADNCJIG;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EELKMIABKIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[HIEFLIGLDHA]
[ILHNOICDLPN("Container", 0)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[HFDGEEOOBCM(2613756846563002039uL, 6372660366488563574uL)]
public struct JBNFHJKINBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[KCNAOLEHLIG(1)]
	[HNONLGLFLKI(0)]
	public IJMMOFNBOEI GOBIEAPLKNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[Flags]
[GHGPPNIDBEA(0, 15)]
public enum IJMMOFNBOEI
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
[HIEFLIGLDHA]
[HFDGEEOOBCM(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct ODALONFHOFF : IComponentData, IEquatable<ODALONFHOFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[KCNAOLEHLIG(1)]
	public FixedString64Bytes GDKOBCHHFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	[KCNAOLEHLIG(2)]
	public EHCJCADIMGK ECFHAHDOLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[KCNAOLEHLIG(3)]
	public IJMMOFNBOEI GOBIEAPLKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[KCNAOLEHLIG(4)]
	public BOBHEBMPHOB DEMGLLKMBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[KCNAOLEHLIG(5)]
	public CAIENIPDHPC BLBMFDIEDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	[KCNAOLEHLIG(6)]
	public float HEFLELEADFE;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6837DD0", Offset = "0x68371D0", VA = "0x186837DD0", Slot = "4")]
	public bool Equals(ODALONFHOFF ICELKIGIKKP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct MDAIHPGAOBN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct KACENJHHHOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	[KCNAOLEHLIG(1)]
	public MGFBLKCEIKC NPOLKGPPPJC;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct JFMBCHEMIHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	[KCNAOLEHLIG(1)]
	public float3 IEGBDEAOAGE;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly LMDMHELMEME<JFMBCHEMIHN> KCIIGNIKLNC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
	public static JFMBCHEMIHN LFFBPOODCDC(float3 AGLCIEKHLEE)
	{
		return default(JFMBCHEMIHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct JJKAHCIIMPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public Entity JFCBKPIOALE;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[InternalBufferCapacity(8)]
public struct PHKJDNACMEE : ISystemStateBufferElementData, IBufferElementData, IEquatable<PHKJDNACMEE>, LILBGEFEHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public Entity KEGFIDMGBNO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity CMBBKNEMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6837960", Offset = "0x6836D60", VA = "0x186837960", Slot = "4")]
	public bool Equals(PHKJDNACMEE ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct GOFDHIDALFI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public Entity EFDPMAIOLJO;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[GHGPPNIDBEA(0, 4)]
public enum HMPGJEKMJBE
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
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct OKLGNNPGBAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	[KCNAOLEHLIG(1)]
	public quaternion IKMDCPAAKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	[KCNAOLEHLIG(2)]
	public float3 IEGBDEAOAGE;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static readonly LMDMHELMEME<OKLGNNPGBAD> KCIIGNIKLNC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x176B4D0", Offset = "0x176A8D0", VA = "0x18176B4D0")]
	public OKLGNNPGBAD(quaternion IKMDCPAAKBK, float3 IEGBDEAOAGE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6838830", Offset = "0x6837C30", VA = "0x186838830")]
	public static RigidTransform LFFBPOODCDC(OKLGNNPGBAD FNFCBOAICAN)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6838830", Offset = "0x6837C30", VA = "0x186838830")]
	public static OKLGNNPGBAD LFFBPOODCDC(RigidTransform IGFAAHIBKML)
	{
		return default(OKLGNNPGBAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class JKGKENHENLC
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface LILBGEFEHNB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity JFBIKPNIMAI
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
[HIEFLIGLDHA]
[HFDGEEOOBCM(9807788745867066359uL, 15168486114979071194uL)]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct JJDHCPGNCCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	[KCNAOLEHLIG(1)]
	public PLFLDLIKPGM BLBMFDIEDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	[KCNAOLEHLIG(2)]
	public JCGNABNJLAL DAPHPHIBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	[KCNAOLEHLIG(3)]
	[HNONLGLFLKI(0)]
	public bool LOONFBPEOKM;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static readonly LMDMHELMEME<JJDHCPGNCCG> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[JFGLPCLMEGA]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
public struct HNFKHNCLACN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	[KCNAOLEHLIG(2)]
	public bool DEAPJDNEFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	[KCNAOLEHLIG(3)]
	public bool IIAKNJEBEGP;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly LMDMHELMEME<HNFKHNCLACN> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[TypeManager.TypeVersion(3)]
[ILHNOICDLPN("Object", 0)]
public struct AEINALOEIKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	[KCNAOLEHLIG(2)]
	public JCGNABNJLAL DAPHPHIBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	[KCNAOLEHLIG(3)]
	[HNONLGLFLKI(0)]
	public JAGLKDCKPOP FBHEDDKIAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	[HNONLGLFLKI(0)]
	[KCNAOLEHLIG(5)]
	public BCPJINOKPFK PEPHLLLJFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	[IHIPOJOKOIJ(4)]
	public PLFLDLIKPGM BLBMFDIEDCO;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly LMDMHELMEME<AEINALOEIKO> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct DCOFGBOLKBH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public int GAAPLDCPBBH;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct KADDJKKFLEM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public GCHandle JHACAIOGIKJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct HAJLKENCNBI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private int LHPJGCKIOAM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BNOAGGNAMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6835AE0", Offset = "0x6834EE0", VA = "0x186835AE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6835AF0", Offset = "0x6834EF0", VA = "0x186835AF0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct EKGDMHOJIOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	[KCNAOLEHLIG(1)]
	public Entity NIEKBNLNEJE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static EKGDMHOJIOG LFFBPOODCDC(Entity GKMECPLEALF)
	{
		return default(EKGDMHOJIOG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[HIEFLIGLDHA]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[HFDGEEOOBCM(14327281633525910712uL, 2559857777606771911uL)]
public struct PILBPMBIBMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	[KCNAOLEHLIG(1)]
	public IMPAOGMALJN JBGKOICMKNG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct HEOMHGIBEHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct HAGJKHAGDIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[KCNAOLEHLIG(1)]
	public float3 INOKFMOGILM;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static readonly LMDMHELMEME<HAGJKHAGDIE> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[JFGLPCLMEGA]
[ILHNOICDLPN("Container", 0)]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
public struct EPPEJAEPNLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[KCNAOLEHLIG(1)]
	[HNONLGLFLKI(0)]
	public BOBHEBMPHOB DEMGLLKMBKE;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[GHGPPNIDBEA(0, 1)]
public enum BOBHEBMPHOB
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
[BDAHAFGFILL(1)]
public struct JCGNABNJLAL : AKHJKCAIBOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[IHIPOJOKOIJ(1)]
	public bool OMIGIJBCKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[IHIPOJOKOIJ(2)]
	public float3 FLKBMMFNHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[IHIPOJOKOIJ(3)]
	public float3 HCGGJIINGLD;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public static readonly LMDMHELMEME<JCGNABNJLAL> KCIIGNIKLNC;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68364F0", Offset = "0x68358F0", VA = "0x1868364F0", Slot = "5")]
	public void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68364A0", Offset = "0x68358A0", VA = "0x1868364A0", Slot = "4")]
	public void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct AAPPBDIJGNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[KCNAOLEHLIG(1)]
	public DJOJBOPMMAC GDBONNHGFGN;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct PMCOFEHKGHL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public int GAAPLDCPBBH;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface MKGELIIKCMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEDPEJKHGBN(bool HMIFEGBEHGK);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.TypeVersion(2)]
public struct CCNJGHCPMLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public uint IFGGGLBCIJI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6831E80", Offset = "0x6831280", VA = "0x186831E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct IEGCEIIBBNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct KKGHANBBIGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct CBIMOOALJBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[AIPCDKCBABC]
internal struct CJGIDBLNKDB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public Entity HOCJOMLKNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public int BNOAGGNAMKG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct MMNCNJEDPEA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[ILHNOICDLPN("Visual", 0)]
public struct NMKHBFBBOGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[KCNAOLEHLIG(1)]
	[HNONLGLFLKI(0)]
	public CDPEKNFNMNM DEJOCIOKOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	[HNONLGLFLKI(0)]
	[KCNAOLEHLIG(2)]
	public NLEMDAHFKEP NKAMKIHOODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	[KCNAOLEHLIG(3)]
	[HNONLGLFLKI(0)]
	public float MLEBAKNKHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	[KCNAOLEHLIG(4)]
	[HNONLGLFLKI(0)]
	public Vector3 HKIHJOANCCH;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[JFGLPCLMEGA]
[ILHNOICDLPN("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct MFFCMBGAGGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	[KCNAOLEHLIG(1)]
	[HNONLGLFLKI(0)]
	public float KCBAGJILBKC;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly LMDMHELMEME<MFFCMBGAGGG> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BDAHAFGFILL(1)]
public struct EEICHPGJODP : IComparable<EEICHPGJODP>, IEquatable<EEICHPGJODP>, AKHJKCAIBOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	[IHIPOJOKOIJ(1)]
	public uint NNJGPDNFLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	[IHIPOJOKOIJ(2)]
	public uint JFCDBKCEKMP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint EAAOOHBEKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6835010", Offset = "0x6834410", VA = "0x186835010")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6835130", Offset = "0x6834530", VA = "0x186835130")]
	public EEICHPGJODP(int NNJGPDNFLDN, int FFMFHAFLEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6835130", Offset = "0x6834530", VA = "0x186835130")]
	public EEICHPGJODP(uint NNJGPDNFLDN, uint FFMFHAFLEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6834FB0", Offset = "0x68343B0", VA = "0x186834FB0")]
	public EEICHPGJODP IEKMFDHKJFL(int AEHKIMOEIJL = 1)
	{
		return default(EEICHPGJODP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6834CC0", Offset = "0x68340C0", VA = "0x186834CC0")]
	public EEICHPGJODP BIINPCCHACI(int AEHKIMOEIJL = 1)
	{
		return default(EEICHPGJODP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6834F30", Offset = "0x6834330", VA = "0x186834F30")]
	public static EEICHPGJODP IABGIJEAGFO(EEICHPGJODP FINJCDHFPJB, EEICHPGJODP JHJGODIMNAF)
	{
		return default(EEICHPGJODP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6835020", Offset = "0x6834420", VA = "0x186835020")]
	private static uint OICLGPPBEEE(uint NPBBJPKPNCJ, uint KBAEKPMBMFG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6834D90", Offset = "0x6834190", VA = "0x186834D90", Slot = "4")]
	public int CompareTo(EEICHPGJODP ICELKIGIKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6834E20", Offset = "0x6834220", VA = "0x186834E20", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6835050", Offset = "0x6834450", VA = "0x186835050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6834EC0", Offset = "0x68342C0", VA = "0x186834EC0", Slot = "5")]
	public bool Equals(EEICHPGJODP ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6834EE0", Offset = "0x68342E0", VA = "0x186834EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6834D20", Offset = "0x6834120", VA = "0x186834D20", Slot = "6")]
	public void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6834DB0", Offset = "0x68341B0", VA = "0x186834DB0", Slot = "7")]
	public void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x16D1190", Offset = "0x16D0590", VA = "0x1816D1190")]
	public static bool PHJEMBLBEDF(EEICHPGJODP FINJCDHFPJB, EEICHPGJODP JHJGODIMNAF)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[JFGLPCLMEGA]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public IMPAOGMALJN prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class CKOGIKLCPCB
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6832160", Offset = "0x6831560", VA = "0x186832160")]
	public static bool OKIGMPOMPBL(this IMPAOGMALJN GANFKPHKNKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x68320E0", Offset = "0x68314E0", VA = "0x1868320E0")]
	public static string MBEILLCINFF(this IMPAOGMALJN GANFKPHKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x68320C0", Offset = "0x68314C0", VA = "0x1868320C0")]
	public static NILIGAKBOAA BOPDAANMFBE(this IMPAOGMALJN JBGKOICMKNG)
	{
		return default(NILIGAKBOAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x68320B0", Offset = "0x68314B0", VA = "0x1868320B0")]
	internal static MIACLOCLIHO BMAALLGADFB(this NILIGAKBOAA FPMOMLONBEI)
	{
		return default(MIACLOCLIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6832090", Offset = "0x6831490", VA = "0x186832090")]
	internal static MIACLOCLIHO BMAALLGADFB(this IMPAOGMALJN JBGKOICMKNG)
	{
		return default(MIACLOCLIHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class ODKNKEAGDPJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly Dictionary<IMPAOGMALJN, string> DCMNAEMNFAM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6837F60", Offset = "0x6837360", VA = "0x186837F60")]
	public static string LPMNNDNJBPB(this IMPAOGMALJN GANFKPHKNKH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct KECHJIMMDEC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[HIEFLIGLDHA]
[HFDGEEOOBCM(9898405628982320166uL, 2023375009558162791uL)]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
public struct FOINBIBPFDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[KCNAOLEHLIG(1)]
	public PLFLDLIKPGM BLBMFDIEDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	[KCNAOLEHLIG(2)]
	public JCGNABNJLAL DAPHPHIBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	[KCNAOLEHLIG(3)]
	[HNONLGLFLKI(0)]
	public bool LOONFBPEOKM;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly LMDMHELMEME<FOINBIBPFDI> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct CJOLMMLIEMF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public Entity ENHADNJFECO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static CJOLMMLIEMF LFFBPOODCDC(Entity GKMECPLEALF)
	{
		return default(CJOLMMLIEMF);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[JFGLPCLMEGA]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[IHIPOJOKOIJ(1)]
		public uint networkIdBits;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct KMPNMOFFIOP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct LAEGLBOPBMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public float3 GLOHAKILNKC;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly LMDMHELMEME<LAEGLBOPBMJ> KCIIGNIKLNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct IFAOFKNMFKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[ILHNOICDLPN("Container", 0)]
public struct AOILHOBPGBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[HNONLGLFLKI(0)]
	[KCNAOLEHLIG(1)]
	public HCMODPLKBON ADBMAPOIAEC;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly LMDMHELMEME<AOILHOBPGBG> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[GHGPPNIDBEA(0, 127)]
public enum HCMODPLKBON
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
public static class EPHJGBIPGDB
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public enum HJJIEKMCFLL
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
	public enum KFECEPLNHJG
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
	[Cpp2IlInjected.Address(RVA = "0x68354D0", Offset = "0x68348D0", VA = "0x1868354D0")]
	public static (HJJIEKMCFLL, KFECEPLNHJG) HHELEFIPNFG(this HCMODPLKBON CJBPODGOGEE)
	{
		return default((HJJIEKMCFLL, KFECEPLNHJG));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct GOJJIKKHBCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Entity AOCBEEBNJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public int AEHKIMOEIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public int HBBGBOONHJE;
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
public struct EODNMPFLBLP : IComponentData, LILBGEFEHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	[KCNAOLEHLIG(1)]
	public Entity OJBGDMNECON;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity CMBBKNEMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10")]
	public EODNMPFLBLP(Entity OJBGDMNECON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static EODNMPFLBLP LFFBPOODCDC(Entity GKMECPLEALF)
	{
		return default(EODNMPFLBLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct LMCCJLJHFEM : ISystemStateComponentData, IComponentData, LILBGEFEHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Entity LPAAFNPINOB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity CMBBKNEMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10")]
	public LMCCJLJHFEM(Entity OJBGDMNECON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static LMCCJLJHFEM LFFBPOODCDC(Entity GKMECPLEALF)
	{
		return default(LMCCJLJHFEM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct HJPPACGEKOP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[GHGPPNIDBEA(1000, 8000)]
public enum IMPAOGMALJN
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
public static class PNMEINKGNKJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct CLFDOHHJIOA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[GHGPPNIDBEA(-2, 2)]
public enum ECAGGHEHEOG
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
public struct HIJGOCMGIOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct KLNPDGMJJML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public uint LPBGHNMJOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public int ODEHAJLJHPC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
	public KLNPDGMJJML(uint BJPPJOGKAEG, int PGPFNOMJMHO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct ILMNACFNHNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[GHGPPNIDBEA(-1, 31)]
public enum NLEMDAHFKEP
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
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct FLBFLPBHMEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[KCNAOLEHLIG(1)]
	public LDPBHDEACKL FHHAMKDPPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public GCHandle IILNPDLGJIK;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct LEIMONNOBFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public float4x4 KANIJOBCBKN;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly LMDMHELMEME<LEIMONNOBFD> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
public struct MJNEFILJOEE : IComponentData, LILBGEFEHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[KCNAOLEHLIG(1)]
	public Entity OJBGDMNECON;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Entity CMBBKNEMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10")]
	public MJNEFILJOEE(Entity OJBGDMNECON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static MJNEFILJOEE LFFBPOODCDC(Entity GKMECPLEALF)
	{
		return default(MJNEFILJOEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6837700", Offset = "0x6836B00", VA = "0x186837700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct EJNBEFLGKCF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[AIPCDKCBABC]
public struct AEBKFDGLLKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public Entity PJOBCGNOOBP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static AEBKFDGLLKH LFFBPOODCDC(Entity AGLCIEKHLEE)
	{
		return default(AEBKFDGLLKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct FOJHDGPKKHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[KCNAOLEHLIG(1)]
	public BJFGHKIIBEA JNIJBIAPFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[KCNAOLEHLIG(2)]
	public ECAGGHEHEOG KNBIIEAAFOM;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct JMCABOIGFEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[KCNAOLEHLIG(1)]
	public bool GCNKNLGIDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[KCNAOLEHLIG(2)]
	public bool MJGLAAJCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[KCNAOLEHLIG(3)]
	public float EMKLNGDPLLA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct NACBJGKILAP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct JCPMHPFBGMJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct OHBGCALBLDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[KCNAOLEHLIG(1)]
	public quaternion IKMDCPAAKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[KCNAOLEHLIG(2)]
	public float3 IEGBDEAOAGE;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly LMDMHELMEME<OHBGCALBLDC> KCIIGNIKLNC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x176B4D0", Offset = "0x176A8D0", VA = "0x18176B4D0")]
	public OHBGCALBLDC(quaternion IKMDCPAAKBK, float3 IEGBDEAOAGE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6838830", Offset = "0x6837C30", VA = "0x186838830")]
	public static OHBGCALBLDC LFFBPOODCDC(RigidTransform IGFAAHIBKML)
	{
		return default(OHBGCALBLDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class GCMMOHJHLGL
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[JFGLPCLMEGA]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct NBLHFDJJAAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[KCNAOLEHLIG(1)]
	public MEFJBIKHGAA GDBONNHGFGN;
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : NBHAMHKLBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6839AD0", Offset = "0x6838ED0", VA = "0x186839AD0", Slot = "4")]
		public sealed override void ALPFLNNIPAO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal class AJFKLMCIMNB : ContainerPropertyBag<NMONOCINAHL>
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private class AKMIHBLMPKO : Property<NMONOCINAHL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6831300", Offset = "0x6830700", VA = "0x186831300", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x68312C0", Offset = "0x68306C0", VA = "0x1868312C0")]
		public AKMIHBLMPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x27B1590", Offset = "0x27B0990", VA = "0x1827B1590", Slot = "14")]
		public override Rigidbody GetValue(ref NMONOCINAHL DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x27B15B0", Offset = "0x27B09B0", VA = "0x1827B15B0", Slot = "15")]
		public override void SetValue(ref NMONOCINAHL DOJDGHDKCLO, Rigidbody AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x68311F0", Offset = "0x68305F0", VA = "0x1868311F0")]
	public AJFKLMCIMNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class GIPIPKBAHCK : ContainerPropertyBag<EIEHOBLCIBF>
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class CPLOKDPCKDF : Property<EIEHOBLCIBF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6832260", Offset = "0x6831660", VA = "0x186832260", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6832220", Offset = "0x6831620", VA = "0x186832220")]
		public CPLOKDPCKDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x27B1590", Offset = "0x27B0990", VA = "0x1827B1590", Slot = "14")]
		public override object GetValue(ref EIEHOBLCIBF DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x27B15B0", Offset = "0x27B09B0", VA = "0x1827B15B0", Slot = "15")]
		public override void SetValue(ref EIEHOBLCIBF DOJDGHDKCLO, object AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x68358E0", Offset = "0x6834CE0", VA = "0x1868358E0")]
	public GIPIPKBAHCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal class MKCPFCEIGNH : ContainerPropertyBag<KGCLIDEHBDE>
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class BJKHDBNAJLI : Property<KGCLIDEHBDE, COBFMFPIDNL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6831D90", Offset = "0x6831190", VA = "0x186831D90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6831D50", Offset = "0x6831150", VA = "0x186831D50")]
		public BJKHDBNAJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x27B1590", Offset = "0x27B0990", VA = "0x1827B1590", Slot = "14")]
		public override COBFMFPIDNL GetValue(ref KGCLIDEHBDE DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x27B15B0", Offset = "0x27B09B0", VA = "0x1827B15B0", Slot = "15")]
		public override void SetValue(ref KGCLIDEHBDE DOJDGHDKCLO, COBFMFPIDNL AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6837710", Offset = "0x6836B10", VA = "0x186837710")]
	public MKCPFCEIGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class EHNELINDOFC : ContainerPropertyBag<OAECBANIOKB>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class KGCENLDBFOI : Property<OAECBANIOKB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6836C20", Offset = "0x6836020", VA = "0x186836C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6836BE0", Offset = "0x6835FE0", VA = "0x186836BE0")]
		public KGCENLDBFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x27B1590", Offset = "0x27B0990", VA = "0x1827B1590", Slot = "14")]
		public override object GetValue(ref OAECBANIOKB DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x27B15B0", Offset = "0x27B09B0", VA = "0x1827B15B0", Slot = "15")]
		public override void SetValue(ref OAECBANIOKB DOJDGHDKCLO, object AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x68352D0", Offset = "0x68346D0", VA = "0x1868352D0")]
	public EHNELINDOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class AIHHIBFFODF : ContainerPropertyBag<JCIMAMOBEKP>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class JONJIJJPLGI : Property<JCIMAMOBEKP, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6836A90", Offset = "0x6835E90", VA = "0x186836A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6836A50", Offset = "0x6835E50", VA = "0x186836A50")]
		public JONJIJJPLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4446CB0", Offset = "0x44460B0", VA = "0x184446CB0", Slot = "14")]
		public override int GetValue(ref JCIMAMOBEKP DOJDGHDKCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6836A30", Offset = "0x6835E30", VA = "0x186836A30", Slot = "15")]
		public override void SetValue(ref JCIMAMOBEKP DOJDGHDKCLO, int AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	private class BAJLFAFIPLM : Property<JCIMAMOBEKP, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x68318A0", Offset = "0x6830CA0", VA = "0x1868318A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6831860", Offset = "0x6830C60", VA = "0x186831860")]
		public BAJLFAFIPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4446D40", Offset = "0x4446140", VA = "0x184446D40", Slot = "14")]
		public override int GetValue(ref JCIMAMOBEKP DOJDGHDKCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6831840", Offset = "0x6830C40", VA = "0x186831840", Slot = "15")]
		public override void SetValue(ref JCIMAMOBEKP DOJDGHDKCLO, int AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class DAJOAFNCNCG : Property<JCIMAMOBEKP, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x68323E0", Offset = "0x68317E0", VA = "0x1868323E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x68323A0", Offset = "0x68317A0", VA = "0x1868323A0")]
		public DAJOAFNCNCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6832350", Offset = "0x6831750", VA = "0x186832350", Slot = "14")]
		public override GameObject GetValue(ref JCIMAMOBEKP DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6832370", Offset = "0x6831770", VA = "0x186832370", Slot = "15")]
		public override void SetValue(ref JCIMAMOBEKP DOJDGHDKCLO, GameObject AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6830DB0", Offset = "0x68301B0", VA = "0x186830DB0")]
	public AIHHIBFFODF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class JBCFEICKPDH : ContainerPropertyBag<EELKMIABKIM>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class BKFCAJJFCFE : Property<EELKMIABKIM, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6831E50", Offset = "0x6831250", VA = "0x186831E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6831E10", Offset = "0x6831210", VA = "0x186831E10")]
		public BKFCAJJFCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6831DC0", Offset = "0x68311C0", VA = "0x186831DC0", Slot = "14")]
		public override SerializableGuid GetValue(ref EELKMIABKIM DOJDGHDKCLO)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6831DF0", Offset = "0x68311F0", VA = "0x186831DF0", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM DOJDGHDKCLO, SerializableGuid AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class CPMJPEPBJAL : Property<EELKMIABKIM, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6832320", Offset = "0x6831720", VA = "0x186832320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x68322E0", Offset = "0x68316E0", VA = "0x1868322E0")]
		public CPMJPEPBJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6832290", Offset = "0x6831690", VA = "0x186832290", Slot = "14")]
		public override List<int> GetValue(ref EELKMIABKIM DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68322B0", Offset = "0x68316B0", VA = "0x1868322B0", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM DOJDGHDKCLO, List<int> AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private class DEKKKIKHMCN : Property<EELKMIABKIM, List<EELKMIABKIM.MIMDFLIGBPH>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x68325F0", Offset = "0x68319F0", VA = "0x1868325F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x68325B0", Offset = "0x68319B0", VA = "0x1868325B0")]
		public DEKKKIKHMCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6832560", Offset = "0x6831960", VA = "0x186832560", Slot = "14")]
		public override List<EELKMIABKIM.MIMDFLIGBPH> GetValue(ref EELKMIABKIM DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6832580", Offset = "0x6831980", VA = "0x186832580", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM DOJDGHDKCLO, List<EELKMIABKIM.MIMDFLIGBPH> AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class HANNPKKDCGL : Property<EELKMIABKIM, List<EELKMIABKIM.ILNCPLKCPOL>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6835B90", Offset = "0x6834F90", VA = "0x186835B90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6835B50", Offset = "0x6834F50", VA = "0x186835B50")]
		public HANNPKKDCGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6835B00", Offset = "0x6834F00", VA = "0x186835B00", Slot = "14")]
		public override List<EELKMIABKIM.ILNCPLKCPOL> GetValue(ref EELKMIABKIM DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6835B20", Offset = "0x6834F20", VA = "0x186835B20", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM DOJDGHDKCLO, List<EELKMIABKIM.ILNCPLKCPOL> AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class JCBGKKHMKDF : Property<EELKMIABKIM, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6836470", Offset = "0x6835870", VA = "0x186836470", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6836430", Offset = "0x6835830", VA = "0x186836430")]
		public JCBGKKHMKDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x68363E0", Offset = "0x68357E0", VA = "0x1868363E0", Slot = "14")]
		public override GameObject GetValue(ref EELKMIABKIM DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6836400", Offset = "0x6835800", VA = "0x186836400", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM DOJDGHDKCLO, GameObject AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class PICNIIMFDMG : Property<EELKMIABKIM, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6838A30", Offset = "0x6837E30", VA = "0x186838A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68389F0", Offset = "0x6837DF0", VA = "0x1868389F0")]
		public PICNIIMFDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x68389A0", Offset = "0x6837DA0", VA = "0x1868389A0", Slot = "14")]
		public override Light GetValue(ref EELKMIABKIM DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x68389C0", Offset = "0x6837DC0", VA = "0x1868389C0", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM DOJDGHDKCLO, Light AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class GOGFNAPADAJ : Property<EELKMIABKIM, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x6835A40", Offset = "0x6834E40", VA = "0x186835A40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6835A00", Offset = "0x6834E00", VA = "0x186835A00")]
		public GOGFNAPADAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x68359B0", Offset = "0x6834DB0", VA = "0x1868359B0", Slot = "14")]
		public override Collider GetValue(ref EELKMIABKIM DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x68359D0", Offset = "0x6834DD0", VA = "0x1868359D0", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM DOJDGHDKCLO, Collider AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class MJMDFNDELCK : Property<EELKMIABKIM, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x68376D0", Offset = "0x6836AD0", VA = "0x1868376D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6837690", Offset = "0x6836A90", VA = "0x186837690")]
		public MJMDFNDELCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6837640", Offset = "0x6836A40", VA = "0x186837640", Slot = "14")]
		public override string GetValue(ref EELKMIABKIM DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6837660", Offset = "0x6836A60", VA = "0x186837660", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM DOJDGHDKCLO, string AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6836000", Offset = "0x6835400", VA = "0x186836000")]
	public JBCFEICKPDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class FJKPGAPKFPD : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class MNLMGOPEGNJ : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6837930", Offset = "0x6836D30", VA = "0x186837930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6837840", Offset = "0x6836C40", VA = "0x186837840")]
		public MNLMGOPEGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x19E4E90", Offset = "0x19E4290", VA = "0x1819E4E90", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid DOJDGHDKCLO)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x65A7D40", Offset = "0x65A7140", VA = "0x1865A7D40", Slot = "15")]
		public override void SetValue(ref SerializableGuid DOJDGHDKCLO, Data128 AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6835640", Offset = "0x6834A40", VA = "0x186835640")]
	public FJKPGAPKFPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class BJDOMNEIMFG : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class IJHDNPLBJJK : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6835FD0", Offset = "0x68353D0", VA = "0x186835FD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6835EE0", Offset = "0x68352E0", VA = "0x186835EE0")]
		public IJHDNPLBJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9A40", VA = "0x180BEA640", Slot = "14")]
		public override int GetValue(ref Data128 DOJDGHDKCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB320", Offset = "0x3EDA720", VA = "0x183EDB320", Slot = "15")]
		public override void SetValue(ref Data128 DOJDGHDKCLO, int AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class JLCLNLMMBKJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6836A00", Offset = "0x6835E00", VA = "0x186836A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6836910", Offset = "0x6835D10", VA = "0x186836910")]
		public JLCLNLMMBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x65AA070", Offset = "0x65A9470", VA = "0x1865AA070", Slot = "14")]
		public override int GetValue(ref Data128 DOJDGHDKCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4458DF0", Offset = "0x44581F0", VA = "0x184458DF0", Slot = "15")]
		public override void SetValue(ref Data128 DOJDGHDKCLO, int AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class NNJOIAMDIDC : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6837C50", Offset = "0x6837050", VA = "0x186837C50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6837B60", Offset = "0x6836F60", VA = "0x186837B60")]
		public NNJOIAMDIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9D28D0", Offset = "0x9D1CD0", VA = "0x1809D28D0", Slot = "14")]
		public override int GetValue(ref Data128 DOJDGHDKCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x65B0660", Offset = "0x65AFA60", VA = "0x1865B0660", Slot = "15")]
		public override void SetValue(ref Data128 DOJDGHDKCLO, int AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class HMOJPKMPEKG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6835DE0", Offset = "0x68351E0", VA = "0x186835DE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6835CF0", Offset = "0x68350F0", VA = "0x186835CF0")]
		public HMOJPKMPEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x65B04F0", Offset = "0x65AF8F0", VA = "0x1865B04F0", Slot = "14")]
		public override int GetValue(ref Data128 DOJDGHDKCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x65B0500", Offset = "0x65AF900", VA = "0x1865B0500", Slot = "15")]
		public override void SetValue(ref Data128 DOJDGHDKCLO, int AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x68318D0", Offset = "0x6830CD0", VA = "0x1868318D0")]
	public BJDOMNEIMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class EGEHOCIMHFG : ContainerPropertyBag<EELKMIABKIM.MIMDFLIGBPH>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class CNDAMGCEICA : Property<EELKMIABKIM.MIMDFLIGBPH, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x68321F0", Offset = "0x68315F0", VA = "0x1868321F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x68321B0", Offset = "0x68315B0", VA = "0x1868321B0")]
		public CNDAMGCEICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xDFA030", Offset = "0xDF9430", VA = "0x180DFA030", Slot = "14")]
		public override Vector3 GetValue(ref EELKMIABKIM.MIMDFLIGBPH DOJDGHDKCLO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6832190", Offset = "0x6831590", VA = "0x186832190", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM.MIMDFLIGBPH DOJDGHDKCLO, Vector3 AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class JHPONEKGCPC : Property<EELKMIABKIM.MIMDFLIGBPH, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x68367D0", Offset = "0x6835BD0", VA = "0x1868367D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6836790", Offset = "0x6835B90", VA = "0x186836790")]
		public JHPONEKGCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6836770", Offset = "0x6835B70", VA = "0x186836770", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref EELKMIABKIM.MIMDFLIGBPH DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6836780", Offset = "0x6835B80", VA = "0x186836780", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM.MIMDFLIGBPH DOJDGHDKCLO, List<SerializableGuid> AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6835180", Offset = "0x6834580", VA = "0x186835180")]
	public EGEHOCIMHFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class CJBPOHCHDLP : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class KKDGJPFNKMP : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6836D80", Offset = "0x6836180", VA = "0x186836D80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6836D40", Offset = "0x6836140", VA = "0x186836D40")]
		public KKDGJPFNKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6836D20", Offset = "0x6836120", VA = "0x186836D20", Slot = "14")]
		public override float GetValue(ref Vector3 DOJDGHDKCLO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6836D30", Offset = "0x6836130", VA = "0x186836D30", Slot = "15")]
		public override void SetValue(ref Vector3 DOJDGHDKCLO, float AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class ECICOAJAOOI : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6832680", Offset = "0x6831A80", VA = "0x186832680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6832640", Offset = "0x6831A40", VA = "0x186832640")]
		public ECICOAJAOOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6832620", Offset = "0x6831A20", VA = "0x186832620", Slot = "14")]
		public override float GetValue(ref Vector3 DOJDGHDKCLO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6832630", Offset = "0x6831A30", VA = "0x186832630", Slot = "15")]
		public override void SetValue(ref Vector3 DOJDGHDKCLO, float AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class LCKFNFNHDEK : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6836F90", Offset = "0x6836390", VA = "0x186836F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6836F50", Offset = "0x6836350", VA = "0x186836F50")]
		public LCKFNFNHDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x175BB50", Offset = "0x175AF50", VA = "0x18175BB50", Slot = "14")]
		public override float GetValue(ref Vector3 DOJDGHDKCLO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6836F40", Offset = "0x6836340", VA = "0x186836F40", Slot = "15")]
		public override void SetValue(ref Vector3 DOJDGHDKCLO, float AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6831F10", Offset = "0x6831310", VA = "0x186831F10")]
	public CJBPOHCHDLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class LHIBJFKINNC : ContainerPropertyBag<EELKMIABKIM.ILNCPLKCPOL>
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class ODGDMODEDNN : Property<EELKMIABKIM.ILNCPLKCPOL, EELKMIABKIM.MIMDFLIGBPH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x6837F30", Offset = "0x6837330", VA = "0x186837F30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6837EF0", Offset = "0x68372F0", VA = "0x186837EF0")]
		public ODGDMODEDNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x65A6BA0", Offset = "0x65A5FA0", VA = "0x1865A6BA0", Slot = "14")]
		public override EELKMIABKIM.MIMDFLIGBPH GetValue(ref EELKMIABKIM.ILNCPLKCPOL DOJDGHDKCLO)
		{
			return default(EELKMIABKIM.MIMDFLIGBPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6837EB0", Offset = "0x68372B0", VA = "0x186837EB0", Slot = "15")]
		public override void SetValue(ref EELKMIABKIM.ILNCPLKCPOL DOJDGHDKCLO, EELKMIABKIM.MIMDFLIGBPH AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6837220", Offset = "0x6836620", VA = "0x186837220")]
	public LHIBJFKINNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class BADPFPAJENE : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class HNEOJPAOBJB : Property<RRObjectPrefabV2Data, IMPAOGMALJN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x6835E50", Offset = "0x6835250", VA = "0x186835E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6835E10", Offset = "0x6835210", VA = "0x186835E10")]
		public HNEOJPAOBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9A40", VA = "0x180BEA640", Slot = "14")]
		public override IMPAOGMALJN GetValue(ref RRObjectPrefabV2Data DOJDGHDKCLO)
		{
			return default(IMPAOGMALJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB320", Offset = "0x3EDA720", VA = "0x183EDB320", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data DOJDGHDKCLO, IMPAOGMALJN AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6831770", Offset = "0x6830B70", VA = "0x186831770")]
	public BADPFPAJENE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6838C00", Offset = "0x6838000", VA = "0x186838C00")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200010A")]
public class MGDDIBLAEHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MGDDIBLAEHJ()
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

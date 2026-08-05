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
public class PJIPOLIEGDE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Rigidbody MFDMLFENPMD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B85640", Offset = "0x6B84440", VA = "0x186B85640", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public PJIPOLIEGDE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct LMOEHJHAFGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct APBKAAEHLKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public ALFCLIHOIFK NOABEHCLBOM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LGFDFNBDHFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HNDLFAKOBIF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public object LLLLFDEJGAG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B83120", Offset = "0x6B81F20", VA = "0x186B83120", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HNDLFAKOBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[InternalBufferCapacity(0)]
public struct MCNJFEOFHMI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity IBGFFODDGJN;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FPIKDKFKJML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float BEKPKNPABJJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly PANAMJAKCEP<FPIKDKFKJML> KBEILLGFBKH;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FHKFHOJOFLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public float3 CAAPHHINDMJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DCHNHBJPIEB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NNCIKKMHHAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCJGBBCDJPE(KOMKGHLBIAP NBFPLCPGBFE, KOMKGHLBIAP PEJJGPPCBOM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKGLBNOFCOD();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPCJMHADBOI();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMEGEDMPEND(bool LBLKJDFBHDJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JGNHFAIMFLE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPIDGJCIFGI();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JBGLALIPECK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LLLKGIOEGIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int EELACDAEOIA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xCB2D60", Offset = "0xCB1B60", VA = "0x180CB2D60")]
	public static LLLKGIOEGIA HAJGNNHEPJI(int KKLNCEHOHED)
	{
		return default(LLLKGIOEGIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ALFCLIHOIFK
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum MNKJPBHDJIH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GCOMPNKDEGA : PBBGKOOHOCC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ENDOEPPMPID GJJBONAPLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(ENDOEPPMPID);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GKNBHGDEBLI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NNCIKKMHHAL IFNAKBIEEOG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B82C90", Offset = "0x6B81A90", VA = "0x186B82C90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public GKNBHGDEBLI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KGJCMOHNKHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KJNKBHKJPBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 KNPDJDGFNIG;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PANAMJAKCEP<KJNKBHKJPBI> KBEILLGFBKH;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FOAAODONCNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float GCPCFLAFFFD;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly PANAMJAKCEP<FOAAODONCNM> KBEILLGFBKH;
}
namespace RecRoom.Rbex
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[HEGCBOLEINM]
	public struct RbexKinematicChangeSystemStateData : ISystemStateBufferElementData, IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BCGAPOBAPOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float LHHPCOFPECN;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly PANAMJAKCEP<BCGAPOBAPOI> KBEILLGFBKH;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DGIDFADOBCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 ILMAPPFHFNO;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GEHEFKNHPAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Entity BHODGDEIEBD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct COBCOLCMDGD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum KOMKGHLBIAP
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IPNGKKIPMPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 KNPDJDGFNIG;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly PANAMJAKCEP<KJNKBHKJPBI> KBEILLGFBKH;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DGIEILBENOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity GMBPOBACJJI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KMOPFEKJAJC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BCKDCBOJDFO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ALFCLIHOIFK MFDBBOJKANP;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MLNJHBHIMJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public RigidbodyConstraints LJBMLIOKNCM;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct AGGAFHDLDPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float GDMKAOAJHEN;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly PANAMJAKCEP<AGGAFHDLDPD> KBEILLGFBKH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct CLLBJNDPNDD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JONODELBAOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public KOMKGHLBIAP JAEONEFAODP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly PANAMJAKCEP<JONODELBAOA> KBEILLGFBKH;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct EGHEEOKPHLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public CollisionDetectionMode IDKLOPNLCFM;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PLHBEEDHHCE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public object KFOMIBHPFBN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B85780", Offset = "0x6B84580", VA = "0x186B85780", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public PLHBEEDHHCE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NKJOJKAJCBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DCALNEJLKBF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LHCGNICAHIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float3 OGKLPMINDBO;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct LCMMFAEOICL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float JJAPGBCDNEE;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct OBAMPFBBALL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float3 DKNNDEIMELD;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[InternalBufferCapacity(8)]
public struct PAOJHJCHDJD : ISystemStateBufferElementData, IBufferElementData, IEquatable<PAOJHJCHDJD>, OCBAMJCDHCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity IBGFFODDGJN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity HALPEJGKFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600")]
	public PAOJHJCHDJD(Entity IBGFFODDGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B83110", Offset = "0x6B81F10", VA = "0x186B83110", Slot = "4")]
	public bool Equals(PAOJHJCHDJD FGBEDAPNDEP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	public static PAOJHJCHDJD HAJGNNHEPJI(Entity FPIIEOBJDDB)
	{
		return default(PAOJHJCHDJD);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[MDDPAIKJPKM]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[KOCHDIKDLDL(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[KOCHDIKDLDL(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[KOCHDIKDLDL(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[MDDPAIKJPKM]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[KOCHDIKDLDL(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly PANAMJAKCEP<LocalUniformScaleData> Default;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct HGNEJHPPIHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct EMHFMPMJINP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity FPIIEOBJDDB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	public static EMHFMPMJINP HAJGNNHEPJI(Entity FPIIEOBJDDB)
	{
		return default(EMHFMPMJINP);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Container", 0)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(1)]
		public ContainerEnumFlags flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Flags]
	[KHFBHGPLBFG(0, 15943)]
	public enum ContainerEnumFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		CollisionEvent = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		CanUse = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		CanClimb = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		CanWallRun = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		CanClamber = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		CanTeleport = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		ALL = 0x3E47,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		MAX = 0x3E47
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CGKDCHEHEBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KEDBABOFPON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EAGMNJIJIHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MMHJOAMMOLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct JMEECKAOGHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct NFJGOAHBGJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct OECEGGBILEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct PLIPCLOEPFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GIJKHJMDDLH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[MDDPAIKJPKM]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[EBOLAGOCCLP(1)]
		public LFMOCNOCFFM version;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly PANAMJAKCEP<ComponentSerializedVersionData> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum LFMOCNOCFFM : uint
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CURRENT = 1u
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[MDDPAIKJPKM]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[KOCHDIKDLDL(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly PANAMJAKCEP<SplinePointScaleData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2644480", Offset = "0x2643280", VA = "0x182644480")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct CKDMFLHHILH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float DCHDAALBDEM;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly PANAMJAKCEP<CKDMFLHHILH> KBEILLGFBKH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[MDDPAIKJPKM]
	[PMPCPNGBBDE(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[KOCHDIKDLDL(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[KOCHDIKDLDL(2)]
		public SerializableGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Container", 0)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[KOCHDIKDLDL(1)]
		[LHIFMDOIFFA(0)]
		public CollisionMode collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly PANAMJAKCEP<ContainerCollisionModeData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[KHFBHGPLBFG(0, 2)]
	public enum CollisionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Off = 0,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Children = 1,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Hull = 2,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		COUNT = 3,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		MAX = 2
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal enum HEBOFMHKCLN
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class JOLJIJAOKIE
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct OFCKLOIIOOG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[MDDPAIKJPKM]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[KOCHDIKDLDL(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[KOCHDIKDLDL(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[KOCHDIKDLDL(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[KOCHDIKDLDL(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[KOCHDIKDLDL(5)]
		public float max;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal struct ENGODACHAJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct KIFABIEPMIB : ISystemStateComponentData, IComponentData, OCBAMJCDHCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Entity BCPFLMLFOCI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private Entity HALPEJGKFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct LDBHNONOMJK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct FPPKNKCMCMM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct DKBEKCOMAOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float4x4 CBBEJKPNFFJ;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly PANAMJAKCEP<DKBEKCOMAOE> KBEILLGFBKH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[KHFBHGPLBFG(0, 4)]
	public enum GizmoType
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Clamp = 1,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Piston = 2,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Rotator = 3,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		LookAt = 4,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		COUNT = 5,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		MAX = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[MDDPAIKJPKM]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[KOCHDIKDLDL(1)]
		public GizmoType gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[MDDPAIKJPKM]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[Flags]
		[KHFBHGPLBFG(0, 7)]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			DynamicUVProjection = 1,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			PreventInvertedCreation = 2,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			NewBendLogic = 4,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			MIN = 0,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			MAX = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[KOCHDIKDLDL(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly PANAMJAKCEP<ShapeConfigData> Default;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6B86800", Offset = "0x6B85600", VA = "0x186B86800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6B86880", Offset = "0x6B85680", VA = "0x186B86880")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[MDDPAIKJPKM]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[KOCHDIKDLDL(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly PANAMJAKCEP<AuthoredLocalUniformScaleData> Default;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct DGHGNMCCPEM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[KHFBHGPLBFG(0, 1)]
	public enum PropType
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Custom = 1,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		MAX = 1
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[MDDPAIKJPKM]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[KOCHDIKDLDL(1)]
		public PropType propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct KINIEEAAMPH : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[MDDPAIKJPKM]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[KOCHDIKDLDL(1)]
		public Entity spline;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct CJDIDCOBHNI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[KHFBHGPLBFG(0, 9)]
	public enum ObjectType
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Container = 1,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Primitive = 2,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Spline = 3,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Gizmo = 4,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Prop = 5,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Other = 6,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		GameObject = 7,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		Player = 8,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Unused = 9,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		COUNT = 10,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		MAX = 9
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class ELEOPDLOKOA
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B82050", Offset = "0x6B80E50", VA = "0x186B82050")]
	public static bool CJEOBILJLKK(this ObjectType DPBNAMGABDA)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[KHFBHGPLBFG(-1, 38)]
	public enum PrimitiveShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		MAX_VALUE = 38
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ALBCNCEHFJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct EKGDMDIEDJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct MCLJJDNDKFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct MFOKLKIEDML : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[MDDPAIKJPKM]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[KOCHDIKDLDL(1)]
		public MGGFHICFICB order;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
		public static implicit operator SplinePointOrderData(MGGFHICFICB value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(1)]
		public FixedString64Bytes name;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class GCGAMFLLEOG
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B82940", Offset = "0x6B81740", VA = "0x186B82940")]
	public static void MDELLMLPPIN(this ref ObjectPolicyEnumFlags KCEKDHFAAAO, MCNDCMCKKKP EFDDPLAIJPB, bool IIOKBCMDCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B82990", Offset = "0x6B81790", VA = "0x186B82990")]
	public static bool NPODJAMBCMK(this ObjectPolicyEnumFlags KCEKDHFAAAO, MCNDCMCKKKP EFDDPLAIJPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B82930", Offset = "0x6B81730", VA = "0x186B82930")]
	public static ObjectPolicyEnumFlags ECDIJNCNOBG(this MCNDCMCKKKP EFDDPLAIJPB)
	{
		return default(ObjectPolicyEnumFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B82970", Offset = "0x6B81770", VA = "0x186B82970")]
	public static void MDELLMLPPIN(this ref ObjectPolicyUserConfigurableFlags KCEKDHFAAAO, ObjectPolicyUserConfigurableFlags CDMJMAILEKC, bool IIOKBCMDCCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum MCNDCMCKKKP
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	COUNT
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Flags]
	[KHFBHGPLBFG(0, 16383)]
	public enum ObjectPolicyEnumFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		All = 0x3FFF,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Default = 0x3FFF,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		MAX = 0x3FFF
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[Flags]
	[KHFBHGPLBFG(0, 3)]
	public enum ObjectPolicyUserConfigurableFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		COUNT = 3,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		DEFAULT = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		MAX = 3
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct BIFOLDPNNOA : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[KIAEBJGCOHK]
	[KGJJNEDIOGJ(1029043735688538310uL, 14256247939851101839uL)]
	public struct DEPRECATED_RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ObjectType objectType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[KHFBHGPLBFG(int.MinValue, int.MaxValue)]
	public enum RenderableColor
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Red = 0,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Orange = 1,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Yellow = 2,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		LightGreen = 3,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Blue = 4,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		LightBlue = 5,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Teal = 6,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Green = 7,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		Purple = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		LightPink = 9,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Pink = 10,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Brown = 11,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Tan = 12,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		White = 13,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Grey = 14,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		DarkGrey = 15,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		DarkBrown = 16,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		LightBrown = 17,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		LightGrey = 18,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Black = 19,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		DarkRed = 20,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		DarkOrange = 21,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		DarkYellow = 22,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		DarkGreen = 23,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		DarkTeal = 24,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		DarkBlue = 25,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		DarkPurple = 26,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		DarkPink = 27,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		LightRed = 28,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		LightOrange = 29,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		LightYellow = 30,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Cyan = 31,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		LightPurple = 32,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		DarkTan = 33,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		NewColor1 = 34,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		NewColor2 = 35,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		NewColor3 = 36,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		NewColor4 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		NewColor5 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		NewColor6 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		NewColor7 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		NewColor8 = 41,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		NewColor9 = 42,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		NewColor10 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		NewColor11 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NewColor12 = 45,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		NewColor13 = 46,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		NewColor14 = 47,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		NewColor15 = 48,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		NewColor16 = 49,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		NewColor17 = 50,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		NewColor18 = 51,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		NewColor19 = 52,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		NewColor20 = 53,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		NewColor21 = 54,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		NewColor22 = 55,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		NewColor23 = 56,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		NewColor24 = 57,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		NewColor25 = 58,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		NewColor26 = 59,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		NewColor27 = 60,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Default = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[KOCHDIKDLDL(1)]
		[LHIFMDOIFFA(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[KOCHDIKDLDL(2)]
		[LHIFMDOIFFA(0)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[KOCHDIKDLDL(1)]
		[LHIFMDOIFFA(0)]
		public float angle;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct BDHAMPGCPHI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Container", 0)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(1)]
		public float mass;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct DIJIPMHBBCA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private NativeList<PJEAICEICBP> AMFICELNBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private NativeList<Entity> NLCDNCFFAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private JobHandle DPDOHIMELGE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JKEFCNHAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B81B50", Offset = "0x6B80950", VA = "0x186B81B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B81BC0", Offset = "0x6B809C0", VA = "0x186B81BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x39C3860", Offset = "0x39C2660", VA = "0x1839C3860")]
	public DIJIPMHBBCA(NativeList<PJEAICEICBP> AMFICELNBOD, NativeList<Entity> NLCDNCFFAJH, JobHandle DPDOHIMELGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B81C10", Offset = "0x6B80A10", VA = "0x186B81C10")]
	public (Entity, NativeSlice<Entity>) PANLAHHOLPP(int EFGAFPEAGGO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B81AF0", Offset = "0x6B808F0", VA = "0x186B81AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct LKFNLBEEALN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 IHHJAKDKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public quaternion EMNOFGLPALH;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly PANAMJAKCEP<LKFNLBEEALN> KBEILLGFBKH;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B83FD0", Offset = "0x6B82DD0", VA = "0x186B83FD0")]
	public float3 HBIDPKJEAFK(float3 PICIOEJJELN)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class JCEJNEJIOMB
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[KIAEBJGCOHK]
	[KGJJNEDIOGJ(218523523639012570uL, 15191719635551116065uL)]
	public struct DEPRECATED_ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private uint networkIdBits;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[MDDPAIKJPKM]
	[KGJJNEDIOGJ(17667479821163689808uL, 11946378475791123970uL)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[MDDPAIKJPKM]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[KOCHDIKDLDL(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly PANAMJAKCEP<SplinePointRotationData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[MDDPAIKJPKM]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[KOCHDIKDLDL(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[KOCHDIKDLDL(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OKPMILOHPJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public FixedString32Bytes PPPOJKMOIGD;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct MPDBIAGEIJJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Entity PLDDDFGDLMK;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Flags]
	[KHFBHGPLBFG(0, 1)]
	public enum TransformHint
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Static = 0,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Dynamic = 1,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		All = 1
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct EBKIEFMFMKC : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[PMPCPNGBBDE(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[EBOLAGOCCLP(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[EBOLAGOCCLP(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[EBOLAGOCCLP(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[EBOLAGOCCLP(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[PMPCPNGBBDE(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, NBCOBFFPIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[EBOLAGOCCLP(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		public static SerializableGuid HAJGNNHEPJI(Guid LOOGPKNLJEM)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6B865A0", Offset = "0x6B853A0", VA = "0x186B865A0", Slot = "4")]
		public bool Equals(SerializableGuid FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B86580", Offset = "0x6B85380", VA = "0x186B86580", Slot = "5")]
		public int CompareTo(SerializableGuid FGBEDAPNDEP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B866B0", Offset = "0x6B854B0", VA = "0x186B866B0", Slot = "6")]
		public void LKKGLINHIKF(ref NCJBBMAAODO BAJNDLOCJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6B86630", Offset = "0x6B85430", VA = "0x186B86630", Slot = "7")]
		public void KMIKNNFPDOG(ref MKGGFOJJCNM NILJFJKCFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6B867A0", Offset = "0x6B855A0", VA = "0x186B867A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct HGDMAAMHPJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BFFJMJJMGPG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[KHFBHGPLBFG(0, 4)]
	public enum ColliderType
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Box = 1,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Sphere = 2,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Capsule = 3,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Mesh = 4,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		COUNT = 5,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		MAX = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[MDDPAIKJPKM]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[KOCHDIKDLDL(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[KOCHDIKDLDL(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[KOCHDIKDLDL(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[KOCHDIKDLDL(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[KOCHDIKDLDL(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[KOCHDIKDLDL(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[KOCHDIKDLDL(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[KOCHDIKDLDL(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[KOCHDIKDLDL(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[KOCHDIKDLDL(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[KOCHDIKDLDL(11)]
		public KHIPLFDJCCB mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[KOCHDIKDLDL(12)]
		public HMPGGNIAIFF myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[KOCHDIKDLDL(13)]
		public OIACBJGLENF myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[KOCHDIKDLDL(14)]
		public BJDNFLCKFHA myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[KOCHDIKDLDL(15)]
		public PAKMMNDCHKP myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[KOCHDIKDLDL(16)]
		public JPFDFCCOANN myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[KOCHDIKDLDL(17)]
		public CCIGFIPPPND myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[KOCHDIKDLDL(18)]
		public KIPANAPGLKM myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[KOCHDIKDLDL(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[KOCHDIKDLDL(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[KOCHDIKDLDL(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[KOCHDIKDLDL(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public enum KHIPLFDJCCB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public enum HMPGGNIAIFF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public enum OIACBJGLENF : short
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum BJDNFLCKFHA : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum PAKMMNDCHKP
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum JPFDFCCOANN : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum CCIGFIPPPND : long
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public enum KIPANAPGLKM : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[MDDPAIKJPKM]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[MDDPAIKJPKM]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MCNHDCJMIDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public int NCMINFKEPHO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public int GEKGIECEDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public GameObject KKHNMHOFPEF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public MCNHDCJMIDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GHANMENCIML : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct HOIJHEMHMBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Vector3 EOMJHIEBAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public List<SerializableGuid> PFJBOMGPAAF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class EAAJLEBCKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public HOIJHEMHMBB LNBHJJDGOCD;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EAAJLEBCKME()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public SerializableGuid MHDDDMHMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public List<int> LBNDADBLDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public List<HOIJHEMHMBB> GOFLAHOEAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public List<EAAJLEBCKME> FKCMMGFBCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public GameObject KKHNMHOFPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Light GNNGPCIHNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public Collider DMENEKHAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public string BAOLMPIPBCL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public GHANMENCIML()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[KIAEBJGCOHK]
	[KGJJNEDIOGJ(2613756846563002039uL, 6372660366488563574uL)]
	[MMEJFHPOCLO("Container", 0)]
	public struct DEPRECATED_ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(1)]
		public DEPRECATED_CollidesWith collidesWith;
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Flags]
	[KHFBHGPLBFG(0, 15)]
	public enum DEPRECATED_CollidesWith
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Object = 1,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Player = 2,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Projectile = 4,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		Vehicle = 8,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		ALL = 0xF,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		MAX = 0xF
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[KIAEBJGCOHK]
	[KGJJNEDIOGJ(9804513251708000208uL, 10903582988135044631uL)]
	public struct DEPRECATED_ContainerData : IComponentData, IEquatable<DEPRECATED_ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[KOCHDIKDLDL(1)]
		public FixedString64Bytes name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[KOCHDIKDLDL(2)]
		public CollisionMode collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[KOCHDIKDLDL(3)]
		public DEPRECATED_CollidesWith collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[KOCHDIKDLDL(4)]
		public GrabbableMode grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[KOCHDIKDLDL(5)]
		public ContainerEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[KOCHDIKDLDL(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6B81900", Offset = "0x6B80700", VA = "0x186B81900", Slot = "4")]
		public bool Equals(DEPRECATED_ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[PMPCPNGBBDE(1)]
public struct HINIBFNNAPD : NBCOBFFPIIB
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Flags]
	[KHFBHGPLBFG(0, 7)]
	public enum Flags
	{
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[EBOLAGOCCLP(1)]
	public float tubeHeightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[EBOLAGOCCLP(2)]
	public int tubeRingPoints;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[EBOLAGOCCLP(3)]
	public Flags flags;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JAKDGHONKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B82F40", Offset = "0x6B81D40", VA = "0x186B82F40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B82EA0", Offset = "0x6B81CA0", VA = "0x186B82EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BIFMBPIOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B82FE0", Offset = "0x6B81DE0", VA = "0x186B82FE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B82E80", Offset = "0x6B81C80", VA = "0x186B82E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JLMEMMDKCED
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B82EC0", Offset = "0x6B81CC0", VA = "0x186B82EC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B82FC0", Offset = "0x6B81DC0", VA = "0x186B82FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6B83060", Offset = "0x6B81E60", VA = "0x186B83060", Slot = "5")]
	public void KMIKNNFPDOG(ref MKGGFOJJCNM NILJFJKCFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B830B0", Offset = "0x6B81EB0", VA = "0x186B830B0", Slot = "4")]
	public void LKKGLINHIKF(ref NCJBBMAAODO BAJNDLOCJJI)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[MDDPAIKJPKM]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[KOCHDIKDLDL(1)]
		public HINIBFNNAPD parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[MDDPAIKJPKM]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[KOCHDIKDLDL(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly PANAMJAKCEP<SplinePointPositionData> Default;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2644480", Offset = "0x2643280", VA = "0x182644480")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct BOHKCPPMJDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Entity PLDDDFGDLMK;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[InternalBufferCapacity(8)]
public struct HMNMMHDCEOL : ISystemStateBufferElementData, IBufferElementData, IEquatable<HMNMMHDCEOL>, OCBAMJCDHCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Entity IBGFFODDGJN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity HALPEJGKFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6B83110", Offset = "0x6B81F10", VA = "0x186B83110", Slot = "4")]
	public bool Equals(HMNMMHDCEOL FGBEDAPNDEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal struct CCLAMBCCDLA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Entity PHFCPLFJKGF;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[MDDPAIKJPKM]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[KOCHDIKDLDL(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[KOCHDIKDLDL(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public static readonly PANAMJAKCEP<LocalPoseData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2644110", Offset = "0x2642F10", VA = "0x182644110")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B81150", Offset = "0x6B7FF50", VA = "0x186B81150")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B81150", Offset = "0x6B7FF50", VA = "0x186B81150")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class BDADJOOLOGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface OCBAMJCDHCH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity BKNJOEGAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[MDDPAIKJPKM]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[KOCHDIKDLDL(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[KOCHDIKDLDL(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static readonly PANAMJAKCEP<OMShapeContainerData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Object", 0)]
	public struct ObjectPolicyV2Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[EBOLAGOCCLP(1)]
		public ObjectPolicyEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[KOCHDIKDLDL(2)]
		public AGAPFINMGJK scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[KOCHDIKDLDL(3)]
		[LHIFMDOIFFA(0)]
		public ObjectPolicyUserConfigurableFlags userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly PANAMJAKCEP<ObjectPolicyV2Data> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[KIAEBJGCOHK]
	[KGJJNEDIOGJ(9898405628982320166uL, 2023375009558162791uL)]
	[KGJJNEDIOGJ(9807788745867066359uL, 15168486114979071194uL)]
	public struct DEPRECATED_ObjectPolicyV1Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[KOCHDIKDLDL(1)]
		public ObjectPolicyEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[KOCHDIKDLDL(2)]
		public AGAPFINMGJK scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(3)]
		public bool isFrozen;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly PANAMJAKCEP<DEPRECATED_ObjectPolicyV1Data> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct GOINDOAIHKE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public int JMIAPMFLFBD;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HIMGIFIMOFJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public GCHandle KGPMOHLKMDN;
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct CIAPHBOKPGG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private int ECJPAHJMIEE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FHOMILACEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B81330", Offset = "0x6B80130", VA = "0x186B81330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6B81340", Offset = "0x6B80140", VA = "0x186B81340")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[MDDPAIKJPKM]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[KOCHDIKDLDL(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct IKADNKOBMPG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[MDDPAIKJPKM]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[KOCHDIKDLDL(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly PANAMJAKCEP<LocalDeformableScaleData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Container", 0)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[KOCHDIKDLDL(1)]
		[LHIFMDOIFFA(0)]
		public GrabbableMode grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[KHFBHGPLBFG(0, 1)]
	public enum GrabbableMode
	{
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		Pivot = 0,
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		Bounds = 1,
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		MAX = 1
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[PMPCPNGBBDE(1)]
public struct AGAPFINMGJK : NBCOBFFPIIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[EBOLAGOCCLP(1)]
	public bool enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[EBOLAGOCCLP(2)]
	public float3 minScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[EBOLAGOCCLP(3)]
	public float3 maxScale;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static readonly PANAMJAKCEP<AGAPFINMGJK> KBEILLGFBKH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B80F00", Offset = "0x6B7FD00", VA = "0x186B80F00", Slot = "5")]
	public void KMIKNNFPDOG(ref MKGGFOJJCNM NILJFJKCFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6B80F70", Offset = "0x6B7FD70", VA = "0x186B80F70", Slot = "4")]
	public void LKKGLINHIKF(ref NCJBBMAAODO BAJNDLOCJJI)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[MDDPAIKJPKM]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[KOCHDIKDLDL(1)]
		public PrimitiveShapeType shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct EJFBMBJLIMH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public int JMIAPMFLFBD;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface JKDFEICGLLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAEGPAEGJCB(bool LHFLDPPEFKH);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.TypeVersion(2)]
public struct NLOOKGFOFHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public uint NBANOMNFNKE;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B85030", Offset = "0x6B83E30", VA = "0x186B85030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct ELCFFFBAMKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal struct LJOEAJGNPDP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct HJFKHLFBMIP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[HEGCBOLEINM]
	internal struct SplinePointIndexChangeSystemStateData : ISystemStateBufferElementData, IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Entity splinePoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int index;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct HINKCIDHOGC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(1)]
		public RenderableColor color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(2)]
		public RenderableMaterial material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[LHIFMDOIFFA(0)]
		[KOCHDIKDLDL(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[KOCHDIKDLDL(4)]
		[LHIFMDOIFFA(0)]
		public Vector3 uvOffset;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[KOCHDIKDLDL(1)]
		[LHIFMDOIFFA(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static readonly PANAMJAKCEP<PhysicsMaterialData> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[PMPCPNGBBDE(1)]
public struct MGGFHICFICB : IComparable<MGGFHICFICB>, IEquatable<MGGFHICFICB>, NBCOBFFPIIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	[EBOLAGOCCLP(1)]
	public uint nom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	[EBOLAGOCCLP(2)]
	public uint denomMinusOne;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint BJCMLFLKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B84BF0", Offset = "0x6B839F0", VA = "0x186B84BF0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B84D40", Offset = "0x6B83B40", VA = "0x186B84D40")]
	public MGGFHICFICB(int JELFIKHNAHP, int OEEHMCKDNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B84D40", Offset = "0x6B83B40", VA = "0x186B84D40")]
	public MGGFHICFICB(uint JELFIKHNAHP, uint OEEHMCKDNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B84C00", Offset = "0x6B83A00", VA = "0x186B84C00")]
	public MGGFHICFICB PLNDFFFKFNM(int FHMAJLHBFAD = 1)
	{
		return default(MGGFHICFICB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B84AF0", Offset = "0x6B838F0", VA = "0x186B84AF0")]
	public MGGFHICFICB LIIIFBPFIPC(int FHMAJLHBFAD = 1)
	{
		return default(MGGFHICFICB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B84A00", Offset = "0x6B83800", VA = "0x186B84A00")]
	public static MGGFHICFICB KHNMJDGLNNG(MGGFHICFICB BGNJLPDNBMK, MGGFHICFICB MDKJCMEMIDH)
	{
		return default(MGGFHICFICB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B84BC0", Offset = "0x6B839C0", VA = "0x186B84BC0")]
	private static uint NLIOJNMJLIE(uint IKGMJGNOMBA, uint GOEPIJCAGGA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B848D0", Offset = "0x6B836D0", VA = "0x186B848D0", Slot = "4")]
	public int CompareTo(MGGFHICFICB FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B848F0", Offset = "0x6B836F0", VA = "0x186B848F0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B84C60", Offset = "0x6B83A60", VA = "0x186B84C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B84990", Offset = "0x6B83790", VA = "0x186B84990", Slot = "5")]
	public bool Equals(MGGFHICFICB FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B849B0", Offset = "0x6B837B0", VA = "0x186B849B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B84B50", Offset = "0x6B83950", VA = "0x186B84B50", Slot = "6")]
	public void LKKGLINHIKF(ref NCJBBMAAODO BAJNDLOCJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B84A80", Offset = "0x6B83880", VA = "0x186B84A80", Slot = "7")]
	public void KMIKNNFPDOG(ref MKGGFOJJCNM NILJFJKCFNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1942F20", Offset = "0x1941D20", VA = "0x181942F20")]
	public static bool DDONPFMGGHF(MGGFHICFICB BGNJLPDNBMK, MGGFHICFICB MDKJCMEMIDH)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[MDDPAIKJPKM]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public ObjectPrefabType prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[KIAEBJGCOHK]
	[KGJJNEDIOGJ(14327281633525910712uL, 2559857777606771911uL)]
	[KGJJNEDIOGJ(15725208981563603541uL, 17017036095303668770uL)]
	public struct DEPRECATED_RRObjectPrefabV1Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[KOCHDIKDLDL(1)]
		public ObjectPrefabType prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class NMMIEDDBPGO
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B85190", Offset = "0x6B83F90", VA = "0x186B85190")]
	public static bool OLALPACEACC(this ObjectPrefabType LKLFHGBOOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B85110", Offset = "0x6B83F10", VA = "0x186B85110")]
	public static string LAILJNMCDHP(this ObjectPrefabType LKLFHGBOOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B850C0", Offset = "0x6B83EC0", VA = "0x186B850C0")]
	public static ObjectType BNDFCJCKGAJ(this ObjectPrefabType HPLFBDKKOIF)
	{
		return default(ObjectType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B850E0", Offset = "0x6B83EE0", VA = "0x186B850E0")]
	internal static HEBOFMHKCLN FOCEHNOLKLK(this ObjectType DPBNAMGABDA)
	{
		return default(HEBOFMHKCLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B850F0", Offset = "0x6B83EF0", VA = "0x186B850F0")]
	internal static HEBOFMHKCLN FOCEHNOLKLK(this ObjectPrefabType HPLFBDKKOIF)
	{
		return default(HEBOFMHKCLN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct AAEBAEAIHIC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal struct PHIJAHFAHHO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public Entity FMEAADHIKJC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	public static PHIJAHFAHHO HAJGNNHEPJI(Entity FPIIEOBJDDB)
	{
		return default(PHIJAHFAHHO);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[MDDPAIKJPKM]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[EBOLAGOCCLP(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct ILAJJCAODEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public float3 BCLPOHJOKEG;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static readonly PANAMJAKCEP<ILAJJCAODEP> KBEILLGFBKH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct IFMCEPMBDBD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[MDDPAIKJPKM]
	[MMEJFHPOCLO("Container", 0)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[KOCHDIKDLDL(1)]
		[LHIFMDOIFFA(0)]
		public ContainerCollisionLayerEnum collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static readonly PANAMJAKCEP<ContainerCollisionLayerData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[KHFBHGPLBFG(0, 127)]
	public enum ContainerCollisionLayerEnum
	{
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		DECORATION = 101,
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		MAX = 127
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class CIKANKHAINA
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public enum BCPDNMIGKJA
	{
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public enum NALNKDEAAGN
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B81350", Offset = "0x6B80150", VA = "0x186B81350")]
	public static (BCPDNMIGKJA, NALNKDEAAGN) HOOHMBFOKIJ(this ContainerCollisionLayerEnum HIICPNGGJEO)
	{
		return default((BCPDNMIGKJA, NALNKDEAAGN));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct PJEAICEICBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public Entity BHODGDEIEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public int FHMAJLHBFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public int CNKKOGIEKAD;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[MDDPAIKJPKM]
	public struct ParentData : IComponentData, OCBAMJCDHCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[KOCHDIKDLDL(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct EMPPJKCLKOA : ISystemStateComponentData, IComponentData, OCBAMJCDHCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public Entity BCPFLMLFOCI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity HALPEJGKFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600")]
	public EMPPJKCLKOA(Entity GMBPOBACJJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	public static EMPPJKCLKOA HAJGNNHEPJI(Entity FPIIEOBJDDB)
	{
		return default(EMPPJKCLKOA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct HIMLILKFJAM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[KHFBHGPLBFG(1000, 8000)]
	public enum ObjectPrefabType
	{
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		Gizmo_Clamp = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		Gizmo_Piston = 4001,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		Gizmo_Rotator = 4002,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		Gizmo_LookAt = 4003,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		Prop_Custom = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		GameObject_Transform = 7000,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		GameObject_Rbex = 7001,
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		GameObject_Prop = 7002,
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		GameObject_LegacyGizmo = 7003,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		GameObject_GameRoleNode = 7004,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		GameObject_PlayerTrackingSpace = 7005,
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		Player = 8000
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class DNAADPDGCMI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct BACMDECEGGI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[KHFBHGPLBFG(-2, 2)]
	public enum TransformPriority
	{
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		Frozen = -2,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		Low = -1,
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		High = 1,
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		Realtime = 2,
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		MIN = -2,
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		MAX = 2
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct DJMMMPPMBPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct GBNIDODBNNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public uint FNNDALNEIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public int NGMNHKHBENE;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x866E30", Offset = "0x865C30", VA = "0x180866E30")]
	public GBNIDODBNNO(uint KCBMCJEHOPH, int BIBOJJDLHNM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public struct APANBBBOCEM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[KHFBHGPLBFG(-1, 31)]
	public enum RenderableMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		Cardboard = 0,
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		Neon = 1,
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		Brick = 2,
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		Carpet = 3,
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		Dirt = 4,
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		Grass = 5,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		MetalReflective = 6,
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		Concrete = 7,
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		Linoleum = 8,
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		Plaster = 9,
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		WoodLogs = 10,
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		WoodBoards = 11,
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		WoodGrain = 12,
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		WoodFloor = 13,
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		Sand = 14,
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		GlossyPlastic = 15,
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		Cloth = 16,
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		RubberFloor = 17,
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		MetalFloorTread = 18,
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		PaintedBrick = 19,
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		Crashpad = 20,
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		PaintedWood = 21,
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		GripTape = 22,
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		GalvanizedMetal = 23,
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		ParticleBoard = 24,
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		CheckeredFloor = 25,
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		SparklyVinyl = 26,
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		Gravel = 27,
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		Rock = 28,
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		Placeholder29 = 29,
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		Placeholder30 = 30,
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		Placeholder31 = 31,
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		MIN = -1,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		MAX = 31,
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		Default = 0
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[PMPCPNGBBDE(1)]
public struct GJANPBGBPGA : NBCOBFFPIIB, IEquatable<GJANPBGBPGA>
{
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly GJANPBGBPGA IOPEGLNHBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[EBOLAGOCCLP(1)]
	public int id;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xAFF400", Offset = "0xAFE200", VA = "0x180AFF400")]
	public GJANPBGBPGA(int PJCEAFJNLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B82BA0", Offset = "0x6B819A0", VA = "0x186B82BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B82B10", Offset = "0x6B81910", VA = "0x186B82B10", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xCB11A0", Offset = "0xCAFFA0", VA = "0x180CB11A0", Slot = "6")]
	public bool Equals(GJANPBGBPGA FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B82C40", Offset = "0x6B81A40", VA = "0x186B82C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B82C10", Offset = "0x6B81A10", VA = "0x186B82C10", Slot = "5")]
	public void KMIKNNFPDOG(ref MKGGFOJJCNM NILJFJKCFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B82C30", Offset = "0x6B81A30", VA = "0x186B82C30", Slot = "4")]
	public void LKKGLINHIKF(ref NCJBBMAAODO BAJNDLOCJJI)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[MDDPAIKJPKM]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		[KOCHDIKDLDL(1)]
		public GJANPBGBPGA customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct CFPLFOFBKHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public float4x4 BJJJIKJJEPE;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly PANAMJAKCEP<CFPLFOFBKHP> KBEILLGFBKH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[MDDPAIKJPKM]
	public struct AuthoredParentData : IComponentData, OCBAMJCDHCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		[KOCHDIKDLDL(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x861600", Offset = "0x860400", VA = "0x180861600")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6B811E0", Offset = "0x6B7FFE0", VA = "0x186B811E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public struct INGDMKFEABM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[HEGCBOLEINM]
	public struct SingletonActiveSceneData : ISystemStateComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public Entity scene;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
		public static implicit operator SingletonActiveSceneData(Entity value)
		{
			return default(SingletonActiveSceneData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[MDDPAIKJPKM]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		[KOCHDIKDLDL(1)]
		public TransformHint transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		[KOCHDIKDLDL(2)]
		public TransformPriority transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[MDDPAIKJPKM]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		[KOCHDIKDLDL(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		[KOCHDIKDLDL(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[KOCHDIKDLDL(3)]
		public float speed;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public struct IGDIMGAHMPJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal struct NBLGMOHHELK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[MDDPAIKJPKM]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		[KOCHDIKDLDL(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		[KOCHDIKDLDL(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public static readonly PANAMJAKCEP<AuthoredLocalPoseData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2644110", Offset = "0x2642F10", VA = "0x182644110")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6B81150", Offset = "0x6B7FF50", VA = "0x186B81150")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class PLNPJCMBJLK
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[KHFBHGPLBFG(0, 2)]
	public enum EShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		Primitive = 1,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		Spline = 2,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		COUNT = 3,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		MAX = 2
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[MDDPAIKJPKM]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		[KOCHDIKDLDL(1)]
		public EShapeType shapeType;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : CEBDOCPDCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6B86A80", Offset = "0x6B85880", VA = "0x186B86A80", Slot = "4")]
		public sealed override void DHFPPHBCEKD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class GGEGIBJBJNO : ContainerPropertyBag<PJIPOLIEGDE>
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class JCIOPKHDJHG : Property<PJIPOLIEGDE, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6B83500", Offset = "0x6B82300", VA = "0x186B83500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6B834C0", Offset = "0x6B822C0", VA = "0x186B834C0")]
		public JCIOPKHDJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3A94F50", Offset = "0x3A93D50", VA = "0x183A94F50", Slot = "14")]
		public override Rigidbody GetValue(ref PJIPOLIEGDE PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3A94F70", Offset = "0x3A93D70", VA = "0x183A94F70", Slot = "15")]
		public override void SetValue(ref PJIPOLIEGDE PIOBINFNKKO, Rigidbody KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6B829B0", Offset = "0x6B817B0", VA = "0x186B829B0")]
	public GGEGIBJBJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class PJLBAOHLBHK : ContainerPropertyBag<HNDLFAKOBIF>
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private class EPHBPMGOCNB : Property<HNDLFAKOBIF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6B82160", Offset = "0x6B80F60", VA = "0x186B82160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6B82120", Offset = "0x6B80F20", VA = "0x186B82120")]
		public EPHBPMGOCNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A94F50", Offset = "0x3A93D50", VA = "0x183A94F50", Slot = "14")]
		public override object GetValue(ref HNDLFAKOBIF PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A94F70", Offset = "0x3A93D70", VA = "0x183A94F70", Slot = "15")]
		public override void SetValue(ref HNDLFAKOBIF PIOBINFNKKO, object KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B856B0", Offset = "0x6B844B0", VA = "0x186B856B0")]
	public PJLBAOHLBHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class LGCPFMEJNNJ : ContainerPropertyBag<GKNBHGDEBLI>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	private class DNBOBKKGOOE : Property<GKNBHGDEBLI, NNCIKKMHHAL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6B81F00", Offset = "0x6B80D00", VA = "0x186B81F00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6B81EC0", Offset = "0x6B80CC0", VA = "0x186B81EC0")]
		public DNBOBKKGOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A94F50", Offset = "0x3A93D50", VA = "0x183A94F50", Slot = "14")]
		public override NNCIKKMHHAL GetValue(ref GKNBHGDEBLI PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A94F70", Offset = "0x3A93D70", VA = "0x183A94F70", Slot = "15")]
		public override void SetValue(ref GKNBHGDEBLI PIOBINFNKKO, NNCIKKMHHAL KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B83D60", Offset = "0x6B82B60", VA = "0x186B83D60")]
	public LGCPFMEJNNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class LHPAFBFGCOA : ContainerPropertyBag<PLHBEEDHHCE>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class KJALFBHFPLB : Property<PLHBEEDHHCE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6B83A30", Offset = "0x6B82830", VA = "0x186B83A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6B839F0", Offset = "0x6B827F0", VA = "0x186B839F0")]
		public KJALFBHFPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A94F50", Offset = "0x3A93D50", VA = "0x183A94F50", Slot = "14")]
		public override object GetValue(ref PLHBEEDHHCE PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A94F70", Offset = "0x3A93D70", VA = "0x183A94F70", Slot = "15")]
		public override void SetValue(ref PLHBEEDHHCE PIOBINFNKKO, object KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B83F00", Offset = "0x6B82D00", VA = "0x186B83F00")]
	public LHPAFBFGCOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class KAHCEHMINIH : ContainerPropertyBag<MCNHDCJMIDM>
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private class POHFOFNIAKD : Property<MCNHDCJMIDM, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6B85850", Offset = "0x6B84650", VA = "0x186B85850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B85810", Offset = "0x6B84610", VA = "0x186B85810")]
		public POHFOFNIAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xE40550", Offset = "0xE3F350", VA = "0x180E40550", Slot = "14")]
		public override int GetValue(ref MCNHDCJMIDM PIOBINFNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6B857F0", Offset = "0x6B845F0", VA = "0x186B857F0", Slot = "15")]
		public override void SetValue(ref MCNHDCJMIDM PIOBINFNKKO, int KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class FEEFDBDLJGE : Property<MCNHDCJMIDM, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6B82280", Offset = "0x6B81080", VA = "0x186B82280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6B82240", Offset = "0x6B81040", VA = "0x186B82240")]
		public FEEFDBDLJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xE405E0", Offset = "0xE3F3E0", VA = "0x180E405E0", Slot = "14")]
		public override int GetValue(ref MCNHDCJMIDM PIOBINFNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6B82220", Offset = "0x6B81020", VA = "0x186B82220", Slot = "15")]
		public override void SetValue(ref MCNHDCJMIDM PIOBINFNKKO, int KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class FOEJFEKBJHG : Property<MCNHDCJMIDM, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6B828A0", Offset = "0x6B816A0", VA = "0x186B828A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B82860", Offset = "0x6B81660", VA = "0x186B82860")]
		public FOEJFEKBJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B82810", Offset = "0x6B81610", VA = "0x186B82810", Slot = "14")]
		public override GameObject GetValue(ref MCNHDCJMIDM PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6B82830", Offset = "0x6B81630", VA = "0x186B82830", Slot = "15")]
		public override void SetValue(ref MCNHDCJMIDM PIOBINFNKKO, GameObject KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B836D0", Offset = "0x6B824D0", VA = "0x186B836D0")]
	public KAHCEHMINIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class FJFAJAECPGF : ContainerPropertyBag<GHANMENCIML>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class GPIAFBFALJL : Property<GHANMENCIML, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6B82D90", Offset = "0x6B81B90", VA = "0x186B82D90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6B82D50", Offset = "0x6B81B50", VA = "0x186B82D50")]
		public GPIAFBFALJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6B82D00", Offset = "0x6B81B00", VA = "0x186B82D00", Slot = "14")]
		public override SerializableGuid GetValue(ref GHANMENCIML PIOBINFNKKO)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6B82D30", Offset = "0x6B81B30", VA = "0x186B82D30", Slot = "15")]
		public override void SetValue(ref GHANMENCIML PIOBINFNKKO, SerializableGuid KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private class HHPMIKGMAPG : Property<GHANMENCIML, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6B82E50", Offset = "0x6B81C50", VA = "0x186B82E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B82E10", Offset = "0x6B81C10", VA = "0x186B82E10")]
		public HHPMIKGMAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B82DC0", Offset = "0x6B81BC0", VA = "0x186B82DC0", Slot = "14")]
		public override List<int> GetValue(ref GHANMENCIML PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6B82DE0", Offset = "0x6B81BE0", VA = "0x186B82DE0", Slot = "15")]
		public override void SetValue(ref GHANMENCIML PIOBINFNKKO, List<int> KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private class OBFKAJFHKAA : Property<GHANMENCIML, List<GHANMENCIML.HOIJHEMHMBB>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6B85250", Offset = "0x6B84050", VA = "0x186B85250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6B85210", Offset = "0x6B84010", VA = "0x186B85210")]
		public OBFKAJFHKAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6B851C0", Offset = "0x6B83FC0", VA = "0x186B851C0", Slot = "14")]
		public override List<GHANMENCIML.HOIJHEMHMBB> GetValue(ref GHANMENCIML PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6B851E0", Offset = "0x6B83FE0", VA = "0x186B851E0", Slot = "15")]
		public override void SetValue(ref GHANMENCIML PIOBINFNKKO, List<GHANMENCIML.HOIJHEMHMBB> KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class MONNGMHFBDC : Property<GHANMENCIML, List<GHANMENCIML.EAAJLEBCKME>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6B84F40", Offset = "0x6B83D40", VA = "0x186B84F40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6B84F00", Offset = "0x6B83D00", VA = "0x186B84F00")]
		public MONNGMHFBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6B84EB0", Offset = "0x6B83CB0", VA = "0x186B84EB0", Slot = "14")]
		public override List<GHANMENCIML.EAAJLEBCKME> GetValue(ref GHANMENCIML PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6B84ED0", Offset = "0x6B83CD0", VA = "0x186B84ED0", Slot = "15")]
		public override void SetValue(ref GHANMENCIML PIOBINFNKKO, List<GHANMENCIML.EAAJLEBCKME> KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class KJNINLMMDNO : Property<GHANMENCIML, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6B83AF0", Offset = "0x6B828F0", VA = "0x186B83AF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6B83AB0", Offset = "0x6B828B0", VA = "0x186B83AB0")]
		public KJNINLMMDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6B83A60", Offset = "0x6B82860", VA = "0x186B83A60", Slot = "14")]
		public override GameObject GetValue(ref GHANMENCIML PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6B83A80", Offset = "0x6B82880", VA = "0x186B83A80", Slot = "15")]
		public override void SetValue(ref GHANMENCIML PIOBINFNKKO, GameObject KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class NLGCEBACELH : Property<GHANMENCIML, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6B85000", Offset = "0x6B83E00", VA = "0x186B85000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B84FC0", Offset = "0x6B83DC0", VA = "0x186B84FC0")]
		public NLGCEBACELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6B84F70", Offset = "0x6B83D70", VA = "0x186B84F70", Slot = "14")]
		public override Light GetValue(ref GHANMENCIML PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B84F90", Offset = "0x6B83D90", VA = "0x186B84F90", Slot = "15")]
		public override void SetValue(ref GHANMENCIML PIOBINFNKKO, Light KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	private class JONFBIJLIHD : Property<GHANMENCIML, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6B83640", Offset = "0x6B82440", VA = "0x186B83640", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B83600", Offset = "0x6B82400", VA = "0x186B83600")]
		public JONFBIJLIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B835B0", Offset = "0x6B823B0", VA = "0x186B835B0", Slot = "14")]
		public override Collider GetValue(ref GHANMENCIML PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B835D0", Offset = "0x6B823D0", VA = "0x186B835D0", Slot = "15")]
		public override void SetValue(ref GHANMENCIML PIOBINFNKKO, Collider KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class EMOCAIJDABF : Property<GHANMENCIML, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6B820F0", Offset = "0x6B80EF0", VA = "0x186B820F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B820B0", Offset = "0x6B80EB0", VA = "0x186B820B0")]
		public EMOCAIJDABF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6B82060", Offset = "0x6B80E60", VA = "0x186B82060", Slot = "14")]
		public override string GetValue(ref GHANMENCIML PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B82080", Offset = "0x6B80E80", VA = "0x186B82080", Slot = "15")]
		public override void SetValue(ref GHANMENCIML PIOBINFNKKO, string KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6B822B0", Offset = "0x6B810B0", VA = "0x186B822B0")]
	public FJFAJAECPGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class KCMEDAPDBKA : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class ODGDCAHFIGH : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6B85370", Offset = "0x6B84170", VA = "0x186B85370", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6B85280", Offset = "0x6B84080", VA = "0x186B85280")]
		public ODGDCAHFIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BACAE0", Offset = "0x2BAB8E0", VA = "0x182BACAE0", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid PIOBINFNKKO)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x66E0290", Offset = "0x66DF090", VA = "0x1866E0290", Slot = "15")]
		public override void SetValue(ref SerializableGuid PIOBINFNKKO, Data128 KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B83860", Offset = "0x6B82660", VA = "0x186B83860")]
	public KCMEDAPDBKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class LNMHFNDEHIJ : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class FJMPEEFGEDO : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x6B82780", Offset = "0x6B81580", VA = "0x186B82780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B82690", Offset = "0x6B81490", VA = "0x186B82690")]
		public FJMPEEFGEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1307A80", Offset = "0x1306880", VA = "0x181307A80", Slot = "14")]
		public override int GetValue(ref Data128 PIOBINFNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xE525A0", Offset = "0xE513A0", VA = "0x180E525A0", Slot = "15")]
		public override void SetValue(ref Data128 PIOBINFNKKO, int KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	private class LABBCGAIIMI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6B83D30", Offset = "0x6B82B30", VA = "0x186B83D30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B83C40", Offset = "0x6B82A40", VA = "0x186B83C40")]
		public LABBCGAIIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x66E25D0", Offset = "0x66E13D0", VA = "0x1866E25D0", Slot = "14")]
		public override int GetValue(ref Data128 PIOBINFNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xE527A0", Offset = "0xE515A0", VA = "0x180E527A0", Slot = "15")]
		public override void SetValue(ref Data128 PIOBINFNKKO, int KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class EDLCGJEAIHB : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6B82020", Offset = "0x6B80E20", VA = "0x186B82020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6B81F30", Offset = "0x6B80D30", VA = "0x186B81F30")]
		public EDLCGJEAIHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BB19E0", Offset = "0x2BB07E0", VA = "0x182BB19E0", Slot = "14")]
		public override int GetValue(ref Data128 PIOBINFNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x66E8B30", Offset = "0x66E7930", VA = "0x1866E8B30", Slot = "15")]
		public override void SetValue(ref Data128 PIOBINFNKKO, int KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class MIAEJPHINIP : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6B84E80", Offset = "0x6B83C80", VA = "0x186B84E80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6B84D90", Offset = "0x6B83B90", VA = "0x186B84D90")]
		public MIAEJPHINIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x66E89C0", Offset = "0x66E77C0", VA = "0x1866E89C0", Slot = "14")]
		public override int GetValue(ref Data128 PIOBINFNKKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x66E89D0", Offset = "0x66E77D0", VA = "0x1866E89D0", Slot = "15")]
		public override void SetValue(ref Data128 PIOBINFNKKO, int KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B842D0", Offset = "0x6B830D0", VA = "0x186B842D0")]
	public LNMHFNDEHIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class DAEFAKMGPOO : ContainerPropertyBag<GHANMENCIML.HOIJHEMHMBB>
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class GJANFCJJPHL : Property<GHANMENCIML.HOIJHEMHMBB, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6B82AE0", Offset = "0x6B818E0", VA = "0x186B82AE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6B82AA0", Offset = "0x6B818A0", VA = "0x186B82AA0")]
		public GJANFCJJPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x25BE0A0", Offset = "0x25BCEA0", VA = "0x1825BE0A0", Slot = "14")]
		public override Vector3 GetValue(ref GHANMENCIML.HOIJHEMHMBB PIOBINFNKKO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6B82A80", Offset = "0x6B81880", VA = "0x186B82A80", Slot = "15")]
		public override void SetValue(ref GHANMENCIML.HOIJHEMHMBB PIOBINFNKKO, Vector3 KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class FDPKHDDHGCP : Property<GHANMENCIML.HOIJHEMHMBB, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6B821F0", Offset = "0x6B80FF0", VA = "0x186B821F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6B821B0", Offset = "0x6B80FB0", VA = "0x186B821B0")]
		public FDPKHDDHGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6B82190", Offset = "0x6B80F90", VA = "0x186B82190", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref GHANMENCIML.HOIJHEMHMBB PIOBINFNKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6B821A0", Offset = "0x6B80FA0", VA = "0x186B821A0", Slot = "15")]
		public override void SetValue(ref GHANMENCIML.HOIJHEMHMBB PIOBINFNKKO, List<SerializableGuid> KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6B817B0", Offset = "0x6B805B0", VA = "0x186B817B0")]
	public DAEFAKMGPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class CKNENCGNLCK : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class DJLHLINAPJN : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6B81DB0", Offset = "0x6B80BB0", VA = "0x186B81DB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6B81D70", Offset = "0x6B80B70", VA = "0x186B81D70")]
		public DJLHLINAPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD1A0", Offset = "0x6ACBFA0", VA = "0x186ACD1A0", Slot = "14")]
		public override float GetValue(ref Vector3 PIOBINFNKKO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6B81D60", Offset = "0x6B80B60", VA = "0x186B81D60", Slot = "15")]
		public override void SetValue(ref Vector3 PIOBINFNKKO, float KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class PFEDOPLBOOA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x6B85610", Offset = "0x6B84410", VA = "0x186B85610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6B855D0", Offset = "0x6B843D0", VA = "0x186B855D0")]
		public PFEDOPLBOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9520", Offset = "0x6AC8320", VA = "0x186AC9520", Slot = "14")]
		public override float GetValue(ref Vector3 PIOBINFNKKO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6B855C0", Offset = "0x6B843C0", VA = "0x186B855C0", Slot = "15")]
		public override void SetValue(ref Vector3 PIOBINFNKKO, float KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class JJEFFCIDDDA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6B83580", Offset = "0x6B82380", VA = "0x186B83580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6B83540", Offset = "0x6B82340", VA = "0x186B83540")]
		public JJEFFCIDDDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1CED810", Offset = "0x1CEC610", VA = "0x181CED810", Slot = "14")]
		public override float GetValue(ref Vector3 PIOBINFNKKO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6B83530", Offset = "0x6B82330", VA = "0x186B83530", Slot = "15")]
		public override void SetValue(ref Vector3 PIOBINFNKKO, float KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6B81520", Offset = "0x6B80320", VA = "0x186B81520")]
	public CKNENCGNLCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal class LGDCBDMBHML : ContainerPropertyBag<GHANMENCIML.EAAJLEBCKME>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class PAOCBDNCKDD : Property<GHANMENCIML.EAAJLEBCKME, GHANMENCIML.HOIJHEMHMBB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6B85590", Offset = "0x6B84390", VA = "0x186B85590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6B85550", Offset = "0x6B84350", VA = "0x186B85550")]
		public PAOCBDNCKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x66DF120", Offset = "0x66DDF20", VA = "0x1866DF120", Slot = "14")]
		public override GHANMENCIML.HOIJHEMHMBB GetValue(ref GHANMENCIML.EAAJLEBCKME PIOBINFNKKO)
		{
			return default(GHANMENCIML.HOIJHEMHMBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6B85510", Offset = "0x6B84310", VA = "0x186B85510", Slot = "15")]
		public override void SetValue(ref GHANMENCIML.EAAJLEBCKME PIOBINFNKKO, GHANMENCIML.HOIJHEMHMBB KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B83E30", Offset = "0x6B82C30", VA = "0x186B83E30")]
	public LGDCBDMBHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal class IKIMEFGHAFD : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class HNKGLOLCODG : Property<RRObjectPrefabV2Data, ObjectPrefabType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6B831D0", Offset = "0x6B81FD0", VA = "0x186B831D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool CKPLHALPLKL
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6B83190", Offset = "0x6B81F90", VA = "0x186B83190")]
		public HNKGLOLCODG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1307A80", Offset = "0x1306880", VA = "0x181307A80", Slot = "14")]
		public override ObjectPrefabType GetValue(ref RRObjectPrefabV2Data PIOBINFNKKO)
		{
			return default(ObjectPrefabType);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xE525A0", Offset = "0xE513A0", VA = "0x180E525A0", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data PIOBINFNKKO, ObjectPrefabType KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B83200", Offset = "0x6B82000", VA = "0x186B83200")]
	public IKIMEFGHAFD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6B858E0", Offset = "0x6B846E0", VA = "0x186B858E0")]
		[RuntimeInitializeOnLoadMethod]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public class AuthoredPreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public class AuthoredChildrenData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	public class PreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
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

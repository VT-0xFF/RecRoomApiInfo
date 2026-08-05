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
public class OENKFKCIBMC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Rigidbody PJFGPOLLAAL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C50AE0", Offset = "0x6C4F0E0", VA = "0x186C50AE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public OENKFKCIBMC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct ECLMOOEJHMP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ODOCLNFEOED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public BJDBFCFOACF PPKMCBDGMPJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FDDPDKKKPOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AAKDEJMMFNK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public object HFGHPFMKFOC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C7F0", Offset = "0x6C4ADF0", VA = "0x186C4C7F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public AAKDEJMMFNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[InternalBufferCapacity(0)]
public struct CADMDDBDCNH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity AIMPELPKDNP;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IDJPIPEEBPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float PBMOANADGLE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HEDMIMHLNEJ<IDJPIPEEBPK> EDEKLFBDJFC;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KAJIMMHHLLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public float3 EABMIPHILFJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LOGPEHMOKOC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CMEDKBLEPDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFHABDBJNEC(LADENCOPJDI FAMEAJFIOMB, LADENCOPJDI IAEIKKJEGBE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMBANIDNFF();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POJPONNLGEE();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCOIBLJJPNH(bool JBNIAAIKEEJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GJHNHBIFCLH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNKFBDMKMOG();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DKLFPAIPGIK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MILKHJMHMKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int CABNHPJEJFD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C230", Offset = "0x1E7A830", VA = "0x181E7C230")]
	public static MILKHJMHMKE BJIOOOHFEFG(int FEBHELIDNED)
	{
		return default(MILKHJMHMKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BJDBFCFOACF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum DEJBIADAKBB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GIGIIPNKEGM : PJLMLLPIOIJ, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BPBJOMPNFMJ CLPMLFCNGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BPBJOMPNFMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NKODOAHJPBE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public CMEDKBLEPDC EEPCEIBOACD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C50830", Offset = "0x6C4EE30", VA = "0x186C50830", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public NKODOAHJPBE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IOIEHOPIBJB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KIICEOEOHHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 HDOKHMMEHLM;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly HEDMIMHLNEJ<KIICEOEOHHD> EDEKLFBDJFC;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IMABBGLHHBL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float DJJLJFPNFJA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly HEDMIMHLNEJ<IMABBGLHHBL> EDEKLFBDJFC;
}
namespace RecRoom.Rbex
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[DIBAGFOHPFM]
	public struct RbexKinematicChangeSystemStateData : ISystemStateBufferElementData, IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EJOALNAGOJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float OGAOFMHMEAK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly HEDMIMHLNEJ<EJOALNAGOJH> EDEKLFBDJFC;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JNBIEKEFKHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 IJHPFKPGEIA;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LOGDLKGOIGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Entity MPEICFNBKOF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MIKFMNMNNAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum LADENCOPJDI
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
public struct FCFFLCKAAMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 HDOKHMMEHLM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly HEDMIMHLNEJ<KIICEOEOHHD> EDEKLFBDJFC;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KFDJELBIFHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity KHJHJOOPMKP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EHEBCLBINDK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FECJMPLDKNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public BJDBFCFOACF HODDNMIFCNK;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct IFKMGPFGMNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public RigidbodyConstraints PLAAPHPJNLF;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CJDJCPNNOEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float MFACEPCJDLN;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly HEDMIMHLNEJ<CJDJCPNNOEK> EDEKLFBDJFC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct NHGEPGCHAHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct ALLFKCHDGCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public LADENCOPJDI IMICAOBHNAC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly HEDMIMHLNEJ<ALLFKCHDGCH> EDEKLFBDJFC;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JOOIPPJLBFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public CollisionDetectionMode BJIEJGAKEFA;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IBAFFAMFDAK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public object LANABFCIAOC;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F2A0", Offset = "0x6C4D8A0", VA = "0x186C4F2A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IBAFFAMFDAK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct LHKLIELJACA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FEJAEDNMMJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MHAHOCDIMGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float3 AEBCBPIOEOM;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MFFICJJJLLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float FHNDOPNGBEH;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct OMFJGGBFCGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float3 CHDJMFPCPOB;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[InternalBufferCapacity(8)]
public struct NAOAKHIHLEE : ISystemStateBufferElementData, IBufferElementData, IEquatable<NAOAKHIHLEE>, HHPHCEALIMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity AIMPELPKDNP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity DOAKKPAMMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40")]
	public NAOAKHIHLEE(Entity AIMPELPKDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ED90", Offset = "0x6C4D390", VA = "0x186C4ED90", Slot = "4")]
	public bool Equals(NAOAKHIHLEE EJECOGCICOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
	public static NAOAKHIHLEE BJIOOOHFEFG(Entity PEKCJMKIHGK)
	{
		return default(NAOAKHIHLEE);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CADHJLBHGHL]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[BJIPCIEBFJH(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[BJIPCIEBFJH(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[BJIPCIEBFJH(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CADHJLBHGHL]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[BJIPCIEBFJH(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly HEDMIMHLNEJ<LocalUniformScaleData> Default;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct DLCJBAGNOPO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct PKJJFCBJBCN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity PEKCJMKIHGK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
	public static PKJJFCBJBCN BJIOOOHFEFG(Entity PEKCJMKIHGK)
	{
		return default(PKJJFCBJBCN);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Container", 0)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(1)]
		public ContainerEnumFlags flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Flags]
	[MGDHFFNJLNP(0, 15943)]
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
public struct CJBNPPGJKBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OFPANOIJOBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct IPGBAJIMIFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LBFICMKDOPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FJCJGNLJKAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct NDODGNKADBN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct NNJFGIKACGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct AFJCDHNODLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GJAJOGPKCOC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CADHJLBHGHL]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[NGGNDCHNGFA(1)]
		public FFDLEHAKJCM version;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly HEDMIMHLNEJ<ComponentSerializedVersionData> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum FFDLEHAKJCM : uint
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
	[CADHJLBHGHL]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[BJIPCIEBFJH(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly HEDMIMHLNEJ<SplinePointScaleData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x15C4C40", Offset = "0x15C3240", VA = "0x1815C4C40")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct LMIMDNONMCP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float PBMCAAMOHNL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly HEDMIMHLNEJ<LMIMDNONMCP> EDEKLFBDJFC;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CADHJLBHGHL]
	[HABILHFCNMN(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[BJIPCIEBFJH(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[BJIPCIEBFJH(2)]
		public SerializableGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Container", 0)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[BJIPCIEBFJH(1)]
		[BECCBFAEBJL(0)]
		public CollisionMode collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly HEDMIMHLNEJ<ContainerCollisionModeData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[MGDHFFNJLNP(0, 2)]
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
internal enum NOGLPGHPFKN
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
internal static class FOAMCAPDFIN
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct FCEEKMAEICA : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CADHJLBHGHL]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[BJIPCIEBFJH(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[BJIPCIEBFJH(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[BJIPCIEBFJH(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[BJIPCIEBFJH(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[BJIPCIEBFJH(5)]
		public float max;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal struct GMNLJCFMLNG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct NELJOLJBPCB : ISystemStateComponentData, IComponentData, HHPHCEALIMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Entity HPNLJLJFBFN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private Entity DOAKKPAMMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct LFEEAIFPIGF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BGIGGINAMAM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct LEGHHECAHGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float4x4 FHJDFFHMFGO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly HEDMIMHLNEJ<LEGHHECAHGO> EDEKLFBDJFC;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[MGDHFFNJLNP(0, 4)]
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
	[CADHJLBHGHL]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[BJIPCIEBFJH(1)]
		public GizmoType gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CADHJLBHGHL]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[Flags]
		[MGDHFFNJLNP(0, 7)]
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
		[BJIPCIEBFJH(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly HEDMIMHLNEJ<ShapeConfigData> Default;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6C51FC0", Offset = "0x6C505C0", VA = "0x186C51FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6C52040", Offset = "0x6C50640", VA = "0x186C52040")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CADHJLBHGHL]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[BJIPCIEBFJH(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly HEDMIMHLNEJ<AuthoredLocalUniformScaleData> Default;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct HFODIFBOOBL : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[MGDHFFNJLNP(0, 1)]
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
	[CADHJLBHGHL]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[BJIPCIEBFJH(1)]
		public PropType propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct LBCBFNKOGMN : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CADHJLBHGHL]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[BJIPCIEBFJH(1)]
		public Entity spline;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct ADOPKKLNLDP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[MGDHFFNJLNP(0, 9)]
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
public static class FGCMABJHNAO
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E5E0", Offset = "0x6C4CBE0", VA = "0x186C4E5E0")]
	public static bool PHBMODACMOO(this ObjectType DCBCJOPDBFH)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[MGDHFFNJLNP(-1, 38)]
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
public struct OPNAFOOGEGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct EHNJDJNMGNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct NAFLCIGLFAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct HNHMFKGPKBI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CADHJLBHGHL]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[BJIPCIEBFJH(1)]
		public EALGDNFPJGP order;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
		public static implicit operator SplinePointOrderData(EALGDNFPJGP value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(1)]
		public FixedString64Bytes name;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class LOANKDGFAEN
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FDF0", Offset = "0x6C4E3F0", VA = "0x186C4FDF0")]
	public static void PCICHOODFHC(this ref ObjectPolicyEnumFlags OHMIPIKLIJM, DJGIOMCBOKH EBNGIGOPFBM, bool CHKEADEKBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FDA0", Offset = "0x6C4E3A0", VA = "0x186C4FDA0")]
	public static bool FNPFDNJIAGF(this ObjectPolicyEnumFlags OHMIPIKLIJM, DJGIOMCBOKH EBNGIGOPFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FDC0", Offset = "0x6C4E3C0", VA = "0x186C4FDC0")]
	public static ObjectPolicyEnumFlags MDFJNEAOOAO(this DJGIOMCBOKH EBNGIGOPFBM)
	{
		return default(ObjectPolicyEnumFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FDD0", Offset = "0x6C4E3D0", VA = "0x186C4FDD0")]
	public static void PCICHOODFHC(this ref ObjectPolicyUserConfigurableFlags OHMIPIKLIJM, ObjectPolicyUserConfigurableFlags LGEAECDPGKJ, bool CHKEADEKBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum DJGIOMCBOKH
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
	[MGDHFFNJLNP(0, 16383)]
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
	[MGDHFFNJLNP(0, 3)]
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
public struct MPIODBPAPBN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[PBEGMMHNNPD]
	[JMCBBDDNFGG(1029043735688538310uL, 14256247939851101839uL)]
	public struct DEPRECATED_RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ObjectType objectType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[MGDHFFNJLNP(int.MinValue, int.MaxValue)]
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
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[BJIPCIEBFJH(1)]
		[BECCBFAEBJL(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[BJIPCIEBFJH(3)]
		[BECCBFAEBJL(0)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(1)]
		public float angle;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct FGNBNDDFBOB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Container", 0)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(1)]
		public float mass;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct ABMGLFIKGIM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private NativeList<MHELJFJMPGD> HPKLDDCMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private NativeList<Entity> GKDCAFLCDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private JobHandle OAGOIKMJJAE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EGOPANFHJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CAD0", Offset = "0x6C4B0D0", VA = "0x186C4CAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CB40", Offset = "0x6C4B140", VA = "0x186C4CB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2600810", Offset = "0x25FEE10", VA = "0x182600810")]
	public ABMGLFIKGIM(NativeList<MHELJFJMPGD> HPKLDDCMJDP, NativeList<Entity> GKDCAFLCDKM, JobHandle OAGOIKMJJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C980", Offset = "0x6C4AF80", VA = "0x186C4C980")]
	public (Entity, NativeSlice<Entity>) FOJOCFINGDL(int JMCLMPHOKNG)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C920", Offset = "0x6C4AF20", VA = "0x186C4C920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct EGDIAJCCCCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 FADCMIMHMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public quaternion HOHKOHLHECA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly HEDMIMHLNEJ<EGDIAJCCCCO> EDEKLFBDJFC;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DFB0", Offset = "0x6C4C5B0", VA = "0x186C4DFB0")]
	public float3 EFAAACEECMA(float3 DEGODPDOPJM)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class EJHKOLILFLI
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[PBEGMMHNNPD]
	[JMCBBDDNFGG(218523523639012570uL, 15191719635551116065uL)]
	public struct DEPRECATED_ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private uint networkIdBits;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CADHJLBHGHL]
	[JMCBBDDNFGG(17667479821163689808uL, 11946378475791123970uL)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CADHJLBHGHL]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[BJIPCIEBFJH(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly HEDMIMHLNEJ<SplinePointRotationData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CADHJLBHGHL]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[BJIPCIEBFJH(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[BJIPCIEBFJH(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct EJFANJLCPOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public FixedString32Bytes HNPIEGONNBC;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DJPLGKECEEC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Entity JLJGNFEPNIK;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Flags]
	[MGDHFFNJLNP(0, 1)]
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
public struct IHGLGAHNJHL : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[HABILHFCNMN(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[NGGNDCHNGFA(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[NGGNDCHNGFA(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[NGGNDCHNGFA(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[NGGNDCHNGFA(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[HABILHFCNMN(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, KIAMMPFPLDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[NGGNDCHNGFA(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		public static SerializableGuid BJIOOOHFEFG(Guid IKGPBILBBIK)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6C51ED0", Offset = "0x6C504D0", VA = "0x186C51ED0", Slot = "4")]
		public bool Equals(SerializableGuid EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6C51D40", Offset = "0x6C50340", VA = "0x186C51D40", Slot = "5")]
		public int CompareTo(SerializableGuid EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6C51D60", Offset = "0x6C50360", VA = "0x186C51D60", Slot = "6")]
		public void DHDFEGACAHE(ref PMFHDCBANDG NKODOJNBMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C51E50", Offset = "0x6C50450", VA = "0x186C51E50", Slot = "7")]
		public void EMHFJGFFMPB(ref GIGHIDGOGIA PDNINNPJLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6C51F60", Offset = "0x6C50560", VA = "0x186C51F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct DFFDEFIACCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct MNOBPGHBKPH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[MGDHFFNJLNP(0, 4)]
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
	[CADHJLBHGHL]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[BJIPCIEBFJH(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[BJIPCIEBFJH(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[BJIPCIEBFJH(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[BJIPCIEBFJH(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[BJIPCIEBFJH(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[BJIPCIEBFJH(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[BJIPCIEBFJH(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[BJIPCIEBFJH(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[BJIPCIEBFJH(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[BJIPCIEBFJH(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[BJIPCIEBFJH(11)]
		public EICPAGHKEIK mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[BJIPCIEBFJH(12)]
		public CJNAGOMELGE myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[BJIPCIEBFJH(13)]
		public PHCLCKGJAPL myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[BJIPCIEBFJH(14)]
		public JFNOGMMIDCG myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[BJIPCIEBFJH(15)]
		public BHMJDHKCCLF myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[BJIPCIEBFJH(16)]
		public EAGPGMEDJGI myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[BJIPCIEBFJH(17)]
		public DENPCEPEEJD myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[BJIPCIEBFJH(18)]
		public PILJEIAIFNE myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[BJIPCIEBFJH(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[BJIPCIEBFJH(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[BJIPCIEBFJH(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[BJIPCIEBFJH(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public enum EICPAGHKEIK : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public enum CJNAGOMELGE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public enum PHCLCKGJAPL : short
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum JFNOGMMIDCG : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum BHMJDHKCCLF
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum EAGPGMEDJGI : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum DENPCEPEEJD : long
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public enum PILJEIAIFNE : ulong
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
	[CADHJLBHGHL]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CADHJLBHGHL]
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
public class MEIKLKMFLII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public int FBJCGAGDCPB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public int AHEJODBDKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public GameObject CGLKMGEDNPH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public MEIKLKMFLII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class PFEAOLCCGMB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct LDMDCJDIFHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Vector3 KGDBLNMNCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public List<SerializableGuid> CMCEJPMCLKD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class DNFMONHCIOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public LDMDCJDIFHB INIEFBIPPBP;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DNFMONHCIOF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public SerializableGuid HCAICEFOBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public List<int> AJPLPLPFMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public List<LDMDCJDIFHB> JGBGHOJOCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public List<DNFMONHCIOF> FHBLDPBJOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public GameObject CGLKMGEDNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Light EOECKELMEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public Collider OHNLBFFNOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public string HHLMFNOBKCF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public PFEAOLCCGMB()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[PBEGMMHNNPD]
	[JMCBBDDNFGG(2613756846563002039uL, 6372660366488563574uL)]
	[DJCKHAFPFBB("Container", 0)]
	public struct DEPRECATED_ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[BJIPCIEBFJH(1)]
		[BECCBFAEBJL(0)]
		public DEPRECATED_CollidesWith collidesWith;
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Flags]
	[MGDHFFNJLNP(0, 15)]
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
	[PBEGMMHNNPD]
	[JMCBBDDNFGG(9804513251708000208uL, 10903582988135044631uL)]
	public struct DEPRECATED_ContainerData : IComponentData, IEquatable<DEPRECATED_ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[BJIPCIEBFJH(1)]
		public FixedString64Bytes name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[BJIPCIEBFJH(2)]
		public CollisionMode collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[BJIPCIEBFJH(3)]
		public DEPRECATED_CollidesWith collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[BJIPCIEBFJH(4)]
		public GrabbableMode grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[BJIPCIEBFJH(5)]
		public ContainerEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[BJIPCIEBFJH(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D750", Offset = "0x6C4BD50", VA = "0x186C4D750", Slot = "4")]
		public bool Equals(DEPRECATED_ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[HABILHFCNMN(1)]
public struct HOLODDBGGIJ : KIAMMPFPLDI
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Flags]
	[MGDHFFNJLNP(0, 7)]
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
	[NGGNDCHNGFA(1)]
	public float tubeHeightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[NGGNDCHNGFA(2)]
	public int tubeRingPoints;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[NGGNDCHNGFA(3)]
	public Flags flags;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KBEGIMNGKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F180", Offset = "0x6C4D780", VA = "0x186C4F180")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F280", Offset = "0x6C4D880", VA = "0x186C4F280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool NGPJHBPBHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F200", Offset = "0x6C4D800", VA = "0x186C4F200")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F010", Offset = "0x6C4D610", VA = "0x186C4F010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JMOKLJONOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F100", Offset = "0x6C4D700", VA = "0x186C4F100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F0E0", Offset = "0x6C4D6E0", VA = "0x186C4F0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F090", Offset = "0x6C4D690", VA = "0x186C4F090", Slot = "5")]
	public void EMHFJGFFMPB(ref GIGHIDGOGIA PDNINNPJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F030", Offset = "0x6C4D630", VA = "0x186C4F030", Slot = "4")]
	public void DHDFEGACAHE(ref PMFHDCBANDG NKODOJNBMFJ)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CADHJLBHGHL]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[BJIPCIEBFJH(1)]
		public HOLODDBGGIJ parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CADHJLBHGHL]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[BJIPCIEBFJH(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly HEDMIMHLNEJ<SplinePointPositionData> Default;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x15C4C40", Offset = "0x15C3240", VA = "0x1815C4C40")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct LODHDLIFHEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Entity JLJGNFEPNIK;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[InternalBufferCapacity(8)]
public struct HDDOKOGPICE : ISystemStateBufferElementData, IBufferElementData, IEquatable<HDDOKOGPICE>, HHPHCEALIMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Entity AIMPELPKDNP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity DOAKKPAMMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ED90", Offset = "0x6C4D390", VA = "0x186C4ED90", Slot = "4")]
	public bool Equals(HDDOKOGPICE EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal struct AGLGGPNAHMI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Entity LPBMHDMBDFH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CADHJLBHGHL]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[BJIPCIEBFJH(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[BJIPCIEBFJH(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public static readonly HEDMIMHLNEJ<LocalPoseData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x15C48A0", Offset = "0x15C2EA0", VA = "0x1815C48A0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D120", Offset = "0x6C4B720", VA = "0x186C4D120")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D120", Offset = "0x6C4B720", VA = "0x186C4D120")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class FLJALFAJBNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface HHPHCEALIMN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity CACKOBDMMDL
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
	[CADHJLBHGHL]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[BJIPCIEBFJH(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[BJIPCIEBFJH(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static readonly HEDMIMHLNEJ<OMShapeContainerData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Object", 0)]
	public struct ObjectPolicyV2Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[NGGNDCHNGFA(1)]
		public ObjectPolicyEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[BJIPCIEBFJH(2)]
		public NANOMDBPNDG scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(3)]
		public ObjectPolicyUserConfigurableFlags userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly HEDMIMHLNEJ<ObjectPolicyV2Data> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[PBEGMMHNNPD]
	[JMCBBDDNFGG(9807788745867066359uL, 15168486114979071194uL)]
	[JMCBBDDNFGG(9898405628982320166uL, 2023375009558162791uL)]
	public struct DEPRECATED_ObjectPolicyV1Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[BJIPCIEBFJH(1)]
		public ObjectPolicyEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[BJIPCIEBFJH(2)]
		public NANOMDBPNDG scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(3)]
		public bool isFrozen;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly HEDMIMHLNEJ<DEPRECATED_ObjectPolicyV1Data> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct LICGIDEGMKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public int GEIGFOMNNFC;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MMFLLJMPBFJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public GCHandle HKADOILBGPH;
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct IGOIAKJDHDM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private int KLECNAEGDLO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IIOMOLKAONM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F380", Offset = "0x6C4D980", VA = "0x186C4F380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F370", Offset = "0x6C4D970", VA = "0x186C4F370")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CADHJLBHGHL]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[BJIPCIEBFJH(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct GLIIFIGLFAB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CADHJLBHGHL]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[BJIPCIEBFJH(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly HEDMIMHLNEJ<LocalDeformableScaleData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Container", 0)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[BJIPCIEBFJH(1)]
		[BECCBFAEBJL(0)]
		public GrabbableMode grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[MGDHFFNJLNP(0, 1)]
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
[HABILHFCNMN(1)]
public struct NANOMDBPNDG : KIAMMPFPLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[NGGNDCHNGFA(1)]
	public bool enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[NGGNDCHNGFA(2)]
	public float3 minScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[NGGNDCHNGFA(3)]
	public float3 maxScale;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static readonly HEDMIMHLNEJ<NANOMDBPNDG> EDEKLFBDJFC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C50620", Offset = "0x6C4EC20", VA = "0x186C50620", Slot = "5")]
	public void EMHFJGFFMPB(ref GIGHIDGOGIA PDNINNPJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C505D0", Offset = "0x6C4EBD0", VA = "0x186C505D0", Slot = "4")]
	public void DHDFEGACAHE(ref PMFHDCBANDG NKODOJNBMFJ)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CADHJLBHGHL]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[BJIPCIEBFJH(1)]
		public PrimitiveShapeType shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct CMAIGLPCKJK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public int GEIGFOMNNFC;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface CPKDAEAJPMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICGFHOLNLFB(bool BJEGLJLIMAF);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.TypeVersion(2)]
public struct HIDFLNGFBEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public uint DOBEIKMHFED;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EF80", Offset = "0x6C4D580", VA = "0x186C4EF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct EDADJPNBDDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal struct KEBAOEBOJHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct NIOIAAPFGJN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[DIBAGFOHPFM]
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
public struct BPBMEBBODLG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[BJIPCIEBFJH(1)]
		[BECCBFAEBJL(0)]
		public RenderableColor color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[BJIPCIEBFJH(2)]
		[BECCBFAEBJL(0)]
		public RenderableMaterial material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[BJIPCIEBFJH(3)]
		[BECCBFAEBJL(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(4)]
		public Vector3 uvOffset;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[BECCBFAEBJL(0)]
		[BJIPCIEBFJH(1)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static readonly HEDMIMHLNEJ<PhysicsMaterialData> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[HABILHFCNMN(1)]
public struct EALGDNFPJGP : IComparable<EALGDNFPJGP>, IEquatable<EALGDNFPJGP>, KIAMMPFPLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	[NGGNDCHNGFA(1)]
	public uint nom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	[NGGNDCHNGFA(2)]
	public uint denomMinusOne;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint HNAHMFOBGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C4DA20", Offset = "0x6C4C020", VA = "0x186C4DA20")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DE90", Offset = "0x6C4C490", VA = "0x186C4DE90")]
	public EALGDNFPJGP(int LGIDFINJOJB, int GCAFMBCDIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DE90", Offset = "0x6C4C490", VA = "0x186C4DE90")]
	public EALGDNFPJGP(uint LGIDFINJOJB, uint GCAFMBCDIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DD50", Offset = "0x6C4C350", VA = "0x186C4DD50")]
	public EALGDNFPJGP PGHFCPBAHGE(int BIKMMIGFKEM = 1)
	{
		return default(EALGDNFPJGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DC70", Offset = "0x6C4C270", VA = "0x186C4DC70")]
	public EALGDNFPJGP KMKMDNIDBDP(int BIKMMIGFKEM = 1)
	{
		return default(EALGDNFPJGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DCD0", Offset = "0x6C4C2D0", VA = "0x186C4DCD0")]
	public static EALGDNFPJGP OCDLMAFCGOP(EALGDNFPJGP CNCLMHODMJG, EALGDNFPJGP ECNLMNDOGCG)
	{
		return default(EALGDNFPJGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DAC0", Offset = "0x6C4C0C0", VA = "0x186C4DAC0")]
	private static uint DMJEEJGMLHM(uint LLAFGJINMOA, uint LKIHFBEPDMH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DA30", Offset = "0x6C4C030", VA = "0x186C4DA30", Slot = "4")]
	public int CompareTo(EALGDNFPJGP EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DB60", Offset = "0x6C4C160", VA = "0x186C4DB60", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DDB0", Offset = "0x6C4C3B0", VA = "0x186C4DDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DC00", Offset = "0x6C4C200", VA = "0x186C4DC00", Slot = "5")]
	public bool Equals(EALGDNFPJGP EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DC20", Offset = "0x6C4C220", VA = "0x186C4DC20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DA50", Offset = "0x6C4C050", VA = "0x186C4DA50", Slot = "6")]
	public void DHDFEGACAHE(ref PMFHDCBANDG NKODOJNBMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DAF0", Offset = "0x6C4C0F0", VA = "0x186C4DAF0", Slot = "7")]
	public void EMHFJGFFMPB(ref GIGHIDGOGIA PDNINNPJLDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2301A50", Offset = "0x2300050", VA = "0x182301A50")]
	public static bool MOJFGPLDDKP(EALGDNFPJGP CNCLMHODMJG, EALGDNFPJGP ECNLMNDOGCG)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CADHJLBHGHL]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public ObjectPrefabType prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[PBEGMMHNNPD]
	[JMCBBDDNFGG(15725208981563603541uL, 17017036095303668770uL)]
	[JMCBBDDNFGG(14327281633525910712uL, 2559857777606771911uL)]
	public struct DEPRECATED_RRObjectPrefabV1Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[BJIPCIEBFJH(1)]
		public ObjectPrefabType prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class MCOHGDOLLEC
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C50260", Offset = "0x6C4E860", VA = "0x186C50260")]
	public static bool NBFMNGJLAMM(this ObjectPrefabType LFBJHCMDIAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C501E0", Offset = "0x6C4E7E0", VA = "0x186C501E0")]
	public static string NBCOBOHAMDB(this ObjectPrefabType LFBJHCMDIAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C501C0", Offset = "0x6C4E7C0", VA = "0x186C501C0")]
	public static ObjectType FIHCDMAJGBN(this ObjectPrefabType INKNLFCIIAC)
	{
		return default(ObjectType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C501B0", Offset = "0x6C4E7B0", VA = "0x186C501B0")]
	internal static NOGLPGHPFKN FDFMMMGDLCI(this ObjectType DCBCJOPDBFH)
	{
		return default(NOGLPGHPFKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C50190", Offset = "0x6C4E790", VA = "0x186C50190")]
	internal static NOGLPGHPFKN FDFMMMGDLCI(this ObjectPrefabType INKNLFCIIAC)
	{
		return default(NOGLPGHPFKN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct JHOMGBMJCDD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal struct BEBJJILJIGA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public Entity KFLBOBCOIKK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
	public static BEBJJILJIGA BJIOOOHFEFG(Entity PEKCJMKIHGK)
	{
		return default(BEBJJILJIGA);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CADHJLBHGHL]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[NGGNDCHNGFA(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct LBNBMKPFLED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public float3 DLMLLOOAFDO;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static readonly HEDMIMHLNEJ<LBNBMKPFLED> EDEKLFBDJFC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct GCDDCLMGILF : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CADHJLBHGHL]
	[DJCKHAFPFBB("Container", 0)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[BJIPCIEBFJH(1)]
		[BECCBFAEBJL(0)]
		public ContainerCollisionLayerEnum collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static readonly HEDMIMHLNEJ<ContainerCollisionLayerData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[MGDHFFNJLNP(0, 127)]
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
public static class GIAKLEKCJFO
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public enum GPPJFIBDIOP
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
	public enum BBPHNKEKGJJ
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
	[Cpp2IlInjected.Address(RVA = "0x6C4EC20", Offset = "0x6C4D220", VA = "0x186C4EC20")]
	public static (GPPJFIBDIOP, BBPHNKEKGJJ) PFIENIGFEBH(this ContainerCollisionLayerEnum FKOBHPAJHOO)
	{
		return default((GPPJFIBDIOP, BBPHNKEKGJJ));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct MHELJFJMPGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public Entity MPEICFNBKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public int BIKMMIGFKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public int CPHEGBCGAHF;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CADHJLBHGHL]
	public struct ParentData : IComponentData, HHPHCEALIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[BJIPCIEBFJH(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct CAPIHHPALAF : ISystemStateComponentData, IComponentData, HHPHCEALIMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public Entity HPNLJLJFBFN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity DOAKKPAMMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40")]
	public CAPIHHPALAF(Entity KHJHJOOPMKP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
	public static CAPIHHPALAF BJIOOOHFEFG(Entity PEKCJMKIHGK)
	{
		return default(CAPIHHPALAF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct CLCADPAIPPH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[MGDHFFNJLNP(1000, 8000)]
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
public static class CGDMGJAOHHC
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct EIJOPAKCKOC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[MGDHFFNJLNP(-2, 2)]
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
public struct LLPLHIOIGOC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct GKCHBEMPPED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public uint KFDJCBHOAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public int AMEPEDMEPCE;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA2D850", Offset = "0xA2BE50", VA = "0x180A2D850")]
	public GKCHBEMPPED(uint PPNAIHHMMCA, int DOFPKHKCPOF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public struct IJEHIPCBIKJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[MGDHFFNJLNP(-1, 31)]
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
[HABILHFCNMN(1)]
public struct NLLGCLNFGJN : KIAMMPFPLDI, IEquatable<NLLGCLNFGJN>
{
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly NLLGCLNFGJN MJIPICDIFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[NGGNDCHNGFA(1)]
	public int id;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA47570", Offset = "0xA45B70", VA = "0x180A47570")]
	public NLLGCLNFGJN(int LNHACNHDILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6C50960", Offset = "0x6C4EF60", VA = "0x186C50960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C508D0", Offset = "0x6C4EED0", VA = "0x186C508D0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEE550", Offset = "0x3EECB50", VA = "0x183EEE550", Slot = "6")]
	public bool Equals(NLLGCLNFGJN EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C509D0", Offset = "0x6C4EFD0", VA = "0x186C509D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C508B0", Offset = "0x6C4EEB0", VA = "0x186C508B0", Slot = "5")]
	public void EMHFJGFFMPB(ref GIGHIDGOGIA PDNINNPJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C508A0", Offset = "0x6C4EEA0", VA = "0x186C508A0", Slot = "4")]
	public void DHDFEGACAHE(ref PMFHDCBANDG NKODOJNBMFJ)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CADHJLBHGHL]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		[BJIPCIEBFJH(1)]
		public NLLGCLNFGJN customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct DJGLIIBOHHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public float4x4 HBDOGBNHOBE;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly HEDMIMHLNEJ<DJGLIIBOHHP> EDEKLFBDJFC;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CADHJLBHGHL]
	public struct AuthoredParentData : IComponentData, HHPHCEALIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		[BJIPCIEBFJH(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD40", Offset = "0xBEA340", VA = "0x180BEBD40")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D1B0", Offset = "0x6C4B7B0", VA = "0x186C4D1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public struct AJJDPNMNLJP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[DIBAGFOHPFM]
	public struct SingletonActiveSceneData : ISystemStateComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public Entity scene;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
		public static implicit operator SingletonActiveSceneData(Entity value)
		{
			return default(SingletonActiveSceneData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CADHJLBHGHL]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		[BJIPCIEBFJH(1)]
		public TransformHint transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		[BJIPCIEBFJH(2)]
		public TransformPriority transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CADHJLBHGHL]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		[BJIPCIEBFJH(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		[BJIPCIEBFJH(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[BJIPCIEBFJH(3)]
		public float speed;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public struct ODEOPFELGEC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal struct JIJMJBAJDOA : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CADHJLBHGHL]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		[BJIPCIEBFJH(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		[BJIPCIEBFJH(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public static readonly HEDMIMHLNEJ<AuthoredLocalPoseData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x15C48A0", Offset = "0x15C2EA0", VA = "0x1815C48A0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D120", Offset = "0x6C4B720", VA = "0x186C4D120")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class PLPGLMLKJNI
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[MGDHFFNJLNP(0, 2)]
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
	[CADHJLBHGHL]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		[BJIPCIEBFJH(1)]
		public EShapeType shapeType;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : GCCNFJGECLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C52230", Offset = "0x6C50830", VA = "0x186C52230", Slot = "4")]
		public sealed override void NGALBCBKFHF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class CGEIAIPBIGM : ContainerPropertyBag<OENKFKCIBMC>
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class NFBCGADEGMH : Property<OENKFKCIBMC, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6C50770", Offset = "0x6C4ED70", VA = "0x186C50770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C50730", Offset = "0x6C4ED30", VA = "0x186C50730")]
		public NFBCGADEGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x27F0420", Offset = "0x27EEA20", VA = "0x1827F0420", Slot = "14")]
		public override Rigidbody GetValue(ref OENKFKCIBMC GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x27F0440", Offset = "0x27EEA40", VA = "0x1827F0440", Slot = "15")]
		public override void SetValue(ref OENKFKCIBMC GEAGAOEEJFO, Rigidbody FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D510", Offset = "0x6C4BB10", VA = "0x186C4D510")]
	public CGEIAIPBIGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class ECMBLENGNHO : ContainerPropertyBag<AAKDEJMMFNK>
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private class BPOFIIADNHF : Property<AAKDEJMMFNK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D2C0", Offset = "0x6C4B8C0", VA = "0x186C4D2C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D280", Offset = "0x6C4B880", VA = "0x186C4D280")]
		public BPOFIIADNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x27F0420", Offset = "0x27EEA20", VA = "0x1827F0420", Slot = "14")]
		public override object GetValue(ref AAKDEJMMFNK GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x27F0440", Offset = "0x27EEA40", VA = "0x1827F0440", Slot = "15")]
		public override void SetValue(ref AAKDEJMMFNK GEAGAOEEJFO, object FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DEE0", Offset = "0x6C4C4E0", VA = "0x186C4DEE0")]
	public ECMBLENGNHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class AEFKFFKEJNA : ContainerPropertyBag<NKODOAHJPBE>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	private class LAGCJKFIEPP : Property<NKODOAHJPBE, CMEDKBLEPDC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6C4F980", Offset = "0x6C4DF80", VA = "0x186C4F980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F940", Offset = "0x6C4DF40", VA = "0x186C4F940")]
		public LAGCJKFIEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x27F0420", Offset = "0x27EEA20", VA = "0x1827F0420", Slot = "14")]
		public override CMEDKBLEPDC GetValue(ref NKODOAHJPBE GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x27F0440", Offset = "0x27EEA40", VA = "0x1827F0440", Slot = "15")]
		public override void SetValue(ref NKODOAHJPBE GEAGAOEEJFO, CMEDKBLEPDC FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CF70", Offset = "0x6C4B570", VA = "0x186C4CF70")]
	public AEFKFFKEJNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class CCCHKINOOEA : ContainerPropertyBag<IBAFFAMFDAK>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class FMKMAEKJAGE : Property<IBAFFAMFDAK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6C4E630", Offset = "0x6C4CC30", VA = "0x186C4E630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E5F0", Offset = "0x6C4CBF0", VA = "0x186C4E5F0")]
		public FMKMAEKJAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x27F0420", Offset = "0x27EEA20", VA = "0x1827F0420", Slot = "14")]
		public override object GetValue(ref IBAFFAMFDAK GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x27F0440", Offset = "0x27EEA40", VA = "0x1827F0440", Slot = "15")]
		public override void SetValue(ref IBAFFAMFDAK GEAGAOEEJFO, object FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D3C0", Offset = "0x6C4B9C0", VA = "0x186C4D3C0")]
	public CCCHKINOOEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class MMGIBDKGDGK : ContainerPropertyBag<MEIKLKMFLII>
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private class MKPNMJPENAM : Property<MEIKLKMFLII, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6C502F0", Offset = "0x6C4E8F0", VA = "0x186C502F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C502B0", Offset = "0x6C4E8B0", VA = "0x186C502B0")]
		public MKPNMJPENAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x446DFA0", Offset = "0x446C5A0", VA = "0x18446DFA0", Slot = "14")]
		public override int GetValue(ref MEIKLKMFLII GEAGAOEEJFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C50290", Offset = "0x6C4E890", VA = "0x186C50290", Slot = "15")]
		public override void SetValue(ref MEIKLKMFLII GEAGAOEEJFO, int FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class NFIDBHIFOFL : Property<MEIKLKMFLII, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6C50800", Offset = "0x6C4EE00", VA = "0x186C50800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C507C0", Offset = "0x6C4EDC0", VA = "0x186C507C0")]
		public NFIDBHIFOFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x446E030", Offset = "0x446C630", VA = "0x18446E030", Slot = "14")]
		public override int GetValue(ref MEIKLKMFLII GEAGAOEEJFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C507A0", Offset = "0x6C4EDA0", VA = "0x186C507A0", Slot = "15")]
		public override void SetValue(ref MEIKLKMFLII GEAGAOEEJFO, int FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class BDHMLILKBGF : Property<MEIKLKMFLII, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D250", Offset = "0x6C4B850", VA = "0x186C4D250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D210", Offset = "0x6C4B810", VA = "0x186C4D210")]
		public BDHMLILKBGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D1C0", Offset = "0x6C4B7C0", VA = "0x186C4D1C0", Slot = "14")]
		public override GameObject GetValue(ref MEIKLKMFLII GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D1E0", Offset = "0x6C4B7E0", VA = "0x186C4D1E0", Slot = "15")]
		public override void SetValue(ref MEIKLKMFLII GEAGAOEEJFO, GameObject FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C50320", Offset = "0x6C4E920", VA = "0x186C50320")]
	public MMGIBDKGDGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class ACOIGHHKIPH : ContainerPropertyBag<PFEAOLCCGMB>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class AAGIANBEMBL : Property<PFEAOLCCGMB, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6C4C7C0", Offset = "0x6C4ADC0", VA = "0x186C4C7C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C780", Offset = "0x6C4AD80", VA = "0x186C4C780")]
		public AAGIANBEMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C730", Offset = "0x6C4AD30", VA = "0x186C4C730", Slot = "14")]
		public override SerializableGuid GetValue(ref PFEAOLCCGMB GEAGAOEEJFO)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C760", Offset = "0x6C4AD60", VA = "0x186C4C760", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB GEAGAOEEJFO, SerializableGuid FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private class KPBKJLFMOCJ : Property<PFEAOLCCGMB, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6C4F910", Offset = "0x6C4DF10", VA = "0x186C4F910", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F8D0", Offset = "0x6C4DED0", VA = "0x186C4F8D0")]
		public KPBKJLFMOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F880", Offset = "0x6C4DE80", VA = "0x186C4F880", Slot = "14")]
		public override List<int> GetValue(ref PFEAOLCCGMB GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F8A0", Offset = "0x6C4DEA0", VA = "0x186C4F8A0", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB GEAGAOEEJFO, List<int> FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private class JBKBMMEECIG : Property<PFEAOLCCGMB, List<PFEAOLCCGMB.LDMDCJDIFHB>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6C4F6A0", Offset = "0x6C4DCA0", VA = "0x186C4F6A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F660", Offset = "0x6C4DC60", VA = "0x186C4F660")]
		public JBKBMMEECIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F610", Offset = "0x6C4DC10", VA = "0x186C4F610", Slot = "14")]
		public override List<PFEAOLCCGMB.LDMDCJDIFHB> GetValue(ref PFEAOLCCGMB GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F630", Offset = "0x6C4DC30", VA = "0x186C4F630", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB GEAGAOEEJFO, List<PFEAOLCCGMB.LDMDCJDIFHB> FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class MADFNODEGIB : Property<PFEAOLCCGMB, List<PFEAOLCCGMB.DNFMONHCIOF>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6C50160", Offset = "0x6C4E760", VA = "0x186C50160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6C50120", Offset = "0x6C4E720", VA = "0x186C50120")]
		public MADFNODEGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6C500D0", Offset = "0x6C4E6D0", VA = "0x186C500D0", Slot = "14")]
		public override List<PFEAOLCCGMB.DNFMONHCIOF> GetValue(ref PFEAOLCCGMB GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6C500F0", Offset = "0x6C4E6F0", VA = "0x186C500F0", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB GEAGAOEEJFO, List<PFEAOLCCGMB.DNFMONHCIOF> FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class HGFJMKFNBGN : Property<PFEAOLCCGMB, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6C4EF50", Offset = "0x6C4D550", VA = "0x186C4EF50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EF10", Offset = "0x6C4D510", VA = "0x186C4EF10")]
		public HGFJMKFNBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EEC0", Offset = "0x6C4D4C0", VA = "0x186C4EEC0", Slot = "14")]
		public override GameObject GetValue(ref PFEAOLCCGMB GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EEE0", Offset = "0x6C4D4E0", VA = "0x186C4EEE0", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB GEAGAOEEJFO, GameObject FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class NOLLPFLJAPI : Property<PFEAOLCCGMB, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6C50AB0", Offset = "0x6C4F0B0", VA = "0x186C50AB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C50A70", Offset = "0x6C4F070", VA = "0x186C50A70")]
		public NOLLPFLJAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C50A20", Offset = "0x6C4F020", VA = "0x186C50A20", Slot = "14")]
		public override Light GetValue(ref PFEAOLCCGMB GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C50A40", Offset = "0x6C4F040", VA = "0x186C50A40", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB GEAGAOEEJFO, Light FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	private class ABCEIDJGOEC : Property<PFEAOLCCGMB, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6C4C8F0", Offset = "0x6C4AEF0", VA = "0x186C4C8F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C8B0", Offset = "0x6C4AEB0", VA = "0x186C4C8B0")]
		public ABCEIDJGOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C860", Offset = "0x6C4AE60", VA = "0x186C4C860", Slot = "14")]
		public override Collider GetValue(ref PFEAOLCCGMB GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C880", Offset = "0x6C4AE80", VA = "0x186C4C880", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB GEAGAOEEJFO, Collider FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class GEOIELPMHAD : Property<PFEAOLCCGMB, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6C4EBF0", Offset = "0x6C4D1F0", VA = "0x186C4EBF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EBB0", Offset = "0x6C4D1B0", VA = "0x186C4EBB0")]
		public GEOIELPMHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EB60", Offset = "0x6C4D160", VA = "0x186C4EB60", Slot = "14")]
		public override string GetValue(ref PFEAOLCCGMB GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EB80", Offset = "0x6C4D180", VA = "0x186C4EB80", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB GEAGAOEEJFO, string FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CB90", Offset = "0x6C4B190", VA = "0x186C4CB90")]
	public ACOIGHHKIPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class JBINOIGHBJG : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class OHDAGPCJHMA : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6C50C40", Offset = "0x6C4F240", VA = "0x186C50C40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6C50B50", Offset = "0x6C4F150", VA = "0x186C50B50")]
		public OHDAGPCJHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1B5E860", Offset = "0x1B5CE60", VA = "0x181B5E860", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid GEAGAOEEJFO)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x661DD10", Offset = "0x661C310", VA = "0x18661DD10", Slot = "15")]
		public override void SetValue(ref SerializableGuid GEAGAOEEJFO, Data128 FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F480", Offset = "0x6C4DA80", VA = "0x186C4F480")]
	public JBINOIGHBJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class GBALHPMKCEP : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class LPFKBHIKHLB : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x6C4FF10", Offset = "0x6C4E510", VA = "0x186C4FF10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FE20", Offset = "0x6C4E420", VA = "0x186C4FE20")]
		public LPFKBHIKHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xCA2350", Offset = "0xCA0950", VA = "0x180CA2350", Slot = "14")]
		public override int GetValue(ref Data128 GEAGAOEEJFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E960", Offset = "0x3F8CF60", VA = "0x183F8E960", Slot = "15")]
		public override void SetValue(ref Data128 GEAGAOEEJFO, int FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	private class MPOGDOPGHJG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6C505A0", Offset = "0x6C4EBA0", VA = "0x186C505A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C504B0", Offset = "0x6C4EAB0", VA = "0x186C504B0")]
		public MPOGDOPGHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6620050", Offset = "0x661E650", VA = "0x186620050", Slot = "14")]
		public override int GetValue(ref Data128 GEAGAOEEJFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x44800C0", Offset = "0x447E6C0", VA = "0x1844800C0", Slot = "15")]
		public override void SetValue(ref Data128 GEAGAOEEJFO, int FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class PFDILGMJADM : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6C51010", Offset = "0x6C4F610", VA = "0x186C51010", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C50F20", Offset = "0x6C4F520", VA = "0x186C50F20")]
		public PFDILGMJADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xC2C9C0", Offset = "0xC2AFC0", VA = "0x180C2C9C0", Slot = "14")]
		public override int GetValue(ref Data128 GEAGAOEEJFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6626620", Offset = "0x6624C20", VA = "0x186626620", Slot = "15")]
		public override void SetValue(ref Data128 GEAGAOEEJFO, int FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class HFNKNMNOLOI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6C4EE90", Offset = "0x6C4D490", VA = "0x186C4EE90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EDA0", Offset = "0x6C4D3A0", VA = "0x186C4EDA0")]
		public HFNKNMNOLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x66264B0", Offset = "0x6624AB0", VA = "0x1866264B0", Slot = "14")]
		public override int GetValue(ref Data128 GEAGAOEEJFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x66264C0", Offset = "0x6624AC0", VA = "0x1866264C0", Slot = "15")]
		public override void SetValue(ref Data128 GEAGAOEEJFO, int FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E6E0", Offset = "0x6C4CCE0", VA = "0x186C4E6E0")]
	public GBALHPMKCEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class FELDGDPPDJM : ContainerPropertyBag<PFEAOLCCGMB.LDMDCJDIFHB>
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class KKEDNNGFMOJ : Property<PFEAOLCCGMB.LDMDCJDIFHB, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6C4F850", Offset = "0x6C4DE50", VA = "0x186C4F850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F810", Offset = "0x6C4DE10", VA = "0x186C4F810")]
		public KKEDNNGFMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xF227F0", Offset = "0xF20DF0", VA = "0x180F227F0", Slot = "14")]
		public override Vector3 GetValue(ref PFEAOLCCGMB.LDMDCJDIFHB GEAGAOEEJFO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F7F0", Offset = "0x6C4DDF0", VA = "0x186C4F7F0", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB.LDMDCJDIFHB GEAGAOEEJFO, Vector3 FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class IOAOOKKEJPE : Property<PFEAOLCCGMB.LDMDCJDIFHB, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6C4F450", Offset = "0x6C4DA50", VA = "0x186C4F450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F410", Offset = "0x6C4DA10", VA = "0x186C4F410")]
		public IOAOOKKEJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F3F0", Offset = "0x6C4D9F0", VA = "0x186C4F3F0", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref PFEAOLCCGMB.LDMDCJDIFHB GEAGAOEEJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F400", Offset = "0x6C4DA00", VA = "0x186C4F400", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB.LDMDCJDIFHB GEAGAOEEJFO, List<SerializableGuid> FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E490", Offset = "0x6C4CA90", VA = "0x186C4E490")]
	public FELDGDPPDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class LIICJKOLEHI : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class LCHHJFMPNGH : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6C4FAB0", Offset = "0x6C4E0B0", VA = "0x186C4FAB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FA70", Offset = "0x6C4E070", VA = "0x186C4FA70")]
		public LCHHJFMPNGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2AB0", Offset = "0x6BB10B0", VA = "0x186BB2AB0", Slot = "14")]
		public override float GetValue(ref Vector3 GEAGAOEEJFO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FA60", Offset = "0x6C4E060", VA = "0x186C4FA60", Slot = "15")]
		public override void SetValue(ref Vector3 GEAGAOEEJFO, float FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class FMLFNLCHPCA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x6C4E6B0", Offset = "0x6C4CCB0", VA = "0x186C4E6B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E670", Offset = "0x6C4CC70", VA = "0x186C4E670")]
		public FMLFNLCHPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2250", Offset = "0x6BB0850", VA = "0x186BB2250", Slot = "14")]
		public override float GetValue(ref Vector3 GEAGAOEEJFO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E660", Offset = "0x6C4CC60", VA = "0x186C4E660", Slot = "15")]
		public override void SetValue(ref Vector3 GEAGAOEEJFO, float FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class CFGPIGNBHJM : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D4E0", Offset = "0x6C4BAE0", VA = "0x186C4D4E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D4A0", Offset = "0x6C4BAA0", VA = "0x186C4D4A0")]
		public CFGPIGNBHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xFA5BA0", Offset = "0xFA41A0", VA = "0x180FA5BA0", Slot = "14")]
		public override float GetValue(ref Vector3 GEAGAOEEJFO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D490", Offset = "0x6C4BA90", VA = "0x186C4D490", Slot = "15")]
		public override void SetValue(ref Vector3 GEAGAOEEJFO, float FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FBC0", Offset = "0x6C4E1C0", VA = "0x186C4FBC0")]
	public LIICJKOLEHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal class CBLNHNJHPOK : ContainerPropertyBag<PFEAOLCCGMB.DNFMONHCIOF>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class EHHDEBMDFHA : Property<PFEAOLCCGMB.DNFMONHCIOF, PFEAOLCCGMB.LDMDCJDIFHB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6C4E2E0", Offset = "0x6C4C8E0", VA = "0x186C4E2E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E2A0", Offset = "0x6C4C8A0", VA = "0x186C4E2A0")]
		public EHHDEBMDFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x661CBA0", Offset = "0x661B1A0", VA = "0x18661CBA0", Slot = "14")]
		public override PFEAOLCCGMB.LDMDCJDIFHB GetValue(ref PFEAOLCCGMB.DNFMONHCIOF GEAGAOEEJFO)
		{
			return default(PFEAOLCCGMB.LDMDCJDIFHB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E260", Offset = "0x6C4C860", VA = "0x186C4E260", Slot = "15")]
		public override void SetValue(ref PFEAOLCCGMB.DNFMONHCIOF GEAGAOEEJFO, PFEAOLCCGMB.LDMDCJDIFHB FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D2F0", Offset = "0x6C4B8F0", VA = "0x186C4D2F0")]
	public CBLNHNJHPOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal class OLIPDIPHCCH : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class OJDMLIHJOIC : Property<RRObjectPrefabV2Data, ObjectPrefabType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string NHAFHGAJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6C50CB0", Offset = "0x6C4F2B0", VA = "0x186C50CB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool ICHMNNBEJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6C50C70", Offset = "0x6C4F270", VA = "0x186C50C70")]
		public OJDMLIHJOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xCA2350", Offset = "0xCA0950", VA = "0x180CA2350", Slot = "14")]
		public override ObjectPrefabType GetValue(ref RRObjectPrefabV2Data GEAGAOEEJFO)
		{
			return default(ObjectPrefabType);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E960", Offset = "0x3F8CF60", VA = "0x183F8E960", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data GEAGAOEEJFO, ObjectPrefabType FEBHELIDNED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C50CE0", Offset = "0x6C4F2E0", VA = "0x186C50CE0")]
	public OLIPDIPHCCH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C510A0", Offset = "0x6C4F6A0", VA = "0x186C510A0")]
		[RuntimeInitializeOnLoadMethod]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
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

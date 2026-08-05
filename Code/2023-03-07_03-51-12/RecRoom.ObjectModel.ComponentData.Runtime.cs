using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Components;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct PENHFLDCBMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode EGLKBFANDMD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly PENHFLDCBMB OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct DLIPPIPENLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public HCFBDPBEMPC IHEJIMPLCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly DLIPPIPENLK OKLBJLNFLNK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KGPCAMPCEGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BPCJCFEFINJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HCFBDPBEMPC
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Invalid = -1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct JCCINJHCIHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct BHBEEIJILBP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity NEICBHGNPLE;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PLKGCDOPNLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity CNDFBGEJOLI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly PLKGCDOPNLC OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HMPNNFBAFNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity ALLJDBGIIHH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly HMPNNFBAFNG OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NEAGDLJJMAE : IKMGKFNJFNI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NIFOBLJHHEF GONBOMHGDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NIFOBLJHHEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BGNDDHDHDEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3 PFMGHEAKHEN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GNKDHEGNDGF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BENIBOGNCMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3 BEJHLNNAKMK;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly BENIBOGNCMN OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MNMLJCAKJFO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public quaternion MIIDNIGPBLH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly MNMLJCAKJFO OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NJNEHIABPCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 DBBHDGCNJCP;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NJNEHIABPCJ OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NCJEKCILLIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float CDPAONMBAJA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly NCJEKCILLIA OKLBJLNFLNK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OMNCJLIOIAL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GBKIEOCJJEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float IBIBANLMLNC;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly GBKIEOCJJEA OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NAOENDIJOID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float3 JKJKCACHMDF;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BKLJNOONDKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public HIHNKPGEDDE NGANBKDNDFJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly BKLJNOONDKF OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BNBEBOFLMCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HIHNKPGEDDE AOJGKGEIPOI;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly BNBEBOFLMCM OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IJOBBGGAIEO : IKMGKFNJFNI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NIFOBLJHHEF GONBOMHGDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NIFOBLJHHEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LALAMJAPLNJ : IKMGKFNJFNI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NIFOBLJHHEF GONBOMHGDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NIFOBLJHHEF);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IDCGGIENNII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct PADBPIFCMKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NMKFGMGODCN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FBHDLDIDMIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public RigidbodyConstraints FPIDJKEBJEI;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly FBHDLDIDMIB OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct IOEIPMEBCCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float PGKLJIMOLEL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IOEIPMEBCCD OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct NONLCMCGKIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float HEMOAGALFFP;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly NONLCMCGKIP OKLBJLNFLNK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BMHGIKDDNHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MFIAJHKPGIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int NJHEOBDPBHL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MFIAJHKPGIO OKLBJLNFLNK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82A670", Offset = "0x829A70", VA = "0x18082A670")]
	public static MFIAJHKPGIO ABLJGBEPCFM(int FPLJCBGEJAP)
	{
		return default(MFIAJHKPGIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OBIEBPGGFLM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Rigidbody DFDJIBDBDBK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1981420", Offset = "0x1980820", VA = "0x181981420", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public OBIEBPGGFLM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NOKFAINFLBA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct NFBEHOPADBG : IKMGKFNJFNI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NIFOBLJHHEF GONBOMHGDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NIFOBLJHHEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LDODHIOFJDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float HCOJLIDODNN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly LDODHIOFJDE OKLBJLNFLNK;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct KJNANFAKCIO : IKMGKFNJFNI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NIFOBLJHHEF GONBOMHGDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NIFOBLJHHEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IAIJLHFOCAD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public object PODJNOKNKON;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1980B00", Offset = "0x197FF00", VA = "0x181980B00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public IAIJLHFOCAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FKKCKPPKDBK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public object MHCGKIMAEOF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1980A50", Offset = "0x197FE50", VA = "0x181980A50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FKKCKPPKDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum HIHNKPGEDDE
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum CJAGCCPNBHO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface ENMGKLMFFLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEBJGEDHHIB(HCFBDPBEMPC GJLONDIJOCN, HCFBDPBEMPC HAJFBLJEELF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHBIHICHPME();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMLGGMHGOEL();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEMMOGJEFHM(bool IADBGGBPGCE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PPEJNLOLNLN();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KBGHDCFNHOM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public ENMGKLMFFLD ELFAMKLNMNA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1980FB0", Offset = "0x19803B0", VA = "0x181980FB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public KBGHDCFNHOM()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[IEHEJCCOBAI(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, JAADDGFLGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1980170", Offset = "0x197F570", VA = "0x181980170", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[IEHEJCCOBAI(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CMDBCGMDFMJ(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[CMDBCGMDFMJ(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x19801E0", Offset = "0x197F5E0", VA = "0x1819801E0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1980200", Offset = "0x197F600", VA = "0x181980200")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[IEHEJCCOBAI(1)]
	public struct AuthoredParentData : IComponentData, JAADDGFLGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[CMDBCGMDFMJ(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1980230", Offset = "0x197F630", VA = "0x181980230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct MNGLDFJNAEC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct PHBKBJJGFLG : ISystemStateComponentData, IComponentData, JAADDGFLGJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity PLFCHHOLKCP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity HGBLLMLJIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FFMKAEJDGKM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct BNAIGBHANBK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int CPILGALONLA;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NEPMLAKOPPD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public GCHandle CFOBPIADCIA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[IEHEJCCOBAI(1)]
	[JJCMNFAAIBJ(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[CMDBCGMDFMJ(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[CMDBCGMDFMJ(2)]
		public SerializableGuid graphId;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
[NGOPNIOPFEH(0, 15)]
public enum CKLGMDMGHHI
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	All = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[NGOPNIOPFEH(0, 2)]
public enum PNEFCINAGOM
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[HHKDKJIEHJC("Container", 0)]
	[IEHEJCCOBAI(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(1)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HBJCOBAKLGK]
		[CMDBCGMDFMJ(2)]
		[BJAPGCKDMBD(0)]
		public PNEFCINAGOM collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HBJCOBAKLGK]
		[CMDBCGMDFMJ(3)]
		[BJAPGCKDMBD(0)]
		public CKLGMDMGHHI collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[HBJCOBAKLGK]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(4)]
		public EGKDCKEJNDC grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[HBJCOBAKLGK]
		[CMDBCGMDFMJ(5)]
		[BJAPGCKDMBD(0)]
		public CNMJOKONFPK flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[HBJCOBAKLGK]
		[CMDBCGMDFMJ(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x19805B0", Offset = "0x197F9B0", VA = "0x1819805B0", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Flags]
[NGOPNIOPFEH(0, 16071)]
public enum CNMJOKONFPK
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	IsGrabbable = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	All = 0x3EC7,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	MAX = 0x3EC7
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[NGOPNIOPFEH(0, 1)]
public enum EGKDCKEJNDC
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[JJCMNFAAIBJ(1)]
public struct DFIEAKMCLGJ : IComparable<DFIEAKMCLGJ>, IEquatable<DFIEAKMCLGJ>, HDLMEPPPPDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[LFNDKJBLFGG(1)]
	public uint PBIOJKHLNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[LFNDKJBLFGG(2)]
	public uint LMGKDPPFKDH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private uint CFJEFKLIHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x19808D0", Offset = "0x197FCD0", VA = "0x1819808D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x19809C0", Offset = "0x197FDC0", VA = "0x1819809C0")]
	public DFIEAKMCLGJ(int PBIOJKHLNAF, int LHNELBCMDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x19809C0", Offset = "0x197FDC0", VA = "0x1819809C0")]
	public DFIEAKMCLGJ(uint PBIOJKHLNAF, uint LHNELBCMDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1980700", Offset = "0x197FB00", VA = "0x181980700")]
	private static uint APDNPGCCPOM(uint KEPOHMNFLGL, uint CFEKEMJOJGA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1980730", Offset = "0x197FB30", VA = "0x181980730", Slot = "4")]
	public int CompareTo(DFIEAKMCLGJ FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x19807F0", Offset = "0x197FBF0", VA = "0x1819807F0", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x19808E0", Offset = "0x197FCE0", VA = "0x1819808E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x19807D0", Offset = "0x197FBD0", VA = "0x1819807D0", Slot = "5")]
	public bool Equals(DFIEAKMCLGJ FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1980880", Offset = "0x197FC80", VA = "0x181980880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1980750", Offset = "0x197FB50", VA = "0x181980750", Slot = "6")]
	public void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1980690", Offset = "0x197FA90", VA = "0x181980690", Slot = "7")]
	public void AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1652BE0", Offset = "0x1651FE0", VA = "0x181652BE0")]
	public static bool OACFLELFBPC(DFIEAKMCLGJ COMOCJDHDGL, DFIEAKMCLGJ APKFNCAIFAF)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[JJCMNFAAIBJ(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[LFNDKJBLFGG(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[LFNDKJBLFGG(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[LFNDKJBLFGG(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[LFNDKJBLFGG(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[JJCMNFAAIBJ(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, HDLMEPPPPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[LFNDKJBLFGG(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x78E450", Offset = "0x78D850", VA = "0x18078E450")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x78E450", Offset = "0x78D850", VA = "0x18078E450")]
		public static SerializableGuid ABLJGBEPCFM(Guid CFOLAEKFCNI)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1981820", Offset = "0x1980C20", VA = "0x181981820", Slot = "4")]
		public bool Equals(SerializableGuid FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1981700", Offset = "0x1980B00", VA = "0x181981700", Slot = "5")]
		public int CompareTo(SerializableGuid FJLHJLAMLMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1981720", Offset = "0x1980B20", VA = "0x181981720", Slot = "6")]
		public void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1981680", Offset = "0x1980A80", VA = "0x181981680", Slot = "7")]
		public void AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x19818B0", Offset = "0x1980CB0", VA = "0x1819818B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[IEHEJCCOBAI(1)]
	[FHNEMADLICK("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[IEHEJCCOBAI(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[CMDBCGMDFMJ(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[CMDBCGMDFMJ(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[NGOPNIOPFEH(0, 4)]
public enum COHKEJMMIKI
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MAX = 4
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[IEHEJCCOBAI(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[CMDBCGMDFMJ(1)]
		public COHKEJMMIKI gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[IEHEJCCOBAI(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[CMDBCGMDFMJ(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[CMDBCGMDFMJ(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[CMDBCGMDFMJ(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[IEHEJCCOBAI(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[CMDBCGMDFMJ(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[CMDBCGMDFMJ(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[CMDBCGMDFMJ(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[CMDBCGMDFMJ(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[CMDBCGMDFMJ(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[IEHEJCCOBAI(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[CMDBCGMDFMJ(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[CMDBCGMDFMJ(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[CMDBCGMDFMJ(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[IEHEJCCOBAI(1)]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, JAADDGFLGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1980170", Offset = "0x197F570", VA = "0x181980170", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[IEHEJCCOBAI(1)]
	public struct ParentData : IComponentData, JAADDGFLGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[CMDBCGMDFMJ(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct FIFLOEKHLJG : ISystemStateComponentData, IComponentData, JAADDGFLGJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity PLFCHHOLKCP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Entity HGBLLMLJIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990")]
	public FIFLOEKHLJG(Entity CNDFBGEJOLI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	public static FIFLOEKHLJG ABLJGBEPCFM(Entity OOEHGINMJGM)
	{
		return default(FIFLOEKHLJG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct AANLLFDJIJG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JAADDGFLGJN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity KFOGOEMFEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[IEHEJCCOBAI(1)]
	[HHKDKJIEHJC("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[CMDBCGMDFMJ(1)]
		[BJAPGCKDMBD(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[CMDBCGMDFMJ(2)]
		[BJAPGCKDMBD(0)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[HHKDKJIEHJC("Light", 0)]
	[IEHEJCCOBAI(1)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(1)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[IEHEJCCOBAI(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public uint networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1981500", Offset = "0x1980900", VA = "0x181981500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[NGOPNIOPFEH(0, 4)]
public enum HALFHFDOFNN
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	MAX = 4
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct EOGDNFHHDIJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct JPCOCNLBGFO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int CPILGALONLA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct PFPNEJLFFHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct FEOKHEAJLOH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[IEHEJCCOBAI(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[CMDBCGMDFMJ(1)]
		public CKNCKKKBFMK flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[CMDBCGMDFMJ(2)]
		public CBCIKHLOPDF scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(3)]
		public bool isFrozen;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class MJFFJLJDGEA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1981320", Offset = "0x1980720", VA = "0x181981320")]
	public static CKNCKKKBFMK BKCAAEBNAMB(this CKNCKKKBFMK FAPLMCMDPDI, BBFFFLDLEPA CAMCOAGECDC)
	{
		return default(CKNCKKKBFMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1981350", Offset = "0x1980750", VA = "0x181981350")]
	public static CKNCKKKBFMK GAMANBAONBG(this CKNCKKKBFMK FAPLMCMDPDI, BBFFFLDLEPA CAMCOAGECDC)
	{
		return default(CKNCKKKBFMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1981330", Offset = "0x1980730", VA = "0x181981330")]
	public static CKNCKKKBFMK DCDENHAPMPP(this CKNCKKKBFMK FAPLMCMDPDI, BBFFFLDLEPA CAMCOAGECDC, bool KPIHKDBOEID)
	{
		return default(CKNCKKKBFMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1981360", Offset = "0x1980760", VA = "0x181981360")]
	public static bool HKKFLCFAJBC(this CKNCKKKBFMK FAPLMCMDPDI, BBFFFLDLEPA CAMCOAGECDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum BBFFFLDLEPA
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Flags]
[NGOPNIOPFEH(0, 16383)]
public enum CKNCKKKBFMK
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[JJCMNFAAIBJ(1)]
public struct CBCIKHLOPDF : HDLMEPPPPDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[LFNDKJBLFGG(1)]
	public bool KHOMHGNHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[LFNDKJBLFGG(2)]
	public float3 AHHEKOIFGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[LFNDKJBLFGG(3)]
	public float3 OKOOBJFLJBD;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x19802A0", Offset = "0x197F6A0", VA = "0x1819802A0", Slot = "5")]
	public void AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x19803A0", Offset = "0x197F7A0", VA = "0x1819803A0", Slot = "4")]
	public void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[JJCMNFAAIBJ(1)]
public struct JBHHOPMKBJL : HDLMEPPPPDP, IEquatable<JBHHOPMKBJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[LFNDKJBLFGG(1)]
	public int BJKMNBIBKCI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0")]
	public JBHHOPMKBJL(int BJKMNBIBKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1980C90", Offset = "0x1980090", VA = "0x181980C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1980C10", Offset = "0x1980010", VA = "0x181980C10", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82A660", Offset = "0x829A60", VA = "0x18082A660", Slot = "6")]
	public bool Equals(JBHHOPMKBJL FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1295310", Offset = "0x1294710", VA = "0x181295310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1980BB0", Offset = "0x197FFB0", VA = "0x181980BB0", Slot = "5")]
	public void AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1980BE0", Offset = "0x197FFE0", VA = "0x181980BE0", Slot = "4")]
	public void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[IEHEJCCOBAI(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[CMDBCGMDFMJ(1)]
		public JBHHOPMKBJL customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[NGOPNIOPFEH(0, 1)]
public enum DDJDBMCMGGJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	MAX = 1
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[IEHEJCCOBAI(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[CMDBCGMDFMJ(1)]
		public DDJDBMCMGGJ propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct LNOOOMHLAAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct MGPGGOAEHFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct OHPANNODMLF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct NKPMMAHPCDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public FixedString32 LBEPPIIBMPA;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DJMLAPHNFLC]
public struct GNICOCKOKOI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Entity LKJCHBJAPLC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	public static GNICOCKOKOI ABLJGBEPCFM(Entity FPLJCBGEJAP)
	{
		return default(GNICOCKOKOI);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[IEHEJCCOBAI(1)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[CMDBCGMDFMJ(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct NELHLNDHFHE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Entity OOEHGINMJGM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	public static NELHLNDHFHE ABLJGBEPCFM(Entity OOEHGINMJGM)
	{
		return default(NELHLNDHFHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct OIHPIIJJAAL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Entity OEHDKKHFEED;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	public static OIHPIIJJAAL ABLJGBEPCFM(Entity OOEHGINMJGM)
	{
		return default(OIHPIIJJAAL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct JHOMBPNBJEJ : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[IEHEJCCOBAI(1)]
	[HHKDKJIEHJC("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(1)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[IEHEJCCOBAI(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[CMDBCGMDFMJ(1)]
		public LGHJFDELFEL shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[NGOPNIOPFEH(-1, 38)]
public enum LGHJFDELFEL
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MAX_VALUE = 38
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[IEHEJCCOBAI(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[Flags]
		[NGOPNIOPFEH(0, 7)]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			DynamicUVProjection = 1,
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			PreventInvertedCreation = 2,
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			NewBendLogic = 4,
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			MIN = 0,
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			MAX = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[CMDBCGMDFMJ(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1981900", Offset = "0x1980D00", VA = "0x181981900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1981980", Offset = "0x1980D80", VA = "0x181981980")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[NGOPNIOPFEH(0, 2)]
public enum MGOEDEEJBAK
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[IEHEJCCOBAI(1)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[CMDBCGMDFMJ(1)]
		public MGOEDEEJBAK shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[IEHEJCCOBAI(1)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[CMDBCGMDFMJ(1)]
		public DFIEAKMCLGJ order;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[IEHEJCCOBAI(1)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[CMDBCGMDFMJ(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[IEHEJCCOBAI(1)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[CMDBCGMDFMJ(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly SplinePointPositionData Default;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7EFD10", Offset = "0x7EF110", VA = "0x1807EFD10")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[IEHEJCCOBAI(1)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[CMDBCGMDFMJ(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly SplinePointRotationData Default;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x78E450", Offset = "0x78D850", VA = "0x18078E450")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[IEHEJCCOBAI(1)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[CMDBCGMDFMJ(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly SplinePointScaleData Default;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFD10", Offset = "0x7EF110", VA = "0x1807EFD10")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[JJCMNFAAIBJ(1)]
public struct JDCGALHMEJB : HDLMEPPPPDP
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	[NGOPNIOPFEH(0, 7)]
	public enum KELPKECABKD
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[LFNDKJBLFGG(1)]
	public float COCDLFDOMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[LFNDKJBLFGG(2)]
	public int LMKENHKKEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[LFNDKJBLFGG(3)]
	public KELPKECABKD FAPLMCMDPDI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EDAJGKHNLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1980DC0", Offset = "0x19801C0", VA = "0x181980DC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1980EE0", Offset = "0x19802E0", VA = "0x181980EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool PDJLMINKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1980F20", Offset = "0x1980320", VA = "0x181980F20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1980F00", Offset = "0x1980300", VA = "0x181980F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PGOGCHLEIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1980E40", Offset = "0x1980240", VA = "0x181980E40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1980EC0", Offset = "0x19802C0", VA = "0x181980EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1980D00", Offset = "0x1980100", VA = "0x181980D00", Slot = "5")]
	public void AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1980D60", Offset = "0x1980160", VA = "0x181980D60", Slot = "4")]
	public void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[IEHEJCCOBAI(1)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[CMDBCGMDFMJ(1)]
		public JDCGALHMEJB parameters;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct KLBGAHLDLBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LHNPIPBLJIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct CDHMAIPLGON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct JLOFMLPMANM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct CBDNJLBNAHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal struct GKJAAFEALKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct GOAEINGFCLI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal struct EAFHDMLKECA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct IKBPBJIAOOK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EKAHCJOBNPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct KDHDOGMIKBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct EDELGLFAAAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct OIFMOKPGJCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct CEKGLAFIGBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct ONACCOJBNDA : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[IEHEJCCOBAI(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[CMDBCGMDFMJ(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[CMDBCGMDFMJ(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[CMDBCGMDFMJ(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[IEHEJCCOBAI(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[CMDBCGMDFMJ(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CMDBCGMDFMJ(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CMDBCGMDFMJ(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CMDBCGMDFMJ(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CMDBCGMDFMJ(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[CMDBCGMDFMJ(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CMDBCGMDFMJ(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CMDBCGMDFMJ(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CMDBCGMDFMJ(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CMDBCGMDFMJ(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CMDBCGMDFMJ(11)]
		public EFKPAKBOOIK mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CMDBCGMDFMJ(12)]
		public ABPCLFEMPGM myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CMDBCGMDFMJ(13)]
		public GKIINNCKKNE myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CMDBCGMDFMJ(14)]
		public BNHABFHCIGF myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[CMDBCGMDFMJ(15)]
		public NDFCCDKKHOO myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CMDBCGMDFMJ(16)]
		public IACHMLFIMHJ myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CMDBCGMDFMJ(17)]
		public OMJNKKMGGPL myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CMDBCGMDFMJ(18)]
		public DDIHAABKCJM myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CMDBCGMDFMJ(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[CMDBCGMDFMJ(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[CMDBCGMDFMJ(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[CMDBCGMDFMJ(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum EFKPAKBOOIK : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum ABPCLFEMPGM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum GKIINNCKKNE : short
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum BNHABFHCIGF : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum NDFCCDKKHOO
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum IACHMLFIMHJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum OMJNKKMGGPL : long
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum DDIHAABKCJM : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[IEHEJCCOBAI(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[IEHEJCCOBAI(1)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int nonSerialized;
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[IEHEJCCOBAI(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class INHOKENFEBP : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct DDNMMAEIOAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Vector3 ABDMPHFBDJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public List<SerializableGuid> JMDJHPFPLII;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class FELGIJEMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FELGIJEMIFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public INHOKENFEBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DJMLAPHNFLC]
public struct ONMLDABACEI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public TimeData AHNEEFEJHDH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x78E450", Offset = "0x78D850", VA = "0x18078E450")]
	public static ONMLDABACEI ABLJGBEPCFM(TimeData FPLJCBGEJAP)
	{
		return default(ONMLDABACEI);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[IEHEJCCOBAI(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[CMDBCGMDFMJ(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[IEHEJCCOBAI(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[CMDBCGMDFMJ(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[CMDBCGMDFMJ(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x19801E0", Offset = "0x197F5E0", VA = "0x1819801E0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1980200", Offset = "0x197F600", VA = "0x181980200")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1980200", Offset = "0x197F600", VA = "0x181980200")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[IEHEJCCOBAI(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[IEHEJCCOBAI(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x19811F0", Offset = "0x19805F0", VA = "0x1819811F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[IEHEJCCOBAI(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[CMDBCGMDFMJ(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct OEFJJMOOHJE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int MFODCCDKLNO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int GABJOMFFJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1981490", Offset = "0x1980890", VA = "0x181981490")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19814A0", Offset = "0x19808A0", VA = "0x1819814A0")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[IEHEJCCOBAI(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[CMDBCGMDFMJ(1)]
		public BBGNDNFGEGI transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[CMDBCGMDFMJ(2)]
		public FEOGIIAAFKG transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
[NGOPNIOPFEH(0, 1)]
public enum BBGNDNFGEGI
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[NGOPNIOPFEH(-2, 2)]
public enum FEOGIIAAFKG
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[IEHEJCCOBAI(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[IEHEJCCOBAI(1)]
	public struct WorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly WorldPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1981BC0", Offset = "0x1980FC0", VA = "0x181981BC0")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[IEHEJCCOBAI(1)]
	public struct WorldUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public float worldUniformScale;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public static readonly WorldUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[NGOPNIOPFEH(1000, 8001)]
public enum AGNBDHNLGKL
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	GameObject_Connectable = 7002,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Player = 8000,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Unused = 8001,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	COUNT = 8002,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	MIN = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	MAX = 8001
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal enum EFMFEOHGBNE
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal static class GFJFJFDPLLL
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[IEHEJCCOBAI(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[CMDBCGMDFMJ(1)]
		public AGNBDHNLGKL prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class CBJHBDDMLEH
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1980590", Offset = "0x197F990", VA = "0x181980590")]
	public static bool OAJCFBMLPOF(this AGNBDHNLGKL BKGBGEHNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1980510", Offset = "0x197F910", VA = "0x181980510")]
	public static string LBDCFLMFOKA(this AGNBDHNLGKL BKGBGEHNCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x19804C0", Offset = "0x197F8C0", VA = "0x1819804C0")]
	public static EMEBICHCNIH ABIPMKBCDCC(this AGNBDHNLGKL LDKBJDPJMKG)
	{
		return default(EMEBICHCNIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x19804E0", Offset = "0x197F8E0", VA = "0x1819804E0")]
	internal static EFMFEOHGBNE FMMCPKLIHOK(this EMEBICHCNIH FDKMFKPFJOM)
	{
		return default(EFMFEOHGBNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x19804F0", Offset = "0x197F8F0", VA = "0x1819804F0")]
	internal static EFMFEOHGBNE FMMCPKLIHOK(this AGNBDHNLGKL LDKBJDPJMKG)
	{
		return default(EFMFEOHGBNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[NGOPNIOPFEH(0, 9)]
public enum EMEBICHCNIH
{
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	MAX = 9
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[IEHEJCCOBAI(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[CMDBCGMDFMJ(1)]
		public EMEBICHCNIH objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class JNKIDHBGHEM
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1980FA0", Offset = "0x19803A0", VA = "0x181980FA0")]
	public static bool PEOKIGAIDHE(this EMEBICHCNIH FDKMFKPFJOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[NGOPNIOPFEH(int.MinValue, int.MaxValue)]
public enum ABKIOCAMCDA
{
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[NGOPNIOPFEH(-1, 31)]
public enum OPFAMALHLPA
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Default = 0
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[HHKDKJIEHJC("Visual", 0)]
	[IEHEJCCOBAI(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(1)]
		public ABKIOCAMCDA color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(2)]
		public OPFAMALHLPA material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		[CMDBCGMDFMJ(3)]
		[BJAPGCKDMBD(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		[BJAPGCKDMBD(0)]
		[CMDBCGMDFMJ(4)]
		public Vector3 uvOffset;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[Preserve]
	internal class _RRAssemblyIndex : AOMBDDGFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1981F10", Offset = "0x1981310", VA = "0x181981F10", Slot = "4")]
		public sealed override void IPAAHMOMIKO()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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

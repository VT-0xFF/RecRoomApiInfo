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
public struct NEENNFHOGGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode NDNMPGDEEHP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly NEENNFHOGGF MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct MNNCEFECDCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public CEFLALGDCIE LCHBEBFJGPP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly MNNCEFECDCD MKNJDLGIAOG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BILAOLDCBDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OPKMDLCFNGM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CEFLALGDCIE
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
public struct LPFOALEJFGH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct MMKPOMLOLNF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity IMDKOHMGEGA;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DLFBNOKPKBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity LFAIGCEGCPL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly DLFBNOKPKBC MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LLNBIIKNEIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity COMPFMNMPEI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly LLNBIIKNEIJ MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OOADEDOKLOJ : FEHJDGBIBFC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GMLHAACHBKL NCHIEACOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GMLHAACHBKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AEJGDNAMLJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3 HGJNFBEOBMB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KLOOHOMKJMA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JIJBADJOGIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3 CGEGKNKGPFM;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly JIJBADJOGIO MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JOEJMIAFIFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public quaternion LGNJCDPNHAP;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly JOEJMIAFIFE MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JDMLIIAJBHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 KDBLJOCPCPM;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JDMLIIAJBHN MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AOLGDHGENHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float BCCFBPPIBNF;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly AOLGDHGENHL MKNJDLGIAOG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HGCKHJBHBOF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CINHIPIKIBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float MNOFKHGJHAL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly CINHIPIKIBO MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct POEHOBDAEAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float3 KKHPEDMDNHD;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FKEHEAMCNPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public MGONBPIMIEF BKKPLIKBIMJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly FKEHEAMCNPI MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EMGCDFLNBDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MGONBPIMIEF CIJLPNNDDFG;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly EMGCDFLNBDL MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MPLAECHOBPI : FEHJDGBIBFC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public GMLHAACHBKL NCHIEACOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GMLHAACHBKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AMNJAHKIGJJ : FEHJDGBIBFC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GMLHAACHBKL NCHIEACOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GMLHAACHBKL);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IGJJMCGGBOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct IPCKMBFDDJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KMFKGDLOIIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct EHOCBLCDNKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public RigidbodyConstraints ILIMCMHHIEN;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly EHOCBLCDNKH MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JPCAADMAFAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float CHHDLHAEMBC;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JPCAADMAFAD MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct KCGIAJMMCLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float ELGKPJENLOI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KCGIAJMMCLL MKNJDLGIAOG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DAGMJNLFFHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct AFOKGPPEBPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int HHNNDCDGJHA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly AFOKGPPEBPN MKNJDLGIAOG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85A260", Offset = "0x858C60", VA = "0x18085A260")]
	public static AFOKGPPEBPN DGKBAOBECFH(int MAKFNMHIJIF)
	{
		return default(AFOKGPPEBPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DHGACIIADNG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Rigidbody CCLEKJNADLB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9FA0", Offset = "0x5FC89A0", VA = "0x185FC9FA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public DHGACIIADNG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct LMDHAFJGMHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct FLHDEMJJLMD : FEHJDGBIBFC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GMLHAACHBKL NCHIEACOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GMLHAACHBKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct NOMAMFEPBAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float JBGGBKDLDAD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly NOMAMFEPBAF MKNJDLGIAOG;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BDFMJFCAPKN : FEHJDGBIBFC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GMLHAACHBKL NCHIEACOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GMLHAACHBKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class APACPBNNGHA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public object LDDEEHJKFNB;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9AD0", Offset = "0x5FC84D0", VA = "0x185FC9AD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public APACPBNNGHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HHINAGHGBAA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public object NADOMFBGHGD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA0E0", Offset = "0x5FC8AE0", VA = "0x185FCA0E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public HHINAGHGBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum MGONBPIMIEF
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum CKHEJONCKGK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IAEKLBCNHIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADGNAFGAAEA(CEFLALGDCIE HPKJNHPLCPI, CEFLALGDCIE FBLLAOEFGAF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNKIHCFNJJA();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKINNNDBIAE();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKDHIFCLEOH(bool HBGILCDGAGC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FAKDMJMODLG();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GOHDJONDEKA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public IAEKLBCNHIG HPKDIDLHPFH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA070", Offset = "0x5FC8A70", VA = "0x185FCA070", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public GOHDJONDEKA()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[InternalBufferCapacity(8)]
	[JGBDPINIJKE(1)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, CGCOJDLBGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F4B0", Offset = "0x3A9DEB0", VA = "0x183A9F4B0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[JGBDPINIJKE(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[AOEJMFPFNLA(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[AOEJMFPFNLA(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1E24870", Offset = "0x1E23270", VA = "0x181E24870")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9BA0", Offset = "0x5FC85A0", VA = "0x185FC9BA0")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[JGBDPINIJKE(1)]
	public struct AuthoredParentData : IComponentData, CGCOJDLBGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[AOEJMFPFNLA(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9BD0", Offset = "0x5FC85D0", VA = "0x185FC9BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EFOALCEOGCA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct OAGDIIKIAEI : ISystemStateComponentData, IComponentData, CGCOJDLBGDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity LPKNCDBAGGK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity CGOCBOJPKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct EBHJKLMPGMD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GNKPBKJDEDC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int NPMIJOEHCCM;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct FHOCMEIPDGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public GCHandle HCIFOCFALCD;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CNOHNABFIOA(1)]
	[JGBDPINIJKE(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[AOEJMFPFNLA(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[AOEJMFPFNLA(2)]
		public SerializableGuid graphId;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
[KMLFCMJIBLH(0, 15)]
public enum MPNNGDKOEBM
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
[KMLFCMJIBLH(0, 2)]
public enum HNDEMGLFIOH
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
	[BBBICGHCCGN("Container", 0)]
	[JGBDPINIJKE(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[AOEJMFPFNLA(1)]
		[KNALJDPGPBH(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HPHIIDHJGLP]
		[AOEJMFPFNLA(2)]
		[KNALJDPGPBH(0)]
		public HNDEMGLFIOH collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HPHIIDHJGLP]
		[AOEJMFPFNLA(3)]
		[KNALJDPGPBH(0)]
		public MPNNGDKOEBM collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[HPHIIDHJGLP]
		[KNALJDPGPBH(0)]
		[AOEJMFPFNLA(4)]
		public PEPPHEAHICB grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[HPHIIDHJGLP]
		[AOEJMFPFNLA(5)]
		[KNALJDPGPBH(0)]
		public OECOGGMFNPJ flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[HPHIIDHJGLP]
		[AOEJMFPFNLA(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9EC0", Offset = "0x5FC88C0", VA = "0x185FC9EC0", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Flags]
[KMLFCMJIBLH(0, 16071)]
public enum OECOGGMFNPJ
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
[KMLFCMJIBLH(0, 1)]
public enum PEPPHEAHICB
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
[CNOHNABFIOA(1)]
public struct JLCJILFNEPI : IComparable<JLCJILFNEPI>, IEquatable<JLCJILFNEPI>, EAGFMBINGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[FOLKMANPFEM(1)]
	public uint ANDLGEJFDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[FOLKMANPFEM(2)]
	public uint FFKHEILHCGJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private uint KPGHPNNCIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA1B0", Offset = "0x5FC8BB0", VA = "0x185FCA1B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA4E0", Offset = "0x5FC8EE0", VA = "0x185FCA4E0")]
	public JLCJILFNEPI(int ANDLGEJFDCM, int DMCELOPHHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA4E0", Offset = "0x5FC8EE0", VA = "0x185FCA4E0")]
	public JLCJILFNEPI(uint ANDLGEJFDCM, uint DMCELOPHHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA3D0", Offset = "0x5FC8DD0", VA = "0x185FCA3D0")]
	private static uint KIAAFLJLGEG(uint IKAMJBDPPHG, uint LKLEFAIICIC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA1C0", Offset = "0x5FC8BC0", VA = "0x185FCA1C0", Slot = "4")]
	public int CompareTo(JLCJILFNEPI OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA1E0", Offset = "0x5FC8BE0", VA = "0x185FCA1E0", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA400", Offset = "0x5FC8E00", VA = "0x185FCA400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA270", Offset = "0x5FC8C70", VA = "0x185FCA270", Slot = "5")]
	public bool Equals(JLCJILFNEPI OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA300", Offset = "0x5FC8D00", VA = "0x185FCA300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA350", Offset = "0x5FC8D50", VA = "0x185FCA350", Slot = "6")]
	public void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA290", Offset = "0x5FC8C90", VA = "0x185FCA290", Slot = "7")]
	public void FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xD832B0", Offset = "0xD81CB0", VA = "0x180D832B0")]
	public static bool GBIPOJBPNDJ(JLCJILFNEPI FFMFLKJEKLP, JLCJILFNEPI PHDGNGLFBBB)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CNOHNABFIOA(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[FOLKMANPFEM(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[FOLKMANPFEM(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[FOLKMANPFEM(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[FOLKMANPFEM(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CNOHNABFIOA(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, EAGFMBINGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[FOLKMANPFEM(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCC670", VA = "0x180CCDC70")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCC670", VA = "0x180CCDC70")]
		public static SerializableGuid DGKBAOBECFH(Guid GDIIAHJOKME)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCAFF0", Offset = "0x5FC99F0", VA = "0x185FCAFF0", Slot = "4")]
		public bool Equals(SerializableGuid OANENNOJEBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FCAFD0", Offset = "0x5FC99D0", VA = "0x185FCAFD0", Slot = "5")]
		public int CompareTo(SerializableGuid OANENNOJEBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB100", Offset = "0x5FC9B00", VA = "0x185FCB100", Slot = "6")]
		public void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB080", Offset = "0x5FC9A80", VA = "0x185FCB080", Slot = "7")]
		public void FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB200", Offset = "0x5FC9C00", VA = "0x185FCB200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[JGBDPINIJKE(1)]
	[HEIFOBIHJDO("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[JGBDPINIJKE(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[AOEJMFPFNLA(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[AOEJMFPFNLA(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[KMLFCMJIBLH(0, 4)]
public enum KHIPNLNOHNH
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
	[JGBDPINIJKE(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[AOEJMFPFNLA(1)]
		public KHIPNLNOHNH gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[JGBDPINIJKE(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[AOEJMFPFNLA(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[AOEJMFPFNLA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[AOEJMFPFNLA(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[JGBDPINIJKE(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[AOEJMFPFNLA(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[AOEJMFPFNLA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[AOEJMFPFNLA(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[AOEJMFPFNLA(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[AOEJMFPFNLA(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[JGBDPINIJKE(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[AOEJMFPFNLA(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[AOEJMFPFNLA(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[AOEJMFPFNLA(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[InternalBufferCapacity(8)]
	[JGBDPINIJKE(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, CGCOJDLBGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F4B0", Offset = "0x3A9DEB0", VA = "0x183A9F4B0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[JGBDPINIJKE(1)]
	public struct ParentData : IComponentData, CGCOJDLBGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[AOEJMFPFNLA(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct EELLNPEINOG : ISystemStateComponentData, IComponentData, CGCOJDLBGDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity LPKNCDBAGGK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Entity CGOCBOJPKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0")]
	public EELLNPEINOG(Entity LFAIGCEGCPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
	public static EELLNPEINOG DGKBAOBECFH(Entity FLADPKIONGF)
	{
		return default(EELLNPEINOG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct DNMGLLIEOCK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface CGCOJDLBGDN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity LHEGNCBACAB
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
	[JGBDPINIJKE(1)]
	[BBBICGHCCGN("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[AOEJMFPFNLA(1)]
		[KNALJDPGPBH(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[KNALJDPGPBH(0)]
		[AOEJMFPFNLA(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[AOEJMFPFNLA(3)]
		[KNALJDPGPBH(0)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[BBBICGHCCGN("Light", 0)]
	[JGBDPINIJKE(1)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[KNALJDPGPBH(0)]
		[AOEJMFPFNLA(1)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[JGBDPINIJKE(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public uint networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5FCAE60", Offset = "0x5FC9860", VA = "0x185FCAE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[KMLFCMJIBLH(0, 4)]
public enum LDDODKCKGCO
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
public struct JDPEHMOPLMI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct JEFFEPCLDAL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int NPMIJOEHCCM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct JDJKCHGJDEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct JHHOHHJIPMJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[JGBDPINIJKE(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[AOEJMFPFNLA(1)]
		public BOGEPPOKNAE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[AOEJMFPFNLA(2)]
		public LPHLKNKEJFB scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class GFGPLNGCBKE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA060", Offset = "0x5FC8A60", VA = "0x185FCA060")]
	public static BOGEPPOKNAE MFMCNFFMIAP(this BOGEPPOKNAE NBBMMINMBNH, HDLNADHIOGE CHCEKBPDNGP)
	{
		return default(BOGEPPOKNAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA010", Offset = "0x5FC8A10", VA = "0x185FCA010")]
	public static BOGEPPOKNAE EMIFMEAGDDE(this BOGEPPOKNAE NBBMMINMBNH, HDLNADHIOGE CHCEKBPDNGP)
	{
		return default(BOGEPPOKNAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA020", Offset = "0x5FC8A20", VA = "0x185FCA020")]
	public static BOGEPPOKNAE KBBKOOAEJFK(this BOGEPPOKNAE NBBMMINMBNH, HDLNADHIOGE CHCEKBPDNGP, bool DBNFCLHCFFP)
	{
		return default(BOGEPPOKNAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA040", Offset = "0x5FC8A40", VA = "0x185FCA040")]
	public static bool LFIKBHCLHHI(this BOGEPPOKNAE NBBMMINMBNH, HDLNADHIOGE CHCEKBPDNGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum HDLNADHIOGE
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Flags]
[KMLFCMJIBLH(0, 16383)]
public enum BOGEPPOKNAE
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[CNOHNABFIOA(1)]
public struct LPHLKNKEJFB : EAGFMBINGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[FOLKMANPFEM(1)]
	public bool CFGMGGHPOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[FOLKMANPFEM(2)]
	public float3 AGOAGCGIEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[FOLKMANPFEM(3)]
	public float3 JFAFAILLJLC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA5F0", Offset = "0x5FC8FF0", VA = "0x185FCA5F0", Slot = "5")]
	public void FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA6F0", Offset = "0x5FC90F0", VA = "0x185FCA6F0", Slot = "4")]
	public void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CNOHNABFIOA(1)]
public struct ALGPAJCFDGK : EAGFMBINGCM, IEquatable<ALGPAJCFDGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[FOLKMANPFEM(1)]
	public int CBBOJGIJLHN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727790", VA = "0x180728D90")]
	public ALGPAJCFDGK(int CBBOJGIJLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FC99F0", Offset = "0x5FC83F0", VA = "0x185FC99F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9940", Offset = "0x5FC8340", VA = "0x185FC9940", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8586A0", Offset = "0x8570A0", VA = "0x1808586A0", Slot = "6")]
	public bool Equals(ALGPAJCFDGK OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x151C470", Offset = "0x151AE70", VA = "0x18151C470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC99C0", Offset = "0x5FC83C0", VA = "0x185FC99C0", Slot = "5")]
	public void FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9A60", Offset = "0x5FC8460", VA = "0x185FC9A60", Slot = "4")]
	public void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[JGBDPINIJKE(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[AOEJMFPFNLA(1)]
		public ALGPAJCFDGK customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[KMLFCMJIBLH(0, 1)]
public enum MMGDPJMPAJM
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	MAX = 1
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[JGBDPINIJKE(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[AOEJMFPFNLA(1)]
		public MMGDPJMPAJM propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct AOKIPFDCMBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct FIFLKLIOGIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct JMNELEPBJOM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct JGBPKLICBOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public FixedString32 NBODBMLPNJA;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[ENKELIFCJJD]
public struct OCBPABNKKIJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Entity FMEDCFLNIMM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
	public static OCBPABNKKIJ DGKBAOBECFH(Entity MAKFNMHIJIF)
	{
		return default(OCBPABNKKIJ);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[JGBDPINIJKE(1)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[AOEJMFPFNLA(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct PLGKGDLBNHN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Entity FLADPKIONGF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
	public static PLGKGDLBNHN DGKBAOBECFH(Entity FLADPKIONGF)
	{
		return default(PLGKGDLBNHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct KONMCEKPCIB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Entity LGMALBCOCGG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
	public static KONMCEKPCIB DGKBAOBECFH(Entity FLADPKIONGF)
	{
		return default(KONMCEKPCIB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct DFGKLFJLCID : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BBBICGHCCGN("Physics", 0)]
	[JGBDPINIJKE(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[AOEJMFPFNLA(1)]
		[KNALJDPGPBH(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[JGBDPINIJKE(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[AOEJMFPFNLA(1)]
		public KFKBMIIJOHI shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[KMLFCMJIBLH(-1, 18)]
public enum KFKBMIIJOHI
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	LegacyWedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	LegacyPyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	COUNT = 19,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	MAX = 18,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	MIN = -1
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[JGBDPINIJKE(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[Flags]
		[KMLFCMJIBLH(0, 7)]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			DynamicUVProjection = 1,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			PreventInvertedCreation = 2,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			NewBendLogic = 4,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			All = 7,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			MIN = 0,
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			MAX = 7
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[AOEJMFPFNLA(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5FCB250", Offset = "0x5FC9C50", VA = "0x185FCB250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5FCB2D0", Offset = "0x5FC9CD0", VA = "0x185FCB2D0")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[KMLFCMJIBLH(0, 2)]
public enum BFECPMCNOPN
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[JGBDPINIJKE(1)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[AOEJMFPFNLA(1)]
		public BFECPMCNOPN shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[JGBDPINIJKE(1)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[AOEJMFPFNLA(1)]
		public JLCJILFNEPI order;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[JGBDPINIJKE(1)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[AOEJMFPFNLA(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[JGBDPINIJKE(1)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[AOEJMFPFNLA(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly SplinePointPositionData Default;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1E24A90", Offset = "0x1E23490", VA = "0x181E24A90")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[JGBDPINIJKE(1)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[AOEJMFPFNLA(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly SplinePointRotationData Default;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCC670", VA = "0x180CCDC70")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[JGBDPINIJKE(1)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[AOEJMFPFNLA(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly SplinePointScaleData Default;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E24A90", Offset = "0x1E23490", VA = "0x181E24A90")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[CNOHNABFIOA(1)]
public struct BKNCABFHGMF : EAGFMBINGCM
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	[KMLFCMJIBLH(0, 7)]
	public enum JABOBBMIKLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[FOLKMANPFEM(1)]
	public float JJOIHEACAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[FOLKMANPFEM(2)]
	public int BKLIBLOODAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[FOLKMANPFEM(3)]
	public JABOBBMIKLF NBBMMINMBNH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool OBCEGAHANBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9E00", Offset = "0x5FC8800", VA = "0x185FC9E00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9BE0", Offset = "0x5FC85E0", VA = "0x185FC9BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MDBBPKMDCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9D80", Offset = "0x5FC8780", VA = "0x185FC9D80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9CE0", Offset = "0x5FC86E0", VA = "0x185FC9CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BEENBIKMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9C00", Offset = "0x5FC8600", VA = "0x185FC9C00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9D60", Offset = "0x5FC8760", VA = "0x185FC9D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9C80", Offset = "0x5FC8680", VA = "0x185FC9C80", Slot = "5")]
	public void FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9D00", Offset = "0x5FC8700", VA = "0x185FC9D00", Slot = "4")]
	public void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[JGBDPINIJKE(1)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[AOEJMFPFNLA(1)]
		public BKNCABFHGMF parameters;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct MCKNIMPIFJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct DJHOCNCBKOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct MEEFKOFGEBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct HBBABJAEPNO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct BDBOCFCINLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal struct MDJOKCOOJPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct IPBDMOILOAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal struct ANMJLMLPDEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct CAKMGCLFGKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EMNIAIJLPNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct HDPCOPJKILI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct NLHGPACJEBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct FNAMAEIFKCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct GFJHEGKNEKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct FFMFDCMBNDA : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[JGBDPINIJKE(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[AOEJMFPFNLA(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[AOEJMFPFNLA(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[AOEJMFPFNLA(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[JGBDPINIJKE(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[AOEJMFPFNLA(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[AOEJMFPFNLA(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[AOEJMFPFNLA(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[AOEJMFPFNLA(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[AOEJMFPFNLA(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[AOEJMFPFNLA(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[AOEJMFPFNLA(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[AOEJMFPFNLA(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[AOEJMFPFNLA(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[AOEJMFPFNLA(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[AOEJMFPFNLA(11)]
		public NDBFCOLAAPB mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[AOEJMFPFNLA(12)]
		public PAEKECPBCDO myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[AOEJMFPFNLA(13)]
		public DJMDGLGEJLH myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[AOEJMFPFNLA(14)]
		public MJNGMJNBJCJ myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[AOEJMFPFNLA(15)]
		public OJDIOHFIKND myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[AOEJMFPFNLA(16)]
		public DFDOIEHGDMO myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[AOEJMFPFNLA(17)]
		public OHPCOHELPHG myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[AOEJMFPFNLA(18)]
		public OIICBLOLNBJ myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[AOEJMFPFNLA(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[AOEJMFPFNLA(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[AOEJMFPFNLA(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[AOEJMFPFNLA(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum NDBFCOLAAPB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum PAEKECPBCDO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum DJMDGLGEJLH : short
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum MJNGMJNBJCJ : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum OJDIOHFIKND
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum DFDOIEHGDMO : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum OHPCOHELPHG : long
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum OIICBLOLNBJ : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[JGBDPINIJKE(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[JGBDPINIJKE(1)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int nonSerialized;
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[JGBDPINIJKE(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class PBANGEEAADK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct GGPDKAJNFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector3 LEJNBECFMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public List<SerializableGuid> AKMDNBDAHHD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class KBCJCLMFMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public KBCJCLMFMFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public PBANGEEAADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ENKELIFCJJD]
public struct FNOJDNDPFPD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public TimeData BPPPFJGDDBP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCC670", VA = "0x180CCDC70")]
	public static FNOJDNDPFPD DGKBAOBECFH(TimeData MAKFNMHIJIF)
	{
		return default(FNOJDNDPFPD);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[JGBDPINIJKE(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[AOEJMFPFNLA(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[JGBDPINIJKE(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[AOEJMFPFNLA(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[AOEJMFPFNLA(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E24870", Offset = "0x1E23270", VA = "0x181E24870")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9BA0", Offset = "0x5FC85A0", VA = "0x185FC9BA0")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9BA0", Offset = "0x5FC85A0", VA = "0x185FC9BA0")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[JGBDPINIJKE(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[JGBDPINIJKE(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA9A0", Offset = "0x5FC93A0", VA = "0x185FCA9A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[JGBDPINIJKE(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[AOEJMFPFNLA(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct LBEPJEEIEEG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int OENCDCKKPJI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int EBBLFLFCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA5D0", Offset = "0x5FC8FD0", VA = "0x185FCA5D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA5E0", Offset = "0x5FC8FE0", VA = "0x185FCA5E0")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[JGBDPINIJKE(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[AOEJMFPFNLA(1)]
		public EFHPOLOALMB transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[AOEJMFPFNLA(2)]
		public MBHBKENMOHM transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
[KMLFCMJIBLH(0, 1)]
public enum EFHPOLOALMB
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[KMLFCMJIBLH(-2, 2)]
public enum MBHBKENMOHM
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MAX = 2
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[JGBDPINIJKE(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[JGBDPINIJKE(1)]
	public struct WorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly WorldPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB510", Offset = "0x5FC9F10", VA = "0x185FCB510")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[JGBDPINIJKE(1)]
	public struct WorldUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public float worldUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly WorldUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[KMLFCMJIBLH(1000, 8001)]
public enum HLEPLICHNKK
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	GameObject_Connectable = 7002,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Player = 8000,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Unused = 8001,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	COUNT = 8002,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	MIN = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	MAX = 8001
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal enum KIFAHMHKCNP
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal static class NGBJFBIDNCI
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[JGBDPINIJKE(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[AOEJMFPFNLA(1)]
		public HLEPLICHNKK prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class MFGPCDFCMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FCACF0", Offset = "0x5FC96F0", VA = "0x185FCACF0")]
	public static bool KDLEBFNCLKD(this HLEPLICHNKK MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCAD10", Offset = "0x5FC9710", VA = "0x185FCAD10")]
	public static string MHCHBKFLKKI(this HLEPLICHNKK MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCACD0", Offset = "0x5FC96D0", VA = "0x185FCACD0")]
	public static ODOBGKDOFKD GBHFENEHOGG(this HLEPLICHNKK IGDDGFIHFCA)
	{
		return default(ODOBGKDOFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCACC0", Offset = "0x5FC96C0", VA = "0x185FCACC0")]
	internal static KIFAHMHKCNP BILNOLNOFAB(this ODOBGKDOFKD OHIFCFJILKH)
	{
		return default(KIFAHMHKCNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCACA0", Offset = "0x5FC96A0", VA = "0x185FCACA0")]
	internal static KIFAHMHKCNP BILNOLNOFAB(this HLEPLICHNKK IGDDGFIHFCA)
	{
		return default(KIFAHMHKCNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[KMLFCMJIBLH(0, 9)]
public enum ODOBGKDOFKD
{
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	MAX = 9
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[JGBDPINIJKE(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[AOEJMFPFNLA(1)]
		public ODOBGKDOFKD objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class ABJKPMLNMHP
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9930", Offset = "0x5FC8330", VA = "0x185FC9930")]
	public static bool AONLFIJKBJP(this ODOBGKDOFKD OHIFCFJILKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[KMLFCMJIBLH(int.MinValue, int.MaxValue)]
public enum JNEJGOPIMPI
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[KMLFCMJIBLH(-1, 31)]
public enum KDFAOHLHAKP
{
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	Default = 0
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[BBBICGHCCGN("Visual", 0)]
	[JGBDPINIJKE(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[KNALJDPGPBH(0)]
		[AOEJMFPFNLA(1)]
		public JNEJGOPIMPI color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[KNALJDPGPBH(0)]
		[AOEJMFPFNLA(2)]
		public KDFAOHLHAKP material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[AOEJMFPFNLA(3)]
		[KNALJDPGPBH(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[KNALJDPGPBH(0)]
		[AOEJMFPFNLA(4)]
		public Vector3 uvOffset;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[Preserve]
	internal class _RRAssemblyIndex : AHAHNEIKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB860", Offset = "0x5FCA260", VA = "0x185FCB860", Slot = "4")]
		public sealed override void GBDHAHIIBFE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
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

		[Cpp2IlInjected.Token(Token = "0x400021A")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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

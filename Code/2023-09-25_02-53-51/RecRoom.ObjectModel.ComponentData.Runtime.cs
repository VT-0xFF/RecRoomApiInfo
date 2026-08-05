using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
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
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JABDKIFKFIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode EKDOOMPMEKM;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LMFJIMCCJHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public OJEJFFJPFHH LMLJDEAMGMC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly EDFBLELCCFE<LMFJIMCCJHC> DFAIJMEJABN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DINKHCDCAMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GBCHCOEHIPN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OJEJFFJPFHH
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Invalid = -1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HNNNAEPGBHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct OCPLFFJHNHD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity PPNMHLJNNKC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JDHBGEPLFNH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity DCLCDDGJKIC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MFOJHEADFNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EFFCNMNNAHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity JMNDOLBKAMN;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LOEHFBCMKLI : AKJDOCOCMOM, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MPCGNBAKMOK GPOHNIKAKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(MPCGNBAKMOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BABFEBBGPFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 JFEDIJMIENI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IECHHKPIGIC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LFKMOFNNPMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 NALIPBLIBJK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly EDFBLELCCFE<LGLLHKDLCOL> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LGLLHKDLCOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 NALIPBLIBJK;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly EDFBLELCCFE<LGLLHKDLCOL> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct INKEOJGPAKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 GFNDKMCNOLL;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OKHCIHCBDMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 MFIKHHJPENP;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EBAMPNJBOHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float FLHGCCEJBEK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EDFBLELCCFE<EBAMPNJBOHM> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DIHEJGGAGDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float AFDMNIGHMED;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly EDFBLELCCFE<DIHEJGGAGDD> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LMJOLKMHGNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 NDJPHAMNFNI;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IMPJJBDIJGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public JJDKBJICEBO JCCGOBCMAPF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LOIPDIHBFBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JJDKBJICEBO NLOIPABJBHJ;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[PLPMKAGKLMA]
public struct JOGLMNJBOLA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity AHNNJNFIHFM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CFKPMPBAJLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct EPFJLEFAGCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GLJLIKCFPKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct EJEEHLPCFOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints CHLBLGJLHDJ;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MNCOOHNJCEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float BBGNOAKCOED;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly EDFBLELCCFE<MNCOOHNJCEM> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HCCAKAIADLA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float BIIEOCAJMLN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct OIBCFBKLJIO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct FIIOGKJHPKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int CPMIKLNPAMD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xBD40E0", Offset = "0xBD34E0", VA = "0x180BD40E0")]
	public static FIIOGKJHPKC DLNOOKJDMMJ(int LPCGJALKADL)
	{
		return default(FIIOGKJHPKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GNOKNAGDDEJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody DKNAEDLPCJA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D827A0", Offset = "0x5D81BA0", VA = "0x185D827A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public GNOKNAGDDEJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct MHNCCLPNCNP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct FBOMIPHKLDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float BHGMAPEPNPP;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly EDFBLELCCFE<FBOMIPHKLDN> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DOBNFKINGLB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public object IFOKDICLJKK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D81A30", Offset = "0x5D80E30", VA = "0x185D81A30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public DOBNFKINGLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AOLGMKKMBEA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public object BGKHPDFPBJH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D80E80", Offset = "0x5D80280", VA = "0x185D80E80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public AOLGMKKMBEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum JJDKBJICEBO
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum LHMMHIJEJEH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EOMJBFBJHKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAKPEMINCNN(OJEJFFJPFHH ICFFEKPCFNB, OJEJFFJPFHH EEOPBEIAHMC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIFMKCLBFIF();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIEINDCLKOL();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLGOLFFLAAE(bool FGLLJKDIGGN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FNOEGGCIOLL();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHNINHPNJPA();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EJBPJMMFNGJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EOMJBFBJHKL PJKIONOKIFN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D81C50", Offset = "0x5D81050", VA = "0x185D81C50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public EJBPJMMFNGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IGJIJOJNBCP
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly List<(NPCOHFDIHDL nameHash, HOFAJMHGPOB stableTypeHash, Type type)> DKNLHENMDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly List<(NPCOHFDIHDL nameHash, HOFAJMHGPOB stableTypeHash, Type type)> MMIMFGMIADH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(NPCOHFDIHDL previousNameHash, HOFAJMHGPOB previousStableTypeHash, Type currentTypeName)> JOPECLAIENJ;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, KMPHIOOOMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D80FB0", Offset = "0x5D803B0", VA = "0x185D80FB0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
[LJNHLKBKPLC]
public struct BCKADNEGCAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[LDBEPADCEPH(1)]
	public quaternion ALNLHNLOHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[LDBEPADCEPH(2)]
	public float3 EDOEDBAJLGN;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly EDFBLELCCFE<BCKADNEGCAC> DFAIJMEJABN;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38ABC60", Offset = "0x38AB060", VA = "0x1838ABC60")]
	public BCKADNEGCAC(quaternion ALNLHNLOHOA, float3 EDOEDBAJLGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D80FD0", Offset = "0x5D803D0", VA = "0x185D80FD0")]
	public static BCKADNEGCAC DLNOOKJDMMJ(RigidTransform BLHLKIADHCI)
	{
		return default(BCKADNEGCAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class MELHKLOEPCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct CNMCJMOMOIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[LDBEPADCEPH(1)]
	public float CBLNFJJIPNH;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly EDFBLELCCFE<CNMCJMOMOIM> DFAIJMEJABN;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[LJNHLKBKPLC]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, KMPHIOOOMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[LDBEPADCEPH(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D80FC0", Offset = "0x5D803C0", VA = "0x185D80FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct HNHJOMCPKFI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, KMPHIOOOMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct PGPMMIIJBJA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct DBBMMELOINJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int JNIFDEFBBOF;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MIFDFLCNCKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public GCHandle MFCIMIDBMDP;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct BCGFIGGPKKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[LDBEPADCEPH(1)]
	public SerializableGuid CNCFOBBIEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[LDBEPADCEPH(2)]
	public SerializableGuid OFLFFIGFOIA;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FMKBPPGJGLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity FDILHOBLHCD;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct MDODANHOEAN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity FDILHOBLHCD;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[HPPKKFEODPC("Container", 0)]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[LJNHLKBKPLC]
public struct PBNNEOGGDLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[LDBEPADCEPH(1)]
	[MKJCDFGJBKG(0)]
	public GIPDCNOKOFM NOIHOGLAIJL;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly EDFBLELCCFE<PBNNEOGGDLO> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[LAEHHBKHLHN(0, 127)]
public enum GIPDCNOKOFM
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HPKCCJOLKON
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum KHJGHCKCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum HPCIPDMCNKA
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D82C90", Offset = "0x5D82090", VA = "0x185D82C90")]
	public static (KHJGHCKCMKN, HPCIPDMCNKA) KGDHICKKMCP(this GIPDCNOKOFM GCJEHMDFLNP)
	{
		return default((KHJGHCKCMKN, HPCIPDMCNKA));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[HPPKKFEODPC("Container", 0)]
public struct KPBKEHJCKKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[MKJCDFGJBKG(0)]
	[LDBEPADCEPH(1)]
	public JCINPLFGCIG KGIKLOFHJCB;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly EDFBLELCCFE<KPBKEHJCKKA> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[LAEHHBKHLHN(0, 2)]
public enum JCINPLFGCIG
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[HPPKKFEODPC("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[LJNHLKBKPLC]
public struct ADGEOGFCGOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[MKJCDFGJBKG(0)]
	[LDBEPADCEPH(1)]
	public KLIANFEEIOH PLINNFIDOFF;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Flags]
[LAEHHBKHLHN(0, 15943)]
public enum KLIANFEEIOH
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	MAX = 0x3E47
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct GJAFKDPOOOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct KOKDFEGELCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct LEMPGGBKCHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct IFLAPGPGEKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct JKKIBDMIBCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BNBLEADIELE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct LAKEODNDHNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct PIOBNBEEAGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct ICGFOKHLODH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[HPPKKFEODPC("Container", 0)]
public struct DHHILKLJEEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[LDBEPADCEPH(1)]
	[MKJCDFGJBKG(0)]
	public float ICKLDLHGKGP;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[LJNHLKBKPLC]
[HPPKKFEODPC("Container", 0)]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
public struct DFEKDELANAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[LDBEPADCEPH(1)]
	[MKJCDFGJBKG(0)]
	public FixedString64Bytes DKFEAPHKBMP;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct GPEGLENBLNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<NIGMGKHOBML> ALDIHCKBCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<Entity> ONDGEICIKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JobHandle HDIPEJPBMFJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PJPBOLEMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D82990", Offset = "0x5D81D90", VA = "0x185D82990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D82A00", Offset = "0x5D81E00", VA = "0x185D82A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x432DE90", Offset = "0x432D290", VA = "0x18432DE90")]
	public GPEGLENBLNP(NativeList<NIGMGKHOBML> ALDIHCKBCEP, NativeList<Entity> ONDGEICIKCI, JobHandle HDIPEJPBMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D82810", Offset = "0x5D81C10", VA = "0x185D82810")]
	public (Entity, NativeSlice<Entity>) CMMNBGBEDAI(int PBOOCHALMNO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D82930", Offset = "0x5D81D30", VA = "0x185D82930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct NIGMGKHOBML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity JMNDOLBKAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int POBHOBNPPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int FADEBHLHEEP;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface KECPHEPKDGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PABKEAIFIEG(bool HLBLIGNGLNP);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[LJNHLKBKPLC]
[HPPKKFEODPC("Container", 0)]
public struct NJLKMOPJHJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[LDBEPADCEPH(1)]
	[MKJCDFGJBKG(0)]
	public MLHANPINLIJ DMECPGABCMP;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[LAEHHBKHLHN(0, 1)]
public enum MLHANPINLIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[EAAGPKNOBMP(1)]
public struct KIEGJAEKKEG : IComparable<KIEGJAEKKEG>, IEquatable<KIEGJAEKKEG>, GJJMNANPJKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[BNNBHLDLPGP(1)]
	public uint LACCMKDGBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[BNNBHLDLPGP(2)]
	public uint MIIAJHFLBJA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint LACLPBPHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D86510", Offset = "0x5D85910", VA = "0x185D86510")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D86850", Offset = "0x5D85C50", VA = "0x185D86850")]
	public KIEGJAEKKEG(int LACCMKDGBEH, int ABEEFIBIAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D86850", Offset = "0x5D85C50", VA = "0x185D86850")]
	public KIEGJAEKKEG(uint LACCMKDGBEH, uint ABEEFIBIAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D86700", Offset = "0x5D85B00", VA = "0x185D86700")]
	public KIEGJAEKKEG NNFBPFLOBPG(int POBHOBNPPIN = 1)
	{
		return default(KIEGJAEKKEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D863D0", Offset = "0x5D857D0", VA = "0x185D863D0")]
	public KIEGJAEKKEG CKONCHONCFB(int POBHOBNPPIN = 1)
	{
		return default(KIEGJAEKKEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D86520", Offset = "0x5D85920", VA = "0x185D86520")]
	public static KIEGJAEKKEG GHBMJOLGCGL(KIEGJAEKKEG AHKCLAHHIPP, KIEGJAEKKEG MHLPFPGAPOG)
	{
		return default(KIEGJAEKKEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D86660", Offset = "0x5D85A60", VA = "0x185D86660")]
	private static uint JANOHHLECDB(uint BOGGCLFEFDJ, uint OGHJEHJOFGN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D86440", Offset = "0x5D85840", VA = "0x185D86440", Slot = "4")]
	public int CompareTo(KIEGJAEKKEG KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D86480", Offset = "0x5D85880", VA = "0x185D86480", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D86770", Offset = "0x5D85B70", VA = "0x185D86770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D86460", Offset = "0x5D85860", VA = "0x185D86460", Slot = "5")]
	public bool Equals(KIEGJAEKKEG KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D865A0", Offset = "0x5D859A0", VA = "0x185D865A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D86690", Offset = "0x5D85A90", VA = "0x185D86690", Slot = "6")]
	public void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D865F0", Offset = "0x5D859F0", VA = "0x185D865F0", Slot = "7")]
	public void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x238D1F0", Offset = "0x238C5F0", VA = "0x18238D1F0")]
	public static bool HCMKGGFOPFL(KIEGJAEKKEG AHKCLAHHIPP, KIEGJAEKKEG MHLPFPGAPOG)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[EAAGPKNOBMP(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[BNNBHLDLPGP(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[BNNBHLDLPGP(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[BNNBHLDLPGP(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[BNNBHLDLPGP(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[EAAGPKNOBMP(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, GJJMNANPJKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[BNNBHLDLPGP(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0")]
		public static SerializableGuid DLNOOKJDMMJ(Guid HILDEDLDEPK)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D8A220", Offset = "0x5D89620", VA = "0x185D8A220", Slot = "4")]
		public bool Equals(SerializableGuid KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D8A200", Offset = "0x5D89600", VA = "0x185D8A200", Slot = "5")]
		public int CompareTo(SerializableGuid KEEHOGPOIFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D8A2D0", Offset = "0x5D896D0", VA = "0x185D8A2D0", Slot = "6")]
		public void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5D8A250", Offset = "0x5D89650", VA = "0x185D8A250", Slot = "7")]
		public void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D8A390", Offset = "0x5D89790", VA = "0x185D8A390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct ELPJEOHAOJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct JPAGCAPGNMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[LDBEPADCEPH(1)]
	public Entity ADOGMMPMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[LDBEPADCEPH(2)]
	public bool NANGNMOHLPP;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct KGJBOGKMCEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[LDBEPADCEPH(1)]
	public PGIPCBAJLMP PFDAGEJKGIP;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[LAEHHBKHLHN(0, 4)]
public enum PGIPCBAJLMP
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
[LJNHLKBKPLC]
public struct GJBLJPNEFAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[LDBEPADCEPH(1)]
	public Entity ADOGMMPMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[LDBEPADCEPH(2)]
	public bool MOPJHCLJLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[LDBEPADCEPH(3)]
	public float DDPGJHIGHPJ;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[LJNHLKBKPLC]
public struct BJIIDEFOAAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[LDBEPADCEPH(1)]
	public bool DDLNIHBIJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[LDBEPADCEPH(2)]
	public bool MOPJHCLJLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[LDBEPADCEPH(3)]
	public float MFOKJACCBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[LDBEPADCEPH(4)]
	public float MAKCHOBJLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[LDBEPADCEPH(5)]
	public float NFJOIFHGCKE;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
[LJNHLKBKPLC]
public struct PHKDIKHNCOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[LDBEPADCEPH(1)]
	public bool DDLNIHBIJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[LDBEPADCEPH(2)]
	public bool MOPJHCLJLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[LDBEPADCEPH(3)]
	public float DDPGJHIGHPJ;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, KMPHIOOOMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D80FB0", Offset = "0x5D803B0", VA = "0x185D80FB0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[LJNHLKBKPLC]
	public struct ParentData : IComponentData, KMPHIOOOMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[LDBEPADCEPH(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, KMPHIOOOMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct HJNKEOEKKOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface KMPHIOOOMFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Entity EKDNLCACBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct ANACKEPIBFM<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly bool ADBIFDDOPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public uint BMLKIBEJMJO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	private static bool CMDIKJPNNDA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
[HPPKKFEODPC("Light", 0)]
public struct HHHGCPDEFEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[LDBEPADCEPH(1)]
	[MKJCDFGJBKG(0)]
	public bool GGJLDJABGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[LDBEPADCEPH(2)]
	[MKJCDFGJBKG(0)]
	public float LBMBDIJAAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[LDBEPADCEPH(3)]
	[MKJCDFGJBKG(0)]
	public float DKFJHNAPKHH;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[HPPKKFEODPC("Light", 0)]
public struct MIOELBGHBAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[LDBEPADCEPH(1)]
	[MKJCDFGJBKG(0)]
	public float KOGGMGCKEFP;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.TypeVersion(2)]
public struct ACNBNJEPOMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public uint JHFLJNJDJMF;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D80D70", Offset = "0x5D80170", VA = "0x185D80D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[LJNHLKBKPLC]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[BNNBHLDLPGP(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[LAEHHBKHLHN(0, 4)]
public enum GHBNOAFIECK
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	MAX = 4
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct JNPGJMICMGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct GPFOGFKMNCN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int JNIFDEFBBOF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct DEEFEDEGKCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct JFOIEELONBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct AFHLKEPOMBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[TypeManager.TypeVersion(3)]
[HPPKKFEODPC("Object", 0)]
public struct NIMLEEDPPHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[LDBEPADCEPH(2)]
	public CGEFKCFJALD CJOEEGOCEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[MKJCDFGJBKG(0)]
	[LDBEPADCEPH(3)]
	public AGMJJKFLOHH FHLFLGKAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[LDBEPADCEPH(5)]
	[MKJCDFGJBKG(0)]
	public PJIHJNCGMAC DPLBONDPGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[BNNBHLDLPGP(4)]
	public BCBOIEPJKPJ PLINNFIDOFF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public static readonly EDFBLELCCFE<NIMLEEDPPHK> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class OACNGAEDBBG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D88B50", Offset = "0x5D87F50", VA = "0x185D88B50")]
	public static void FAJCEJLMNJF(this BCBOIEPJKPJ PLINNFIDOFF, MNDOHIPFFMC JAFBNCHKCIJ, bool FAGLGPEMPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D88B80", Offset = "0x5D87F80", VA = "0x185D88B80")]
	public static bool IJBPLNGPPAK(this BCBOIEPJKPJ PLINNFIDOFF, MNDOHIPFFMC JAFBNCHKCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D88B20", Offset = "0x5D87F20", VA = "0x185D88B20")]
	public static BCBOIEPJKPJ EPGHJKDDMEC(this MNDOHIPFFMC JAFBNCHKCIJ)
	{
		return default(BCBOIEPJKPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D88B30", Offset = "0x5D87F30", VA = "0x185D88B30")]
	public static void FAJCEJLMNJF(this AGMJJKFLOHH PLINNFIDOFF, AGMJJKFLOHH LGHBOELIKLL, bool FAGLGPEMPJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum MNDOHIPFFMC
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
[LAEHHBKHLHN(0, 16383)]
public enum BCBOIEPJKPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[Flags]
[LAEHHBKHLHN(0, 3)]
public enum AGMJJKFLOHH
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MAX = 3
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[IMCBPHJDNJK]
[LAEHHBKHLHN(0, 4)]
public enum PJIHJNCGMAC
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IMCBPHJDNJK : DLNHCMPGJGB
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D85ED0", Offset = "0x5D852D0", VA = "0x185D85ED0", Slot = "7")]
	public override string LEFOCAFCCCD(string BMDIIPBLIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public IMCBPHJDNJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[EAAGPKNOBMP(1)]
public struct CGEFKCFJALD : GJJMNANPJKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[BNNBHLDLPGP(1)]
	public bool GGJLDJABGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[BNNBHLDLPGP(2)]
	public float3 CBEEIPDPGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[BNNBHLDLPGP(3)]
	public float3 DBBEGDDDJNJ;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly EDFBLELCCFE<CGEFKCFJALD> DFAIJMEJABN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D81510", Offset = "0x5D80910", VA = "0x185D81510", Slot = "5")]
	public void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5D81580", Offset = "0x5D80980", VA = "0x185D81580", Slot = "4")]
	public void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[LJNHLKBKPLC]
public struct KAMKIHODJAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[LDBEPADCEPH(1)]
	public OOOKHLEFLPC CFPNKLPCMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public GCHandle CLFOAALEFAI;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[EAAGPKNOBMP(1)]
public struct OOOKHLEFLPC : GJJMNANPJKP, IEquatable<OOOKHLEFLPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[BNNBHLDLPGP(1)]
	public int KOJKDECJOKK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60")]
	public OOOKHLEFLPC(int KOJKDECJOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D88E00", Offset = "0x5D88200", VA = "0x185D88E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D88D80", Offset = "0x5D88180", VA = "0x185D88D80", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF70", Offset = "0x15EF370", VA = "0x1815EFF70", Slot = "6")]
	public bool Equals(OOOKHLEFLPC KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x15FE5D0", Offset = "0x15FD9D0", VA = "0x1815FE5D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D88E60", Offset = "0x5D88260", VA = "0x185D88E60", Slot = "5")]
	public void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D88E80", Offset = "0x5D88280", VA = "0x185D88E80", Slot = "4")]
	public void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
public struct ENOEHDHNJGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[LDBEPADCEPH(1)]
	public IDDFBLEEJOO IBCMKHCPHNP;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[LAEHHBKHLHN(0, 1)]
public enum IDDFBLEEJOO
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	MAX = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct DOHCCNAICHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct LLHPDJOKGPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct ICMCLGJCAJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct DOHJJPEGPMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public FixedString32Bytes DKFEAPHKBMP;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[PLPMKAGKLMA]
public struct ANGKHLKBOND : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Entity KJAEFLADAPH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static ANGKHLKBOND DLNOOKJDMMJ(Entity LPCGJALKADL)
	{
		return default(ANGKHLKBOND);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct DHJNJCBAOOH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[LDBEPADCEPH(1)]
	public Entity JADIOBADCCB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static DHJNJCBAOOH DLNOOKJDMMJ(Entity AHNNJNFIHFM)
	{
		return default(DHJNJCBAOOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct LDNOCNPONFN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Entity AHNNJNFIHFM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static LDNOCNPONFN DLNOOKJDMMJ(Entity AHNNJNFIHFM)
	{
		return default(LDNOCNPONFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct GAMOHIFFAOI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Entity PLHHOPKGEDD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static GAMOHIFFAOI DLNOOKJDMMJ(Entity AHNNJNFIHFM)
	{
		return default(GAMOHIFFAOI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct JPOPPOOAMJG : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[LAEHHBKHLHN(0, 2)]
public enum DFOLKCOBCLF
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[HPPKKFEODPC("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
[LJNHLKBKPLC]
public struct PDCEHDJOHGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[MKJCDFGJBKG(0)]
	[LDBEPADCEPH(1)]
	public float JMNGLFOPHHD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly EDFBLELCCFE<PDCEHDJOHGM> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct DIBFPGJGPCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[LDBEPADCEPH(1)]
	public JHDIEJNPMMJ KBIHHOCHFCF;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[LAEHHBKHLHN(-1, 38)]
public enum JHDIEJNPMMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct OBIKGGNDJAN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Flags]
	[LAEHHBKHLHN(0, 7)]
	public enum FAKKOBNKBNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[LDBEPADCEPH(1)]
	public FAKKOBNKBNF PLINNFIDOFF;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly EDFBLELCCFE<OBIKGGNDJAN> DFAIJMEJABN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DCDFPGFGBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D88BB0", Offset = "0x5D87FB0", VA = "0x185D88BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JPHLEICNMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D88BA0", Offset = "0x5D87FA0", VA = "0x185D88BA0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct LFBCJLFPEPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[LDBEPADCEPH(1)]
	public DFOLKCOBCLF KBIHHOCHFCF;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[EAAGPKNOBMP(1)]
public struct LOAAMPEDBNJ : GJJMNANPJKP
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[LAEHHBKHLHN(0, 7)]
	[Flags]
	public enum BNDMNMODMGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[BNNBHLDLPGP(1)]
	public float NIJBPMOHHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[BNNBHLDLPGP(2)]
	public int GIFOMJFIHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[BNNBHLDLPGP(3)]
	public BNDMNMODMGH PLINNFIDOFF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool AMAFNPEFGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5D87AC0", Offset = "0x5D86EC0", VA = "0x185D87AC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5D879C0", Offset = "0x5D86DC0", VA = "0x185D879C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EGDFMGPHMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5D87AD0", Offset = "0x5D86ED0", VA = "0x185D87AD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D879A0", Offset = "0x5D86DA0", VA = "0x185D879A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool PMGEALKDFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D879E0", Offset = "0x5D86DE0", VA = "0x185D879E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D879F0", Offset = "0x5D86DF0", VA = "0x185D879F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D87A10", Offset = "0x5D86E10", VA = "0x185D87A10", Slot = "5")]
	public void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D87A60", Offset = "0x5D86E60", VA = "0x185D87A60", Slot = "4")]
	public void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[PLPMKAGKLMA]
internal struct EOEJBDFFKPH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Entity EMLMPKDDJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public int JPEMHHILGGG;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[LJNHLKBKPLC]
public struct NDHHNBFLAPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[LDBEPADCEPH(1)]
	public KIEGJAEKKEG CGGPKFNFKEA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static NDHHNBFLAPP DLNOOKJDMMJ(KIEGJAEKKEG LPCGJALKADL)
	{
		return default(NDHHNBFLAPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct JLDGOFKMBDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[LDBEPADCEPH(1)]
	public Entity ALKPGICEAHM;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal struct FMKMGABDEPP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Entity ALKPGICEAHM;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct AECIBMNAFMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[LDBEPADCEPH(1)]
	public float3 EDOEDBAJLGN;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static readonly EDFBLELCCFE<AECIBMNAFMF> DFAIJMEJABN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
	public static AECIBMNAFMF DLNOOKJDMMJ(float3 LPCGJALKADL)
	{
		return default(AECIBMNAFMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
[LJNHLKBKPLC]
public struct GFDMIAGDOFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[LDBEPADCEPH(1)]
	public quaternion ALNLHNLOHOA;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static readonly EDFBLELCCFE<GFDMIAGDOFF> DFAIJMEJABN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0")]
	public static GFDMIAGDOFF DLNOOKJDMMJ(quaternion LPCGJALKADL)
	{
		return default(GFDMIAGDOFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct JOPAFADPKGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[LDBEPADCEPH(1)]
	public float3 EAKOEGCEGDF;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static readonly EDFBLELCCFE<JOPAFADPKGF> DFAIJMEJABN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
	public static JOPAFADPKGF DLNOOKJDMMJ(float3 LPCGJALKADL)
	{
		return default(JOPAFADPKGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct GEJEAEPKOAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[LDBEPADCEPH(1)]
	public LOAAMPEDBNJ OJJNHGGGKOD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct PDIFJNPHLCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct LJIOMBCKNCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public uint BMLKIBEJMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public int KEBPOIAAJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x962380", Offset = "0x961780", VA = "0x180962380")]
	public LJIOMBCKNCF(uint NPAFEJNKGNK, int AJKEPAPGFAC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct CCOLPDKEJLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct LNDCPNKDLGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct CJPABDNNHLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct MAEDGDFFCIF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct GBKNKJIFEHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GKELNEPNOFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct DDHBJPEDLDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct EKIAPAKCNII : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct KFBAJGOFLMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal struct KNOPADIJKAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct DMDKGPBPJPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal struct MCBEHKJGAAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct NCLCGLAKCFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct MPHFNFGPMFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct JAKHKLMCBPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct CDHMGKGLCMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct LECAKLFDDGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal struct HDKPOAIKJEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct EIEPFKLGOMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct CDECKMGGGCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct LBOHDHMBHAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
[LJNHLKBKPLC]
public struct CPJLKDBGPGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[BNNBHLDLPGP(1)]
	public EPPFDODHFHJ KAHINILDCOI;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static readonly EDFBLELCCFE<CPJLKDBGPGF> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public enum EPPFDODHFHJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct LHJDDFFBLAI : IComponentData, IComparable<LHJDDFFBLAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public int FBLLEBCNOOM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x15FE540", Offset = "0x15FD940", VA = "0x1815FE540", Slot = "4")]
	public int CompareTo(LHJDDFFBLAI KEEHOGPOIFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.TypeVersion(2)]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
public struct BIDCHAAGDGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[LDBEPADCEPH(2)]
	public bool AHOIGGIJHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[LDBEPADCEPH(3)]
	public bool CKAAJHLKPAD;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static readonly EDFBLELCCFE<BIDCHAAGDGC> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct OGIIHJHAGLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[LDBEPADCEPH(1)]
	public bool KHFLCPDFPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[LDBEPADCEPH(2)]
	public byte OEJMLOEBOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[LDBEPADCEPH(3)]
	public short GHNIAGPFBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[LDBEPADCEPH(4)]
	public ushort LPBEHMPOAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[LDBEPADCEPH(5)]
	public int BEKAPKBMLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[LDBEPADCEPH(6)]
	public uint FDCEMCCDJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[LDBEPADCEPH(7)]
	public long PNHBJPGAIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[LDBEPADCEPH(8)]
	public ulong LKDBJHOHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[LDBEPADCEPH(9)]
	public float NIKJGAACNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[LDBEPADCEPH(10)]
	public double HBNMBMHAMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[LDBEPADCEPH(11)]
	public BEOIFLOFEOD PKHLNEPDIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[LDBEPADCEPH(12)]
	public PLIHKDLIBLP BNDLKCABMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[LDBEPADCEPH(13)]
	public AMOPHJLNOLH MMJNKDLGNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[LDBEPADCEPH(14)]
	public MOLCPBNLEOD HEGPFLOBNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[LDBEPADCEPH(15)]
	public EDMPKPBCNCH DBGCHBJHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[LDBEPADCEPH(16)]
	public MDJBAELGKAK MNFOGOEPFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[LDBEPADCEPH(17)]
	public PDCIMJBDHPJ MNHBEPCBDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[LDBEPADCEPH(18)]
	public FCDOIDFOBBL DALMIFNFIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[LDBEPADCEPH(20)]
	public Quaternion FDBEHEKDCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[LDBEPADCEPH(22)]
	public Vector3 IFMEDJMJOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[LDBEPADCEPH(23)]
	public Vector4 JJMLDJIAMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[LDBEPADCEPH(40)]
	public Entity FEFDBPIJAON;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public enum BEOIFLOFEOD : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum PLIHKDLIBLP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum AMOPHJLNOLH : short
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public enum MOLCPBNLEOD : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum EDMPKPBCNCH
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum MDJBAELGKAK : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum PDCIMJBDHPJ : long
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum FCDOIDFOBBL : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	[LJNHLKBKPLC]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[LJNHLKBKPLC]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class MHIKFBIMIFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public int KHPJJNGKJGC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public int MGJFAGIENAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public GameObject GHAOKLKOOCA;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public MHIKFBIMIFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class AMLBELHLCHP : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public struct AHFMBLJJKOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public Vector3 LINPBLDHHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public List<SerializableGuid> OIDPHENAMKF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class JNFDPAKBLJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AHFMBLJJKOB CGOKNMFAEJD;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JNFDPAKBLJC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public SerializableGuid ACNDFGNCMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public List<int> EFFIIGAMGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public List<AHFMBLJJKOB> CIOGAFKNCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public List<JNFDPAKBLJC> CINKGDKDDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public GameObject GHAOKLKOOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Light NDBBNPHDAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Collider MHOODELGFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public string HPEDEAJDIJI;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public AMLBELHLCHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[LJNHLKBKPLC]
public struct PKHNNEBJACH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[LDBEPADCEPH(1)]
	public float3 JJODKBKAHHM;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public static readonly EDFBLELCCFE<PKHNNEBJACH> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct JHKAHHLIAHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	[LDBEPADCEPH(1)]
	public quaternion ALNLHNLOHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[LDBEPADCEPH(2)]
	public float3 EDOEDBAJLGN;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public static readonly EDFBLELCCFE<JHKAHHLIAHN> DFAIJMEJABN;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38ABC60", Offset = "0x38AB060", VA = "0x1838ABC60")]
	public JHKAHHLIAHN(quaternion ALNLHNLOHOA, float3 EDOEDBAJLGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D80FD0", Offset = "0x5D803D0", VA = "0x185D80FD0")]
	public static RigidTransform DLNOOKJDMMJ(JHKAHHLIAHN JEEDFBDCNNJ)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D80FD0", Offset = "0x5D803D0", VA = "0x185D80FD0")]
	public static JHKAHHLIAHN DLNOOKJDMMJ(RigidTransform BLHLKIADHCI)
	{
		return default(JHKAHHLIAHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class GMAACEHNGGA
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct NFEPIODLPJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public float4x4 LBBGHCBMOMO;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static readonly EDFBLELCCFE<NFEPIODLPJH> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct JEMPGDCEMGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public float4x4 BFDECFAPKAM;

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public static readonly EDFBLELCCFE<JEMPGDCEMGA> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
[LJNHLKBKPLC]
public struct KMCDAKDJLDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	[LDBEPADCEPH(1)]
	public float CBLNFJJIPNH;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static readonly EDFBLELCCFE<KMCDAKDJLDL> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct OKFNLLOPCFB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int HHCIDMHDEDM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JPEMHHILGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5D88D00", Offset = "0x5D88100", VA = "0x185D88D00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5D88CF0", Offset = "0x5D880F0", VA = "0x185D88CF0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[LJNHLKBKPLC]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct OMCOJBIKEIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[LDBEPADCEPH(1)]
	public JGINCHHGNGI OLBIKMPJOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[LDBEPADCEPH(2)]
	public LKPGPLFEBCE POIGKPMMAHP;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[LAEHHBKHLHN(0, 1)]
[Flags]
public enum JGINCHHGNGI
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[LAEHHBKHLHN(-2, 2)]
public enum LKPGPLFEBCE
{
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public struct BFFJMHOAOGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public float3 KBLJNEAJGDK;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static readonly EDFBLELCCFE<BFFJMHOAOGI> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct NJLFDIIMCKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public float3 BAONBICGOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public quaternion CKFJFCLIANA;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static readonly EDFBLELCCFE<NJLFDIIMCKB> DFAIJMEJABN;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D882B0", Offset = "0x5D876B0", VA = "0x185D882B0")]
	public float3 EBPDODLAAAM(float3 NODMEHJAHII)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class ACGKPPEJGPB
{
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public struct NDPCMDFICAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public float EIBBDGKHAFA;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static readonly EDFBLELCCFE<NDPCMDFICAO> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[LAEHHBKHLHN(1000, 8000)]
public enum HNGHCMBBKEB
{
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	GameObject_Prop = 7002,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class PDAHOPKLHGJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal enum MHAIJGKCNAA
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class BLMOCEJJINK
{
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[LAEHHBKHLHN(0, 9)]
public enum PLMJAAHFMOO
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class ELCMAEPBKHL
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D81CC0", Offset = "0x5D810C0", VA = "0x185D81CC0")]
	public static bool LLGCBHPDFPF(this PLMJAAHFMOO LOCBBBKMLDK)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[LJNHLKBKPLC]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public HNGHCMBBKEB prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class FLCAPNKFKDB
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5D824A0", Offset = "0x5D818A0", VA = "0x185D824A0")]
	public static bool FIAMPGGCLLH(this HNGHCMBBKEB DJMKKNDNCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D824C0", Offset = "0x5D818C0", VA = "0x185D824C0")]
	public static string HPDAAEIGHIE(this HNGHCMBBKEB DJMKKNDNCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D82480", Offset = "0x5D81880", VA = "0x185D82480")]
	public static PLMJAAHFMOO CBFFKDJAICB(this HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(PLMJAAHFMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D82530", Offset = "0x5D81930", VA = "0x185D82530")]
	internal static MHAIJGKCNAA OPDDIPPIAHA(this PLMJAAHFMOO LOCBBBKMLDK)
	{
		return default(MHAIJGKCNAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D82510", Offset = "0x5D81910", VA = "0x185D82510")]
	internal static MHAIJGKCNAA OPDDIPPIAHA(this HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(MHAIJGKCNAA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class KMOAHMLFANL
{
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly Dictionary<HNGHCMBBKEB, string> JLCEILGOJAP;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D86900", Offset = "0x5D85D00", VA = "0x185D86900")]
	public static string MMLODJNFBCC(this HNGHCMBBKEB DJMKKNDNCBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[LAEHHBKHLHN(int.MinValue, int.MaxValue)]
public enum DCIDHALDCEC
{
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[LAEHHBKHLHN(-1, 31)]
public enum LLJDLBGKLMH
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[HPPKKFEODPC("Visual", 0)]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[LJNHLKBKPLC]
public struct NCFDPPIDBLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	[LDBEPADCEPH(1)]
	[MKJCDFGJBKG(0)]
	public DCIDHALDCEC KKBAHNFNJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	[LDBEPADCEPH(2)]
	[MKJCDFGJBKG(0)]
	public LLJDLBGKLMH CFMOAHBPGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	[MKJCDFGJBKG(0)]
	[LDBEPADCEPH(3)]
	public float LAPPFBIDPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	[LDBEPADCEPH(4)]
	[MKJCDFGJBKG(0)]
	public Vector3 BCFCOJEPGKO;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[DOMHMCJBIDO]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[EPKJOJCJFNK(2613756846563002039uL, 6372660366488563574uL)]
[HPPKKFEODPC("Container", 0)]
public struct DOHHABBHHNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	[LDBEPADCEPH(1)]
	[MKJCDFGJBKG(0)]
	public EBKDDJHLEME IPKGDACCECL;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[Flags]
[LAEHHBKHLHN(0, 15)]
public enum EBKDDJHLEME
{
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[EPKJOJCJFNK(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[DOMHMCJBIDO]
public struct FDCHJMJKAJM : IComponentData, IEquatable<FDCHJMJKAJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	[LDBEPADCEPH(1)]
	public FixedString64Bytes DKFEAPHKBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[LDBEPADCEPH(2)]
	public JCINPLFGCIG KGIKLOFHJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[LDBEPADCEPH(3)]
	public EBKDDJHLEME IPKGDACCECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	[LDBEPADCEPH(4)]
	public MLHANPINLIJ DMECPGABCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	[LDBEPADCEPH(5)]
	public KLIANFEEIOH PLINNFIDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[LDBEPADCEPH(6)]
	public float ICKLDLHGKGP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D81F80", Offset = "0x5D81380", VA = "0x185D81F80", Slot = "4")]
	public bool Equals(FDCHJMJKAJM KEEHOGPOIFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[DOMHMCJBIDO]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[EPKJOJCJFNK(218523523639012570uL, 15191719635551116065uL)]
public struct MPEKLHFHCHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private uint GNJFFJKLPBN;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[EPKJOJCJFNK(9898405628982320166uL, 2023375009558162791uL)]
[DOMHMCJBIDO]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
public struct GPICBPKHPPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[LDBEPADCEPH(1)]
	public BCBOIEPJKPJ PLINNFIDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	[LDBEPADCEPH(2)]
	public CGEFKCFJALD CJOEEGOCEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[MKJCDFGJBKG(0)]
	[LDBEPADCEPH(3)]
	public bool CFHOENAMIBG;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly EDFBLELCCFE<GPICBPKHPPP> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[DOMHMCJBIDO]
[EPKJOJCJFNK(9807788745867066359uL, 15168486114979071194uL)]
public struct NNMJJBNOBBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[LDBEPADCEPH(1)]
	public BCBOIEPJKPJ PLINNFIDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[LDBEPADCEPH(2)]
	public CGEFKCFJALD CJOEEGOCEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[MKJCDFGJBKG(0)]
	[LDBEPADCEPH(3)]
	public bool CFHOENAMIBG;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly EDFBLELCCFE<NNMJJBNOBBA> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[EPKJOJCJFNK(4470189027631723570uL, 5922380073816386711uL)]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[DOMHMCJBIDO]
public struct MFMALOPLMGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[BNNBHLDLPGP(1)]
	public BCBOIEPJKPJ PLINNFIDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[LDBEPADCEPH(2)]
	public CGEFKCFJALD CJOEEGOCEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[LDBEPADCEPH(3)]
	[MKJCDFGJBKG(0)]
	public AGMJJKFLOHH FHLFLGKAJCJ;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly EDFBLELCCFE<MFMALOPLMGO> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[DOMHMCJBIDO]
[EPKJOJCJFNK(12226092714547765037uL, 15970362445488810630uL)]
public struct OHFCKCCLMHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[LDBEPADCEPH(2)]
	public CGEFKCFJALD CJOEEGOCEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[LDBEPADCEPH(3)]
	[MKJCDFGJBKG(0)]
	public AGMJJKFLOHH FHLFLGKAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[BNNBHLDLPGP(4)]
	public BCBOIEPJKPJ PLINNFIDOFF;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly EDFBLELCCFE<OHFCKCCLMHB> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[EPKJOJCJFNK(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
[DOMHMCJBIDO]
public struct DJPBNNMNDAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public int LNDCNJIIMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[LDBEPADCEPH(2)]
	public bool AHOIGGIJHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[LDBEPADCEPH(3)]
	public bool CKAAJHLKPAD;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly EDFBLELCCFE<DJPBNNMNDAF> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[DOMHMCJBIDO]
[EPKJOJCJFNK(14327281633525910712uL, 2559857777606771911uL)]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
public struct AAJBENABJJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[LDBEPADCEPH(1)]
	public HNGHCMBBKEB HOAIKLJFCGK;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[DOMHMCJBIDO]
[EPKJOJCJFNK(15725208981563603541uL, 17017036095303668770uL)]
public struct MPLACFMMCHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[LDBEPADCEPH(1)]
	public HNGHCMBBKEB HOAIKLJFCGK;
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[DOMHMCJBIDO]
[EPKJOJCJFNK(1029043735688538310uL, 14256247939851101839uL)]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
public struct EIIGBHPFKGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public PLMJAAHFMOO LOCBBBKMLDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[EPKJOJCJFNK(17667479821163689808uL, 11946378475791123970uL)]
[DOMHMCJBIDO]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
public struct MOILEDNJIDM : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : GHHKFIIHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D8A3A0", Offset = "0x5D897A0", VA = "0x185D8A3A0", Slot = "4")]
		public sealed override void HKGCGLFIJJG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal class BNAEIGKCOEP : ContainerPropertyBag<GNOKNAGDDEJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class OMPMEBPCCJL : Property<GNOKNAGDDEJ, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5D88D50", Offset = "0x5D88150", VA = "0x185D88D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D88D10", Offset = "0x5D88110", VA = "0x185D88D10")]
		public OMPMEBPCCJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CB0", Offset = "0x5D800B0", VA = "0x185D80CB0", Slot = "14")]
		public override Rigidbody GetValue(GNOKNAGDDEJ MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CD0", Offset = "0x5D800D0", VA = "0x185D80CD0", Slot = "15")]
		public override void SetValue(GNOKNAGDDEJ MIPCMNILFEO, Rigidbody LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D81180", Offset = "0x5D80580", VA = "0x185D81180")]
	public BNAEIGKCOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal class JAHJDLPAMHB : ContainerPropertyBag<DOBNFKINGLB>
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	private class ENPAGBPEAHN : Property<DOBNFKINGLB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5D81D10", Offset = "0x5D81110", VA = "0x185D81D10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D81CD0", Offset = "0x5D810D0", VA = "0x185D81CD0")]
		public ENPAGBPEAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CB0", Offset = "0x5D800B0", VA = "0x185D80CB0", Slot = "14")]
		public override object GetValue(DOBNFKINGLB MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CD0", Offset = "0x5D800D0", VA = "0x185D80CD0", Slot = "15")]
		public override void SetValue(DOBNFKINGLB MIPCMNILFEO, object LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D85FA0", Offset = "0x5D853A0", VA = "0x185D85FA0")]
	public JAHJDLPAMHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class LHLPCBMFLON : ContainerPropertyBag<AOLGMKKMBEA>
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class GFIGIBOFJNN : Property<AOLGMKKMBEA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5D826C0", Offset = "0x5D81AC0", VA = "0x185D826C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D82680", Offset = "0x5D81A80", VA = "0x185D82680")]
		public GFIGIBOFJNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CB0", Offset = "0x5D800B0", VA = "0x185D80CB0", Slot = "14")]
		public override object GetValue(AOLGMKKMBEA MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CD0", Offset = "0x5D800D0", VA = "0x185D80CD0", Slot = "15")]
		public override void SetValue(AOLGMKKMBEA MIPCMNILFEO, object LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D87440", Offset = "0x5D86840", VA = "0x185D87440")]
	public LHLPCBMFLON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class BOBHDPHELOP : ContainerPropertyBag<EJBPJMMFNGJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	private class AAGJFPAEPBF : Property<EJBPJMMFNGJ, EOMJBFBJHKL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5D80D40", Offset = "0x5D80140", VA = "0x185D80D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D80D00", Offset = "0x5D80100", VA = "0x185D80D00")]
		public AAGJFPAEPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CB0", Offset = "0x5D800B0", VA = "0x185D80CB0", Slot = "14")]
		public override EOMJBFBJHKL GetValue(EJBPJMMFNGJ MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CD0", Offset = "0x5D800D0", VA = "0x185D80CD0", Slot = "15")]
		public override void SetValue(EJBPJMMFNGJ MIPCMNILFEO, EOMJBFBJHKL LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D81260", Offset = "0x5D80660", VA = "0x185D81260")]
	public BOBHDPHELOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class DECADKCCIML : ContainerPropertyBag<MHIKFBIMIFJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	private class FCJJAOELHFC : Property<MHIKFBIMIFJ, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5D81F50", Offset = "0x5D81350", VA = "0x185D81F50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D81F10", Offset = "0x5D81310", VA = "0x185D81F10")]
		public FCJJAOELHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D81ED0", Offset = "0x5D812D0", VA = "0x185D81ED0", Slot = "14")]
		public override int GetValue(MHIKFBIMIFJ MIPCMNILFEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D81EF0", Offset = "0x5D812F0", VA = "0x185D81EF0", Slot = "15")]
		public override void SetValue(MHIKFBIMIFJ MIPCMNILFEO, int LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class GHHKFEHHCPA : Property<MHIKFBIMIFJ, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5D82770", Offset = "0x5D81B70", VA = "0x185D82770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5D82730", Offset = "0x5D81B30", VA = "0x185D82730")]
		public GHHKFEHHCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D826F0", Offset = "0x5D81AF0", VA = "0x185D826F0", Slot = "14")]
		public override int GetValue(MHIKFBIMIFJ MIPCMNILFEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D82710", Offset = "0x5D81B10", VA = "0x185D82710", Slot = "15")]
		public override void SetValue(MHIKFBIMIFJ MIPCMNILFEO, int LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class FHLPEJPGFKM : Property<MHIKFBIMIFJ, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5D82310", Offset = "0x5D81710", VA = "0x185D82310", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D822D0", Offset = "0x5D816D0", VA = "0x185D822D0")]
		public FHLPEJPGFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D82280", Offset = "0x5D81680", VA = "0x185D82280", Slot = "14")]
		public override GameObject GetValue(MHIKFBIMIFJ MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D822A0", Offset = "0x5D816A0", VA = "0x185D822A0", Slot = "15")]
		public override void SetValue(MHIKFBIMIFJ MIPCMNILFEO, GameObject LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D817C0", Offset = "0x5D80BC0", VA = "0x185D817C0")]
	public DECADKCCIML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class LLDMDBOEBFN : ContainerPropertyBag<AMLBELHLCHP>
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class GBKEIAGOADP : Property<AMLBELHLCHP, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5D825D0", Offset = "0x5D819D0", VA = "0x185D825D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D82590", Offset = "0x5D81990", VA = "0x185D82590")]
		public GBKEIAGOADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D82540", Offset = "0x5D81940", VA = "0x185D82540", Slot = "14")]
		public override SerializableGuid GetValue(AMLBELHLCHP MIPCMNILFEO)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D82570", Offset = "0x5D81970", VA = "0x185D82570", Slot = "15")]
		public override void SetValue(AMLBELHLCHP MIPCMNILFEO, SerializableGuid LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class KBEJPDDAFKG : Property<AMLBELHLCHP, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5D863A0", Offset = "0x5D857A0", VA = "0x185D863A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D86360", Offset = "0x5D85760", VA = "0x185D86360")]
		public KBEJPDDAFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D86310", Offset = "0x5D85710", VA = "0x185D86310", Slot = "14")]
		public override List<int> GetValue(AMLBELHLCHP MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D86330", Offset = "0x5D85730", VA = "0x185D86330", Slot = "15")]
		public override void SetValue(AMLBELHLCHP MIPCMNILFEO, List<int> LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class HLCNOIJOJNB : Property<AMLBELHLCHP, List<AMLBELHLCHP.AHFMBLJJKOB>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5D82C60", Offset = "0x5D82060", VA = "0x185D82C60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D82C20", Offset = "0x5D82020", VA = "0x185D82C20")]
		public HLCNOIJOJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D82BD0", Offset = "0x5D81FD0", VA = "0x185D82BD0", Slot = "14")]
		public override List<AMLBELHLCHP.AHFMBLJJKOB> GetValue(AMLBELHLCHP MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D82BF0", Offset = "0x5D81FF0", VA = "0x185D82BF0", Slot = "15")]
		public override void SetValue(AMLBELHLCHP MIPCMNILFEO, List<AMLBELHLCHP.AHFMBLJJKOB> LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class HPKJPHOKCLL : Property<AMLBELHLCHP, List<AMLBELHLCHP.JNFDPAKBLJC>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5D82E90", Offset = "0x5D82290", VA = "0x185D82E90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D82E50", Offset = "0x5D82250", VA = "0x185D82E50")]
		public HPKJPHOKCLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D82E00", Offset = "0x5D82200", VA = "0x185D82E00", Slot = "14")]
		public override List<AMLBELHLCHP.JNFDPAKBLJC> GetValue(AMLBELHLCHP MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D82E20", Offset = "0x5D82220", VA = "0x185D82E20", Slot = "15")]
		public override void SetValue(AMLBELHLCHP MIPCMNILFEO, List<AMLBELHLCHP.JNFDPAKBLJC> LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class ECBKOBNOPOC : Property<AMLBELHLCHP, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5D81B90", Offset = "0x5D80F90", VA = "0x185D81B90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D81B50", Offset = "0x5D80F50", VA = "0x185D81B50")]
		public ECBKOBNOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D81B00", Offset = "0x5D80F00", VA = "0x185D81B00", Slot = "14")]
		public override GameObject GetValue(AMLBELHLCHP MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D81B20", Offset = "0x5D80F20", VA = "0x185D81B20", Slot = "15")]
		public override void SetValue(AMLBELHLCHP MIPCMNILFEO, GameObject LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class FEMHMEGLAHF : Property<AMLBELHLCHP, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x5D820F0", Offset = "0x5D814F0", VA = "0x185D820F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D820B0", Offset = "0x5D814B0", VA = "0x185D820B0")]
		public FEMHMEGLAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D82060", Offset = "0x5D81460", VA = "0x185D82060", Slot = "14")]
		public override Light GetValue(AMLBELHLCHP MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D82080", Offset = "0x5D81480", VA = "0x185D82080", Slot = "15")]
		public override void SetValue(AMLBELHLCHP MIPCMNILFEO, Light LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class NJICAPKICFC : Property<AMLBELHLCHP, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5D88280", Offset = "0x5D87680", VA = "0x185D88280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D88240", Offset = "0x5D87640", VA = "0x185D88240")]
		public NJICAPKICFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D881F0", Offset = "0x5D875F0", VA = "0x185D881F0", Slot = "14")]
		public override Collider GetValue(AMLBELHLCHP MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D88210", Offset = "0x5D87610", VA = "0x185D88210", Slot = "15")]
		public override void SetValue(AMLBELHLCHP MIPCMNILFEO, Collider LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class APBJANIJODD : Property<AMLBELHLCHP, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5D80F80", Offset = "0x5D80380", VA = "0x185D80F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D80F40", Offset = "0x5D80340", VA = "0x185D80F40")]
		public APBJANIJODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D80EF0", Offset = "0x5D802F0", VA = "0x185D80EF0", Slot = "14")]
		public override string GetValue(AMLBELHLCHP MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D80F10", Offset = "0x5D80310", VA = "0x185D80F10", Slot = "15")]
		public override void SetValue(AMLBELHLCHP MIPCMNILFEO, string LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D87520", Offset = "0x5D86920", VA = "0x185D87520")]
	public LLDMDBOEBFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal class PJHMMJDPEEJ : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class EOBCEKKLDMI : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x5D81E40", Offset = "0x5D81240", VA = "0x185D81E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D81D50", Offset = "0x5D81150", VA = "0x185D81D50")]
		public EOBCEKKLDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD2E1A0", Offset = "0xD2D5A0", VA = "0x180D2E1A0", Slot = "14")]
		public override Data128 GetValue(SerializableGuid MIPCMNILFEO)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D81D40", Offset = "0x5D81140", VA = "0x185D81D40", Slot = "15")]
		public override void SetValue(SerializableGuid MIPCMNILFEO, Data128 LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D89200", Offset = "0x5D88600", VA = "0x185D89200")]
	public PJHMMJDPEEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class NNAJDIAPPFB : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class PHFEBCIMBMJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5D891D0", Offset = "0x5D885D0", VA = "0x185D891D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D890E0", Offset = "0x5D884E0", VA = "0x185D890E0")]
		public PHFEBCIMBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x11E3670", Offset = "0x11E2A70", VA = "0x1811E3670", Slot = "14")]
		public override int GetValue(Data128 MIPCMNILFEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5D86220", Offset = "0x5D85620", VA = "0x185D86220", Slot = "15")]
		public override void SetValue(Data128 MIPCMNILFEO, int LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class FJBJBPHPKPB : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5D82450", Offset = "0x5D81850", VA = "0x185D82450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D82360", Offset = "0x5D81760", VA = "0x185D82360")]
		public FJBJBPHPKPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D82340", Offset = "0x5D81740", VA = "0x185D82340", Slot = "14")]
		public override int GetValue(Data128 MIPCMNILFEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D82350", Offset = "0x5D81750", VA = "0x185D82350", Slot = "15")]
		public override void SetValue(Data128 MIPCMNILFEO, int LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class NHFLKACLAPA : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5D880C0", Offset = "0x5D874C0", VA = "0x185D880C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D87FD0", Offset = "0x5D873D0", VA = "0x185D87FD0")]
		public NHFLKACLAPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1490560", Offset = "0x148F960", VA = "0x181490560", Slot = "14")]
		public override int GetValue(Data128 MIPCMNILFEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D87FC0", Offset = "0x5D873C0", VA = "0x185D87FC0", Slot = "15")]
		public override void SetValue(Data128 MIPCMNILFEO, int LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class CGDJMKJELMG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5D814E0", Offset = "0x5D808E0", VA = "0x185D814E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D813F0", Offset = "0x5D807F0", VA = "0x185D813F0")]
		public CGDJMKJELMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D813D0", Offset = "0x5D807D0", VA = "0x185D813D0", Slot = "14")]
		public override int GetValue(Data128 MIPCMNILFEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D813E0", Offset = "0x5D807E0", VA = "0x185D813E0", Slot = "15")]
		public override void SetValue(Data128 MIPCMNILFEO, int LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D885A0", Offset = "0x5D879A0", VA = "0x185D885A0")]
	public NNAJDIAPPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class FGJHIKAELGH : ContainerPropertyBag<AMLBELHLCHP.AHFMBLJJKOB>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class MJNCGCAEHEO : Property<AMLBELHLCHP.AHFMBLJJKOB, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5D87D10", Offset = "0x5D87110", VA = "0x185D87D10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5D87CD0", Offset = "0x5D870D0", VA = "0x185D87CD0")]
		public MJNCGCAEHEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x845A20", Offset = "0x844E20", VA = "0x180845A20", Slot = "14")]
		public override Vector3 GetValue(AMLBELHLCHP.AHFMBLJJKOB MIPCMNILFEO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D87CB0", Offset = "0x5D870B0", VA = "0x185D87CB0", Slot = "15")]
		public override void SetValue(AMLBELHLCHP.AHFMBLJJKOB MIPCMNILFEO, Vector3 LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class CLMENMNBDLF : Property<AMLBELHLCHP.AHFMBLJJKOB, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5D816D0", Offset = "0x5D80AD0", VA = "0x185D816D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D81690", Offset = "0x5D80A90", VA = "0x185D81690")]
		public CLMENMNBDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D81670", Offset = "0x5D80A70", VA = "0x185D81670", Slot = "14")]
		public override List<SerializableGuid> GetValue(AMLBELHLCHP.AHFMBLJJKOB MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D81680", Offset = "0x5D80A80", VA = "0x185D81680", Slot = "15")]
		public override void SetValue(AMLBELHLCHP.AHFMBLJJKOB MIPCMNILFEO, List<SerializableGuid> LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D82120", Offset = "0x5D81520", VA = "0x185D82120")]
	public FGJHIKAELGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class PFCNINIAAOC : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class CBPJIOJMBKI : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5D813A0", Offset = "0x5D807A0", VA = "0x185D813A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5D81360", Offset = "0x5D80760", VA = "0x185D81360")]
		public CBPJIOJMBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D81340", Offset = "0x5D80740", VA = "0x185D81340", Slot = "14")]
		public override float GetValue(Vector3 MIPCMNILFEO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D81350", Offset = "0x5D80750", VA = "0x185D81350", Slot = "15")]
		public override void SetValue(Vector3 MIPCMNILFEO, float LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class EGAIBGLPGBB : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5D81C20", Offset = "0x5D81020", VA = "0x185D81C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5D81BE0", Offset = "0x5D80FE0", VA = "0x185D81BE0")]
		public EGAIBGLPGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5D81BC0", Offset = "0x5D80FC0", VA = "0x185D81BC0", Slot = "14")]
		public override float GetValue(Vector3 MIPCMNILFEO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D81BD0", Offset = "0x5D80FD0", VA = "0x185D81BD0", Slot = "15")]
		public override void SetValue(Vector3 MIPCMNILFEO, float LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class HDHNOKNHOJO : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5D82BA0", Offset = "0x5D81FA0", VA = "0x185D82BA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5D82B60", Offset = "0x5D81F60", VA = "0x185D82B60")]
		public HDHNOKNHOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x187E6C0", Offset = "0x187DAC0", VA = "0x18187E6C0", Slot = "14")]
		public override float GetValue(Vector3 MIPCMNILFEO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5D82B50", Offset = "0x5D81F50", VA = "0x185D82B50", Slot = "15")]
		public override void SetValue(Vector3 MIPCMNILFEO, float LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D88F40", Offset = "0x5D88340", VA = "0x185D88F40")]
	public PFCNINIAAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal class MPBHNLPMKLM : ContainerPropertyBag<AMLBELHLCHP.JNFDPAKBLJC>
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class LPGJBMAOCEG : Property<AMLBELHLCHP.JNFDPAKBLJC, AMLBELHLCHP.AHFMBLJJKOB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x5D87B90", Offset = "0x5D86F90", VA = "0x185D87B90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5D87B50", Offset = "0x5D86F50", VA = "0x185D87B50")]
		public LPGJBMAOCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5D87AE0", Offset = "0x5D86EE0", VA = "0x185D87AE0", Slot = "14")]
		public override AMLBELHLCHP.AHFMBLJJKOB GetValue(AMLBELHLCHP.JNFDPAKBLJC MIPCMNILFEO)
		{
			return default(AMLBELHLCHP.AHFMBLJJKOB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5D87B10", Offset = "0x5D86F10", VA = "0x185D87B10", Slot = "15")]
		public override void SetValue(AMLBELHLCHP.JNFDPAKBLJC MIPCMNILFEO, AMLBELHLCHP.AHFMBLJJKOB LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D87DA0", Offset = "0x5D871A0", VA = "0x185D87DA0")]
	public MPBHNLPMKLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class PMKIKCEPMHI : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class JOFOIHGCJLH : Property<RRObjectPrefabV2Data, HNGHCMBBKEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x5D86270", Offset = "0x5D85670", VA = "0x185D86270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5D86230", Offset = "0x5D85630", VA = "0x185D86230")]
		public JOFOIHGCJLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x11E3670", Offset = "0x11E2A70", VA = "0x1811E3670", Slot = "14")]
		public override HNGHCMBBKEB GetValue(RRObjectPrefabV2Data MIPCMNILFEO)
		{
			return default(HNGHCMBBKEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5D86220", Offset = "0x5D85620", VA = "0x185D86220", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data MIPCMNILFEO, HNGHCMBBKEB LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D893F0", Offset = "0x5D887F0", VA = "0x185D893F0")]
	public PMKIKCEPMHI()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D894D0", Offset = "0x5D888D0", VA = "0x185D894D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200010D")]
public class FCJMKIHNMJN
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FCJMKIHNMJN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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

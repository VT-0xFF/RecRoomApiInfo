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
public struct NNIJCHHNMEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode ODBBONENPLE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly NNIJCHHNMEM EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct AGEBNMMIEBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public PHOCPPOEDBC FLKPKCEFJEK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly AGEBNMMIEBF EBMJMAANCBN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MCOHMGGCBLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ONGOOLMIAKM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PHOCPPOEDBC
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
public struct BGAAPMJDJPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct EOEMKHEBMAN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity ILLPMKANGKO;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JHKBLGANKPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity GGEKFPEBLKN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly JHKBLGANKPN EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FFHACBMLEMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity EAGPPNPHOBG;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly FFHACBMLEMB EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ODJLKCLLLBM : NIJKBPKBPOC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GELFNNAOOFF PIBPGDOMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GELFNNAOOFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PBIIHPPLGHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3 DDBDFGDEJNG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HFLFCKBIDMI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LAJDKHFEKJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3 LDCILLCEGOA;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly LAJDKHFEKJC EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MMKGOJLEAIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public quaternion JLHJJCGNBIE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly MMKGOJLEAIN EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JLMBEOKAAAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 GMBCHMBJMEK;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JLMBEOKAAAA EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FFAKMJDIHMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float NJAPMMIKJGK;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly FFAKMJDIHMM EBMJMAANCBN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MLCFNIPMLOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ILKOCECPAKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float BJEKPKOHOHD;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly ILKOCECPAKD EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BGECCJPMMDA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float3 OCCIBCJMCMD;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OGNKHCHAGAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public JGBCGHMDEIJ FAACPMLGAIL;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly OGNKHCHAGAJ EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OPBNCGIGLHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public JGBCGHMDEIJ IICFOLDCDCK;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly OPBNCGIGLHN EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NMLPINBEDCF : NIJKBPKBPOC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public GELFNNAOOFF PIBPGDOMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GELFNNAOOFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JACFLKOCHDH : NIJKBPKBPOC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GELFNNAOOFF PIBPGDOMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GELFNNAOOFF);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BOPGOMNCGHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NPCEDAHGOMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JHCHDHICCOI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ECDMIFMOEPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public RigidbodyConstraints JBGLIGODAKH;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly ECDMIFMOEPN EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OPEHCLGAILI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float KJIENHELDBA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly OPEHCLGAILI EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LPEIBMMAMCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float NKICPJKJIPG;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly LPEIBMMAMCD EBMJMAANCBN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FABIFBALALA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GLNHNPPHFPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int IICOFCPBOJK;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly GLNHNPPHFPM EBMJMAANCBN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C20", Offset = "0x8A2620", VA = "0x1808A3C20")]
	public static GLNHNPPHFPM HPHCHABBDNG(int LPJDDLMPNCG)
	{
		return default(GLNHNPPHFPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EHFMOPHHLPO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Rigidbody HKPNCKPHHLB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6932550", Offset = "0x6930F50", VA = "0x186932550", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public EHFMOPHHLPO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct EFAMOJNKNOA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct MEPMOPELKDN : NIJKBPKBPOC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GELFNNAOOFF PIBPGDOMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GELFNNAOOFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct NILHCIFOLHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float GHBILKANCFB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly NILHCIFOLHN EBMJMAANCBN;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct POOAGDAKJNG : NIJKBPKBPOC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GELFNNAOOFF PIBPGDOMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GELFNNAOOFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HAGLCGJBINH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public object KBMJGCNNHMK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6932930", Offset = "0x6931330", VA = "0x186932930", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public HAGLCGJBINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NGMFBFBKLIJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public object GLCMDGIIHOB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69333A0", Offset = "0x6931DA0", VA = "0x1869333A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public NGMFBFBKLIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum JGBCGHMDEIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum GGPABLKNBJB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KDBGLABEDCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFNAHMJFGNN(PHOCPPOEDBC NBPFLJDNNCH, PHOCPPOEDBC ABBGLPJCAMC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBCHKCMKFFL();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LECPOGDAAEN();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHLPAOAPADB(bool DFLJHGHEKJD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KOAJJHHAGFJ();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FEACNFFGFCB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public KDBGLABEDCA IDLCOLGAADE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69325E0", Offset = "0x6930FE0", VA = "0x1869325E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public FEACNFFGFCB()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[EKJLLHCNGAM(1)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, JJCEHBPPLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A110", Offset = "0x3F68B10", VA = "0x183F6A110", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[EKJLLHCNGAM(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CDICCPPKCOO(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[CDICCPPKCOO(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2351EC0", Offset = "0x23508C0", VA = "0x182351EC0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6932210", Offset = "0x6930C10", VA = "0x186932210")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[EKJLLHCNGAM(1)]
	public struct AuthoredParentData : IComponentData, JJCEHBPPLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[CDICCPPKCOO(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6932240", Offset = "0x6930C40", VA = "0x186932240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct IOKCFDFGMOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct OFDDALEFPDF : ISystemStateComponentData, IComponentData, JJCEHBPPLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity POIOLLCGPHC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity ECDAABMOGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct JLLEHMPLIFG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MAFMNDNCKFB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int ENNAKHLEBJN;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EKIHKBOCOAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public GCHandle DKDHMJGJECA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[EKJLLHCNGAM(1)]
	[CBDDLELHGEE(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[CDICCPPKCOO(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[CDICCPPKCOO(2)]
		public SerializableGuid graphId;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
[NPGBCCJHHPF(0, 15)]
public enum BDECFBIKHMO
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
[NPGBCCJHHPF(0, 2)]
public enum EEBJDADPGDI
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
	[DPGGCLGJEJM("Container", 0)]
	[EKJLLHCNGAM(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(1)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[AOEDHKIGNFF]
		[CDICCPPKCOO(2)]
		[LILMMBLFBHF(0)]
		public EEBJDADPGDI collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[AOEDHKIGNFF]
		[CDICCPPKCOO(3)]
		[LILMMBLFBHF(0)]
		public BDECFBIKHMO collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[AOEDHKIGNFF]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(4)]
		public OJEJIHBJLJJ grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[AOEDHKIGNFF]
		[CDICCPPKCOO(5)]
		[LILMMBLFBHF(0)]
		public ILMHKAKENLF flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[AOEDHKIGNFF]
		[CDICCPPKCOO(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6932470", Offset = "0x6930E70", VA = "0x186932470", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Flags]
[NPGBCCJHHPF(0, 16071)]
public enum ILMHKAKENLF
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
[NPGBCCJHHPF(0, 1)]
public enum OJEJIHBJLJJ
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
[CBDDLELHGEE(1)]
public struct HMDNAIPHAAE : IComparable<HMDNAIPHAAE>, IEquatable<HMDNAIPHAAE>, HLLCIEEAKDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[EAPAPGKGHMN(1)]
	public uint KJOJHHKBJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[EAPAPGKGHMN(2)]
	public uint IBIMMGIDDKB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private uint CEALEGEOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6932A70", Offset = "0x6931470", VA = "0x186932A70")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6932CD0", Offset = "0x69316D0", VA = "0x186932CD0")]
	public HMDNAIPHAAE(int KJOJHHKBJMB, int GAJMMJMIOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6932CD0", Offset = "0x69316D0", VA = "0x186932CD0")]
	public HMDNAIPHAAE(uint KJOJHHKBJMB, uint GAJMMJMIOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6932AD0", Offset = "0x69314D0", VA = "0x186932AD0")]
	private static uint HFMGCAHAHCB(uint HFOFADIOHHP, uint GFCGIJPPCBN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69329A0", Offset = "0x69313A0", VA = "0x1869329A0", Slot = "4")]
	public int CompareTo(HMDNAIPHAAE MPHACEGLFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69329E0", Offset = "0x69313E0", VA = "0x1869329E0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6932BF0", Offset = "0x69315F0", VA = "0x186932BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69329C0", Offset = "0x69313C0", VA = "0x1869329C0", Slot = "5")]
	public bool Equals(HMDNAIPHAAE MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6932A80", Offset = "0x6931480", VA = "0x186932A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6932B00", Offset = "0x6931500", VA = "0x186932B00", Slot = "6")]
	public void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6932B80", Offset = "0x6931580", VA = "0x186932B80", Slot = "7")]
	public void JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xCCC090", Offset = "0xCCAA90", VA = "0x180CCC090")]
	public static bool BOBJELOEACN(HMDNAIPHAAE LJLKLAFAGNO, HMDNAIPHAAE HFBAHIGFPIF)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CBDDLELHGEE(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[EAPAPGKGHMN(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[EAPAPGKGHMN(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[EAPAPGKGHMN(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[EAPAPGKGHMN(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CBDDLELHGEE(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, HLLCIEEAKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[EAPAPGKGHMN(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xC32FD0", Offset = "0xC319D0", VA = "0x180C32FD0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC32FD0", Offset = "0xC319D0", VA = "0x180C32FD0")]
		public static SerializableGuid HPHCHABBDNG(Guid NPIFLODGAHD)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69337D0", Offset = "0x69321D0", VA = "0x1869337D0", Slot = "4")]
		public bool Equals(SerializableGuid MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x69337B0", Offset = "0x69321B0", VA = "0x1869337B0", Slot = "5")]
		public int CompareTo(SerializableGuid MPHACEGLFIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6933860", Offset = "0x6932260", VA = "0x186933860", Slot = "6")]
		public void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6933960", Offset = "0x6932360", VA = "0x186933960", Slot = "7")]
		public void JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x69339E0", Offset = "0x69323E0", VA = "0x1869339E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[EKJLLHCNGAM(1)]
	[OFAKJNIAKOO("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[EKJLLHCNGAM(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[CDICCPPKCOO(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[CDICCPPKCOO(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[NPGBCCJHHPF(0, 4)]
public enum ECHOKHJACKM
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
	[EKJLLHCNGAM(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[CDICCPPKCOO(1)]
		public ECHOKHJACKM gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[EKJLLHCNGAM(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[CDICCPPKCOO(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[CDICCPPKCOO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[CDICCPPKCOO(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[EKJLLHCNGAM(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[CDICCPPKCOO(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[CDICCPPKCOO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[CDICCPPKCOO(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[CDICCPPKCOO(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[CDICCPPKCOO(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[EKJLLHCNGAM(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[CDICCPPKCOO(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[CDICCPPKCOO(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[CDICCPPKCOO(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[EKJLLHCNGAM(1)]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, JJCEHBPPLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A110", Offset = "0x3F68B10", VA = "0x183F6A110", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[EKJLLHCNGAM(1)]
	public struct ParentData : IComponentData, JJCEHBPPLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[CDICCPPKCOO(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct KLGHMJKGANI : ISystemStateComponentData, IComponentData, JJCEHBPPLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity POIOLLCGPHC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Entity ECDAABMOGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x775F40", Offset = "0x774940", VA = "0x180775F40")]
	public KLGHMJKGANI(Entity GGEKFPEBLKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	public static KLGHMJKGANI HPHCHABBDNG(Entity LCLDFKAJPDK)
	{
		return default(KLGHMJKGANI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct BGCCCKOCKHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JJCEHBPPLLO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity PBIJGMNGOLA
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
	[EKJLLHCNGAM(1)]
	[DPGGCLGJEJM("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[CDICCPPKCOO(1)]
		[LILMMBLFBHF(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[CDICCPPKCOO(2)]
		[LILMMBLFBHF(0)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[DPGGCLGJEJM("Light", 0)]
	[EKJLLHCNGAM(1)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(1)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[EKJLLHCNGAM(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public uint networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6933630", Offset = "0x6932030", VA = "0x186933630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[NPGBCCJHHPF(0, 4)]
public enum NAOLIHBBMIF
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
public struct NGPLPBCNPIA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HBPACDHDPOG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int ENNAKHLEBJN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct AKNLNNJHMFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct FIAAPFIFKGI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[EKJLLHCNGAM(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[CDICCPPKCOO(1)]
		public GGAHGICMACJ flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[CDICCPPKCOO(2)]
		public BBIKBLOAPOF scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(3)]
		public bool isFrozen;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class AHFNGLDICPC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6932150", Offset = "0x6930B50", VA = "0x186932150")]
	public static GGAHGICMACJ AGMLDLCGDGN(this GGAHGICMACJ CAAHBOFLBKP, CHFCLHOLODC PIALGNLFEHH)
	{
		return default(GGAHGICMACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6932160", Offset = "0x6930B60", VA = "0x186932160")]
	public static GGAHGICMACJ FJEBMLODAAK(this GGAHGICMACJ CAAHBOFLBKP, CHFCLHOLODC PIALGNLFEHH)
	{
		return default(GGAHGICMACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6932170", Offset = "0x6930B70", VA = "0x186932170")]
	public static GGAHGICMACJ MGJIHPONLOL(this GGAHGICMACJ CAAHBOFLBKP, CHFCLHOLODC PIALGNLFEHH, bool HEIBCIECNKO)
	{
		return default(GGAHGICMACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6932190", Offset = "0x6930B90", VA = "0x186932190")]
	public static bool ODLOGLIACAA(this GGAHGICMACJ CAAHBOFLBKP, CHFCLHOLODC PIALGNLFEHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum CHFCLHOLODC
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
[NPGBCCJHHPF(0, 16383)]
public enum GGAHGICMACJ
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
[CBDDLELHGEE(1)]
public struct BBIKBLOAPOF : HLLCIEEAKDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[EAPAPGKGHMN(1)]
	public bool EFCPHECCPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[EAPAPGKGHMN(2)]
	public float3 OHDMJHFFOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[EAPAPGKGHMN(3)]
	public float3 CGDEHBNHBHE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6932370", Offset = "0x6930D70", VA = "0x186932370", Slot = "5")]
	public void JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6932250", Offset = "0x6930C50", VA = "0x186932250", Slot = "4")]
	public void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CBDDLELHGEE(1)]
public struct OMJADPLKEJB : HLLCIEEAKDG, IEquatable<OMJADPLKEJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[EAPAPGKGHMN(1)]
	public int PKNOIGMENLD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A30", Offset = "0x7C1430", VA = "0x1807C2A30")]
	public OMJADPLKEJB(int PKNOIGMENLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69334D0", Offset = "0x6931ED0", VA = "0x1869334D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6933450", Offset = "0x6931E50", VA = "0x186933450", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8A2060", Offset = "0x8A0A60", VA = "0x1808A2060", Slot = "6")]
	public bool Equals(OMJADPLKEJB MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x19D88C0", Offset = "0x19D72C0", VA = "0x1819D88C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6933570", Offset = "0x6931F70", VA = "0x186933570", Slot = "5")]
	public void JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6933540", Offset = "0x6931F40", VA = "0x186933540", Slot = "4")]
	public void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[EKJLLHCNGAM(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[CDICCPPKCOO(1)]
		public OMJADPLKEJB customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[NPGBCCJHHPF(0, 1)]
public enum MPLEMCBHLOA
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
	[EKJLLHCNGAM(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[CDICCPPKCOO(1)]
		public MPLEMCBHLOA propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct FLOHAKJOPLO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct CAGCKKGIBCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct GDJCFKGGKOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct NKBBKPDMLHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public FixedString32 AMNLGEBHFHK;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[BHJGMMLBLEP]
public struct PFNGMFAAECK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Entity OOOMPFGDEEN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	public static PFNGMFAAECK HPHCHABBDNG(Entity LPJDDLMPNCG)
	{
		return default(PFNGMFAAECK);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[EKJLLHCNGAM(1)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[CDICCPPKCOO(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct CDKPNOKKLBK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Entity LCLDFKAJPDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	public static CDKPNOKKLBK HPHCHABBDNG(Entity LCLDFKAJPDK)
	{
		return default(CDKPNOKKLBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct FHIBCCPHCEJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Entity PFDKPHBFDMM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	public static FHIBCCPHCEJ HPHCHABBDNG(Entity LCLDFKAJPDK)
	{
		return default(FHIBCCPHCEJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct LNAFKMOEIJK : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[EKJLLHCNGAM(1)]
	[DPGGCLGJEJM("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(1)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[EKJLLHCNGAM(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[CDICCPPKCOO(1)]
		public LFEIHDPDPKH shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[NPGBCCJHHPF(-1, 38)]
public enum LFEIHDPDPKH
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
	[EKJLLHCNGAM(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[Flags]
		[NPGBCCJHHPF(0, 7)]
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
		[CDICCPPKCOO(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6933A30", Offset = "0x6932430", VA = "0x186933A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6933AB0", Offset = "0x69324B0", VA = "0x186933AB0")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[NPGBCCJHHPF(0, 2)]
public enum OOJGABAKKJC
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
	[EKJLLHCNGAM(1)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[CDICCPPKCOO(1)]
		public OOJGABAKKJC shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[EKJLLHCNGAM(1)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[CDICCPPKCOO(1)]
		public HMDNAIPHAAE order;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[EKJLLHCNGAM(1)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[CDICCPPKCOO(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[EKJLLHCNGAM(1)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[CDICCPPKCOO(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly SplinePointPositionData Default;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2352140", Offset = "0x2350B40", VA = "0x182352140")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[EKJLLHCNGAM(1)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[CDICCPPKCOO(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly SplinePointRotationData Default;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC32FD0", Offset = "0xC319D0", VA = "0x180C32FD0")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[EKJLLHCNGAM(1)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[CDICCPPKCOO(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly SplinePointScaleData Default;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2352140", Offset = "0x2350B40", VA = "0x182352140")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[CBDDLELHGEE(1)]
public struct FOIGNAKKMCJ : HLLCIEEAKDG
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	[NPGBCCJHHPF(0, 7)]
	public enum FAMAOCIENLG
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
	[EAPAPGKGHMN(1)]
	public float PFEAICAFMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[EAPAPGKGHMN(2)]
	public int DKGGMCBMAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[EAPAPGKGHMN(3)]
	public FAMAOCIENLG CAAHBOFLBKP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JEPAPCNOKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6932730", Offset = "0x6931130", VA = "0x186932730")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6932830", Offset = "0x6931230", VA = "0x186932830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GOKKCDMNODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69327B0", Offset = "0x69311B0", VA = "0x1869327B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69328B0", Offset = "0x69312B0", VA = "0x1869328B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FMFOIEKMAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69326B0", Offset = "0x69310B0", VA = "0x1869326B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6932690", Offset = "0x6931090", VA = "0x186932690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69328D0", Offset = "0x69312D0", VA = "0x1869328D0", Slot = "5")]
	public void JDGCKOHAIDJ(CDCPEIFBKAJ MPOAAENBMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6932850", Offset = "0x6931250", VA = "0x186932850", Slot = "4")]
	public void HLHCEBOKDMG(CDCPEIFBKAJ MPOAAENBMAH)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[EKJLLHCNGAM(1)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[CDICCPPKCOO(1)]
		public FOIGNAKKMCJ parameters;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct BKNGAMLMBDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct GJOJOHMJDIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct LFEGCIIELOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct IDHFDAJPFKA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct MHAEBGFPPLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal struct HNOFLHKGHKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct IFNCGNOHMAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal struct OBCIDDAMBBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct CBBMKOCCLNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct LNBCEJAHAJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct HAMDCNGBEPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct DCHLGGAEAAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct PDEKENIMGJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct BBOFBCFOPBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct LBJODCODGDD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[EKJLLHCNGAM(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[CDICCPPKCOO(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[CDICCPPKCOO(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[CDICCPPKCOO(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[EKJLLHCNGAM(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[CDICCPPKCOO(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CDICCPPKCOO(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CDICCPPKCOO(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[CDICCPPKCOO(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CDICCPPKCOO(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[CDICCPPKCOO(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[CDICCPPKCOO(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[CDICCPPKCOO(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[CDICCPPKCOO(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[CDICCPPKCOO(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[CDICCPPKCOO(11)]
		public APIKDONJIFA mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[CDICCPPKCOO(12)]
		public PHDOOKGEFCM myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[CDICCPPKCOO(13)]
		public CNMPAEINPCP myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[CDICCPPKCOO(14)]
		public LEICAJHECGD myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[CDICCPPKCOO(15)]
		public PGCOIIMEAGM myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[CDICCPPKCOO(16)]
		public OBKDJDFACID myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[CDICCPPKCOO(17)]
		public BBHDELCIFIL myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[CDICCPPKCOO(18)]
		public AOJMHEEOMEJ myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CDICCPPKCOO(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[CDICCPPKCOO(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[CDICCPPKCOO(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[CDICCPPKCOO(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum APIKDONJIFA : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum PHDOOKGEFCM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum CNMPAEINPCP : short
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum LEICAJHECGD : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum PGCOIIMEAGM
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum OBKDJDFACID : uint
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum BBHDELCIFIL : long
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum AOJMHEEOMEJ : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[EKJLLHCNGAM(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[EKJLLHCNGAM(1)]
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
	[EKJLLHCNGAM(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class JACPCGMDKNG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct EPHIPCKHNCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Vector3 JBGCJOCPADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public List<SerializableGuid> LAPDLMHGDHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class FGCBOOKCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FGCBOOKCEKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public JACPCGMDKNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BHJGMMLBLEP]
public struct PGNIODGPAKA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public TimeData LAOEDLDFAJL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xC32FD0", Offset = "0xC319D0", VA = "0x180C32FD0")]
	public static PGNIODGPAKA HPHCHABBDNG(TimeData LPJDDLMPNCG)
	{
		return default(PGNIODGPAKA);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[EKJLLHCNGAM(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[CDICCPPKCOO(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[EKJLLHCNGAM(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[CDICCPPKCOO(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[CDICCPPKCOO(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2351EC0", Offset = "0x23508C0", VA = "0x182351EC0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6932210", Offset = "0x6930C10", VA = "0x186932210")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6932210", Offset = "0x6930C10", VA = "0x186932210")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[EKJLLHCNGAM(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[EKJLLHCNGAM(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6933210", Offset = "0x6931C10", VA = "0x186933210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[EKJLLHCNGAM(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[CDICCPPKCOO(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct FCKMCCGOFNE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int BHAFONMGEIA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int EGNHJGKABLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69325D0", Offset = "0x6930FD0", VA = "0x1869325D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69325C0", Offset = "0x6930FC0", VA = "0x1869325C0")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[EKJLLHCNGAM(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[CDICCPPKCOO(1)]
		public EPJALMAKADJ transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[CDICCPPKCOO(2)]
		public COAHEHLHNHH transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
[NPGBCCJHHPF(0, 1)]
public enum EPJALMAKADJ
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
[NPGBCCJHHPF(-2, 2)]
public enum COAHEHLHNHH
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
	[EKJLLHCNGAM(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[EKJLLHCNGAM(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x6933CF0", Offset = "0x69326F0", VA = "0x186933CF0")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[EKJLLHCNGAM(1)]
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
[NPGBCCJHHPF(1000, 8001)]
public enum GODNFBOIBNJ
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
internal enum FINFAOHFIGC
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
internal static class NCOIEONHEMO
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[EKJLLHCNGAM(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[CDICCPPKCOO(1)]
		public GODNFBOIBNJ prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class LAKANHPOBDI
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6932F90", Offset = "0x6931990", VA = "0x186932F90")]
	public static bool BDPBEFJCECP(this GODNFBOIBNJ OGILDIMGIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6932FD0", Offset = "0x69319D0", VA = "0x186932FD0")]
	public static string ECMIJIDIAKO(this GODNFBOIBNJ OGILDIMGIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6932FB0", Offset = "0x69319B0", VA = "0x186932FB0")]
	public static BDPFCKONNMG CNLDDDHJFJE(this GODNFBOIBNJ KLFAINNONJC)
	{
		return default(BDPFCKONNMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6933050", Offset = "0x6931A50", VA = "0x186933050")]
	internal static FINFAOHFIGC GPCANNKGMCM(this BDPFCKONNMG HHKPMCBFHDJ)
	{
		return default(FINFAOHFIGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6933060", Offset = "0x6931A60", VA = "0x186933060")]
	internal static FINFAOHFIGC GPCANNKGMCM(this GODNFBOIBNJ KLFAINNONJC)
	{
		return default(FINFAOHFIGC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[NPGBCCJHHPF(0, 9)]
public enum BDPFCKONNMG
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
	[EKJLLHCNGAM(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[CDICCPPKCOO(1)]
		public BDPFCKONNMG objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class AEDMOIOJPEF
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6932100", Offset = "0x6930B00", VA = "0x186932100")]
	public static bool LCBHMNDFPLA(this BDPFCKONNMG HHKPMCBFHDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[NPGBCCJHHPF(int.MinValue, int.MaxValue)]
public enum MAODNMABAFO
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
[NPGBCCJHHPF(-1, 31)]
public enum MHBJDIJEHNF
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
	[DPGGCLGJEJM("Visual", 0)]
	[EKJLLHCNGAM(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(1)]
		public MAODNMABAFO color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(2)]
		public MHBJDIJEHNF material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		[CDICCPPKCOO(3)]
		[LILMMBLFBHF(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		[LILMMBLFBHF(0)]
		[CDICCPPKCOO(4)]
		public Vector3 uvOffset;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[Preserve]
	internal class _RRAssemblyIndex : AAHOHGIJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6934040", Offset = "0x6932A40", VA = "0x186934040", Slot = "4")]
		public sealed override void KLMOEJEAKPE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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

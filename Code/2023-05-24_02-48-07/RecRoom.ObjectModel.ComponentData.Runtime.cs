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
public class IEHHBJNNNIL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Rigidbody GGGGHNNPHJC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B67110", Offset = "0x6B65D10", VA = "0x186B67110", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public IEHHBJNNNIL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct BKINMNHDBCM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FFBKFBIJNKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public LHPAGGDFKDF LMIIBOOAPKI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BPAKPPLANGF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NEOAAOEPFPL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public object JCBGJNBPPGE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B68630", Offset = "0x6B67230", VA = "0x186B68630", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public NEOAAOEPFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[InternalBufferCapacity(0)]
public struct OCEAOHDCFAK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity PIKIEEICNEP;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FKAPPAMEKFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float GIFDAOBHDEB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly global::BAGKINIFOEG<FKAPPAMEKFC> OAEIAFEPBFB;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FGHHJLEOALK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public float3 NJPNNPKDNHK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FJELCIJMBEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MKCCBALLBBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLNOJJNGPDA(BLMHMCOGNAC FIIFHFDPPBC, BLMHMCOGNAC DPHBMFBPJLA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHGMJJCAPC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KEFOHPEBEHN();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBMPOHOFPGJ(bool AOHFCNFADMO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KNJFBMCNMDD();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBKADGJMAIB();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EDNNLLIMNAI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PAFDEGPAOEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int KIOKOHMNEOH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA92A00", Offset = "0xA91600", VA = "0x180A92A00")]
	public static PAFDEGPAOEB DGIADCHILCD(int ECNGHFJBIJL)
	{
		return default(PAFDEGPAOEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum LHPAGGDFKDF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum GALCBGLBFAD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct COAHCKDCMDO : FBNBLAKKAPF, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GHBLMLDHKJD IFBAAEKPOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GHBLMLDHKJD);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OIKNDGJJMDK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public MKCCBALLBBE AGBGOILKOJP;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B687C0", Offset = "0x6B673C0", VA = "0x186B687C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public OIKNDGJJMDK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LPIGDNGEKDF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KMCKFEMMPIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 INPCFJLMNAK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly global::BAGKINIFOEG<KMCKFEMMPIG> OAEIAFEPBFB;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MHOJKICAJNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float FMKENJDMKIE;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly global::BAGKINIFOEG<MHOJKICAJNG> OAEIAFEPBFB;
}
namespace RecRoom.Rbex
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[HBLBMFDKOAO]
	public struct RbexKinematicChangeSystemStateData : ISystemStateBufferElementData, IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JKJFDMAKIJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float LMACMILFAEC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly global::BAGKINIFOEG<JKJFDMAKIJO> OAEIAFEPBFB;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EECLEHGKCEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 AOPDIFGHMNI;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HEMPGBBKCGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Entity PMBNHDHBMIA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KHNHNKBAHLA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BLMHMCOGNAC
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
public struct IGDHNPPJKOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 INPCFJLMNAK;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly global::BAGKINIFOEG<KMCKFEMMPIG> OAEIAFEPBFB;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OHLFFFMBAPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity ONIJEEBBCHK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct AMDJDAJCNAL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct ABPNLCFCOOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public LHPAGGDFKDF LBJPOENPNLH;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OHPAHIBLMEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public RigidbodyConstraints IJJBJLEMONJ;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CLIFEOOCIDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float LOOFLEPAOCC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly global::BAGKINIFOEG<CLIFEOOCIDE> OAEIAFEPBFB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LCOAJJCLBGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct LODCDOHILOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public BLMHMCOGNAC PIAGEAPKBKH;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly global::BAGKINIFOEG<LODCDOHILOL> OAEIAFEPBFB;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KLHAGNKFIKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public CollisionDetectionMode IFFHGGHFFEP;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IMGKECMJNPA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public object GHLNPLNGOLO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B672A0", Offset = "0x6B65EA0", VA = "0x186B672A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public IMGKECMJNPA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct MILMKNLJHIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JCBKOFLKKFL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct ADLMFBCFECK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float3 MGLJKNHHDII;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MDEKCAAADBL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float OIOOEPMJBBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct NGDGKPHHHKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float3 NOIKJKFLDHI;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[InternalBufferCapacity(8)]
public struct DJPOONHPMCK : ISystemStateBufferElementData, IBufferElementData, IEquatable<DJPOONHPMCK>, LLGKCODLICG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity PIKIEEICNEP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity FNJEDEPEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0")]
	public DJPOONHPMCK(Entity PIKIEEICNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B65C40", Offset = "0x6B64840", VA = "0x186B65C40", Slot = "4")]
	public bool Equals(DJPOONHPMCK MDHJAFNLPON)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
	public static DJPOONHPMCK DGIADCHILCD(Entity CMBJDMJHALL)
	{
		return default(DJPOONHPMCK);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[AOKGGDGMDNB]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[LKOGHMJILOJ(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[LKOGHMJILOJ(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[LKOGHMJILOJ(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[AOKGGDGMDNB]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[LKOGHMJILOJ(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly global::BAGKINIFOEG<LocalUniformScaleData> Default;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct CLGOIDBAELA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct HKEKBNJBKPM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity CMBJDMJHALL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
	public static HKEKBNJBKPM DGIADCHILCD(Entity CMBJDMJHALL)
	{
		return default(HKEKBNJBKPM);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Container", 0)]
	public struct ContainerFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(1)]
		public ContainerEnumFlags flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Flags]
	[BBPHNBKLBKA(0, 15943)]
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
public struct BEFCJPCPDJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MMNKAFCFCFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EGKOKLFHEED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct FBAJGDNCIMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct KPCLEJGPNFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct KAHOLPAPGIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct PDAMJLNNAFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NDNHFBEMOIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct HHOKBNBPFIG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[AOKGGDGMDNB]
	public struct ComponentSerializedVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[IPEMEPMKPEF(1)]
		public BNPJAIHNGJD version;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly global::BAGKINIFOEG<ComponentSerializedVersionData> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum BNPJAIHNGJD : uint
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
	[AOKGGDGMDNB]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[LKOGHMJILOJ(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly global::BAGKINIFOEG<SplinePointScaleData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x240CA80", Offset = "0x240B680", VA = "0x18240CA80")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct COPDKIEPBNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float EPKBCLGGBME;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly global::BAGKINIFOEG<COPDKIEPBNK> OAEIAFEPBFB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[AOKGGDGMDNB]
	[PLFBOKKLFBM(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[LKOGHMJILOJ(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[LKOGHMJILOJ(2)]
		public SerializableGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Container", 0)]
	public struct ContainerCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[LKOGHMJILOJ(1)]
		[CHOEMHHHMIG(0)]
		public CollisionMode collisionMode;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly global::BAGKINIFOEG<ContainerCollisionModeData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[BBPHNBKLBKA(0, 2)]
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
internal enum DAKHLAKFCPF
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
internal static class IHHGOMOKNHC
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct PJJGEHICIIL : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[AOKGGDGMDNB]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[LKOGHMJILOJ(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[LKOGHMJILOJ(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[LKOGHMJILOJ(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[LKOGHMJILOJ(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[LKOGHMJILOJ(5)]
		public float max;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal struct ECINNBFFLEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct IKDNJGILAHL : ISystemStateComponentData, IComponentData, LLGKCODLICG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Entity OMCPFFEGLFK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private Entity FNJEDEPEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct GCHKCJIJLEK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct HCLCLPIGBHH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct BGJIIECJADH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float4x4 EFOLJGHPAFE;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly global::BAGKINIFOEG<BGJIIECJADH> OAEIAFEPBFB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[BBPHNBKLBKA(0, 4)]
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
	[AOKGGDGMDNB]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[LKOGHMJILOJ(1)]
		public GizmoType gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[AOKGGDGMDNB]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[Flags]
		[BBPHNBKLBKA(0, 7)]
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
		[LKOGHMJILOJ(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::BAGKINIFOEG<ShapeConfigData> Default;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6B69FC0", Offset = "0x6B68BC0", VA = "0x186B69FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6B6A040", Offset = "0x6B68C40", VA = "0x186B6A040")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[AOKGGDGMDNB]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[LKOGHMJILOJ(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::BAGKINIFOEG<AuthoredLocalUniformScaleData> Default;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MDCDPBFHOFO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[BBPHNBKLBKA(0, 1)]
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
	[AOKGGDGMDNB]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[LKOGHMJILOJ(1)]
		public PropType propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct PIGOKANOEKM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[AOKGGDGMDNB]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[LKOGHMJILOJ(1)]
		public Entity spline;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct FEBKDPOBKOM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[BBPHNBKLBKA(0, 9)]
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
public static class CPBGLALJBCM
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B65610", Offset = "0x6B64210", VA = "0x186B65610")]
	public static bool LGGHMKNAHIF(this ObjectType NEKHODKNEJH)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[BBPHNBKLBKA(-1, 38)]
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
public struct BONINGHIDND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct ICONKHNGNAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct LOEOEEOFFEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct EFOGGMDHEIH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[AOKGGDGMDNB]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[LKOGHMJILOJ(1)]
		public HOAOFIPLABA order;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
		public static implicit operator SplinePointOrderData(HOAOFIPLABA value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(1)]
		public FixedString64Bytes name;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class EODFFEBAJAH
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B66100", Offset = "0x6B64D00", VA = "0x186B66100")]
	public static void OLBGCODNBJK(this ref ObjectPolicyEnumFlags BJCAHHPNCBK, GHMJMLIAAOF JEFKBPGPKGJ, bool PKDEOIANGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B660E0", Offset = "0x6B64CE0", VA = "0x186B660E0")]
	public static bool HOGEKIDDJEB(this ObjectPolicyEnumFlags BJCAHHPNCBK, GHMJMLIAAOF JEFKBPGPKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B660D0", Offset = "0x6B64CD0", VA = "0x186B660D0")]
	public static ObjectPolicyEnumFlags GOCGDJNGALO(this GHMJMLIAAOF JEFKBPGPKGJ)
	{
		return default(ObjectPolicyEnumFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B66130", Offset = "0x6B64D30", VA = "0x186B66130")]
	public static void OLBGCODNBJK(this ref ObjectPolicyUserConfigurableFlags BJCAHHPNCBK, ObjectPolicyUserConfigurableFlags AOCJDBLPGHC, bool PKDEOIANGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum GHMJMLIAAOF
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
	[BBPHNBKLBKA(0, 16383)]
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
	[BBPHNBKLBKA(0, 3)]
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
public struct FNLGDLCPBCN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[NLAOCKFKKPI]
	[MPLGEIBKPCK(1029043735688538310uL, 14256247939851101839uL)]
	public struct DEPRECATED_RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ObjectType objectType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BBPHNBKLBKA(int.MinValue, int.MaxValue)]
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
	[AOKGGDGMDNB]
	[FFFANHNINPP("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[LKOGHMJILOJ(1)]
		[CHOEMHHHMIG(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[LKOGHMJILOJ(2)]
		[CHOEMHHHMIG(0)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(3)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Light", 0)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[LKOGHMJILOJ(1)]
		[CHOEMHHHMIG(0)]
		public float angle;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GAKOOFLBENN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Container", 0)]
	public struct ContainerMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(1)]
		public float mass;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct FOBJCOEKDPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private NativeList<DFGHHANBAFO> MNIHLGMKNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private NativeList<Entity> PDDGEEDNAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private JobHandle KHHIMFIIKFD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MMKBNABBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B66650", Offset = "0x6B65250", VA = "0x186B66650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B664B0", Offset = "0x6B650B0", VA = "0x186B664B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B4D7B0", Offset = "0x2B4C3B0", VA = "0x182B4D7B0")]
	public FOBJCOEKDPN(NativeList<DFGHHANBAFO> MNIHLGMKNDP, NativeList<Entity> PDDGEEDNAFH, JobHandle KHHIMFIIKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B66500", Offset = "0x6B65100", VA = "0x186B66500")]
	public (Entity, NativeSlice<Entity>) NHMDMEKCFPE(int OCIFJAIBHIA)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B66450", Offset = "0x6B65050", VA = "0x186B66450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct NDAPMPMEDLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 NABPHMOHNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public quaternion KDPJNNPKKHC;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly global::BAGKINIFOEG<NDAPMPMEDLD> OAEIAFEPBFB;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B68270", Offset = "0x6B66E70", VA = "0x186B68270")]
	public float3 CGLPHBFHGPI(float3 DBMHGAAIFOA)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class JGOLLKIIBNB
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[NLAOCKFKKPI]
	[MPLGEIBKPCK(218523523639012570uL, 15191719635551116065uL)]
	public struct DEPRECATED_ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private uint networkIdBits;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[AOKGGDGMDNB]
	[MPLGEIBKPCK(17667479821163689808uL, 11946378475791123970uL)]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[AOKGGDGMDNB]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[LKOGHMJILOJ(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly global::BAGKINIFOEG<SplinePointRotationData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF944D0", Offset = "0xF930D0", VA = "0x180F944D0")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[AOKGGDGMDNB]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[LKOGHMJILOJ(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[LKOGHMJILOJ(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct KCCEFNCIFLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public FixedString32Bytes BPOKAAOBIOI;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct GAFEIDBCPGC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Entity NEOANJPAOAH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Flags]
	[BBPHNBKLBKA(0, 1)]
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
public struct KJDHPICCGGO : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[PLFBOKKLFBM(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[IPEMEPMKPEF(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[IPEMEPMKPEF(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[IPEMEPMKPEF(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[IPEMEPMKPEF(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[PLFBOKKLFBM(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, DCEINGFKEIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[IPEMEPMKPEF(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xF944D0", Offset = "0xF930D0", VA = "0x180F944D0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xF944D0", Offset = "0xF930D0", VA = "0x180F944D0")]
		public static SerializableGuid DGIADCHILCD(Guid PCFHAIHNKAK)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6B69E50", Offset = "0x6B68A50", VA = "0x186B69E50", Slot = "4")]
		public bool Equals(SerializableGuid MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B69D40", Offset = "0x6B68940", VA = "0x186B69D40", Slot = "5")]
		public int CompareTo(SerializableGuid MDHJAFNLPON)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B69D60", Offset = "0x6B68960", VA = "0x186B69D60", Slot = "6")]
		public void ECCPKOGLKLF(ref OCBGHMJPILB FEHOOJAGKPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6B69EE0", Offset = "0x6B68AE0", VA = "0x186B69EE0", Slot = "7")]
		public void NLJPEOGMFGO(ref JDMEGDECHOI GAPKPHPMEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6B69F60", Offset = "0x6B68B60", VA = "0x186B69F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct FKIIGINDJIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BOHECFLPGEB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[BBPHNBKLBKA(0, 4)]
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
	[AOKGGDGMDNB]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[LKOGHMJILOJ(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[LKOGHMJILOJ(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[LKOGHMJILOJ(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[LKOGHMJILOJ(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[LKOGHMJILOJ(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[LKOGHMJILOJ(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[LKOGHMJILOJ(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[LKOGHMJILOJ(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[LKOGHMJILOJ(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[LKOGHMJILOJ(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[LKOGHMJILOJ(11)]
		public GKKPDJLHDGH mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[LKOGHMJILOJ(12)]
		public DLDOCGIPGIL myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[LKOGHMJILOJ(13)]
		public PFPNMOLONAA myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[LKOGHMJILOJ(14)]
		public DDCJLFHMGAC myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[LKOGHMJILOJ(15)]
		public LDHALAGAFND myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[LKOGHMJILOJ(16)]
		public EFHCNACLCNK myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[LKOGHMJILOJ(17)]
		public FOJFOPHCBHB myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[LKOGHMJILOJ(18)]
		public AHAILMFMKIE myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[LKOGHMJILOJ(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[LKOGHMJILOJ(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[LKOGHMJILOJ(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[LKOGHMJILOJ(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public enum GKKPDJLHDGH : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public enum DLDOCGIPGIL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public enum PFPNMOLONAA : short
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum DDCJLFHMGAC : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum LDHALAGAFND
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum EFHCNACLCNK : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum FOJFOPHCBHB : long
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public enum AHAILMFMKIE : ulong
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
	[AOKGGDGMDNB]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[AOKGGDGMDNB]
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
public class OIBICJNPGGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public int KNJBCHEFCED;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public int NFGPNNPLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public GameObject ALBKEDBKENG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public OIBICJNPGGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OMHIJEDIHLJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct PBGKCMCKGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Vector3 KMLEJEKMLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public List<SerializableGuid> BOFBJOOFDIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class PIGMPEFEGIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public PBGKCMCKGMO BBHJOLENOOC;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public PIGMPEFEGIK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public SerializableGuid KOJKEMEPAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public List<int> BCDGKMNPOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public List<PBGKCMCKGMO> KGENONOGLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public List<PIGMPEFEGIK> NKIOOELMDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public GameObject ALBKEDBKENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Light IJAAKLINKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public Collider JNLMKMJDNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public string MPMPOIGCMPE;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public OMHIJEDIHLJ()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[NLAOCKFKKPI]
	[MPLGEIBKPCK(2613756846563002039uL, 6372660366488563574uL)]
	[FFFANHNINPP("Container", 0)]
	public struct DEPRECATED_ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(1)]
		public DEPRECATED_CollidesWith collidesWith;
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Flags]
	[BBPHNBKLBKA(0, 15)]
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
	[NLAOCKFKKPI]
	[MPLGEIBKPCK(9804513251708000208uL, 10903582988135044631uL)]
	public struct DEPRECATED_ContainerData : IComponentData, IEquatable<DEPRECATED_ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[LKOGHMJILOJ(1)]
		public FixedString64Bytes name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[LKOGHMJILOJ(2)]
		public CollisionMode collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[LKOGHMJILOJ(3)]
		public DEPRECATED_CollidesWith collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[LKOGHMJILOJ(4)]
		public GrabbableMode grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[LKOGHMJILOJ(5)]
		public ContainerEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[LKOGHMJILOJ(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6B65900", Offset = "0x6B64500", VA = "0x186B65900", Slot = "4")]
		public bool Equals(DEPRECATED_ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[PLFBOKKLFBM(1)]
public struct BHKMKIAFEBP : DCEINGFKEIM
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Flags]
	[BBPHNBKLBKA(0, 7)]
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
	[IPEMEPMKPEF(1)]
	public float tubeHeightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[IPEMEPMKPEF(2)]
	public int tubeRingPoints;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[IPEMEPMKPEF(3)]
	public Flags flags;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool AFHNGNCFMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B64B60", Offset = "0x6B63760", VA = "0x186B64B60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B64BE0", Offset = "0x6B637E0", VA = "0x186B64BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LDPCLNFHDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B64C80", Offset = "0x6B63880", VA = "0x186B64C80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B64AE0", Offset = "0x6B636E0", VA = "0x186B64AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FPDNGLEOHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B64C00", Offset = "0x6B63800", VA = "0x186B64C00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B64D00", Offset = "0x6B63900", VA = "0x186B64D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6B64D20", Offset = "0x6B63920", VA = "0x186B64D20", Slot = "5")]
	public void NLJPEOGMFGO(ref JDMEGDECHOI GAPKPHPMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B64B00", Offset = "0x6B63700", VA = "0x186B64B00", Slot = "4")]
	public void ECCPKOGLKLF(ref OCBGHMJPILB FEHOOJAGKPN)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[AOKGGDGMDNB]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[LKOGHMJILOJ(1)]
		public BHKMKIAFEBP parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[AOKGGDGMDNB]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[LKOGHMJILOJ(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly global::BAGKINIFOEG<SplinePointPositionData> Default;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x240CA80", Offset = "0x240B680", VA = "0x18240CA80")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct CODEPIOBBIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Entity NEOANJPAOAH;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[InternalBufferCapacity(8)]
public struct LNJMODDHJJK : ISystemStateBufferElementData, IBufferElementData, IEquatable<LNJMODDHJJK>, LLGKCODLICG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Entity PIKIEEICNEP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity FNJEDEPEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6B65C40", Offset = "0x6B64840", VA = "0x186B65C40", Slot = "4")]
	public bool Equals(LNJMODDHJJK MDHJAFNLPON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal struct NBMMCICMLMD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Entity NAKLMJDMHGM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[AOKGGDGMDNB]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[LKOGHMJILOJ(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[LKOGHMJILOJ(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public static readonly global::BAGKINIFOEG<LocalPoseData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x102D310", Offset = "0x102BF10", VA = "0x18102D310")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B647E0", Offset = "0x6B633E0", VA = "0x186B647E0")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B647E0", Offset = "0x6B633E0", VA = "0x186B647E0")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class GNEPBMKGCNK
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface LLGKCODLICG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity OECGFJCJDKA
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
	[AOKGGDGMDNB]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[LKOGHMJILOJ(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[LKOGHMJILOJ(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static readonly global::BAGKINIFOEG<OMShapeContainerData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Object", 0)]
	public struct ObjectPolicyV2Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[IPEMEPMKPEF(1)]
		public ObjectPolicyEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[LKOGHMJILOJ(2)]
		public PBFJELEPPLM scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[LKOGHMJILOJ(3)]
		[CHOEMHHHMIG(0)]
		public ObjectPolicyUserConfigurableFlags userConfigurableFlags;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly global::BAGKINIFOEG<ObjectPolicyV2Data> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[NLAOCKFKKPI]
	[MPLGEIBKPCK(9898405628982320166uL, 2023375009558162791uL)]
	[MPLGEIBKPCK(9807788745867066359uL, 15168486114979071194uL)]
	public struct DEPRECATED_ObjectPolicyV1Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[LKOGHMJILOJ(1)]
		public ObjectPolicyEnumFlags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[LKOGHMJILOJ(2)]
		public PBFJELEPPLM scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(3)]
		public bool isFrozen;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly global::BAGKINIFOEG<DEPRECATED_ObjectPolicyV1Data> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct PPGJCOKKPKP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public int FNPPFCMGJKO;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct IGBONBLLCHN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public GCHandle HBMNKIDGNML;
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct KGHEHDAGMGG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private int AHMPNOCINEO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NHHNPPKPBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B67730", Offset = "0x6B66330", VA = "0x186B67730")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6B67720", Offset = "0x6B66320", VA = "0x186B67720")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[AOKGGDGMDNB]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[LKOGHMJILOJ(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct HJGBIGLPPLF : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[AOKGGDGMDNB]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[LKOGHMJILOJ(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly global::BAGKINIFOEG<LocalDeformableScaleData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Container", 0)]
	public struct ContainerGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[LKOGHMJILOJ(1)]
		[CHOEMHHHMIG(0)]
		public GrabbableMode grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[BBPHNBKLBKA(0, 1)]
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
[PLFBOKKLFBM(1)]
public struct PBFJELEPPLM : DCEINGFKEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[IPEMEPMKPEF(1)]
	public bool enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[IPEMEPMKPEF(2)]
	public float3 minScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[IPEMEPMKPEF(3)]
	public float3 maxScale;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static readonly global::BAGKINIFOEG<PBFJELEPPLM> OAEIAFEPBFB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B68B90", Offset = "0x6B67790", VA = "0x186B68B90", Slot = "5")]
	public void NLJPEOGMFGO(ref JDMEGDECHOI GAPKPHPMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6B68B40", Offset = "0x6B67740", VA = "0x186B68B40", Slot = "4")]
	public void ECCPKOGLKLF(ref OCBGHMJPILB FEHOOJAGKPN)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[AOKGGDGMDNB]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[LKOGHMJILOJ(1)]
		public PrimitiveShapeType shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct GPPNACPKCGP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public int FNPPFCMGJKO;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface AIKDJHPHICP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJAHNFAKPIB(bool NLKAGOBENNM);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.TypeVersion(2)]
public struct AHMFPJGDLPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public uint OIDBGBALHDI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B646C0", Offset = "0x6B632C0", VA = "0x186B646C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct AFOFIDDGCAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal struct HNNEIEMEEMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct GAHGGKOPABJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[HBLBMFDKOAO]
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
public struct GMOBLLJOKKG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(1)]
		public RenderableColor color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(2)]
		public RenderableMaterial material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[CHOEMHHHMIG(0)]
		[LKOGHMJILOJ(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[LKOGHMJILOJ(4)]
		[CHOEMHHHMIG(0)]
		public Vector3 uvOffset;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Physics", 0)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[LKOGHMJILOJ(1)]
		[CHOEMHHHMIG(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static readonly global::BAGKINIFOEG<PhysicsMaterialData> Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[PLFBOKKLFBM(1)]
public struct HOAOFIPLABA : IComparable<HOAOFIPLABA>, IEquatable<HOAOFIPLABA>, DCEINGFKEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	[IPEMEPMKPEF(1)]
	public uint nom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	[IPEMEPMKPEF(2)]
	public uint denomMinusOne;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint BHDADFMNHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B66C50", Offset = "0x6B65850", VA = "0x186B66C50")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B670C0", Offset = "0x6B65CC0", VA = "0x186B670C0")]
	public HOAOFIPLABA(int HIPAPJOHLHB, int IMFLGOALBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B670C0", Offset = "0x6B65CC0", VA = "0x186B670C0")]
	public HOAOFIPLABA(uint HIPAPJOHLHB, uint IMFLGOALBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B66C60", Offset = "0x6B65860", VA = "0x186B66C60")]
	public HOAOFIPLABA APGBGMHOLAC(int MCMFGBNCCMI = 1)
	{
		return default(HOAOFIPLABA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B66F80", Offset = "0x6B65B80", VA = "0x186B66F80")]
	public HOAOFIPLABA PAIBMEOOAFJ(int MCMFGBNCCMI = 1)
	{
		return default(HOAOFIPLABA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B66E60", Offset = "0x6B65A60", VA = "0x186B66E60")]
	public static HOAOFIPLABA MGDKLECCNLM(HOAOFIPLABA FDMHBFLJJHC, HOAOFIPLABA DNGDHCADJJH)
	{
		return default(HOAOFIPLABA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B66EE0", Offset = "0x6B65AE0", VA = "0x186B66EE0")]
	private static uint MHCIGNDAPBO(uint NBLDAOBEAEA, uint PAJLLFKCBBD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B66CC0", Offset = "0x6B658C0", VA = "0x186B66CC0", Slot = "4")]
	public int CompareTo(HOAOFIPLABA MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B66D50", Offset = "0x6B65950", VA = "0x186B66D50", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B66FE0", Offset = "0x6B65BE0", VA = "0x186B66FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B66DF0", Offset = "0x6B659F0", VA = "0x186B66DF0", Slot = "5")]
	public bool Equals(HOAOFIPLABA MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B66E10", Offset = "0x6B65A10", VA = "0x186B66E10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B66CE0", Offset = "0x6B658E0", VA = "0x186B66CE0", Slot = "6")]
	public void ECCPKOGLKLF(ref OCBGHMJPILB FEHOOJAGKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B66F10", Offset = "0x6B65B10", VA = "0x186B66F10", Slot = "7")]
	public void NLJPEOGMFGO(ref JDMEGDECHOI GAPKPHPMEOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x13AB130", Offset = "0x13A9D30", VA = "0x1813AB130")]
	public static bool FMMDKFLNNFA(HOAOFIPLABA FDMHBFLJJHC, HOAOFIPLABA DNGDHCADJJH)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[AOKGGDGMDNB]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public ObjectPrefabType prefabType;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[NLAOCKFKKPI]
	[MPLGEIBKPCK(14327281633525910712uL, 2559857777606771911uL)]
	[MPLGEIBKPCK(15725208981563603541uL, 17017036095303668770uL)]
	public struct DEPRECATED_RRObjectPrefabV1Data : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[LKOGHMJILOJ(1)]
		public ObjectPrefabType prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class DABOCJBPJOK
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B658B0", Offset = "0x6B644B0", VA = "0x186B658B0")]
	public static bool MCIMGEAOMAE(this ObjectPrefabType FIJCKHKKDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B65830", Offset = "0x6B64430", VA = "0x186B65830")]
	public static string HLLIMPMAADG(this ObjectPrefabType FIJCKHKKDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B658E0", Offset = "0x6B644E0", VA = "0x186B658E0")]
	public static ObjectType OJJNJPCANCF(this ObjectPrefabType KJIFGCIDDIC)
	{
		return default(ObjectType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B65800", Offset = "0x6B64400", VA = "0x186B65800")]
	internal static DAKHLAKFCPF ENIFOPDBJPM(this ObjectType NEKHODKNEJH)
	{
		return default(DAKHLAKFCPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B65810", Offset = "0x6B64410", VA = "0x186B65810")]
	internal static DAKHLAKFCPF ENIFOPDBJPM(this ObjectPrefabType KJIFGCIDDIC)
	{
		return default(DAKHLAKFCPF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct CAIDNHOILPP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal struct JEKBENCNELE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public Entity GBOLOAJMEOH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
	public static JEKBENCNELE DGIADCHILCD(Entity CMBJDMJHALL)
	{
		return default(JEKBENCNELE);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[AOKGGDGMDNB]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[IPEMEPMKPEF(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct HLJPFMNOIII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public float3 FOJIPMHFJFB;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static readonly global::BAGKINIFOEG<HLJPFMNOIII> OAEIAFEPBFB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct HDJMIHHBEIE : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[AOKGGDGMDNB]
	[FFFANHNINPP("Container", 0)]
	public struct ContainerCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[LKOGHMJILOJ(1)]
		[CHOEMHHHMIG(0)]
		public ContainerCollisionLayerEnum collisionLayer;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static readonly global::BAGKINIFOEG<ContainerCollisionLayerData> Default;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[BBPHNBKLBKA(0, 127)]
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
public static class KDKFMFKLPMI
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public enum MMKIAINHPMP
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
	public enum CKELKLMOIDH
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
	[Cpp2IlInjected.Address(RVA = "0x6B675B0", Offset = "0x6B661B0", VA = "0x186B675B0")]
	public static (MMKIAINHPMP, CKELKLMOIDH) LLJIDLBMPAC(this ContainerCollisionLayerEnum DOBMDPHLPNO)
	{
		return default((MMKIAINHPMP, CKELKLMOIDH));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct DFGHHANBAFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public Entity PMBNHDHBMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public int MCMFGBNCCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public int HLPFAIAMMGH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[AOKGGDGMDNB]
	public struct ParentData : IComponentData, LLGKCODLICG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[LKOGHMJILOJ(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct PECBMBHHHPP : ISystemStateComponentData, IComponentData, LLGKCODLICG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public Entity OMCPFFEGLFK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity FNJEDEPEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0")]
	public PECBMBHHHPP(Entity ONIJEEBBCHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
	public static PECBMBHHHPP DGIADCHILCD(Entity CMBJDMJHALL)
	{
		return default(PECBMBHHHPP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct FHLFEMMHMFB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[BBPHNBKLBKA(1000, 8000)]
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
public static class DEKNILBPOIK
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct PFADMLOOCEH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[BBPHNBKLBKA(-2, 2)]
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
public struct HFKDGBCGIDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct AJJCHPOMHND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public uint PNNGMEJNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public int ONHGJKCGLNK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81E4F0", Offset = "0x81D0F0", VA = "0x18081E4F0")]
	public AJJCHPOMHND(uint DBAHFFFPHBI, int OOMOMLEECCO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public struct MIBEFJPIKMJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[BBPHNBKLBKA(-1, 31)]
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
[PLFBOKKLFBM(1)]
public struct FBAPEENEEOL : DCEINGFKEIM, IEquatable<FBAPEENEEOL>
{
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly FBAPEENEEOL BGKJPCCCNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[IPEMEPMKPEF(1)]
	public int id;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x96CBB0", Offset = "0x96B7B0", VA = "0x18096CBB0")]
	public FBAPEENEEOL(int EDPPELMHBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B661F0", Offset = "0x6B64DF0", VA = "0x186B661F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B66160", Offset = "0x6B64D60", VA = "0x186B66160", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA90E40", Offset = "0xA8FA40", VA = "0x180A90E40", Slot = "6")]
	public bool Equals(FBAPEENEEOL MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B66280", Offset = "0x6B64E80", VA = "0x186B66280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B66260", Offset = "0x6B64E60", VA = "0x186B66260", Slot = "5")]
	public void NLJPEOGMFGO(ref JDMEGDECHOI GAPKPHPMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B66150", Offset = "0x6B64D50", VA = "0x186B66150", Slot = "4")]
	public void ECCPKOGLKLF(ref OCBGHMJPILB FEHOOJAGKPN)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[AOKGGDGMDNB]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		[LKOGHMJILOJ(1)]
		public FBAPEENEEOL customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct CJEIJOLDENJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public float4x4 PAOMBAOFFIM;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly global::BAGKINIFOEG<CJEIJOLDENJ> OAEIAFEPBFB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[AOKGGDGMDNB]
	public struct AuthoredParentData : IComponentData, LLGKCODLICG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		[LKOGHMJILOJ(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x818CC0", Offset = "0x8178C0", VA = "0x180818CC0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6B64870", Offset = "0x6B63470", VA = "0x186B64870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public struct FCOBKOFNHMJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[HBLBMFDKOAO]
	public struct SingletonActiveSceneData : ISystemStateComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public Entity scene;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
		public static implicit operator SingletonActiveSceneData(Entity value)
		{
			return default(SingletonActiveSceneData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[AOKGGDGMDNB]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		[LKOGHMJILOJ(1)]
		public TransformHint transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		[LKOGHMJILOJ(2)]
		public TransformPriority transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[AOKGGDGMDNB]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		[LKOGHMJILOJ(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		[LKOGHMJILOJ(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[LKOGHMJILOJ(3)]
		public float speed;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public struct IBEBEDLJBGC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal struct EIHNHFLDHIN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[AOKGGDGMDNB]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		[LKOGHMJILOJ(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		[LKOGHMJILOJ(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public static readonly global::BAGKINIFOEG<AuthoredLocalPoseData> Default;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x102D310", Offset = "0x102BF10", VA = "0x18102D310")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6B647E0", Offset = "0x6B633E0", VA = "0x186B647E0")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class BCMONIEILDG
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[BBPHNBKLBKA(0, 2)]
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
	[AOKGGDGMDNB]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		[LKOGHMJILOJ(1)]
		public EShapeType shapeType;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : HPBGIGMFLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6B6A240", Offset = "0x6B68E40", VA = "0x186B6A240", Slot = "4")]
		public sealed override void FFPJNMKMBJA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class PJFBAPELDIF : ContainerPropertyBag<IEHHBJNNNIL>
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class KPEAEGKLGJH : Property<IEHHBJNNNIL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6B679F0", Offset = "0x6B665F0", VA = "0x186B679F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6B679B0", Offset = "0x6B665B0", VA = "0x186B679B0")]
		public KPEAEGKLGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3196790", Offset = "0x3195390", VA = "0x183196790", Slot = "14")]
		public override Rigidbody GetValue(ref IEHHBJNNNIL JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x31967B0", Offset = "0x31953B0", VA = "0x1831967B0", Slot = "15")]
		public override void SetValue(ref IEHHBJNNNIL JMIFLNNGBHG, Rigidbody ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6B68EB0", Offset = "0x6B67AB0", VA = "0x186B68EB0")]
	public PJFBAPELDIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class CPICMCOICGC : ContainerPropertyBag<NEOAAOEPFPL>
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private class OMPFJOFCAFI : Property<NEOAAOEPFPL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6B688E0", Offset = "0x6B674E0", VA = "0x186B688E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6B688A0", Offset = "0x6B674A0", VA = "0x186B688A0")]
		public OMPFJOFCAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3196790", Offset = "0x3195390", VA = "0x183196790", Slot = "14")]
		public override object GetValue(ref NEOAAOEPFPL JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x31967B0", Offset = "0x31953B0", VA = "0x1831967B0", Slot = "15")]
		public override void SetValue(ref NEOAAOEPFPL JMIFLNNGBHG, object ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B65620", Offset = "0x6B64220", VA = "0x186B65620")]
	public CPICMCOICGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class PBOFJGOBPPA : ContainerPropertyBag<OIKNDGJJMDK>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	private class OINEGGANLJJ : Property<OIKNDGJJMDK, MKCCBALLBBE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6B68870", Offset = "0x6B67470", VA = "0x186B68870", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6B68830", Offset = "0x6B67430", VA = "0x186B68830")]
		public OINEGGANLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3196790", Offset = "0x3195390", VA = "0x183196790", Slot = "14")]
		public override MKCCBALLBBE GetValue(ref OIKNDGJJMDK JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x31967B0", Offset = "0x31953B0", VA = "0x1831967B0", Slot = "15")]
		public override void SetValue(ref OIKNDGJJMDK JMIFLNNGBHG, MKCCBALLBBE ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B68CA0", Offset = "0x6B678A0", VA = "0x186B68CA0")]
	public PBOFJGOBPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class BJNEPLJGFIJ : ContainerPropertyBag<IMGKECMJNPA>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class MHKJGHPGLJL : Property<IMGKECMJNPA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6B68050", Offset = "0x6B66C50", VA = "0x186B68050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6B68010", Offset = "0x6B66C10", VA = "0x186B68010")]
		public MHKJGHPGLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3196790", Offset = "0x3195390", VA = "0x183196790", Slot = "14")]
		public override object GetValue(ref IMGKECMJNPA JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x31967B0", Offset = "0x31953B0", VA = "0x1831967B0", Slot = "15")]
		public override void SetValue(ref IMGKECMJNPA JMIFLNNGBHG, object ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B64E30", Offset = "0x6B63A30", VA = "0x186B64E30")]
	public BJNEPLJGFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class MJBJCKPNMBK : ContainerPropertyBag<OIBICJNPGGF>
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private class JEICAENFPEK : Property<OIBICJNPGGF, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6B673E0", Offset = "0x6B65FE0", VA = "0x186B673E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B673A0", Offset = "0x6B65FA0", VA = "0x186B673A0")]
		public JEICAENFPEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB94170", Offset = "0xB92D70", VA = "0x180B94170", Slot = "14")]
		public override int GetValue(ref OIBICJNPGGF JMIFLNNGBHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6B67380", Offset = "0x6B65F80", VA = "0x186B67380", Slot = "15")]
		public override void SetValue(ref OIBICJNPGGF JMIFLNNGBHG, int ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class MGMIOPLKAFA : Property<OIBICJNPGGF, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6B67FE0", Offset = "0x6B66BE0", VA = "0x186B67FE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6B67FA0", Offset = "0x6B66BA0", VA = "0x186B67FA0")]
		public MGMIOPLKAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xB94200", Offset = "0xB92E00", VA = "0x180B94200", Slot = "14")]
		public override int GetValue(ref OIBICJNPGGF JMIFLNNGBHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6B67F80", Offset = "0x6B66B80", VA = "0x186B67F80", Slot = "15")]
		public override void SetValue(ref OIBICJNPGGF JMIFLNNGBHG, int ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class PGMCCNHBABE : Property<OIBICJNPGGF, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6B68E80", Offset = "0x6B67A80", VA = "0x186B68E80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B68E40", Offset = "0x6B67A40", VA = "0x186B68E40")]
		public PGMCCNHBABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B68DF0", Offset = "0x6B679F0", VA = "0x186B68DF0", Slot = "14")]
		public override GameObject GetValue(ref OIBICJNPGGF JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6B68E10", Offset = "0x6B67A10", VA = "0x186B68E10", Slot = "15")]
		public override void SetValue(ref OIBICJNPGGF JMIFLNNGBHG, GameObject ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B680E0", Offset = "0x6B66CE0", VA = "0x186B680E0")]
	public MJBJCKPNMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class BLDGOFKBNEM : ContainerPropertyBag<OMHIJEDIHLJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class PNGIFGFIBBG : Property<OMHIJEDIHLJ, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6B69010", Offset = "0x6B67C10", VA = "0x186B69010", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6B68FD0", Offset = "0x6B67BD0", VA = "0x186B68FD0")]
		public PNGIFGFIBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6B68F80", Offset = "0x6B67B80", VA = "0x186B68F80", Slot = "14")]
		public override SerializableGuid GetValue(ref OMHIJEDIHLJ JMIFLNNGBHG)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6B68FB0", Offset = "0x6B67BB0", VA = "0x186B68FB0", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ JMIFLNNGBHG, SerializableGuid ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private class NDPJPOOMBLE : Property<OMHIJEDIHLJ, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6B68600", Offset = "0x6B67200", VA = "0x186B68600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B685C0", Offset = "0x6B671C0", VA = "0x186B685C0")]
		public NDPJPOOMBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B68570", Offset = "0x6B67170", VA = "0x186B68570", Slot = "14")]
		public override List<int> GetValue(ref OMHIJEDIHLJ JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6B68590", Offset = "0x6B67190", VA = "0x186B68590", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ JMIFLNNGBHG, List<int> ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private class CGODFKEIACK : Property<OMHIJEDIHLJ, List<OMHIJEDIHLJ.PBGKCMCKGMO>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6B65440", Offset = "0x6B64040", VA = "0x186B65440", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6B65400", Offset = "0x6B64000", VA = "0x186B65400")]
		public CGODFKEIACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6B653B0", Offset = "0x6B63FB0", VA = "0x186B653B0", Slot = "14")]
		public override List<OMHIJEDIHLJ.PBGKCMCKGMO> GetValue(ref OMHIJEDIHLJ JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6B653D0", Offset = "0x6B63FD0", VA = "0x186B653D0", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ JMIFLNNGBHG, List<OMHIJEDIHLJ.PBGKCMCKGMO> ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class GNDAOBBACJC : Property<OMHIJEDIHLJ, List<OMHIJEDIHLJ.PIGMPEFEGIK>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6B668F0", Offset = "0x6B654F0", VA = "0x186B668F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6B668B0", Offset = "0x6B654B0", VA = "0x186B668B0")]
		public GNDAOBBACJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6B66860", Offset = "0x6B65460", VA = "0x186B66860", Slot = "14")]
		public override List<OMHIJEDIHLJ.PIGMPEFEGIK> GetValue(ref OMHIJEDIHLJ JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6B66880", Offset = "0x6B65480", VA = "0x186B66880", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ JMIFLNNGBHG, List<OMHIJEDIHLJ.PIGMPEFEGIK> ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class LHNPLFAEGKM : Property<OMHIJEDIHLJ, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6B67BD0", Offset = "0x6B667D0", VA = "0x186B67BD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6B67B90", Offset = "0x6B66790", VA = "0x186B67B90")]
		public LHNPLFAEGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6B67B40", Offset = "0x6B66740", VA = "0x186B67B40", Slot = "14")]
		public override GameObject GetValue(ref OMHIJEDIHLJ JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6B67B60", Offset = "0x6B66760", VA = "0x186B67B60", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ JMIFLNNGBHG, GameObject ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class OPHIJMPCOMN : Property<OMHIJEDIHLJ, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6B68A10", Offset = "0x6B67610", VA = "0x186B68A10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B689D0", Offset = "0x6B675D0", VA = "0x186B689D0")]
		public OPHIJMPCOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6B68980", Offset = "0x6B67580", VA = "0x186B68980", Slot = "14")]
		public override Light GetValue(ref OMHIJEDIHLJ JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B689A0", Offset = "0x6B675A0", VA = "0x186B689A0", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ JMIFLNNGBHG, Light ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	private class BJENLKMOOMA : Property<OMHIJEDIHLJ, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6B64E00", Offset = "0x6B63A00", VA = "0x186B64E00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B64DC0", Offset = "0x6B639C0", VA = "0x186B64DC0")]
		public BJENLKMOOMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B64D70", Offset = "0x6B63970", VA = "0x186B64D70", Slot = "14")]
		public override Collider GetValue(ref OMHIJEDIHLJ JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B64D90", Offset = "0x6B63990", VA = "0x186B64D90", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ JMIFLNNGBHG, Collider ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class KGPIIODOPOC : Property<OMHIJEDIHLJ, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6B677D0", Offset = "0x6B663D0", VA = "0x186B677D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B67790", Offset = "0x6B66390", VA = "0x186B67790")]
		public KGPIIODOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6B67740", Offset = "0x6B66340", VA = "0x186B67740", Slot = "14")]
		public override string GetValue(ref OMHIJEDIHLJ JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B67760", Offset = "0x6B66360", VA = "0x186B67760", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ JMIFLNNGBHG, string ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6B64F00", Offset = "0x6B63B00", VA = "0x186B64F00")]
	public BLDGOFKBNEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class HLKMAJCNIDP : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class GIBMPGHEHKB : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6B66830", Offset = "0x6B65430", VA = "0x186B66830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6B66740", Offset = "0x6B65340", VA = "0x186B66740")]
		public GIBMPGHEHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2553460", Offset = "0x2552060", VA = "0x182553460", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid JMIFLNNGBHG)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x66408E0", Offset = "0x663F4E0", VA = "0x1866408E0", Slot = "15")]
		public override void SetValue(ref SerializableGuid JMIFLNNGBHG, Data128 ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B66AC0", Offset = "0x6B656C0", VA = "0x186B66AC0")]
	public HLKMAJCNIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class EJHNOPKFOJK : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class OHKINNFFBFP : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x6B68790", Offset = "0x6B67390", VA = "0x186B68790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B686A0", Offset = "0x6B672A0", VA = "0x186B686A0")]
		public OHKINNFFBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x17DFA00", Offset = "0x17DE600", VA = "0x1817DFA00", Slot = "14")]
		public override int GetValue(ref Data128 JMIFLNNGBHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xBA61D0", Offset = "0xBA4DD0", VA = "0x180BA61D0", Slot = "15")]
		public override void SetValue(ref Data128 JMIFLNNGBHG, int ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	private class FCDJLPIPNOF : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6B663C0", Offset = "0x6B64FC0", VA = "0x186B663C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B662D0", Offset = "0x6B64ED0", VA = "0x186B662D0")]
		public FCDJLPIPNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6642C20", Offset = "0x6641820", VA = "0x186642C20", Slot = "14")]
		public override int GetValue(ref Data128 JMIFLNNGBHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xBA63D0", Offset = "0xBA4FD0", VA = "0x180BA63D0", Slot = "15")]
		public override void SetValue(ref Data128 JMIFLNNGBHG, int ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class LFELFOBEHEI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6B67B10", Offset = "0x6B66710", VA = "0x186B67B10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6B67A20", Offset = "0x6B66620", VA = "0x186B67A20")]
		public LFELFOBEHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2557B60", Offset = "0x2556760", VA = "0x182557B60", Slot = "14")]
		public override int GetValue(ref Data128 JMIFLNNGBHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6649180", Offset = "0x6647D80", VA = "0x186649180", Slot = "15")]
		public override void SetValue(ref Data128 JMIFLNNGBHG, int ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class MAJAGLAJMIC : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6B67ED0", Offset = "0x6B66AD0", VA = "0x186B67ED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6B67DE0", Offset = "0x6B669E0", VA = "0x186B67DE0")]
		public MAJAGLAJMIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6649010", Offset = "0x6647C10", VA = "0x186649010", Slot = "14")]
		public override int GetValue(ref Data128 JMIFLNNGBHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6649020", Offset = "0x6647C20", VA = "0x186649020", Slot = "15")]
		public override void SetValue(ref Data128 JMIFLNNGBHG, int ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B65C50", Offset = "0x6B64850", VA = "0x186B65C50")]
	public EJHNOPKFOJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class DFIAALKGOFC : ContainerPropertyBag<OMHIJEDIHLJ.PBGKCMCKGMO>
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class JMEFCDHMHKB : Property<OMHIJEDIHLJ.PBGKCMCKGMO, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6B674D0", Offset = "0x6B660D0", VA = "0x186B674D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6B67490", Offset = "0x6B66090", VA = "0x186B67490")]
		public JMEFCDHMHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x150B240", Offset = "0x1509E40", VA = "0x18150B240", Slot = "14")]
		public override Vector3 GetValue(ref OMHIJEDIHLJ.PBGKCMCKGMO JMIFLNNGBHG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6B67470", Offset = "0x6B66070", VA = "0x186B67470", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ.PBGKCMCKGMO JMIFLNNGBHG, Vector3 ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class KLDOOJCDMKP : Property<OMHIJEDIHLJ.PBGKCMCKGMO, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6B67860", Offset = "0x6B66460", VA = "0x186B67860", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6B67820", Offset = "0x6B66420", VA = "0x186B67820")]
		public KLDOOJCDMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6B67800", Offset = "0x6B66400", VA = "0x186B67800", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref OMHIJEDIHLJ.PBGKCMCKGMO JMIFLNNGBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6B67810", Offset = "0x6B66410", VA = "0x186B67810", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ.PBGKCMCKGMO JMIFLNNGBHG, List<SerializableGuid> ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6B65AF0", Offset = "0x6B646F0", VA = "0x186B65AF0")]
	public DFIAALKGOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class BGAADHHMHNK : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class MDMHIFMBADA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6B67F50", Offset = "0x6B66B50", VA = "0x186B67F50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6B67F10", Offset = "0x6B66B10", VA = "0x186B67F10")]
		public MDMHIFMBADA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A873A0", Offset = "0x6A85FA0", VA = "0x186A873A0", Slot = "14")]
		public override float GetValue(ref Vector3 JMIFLNNGBHG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6B67F00", Offset = "0x6B66B00", VA = "0x186B67F00", Slot = "15")]
		public override void SetValue(ref Vector3 JMIFLNNGBHG, float ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class GGPGCGDKAIJ : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x6B66710", Offset = "0x6B65310", VA = "0x186B66710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6B666D0", Offset = "0x6B652D0", VA = "0x186B666D0")]
		public GGPGCGDKAIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A87B50", Offset = "0x6A86750", VA = "0x186A87B50", Slot = "14")]
		public override float GetValue(ref Vector3 JMIFLNNGBHG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6B666C0", Offset = "0x6B652C0", VA = "0x186B666C0", Slot = "15")]
		public override void SetValue(ref Vector3 JMIFLNNGBHG, float ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class PENDIBGIOBG : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6B68DC0", Offset = "0x6B679C0", VA = "0x186B68DC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6B68D80", Offset = "0x6B67980", VA = "0x186B68D80")]
		public PENDIBGIOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x15DF8B0", Offset = "0x15DE4B0", VA = "0x1815DF8B0", Slot = "14")]
		public override float GetValue(ref Vector3 JMIFLNNGBHG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6B68D70", Offset = "0x6B67970", VA = "0x186B68D70", Slot = "15")]
		public override void SetValue(ref Vector3 JMIFLNNGBHG, float ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6B64880", Offset = "0x6B63480", VA = "0x186B64880")]
	public BGAADHHMHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal class HFMJJFDDFHC : ContainerPropertyBag<OMHIJEDIHLJ.PIGMPEFEGIK>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class KAHAPOALEPO : Property<OMHIJEDIHLJ.PIGMPEFEGIK, OMHIJEDIHLJ.PBGKCMCKGMO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6B67580", Offset = "0x6B66180", VA = "0x186B67580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6B67540", Offset = "0x6B66140", VA = "0x186B67540")]
		public KAHAPOALEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x663F770", Offset = "0x663E370", VA = "0x18663F770", Slot = "14")]
		public override OMHIJEDIHLJ.PBGKCMCKGMO GetValue(ref OMHIJEDIHLJ.PIGMPEFEGIK JMIFLNNGBHG)
		{
			return default(OMHIJEDIHLJ.PBGKCMCKGMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6B67500", Offset = "0x6B66100", VA = "0x186B67500", Slot = "15")]
		public override void SetValue(ref OMHIJEDIHLJ.PIGMPEFEGIK JMIFLNNGBHG, OMHIJEDIHLJ.PBGKCMCKGMO ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B66920", Offset = "0x6B65520", VA = "0x186B66920")]
	public HFMJJFDDFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal class CELPIAGDMDJ : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class JAGIDFJDCHI : Property<RRObjectPrefabV2Data, ObjectPrefabType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string EKPDCEFJBCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6B67350", Offset = "0x6B65F50", VA = "0x186B67350", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool JKOPFKMGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6B67310", Offset = "0x6B65F10", VA = "0x186B67310")]
		public JAGIDFJDCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x17DFA00", Offset = "0x17DE600", VA = "0x1817DFA00", Slot = "14")]
		public override ObjectPrefabType GetValue(ref RRObjectPrefabV2Data JMIFLNNGBHG)
		{
			return default(ObjectPrefabType);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xBA61D0", Offset = "0xBA4DD0", VA = "0x180BA61D0", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data JMIFLNNGBHG, ObjectPrefabType ECNGHFJBIJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B652E0", Offset = "0x6B63EE0", VA = "0x186B652E0")]
	public CELPIAGDMDJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6B690A0", Offset = "0x6B67CA0", VA = "0x186B690A0")]
		[RuntimeInitializeOnLoadMethod]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
